using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276073
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,4L,5L,6L,7L,8L,9L,8L,9L,10L,11L,12L,13L,12L,13L,14L,15L,16L,17L,8L,9L,10L,11L,12L,13L,12L,13L,14L,15L,16L,17L,16L,17L,18L,19L,20L,21L,20L,21L,22L,23L,24L,25L,16L,17L,18L,19L,20L,21L,20L,21L,22L,23L,24L,25L,24L,25L,26L,27L,28L,29L,28L,29L,30L,31L,32L,33L,24L,25L,26L,27L,28L,29L,28L,29L,30L,31L,32L,33L,32L,33L,34L,35L,36L,37L,36L };
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
public class A276073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276073Inst : IEnumerable<long>
{
public static readonly long[] Value=A276073.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276073.Bytes);
public long this[int i]=>Value[i];

public static A276073Inst Instance=new A276073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276074
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,8L,9L,10L,11L,8L,9L,12L,13L,14L,15L,12L,13L,8L,9L,10L,11L,8L,9L,12L,13L,14L,15L,12L,13L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,8L,9L,10L,11L,8L,9L,12L,13L,14L,15L,12L,13L,8L,9L,10L,11L,8L,9L,12L,13L,14L,15L,12L,13L,0L,1L,2L,3L,0L,1L,4L,5L,6L,7L,4L,5L,0L,1L,2L,3L,0L,1L };
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
public class A276074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276074Inst : IEnumerable<long>
{
public static readonly long[] Value=A276074.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276074.Bytes);
public long this[int i]=>Value[i];

public static A276074Inst Instance=new A276074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276075
{
public static readonly long[] Value={ 0L,1L,2L,2L,6L,3L,24L,3L,4L,7L,120L,4L,720L,25L,8L,4L,5040L,5L,40320L,8L,26L,121L,362880L,5L,12L,721L,6L,26L,3628800L,9L,39916800L,5L,122L,5041L,30L,6L,479001600L,40321L,722L,9L,6227020800L,27L,87178291200L,122L,10L,362881L,1307674368000L,6L,48L,13L,5042L,722L,20922789888000L,7L,126L,27L,40322L,3628801L,355687428096000L,10L,6402373705728000L,39916801L,28L,6L,726L,123L };
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
public class A276075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276075Inst : IEnumerable<long>
{
public static readonly long[] Value=A276075.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276075.Bytes);
public long this[int i]=>Value[i];

public static A276075Inst Instance=new A276075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276076
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,18L,5L,10L,15L,30L,45L,90L,25L,50L,75L,150L,225L,450L,125L,250L,375L,750L,1125L,2250L,7L,14L,21L,42L,63L,126L,35L,70L,105L,210L,315L,630L,175L,350L,525L,1050L,1575L,3150L,875L,1750L,2625L,5250L,7875L,15750L,49L,98L,147L,294L,441L,882L,245L,490L,735L,1470L,2205L,4410L,1225L,2450L,3675L,7350L,11025L,22050L,6125L,12250L,18375L,36750L,55125L,110250L,343L };
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
public class A276076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276076Inst : IEnumerable<long>
{
public static readonly long[] Value=A276076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276076.Bytes);
public long this[int i]=>Value[i];

public static A276076Inst Instance=new A276076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276077
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L };
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
public class A276077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276077Inst : IEnumerable<long>
{
public static readonly long[] Value=A276077.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276077.Bytes);
public long this[int i]=>Value[i];

public static A276077Inst Instance=new A276077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276078
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,25L,26L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,45L,46L,47L,49L,50L,51L,53L,55L,57L,58L,59L,61L,62L,63L,65L,66L,67L,69L,70L,71L,73L,74L,75L,77L,78L,79L,82L,83L,85L,86L,87L,89L,90L,91L,93L,94L,95L,97L,98L,99L,101L,102L,103L,105L,106L,107L,109L,110L,111L,113L,114L,115L,117L,118L,119L,121L };
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
public class A276078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276078Inst : IEnumerable<long>
{
public static readonly long[] Value=A276078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276078.Bytes);
public long this[int i]=>Value[i];

public static A276078Inst Instance=new A276078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276079
{
public static readonly long[] Value={ 4L,8L,12L,16L,20L,24L,27L,28L,32L,36L,40L,44L,48L,52L,54L,56L,60L,64L,68L,72L,76L,80L,81L,84L,88L,92L,96L,100L,104L,108L,112L,116L,120L,124L,128L,132L,135L,136L,140L,144L,148L,152L,156L,160L,162L,164L,168L,172L,176L,180L,184L,188L,189L,192L,196L,200L,204L,208L,212L,216L,220L,224L,228L,232L,236L,240L,243L,244L,248L,252L,256L,260L,264L,268L,270L,272L };
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
public class A276079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276079Inst : IEnumerable<long>
{
public static readonly long[] Value=A276079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276079.Bytes);
public long this[int i]=>Value[i];

public static A276079Inst Instance=new A276079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276080
{
public static readonly BigInteger[] Value={ 0L,1L,2L,7L,28L,139L,822L,5677L,44888L,400021L,3966970L,43328131L,516782292L,6682867087L,93130824878L,1391321096089L,22181459914672L,375880800693097L,6746469047955378L,127851581333528191L,2551039715319388940L,BigInteger.Parse("53457519928692619411"),BigInteger.Parse("1173770856436282074982"),BigInteger.Parse("26948387795024752862917"),BigInteger.Parse("645694707721735535710728"),BigInteger.Parse("16117771962578155161812989") };
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
public class A276080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276080.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276080Inst Instance=new A276080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276081
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,8L,9L,24L,11L,14L,13L,30L,17L,32L,33L,120L,35L,38L,25L,54L,27L,44L,43L,144L,47L,62L,49L,150L,65L,152L,153L,720L,155L,158L,73L,174L,63L,92L,79L,264L,81L,98L,71L,198L,87L,188L,187L,840L,191L,206L,109L,294L,111L,212L,199L,864L,215L,302L,217L,870L,305L,872L,873L,5040L,875L,878L,313L,894L,231L,332L,247L,984L,237L,266L,155L,438L,171L };
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
public class A276081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276081Inst : IEnumerable<long>
{
public static readonly long[] Value=A276081.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276081.Bytes);
public long this[int i]=>Value[i];

public static A276081Inst Instance=new A276081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276082
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,13L,14L,23L,24L,49L,50L,77L,54L,85L,86L,119L,120L,241L,242L,365L,246L,373L,374L,503L,264L,409L,410L,557L,414L,565L,566L,719L,720L,1441L,1442L,2165L,1446L,2173L,2174L,2903L,1464L,2209L,2210L,2957L,2214L,2965L,2966L,3719L,1560L,2401L,2402L,3245L,2406L,3253L,3254L,4103L,2424L,3289L,3290L,4157L,3294L,4165L,4166L,5039L,5040L,10081L };
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
public class A276082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276082Inst : IEnumerable<long>
{
public static readonly long[] Value=A276082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276082.Bytes);
public long this[int i]=>Value[i];

public static A276082Inst Instance=new A276082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276083
{
public static readonly long[] Value={ 0L,1L,4L,3L,18L,13L,16L,9L,96L,73L,76L,51L,90L,61L,64L,33L,600L,481L,484L,363L,498L,373L,376L,249L,576L,433L,436L,291L,450L,301L,304L,153L,4320L,3601L,3604L,2883L,3618L,2893L,2896L,2169L,3696L,2953L,2956L,2211L,2970L,2221L,2224L,1473L,4200L,3361L,3364L,2523L,3378L,2533L,2536L,1689L,3456L,2593L,2596L,1731L,2610L,1741L,1744L,873L,35280L,30241L };
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
public class A276083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276083Inst : IEnumerable<long>
{
public static readonly long[] Value=A276083.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276083.Bytes);
public long this[int i]=>Value[i];

public static A276083Inst Instance=new A276083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276132
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,31L,37L,71L,73L,79L,97L,131L,151L,157L,179L,337L,353L,359L,373L,727L,733L,739L,751L,757L,929L,937L,953L,971L,1733L,1979L,3319L,3371L,3373L,3719L,3733L,7177L,7717L,9133L,9173L,9791L };
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
public class A276132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276132Inst : IEnumerable<long>
{
public static readonly long[] Value=A276132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276132.Bytes);
public long this[int i]=>Value[i];

