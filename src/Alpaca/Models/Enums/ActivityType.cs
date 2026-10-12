using System;
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
public sealed record ActivityType : OpenStringEnum<ActivityType>
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

    public TResult Match<TResult>(Func<TResult> onFill,
        Func<TResult> onTrans,
        Func<TResult> onMisc,
        Func<TResult> onAcatc,
        Func<TResult> onAcats,
        Func<TResult> onCsd,
        Func<TResult> onCsw,
        Func<TResult> onDiv,
        Func<TResult> onDivcgl,
        Func<TResult> onDivcgs,
        Func<TResult> onDivfee,
        Func<TResult> onDivft,
        Func<TResult> onDivnra,
        Func<TResult> onDivroc,
        Func<TResult> onDivtw,
        Func<TResult> onDivtxex,
        Func<TResult> onInt,
        Func<TResult> onIntnra,
        Func<TResult> onInttw,
        Func<TResult> onJnl,
        Func<TResult> onJnlc,
        Func<TResult> onJnls,
        Func<TResult> onMa,
        Func<TResult> onNc,
        Func<TResult> onOpasn,
        Func<TResult> onOpexp,
        Func<TResult> onOpxrc,
        Func<TResult> onPtc,
        Func<TResult> onPtr,
        Func<TResult> onReorg,
        Func<TResult> onSc,
        Func<TResult> onSso,
        Func<TResult> onSsp,
        Func<TResult> onCfee,
        Func<TResult> onFee,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Fill => onFill(),
            _ when this == Trans => onTrans(),
            _ when this == Misc => onMisc(),
            _ when this == Acatc => onAcatc(),
            _ when this == Acats => onAcats(),
            _ when this == Csd => onCsd(),
            _ when this == Csw => onCsw(),
            _ when this == Div => onDiv(),
            _ when this == Divcgl => onDivcgl(),
            _ when this == Divcgs => onDivcgs(),
            _ when this == Divfee => onDivfee(),
            _ when this == Divft => onDivft(),
            _ when this == Divnra => onDivnra(),
            _ when this == Divroc => onDivroc(),
            _ when this == Divtw => onDivtw(),
            _ when this == Divtxex => onDivtxex(),
            _ when this == Int => onInt(),
            _ when this == Intnra => onIntnra(),
            _ when this == Inttw => onInttw(),
            _ when this == Jnl => onJnl(),
            _ when this == Jnlc => onJnlc(),
            _ when this == Jnls => onJnls(),
            _ when this == Ma => onMa(),
            _ when this == Nc => onNc(),
            _ when this == Opasn => onOpasn(),
            _ when this == Opexp => onOpexp(),
            _ when this == Opxrc => onOpxrc(),
            _ when this == Ptc => onPtc(),
            _ when this == Ptr => onPtr(),
            _ when this == Reorg => onReorg(),
            _ when this == Sc => onSc(),
            _ when this == Sso => onSso(),
            _ when this == Ssp => onSsp(),
            _ when this == Cfee => onCfee(),
            _ when this == Fee => onFee(),
            _ => otherwise(Value)
        };

    public void Match(Action onFill,
        Action onTrans,
        Action onMisc,
        Action onAcatc,
        Action onAcats,
        Action onCsd,
        Action onCsw,
        Action onDiv,
        Action onDivcgl,
        Action onDivcgs,
        Action onDivfee,
        Action onDivft,
        Action onDivnra,
        Action onDivroc,
        Action onDivtw,
        Action onDivtxex,
        Action onInt,
        Action onIntnra,
        Action onInttw,
        Action onJnl,
        Action onJnlc,
        Action onJnls,
        Action onMa,
        Action onNc,
        Action onOpasn,
        Action onOpexp,
        Action onOpxrc,
        Action onPtc,
        Action onPtr,
        Action onReorg,
        Action onSc,
        Action onSso,
        Action onSsp,
        Action onCfee,
        Action onFee,
        Action<string> otherwise)
    {
        if (this == Fill) onFill();
        else if (this == Trans) onTrans();
        else if (this == Misc) onMisc();
        else if (this == Acatc) onAcatc();
        else if (this == Acats) onAcats();
        else if (this == Csd) onCsd();
        else if (this == Csw) onCsw();
        else if (this == Div) onDiv();
        else if (this == Divcgl) onDivcgl();
        else if (this == Divcgs) onDivcgs();
        else if (this == Divfee) onDivfee();
        else if (this == Divft) onDivft();
        else if (this == Divnra) onDivnra();
        else if (this == Divroc) onDivroc();
        else if (this == Divtw) onDivtw();
        else if (this == Divtxex) onDivtxex();
        else if (this == Int) onInt();
        else if (this == Intnra) onIntnra();
        else if (this == Inttw) onInttw();
        else if (this == Jnl) onJnl();
        else if (this == Jnlc) onJnlc();
        else if (this == Jnls) onJnls();
        else if (this == Ma) onMa();
        else if (this == Nc) onNc();
        else if (this == Opasn) onOpasn();
        else if (this == Opexp) onOpexp();
        else if (this == Opxrc) onOpxrc();
        else if (this == Ptc) onPtc();
        else if (this == Ptr) onPtr();
        else if (this == Reorg) onReorg();
        else if (this == Sc) onSc();
        else if (this == Sso) onSso();
        else if (this == Ssp) onSsp();
        else if (this == Cfee) onCfee();
        else if (this == Fee) onFee();
        else otherwise(Value);
    }
}
