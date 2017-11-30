using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A093583
{
public static readonly BigInteger[] Value={ 3L,35L,3003L,415701L,5311735L,434113615L,18533312025L,435656388001L,177055881452877L,7408390829212485L,181379582274392745L,7925499138511509075L,BigInteger.Parse("4929343444188618184287"),BigInteger.Parse("1110562821148124607963623"),BigInteger.Parse("3178507384665322153826921"),BigInteger.Parse("830410687367885294317555909"),BigInteger.Parse("7322712424971352140800265743"),BigInteger.Parse("1554656680754632169811125806621"),BigInteger.Parse("1470158989268211486203283266158437"),BigInteger.Parse("4259691430443792254896692540407779") };
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
public class A093583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093583.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093583Inst Instance=new A093583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093584
{
public static readonly BigInteger[] Value={ 2L,32L,2560L,286720L,2752512L,161480704L,4798283776L,76772540416L,20882130993152L,577106165628928L,9233698650062848L,261384700247932928L,BigInteger.Parse("104553880099173171200"),BigInteger.Parse("15055758734280936652800"),BigInteger.Parse("27395576677279821987840"),BigInteger.Parse("4529402010643597235322880"),BigInteger.Parse("25173939595998098318426112"),BigInteger.Parse("3356525279466413109123481600"),BigInteger.Parse("1987062965444116560601101107200"),BigInteger.Parse("3593992146194576040043730698240") };
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
public class A093584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093584Inst Instance=new A093584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093585
{
public static readonly BigInteger[] Value={ 1L,3L,45L,105L,17325L,189189L,1072071L,6235515L,4732755885L,56968357875L,1387749197835L,1066617152055L,211545735157575L,2639940564777075L,33133947904855125L,208964764786619655L,BigInteger.Parse("677672732203007541165"),BigInteger.Parse("8617464674207794857375"),BigInteger.Parse("219904931871450765064125"),BigInteger.Parse("703573951001456048889375"),BigInteger.Parse("144457803619618955957966475") };
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
public class A093585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093585Inst Instance=new A093585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093586
{
public static readonly BigInteger[] Value={ 1L,8L,128L,256L,32768L,262144L,1048576L,4194304L,2147483648L,17179869184L,274877906944L,137438953472L,17592186044416L,140737488355328L,1125899906842624L,4503599627370496L,9223372036854775808UL,BigInteger.Parse("73786976294838206464"),BigInteger.Parse("1180591620717411303424"),BigInteger.Parse("2361183241434822606848"),BigInteger.Parse("302231454903657293676544") };
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
public class A093586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093586Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093586.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093586.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093586Inst Instance=new A093586Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093587
{
public static readonly long[] Value={ 0L,7L,3L,8L,8L,0L,0L,2L,9L,7L,3L,9L,2L,0L,4L,6L,2L,5L,0L,1L,1L,1L,6L,2L,1L,0L,8L,5L,9L,0L,4L,2L,6L,4L,0L,3L,3L,6L,7L,7L,6L,1L,6L,0L,6L,5L,3L,1L,8L,4L,6L,4L,4L,1L,8L,6L,6L,5L,8L,9L,9L,1L,9L,0L,8L,9L,5L,0L,1L,2L,3L,4L,0L,3L,4L,9L,6L,3L,3L,4L,2L,5L,3L,5L,2L,5L,6L,7L,6L,2L,2L,3L,7L,4L,3L,2L,5L,8L,9L,9L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093587Inst : IEnumerable<long>
{
public static readonly long[] Value=A093587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093587.Bytes);
public long this[int i]=>Value[i];

public static A093587Inst Instance=new A093587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093604
{
public static readonly long[] Value={ 6L,4L,3L,0L,3L,7L,0L,6L,8L,5L,7L,8L,7L,4L,3L,7L,8L,4L,6L,4L,1L,7L,8L,2L,5L,0L,5L,6L,6L,5L,1L,5L,7L,9L,7L,8L,8L,6L,2L,3L,0L,4L,9L,8L,3L,3L,3L,2L,6L,3L,0L,4L,8L,7L,1L,2L,3L,9L,1L,4L,9L,9L,0L,4L,1L,5L,4L,3L,0L,2L,9L,9L,2L,4L,2L,4L,5L,1L,7L,0L,1L,6L,5L,0L,2L,7L,7L,8L,4L,9L,7L,5L,0L,7L,0L,8L,6L,5L,9L,8L,9L,3L,8L,2L,8L,7L,8L,9L,7L,5L,0L,3L,9L,8L,7L,2L,2L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093604Inst : IEnumerable<long>
{
public static readonly long[] Value=A093604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093604.Bytes);
public long this[int i]=>Value[i];

public static A093604Inst Instance=new A093604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093605
{
public static readonly long[] Value={ 0L,1L,11L,13L,211L,271L,1919L,2597L,67843L,95259L,588933L,850251L,10098967L,14904091L,85806311L,128927573L,5792144099L,8834766227L,48605936617L,75096287791L,812156618077L,1268822838961L,6760265315081L,10665172132163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093605Inst : IEnumerable<long>
{
public static readonly long[] Value=A093605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093605.Bytes);
public long this[int i]=>Value[i];

public static A093605Inst Instance=new A093605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093606
{
public static readonly long[] Value={ 5L,2L,7L,3L,9L,8L,8L,6L,8L,1L,6L,3L,3L,1L,8L,0L,8L,0L,3L,7L,0L,9L,9L,9L,3L,3L,8L,9L,1L,4L,1L,4L,6L,7L,7L,3L,2L,5L,1L,4L,9L,3L,7L,0L,6L,8L,7L,3L,9L,4L,1L,8L,3L,4L,0L,7L,9L,0L,6L,4L,9L,5L,8L,8L,5L,6L,8L,7L,0L,4L,5L,6L,4L,8L,8L,0L,3L,5L,1L,0L,4L,4L,8L,6L,9L,7L,6L,4L,0L,7L,0L,8L,2L,4L,1L,1L,5L,2L,3L,6L,7L,7L,2L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093606Inst : IEnumerable<long>
{
public static readonly long[] Value=A093606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093606.Bytes);
public long this[int i]=>Value[i];

public static A093606Inst Instance=new A093606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093607
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,20L,33L,54L,90L,148L,244L,401L,660L,1086L,1786L,2939L,4835L,7953L,13082L,21520L,35399L,58230L,95785L,157560L,259175L,426327L,701280L,1153559L,1897529L,3121310L,5134350L,8445667L,13892566L,22852355L,37590617L,61834088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093607Inst : IEnumerable<long>
{
public static readonly long[] Value=A093607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093607.Bytes);
public long this[int i]=>Value[i];

public static A093607Inst Instance=new A093607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093608
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,11L,20L,36L,64L,115L,205L,366L,652L,1162L,2070L,3687L,6567L,11696L,20832L,37103L,66084L,117701L,209635L,373375L,665008L,1184428L,2109552L,3757265L,6691962L,11918868L,21228368L,37809262L,67341034L,119939258L,213620504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093608Inst : IEnumerable<long>
{
public static readonly long[] Value=A093608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093608.Bytes);
public long this[int i]=>Value[i];

public static A093608Inst Instance=new A093608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093609
{
public static readonly long[] Value={ 2L,5L,8L,11L,13L,16L,19L,22L,25L,27L,30L,33L,36L,38L,41L,44L,47L,50L,52L,55L,58L,61L,63L,66L,69L,72L,75L,77L,80L,83L,86L,88L,91L,94L,97L,100L,102L,105L,108L,111L,114L,116L,119L,122L,125L,127L,130L,133L,136L,139L,141L,144L,147L,150L,152L,155L,158L,161L,164L,166L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093609Inst : IEnumerable<long>
{
public static readonly long[] Value=A093609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093609.Bytes);
public long this[int i]=>Value[i];

public static A093609Inst Instance=new A093609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093610
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,14L,15L,17L,18L,20L,21L,23L,24L,26L,28L,29L,31L,32L,34L,35L,37L,39L,40L,42L,43L,45L,46L,48L,49L,51L,53L,54L,56L,57L,59L,60L,62L,64L,65L,67L,68L,70L,71L,73L,74L,76L,78L,79L,81L,82L,84L,85L,87L,89L,90L,92L,93L,95L,96L,98L,99L,101L,103L,104L,106L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093610Inst : IEnumerable<long>
{
public static readonly long[] Value=A093610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093610.Bytes);
public long this[int i]=>Value[i];

public static A093610Inst Instance=new A093610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093611
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,18L,25L,43L,111L,154L,265L,684L,949L,1633L,4215L,5848L,10063L,25974L,36037L,62011L,160059L,222070L,382129L,986328L,1368457L,2354785L,6078027L,8432812L,14510839L,37454490L,51965329L,89419819L,230804967L,320224786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093611Inst : IEnumerable<long>
{
public static readonly long[] Value=A093611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093611.Bytes);
public long this[int i]=>Value[i];

public static A093611Inst Instance=new A093611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093612
{
public static readonly BigInteger[] Value={ 5L,47L,2399L,823541L,5764799L,13841287199L,4747561509941L,BigInteger.Parse("459986536544739960976799"),BigInteger.Parse("157775382034845806615042741"),BigInteger.Parse("97327453648743672783790144527749033795901408624680013074608083129650399") };
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
public class A093612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093612.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093612Inst Instance=new A093612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093613
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,3L,1L,4L,2L,5L,5L,2L,7L,4L,1L,6L,3L,8L,8L,3L,11L,6L,1L,9L,4L,12L,7L,2L,10L,5L,13L,13L,5L,18L,10L,2L,15L,7L,20L,12L,4L,17L,9L,1L,14L,6L,19L,11L,3L,16L,8L,21L,21L,8L,29L,16L,3L,24L,11L,32L,19L,6L,27L,14L,1L,22L,9L,30L,17L,4L,25L,12L,33L,20L,7L,28L,15L,2L,23L,10L,31L,18L,5L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093613Inst : IEnumerable<long>
{
public static readonly long[] Value=A093613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093613.Bytes);
public long this[int i]=>Value[i];

public static A093613Inst Instance=new A093613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093614
{
public static readonly long[] Value={ 5L,6L,10L,12L,15L,17L,18L,20L,24L,25L,30L,31L,33L,34L,35L,36L,40L,42L,45L,48L,50L,51L,54L,55L,60L,62L,63L,65L,66L,68L,70L,72L,75L,78L,80L,84L,85L,90L,93L,95L,96L,99L,100L,102L,105L,108L,110L,114L,115L,119L,120L,124L,125L,126L,127L,129L,130L,132L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093614Inst : IEnumerable<long>
{
public static readonly long[] Value=A093614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093614.Bytes);
public long this[int i]=>Value[i];

public static A093614Inst Instance=new A093614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093615
{
public static readonly BigInteger[] Value={ 0L,1L,-1L,3L,-15L,85L,-570L,4509L,-40804L,414864L,-4686570L,58245650L,-789691134L,11598605460L,-183459343613L,3109122970590L,-56203651969935L,1079493501290439L,-21953265755518782L,471258656426134701L,BigInteger.Parse("-10648683969964745520"),BigInteger.Parse("252651472831081785300") };
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
public class A093615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093615Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093615.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093615.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093615Inst Instance=new A093615Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093616
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,8L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,8L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093616Inst : IEnumerable<long>
{
public static readonly long[] Value=A093616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093616.Bytes);
public long this[int i]=>Value[i];

public static A093616Inst Instance=new A093616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093617
{
public static readonly long[] Value={ 18L,50L,75L,90L,98L,108L,126L,144L,147L,150L,198L,234L,242L,245L,294L,300L,306L,324L,338L,342L,350L,363L,384L,400L,414L,450L,490L,500L,507L,522L,525L,540L,550L,558L,578L,588L,600L,605L,630L,640L,648L,650L,666L,720L,722L,726L,735L,738L,756L,774L,784L,825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093617Inst : IEnumerable<long>
{
public static readonly long[] Value=A093617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093617.Bytes);
public long this[int i]=>Value[i];

public static A093617Inst Instance=new A093617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093618
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093618Inst : IEnumerable<long>
{
public static readonly long[] Value=A093618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093618.Bytes);
public long this[int i]=>Value[i];

public static A093618Inst Instance=new A093618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093619
{
public static readonly long[] Value={ 0L,0L,4L,3L,5L,4L,4L,2L,0L,8L,7L,4L,7L,2L,2L,2L,5L,2L,2L,7L,9L,6L,7L,7L,3L,4L,2L,5L,1L,2L,7L,9L,4L,3L,2L,1L,1L,5L,1L,2L,3L,2L,4L,9L,2L,4L,6L,0L,1L,8L,0L,5L,7L,4L,3L,6L,2L,3L,4L,4L,1L,8L,7L,3L,5L,5L,2L,6L,8L,6L,3L,8L,4L,8L,3L,7L,8L,7L,8L,5L,9L,2L,4L,7L,3L,9L,8L,1L,2L,0L,5L,5L,0L,6L,1L,1L,7L,1L,7L,6L,6L,5L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093619Inst : IEnumerable<long>
{
public static readonly long[] Value=A093619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093619.Bytes);
public long this[int i]=>Value[i];

public static A093619Inst Instance=new A093619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093748
{
public static readonly long[] Value={ 0L,0L,0L,3L,88L,1175L,12249L,119465L,1119585L,10347754L,94842255L,866077378L,7902711871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093748Inst : IEnumerable<long>
{
public static readonly long[] Value=A093748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093748.Bytes);
public long this[int i]=>Value[i];

public static A093748Inst Instance=new A093748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093749
{
public static readonly long[] Value={ 0L,0L,0L,5L,98L,1234L,13255L,129567L,1219243L,11287965L,103578486L,946685407L,8643973155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093749Inst : IEnumerable<long>
{
public static readonly long[] Value=A093749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093749.Bytes);
public long this[int i]=>Value[i];

public static A093749Inst Instance=new A093749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093750
{
public static readonly long[] Value={ 0L,0L,0L,11L,146L,1914L,21741L,222847L,2177991L,20706430L,194021497L,1803413614L,16694681959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093750Inst : IEnumerable<long>
{
public static readonly long[] Value=A093750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093750.Bytes);
public long this[int i]=>Value[i];

public static A093750Inst Instance=new A093750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093751
{
public static readonly long[] Value={ 0L,0L,0L,1L,32L,550L,6364L,68291L,683896L,6641319L,63276295L,596278790L,5582122930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093751Inst : IEnumerable<long>
{
public static readonly long[] Value=A093751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093751.Bytes);
public long this[int i]=>Value[i];

public static A093751Inst Instance=new A093751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093752
{
public static readonly long[] Value={ 0L,0L,0L,2L,33L,557L,6721L,71248L,719531L,6996756L,66745265L,629634308L,5900013825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093752Inst : IEnumerable<long>
{
public static readonly long[] Value=A093752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093752.Bytes);
public long this[int i]=>Value[i];

public static A093752Inst Instance=new A093752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093753
{
public static readonly long[] Value={ 1L,7L,2L,8L,2L,7L,4L,5L,0L,9L,7L,4L,5L,8L,2L,0L,5L,0L,1L,9L,5L,7L,4L,0L,9L,3L,4L,1L,8L,6L,4L,2L,2L,8L,6L,2L,8L,9L,5L,1L,4L,2L,4L,7L,5L,9L,0L,2L,9L,7L,1L,0L,1L,2L,8L,9L,6L,3L,9L,9L,5L,0L,6L,9L,7L,5L,3L,9L,1L,2L,5L,4L,8L,1L,2L,1L,1L,6L,2L,2L,3L,7L,3L,5L,8L,0L,7L,9L,6L,7L,8L,7L,9L,2L,1L,6L,4L,0L,6L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093753Inst : IEnumerable<long>
{
public static readonly long[] Value=A093753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093753.Bytes);
public long this[int i]=>Value[i];

public static A093753Inst Instance=new A093753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093754
{
public static readonly long[] Value={ 6L,3L,9L,5L,1L,0L,3L,5L,1L,8L,7L,0L,3L,1L,1L,0L,0L,1L,9L,6L,2L,6L,9L,3L,0L,8L,5L,4L,2L,7L,3L,2L,3L,6L,7L,9L,8L,7L,5L,9L,9L,4L,6L,2L,5L,1L,8L,4L,7L,2L,8L,2L,9L,5L,1L,5L,8L,5L,6L,2L,3L,0L,8L,0L,2L,9L,2L,0L,5L,1L,6L,6L,3L,5L,6L,2L,5L,0L,3L,0L,5L,1L,8L,4L,8L,9L,7L,8L,9L,5L,4L,7L,7L,4L,2L,7L,3L,1L,6L,0L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093754Inst : IEnumerable<long>
{
public static readonly long[] Value=A093754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093754.Bytes);
public long this[int i]=>Value[i];

public static A093754Inst Instance=new A093754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093755
{
public static readonly long[] Value={ 0L,0L,3L,3L,0L,7L,11L,3L,15L,3L,7L,3L,23L,27L,3L,15L,11L,23L,31L,35L,3L,7L,11L,19L,39L,3L,11L,23L,27L,31L,35L,15L,31L,43L,3L,7L,15L,35L,47L,51L,11L,27L,31L,15L,19L,39L,43L,55L,59L,3L,47L,63L,7L,47L,71L,3L,7L,39L,55L,63L,75L,11L,23L,67L,75L,3L,7L,15L,19L,23L,27L,39L,87L,7L,15L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093755Inst : IEnumerable<long>
{
public static readonly long[] Value=A093755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093755.Bytes);
public long this[int i]=>Value[i];

public static A093755Inst Instance=new A093755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093756
{
public static readonly BigInteger[] Value={ 33L,1415L,231161L,9615369L,820764593L,35893627367L,4276470291419L,583865695517141L,4908050310594281L,2530031130103430497L,1272637542427085117L,BigInteger.Parse("22974734334167183952845") };
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
public class A093756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093756.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093756Inst Instance=new A093756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093757
{
public static readonly BigInteger[] Value={ 70L,2002L,277134L,10623470L,868227230L,37066624050L,4356563880010L,590186271509590L,4938927219474990L,2539314151841498430L,1275367677461622150L,BigInteger.Parse("23003602739546884860006") };
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
public class A093757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093757Inst Instance=new A093757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093758
{
public static readonly long[] Value={ -1L,1L,31L,89L,1469L,3659L,15349L,346963L,833089L,258703L,8323377L,1987291133L,635794127L,5092025963L,1072713041L,49364084095L,493755098403L,85882225477L,10581549625005L,23912704453369L,494209983771919L,14178953572271615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093758Inst : IEnumerable<long>
{
public static readonly long[] Value=A093758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093758.Bytes);
public long this[int i]=>Value[i];

public static A093758Inst Instance=new A093758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093759
{
public static readonly long[] Value={ 8L,32L,256L,512L,7168L,16384L,65536L,1441792L,3407872L,1048576L,33554432L,7985954816L,2550136832L,20401094656L,4294967296L,197568495616L,1975684956160L,343597383680L,42331197669376L,95657511616512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093759Inst : IEnumerable<long>
{
public static readonly long[] Value=A093759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093759.Bytes);
public long this[int i]=>Value[i];

public static A093759Inst Instance=new A093759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093760
{
public static readonly BigInteger[] Value={ 4L,256L,2048L,4194304L,54525952L,134754598912L,4797478469632L,281474976710656L,6757369765892718592L,BigInteger.Parse("745800601892181508096"),15816641891325181952UL,BigInteger.Parse("198634540185704451801088") };
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
public class A093760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093760Inst Instance=new A093760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093761
{
public static readonly BigInteger[] Value={ 1L,45L,315L,606375L,7640325L,18573630075L,655383804075L,38264331330225L,916111865931136875L,BigInteger.Parse("100955527625611283625"),2139180694732706625L,BigInteger.Parse("26851955023354986149625"),BigInteger.Parse("1684402483265040315792015") };
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
public class A093761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093761.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093761Inst Instance=new A093761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093762
{
public static readonly long[] Value={ 0L,0L,1L,1L,43L,3L,197L,499L,5471L,589L,82609L,7243L,1376527L,1530967L,1687123L,217033L,68127937L,1290761L,500679401L,107119657L,38046795L,1756445L,983477669L,622806889L,81955769933L,86074407533L,811851812797L,29280696293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093762Inst : IEnumerable<long>
{
public static readonly long[] Value=A093762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093762.Bytes);
public long this[int i]=>Value[i];

public static A093762Inst Instance=new A093762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093763
{
public static readonly long[] Value={ 1L,1L,12L,6L,180L,10L,560L,1260L,12600L,1260L,166320L,13860L,2522520L,2702700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093763Inst : IEnumerable<long>
{
public static readonly long[] Value=A093763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093763.Bytes);
public long this[int i]=>Value[i];

public static A093763Inst Instance=new A093763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093780
{
public static readonly long[] Value={ 3L,2L,7L,5L,59L,479L,821L,1871L,17393L,43019L,284783L,1572149L,2737793L,32938853L,24254639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093780Inst : IEnumerable<long>
{
public static readonly long[] Value=A093780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093780.Bytes);
public long this[int i]=>Value[i];

public static A093780Inst Instance=new A093780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093781
{
public static readonly long[] Value={ 7L,7L,1L,7L,18L,10L,3L,4L,11L,7L,8L,8L,10L,7L,3L,13L,8L,6L,7L,8L,6L,4L,7L,8L,9L,4L,6L,3L,4L,11L,5L,8L,3L,4L,4L,8L,8L,13L,3L,10L,21L,15L,6L,8L,3L,4L,13L,5L,3L,4L,8L,14L,6L,10L,3L,6L,12L,6L,10L,6L,6L,13L,8L,4L,6L,3L,11L,5L,3L,4L,13L,6L,10L,8L,4L,26L,8L,7L,11L,4L,7L,10L,7L,5L,4L,7L,16L,8L,7L,9L,3L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093781Inst : IEnumerable<long>
{
public static readonly long[] Value=A093781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093781.Bytes);
public long this[int i]=>Value[i];

public static A093781Inst Instance=new A093781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093782
{
public static readonly long[] Value={ 5L,0L,17L,19L,127L,61L,2L,31L,97L,13L,23L,269L,53L,239L,181L,449L,541L,11L,953L,1741L,179L,1889L,823L,3209L,13619L,383L,6971L,10331L,45959L,13721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093782Inst : IEnumerable<long>
{
public static readonly long[] Value=A093782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093782.Bytes);
public long this[int i]=>Value[i];

public static A093782Inst Instance=new A093782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093783
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,6L,7L,8L,11L,10L,11L,12L,13L,16L,15L,16L,17L,18L,21L,20L,21L,22L,23L,26L,25L,26L,27L,28L,31L,30L,31L,32L,33L,36L,35L,36L,37L,38L,41L,60L,61L,62L,63L,66L,65L,66L,67L,68L,71L,50L,51L,52L,53L,56L,55L,56L,57L,58L,61L,60L,61L,62L,63L,66L,65L,66L,67L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093783Inst : IEnumerable<long>
{
public static readonly long[] Value=A093783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093783.Bytes);
public long this[int i]=>Value[i];

public static A093783Inst Instance=new A093783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093784
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,6L,8L,8L,12L,24L,24L,20L,24L,24L,30L,30L,120L,120L,45L,72L,72L,80L,80L,144L,144L,144L,144L,720L,720L,144L,144L,240L,240L,252L,336L,336L,360L,360L,360L,360L,840L,840L,5040L,5040L,448L,576L,576L,630L,630L,720L,720L,960L,1152L,1152L,1440L,1440L,1920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093784Inst : IEnumerable<long>
{
public static readonly long[] Value=A093784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093784.Bytes);
public long this[int i]=>Value[i];

public static A093784Inst Instance=new A093784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093785
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,20L,30L,50L,100L,200L,300L,500L,1000L,2000L,3000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093785Inst : IEnumerable<long>
{
public static readonly long[] Value=A093785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093785.Bytes);
public long this[int i]=>Value[i];

public static A093785Inst Instance=new A093785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093786
{
public static readonly long[] Value={ 448L,576L,576L,630L,630L,720L,720L,960L,1152L,1152L,1440L,1440L,1920L,1920L,2016L,2016L,2880L,2880L,5760L,5760L,40320L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093786Inst : IEnumerable<long>
{
public static readonly long[] Value=A093786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093786.Bytes);
public long this[int i]=>Value[i];

public static A093786Inst Instance=new A093786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093787
{
public static readonly long[] Value={ 1680L,1680L,1920L,1920L,2160L,2160L,2240L,2240L,3024L,3024L,3456L,3456L,4320L,4320L,5184L,6480L,6480L,7560L,7560L,8640L,8640L,8640L,12960L,12960L,13440L,13440L,45360L,45360L,362880L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093787Inst : IEnumerable<long>
{
public static readonly long[] Value=A093787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093787.Bytes);
public long this[int i]=>Value[i];

public static A093787Inst Instance=new A093787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093788
{
public static readonly long[] Value={ 1L,11L,111L,15L,5L,51L,511L,5111L,110L,10L,101L,1011L,10111L,1015L,105L,1051L,10511L,105111L,10110L,1010L,10101L,101011L,1010111L,101015L,10105L,101051L,1010511L,10105111L,1010110L,101010L,1010101L,10101011L,101010111L,10101015L,1010105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093788Inst : IEnumerable<long>
{
public static readonly long[] Value=A093788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093788.Bytes);
public long this[int i]=>Value[i];

public static A093788Inst Instance=new A093788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093789
{
public static readonly long[] Value={ 4725L,6400L,6400L,6912L,6912L,8064L,8064L,8100L,10368L,10368L,11520L,11520L,12096L,12096L,12600L,12600L,14400L,14400L,16128L,16128L,17280L,17280L,22680L,22680L,28800L,28800L,40320L,40320L,43200L,43200L,48384L,48384L,86400L,86400L,100800L,100800L,103680L,103680L,403200L,403200L,3628800L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093789Inst : IEnumerable<long>
{
public static readonly long[] Value=A093789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093789.Bytes);
public long this[int i]=>Value[i];

public static A093789Inst Instance=new A093789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093790
{
public static readonly long[] Value={ 17280L,17280L,25920L,25920L,30240L,30240L,32400L,32400L,33600L,34560L,34560L,36288L,36288L,40320L,40320L,40320L,40320L,43200L,43200L,48384L,48384L,57600L,57600L,60480L,60480L,67200L,67200L,72576L,72576L,86400L,86400L,103680L,103680L,120960L,120960L,158400L,172800L,172800L,190080L,190080L,241920L,241920L,302400L,302400L,332640L,332640L,362880L,362880L,887040L,887040L,907200L,907200L,3991680L,3991680L,39916800L,39916800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093790Inst : IEnumerable<long>
{
public static readonly long[] Value=A093790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093790.Bytes);
public long this[int i]=>Value[i];

public static A093790Inst Instance=new A093790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093791
{
public static readonly long[] Value={ 62208L,82944L,82944L,85050L,85050L,107520L,107520L,115200L,115200L,129600L,129600L,134400L,134400L,136080L,136080L,155520L,155520L,161280L,161280L,179200L,179200L,181440L,201600L,201600L,226800L,226800L,228096L,230400L,230400L,248832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093791Inst : IEnumerable<long>
{
public static readonly long[] Value=A093791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093791.Bytes);
public long this[int i]=>Value[i];

public static A093791Inst Instance=new A093791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093792
{
public static readonly long[] Value={ 290304L,290304L,302400L,302400L,362880L,362880L,388800L,414720L,414720L,483840L,483840L,518400L,518400L,518400L,518400L,537600L,537600L,544320L,544320L,604800L,604800L,665280L,665280L,691200L,691200L,725760L,725760L,725760L,798336L,798336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093792Inst : IEnumerable<long>
{
public static readonly long[] Value=A093792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093792.Bytes);
public long this[int i]=>Value[i];

public static A093792Inst Instance=new A093792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093793
{
public static readonly long[] Value={ 2L,6L,22L,94L,622L,910L,1058L,1306L,4430L,18914L,23654L,35630L,52846L,63498L,85630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093793Inst : IEnumerable<long>
{
public static readonly long[] Value=A093793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093793.Bytes);
public long this[int i]=>Value[i];

public static A093793Inst Instance=new A093793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093794
{
public static readonly long[] Value={ 2L,14L,30L,56L,96L,192L,200L,462L,540L,1400L,2756L,9030L,99702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093794Inst : IEnumerable<long>
{
public static readonly long[] Value=A093794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093794.Bytes);
public long this[int i]=>Value[i];

public static A093794Inst Instance=new A093794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093795
{
public static readonly long[] Value={ 2L,7L,8L,31L,610L,1292L,4015L,5990L,8887L,9626L,57952L,62116L,84698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093795Inst : IEnumerable<long>
{
public static readonly long[] Value=A093795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093795.Bytes);
public long this[int i]=>Value[i];

public static A093795Inst Instance=new A093795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093812
{
public static readonly BigInteger[] Value={ 1L,15L,17L,1680L,421L,56086995L,9940915081637L,BigInteger.Parse("31271643639794562523698024915"),BigInteger.Parse("3090319883395626207270178075850946683940891639487741952"),BigInteger.Parse("9721376888636052447184767296534734059409700304429485542107645657085305") };
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
public class A093812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093812Inst Instance=new A093812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093813
{
public static readonly long[] Value={ 7L,6L,7L,8L,10L,8L,11L,8L,7L,7L,6L,5L,8L,7L,4L,6L,8L,9L,5L,8L,13L,8L,9L,11L,8L,7L,8L,6L,12L,9L,9L,7L,13L,11L,4L,8L,6L,12L,11L,13L,11L,9L,5L,4L,7L,8L,10L,12L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093813Inst : IEnumerable<long>
{
public static readonly long[] Value=A093813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093813.Bytes);
public long this[int i]=>Value[i];

public static A093813Inst Instance=new A093813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093814
{
public static readonly long[] Value={ 1L,5L,2L,0L,3L,4L,6L,9L,0L,1L,0L,6L,6L,2L,8L,0L,8L,0L,5L,6L,1L,1L,9L,4L,0L,1L,4L,6L,7L,5L,4L,9L,7L,5L,6L,2L,7L,0L,3L,6L,1L,0L,7L,4L,1L,8L,7L,7L,9L,0L,4L,6L,3L,3L,7L,5L,2L,8L,3L,6L,3L,8L,6L,8L,5L,2L,6L,7L,3L,4L,6L,2L,3L,9L,3L,0L,0L,5L,8L,3L,0L,4L,3L,1L,4L,8L,4L,1L,5L,3L,7L,2L,5L,9L,5L,6L,5L,5L,7L,7L,0L,7L,1L,6L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093814Inst : IEnumerable<long>
{
public static readonly long[] Value=A093814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093814.Bytes);
public long this[int i]=>Value[i];

public static A093814Inst Instance=new A093814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093815
{
public static readonly long[] Value={ 1L,4L,6L,28L,80L,409L,2010L,13314L,99363L,919304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093815Inst : IEnumerable<long>
{
public static readonly long[] Value=A093815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093815.Bytes);
public long this[int i]=>Value[i];

public static A093815Inst Instance=new A093815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093816
{
public static readonly long[] Value={ 1L,1L,9L,40L,282L,1455L,7278L,29849L,107399L,330369L,890152L,2096153L,4364470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093816Inst : IEnumerable<long>
{
public static readonly long[] Value=A093816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093816.Bytes);
public long this[int i]=>Value[i];

public static A093816Inst Instance=new A093816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093817
{
public static readonly long[] Value={ 1L,5L,13L,29L,61L,5L,23L,509L,1021L,409L,4093L,431L,16381L,6553L,71L,2473L,23831L,97L,1048573L,2713L,4194301L,1677721L,16777213L,70051L,5197L,31033L,1877171L,536870909L,46684427L,22605091L,464773L,296204641L,3360037L,6871947673L,283007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093817Inst : IEnumerable<long>
{
public static readonly long[] Value=A093817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093817.Bytes);
public long this[int i]=>Value[i];

public static A093817Inst Instance=new A093817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093818
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,3L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,1L,1L,11L,1L,1L,1L,11L,1L,1L,11L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093818Inst : IEnumerable<long>
{
public static readonly long[] Value=A093818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093818.Bytes);
public long this[int i]=>Value[i];

public static A093818Inst Instance=new A093818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093819
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,2L,6L,2L,6L,4L,10L,1L,12L,6L,8L,4L,16L,6L,18L,2L,12L,10L,22L,4L,20L,12L,18L,3L,28L,8L,30L,8L,20L,16L,24L,3L,36L,18L,24L,8L,40L,12L,42L,5L,24L,22L,46L,8L,42L,20L,32L,6L,52L,18L,40L,12L,36L,28L,58L,4L,60L,30L,36L,16L,48L,20L,66L,8L,44L,24L,70L,12L,72L,36L,40L,9L,60L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093819Inst : IEnumerable<long>
{
public static readonly long[] Value=A093819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093819.Bytes);
public long this[int i]=>Value[i];

public static A093819Inst Instance=new A093819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093820
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,8L,6L,22L,10L,24L,20L,42L,12L,36L,32L,64L,16L,64L,18L,82L,50L,60L,22L,144L,60L,48L,64L,96L,28L,172L,30L,282L,78L,64L,70L,256L,36L,72L,106L,254L,80L,204L,84L,176L,166L,88L,92L,518L,78L,200L,136L,210L,104L,244L,134L,346L,96L,112L,58L,538L,120L,120L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093820Inst : IEnumerable<long>
{
public static readonly long[] Value=A093820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093820.Bytes);
public long this[int i]=>Value[i];

public static A093820Inst Instance=new A093820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093821
{
public static readonly long[] Value={ 8L,4L,5L,2L,9L,9L,4L,6L,1L,6L,2L,0L,7L,4L,8L,4L,7L,0L,9L,8L,1L,7L,0L,2L,4L,3L,8L,9L,9L,6L,0L,8L,5L,0L,8L,8L,7L,0L,4L,7L,9L,6L,4L,9L,7L,4L,5L,9L,7L,4L,6L,2L,4L,7L,9L,6L,2L,7L,9L,5L,3L,4L,7L,0L,3L,2L,0L,4L,4L,6L,5L,5L,3L,9L,4L,1L,3L,3L,3L,0L,8L,6L,1L,2L,5L,6L,9L,2L,0L,8L,8L,2L,8L,5L,0L,0L,9L,4L,9L,5L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093821Inst : IEnumerable<long>
{
public static readonly long[] Value=A093821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093821.Bytes);
public long this[int i]=>Value[i];

public static A093821Inst Instance=new A093821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093822
{
public static readonly long[] Value={ 8L,4L,4L,1L,3L,7L,1L,2L,3L,7L,9L,5L,6L,3L,7L,6L,8L,1L,0L,6L,3L,0L,8L,7L,1L,3L,8L,0L,2L,9L,5L,2L,2L,6L,5L,4L,5L,1L,8L,4L,5L,1L,7L,4L,9L,8L,6L,6L,2L,7L,5L,9L,4L,2L,6L,2L,4L,8L,4L,9L,6L,8L,1L,6L,6L,4L,9L,6L,9L,8L,2L,9L,4L,0L,1L,0L,3L,9L,4L,1L,4L,6L,2L,2L,9L,9L,8L,0L,9L,6L,7L,0L,5L,8L,1L,6L,0L,1L,9L,8L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093822Inst : IEnumerable<long>
{
public static readonly long[] Value=A093822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093822.Bytes);
public long this[int i]=>Value[i];

public static A093822Inst Instance=new A093822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093823
{
public static readonly long[] Value={ 2L,8L,4L,2L,5L,8L,2L,2L,4L,6L,5L,1L,3L,4L,3L,0L,7L,0L,7L,6L,1L,7L,2L,7L,2L,8L,9L,0L,1L,1L,5L,0L,5L,2L,9L,2L,6L,5L,6L,5L,2L,5L,1L,5L,0L,7L,5L,5L,1L,7L,2L,8L,6L,0L,7L,7L,9L,3L,3L,0L,4L,8L,9L,4L,8L,4L,4L,2L,5L,5L,1L,8L,5L,5L,1L,3L,3L,7L,3L,8L,2L,1L,6L,6L,2L,3L,0L,0L,1L,0L,7L,1L,5L,8L,7L,7L,2L,8L,6L,0L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093823Inst : IEnumerable<long>
{
public static readonly long[] Value=A093823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093823.Bytes);
public long this[int i]=>Value[i];

public static A093823Inst Instance=new A093823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093824
{
public static readonly long[] Value={ 7L,5L,3L,3L,5L,5L,4L,6L,0L,5L,1L,9L,5L,2L,9L,8L,8L,0L,2L,7L,8L,0L,3L,8L,2L,3L,7L,8L,3L,5L,3L,5L,4L,7L,6L,8L,2L,6L,4L,0L,3L,2L,3L,5L,0L,9L,0L,0L,9L,1L,1L,8L,5L,7L,5L,1L,3L,4L,0L,0L,9L,3L,0L,2L,4L,3L,4L,4L,6L,2L,2L,4L,0L,1L,7L,7L,0L,2L,6L,8L,6L,9L,6L,5L,1L,3L,9L,5L,8L,1L,0L,9L,8L,6L,1L,3L,5L,8L,6L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093824Inst : IEnumerable<long>
{
public static readonly long[] Value=A093824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093824.Bytes);
public long this[int i]=>Value[i];

public static A093824Inst Instance=new A093824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093825
{
public static readonly long[] Value={ 7L,4L,0L,4L,8L,0L,4L,8L,9L,6L,9L,3L,0L,6L,1L,0L,4L,1L,1L,6L,9L,3L,1L,3L,4L,9L,8L,3L,4L,3L,4L,4L,8L,9L,4L,9L,7L,6L,9L,1L,0L,3L,6L,1L,4L,8L,9L,5L,9L,4L,8L,3L,7L,0L,5L,1L,4L,2L,3L,2L,6L,0L,1L,1L,5L,9L,4L,0L,5L,7L,9L,8L,8L,4L,9L,9L,1L,2L,3L,1L,8L,4L,2L,9L,2L,2L,1L,1L,5L,5L,7L,9L,4L,1L,2L,7L,5L,3L,9L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093825Inst : IEnumerable<long>
{
public static readonly long[] Value=A093825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093825.Bytes);
public long this[int i]=>Value[i];

public static A093825Inst Instance=new A093825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093826
{
public static readonly long[] Value={ 5L,1L,16L,12L,49L,58L,60L,110L,209L,117L,240L,430L,255L,1423L,921L,980L,511L,1847L,3737L,3692L,3998L,7265L,15267L,15651L,15722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093826Inst : IEnumerable<long>
{
public static readonly long[] Value=A093826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093826.Bytes);
public long this[int i]=>Value[i];

public static A093826Inst Instance=new A093826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093827
{
public static readonly long[] Value={ 1L,7L,8L,6L,5L,7L,6L,4L,5L,9L,3L,6L,5L,9L,2L,2L,4L,6L,3L,4L,5L,8L,5L,9L,0L,4L,7L,5L,5L,4L,1L,3L,1L,5L,7L,5L,0L,3L,1L,2L,6L,2L,1L,9L,0L,2L,3L,8L,4L,2L,4L,3L,2L,9L,4L,9L,0L,1L,0L,7L,2L,4L,9L,6L,2L,1L,4L,2L,4L,5L,2L,7L,9L,1L,3L,4L,7L,8L,6L,2L,2L,3L,7L,7L,3L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093827Inst : IEnumerable<long>
{
public static readonly long[] Value=A093827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093827.Bytes);
public long this[int i]=>Value[i];

public static A093827Inst Instance=new A093827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093860
{
public static readonly long[] Value={ 37L,23L,17L,19L,67L,41L,29L,31L,97L,59L,41L,43L,71L,983L,383L,53L,293L,157L,277L,373L,67L,353L,71L,113L,653L,79L,467L,131L,89L,139L,193L,97L,311L,101L,103L,919L,109L,743L,113L,563L,307L,587L,457L,127L,263L,131L,419L,137L,139L,367L,613L,149L,151L,311L,653L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093860Inst : IEnumerable<long>
{
public static readonly long[] Value=A093860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093860.Bytes);
public long this[int i]=>Value[i];

public static A093860Inst Instance=new A093860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093861
{
public static readonly long[] Value={ 256L,216L,256L,140L,100L,144L,196L,160L,138L,181L,232L,206L,186L,232L,213L,199L,187L,178L,214L,256L,243L,232L,223L,216L,251L,243L,236L,272L,311L,301L,293L,332L,323L,315L,307L,301L,337L,330L,323L,317L,312L,346L,384L,376L,370L,364L,359L,394L,388L,382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093861Inst : IEnumerable<long>
{
public static readonly long[] Value=A093861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093861.Bytes);
public long this[int i]=>Value[i];

public static A093861Inst Instance=new A093861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093862
{
public static readonly long[] Value={ 4L,5L,14L,30L,195L,259L,973L,1089L,3019L,17416L,15956L,68436L,122031L,104011L,173476L,514829L,1399259L,1122753L,2749896L,3732219L,3000994L,6519381L,8421098L,16942907L,51129827L,61096684L,47709104L,56904308L,45489733L,54108081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093862Inst : IEnumerable<long>
{
public static readonly long[] Value=A093862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093862.Bytes);
public long this[int i]=>Value[i];

public static A093862Inst Instance=new A093862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093863
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,16L,17L,18L,20L,24L,34L,36L,40L,48L,68L,72L,80L,136L,144L,256L,257L,272L,514L,768L,1028L,1280L,2056L,2304L,2808L,4112L,4320L,4352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093863Inst : IEnumerable<long>
{
public static readonly long[] Value=A093863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093863.Bytes);
public long this[int i]=>Value[i];

public static A093863Inst Instance=new A093863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093864
{
public static readonly long[] Value={ 11L,53L,173L,521L,1523L,4327L,11579L,31469L,85411L,229547L,614477L,1640461L,4393369L,11806297L,31656553L,84979847L,228346229L,614582509L,1654328267L,4457160931L,12016414601L,32419200013L,87508870037L,236325429049L,638490906857L,1725782162981L,4666340800001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093864Inst : IEnumerable<long>
{
public static readonly long[] Value=A093864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093864.Bytes);
public long this[int i]=>Value[i];

public static A093864Inst Instance=new A093864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093865
{
public static readonly BigInteger[] Value={ 2L,5L,127L,260144663L,BigInteger.Parse("1191446656198440121121655815832664828439647") };
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
public class A093865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093865Inst Instance=new A093865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093866
{
public static readonly long[] Value={ 1L,3L,6L,14L,24L,38L,50L,68L,84L,114L,146L,168L,210L,264L,308L,348L,398L,432L,486L,542L,582L,644L,698L,744L,818L,868L,930L,1034L,1098L,1188L,1286L,1348L,1412L,1478L,1546L,1616L,1688L,1762L,1838L,1916L,1996L,2078L,2162L,2254L,2362L,2452L,2544L,2688L,2856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093866Inst : IEnumerable<long>
{
public static readonly long[] Value=A093866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093866.Bytes);
public long this[int i]=>Value[i];

public static A093866Inst Instance=new A093866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093867
{
public static readonly long[] Value={ 4L,9L,25L,25L,49L,49L,121L,121L,121L,121L,169L,169L,289L,289L,289L,289L,361L,361L,529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093867Inst : IEnumerable<long>
{
public static readonly long[] Value=A093867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093867.Bytes);
public long this[int i]=>Value[i];

public static A093867Inst Instance=new A093867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093868
{
public static readonly long[] Value={ 2L,3L,2L,3L,11L,5L,13L,7L,17L,11L,23L,11L,53L,13L,29L,17L,67L,17L,37L,19L,41L,23L,47L,23L,101L,53L,53L,29L,59L,29L,61L,31L,67L,67L,71L,37L,73L,37L,79L,41L,83L,41L,173L,43L,89L,47L,281L,47L,97L,101L,101L,53L,107L,53L,109L,113L,113L,59L,353L,59L,367L,61L,127L,127L,131L,67L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093868Inst : IEnumerable<long>
{
public static readonly long[] Value=A093868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093868.Bytes);
public long this[int i]=>Value[i];

public static A093868Inst Instance=new A093868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093869
{
public static readonly long[] Value={ 2L,2L,1L,1L,3L,2L,3L,1L,3L,3L,1L,3L,3L,1L,3L,5L,3L,2L,5L,3L,2L,3L,3L,3L,3L,5L,1L,3L,2L,4L,4L,3L,3L,1L,3L,2L,3L,3L,3L,5L,3L,2L,3L,2L,3L,1L,3L,3L,3L,2L,4L,4L,2L,3L,3L,3L,5L,1L,4L,5L,3L,5L,5L,3L,2L,3L,3L,3L,3L,2L,6L,3L,6L,6L,3L,3L,3L,3L,3L,4L,3L,2L,5L,2L,4L,3L,3L,3L,3L,1L,3L,4L,4L,5L,3L,3L,7L,4L,1L,3L,5L,3L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093869Inst : IEnumerable<long>
{
public static readonly long[] Value=A093869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093869.Bytes);
public long this[int i]=>Value[i];

public static A093869Inst Instance=new A093869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093870
{
public static readonly long[] Value={ 2L,3L,5L,2L,5L,11L,3L,7L,11L,19L,19L,29L,59L,79L,89L,5L,11L,17L,23L,29L,41L,13L,41L,83L,97L,139L,167L,181L,7L,23L,31L,47L,71L,79L,103L,127L,17L,53L,71L,89L,107L,179L,197L,233L,251L,19L,29L,59L,79L,89L,109L,139L,139L,149L,179L,199L,43L,109L,131L,197L,241L,263L,307L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093870Inst : IEnumerable<long>
{
public static readonly long[] Value=A093870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093870.Bytes);
public long this[int i]=>Value[i];

public static A093870Inst Instance=new A093870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093871
{
public static readonly long[] Value={ 2L,5L,11L,19L,89L,41L,181L,127L,251L,199L,571L,227L,1013L,433L,599L,751L,2039L,593L,2089L,859L,1637L,1429L,4001L,1103L,4049L,2053L,3779L,2267L,6263L,1499L,6571L,3583L,5279L,3943L,6089L,2879L,11321L,4597L,7331L,4919L,15497L,3779L,15307L,6599L,8009L,7681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093871Inst : IEnumerable<long>
{
public static readonly long[] Value=A093871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093871.Bytes);
public long this[int i]=>Value[i];

public static A093871Inst Instance=new A093871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093872
{
public static readonly long[] Value={ 0L,4L,9L,0L,6L,0L,10L,15L,14L,21L,121L,35L,22L,33L,26L,39L,210L,65L,34L,51L,38L,57L,273L,95L,46L,69L,285L,115L,399L,161L,58L,87L,62L,93L,741L,155L,435L,217L,74L,111L,651L,185L,82L,123L,86L,129L,777L,215L,94L,141L,645L,235L,903L,329L,106L,159L,987L,265L,1645L,371L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093872Inst : IEnumerable<long>
{
public static readonly long[] Value=A093872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093872.Bytes);
public long this[int i]=>Value[i];

public static A093872Inst Instance=new A093872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093873
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,3L,2L,3L,1L,3L,2L,3L,1L,4L,3L,4L,2L,5L,3L,5L,1L,4L,3L,4L,2L,5L,3L,5L,1L,5L,4L,5L,3L,7L,4L,7L,2L,7L,5L,7L,3L,8L,5L,8L,1L,5L,4L,5L,3L,7L,4L,7L,2L,7L,5L,7L,3L,8L,5L,8L,1L,6L,5L,6L,4L,9L,5L,9L,3L,10L,7L,10L,4L,11L,7L,11L,2L,9L,7L,9L,5L,12L,7L,12L,3L,11L,8L,11L,5L,13L,8L,13L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093873Inst : IEnumerable<long>
{
public static readonly long[] Value=A093873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093873.Bytes);
public long this[int i]=>Value[i];

public static A093873Inst Instance=new A093873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093874
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,5L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093874Inst : IEnumerable<long>
{
public static readonly long[] Value=A093874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093874.Bytes);
public long this[int i]=>Value[i];

public static A093874Inst Instance=new A093874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093875
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,3L,3L,4L,4L,5L,5L,4L,4L,5L,5L,5L,5L,7L,7L,7L,7L,8L,8L,5L,5L,7L,7L,7L,7L,8L,8L,6L,6L,9L,9L,10L,10L,11L,11L,9L,9L,12L,12L,11L,11L,13L,13L,6L,6L,9L,9L,10L,10L,11L,11L,9L,9L,12L,12L,11L,11L,13L,13L,7L,7L,11L,11L,13L,13L,14L,14L,13L,13L,17L,17L,15L,15L,18L,18L,11L,11L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093875Inst : IEnumerable<long>
{
public static readonly long[] Value=A093875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093875.Bytes);
public long this[int i]=>Value[i];

public static A093875Inst Instance=new A093875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093892
{
public static readonly long[] Value={ 1L,3L,2L,51L,4L,6L,8L,10L,242L,12L,363L,16L,18L,20L,92L,50L,28L,24L,32L,2514L,30L,1002L,1434L,894L,36L,474L,678L,1338L,354L,402L,48L,64L,174L,138L,66L,105L,114L,255L,102L,60L,627L,88L,80L,470L,72L,130L,104L,100L,84L,170L,190L,90L,152L,112L,96L,136L,406L,595L,385L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093892Inst : IEnumerable<long>
{
public static readonly long[] Value=A093892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093892.Bytes);
public long this[int i]=>Value[i];

public static A093892Inst Instance=new A093892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093893
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,83L,87L,89L,91L,97L,101L,103L,107L,109L,113L,121L,127L,131L,133L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,183L,191L,193L,197L,199L,211L,213L,217L,223L,227L,229L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093893Inst : IEnumerable<long>
{
public static readonly long[] Value=A093893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093893.Bytes);
public long this[int i]=>Value[i];

public static A093893Inst Instance=new A093893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093894
{
public static readonly long[] Value={ 49L,87L,91L,121L,133L,169L,183L,213L,217L,247L,249L,259L,287L,301L,339L,343L,361L,403L,411L,427L,445L,469L,473L,481L,501L,511L,527L,529L,553L,559L,581L,589L,591L,633L,679L,699L,703L,713L,717L,721L,763L,789L,793L,817L,841L,843L,871L,889L,895L,949L,951L,961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093894Inst : IEnumerable<long>
{
public static readonly long[] Value=A093894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093894.Bytes);
public long this[int i]=>Value[i];

public static A093894Inst Instance=new A093894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093895
{
public static readonly long[] Value={ 2L,4L,2L,8L,2L,13L,2L,16L,2L,4L,2L,29L,2L,4L,2L,32L,2L,40L,2L,43L,2L,4L,2L,61L,2L,4L,2L,57L,2L,73L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093895Inst : IEnumerable<long>
{
public static readonly long[] Value=A093895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093895.Bytes);
public long this[int i]=>Value[i];

public static A093895Inst Instance=new A093895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093896
{
public static readonly long[] Value={ 1L,4L,9L,10L,25L,15L,49L,28L,39L,45L,121L,28L,169L,91L,65L,66L,289L,78L,361L,85L,133L,231L,529L,76L,205L,325L,165L,175L,841L,125L,961L,164L,341L,561L,217L,150L,1369L,703L,481L,165L,1681L,259L,1849L,451L,186L,1035L,2209L,196L,595L,405L,833L,637L,2809L,327L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093896Inst : IEnumerable<long>
{
public static readonly long[] Value=A093896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093896.Bytes);
public long this[int i]=>Value[i];

public static A093896Inst Instance=new A093896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093897
{
public static readonly BigInteger[] Value={ 1L,6L,13440L,14175L,BigInteger.Parse("4963587213865915514880"),28028000L,BigInteger.Parse("738615790595351500616546025309298211371540807680000000000"),BigInteger.Parse("18172761476738086968750"),BigInteger.Parse("52650499032325167909847642931200000000") };
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
public class A093897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A093897.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A093897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A093897Inst Instance=new A093897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093898
{
public static readonly long[] Value={ 2L,3L,8L,4L,17L,54L,5L,32L,145L,512L,6L,57L,368L,1649L,6250L,7L,100L,945L,5392L,23401L,93312L,8L,177L,2530L,18785L,94932L,397585L,1647086L,9L,320L,7073L,69632L,423393L,1941760L,7861953L,33554432L,10L,593L,20412L,268705L,2012174L,10609137L,45136576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093898Inst : IEnumerable<long>
{
public static readonly long[] Value=A093898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093898.Bytes);
public long this[int i]=>Value[i];

public static A093898Inst Instance=new A093898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093899
{
public static readonly long[] Value={ 1L,3L,6L,8L,19L,12L,25L,48L,79L,60L,62L,109L,38L,139L,96L,9L,182L,265L,42L,155L,66L,112L,291L,134L,241L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093899Inst : IEnumerable<long>
{
public static readonly long[] Value=A093899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093899.Bytes);
public long this[int i]=>Value[i];

public static A093899Inst Instance=new A093899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093900
{
public static readonly long[] Value={ 1L,3L,8L,25L,62L,9L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093900Inst : IEnumerable<long>
{
public static readonly long[] Value=A093900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093900.Bytes);
public long this[int i]=>Value[i];

public static A093900Inst Instance=new A093900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093901
{
public static readonly long[] Value={ 1L,6L,12L,60L,96L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093901Inst : IEnumerable<long>
{
public static readonly long[] Value=A093901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093901.Bytes);
public long this[int i]=>Value[i];

public static A093901Inst Instance=new A093901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093902
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,7L,17L,23L,29L,31L,67L,19L,37L,47L,61L,71L,41L,101L,79L,43L,53L,173L,73L,83L,227L,223L,97L,113L,59L,89L,103L,179L,109L,157L,131L,107L,199L,191L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093902Inst : IEnumerable<long>
{
public static readonly long[] Value=A093902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093902.Bytes);
public long this[int i]=>Value[i];

public static A093902Inst Instance=new A093902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093903
{
public static readonly long[] Value={ 1L,3L,6L,11L,4L,15L,2L,19L,38L,9L,32L,63L,26L,67L,24L,71L,18L,77L,16L,83L,12L,85L,164L,81L,170L,73L,174L,65L,168L,61L,188L,75L,206L,69L,208L,59L,210L,53L,216L,49L,222L,43L,224L,33L,226L,29L,228L,17L,240L,13L,242L,475L,236L,477L,220L,471L,202L,465L,194L,487L,204L,481L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093903Inst : IEnumerable<long>
{
public static readonly long[] Value=A093903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093903.Bytes);
public long this[int i]=>Value[i];

public static A093903Inst Instance=new A093903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093904
{
public static readonly long[] Value={ 0L,1L,4L,17L,84L,485L,3236L,24609L,210572L,2004749L,21033900L,241237001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093904Inst : IEnumerable<long>
{
public static readonly long[] Value=A093904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093904.Bytes);
public long this[int i]=>Value[i];

public static A093904Inst Instance=new A093904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093905
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,11L,1L,7L,26L,50L,1L,9L,47L,154L,274L,1L,11L,74L,342L,1044L,1764L,1L,13L,107L,638L,2754L,8028L,13068L,1L,15L,146L,1066L,5944L,24552L,69264L,109584L,1L,17L,191L,1650L,11274L,60216L,241128L,663696L,1026576L,1L,19L,242L,2414L,19524L,127860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093905Inst : IEnumerable<long>
{
public static readonly long[] Value=A093905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093905.Bytes);
public long this[int i]=>Value[i];

public static A093905Inst Instance=new A093905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A093906
{
public static readonly long[] Value={ 1L,3L,6L,7L,12L,13L,14L,15L,24L,27L,28L,29L,30L,31L,48L,49L,54L,57L,58L,59L,60L,61L,62L,63L,97L,98L,108L,109L,114L,117L,118L,119L,120L,123L,124L,127L,194L,197L,217L,218L,219L,228L,229L,237L,238L,239L,240L,241L,246L,247L,248L,249L,389L,394L,434L,439L,457L,458L,479L,482L,492L,493L,497L,498L,499L,788L,789L,878L,879L,917L,959L,984L,985L,986L,994L,997L,998L,1579L,1757L,1758L,1759L,1968L,1971L,1988L,1994L,1997L,3514L,3517L,3518L,3989L,7028L,7034L,7037L,7978L,14074L,28148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A093906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A093906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A093906Inst : IEnumerable<long>
{
public static readonly long[] Value=A093906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A093906.Bytes);
public long this[int i]=>Value[i];

public static A093906Inst Instance=new A093906Inst();

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