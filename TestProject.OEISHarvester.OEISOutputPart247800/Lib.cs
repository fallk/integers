using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A070327
{
public static readonly BigInteger[] Value={ 256L,387420489L,4096L,59604644775390625L,60466176L,79792266297612001L,8589934592L,BigInteger.Parse("984770902183611232881"),100L,BigInteger.Parse("1191817653772720942460132761"),1283918464548864L,137858491849L,1475789056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070327Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070327.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070327Inst Instance=new A070327Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070328
{
public static readonly long[] Value={ 2L,5L,8L,11L,12L,14L,16L,17L,20L,22L,23L,26L,29L,30L,32L,34L,35L,36L,38L,41L,44L,45L,47L,48L,50L,53L,55L,56L,58L,59L,61L,62L,65L,68L,71L,72L,74L,77L,78L,80L,83L,84L,85L,86L,87L,89L,90L,92L,95L,96L,98L,100L,101L,104L,107L,108L,110L,111L,112L,113L,114L,116L,119L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070328Inst : IEnumerable<long>
{
public static readonly long[] Value=A070328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070328.Bytes);
public long this[int i]=>Value[i];

public static A070328Inst Instance=new A070328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070329
{
public static readonly long[] Value={ 12L,16L,22L,30L,34L,36L,45L,48L,55L,58L,61L,72L,78L,84L,85L,87L,90L,96L,100L,108L,111L,112L,114L,121L,124L,126L,133L,135L,141L,142L,144L,150L,154L,156L,159L,165L,166L,168L,175L,177L,178L,184L,189L,192L,196L,198L,199L,202L,204L,205L,210L,219L,220L,226L,232L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070329Inst : IEnumerable<long>
{
public static readonly long[] Value=A070329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070329.Bytes);
public long this[int i]=>Value[i];

public static A070329Inst Instance=new A070329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070330
{
public static readonly long[] Value={ 7L,23L,29L,31L,43L,47L,73L,77L,83L,91L,101L,103L,107L,127L,143L,157L,173L,199L,209L,221L,233L,241L,247L,251L,257L,259L,271L,307L,313L,317L,343L,353L,359L,373L,377L,391L,409L,431L,433L,437L,439L,443L,461L,467L,469L,487L,497L,527L,541L,563L,569L,583L,589L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070330Inst : IEnumerable<long>
{
public static readonly long[] Value=A070330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070330.Bytes);
public long this[int i]=>Value[i];

public static A070330Inst Instance=new A070330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070331
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,73L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070331Inst : IEnumerable<long>
{
public static readonly long[] Value=A070331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070331.Bytes);
public long this[int i]=>Value[i];

public static A070331Inst Instance=new A070331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070332
{
public static readonly BigInteger[] Value={ 32L,243L,64L,25L,36L,16807L,32768L,729L,0L,285311670611L,BigInteger.Parse("46005119909369701466112"),BigInteger.Parse("247064529073450392704413") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A070332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A070332Inst Instance=new A070332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070333
{
public static readonly long[] Value={ 1L,3L,6L,12L,21L,33L,50L,72L,99L,133L,174L,222L,279L,345L,420L,506L,603L,711L,832L,966L,1113L,1275L,1452L,1644L,1853L,2079L,2322L,2584L,2865L,3165L,3486L,3828L,4191L,4577L,4986L,5418L,5875L,6357L,6864L,7398L,7959L,8547L,9164L,9810L,10485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070333Inst : IEnumerable<long>
{
public static readonly long[] Value=A070333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070333.Bytes);
public long this[int i]=>Value[i];

public static A070333Inst Instance=new A070333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070334
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,12L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070334Inst : IEnumerable<long>
{
public static readonly long[] Value=A070334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070334.Bytes);
public long this[int i]=>Value[i];

public static A070334Inst Instance=new A070334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070335
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L,8L,16L,9L,18L,13L,3L,6L,12L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070335Inst : IEnumerable<long>
{
public static readonly long[] Value=A070335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070335.Bytes);
public long this[int i]=>Value[i];

public static A070335Inst Instance=new A070335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070336
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,7L,14L,3L,6L,12L,24L,23L,21L,17L,9L,18L,11L,22L,19L,13L,1L,2L,4L,8L,16L,7L,14L,3L,6L,12L,24L,23L,21L,17L,9L,18L,11L,22L,19L,13L,1L,2L,4L,8L,16L,7L,14L,3L,6L,12L,24L,23L,21L,17L,9L,18L,11L,22L,19L,13L,1L,2L,4L,8L,16L,7L,14L,3L,6L,12L,24L,23L,21L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070336Inst : IEnumerable<long>
{
public static readonly long[] Value=A070336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070336.Bytes);
public long this[int i]=>Value[i];

public static A070336Inst Instance=new A070336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070337
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,5L,10L,20L,13L,26L,25L,23L,19L,11L,22L,17L,7L,14L,1L,2L,4L,8L,16L,5L,10L,20L,13L,26L,25L,23L,19L,11L,22L,17L,7L,14L,1L,2L,4L,8L,16L,5L,10L,20L,13L,26L,25L,23L,19L,11L,22L,17L,7L,14L,1L,2L,4L,8L,16L,5L,10L,20L,13L,26L,25L,23L,19L,11L,22L,17L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070337Inst : IEnumerable<long>
{
public static readonly long[] Value=A070337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070337.Bytes);
public long this[int i]=>Value[i];

public static A070337Inst Instance=new A070337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070338
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,31L,29L,25L,17L,1L,2L,4L,8L,16L,32L,31L,29L,25L,17L,1L,2L,4L,8L,16L,32L,31L,29L,25L,17L,1L,2L,4L,8L,16L,32L,31L,29L,25L,17L,1L,2L,4L,8L,16L,32L,31L,29L,25L,17L,1L,2L,4L,8L,16L,32L,31L,29L,25L,17L,1L,2L,4L,8L,16L,32L,31L,29L,25L,17L,1L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070338Inst : IEnumerable<long>
{
public static readonly long[] Value=A070338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070338.Bytes);
public long this[int i]=>Value[i];

public static A070338Inst Instance=new A070338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070339
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,32L,29L,23L,11L,22L,9L,18L,1L,2L,4L,8L,16L,32L,29L,23L,11L,22L,9L,18L,1L,2L,4L,8L,16L,32L,29L,23L,11L,22L,9L,18L,1L,2L,4L,8L,16L,32L,29L,23L,11L,22L,9L,18L,1L,2L,4L,8L,16L,32L,29L,23L,11L,22L,9L,18L,1L,2L,4L,8L,16L,32L,29L,23L,11L,22L,9L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070339Inst : IEnumerable<long>
{
public static readonly long[] Value=A070339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070339.Bytes);
public long this[int i]=>Value[i];

public static A070339Inst Instance=new A070339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070420
{
public static readonly long[] Value={ 1L,7L,12L,10L,33L,9L,26L,34L,16L,1L,7L,12L,10L,33L,9L,26L,34L,16L,1L,7L,12L,10L,33L,9L,26L,34L,16L,1L,7L,12L,10L,33L,9L,26L,34L,16L,1L,7L,12L,10L,33L,9L,26L,34L,16L,1L,7L,12L,10L,33L,9L,26L,34L,16L,1L,7L,12L,10L,33L,9L,26L,34L,16L,1L,7L,12L,10L,33L,9L,26L,34L,16L,1L,7L,12L,10L,33L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070420Inst : IEnumerable<long>
{
public static readonly long[] Value=A070420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070420.Bytes);
public long this[int i]=>Value[i];

public static A070420Inst Instance=new A070420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070421
{
public static readonly long[] Value={ 1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L,1L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070421Inst : IEnumerable<long>
{
public static readonly long[] Value=A070421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070421.Bytes);
public long this[int i]=>Value[i];

public static A070421Inst Instance=new A070421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070422
{
public static readonly long[] Value={ 1L,7L,10L,31L,22L,37L,25L,19L,16L,34L,4L,28L,1L,7L,10L,31L,22L,37L,25L,19L,16L,34L,4L,28L,1L,7L,10L,31L,22L,37L,25L,19L,16L,34L,4L,28L,1L,7L,10L,31L,22L,37L,25L,19L,16L,34L,4L,28L,1L,7L,10L,31L,22L,37L,25L,19L,16L,34L,4L,28L,1L,7L,10L,31L,22L,37L,25L,19L,16L,34L,4L,28L,1L,7L,10L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070422Inst : IEnumerable<long>
{
public static readonly long[] Value=A070422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070422.Bytes);
public long this[int i]=>Value[i];

public static A070422Inst Instance=new A070422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070423
{
public static readonly long[] Value={ 1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L,7L,9L,23L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070423Inst : IEnumerable<long>
{
public static readonly long[] Value=A070423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070423.Bytes);
public long this[int i]=>Value[i];

public static A070423Inst Instance=new A070423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070424
{
public static readonly long[] Value={ 1L,7L,8L,15L,23L,38L,20L,17L,37L,13L,9L,22L,31L,12L,2L,14L,16L,30L,5L,35L,40L,34L,33L,26L,18L,3L,21L,24L,4L,28L,32L,19L,10L,29L,39L,27L,25L,11L,36L,6L,1L,7L,8L,15L,23L,38L,20L,17L,37L,13L,9L,22L,31L,12L,2L,14L,16L,30L,5L,35L,40L,34L,33L,26L,18L,3L,21L,24L,4L,28L,32L,19L,10L,29L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070424Inst : IEnumerable<long>
{
public static readonly long[] Value=A070424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070424.Bytes);
public long this[int i]=>Value[i];

public static A070424Inst Instance=new A070424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070425
{
public static readonly long[] Value={ 1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L,37L,1L,7L,6L,42L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070425Inst : IEnumerable<long>
{
public static readonly long[] Value=A070425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070425.Bytes);
public long this[int i]=>Value[i];

public static A070425Inst Instance=new A070425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070426
{
public static readonly long[] Value={ 1L,7L,5L,35L,25L,43L,37L,39L,9L,19L,1L,7L,5L,35L,25L,43L,37L,39L,9L,19L,1L,7L,5L,35L,25L,43L,37L,39L,9L,19L,1L,7L,5L,35L,25L,43L,37L,39L,9L,19L,1L,7L,5L,35L,25L,43L,37L,39L,9L,19L,1L,7L,5L,35L,25L,43L,37L,39L,9L,19L,1L,7L,5L,35L,25L,43L,37L,39L,9L,19L,1L,7L,5L,35L,25L,43L,37L,39L,9L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070426Inst : IEnumerable<long>
{
public static readonly long[] Value=A070426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070426.Bytes);
public long this[int i]=>Value[i];

public static A070426Inst Instance=new A070426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070427
{
public static readonly long[] Value={ 1L,7L,4L,28L,16L,22L,19L,43L,31L,37L,34L,13L,1L,7L,4L,28L,16L,22L,19L,43L,31L,37L,34L,13L,1L,7L,4L,28L,16L,22L,19L,43L,31L,37L,34L,13L,1L,7L,4L,28L,16L,22L,19L,43L,31L,37L,34L,13L,1L,7L,4L,28L,16L,22L,19L,43L,31L,37L,34L,13L,1L,7L,4L,28L,16L,22L,19L,43L,31L,37L,34L,13L,1L,7L,4L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070427Inst : IEnumerable<long>
{
public static readonly long[] Value=A070427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070427.Bytes);
public long this[int i]=>Value[i];

public static A070427Inst Instance=new A070427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070428
{
public static readonly long[] Value={ 1L,4L,13L,41L,125L,367L,1111L,3395L,10491L,32670L,102231L,320990L,1010196L,3184138L,10046921L,31723592L,100216745L,316694005L,1001003332L,3164437425L,10004650118L,31632790244L,100021566157L,316274216762L,1000100055684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070428Inst : IEnumerable<long>
{
public static readonly long[] Value=A070428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070428.Bytes);
public long this[int i]=>Value[i];

public static A070428Inst Instance=new A070428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070429
{
public static readonly long[] Value={ 1L,7L,2L,14L,4L,28L,8L,9L,16L,18L,32L,36L,17L,25L,34L,3L,21L,6L,42L,12L,37L,24L,27L,1L,7L,2L,14L,4L,28L,8L,9L,16L,18L,32L,36L,17L,25L,34L,3L,21L,6L,42L,12L,37L,24L,27L,1L,7L,2L,14L,4L,28L,8L,9L,16L,18L,32L,36L,17L,25L,34L,3L,21L,6L,42L,12L,37L,24L,27L,1L,7L,2L,14L,4L,28L,8L,9L,16L,18L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070429Inst : IEnumerable<long>
{
public static readonly long[] Value=A070429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070429.Bytes);
public long this[int i]=>Value[i];

public static A070429Inst Instance=new A070429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070430
{
public static readonly long[] Value={ 0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L,1L,4L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070430Inst : IEnumerable<long>
{
public static readonly long[] Value=A070430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070430.Bytes);
public long this[int i]=>Value[i];

public static A070430Inst Instance=new A070430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070431
{
public static readonly long[] Value={ 0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L,1L,0L,1L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070431Inst : IEnumerable<long>
{
public static readonly long[] Value=A070431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070431.Bytes);
public long this[int i]=>Value[i];

public static A070431Inst Instance=new A070431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070432
{
public static readonly long[] Value={ 0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L,1L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070432Inst : IEnumerable<long>
{
public static readonly long[] Value=A070432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070432.Bytes);
public long this[int i]=>Value[i];

public static A070432Inst Instance=new A070432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070433
{
public static readonly long[] Value={ 0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L,4L,0L,7L,7L,0L,4L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070433Inst : IEnumerable<long>
{
public static readonly long[] Value=A070433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070433.Bytes);
public long this[int i]=>Value[i];

public static A070433Inst Instance=new A070433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070434
{
public static readonly long[] Value={ 0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L,4L,9L,5L,3L,3L,5L,9L,4L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070434Inst : IEnumerable<long>
{
public static readonly long[] Value=A070434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070434.Bytes);
public long this[int i]=>Value[i];

public static A070434Inst Instance=new A070434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070435
{
public static readonly long[] Value={ 0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L,1L,0L,1L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070435Inst : IEnumerable<long>
{
public static readonly long[] Value=A070435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070435.Bytes);
public long this[int i]=>Value[i];

public static A070435Inst Instance=new A070435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070436
{
public static readonly long[] Value={ 0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L,1L,0L,1L,4L,9L,3L,12L,10L,10L,12L,3L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070436Inst : IEnumerable<long>
{
public static readonly long[] Value=A070436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070436.Bytes);
public long this[int i]=>Value[i];

public static A070436Inst Instance=new A070436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070437
{
public static readonly long[] Value={ 0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L,1L,0L,1L,4L,9L,2L,11L,8L,7L,8L,11L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070437Inst : IEnumerable<long>
{
public static readonly long[] Value=A070437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070437.Bytes);
public long this[int i]=>Value[i];

public static A070437Inst Instance=new A070437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070438
{
public static readonly long[] Value={ 0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L,4L,4L,6L,10L,1L,9L,4L,1L,0L,1L,4L,9L,1L,10L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070438Inst : IEnumerable<long>
{
public static readonly long[] Value=A070438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070438.Bytes);
public long this[int i]=>Value[i];

public static A070438Inst Instance=new A070438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070439
{
public static readonly long[] Value={ 0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L,9L,4L,1L,0L,1L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070439Inst : IEnumerable<long>
{
public static readonly long[] Value=A070439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070439.Bytes);
public long this[int i]=>Value[i];

public static A070439Inst Instance=new A070439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070440
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L,4L,1L,0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L,4L,1L,0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L,4L,1L,0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L,4L,1L,0L,1L,4L,9L,16L,7L,0L,13L,10L,9L,10L,13L,0L,7L,16L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070440Inst : IEnumerable<long>
{
public static readonly long[] Value=A070440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070440.Bytes);
public long this[int i]=>Value[i];

public static A070440Inst Instance=new A070440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070441
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L,17L,6L,16L,9L,4L,1L,0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L,17L,6L,16L,9L,4L,1L,0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L,17L,6L,16L,9L,4L,1L,0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L,17L,6L,16L,9L,4L,1L,0L,1L,4L,9L,16L,6L,17L,11L,7L,5L,5L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070441Inst : IEnumerable<long>
{
public static readonly long[] Value=A070441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070441.Bytes);
public long this[int i]=>Value[i];

public static A070441Inst Instance=new A070441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070442
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L,5L,16L,9L,4L,1L,0L,1L,4L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070442Inst : IEnumerable<long>
{
public static readonly long[] Value=A070442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070442.Bytes);
public long this[int i]=>Value[i];

public static A070442Inst Instance=new A070442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070443
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,4L,15L,7L,1L,18L,16L,16L,18L,1L,7L,15L,4L,16L,9L,4L,1L,0L,1L,4L,9L,16L,4L,15L,7L,1L,18L,16L,16L,18L,1L,7L,15L,4L,16L,9L,4L,1L,0L,1L,4L,9L,16L,4L,15L,7L,1L,18L,16L,16L,18L,1L,7L,15L,4L,16L,9L,4L,1L,0L,1L,4L,9L,16L,4L,15L,7L,1L,18L,16L,16L,18L,1L,7L,15L,4L,16L,9L,4L,1L,0L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070443Inst : IEnumerable<long>
{
public static readonly long[] Value=A070443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070443.Bytes);
public long this[int i]=>Value[i];

public static A070443Inst Instance=new A070443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070444
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,3L,14L,5L,20L,15L,12L,11L,12L,15L,20L,5L,14L,3L,16L,9L,4L,1L,0L,1L,4L,9L,16L,3L,14L,5L,20L,15L,12L,11L,12L,15L,20L,5L,14L,3L,16L,9L,4L,1L,0L,1L,4L,9L,16L,3L,14L,5L,20L,15L,12L,11L,12L,15L,20L,5L,14L,3L,16L,9L,4L,1L,0L,1L,4L,9L,16L,3L,14L,5L,20L,15L,12L,11L,12L,15L,20L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070444Inst : IEnumerable<long>
{
public static readonly long[] Value=A070444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070444.Bytes);
public long this[int i]=>Value[i];

public static A070444Inst Instance=new A070444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070445
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,2L,13L,3L,18L,12L,8L,6L,6L,8L,12L,18L,3L,13L,2L,16L,9L,4L,1L,0L,1L,4L,9L,16L,2L,13L,3L,18L,12L,8L,6L,6L,8L,12L,18L,3L,13L,2L,16L,9L,4L,1L,0L,1L,4L,9L,16L,2L,13L,3L,18L,12L,8L,6L,6L,8L,12L,18L,3L,13L,2L,16L,9L,4L,1L,0L,1L,4L,9L,16L,2L,13L,3L,18L,12L,8L,6L,6L,8L,12L,18L,3L,13L,2L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070445Inst : IEnumerable<long>
{
public static readonly long[] Value=A070445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070445.Bytes);
public long this[int i]=>Value[i];

public static A070445Inst Instance=new A070445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070446
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L,16L,9L,4L,1L,0L,1L,4L,9L,16L,1L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070446Inst : IEnumerable<long>
{
public static readonly long[] Value=A070446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070446.Bytes);
public long this[int i]=>Value[i];

public static A070446Inst Instance=new A070446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070447
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,0L,11L,24L,14L,6L,0L,21L,19L,19L,21L,0L,6L,14L,24L,11L,0L,16L,9L,4L,1L,0L,1L,4L,9L,16L,0L,11L,24L,14L,6L,0L,21L,19L,19L,21L,0L,6L,14L,24L,11L,0L,16L,9L,4L,1L,0L,1L,4L,9L,16L,0L,11L,24L,14L,6L,0L,21L,19L,19L,21L,0L,6L,14L,24L,11L,0L,16L,9L,4L,1L,0L,1L,4L,9L,16L,0L,11L,24L,14L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070447Inst : IEnumerable<long>
{
public static readonly long[] Value=A070447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070447.Bytes);
public long this[int i]=>Value[i];

public static A070447Inst Instance=new A070447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070448
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,10L,23L,12L,3L,22L,17L,14L,13L,14L,17L,22L,3L,12L,23L,10L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,10L,23L,12L,3L,22L,17L,14L,13L,14L,17L,22L,3L,12L,23L,10L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,10L,23L,12L,3L,22L,17L,14L,13L,14L,17L,22L,3L,12L,23L,10L,25L,16L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070448Inst : IEnumerable<long>
{
public static readonly long[] Value=A070448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070448.Bytes);
public long this[int i]=>Value[i];

public static A070448Inst Instance=new A070448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070449
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,9L,22L,10L,0L,19L,13L,9L,7L,7L,9L,13L,19L,0L,10L,22L,9L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,9L,22L,10L,0L,19L,13L,9L,7L,7L,9L,13L,19L,0L,10L,22L,9L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,9L,22L,10L,0L,19L,13L,9L,7L,7L,9L,13L,19L,0L,10L,22L,9L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070449Inst : IEnumerable<long>
{
public static readonly long[] Value=A070449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070449.Bytes);
public long this[int i]=>Value[i];

public static A070449Inst Instance=new A070449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070450
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,8L,21L,8L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070450Inst : IEnumerable<long>
{
public static readonly long[] Value=A070450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070450.Bytes);
public long this[int i]=>Value[i];

public static A070450Inst Instance=new A070450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070451
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,7L,20L,6L,23L,13L,5L,28L,24L,22L,22L,24L,28L,5L,13L,23L,6L,20L,7L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,7L,20L,6L,23L,13L,5L,28L,24L,22L,22L,24L,28L,5L,13L,23L,6L,20L,7L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,7L,20L,6L,23L,13L,5L,28L,24L,22L,22L,24L,28L,5L,13L,23L,6L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070451Inst : IEnumerable<long>
{
public static readonly long[] Value=A070451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070451.Bytes);
public long this[int i]=>Value[i];

public static A070451Inst Instance=new A070451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070468
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,3L,18L,35L,8L,29L,6L,31L,12L,41L,26L,13L,2L,39L,32L,27L,24L,23L,24L,27L,32L,39L,2L,13L,26L,41L,12L,31L,6L,29L,8L,35L,18L,3L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,3L,18L,35L,8L,29L,6L,31L,12L,41L,26L,13L,2L,39L,32L,27L,24L,23L,24L,27L,32L,39L,2L,13L,26L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070468Inst : IEnumerable<long>
{
public static readonly long[] Value=A070468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070468.Bytes);
public long this[int i]=>Value[i];

public static A070468Inst Instance=new A070468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070469
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,2L,17L,34L,6L,27L,3L,28L,8L,37L,21L,7L,42L,32L,24L,18L,14L,12L,12L,14L,18L,24L,32L,42L,7L,21L,37L,8L,28L,3L,27L,6L,34L,17L,2L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,2L,17L,34L,6L,27L,3L,28L,8L,37L,21L,7L,42L,32L,24L,18L,14L,12L,12L,14L,18L,24L,32L,42L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070469Inst : IEnumerable<long>
{
public static readonly long[] Value=A070469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070469.Bytes);
public long this[int i]=>Value[i];

public static A070469Inst Instance=new A070469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070470
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,25L,36L,1L,16L,33L,4L,25L,0L,25L,4L,33L,16L,1L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,1L,16L,33L,4L,25L,0L,25L,4L,33L,16L,1L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,1L,16L,33L,4L,25L,0L,25L,4L,33L,16L,1L,36L,25L,16L,9L,4L,1L,0L,1L,4L,9L,16L,25L,36L,1L,16L,33L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070470Inst : IEnumerable<long>
{
public static readonly long[] Value=A070470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070470.Bytes);
public long this[int i]=>Value[i];

public static A070470Inst Instance=new A070470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070471
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L,1L,3L,2L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070471Inst : IEnumerable<long>
{
public static readonly long[] Value=A070471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070471.Bytes);
public long this[int i]=>Value[i];

public static A070471Inst Instance=new A070471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070472
{
public static readonly long[] Value={ 0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L,6L,1L,6L,6L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070472Inst : IEnumerable<long>
{
public static readonly long[] Value=A070472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070472.Bytes);
public long this[int i]=>Value[i];

public static A070472Inst Instance=new A070472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070473
{
public static readonly long[] Value={ 0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L,0L,1L,8L,5L,9L,4L,7L,2L,6L,3L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070473Inst : IEnumerable<long>
{
public static readonly long[] Value=A070473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070473.Bytes);
public long this[int i]=>Value[i];

public static A070473Inst Instance=new A070473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070474
{
public static readonly long[] Value={ 0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L,4L,5L,0L,7L,8L,9L,4L,11L,0L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070474Inst : IEnumerable<long>
{
public static readonly long[] Value=A070474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070474.Bytes);
public long this[int i]=>Value[i];

public static A070474Inst Instance=new A070474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070475
{
public static readonly long[] Value={ 0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L,8L,1L,12L,8L,8L,5L,5L,1L,12L,5L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070475Inst : IEnumerable<long>
{
public static readonly long[] Value=A070475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070475.Bytes);
public long this[int i]=>Value[i];

public static A070475Inst Instance=new A070475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070476
{
public static readonly long[] Value={ 0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L,6L,1L,6L,13L,0L,1L,8L,13L,8L,13L,6L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070476Inst : IEnumerable<long>
{
public static readonly long[] Value=A070476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070476.Bytes);
public long this[int i]=>Value[i];

public static A070476Inst Instance=new A070476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070477
{
public static readonly long[] Value={ 0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L,0L,1L,8L,12L,4L,5L,6L,13L,2L,9L,10L,11L,3L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070477Inst : IEnumerable<long>
{
public static readonly long[] Value=A070477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070477.Bytes);
public long this[int i]=>Value[i];

public static A070477Inst Instance=new A070477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070478
{
public static readonly long[] Value={ 0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L,0L,1L,8L,11L,0L,13L,8L,7L,0L,9L,8L,3L,0L,5L,8L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070478Inst : IEnumerable<long>
{
public static readonly long[] Value=A070478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070478.Bytes);
public long this[int i]=>Value[i];

public static A070478Inst Instance=new A070478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070479
{
public static readonly long[] Value={ 0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L,8L,10L,13L,6L,12L,3L,2L,15L,14L,5L,11L,4L,7L,9L,16L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070479Inst : IEnumerable<long>
{
public static readonly long[] Value=A070479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070479.Bytes);
public long this[int i]=>Value[i];

public static A070479Inst Instance=new A070479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070480
{
public static readonly long[] Value={ 0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L,0L,1L,8L,9L,10L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070480Inst : IEnumerable<long>
{
public static readonly long[] Value=A070480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070480.Bytes);
public long this[int i]=>Value[i];

public static A070480Inst Instance=new A070480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070481
{
public static readonly long[] Value={ 0L,1L,8L,8L,7L,11L,7L,1L,18L,7L,12L,1L,18L,12L,8L,12L,11L,11L,18L,0L,1L,8L,8L,7L,11L,7L,1L,18L,7L,12L,1L,18L,12L,8L,12L,11L,11L,18L,0L,1L,8L,8L,7L,11L,7L,1L,18L,7L,12L,1L,18L,12L,8L,12L,11L,11L,18L,0L,1L,8L,8L,7L,11L,7L,1L,18L,7L,12L,1L,18L,12L,8L,12L,11L,11L,18L,0L,1L,8L,8L,7L,11L,7L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070481Inst : IEnumerable<long>
{
public static readonly long[] Value=A070481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070481.Bytes);
public long this[int i]=>Value[i];

public static A070481Inst Instance=new A070481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070482
{
public static readonly long[] Value={ 0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L,16L,3L,12L,9L,0L,11L,8L,17L,4L,15L,16L,13L,12L,19L,0L,1L,8L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070482Inst : IEnumerable<long>
{
public static readonly long[] Value=A070482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070482.Bytes);
public long this[int i]=>Value[i];

public static A070482Inst Instance=new A070482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070483
{
public static readonly long[] Value={ 0L,1L,8L,6L,1L,20L,6L,7L,8L,15L,13L,8L,6L,13L,14L,15L,1L,20L,15L,13L,20L,0L,1L,8L,6L,1L,20L,6L,7L,8L,15L,13L,8L,6L,13L,14L,15L,1L,20L,15L,13L,20L,0L,1L,8L,6L,1L,20L,6L,7L,8L,15L,13L,8L,6L,13L,14L,15L,1L,20L,15L,13L,20L,0L,1L,8L,6L,1L,20L,6L,7L,8L,15L,13L,8L,6L,13L,14L,15L,1L,20L,15L,13L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070483Inst : IEnumerable<long>
{
public static readonly long[] Value=A070483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070483.Bytes);
public long this[int i]=>Value[i];

public static A070483Inst Instance=new A070483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070740
{
public static readonly long[] Value={ 24L,36L,40320L,7200L,479001600L,25401600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070740Inst : IEnumerable<long>
{
public static readonly long[] Value=A070740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070740.Bytes);
public long this[int i]=>Value[i];

public static A070740Inst Instance=new A070740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070741
{
public static readonly long[] Value={ 14L,57L,78L,148L,224L,252L,305L,490L,546L,585L,620L,639L,889L,897L,912L,1134L,1248L,1290L,1352L,1526L,1953L,2212L,2345L,2368L,2394L,2470L,2678L,2710L,3096L,3474L,3584L,3641L,3880L,4032L,4088L,4617L,4764L,4880L,5436L,5985L,6097L,6318L,6489L,6552L,6570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070741Inst : IEnumerable<long>
{
public static readonly long[] Value=A070741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070741.Bytes);
public long this[int i]=>Value[i];

public static A070741Inst Instance=new A070741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070742
{
public static readonly long[] Value={ 18L,17L,32L,16L,36L,31L,30L,15L,23L,35L,34L,30L,33L,29L,29L,14L,32L,22L,28L,34L,30L,33L,29L,29L,14L,32L,22L,28L,27L,30L,33L,29L,29L,14L,32L,22L,28L,27L,28L,33L,29L,29L,14L,32L,22L,28L,27L,28L,26L,29L,29L,14L,32L,22L,28L,27L,28L,26L,13L,29L,14L,32L,22L,28L,27L,28L,26L,13L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070742Inst : IEnumerable<long>
{
public static readonly long[] Value=A070742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070742.Bytes);
public long this[int i]=>Value[i];

public static A070742Inst Instance=new A070742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070743
{
public static readonly long[] Value={ 1L,3L,5L,122L,160L,190L,739L,10000L,10058L,10151L,1003346L,1304392L,1702190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070743Inst : IEnumerable<long>
{
public static readonly long[] Value=A070743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070743.Bytes);
public long this[int i]=>Value[i];

public static A070743Inst Instance=new A070743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070744
{
public static readonly long[] Value={ 18L,32L,36L,37L,38L,39L,40L,54L,80L,82L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070744Inst : IEnumerable<long>
{
public static readonly long[] Value=A070744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070744.Bytes);
public long this[int i]=>Value[i];

public static A070744Inst Instance=new A070744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070745
{
public static readonly long[] Value={ 3L,6L,10L,14L,15L,17L,21L,24L,28L,29L,35L,36L,42L,43L,45L,48L,55L,57L,60L,62L,63L,66L,76L,78L,80L,81L,90L,91L,99L,105L,112L,118L,119L,120L,123L,127L,129L,132L,136L,140L,141L,143L,147L,153L,154L,155L,161L,162L,165L,168L,171L,172L,179L,185L,190L,192L,195L,209L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070745Inst : IEnumerable<long>
{
public static readonly long[] Value=A070745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070745.Bytes);
public long this[int i]=>Value[i];

public static A070745Inst Instance=new A070745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070746
{
public static readonly long[] Value={ 1L,7L,709L,2203L,4481L,5107L,11489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070746Inst : IEnumerable<long>
{
public static readonly long[] Value=A070746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070746.Bytes);
public long this[int i]=>Value[i];

public static A070746Inst Instance=new A070746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070747
{
public static readonly long[] Value={ 0L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070747Inst : IEnumerable<long>
{
public static readonly long[] Value=A070747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070747.Bytes);
public long this[int i]=>Value[i];

public static A070747Inst Instance=new A070747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070748
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070748Inst : IEnumerable<long>
{
public static readonly long[] Value=A070748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070748.Bytes);
public long this[int i]=>Value[i];

public static A070748Inst Instance=new A070748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070749
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-1L,0L,-1L,0L,-1L,-1L,0L,-1L,0L,-1L,0L,0L,1L,-1L,-1L,1L,-1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,-1L,-1L,1L,-1L,0L,0L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,0L,0L,1L,0L,0L,0L,1L,0L,-1L,-1L,-1L,1L,1L,-1L,0L,-1L,-1L,0L,-1L,0L,-1L,-1L,1L,0L,1L,1L,1L,1L,1L,0L,-1L,1L,-1L,1L,-1L,0L,-1L,-1L,-1L,0L,0L,-1L,1L,-1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,-1L,-1L,0L,-1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070749Inst : IEnumerable<long>
{
public static readonly long[] Value=A070749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070749.Bytes);
public long this[int i]=>Value[i];

public static A070749Inst Instance=new A070749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070750
{
public static readonly long[] Value={ 0L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070750Inst : IEnumerable<long>
{
public static readonly long[] Value=A070750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070750.Bytes);
public long this[int i]=>Value[i];

public static A070750Inst Instance=new A070750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070751
{
public static readonly long[] Value={ 4L,5L,6L,10L,11L,12L,16L,17L,18L,22L,23L,24L,25L,29L,30L,31L,35L,36L,37L,41L,42L,43L,48L,49L,50L,54L,55L,56L,60L,61L,62L,66L,67L,68L,69L,73L,74L,75L,79L,80L,81L,85L,86L,87L,92L,93L,94L,98L,99L,100L,104L,105L,106L,110L,111L,112L,113L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070751Inst : IEnumerable<long>
{
public static readonly long[] Value=A070751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070751.Bytes);
public long this[int i]=>Value[i];

public static A070751Inst Instance=new A070751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070752
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,9L,13L,14L,15L,19L,20L,21L,26L,27L,28L,32L,33L,34L,38L,39L,40L,44L,45L,46L,47L,51L,52L,53L,57L,58L,59L,63L,64L,65L,70L,71L,72L,76L,77L,78L,82L,83L,84L,88L,89L,90L,91L,95L,96L,97L,101L,102L,103L,107L,108L,109L,114L,115L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070752Inst : IEnumerable<long>
{
public static readonly long[] Value=A070752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070752.Bytes);
public long this[int i]=>Value[i];

public static A070752Inst Instance=new A070752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070753
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,31L,37L,41L,43L,61L,67L,73L,79L,113L,131L,137L,149L,157L,163L,167L,173L,181L,193L,199L,211L,251L,257L,263L,269L,281L,293L,307L,313L,331L,337L,349L,383L,389L,401L,419L,431L,433L,439L,443L,457L,463L,487L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070753Inst : IEnumerable<long>
{
public static readonly long[] Value=A070753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070753.Bytes);
public long this[int i]=>Value[i];

public static A070753Inst Instance=new A070753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070754
{
public static readonly long[] Value={ 2L,3L,7L,13L,19L,47L,53L,59L,71L,83L,89L,97L,101L,103L,107L,109L,127L,139L,151L,179L,191L,197L,223L,227L,229L,233L,239L,241L,271L,277L,283L,311L,317L,347L,353L,359L,367L,373L,379L,397L,409L,421L,449L,461L,467L,479L,491L,499L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070754Inst : IEnumerable<long>
{
public static readonly long[] Value=A070754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070754.Bytes);
public long this[int i]=>Value[i];

public static A070754Inst Instance=new A070754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070755
{
public static readonly long[] Value={ 1L,10L,35L,165L,286L,455L,969L,1330L,1771L,4495L,6545L,7770L,9139L,12341L,14190L,16215L,23426L,32509L,35990L,39711L,47905L,52394L,57155L,79079L,98770L,105995L,121485L,129766L,138415L,176851L,198485L,221815L,246905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070755Inst : IEnumerable<long>
{
public static readonly long[] Value=A070755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070755.Bytes);
public long this[int i]=>Value[i];

public static A070755Inst Instance=new A070755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070756
{
public static readonly long[] Value={ 30L,85L,195L,240L,525L,700L,960L,1020L,1170L,1845L,2720L,3045L,3120L,4026L,4818L,5005L,5655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070756Inst : IEnumerable<long>
{
public static readonly long[] Value=A070756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070756.Bytes);
public long this[int i]=>Value[i];

public static A070756Inst Instance=new A070756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070757
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,9L,11L,14L,19L,23L,25L,32L,36L,40L,50L,55L,57L,70L,76L,81L,96L,100L,109L,126L,129L,138L,156L,163L,175L,199L,198L,211L,239L,241L,258L,283L,281L,308L,335L,335L,360L,382L,385L,421L,445L,437L,482L,508L,503L,556L,571L,561L,632L,657L,645L,705L,726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070757Inst : IEnumerable<long>
{
public static readonly long[] Value=A070757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070757.Bytes);
public long this[int i]=>Value[i];

public static A070757Inst Instance=new A070757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070758
{
public static readonly long[] Value={ 25L,38L,57L,86L,129L,194L,291L,437L,656L,985L,1477L,2216L,3325L,11222L,16834L,25251L,37876L,56815L,85222L,127834L,191751L,287626L,431439L,647159L,970739L,1456109L,2184164L,3276246L,4914369L,7371554L,11057332L,16585998L,24878997L,37318496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070758Inst : IEnumerable<long>
{
public static readonly long[] Value=A070758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070758.Bytes);
public long this[int i]=>Value[i];

public static A070758Inst Instance=new A070758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070759
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,21L,22L,98L,106L,164L,189L,219L,364L,443L,670L,775L,1919L,2204L,2715L,3692L,4228L,4912L,10466L,12300L,14087L,21659L,28170L,55832L,66577L,87309L,87505L,98144L,167512L,259517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070759Inst : IEnumerable<long>
{
public static readonly long[] Value=A070759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070759.Bytes);
public long this[int i]=>Value[i];

public static A070759Inst Instance=new A070759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070760
{
public static readonly long[] Value={ 100L,144L,169L,200L,288L,300L,400L,441L,500L,528L,600L,700L,768L,800L,825L,867L,882L,900L,961L,1089L,1100L,1584L,2178L,2200L,3300L,4400L,4851L,5500L,6600L,7700L,8712L,8800L,9801L,9900L,10000L,10100L,10404L,10609L,10989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070760Inst : IEnumerable<long>
{
public static readonly long[] Value=A070760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070760.Bytes);
public long this[int i]=>Value[i];

public static A070760Inst Instance=new A070760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070761
{
public static readonly long[] Value={ 4L,9L,42L,56L,74L,99L,133L,177L,236L,315L,420L,560L,747L,996L,1328L,1771L,2362L,3149L,4199L,5599L,7466L,9954L,13273L,17697L,23596L,31462L,41950L,74577L,99437L,132583L,235703L,314271L,419028L,558704L,744938L,993251L,1324335L,1765780L,2354374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070761Inst : IEnumerable<long>
{
public static readonly long[] Value=A070761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070761.Bytes);
public long this[int i]=>Value[i];

public static A070761Inst Instance=new A070761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070762
{
public static readonly long[] Value={ 3L,4L,6L,7L,9L,10L,11L,12L,38L,42L,59L,96L,154L,171L,211L,313L,465L,563L,1040L,1176L,1213L,1431L,1519L,1987L,2527L,3033L,4039L,4209L,4358L,5109L,5251L,6642L,19200L,25275L,42589L,43025L,49294L,58585L,66290L,77458L,80409L,86533L,94192L,110452L,115166L,124470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070762Inst : IEnumerable<long>
{
public static readonly long[] Value=A070762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070762.Bytes);
public long this[int i]=>Value[i];

public static A070762Inst Instance=new A070762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070763
{
public static readonly long[] Value={ 2L,3L,4L,7L,9L,16L,21L,25L,31L,64L,81L,93L,127L,217L,289L,381L,400L,651L,729L,889L,1681L,2401L,2667L,3481L,3937L,4096L,5041L,7921L,8191L,10201L,11811L,15625L,17161L,24573L,27559L,27889L,28561L,29929L,57337L,65536L,82677L,83521L,85849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070763Inst : IEnumerable<long>
{
public static readonly long[] Value=A070763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070763.Bytes);
public long this[int i]=>Value[i];

public static A070763Inst Instance=new A070763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070764
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,4L,25L,108L,450L,1713L,6267L,21988L,75185L,251590L,828408L,2692630L,8661287L,27624040L,87479663L,275392248L,862593661L,2690285608L,8359581585L,25893044920L,79978118632L,246433568617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070764Inst : IEnumerable<long>
{
public static readonly long[] Value=A070764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070764.Bytes);
public long this[int i]=>Value[i];

public static A070764Inst Instance=new A070764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070765
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,12L,24L,66L,159L,444L,1161L,3226L,8785L,24453L,67716L,189309L,528922L,1484738L,4172185L,11756354L,33174451L,93795220L,265565628L,753060469L,2138206966L,6078931114L,17302380313L,49302121747L,140627400927L,401510058179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070765Inst : IEnumerable<long>
{
public static readonly long[] Value=A070765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070765.Bytes);
public long this[int i]=>Value[i];

public static A070765Inst Instance=new A070765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070766
{
public static readonly long[] Value={ 1L,1L,3L,7L,22L,77L,294L,1054L,3788L,11326L,24790L,103641L,164559L,532510L,1574252L,2939898L,4761009L,21048218L,24306306L,95707819L,205176450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070766Inst : IEnumerable<long>
{
public static readonly long[] Value=A070766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070766.Bytes);
public long this[int i]=>Value[i];

public static A070766Inst Instance=new A070766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070767
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,5L,39L,394L,2784L,19164L,118762L,579460L,3110267L,15264387L,75007623L,369928203L,1817475619L,8913862144L,43914857957L,216555328193L,1070588132492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070767Inst : IEnumerable<long>
{
public static readonly long[] Value=A070767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070767.Bytes);
public long this[int i]=>Value[i];

public static A070767Inst Instance=new A070767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070768
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,4L,37L,381L,2717L,18760L,116439L,565943L,3033697L,14835067L,72633658L,356923880L,1746833634L,8532601529L,41868336466L,205618704167L,1012359995953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070768Inst : IEnumerable<long>
{
public static readonly long[] Value=A070768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070768.Bytes);
public long this[int i]=>Value[i];

public static A070768Inst Instance=new A070768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070769
{
public static readonly long[] Value={ 1L,4L,5L,1L,3L,6L,9L,2L,3L,4L,8L,8L,3L,3L,8L,1L,0L,5L,0L,2L,8L,3L,9L,6L,8L,4L,8L,5L,8L,9L,2L,0L,2L,7L,4L,4L,9L,4L,9L,3L,0L,3L,2L,2L,8L,3L,6L,4L,8L,0L,1L,5L,8L,6L,3L,0L,9L,3L,0L,0L,4L,5L,5L,7L,6L,6L,2L,4L,2L,5L,5L,9L,5L,7L,5L,4L,5L,1L,7L,8L,3L,5L,6L,5L,9L,5L,3L,1L,3L,5L,7L,7L,1L,1L,0L,8L,6L,8L,2L,8L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070769Inst : IEnumerable<long>
{
public static readonly long[] Value=A070769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070769.Bytes);
public long this[int i]=>Value[i];

public static A070769Inst Instance=new A070769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070770
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,4L,5L,6L,3L,4L,5L,5L,6L,7L,6L,7L,8L,9L,4L,5L,6L,6L,7L,8L,7L,8L,9L,10L,8L,9L,10L,11L,12L,5L,6L,7L,7L,8L,9L,8L,9L,10L,11L,9L,10L,11L,12L,13L,10L,11L,12L,13L,14L,15L,6L,7L,8L,8L,9L,10L,9L,10L,11L,12L,10L,11L,12L,13L,14L,11L,12L,13L,14L,15L,16L,12L,13L,14L,15L,16L,17L,18L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070770Inst : IEnumerable<long>
{
public static readonly long[] Value=A070770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070770.Bytes);
public long this[int i]=>Value[i];

public static A070770Inst Instance=new A070770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070771
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,2L,3L,4L,5L,4L,5L,6L,6L,7L,8L,3L,4L,5L,6L,5L,6L,7L,7L,8L,9L,6L,7L,8L,8L,9L,10L,9L,10L,11L,12L,4L,5L,6L,7L,6L,7L,8L,8L,9L,10L,7L,8L,9L,9L,10L,11L,10L,11L,12L,13L,8L,9L,10L,10L,11L,12L,11L,12L,13L,14L,12L,13L,14L,15L,16L,5L,6L,7L,8L,7L,8L,9L,9L,10L,11L,8L,9L,10L,10L,11L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070771Inst : IEnumerable<long>
{
public static readonly long[] Value=A070771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070771.Bytes);
public long this[int i]=>Value[i];

public static A070771Inst Instance=new A070771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070788
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,100L,102L,106L,108L,111L,112L,113L,114L,116L,117L,118L,119L,122L,124L,128L,133L,135L,137L,138L,166L,184L,186L,196L,199L,359L,399L,459L,539L,659L,679L,739L,759L,779L,799L,859L,879L,919L,939L,959L,979L,999L,1000L,1006L,1011L,1013L,1022L,1033L,1037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070788Inst : IEnumerable<long>
{
public static readonly long[] Value=A070788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070788.Bytes);
public long this[int i]=>Value[i];

public static A070788Inst Instance=new A070788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070789
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,25L,34L,43L,52L,59L,61L,68L,70L,77L,86L,95L,104L,109L,151L,154L,155L,157L,203L,208L,209L,250L,253L,254L,256L,302L,307L,308L,352L,353L,355L,401L,406L,407L,409L,451L,452L,454L,500L,505L,506L,508L,550L,551L,553L,604L,605L,607L,650L,652L,703L,704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070789Inst : IEnumerable<long>
{
public static readonly long[] Value=A070789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070789.Bytes);
public long this[int i]=>Value[i];

public static A070789Inst Instance=new A070789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070790
{
public static readonly long[] Value={ 3L,6L,12L,15L,21L,24L,30L,33L,39L,42L,48L,51L,57L,60L,66L,69L,75L,78L,84L,87L,93L,96L,132L,159L,165L,177L,219L,231L,258L,264L,276L,318L,330L,357L,363L,375L,417L,429L,456L,462L,474L,516L,528L,555L,561L,573L,579L,615L,627L,654L,660L,672L,678L,699L,714L,726L,753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070790Inst : IEnumerable<long>
{
public static readonly long[] Value=A070790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070790.Bytes);
public long this[int i]=>Value[i];

public static A070790Inst Instance=new A070790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070791
{
public static readonly long[] Value={ 5L,10L,11L,13L,17L,20L,22L,26L,31L,35L,40L,44L,53L,62L,71L,79L,80L,88L,97L,115L,142L,158L,170L,176L,185L,214L,241L,257L,275L,284L,313L,329L,340L,356L,374L,383L,412L,428L,455L,469L,473L,482L,511L,527L,554L,568L,572L,581L,599L,610L,626L,649L,653L,667L,671L,680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070791Inst : IEnumerable<long>
{
public static readonly long[] Value=A070791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070791.Bytes);
public long this[int i]=>Value[i];

public static A070791Inst Instance=new A070791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070792
{
public static readonly long[] Value={ 7L,14L,19L,23L,28L,29L,32L,37L,38L,41L,46L,47L,49L,50L,55L,56L,58L,64L,65L,67L,73L,74L,76L,82L,83L,85L,89L,91L,92L,94L,98L,110L,121L,136L,143L,187L,220L,235L,242L,286L,334L,341L,385L,433L,440L,484L,532L,569L,583L,631L,668L,682L,719L,730L,767L,781L,818L,866L,869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070792Inst : IEnumerable<long>
{
public static readonly long[] Value=A070792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070792.Bytes);
public long this[int i]=>Value[i];

public static A070792Inst Instance=new A070792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070793
{
public static readonly long[] Value={ 9L,18L,27L,36L,45L,54L,63L,72L,81L,90L,99L,198L,297L,396L,495L,594L,693L,792L,891L,990L,1017L,1035L,1044L,1089L,1107L,1125L,1134L,1179L,1215L,1224L,1269L,1305L,1314L,1359L,1404L,1449L,1539L,1629L,1719L,1809L,1899L,1989L,2016L,2034L,2043L,2088L,2106L,2124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070793Inst : IEnumerable<long>
{
public static readonly long[] Value=A070793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070793.Bytes);
public long this[int i]=>Value[i];

public static A070793Inst Instance=new A070793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A070794
{
public static readonly long[] Value={ 100L,101L,103L,107L,188L,193L,200L,202L,206L,287L,292L,299L,301L,305L,386L,391L,398L,400L,404L,485L,490L,497L,503L,584L,596L,602L,683L,695L,701L,709L,782L,794L,800L,808L,881L,893L,907L,980L,992L,1034L,1069L,1076L,1124L,1159L,1166L,1214L,1249L,1256L,1291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A070794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A070794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A070794Inst : IEnumerable<long>
{
public static readonly long[] Value=A070794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A070794.Bytes);
public long this[int i]=>Value[i];

public static A070794Inst Instance=new A070794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}