// Copyright 2004-2009 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.Components.Validator
{
	/// <summary>
	/// Validates that the content is not set to the specified value
	/// </summary>
	public class NotSameValueValidator : AbstractValidator
	{
		private readonly object value;

		/// <summary>
		/// Initializes a new instance of the <see cref="SameAsValidator"/> class.
		/// </summary>
		public NotSameValueValidator(object value)
		{
			this.value = value;
		}

		/// <summary>
		/// Validates that the <c>fieldValue</c>
		/// is not set to the specified value 
		/// </summary>
		/// <param name="instance">The target type instance</param>
		/// <param name="fieldValue">The property/field value. It can be null.</param>
		/// <returns>
		/// 	<c>true</c> if the value is accepted (has passed the validation test)
		/// </returns>
		public override bool IsValid(object instance, object fieldValue)
		{
			return Equals(value, fieldValue) == false;
		}

		/// <summary>
		/// Gets a value indicating whether this validator supports browser validation.
		/// </summary>
		/// <value>
		/// 	<see langword="true"/> if browser validation is supported; otherwise, <see langword="false"/>.
		/// </value>
		public override bool SupportsBrowserValidation
		{
			get { return false; }
		}

		/// <summary>
		/// Returns the key used to internationalize error messages
		/// </summary>
		/// <value></value>
		protected override string MessageKey
		{
			get { return MessageConstants.NotSameValueMessage; }
		}

		/// <summary>
		/// Builds the error message.
		/// </summary>
		/// <returns></returns>
		protected override string BuildErrorMessage()
		{
			return string.Format(GetString(MessageConstants.NotSameValueMessage), value);
		}
	}
}
