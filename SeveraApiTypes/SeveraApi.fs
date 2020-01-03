namespace Mutex.Visma.Severa.SOAP.API

open Microsoft.FSharp.Data.TypeProviders

type VismaSeveraApi = WsdlService<"http://sync.severa.com/webservice/S3/API.svc/WSDL">

// ------------------------------
// Type aliases: Clients
// ------------------------------

type AccessRightsClient = VismaSeveraApi.ServiceTypes.AccessRightsClient
type AccountClient = VismaSeveraApi.ServiceTypes.AccountClient
type AccountGroupClient = VismaSeveraApi.ServiceTypes.AccountGroupClient
type ActivityClient = VismaSeveraApi.ServiceTypes.ActivityClient
type ActivityTypeClient = VismaSeveraApi.ServiceTypes.ActivityTypeClient
type AddressClient = VismaSeveraApi.ServiceTypes.AddressClient
type APIClient = VismaSeveraApi.ServiceTypes.APIClient
type BusinessUnitClient = VismaSeveraApi.ServiceTypes.BusinessUnitClient
type CaseClient = VismaSeveraApi.ServiceTypes.CaseClient
type CaseStatusClient = VismaSeveraApi.ServiceTypes.CaseStatusClient
type CompanyClient = VismaSeveraApi.ServiceTypes.CompanyClient
type ContactClient = VismaSeveraApi.ServiceTypes.ContactClient
type CostCenterClient = VismaSeveraApi.ServiceTypes.CostCenterClient
type CountryClient = VismaSeveraApi.ServiceTypes.CountryClient
type CurrencyClient = VismaSeveraApi.ServiceTypes.CurrencyClient
type CustomerClient = VismaSeveraApi.ServiceTypes.CustomerClient
type EmploymentClient = VismaSeveraApi.ServiceTypes.EmploymentClient
type ExtranetClient = VismaSeveraApi.ServiceTypes.ExtranetClient
type FileClient = VismaSeveraApi.ServiceTypes.FileClient
type HeartbeatClient = VismaSeveraApi.ServiceTypes.HeartbeatClient
type HourEntryClient = VismaSeveraApi.ServiceTypes.HourEntryClient
type IndustryClient = VismaSeveraApi.ServiceTypes.IndustryClient
type InvoiceClient = VismaSeveraApi.ServiceTypes.InvoiceClient
type InvoiceStatusClient = VismaSeveraApi.ServiceTypes.InvoiceStatusClient
type ItemClient = VismaSeveraApi.ServiceTypes.ItemClient
type LanguageClient = VismaSeveraApi.ServiceTypes.LanguageClient
type LeadSourceClient = VismaSeveraApi.ServiceTypes.LeadSourceClient
type OvertimeClient = VismaSeveraApi.ServiceTypes.OverTimeClient
type PhaseClient = VismaSeveraApi.ServiceTypes.PhaseClient
type PhaseMemberClient = VismaSeveraApi.ServiceTypes.PhaseMemberClient
type PricelistClient = VismaSeveraApi.ServiceTypes.PricelistClient
type ProductClient = VismaSeveraApi.ServiceTypes.ProductClient
type ProductCategoryClient = VismaSeveraApi.ServiceTypes.ProductCategoryClient
type ResourceClient= VismaSeveraApi.ServiceTypes.ResourceClient
type ResourceAllocationClient = VismaSeveraApi.ServiceTypes.ResourceAllocationClient
type SalesProcessClient = VismaSeveraApi.ServiceTypes.SalesProcessClient
type SalesStatusClient = VismaSeveraApi.ServiceTypes.SalesStatusClient
type TagClient = VismaSeveraApi.ServiceTypes.TagClient
type TimeEntryClient = VismaSeveraApi.ServiceTypes.TimeEntryClient
type TimezoneClient = VismaSeveraApi.ServiceTypes.TimezoneClient
type TravelReimbursementClient = VismaSeveraApi.ServiceTypes.TravelReimbursementClient
type TravelReimbursementStatusClient = VismaSeveraApi.ServiceTypes.TravelReimbursementStatusClient
type UserClient = VismaSeveraApi.ServiceTypes.UserClient
type WorkTypeClient = VismaSeveraApi.ServiceTypes.WorkTypeClient

