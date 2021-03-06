﻿using System;
using System.Web;
using Fortis.Providers;
using Sitecore;
using Sitecore.Data;

namespace Fortis.Model.RenderingParameters.Fields
{
	public class FieldWrapper : IRenderingParameterFieldWrapper
	{
		protected ISpawnProvider SpawnProvider;
		protected string _value;

		public bool Modified
		{
			get { throw new NotImplementedException(); }
		}

		public object Original
		{
			get { return _value; }
		}

		public string Name { get; protected set; }

		public string RawValue
		{
			get
			{
				return _value;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public FieldWrapper(string fieldName, string value, ISpawnProvider spawnProvider)
		{
			this.Name = fieldName;
			_value = value;

			SpawnProvider = spawnProvider;
		}

		public bool HasValue
		{
			get { return !string.IsNullOrWhiteSpace(RawValue); }
		}

		public virtual IHtmlString Render(string parameters = null, bool editing = false)
		{
			throw new NotImplementedException();
		}

		public IHtmlString Render(object parameters, bool editing = true)
		{
			throw new NotImplementedException();
		}

		public IHtmlString RenderBeginField(object parameters, bool editing = true)
		{
			throw new NotImplementedException();
		}

		public IHtmlString RenderBeginField(string parameters, bool editing = true)
		{
			throw new NotImplementedException();
		}

		public IHtmlString RenderEndField()
		{
			throw new NotImplementedException();
		}

		public Database Database
		{
			get { return Context.Database ?? Context.ContentDatabase; }
		}

		public override string ToString()
		{
			return RawValue;
		}

		public static implicit operator string(FieldWrapper field)
		{
			return field.RawValue;
		}

		public string ToHtmlString()
		{
			return Render().ToString();
		}

		public bool IsLazy
		{
			get { return true; }
		}

	}
}
