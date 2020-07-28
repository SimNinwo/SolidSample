using System;

namespace ArdalisRating
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, IRatingContext context)
        {
            try
            {
                //**Using Reflection to instantiate * **//

                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRating.{policy.Type}PolicyRater"),
                    new object[] { new RatingUpdater(context.Engine) });
            }
            catch
            {
                return new UnknownPolicyRater(new RatingUpdater(context.Engine));
            }

        }
    }
}
