using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web.Mvc;
using EnrollmentWorkflow.Domain;
using EnrollmentWorkflow.EventService;
using EnrollmentWorkflow.Helpers;
using EnrollmentWorkflow.MadaketIntegration;
using EnrollmentWorkflow.Models;
using EnrollmentWorkflow.PayerManager;
using EnrollmentWorkflow.PracticeManager;
using EnrollmentWorkflow.ProviderManager;
using EnrollmentWorkflow.WorkItemManager;
using GatewayEDI.Logging;
using Newtonsoft.Json;


namespace EnrollmentWorkflow.Controllers
{
    public class WorkItemController : Controller
    {
        private static readonly ILog Log = LogManager.GetLog(typeof(WorkItemController));

        private readonly PracticeManagerClient practiceManager = new PracticeManagerClient();
        private readonly PayerManagerClient payerManager = new PayerManagerClient();
        private readonly ProviderManagerClient providerManager = new ProviderManagerClient();
        private readonly WorkItemServiceClient workItemManager = new WorkItemServiceClient();
        private readonly EventServiceClient eventManager = new EventServiceClient();

        public WorkItemController()
        {
            LoadSpecialtiesInViewBag();
        }

        private String GetUserPrincipalName(IPrincipal principal)
        {
            try
            {
                var context = new PrincipalContext(ContextType.Domain);
                var userPrincipal = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName,
                    principal.Identity.Name);

                if (userPrincipal == null)
                    return String.Empty;

                return userPrincipal.SamAccountName;
            }
            catch (NoMatchingPrincipalException)
            {
                return String.Empty;
            }
        }

        public ActionResult Index(int workItemId)
        {
            LoadGroupMembersInViewBag();
            ViewBag.User = GetUserPrincipalName(User).ToLower();

            WorkItem serviceWorkItem = workItemManager.GetWorkItem(workItemId);

            WorkItemModel workItem = WorkItemMapper.Map(serviceWorkItem, true);

            EnrollmentDetailsModel enrollmentDetails = BuildEnrollmentDetails(workItem.SiteId);

            workItem.EnrollmentDetails = enrollmentDetails;

            return View(workItem);
        }

        [HttpPost]
        public ActionResult UpdateGeneralInformation(int workItemId, string status, string ecwProjectManager, string ecwGroup, string enrollmentRep, string testingRep)
        {
            var currentServiceWorkItem = workItemManager.GetWorkItem(workItemId);

            var currentUser = GetUserPrincipalName(User).ToLower();

            currentServiceWorkItem.WorkItemStatus = (WorkItemStatus)Enum.Parse(typeof(WorkItemStatus), status.Replace(" ", String.Empty), true);
            currentServiceWorkItem.EcwProjectManager = ecwProjectManager;
            currentServiceWorkItem.EcwGroup = ecwGroup;
            currentServiceWorkItem.EnrollmentRep = enrollmentRep;
            currentServiceWorkItem.TestingRep = testingRep;

            workItemManager.UpdateWorkItem(currentServiceWorkItem, currentUser);

            WorkItem serviceWorkItem = workItemManager.GetWorkItem(workItemId);

            WorkItemModel workItem = WorkItemMapper.Map(serviceWorkItem);

            EnrollmentDetailsModel enrollmentDetails = BuildEnrollmentDetails(workItem.SiteId);

            workItem.EnrollmentDetails = enrollmentDetails;

            LoadGroupMembersInViewBag();

            return View("Index", workItem);
        }

        [HttpPost]
        public ActionResult UpdateAdditionalInformation(int workItemId, string notes)
        {
            var currentServiceWorkItem = workItemManager.GetWorkItem(workItemId);

            var currentUser = GetUserPrincipalName(User).ToLower();

            currentServiceWorkItem.Notes = notes;

            workItemManager.UpdateWorkItem(currentServiceWorkItem, currentUser);

            WorkItem serviceWorkItem = workItemManager.GetWorkItem(workItemId);

            WorkItemModel workItem = WorkItemMapper.Map(serviceWorkItem);

            EnrollmentDetailsModel enrollmentDetails = BuildEnrollmentDetails(workItem.SiteId);

            workItem.EnrollmentDetails = enrollmentDetails;

            LoadGroupMembersInViewBag();

            return View("Index", workItem);
        }

