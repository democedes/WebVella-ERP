﻿using Newtonsoft.Json;
using System;

namespace WebVella.ERP.Api.Models
{
    public class MultiLineTextField : Field
    {
        [JsonProperty(PropertyName = "fieldType")]
        public static FieldType FieldType { get { return FieldType.MultiLineTextField; } }

        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty(PropertyName = "maxLength")]
        public int? MaxLength { get; set; }

        [JsonProperty(PropertyName = "visibleLineNumber")]
        public int? VisibleLineNumber { get; set; }
    }

    public class MultiLineTextFieldMeta : MultiLineTextField
    {
        [JsonProperty(PropertyName = "entityId")]
        public Guid EntityId { get; set; }

        [JsonProperty(PropertyName = "entityName")]
        public string EntityName { get; set; }

		public MultiLineTextFieldMeta(Guid entityId, string entityName, MultiLineTextField field)
		{
			EntityId = entityId;
			EntityName = entityName;
			DefaultValue = field.DefaultValue;
			MaxLength = field.MaxLength;
			VisibleLineNumber = field.VisibleLineNumber;
		}
	}
}