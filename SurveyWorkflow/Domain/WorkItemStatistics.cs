using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EnrollmentWorkflow.Helpers;
using EnrollmentWorkflow.Models;
using EnrollmentWorkflow.WorkItemManager;
using GatewayEDI.Logging;

namespace EnrollmentWorkflow.Domain
{
    public class WorkItemStatistics
    {
        private SettingsManager settingsManager = new SettingsManager();
        private static readonly ILog Log = LogManager.GetLog(typeof(WorkItemStatistics));

        public IEnumerable<WorkItemModel> GetMissingGoLive(IEnumerable<WorkItem> workItemList = null)
        {
            int thresholdInEnrollment = settingsManager.MissingGoLiveEnrollment;
            int thresholdInTesting = settingsManager.MissingGoLiveTesting;
            workItemList = workItemList ?? this.GetAllWorkItems(true);

            return workItemList.Where(x =>
                    {
                        double daysTillGoLive = 0;
                        if (x.GoLiveDate != null)
                        {
                            daysTillGoLive = (x.GoLiveDate.Value - DateTime.Now).TotalDays;

                            if (daysTillGoLive <= 0)
                                daysTillGoLive = 0;

                            TimeSpan span = DateTime.Now - x.GoLiveDate.Value;
                            daysTillGoLive = Math.Abs(span.TotalDays);
                        }

                        return (x.GoLiveDate != null && ((daysTillGoLive <= thresholdInEnrollment && this.IsStillEnrolling(x.WorkItemStatus))
                            || (daysTillGoLive <= thresholdInTesting && x.WorkItemStatus != WorkItemStatus.Testing)));
                    }).Select(wi => WorkItemMapper.Map(wi));
        }

        public IEnumerable<WorkItemModel> GetPagedMissingGoLive(Tuple<int, int> pagingArguments, Tuple<string, string> sortingArguments = null)
        {
            var pageNumber = pagingArguments.Item1;
            var pageSize = pagingArguments.Item2;

            var recordsToBeSkipped = ((pageNumber - 1) * pageSize);
            var recordsToBeTaken = pageSize;

            int thresholdInEnrollment = settingsManager.MissingGoLiveEnrollment;
            int thresholdInTesting = settingsManager.MissingGoLiveTesting;
            var workItemList = this.GetAllWorkItems(true);

            var filteredModelList = workItemList
                                        .Where(x =>
                                                {
                                                    double daysTillGoLive = 0;
                                                    if (x.GoLiveDate != null)
                                                    {
                                                        daysTillGoLive = (x.GoLiveDate.Value - DateTime.Now).TotalDays;

                                                        if (daysTillGoLive <= 0)
                                                            daysTillGoLive = 0;

                                                        TimeSpan span = DateTime.Now - x.GoLiveDate.Value;
                                                        daysTillGoLive = Math.Abs(span.TotalDays);
                                                    }

                                                    return (x.GoLiveDate != null && ((daysTillGoLive <= thresholdInEnrollment && this.IsStillEnrolling(x.WorkItemStatus))
                                                        || (daysTillGoLive <= thresholdInTesting && x.WorkItemStatus != WorkItemStatus.Testing)));
                                                })
                                        .Select(wi => WorkItemMapper.Map(wi));

            if (sortingArguments != null)
            {
                var sortMember = sortingArguments.Item1;
                var sortDirection = sortingArguments.Item2;
                PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(WorkItemModel)).Find(sortMember, false);

                switch (sortDirection.ToUpper())
                {
                    case "ASCENDING":
                        filteredModelList = filteredModelList.OrderBy(x => prop.GetValue(x));
                        break;
                    case "DESCENDING":
                        filteredModelList = filteredModelList.OrderByDescending(x => prop.GetValue(x));
                        break;
                }
            }
            return filteredModelList
                                   .Skip(recordsToBeSkipped)
                                   .Take(recordsToBeTaken);

        }

