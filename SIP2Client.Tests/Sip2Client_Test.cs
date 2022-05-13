using SIP2Client.Codes;
using SIP2Client.Entities;
using SIP2Client.Entities.Sip2Request;
using SIP2Client.Entities.Sip2Response;
using Xunit;

namespace SIP2Client.Tests;

public class Sip2Client_Test
{
    #region 通用数据

    private Sip2Client sip2Connect { get; set; } = new();
    /// <summary>
    /// 读者条码
    /// </summary>
    private string readerCode { get; set; } = "431000213972";
    /// <summary>
    /// 图书条码
    /// </summary>
    private string bookCode { get; set; } = "431202540693";

    private string AO = "";

    private void Init()
    {
        sip2Connect.Init(new Sip2Model() { Ip = "192.168.0.100", Port = "6789", Encoding = "gbk" });
    }

    #endregion



    /// <summary>
    /// 登录
    /// </summary>
    [Fact]
    public void Login_Test()
    {
        Init();

        Sip2Result<Sip2LoginResponse> result = sip2Connect.GetResult<Sip2LoginResponse, Sip2LoginRequest>(new Sip2LoginRequest()
        {
            Sip2UserName = "ACS01",
            Sip2Password = "Acs123456",
            LocationCode = "1"
        });
    }

    /// <summary>
    /// 查询图书信息
    /// </summary>
    [Fact]
    public void GetBookInfo_Test()
    {
        Init();

        Sip2Result<Sip2BookResponse> result = sip2Connect.GetResult<Sip2BookResponse, Sip2BookRequest>(new Sip2BookRequest()
        {
            BookBarcode = bookCode
        });
      
    }

    /// <summary>
    /// 查询读者信息
    /// </summary>
    [Fact]
    public void GetReaderInfo_Test()
    {
        Init();

        Sip2ReaderRequest readerSend = new Sip2ReaderRequest()
        {
            Language = "001",
            TransactionDate = DateTime.Now.ToSipString(),
            Summary = Sip2TestExtensions.Summary["none"],
            InstitutionId = AO,
            ReaderBarcode = "TEST009",
            ReaderPin = "123",
            BP = "1",
            BQ = "5"
        };

        Sip2Result<Sip2ReaderResponse> result = sip2Connect.GetResult<Sip2ReaderResponse, Sip2ReaderRequest>(readerSend);

    }

    /// <summary>
    /// 借书
    /// </summary>
    [Fact]
    public void BookCheckOut_Test()
    {
        Init();

        Sip2Result<Sip2LendBookResponse> result = sip2Connect.GetResult<Sip2LendBookResponse, Sip2LendBookRequest>(new Sip2LendBookRequest()
        {
            InstitutionId = AO,
            ReaderIdentifier = "TEST011",
            BookIdentifier = bookCode,
            ReaderPassword = "11231231231312",
            NbDueDate = DateTime.Now.AddDays(3).ToSipString()
        });
    }

    /// <summary>
    /// 还书
    /// </summary>
    [Fact]
    public void BookCheckIn_Test()
    {
        Init();

        Sip2Result<Sip2ReturnBookResponse> result = sip2Connect.GetResult<Sip2ReturnBookResponse, Sip2ReturnBookRequest>(new Sip2ReturnBookRequest()
        {
            InstitutionId = AO,
            BookIdentifier = bookCode
        });
    }

    /// <summary>
    /// 续借
    /// </summary>
    [Fact]
    public void ReNew_Test()
    {
        Init();

        Sip2Result<Sip2ReNewResponse> result = sip2Connect.GetResult<Sip2ReNewResponse, Sip2ReNewRequest>(new Sip2ReNewRequest()
        {
            InstitutionId = AO,
            ReaderIdentifier = readerCode,
            BookIdentifier = bookCode,
            NbDueDate = DateTime.Now.ToSipString()
        });
    }

    /// <summary>
    /// 欠费缴纳
    /// </summary>
    [Fact]
    public void FeePaidOpen_Test()
    {
        Init();

        Sip2Result<Sip2FeePaidResponse> result = sip2Connect.GetResult<Sip2FeePaidResponse, Sip2FeePaidRequest>(new Sip2FeePaidRequest()
        {
            Amount = "10000",
            InstitutionId = AO,
            ReaderIdentifier = readerCode,
            ReaderPassword = "123"
        });
    }

    /// <summary>
    /// 修改读者密码
    /// </summary>
    [Fact]
    public void ChangeReaderPwd_Test()
    {
        Init();

            Sip2Result<Sip2ChangeReaderPwdResponse> result = sip2Connect.GetResult<Sip2ChangeReaderPwdResponse, Sip2ChangeReaderPwdRequest>(new Sip2ChangeReaderPwdRequest()
        {
            ReaderIdentifier = readerCode,
            ReaderPassword = "",
            NewReaderPassword = ""
        });
    }

    /// <summary>
    /// 图书信息更新
    /// </summary>
    [Fact]
    public void ChangeBookInfo_Test()
    {
        Init();

        Sip2Result<Sip2ChangeBookResponse> result = sip2Connect.GetResult<Sip2ChangeBookResponse, Sip2ChangeBookRequest>(new Sip2ChangeBookRequest()
        {
            InstitutionId = AO,
            BookIdentifier = bookCode,
            UpdateField = "",
            FieldValue = ""
        });
    }

    /// <summary>
    /// 读者证号/身份证号查重
    /// </summary>
    [Fact]
    public void ReaderIdVerification_Test()
    {
        Init();
        Sip2Result<Sip2ReaderIdVerificationResponse> result = sip2Connect.GetResult<Sip2ReaderIdVerificationResponse, Sip2ReaderIdVerificationRequest>(new Sip2ReaderIdVerificationRequest()
        {
            ReaderIdentifier = readerCode+"131212312212132131313",
            InstitutionId = AO,
            VerificationMethod = "0"
        });
    }

    /// <summary>
    /// 读者注册
    /// </summary>
    [Fact]
    public void ReaderRegister_Test()
    {
        Init();

        Sip2Result<Sip2ReaderRegisterResponse> result = sip2Connect.GetResult<Sip2ReaderRegisterResponse, Sip2ReaderRegisterRequest>(new Sip2ReaderRegisterRequest()
        {
            InstitutionId = AO,
            ReaderIdentifier = "TEST011",
            ReaderPassword = "123",
            ReaderName = "测试2333",
            ReaderOpenAccountLibrary = AO,
            CertificateDeposit = "1000",
            DateOfBirth = DateTime.Now.ToString("yyyyMMdd"),
            OperationMode = "01",
            ReaderEffectiveDate = DateTime.Now.AddDays(3).ToString("yyyyMMdd"),
            ReaderType = "读者"
        });
    }

}