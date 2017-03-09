using System;

namespace GatewayEDI.Logging
{
    /// <summary> Provides helper methods that supplement the <see cref="System.Activator" />. </summary>
    internal static class ActivatorHelper
    {
        /// <summary> Instantiates an object of the given type. </summary>
        /// <typeparam name="T"> The type being instantiated </typeparam>
        /// <param name="typeName"> The full type name </param>
        /// <param name="logger"> A log which is used to log any problems which occur in the instantiation process. </param>
        /// <returns> </returns>
        internal static T Instantiate<T>(string typeName, ILog log)
        {
            Type typeToInstantiate = Type.GetType(typeName);

            // check that the type can be located
            if (typeToInstantiate == null)
            {
                log.Error("The item has a type which cannot be located [type={0}].", typeName);
                return default(T);
            }

            // create instance of the given type
            object instantiatedInstance;
            try
            {
                instantiatedInstance = Activator.CreateInstance(typeToInstantiate);
            }
            catch (Exception e)
            {
                log.Error(e, "The item [type={0}], cannot be instantiated", typeToInstantiate);
                return default(T);
            }

            // make sure we do have an item of the correct type
            T instantiatedType = default(T);
            try
            {
                instantiatedType = (T) instantiatedInstance;
            }
            catch (InvalidCastException)
            {
                log.Error("The item [type={0}], is not of type {1}.", typeToInstantiate, typeof (T));
            }

            return instantiatedType;
        }
    }
}