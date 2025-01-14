using Bitwise;

Console.WriteLine("***** Fun with Bitwise Operations *****\n");

Console.WriteLine("6 & 4 = {0} | {1}", 6 & 4, Convert.ToString((6 & 4),2));

Console.WriteLine("6 | 4 = {0} | {1}", 6 & 4, Convert.ToString((6 | 4), 2));

Console.WriteLine("6 ^ 4 = {0} | {1}", 6 & 4, Convert.ToString((6 ^ 4), 2));

Console.WriteLine("6 << 1 = {0} | {1}", 6 << 1, Convert.ToString((6 << 1), 2));

Console.WriteLine("6 >> 1 = {0} | {1}", 6 >> 1, Convert.ToString((6 >> 1), 2));

Console.WriteLine("~6 = {0} | {1}", ~6, Convert.ToString((~(short)6), 2));

Console.WriteLine("Int.MaxValue {0}", Convert.ToString((int.MaxValue), 2));


ContactPreferenceEnum emailAndPhone = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;

Console.WriteLine("Email and Phone: {0}", emailAndPhone);

Console.WriteLine("None? {0}", (emailAndPhone | ContactPreferenceEnum.None) == emailAndPhone);

Console.WriteLine("Email? {0}", (emailAndPhone | ContactPreferenceEnum.Email) == emailAndPhone);

Console.WriteLine("Phone? {0}", (emailAndPhone | ContactPreferenceEnum.Phone) == emailAndPhone);

Console.WriteLine("Mail? {0}", (emailAndPhone | ContactPreferenceEnum.Mail) == emailAndPhone);



Console.WriteLine("Email and Phone: {0}", emailAndPhone);

Console.WriteLine("None? {0}", (emailAndPhone & ContactPreferenceEnum.None) == ContactPreferenceEnum.None);

Console.WriteLine("Email? {0}", (emailAndPhone & ContactPreferenceEnum.Email) == ContactPreferenceEnum.Email);

Console.WriteLine("Phone? {0}", (emailAndPhone & ContactPreferenceEnum.Phone) == ContactPreferenceEnum.Phone);

Console.WriteLine("Mail? {0}", (emailAndPhone & ContactPreferenceEnum.Mail) == ContactPreferenceEnum.Mail);


Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();