// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    //[Cmdlet(VerbsLifecycle.Invoke, "AzureComputeMethod", DefaultParameterSetName = "InvokeByDynamicParameters")]
    [OutputType(typeof(object))]
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet, IDynamicParameters
    {
        protected RuntimeDefinedParameterDictionary dynamicParameters;
        protected object[] argumentList;

        protected static object[] ConvertDynamicParameters(RuntimeDefinedParameterDictionary parameters)
        {
            List<object> paramList = new List<object>();

            foreach (var param in parameters)
            {
                paramList.Add(param.Value.Value);
            }

            return paramList.ToArray();
        }

        [Parameter(Mandatory = true, ParameterSetName = "InvokeByDynamicParameters", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "InvokeByStaticParameters", Position = 0)]
        [ValidateSet(
            "ContainerServiceCreateOrUpdate",
            "ContainerServiceDelete",
            "ContainerServiceGet",
            "ContainerServiceList",
            "VirtualMachineScaleSetCreateOrUpdate",
            "VirtualMachineScaleSetDeallocate",
            "VirtualMachineScaleSetDelete",
            "VirtualMachineScaleSetDeleteInstances",
            "VirtualMachineScaleSetGet",
            "VirtualMachineScaleSetGetInstanceView",
            "VirtualMachineScaleSetList",
            "VirtualMachineScaleSetListAll",
            "VirtualMachineScaleSetListAllNext",
            "VirtualMachineScaleSetListNext",
            "VirtualMachineScaleSetListSkus",
            "VirtualMachineScaleSetListSkusNext",
            "VirtualMachineScaleSetPowerOff",
            "VirtualMachineScaleSetReimage",
            "VirtualMachineScaleSetRestart",
            "VirtualMachineScaleSetStart",
            "VirtualMachineScaleSetUpdateInstances",
            "VirtualMachineScaleSetVMDeallocate",
            "VirtualMachineScaleSetVMDelete",
            "VirtualMachineScaleSetVMGet",
            "VirtualMachineScaleSetVMGetInstanceView",
            "VirtualMachineScaleSetVMList",
            "VirtualMachineScaleSetVMListNext",
            "VirtualMachineScaleSetVMPowerOff",
            "VirtualMachineScaleSetVMReimage",
            "VirtualMachineScaleSetVMRestart",
            "VirtualMachineScaleSetVMStart"
        )]
        public virtual string MethodName { get; set; }

        protected object ParseParameter(object input)
        {
            if (input is PSObject)
            {
                return (input as PSObject).BaseObject;
            }
            else
            {
                return input;
            }
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ExecuteClientAction(() =>
            {
                if (ParameterSetName.StartsWith("InvokeByDynamicParameters"))
                {
                    argumentList = ConvertDynamicParameters(dynamicParameters);
                }
                else
                {
                    argumentList = ConvertFromArgumentsToObjects((object[])dynamicParameters["ArgumentList"].Value);
                }

                switch (MethodName)
                {
                    case "ContainerServiceCreateOrUpdate":
                        ExecuteContainerServiceCreateOrUpdateMethod(argumentList);
                        break;
                    case "ContainerServiceDelete":
                        ExecuteContainerServiceDeleteMethod(argumentList);
                        break;
                    case "ContainerServiceGet":
                        ExecuteContainerServiceGetMethod(argumentList);
                        break;
                    case "ContainerServiceList":
                        ExecuteContainerServiceListMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetCreateOrUpdate":
                        ExecuteVirtualMachineScaleSetCreateOrUpdateMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetDeallocate":
                        ExecuteVirtualMachineScaleSetDeallocateMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetDelete":
                        ExecuteVirtualMachineScaleSetDeleteMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetDeleteInstances":
                        ExecuteVirtualMachineScaleSetDeleteInstancesMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetGet":
                        ExecuteVirtualMachineScaleSetGetMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetGetInstanceView":
                        ExecuteVirtualMachineScaleSetGetInstanceViewMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetList":
                        ExecuteVirtualMachineScaleSetListMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListAll":
                        ExecuteVirtualMachineScaleSetListAllMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListAllNext":
                        ExecuteVirtualMachineScaleSetListAllNextMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListNext":
                        ExecuteVirtualMachineScaleSetListNextMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListSkus":
                        ExecuteVirtualMachineScaleSetListSkusMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetListSkusNext":
                        ExecuteVirtualMachineScaleSetListSkusNextMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetPowerOff":
                        ExecuteVirtualMachineScaleSetPowerOffMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetReimage":
                        ExecuteVirtualMachineScaleSetReimageMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetRestart":
                        ExecuteVirtualMachineScaleSetRestartMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetStart":
                        ExecuteVirtualMachineScaleSetStartMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetUpdateInstances":
                        ExecuteVirtualMachineScaleSetUpdateInstancesMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMDeallocate":
                        ExecuteVirtualMachineScaleSetVMDeallocateMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMDelete":
                        ExecuteVirtualMachineScaleSetVMDeleteMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMGet":
                        ExecuteVirtualMachineScaleSetVMGetMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMGetInstanceView":
                        ExecuteVirtualMachineScaleSetVMGetInstanceViewMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMList":
                        ExecuteVirtualMachineScaleSetVMListMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMListNext":
                        ExecuteVirtualMachineScaleSetVMListNextMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMPowerOff":
                        ExecuteVirtualMachineScaleSetVMPowerOffMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMReimage":
                        ExecuteVirtualMachineScaleSetVMReimageMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMRestart":
                        ExecuteVirtualMachineScaleSetVMRestartMethod(argumentList);
                        break;
                    case "VirtualMachineScaleSetVMStart":
                        ExecuteVirtualMachineScaleSetVMStartMethod(argumentList);
                        break;
                    default: WriteWarning("Cannot find the method by name = '" + MethodName + "'."); break;
                }
            });
        }


        public virtual object GetDynamicParameters()
        {
            switch (MethodName)
            {
                case "ContainerServiceCreateOrUpdate": return CreateContainerServiceCreateOrUpdateDynamicParameters();
                case "ContainerServiceDelete": return CreateContainerServiceDeleteDynamicParameters();
                case "ContainerServiceGet": return CreateContainerServiceGetDynamicParameters();
                case "ContainerServiceList": return CreateContainerServiceListDynamicParameters();
                case "VirtualMachineScaleSetCreateOrUpdate": return CreateVirtualMachineScaleSetCreateOrUpdateDynamicParameters();
                case "VirtualMachineScaleSetDeallocate": return CreateVirtualMachineScaleSetDeallocateDynamicParameters();
                case "VirtualMachineScaleSetDelete": return CreateVirtualMachineScaleSetDeleteDynamicParameters();
                case "VirtualMachineScaleSetDeleteInstances": return CreateVirtualMachineScaleSetDeleteInstancesDynamicParameters();
                case "VirtualMachineScaleSetGet": return CreateVirtualMachineScaleSetGetDynamicParameters();
                case "VirtualMachineScaleSetGetInstanceView": return CreateVirtualMachineScaleSetGetInstanceViewDynamicParameters();
                case "VirtualMachineScaleSetList": return CreateVirtualMachineScaleSetListDynamicParameters();
                case "VirtualMachineScaleSetListAll": return CreateVirtualMachineScaleSetListAllDynamicParameters();
                case "VirtualMachineScaleSetListAllNext": return CreateVirtualMachineScaleSetListAllNextDynamicParameters();
                case "VirtualMachineScaleSetListNext": return CreateVirtualMachineScaleSetListNextDynamicParameters();
                case "VirtualMachineScaleSetListSkus": return CreateVirtualMachineScaleSetListSkusDynamicParameters();
                case "VirtualMachineScaleSetListSkusNext": return CreateVirtualMachineScaleSetListSkusNextDynamicParameters();
                case "VirtualMachineScaleSetPowerOff": return CreateVirtualMachineScaleSetPowerOffDynamicParameters();
                case "VirtualMachineScaleSetReimage": return CreateVirtualMachineScaleSetReimageDynamicParameters();
                case "VirtualMachineScaleSetRestart": return CreateVirtualMachineScaleSetRestartDynamicParameters();
                case "VirtualMachineScaleSetStart": return CreateVirtualMachineScaleSetStartDynamicParameters();
                case "VirtualMachineScaleSetUpdateInstances": return CreateVirtualMachineScaleSetUpdateInstancesDynamicParameters();
                case "VirtualMachineScaleSetVMDeallocate": return CreateVirtualMachineScaleSetVMDeallocateDynamicParameters();
                case "VirtualMachineScaleSetVMDelete": return CreateVirtualMachineScaleSetVMDeleteDynamicParameters();
                case "VirtualMachineScaleSetVMGet": return CreateVirtualMachineScaleSetVMGetDynamicParameters();
                case "VirtualMachineScaleSetVMGetInstanceView": return CreateVirtualMachineScaleSetVMGetInstanceViewDynamicParameters();
                case "VirtualMachineScaleSetVMList": return CreateVirtualMachineScaleSetVMListDynamicParameters();
                case "VirtualMachineScaleSetVMListNext": return CreateVirtualMachineScaleSetVMListNextDynamicParameters();
                case "VirtualMachineScaleSetVMPowerOff": return CreateVirtualMachineScaleSetVMPowerOffDynamicParameters();
                case "VirtualMachineScaleSetVMReimage": return CreateVirtualMachineScaleSetVMReimageDynamicParameters();
                case "VirtualMachineScaleSetVMRestart": return CreateVirtualMachineScaleSetVMRestartDynamicParameters();
                case "VirtualMachineScaleSetVMStart": return CreateVirtualMachineScaleSetVMStartDynamicParameters();
                default: break;
            }

            return null;
        }

    }
}
