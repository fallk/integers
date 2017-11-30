using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A108341
{
public static readonly long[] Value={ 6L,8L,18L,30L,36L,38L,44L,66L,78L,90L,98L,104L,116L,134L,140L,144L,156L,164L,168L,170L,200L,228L,230L,246L,248L,260L,276L,296L,318L,344L,354L,374L,378L,380L,386L,408L,420L,426L,450L,464L,468L,480L,500L,510L,546L,576L,578L,584L,606L,608L,618L,620L,630L,654L,678L };
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
public class A108341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108341Inst : IEnumerable<long>
{
public static readonly long[] Value=A108341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108341.Bytes);
public long this[int i]=>Value[i];

public static A108341Inst Instance=new A108341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108342
{
public static readonly long[] Value={ 2L,20L,26L,36L,42L,44L,62L,102L,116L,140L,144L,146L,174L,180L,182L,194L,216L,282L,284L,300L,314L,330L,336L,372L,386L,440L,450L,462L,476L,480L,494L,506L,510L,512L,516L,572L,576L,590L,596L,606L,636L,642L,650L,680L,702L,722L,732L,746L,756L,770L,776L,782L,792L };
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
public class A108342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108342Inst : IEnumerable<long>
{
public static readonly long[] Value=A108342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108342.Bytes);
public long this[int i]=>Value[i];

public static A108342Inst Instance=new A108342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108343
{
public static readonly long[] Value={ 100L,105L,108L,110L,120L,121L,130L,132L,135L,140L,143L,150L,154L,160L,165L,170L,176L,180L,187L,190L,192L,195L,198L,200L,220L,225L,231L,240L,242L,253L,260L,264L,275L,280L,286L,297L,300L,315L,330L,341L,352L,360L,363L,374L,385L,390L,396L,400L,405L,440L,451L };
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
public class A108343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108343Inst : IEnumerable<long>
{
public static readonly long[] Value=A108343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108343.Bytes);
public long this[int i]=>Value[i];

public static A108343Inst Instance=new A108343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108344
{
public static readonly long[] Value={ 114L,1368L,1152L,232L,3336L,1872L,1206L,228L,1780L,1318L,700L,1038L,3534L,6652L,192L,1948L };
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
public class A108344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108344Inst : IEnumerable<long>
{
public static readonly long[] Value=A108344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108344.Bytes);
public long this[int i]=>Value[i];

public static A108344Inst Instance=new A108344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108345
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,8L,9L,13L,17L,18L,23L,27L,29L,31L,32L,35L,37L,39L,41L,45L,47L,49L,50L,53L,55L,59L,61L,63L,71L,72L,73L,79L,81L,83L,87L,89L,91L,97L,98L,101L,103L,107L,109L,113L,115L,117L,121L,127L,128L,137L,139L,149L,151L,153L,157L,159L,162L,167L,171L,173L,181L,183L,191L };
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
public class A108345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108345Inst : IEnumerable<long>
{
public static readonly long[] Value=A108345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108345.Bytes);
public long this[int i]=>Value[i];

public static A108345Inst Instance=new A108345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108346
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,7L,7L,4L,4L,15L,6L,7L,15L,6L,7L,5L,5L,21L,31L,14L,31L,15L,12L,31L,21L,8L,15L,31L,14L,31L,31L,6L,6L,63L,14L,31L,9L,28L,31L,15L,14L,21L,8L,21L,31L,63L,15L,30L,63L,10L,21L,63L,28L,12L,63L,31L,31L,63L,21L,12L,15L,31L,30L,7L,7L,127L,93L,60L,127L,15L,62L,127L,127L,62L };
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
public class A108346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108346Inst : IEnumerable<long>
{
public static readonly long[] Value=A108346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108346.Bytes);
public long this[int i]=>Value[i];

public static A108346Inst Instance=new A108346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108347
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,15L,21L,25L,27L,35L,45L,49L,63L,75L,81L,105L,125L,135L,147L,175L,189L,225L,243L,245L,315L,343L,375L,405L,441L,525L,567L,625L,675L,729L,735L,875L,945L,1029L,1125L,1215L,1225L,1323L,1575L,1701L,1715L,1875L,2025L,2187L,2205L,2401L,2625L,2835L,3087L };
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
public class A108347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108347Inst : IEnumerable<long>
{
public static readonly long[] Value=A108347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108347.Bytes);
public long this[int i]=>Value[i];

public static A108347Inst Instance=new A108347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108348
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,12L,13L,14L,15L,18L,20L,24L,30L,31L,32L,38L,40L,42L,44L,48L,54L,57L,60L,62L,63L,68L,72L,74L,80L,84L,90L,98L,102L,104L,108L,110L,114L,121L,127L,128L,132L,133L,138L,140L,150L,152L,156L,158L,164L,168L,174L,180L,182L,183L,192L,194L,198L,200L };
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
public class A108348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108348Inst : IEnumerable<long>
{
public static readonly long[] Value=A108348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108348.Bytes);
public long this[int i]=>Value[i];

public static A108348Inst Instance=new A108348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108349
{
public static readonly BigInteger[] Value={ 1L,1L,2L,24L,25920L,1511654400000L,BigInteger.Parse("11882514930204672000000000000000"),BigInteger.Parse("3711388892113415871206624306663300844748800000000000000000000000000000000000") };
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
public class A108349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108349Inst Instance=new A108349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108350
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,7L,4L,1L,1L,5L,13L,13L,5L,1L,1L,6L,21L,32L,21L,6L,1L,1L,7L,31L,65L,65L,31L,7L,1L,1L,8L,43L,116L,161L,116L,43L,8L,1L,1L,9L,57L,189L,341L,341L,189L,57L,9L,1L,1L,10L,73L,288L,645L,842L,645L,288L,73L,10L,1L,1L,11L,91L,417L,1121L,1827L,1827L,1121L,417L,91L };
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
public class A108350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108350Inst : IEnumerable<long>
{
public static readonly long[] Value=A108350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108350.Bytes);
public long this[int i]=>Value[i];

public static A108350Inst Instance=new A108350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108351
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,14L,24L,43L,77L,140L,255L,467L,856L,1572L,2888L,5309L,9761L,17950L,33011L,60713L,111664L,205378L,377744L,694775L,1277885L,2350392L,4323039L,7951303L,14624720L,26899048L,49475056L,90998809L,167372897L,307846746L };
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
public class A108351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108351Inst : IEnumerable<long>
{
public static readonly long[] Value=A108351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108351.Bytes);
public long this[int i]=>Value[i];