        [HttpPost]
        public ActionResult UpdateDateInformation(int workItemId, DateTime? ContractDate, DateTime? GoLiveDate, DateTime? lastContacted, DateTime? kickOffCallDate, DateTime? reinstateDate, DateTime? clientSubmissionDate, DateTime? enrollmentSentToThirdParty, DateTime? tafReceivedDate, DateTime? paperworkReceived, DateTime? paperworkSentToPayer, DateTime? introDate, DateTime? installDate, DateTime? testingDate1, DateTime? productionDate, DateTime? siteAnalysisDue, DateTime? movedOutOfImplementation)
        {

            var currentServiceWorkItem = workItemManager.GetWorkItem(workItemId);
            var currentUser = GetUserPrincipalName(User).ToLower();

            string SiteId = currentServiceWorkItem.SiteId;

            currentServiceWorkItem.LastContactedDate = lastContacted;
            currentServiceWorkItem.KickOffCallDate = kickOffCallDate;
            currentServiceWorkItem.ReinstatedDate = reinstateDate;
            currentServiceWorkItem.ClientSubmissionDate = clientSubmissionDate;
            currentServiceWorkItem.EnrollmentSentDate = enrollmentSentToThirdParty;
            currentServiceWorkItem.TAFReceivedDate = tafReceivedDate;
            currentServiceWorkItem.PaperworkReceivedDate = paperworkReceived;
            currentServiceWorkItem.PaperworkSentDate = paperworkSentToPayer;
            currentServiceWorkItem.InstallDate = installDate;
            currentServiceWorkItem.IntroDate = introDate;
            currentServiceWorkItem.TestingDate1 = testingDate1;
            currentServiceWorkItem.ProductionDate = productionDate;
            currentServiceWorkItem.SiteAnalysisDue = siteAnalysisDue;
            currentServiceWorkItem.MovedOutOfImplementation = movedOutOfImplementation;
            currentServiceWorkItem.ContractDate = ContractDate;

            DateTime? naComplete = workItemManager.GetNaCompleteDate(SiteId);
            if (!naComplete.HasValue || naComplete.HasValue == null)
            {

                currentServiceWorkItem.GoLiveDate = GoLiveDate;
            }

            workItemManager.UpdateWorkItem(currentServiceWorkItem, currentUser);

            WorkItem serviceWorkItem = workItemManager.GetWorkItem(workItemId);

            WorkItemModel workItem = WorkItemMapper.Map(serviceWorkItem, true);

            EnrollmentDetailsModel enrollmentDetails = BuildEnrollmentDetails(workItem.SiteId);

            workItem.EnrollmentDetails = enrollmentDetails;

            LoadGroupMembersInViewBag();

            return PartialView("_DateInfo", workItem);
        }