public static A276132Inst Instance=new A276132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276133
{
public static readonly long[] Value={ 0L,2L,1L,4L,2L,5L,1L,3L,6L,1L,8L,4L,1L,3L,7L,6L,2L,8L,3L,3L,4L,5L,6L,9L,3L,1L,4L,2L,5L,11L,8L,6L,1L,10L,1L,6L,7L,3L,6L,6L,2L,8L,6L,3L,1L,12L,10L,6L,2L,4L,4L,4L,8L,11L,4L,6L,1L,7L,4L,1L,11L,13L,3L,3L,3L,15L,7L,8L,2L,6L,4L,7L,7L,5L,3L,10L,7L,5L,7L };
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
public class A276133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276133Inst : IEnumerable<long>
{
public static readonly long[] Value=A276133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276133.Bytes);
public long this[int i]=>Value[i];

public static A276133Inst Instance=new A276133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276134
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L };
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
public class A276134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276134Inst : IEnumerable<long>
{
public static readonly long[] Value=A276134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276134.Bytes);
public long this[int i]=>Value[i];

public static A276134Inst Instance=new A276134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276135
{
public static readonly BigInteger[] Value={ 0L,0L,1L,20L,51L,2604L,6665L,720600L,1864135L,348678440L,909090909L,261535698060L,685853880635L,281241170407092L,740800455037201L,410525522232055664L,1085102592571150095L,BigInteger.Parse("781282469559318055056"),BigInteger.Parse("2070863582910344082917"),BigInteger.Parse("1879498672877297909667780"),BigInteger.Parse("4993219047619047619047619"),BigInteger.Parse("5577014881186619679500164220") };
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
public class A276135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276135Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276135.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276135Inst Instance=new A276135Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276136
{
public static readonly long[] Value={ 6L,11L,12L,13L,23L,47L,192L,193L,383L,786432L };
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
public class A276136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276136Inst : IEnumerable<long>
{
public static readonly long[] Value=A276136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276136.Bytes);
public long this[int i]=>Value[i];

public static A276136Inst Instance=new A276136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276137
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,10L,11L,13L,15L,17L,19L,30L,31L,33L,35L,37L,39L,50L,51L,53L,55L,57L,59L,70L,71L,73L,75L,77L,79L,90L,91L,93L,95L,97L,99L,100L,101L,103L,105L,107L,109L,110L,111L,113L,115L,117L,119L,130L,131L,133L,135L,137L,139L,150L,151L,153L,155L,157L };
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
public class A276137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276137Inst : IEnumerable<long>
{
public static readonly long[] Value=A276137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276137.Bytes);
public long this[int i]=>Value[i];

public static A276137Inst Instance=new A276137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276138
{
public static readonly long[] Value={ 0L,2L,4L,6L,8L,9L,20L,22L,24L,26L,28L,29L,40L,42L,44L,46L,48L,49L,60L,62L,64L,66L,68L,69L,80L,82L,84L,86L,88L,89L,90L,92L,94L,96L,98L,99L,200L,202L,204L,206L,208L,209L,220L,222L,224L,226L,228L,229L,240L,242L,244L,246L,248L,249L,260L,262L,264L,266L };
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
public class A276138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276138Inst : IEnumerable<long>
{
public static readonly long[] Value=A276138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276138.Bytes);
public long this[int i]=>Value[i];

public static A276138Inst Instance=new A276138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276139
{
public static readonly long[] Value={ 1L,5L,24L,97L,411L,1718L,7209L,30217L,126696L,531173L,2226999L,9336862L,39145581L,164121053L,688091064L,2884878457L,12095090691L,50709664358L,212604446529L,891361661377L,3737107216776L,15668129957213L,65689925955519L,275410427652622L,1154680912735461L,4841094876469493L };
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
public class A276139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276139Inst : IEnumerable<long>
{
public static readonly long[] Value=A276139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276139.Bytes);
public long this[int i]=>Value[i];

public static A276139Inst Instance=new A276139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276140
{
public static readonly long[] Value={ 1L,2L,7L,9L,4L,11L,3L,12L,15L,19L,5L,16L,10L,13L,23L,35L,14L,29L,17L,36L,26L,31L,37L,21L,33L,43L,41L,28L,24L,47L,53L,18L,45L,59L,61L,32L,50L,67L,79L,115L,57L,83L,71L,40L,52L,89L,73L,94L,64L,97L,101L,58L,62L,103L,107L,135L,85L,109L,113L,66L,74L,127L,137L,119L,86L,131L,139L,80L,88L,149L,151L,183L,117L,167L,157L,90L,84L,163L,173L,288L,122L,179L,181L,98L,120L,191L };
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
public class A276140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276140Inst : IEnumerable<long>
{
public static readonly long[] Value=A276140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276140.Bytes);
public long this[int i]=>Value[i];

public static A276140Inst Instance=new A276140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276141
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,23L,37L,53L,61L,71L,97L,113L,127L,167L,223L,227L,229L,233L,277L,353L,397L,419L,421L,449L,463L,503L,547L,563L,571L,599L,613L,641L,691L,701L,709L,719L,769L,773L,787L,797L,823L,827L,877L,929L,1021L,1187L,1249L,1409L,1423L,1427L,1429L };
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
public class A276141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276141Inst : IEnumerable<long>
{
public static readonly long[] Value=A276141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276141.Bytes);
public long this[int i]=>Value[i];

public static A276141Inst Instance=new A276141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276142
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,279972L,2774772L,5499945L,25477452L,27722772L,254545452L,277202772L,279999972L,2133333312L,2522772252L,2545225452L,2772002772L,4266666624L,6399999936L,21331413312L,23466666432L,25225452252L,25452025452L,25479997452L,27720002772L };
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
public class A276142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276142Inst : IEnumerable<long>
{
public static readonly long[] Value=A276142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276142.Bytes);
public long this[int i]=>Value[i];

public static A276142Inst Instance=new A276142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276143
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,36L,36L,45L,36L,36L,36L,36L,63L,24L,36L,36L,36L,48L,72L,24L,48L,36L,36L,63L,36L,63L,63L,48L,48L,48L,48L,24L,24L,24L,48L,48L,48L,48L,36L,36L,36L,36L,48L,48L,48L,48L,48L,48L,48L,48L,48L,72L,24L,24L,48L,48L,48L,48L,48L,48L,48L,48L,48L };
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
public class A276143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276143Inst : IEnumerable<long>
{
public static readonly long[] Value=A276143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276143.Bytes);
public long this[int i]=>Value[i];

public static A276143Inst Instance=new A276143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276144
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,7777L,77077L,122221L,707707L,770077L,7070707L,7700077L,4444444L,88888888L,70077007L,70700707L,77000077L,88888888L,88888888L,888808888L,488888884L,700707007L,707000707L,404444404L,770000077L,440444044L,444040444L,848888848L,884888488L };
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
public class A276144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276144Inst : IEnumerable<long>
{
public static readonly long[] Value=A276144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276144.Bytes);
public long this[int i]=>Value[i];

