// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class AlertPropertiesDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TimeGrainType))
            {
                writer.WritePropertyName("timeGrainType"u8);
                writer.WriteStringValue(TimeGrainType.Value.ToString());
            }
            if (Optional.IsDefined(PeriodStartDate))
            {
                writer.WritePropertyName("periodStartDate"u8);
                writer.WriteStringValue(PeriodStartDate);
            }
            if (Optional.IsDefined(TriggeredBy))
            {
                writer.WritePropertyName("triggeredBy"u8);
                writer.WriteStringValue(TriggeredBy);
            }
            if (Optional.IsCollectionDefined(ResourceGroupFilter))
            {
                writer.WritePropertyName("resourceGroupFilter"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGroupFilter)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ResourceFilter))
            {
                writer.WritePropertyName("resourceFilter"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceFilter)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MeterFilter))
            {
                writer.WritePropertyName("meterFilter"u8);
                writer.WriteStartArray();
                foreach (var item in MeterFilter)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(TagFilter))
            {
                writer.WritePropertyName("tagFilter"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TagFilter);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(TagFilter.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteNumberValue(Threshold.Value);
            }
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToString());
            }
            if (Optional.IsDefined(Amount))
            {
                writer.WritePropertyName("amount"u8);
                writer.WriteNumberValue(Amount.Value);
            }
            if (Optional.IsDefined(Unit))
            {
                writer.WritePropertyName("unit"u8);
                writer.WriteStringValue(Unit);
            }
            if (Optional.IsDefined(CurrentSpend))
            {
                writer.WritePropertyName("currentSpend"u8);
                writer.WriteNumberValue(CurrentSpend.Value);
            }
            if (Optional.IsCollectionDefined(ContactEmails))
            {
                writer.WritePropertyName("contactEmails"u8);
                writer.WriteStartArray();
                foreach (var item in ContactEmails)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContactGroups))
            {
                writer.WritePropertyName("contactGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ContactGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ContactRoles))
            {
                writer.WritePropertyName("contactRoles"u8);
                writer.WriteStartArray();
                foreach (var item in ContactRoles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OverridingAlert))
            {
                writer.WritePropertyName("overridingAlert"u8);
                writer.WriteStringValue(OverridingAlert);
            }
            if (Optional.IsDefined(DepartmentName))
            {
                writer.WritePropertyName("departmentName"u8);
                writer.WriteStringValue(DepartmentName);
            }
            if (Optional.IsDefined(CompanyName))
            {
                writer.WritePropertyName("companyName"u8);
                writer.WriteStringValue(CompanyName);
            }
            if (Optional.IsDefined(EnrollmentNumber))
            {
                writer.WritePropertyName("enrollmentNumber"u8);
                writer.WriteStringValue(EnrollmentNumber);
            }
            if (Optional.IsDefined(EnrollmentStartDate))
            {
                writer.WritePropertyName("enrollmentStartDate"u8);
                writer.WriteStringValue(EnrollmentStartDate);
            }
            if (Optional.IsDefined(EnrollmentEndDate))
            {
                writer.WritePropertyName("enrollmentEndDate"u8);
                writer.WriteStringValue(EnrollmentEndDate);
            }
            if (Optional.IsDefined(InvoicingThreshold))
            {
                writer.WritePropertyName("invoicingThreshold"u8);
                writer.WriteNumberValue(InvoicingThreshold.Value);
            }
            writer.WriteEndObject();
        }

        internal static AlertPropertiesDetails DeserializeAlertPropertiesDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AlertTimeGrainType> timeGrainType = default;
            Optional<string> periodStartDate = default;
            Optional<string> triggeredBy = default;
            Optional<IList<BinaryData>> resourceGroupFilter = default;
            Optional<IList<BinaryData>> resourceFilter = default;
            Optional<IList<BinaryData>> meterFilter = default;
            Optional<BinaryData> tagFilter = default;
            Optional<decimal> threshold = default;
            Optional<CostManagementAlertOperator> @operator = default;
            Optional<decimal> amount = default;
            Optional<string> unit = default;
            Optional<decimal> currentSpend = default;
            Optional<IList<string>> contactEmails = default;
            Optional<IList<string>> contactGroups = default;
            Optional<IList<string>> contactRoles = default;
            Optional<string> overridingAlert = default;
            Optional<string> departmentName = default;
            Optional<string> companyName = default;
            Optional<string> enrollmentNumber = default;
            Optional<string> enrollmentStartDate = default;
            Optional<string> enrollmentEndDate = default;
            Optional<decimal> invoicingThreshold = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeGrainType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeGrainType = new AlertTimeGrainType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("periodStartDate"u8))
                {
                    periodStartDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggeredBy"u8))
                {
                    triggeredBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    resourceGroupFilter = array;
                    continue;
                }
                if (property.NameEquals("resourceFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    resourceFilter = array;
                    continue;
                }
                if (property.NameEquals("meterFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    meterFilter = array;
                    continue;
                }
                if (property.NameEquals("tagFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tagFilter = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    threshold = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = new CostManagementAlertOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("amount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    amount = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("unit"u8))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentSpend"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentSpend = property.Value.GetDecimal();
                    continue;
                }
                if (property.NameEquals("contactEmails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactEmails = array;
                    continue;
                }
                if (property.NameEquals("contactGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactGroups = array;
                    continue;
                }
                if (property.NameEquals("contactRoles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    contactRoles = array;
                    continue;
                }
                if (property.NameEquals("overridingAlert"u8))
                {
                    overridingAlert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("departmentName"u8))
                {
                    departmentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentNumber"u8))
                {
                    enrollmentNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentStartDate"u8))
                {
                    enrollmentStartDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enrollmentEndDate"u8))
                {
                    enrollmentEndDate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invoicingThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invoicingThreshold = property.Value.GetDecimal();
                    continue;
                }
            }
            return new AlertPropertiesDetails(Optional.ToNullable(timeGrainType), periodStartDate.Value, triggeredBy.Value, Optional.ToList(resourceGroupFilter), Optional.ToList(resourceFilter), Optional.ToList(meterFilter), tagFilter.Value, Optional.ToNullable(threshold), Optional.ToNullable(@operator), Optional.ToNullable(amount), unit.Value, Optional.ToNullable(currentSpend), Optional.ToList(contactEmails), Optional.ToList(contactGroups), Optional.ToList(contactRoles), overridingAlert.Value, departmentName.Value, companyName.Value, enrollmentNumber.Value, enrollmentStartDate.Value, enrollmentEndDate.Value, Optional.ToNullable(invoicingThreshold));
        }
    }
}
