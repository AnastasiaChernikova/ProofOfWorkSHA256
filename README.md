# ProofOfWorkSHA256
This is university project about blockchain. We will implement proof of work with sha256 in C#.
Task.

1. Select programming language, supporting SHA256 hash function.

Example: https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=net-5.0

2. Design you own PoW nonce format (number, string etc.).

3. Write a program to create block for a given text data. Your program needs to have configurable parameter StartingZeros – number of starting zero bits resulting SHA256 block hash should contain. Test your program for StartingZeros not less than 16.

a. SHA256(Data + PoW nonce) = Block Hash

b. Block = [Block Hash, Data, PoW nonce]

4. Design block structure for storage, for example, use JSON.

5. Write a program or a different program function to verify block, stored on disk.

