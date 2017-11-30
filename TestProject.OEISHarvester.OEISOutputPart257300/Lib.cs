using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A141810
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,2L,3L,7L,8L,9L,2L,5L,11L,3L,4L,13L,2L,7L,3L,5L,16L,17L,2L,9L,19L,4L,5L,3L,7L,2L,11L,23L,3L,8L,25L,2L,13L,27L,4L,7L,29L,2L,3L,5L,31L,32L,3L,11L,2L,17L,5L,7L,4L,9L,37L,2L,19L,3L,13L,5L,8L,41L,2L,3L,7L,43L,4L,11L,5L,9L,2L,23L,47L,3L,16L,49L,2L,25L,3L,17L,4L,13L,53L,2L,27L,5L,11L,7L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141810Inst : IEnumerable<long>
{
public static readonly long[] Value=A141810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141810.Bytes);
public long this[int i]=>Value[i];

public static A141810Inst Instance=new A141810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141811
{
public static readonly long[] Value={ 1L,3L,1L,10L,3L,2L,35L,10L,6L,5L,126L,35L,20L,15L,14L,462L,126L,70L,50L,42L,42L,1716L,462L,252L,175L,140L,126L,132L,6435L,1716L,924L,630L,490L,420L,396L,429L,24310L,6435L,3432L,2310L,1764L,1470L,1320L,1287L,1430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141811Inst : IEnumerable<long>
{
public static readonly long[] Value=A141811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141811.Bytes);
public long this[int i]=>Value[i];

public static A141811Inst Instance=new A141811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141812
{
public static readonly long[] Value={ 1L,5L,29L,169L,145L,845L,1105L,2405L,3445L,4901L,2665L,5525L,9425L,12325L,12025L,17225L,24505L,13325L,32045L,55205L,47125L,61625L,69745L,101065L,99905L,77285L,124501L,160225L,186745L,204425L,239425L,160225L,273325L,276025L,292825L,226525L,446165L,456025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141812Inst : IEnumerable<long>
{
public static readonly long[] Value=A141812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141812.Bytes);
public long this[int i]=>Value[i];

public static A141812Inst Instance=new A141812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141813
{
public static readonly long[] Value={ 1L,7L,41L,239L,3055L,6665L,9545L,9855L,26095L,34697L,155287L,380511L,421655L,627215L,814463L,823537L,1166399L,1204281L,1256489L,1289441L,1815073L,2265353L,2544697L,2627343L,3132935L,3188809L,3762639L,4647985L,4730879L,4963127L,4995569L,5054015L,5143945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141813Inst : IEnumerable<long>
{
public static readonly long[] Value=A141813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141813.Bytes);
public long this[int i]=>Value[i];

public static A141813Inst Instance=new A141813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141814
{
public static readonly long[] Value={ 1L,5L,29L,169L,1105L,2405L,3445L,2665L,9425L,12325L,55205L,101065L,124501L,160225L,204425L,239425L,292825L,226525L,446165L,456025L,456025L,801125L,637325L,493025L,801125L,801125L,706225L,1185665L,1185665L,1759925L,1770305L,1291225L,1313845L,1185665L,1743625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141814Inst : IEnumerable<long>
{
public static readonly long[] Value=A141814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141814.Bytes);
public long this[int i]=>Value[i];

public static A141814Inst Instance=new A141814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A141815
{
public static readonly long[] Value={ 627215L,876785L,1289441L,1815073L,2265353L,3132935L,3188809L,4390505L,4647985L,4730879L,6542705L,9026087L,11369969L,12705511L,15203889L,15857471L,17888153L,18253913L,18578719L,20871649L,21026655L,21930545L,22321663L,23630711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A141815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A141815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A141815Inst : IEnumerable<long>
{
public static readonly long[] Value=A141815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A141815.Bytes);
public long this[int i]=>Value[i];

public static A141815Inst Instance=new A141815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142216
{
public static readonly long[] Value={ 19L,101L,347L,593L,757L,839L,1249L,1741L,1823L,1987L,2069L,2971L,3217L,3299L,3463L,3709L,4201L,4283L,4447L,5021L,5431L,5923L,6661L,6907L,7481L,7727L,8219L,8629L,9203L,9613L,9859L,9941L,10433L,10597L,11171L,11827L,11909L,12073L,12401L,12647L,12893L,13877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142216Inst : IEnumerable<long>
{
public static readonly long[] Value=A142216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142216.Bytes);
public long this[int i]=>Value[i];

public static A142216Inst Instance=new A142216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142217
{
public static readonly long[] Value={ 61L,307L,389L,881L,1291L,1373L,1619L,1783L,2029L,2111L,2357L,2521L,2767L,3259L,3833L,4079L,4243L,4817L,5227L,5309L,5801L,6047L,6211L,6703L,6949L,7523L,7687L,7933L,8179L,8753L,8999L,9491L,9901L,10639L,11131L,11213L,12197L,12689L,12853L,13099L,13591L,14083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142217Inst : IEnumerable<long>
{
public static readonly long[] Value=A142217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142217.Bytes);
public long this[int i]=>Value[i];

public static A142217Inst Instance=new A142217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142218
{
public static readonly long[] Value={ 103L,349L,431L,677L,1087L,1579L,1907L,2153L,2399L,3137L,3301L,3547L,3793L,5023L,5351L,5843L,6007L,6089L,6581L,6827L,6991L,7237L,8221L,8467L,8713L,9041L,9533L,9697L,10271L,11173L,12157L,12239L,13469L,13633L,13879L,14207L,14699L,15601L,15683L,16339L,16421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142218Inst : IEnumerable<long>
{
public static readonly long[] Value=A142218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142218.Bytes);
public long this[int i]=>Value[i];

public static A142218Inst Instance=new A142218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142219
{
public static readonly long[] Value={ 227L,719L,883L,1129L,1621L,1867L,1949L,2113L,2441L,2687L,2851L,3343L,3671L,3917L,4327L,4409L,5147L,5393L,5557L,5639L,6131L,6869L,7607L,7853L,8017L,8263L,8837L,9001L,9739L,10067L,10313L,10477L,10559L,10723L,11789L,11953L,12281L,12527L,13183L,13757L,13921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142219Inst : IEnumerable<long>
{
public static readonly long[] Value=A142219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142219.Bytes);
public long this[int i]=>Value[i];

public static A142219Inst Instance=new A142219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142220
{
public static readonly long[] Value={ 23L,269L,433L,761L,1171L,1499L,1663L,2237L,2647L,2729L,3221L,3467L,3631L,3877L,4451L,4861L,4943L,5107L,5189L,5927L,6091L,6173L,6337L,6829L,6911L,7321L,7649L,8059L,8387L,9043L,9371L,9781L,10273L,10601L,10847L,11093L,11257L,11503L,11831L,12241L,12323L,12487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142220Inst : IEnumerable<long>
{
public static readonly long[] Value=A142220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142220.Bytes);
public long this[int i]=>Value[i];

public static A142220Inst Instance=new A142220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142221
{
public static readonly long[] Value={ 229L,311L,557L,967L,1049L,1213L,1459L,1787L,1951L,2689L,3181L,3673L,3919L,4001L,4493L,4657L,4903L,5231L,5477L,5641L,6133L,6379L,6871L,7691L,7937L,8101L,8429L,8839L,9413L,10069L,10151L,10889L,11299L,12037L,12119L,12611L,13103L,13267L,13513L,13759L,13841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142221Inst : IEnumerable<long>
{
public static readonly long[] Value=A142221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142221.Bytes);
public long this[int i]=>Value[i];

public static A142221Inst Instance=new A142221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142222
{
public static readonly long[] Value={ 107L,271L,353L,599L,1009L,1091L,1583L,1747L,1993L,2239L,2731L,3469L,3797L,4289L,5273L,5437L,5519L,5683L,6011L,6257L,6421L,7159L,7487L,8389L,8963L,9127L,9209L,9619L,10111L,10193L,10357L,11177L,11423L,11587L,11833L,12161L,12653L,12899L,13063L,13309L,13883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142222Inst : IEnumerable<long>
{
public static readonly long[] Value=A142222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142222.Bytes);
public long this[int i]=>Value[i];

public static A142222Inst Instance=new A142222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142223
{
public static readonly long[] Value={ 67L,149L,313L,641L,887L,1051L,1297L,1543L,1789L,1871L,2281L,2609L,3019L,3347L,3511L,3593L,4003L,4987L,5233L,5479L,5807L,6053L,6217L,6299L,6709L,6791L,7283L,7529L,8431L,8513L,8677L,8923L,9497L,9661L,9743L,9907L,10399L,10891L,10973L,11383L,12203L,12613L,12941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142223Inst : IEnumerable<long>
{
public static readonly long[] Value=A142223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142223.Bytes);
public long this[int i]=>Value[i];

public static A142223Inst Instance=new A142223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142224
{
public static readonly long[] Value={ 109L,191L,601L,683L,929L,1093L,1667L,1831L,1913L,2897L,3061L,3307L,3389L,3881L,4127L,4373L,4783L,5521L,5849L,6833L,6997L,7079L,7243L,7489L,7817L,8719L,9293L,9539L,9949L,10687L,11261L,12163L,12409L,12491L,12983L,13147L,13229L,13721L,13967L,14869L,14951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142224Inst : IEnumerable<long>
{
public static readonly long[] Value=A142224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142224.Bytes);
public long this[int i]=>Value[i];

public static A142224Inst Instance=new A142224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142225
{
public static readonly long[] Value={ 151L,233L,397L,479L,643L,971L,1217L,1381L,1627L,1709L,1873L,2447L,2693L,2857L,2939L,3677L,3923L,5153L,5399L,5563L,6301L,6547L,6793L,7039L,7121L,8269L,8597L,8761L,9007L,10729L,11057L,11467L,11549L,11959L,12041L,12451L,12697L,13681L,13763L,14009L,14173L,14419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142225Inst : IEnumerable<long>
{
public static readonly long[] Value=A142225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142225.Bytes);
public long this[int i]=>Value[i];

public static A142225Inst Instance=new A142225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142226
{
public static readonly long[] Value={ 29L,193L,439L,521L,1013L,1259L,1423L,1669L,1997L,2161L,2243L,3391L,3637L,3719L,4129L,4211L,4457L,4621L,4703L,5113L,5441L,5851L,6343L,6917L,7573L,7901L,8147L,8311L,8803L,9049L,9377L,9623L,9787L,10607L,10771L,10853L,12329L,12739L,12821L,13313L,13477L,13723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142226Inst : IEnumerable<long>
{
public static readonly long[] Value=A142226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142226.Bytes);
public long this[int i]=>Value[i];

public static A142226Inst Instance=new A142226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142227
{
public static readonly long[] Value={ 71L,317L,563L,727L,809L,1301L,2039L,2203L,2531L,2777L,3023L,3187L,3433L,3761L,4007L,4253L,4663L,4909L,5237L,5483L,5647L,6221L,6959L,7369L,7451L,8353L,8599L,8681L,9091L,9173L,9337L,9419L,9829L,10321L,10567L,11059L,11551L,11633L,12043L,12289L,12781L,13109L,14011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142227Inst : IEnumerable<long>
{
public static readonly long[] Value=A142227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142227.Bytes);
public long this[int i]=>Value[i];

public static A142227Inst Instance=new A142227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142228
{
public static readonly long[] Value={ 31L,113L,277L,359L,523L,769L,1097L,1753L,1999L,2081L,2819L,3229L,3557L,3803L,3967L,4049L,4787L,4951L,5197L,5279L,5443L,5689L,6263L,6427L,6673L,7001L,7247L,7411L,8231L,8641L,8887L,8969L,9133L,9461L,9871L,10691L,10937L,11593L,11839L,12413L,12577L,12659L,12823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142228Inst : IEnumerable<long>
{
public static readonly long[] Value=A142228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142228.Bytes);
public long this[int i]=>Value[i];

public static A142228Inst Instance=new A142228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142229
{
public static readonly long[] Value={ 73L,401L,647L,811L,1303L,1549L,1877L,2287L,2861L,3271L,3517L,4091L,4337L,4583L,4993L,5813L,6469L,6551L,6961L,7043L,7207L,7699L,8191L,8273L,8929L,9011L,9257L,9421L,9749L,10159L,10487L,10651L,10733L,10979L,11471L,11717L,12373L,12619L,13931L,14177L,14341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142229Inst : IEnumerable<long>
{
public static readonly long[] Value=A142229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142229.Bytes);
public long this[int i]=>Value[i];

public static A142229Inst Instance=new A142229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142230
{
public static readonly long[] Value={ 197L,443L,607L,853L,1181L,1427L,2083L,2411L,2657L,2903L,3067L,3313L,3559L,4051L,4133L,4297L,4789L,4871L,5281L,5527L,6101L,7331L,7577L,7741L,7823L,8069L,8233L,8807L,8971L,9463L,9791L,10037L,10529L,10939L,11677L,11923L,12251L,12497L,12743L,12907L,13399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142230Inst : IEnumerable<long>
{
public static readonly long[] Value=A142230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142230.Bytes);
public long this[int i]=>Value[i];

public static A142230Inst Instance=new A142230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142231
{
public static readonly long[] Value={ 157L,239L,977L,1223L,1879L,2207L,2371L,2617L,2699L,3109L,3191L,3847L,3929L,4093L,4339L,4421L,4831L,5077L,5323L,5569L,5651L,5897L,6143L,6389L,6553L,7127L,7537L,8111L,8521L,8849L,9013L,9341L,9587L,9833L,10079L,10243L,11719L,11801L,12211L,12457L,12539L,12703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142231Inst : IEnumerable<long>
{
public static readonly long[] Value=A142231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142231.Bytes);
public long this[int i]=>Value[i];

public static A142231Inst Instance=new A142231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142264
{
public static readonly long[] Value={ 101L,359L,617L,1907L,1993L,2251L,2423L,2767L,2939L,3541L,4057L,4229L,4831L,5003L,5261L,5347L,5519L,6121L,6379L,6551L,6637L,7411L,7583L,7669L,7841L,7927L,8443L,9733L,10163L,10937L,11969L,12227L,12743L,12829L,13001L,13259L,14033L,14549L,15581L,15667L,16097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142264Inst : IEnumerable<long>
{
public static readonly long[] Value=A142264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142264.Bytes);
public long this[int i]=>Value[i];

public static A142264Inst Instance=new A142264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142265
{
public static readonly long[] Value={ 59L,317L,661L,919L,1091L,1607L,1693L,1951L,2381L,2467L,2897L,3413L,3499L,3671L,3929L,4273L,4703L,4789L,5477L,5563L,5821L,6079L,6337L,7283L,7369L,7541L,8573L,8831L,9433L,9949L,10723L,11239L,11411L,11497L,11927L,12959L,13217L,14249L,14593L,14851L,15797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142265Inst : IEnumerable<long>
{
public static readonly long[] Value=A142265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142265.Bytes);
public long this[int i]=>Value[i];

public static A142265Inst Instance=new A142265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142266
{
public static readonly long[] Value={ 17L,103L,619L,877L,1049L,1307L,1823L,2081L,2339L,2683L,3371L,3457L,4231L,4919L,5521L,5693L,5779L,6037L,6553L,6983L,7069L,7499L,7757L,8101L,8273L,9133L,9391L,9649L,9907L,10079L,10337L,10853L,10939L,11197L,11369L,11971L,12143L,12401L,12487L,12659L,12917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142266Inst : IEnumerable<long>
{
public static readonly long[] Value=A142266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142266.Bytes);
public long this[int i]=>Value[i];

public static A142266Inst Instance=new A142266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142267
{
public static readonly long[] Value={ 61L,233L,491L,577L,1093L,1523L,1609L,1867L,2039L,2297L,2383L,3329L,3673L,3931L,4447L,4877L,5393L,5479L,5651L,5737L,7027L,7457L,8059L,8231L,8317L,8747L,9091L,9349L,9521L,10037L,10639L,11069L,12101L,12703L,13219L,13477L,13649L,13907L,14251L,14423L,14767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142267Inst : IEnumerable<long>
{
public static readonly long[] Value=A142267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142267.Bytes);
public long this[int i]=>Value[i];

public static A142267Inst Instance=new A142267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142268
{
public static readonly long[] Value={ 19L,191L,277L,449L,1051L,1223L,1481L,1567L,1997L,2083L,2341L,2857L,3373L,3631L,3803L,3889L,4663L,5179L,5351L,5437L,5867L,5953L,6211L,6469L,6899L,7243L,7673L,7759L,8017L,8447L,8963L,9049L,9221L,9479L,10253L,10597L,11027L,11113L,11801L,11887L,12919L,13177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142268Inst : IEnumerable<long>
{
public static readonly long[] Value=A142268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142268.Bytes);
public long this[int i]=>Value[i];

public static A142268Inst Instance=new A142268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142269
{
public static readonly long[] Value={ 149L,751L,1009L,1181L,1439L,1697L,1783L,2213L,2557L,2729L,3331L,3761L,3847L,4019L,4363L,4621L,4793L,5051L,5309L,5653L,6427L,6599L,6857L,7459L,7717L,8147L,8233L,8663L,9007L,9437L,9781L,10039L,10211L,11071L,11243L,11329L,11587L,12619L,12791L,13049L,14081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142269Inst : IEnumerable<long>
{
public static readonly long[] Value=A142269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142269.Bytes);
public long this[int i]=>Value[i];

public static A142269Inst Instance=new A142269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142270
{
public static readonly long[] Value={ 107L,193L,709L,881L,967L,1483L,1741L,1913L,1999L,2687L,3203L,3461L,3547L,3719L,4493L,4751L,5009L,5783L,5869L,6299L,7159L,7331L,7417L,7589L,7933L,8191L,8363L,8707L,9137L,9739L,10169L,10427L,10513L,10771L,11287L,11717L,12491L,12577L,13007L,13093L,13523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142270Inst : IEnumerable<long>
{
public static readonly long[] Value=A142270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142270.Bytes);
public long this[int i]=>Value[i];

public static A142270Inst Instance=new A142270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142271
{
public static readonly long[] Value={ 151L,409L,839L,1097L,1613L,1699L,1871L,2129L,2473L,2731L,2903L,3677L,4021L,4451L,4967L,5483L,5569L,5741L,5827L,6257L,6343L,7547L,8837L,8923L,9181L,9439L,9697L,10729L,10987L,11159L,11503L,11933L,12277L,13309L,13567L,13997L,14083L,14341L,14771L,15287L,15373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142271Inst : IEnumerable<long>
{
public static readonly long[] Value=A142271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142271.Bytes);
public long this[int i]=>Value[i];

public static A142271Inst Instance=new A142271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142272
{
public static readonly long[] Value={ 23L,109L,281L,367L,797L,883L,1399L,1571L,1657L,2087L,2689L,2861L,3119L,3463L,4409L,5011L,5441L,5527L,6043L,6301L,6473L,7247L,7333L,7591L,8537L,8623L,9311L,9397L,10343L,10429L,10601L,10687L,10859L,11117L,11633L,11719L,12149L,12923L,13009L,13267L,13697L,14557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142272Inst : IEnumerable<long>
{
public static readonly long[] Value=A142272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142272.Bytes);
public long this[int i]=>Value[i];

public static A142272Inst Instance=new A142272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142273
{
public static readonly long[] Value={ 67L,239L,1013L,1787L,1873L,2131L,2389L,2647L,2819L,3163L,3593L,3851L,4969L,5227L,5399L,5657L,5743L,6173L,6689L,6947L,7549L,8237L,8581L,8753L,8839L,9011L,9613L,9871L,10301L,10559L,10903L,11161L,11677L,12107L,12451L,12967L,13397L,13913L,13999L,15031L,15289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142273Inst : IEnumerable<long>
{
public static readonly long[] Value=A142273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142273.Bytes);
public long this[int i]=>Value[i];

public static A142273Inst Instance=new A142273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142274
{
public static readonly long[] Value={ 197L,283L,541L,971L,1229L,1487L,1831L,2003L,2089L,2347L,2777L,3121L,3637L,4153L,4583L,5099L,5443L,5701L,6131L,6217L,6389L,6733L,6991L,7507L,7937L,8539L,8969L,9227L,9743L,9829L,10259L,10861L,11119L,11549L,11807L,12323L,12409L,13183L,13441L,13613L,14387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142274Inst : IEnumerable<long>
{
public static readonly long[] Value=A142274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142274.Bytes);
public long this[int i]=>Value[i];

public static A142274Inst Instance=new A142274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142275
{
public static readonly long[] Value={ 241L,499L,757L,929L,1187L,1531L,1789L,2477L,3079L,3251L,3767L,3853L,4111L,4283L,4799L,5573L,5659L,6089L,6691L,6863L,6949L,7121L,7207L,7723L,8669L,9013L,9787L,10303L,10733L,11593L,12109L,12281L,12539L,13313L,13399L,13829L,14087L,14173L,14431L,14947L,15377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142275Inst : IEnumerable<long>
{
public static readonly long[] Value=A142275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142275.Bytes);
public long this[int i]=>Value[i];

public static A142275Inst Instance=new A142275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142276
{
public static readonly long[] Value={ 113L,199L,457L,887L,1231L,1489L,1747L,2521L,2693L,3037L,3209L,3467L,4241L,4327L,5101L,5273L,5531L,6047L,6133L,6563L,6907L,7079L,7681L,7853L,8111L,8369L,8627L,8713L,8971L,10433L,10691L,10949L,11551L,11981L,12239L,12497L,12583L,12841L,13099L,13873L,14303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142276Inst : IEnumerable<long>
{
public static readonly long[] Value=A142276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142276.Bytes);
public long this[int i]=>Value[i];

public static A142276Inst Instance=new A142276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142277
{
public static readonly long[] Value={ 71L,157L,587L,673L,1103L,1361L,1447L,1619L,1877L,2221L,2393L,2909L,3167L,3253L,3511L,3769L,4027L,4457L,4801L,4973L,5059L,5231L,6091L,6263L,6521L,6607L,6779L,7639L,8069L,8929L,9187L,10133L,10391L,10477L,10993L,11251L,11423L,11681L,11939L,12197L,12541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142277Inst : IEnumerable<long>
{
public static readonly long[] Value=A142277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142277.Bytes);
public long this[int i]=>Value[i];

public static A142277Inst Instance=new A142277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142278
{
public static readonly long[] Value={ 29L,373L,631L,1061L,1319L,1663L,2179L,2351L,2437L,2609L,2953L,3469L,3727L,4157L,4243L,4673L,4759L,4931L,5189L,5791L,6221L,6737L,6823L,7253L,8543L,8629L,8887L,9059L,9403L,9661L,9833L,10091L,10177L,10607L,11467L,11897L,12241L,12413L,12671L,12757L,13187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142278Inst : IEnumerable<long>
{
public static readonly long[] Value=A142278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142278.Bytes);
public long this[int i]=>Value[i];

public static A142278Inst Instance=new A142278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142279
{
public static readonly long[] Value={ 73L,331L,503L,761L,1019L,1277L,1621L,1879L,2137L,2309L,3083L,3169L,3943L,4201L,4373L,4889L,5147L,5233L,5749L,6007L,6781L,7039L,7211L,7297L,7727L,8243L,8329L,8501L,9103L,9533L,9619L,9791L,10651L,10909L,11597L,11941L,12113L,12457L,12973L,14177L,14779L,14951L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142279Inst : IEnumerable<long>
{
public static readonly long[] Value=A142279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142279.Bytes);
public long this[int i]=>Value[i];

public static A142279Inst Instance=new A142279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142328
{
public static readonly long[] Value={ 31L,211L,571L,661L,751L,1021L,1201L,1291L,1381L,1471L,1741L,1831L,2011L,2281L,2371L,2551L,2731L,3001L,3181L,3271L,3361L,3541L,3631L,4261L,4441L,4621L,4801L,5431L,5521L,5701L,5791L,5881L,6151L,6421L,6691L,6781L,6871L,6961L,7321L,7411L,7591L,7681L,7951L,8221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142328Inst : IEnumerable<long>
{
public static readonly long[] Value=A142328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142328.Bytes);
public long this[int i]=>Value[i];

public static A142328Inst Instance=new A142328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142329
{
public static readonly long[] Value={ 167L,257L,347L,617L,797L,887L,977L,1427L,1607L,1697L,1787L,1877L,2237L,2417L,2687L,2777L,2957L,3137L,3407L,3677L,3767L,3947L,4127L,4217L,4397L,4937L,5297L,5387L,5477L,5657L,5927L,6197L,6287L,6737L,6827L,6917L,7187L,7457L,7547L,7727L,7817L,7907L,8087L,8447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142329Inst : IEnumerable<long>
{
public static readonly long[] Value=A142329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142329.Bytes);
public long this[int i]=>Value[i];

public static A142329Inst Instance=new A142329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142330
{
public static readonly long[] Value={ 79L,349L,439L,619L,709L,1069L,1249L,1429L,1609L,1699L,1789L,1879L,2239L,2689L,3049L,3229L,3319L,3499L,3769L,4129L,4219L,4759L,5119L,5209L,5479L,5569L,5659L,5749L,5839L,6199L,6379L,6469L,6829L,7369L,7459L,7549L,7639L,8089L,8179L,8269L,8539L,8629L,8719L,9349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142330Inst : IEnumerable<long>
{
public static readonly long[] Value=A142330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142330.Bytes);
public long this[int i]=>Value[i];

public static A142330Inst Instance=new A142330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142331
{
public static readonly long[] Value={ 37L,127L,307L,397L,487L,577L,757L,937L,1117L,1297L,1567L,1657L,1747L,2017L,2287L,2377L,2467L,2557L,2647L,2917L,3187L,3457L,3547L,3637L,3727L,3907L,4177L,4357L,4447L,4987L,5077L,5167L,5347L,5437L,5527L,6067L,6247L,6337L,6427L,6607L,6967L,7057L,7237L,7417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142331Inst : IEnumerable<long>
{
public static readonly long[] Value=A142331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142331.Bytes);
public long this[int i]=>Value[i];

public static A142331Inst Instance=new A142331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142332
{
public static readonly long[] Value={ 83L,173L,263L,353L,443L,983L,1163L,1433L,1523L,1613L,1973L,2063L,2153L,2243L,2333L,2423L,2693L,2963L,3323L,3413L,3593L,3863L,4133L,4493L,4583L,4673L,4943L,5303L,5393L,5483L,5573L,5843L,6113L,6203L,6473L,6563L,6653L,6833L,7013L,7103L,7193L,7283L,7643L,7823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142332Inst : IEnumerable<long>
{
public static readonly long[] Value=A142332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142332.Bytes);
public long this[int i]=>Value[i];

public static A142332Inst Instance=new A142332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142333
{
public static readonly long[] Value={ 41L,131L,311L,401L,491L,761L,941L,1031L,1301L,1481L,1571L,1931L,2111L,2381L,2741L,3011L,3191L,3371L,3461L,3821L,3911L,4001L,4091L,4271L,4451L,4721L,5081L,5171L,5261L,5351L,5441L,5531L,5711L,5801L,5981L,6521L,6701L,6791L,6971L,7151L,7331L,7691L,8231L,8501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142333Inst : IEnumerable<long>
{
public static readonly long[] Value=A142333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142333.Bytes);
public long this[int i]=>Value[i];

public static A142333Inst Instance=new A142333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142334
{
public static readonly long[] Value={ 43L,223L,313L,673L,853L,1033L,1123L,1213L,1303L,1483L,1663L,1753L,1933L,2113L,2203L,2293L,2383L,2473L,2833L,3373L,3463L,3643L,3733L,3823L,4003L,4093L,4273L,4363L,4723L,4813L,4903L,4993L,5443L,5623L,6073L,6163L,6343L,6703L,6793L,6883L,7243L,7333L,7603L,7873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142334Inst : IEnumerable<long>
{
public static readonly long[] Value=A142334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142334.Bytes);
public long this[int i]=>Value[i];

public static A142334Inst Instance=new A142334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142335
{
public static readonly long[] Value={ 89L,179L,269L,359L,449L,719L,809L,1259L,1439L,1619L,1709L,1889L,1979L,2069L,2339L,2609L,2699L,2789L,2879L,2969L,3329L,3779L,4049L,4139L,4229L,4409L,4679L,5039L,5309L,5399L,5669L,5849L,5939L,6029L,6299L,6389L,6569L,6659L,7019L,7109L,7559L,7649L,7829L,7919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142335Inst : IEnumerable<long>
{
public static readonly long[] Value=A142335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142335.Bytes);
public long this[int i]=>Value[i];

public static A142335Inst Instance=new A142335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142336
{
public static readonly long[] Value={ -1L,1L,-2L,-1L,8L,-6L,1L,-24L,57L,-24L,-1L,64L,-361L,424L,-120L,1L,-160L,1890L,-4720L,3415L,-720L,-1L,384L,-8828L,41642L,-59543L,30036L,-5040L,1L,-896L,38199L,-317072L,803383L,-757120L,288449L,-40320L,-1L,2048L,-156483L,2177996L,-9156523L,14586084L,-9908113L,3015440L,-362880L,1L,-4608L,615288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142336Inst : IEnumerable<long>
{
public static readonly long[] Value=A142336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142336.Bytes);
public long this[int i]=>Value[i];

public static A142336Inst Instance=new A142336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142337
{
public static readonly long[] Value={ 7L,12L,18L,23L,24L,32L,49L,66L,84L,87L,90L,92L,111L,112L,113L,114L,129L,130L,132L,133L,137L,138L,199L,238L,239L,271L,275L,278L,283L,285L,307L,313L,314L,317L,319L,322L,340L,342L,352L,357L,392L,394L,397L,399L,442L,443L,491L,492L,494L,499L,500L,619L,622L,648L,649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142337Inst : IEnumerable<long>
{
public static readonly long[] Value=A142337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142337.Bytes);
public long this[int i]=>Value[i];

public static A142337Inst Instance=new A142337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142338
{
public static readonly long[] Value={ 1L,6L,12L,15L,16L,20L,24L,27L,33L,39L,42L,45L,45L,50L,52L,54L,55L,63L,63L,66L,70L,70L,70L,78L,81L,84L,86L,102L,105L,108L,110L,115L,117L,117L,118L,121L,121L,132L,133L,138L,141L,146L,148L,150L,156L,158L,165L,168L,168L,171L,180L,180L,182L,198L,203L,205L,205L,210L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142338Inst : IEnumerable<long>
{
public static readonly long[] Value=A142338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142338.Bytes);
public long this[int i]=>Value[i];

public static A142338Inst Instance=new A142338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142339
{
public static readonly long[] Value={ 2L,13L,17L,19L,67L,83L,197L,257L,311L,409L,419L,557L,571L,587L,659L,677L,677L,733L,773L,827L,853L,877L,881L,971L,983L,1087L,1123L,1171L,1171L,1229L,1259L,1279L,1283L,1367L,1423L,1429L,1499L,1543L,1657L,1733L,1741L,1759L,1759L,1777L,1871L,1871L,1877L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142339Inst : IEnumerable<long>
{
public static readonly long[] Value=A142339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142339.Bytes);
public long this[int i]=>Value[i];

public static A142339Inst Instance=new A142339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142340
{
public static readonly long[] Value={ 3L,5L,7L,7L,23L,23L,43L,67L,71L,73L,127L,127L,151L,163L,173L,181L,199L,199L,229L,239L,257L,271L,293L,353L,383L,419L,419L,457L,463L,479L,487L,523L,571L,599L,601L,617L,631L,643L,643L,673L,733L,739L,739L,761L,821L,827L,827L,863L,881L,881L,887L,907L,937L,967L,1033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142340Inst : IEnumerable<long>
{
public static readonly long[] Value=A142340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142340.Bytes);
public long this[int i]=>Value[i];

public static A142340Inst Instance=new A142340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142341
{
public static readonly long[] Value={ 2L,5L,7L,17L,23L,59L,61L,83L,131L,137L,157L,241L,257L,293L,367L,467L,479L,557L,569L,571L,587L,787L,823L,853L,859L,971L,1093L,1217L,1499L,1523L,1553L,1559L,1571L,1579L,1699L,1733L,1789L,1831L,1847L,1907L,1999L,2011L,2081L,2113L,2129L,2239L,2293L,2393L,2423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142341Inst : IEnumerable<long>
{
public static readonly long[] Value=A142341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142341.Bytes);
public long this[int i]=>Value[i];

public static A142341Inst Instance=new A142341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142342
{
public static readonly long[] Value={ 20L,30L,50L,70L,110L,130L,170L,190L,230L,290L,310L,370L,410L,430L,470L,530L,590L,610L,670L,710L,730L,790L,830L,890L,970L,1010L,1030L,1070L,1090L,1130L,1270L,1310L,1370L,1390L,1490L,1510L,1570L,1630L,1670L,1730L,1790L,1810L,1910L,1930L,1970L,1990L,2110L,2230L,2270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142342Inst : IEnumerable<long>
{
public static readonly long[] Value=A142342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142342.Bytes);
public long this[int i]=>Value[i];

public static A142342Inst Instance=new A142342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142343
{
public static readonly long[] Value={ 11L,31L,43L,47L,73L,103L,109L,113L,127L,211L,239L,269L,353L,443L,509L,631L,733L,743L,823L,839L,881L,887L,1051L,1213L,1277L,1283L,1303L,1307L,1321L,1571L,1583L,1597L,1709L,1747L,1783L,1801L,1997L,2003L,2017L,2087L,2111L,2239L,2267L,2441L,2503L,2591L,2609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142343Inst : IEnumerable<long>
{
public static readonly long[] Value=A142343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142343.Bytes);
public long this[int i]=>Value[i];

public static A142343Inst Instance=new A142343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142392
{
public static readonly long[] Value={ 41L,229L,887L,1451L,1733L,2203L,2297L,2579L,2767L,2861L,3049L,3331L,3613L,3989L,4177L,4271L,5023L,5399L,5869L,6151L,6997L,7561L,7937L,8219L,8501L,8689L,8783L,8971L,9629L,9817L,10099L,10193L,10663L,11321L,12073L,12637L,12919L,13577L,13859L,14423L,15269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142392Inst : IEnumerable<long>
{
public static readonly long[] Value=A142392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142392.Bytes);
public long this[int i]=>Value[i];

public static A142392Inst Instance=new A142392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142393
{
public static readonly long[] Value={ 89L,277L,653L,1123L,1217L,1499L,2063L,2251L,2909L,3191L,3943L,4507L,4789L,6011L,6199L,6481L,6763L,6857L,7703L,8737L,8831L,9677L,10429L,10711L,10993L,11087L,11369L,11839L,11933L,12497L,12967L,13249L,13907L,14753L,15787L,15881L,16069L,16633L,17291L,17573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142393Inst : IEnumerable<long>
{
public static readonly long[] Value=A142393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142393.Bytes);
public long this[int i]=>Value[i];

public static A142393Inst Instance=new A142393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142394
{
public static readonly long[] Value={ 43L,137L,419L,607L,701L,983L,1171L,1453L,2017L,2111L,2393L,2957L,3709L,3803L,4273L,4649L,4931L,5119L,5683L,6247L,6529L,7187L,8221L,8597L,9067L,9161L,9349L,9631L,10007L,10289L,10477L,10853L,11699L,11887L,11981L,12263L,12451L,13109L,13297L,14143L,14519L,15083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142394Inst : IEnumerable<long>
{
public static readonly long[] Value=A142394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142394.Bytes);
public long this[int i]=>Value[i];

public static A142394Inst Instance=new A142394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142395
{
public static readonly long[] Value={ 373L,467L,937L,1031L,1783L,1877L,2347L,2441L,3851L,4133L,4603L,5167L,5261L,5449L,6389L,6577L,7517L,8081L,8269L,8363L,9209L,9397L,9491L,9679L,10243L,10337L,12781L,13063L,13627L,13721L,15131L,15319L,15413L,15601L,16447L,16729L,16823L,17011L,17293L,17387L,17669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142395Inst : IEnumerable<long>
{
public static readonly long[] Value=A142395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142395.Bytes);
public long this[int i]=>Value[i];

public static A142395Inst Instance=new A142395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142396
{
public static readonly long[] Value={ 139L,233L,421L,797L,1361L,1549L,1831L,2113L,2207L,2677L,3617L,4463L,4651L,4933L,5309L,5591L,5779L,6343L,6719L,6907L,7001L,7283L,7753L,8317L,8599L,8693L,9257L,9539L,10009L,10103L,10667L,10949L,11701L,12547L,12641L,12829L,12923L,13487L,14051L,14897L,15461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142396Inst : IEnumerable<long>
{
public static readonly long[] Value=A142396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142396.Bytes);
public long this[int i]=>Value[i];

public static A142396Inst Instance=new A142396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142397
{
public static readonly long[] Value={ 281L,563L,751L,1033L,1409L,1597L,1879L,1973L,2161L,2819L,3571L,3853L,3947L,4229L,4793L,5639L,5827L,6203L,6673L,7237L,7331L,8647L,8741L,8929L,9587L,10151L,10433L,10903L,11279L,11467L,12689L,13159L,13441L,13723L,14851L,15227L,15791L,16073L,17107L,17389L,17483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142397Inst : IEnumerable<long>
{
public static readonly long[] Value=A142397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142397.Bytes);
public long this[int i]=>Value[i];

public static A142397Inst Instance=new A142397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142398
{
public static readonly long[] Value={ 97L,193L,241L,337L,433L,577L,673L,769L,1009L,1153L,1201L,1249L,1297L,1489L,1777L,1873L,2017L,2113L,2161L,2593L,2689L,2833L,3121L,3169L,3217L,3313L,3361L,3457L,3697L,3793L,3889L,4129L,4177L,4273L,4513L,4561L,4657L,4801L,4993L,5233L,5281L,5521L,5569L,5857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142398Inst : IEnumerable<long>
{
public static readonly long[] Value=A142398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142398.Bytes);
public long this[int i]=>Value[i];

public static A142398Inst Instance=new A142398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142399
{
public static readonly long[] Value={ 5L,53L,101L,149L,197L,293L,389L,677L,773L,821L,1013L,1061L,1109L,1301L,1493L,1637L,1733L,1877L,1973L,2069L,2213L,2309L,2357L,2549L,2693L,2741L,2789L,2837L,3221L,3413L,3461L,3557L,3701L,3797L,3989L,4133L,4229L,4373L,4421L,4517L,5189L,5237L,5333L,5381L,5477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142399Inst : IEnumerable<long>
{
public static readonly long[] Value=A142399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142399.Bytes);
public long this[int i]=>Value[i];

public static A142399Inst Instance=new A142399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142400
{
public static readonly long[] Value={ 7L,103L,151L,199L,439L,487L,631L,727L,823L,919L,967L,1063L,1303L,1399L,1447L,1543L,1783L,1831L,1879L,2311L,2503L,2551L,2647L,2791L,2887L,3079L,3271L,3319L,3463L,3511L,3559L,3607L,3847L,3943L,4231L,4327L,4423L,4519L,4567L,4663L,4759L,4903L,4951L,4999L,5431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142400Inst : IEnumerable<long>
{
public static readonly long[] Value=A142400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142400.Bytes);
public long this[int i]=>Value[i];

public static A142400Inst Instance=new A142400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142401
{
public static readonly long[] Value={ 11L,59L,107L,251L,347L,443L,491L,587L,683L,827L,971L,1019L,1163L,1259L,1307L,1451L,1499L,1787L,1931L,1979L,2027L,2267L,2411L,2459L,2699L,2843L,2939L,3083L,3323L,3371L,3467L,3659L,3803L,3851L,3947L,4091L,4139L,4283L,4523L,5003L,5051L,5099L,5147L,5387L,5483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142401Inst : IEnumerable<long>
{
public static readonly long[] Value=A142401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142401.Bytes);
public long this[int i]=>Value[i];

public static A142401Inst Instance=new A142401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142402
{
public static readonly long[] Value={ 13L,61L,109L,157L,349L,397L,541L,733L,829L,877L,1021L,1069L,1117L,1213L,1453L,1549L,1597L,1693L,1741L,1789L,1933L,2029L,2221L,2269L,2557L,2749L,2797L,3037L,3181L,3229L,3373L,3469L,3517L,3613L,3709L,3853L,4093L,4621L,4813L,4861L,4909L,4957L,5101L,5197L,5437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142402Inst : IEnumerable<long>
{
public static readonly long[] Value=A142402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142402.Bytes);
public long this[int i]=>Value[i];

public static A142402Inst Instance=new A142402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142403
{
public static readonly long[] Value={ 17L,113L,257L,353L,401L,449L,593L,641L,881L,929L,977L,1217L,1361L,1409L,1553L,1601L,1697L,1889L,2081L,2129L,2273L,2417L,2609L,2657L,2753L,2801L,2897L,3041L,3089L,3137L,3329L,3617L,3761L,4001L,4049L,4241L,4289L,4337L,4481L,4673L,4721L,4817L,5009L,5153L,5297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142403Inst : IEnumerable<long>
{
public static readonly long[] Value=A142403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142403.Bytes);
public long this[int i]=>Value[i];

public static A142403Inst Instance=new A142403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142404
{
public static readonly long[] Value={ 19L,67L,163L,211L,307L,499L,547L,643L,691L,739L,787L,883L,1123L,1171L,1459L,1699L,1747L,1987L,2083L,2131L,2179L,2371L,2467L,2659L,2707L,2803L,2851L,3187L,3331L,3571L,3907L,4003L,4051L,4099L,4243L,4339L,4483L,4723L,5011L,5059L,5107L,5347L,5443L,5683L,5779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142404Inst : IEnumerable<long>
{
public static readonly long[] Value=A142404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142404.Bytes);
public long this[int i]=>Value[i];

public static A142404Inst Instance=new A142404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142405
{
public static readonly long[] Value={ 23L,71L,167L,263L,311L,359L,503L,599L,647L,743L,839L,887L,983L,1031L,1223L,1319L,1367L,1511L,1559L,1607L,1847L,2039L,2087L,2423L,2663L,2711L,2903L,2999L,3191L,3527L,3623L,3671L,3719L,3767L,3863L,3911L,4007L,4391L,4583L,4679L,4871L,4919L,4967L,5303L,5351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142405Inst : IEnumerable<long>
{
public static readonly long[] Value=A142405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142405.Bytes);
public long this[int i]=>Value[i];

public static A142405Inst Instance=new A142405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142406
{
public static readonly long[] Value={ 73L,313L,409L,457L,601L,937L,1033L,1129L,1321L,1609L,1657L,1753L,1801L,1993L,2089L,2137L,2281L,2377L,2473L,2521L,2617L,2713L,2857L,2953L,3001L,3049L,3433L,3529L,3673L,3769L,4057L,4153L,4201L,4297L,4441L,4729L,4969L,5113L,5209L,5449L,5641L,5689L,5737L,5881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142406Inst : IEnumerable<long>
{
public static readonly long[] Value=A142406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142406.Bytes);
public long this[int i]=>Value[i];

public static A142406Inst Instance=new A142406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142407
{
public static readonly long[] Value={ 29L,173L,269L,317L,461L,509L,557L,653L,701L,797L,941L,1181L,1229L,1277L,1373L,1613L,1709L,1901L,1949L,1997L,2141L,2237L,2333L,2381L,2477L,2621L,2861L,2909L,2957L,3389L,3533L,3581L,3677L,3821L,3917L,4013L,4157L,4253L,4349L,4397L,4493L,4637L,4733L,4877L,4973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142407Inst : IEnumerable<long>
{
public static readonly long[] Value=A142407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142407.Bytes);
public long this[int i]=>Value[i];

public static A142407Inst Instance=new A142407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142504
{
public static readonly long[] Value={ 97L,199L,607L,709L,811L,1117L,1321L,1423L,1627L,1831L,1933L,2137L,2239L,2341L,2647L,2749L,2851L,2953L,3259L,3361L,3463L,3769L,4177L,4483L,4789L,4993L,5197L,5503L,6217L,6421L,6829L,7237L,7951L,8053L,8461L,8563L,8971L,9277L,9787L,10093L,10399L,10501L,10909L,11113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142504Inst : IEnumerable<long>
{
public static readonly long[] Value=A142504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142504.Bytes);
public long this[int i]=>Value[i];

public static A142504Inst Instance=new A142504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142505
{
public static readonly long[] Value={ 47L,149L,251L,353L,557L,659L,761L,863L,1373L,2087L,2393L,2699L,2801L,2903L,3209L,3413L,3617L,3719L,3821L,3923L,4127L,4229L,4637L,4943L,5147L,5351L,5657L,5861L,6269L,6473L,6779L,6983L,7187L,7901L,8513L,8819L,9227L,9431L,9533L,9839L,9941L,10247L,10859L,11369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142505Inst : IEnumerable<long>
{
public static readonly long[] Value=A142505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142505.Bytes);
public long this[int i]=>Value[i];

public static A142505Inst Instance=new A142505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142506
{
public static readonly long[] Value={ 151L,457L,661L,967L,1069L,1171L,1579L,1783L,1987L,2089L,2293L,2803L,3109L,3313L,3517L,3823L,4027L,4129L,4231L,4639L,5557L,5659L,6067L,6271L,6373L,6577L,6679L,6781L,6883L,7393L,7699L,8209L,8311L,8719L,8821L,8923L,9127L,9433L,9739L,10453L,10657L,10861L,11677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142506Inst : IEnumerable<long>
{
public static readonly long[] Value=A142506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142506.Bytes);
public long this[int i]=>Value[i];

public static A142506Inst Instance=new A142506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142507
{
public static readonly long[] Value={ 101L,509L,1019L,1223L,1427L,1733L,2039L,2141L,2243L,2447L,2549L,2753L,2957L,3467L,3671L,4079L,4283L,4691L,4793L,5099L,5303L,5507L,5711L,5813L,6221L,6323L,6833L,7547L,7649L,7853L,8363L,8669L,9281L,9587L,9689L,9791L,10301L,10607L,10709L,11117L,11321L,11423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142507Inst : IEnumerable<long>
{
public static readonly long[] Value=A142507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142507.Bytes);
public long this[int i]=>Value[i];

public static A142507Inst Instance=new A142507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142508
{
public static readonly long[] Value={ 53L,157L,313L,521L,677L,937L,1093L,1249L,1301L,1613L,1873L,2029L,2081L,2237L,2341L,2393L,2549L,2861L,3121L,3329L,3433L,3797L,4057L,4421L,4733L,4889L,4993L,5669L,5981L,6397L,6449L,6553L,6709L,6761L,6917L,7177L,7229L,7333L,7489L,7541L,7853L,8009L,8269L,8581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142508Inst : IEnumerable<long>
{
public static readonly long[] Value=A142508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142508.Bytes);
public long this[int i]=>Value[i];

public static A142508Inst Instance=new A142508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142509
{
public static readonly long[] Value={ 3L,107L,211L,263L,367L,419L,523L,887L,991L,1303L,1459L,1511L,1667L,1823L,1979L,2083L,2239L,2447L,2551L,2707L,3019L,3331L,3539L,3643L,3851L,4007L,4111L,4423L,4787L,4943L,5099L,5827L,5879L,6451L,6607L,6659L,6763L,6971L,7127L,7283L,7699L,7907L,8011L,8167L,8219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142509Inst : IEnumerable<long>
{
public static readonly long[] Value=A142509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142509.Bytes);
public long this[int i]=>Value[i];

public static A142509Inst Instance=new A142509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142510
{
public static readonly long[] Value={ 5L,109L,317L,421L,577L,733L,941L,1097L,1201L,1409L,1669L,1721L,1877L,2137L,2293L,2657L,2917L,2969L,3229L,3541L,3593L,3697L,3853L,4217L,4373L,4789L,5101L,5153L,5309L,5413L,5569L,5881L,6037L,6089L,6661L,6869L,7129L,7649L,7753L,8117L,8221L,8273L,8377L,8429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142510Inst : IEnumerable<long>
{
public static readonly long[] Value=A142510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142510.Bytes);
public long this[int i]=>Value[i];

public static A142510Inst Instance=new A142510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142511
{
public static readonly long[] Value={ 7L,59L,163L,631L,683L,787L,839L,1151L,1307L,1567L,1619L,1723L,1879L,1931L,2087L,2243L,2347L,2399L,2503L,2659L,2711L,2971L,3023L,3491L,3803L,3907L,4219L,4271L,4583L,4999L,5051L,5519L,5623L,5779L,5987L,6091L,6143L,6247L,6299L,6871L,7027L,7079L,7547L,7703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142511Inst : IEnumerable<long>
{
public static readonly long[] Value=A142511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142511.Bytes);
public long this[int i]=>Value[i];

public static A142511Inst Instance=new A142511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142512
{
public static readonly long[] Value={ 61L,113L,269L,373L,997L,1049L,1153L,1361L,1621L,1777L,1933L,2089L,2141L,2297L,2557L,2609L,2713L,3181L,3389L,3701L,4013L,4273L,4481L,4637L,4793L,5209L,5261L,5417L,5521L,5573L,6197L,6301L,6353L,6977L,7237L,7393L,7549L,7757L,8017L,8069L,8329L,8537L,8641L,8693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142512Inst : IEnumerable<long>
{
public static readonly long[] Value=A142512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142512.Bytes);
public long this[int i]=>Value[i];

public static A142512Inst Instance=new A142512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142513
{
public static readonly long[] Value={ 11L,167L,271L,479L,739L,947L,1051L,1103L,1259L,1571L,1831L,1987L,2039L,2143L,2351L,2663L,2767L,2819L,3079L,3391L,3547L,3911L,4327L,4483L,4639L,4691L,4951L,5003L,5107L,5419L,5471L,5783L,5939L,6043L,6199L,6563L,6719L,6823L,7187L,7499L,7603L,7759L,8123L,8539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142513Inst : IEnumerable<long>
{
public static readonly long[] Value=A142513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142513.Bytes);
public long this[int i]=>Value[i];

public static A142513Inst Instance=new A142513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142514
{
public static readonly long[] Value={ 67L,223L,379L,431L,587L,691L,743L,1367L,1471L,1523L,1627L,1783L,2251L,2459L,2719L,2927L,3083L,3187L,3343L,3499L,3863L,3967L,4019L,4591L,4643L,4799L,4903L,5059L,5527L,5683L,5839L,6047L,6151L,6203L,6359L,6619L,6827L,6983L,7243L,7451L,7607L,7867L,7919L,8179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142514Inst : IEnumerable<long>
{
public static readonly long[] Value=A142514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142514.Bytes);
public long this[int i]=>Value[i];

public static A142514Inst Instance=new A142514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142515
{
public static readonly long[] Value={ 17L,173L,277L,433L,641L,797L,953L,1109L,1213L,1733L,1889L,1993L,2357L,2617L,3137L,3449L,3709L,3761L,3917L,4021L,4073L,4177L,4229L,4801L,4957L,5009L,5113L,5477L,5581L,5737L,6101L,6257L,6361L,6569L,6673L,6829L,7193L,7297L,7349L,7817L,8233L,8389L,8597L,8753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142515Inst : IEnumerable<long>
{
public static readonly long[] Value=A142515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142515.Bytes);
public long this[int i]=>Value[i];

public static A142515Inst Instance=new A142515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142516
{
public static readonly long[] Value={ 19L,71L,227L,331L,383L,487L,643L,1163L,1319L,1423L,1579L,1787L,2099L,2203L,2411L,2671L,2879L,3191L,3347L,3607L,3659L,3919L,4127L,4231L,4283L,4751L,5011L,5167L,5323L,5479L,5531L,5791L,5843L,6311L,6571L,6779L,6883L,7039L,7247L,7351L,7507L,7559L,8287L,8443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142516Inst : IEnumerable<long>
{
public static readonly long[] Value=A142516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142516.Bytes);
public long this[int i]=>Value[i];

public static A142516Inst Instance=new A142516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142517
{
public static readonly long[] Value={ 73L,229L,281L,541L,593L,853L,1009L,1061L,1217L,1321L,1373L,1789L,1997L,2153L,2309L,2621L,2777L,3037L,3089L,3557L,4129L,4337L,4441L,4493L,4597L,4649L,4909L,5273L,5689L,5741L,5897L,6053L,6469L,6521L,6781L,6833L,7457L,7561L,7717L,7873L,8081L,8237L,8861L,9173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142517Inst : IEnumerable<long>
{
public static readonly long[] Value=A142517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142517.Bytes);
public long this[int i]=>Value[i];

public static A142517Inst Instance=new A142517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142518
{
public static readonly long[] Value={ 23L,127L,179L,283L,439L,491L,647L,751L,907L,1063L,1427L,1531L,1583L,1999L,2207L,2311L,2467L,3299L,3559L,3767L,3923L,4027L,4079L,4339L,4391L,4547L,4651L,4703L,5119L,5171L,5431L,5483L,5639L,5743L,6211L,6263L,6367L,6679L,6991L,7043L,7459L,7823L,7927L,8291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142518Inst : IEnumerable<long>
{
public static readonly long[] Value=A142518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142518.Bytes);
public long this[int i]=>Value[i];

public static A142518Inst Instance=new A142518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142519
{
public static readonly long[] Value={ 181L,233L,337L,389L,701L,857L,1013L,1117L,1429L,1481L,1637L,1741L,1949L,2053L,2417L,2521L,2677L,2729L,2833L,3041L,3301L,3457L,3613L,3769L,3821L,4133L,4289L,4549L,4861L,5381L,5641L,5693L,5849L,5953L,6317L,6421L,6473L,6577L,6733L,7253L,7669L,7877L,8293L,8501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142519Inst : IEnumerable<long>
{
public static readonly long[] Value=A142519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142519.Bytes);
public long this[int i]=>Value[i];

public static A142519Inst Instance=new A142519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142648
{
public static readonly long[] Value={ 17L,73L,241L,353L,409L,521L,577L,857L,1193L,1249L,1361L,1697L,1753L,2089L,2593L,3041L,3209L,3433L,3769L,3881L,4049L,4217L,4273L,4441L,4721L,4889L,5113L,5281L,5393L,5449L,5897L,5953L,6121L,6569L,6737L,6793L,6961L,7129L,7297L,7577L,8081L,8641L,8753L,9257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142648Inst : IEnumerable<long>
{
public static readonly long[] Value=A142648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142648.Bytes);
public long this[int i]=>Value[i];

public static A142648Inst Instance=new A142648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142649
{
public static readonly long[] Value={ 19L,131L,467L,523L,691L,859L,971L,1307L,1531L,1699L,1811L,1867L,1979L,2203L,2371L,2539L,2707L,2819L,3323L,3491L,3547L,3659L,4051L,4219L,4723L,5003L,5059L,5171L,5227L,5507L,5563L,5843L,6011L,6067L,6571L,6907L,7019L,7187L,7243L,7411L,7523L,7691L,8363L,8419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142649Inst : IEnumerable<long>
{
public static readonly long[] Value=A142649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142649.Bytes);
public long this[int i]=>Value[i];

public static A142649Inst Instance=new A142649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142650
{
public static readonly long[] Value={ 23L,79L,191L,359L,751L,863L,919L,1031L,1087L,1367L,1423L,1759L,1871L,2039L,2207L,2543L,2711L,2767L,2879L,3271L,3607L,3719L,3943L,4111L,4391L,4447L,4783L,4951L,5119L,5231L,5399L,5623L,5791L,5903L,6911L,6967L,7079L,7247L,7583L,7639L,7919L,8087L,8311L,8423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142650Inst : IEnumerable<long>
{
public static readonly long[] Value=A142650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142650.Bytes);
public long this[int i]=>Value[i];

public static A142650Inst Instance=new A142650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142651
{
public static readonly long[] Value={ 137L,193L,641L,809L,977L,1033L,1201L,1481L,1873L,2153L,2377L,2657L,2713L,3049L,3217L,3329L,3833L,3889L,4001L,4057L,4337L,4561L,4673L,4729L,5009L,5233L,5569L,5737L,5849L,6073L,6353L,6521L,6577L,6689L,6857L,7193L,7417L,7529L,7753L,8089L,8369L,8537L,8761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142651Inst : IEnumerable<long>
{
public static readonly long[] Value=A142651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142651.Bytes);
public long this[int i]=>Value[i];

public static A142651Inst Instance=new A142651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142652
{
public static readonly long[] Value={ 83L,139L,251L,307L,419L,587L,643L,811L,1091L,1259L,1427L,1483L,1931L,1987L,2099L,2267L,2659L,2939L,3163L,3331L,3499L,3779L,3947L,4003L,4283L,4339L,4451L,4507L,4787L,5011L,5179L,5347L,5683L,5851L,6131L,6299L,6691L,6803L,6971L,7027L,7307L,7643L,7699L,7867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142652Inst : IEnumerable<long>
{
public static readonly long[] Value=A142652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142652.Bytes);
public long this[int i]=>Value[i];

public static A142652Inst Instance=new A142652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142653
{
public static readonly long[] Value={ 29L,197L,421L,701L,757L,1093L,1373L,1429L,1597L,1709L,1877L,1933L,2213L,2269L,2381L,2437L,2549L,3109L,3221L,3389L,3557L,3613L,4229L,4397L,4621L,4733L,4789L,4957L,5237L,5573L,5741L,6133L,6301L,6469L,6581L,6637L,6917L,7253L,7309L,7477L,7589L,7757L,8093L,8317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142653Inst : IEnumerable<long>
{
public static readonly long[] Value=A142653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142653.Bytes);
public long this[int i]=>Value[i];

public static A142653Inst Instance=new A142653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142654
{
public static readonly long[] Value={ 31L,199L,311L,367L,479L,647L,983L,1039L,1151L,1319L,1487L,1543L,1823L,1879L,2383L,2551L,2663L,2719L,2887L,2999L,3167L,3391L,3559L,3671L,3727L,4007L,4231L,4567L,4679L,4903L,5351L,5407L,5519L,5743L,6079L,6247L,6359L,6863L,7591L,7703L,7759L,7927L,8039L,8263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142654Inst : IEnumerable<long>
{
public static readonly long[] Value=A142654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142654.Bytes);
public long this[int i]=>Value[i];

public static A142654Inst Instance=new A142654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142655
{
public static readonly long[] Value={ 89L,257L,313L,593L,761L,929L,1097L,1153L,1321L,1433L,1489L,1601L,1657L,1993L,2161L,2273L,2441L,2609L,2777L,2833L,3001L,3169L,3449L,3617L,3673L,4177L,4289L,4457L,4513L,4793L,5297L,5521L,5689L,5801L,5857L,6361L,6473L,6529L,6977L,7369L,7481L,7537L,7649L,7817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142655Inst : IEnumerable<long>
{
public static readonly long[] Value=A142655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142655.Bytes);
public long this[int i]=>Value[i];

public static A142655Inst Instance=new A142655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142656
{
public static readonly long[] Value={ 37L,149L,317L,373L,541L,653L,709L,821L,877L,1213L,1381L,1493L,1549L,1997L,2053L,2221L,2333L,2389L,2557L,2837L,3061L,3229L,3677L,3733L,4013L,4349L,4517L,4909L,5021L,5077L,5189L,5413L,5581L,5693L,5749L,5861L,6029L,6197L,6421L,6701L,6869L,7541L,7877L,7933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142656Inst : IEnumerable<long>
{
public static readonly long[] Value=A142656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142656.Bytes);
public long this[int i]=>Value[i];

public static A142656Inst Instance=new A142656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142657
{
public static readonly long[] Value={ 151L,263L,431L,487L,599L,823L,991L,1103L,1327L,1439L,1607L,1663L,1831L,1999L,2111L,2447L,2503L,2671L,3119L,3343L,3511L,3623L,3847L,4127L,4463L,4519L,4799L,4967L,5023L,5303L,5471L,5527L,5639L,5807L,6143L,6199L,6311L,6367L,6703L,6871L,6983L,7039L,7151L,7207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142657Inst : IEnumerable<long>
{
public static readonly long[] Value=A142657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142657.Bytes);
public long this[int i]=>Value[i];

public static A142657Inst Instance=new A142657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142658
{
public static readonly long[] Value={ 41L,97L,433L,601L,769L,881L,937L,1049L,1217L,1553L,1609L,1721L,1777L,1889L,2113L,2281L,2393L,2617L,2729L,2897L,2953L,3121L,3457L,3793L,4073L,4129L,4241L,4297L,4409L,4801L,4969L,5081L,5417L,5641L,6089L,6257L,6481L,6761L,7321L,7433L,7489L,7937L,7993L,8161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142658Inst : IEnumerable<long>
{
public static readonly long[] Value=A142658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142658.Bytes);
public long this[int i]=>Value[i];

public static A142658Inst Instance=new A142658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142659
{
public static readonly long[] Value={ 43L,211L,379L,491L,547L,659L,827L,883L,1051L,1163L,1499L,1667L,1723L,2003L,2339L,2731L,2843L,3011L,3067L,3347L,3571L,3739L,3851L,3907L,4019L,4243L,4523L,4691L,5419L,5531L,5867L,5923L,6091L,6203L,6427L,6763L,7043L,7211L,7547L,7603L,7883L,8219L,8387L,8443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142659Inst : IEnumerable<long>
{
public static readonly long[] Value=A142659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142659.Bytes);
public long this[int i]=>Value[i];

public static A142659Inst Instance=new A142659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142660
{
public static readonly long[] Value={ 101L,157L,269L,661L,773L,829L,941L,997L,1109L,1277L,1613L,1669L,1949L,2341L,2621L,2677L,2789L,2957L,3181L,3461L,3517L,3797L,3853L,4021L,4133L,4357L,4637L,4861L,4973L,5197L,5309L,5477L,5701L,5813L,5869L,5981L,6037L,6317L,6373L,6653L,6709L,7213L,7549L,7717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142660Inst : IEnumerable<long>
{
public static readonly long[] Value=A142660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142660.Bytes);
public long this[int i]=>Value[i];

public static A142660Inst Instance=new A142660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142661
{
public static readonly long[] Value={ 47L,103L,271L,383L,439L,607L,719L,887L,1223L,1279L,1447L,1559L,1783L,1951L,2063L,2287L,2399L,2791L,2903L,3407L,3463L,3631L,3911L,3967L,4079L,4583L,4639L,4751L,4919L,5087L,5479L,5591L,5647L,5927L,6151L,6263L,6599L,6823L,6991L,7103L,7159L,7607L,8111L,8167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142661Inst : IEnumerable<long>
{
public static readonly long[] Value=A142661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142661.Bytes);
public long this[int i]=>Value[i];

public static A142661Inst Instance=new A142661Inst();

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