        public IEnumerable<WorkItemModel> GetMissingDaysToImplement(IEnumerable<WorkItem> workItemList = null)
        {
            int stillEnrolling = settingsManager.DaysAfterContractButStillEnrolling;
            int notTesting = settingsManager.DaysAfterContractAndNotTesting;
            workItemList = workItemList ?? this.GetAllWorkItems(true);

            return workItemList.Where(x =>
                    {
                        if (x.ContractDate == null)
                            return false;

                        if (x.ProductionDate != null)
                            return false;

                        TimeSpan span = DateTime.Now - x.ContractDate.Value;
                        double daysAfterContract = span.TotalDays;

                        if (daysAfterContract >= stillEnrolling && this.IsStillEnrolling(x.WorkItemStatus))
                            return true;

                        if (daysAfterContract >= notTesting && x.WorkItemStatus != WorkItemStatus.Testing)
                            return true;

                        return false;
                    }).Select(wi => WorkItemMapper.Map(wi));
        }

        public IEnumerable<WorkItemModel> GetPagedMissingDaysToImplement(Tuple<int, int> pagingArguments, Tuple<string, string> sortingArguments = null)
        {
            var page = pagingArguments.Item1;
            var pageSize = pagingArguments.Item2;

            var recordsToBeSkipped = ((page - 1) * pageSize);
            var recordsToBeTaken = pageSize;

            int stillEnrolling = settingsManager.DaysAfterContractButStillEnrolling;
            int notTesting = settingsManager.DaysAfterContractAndNotTesting;
            var workItemList = this.GetAllWorkItems(true);

            var filteredWorkItemModelList = workItemList
                                            .Where(x =>
                                                    {
                                                        if (x.ContractDate == null)
                                                            return false;

                                                        if (x.ProductionDate != null)
                                                            return false;

                                                        TimeSpan span = DateTime.Now - x.ContractDate.Value;
                                                        double daysAfterContract = span.TotalDays;

                                                        if (daysAfterContract >= stillEnrolling && this.IsStillEnrolling(x.WorkItemStatus))
                                                            return true;

                                                        if (daysAfterContract >= notTesting && x.WorkItemStatus != WorkItemStatus.Testing)
                                                            return true;

                                                        return false;
                                                    })
                                            .Select(wi => WorkItemMapper.Map(wi));

            if (sortingArguments != null)
            {
                var sortMember = sortingArguments.Item1;
                var sortDirection = sortingArguments.Item2;
                PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(WorkItemModel)).Find(sortMember, false);

                switch (sortDirection.ToUpper())
                {
                    case "ASCENDING":
                        filteredWorkItemModelList = filteredWorkItemModelList.OrderBy(x => prop.GetValue(x));
                        break;
                    case "DESCENDING":
                        filteredWorkItemModelList = filteredWorkItemModelList.OrderByDescending(x => prop.GetValue(x));
                        break;
                }
            }

