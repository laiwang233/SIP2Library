namespace SIP2Client.Entities.Sip2Response;
public class BaseSip2Response
{
    public virtual ErrorCode Valid(Sip2Transaction sip2Transaction)
    {
        //验证操作是否成功
        if (sip2Transaction.Field.ContainsKey("AF"))
        {
            if (sip2Transaction.Field["AF"].Contains("成功"))
            {
                return ErrorCode.Success;
            }
        }

        return ErrorCode.Failed;
    }
}