// ------------------------------
// Type aliases: Contracts
// ------------------------------

type IAccessRights = VismaSeveraApi.ServiceTypes.IAccessRights
type IAccount = VismaSeveraApi.ServiceTypes.IAccount
type AccountGroupClientX = VismaSeveraApi.ServiceTypes.AccountGroupClient
type IActivity = VismaSeveraApi.ServiceTypes.IActivity
type IActivityType = VismaSeveraApi.ServiceTypes.IActivityType
type IAddress = VismaSeveraApi.ServiceTypes.IAddress
type IAPI = VismaSeveraApi.ServiceTypes.IAPI
type IBusinessUnit = VismaSeveraApi.ServiceTypes.IBusinessUnit
type ICase = VismaSeveraApi.ServiceTypes.ICase
type ICaseStatus = VismaSeveraApi.ServiceTypes.ICaseStatus
type ICompany = VismaSeveraApi.ServiceTypes.ICompany
type IContact = VismaSeveraApi.ServiceTypes.IContact
type ICostCenter = VismaSeveraApi.ServiceTypes.ICostCenter
type ICountry = VismaSeveraApi.ServiceTypes.ICountry
type ICurrency = VismaSeveraApi.ServiceTypes.ICurrency
type ICustomer = VismaSeveraApi.ServiceTypes.ICustomer
type IEmployment = VismaSeveraApi.ServiceTypes.IEmployment
type IExtranet = VismaSeveraApi.ServiceTypes.IExtranet
type IFile = VismaSeveraApi.ServiceTypes.IFile
type IHeartbeat = VismaSeveraApi.ServiceTypes.IHeartbeat
type IHourEntry = VismaSeveraApi.ServiceTypes.IHourEntry
type IIndustry = VismaSeveraApi.ServiceTypes.IIndustry
type IInvoice = VismaSeveraApi.ServiceTypes.IInvoice
type IInvoiceStatus = VismaSeveraApi.ServiceTypes.IInvoiceStatus
type IItem = VismaSeveraApi.ServiceTypes.IItem
type ILanguage = VismaSeveraApi.ServiceTypes.ILanguage
type ILeadSource = VismaSeveraApi.ServiceTypes.ILeadSource
type IOvertime = VismaSeveraApi.ServiceTypes.IOverTime
type IPhase = VismaSeveraApi.ServiceTypes.IPhase
type IPhaseMember = VismaSeveraApi.ServiceTypes.IPhaseMember
type IPricelist = VismaSeveraApi.ServiceTypes.IPricelist
type IProduct = VismaSeveraApi.ServiceTypes.IProduct
type IProductCategory = VismaSeveraApi.ServiceTypes.IProductCategory
type IResource = VismaSeveraApi.ServiceTypes.IResource
type IResourceAllocation = VismaSeveraApi.ServiceTypes.IResourceAllocation
type ISalesProcess = VismaSeveraApi.ServiceTypes.ISalesProcess
type ISalesStatus = VismaSeveraApi.ServiceTypes.ISalesStatus
type ITag = VismaSeveraApi.ServiceTypes.ITag
type ITimeEntry = VismaSeveraApi.ServiceTypes.ITimeEntry
type ITimezone = VismaSeveraApi.ServiceTypes.ITimezone
type ITravelReimbursement = VismaSeveraApi.ServiceTypes.ITravelReimbursement
type ITravelReimbursementStatus = VismaSeveraApi.ServiceTypes.ITravelReimbursementStatus
type IUser = VismaSeveraApi.ServiceTypes.IUser
type IWorkType = VismaSeveraApi.ServiceTypes.IWorkType

// ------------------------------
// Type aliases: Entities
// ------------------------------