        [HttpPost]
        public ActionResult UpdatePracticeInformation(string siteId, PracticeDetailsViewModel practiceDetails)
        {
            var domainUsers = new DomainUsers();
            string user = domainUsers.GetCurrentUser(User).ToLower();
            if (practiceDetails.PracticeInfo != null)
            {
                var practiceNotes = new PracticeNotes();
                practiceNotes.PracticeId = practiceDetails.PracticeInfo.PracticeId;
                practiceNotes.Address1 = practiceDetails.PracticeInfo.NoteAddress1;
                practiceNotes.Address2 = practiceDetails.PracticeInfo.NoteAddress2;
                practiceNotes.BillingNpi = practiceDetails.PracticeInfo.NoteBillingNpi;
                practiceNotes.City = practiceDetails.PracticeInfo.NoteCity;
                practiceNotes.DoingBusinessAs = practiceDetails.PracticeInfo.NoteDoingBusinessAs;
                practiceNotes.GoLiveDate = practiceDetails.PracticeInfo.NoteGoLiveDate;
                practiceNotes.Name = practiceDetails.PracticeInfo.NotePracticeName;
                practiceNotes.State = practiceDetails.PracticeInfo.NoteState;
                practiceNotes.TaxIdOrSsn = practiceDetails.PracticeInfo.NoteTaxIdOrSsn;
                practiceNotes.Zip = practiceDetails.PracticeInfo.NoteZip;

                var practiceInfo = new Practice();
                practiceInfo.Address1 = practiceDetails.PracticeInfo.Address1;
                practiceInfo.Address2 = practiceDetails.PracticeInfo.Address2;
                practiceInfo.BillingNpi = practiceDetails.PracticeInfo.BillingNpi;
                practiceInfo.City = practiceDetails.PracticeInfo.City;
                practiceInfo.DoingBusinessAs = practiceDetails.PracticeInfo.DoingBusinessAs;
                practiceInfo.GoLiveDate = practiceDetails.PracticeInfo.GoLiveDate;
                practiceInfo.GoLiveSoonAsPossible = practiceDetails.PracticeInfo.GoLiveSoonAsPossible;
                practiceInfo.Id = practiceDetails.PracticeInfo.PracticeId;
                practiceInfo.Name = practiceDetails.PracticeInfo.PracticeName;
                practiceInfo.SharedTaxIdSsn = practiceDetails.PracticeInfo.SharedTaxIdSsn;
                practiceInfo.State = practiceDetails.PracticeInfo.State;
                practiceInfo.TaxIdOrSsn = practiceDetails.PracticeInfo.TaxIdOrSsn;
                practiceInfo.Zip = practiceDetails.PracticeInfo.Zip;

                practiceManager.AddPracticeNotes(practiceNotes);

                string metadata = JsonConvert.SerializeObject(practiceNotes, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

                var webUserId = eventManager.GetWebUserId(siteId);

                eventManager.Add(webUserId, true, EventCode.NoteAdded, metadata);

                practiceManager.UpdatePractice(siteId, practiceInfo, user);

            }

            if (practiceDetails.ProviderInfo != null)
            {
                foreach (var provider in practiceDetails.ProviderInfo)
                {
                    var providerNotes = new ProviderNotes();
                    providerNotes.Id = provider.Id;
                    providerNotes.IndividualRenderingNpi = provider.NoteIndividualRenderingNpi;
                    providerNotes.FirstName = provider.NoteFirstName;
                    providerNotes.LastName = provider.NoteLastName;
                    providerNotes.MiddleInitial = provider.NoteMiddleInitial;
                    providerNotes.Specialty = provider.NoteSpecialty;
                    providerNotes.TaxIdOrSsn = provider.NoteTaxIdOrSsn;
                    providerNotes.Title = provider.NoteProviderTitle;

                    var providerInfo = new Provider();
                    providerInfo.Id = provider.Id;
                    providerInfo.IndividualRenderingNpi = provider.IndividualRenderingNpi;
                    providerInfo.FirstName = provider.FirstName;
                    providerInfo.LastName = provider.LastName;
                    providerInfo.MiddleInitial = provider.MiddleInitial;
                    providerInfo.Specialty = provider.Specialty;
                    providerInfo.TaxIdOrSsn = provider.TaxIdOrSsn;
                    providerInfo.Title = provider.ProviderTitle;

                    providerManager.AddProviderNotes(providerNotes);

                    string metadata = JsonConvert.SerializeObject(providerNotes, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

                    var webUserId = eventManager.GetWebUserId(siteId);

                    eventManager.Add(webUserId, true, EventCode.NoteAdded, metadata);

                    var practiceIds = providerManager.GetProviderPracticeInfoForProviderId(provider.Id);

                    providerManager.UpdateProvider(siteId, providerInfo, practiceIds, user);
                }
            }

            if (practiceDetails.PayerInfo != null)
            {
                var originalPayerInfo = payerManager.GetPracticePayerDetailForPracticeId(practiceDetails.PracticeInfo.PracticeId);

                foreach (var payerInfo in practiceDetails.PayerInfo)
                {
                    var payerNotes = new PayerNotes()
                    {
                        PracticeId = practiceDetails.PracticeInfo.PracticeId
                        ,
                        PayerListId = payerInfo.Id
                        ,
                        ProviderId = payerInfo.NoteProviderId
                    };

                    var payerDetail = originalPayerInfo.FirstOrDefault(x => x.Id == payerInfo.Id && !String.IsNullOrWhiteSpace(x.ProviderId));

                    if (payerDetail != null)
                    {
                        payerDetail.ProviderId = payerInfo.ProviderId;

                        payerManager.AddPayerNotes(payerNotes);

                        string metadata = JsonConvert.SerializeObject(payerNotes, Formatting.None, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });

                        var webUserId = eventManager.GetWebUserId(siteId);

                        eventManager.Add(webUserId, true, EventCode.NoteAdded, metadata);

                        PracticePayerDetail[] details = new PracticePayerDetail[1];

                        details[0] = payerDetail;

                        payerManager.AddPracticePayerDetail(user, siteId, practiceDetails.PracticeInfo.PracticeId, details);
                    }
                }
            }

            LoadGroupMembersInViewBag();

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public JsonResult AssignWorkItemToEnrollmentRep(int workItemId, string enrollmentRep)
        {
            var currentUser = GetUserPrincipalName(User).ToLower();

            if (workItemId < 1)
                return Json(new
                {
                    success = false
                });

            if (enrollmentRep == null)
                return Json(new
                {
                    success = false
                });

            return Json(new
            {
                success = workItemManager.AssignWorkItemToEnrollmentRep(workItemId, enrollmentRep, currentUser)
            });
        }

        public JsonResult AssignWorkItemToTestingRep(int workItemId, string testingRep)
        {
            var currentUser = GetUserPrincipalName(User).ToLower();

            if (workItemId < 1)
                return Json(new
                {
                    success = false
                });

            if (testingRep == null)
                return Json(new
                {
                    success = false
                });

            return Json(new
            {
                success = workItemManager.AssignWorkItemToTestingRep(workItemId, testingRep, currentUser)
            });
        }

        private EnrollmentDetailsModel BuildEnrollmentDetails(string siteId)
        {
            IList<PayerModel> payerList = new List<PayerModel>();

            var payers = payerManager.GetPayerListData("H", String.Empty, String.Empty, 0, 0)
                .Union(payerManager.GetPayerListData("U", String.Empty, String.Empty, 0, 0))
                .Union(payerManager.GetPayerListData("D", String.Empty, String.Empty, 0, 0));

            foreach (var payer in payers.Distinct())
            {
                var payerModel = new PayerModel();

                switch (payer.ClaimType)
                {
                    case "H":
                        payerModel.ClaimType = "professional";
                        break;

                    case "U":
                        payerModel.ClaimType = "institutional";
                        break;
                    case "D":
                        payerModel.ClaimType = "dental";
                        break;
                    default:
                        payerModel.ClaimType = "professional";
                        break;
                }

                payerModel.ContactName = payer.ContactName;
                payerModel.ContactPhoneNumber = payer.ContactPhoneNumber;
                payerModel.Id = payer.Id;
                payerModel.Name = payer.Name;
                payerModel.ServiceStates = payer.ServiceStates;
                payerModel.PayerId = payer.PayerId;
                payerModel.OffersRemits = payer.OffersRemits;

                payerList.Add(payerModel);
            }

            var payerListCombined = payerList
                .Where(x => x.ClaimType == "institutional" || x.ClaimType == "professional" || x.ClaimType == "dental")
                .OrderBy(x => x.Name)
                .ToList();


            EnrollmentDetailsModel enrollmentDetails = new EnrollmentDetailsModel();
            enrollmentDetails.PracticeDetails = new List<PracticeDetailsViewModel>();

            // Retrieving practices for the siteId 
            Practice[] practices = practiceManager.GetPractices(siteId);

            var practiceList = practices.Select(x => x.Id).ToArray();
            var practicePayerDetails = payerManager.GetPracticePayerDetailForPracticeIdList(practiceList);

            // Retrieving the providers
            Provider[] providers = providerManager.GetProviders(siteId);

            // Retrieving the speciality list 
            var specialties = providerManager.GetSpecialtyList();

            foreach (var practice in practices)
            {
                var practiceDetails = new PracticeDetailsViewModel();
                var practiceModel = new PracticeModel();
                practiceModel.PracticeId = practice.Id;
                practiceModel.PracticeName = practice.Name;
                practiceModel.GoLiveSoonAsPossible = practice.GoLiveSoonAsPossible;
                practiceModel.GoLiveDate = (practice.GoLiveDate != null) ? practice.GoLiveDate.Value : practice.GoLiveDate;
                practiceModel.TaxIdOrSsn = practice.TaxIdOrSsn;
                practiceModel.SharedTaxIdSsn = practice.SharedTaxIdSsn;
                practiceModel.BillingNpi = practice.BillingNpi;
                practiceModel.DoingBusinessAs = practice.DoingBusinessAs;
                practiceModel.Address1 = practice.Address1;
                practiceModel.Address2 = practice.Address2;
                practiceModel.City = practice.City;
                practiceModel.State = practice.State;
                practiceModel.Zip = practice.Zip;

                practiceModel.NoteAddress1 = practice.NoteAddress1;
                practiceModel.NoteAddress2 = practice.NoteAddress2;
                practiceModel.NoteBillingNpi = practice.NoteBillingNpi;
                practiceModel.NoteCity = practice.NoteCity;
                practiceModel.NoteDoingBusinessAs = practice.NoteDoingBusinessAs;
                practiceModel.NoteGoLiveDate = practice.NoteGoLiveDate;
                practiceModel.NotePracticeName = practice.NoteName;
                practiceModel.NoteState = practice.NoteState;
                practiceModel.NoteTaxIdOrSsn = practice.NoteTaxIdOrSsn;
                practiceModel.NoteZip = practice.NoteZip;

                practiceDetails.PracticeInfo = practiceModel;

                var practicePayerDetailModelList = new List<PracticePayerDetailModel>();

                if (practicePayerDetails != null)
                {
                    foreach (var payer in payerListCombined.Where(x => practicePayerDetails.Any(y => y.Id == x.Id)))
                    {
                        var detail = practicePayerDetails.FirstOrDefault(x => x.Id == payer.Id && x.PracticeId == practice.Id);

                        if (detail != null)
                        {
                            var practiceDetail = new PracticePayerDetailModel
                            {
                                Id = detail.Id,
                                Name = payer.Name,
                                Claims = detail.Claims,
                                Remits = detail.Remits,
                                ProviderId = detail.ProviderId,
                                Message = detail.Message,
                                OnHold = detail.OnHold,
                                PayerId = payer.PayerId,
                                NoteProviderId = detail.NoteProviderId,
                            };

                            practicePayerDetailModelList.Add(practiceDetail);
                        }
                    }
                }

                practiceDetails.PayerInfo = practicePayerDetailModelList;

                IList<long> providerIds = practiceManager.GetPracticeProviderInfoForPracticeId(practice.Id);

                var practiceProviders = new List<ProviderModel>();

                foreach (var provider in providers.Where(x => providerIds.Contains(x.Id)))
                {
                    var providerModel = new ProviderModel();

                    providerModel.Id = provider.Id;
                    providerModel.FirstName = provider.FirstName;
                    providerModel.MiddleInitial = provider.MiddleInitial;
                    providerModel.LastName = provider.LastName;
                    providerModel.TaxIdOrSsn = provider.TaxIdOrSsn;
                    providerModel.ProviderTitle = provider.Title;
                    providerModel.IndividualRenderingNpi = provider.IndividualRenderingNpi;

                    providerModel.NoteFirstName = provider.NoteFirstName;
                    providerModel.NoteIndividualRenderingNpi = provider.NoteIndividualRenderingNpi;
                    providerModel.NoteLastName = provider.NoteLastName;
                    providerModel.NoteMiddleInitial = provider.NoteMiddleInitial;
                    providerModel.NoteProviderTitle = provider.NoteTitle;
                    providerModel.NoteSpecialty = provider.NoteSpecialty;
                    providerModel.NoteTaxIdOrSsn = provider.NoteTaxIdOrSsn;

                    var specialty = specialties.FirstOrDefault(x => x.Id.Equals(provider.Specialty, StringComparison.OrdinalIgnoreCase));

                    if (specialty == null)
                        providerModel.Specialty = provider.Specialty;
                    else
                        providerModel.Specialty = specialty.Id;

                    practiceProviders.Add(providerModel);

                }

                practiceDetails.ProviderInfo = practiceProviders;

                enrollmentDetails.PracticeDetails.Add(practiceDetails);
            }
            
            enrollmentDetails.SiteId = siteId;

            return enrollmentDetails;
        }

        private void LoadGroupMembersInViewBag()
        {
            IDictionary<string, string> groupMembers = new DomainUsers().GetGroupMembers();

            var selectList = new List<SelectListItem>();

            selectList.Add(new SelectListItem
            {
                Text = "Unassigned",
                Value = String.Empty
            });


            foreach (var groupMember in groupMembers)
            {
                selectList.Add(new SelectListItem
                {
                    Text = groupMember.Value,
                    Value = groupMember.Key.ToLower()
                });
            }

            ViewBag.GroupMembers = selectList;
        }

        [HttpPost]
        public ActionResult SendWelcomeEmail(string siteId)
        {
            var siteCreatedEvent = WcfClient<EventServiceClient>
                .Instantiate(() => new EventServiceClient())
                .Return(x => x.GetMetaData(siteId, EventCode.SiteCreated).FirstOrDefault());

            if (siteCreatedEvent != null)
            {
                if (!String.IsNullOrWhiteSpace(siteCreatedEvent.MetaData))
                {
                    SiteCreatedEvent siteCreatedData = JsonConvert.DeserializeObject<SiteCreatedEvent>(siteCreatedEvent.MetaData);

                    if (!String.IsNullOrWhiteSpace(siteCreatedData.Email) || !String.IsNullOrWhiteSpace(siteCreatedData.OfficeName))
                    {
                        WcfClient<WorkItemServiceClient>
                            .Instantiate(() => new WorkItemServiceClient())
                            .Use(x => x.SendWelcomeEmail(siteId, siteCreatedData.OfficeName, siteCreatedData.Email, siteCreatedData.VendorNumber));

                        Log.Info("Welcome email sent to {0} at {1} for site {2}.", siteCreatedData.Email, siteCreatedData.OfficeName, siteId);
                    }
                }
            }

            return Json(
                        new
                        {
                            lastSent = WcfClient<EventServiceClient>
                                           .Instantiate(() => new EventServiceClient())
                                           .Return(x => x.GetLastOccurrence(siteId, EventCode.WelcomeEmailSent).ToString())
                        });
        }

        [HttpPost]
        public ActionResult Approve(string siteId)
        {
            try
            {
                DateTime? submissionDate = WcfClient<EventServiceClient>
                    .Instantiate(() => new EventServiceClient())
                    .Return(x => x.GetLastOccurrence(siteId, EventCode.SubmissionApproved));

                RequestType requestType = submissionDate.HasValue ? RequestType.CHANGE : RequestType.ADD;

                Dictionary<long, MedicalGroupEnrollmentResponse> responses = WcfClient<MadaketClientClient>
                    .Instantiate(() => new MadaketClientClient())
                    .Return(x => x.EnrollAllMedicalGroups(siteId, requestType));

                Log.Info("Site {0} received {1} responses after enrollment.", siteId, responses.Count);

                string currentUser = new DomainUsers().GetCurrentUser(User);

                if (responses.Count > 0 && responses.Any(x => x.Value.error != null) && responses.Any(x => x.Value.error.httpReturnCode == "400"))
                {
                    string returnMessage =
                        responses.FirstOrDefault(x => x.Value.error.httpReturnCode == "400").Value.error.message;
                    return Json(
                    new
                    {
                        message = returnMessage
                    });
                }

                WcfClient<EventServiceClient>
                    .Instantiate(() => new EventServiceClient())
                    .Use(x => x.AddForSite(siteId, true, EventCode.SubmissionApproved, String.Format("{{ User: \"{0}\" }}", currentUser)));

                Practice[] practices = practiceManager.GetPractices(siteId);

                DateTime earliestGoLive = practices.Select(x =>
                {
                    if (x.GoLiveSoonAsPossible || !x.GoLiveDate.HasValue)
                        return DateTime.Today;

                    return x.GoLiveDate.Value;
                }).Min();
            }
            catch (Exception ex)
            {
                Log.Error("Site {0} received error while approving submission. Exception: {1}",siteId,ex.ToString());

                return Json(
                new
                {
                    message = "Error sending to Madaket. Try again in 10 minutes."
                });
            }

            return Json(
            new
            {
                message = "Approved"
            });
        }

        private void LoadSpecialtiesInViewBag()
        {
            Specialty[] specialtyList = WcfClient<ProviderManagerClient>
                .Instantiate(() => new ProviderManagerClient())
                .Return(x => x.GetSpecialtyList());

            var selectList = new List<SelectListItem>();

            selectList.Add(new SelectListItem
            {
                Text = "",
                Value = "",
                Selected = true
            });

            foreach (var specialty in specialtyList)
            {

                selectList.Add(new SelectListItem
                {
                    Text = specialty.Name,
                    Value = specialty.Id,
                });
            }

            ViewBag.SpecialtyList = selectList;
        }

        public ActionResult CreateNewWorkItem(NewWorkItem newWorkItem)
        {
            var isSuccess = false;
            List<string> messageList = new List<string>();

            if (ModelState.IsValid)
            {
                try
                {
                    var inputSiteId = newWorkItem.SiteId.ToUpper();

                    var workItemData = new WorkItem
                    {
                        ContractDate = newWorkItem.ContractDate,
                        OfficeName = newWorkItem.OfficeName,
                        SiteId = inputSiteId,
                        VendorNumber = newWorkItem.Vendor,
                        EnrollmentRep = newWorkItem.EnrollmentRep,
                        InstallType = Convert.ToString(newWorkItem.InstallType),
                        EcwProjectManager = newWorkItem.ProjectManager,
                        EcwGroup = newWorkItem.EcwGroup,
                        DocCount = Convert.ToInt32(newWorkItem.DocType),
                        WorkItemStatus = WorkItemStatus.PendingInitialLogin
                    };

                    var workItemId = WcfClient<WorkItemServiceClient>
                            .Instantiate(() => new WorkItemServiceClient())
                            .Return(x => x.CreateWorkItemForProductSite(workItemData, GetUserPrincipalName(User).ToLower()));

                    if (workItemId > 0)
                    {
                        messageList.Add("WorkItem added successfully for " + inputSiteId);
                        isSuccess = true;
                    }
                    else
                    {
                        switch (workItemId)
                        {
                            case -1:
                                messageList.Add(string.Format("Provided SiteId {0} is invalid", inputSiteId));
                                isSuccess = false;
                                break;
                            case -2:
                                messageList.Add(string.Format("WorkItem for the provided siteid  {0} is already present", inputSiteId));
                                isSuccess = false;
                                break;
                            default:
                                messageList.Add("Unexpected error occurred while creating workitem.");
                                isSuccess = false;
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    messageList.Add("Unexpected error occurred while creating workitem.");
                    isSuccess = false;
                    Log.Error("Unexpected error occurred ", ex);
                }
            }
            else
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    { 
                        messageList.Add(error.ErrorMessage); 
                    }
                }

                isSuccess = false;
            }

            return Json(new { isSuccess = isSuccess, messageList = messageList });
        }

        public ActionResult LoadVendor()
        {
            try
            {
                var vendorList = WcfClient<WorkItemServiceClient>
                                    .Instantiate(() => new WorkItemServiceClient())
                                    .Return(x => x.GetVendors());

                var vendors = vendorList.Select(x => new SelectListItem() { Text = x.Value, Value = Convert.ToString(x.Key) });

                return Json(vendors, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }


        public async Task<ActionResult> UpdateWorkItem(long workItemid, bool isActive)
        {
            JsonResult result = null;
            try
            {
                await workItemManager.UpdateWorkItemStatusAsync(workItemid, isActive);
                result = Json(new { success = true });

            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }

            return result;
        }
    }
}