public static A108351Inst Instance=new A108351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108352
{
public static readonly long[] Value={ 1L,0L,2L,2L,2L,0L,2L,2L,0L,0L,2L,0L,2L,0L,2L,2L,2L,0L,2L,3L,2L,0L,2L,3L,2L,0L,2L,3L,2L,0L,2L,2L,2L,0L,2L,0L,2L,0L,2L,0L,2L,0L,2L,3L,0L,0L,2L,3L,2L,0L,2L,3L,2L,0L,2L,3L,2L,0L,2L,0L,2L,0L,2L,2L,2L,0L,2L,3L,2L,0L,2L,0L,2L,0L,3L,3L,2L,0L,2L,3L,2L,0L,2L,0L,2L,0L,2L,3L,2L,0L,2L,3L,2L,0L,2L,3L,2L,0L,0L,2L };
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
public class A108352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108352Inst : IEnumerable<long>
{
public static readonly long[] Value=A108352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108352.Bytes);
public long this[int i]=>Value[i];

public static A108352Inst Instance=new A108352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108353
{
public static readonly long[] Value={ 2L,1L,3L,20L,756L,178200L };
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
public class A108353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108353Inst : IEnumerable<long>
{
public static readonly long[] Value=A108353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108353.Bytes);
public long this[int i]=>Value[i];

public static A108353Inst Instance=new A108353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108354
{
public static readonly long[] Value={ 1L,2L,1L,0L,2L,4L,2L,0L,3L,6L,3L,0L,4L,8L,4L,0L,5L,10L,5L,0L,6L,12L,6L,0L,7L,14L,7L,0L,8L,16L,8L,0L,9L,18L,9L,0L,10L,20L,10L,0L,11L,22L,11L,0L,12L,24L,12L,0L,13L,26L,13L,0L,14L,28L,14L,0L,15L,30L,15L,0L,16L,32L,16L,0L,17L,34L,17L,0L,18L,36L,18L,0L,19L,38L,19L,0L,20L,40L,20L,0L,21L,42L,21L,0L,22L };
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
public class A108354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108354Inst : IEnumerable<long>
{
public static readonly long[] Value=A108354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108354.Bytes);
public long this[int i]=>Value[i];

public static A108354Inst Instance=new A108354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108355
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,4L,6L,8L,7L,6L,9L,12L,10L,8L,12L,16L,13L,10L,15L,20L,16L,12L,18L,24L,19L,14L,21L,28L,22L,16L,24L,32L,25L,18L,27L,36L,28L,20L,30L,40L,31L,22L,33L,44L,34L,24L,36L,48L,37L,26L,39L,52L,40L,28L,42L,56L,43L,30L,45L,60L,46L,32L,48L,64L,49L,34L,51L,68L,52L,36L,54L,72L,55L };
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
public class A108355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108355Inst : IEnumerable<long>
{
public static readonly long[] Value=A108355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108355.Bytes);
public long this[int i]=>Value[i];

public static A108355Inst Instance=new A108355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108356
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,5L,5L,6L,6L,6L,6L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,12L,13L,13L,14L,14L,15L,15L,15L,15L,16L,16L,17L,17L,18L,18L,18L,18L,19L,19L,20L,20L,21L,21L,21L,21L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,26L,26L,27L,27L,27L,27L,28L,28L,29L,29L,30L };
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
public class A108356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108356Inst : IEnumerable<long>
{
public static readonly long[] Value=A108356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108356.Bytes);
public long this[int i]=>Value[i];

public static A108356Inst Instance=new A108356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108357
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L };
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
public class A108357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108357Inst : IEnumerable<long>
{
public static readonly long[] Value=A108357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108357.Bytes);
public long this[int i]=>Value[i];

public static A108357Inst Instance=new A108357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108358
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L };
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
public class A108358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108358Inst : IEnumerable<long>
{
public static readonly long[] Value=A108358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108358.Bytes);
public long this[int i]=>Value[i];

public static A108358Inst Instance=new A108358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108359
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,7L,14L,7L,1L,1L,9L,28L,28L,9L,1L,1L,11L,47L,76L,47L,11L,1L,1L,13L,71L,163L,163L,71L,13L,1L,1L,15L,100L,301L,433L,301L,100L,15L,1L,1L,17L,134L,502L,961L,961L,502L,134L,17L,1L,1L,19L,173L,778L,1879L,2515L,1879L,778L,173L,19L,1L,1L,21L,217L,1141L };
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
public class A108359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108359Inst : IEnumerable<long>
{
public static readonly long[] Value=A108359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108359.Bytes);
public long this[int i]=>Value[i];

public static A108359Inst Instance=new A108359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108360
{
public static readonly long[] Value={ 1L,2L,5L,12L,30L,76L,194L,496L,1267L,3230L,8215L,20844L,52768L,133304L,336100L,845888L,2125381L,5332058L,13357833L,33419820L,83510018L,208437060L,519691110L,1294430448L,3221081335L,8008262966L,19893476315L,49378623564L,122473408452L };
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
public class A108360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108360Inst : IEnumerable<long>
{
public static readonly long[] Value=A108360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108360.Bytes);
public long this[int i]=>Value[i];

public static A108360Inst Instance=new A108360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108361
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,13L,25L,47L,90L,172L,329L,629L,1202L,2294L,4374L,8330L,15847L,30115L,57172L,108434L,205473L,389019L,735927L,1391121L,2627720L,4960134L,9356707L,17639323L,33234036L,62580444L,117776828L,221542596L,416524573L,782743029L };
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
public class A108361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108361Inst : IEnumerable<long>
{
public static readonly long[] Value=A108361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108361.Bytes);
public long this[int i]=>Value[i];

public static A108361Inst Instance=new A108361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108362
{
public static readonly long[] Value={ 1L,0L,2L,1L,5L,3L,13L,8L,34L,21L,89L,55L,233L,144L,610L,377L,1597L,987L,4181L,2584L,10946L,6765L,28657L,17711L,75025L,46368L,196418L,121393L,514229L,317811L,1346269L,832040L,3524578L,2178309L,9227465L,5702887L,24157817L,14930352L,63245986L };
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
public class A108362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108362Inst : IEnumerable<long>
{
public static readonly long[] Value=A108362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108362.Bytes);
public long this[int i]=>Value[i];

public static A108362Inst Instance=new A108362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108363
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,6L,4L,1L,1L,5L,10L,10L,5L,1L,1L,6L,15L,20L,16L,6L,1L,1L,7L,21L,35L,38L,24L,7L,1L };
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
public class A108363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108363Inst : IEnumerable<long>
{
public static readonly long[] Value=A108363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108363.Bytes);
public long this[int i]=>Value[i];

