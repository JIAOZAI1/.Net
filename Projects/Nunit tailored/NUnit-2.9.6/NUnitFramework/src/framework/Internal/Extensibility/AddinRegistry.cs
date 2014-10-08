// ****************************************************************
// Copyright 2007, Charlie Poole
// This is free software licensed under the NUnit license. You may
// obtain a copy of the license at http://nunit.org
// ****************************************************************

#if !NUNITLITE
using System;
using System.Collections;
using System.Reflection;
using NUnit.Framework.Extensibility;

namespace NUnit.Framework.Internal.Extensibility
{
	/// <summary>
	/// Summary description for AddinRegistry.
	/// </summary>
	public class AddinRegistry : IAddinRegistry
    {
        #region Instance Fields
        private ArrayList addins = new ArrayList();
		#endregion

		#region IAddinRegistry Members

		public void Register(Addin addin)
		{
			addins.Add( addin );
		}

		public  IList Addins
		{
			get
			{
				return addins;
			}
		}

        public bool IsAddinRegistered(string name)
        {
            return FindAddinByName(name) != null;
        }

		public void SetStatus( string name, AddinStatus status, string message )
		{
            Addin addin = FindAddinByName(name);
            if (addin != null)
            {
                addin.Status = status;
                addin.Message = message;
            }
        }

        private Addin FindAddinByName(string name)
        {
            foreach (Addin addin in addins)
                if (addin.Name == name)
                    return addin;

            return null;
        }
		#endregion
    }
}
#endif
