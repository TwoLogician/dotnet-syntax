#! "netcoreapp2.1"
#r "nuget:Microsoft.AspNetCore.Cryptography.KeyDerivation,2.1.1"

using Microsoft.AspNetCore.Cryptography.KeyDerivation;


string Hash(string password) {
    var salt = Encoding.UTF8.GetBytes("!@#$%^&*()_");

    string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
        password: password,
        salt: salt,
        prf: KeyDerivationPrf.HMACSHA1,
        iterationCount: 10000,
        numBytesRequested: 256 / 8));

    return hashed;
}

Console.WriteLine(Hash("admin"));