public static A276144Inst Instance=new A276144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276145
{
public static readonly long[] Value={ 1L,1L,2L,4L,11L,30L,89L,250L,776L,2236L,7147L,20979L,68448L };
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
public class A276145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276145Inst : IEnumerable<long>
{
public static readonly long[] Value=A276145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276145.Bytes);
public long this[int i]=>Value[i];

public static A276145Inst Instance=new A276145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276146
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,2L,3L,4L,5L,6L,4L,5L,2L,3L,4L,5L,3L,4L,1L,2L,3L,4L,2L,3L,4L,5L,6L,7L,5L,6L,7L,8L,9L,10L,8L,9L,6L,7L,8L,9L,7L,8L,5L,6L,7L,8L,6L,7L,3L,4L,5L,6L,4L,5L,6L,7L,8L,9L,7L,8L,5L,6L,7L,8L,6L,7L,4L,5L,6L,7L,5L,6L,2L,3L,4L,5L,3L,4L,5L,6L,7L,8L,6L,7L,4L,5L,6L,7L,5L,6L,3L,4L,5L,6L,4L,5L,1L,2L,3L,4L,2L,3L,4L,5L,6L,7L,5L,6L,3L,4L,5L,6L,4L,5L,2L,3L,4L,5L,3L,4L,5L };
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
public class A276146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276146Inst : IEnumerable<long>
{
public static readonly long[] Value=A276146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276146.Bytes);
public long this[int i]=>Value[i];

