using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// - FILL
///   Order fills (both partial and full fills)
/// <para>
/// - TRANS
///   Cash transactions (both CSD and CSW)
/// </para>
/// <para>
/// - MISC
///   Miscellaneous or rarely used activity types (All types except those in TRANS, DIV, or FILL)
/// </para>
/// <para>
/// - ACATC
///   ACATS IN/OUT (Cash)
/// </para>
/// <para>
/// - ACATS
///   ACATS IN/OUT (Securities)
/// </para>
/// <para>
/// - CFEE
///   Crypto fee
/// </para>
/// <para>
/// - CSD
///   Cash deposit(+)
/// </para>
/// <para>
/// - CSW
///   Cash withdrawal(-)
/// </para>
/// <para>
/// - DIV
///   Dividends
/// </para>
/// <para>
/// - DIVCGL
///   Dividend (capital gain long term)
/// </para>
/// <para>
/// - DIVCGS
///   Dividend (capital gain short term)
/// </para>
/// <para>
/// - DIVFEE
///   Dividend fee
/// </para>
/// <para>
/// - DIVFT
///   Dividend adjusted (Foreign Tax Withheld)
/// </para>
/// <para>
/// - DIVNRA
///   Dividend adjusted (NRA Withheld)
/// </para>
/// <para>
/// - DIVROC
///   Dividend return of capital
/// </para>
/// <para>
/// - DIVTW
///   Dividend adjusted (Tefra Withheld)
/// </para>
/// <para>
/// - DIVTXEX
///   Dividend (tax exempt)
/// </para>
/// <para>
/// - FEE
///   Fee denominated in USD
/// </para>
/// <para>
/// - INT
///   Interest (credit/margin)
/// </para>
/// <para>
/// - INTNRA
///   Interest adjusted (NRA Withheld)
/// </para>
/// <para>
/// - INTTW
///   Interest adjusted (Tefra Withheld)
/// </para>
/// <para>
/// - JNL
///   Journal entry
/// </para>
/// <para>
/// - JNLC
///   Journal entry (cash)
/// </para>
/// <para>
/// - JNLS
///   Journal entry (stock)
/// </para>
/// <para>
/// - MA
///   Merger/Acquisition
/// </para>
/// <para>
/// - NC
///   Name change
/// </para>
/// <para>
/// - OPASN
///   Option assignment
/// </para>
/// <para>
/// - OPEXP
///   Option expiration
/// </para>
/// <para>
/// - OPXRC
///   Option exercise
/// </para>
/// <para>
/// - PTC
///   Pass Thru Charge
/// </para>
/// <para>
/// - PTR
///   Pass Thru Rebate
/// </para>
/// <para>
/// - REORG
///   Reorg CA
/// </para>
/// <para>
/// - SC
///   Symbol change
/// </para>
/// <para>
/// - SSO
///   Stock spinoff
/// </para>
/// <para>
/// - SSP
///   Stock split
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ActivityType>))]
public sealed record ActivityType : StringEnum<ActivityType>
{
    private ActivityType(string value) : base(value)
    {
    }

    public static readonly ActivityType Fill = new("FILL");

    public static readonly ActivityType Trans = new("TRANS");

    public static readonly ActivityType Misc = new("MISC");

    public static readonly ActivityType Acatc = new("ACATC");

    public static readonly ActivityType Acats = new("ACATS");

    public static readonly ActivityType Csd = new("CSD");

    public static readonly ActivityType Csw = new("CSW");

    public static readonly ActivityType Div = new("DIV");

    public static readonly ActivityType Divcgl = new("DIVCGL");

    public static readonly ActivityType Divcgs = new("DIVCGS");

    public static readonly ActivityType Divfee = new("DIVFEE");

    public static readonly ActivityType Divft = new("DIVFT");

    public static readonly ActivityType Divnra = new("DIVNRA");

    public static readonly ActivityType Divroc = new("DIVROC");

    public static readonly ActivityType Divtw = new("DIVTW");

    public static readonly ActivityType Divtxex = new("DIVTXEX");

    public static readonly ActivityType Int = new("INT");

    public static readonly ActivityType Intnra = new("INTNRA");

    public static readonly ActivityType Inttw = new("INTTW");

    public static readonly ActivityType Jnl = new("JNL");

    public static readonly ActivityType Jnlc = new("JNLC");

    public static readonly ActivityType Jnls = new("JNLS");

    public static readonly ActivityType Ma = new("MA");

    public static readonly ActivityType Nc = new("NC");

    public static readonly ActivityType Opasn = new("OPASN");

    public static readonly ActivityType Opexp = new("OPEXP");

    public static readonly ActivityType Opxrc = new("OPXRC");

    public static readonly ActivityType Ptc = new("PTC");

    public static readonly ActivityType Ptr = new("PTR");

    public static readonly ActivityType Reorg = new("REORG");

    public static readonly ActivityType Sc = new("SC");

    public static readonly ActivityType Sso = new("SSO");

    public static readonly ActivityType Ssp = new("SSP");

    public static readonly ActivityType Cfee = new("CFEE");

    public static readonly ActivityType Fee = new("FEE");

    public static ActivityType FromValue(string value) => FromValueCore(value);
}
