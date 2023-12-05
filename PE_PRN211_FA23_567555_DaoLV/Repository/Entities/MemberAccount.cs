using System;
using System.Collections.Generic;

namespace Repository.Entities;

public partial class MemberAccount
{
    public int MemberAccountId { get; set; }

    public string MemberAccountPassword { get; set; } = null!;

    public string MemberFullName { get; set; } = null!;

    public string? MemberEmail { get; set; }

    public int? Role { get; set; }
}