            return filteredWorkItemModelList
                                   .Skip(recordsToBeSkipped)
                                   .Take(recordsToBeTaken);

        }

        public IEnumerable<WorkItem> GetAllWorkItems(bool? isActiveWorkItemsRequired)
        {
            IEnumerable<WorkItem> workItemList = null;

            try
            {
                workItemList = WcfClient<WorkItemServiceClient>
                     .Instantiate(() => new WorkItemServiceClient())
                     .Return(client => client.GetAllWorkItems());

                workItemList = workItemList.Where(x => x.IsActive == isActiveWorkItemsRequired);


                if (isActiveWorkItemsRequired.HasValue)
                {
                    bool isActive = Convert.ToBoolean(isActiveWorkItemsRequired);
                    workItemList = workItemList.Where(x => x.IsActive == isActive);
                }
            }

            catch (Exception ex)
            {
                Log.Error(ex);
            }

            return workItemList;

        }

        public IEnumerable<WorkItemModel> GetAllWorkItemModels(bool? isActiveRequired = null, bool isWelComeSentTobeCalculated = false)
        {
            var workItems = this.GetAllWorkItems(isActiveRequired);
            return workItems.Select(wi => WorkItemMapper.Map(wi, isWelComeSentTobeCalculated));

        }

        public IEnumerable<WorkItemModel> GetAllWorkItemModels(IEnumerable<WorkItem> workItems, bool? isActiveRequired = null, bool isWelComeSentTobeCalculated = false)
        {
            return (workItems != null) ?
                            workItems.Select(wi => WorkItemMapper.Map(wi, isWelComeSentTobeCalculated))
                            : GetAllWorkItemModels(isActiveRequired: isActiveRequired, isWelComeSentTobeCalculated: isWelComeSentTobeCalculated);
        }

        public Tuple<IEnumerable<WorkItemModel>, int> GetAllPagedActiveWorkItemModels(Tuple<int, int> pagingArguments, bool? isActiveWorkItems = null,
            IEnumerable<Func<WorkItem, bool>> predicateFilters = null, Tuple<string, string> sortingArguments = null, bool isWelComeSentTobeCalculated = false)
        {
            var totalDataCount = 0;

            try
            {
                var workItems = this.GetAllWorkItems(isActiveWorkItems);

                if (predicateFilters != null && predicateFilters.Any())
                {
                    foreach (var filter in predicateFilters)
                    { 
                        workItems = workItems.Where(filter); 
                    }
                }

                totalDataCount = workItems.Count();
                var workItemModelList = workItems.Select(wi => WorkItemMapper.Map(wi, isWelComeSentTobeCalculated));

                if (sortingArguments != null)
                {
                    var sortproperty = sortingArguments.Item1;
                    var sortDirection = sortingArguments.Item2;
                    PropertyDescriptor prop = TypeDescriptor.GetProperties(typeof(WorkItemModel)).Find(sortproperty, false);

                    switch (sortDirection.ToUpper())
                    {
                        case "ASCENDING":
                            workItemModelList = workItemModelList
                                                        .OrderBy(x => prop.GetValue(x));
                            break;
                        case "DESCENDING":
                            workItemModelList = workItemModelList
                                                        .OrderByDescending(x => prop.GetValue(x));
                            break;
                    }
                }

                var page = pagingArguments.Item1;
                var pageSize = pagingArguments.Item2;

                var recordsToBeSkipped = ((page - 1) * pageSize);
                var recordsToBeTaken = pageSize;

                var filteredWorkItemModelList = workItemModelList
                                                        .Skip(recordsToBeSkipped)
                                                        .Take(recordsToBeTaken);

                return Tuple.Create(filteredWorkItemModelList, totalDataCount);
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                throw;
            }
        }

        public double CalculateAverageDaysToImplement(WorkItemModel workItem)
        {
            double result = 0;

            if (workItem.ReinstateDate == null)
            {
                if (workItem.ProductionDate == null)
                {
                    if (workItem.ContractDate != null)
                    {
                        result = CountBusinessDays(workItem.ContractDate.Value, DateTime.Now);
                    }
                }
                else
                {
                    if (workItem.ContractDate != null)
                    {
                        result = CountBusinessDays(workItem.ContractDate.Value, workItem.ProductionDate.Value);
                    }
                }
            }
            else
            {
                if (workItem.ProductionDate == null)
                {
                    if (workItem.ReinstateDate != null)
                    {
                        result = CountBusinessDays(workItem.ReinstateDate.Value, DateTime.Now);
                    }
                }
                else
                {
                    if (workItem.ReinstateDate != null)
                    {
                        result = CountBusinessDays(workItem.ReinstateDate.Value, workItem.ProductionDate.Value);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates number of business days, taking into account:
        ///  - weekends (Saturdays and Sundays)
        /// </summary>
        /// <param name="firstDay">First day in the time interval</param>
        /// <param name="lastDay">Last day in the time interval</param>
        /// <returns>Number of business days during the 'span'</returns>
        public static double CountBusinessDays(DateTime firstDay, DateTime lastDay)
        {
            var span = Math.Abs((lastDay - firstDay).TotalDays);
            var businessDays = span;
            var fullWeekCount = businessDays / 7;

            if (businessDays > fullWeekCount * 7)
            {
                // we are here to find out if there is a 1-day or 2-days weekend
                // in the time interval remaining after subtracting the complete weeks
                var firstDayOfWeek = (int)firstDay.DayOfWeek;
                var lastDayOfWeek = (int)lastDay.DayOfWeek;

                if (lastDayOfWeek < firstDayOfWeek)
                    lastDayOfWeek += 7;
                if (firstDayOfWeek <= 6)
                {
                    if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                        businessDays -= 2;
                    else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                        businessDays -= 1;
                }
                else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                    businessDays -= 1;
            }
            businessDays -= fullWeekCount + fullWeekCount;
            return businessDays;
        }

        public bool IsStillEnrolling(WorkItemStatus status)
        {
            return (status == WorkItemStatus.PendingInitialLogin ||
                    status == WorkItemStatus.PendingSubmission ||
                    status == WorkItemStatus.PendingTPSReview);
        }

    }
}