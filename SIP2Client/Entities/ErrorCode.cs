using System.ComponentModel;

namespace SIP2Client.Entities;

/// <summary>
/// 错误码
/// </summary>
public enum ErrorCode
{
    /// <summary>
    /// 成功
    /// </summary>
    [Description("成功")]
    Success = 0,
    /// <summary>
    /// 失败
    /// </summary>
    [Description("失败")]
    Failed = 10001,
    /// <summary>
    /// 无效信息
    /// </summary>
    [Description("无效信息")]
    InvalidMessage = 10003,
    /// <summary>
    /// 服务器异常
    /// </summary>
    [Description("服务器异常")]
    ServerException = 10017,
    /// <summary>
    /// 无效参数
    /// </summary>
    [Description("无效参数")]
    InvalidParameter = 10018,
    /// <summary>
    /// 随机码重复
    /// </summary>
    [Description("随机码重复")]
    RandomCodeRepeated = 10019,
    /// <summary>
    /// 校验失败
    /// </summary>
    [Description("校验失败")]
    VerifyFailed = 10020,
    /// <summary>
    /// 设备未注册
    /// </summary>
    [Description("设备未注册")]
    DeviceUnregister = 10021,
    /// <summary>
    /// token已过期
    /// </summary>
    [Description("token已过期")]
    TokenExpired = 10022,
    /// <summary>
    /// token无效
    /// </summary>
    [Description("token无效")]
    InvalidToken = 10023,
    /// <summary>
    /// 记录已存在
    /// </summary>
    [Description("记录已存在")]
    RecordIsExisted = 10024,
    /// <summary>
    /// 请求数据中未发现Token
    /// </summary>
    [Description("请求数据中未发现Token")]
    NotFoundToken = 10025,
    /// <summary>
    /// 用户名不存在
    /// </summary>
    [Description("用户名不存在")]
    UserNameNotExist = 10026,
    /// <summary>
    /// 用户名已存在
    /// </summary>
    [Description("用户名已存在")]
    UserNameIsExist = 10027,
    /// <summary>
    /// 密码错误
    /// </summary>
    [Description("密码错误")]
    PasswordIsWrong = 10028,
    /// <summary>
    /// 动态验证码错误
    /// </summary>
    [Description("动态验证码错误")]
    SecurityCodeIsWrong = 10029,
    /// <summary>
    /// 请求数据中未发现UID
    /// </summary>
    [Description("请求数据中未发现UID")]
    NotFoundUId = 10030,
    /// <summary>
    /// 校验Token失败，服务器端未获取到Token，可能由于用户未登录或者服务器端数据库故障导致
    /// </summary>
    [Description("校验Token失败，服务器端未获取到Token，可能由于用户未登录或者服务器端数据库故障导致")]
    VerifyTokenFailed = 10031,
    /// <summary>
    /// 用户名已存在
    /// </summary>
    [Description("用户名已存在")]
    UserIDExist = 10032,
    /// <summary>
    /// 手机号已存在
    /// </summary>
    [Description("手机号已存在")]
    PhoneExist = 10033,
    /// <summary>
    /// 昵称已存在
    /// </summary>
    [Description("昵称已存在")]
    NicknameExist = 10034,
    /// <summary>
    /// 邮箱地址已存在
    /// </summary>
    [Description("邮箱地址已存在")]
    EmailExist = 10035,
    /// <summary>
    /// 密码为空
    /// </summary>
    [Description("密码为空")]
    PasswordIsEmpty = 10036,
    /// <summary>
    /// 记录不存在
    /// </summary>
    [Description("记录不存在")]
    RecordNotExist = 10037,
    /// <summary>
    /// 用户已被删除
    /// </summary>
    [Description("用户已被删除")]
    UserIsDeleted = 10038,
    /// <summary>
    /// 功能尚未实现
    /// </summary>
    [Description("功能尚未实现")]
    FunctionNotImplemented = 10039,
    /// <summary>
    /// 书籍绑定成功但是与图书馆数据同步未成功,可能导致数据信息不完整
    /// </summary>
    [Description("书籍绑定成功但是与图书馆数据同步未成功,可能导致数据信息不完整")]
    BindBookOkButNotUpdate = 10040,
    /// <summary>
    /// 图书信息更新失败
    /// </summary>
    [Description("图书信息更新失败")]
    UpdateBookFromLibraryFailed = 10041,
    /// <summary>
    /// 无法获取有效的密码信息
    /// </summary>
    [Description("无法获取有效的密码信息")]
    CanNotGetPlainPassword = 10042,
    /// <summary>
    /// 连接ActiveMQ服务器出现异常
    /// </summary>
    [Description("连接ActiveMQ服务器出现异常")]
    ActiveMQServerException = 10043,
    /// <summary>
    /// 不支持的媒体类型
    /// </summary>
    [Description("不支持的媒体类型")]
    UnsupportedMediaType = 10044,
    /// <summary>
    /// 不支持的设备类型
    /// </summary>
    [Description("不支持的设备类型")]
    UnsupportedDeviceType = 10045,
    /// <summary>
    /// 未找到该区域
    /// </summary>
    [Description("未找到该区域")]
    DistrictDeficiency = 10046,
    /// <summary>
    /// 资源不存在
    /// </summary>
    [Description("资源不存在")]
    ResourceNotExist = 10047,
    /// <summary>
    /// 资源未审核
    /// </summary>
    [Description("资源未审核")]
    ResourceUnAudited = 10048,
    /// <summary>
    /// 无法从SIP2服务器获取读者信息
    /// </summary>
    [Description("无法从SIP2服务器获取读者信息")]
    GetReaderInfoFailedFromSIP2Server = 10049,
    /// <summary>
    /// 无法连接SIP2服务器
    /// </summary>
    [Description("无法连接SIP2服务器")]
    DisconnectedWithSIP2Server = 10050,
    /// <summary>
    /// 预借数量已达上限
    /// </summary>
    [Description("预借数量已达上限")]
    PreborrowCountReachedLimit = 10051,
    /// <summary>
    /// 该书已被预约
    /// </summary>
    [Description("该书已被预约")]
    BookHasBeenPreborrowed = 10052,
    /// <summary>
    /// 序号超过当前分区数量
    /// </summary>
    [Description("序号超过当前分区数量")]
    OverMaxSortNumeber = 10053,
    /// <summary>
    /// 序号重复
    /// </summary>
    [Description("序号重复")]
    RepeatSortNumeber = 10054,
    /// <summary>
    /// 服务正在运行
    /// </summary>
    [Description("服务正在运行")]
    ServiceIsRunning = 10055,
    /// <summary>
    /// 启动服务失败
    /// </summary>
    [Description("启动服务失败")]
    StartServiceFailed = 10056,
    /// <summary>
    /// 续借失败
    /// </summary>
    [Description("续借失败")]
    RenewFailed = 10057,
    /// <summary>
    /// E卡通账户不存在
    /// </summary>
    [Description("E卡通账户不存在")]
    AccountNoExist = 10058,
    /// <summary>
    /// 卡无效
    /// </summary>
    [Description("卡无效")]
    AccountUnused = 10059,
    /// <summary>
    /// 网络资源Url不存在
    /// </summary>
    [Description("网络资源Url不存在")]
    UrlNoExist = 10060,
    /// <summary>
    /// 计划任务不存在
    /// </summary>
    [Description("计划任务不存在")]
    ScheduleNoExist = 10061,
    /// <summary>
    /// 该模板已被使用，无法增加或删除行,以及删除该模板
    /// </summary>
    [Description("该模板已被使用，无法增加或删除行,以及删除该模板")]
    MouldUsed = 10062,
    /// <summary>
    /// 课表模板不存在
    /// </summary>
    [Description("课表模板不存在")]
    CourseOrderNoExist = 10063,
    /// <summary>
    /// 是管理员
    /// </summary>
    [Description("是管理员")]
    IsAdmin = 10064,
    /// <summary>
    /// 是读者
    /// </summary>
    [Description("是读者")]
    IsReader = 10065,
    /// <summary>
    /// 断开与Sip2服务器的连接
    /// </summary>
    [Description("断开与Sip2服务器的连接")]
    DisConnectedWithLibraryServer = 20001,
    /// <summary>
    /// 登录库服务器失败
    /// </summary>
    [Description("登录库服务器失败")]
    LoginLibraryServerFailed = 20002,
    /// <summary>
    /// 已登录
    /// </summary>
    [Description("已登录")]
    HasBeenLogin = 20003,

}