public static A276146Inst Instance=new A276146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276147
{
public static readonly long[] Value={ 1L,3L,3L,9L,5L,5L,7L,27L,9L,15L,11L,15L,13L,21L,15L,81L,17L,15L,19L,45L,21L,33L,23L,45L,25L,39L,27L,63L,29L,7L,31L,243L,33L,51L,35L,25L,37L,57L,39L,135L,41L,35L,43L,99L,45L,69L,47L,135L,49L,75L,51L,117L,53L,45L,55L,189L,57L,87L,59L,21L,61L,93L,63L,729L,65L,55L,67L,153L,69L,105L,71L,75L,73L,111L,75L,171L,77L,65L,79L,405L,81L,123L,83L,105L,85L,129L };
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
public class A276147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276147Inst : IEnumerable<long>
{
public static readonly long[] Value=A276147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276147.Bytes);
public long this[int i]=>Value[i];

public static A276147Inst Instance=new A276147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276196
{
public static readonly BigInteger[] Value={ 2L,29L,271L,2719L,27191L,271829L,2718281L,27182839L,271828199L,2718281831L,27182818309L,271828182863L,2718281828489L,27182818284617L,271828182845909L,2718281828459051L,27182818284590483L,271828182845904533L,2718281828459045269L,BigInteger.Parse("27182818284590452387"),BigInteger.Parse("271828182845904523609") };
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
public class A276196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276196Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276196.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276196Inst Instance=new A276196Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276197
{
public static readonly long[] Value={ 2L,3L,73L,3420839L };
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
public class A276197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276197Inst : IEnumerable<long>
{
public static readonly long[] Value=A276197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276197.Bytes);
public long this[int i]=>Value[i];

public static A276197Inst Instance=new A276197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276198
{
public static readonly BigInteger[] Value={ 2L,17L,163L,1619L,16183L,161807L,1618033L,16180349L,161803403L,1618033999L,16180339933L,161803398917L,1618033988749L,16180339887557L,161803398874991L,1618033988749901L,16180339887498961L,161803398874989661L,1618033988749894853L,16180339887498948503UL,BigInteger.Parse("161803398874989484891") };
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
public class A276198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276198Inst Instance=new A276198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276199
{
public static readonly BigInteger[] Value={ 3L,31L,31469L,314107L,314159L,314159L,314159207L,3141592603L,31415926541L,314159265307L,314159265359L,3141592653581L,314159265358909L,3141592653589711L,31415926535897921L,314159265358979347L,3141592653589793239L,3141592653589793239L,BigInteger.Parse("314159265358979323861") };
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
public class A276199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276199Inst Instance=new A276199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276200
{
public static readonly BigInteger[] Value={ 11L,113L,1231L,12343L,123449L,1234547L,12345653L,123456761L,12345678899L,1234567891003L,123456789101099L,12345678910111207L,1234567891011121309L,BigInteger.Parse("123456789101112131383"),BigInteger.Parse("12345678910111213141337"),BigInteger.Parse("1234567891011121314151561"),BigInteger.Parse("123456789101112131415161717"),BigInteger.Parse("12345678910111213141516171723") };
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
public class A276200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276200Inst Instance=new A276200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276201
{
public static readonly BigInteger[] Value={ 19L,233L,2351L,235699L,23571103L,2357111297L,235711131709L,23571113171891L,2357111317192243L,235711131719232929L,BigInteger.Parse("23571113171923293127"),BigInteger.Parse("2357111317192329313727"),BigInteger.Parse("235711131719232931374061"),BigInteger.Parse("23571113171923293137414303"),BigInteger.Parse("2357111317192329313741434739"),BigInteger.Parse("235711131719232931374143475271") };
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
public class A276201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276201Inst Instance=new A276201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276202
{
public static readonly long[] Value={ 1L,4L,3L,6L,11L,7L,14L,9L,25L,33L,59L,57L,39L,135L,191L,127L,123L,159L,219L,379L,251L,167L,223L,111L,793L,263L,175L,466L,103L,137L,183L,91L,121L,107L,71L,47L,31L,41L,27L,97L,145L,129L,171L,231L,235L,553L,411L,487L,327L,649L,703L,763L,1519L,1215L,1471L,1071L };
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
public class A276202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276202Inst : IEnumerable<long>
{
public static readonly long[] Value=A276202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276202.Bytes);
public long this[int i]=>Value[i];

public static A276202Inst Instance=new A276202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276203
{
public static readonly long[] Value={ 2L,76L,122L,422L,2300L,5090L,7166L,58046L,91382L,234178L,314738L };
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
public class A276203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276203Inst : IEnumerable<long>
{
public static readonly long[] Value=A276203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276203.Bytes);
public long this[int i]=>Value[i];

public static A276203Inst Instance=new A276203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276204
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,2L,2L,1L,4L,4L,1L,4L,4L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,2L,2L,1L,4L,4L,1L,4L,4L,1L,2L,2L,1L,7L,7L,1L,7L,7L,1L,2L,2L,1L,7L,7L,1L,7L,7L,1L,2L,2L,1L,4L,4L,1L,4L,4L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,2L,2L,1L,4L,4L,1L,4L,4L,1L,2L,2L,1L,0L,0L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,0L };
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
public class A276204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276204Inst : IEnumerable<long>
{
public static readonly long[] Value=A276204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276204.Bytes);
public long this[int i]=>Value[i];

public static A276204Inst Instance=new A276204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276205
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,1L,2L,1L,3L,0L,0L,0L,4L,0L,1L,2L,2L,3L,1L,4L,0L,0L,1L,0L,0L,0L,5L,3L,0L,7L,1L,0L,4L,2L,4L,2L,3L,5L,1L,1L,4L,1L,3L,0L,0L,0L,1L,0L,0L,2L,0L,0L,0L,9L,2L,8L,10L,0L,4L,0L,0L,0L,2L,1L,7L,13L,4L,12L,4L,6L,7L,4L,4L,2L,0L,10L,2L,2L,1L,3L,1L,0L,0L,0L,12L,0L,9L,1L,0L,5L,2L,1L,17L,0L,3L,5L,0L,1L,1L,0L,0L,8L,3L,0L,0L,0L,15L,12L,9L,10L,11L,1L,5L };
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
public class A276205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276205Inst : IEnumerable<long>
{
public static readonly long[] Value=A276205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276205.Bytes);
public long this[int i]=>Value[i];

public static A276205Inst Instance=new A276205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276206
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,2L,2L,2L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,2L,2L,2L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,2L,2L,2L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,2L,2L,2L,2L,1L,4L,4L,4L,4L,1L,4L,4L,4L,4L,1L,4L,4L,4L,4L,1L,4L,4L,4L,4L,1L,2L };
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
public class A276206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276206Inst : IEnumerable<long>
{
public static readonly long[] Value=A276206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276206.Bytes);
public long this[int i]=>Value[i];

public static A276206Inst Instance=new A276206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276207
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,2L,4L,1L,1L,0L,0L,5L,0L,0L,3L,7L,2L,3L,2L,4L,1L,1L,12L,1L,5L,1L,1L,0L,0L,13L,0L,0L,10L,9L,6L,7L,0L,0L,18L,0L,0L,15L,4L,14L,7L,6L,8L,2L,6L,3L,16L,3L,3L,2L,3L,7L,1L,10L,25L,8L,5L,1L,1L,1L,4L,14L,27L,4L,1L,1L,10L,2L,2L,6L,1L,26L,8L,1L,19L,1L,1L,0L,0L,13L,0L,0L,7L,24L,2L,19L,0L,0L,34L,0L,0L,29L,32L,32L,5L,15L,21L,14L,15L,6L,6L,24L,13L,39L,0L,0L,24L,0L };
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
public class A276207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276207Inst : IEnumerable<long>
{
public static readonly long[] Value=A276207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276207.Bytes);
public long this[int i]=>Value[i];

public static A276207Inst Instance=new A276207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276208
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,14L,18L,22L,26L,30L,35L,39L,44L,49L,54L,59L,64L,69L,74L,80L,85L,90L,96L,102L,107L,113L,119L,124L,130L,136L,142L,148L,154L,160L,166L,173L,179L,185L,191L,198L,204L,210L,217L,223L,230L,236L,243L,249L,256L,263L,269L,276L,283L,290L,296L,303L,310L };
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
public class A276208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276208Inst : IEnumerable<long>
{
public static readonly long[] Value=A276208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276208.Bytes);
public long this[int i]=>Value[i];

public static A276208Inst Instance=new A276208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276209
{
public static readonly long[] Value={ 2L,4L,7L,10L,12L,15L,18L,21L,24L,27L,30L,34L,37L,40L,43L,47L,50L,53L,57L,60L,64L,67L,71L,74L,78L,81L,85L,88L,92L,96L,99L,103L,107L,110L,114L,118L,122L,125L,129L,133L,137L,141L,144L,148L,152L,156L,160L,164L,168L,172L,176L,180L,184L,188L,192L,196L,200L,204L };
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
public class A276209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276209Inst : IEnumerable<long>
{
public static readonly long[] Value=A276209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276209.Bytes);
public long this[int i]=>Value[i];

public static A276209Inst Instance=new A276209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276210
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,9L,11L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,33L,35L,36L,38L,39L,41L,42L,44L,45L,46L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,63L,65L,66L,68L,69L,70L,72L,73L,75L,76L,77L,79L,80L,82L,83L,84L,86L,87L,89L,90L,91L,93L,94L,95L };
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
public class A276210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276210Inst : IEnumerable<long>
{
public static readonly long[] Value=A276210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276210.Bytes);
public long this[int i]=>Value[i];

public static A276210Inst Instance=new A276210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276211
{
public static readonly long[] Value={ 2L,6L,10L,15L,20L,26L,32L,39L,46L,53L,60L,68L,76L,85L,94L,103L,112L,122L,132L,142L,152L,163L,174L,185L,196L,208L,220L,232L,244L,257L,269L,282L,295L,309L,322L,336L,350L,364L,379L,393L,408L,423L,438L,454L,469L,485L,501L,517L,533L,550L,566L,583L,600L,617L,634L };
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
public class A276211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276211Inst : IEnumerable<long>
{
public static readonly long[] Value=A276211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276211.Bytes);
public long this[int i]=>Value[i];

public static A276211Inst Instance=new A276211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276308
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,10L,22L,115L,319L,736L,3886L,10816L,24991L,131989L,367405L,848947L,4483720L,12480934L,28839196L,152314471L,423984331L,979683706L,5174208274L,14402986300L,33280406797L,175770766825L,489277549849L,1130554147381L,5971031863756L,16621033708546L };
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
public class A276308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276308Inst : IEnumerable<long>
{
public static readonly long[] Value=A276308.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276308.Bytes);
public long this[int i]=>Value[i];

public static A276308Inst Instance=new A276308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276309
{
public static readonly long[] Value={ 2L,2L,1L,1L,1L,1L,3L,0L,1L,2L,0L,1L,3L,1L,0L,1L,2L,0L,1L,2L,1L,2L,0L,0L,1L,1L,1L,7L,1L,0L,0L,1L,1L,0L,3L,0L,1L,1L,0L,1L,1L,0L,1L,3L,6L,0L,0L,1L,3L,0L,1L,3L,0L,1L,0L,1L,2L,0L,2L,7L,0L,0L,1L,7L,1L,0L,0L,0L,3L,2L,1L,0L,0L,1L,2L,0L,1L,2L,0L,1L,1L,0L,2L,1L,2L,0L,0L,1L,6L,2L,0L,1L,1L,0L,3L,0L };
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
public class A276309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276309Inst : IEnumerable<long>
{
public static readonly long[] Value=A276309.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276309.Bytes);
public long this[int i]=>Value[i];

public static A276309Inst Instance=new A276309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276310
{
public static readonly long[] Value={ 1L,2L,10L,60L,404L,2912L,21984L,171600L,1373680L,11215776L,93039648L,781936896L,6643741440L,56973685760L,492482782208L,4286561051904L,37536888622848L,330471001126400L,2923338431270400L,25970490200202240L,231607762146309120L,2072719382680535040L };
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
public class A276310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276310Inst : IEnumerable<long>
{
public static readonly long[] Value=A276310.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276310.Bytes);
public long this[int i]=>Value[i];

public static A276310Inst Instance=new A276310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276311
{
public static readonly long[] Value={ 1L,2L,4L,5L,17L,21L,23L,28L,41L,43L,51L,59L,105L,115L,131L,273L,585L,1519L,2303L,4791L,4921L,6019L,7833L,25711L,27319L,32497L,37975L,49381L,87199L };
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
public class A276311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276311Inst : IEnumerable<long>
{
public static readonly long[] Value=A276311.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276311.Bytes);
public long this[int i]=>Value[i];

public static A276311Inst Instance=new A276311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276312
{
public static readonly BigInteger[] Value={ 1L,1L,1L,5L,31L,246L,2353L,26585L,345775L,5094220L,83833256L,1524414737L,30353430420L,656851828075L,15350023574061L,385261255931365L,10335781852020335L,295166535640444376L,8939894824857438940L,BigInteger.Parse("286234265613041061128"),BigInteger.Parse("9659753724363828753408") };
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
public class A276312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276312.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276312Inst Instance=new A276312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276313
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,85L,671L,6405L,72302L,940005L,13846117L,227837533L,4142793511L,82488063476L,1785049505682L,41715243815059L,1046997553798894L,28089178205661221L,802173732190546289L,BigInteger.Parse("24296253228394108980"),BigInteger.Parse("777918130180655893150"),BigInteger.Parse("26253270588637259772768") };
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
public class A276313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276313.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276313Inst Instance=new A276313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276314
{
public static readonly long[] Value={ 1L,1L,5L,20L,104L,546L,3066L,17655L,104555L,630773L,3867617L,24020932L,150827740L,955808680L,6105327912L,39268000188L,254093573088L,1652984379150L,10804631902350L,70925539707330L,467373389649870L,3090558380977020L,20501504119375500L,136392970090612950L };
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
public class A276314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276314Inst : IEnumerable<long>
{
public static readonly long[] Value=A276314.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276314.Bytes);
public long this[int i]=>Value[i];

public static A276314Inst Instance=new A276314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276315
{
public static readonly BigInteger[] Value={ 1L,3L,20L,165L,1524L,15078L,156264L,1674585L,18404980L,206325834L,2350049208L,27118926354L,316381296840L,3725407768140L,44217602683728L,528470024711841L,6354463541900148L,76818345766932450L,933089010748085400L,11382500895815005110UL,BigInteger.Parse("139387948563917844120") };
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
public class A276315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276315.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276315Inst Instance=new A276315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276316
{
public static readonly BigInteger[] Value={ 1L,4L,31L,300L,3251L,37744L,459060L,5773548L,74474455L,979872036L,13099102575L,177414673488L,2429310288468L,33574008073120L,467717206216760L,6560977611629676L,92595131510426943L,1313820730347196300L,BigInteger.Parse("18730821529411507725"),BigInteger.Parse("268185082351558093260") };
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
public class A276316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276316.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276316Inst Instance=new A276316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276317
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,4L,1L,2L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,4L,2L,2L,1L,2L,1L,4L,1L,1L,1L,1L,5L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,5L,2L,1L,1L,3L,2L,2L,3L,1L,1L,1L,1L };
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
public class A276317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276317Inst : IEnumerable<long>
{
public static readonly long[] Value=A276317.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276317.Bytes);
public long this[int i]=>Value[i];

public static A276317Inst Instance=new A276317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276318
{
public static readonly long[] Value={ 1L,17L,89L,79L,321L,49L,23L,20L,139L,87L,26L,48L,41L,56L,75L,88L,38L,81L,49L,134L,196L,78L,68L,114L,155L,65L,552L,111L,80L,349L,103L,104L,142L,192L,110L,342L,123L,359L,395L,249L,83L,349L,101L,74L,481L,292L,219L,1110L,189L,128L,309L,243L,224L,629L,356L,170L,208L };
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
public class A276318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276318Inst : IEnumerable<long>
{
public static readonly long[] Value=A276318.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276318.Bytes);
public long this[int i]=>Value[i];

public static A276318Inst Instance=new A276318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276319
{
public static readonly long[] Value={ 1L,4L,9L,21L,10L,50L,27L,24L,36L,41L,25L,42L,54L,51L,147L,115L,34L,100L,61L,40L,133L,87L,55L,132L,121L,100L,102L,144L,46L,171L,167L,52L,89L,126L,82L,318L,122L,148L,121L,236L,85L,177L,144L,145L,216L,205L,115L,299L,216L,115L,206L,300L,94L,211L,246L,154L,192L,399L };
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
public class A276319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276319Inst : IEnumerable<long>
{
public static readonly long[] Value=A276319.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276319.Bytes);
public long this[int i]=>Value[i];

public static A276319Inst Instance=new A276319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276320
{
public static readonly long[] Value={ 1L,2L,5L,4L,5L,6L,8L,12L,9L,10L,12L,15L,13L,15L,15L,16L,17L,18L,20L,21L,21L,24L,30L,30L,25L,26L,29L,28L,33L,30L,32L,32L,36L,35L,35L,36L,39L,44L,42L,45L,42L,45L,45L,48L,45L,46L,47L,60L,50L,51L,53L,54L,57L,54L,56L,63L,63L,58L,59L,60L,62L,63L,72L,65L,69L,66L,70L,68L };
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
public class A276320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276320Inst : IEnumerable<long>
{
public static readonly long[] Value=A276320.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276320.Bytes);
public long this[int i]=>Value[i];

public static A276320Inst Instance=new A276320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276321
{
public static readonly long[] Value={ 1L,-1L,1L,1L,0L,1L,-2L,1L,-2L,2L,0L,1L,1L,0L,-1L,3L,-3L,1L,3L,-6L,3L,0L,-3L,0L,3L,0L,1L,4L,1L,0L,1L,-4L,6L,-4L,1L,-4L,12L,-12L,4L,0L,6L,-6L,-6L,6L,0L,-4L,-12L,12L,4L,0L,1L,11L,11L,1L,0L,-1L,5L,-10L,10L,-5L,1L,5L,-20L,30L,-20L,5L,0L,-10L,20L,0L,-20L,10L,0L,10L };
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
public class A276321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276321Inst : IEnumerable<long>
{
public static readonly long[] Value=A276321.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276321.Bytes);
public long this[int i]=>Value[i];

public static A276321Inst Instance=new A276321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276322
{
public static readonly long[] Value={ 1L,2L,5L,7L,17L,18L,25L,60L,64L,66L,118L,125L,1021L,1901L,2273L,2524L,6048L,7098L,8281L,11634L,13843L,16098L,18652L,18661L,20570L,32291L,34181L,59928L,65297L,86546L };
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
public class A276322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276322Inst : IEnumerable<long>
{
public static readonly long[] Value=A276322.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276322.Bytes);
public long this[int i]=>Value[i];

public static A276322Inst Instance=new A276322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276323
{
public static readonly BigInteger[] Value={ 4382314L,59821998476834L,338197165389273486L,BigInteger.Parse("17314015796594772560245514"),BigInteger.Parse("145853326344012138627669357202"),BigInteger.Parse("12936469013977571458378002436843685186"),BigInteger.Parse("15931675838688077485749893663903436780403973163302") };
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
public class A276323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276323Inst Instance=new A276323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276356
{
public static readonly BigInteger[] Value={ 0L,1L,3L,30L,480L,12000L,430920L,21052080L,1343381760L,108519626880L,10825535952000L,1307042125804800L,187849403155814400L,BigInteger.Parse("31691651643235584000"),BigInteger.Parse("6201948133744691328000"),BigInteger.Parse("1393497414722424211200000"),BigInteger.Parse("356287752381703180566528000"),BigInteger.Parse("102850159977463464656842752000") };
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
public class A276356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276356Inst Instance=new A276356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276357
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,29L,31L,37L,41L,47L,53L,59L,61L,67L,71L,89L,97L,101L,109L,127L,131L,137L,149L,151L,157L,167L,179L,181L,197L,211L,229L,239L,241L,257L,269L,277L,281L,307L,311L,347L,349L,379L,389L,397L,409L,421L,431L,439L,449L,461L,467L,479L,509L,547L,571L,577L,587L };
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
public class A276357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276357Inst : IEnumerable<long>
{
public static readonly long[] Value=A276357.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276357.Bytes);
public long this[int i]=>Value[i];

public static A276357Inst Instance=new A276357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276358
{
public static readonly BigInteger[] Value={ 1L,2L,8L,46L,324L,2608L,23136L,221370L,2252872L,24153284L,270922880L,3163154736L,38291322000L,479133266432L,6181998751808L,82084129578414L,1119798740473788L,15674024566862424L,224843628257016920L,3302256609111585300L,BigInteger.Parse("49613275311027132672"),BigInteger.Parse("761926428688868584400"),BigInteger.Parse("11952618573953745931536"),BigInteger.Parse("191418290850831848697272"),BigInteger.Parse("3127755564602007721663352"),BigInteger.Parse("52118116918762815035493760"),BigInteger.Parse("885205781290692080951844800"),BigInteger.Parse("15318116453244882343710519680"),BigInteger.Parse("269953482313408263924956600000") };
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
public class A276358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276358.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276358Inst Instance=new A276358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276359
{
public static readonly BigInteger[] Value={ 1L,2L,-6L,16L,40L,-1584L,22848L,-225280L,600192L,44396800L,-1523498240L,31443941376L,-357889339392L,-5030773006336L,467652196515840L,-17115736054956032L,388873431035969536L,-1662253670610173952L,BigInteger.Parse("-382618979322190036992"),BigInteger.Parse("24489375062323586662400"),BigInteger.Parse("-916370270070354027479040"),BigInteger.Parse("17644844659792321770422272"),BigInteger.Parse("514235938004598573701791744"),BigInteger.Parse("-72370532086290923862783688704"),BigInteger.Parse("4192091239711955879273378611200") };
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
public class A276359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276359.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276359Inst Instance=new A276359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276360
{
public static readonly BigInteger[] Value={ 1L,3L,24L,276L,3858L,61092L,1056816L,19550475L,381543576L,7782820548L,164842646424L,3607654164924L,81281990795520L,1879865970374568L,44527769989124976L,1078220967132218616L,BigInteger.Parse("26650484274297181896"),BigInteger.Parse("671558570413109457264"),BigInteger.Parse("17234310756238557856200"),BigInteger.Parse("450044549619831325213920"),BigInteger.Parse("11949386806898017225833312"),BigInteger.Parse("322394088574898542428753168"),BigInteger.Parse("8833647058171126097908059720") };
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
public class A276360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276360.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276360Inst Instance=new A276360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276361
{
public static readonly BigInteger[] Value={ 1L,3L,30L,447L,8202L,171846L,3956796L,97916895L,2567551890L,70655670690L,2026596875268L,60282027684678L,1852444347792036L,58633762133405100L,1907098496516434680L,BigInteger.Parse("63620675921801106495"),BigInteger.Parse("2173457638433471757282"),BigInteger.Parse("75940916632597398212298"),BigInteger.Parse("2710857429948875567968692"),BigInteger.Parse("98775527832178103444182722"),BigInteger.Parse("3670845430153146908693608044"),BigInteger.Parse("139047871842184594320103381524"),BigInteger.Parse("5365224711989826990651317756232") };
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
public class A276361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276361Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276361.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276361.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276361Inst Instance=new A276361Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276362
{
public static readonly BigInteger[] Value={ 1L,4L,40L,564L,9592L,184008L,3844624L,85700980L,2011283640L,49248127800L,1250064156912L,32736194249256L,881252194701616L,24317581366876880L,686300288661644960L,BigInteger.Parse("19774058901706750100"),BigInteger.Parse("580795172081872246232"),BigInteger.Parse("17368587281321383296184"),BigInteger.Parse("528294942152813411073968"),BigInteger.Parse("16329939570298980826852824"),BigInteger.Parse("512590568042639978453793744"),BigInteger.Parse("16329084800479729420462546352"),BigInteger.Parse("527621994750854274463428080608") };
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
public class A276362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276362Inst Instance=new A276362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276363
{
public static readonly BigInteger[] Value={ 1L,4L,56L,1172L,30248L,892296L,28951344L,1010322900L,37384819496L,1452697058744L,58872642043856L,2475764515398568L,107619880380347920L,4821324372637921744L,BigInteger.Parse("222077355203506939104"),BigInteger.Parse("10497354682052048593332"),BigInteger.Parse("508414637258604924680136"),BigInteger.Parse("25197644191294099697736312"),BigInteger.Parse("1276547957544912412461457680"),BigInteger.Parse("66046883289153773427379134360"),BigInteger.Parse("3487101507192780951408327918192") };
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
public class A276363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276363Inst Instance=new A276363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276364
{
public static readonly BigInteger[] Value={ 1L,2L,18L,252L,4410L,88734L,1969668L,47104056L,1195658550L,31891944750L,887565934494L,25639389304560L,765765781572600L,23574635888791804L,746297727831434376L,BigInteger.Parse("24247096863466015152"),BigInteger.Parse("807243935471150901066"),BigInteger.Parse("27503153109167182217082"),BigInteger.Parse("957899411829034037383374"),BigInteger.Parse("34073454839478198669105444"),BigInteger.Parse("1236879534288183156526996062"),BigInteger.Parse("45788365378826408823663436974"),BigInteger.Parse("1727576456033196960394178300184") };
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
public class A276364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276364Inst Instance=new A276364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276365
{
public static readonly BigInteger[] Value={ 1L,1L,6L,53L,578L,7234L,100044L,1495125L,23802346L,399740086L,7032766196L,128952474242L,2454645604820L,48359400068836L,983683769369624L,20618782389897333L,444636132851851386L,9851377271964349038UL,BigInteger.Parse("223998085060636514020"),BigInteger.Parse("5221799494107885481430"),BigInteger.Parse("124695762315403816775932"),BigInteger.Parse("3047952254964607540099676"),BigInteger.Parse("76206565881709345978097960"),BigInteger.Parse("1947752912315470845518308642"),BigInteger.Parse("50860833685759573411702643972") };
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
public class A276365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276365Inst Instance=new A276365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276366
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,57L,300L,1697L,10126L,62991L,405247L,2680901L,18160444L,125562250L,883868590L,6321838520L,45869309028L,337167193262L,2508018933431L,18861358215299L,143293615189089L,1098997404472941L,8504070741463729L,66358269984208701L,521923129718567918L,4136089275165532156L,BigInteger.Parse("33013640650845937124"),BigInteger.Parse("265327447542771171442"),BigInteger.Parse("2146523712216171643254"),BigInteger.Parse("17476155589169506029235"),BigInteger.Parse("143157977185505919650474") };
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
public class A276366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276366Inst Instance=new A276366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276367
{
public static readonly BigInteger[] Value={ 1L,2L,8L,46L,322L,2564L,22482L,213358L,2170856L,23563266L,272229894L,3345403228L,43736868406L,608546129090L,9012054592672L,141977836757366L,2376612322575818L,42191783298374292L,792519258202255050L,15709695283993859430UL,BigInteger.Parse("327743321824492243272"),BigInteger.Parse("7177487348025844367658"),BigInteger.Parse("164595689482728908058190"),BigInteger.Parse("3943617273778939651118764"),BigInteger.Parse("98517855256524601996722238"),BigInteger.Parse("2561403841975017528679295466"),BigInteger.Parse("69192589389178960801205055872") };
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
public class A276367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276367Inst Instance=new A276367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276368
{
public static readonly BigInteger[] Value={ 1L,3L,9L,36L,135L,567L,2268L,9720L,40095L,173745L,729729L,3184272L,13533156L,59337684L,254304360L,1118939184L,4825425231L,21288640725L,92250776475L,407845538100L,1774128090735L,7856852973255L,34284449337840L,152044079672160L,665192848565700L,2953456247631708L,12949769701154412L,57554532005130720L,252828837022538520L,1124652412962326520L,4948470617034236688L,BigInteger.Parse("22028675650023376224") };
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
public class A276368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276368Inst Instance=new A276368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276369
{
public static readonly BigInteger[] Value={ 1L,4L,44L,752L,16816L,454592L,14220544L,501063680L,19533484800L,832009583616L,38365992894464L,1901932780019712L,100804751520935936L,5686686095781380096L,BigInteger.Parse("340176827135446794240"),BigInteger.Parse("21509238608517787746304"),BigInteger.Parse("1433513317187764470480896"),BigInteger.Parse("100449987626468857028280320"),BigInteger.Parse("7383974661633670900631207936"),BigInteger.Parse("568236929745579099067135295488"),BigInteger.Parse("45692685682319633001834926309376"),BigInteger.Parse("3832507849368533459019374474035200"),BigInteger.Parse("334760552511190172092790344295383040") };
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
public class A276369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276369Inst Instance=new A276369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276370
{
public static readonly BigInteger[] Value={ 1L,2L,9L,56L,420L,3572L,33328L,334354L,3559310L,39838760L,465743720L,5658983108L,71191948512L,924554859776L,12365546196641L,169995491295312L,2398380272232272L,34680290150700800L,513390937937217088L,7773229533145403728L,BigInteger.Parse("120277760289804227632"),BigInteger.Parse("1900583166564027019136"),BigInteger.Parse("30649888151334972466392"),BigInteger.Parse("504153517331248726221392"),BigInteger.Parse("8454018409655883681321232"),BigInteger.Parse("144451967918022160558965408") };
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
public class A276370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276370Inst Instance=new A276370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276371
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,177L,2161L,32643L,587539L,12273537L,291853441L,7782998883L,230028553459L,7462717994097L,263654454838321L,10075889406229923L,414147167601017779L,18217983822073897857UL,BigInteger.Parse("853975145498805244801"),BigInteger.Parse("42495107452208870429763"),BigInteger.Parse("2237264405984004517212499"),BigInteger.Parse("124243242448367338311920817"),BigInteger.Parse("7258224393227482972980320881"),BigInteger.Parse("444967879322677755285771182403"),BigInteger.Parse("28563002475012109334240250609619") };
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
public class A276371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276371Inst Instance=new A276371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276436
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,0L,1L,6L,0L,6L,6L,24L,15L,26L,48L,56L,240L,60L,303L,504L,780L,1002L,1776L,3246L,3601L,7826L,7500L,18980L,26874L,38130L,56196L,99360L,153636L,210084L,390348L,486420L,900428L,1310118L,2064612L,3073008L,4825138L,7558008L,11428162L,18596886L,26006031L,43625940L,65162736L,100027728L,152897710L,242895050L };
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
public class A276436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276436Inst : IEnumerable<long>
{
public static readonly long[] Value=A276436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276436.Bytes);
public long this[int i]=>Value[i];

public static A276436Inst Instance=new A276436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276437
{
public static readonly long[] Value={ 19L,25L,31L,49L,55L,59L,73L,77L,79L,85L,91L,101L,103L,109L,113L,115L,119L,121L,133L,137L,139L,143L,145L,151L,161L,163L,167L,169L,175L,187L,191L,197L,199L,203L,205L,209L,221L,229L,235L,241L,247L,251L,253L,259L,263L,265L,269L,271L,281L,287L,289L,293L,295L,299L,301L,311L,317L,319L,323L,325L,329L,341L,343L,347L,349L,355L,361L };
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
public class A276437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276437Inst : IEnumerable<long>
{
public static readonly long[] Value=A276437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276437.Bytes);
public long this[int i]=>Value[i];

public static A276437Inst Instance=new A276437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276438
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,2L,1L,-1L,-1L,2L,1L,-1L,1L,-1L,-1L,2L,1L,-1L,-1L,-1L,1L,-1L,2L,1L,-1L,-1L,2L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,2L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,2L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L };
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
public class A276438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276438Inst : IEnumerable<long>
{
public static readonly long[] Value=A276438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276438.Bytes);
public long this[int i]=>Value[i];

public static A276438Inst Instance=new A276438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276439
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,6L,5L,7L,8L,7L,6L,8L,9L,8L,9L,8L,7L,9L,10L,9L,8L,7L,8L,7L,9L,10L,9L,8L,10L,11L,10L,9L,8L,7L,8L,7L,8L,7L,8L,7L,8L,9L,10L,9L,10L,9L,8L,10L,11L,10L,9L,8L,9L,8L,9L,10L,11L,10L,9L,8L,9L,8L,10L,11L,10L,11L,10L,9L,8L,9L,10L,11L,10L,11L,12L,13L,12L,11L,10L,9L,8L,9L,10L };
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
public class A276439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276439Inst : IEnumerable<long>
{
public static readonly long[] Value=A276439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276439.Bytes);
public long this[int i]=>Value[i];

public static A276439Inst Instance=new A276439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276440
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,3L,13L,7L,5L,2L,17L,3L,1L,5L,7L,11L,23L,3L,25L,13L,3L,7L,29L,5L,1L,2L,11L,17L,7L,3L,37L,2L,13L,5L,41L,7L,43L,11L,5L,23L,47L,3L,7L,25L,17L,13L,53L,3L,11L,7L,3L,29L,1L,5L,61L,2L,7L,2L,13L,11L,67L,17L,23L,7L,71L,3L,1L,37L,25L,2L,77L,13L,1L,5L,3L,41L,83L,7L,17L,43L,29L,11L,89L,5L,91L,23L,3L,47L };
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
public class A276440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276440Inst : IEnumerable<long>
{
public static readonly long[] Value=A276440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276440.Bytes);
public long this[int i]=>Value[i];

public static A276440Inst Instance=new A276440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276441
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,4L,5L,15L,14L,12L,8L,13L,10L,9L,11L,31L,30L,28L,24L,16L,29L,26L,20L,25L,18L,17L,27L,22L,21L,19L,23L,63L,62L,60L,56L,48L,32L,61L,58L,52L,40L,57L,50L,36L,49L,34L,33L,59L,54L,44L,53L,42L,41L,51L,38L,37L,35L,55L,46L,45L,43L,39L,47L,127L,126L,124L,120L,112L,96L,64L,125L,122L,116L,104L,80L,121L,114L,100L,72L,113L,98L };
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
public class A276441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276441Inst : IEnumerable<long>
{
public static readonly long[] Value=A276441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276441.Bytes);
public long this[int i]=>Value[i];

public static A276441Inst Instance=new A276441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276442
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,5L,4L,11L,14L,13L,15L,10L,12L,9L,8L,20L,26L,25L,30L,23L,29L,28L,31L,19L,24L,22L,27L,18L,21L,17L,16L,37L,47L,46L,57L,44L,56L,55L,62L,41L,53L,52L,61L,50L,60L,59L,63L,36L,45L,43L,54L,40L,51L,49L,58L,35L,42L,39L,48L,34L,38L,33L,32L,70L,85L,84L,105L,82L,104L,103L,120L,79L,101L,100L,119L,98L,118L,117L,126L,75L,95L,94L };
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
public class A276442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276442Inst : IEnumerable<long>
{
public static readonly long[] Value=A276442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276442.Bytes);
public long this[int i]=>Value[i];

public static A276442Inst Instance=new A276442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276443
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,11L,15L,13L,14L,16L,17L,18L,20L,24L,19L,23L,30L,21L,27L,25L,22L,29L,31L,26L,28L,32L,33L,34L,36L,40L,48L,35L,39L,46L,60L,37L,43L,54L,41L,51L,49L,38L,45L,58L,47L,63L,61L,42L,53L,55L,50L,44L,57L,59L,62L,52L,56L,64L,65L,66L,68L,72L,80L,96L,67L,71L,78L,92L,120L,69L,75L,86L,108L,73L,83L,102L,81L };
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
public class A276443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276443Inst : IEnumerable<long>
{
public static readonly long[] Value=A276443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276443.Bytes);
public long this[int i]=>Value[i];

public static A276443Inst Instance=new A276443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276444
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,11L,14L,15L,13L,16L,17L,18L,21L,19L,24L,27L,22L,20L,26L,30L,25L,31L,28L,23L,29L,32L,33L,34L,38L,35L,42L,48L,39L,36L,45L,54L,43L,58L,49L,40L,51L,37L,47L,57L,46L,62L,55L,44L,56L,63L,59L,50L,60L,41L,53L,61L,52L,64L,65L,66L,71L,67L,76L,86L,72L,68L,80L,96L,77L,106L,87L,73L,90L,69L,83L,102L,81L };
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
public class A276444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276444Inst : IEnumerable<long>
{
public static readonly long[] Value=A276444.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276444.Bytes);
public long this[int i]=>Value[i];

public static A276444Inst Instance=new A276444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276445
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,4L,5L,12L,13L,14L,8L,15L,11L,9L,10L,24L,25L,26L,28L,16L,27L,31L,22L,29L,19L,17L,30L,21L,23L,18L,20L,48L,49L,50L,52L,56L,32L,51L,55L,62L,44L,53L,59L,38L,57L,35L,33L,54L,61L,42L,63L,47L,45L,58L,37L,39L,34L,60L,41L,43L,46L,36L,40L,96L,97L,98L,100L,104L,112L,64L,99L,103L,110L,124L,88L,101L,107L,118L,76L,105L,115L,70L };
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
public class A276445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276445Inst : IEnumerable<long>
{
public static readonly long[] Value=A276445.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276445.Bytes);
public long this[int i]=>Value[i];

public static A276445Inst Instance=new A276445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276446
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,4L,5L,11L,14L,15L,13L,8L,9L,10L,12L,20L,26L,30L,25L,31L,28L,23L,29L,16L,17L,18L,21L,19L,24L,27L,22L,37L,47L,57L,46L,62L,55L,44L,56L,63L,59L,50L,60L,41L,53L,61L,52L,32L,33L,34L,38L,35L,42L,48L,39L,36L,45L,54L,43L,58L,49L,40L,51L,70L,85L,105L,84L,120L,103L,82L,104L,126L,117L,98L,118L,79L,101L,119L,100L,127L,122L,108L,123L,89L };
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
public class A276446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276446Inst : IEnumerable<long>
{
public static readonly long[] Value=A276446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276446.Bytes);
public long this[int i]=>Value[i];

public static A276446Inst Instance=new A276446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276447
{
public static readonly long[] Value={ 19L,31L,49L,59L,73L,79L,101L,103L,109L,113L,137L,139L,151L,163L,167L,169L,191L,197L,199L,229L,241L,251L,259L,263L,269L,271L,281L,289L,293L,299L,311L,317L,319L,323L,347L,349L,367L,373L,379L,391L,401L,409L,439L,443L,449L,451L,457L,461L,469L,479L,487L,491L,499L,521L,523L,529L,533L,547L,557L,559L,563L,569L,571L,583L,587L,589L,599L,601L };
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
public class A276447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276447Inst : IEnumerable<long>
{
public static readonly long[] Value=A276447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276447.Bytes);
public long this[int i]=>Value[i];

public static A276447Inst Instance=new A276447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276448
{
public static readonly long[] Value={ 25L,55L,77L,85L,91L,115L,119L,121L,133L,143L,145L,161L,175L,187L,203L,205L,209L,221L,235L,247L,253L,265L,287L,295L,301L,325L,329L,341L,343L,355L,361L,371L,377L,385L,403L,407L,413L,415L,437L,445L,473L,475L,481L,493L,497L,505L,511L,517L,527L,535L,539L,551L,553L,565L,581L,595L,623L,625L,655L,667L,671L,685L,697L,703L,707L,713L,715L,721L };
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
public class A276448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276448Inst : IEnumerable<long>
{
public static readonly long[] Value=A276448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276448.Bytes);
public long this[int i]=>Value[i];

public static A276448Inst Instance=new A276448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276449
{
public static readonly long[] Value={ 1L,0L,0L,4L,6L,0L,0L,120L,190L,0L,0L,7140L,11480L,0L,0L,635376L,1028790L,0L,0L,75287520L,122391522L,0L,0L,11143364232L,18161699556L,0L,0L,1978369382080L,3230129794320L,0L,0L,409663695276000L,669741609663270L,0L,0L,96930293990660064L,158625578809472060L };
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
public class A276449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276449Inst : IEnumerable<long>
{
public static readonly long[] Value=A276449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276449.Bytes);
public long this[int i]=>Value[i];

public static A276449Inst Instance=new A276449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276450
{
public static readonly long[] Value={ 1L,9L,59L,169L,339L,641L,1075L,1617L,2381L,3355L,4533L,5939L,7645L,9651L,11933L,14581L,17631L,21053L,24871L,29109L,33863L,39061L,44775L,51023L,57817L,65247L,73193L,81847L,91113L,101063L,111691L,123081L,135155L,148081L,161763L,176249L,191611L,207777L,224861L,242899L,261837L,281627L,302653L,324555L,347405L,371389L,396495L };
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
public class A276450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276450Inst : IEnumerable<long>
{
public static readonly long[] Value=A276450.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276450.Bytes);
public long this[int i]=>Value[i];

public static A276450Inst Instance=new A276450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276451
{
public static readonly long[] Value={ 0L,1L,2L,12L,30L,408L,1012L,17920L,45600L,1059380L,2730756L,78115884L,203235032L,6917206576L,18113945256L,714851008512L,1881039165696L,84449819514060L,223049005408900L,11225502116862880L,29736777118603962L,1658138369930988088L,4403069737450280832L };
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
public class A276451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276451Inst : IEnumerable<long>
{
public static readonly long[] Value=A276451.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276451.Bytes);
public long this[int i]=>Value[i];

public static A276451Inst Instance=new A276451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276468
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,1L,4L,2L,1L,7L,3L,1L,7L,6L,1L,1L,12L,8L,1L,1L,12L,12L,4L,1L,1L,19L,16L,5L,1L,1L,19L,25L,8L,2L,1L,1L,30L,34L,9L,2L,1L,1L,30L,44L,17L,6L,2L,1L,1L,45L,59L,20L,7L,2L,1L,1L,45L,81L,31L,12L,3L,2L,1L,1L,67L,108L,36L,13L,3L,2L,1L,1L,67L,132L,64L,18L,9L };
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
public class A276468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276468Inst : IEnumerable<long>
{
public static readonly long[] Value=A276468.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276468.Bytes);
public long this[int i]=>Value[i];

public static A276468Inst Instance=new A276468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276469
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,2L,1L,2L,1L,0L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,5L,1L,1L,1L,1L,5L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A276469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276469Inst : IEnumerable<long>
{
public static readonly long[] Value=A276469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276469.Bytes);
public long this[int i]=>Value[i];

public static A276469Inst Instance=new A276469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276470
{
public static readonly long[] Value={ 1L,3L,4L,5L,11L,15L,18L,37L,41L,58L,60L,87L,117L,118L,214L,265L,334L,355L,450L,655L,1695L,1734L,2183L,3913L,25313L,32865L };
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
public class A276470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276470Inst : IEnumerable<long>
{
public static readonly long[] Value=A276470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276470.Bytes);
public long this[int i]=>Value[i];

public static A276470Inst Instance=new A276470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276471
{
public static readonly long[] Value={ -61L,-59L,-53L,-43L,-29L,-11L,11L,37L,67L,101L,139L,181L,227L,277L,331L,389L,587L,661L,739L,821L,907L,997L,1091L,1291L,1621L,1861L,1987L,2251L,2389L,2531L,2677L,3301L,3467L,3637L,3989L,4357L,4547L,5347L,5557L,6211L,7877L,8389L,9187L,9461L,9739L,10597L,10891L,11491L,12107L,12421L,12739L };
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
public class A276471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276471Inst : IEnumerable<long>
{
public static readonly long[] Value=A276471.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276471.Bytes);
public long this[int i]=>Value[i];

public static A276471Inst Instance=new A276471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276472
{
public static readonly long[] Value={ 1L,1L,2L,4L,3L,5L,11L,7L,8L,13L,29L,18L,15L,21L,34L,76L,47L,33L,36L,55L,89L,199L,123L,80L,69L,91L,144L,233L,521L,322L,203L,149L,160L,235L,377L,610L,1364L,843L,525L,352L,309L,395L,612L,987L,1597L,3571L,2207L,1368L,877L,661L,704L,1007L,1599L,2584L,4181L };
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
public class A276472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276472Inst : IEnumerable<long>
{
public static readonly long[] Value=A276472.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276472.Bytes);
public long this[int i]=>Value[i];

public static A276472Inst Instance=new A276472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276473
{
public static readonly long[] Value={ 6L,38L,320L,2819L,25668L,237586L,2224574L,21007948L };
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
public class A276473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276473Inst : IEnumerable<long>
{
public static readonly long[] Value=A276473.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276473.Bytes);
public long this[int i]=>Value[i];

public static A276473Inst Instance=new A276473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276474
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,-5L,15L,87L,-609L,-8337L,125055L,2695455L,-83559105L,-4212669825L,265398198975L,22347926076735L,-2838186611745345L,-560679228377509185L,BigInteger.Parse("142973203236264842175"),BigInteger.Parse("47858338570309251530175"),BigInteger.Parse("-24455611009428027531919425"),BigInteger.Parse("-19225279650279123532147010625") };
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
public class A276474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276474.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276474Inst Instance=new A276474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276475
{
public static readonly BigInteger[] Value={ 0L,-1L,1L,3L,-9L,-69L,483L,5355L,-80325L,-2081205L,64517355L,2738408715L,-172519749045L,-17158004483445L,2179066569397515L,365466952872801675L,BigInteger.Parse("-93194072982564427125"),BigInteger.Parse("-36694334101466364023925"),BigInteger.Parse("18750804725849312016225675") };
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
public class A276475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276475Inst Instance=new A276475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276476
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,9L,13L,11L,17L,20L,17L,10L,32L,16L,23L,26L,30L,25L,21L,55L,38L,30L,27L,25L,34L,57L,19L,83L,49L,44L,40L,39L,60L,37L,77L,54L,57L,27L,43L,79L,67L,45L,110L,42L,93L,79L,79L,43L,85L,46L,90L,96L,41L,54L,96L,127L,107L,63L,78L,181L,67L,78L,72L,189L,51L,77L,103L };
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
public class A276476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276476Inst : IEnumerable<long>
{
public static readonly long[] Value=A276476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276476.Bytes);
public long this[int i]=>Value[i];

public static A276476Inst Instance=new A276476Inst();

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