type AccessRights = VismaSeveraApi.ServiceTypes.Severa.Entities.API.AccessRights
type AccessRightsProfile = VismaSeveraApi.ServiceTypes.Severa.Entities.API.AccessRightsProfile
type Account = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Account
type AccountGroup = VismaSeveraApi.ServiceTypes.Severa.Entities.API.AccountGroup
type AccountTiny = VismaSeveraApi.ServiceTypes.Severa.Entities.API.AccountTiny
type Activity = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Activity
type ActivityParticipant = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ActivityParticipant
type ActivityType = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ActivityType
type Address = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Address
type BillingAndExpenseForecast = VismaSeveraApi.ServiceTypes.Severa.Entities.API.BillingAndExpenseForecast
type BusinessUnit = VismaSeveraApi.ServiceTypes.Severa.Entities.API.BusinessUnit
type Case = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Case
type CaseCriteria = VismaSeveraApi.ServiceTypes.Severa.Entities.API.CaseCriteria
type CaseStatus = VismaSeveraApi.ServiceTypes.Severa.Entities.API.CaseStatus
type Company = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Company
type CommunicationMethod = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Contact.CommunicationMethod
type Contact = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Contact
type CostAccount = VismaSeveraApi.ServiceTypes.Severa.Entities.API.CostAccount
type CostCenter = VismaSeveraApi.ServiceTypes.Severa.Entities.API.CostCenter
type Country = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Country
type Currency = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Currency
type Customer = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Customer
type CustomerCriteria = VismaSeveraApi.ServiceTypes.Severa.Entities.API.CustomerCriteria
type Employment = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Employment
type ExtranetCase = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ExtranetCase
type ExtranetCaseRights = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ExtranetCaseRights
type ExtranetContact = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ExtranetContact
type ExtranetContactCaseRights = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ExtranetContactCaseRights
type ExtranetContactRights = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ExtranetContactRights
type File = VismaSeveraApi.ServiceTypes.Severa.Entities.API.File
type Finvoice = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Finvoice
type FlatRate = VismaSeveraApi.ServiceTypes.Severa.Entities.API.FlatRate
type HourEntry = VismaSeveraApi.ServiceTypes.Severa.Entities.API.HourEntry
type Industry = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Industry
type Invoice = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Invoice
type InvoiceBankAccount = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceBankAccount
type InvoiceBuyerOrganization = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceBuyerOrganization
type InvoiceConfig = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceConfig
type InvoiceDetails = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceDetails
type InvoiceFile = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceFile
type InvoiceInformation = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceInformation
type InvoiceOriginDetails = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceOriginDetails
type InvoiceCaseDetails = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceOriginDetailsCaseDetails
type InvoiceRowOrigin = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceOriginDetails.InvoiceRowOrigin
type InvoicePostAddress = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoicePostAddress
type InvoiceRow = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceRow
type InvoiceSellerContact = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceSellerContact
type InvoiceSellerOrganization = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceSellerOrganization
type InvoiceStatus = VismaSeveraApi.ServiceTypes.Severa.Entities.API.InvoiceStatus
type Item = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Item
type Language = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Language
type LeadSource = VismaSeveraApi.ServiceTypes.Severa.Entities.API.LeadSource
type Overtime = VismaSeveraApi.ServiceTypes.Severa.Entities.API.OverTime
type Phase = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Phase
type PhaseTreeNode = VismaSeveraApi.ServiceTypes.Severa.Entities.API.PhaseTreeNode
type Pricelist = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Pricelist
type Product = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Product
type ProductCategory = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ProductCategory
type Resource = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Resource
type ResourceAllocation = VismaSeveraApi.ServiceTypes.Severa.Entities.API.ResourceAllocation
type SalesProcess = VismaSeveraApi.ServiceTypes.Severa.Entities.API.SalesProcess
type SalesStatus = VismaSeveraApi.ServiceTypes.Severa.Entities.API.SalesStatus
type SeveraFinvoice = VismaSeveraApi.ServiceTypes.Severa.Entities.API.SeveraFinvoice
type Tag = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Tag
type TimeEntry = VismaSeveraApi.ServiceTypes.Severa.Entities.API.TimeEntry
type Timezone = VismaSeveraApi.ServiceTypes.Severa.Entities.API.Timezone
type TravelExpense = VismaSeveraApi.ServiceTypes.Severa.Entities.API.TravelExpense
type TravelReimbursement = VismaSeveraApi.ServiceTypes.Severa.Entities.API.TravelReimbursement
type TravelReimbursementRow = VismaSeveraApi.ServiceTypes.Severa.Entities.API.TravelReimbursementRow
type TravelReimbursementStatus = VismaSeveraApi.ServiceTypes.Severa.Entities.API.TravelReimbursementStatus
type User = VismaSeveraApi.ServiceTypes.Severa.Entities.API.User
type UserRights = VismaSeveraApi.ServiceTypes.Severa.Entities.API.UserRights
type WorkDayActivity = VismaSeveraApi.ServiceTypes.Severa.Entities.API.WorkDayActivity
type WorkDayInfo = VismaSeveraApi.ServiceTypes.Severa.Entities.API.WorkDayInfo
type WorkType = VismaSeveraApi.ServiceTypes.Severa.Entities.API.WorkType

