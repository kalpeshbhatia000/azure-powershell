// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support
{

    /// <summary>
    /// The data format of the message. Optionally the data format can be added to each message.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.Synapse.Support.EventGridDataFormatTypeConverter))]
    public partial struct EventGridDataFormat :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "MULTIJSON".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("MULTIJSON", "MULTIJSON", global::System.Management.Automation.CompletionResultType.ParameterValue, "MULTIJSON");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "JSON".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("JSON", "JSON", global::System.Management.Automation.CompletionResultType.ParameterValue, "JSON");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CSV".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("CSV", "CSV", global::System.Management.Automation.CompletionResultType.ParameterValue, "CSV");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TSV".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("TSV", "TSV", global::System.Management.Automation.CompletionResultType.ParameterValue, "TSV");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SCSV".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SCSV", "SCSV", global::System.Management.Automation.CompletionResultType.ParameterValue, "SCSV");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SOHSV".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SOHSV", "SOHSV", global::System.Management.Automation.CompletionResultType.ParameterValue, "SOHSV");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PSV".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("PSV", "PSV", global::System.Management.Automation.CompletionResultType.ParameterValue, "PSV");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TXT".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("TXT", "TXT", global::System.Management.Automation.CompletionResultType.ParameterValue, "TXT");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "RAW".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("RAW", "RAW", global::System.Management.Automation.CompletionResultType.ParameterValue, "RAW");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "SINGLEJSON".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("SINGLEJSON", "SINGLEJSON", global::System.Management.Automation.CompletionResultType.ParameterValue, "SINGLEJSON");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "AVRO".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("AVRO", "AVRO", global::System.Management.Automation.CompletionResultType.ParameterValue, "AVRO");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "TSVE".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("TSVE", "TSVE", global::System.Management.Automation.CompletionResultType.ParameterValue, "TSVE");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PARQUET".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("PARQUET", "PARQUET", global::System.Management.Automation.CompletionResultType.ParameterValue, "PARQUET");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ORC".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("ORC", "ORC", global::System.Management.Automation.CompletionResultType.ParameterValue, "ORC");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "APACHEAVRO".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("APACHEAVRO", "APACHEAVRO", global::System.Management.Automation.CompletionResultType.ParameterValue, "APACHEAVRO");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "W3CLOGFILE".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("W3CLOGFILE", "W3CLOGFILE", global::System.Management.Automation.CompletionResultType.ParameterValue, "W3CLOGFILE");
            }
        }
    }
}