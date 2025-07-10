using Badaczek.Identity.Web.Resources;

using Microsoft.AspNetCore.Identity;

namespace Badaczek.Identity.Web
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = nameof(DefaultError),
                Description = SharedResources.Identity_DefaultError
            };
        }

        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError
            {
                Code = nameof(ConcurrencyFailure),
                Description = SharedResources.Identity_ConcurrencyFailure
            };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = SharedResources.Identity_PasswordMismatch
            };
        }

        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = nameof(InvalidToken),
                Description = SharedResources.Identity_InvalidToken
            };
        }

        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError
            {
                Code = nameof(RecoveryCodeRedemptionFailed),
                Description = SharedResources.Identity_RecoveryCodeRedemptionFailed
            };
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError
            {
                Code = nameof(LoginAlreadyAssociated),
                Description = SharedResources.Identity_LoginAlreadyAssociated
            };
        }

        //jutro pododaję następne. Starczy.
    }
}