// ------------------------------
// Type aliases: Enumerations
// ------------------------------

type AccountRight = VismaSeveraApi.ServiceTypes.Severa.Entities.API.AccountRight
type AdministratorRight = VismaSeveraApi.ServiceTypes.Severa.Entities.API.AdministratorRight
type CaseRight = VismaSeveraApi.ServiceTypes.Severa.Entities.API.CaseRight
type CommunicationMethodType = VismaSeveraApi.ServiceTypes.Severa.Entities.CommunicationMethodType
type TravelReimbursementRight = VismaSeveraApi.ServiceTypes.Severa.Entities.API.TravelReimbursementRight
type UsersRight = VismaSeveraApi.ServiceTypes.Severa.Entities.API.UsersRight
type WorkHourApprovalRight = VismaSeveraApi.ServiceTypes.Severa.Entities.API.WorkHourApprovalRight

type AccountGetOptions = VismaSeveraApi.ServiceTypes.Severa.API.AccountGetOptions
type CustomerGetOptions = AccountGetOptions

// ------------------------------
// Type aliases: Failure Types
// ------------------------------

type AuthenticationFailure = VismaSeveraApi.ServiceTypes.Severa.API.AuthenticationFailureException
type GeneralFailure = VismaSeveraApi.ServiceTypes.Severa.API.GeneralFailureException
type NoPermissionFailure = VismaSeveraApi.ServiceTypes.Severa.API.NoPermissionException
type EntityNotFoundFailure = VismaSeveraApi.ServiceTypes.Severa.API.NotFoundException
//type QuotaLimitExceededFailure = VismaSeveraApi.ServiceTypes.Severa.API.QuotaLimitExceededException
//type TermsOfServiceNotApprovedFailure = VismaSeveraApi.ServiceTypes.Severa.API.TosNotApprovedException
type SeveraApiFailure = VismaSeveraApi.ServiceTypes.Severa.API.SeveraApiException
type ValidationFailure = VismaSeveraApi.ServiceTypes.Severa.API.ValidationException

// ------------------------------
// Types from the documentation
// and missing from the WSDL
// ------------------------------

type AccountGroupGetOptions =
| None = 0
| IncludeInactive = 2

type BusinessUnitGetOptions =
| None = 0
| NewOnly = 1
| IncludeInactive = 2
| IncludeRoot = 4
| EntireHierarchy = 8

type CaseGetOptions =
| None = 0
| NewOnly = 1
| IncludeInactive = 2
| ExcludeNotNumbered = 4
| ExcludeNoWonCases = 8
| InternalOnly = 16
| ExcludeClosed = 32
| ExcludeOpen = 64

type ContactGetOptions =
| None = 0
| NewOnly = 1
| IncludeInactive = 2
| ExcludeNotNumbered = 4
| ExcludeWithNoWonCases = 8

type InvoiceGetOptions =
| None = 0
| NewOnly = 1
| ExcludeChildBusinessUnits = 16

type InvoicePdfGetOptions =
| All = 0
| AttachmentOnly = 1
| InvoiceOnly = 2

type PhaseGetOptions =
| None = 0
| NewOnly = 1

type ProductCategoryGetOptions =
| None = 0
| NewOnly = 1
| IncludeInactive = 2

type ProductGetOptions =
| None = 0
| NewOnly = 1
| IncludeInactive = 2

type TravelReimbursementGetOptions =
| None = 0
| NewOnly = 1
| IncludeChildBusinessUnits = 16

type UserGetOptions =
| None = 0
| NewOnly = 1
| IncludeInactive = 2
