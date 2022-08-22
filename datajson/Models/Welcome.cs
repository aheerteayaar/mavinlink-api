using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace datajson.Models
{

    public partial class Welcome
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("results")]
        public Result[] Results { get; set; }

        [JsonProperty("workspaces")]
        public Dictionary<string, Workspace> Workspaces { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("users")]
        public Dictionary<string, User> Users { get; set; }
    }

    public partial class Meta
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("page_count")]
        public long PageCount { get; set; }

        [JsonProperty("page_number")]
        public long PageNumber { get; set; }

        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("key")]
        public Key Key { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }
    }

    public partial class User
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("photo_path")]
        public Uri PhotoPath { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("generic")]
        public bool Generic { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("update_whitelist")]
        public UpdateWhitelist[] UpdateWhitelist { get; set; }

        [JsonProperty("account_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AccountId { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }
    }

    public partial class Workspace
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("effective_due_date")]
        public string EffectiveDueDate { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("budgeted")]
        public bool Budgeted { get; set; }

        [JsonProperty("change_orders_enabled")]
        public bool ChangeOrdersEnabled { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("consultant_role_name")]
        public NtRoleName ConsultantRoleName { get; set; }

        [JsonProperty("client_role_name")]
        public NtRoleName ClientRoleName { get; set; }

        [JsonProperty("percentage_complete")]
        public long PercentageComplete { get; set; }

        [JsonProperty("access_level")]
        public AccessLevel AccessLevel { get; set; }

        [JsonProperty("exclude_archived_stories_percent_complete")]
        public bool ExcludeArchivedStoriesPercentComplete { get; set; }

        [JsonProperty("show_nonbillable_time_on_invoices")]
        public bool ShowNonbillableTimeOnInvoices { get; set; }

        [JsonProperty("can_create_line_items")]
        public bool CanCreateLineItems { get; set; }

        [JsonProperty("default_rate")]
        public string DefaultRate { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("currency_symbol")]
        public CurrencySymbol CurrencySymbol { get; set; }

        [JsonProperty("currency_base_unit")]
        public long CurrencyBaseUnit { get; set; }

        [JsonProperty("can_invite")]
        public bool? CanInvite { get; set; }

        [JsonProperty("has_budget_access")]
        public bool HasBudgetAccess { get; set; }

        [JsonProperty("revenue_recognition_method")]
        public object RevenueRecognitionMethod { get; set; }

        [JsonProperty("tasks_default_non_billable")]
        public bool TasksDefaultNonBillable { get; set; }

        [JsonProperty("rate_card_id")]
        public long RateCardId { get; set; }

        [JsonProperty("workspace_invoice_preference_id")]
        public long? WorkspaceInvoicePreferenceId { get; set; }

        [JsonProperty("posts_require_privacy_decision")]
        public bool PostsRequirePrivacyDecision { get; set; }

        [JsonProperty("require_time_approvals")]
        public bool RequireTimeApprovals { get; set; }

        [JsonProperty("require_expense_approvals")]
        public bool RequireExpenseApprovals { get; set; }

        [JsonProperty("has_active_timesheet_submissions")]
        public bool HasActiveTimesheetSubmissions { get; set; }

        [JsonProperty("has_active_expense_report_submissions")]
        public bool HasActiveExpenseReportSubmissions { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("update_whitelist")]
        public string[] UpdateWhitelist { get; set; }

        [JsonProperty("account_features")]
        public AccountFeatures AccountFeatures { get; set; }

        [JsonProperty("permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("over_budget")]
        public bool OverBudget { get; set; }

        [JsonProperty("expenses_in_burn_rate")]
        public bool ExpensesInBurnRate { get; set; }

        [JsonProperty("total_expenses_in_cents")]
        public long TotalExpensesInCents { get; set; }

        [JsonProperty("price_in_cents")]
        public long? PriceInCents { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("percent_of_budget_used")]
        public long PercentOfBudgetUsed { get; set; }

        [JsonProperty("budget_used")]
        public string BudgetUsed { get; set; }

        [JsonProperty("budget_used_in_cents")]
        public long BudgetUsedInCents { get; set; }

        [JsonProperty("budget_remaining")]
        public string BudgetRemaining { get; set; }

        [JsonProperty("target_margin")]
        public long? TargetMargin { get; set; }

        [JsonProperty("creator_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long CreatorId { get; set; }

        [JsonProperty("primary_maven_id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long PrimaryMavenId { get; set; }

        [JsonProperty("participant_ids")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] ParticipantIds { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("stories_are_fixed_fee_by_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoriesAreFixedFeeByDefault { get; set; }
    }

    public partial class AccountFeatures
    {
        [JsonProperty("time_trackable")]
        public bool TimeTrackable { get; set; }

        [JsonProperty("has_time_entry_role_picker")]
        public bool HasTimeEntryRolePicker { get; set; }

        [JsonProperty("project_side_panel")]
        public bool ProjectSidePanel { get; set; }
    }

    public partial class Permissions
    {
        [JsonProperty("can_upload_files")]
        public bool CanUploadFiles { get; set; }

        [JsonProperty("can_private_message")]
        public bool CanPrivateMessage { get; set; }

        [JsonProperty("can_join")]
        public bool CanJoin { get; set; }

        [JsonProperty("is_participant")]
        public bool IsParticipant { get; set; }

        [JsonProperty("access_level")]
        public string AccessLevel { get; set; }

        [JsonProperty("team_lead")]
        public bool? TeamLead { get; set; }

        [JsonProperty("user_is_client")]
        public bool? UserIsClient { get; set; }

        [JsonProperty("can_change_price")]
        public bool CanChangePrice { get; set; }

        [JsonProperty("can_change_story_billable")]
        public bool CanChangeStoryBillable { get; set; }

        [JsonProperty("can_post")]
        public bool CanPost { get; set; }

        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }

        [JsonProperty("restricted")]
        public bool? Restricted { get; set; }

        [JsonProperty("can_see_financials")]
        public bool CanSeeFinancials { get; set; }

        [JsonProperty("is_guest_on_project")]
        public bool IsGuestOnProject { get; set; }
    }

    public partial class Status
    {
        [JsonProperty("color")]
        public Color Color { get; set; }

        [JsonProperty("key")]
        public long Key { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }
    }

    public enum Key { Workspaces };

    public enum UpdateWhitelist { Address1, Address2, Bio, City, CompanyName, EmailAddress, ExternalReference, FullName, Headline, LinkedinUrl, State, Website, Zip };

    public enum AccessLevel { Open };

    public enum NtRoleName { Clients, ClientsPartners, RedCaffeine };

    public enum Currency { Usd };

    public enum CurrencySymbol { Empty };

    public enum Color { Green, Grey };

    public enum Message { InProgress, OnHold };

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                KeyConverter.Singleton,
                UpdateWhitelistConverter.Singleton,
                AccessLevelConverter.Singleton,
                NtRoleNameConverter.Singleton,
                CurrencyConverter.Singleton,
                CurrencySymbolConverter.Singleton,
                ColorConverter.Singleton,
                MessageConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class KeyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Key) || t == typeof(Key?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "workspaces")
            {
                return Key.Workspaces;
            }
            throw new Exception("Cannot unmarshal type Key");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Key)untypedValue;
            if (value == Key.Workspaces)
            {
                serializer.Serialize(writer, "workspaces");
                return;
            }
            throw new Exception("Cannot marshal type Key");
        }

        public static readonly KeyConverter Singleton = new KeyConverter();
    }

    internal class UpdateWhitelistConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UpdateWhitelist) || t == typeof(UpdateWhitelist?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "address1":
                    return UpdateWhitelist.Address1;
                case "address2":
                    return UpdateWhitelist.Address2;
                case "bio":
                    return UpdateWhitelist.Bio;
                case "city":
                    return UpdateWhitelist.City;
                case "company_name":
                    return UpdateWhitelist.CompanyName;
                case "email_address":
                    return UpdateWhitelist.EmailAddress;
                case "external_reference":
                    return UpdateWhitelist.ExternalReference;
                case "full_name":
                    return UpdateWhitelist.FullName;
                case "headline":
                    return UpdateWhitelist.Headline;
                case "linkedin_url":
                    return UpdateWhitelist.LinkedinUrl;
                case "state":
                    return UpdateWhitelist.State;
                case "website":
                    return UpdateWhitelist.Website;
                case "zip":
                    return UpdateWhitelist.Zip;
            }
            throw new Exception("Cannot unmarshal type UpdateWhitelist");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UpdateWhitelist)untypedValue;
            switch (value)
            {
                case UpdateWhitelist.Address1:
                    serializer.Serialize(writer, "address1");
                    return;
                case UpdateWhitelist.Address2:
                    serializer.Serialize(writer, "address2");
                    return;
                case UpdateWhitelist.Bio:
                    serializer.Serialize(writer, "bio");
                    return;
                case UpdateWhitelist.City:
                    serializer.Serialize(writer, "city");
                    return;
                case UpdateWhitelist.CompanyName:
                    serializer.Serialize(writer, "company_name");
                    return;
                case UpdateWhitelist.EmailAddress:
                    serializer.Serialize(writer, "email_address");
                    return;
                case UpdateWhitelist.ExternalReference:
                    serializer.Serialize(writer, "external_reference");
                    return;
                case UpdateWhitelist.FullName:
                    serializer.Serialize(writer, "full_name");
                    return;
                case UpdateWhitelist.Headline:
                    serializer.Serialize(writer, "headline");
                    return;
                case UpdateWhitelist.LinkedinUrl:
                    serializer.Serialize(writer, "linkedin_url");
                    return;
                case UpdateWhitelist.State:
                    serializer.Serialize(writer, "state");
                    return;
                case UpdateWhitelist.Website:
                    serializer.Serialize(writer, "website");
                    return;
                case UpdateWhitelist.Zip:
                    serializer.Serialize(writer, "zip");
                    return;
            }
            throw new Exception("Cannot marshal type UpdateWhitelist");
        }

        public static readonly UpdateWhitelistConverter Singleton = new UpdateWhitelistConverter();
    }

    internal class AccessLevelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AccessLevel) || t == typeof(AccessLevel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "open")
            {
                return AccessLevel.Open;
            }
            throw new Exception("Cannot unmarshal type AccessLevel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AccessLevel)untypedValue;
            if (value == AccessLevel.Open)
            {
                serializer.Serialize(writer, "open");
                return;
            }
            throw new Exception("Cannot marshal type AccessLevel");
        }

        public static readonly AccessLevelConverter Singleton = new AccessLevelConverter();
    }

    internal class NtRoleNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NtRoleName) || t == typeof(NtRoleName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Clients":
                    return NtRoleName.Clients;
                case "Clients - Partners":
                    return NtRoleName.ClientsPartners;
                case "Red Caffeine":
                    return NtRoleName.RedCaffeine;
            }
            throw new Exception("Cannot unmarshal type NtRoleName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NtRoleName)untypedValue;
            switch (value)
            {
                case NtRoleName.Clients:
                    serializer.Serialize(writer, "Clients");
                    return;
                case NtRoleName.ClientsPartners:
                    serializer.Serialize(writer, "Clients - Partners");
                    return;
                case NtRoleName.RedCaffeine:
                    serializer.Serialize(writer, "Red Caffeine");
                    return;
            }
            throw new Exception("Cannot marshal type NtRoleName");
        }

        public static readonly NtRoleNameConverter Singleton = new NtRoleNameConverter();
    }

    internal class CurrencyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Currency) || t == typeof(Currency?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "USD")
            {
                return Currency.Usd;
            }
            throw new Exception("Cannot unmarshal type Currency");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Currency)untypedValue;
            if (value == Currency.Usd)
            {
                serializer.Serialize(writer, "USD");
                return;
            }
            throw new Exception("Cannot marshal type Currency");
        }

        public static readonly CurrencyConverter Singleton = new CurrencyConverter();
    }

    internal class CurrencySymbolConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CurrencySymbol) || t == typeof(CurrencySymbol?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "$")
            {
                return CurrencySymbol.Empty;
            }
            throw new Exception("Cannot unmarshal type CurrencySymbol");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CurrencySymbol)untypedValue;
            if (value == CurrencySymbol.Empty)
            {
                serializer.Serialize(writer, "$");
                return;
            }
            throw new Exception("Cannot marshal type CurrencySymbol");
        }

        public static readonly CurrencySymbolConverter Singleton = new CurrencySymbolConverter();
    }

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long[]);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (long[])untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    internal class ColorConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Color) || t == typeof(Color?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "green":
                    return Color.Green;
                case "grey":
                    return Color.Grey;
            }
            throw new Exception("Cannot unmarshal type Color");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Color)untypedValue;
            switch (value)
            {
                case Color.Green:
                    serializer.Serialize(writer, "green");
                    return;
                case Color.Grey:
                    serializer.Serialize(writer, "grey");
                    return;
            }
            throw new Exception("Cannot marshal type Color");
        }

        public static readonly ColorConverter Singleton = new ColorConverter();
    }

    internal class MessageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Message) || t == typeof(Message?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "In Progress":
                    return Message.InProgress;
                case "On Hold":
                    return Message.OnHold;
            }
            throw new Exception("Cannot unmarshal type Message");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Message)untypedValue;
            switch (value)
            {
                case Message.InProgress:
                    serializer.Serialize(writer, "In Progress");
                    return;
                case Message.OnHold:
                    serializer.Serialize(writer, "On Hold");
                    return;
            }
            throw new Exception("Cannot marshal type Message");
        }

        public static readonly MessageConverter Singleton = new MessageConverter();
    }
}