public static A108363Inst Instance=new A108363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108364
{
public static readonly long[] Value={ 2L,3L,4L,10L,18L,46L,48L,121L,154L,158L,170L,196L,211L,250L,294L,316L,320L,663L,975L,1165L,1351L,4126L,4270L,5724L,7156L,15025L,19132L,25035L,36174L,77418L };
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
public class A108364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108364Inst : IEnumerable<long>
{
public static readonly long[] Value=A108364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108364.Bytes);
public long this[int i]=>Value[i];

public static A108364Inst Instance=new A108364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108365
{
public static readonly long[] Value={ 2L,5L,6L,12L,17L,19L,61L,102L,195L,447L,1250L,1329L,1935L,3930L,5837L,7176L,8724L,20881L,23936L,61868L,91920L };
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
public class A108365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108365Inst : IEnumerable<long>
{
public static readonly long[] Value=A108365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108365.Bytes);
public long this[int i]=>Value[i];

public static A108365Inst Instance=new A108365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108366
{
public static readonly BigInteger[] Value={ 1L,0L,1L,13L,153L,2089L,33461L,620166L,13097377L,310957991L,8205571449L,238367471761L,7561422605881L,260127000028908L,9647591076297901L,383769576967012081L,16299953773597203585UL,BigInteger.Parse("736281113282903567521") };
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
public class A108366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108366Inst Instance=new A108366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108367
{
public static readonly BigInteger[] Value={ 1L,-2L,5L,-29L,265L,-3191L,47321L,-832040L,16908641L,-389806471L,10049731549L,-286482047279L,8946795882025L,-303762892305614L,11140078609864049L,-438857301101610929L,BigInteger.Parse("18482410314337295233"),BigInteger.Parse("-828657053219851847135") };
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
public class A108367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108367Inst Instance=new A108367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108368
{
public static readonly long[] Value={ 0L,1L,3L,12L,46L,177L,681L,2620L,10080L,38781L,149203L,574032L,2208486L,8496757L,32689761L,125768040L,483870160L,1861604361L,7162191603L,27555258052L,106013953326L,407869825737L,1569206595241L,6037243216260L,23227219260240L,89362594024741L,343806683071203L };
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
public class A108368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108368Inst : IEnumerable<long>
{
public static readonly long[] Value=A108368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108368.Bytes);
public long this[int i]=>Value[i];

public static A108368Inst Instance=new A108368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108369
{
public static readonly long[] Value={ 0L,1L,-3L,6L,-8L,3L,21L,-80L,180L,-279L,217L,366L,-2028L,5203L,-9159L,9840L,3160L,-48159L,144837L,-286874L,377952L,-128397L,-1035539L,3869760L,-8631060L,13248361L,-9982143L,-18429714L,98483932L,-250144797L,436552881L,-460740320L,-177582480L,2351521281L };
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
public class A108369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108369Inst : IEnumerable<long>
{
public static readonly long[] Value=A108369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108369.Bytes);
public long this[int i]=>Value[i];

public static A108369Inst Instance=new A108369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108370
{
public static readonly long[] Value={ 2L,6L,9L,10L,12L,14L,18L,22L,26L,30L,34L,36L,38L,40L,42L,45L,46L,50L,54L,58L,60L,62L,66L,70L,72L,74L,78L,82L,84L,86L,90L,94L,98L,99L,102L,106L,110L,112L,114L,117L,118L,120L,122L,125L,126L,130L,132L,134L,138L,142L,144L,146L,150L,153L,154L,156L,158L,162L,166L,170L,171L };
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
public class A108370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108370Inst : IEnumerable<long>
{
public static readonly long[] Value=A108370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108370.Bytes);
public long this[int i]=>Value[i];

public static A108370Inst Instance=new A108370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108371
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,1L,2L,1L,5L,1L,1L,2L,1L,6L,1L,1L,1L,2L,1L,7L,6L,1L,1L,1L,2L,1L,8L,1L,6L,1L,1L,1L,2L,1L,9L,1L,1L,6L,1L,1L,1L,2L,1L,10L,9L,1L,1L,6L,1L,1L,1L,2L,1L,11L,10L,9L,1L,1L,6L,1L,1L,1L,2L,1L,12L,1L,10L,9L,1L,1L,6L,1L,1L,1L,2L,1L,13L,18L,1L,10L,9L,1L,1L,6L,1L,1L,1L,2L,1L,14L,1L,12L,1L,10L,9L,1L,1L,6L };
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
public class A108371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108371Inst : IEnumerable<long>
{
public static readonly long[] Value=A108371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108371.Bytes);
public long this[int i]=>Value[i];

public static A108371Inst Instance=new A108371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108372
{
public static readonly long[] Value={ 3L,4L,5L,7L,8L,11L,13L,15L,16L,17L,19L,21L,23L,25L,27L,29L,31L,32L,33L,35L,37L,39L,41L,43L,47L,49L,51L,53L,55L,57L,59L,61L,63L,64L,65L,67L,69L,71L,73L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,100L,101L,103L,105L,107L,109L,111L,113L,115L,119L,121L,123L,127L,128L,129L,131L };
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
public class A108372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108372Inst : IEnumerable<long>
{
public static readonly long[] Value=A108372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108372.Bytes);
public long this[int i]=>Value[i];

public static A108372Inst Instance=new A108372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108373
{
public static readonly long[] Value={ 20L,24L,28L,44L,48L,52L,56L,68L,75L,76L,80L,88L,92L,96L,104L,108L,116L,124L,135L,136L,140L,147L,148L,152L,160L,164L,168L,172L,176L,184L,188L,192L,200L,208L,212L,220L,224L,232L,236L,240L,244L,248L,260L,264L,268L,272L,284L,292L,296L,304L,308L,312L,316L,320L,324L };
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
public class A108373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108373Inst : IEnumerable<long>
{
public static readonly long[] Value=A108373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108373.Bytes);
public long this[int i]=>Value[i];

public static A108373Inst Instance=new A108373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108374
{
public static readonly long[] Value={ 756L,1176L,1188L,1200L,1400L,1404L,1620L,1836L,2052L,2160L,2200L,2400L,2484L,2600L,2904L };
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
public class A108374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108374Inst : IEnumerable<long>
{
public static readonly long[] Value=A108374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108374.Bytes);
public long this[int i]=>Value[i];

public static A108374Inst Instance=new A108374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108375
{
public static readonly long[] Value={ 356L,810L,1364L,1188L,1490L,4178L,164L,11312L,26L,4058L,11234L,3398L,278L,4530L,2804L,7248L,14544L,942L,3504L,4704L,21194L,2708L,14636L,3222L,6990L,948L,48260L,4974L,6636L,10646L,12062L,4944L,28296L,7302L,89264L,2814L,35396L,8688L,19166L,18744L };
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
public class A108375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108375Inst : IEnumerable<long>
{
public static readonly long[] Value=A108375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108375.Bytes);
public long this[int i]=>Value[i];

public static A108375Inst Instance=new A108375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108376
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,12L,13L,14L,16L,20L,22L,24L,25L,26L,30L,33L,34L,35L,36L,40L,44L,46L,50L,55L,56L,60L,65L,100L };
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
public class A108376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108376Inst : IEnumerable<long>
{
public static readonly long[] Value=A108376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108376.Bytes);
public long this[int i]=>Value[i];

public static A108376Inst Instance=new A108376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108377
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,12L,13L,14L,15L,16L,20L,22L,24L,25L,26L,30L,33L,34L,35L,36L,40L,44L,46L,50L,55L,56L,60L,61L,100L };
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
public class A108377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108377Inst : IEnumerable<long>
{
public static readonly long[] Value=A108377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108377.Bytes);
public long this[int i]=>Value[i];

public static A108377Inst Instance=new A108377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108378
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,13L,14L,15L,16L,20L,22L,24L,25L,26L,30L,33L,34L,35L,36L,40L,44L,46L,50L,55L,56L,60L,62L,100L };
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
public class A108378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108378Inst : IEnumerable<long>
{
public static readonly long[] Value=A108378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108378.Bytes);
public long this[int i]=>Value[i];

public static A108378Inst Instance=new A108378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108379
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,12L,14L,15L,16L,20L,22L,24L,25L,26L,30L,33L,34L,35L,36L,40L,44L,46L,50L,55L,56L,60L,63L,100L };
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
public class A108379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108379Inst : IEnumerable<long>
{
public static readonly long[] Value=A108379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108379.Bytes);
public long this[int i]=>Value[i];

public static A108379Inst Instance=new A108379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108380
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,3L,2L,3L,5L,5L,6L,6L,4L,5L,5L,5L,7L,7L,10L,5L,8L,7L,12L,7L,10L,9L,14L,13L,11L,7L,14L,11L,17L,9L,18L,14L,18L,9L,19L,12L,17L,15L,14L,14L,22L,15L,16L,20L,20L,17L,18L,22L,23L,17L,24L,19L,26L,21L,29L,18L,26L,19L,26L,31L,30L,27L,31L,17L,32L,23L,34L };
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
public class A108380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108380Inst : IEnumerable<long>
{
public static readonly long[] Value=A108380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108380.Bytes);
public long this[int i]=>Value[i];

public static A108380Inst Instance=new A108380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108381
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,8L,9L,16L,17L,62L,23L,186L,95L,280L,240L,1963L,225L,6830L,1091L };
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
public class A108381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108381Inst : IEnumerable<long>
{
public static readonly long[] Value=A108381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108381.Bytes);
public long this[int i]=>Value[i];

public static A108381Inst Instance=new A108381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108382
{
public static readonly long[] Value={ 137L,173L,317L,1373L,1733L,3137L,3371L,7331L,11173L,11317L,11731L,13171L,13177L,13337L,13711L,17137L,17317L,17333L,17377L,17713L,17737L,31177L,31337L,31771L,33317L,33713L,37117L,37171L,37313L,37717L,71317L,71333L,71713L,73133L,73331L };
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
public class A108382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108382Inst : IEnumerable<long>
{
public static readonly long[] Value=A108382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108382.Bytes);
public long this[int i]=>Value[i];

public static A108382Inst Instance=new A108382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108383
{
public static readonly long[] Value={ 139L,193L,1193L,1319L,1399L,1913L,1931L,1933L,1993L,3119L,3191L,3319L,3391L,3911L,3919L,3931L,9133L,9311L,9319L,9391L,9931L,11393L,11399L,11933L,11939L,13339L,13399L,13913L,13931L,13933L,13999L,19139L,19319L,19333L,19391L,19913L,19993L,31139L };
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
public class A108383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108383Inst : IEnumerable<long>
{
public static readonly long[] Value=A108383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108383.Bytes);
public long this[int i]=>Value[i];

public static A108383Inst Instance=new A108383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108384
{
public static readonly long[] Value={ 179L,197L,719L,971L,1979L,1997L,7919L,9719L,9791L,11197L,11719L,11779L,11971L,17191L,17791L,17911L,17971L,17977L,19717L,19777L,19979L,19997L,71119L,71191L,71719L,71917L,71971L,71999L,77191L,77719L,79111L,91711L,91771L,91997L,97117L,97171L };
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
public class A108384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108384Inst : IEnumerable<long>
{
public static readonly long[] Value=A108384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108384.Bytes);
public long this[int i]=>Value[i];

public static A108384Inst Instance=new A108384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108385
{
public static readonly long[] Value={ 379L,397L,739L,937L,3739L,3779L,3793L,3797L,7393L,7793L,7933L,7937L,7993L,9337L,9377L,9397L,9733L,9739L,9973L,33739L,33797L,33937L,33997L,37339L,37379L,37397L,37799L,37993L,37997L,39373L,39397L,39733L,39779L,39799L,39937L,39979L,73379L,73939L };
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
public class A108385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108385Inst : IEnumerable<long>
{
public static readonly long[] Value=A108385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108385.Bytes);
public long this[int i]=>Value[i];

public static A108385Inst Instance=new A108385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108386
{
public static readonly long[] Value={ 1973L,3719L,3917L,7193L,9137L,9173L,9371L,13397L,13799L,13997L,17393L,17939L,19373L,19379L,19739L,19793L,19937L,19973L,31379L,31397L,31793L,31799L,31973L,33179L,33791L,37139L,37199L,37991L,39317L,39371L,39719L,39791L,39971L,71339L,71399L };
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
public class A108386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108386Inst : IEnumerable<long>
{
public static readonly long[] Value=A108386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108386.Bytes);
public long this[int i]=>Value[i];

public static A108386Inst Instance=new A108386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108387
{
public static readonly long[] Value={ 113719L,131797L,139177L,139397L,193937L,313979L,317179L,317399L,331937L,371719L,739391L,779173L,793711L,793931L,797131L,917173L,971713L,971933L,979313L,997391L,1111793L,3333971L,7777139L,9999317L,13973731L,31791913L,79319197L,97137379L };
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
public class A108387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108387Inst : IEnumerable<long>
{
public static readonly long[] Value=A108387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108387.Bytes);
public long this[int i]=>Value[i];

public static A108387Inst Instance=new A108387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108388
{
public static readonly long[] Value={ 13L,17L,31L,37L,71L,73L,79L,97L,113L,131L,179L,191L,199L,313L,331L,337L,773L,911L,919L,1171L,1933L,3391L,7717L,9311L,11113L,11119L,11177L,11717L,11933L,33199L,33331L,77171L,77711L,77713L,79999L,97777L,99991L,113111L,131111L,131113L,131171L,131311L };
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
public class A108388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108388Inst : IEnumerable<long>
{
public static readonly long[] Value=A108388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108388.Bytes);
public long this[int i]=>Value[i];

public static A108388Inst Instance=new A108388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108389
{
public static readonly long[] Value={ 133999337137L,139779933779L,173139331177L,173399913979L,177793993177L,179993739971L,391331737931L,771319973999L,917377131371L,933971311913L,997331911711L,1191777377177L,9311933973733L,9979333919939L };
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
public class A108389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108389Inst : IEnumerable<long>
{
public static readonly long[] Value=A108389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108389.Bytes);
public long this[int i]=>Value[i];

public static A108389Inst Instance=new A108389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108390
{
public static readonly long[] Value={ 1L,1L,1L,7L,7L,-1L,25L,25L,1L,111L,111L,-1L,465L,465L,1L,1975L,1975L,-1L,8361L,8361L,1L,35423L,35423L,-1L,150049L,150049L,1L,635623L,635623L,-1L,2692537L,2692537L,1L,11405775L,11405775L,-1L,48315633L,48315633L,1L,204668311L,204668311L,-1L,866988873L,866988873L,1L,3672623807L,3672623807L,-1L };
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
public class A108390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108390Inst : IEnumerable<long>
{
public static readonly long[] Value=A108390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108390.Bytes);
public long this[int i]=>Value[i];

public static A108390Inst Instance=new A108390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108391
{
public static readonly long[] Value={ 1L,-1L,3L,3L,1L,17L,17L,-1L,67L,67L,1L,289L,289L,-1L,1219L,1219L,1L,5169L,5169L,-1L,21891L,21891L,1L,92737L,92737L,-1L,392835L,392835L,1L,1664081L,1664081L,-1L,7049155L,7049155L,1L,29860705L,29860705L,-1L,126491971L,126491971L,1L,535828593L,535828593L,-1L,2269806339L,2269806339L,1L,9615053953L };
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
public class A108391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108391Inst : IEnumerable<long>
{
public static readonly long[] Value=A108391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108391.Bytes);
public long this[int i]=>Value[i];

public static A108391Inst Instance=new A108391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108392
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,11L,12L,13L,15L,16L,20L,22L,24L,25L,26L,30L,33L,34L,35L,36L,40L,44L,46L,50L,55L,56L,60L,64L,100L };
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
public class A108392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108392Inst : IEnumerable<long>
{
public static readonly long[] Value=A108392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108392.Bytes);
public long this[int i]=>Value[i];

public static A108392Inst Instance=new A108392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108393
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,0L,1L,2L,1L,3L,2L,2L,0L,3L,1L,3L,2L,1L,3L,2L,5L,2L,2L,5L,2L,2L,3L,3L,1L,3L,2L,4L,3L,1L,1L,2L,1L,3L,4L,2L,2L,4L,1L,3L,2L,4L,3L };
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
public class A108393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108393Inst : IEnumerable<long>
{
public static readonly long[] Value=A108393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108393.Bytes);
public long this[int i]=>Value[i];

public static A108393Inst Instance=new A108393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108394
{
public static readonly long[] Value={ 43L,89L,97L,214L,19L,239L,37L,79L,83L,239L,31L,431L,19L,79L,23L,827L,43L,173L,31L,103L,94L,73L,19L,243L,141L,101L,53L,811L,47L,1077L,19L,251L,29L,311L,134L,71L,23L,86L,43L,47L,19L,419L,31L,191L,83L,337L,59L,1559L,19L,127L,109L,163L,67L,353L,83L,191L,83L,107L,19L,503L };
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
public class A108394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108394Inst : IEnumerable<long>
{
public static readonly long[] Value=A108394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108394.Bytes);
public long this[int i]=>Value[i];

public static A108394Inst Instance=new A108394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108395
{
public static readonly BigInteger[] Value={ 1L,2L,12L,288L,161280L,1393920L,61479419904000L,592612475535360L,BigInteger.Parse("6670903752021072936960") };
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
public class A108395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108395Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108395.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108395Inst Instance=new A108395Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108396
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,3L,6L,15L,42L,4L,10L,34L,130L,514L,5L,15L,65L,315L,1565L,7815L,6L,21L,111L,651L,3891L,23331L,139971L,7L,28L,175L,1204L,8407L,58828L,411775L,2882404L,8L,36L,260L,2052L,16388L,131076L,1048580L,8388612L,67108868L,9L,45L,369L,3285L,29529L,265725L };
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
public class A108396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108396Inst : IEnumerable<long>
{
public static readonly long[] Value=A108396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108396.Bytes);
public long this[int i]=>Value[i];

public static A108396Inst Instance=new A108396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108397
{
public static readonly BigInteger[] Value={ 0L,2L,10L,66L,692L,9780L,167982L,3362828L,76695880L,1961316270L,55555555610L,1726135607262L,58359930206844L,2132745542253872L,83767436069591302L,3518790190560477240L,BigInteger.Parse("157412216095654840592"),BigInteger.Parse("7471013615160978901626") };
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
public class A108397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108397Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108397.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108397Inst Instance=new A108397Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108398
{
public static readonly BigInteger[] Value={ 0L,1L,5L,42L,514L,7815L,139971L,2882404L,67108868L,1743392205L,50000000005L,1569214188366L,53496602689542L,1968688192849651L,77784047778906119L,3284204177856445320L,BigInteger.Parse("147573952589676412936"),BigInteger.Parse("7031542226033862495513") };
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
public class A108398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108398Inst Instance=new A108398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108399
{
public static readonly long[] Value={ 5L,2L,6L,61L,52L,41L,28L,13L,106L,87L,66L,43L,18L,393L,364L,333L,300L,265L,228L,189L,148L,105L,60L,13L,226L,175L,122L,67L,10L,463L,402L,339L,274L,207L,138L,67L,814L,739L,662L,583L,502L,419L,334L,247L,158L,67L,538L,443L,346L,247L,146L,43L,4494L,4387L,4278L,4167L,4054L };
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
public class A108399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108399Inst : IEnumerable<long>
{
public static readonly long[] Value=A108399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108399.Bytes);
public long this[int i]=>Value[i];

public static A108399Inst Instance=new A108399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108400
{
public static readonly BigInteger[] Value={ 1L,2L,16L,768L,294912L,1132462080L,52183852646400L,BigInteger.Parse("33664847019245568000"),BigInteger.Parse("347485857744891213250560000"),BigInteger.Parse("64560982045934655213753964953600000"),BigInteger.Parse("239901585047846581083822477336190648320000000") };
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
public class A108400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108400Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108400.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108400Inst Instance=new A108400Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108401
{
public static readonly long[] Value={ 5L,6L,7L,8L,9L,15L,16L,17L,18L,29L,42L,63L,74L,83L,161L,273L,286L,300L,400L,684L,900L,1315L,1319L,1513L,1813L,1913L,2582L,3005L,3006L,3007L,3161L,3187L,3600L,3928L,4200L,5429L,6251L,7126L,12147L,16143L,19134L,20024L,39003L,40000L,40003L,40031L,41001L,41009L };
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
public class A108401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108401Inst : IEnumerable<long>
{
public static readonly long[] Value=A108401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108401.Bytes);
public long this[int i]=>Value[i];

public static A108401Inst Instance=new A108401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108402
{
public static readonly long[] Value={ 3L,5L,11L,17L,29L,53L,89L,157L,271L,487L,857L,1487L,2621L,4567L,8011L,13999L,24499L,42901L,75401L,132169L,231431L,406207L,711617L,1247761L,2186941L };
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
public class A108402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108402Inst : IEnumerable<long>
{
public static readonly long[] Value=A108402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108402.Bytes);
public long this[int i]=>Value[i];

public static A108402Inst Instance=new A108402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108403
{
public static readonly long[] Value={ 5L,25L,65L,145L,355L,605L,985L,1075L,1295L,1465L,1565L,1675L,1915L,2345L,2425L,2585L,2755L,3005L,3155L,3785L,4595L,4625L,4975L,5225L,5465L,5665L,5905L,5915L,6115L,6295L,6305L,6415L,6485L,7235L,7775L,8185L,9065L,9275L,9415L,9755L,9835L,10145L,10195L };
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
public class A108403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108403Inst : IEnumerable<long>
{
public static readonly long[] Value=A108403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108403.Bytes);
public long this[int i]=>Value[i];

public static A108403Inst Instance=new A108403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108404
{
public static readonly long[] Value={ 1L,4L,21L,124L,761L,4724L,29421L,183404L,1143601L,7131364L,44471301L,277325404L,1729418921L,10784771924L,67254567261L,419404046924L,2615432135521L,16310012568004L,101710347053301L,634272638178364L,3955367287840601L };
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
public class A108404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108404Inst : IEnumerable<long>
{
public static readonly long[] Value=A108404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108404.Bytes);
public long this[int i]=>Value[i];

public static A108404Inst Instance=new A108404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108405
{
public static readonly long[] Value={ 12L,28L,40L,48L,54L,80L,90L,96L,104L,108L,224L,350L,384L,390L,432L,500L,567L,570L,660L,686L,720L,770L,775L,810L,972L,1085L,1176L,1551L,1575L,1875L,2016L,2400L,2560L,2600L,2700L,2760L,2829L,2880L,2925L,3072L,3456L,3640L,3645L,3888L,4260L,4374L,4400L,4692L };
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
public class A108405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108405Inst : IEnumerable<long>
{
public static readonly long[] Value=A108405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108405.Bytes);
public long this[int i]=>Value[i];

public static A108405Inst Instance=new A108405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108406
{
public static readonly long[] Value={ 0L,211L,220L,235L,20403L,111416L,1011231L,3444142L,10003400L,22303600L,31151021L,53231032L,121542025L,126423126L,202032110L,243425212L,302434003L,311544033L,324231521L,334130241L,375607602L,406221650L,561620561L,662033363L,1053045074L };
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
public class A108406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108406Inst : IEnumerable<long>
{
public static readonly long[] Value=A108406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108406.Bytes);
public long this[int i]=>Value[i];

public static A108406Inst Instance=new A108406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108407
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,3L,3L,4L,0L,6L,0L,6L,6L,8L,0L,9L,0L,10L,9L,10L,0L,14L,9L,12L,12L,15L,0L,18L,0L,17L,15L,16L,15L,23L,0L,18L,18L,24L,0L,25L,0L,24L,24L,22L,0L,31L,18L,28L,24L,29L,0L,32L,24L,34L,27L,28L,0L,41L,0L,30L,35L,38L,29L,40L,0L,38L,33L,44L,0L,49L,0L,36L,41L,43L,32L,47L,0L,52L };
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
public class A108407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108407Inst : IEnumerable<long>
{
public static readonly long[] Value=A108407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108407.Bytes);
public long this[int i]=>Value[i];

public static A108407Inst Instance=new A108407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108408
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,12L,14L,15L,16L,17L,18L,22L,23L,24L,25L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,52L,53L,54L,55L,56L,57L,58L,59L,60L,62L,63L,64L,66L,67L,69L,70L,71L,72L,73L,74L,77L,78L,79L,82L,83L,84L,85L,86L,87L,88L,89L,90L };
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
public class A108408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108408Inst : IEnumerable<long>
{
public static readonly long[] Value=A108408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108408.Bytes);
public long this[int i]=>Value[i];

public static A108408Inst Instance=new A108408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108409
{
public static readonly long[] Value={ 5L,7L,11L,13L,19L,20L,21L,26L,37L,48L,50L,51L,61L,65L,68L,75L,76L,80L,81L,93L,98L,101L,110L,113L,114L,121L,127L,128L,129L,135L,143L,146L,147L,149L,151L,163L,167L,171L,175L,179L,184L,185L,188L,194L,201L,205L,208L,209L,218L,219L,220L,221L,251L,254L,257L,263L,264L };
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
public class A108409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108409Inst : IEnumerable<long>
{
public static readonly long[] Value=A108409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108409.Bytes);
public long this[int i]=>Value[i];

public static A108409Inst Instance=new A108409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108410
{
public static readonly long[] Value={ 1L,2L,1L,5L,5L,2L,14L,21L,15L,5L,42L,84L,84L,49L,14L,132L,330L,420L,336L,168L,42L,429L,1287L,1980L,1980L,1350L,594L,132L,1430L,5005L,9009L,10725L,9075L,5445L,2145L,429L,4862L,19448L,40040L,55055L,55055L,40898L,22022L,7865L,1430L,16796L,75582L };
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
public class A108410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108410Inst : IEnumerable<long>
{
public static readonly long[] Value=A108410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108410.Bytes);
public long this[int i]=>Value[i];

public static A108410Inst Instance=new A108410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108411
{
public static readonly long[] Value={ 1L,1L,3L,3L,9L,9L,27L,27L,81L,81L,243L,243L,729L,729L,2187L,2187L,6561L,6561L,19683L,19683L,59049L,59049L,177147L,177147L,531441L,531441L,1594323L,1594323L,4782969L,4782969L,14348907L,14348907L,43046721L,43046721L,129140163L };
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
public class A108411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108411Inst : IEnumerable<long>
{
public static readonly long[] Value=A108411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108411.Bytes);
public long this[int i]=>Value[i];

public static A108411Inst Instance=new A108411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108412
{
public static readonly long[] Value={ 1L,1L,5L,4L,19L,15L,71L,56L,265L,209L,989L,780L,3691L,2911L,13775L,10864L,51409L,40545L,191861L,151316L,716035L,564719L,2672279L,2107560L,9973081L,7865521L,37220045L,29354524L,138907099L,109552575L,518408351L,408855776L,1934726305L };
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
public class A108412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108412Inst : IEnumerable<long>
{
public static readonly long[] Value=A108412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108412.Bytes);
public long this[int i]=>Value[i];

public static A108412Inst Instance=new A108412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108413
{
public static readonly long[] Value={ 1L,1L,1L,-2L,-5L,7L,19L,-26L,-71L,97L,265L,-362L,-989L,1351L,3691L,-5042L,-13775L,18817L,51409L,-70226L,-191861L,262087L,716035L,-978122L,-2672279L,3650401L,9973081L,-13623482L,-37220045L,50843527L,138907099L,-189750626L,-518408351L };
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
public class A108413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108413Inst : IEnumerable<long>
{
public static readonly long[] Value=A108413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108413.Bytes);
public long this[int i]=>Value[i];

public static A108413Inst Instance=new A108413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108414
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,4L,4L,4L,5L,4L,5L,4L,5L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L };
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
public class A108414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108414Inst : IEnumerable<long>
{
public static readonly long[] Value=A108414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108414.Bytes);
public long this[int i]=>Value[i];

public static A108414Inst Instance=new A108414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108415
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L,2L,3L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,1L,3L,1L,2L,3L,1L,2L,3L,1L,3L,1L,3L,1L,2L,3L,3L,1L,1L,3L,1L,3L,2L,2L,3L,1L,3L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,1L,1L,1L,3L,2L,3L,1L,1L,3L,1L,1L,3L,1L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,1L,3L,2L,3L,1L,1L };
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
public class A108415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108415Inst : IEnumerable<long>
{
public static readonly long[] Value=A108415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108415.Bytes);
public long this[int i]=>Value[i];

public static A108415Inst Instance=new A108415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108416
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,3L,0L,4L,0L,0L,5L,0L,0L,6L,6L,12L,0L,7L,0L,0L,0L,8L,0L,24L,0L,0L,9L,9L,0L,18L,0L,10L,0L,40L,10L,60L,0L,11L,0L,0L,0L,0L,0L,12L,12L,60L,72L,144L,120L,0L,13L,0L,0L,0L,0L,0L,0L,14L,0L,84L,0L,210L,14L,280L,0L,15L,15L,0L,75L,60L,30L,105L,0L,16L,0L,112L,0L,336L,0L,560L,0L,0L,17L,0L,0L };
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
public class A108416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108416Inst : IEnumerable<long>
{
public static readonly long[] Value=A108416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108416.Bytes);
public long this[int i]=>Value[i];

public static A108416Inst Instance=new A108416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108417
{
public static readonly long[] Value={ 0L,1L,2L,6L,8L,10L,36L,14L,64L,72L,180L,22L,720L,26L,924L,600L,2048L,34L,10800L,38L,12240L,2856L,22572L,46L,144000L };
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
public class A108417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108417Inst : IEnumerable<long>
{
public static readonly long[] Value=A108417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108417.Bytes);
public long this[int i]=>Value[i];

public static A108417Inst Instance=new A108417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108418
{
public static readonly long[] Value={ 13597L,13759L,15739L,15937L,15973L,17359L,17539L,19753L,31957L,37159L,37591L,37951L,39157L,51973L,53197L,53719L,53791L,53917L,57139L,57193L,71359L,71593L,73951L,75193L,75391L,75913L,75931L,79153L,79531L,91573L,91753L,95317L,95713L,95731L };
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
public class A108418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108418Inst : IEnumerable<long>
{
public static readonly long[] Value=A108418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108418.Bytes);
public long this[int i]=>Value[i];

public static A108418Inst Instance=new A108418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108419
{
public static readonly long[] Value={ 2357L,2753L,3257L,3527L,5237L,5273L,7253L,7523L,22573L,23357L,23537L,23557L,23753L,25237L,25357L,25373L,25537L,25733L,27253L,32257L,32537L,32573L,35227L,35257L,35327L,35527L,37253L,52237L,52733L,53327L,53527L,57223L,72253L,72353L,72533L };
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
public class A108419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108419Inst : IEnumerable<long>
{
public static readonly long[] Value=A108419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108419.Bytes);
public long this[int i]=>Value[i];

public static A108419Inst Instance=new A108419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108420
{
public static readonly long[] Value={ 3L,14L,20L,54L,56L,144L,206L,212L,436L,1610L,4450L,4512L,5202L,6684L };
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
public class A108420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108420Inst : IEnumerable<long>
{
public static readonly long[] Value=A108420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108420.Bytes);
public long this[int i]=>Value[i];

public static A108420Inst Instance=new A108420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108421
{
public static readonly long[] Value={ 2L,4L,4L,4L,5L,5L,5L,5L,4L,4L,5L,6L,5L,5L,6L,4L,5L,6L,5L,5L,5L,5L,6L,6L,6L,5L,6L,5L,6L,7L,7L,7L,8L,5L,5L,6L,5L,5L,6L,6L,5L,6L,6L,5L,6L,6L,7L,8L,5L,5L,6L,6L,6L,6L,7L,5L,6L,6L,7L,8L,7L,7L,8L,6L,7L,5L,5L,6L,5L,5L,6L,6L,5L,6L,6L,5L,6L,7L,7L,7L,6L,6L,6L,6L,6L,6L,7L,6L,6L,7L,7L,7L,8L,7L,8L,6L,5L,5L,6L,6L,6L,6L,7L,5L,6L };
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
public class A108421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108421Inst : IEnumerable<long>
{
public static readonly long[] Value=A108421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108421.Bytes);
public long this[int i]=>Value[i];

public static A108421Inst Instance=new A108421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108422
{
public static readonly long[] Value={ 2L,4L,4L,5L,5L,6L,5L,6L,6L,6L,6L,6L,6L,7L,6L,7L,7L,8L,7L,8L,8L,8L,7L,8L,8L,9L,7L,8L,9L,10L,7L,8L,8L,9L,8L,9L,9L,10L,8L,9L,9L,8L,9L,10L,10L,10L,8L,8L,9L,9L,9L,10L,10L,10L,9L,9L,8L,10L,10L,10L,8L,10L,8L,9L,9L,10L,9L,10L,10L,9L,9L,10L,9L,11L,9L,10L,11L,12L,9L,10L,10L,10L,10L,11L,9L,12L,8L,9L,11L,10L,8L,12L };
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
public class A108422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108422Inst : IEnumerable<long>
{
public static readonly long[] Value=A108422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108422.Bytes);
public long this[int i]=>Value[i];

public static A108422Inst Instance=new A108422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108423
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,0L,1L,2L,2L,1L,0L,1L,2L,0L,3L,2L,2L,2L,3L,3L,3L,1L,2L,2L,4L,1L,3L,3L,3L,0L,1L,0L,4L,3L,3L,4L,5L,2L,3L,4L,2L,3L,5L,4L,4L,1L,0L,4L,4L,3L,4L,4L,4L,2L,4L,2L,4L,3L,2L,1L,3L,0L,3L,2L,5L,4L,4L,5L,4L,3L,4L,4L,5L,3L,5L,5L,5L,2L,3L,4L,4L,4L,5L,3L,6L,1L,3L,5L,3L,1L,5L,4L,2L,1L,4L,4L,6L,4L,4L,4L,6L,2L,6L,4L };
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
public class A108423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108423Inst : IEnumerable<long>
{
public static readonly long[] Value=A108423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108423.Bytes);
public long this[int i]=>Value[i];

public static A108423Inst Instance=new A108423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108424
{
public static readonly ulong[] Value={ 2L,6L,34L,238L,1858L,15510L,135490L,1223134L,11320066L,106830502L,1024144482L,9945711566L,97634828354L,967298498358L,9659274283650L,97119829841854L,982391779220482L,9990160542904134L,102074758837531810L,1047391288012377774L,10788532748880319298UL };
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
public class A108424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108424Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A108424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108424.Bytes);
public ulong this[int i]=>Value[i];

public static A108424Inst Instance=new A108424Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108425
{
public static readonly long[] Value={ 2L,4L,6L,8L,36L,22L,16L,144L,248L,90L,32L,480L,1600L,1560L,394L,64L,1440L,7840L,14400L,9420L,1806L,128L,4032L,32480L,95760L,115416L,55692L,8558L,256L,10752L,120064L,517440L,986272L,860832L,325360L,41586L,512L,27648L,408576L,2419200L,6668928L };
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
public class A108425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108425Inst : IEnumerable<long>
{
public static readonly long[] Value=A108425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108425.Bytes);
public long this[int i]=>Value[i];

public static A108425Inst Instance=new A108425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108426
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,2L,12L,28L,21L,5L,55L,165L,180L,84L,14L,273L,1001L,1430L,990L,330L,42L,1428L,6188L,10920L,10010L,5005L,1287L,132L,7752L,38760L,81396L,92820L,61880L,24024L,5005L,429L,43263L,245157L,596904L,813960L,678300L,352716L,111384L,19448L,1430L,246675L };
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
public class A108426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108426Inst : IEnumerable<long>
{
public static readonly long[] Value=A108426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108426.Bytes);
public long this[int i]=>Value[i];

public static A108426Inst Instance=new A108426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108427
{
public static readonly BigInteger[] Value={ 1L,9L,85L,833L,8361L,85305L,880685L,9173505L,96220561L,1014889769L,10753517061L,114375683009L,1220435354425L,13058529727833L,140059477112925L,1505357362548737L,16209464357137953L,174827809500822345L,1888383038494338485L,BigInteger.Parse("20424130116241366593"),BigInteger.Parse("221164921352046545609"),BigInteger.Parse("2397512484385887298681") };
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
public class A108427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108427Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A108427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A108427.Bytes);
public BigInteger this[int i]=>Value[i];

public static A108427Inst Instance=new A108427Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108428
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,4L,1L,1L,9L,23L,23L,9L,1L,1L,16L,76L,156L,156L,76L,16L,1L,1L,25L,190L,650L,1167L,1167L,650L,190L,25L,1L,1L,36L,400L,2045L,5685L,9318L,9318L,5685L,2045L,400L,36L,1L,1L,49L,749L,5341L,21133L,50813L,77947L,77947L,50813L,21133L,5341L,749L,49L,1L,1L,64L,1288L };
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
public class A108428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108428Inst : IEnumerable<long>
{
public static readonly long[] Value=A108428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108428.Bytes);
public long this[int i]=>Value[i];

public static A108428Inst Instance=new A108428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108429
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,2L,5L,3L,0L,0L,0L,5L,21L,28L,12L,0L,0L,0L,0L,14L,84L,180L,165L,55L,0L,0L,0L,0L,0L,42L,330L,990L,1430L,1001L,273L,0L,0L,0L,0L,0L,0L,132L,1287L,5005L,10010L,10920L,6188L,1428L,0L,0L,0L,0L,0L,0L,0L,429L,5005L,24024L,61880L,92820L,81396L,38760L,7752L,0L,0L,0L,0L };
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
public class A108429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108429Inst : IEnumerable<long>
{
public static readonly long[] Value=A108429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108429.Bytes);
public long this[int i]=>Value[i];

public static A108429Inst Instance=new A108429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108430
{
public static readonly long[] Value={ 3L,31L,311L,3151L,32299L,334335L,3488239L,36627487L,386618387L,4098713631L,43611791783L,465496885231L,4981942135611L,53443871159551L,574500093677535L,6186886528903231L,66735614131858723L,720897596248427295L };
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
public class A108430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108430Inst : IEnumerable<long>
{
public static readonly long[] Value=A108430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108430.Bytes);
public long this[int i]=>Value[i];

public static A108430Inst Instance=new A108430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108431
{
public static readonly long[] Value={ 1L,0L,2L,6L,0L,4L,34L,24L,0L,8L,274L,136L,72L,0L,16L,2266L,1168L,408L,192L,0L,32L,19738L,9880L,3720L,1088L,480L,0L,64L,177642L,87840L,32088L,10496L,2720L,1152L,0L,128L,1640050L,802216L,291048L,92096L,27680L,6528L,2688L,0L,256L,15445690L,7492240L };
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
public class A108431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108431Inst : IEnumerable<long>
{
public static readonly long[] Value=A108431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108431.Bytes);
public long this[int i]=>Value[i];

public static A108431Inst Instance=new A108431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108432
{
public static readonly long[] Value={ 1L,0L,6L,34L,274L,2266L,19738L,177642L,1640050L,15445690L,147813706L,1433309194L,14052298690L,139063589370L,1387288675002L,13936344557354L,140859338668306L,1431424362057018L,14616361066692778L,149892742974500042L };
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
public class A108432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108432Inst : IEnumerable<long>
{
public static readonly long[] Value=A108432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108432.Bytes);
public long this[int i]=>Value[i];

public static A108432Inst Instance=new A108432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108433
{
public static readonly long[] Value={ 1L,1L,1L,7L,2L,1L,47L,15L,3L,1L,361L,108L,24L,4L,1L,2977L,865L,184L,34L,5L,1L,25775L,7334L,1533L,276L,45L,6L,1L,231103L,64767L,13359L,2387L,385L,57L,7L,1L,2127409L,589368L,120376L,21368L,3450L,512L,70L,8L,1L,19990241L,5488033L,1112424L,196484L,31706L };
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
public class A108433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108433Inst : IEnumerable<long>
{
public static readonly long[] Value=A108433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108433.Bytes);
public long this[int i]=>Value[i];

public static A108433Inst Instance=new A108433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108434
{
public static readonly long[] Value={ 1L,1L,7L,47L,361L,2977L,25775L,231103L,2127409L,19990241L,190957559L,1848911279L,18104425561L,178975914433L,1783843502047L,17906040994559L,180858717257185L,1836792828317761L,18745545101801063L,192145823547338927L };
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
public class A108434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108434Inst : IEnumerable<long>
{
public static readonly long[] Value=A108434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108434.Bytes);
public long this[int i]=>Value[i];

public static A108434Inst Instance=new A108434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108435
{
public static readonly long[] Value={ 2L,6L,4L,34L,24L,8L,238L,172L,72L,16L,1858L,1360L,624L,192L,32L,15510L,11444L,5520L,1952L,480L,64L,135490L,100520L,50040L,19136L,5600L,1152L,128L,1223134L,911068L,463512L,186416L,60320L,15168L,2688L,256L,11320066L,8457504L,4371808L,1821312L,629440L };
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
public class A108435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108435Inst : IEnumerable<long>
{
public static readonly long[] Value=A108435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108435.Bytes);
public long this[int i]=>Value[i];

public static A108435Inst Instance=new A108435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108436
{
public static readonly long[] Value={ 2L,14L,106L,862L,7378L,65550L,599002L,5594942L,53181730L,512784142L,5003410762L,49312114334L,490192537586L,4909102791694L,49482525122490L,501626536004734L,5111038278845506L,52312236295906830L,537605889306476074L };
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
public class A108436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108436Inst : IEnumerable<long>
{
public static readonly long[] Value=A108436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108436.Bytes);
public long this[int i]=>Value[i];

public static A108436Inst Instance=new A108436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108437
{
public static readonly long[] Value={ 1L,1L,2L,5L,2L,1L,10L,28L,13L,11L,3L,1L,66L,196L,90L,89L,34L,18L,4L,1L,498L,1532L,694L,736L,311L,197L,66L,26L,5L,1L,4066L,12804L,5738L,6344L,2800L,1937L,762L,367L,110L,35L,6L,1L,34970L,111964L,49758L,56576L,25560L,18636L,7953L,4263L,1551L,615L,167L,45L,7L,1L };
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
public class A108437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108437Inst : IEnumerable<long>
{
public static readonly long[] Value=A108437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108437.Bytes);
public long this[int i]=>Value[i];

public static A108437Inst Instance=new A108437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108438
{
public static readonly long[] Value={ 1L,1L,4L,3L,2L,1L,24L,18L,13L,7L,3L,1L,172L,130L,96L,55L,28L,12L,4L,1L,1360L,1034L,772L,458L,249L,119L,50L,18L,5L,1L,11444L,8738L,6568L,3982L,2244L,1137L,526L,219L,80L,25L,6L,1L,100520L,76994L,58140L,35770L,20624L,10836L,5293L,2383L,981L,365L,119L,33L,7L,1L };
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
public class A108438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108438Inst : IEnumerable<long>
{
public static readonly long[] Value=A108438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108438.Bytes);
public long this[int i]=>Value[i];

public static A108438Inst Instance=new A108438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108439
{
public static readonly long[] Value={ 2L,4L,6L,20L,12L,34L,132L,60L,68L,238L,996L,396L,340L,476L,1858L,8132L,2988L,2244L,2380L,3716L,15510L,69940L,24396L,16932L,15708L,18580L,31020L,135490L,624132L,209820L,138244L,118524L,122628L,155100L,270980L,1223134L,5725124L,1872396L,1188980L };
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
public class A108439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108439Inst : IEnumerable<long>
{
public static readonly long[] Value=A108439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108439.Bytes);
public long this[int i]=>Value[i];

public static A108439Inst Instance=new A108439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A108440
{
public static readonly long[] Value={ 1L,1L,1L,5L,4L,1L,33L,25L,7L,1L,249L,184L,54L,10L,1L,2033L,1481L,446L,92L,13L,1L,17485L,12620L,3863L,846L,139L,16L,1L,156033L,111889L,34637L,7881L,1411L,195L,19L,1L,1431281L,1021424L,318812L,74492L,14102L,2168L,260L,22L,1L,13412193L,9536113L,2995228L };
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
public class A108440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A108440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A108440Inst : IEnumerable<long>
{
public static readonly long[] Value=A108440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A108440.Bytes);
public long this[int i]=>Value[i];

public static A108440Inst Instance=new A108440Inst();

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