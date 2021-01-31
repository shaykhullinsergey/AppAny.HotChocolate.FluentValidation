using HotChocolate.Types;

namespace AppAny.HotChocolate.FluentValidation.Tests
{
	public class TestCustomAttributeMutation : ObjectType
	{
		protected override void Configure(IObjectTypeDescriptor descriptor)
		{
			descriptor.Field<TestCustomAttributeMutation>(field => field.Test(default!)).Type<StringType>();
		}

		public string Test([UseFluentValidation(typeof(NotEmptyNameValidator))] TestPersonInput input)
		{
			return "test";
		}
	}
}
