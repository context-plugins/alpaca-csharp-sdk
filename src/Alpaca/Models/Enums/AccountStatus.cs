using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// An enum representing the various possible account status values.
/// <para>
/// Most likely, the account status is ACTIVE unless there is any problem. The account status may get in ACCOUNT_UPDATED when personal information is being updated from the dashboard, in which case you may not be allowed trading for a short period of time until the change is approved.
/// </para>
/// <para>
/// - ONBOARDING
///   The account is onboarding.
/// - SUBMISSION_FAILED
///   The account application submission failed for some reason.
/// - SUBMITTED
///   The account application has been submitted for review.
/// - ACCOUNT_UPDATED
///   The account information is being updated.
/// - APPROVAL_PENDING
///   The final account approval is pending.
/// - ACTIVE
///   The account is active for trading.
/// - REJECTED
///   The account application has been rejected.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountStatus>))]
public sealed record AccountStatus : OpenStringEnum<AccountStatus>
{
    private AccountStatus(string value) : base(value)
    {
    }

    public static readonly AccountStatus Onboarding = new("ONBOARDING");

    public static readonly AccountStatus SubmissionFailed = new("SUBMISSION_FAILED");

    public static readonly AccountStatus Submitted = new("SUBMITTED");

    public static readonly AccountStatus AccountUpdated = new("ACCOUNT_UPDATED");

    public static readonly AccountStatus ApprovalPending = new("APPROVAL_PENDING");

    public static readonly AccountStatus Active = new("ACTIVE");

    public static readonly AccountStatus Rejected = new("REJECTED");

    public TResult Match<TResult>(Func<TResult> onOnboarding,
        Func<TResult> onSubmissionFailed,
        Func<TResult> onSubmitted,
        Func<TResult> onAccountUpdated,
        Func<TResult> onApprovalPending,
        Func<TResult> onActive,
        Func<TResult> onRejected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Onboarding => onOnboarding(),
            _ when this == SubmissionFailed => onSubmissionFailed(),
            _ when this == Submitted => onSubmitted(),
            _ when this == AccountUpdated => onAccountUpdated(),
            _ when this == ApprovalPending => onApprovalPending(),
            _ when this == Active => onActive(),
            _ when this == Rejected => onRejected(),
            _ => otherwise(Value)
        };

    public void Match(Action onOnboarding,
        Action onSubmissionFailed,
        Action onSubmitted,
        Action onAccountUpdated,
        Action onApprovalPending,
        Action onActive,
        Action onRejected,
        Action<string> otherwise)
    {
        if (this == Onboarding) onOnboarding();
        else if (this == SubmissionFailed) onSubmissionFailed();
        else if (this == Submitted) onSubmitted();
        else if (this == AccountUpdated) onAccountUpdated();
        else if (this == ApprovalPending) onApprovalPending();
        else if (this == Active) onActive();
        else if (this == Rejected) onRejected();
        else otherwise(Value);
    }
}
