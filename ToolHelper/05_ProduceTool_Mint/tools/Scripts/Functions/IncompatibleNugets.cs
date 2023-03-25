namespace Scripts
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;
    using Mint.Common;
    using Mint.Database.APIs;
    using Mint.Database.Enums;

    public class IncompatibleNugets
    {
        public static void Execute()
        {
            var assemblies = new List<string>
            {
                "ActiveDs.dll",
                "Annotators.Falex.dll",
                "AntiXssLibrary.dll",
                "ApSecretStoreManaged.dll",
                "Autofac.dll",
                "Azure.Core.dll",
                "Azure.Security.KeyVault.Keys.dll",
                "Ben.Demystifier.dll",
                "BihConsumerInterop.dll",
                "Bond.Attributes.dll",
                "Bond.dll",
                "Bond.IO.dll",
                "Bond.JSON.dll",
                "BouncyCastle.Crypto.dll",
                "CardinalityEstimation.dll",
                "Cqo.dll",
                "Crc32C.NET.dll",
                "DiffPlex.dll",
                "DnsWebServiceDualWrite.dll",
                "DocumentFormat.OpenXml.dll",
                "Elasticsearch.Net.dll",
                "EntityFramework.dll",
                "ExpPlatform.Client.dll",
                "FileCache.Signed.dll",
                "FilterUtil.dll",
                "FUSE.Weld.Base.dll",
                "FUSE.Weld.Base.Portable.dll",
                "Google.Protobuf.dll",
                "Graphlib.Security.Cryptography.dll",
                "Grpc.Core.Api.dll",
                "Grpc.Core.dll",
                "HaaSFPGAManagerClient.dll",
                "HashFuzzy.dll",
                "HotConfig.signed.dll",
                "Hyak.Common.dll",
                "IMF.GlobalEnums.signed.dll",
                "IMF.signed.dll",
                "Infer.Runtime.dll",
                "IpcManagedAPIAsync.dll",
                "JobService.Contract.dll",
                "Live.XPander.Utilities.dll",
                "log4net.dll",
                "ManagedBlingSigned.dll",
                "Microsoft.AdCenter.ReliableTransferLibrary.dll",
                "Microsoft.Analytics.Common.dll",
                "Microsoft.Analytics.Interfaces.dll",
                "Microsoft.Analytics.Types.dll",
                "Microsoft.Applications.Telemetry.dll",
                "Microsoft.Applications.Telemetry.Server.dll",
                "Microsoft.ApplicationServer.Caching.Client.dll",
                "Microsoft.ApplicationServer.Caching.Core.dll",
                "Microsoft.AspNet.SignalR.Client.dll",
                "Microsoft.AspNet.SignalR.Core.dll",
                "Microsoft.AspNetCore.WebUtilities.dll",
                "Microsoft.Automata.dll",
                "Microsoft.Azure.ActiveDirectory.GraphClient.FirstParty.dll",
                "Microsoft.Azure.Amqp.dll",
                "Microsoft.Azure.Batch.dll",
                "Microsoft.Azure.Common.dll",
                "Microsoft.Azure.Cosmos.Client.dll",
                "Microsoft.Azure.Cosmos.Core.dll",
                "Microsoft.Azure.Cosmos.Direct.dll",
                "Microsoft.Azure.Cosmos.Encryption.dll",
                "Microsoft.Azure.Cosmos.Serialization.HybridRow.dll",
                "Microsoft.Azure.DataLake.InternalStoreCosmosCompression.dll",
                "Microsoft.Azure.DataLake.InternalStoreSDK.dll",
                "Microsoft.Azure.DataLake.Store.dll",
                "Microsoft.Azure.Documents.ChangeFeedProcessor.dll",
                "Microsoft.Azure.Documents.Client.dll",
                "Microsoft.Azure.EventHubs.dll",
                "Microsoft.Azure.KeyVault.dll",
                "Microsoft.Azure.KeyVault.WebKey.dll",
                "Microsoft.Azure.Management.AppService.Fluent.dll",
                "Microsoft.Azure.Management.Batch.dll",
                "Microsoft.Azure.Management.Batch.Fluent.dll",
                "Microsoft.Azure.Management.BatchAI.Fluent.dll",
                "Microsoft.Azure.Management.Cdn.Fluent.dll",
                "Microsoft.Azure.Management.Compute.Fluent.dll",
                "Microsoft.Azure.Management.ContainerInstance.Fluent.dll",
                "Microsoft.Azure.Management.ContainerRegistry.Fluent.dll",
                "Microsoft.Azure.Management.ContainerService.Fluent.dll",
                "Microsoft.Azure.Management.CosmosDB.Fluent.dll",
                "Microsoft.Azure.Management.DataLake.Analytics.dll",
                "Microsoft.Azure.Management.DataLake.InternalAnalytics.Scope.dll",
                "Microsoft.Azure.Management.DataLake.Store.dll",
                "Microsoft.Azure.Management.Dns.dll",
                "Microsoft.Azure.Management.Dns.Fluent.dll",
                "Microsoft.Azure.Management.EventHub.Fluent.dll",
                "Microsoft.Azure.Management.Fluent.dll",
                "Microsoft.Azure.Management.Graph.RBAC.Fluent.dll",
                "Microsoft.Azure.Management.KeyVault.Fluent.dll",
                "Microsoft.Azure.Management.Locks.Fluent.dll",
                "Microsoft.Azure.Management.Monitor.Fluent.dll",
                "Microsoft.Azure.Management.Msi.Fluent.dll",
                "Microsoft.Azure.Management.Network.Fluent.dll",
                "Microsoft.Azure.Management.Redis.Fluent.dll",
                "Microsoft.Azure.Management.ResourceManager.Fluent.dll",
                "Microsoft.Azure.Management.Search.Fluent.dll",
                "Microsoft.Azure.Management.ServiceBus.Fluent.dll",
                "Microsoft.Azure.Management.Sql.Fluent.dll",
                "Microsoft.Azure.Management.Storage.dll",
                "Microsoft.Azure.Management.Storage.Fluent.dll",
                "Microsoft.Azure.Management.TrafficManager.Fluent.dll",
                "Microsoft.Azure.Relay.dll",
                "Microsoft.Azure.Services.AppAuthentication.dll",
                "Microsoft.Azure.Storage.Blob.dll",
                "Microsoft.Azure.Storage.Common.dll",
                "Microsoft.AzureAD.SmartSessionEvaluator.dll",
                "Microsoft.AzureAD.XtapLib.dll",
                "Microsoft.Bcl.AsyncInterfaces.dll",
                "Microsoft.Bing.Platform.DataModel.dll",
                "Microsoft.Bond.dll",
                "Microsoft.Bond.Interfaces.dll",
                "Microsoft.Bond.Rpc.dll",
                "Microsoft.Ceres.Common.Concurrent.dll",
                "Microsoft.Ceres.Common.IOBuffer.dll",
                "Microsoft.Ceres.Common.Utils.dll",
                "Microsoft.Ceres.Common.WcfUtils.dll",
                "Microsoft.Ceres.ContentEngine.Admin.dll",
                "Microsoft.Ceres.ContentEngine.AliasLookup.dll",
                "Microsoft.Ceres.ContentEngine.AnnotationPrimitives.dll",
                "Microsoft.Ceres.ContentEngine.Bundles.dll",
                "Microsoft.Ceres.ContentEngine.Component.dll",
                "Microsoft.Ceres.ContentEngine.DataModel.RecordSerializer.dll",
                "Microsoft.Ceres.ContentEngine.Fields.dll",
                "Microsoft.Ceres.ContentEngine.NlpEvaluators.dll",
                "Microsoft.Ceres.ContentEngine.NlpOperators.dll",
                "Microsoft.Ceres.ContentEngine.Operators.BuiltIn.dll",
                "Microsoft.Ceres.ContentEngine.Operators.dll",
                "Microsoft.Ceres.ContentEngine.Operators.External.dll",
                "Microsoft.Ceres.ContentEngine.Parsing.Component.dll",
                "Microsoft.Ceres.ContentEngine.Parsing.Evaluators.dll",
                "Microsoft.Ceres.ContentEngine.Parsing.Operators.dll",
                "Microsoft.Ceres.ContentEngine.Processing.BuiltIn.dll",
                "Microsoft.Ceres.ContentEngine.Processing.dll",
                "Microsoft.Ceres.ContentEngine.Processing.External.dll",
                "Microsoft.Ceres.ContentEngine.Properties.dll",
                "Microsoft.Ceres.ContentEngine.RecordCache.dll",
                "Microsoft.Ceres.ContentEngine.RecordType.dll",
                "Microsoft.Ceres.ContentEngine.Repository.dll",
                "Microsoft.Ceres.ContentEngine.SecurityUtil.dll",
                "Microsoft.Ceres.ContentEngine.Services.dll",
                "Microsoft.Ceres.ContentEngine.Types.dll",
                "Microsoft.Ceres.ContentEngine.Util.dll",
                "Microsoft.Ceres.CoreServices.Admin.dll",
                "Microsoft.Ceres.CoreServices.AdminService.dll",
                "Microsoft.Ceres.CoreServices.Clustering.dll",
                "Microsoft.Ceres.CoreServices.Configuration.dll",
                "Microsoft.Ceres.CoreServices.Constellation.dll",
                "Microsoft.Ceres.CoreServices.Framework.dll",
                "Microsoft.Ceres.CoreServices.HostController.dll",
                "Microsoft.Ceres.CoreServices.InternalServices.dll",
                "Microsoft.Ceres.CoreServices.Logging.dll",
                "Microsoft.Ceres.CoreServices.Node.dll",
                "Microsoft.Ceres.CoreServices.Remoting.dll",
                "Microsoft.Ceres.CoreServices.Services.dll",
                "Microsoft.Ceres.CoreServices.SystemManager.dll",
                "Microsoft.Ceres.CoreServices.Tools.Management.Client.dll",
                "Microsoft.Ceres.CoreServices.Transport.dll",
                "Microsoft.Ceres.CoreServices.Utils.dll",
                "Microsoft.Ceres.Diagnostics.dll",
                "Microsoft.Ceres.DocParsing.DocViz.dll",
                "Microsoft.Ceres.DocParsing.FormatHandlers.Common.Interop.dll",
                "Microsoft.Ceres.DocParsing.FormatHandlers.Filter.dll",
                "Microsoft.Ceres.DocParsing.Runtime.Client.dll",
                "Microsoft.Ceres.DocParsing.Runtime.Common.dll",
                "Microsoft.Ceres.DocParsing.Runtime.Core.dll",
                "Microsoft.Ceres.DocParsing.Runtime.FormatDetector.dll",
                "Microsoft.Ceres.DocParsing.Runtime.FormatHandler.dll",
                "Microsoft.Ceres.DocParsing.SandBox.dll",
                "Microsoft.Ceres.Evaluation.DataModel.dll",
                "Microsoft.Ceres.Evaluation.DataModel.Types.dll",
                "Microsoft.Ceres.Evaluation.Engine.dll",
                "Microsoft.Ceres.Evaluation.Operators.BuiltIn.dll",
                "Microsoft.Ceres.Evaluation.Operators.Core.dll",
                "Microsoft.Ceres.Evaluation.Operators.dll",
                "Microsoft.Ceres.Evaluation.Operators.Parsing.dll",
                "Microsoft.Ceres.Evaluation.Processing.BuiltIn.dll",
                "Microsoft.Ceres.Evaluation.Processing.dll",
                "Microsoft.Ceres.Evaluation.Services.dll",
                "Microsoft.Ceres.External.ContentApi.dll",
                "Microsoft.Ceres.External.ContentApi.GraphExtensions.dll",
                "Microsoft.Ceres.Flighting.dll",
                "Microsoft.Ceres.HostController.WcfClient.dll",
                "Microsoft.Ceres.HostController.WcfTypes.dll",
                "Microsoft.Ceres.InteractionEngine.Component.dll",
                "Microsoft.Ceres.InteractionEngine.DataModel.Fields.dll",
                "Microsoft.Ceres.InteractionEngine.DataModel.Types.dll",
                "Microsoft.Ceres.InteractionEngine.Operators.BuiltIn.dll",
                "Microsoft.Ceres.InteractionEngine.Processing.BuiltIn.dll",
                "Microsoft.Ceres.InteractionEngine.Services.dll",
                "Microsoft.Ceres.Monitoring.dll",
                "Microsoft.Ceres.NlpBase.AnnotationStore.dll",
                "Microsoft.Ceres.NlpBase.Automata.dll",
                "Microsoft.Ceres.NlpBase.Diagnostics.dll",
                "Microsoft.Ceres.NlpBase.Dictionaries.dll",
                "Microsoft.Ceres.NlpBase.DictionaryInterface.dll",
                "Microsoft.Ceres.NlpBase.Ese.Interop.dll",
                "Microsoft.Ceres.NlpBase.IndexTokenizer.dll",
                "Microsoft.Ceres.NlpBase.LanguageAndEncodingDetection.dll",
                "Microsoft.Ceres.NlpBase.Phonetic.dll",
                "Microsoft.Ceres.NlpBase.RichFields.dll",
                "Microsoft.Ceres.NlpBase.RichTypes.dll",
                "Microsoft.Ceres.NlpBase.StringDistance.dll",
                "Microsoft.Ceres.NlpBase.Transformers.dll",
                "Microsoft.Ceres.NlpBase.WordBreaker.dll",
                "Microsoft.Ceres.Platform.Parallax.dll",
                "Microsoft.Ceres.SearchCore.Admin.dll",
                "Microsoft.Ceres.SearchCore.Cheetah.dll",
                "Microsoft.Ceres.SearchCore.FastServer.DumpLib.Managed.dll",
                "Microsoft.Ceres.SearchCore.FastServer.Managed.dll",
                "Microsoft.Ceres.SearchCore.FastServerMessages.dll",
                "Microsoft.Ceres.SearchCore.FileTransfer.dll",
                "Microsoft.Ceres.SearchCore.GraphModel.dll",
                "Microsoft.Ceres.SearchCore.GraphQueryModel.dll",
                "Microsoft.Ceres.SearchCore.IndexController.dll",
                "Microsoft.Ceres.SearchCore.Indexes.AbstractIndex.dll",
                "Microsoft.Ceres.SearchCore.Indexes.FastServerIndex.dll",
                "Microsoft.Ceres.SearchCore.Query.MarsLookupComponent.dll",
                "Microsoft.Ceres.SearchCore.Search.dll",
                "Microsoft.Ceres.SearchCore.Seeding.dll",
                "Microsoft.Ceres.SearchCore.Services.dll",
                "Microsoft.Ceres.SearchCore.Tango.dll",
                "Microsoft.Ceres.SearchCore.Utils.dll",
                "Microsoft.Cloud.InstrumentationFramework.Events.dll",
                "Microsoft.Cloud.InstrumentationFramework.Metrics.dll",
                "Microsoft.Codex.CorrelatedInstrumentationFramework.dll",
                "Microsoft.CommonSchema.CorrelationVector.dll",
                "Microsoft.CookieCompliance.dll",
                "Microsoft.CookieCompliance.NetStd.dll",
                "Microsoft.Cosmos.Async.dll",
                "Microsoft.Cosmos.Client.dll",
                "Microsoft.Cosmos.Client.Interfaces.dll",
                "Microsoft.Cosmos.Common.dll",
                "Microsoft.Cosmos.dll",
                "Microsoft.Cosmos.ExportClient.dll",
                "Microsoft.Cosmos.FrontEnd.Common.dll",
                "Microsoft.Cosmos.FrontEnd.Contract.dll",
                "Microsoft.Cosmos.FrontEnd.InteractiveQuery.Client.dll",
                "Microsoft.Cosmos.FrontEnd.InteractiveQuery.Contract.dll",
                "Microsoft.Cosmos.FrontEnd.InteractiveQuery.Internal.Contract.dll",
                "Microsoft.Cosmos.FrontEnd.Internal.Client.dll",
                "Microsoft.Cosmos.FrontEnd.Namespace.dll",
                "Microsoft.Cosmos.FrontEnd.StreamSet.dll",
                "Microsoft.Cosmos.FrontEnd.WebService.Client.dll",
                "Microsoft.Cosmos.GeoRep.Manager.Contract.dll",
                "Microsoft.Cosmos.Native.dll",
                "Microsoft.Cosmos.Table.BajaSnapshot.Client.dll",
                "Microsoft.Cosmos.Table.BajaSnapshot.Contract.dll",
                "Microsoft.Cryptography.DKM.dll",
                "Microsoft.Cyber.Interfaces.dll",
                "Microsoft.Cyber.Libraries.dll",
                "Microsoft.Data.Edm.dll",
                "Microsoft.Data.OData.dll",
                "Microsoft.Data.Services.Client.dll",
                "Microsoft.Data.Services.Client.PowerShell.dll",
                "Microsoft.Data.Services.PowerShell.dll",
                "Microsoft.Datacenter.Substrate.ElevatedAccessDiscoveryClient.dll",
                "Microsoft.Datacenter.Substrate.Security.dll",
                "Microsoft.Datacenter.Substrate.ServiceProcess.dll",
                "Microsoft.Datacenter.Substrate.TenantLockboxSigner.Api.dll",
                "Microsoft.Datacenter.TenantLockbox.Core.dll",
                "Microsoft.Datacenter.TenantLockbox.dll",
                "Microsoft.DataClassification.Edm.Client.dll",
                "Microsoft.DataClassification.Edm.Server.Contract.dll",
                "Microsoft.Diagnostics.Runtime.dll",
                "Microsoft.Exchange.Auth.Common.dll",
                "Microsoft.Exchange.Auth.SAS.Clients.dll",
                "Microsoft.Exchange.Authentication.Basic.Client.dll",
                "Microsoft.Exchange.Authentication.Core.dll",
                "Microsoft.Exchange.Authorization.dll",
                "Microsoft.Exchange.Core.TimeZone.dll",
                "Microsoft.Exchange.Ipcommon.Csom.dll",
                "Microsoft.Exchange.KVCache.Client.dll",
                "Microsoft.Exchange.KVCache.Interface.dll",
                "Microsoft.Exchange.OAuth.Core.dll",
                "Microsoft.Exchange.OfficeGraph.SpoolsScaleOutMapper.dll",
                "Microsoft.Exchange.Relevance.Arthur.dll",
                "Microsoft.Exchange.Relevance.Arthur.Logging.dll",
                "Microsoft.Exchange.Relevance.Merlin.DSSM.dll",
                "Microsoft.Exchange.Relevance.Merlin.RankerRuntime.dll",
                "Microsoft.Exchange.Relevance.Merlin.RankerRuntime.Interface.dll",
                "Microsoft.Exchange.Relevance.Partners.Cortana.dll",
                "Microsoft.Exchange.Security.TokenIssuer.Client.dll",
                "Microsoft.Exchange.Security.TokenIssuer.Common.dll",
                "Microsoft.Exchange.Transport.Protocols.HttpSubmission.Contracts.dll",
                "Microsoft.Exchange.Transport.SubstrateBus.SubmissionClientLibrary.dll",
                "Microsoft.Exchange.VariantConfiguration.Core.dll",
                "Microsoft.Exchange.VariantConfiguration.ExCore.dll",
                "Microsoft.Extensions.Configuration.Abstractions.dll",
                "Microsoft.Extensions.DependencyInjection.Abstractions.dll",
                "Microsoft.Extensions.DependencyInjection.dll",
                "Microsoft.Extensions.Logging.Abstractions.dll",
                "Microsoft.Extensions.Logging.Console.dll",
                "Microsoft.Extensions.Logging.Debug.dll",
                "Microsoft.Extensions.Logging.dll",
                "Microsoft.Extensions.Primitives.dll",
                "Microsoft.Fast.DescriptiveMonitoring.Bootstrap.dll",
                "Microsoft.Fast.DescriptiveMonitoring.dll",
                "Microsoft.Fast.DescriptiveMonitoring.Three.dll",
                "Microsoft.Fast.SpoolsScaleOutTokenService.dll",
                "Microsoft.Flighting.Runtime.dll",
                "Microsoft.Grainlib.Common.dll",
                "Microsoft.Grainlib.Message.dll",
                "Microsoft.Grainlib.Message.Format.Mime.dll",
                "Microsoft.Grainlib.Message.Payload.Http.dll",
                "Microsoft.Grainlib.Message.Transformer.LockyLock.dll",
                "Microsoft.Graph.Core.dll",
                "Microsoft.Griffin.Assistant.Bond.dll",
                "Microsoft.Griffin.Common.Diagnostics.dll",
                "Microsoft.Griffin.HaaSCommon.dll",
                "Microsoft.Griffin.Sdk.Contracts.dll",
                "Microsoft.Griffin.Sdk.Diagnostics.dll",
                "Microsoft.Griffin.Sdk.Models.dll",
                "Microsoft.IC3.ServiceShared.IdentityTypes.dll",
                "Microsoft.IC3.ServiceShared.Security.Ale.BackgroundProcessing.dll",
                "Microsoft.IC3.ServiceShared.Security.Ale.CustomerKey.Client.dll",
                "Microsoft.IC3.ServiceShared.Security.Ale.dll",
                "Microsoft.IC3.ServiceShared.Security.Ale.KeyStorage.Cosmos.dll",
                "Microsoft.Identity.Client.dll",
                "Microsoft.IdentityModel.Clients.ActiveDirectory.dll",
                "Microsoft.IdentityModel.dll",
                "Microsoft.IdentityModel.Extensions.dll",
                "Microsoft.IdentityModel.Internal.Json.dll",
                "Microsoft.IdentityModel.JsonWebTokens.dll",
                "Microsoft.IdentityModel.Logging.dll",
                "Microsoft.IdentityModel.Protocols.dll",
                "Microsoft.IdentityModel.Protocols.OpenIdConnect.dll",
                "Microsoft.IdentityModel.Protocols.SignedHttpRequest.dll",
                "Microsoft.IdentityModel.Protocols.WsFederation.dll",
                "Microsoft.IdentityModel.S2S.Tokens.dll",
                "Microsoft.IdentityModel.Tokens.dll",
                "Microsoft.IdentityModel.Xml.dll",
                "Microsoft.Internal.Security.Cryptography.dll",
                "Microsoft.IO.RecyclableMemoryStream.dll",
                "Microsoft.LegacyWordBreaker.Office.dll",
                "Microsoft.Live.ExFxHelperCore.dll",
                "Microsoft.Live.ExFxHelperMain.dll",
                "Microsoft.Live.ExFxHelperSerializables.dll",
                "Microsoft.Live.Frontend.dll",
                "Microsoft.Live.Json.Signed.dll",
                "Microsoft.Live.Services.dll",
                "Microsoft.M365.CommonServices.dll",
                "Microsoft.M365.Core.ActivityContext.dll",
                "Microsoft.M365.Core.Address.dll",
                "Microsoft.M365.Core.Caches.dll",
                "Microsoft.M365.Core.ConfigurationSettings.dll",
                "Microsoft.M365.Core.Diagnostics.dll",
                "Microsoft.M365.Core.DiagnosticsLog.dll",
                "Microsoft.M365.Core.EventLog.dll",
                "Microsoft.M365.Core.GroupLinks.dll",
                "Microsoft.M365.Core.IdSerialization.dll",
                "Microsoft.M365.Core.Localization.dll",
                "Microsoft.M365.Core.MetricsTracker.dll",
                "Microsoft.M365.Core.Network.VariantConfiguration.dll",
                "Microsoft.M365.Core.NetworkAddress.dll",
                "Microsoft.M365.Core.Notification.dll",
                "Microsoft.M365.Core.PropertyDefinition.dll",
                "Microsoft.M365.Core.Security.dll",
                "Microsoft.M365.Core.Time.dll",
                "Microsoft.M365.Core.Utility.dll",
                "Microsoft.M365.Core.Xml.dll",
                "Microsoft.M365.Directory.Common.dll",
                "Microsoft.M365.Directory.Proxy.Client.dll",
                "Microsoft.M365.Directory.Proxy.Config.dll",
                "Microsoft.M365.Directory.Proxy.Discovery.dll",
                "Microsoft.M365.Directory.Proxy.Identity.dll",
                "Microsoft.M365.Directory.Proxy.Protocol.dll",
                "Microsoft.M365.Directory.Proxy.Routing.dll",
                "Microsoft.M365.EcsConfiguration.dll",
                "Microsoft.M365.Groups.Authorization.dll",
                "Microsoft.M365.Groups.Contracts.dll",
                "Microsoft.M365.Mailbox.Common.dll",
                "Microsoft.M365.SDDriver.dll",
                "Microsoft.M365.SDDriver.DSAPI.dll",
                "Microsoft.M365.SDDriver.Schema.dll",
                "Microsoft.M365.StoreObjects.Abstractions.dll",
                "Microsoft.M365.StoreObjects.Common.dll",
                "Microsoft.M365.StoreObjects.Configuration.dll",
                "Microsoft.M365.Transport.InternetProtocol.dll",
                "Microsoft.M365.VariantConfiguration.ECS.dll",
                "Microsoft.M365.Xtap.dll",
                "Microsoft.MachineLearning.Core.dll",
                "Microsoft.MachineLearning.FastTree.dll",
                "Microsoft.MachineLearning.Learners.dll",
                "Microsoft.MachineLearning.NeuralNetworks.Mkl.dll",
                "Microsoft.MachineLearning.NeuralNetworks.Sse.dll",
                "Microsoft.Management.OData.dll",
                "Microsoft.ML.OnnxRuntime.dll",
                "Microsoft.Net.Http.Headers.dll",
                "Microsoft.NLPFun.Core.dll",
                "Microsoft.O365.HtmlParser.AngleSharp.dll",
                "Microsoft.O365.UnifiedDlp.Server.Contract.dll",
                "Microsoft.OData.Client.dll",
                "Microsoft.OData.Core.dll",
                "Microsoft.OData.Edm.dll",
                "Microsoft.Office.BigData.Cosmos.Proxy.Client.dll",
                "Microsoft.Office.BigData.Cosmos.ProxyContract.dll",
                "Microsoft.Office.Client.Policy.dll",
                "Microsoft.Office.Datacenter.Configuration.dll",
                "Microsoft.Office.Datacenter.Deployment.SxS.ConfigEngine.dll",
                "Microsoft.Office.Datacenter.Deployment.SxS.ConfigOperations.dll",
                "Microsoft.Office.Datacenter.Deployment.SxS.SxSCommon.dll",
                "Microsoft.Office.Datacenter.Griffin.Interop.dll",
                "Microsoft.Office.Datacenter.Networking.AzureStorageClient.dll",
                "Microsoft.Office.Datacenter.PassiveMonitoring.dll",
                "Microsoft.Office.Datacenter.PassiveMonitoring.PIIScrubber.dll",
                "Microsoft.Office.Datacenter.PowerHarvestingStorageClient.dll",
                "Microsoft.Office.Datacenter.Security.RemotingClient.dll",
                "Microsoft.Office.Datacenter.Torus.API.dll",
                "Microsoft.Office.Datacenter.Torus.Common.dll",
                "Microsoft.Office.Datacenter.Torus.Common.Interfaces.dll",
                "Microsoft.Office.Datacenter.Torus.IdmSyncDataContract.dll",
                "Microsoft.Office.Datacenter.Torus.Interop.dll",
                "Microsoft.Office.Datacenter.Torus.KeyManagement.dll",
                "Microsoft.Office.Datacenter.Torus.VariantConfig.dll",
                "Microsoft.Office.Datacenter.WorkerTaskFrameworkInternalProvider.dll",
                "Microsoft.Office.LockBox.ObjectModel.dll",
                "Microsoft.Office.Server.Directory.dll",
                "Microsoft.Office.WorkerTaskFramework.Contracts.dll",
                "Microsoft.Online.SharePoint.Client.Tenant.dll",
                "Microsoft.Ops.Cvs.Client.dll",
                "Microsoft.Ops.NJsonApi.dll",
                "Microsoft.Owin.dll",
                "Microsoft.Owin.Hosting.dll",
                "Microsoft.Owin.Security.dll",
                "Microsoft.Pace.Analytics.dll",
                "Microsoft.Pace.dll",
                "Microsoft.Passport.RPS.dll",
                "Microsoft.Passport.RPS.Native.dll",
                "Microsoft.Pillar.Data.AccessProtection.dll",
                "Microsoft.PlatformBuilder.SqmBase.dll",
                "Microsoft.PowerShell.Commands.Utility.dll",
                "Microsoft.Practices.ObjectBuilder2.dll",
                "Microsoft.Practices.Unity.dll",
                "Microsoft.Reactive.dll",
                "Microsoft.Reactive.Expressions.Model.dll",
                "Microsoft.Reactive.Metadata.Model.dll",
                "Microsoft.Reactive.Model.dll",
                "Microsoft.Reactive.Scheduler.dll",
                "Microsoft.Reactive.Service.Model.dll",
                "Microsoft.Reactive.Shared.Core.dll",
                "Microsoft.Reactive.Shared.Model.dll",
                "Microsoft.Rest.ClientRuntime.Azure.Authentication.dll",
                "Microsoft.Rest.ClientRuntime.Azure.dll",
                "Microsoft.Rest.ClientRuntime.dll",
                "Microsoft.RightsManagementServices.Core.dll",
                "Microsoft.RightsManagementServices.Online.TpdConfigAuthor.dll",
                "Microsoft.Rtc.Client.Psom.ApplicationCore.dll",
                "Microsoft.Rtc.Client.Psom.Kernel.dll",
                "Microsoft.Rtc.Collaboration.dll",
                "Microsoft.Rtc.Internal.Media.dll",
                "Microsoft.Rtc.ServerConfiguration.dll",
                "Microsoft.Scope.CacheService.Client.dll",
                "Microsoft.Scope.Dependencies.Cosmos.dll",
                "Microsoft.Scope.Dependencies.dll",
                "Microsoft.Scope.Dependencies.SqlCore.dll",
                "Microsoft.Scope.Interfaces.dll",
                "Microsoft.Scope.ScopeInsight.Client.dll",
                "Microsoft.Scope.ScopeInsight.Contract.dll",
                "microsoft.search.autopilot.dll",
                "Microsoft.Search.ObjectStore.Client.dll",
                "Microsoft.Search.Platform.Parallax.dll",
                "Microsoft.ServiceBus.dll",
                "Microsoft.SharePoint.Client.dll",
                "Microsoft.SharePoint.Client.Runtime.dll",
                "Microsoft.SharePoint.Client.Search.dll",
                "Microsoft.SharePoint.Client.UserProfiles.dll",
                "Microsoft.SharePoint.KillSwitch.dll",
                "Microsoft.Skype.ECS.Client.AzureStorageCache.dll",
                "Microsoft.Skype.ECS.Client.dll",
                "Microsoft.Skype.ECS.Core.dll",
                "Microsoft.Skype.Seatbelt.Core.ClientHelpers.dll",
                "Microsoft.Skype.Seatbelt.Core.dll",
                "Microsoft.Sonar.Certificates.dll",
                "Microsoft.Sonar.Configuration.dll",
                "Microsoft.Sonar.Cryptography.dll",
                "Microsoft.Sonar.DataEntities.Cyber.dll",
                "Microsoft.Sonar.EopWorkflowClient.dll",
                "Microsoft.Sonar.FrontendClient.dll",
                "Microsoft.Sonar.Http.dll",
                "Microsoft.Sonar.KeyVault.dll",
                "Microsoft.Sonar.PerformanceCounter.dll",
                "Microsoft.Sonar.Security.Tokens.dll",
                "Microsoft.Sonar.Streaming.dll",
                "Microsoft.Sonar.Text.dll",
                "Microsoft.Sonar.Xml.dll",
                "Microsoft.Sonar.Zip.dll",
                "Microsoft.Spatial.dll",
                "Microsoft.Substrate.InferenceClient.Abstractions.dll",
                "Microsoft.Substrate.InferenceClient.dll",
                "Microsoft.Substrate.Polymer.Common.dll",
                "Microsoft.Substrate.Polymer.FeatureCatalog.dll",
                "Microsoft.Substrate.Polymer.Interaction.dll",
                "Microsoft.Substrate.Sds.Schema.Contracts.dll",
                "Microsoft.Substrate.Sds.Schema.Mapping.dll",
                "Microsoft.Threading.Tasks.dll",
                "Microsoft.VisualStudio.Threading.dll",
                "Microsoft.VisualStudio.Validation.dll",
                "Microsoft.WCD.FileMetadata.dll",
                "Microsoft.Web.Administration.dll",
                "Microsoft.WindowsAzure.Common.dll",
                "Microsoft.WindowsAzure.Common.NetFramework.dll",
                "Microsoft.WindowsAzure.Management.Storage.dll",
                "Microsoft.WindowsAzure.ServiceRuntime.dll",
                "Microsoft.WindowsAzure.Storage.dll",
                "Microsoft.WindowsFabric.Common.dll",
                "Microsoft.WindowsFabric.Data.Common.dll",
                "Microsoft.WordBreaker.Office.dll",
                "MimeKit.dll",
                "Mono.Data.Sqlite.dll",
                "MS.Msn.Runtime.whidbey.dll",
                "MS.qas.api.dll",
                "MS.qas.api.implementations.dll",
                "MS.qas.QASQueryRepresentationSchemas.dll",
                "MS.qcs.QASCommon.dll",
                "MSExchangeMigrationWorkflow.dll",
                "MsgPack.dll",
                "MSIPCConsoleLog.dll",
                "msshrtmi.dll",
                "MurmurHash.dll",
                "Nest.dll",
                "netstandard.dll",
                "Newtonsoft.Json.dll",
                "NLog.dll",
                "Npgsql.dll",
                "OnnxRuntime.Client.dll",
                "Optimizer.dll",
                "Owin.dll",
                "ParallelExtensionsExtras.dll",
                "PersonalDataPlatform.Common.dll",
                "Polly.dll",
                "PortableRanker.Common.dll",
                "PortableRanker.Interface.dll",
                "PortableRanker.Protocol.dll",
                "PortableRanker.Proxy.dll",
                "protobuf-net.dll",
                "Roslyn.Compilers.CSharp.dll",
                "Roslyn.Compilers.dll",
                "Scope.exe",
                "Scope.MetadataService.Client.dll",
                "ScopeCompiler.dll",
                "ScopeEngineManaged.dll",
                "scopeeventwriter.dll",
                "ScopeMetadataContract.dll",
                "ScopeRuntime.exe",
                "sharedaggregatorbondDotNet.dll",
                "SimpleInjector.dll",
                "SIPEPS.dll",
                "SiriusCommon.dll",
                "SmartScreen.Satchmo.dll",
                "SmartScreenXsd.dll",
                "Snappy.NET.dll",
                "SSLibEventWriter.dll",
                "SSLibExt.dll",
                "stdole.dll",
                "System.Buffers.dll",
                "System.Collections.Immutable.dll",
                "System.Configuration.ConfigurationManager.dll",
                "System.Console.dll",
                "System.Data.SQLite.dll",
                "System.Diagnostics.DiagnosticSource.dll",
                "System.IdentityModel.Tokens.Jwt.dll",
                "System.Interactive.dll",
                "System.IO.Abstractions.dll",
                "System.IO.FileSystem.AccessControl.dll",
                "System.Linq.CompilerServices.dll",
                "System.Memory.dll",
                "System.Net.Http.Formatting.dll",
                "System.Net.Http.WinHttpHandler.dll",
                "System.Numerics.Vectors.dll",
                "System.Reactive.dll",
                "System.Reflection.Metadata.dll",
                "System.Runtime.CompilerServices.Unsafe.dll",
                "System.Runtime.InteropServices.RuntimeInformation.dll",
                "System.Spatial.dll",
                "System.Text.Encodings.Web.dll",
                "System.Text.Json.dll",
                "System.Threading.AccessControl.dll",
                "System.Threading.Tasks.Dataflow.dll",
                "System.Threading.Tasks.Extensions.dll",
                "System.ValueTuple.dll",
                "System.Web.Http.dll",
                "System.Web.OData.dll",
                "Tlc.Instrumentation.dll",
                "TMSNlearnPrediction.dll",
                "TMSNStreams.dll",
                "TSS.Net.dll",
                "VcClient.dll",
                "Vectors.dll",
                "WordBreaker.dll",
                "WstClient.dll",
                "WstCommon.dll",
                "Xceed.Compression.v5.6.dll",
                "Xceed.FileSystem.v5.6.dll",
                "Xceed.Zip.v5.6.dll",
                "ZlibWrapper.dll",
            };

            var packages = new Dictionary<string, HashSet<string>>();

            var incompatibleDict = new Dictionary<string, List<string>>();

            foreach (var assembly in assemblies)
            {
                var detail = AssemblyDetails.RequestAsync(assembly, process: Process.MapiHttp).GetAwaiter().GetResult();
                var has = detail.Properties?.NugetInfo?.HasNetCoreVersion;
                if (!string.Equals("True", has))
                {
                    incompatibleDict.Add(assembly, detail.ReferencedIncompatibleAPIs);
                    var package = detail.PackageName;
                    if (packages.ContainsKey(package))
                        packages[package].Add(assembly);
                    else
                        packages.Add(package, new HashSet<string> { assembly });
                }
            }

            var json = new List<NugetModel>();
            foreach (var item in packages)
            {
                var name = item.Key;
                var children = item.Value.ToList()
                                         .OrderBy(c => c)
                                         .ToList()
                                         .Select(c => new DllModel(c, incompatibleDict[c]))
                                         .ToList();
                json.Add(new NugetModel(name, children));
            }

            var result = JsonSerializer.Serialize<List<NugetModel>>(json);

            FileUtils.WriteJson("Incompatible_Nugets", result);
        }
    }
}