/* SPDX-License-Identifier: Apache-2.0
*
* The OpenSearch Contributors require contributions made to
* this file be licensed under the Apache-2.0 license or a
* compatible open source license.
*/
/*
* Modifications Copyright OpenSearch Contributors. See
* GitHub history for details.
*
*  Licensed to Elasticsearch B.V. under one or more contributor
*  license agreements. See the NOTICE file distributed with
*  this work for additional information regarding copyright
*  ownership. Elasticsearch B.V. licenses this file to you under
*  the Apache License, Version 2.0 (the "License"); you may
*  not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
* 	http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing,
*  software distributed under the License is distributed on an
*  "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
*  KIND, either express or implied.  See the License for the
*  specific language governing permissions and limitations
*  under the License.
*/

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using OpenSearch.Net.Utf8Json;

namespace OpenSearch.Client.Specification.IngestApi
{
	/// <summary> Ingest pipelines are composed of one or more processors </summary>
	[InterfaceDataContract]
	[JsonFormatter(typeof(ProcessorFormatter))]
	public interface IProcessor
	{
		/// <summary> The name of the processor, will be used as the key when persisting the processor on the pipeline </summary>
		[IgnoreDataMember]
		string Name { get; }

		/// <summary>
		/// A description to explain the purpose of the specific processor instance.
		/// </summary>
		[DataMember(Name = "description")]
		string Description { get; set; }

		/// <summary>
		/// If a processor fails, call these processors instead. Read more about handling failures here:
		///
		/// </summary>
		[DataMember(Name ="on_failure")]
		IEnumerable<IProcessor> OnFailure { get; set; }

		/// <summary> A painless script predicate that can control whether this processor should be executed or not </summary>
		[DataMember(Name = "if")]
		string If { get; set; }

		/// <summary>
		/// A tag is simply a string identifier of the specific instantiation of a certain processor
		/// in a pipeline. The tag field does not affect the processor’s behavior, but is very useful
		/// for bookkeeping and tracing errors to specific processors.
		/// </summary>
		[DataMember(Name = "tag")]
		string Tag { get; set; }

		/// <summary> When a failure happens, ignore it and proceed to the next processor </summary>
		[DataMember(Name = "ignore_failure")]
		bool? IgnoreFailure { get; set; }
	}

	/// <inheritdoc cref="IProcessor"/>
	public abstract class ProcessorBase : IProcessor
	{
		/// <inheritdoc cref="IProcessor.If"/>
		public string If { get; set; }
		/// <inheritdoc cref="IProcessor.Tag"/>
		public string Tag { get; set; }
		/// <inheritdoc cref="IProcessor.IgnoreFailure"/>
		public bool? IgnoreFailure { get; set; }
		/// <inheritdoc cref="IProcessor.OnFailure"/>
		public IEnumerable<IProcessor> OnFailure { get; set; }
		protected abstract string Name { get; }
		/// <inheritdoc cref="IProcessor.Description"/>
		public string Description { get; set; }

		string IProcessor.Name => Name;
	}

	/// <inheritdoc cref="IProcessor"/>
	public abstract class ProcessorDescriptorBase<TProcessorDescriptor, TProcessorInterface>
		: DescriptorBase<TProcessorDescriptor, TProcessorInterface>, IProcessor
		where TProcessorDescriptor : ProcessorDescriptorBase<TProcessorDescriptor, TProcessorInterface>, TProcessorInterface
		where TProcessorInterface : class, IProcessor
	{
		protected abstract string Name { get; }
		string IProcessor.Name => Name;
		string IProcessor.Description { get; set; }
		IEnumerable<IProcessor> IProcessor.OnFailure { get; set; }
		string IProcessor.If { get; set; }
		string IProcessor.Tag { get; set; }
		bool? IProcessor.IgnoreFailure { get; set; }

		/// <inheritdoc cref="IProcessor.Description"/>
		public TProcessorDescriptor Description(string description) => Assign(description, (a, v) => a.Description = v);

		/// <inheritdoc cref="IProcessor.OnFailure"/>
		public TProcessorDescriptor OnFailure(IEnumerable<IProcessor> processors) => Assign(processors.ToListOrNullIfEmpty(), (a, v) => a.OnFailure = v);

		/// <inheritdoc cref="IProcessor.OnFailure"/>
		public TProcessorDescriptor OnFailure(Func<ProcessorsDescriptor, IPromise<IList<IProcessor>>> selector) =>
			Assign(selector, (a, v) => a.OnFailure = v?.Invoke(new ProcessorsDescriptor())?.Value);

		/// <inheritdoc cref="IProcessor.If"/>
		public TProcessorDescriptor If(string painlessPredicate) => Assign(painlessPredicate, (a, v) => a.If = v);

		/// <inheritdoc cref="IProcessor.Tag"/>
		public TProcessorDescriptor Tag(string tag) => Assign(tag, (a, v) => a.Tag = v);

		/// <inheritdoc cref="IProcessor.IgnoreFailure"/>
		public TProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailure = v);

	}

}
