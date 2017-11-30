using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A029868
{
public static readonly long[] Value={ 1L,1L,4L,14L,46L,145L,440L,1315L,3877L,11315L,32792L,94529L,271510L,777764L,2223865L,6350657L,18120730L,51680249L,147359335L,420163711L,1198151432L,3417475326L,9750708533L,27831153091L,79471338455L,227032777454L,648896436944L,1855571389651L,5308837191604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029868Inst : IEnumerable<long>
{
public static readonly long[] Value=A029868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029868.Bytes);
public long this[int i]=>Value[i];

public static A029868Inst Instance=new A029868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029965
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,191L,282L,373L,464L,555L,646L,656L,6886L,25752L,27472L,42324L,50605L,626626L,1540451L,1713171L,1721271L,1828281L,1877781L,1885881L,2401042L,2434342L,2442442L,2450542L,3106013L,3114113L,3122213L,3163613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029965Inst : IEnumerable<long>
{
public static readonly long[] Value=A029965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029965.Bytes);
public long this[int i]=>Value[i];

public static A029965Inst Instance=new A029965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029966
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,232L,343L,454L,565L,676L,787L,898L,909L,26962L,38183L,40504L,49294L,52825L,63936L,75157L,2956592L,2968692L,3262623L,3274723L,3286823L,3298923L,3360633L,3372733L,4348434L,4410144L,4422244L,4581854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029966Inst : IEnumerable<long>
{
public static readonly long[] Value=A029966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029966.Bytes);
public long this[int i]=>Value[i];

public static A029966Inst Instance=new A029966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029967
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,181L,555L,616L,676L,737L,797L,1111L,8008L,35953L,43934L,88888L,646646L,3192913L,5641465L,8364638L,9963699L,133373331L,139979931L,293373392L,520020025L,713171317L,796212697L,1393223931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029967Inst : IEnumerable<long>
{
public static readonly long[] Value=A029967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029967.Bytes);
public long this[int i]=>Value[i];

public static A029967Inst Instance=new A029967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029968
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,222L,313L,353L,444L,575L,666L,797L,1111L,6776L,8778L,24542L,25452L,26362L,56265L,311113L,2377732L,2713172L,2832382L,2906092L,8864688L,10122101L,13055031L,20244202L,20944902L,23177132L,23877832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029968Inst : IEnumerable<long>
{
public static readonly long[] Value=A029968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029968.Bytes);
public long this[int i]=>Value[i];

public static A029968Inst Instance=new A029968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029969
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,323L,464L,717L,858L,999L,1111L,39593L,59095L,420024L,546645L,9046409L,9578759L,9813189L,535505535L,564303465L,595121595L,5736116375L,6758008576L,10476867401L,11652825611L,14203330241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029969Inst : IEnumerable<long>
{
public static readonly long[] Value=A029969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029969.Bytes);
public long this[int i]=>Value[i];

public static A029969Inst Instance=new A029969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029970
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,828L,858L,888L,919L,949L,979L,1551L,2772L,23632L,25552L,60106L,67576L,465564L,477774L,489984L,515515L,527725L,17577571L,26144162L,28300382L,39399393L,47999974L,69455496L,2118008112L,8050880508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029970Inst : IEnumerable<long>
{
public static readonly long[] Value=A029970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029970.Bytes);
public long this[int i]=>Value[i];

public static A029970Inst Instance=new A029970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029971
{
public static readonly long[] Value={ 2L,13L,23L,151L,173L,233L,757L,937L,1093L,1249L,1429L,1487L,1667L,1733L,1823L,1913L,1979L,2069L,8389L,9103L,10111L,12301L,14951L,16673L,16871L,18593L,60103L,60913L,61507L,63127L,69697L,73243L,78979L,80599L,82003L,82813L,83407L,85027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029971Inst : IEnumerable<long>
{
public static readonly long[] Value=A029971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029971.Bytes);
public long this[int i]=>Value[i];

public static A029971Inst Instance=new A029971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029972
{
public static readonly long[] Value={ 2L,3L,5L,17L,29L,59L,257L,373L,409L,461L,509L,787L,839L,887L,907L,991L,4289L,4561L,5189L,5669L,5861L,6133L,6217L,6553L,6761L,7309L,7517L,7789L,7853L,12899L,13171L,13591L,14327L,14347L,14411L,14683L,14747L,14891L,15083L,15227L,15439L,15647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029972Inst : IEnumerable<long>
{
public static readonly long[] Value=A029972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029972.Bytes);
public long this[int i]=>Value[i];

public static A029972Inst Instance=new A029972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029973
{
public static readonly long[] Value={ 2L,3L,31L,41L,67L,83L,109L,701L,911L,1091L,1171L,1277L,1327L,1667L,1847L,2083L,2213L,2293L,2423L,2473L,2579L,2659L,2789L,2969L,3049L,16001L,16651L,19531L,20431L,21481L,23311L,23561L,24611L,25391L,26041L,27091L,28921L,30871L,31121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029973Inst : IEnumerable<long>
{
public static readonly long[] Value=A029973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029973.Bytes);
public long this[int i]=>Value[i];

public static A029973Inst Instance=new A029973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029974
{
public static readonly long[] Value={ 2L,3L,5L,7L,37L,43L,61L,67L,191L,197L,1297L,1627L,1663L,1699L,1741L,1777L,1999L,2143L,2221L,2293L,2551L,6521L,6779L,7001L,7109L,7151L,7187L,7331L,7481L,7517L,7703L,47521L,47737L,49069L,49537L,51517L,52201L,54181L,55987L,57751L,59083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029974Inst : IEnumerable<long>
{
public static readonly long[] Value=A029974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029974.Bytes);
public long this[int i]=>Value[i];

public static A029974Inst Instance=new A029974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029975
{
public static readonly long[] Value={ 2L,3L,5L,71L,107L,157L,257L,271L,307L,2549L,2647L,2801L,3347L,3697L,3851L,4201L,4397L,4649L,4951L,5399L,5651L,5749L,5903L,6449L,6701L,7451L,7703L,8053L,8501L,8753L,9103L,9551L,10007L,10357L,10903L,11057L,11953L,12157L,12409L,13109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029975Inst : IEnumerable<long>
{
public static readonly long[] Value=A029975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029975.Bytes);
public long this[int i]=>Value[i];

public static A029975Inst Instance=new A029975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029976
{
public static readonly long[] Value={ 2L,3L,5L,7L,73L,89L,97L,113L,211L,227L,251L,349L,373L,463L,479L,487L,503L,4289L,4481L,4937L,5393L,5521L,5657L,5849L,6761L,7537L,7993L,12547L,12611L,12739L,13003L,13259L,13331L,13523L,14107L,14563L,14627L,14891L,15083L,15667L,15731L,15859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029976Inst : IEnumerable<long>
{
public static readonly long[] Value=A029976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029976.Bytes);
public long this[int i]=>Value[i];

public static A029976Inst Instance=new A029976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029977
{
public static readonly long[] Value={ 2L,3L,5L,7L,109L,127L,173L,191L,227L,337L,373L,419L,601L,619L,683L,701L,719L,6967L,7129L,7867L,8443L,9181L,9343L,10333L,10657L,11071L,11971L,12547L,13033L,13367L,13691L,14843L,15581L,16319L,16481L,17957L,18119L,18371L,19433L,27067L,27967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029977Inst : IEnumerable<long>
{
public static readonly long[] Value=A029977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029977.Bytes);
public long this[int i]=>Value[i];

public static A029977Inst Instance=new A029977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029978
{
public static readonly long[] Value={ 2L,3L,5L,7L,199L,277L,421L,443L,499L,521L,587L,643L,709L,743L,787L,809L,887L,953L,1009L,1031L,1109L,1153L,1231L,1297L,1319L,15731L,16831L,19031L,19273L,20857L,22441L,23057L,25741L,27809L,28183L,28909L,31231L,32089L,32573L,34157L,35257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029978Inst : IEnumerable<long>
{
public static readonly long[] Value=A029978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029978.Bytes);
public long this[int i]=>Value[i];

public static A029978Inst Instance=new A029978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029979
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,157L,181L,193L,229L,241L,277L,761L,773L,797L,809L,821L,857L,1039L,1051L,1063L,1087L,1123L,1607L,1619L,1667L,21169L,21313L,21601L,22621L,23053L,23197L,23629L,23773L,23917L,24061L,24793L,25657L,25801L,26821L,27109L,27253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029979Inst : IEnumerable<long>
{
public static readonly long[] Value=A029979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029979.Bytes);
public long this[int i]=>Value[i];

public static A029979Inst Instance=new A029979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029980
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,313L,353L,379L,431L,457L,523L,601L,653L,719L,797L,823L,863L,941L,967L,1033L,1163L,1229L,1307L,1373L,1399L,1451L,1543L,1621L,1987L,2053L,2131L,30941L,33151L,33827L,34841L,36037L,36713L,37571L,38923L,42667L,44201L,45553L,46411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029980Inst : IEnumerable<long>
{
public static readonly long[] Value=A029980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029980.Bytes);
public long this[int i]=>Value[i];

public static A029980Inst Instance=new A029980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029997
{
public static readonly long[] Value={ 0L,1L,4L,9L,36L,144L,576L,676L,5184L,7056L,14884L,17689L,20736L,59536L,65025L,77841L,145924L,535824L,1774224L,2143296L,2547216L,5827396L,7096896L,7817616L,9375844L,20034576L,63872064L,214388164L,217946169L,221533456L,255488256L,259371025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029997Inst : IEnumerable<long>
{
public static readonly long[] Value=A029997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029997.Bytes);
public long this[int i]=>Value[i];

public static A029997Inst Instance=new A029997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029998
{
public static readonly long[] Value={ 0L,1L,2L,3L,14L,28L,170L,183L,196L,209L,308L,340L,353L,366L,2198L,2380L,2562L,2898L,4026L,4242L,4396L,4578L,7078L,7662L,28562L,28731L,28900L,29069L,30772L,30941L,31110L,32813L,32982L,33151L,37374L,51510L,52360L,54942L,55449L,57124L,57293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029998Inst : IEnumerable<long>
{
public static readonly long[] Value=A029998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029998.Bytes);
public long this[int i]=>Value[i];

public static A029998Inst Instance=new A029998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A029999
{
public static readonly long[] Value={ 0L,1L,4L,9L,196L,784L,28900L,33489L,38416L,43681L,94864L,115600L,124609L,133956L,4831204L,5664400L,6563844L,8398404L,16208676L,17994564L,19324816L,20958084L,50098084L,58706244L,815787844L,825470361L,835210000L,845006761L,946915984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A029999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A029999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A029999Inst : IEnumerable<long>
{
public static readonly long[] Value=A029999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A029999.Bytes);
public long this[int i]=>Value[i];

public static A029999Inst Instance=new A029999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030000
{
public static readonly long[] Value={ 10L,0L,1L,5L,2L,8L,4L,15L,3L,12L,10L,40L,7L,17L,18L,21L,4L,27L,30L,13L,11L,18L,43L,41L,10L,8L,18L,15L,7L,32L,22L,17L,5L,25L,27L,25L,16L,30L,14L,42L,12L,22L,19L,22L,18L,28L,42L,31L,11L,32L,52L,9L,19L,16L,25L,16L,8L,20L,33L,33L,23L,58L,18L,14L,6L,16L,46L,24L,15L,34L,29L,21L,17L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030000Inst : IEnumerable<long>
{
public static readonly long[] Value=A030000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030000.Bytes);
public long this[int i]=>Value[i];

public static A030000Inst Instance=new A030000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030001
{
public static readonly long[] Value={ 1L,2L,32L,4L,256L,16L,32768L,8L,4096L,1024L,1099511627776L,128L,131072L,262144L,2097152L,16L,134217728L,1073741824L,8192L,2048L,262144L,8796093022208L,2199023255552L,1024L,256L,262144L,32768L,128L,4294967296L,4194304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030001Inst : IEnumerable<long>
{
public static readonly long[] Value=A030001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030001.Bytes);
public long this[int i]=>Value[i];

public static A030001Inst Instance=new A030001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030002
{
public static readonly long[] Value={ 0L,0L,1L,4L,20L,35L,84L,220L,286L,560L,816L,969L,1330L,2024L,2925L,3276L,4495L,5456L,5984L,7770L,9139L,11480L,15180L,17296L,18424L,20825L,22100L,24804L,35990L,39711L,45760L,47905L,59640L,62196L,70300L,79079L,85320L,95284L,105995L,109736L,129766L,134044L,142880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030002Inst : IEnumerable<long>
{
public static readonly long[] Value=A030002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030002.Bytes);
public long this[int i]=>Value[i];

public static A030002Inst Instance=new A030002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030003
{
public static readonly long[] Value={ 0L,0L,0L,4L,10L,35L,56L,120L,286L,364L,680L,969L,1140L,1540L,2300L,3276L,3654L,4960L,5984L,6545L,8436L,9880L,12341L,16215L,18424L,19600L,22100L,23426L,26235L,37820L,41664L,47905L,50116L,62196L,64824L,73150L,82160L,88560L,98770L,109736L,113564L,134044L,138415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030003Inst : IEnumerable<long>
{
public static readonly long[] Value=A030003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030003.Bytes);
public long this[int i]=>Value[i];

public static A030003Inst Instance=new A030003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030004
{
public static readonly long[] Value={ 0L,0L,1L,10L,20L,56L,84L,165L,364L,455L,816L,1140L,1330L,1771L,2600L,3654L,4060L,5456L,6545L,7140L,9139L,10660L,13244L,17296L,19600L,20825L,23426L,24804L,27720L,39711L,43680L,50116L,52394L,64824L,67525L,76076L,85320L,91881L,102340L,113564L,117480L,138415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030004Inst : IEnumerable<long>
{
public static readonly long[] Value=A030004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030004.Bytes);
public long this[int i]=>Value[i];

public static A030004Inst Instance=new A030004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030005
{
public static readonly long[] Value={ 0L,1L,3L,10L,15L,28L,36L,55L,91L,105L,153L,190L,210L,253L,325L,406L,435L,528L,595L,630L,741L,820L,946L,1128L,1225L,1275L,1378L,1431L,1540L,1953L,2080L,2278L,2346L,2701L,2775L,3003L,3240L,3403L,3655L,3916L,4005L,4465L,4560L,4753L,4851L,5460L,6105L,6328L,6441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030005Inst : IEnumerable<long>
{
public static readonly long[] Value=A030005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030005.Bytes);
public long this[int i]=>Value[i];

public static A030005Inst Instance=new A030005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030006
{
public static readonly long[] Value={ 0L,1L,5L,8L,16L,21L,33L,56L,65L,96L,120L,133L,161L,208L,261L,280L,341L,385L,408L,481L,533L,616L,736L,800L,833L,901L,936L,1008L,1281L,1365L,1496L,1541L,1776L,1825L,1976L,2133L,2241L,2408L,2581L,2640L,2945L,3008L,3136L,3201L,3605L,4033L,4181L,4256L,4408L,4641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030006Inst : IEnumerable<long>
{
public static readonly long[] Value=A030006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030006.Bytes);
public long this[int i]=>Value[i];

public static A030006Inst Instance=new A030006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030007
{
public static readonly long[] Value={ 0L,0L,1L,6L,10L,21L,28L,45L,78L,91L,136L,171L,190L,231L,300L,378L,406L,496L,561L,595L,703L,780L,903L,1081L,1176L,1225L,1326L,1378L,1485L,1891L,2016L,2211L,2278L,2628L,2701L,2926L,3160L,3321L,3570L,3828L,3916L,4371L,4465L,4656L,4753L,5356L,5995L,6216L,6328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030007Inst : IEnumerable<long>
{
public static readonly long[] Value=A030007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030007.Bytes);
public long this[int i]=>Value[i];

public static A030007Inst Instance=new A030007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030008
{
public static readonly long[] Value={ 1L,14L,182L,2366L,30590L,395486L,5105870L,65919182L,850586702L,10975573182L,141586912166L,1826501185054L,23558885899318L,303871575267918L,3919114007263518L,50545912921275198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030008Inst : IEnumerable<long>
{
public static readonly long[] Value=A030008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030008.Bytes);
public long this[int i]=>Value[i];

public static A030008Inst Instance=new A030008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030009
{
public static readonly long[] Value={ 1L,2L,6L,15L,37L,85L,192L,414L,879L,1816L,3694L,7362L,14480L,28037L,53644L,101379L,189587L,350874L,643431L,1169388L,2108045L,3770430L,6694894L,11804968L,20679720L,35999794L,62298755L,107198541L,183462856L,312357002L,529173060L,892216829L,1497454396L,2502190992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030009Inst : IEnumerable<long>
{
public static readonly long[] Value=A030009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030009.Bytes);
public long this[int i]=>Value[i];

public static A030009Inst Instance=new A030009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030010
{
public static readonly long[] Value={ 2L,0L,1L,0L,2L,-3L,2L,-4L,4L,-3L,4L,-5L,10L,-21L,20L,-18L,34L,-46L,64L,-99L,126L,-182L,258L,-319L,464L,-685L,936L,-1352L,1888L,-2570L,3690L,-5188L,7292L,-10501L,14742L,-20766L,29610L,-41650L,59052L,-84338L,119602L,-170279L,242256L,-343356L,489550L,-698073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030010Inst : IEnumerable<long>
{
public static readonly long[] Value=A030010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030010.Bytes);
public long this[int i]=>Value[i];

public static A030010Inst Instance=new A030010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030011
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,-1L,-2L,-3L,-2L,4L,-1L,5L,3L,-4L,-5L,-9L,3L,-3L,15L,19L,0L,6L,-39L,-27L,-22L,5L,57L,50L,107L,-49L,-96L,-142L,-213L,83L,138L,468L,365L,0L,-327L,-1215L,-618L,-526L,957L,2572L,1831L,1673L,-2820L,-4516L,-6155L,-3880L,5998L,9282L,18213L,7414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030011Inst : IEnumerable<long>
{
public static readonly long[] Value=A030011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030011.Bytes);
public long this[int i]=>Value[i];

public static A030011Inst Instance=new A030011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030012
{
public static readonly long[] Value={ 1L,3L,6L,14L,27L,58L,109L,216L,402L,760L,1390L,2550L,4569L,8178L,14408L,25280L,43850L,75685L,129436L,220226L,371906L,624840L,1043178L,1733108L,2863422L,4709222L,7706800L,12558213L,20372860L,32917707L,52971756L,84923643L,135640660L,215886778L,342419132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030012Inst : IEnumerable<long>
{
public static readonly long[] Value=A030012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030012.Bytes);
public long this[int i]=>Value[i];

public static A030012Inst Instance=new A030012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030173
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,20L,21L,22L,24L,26L,27L,28L,29L,30L,32L,34L,35L,36L,38L,39L,40L,41L,42L,44L,45L,46L,48L,50L,51L,52L,54L,56L,57L,58L,59L,60L,62L,64L,65L,66L,68L,69L,70L,71L,72L,74L,76L,77L,78L,80L,81L,82L,84L,86L,87L,88L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030173Inst : IEnumerable<long>
{
public static readonly long[] Value=A030173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030173.Bytes);
public long this[int i]=>Value[i];

public static A030173Inst Instance=new A030173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030174
{
public static readonly BigInteger[] Value={ 1L,121L,12321L,1322122321L,132233322321L,213223221121L,13223121322321L,1212111311221321L,131332121232312121L,BigInteger.Parse("31121322221111133211321"),BigInteger.Parse("3322133322121313132333322321"),BigInteger.Parse("12232213113321121113332133323121") };
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
public class A030174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A030174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A030174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A030174Inst Instance=new A030174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030175
{
public static readonly BigInteger[] Value={ 1L,11L,111L,36361L,363639L,461761L,3636361L,34815389L,362397739L,176412364139L,57637950363639L,3497458093147239L,BigInteger.Parse("56843832676142723489"),BigInteger.Parse("557963558954625926861") };
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
public class A030175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A030175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A030175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A030175Inst Instance=new A030175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030176
{
public static readonly BigInteger[] Value={ 4L,64L,46656L,56644L,66564L,544644L,45454564L,645566464L,6465446464L,5654446456464L,6444655544646544L,445646655445456656L,BigInteger.Parse("45645446454646566544"),BigInteger.Parse("46556646565455444544"),BigInteger.Parse("566545664646454546564"),BigInteger.Parse("6666455655446656664464") };
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
public class A030176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A030176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A030176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A030176Inst Instance=new A030176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030177
{
public static readonly BigInteger[] Value={ 2L,8L,216L,238L,258L,738L,6742L,25408L,80408L,2377908L,80278612L,667567716L,6756141388L,6823243112L,23802219742L,81648365908L,2136952377908L,80401900255258L,258159749875238L,25425667278648884L,BigInteger.Parse("237605691124298293112") };
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
public class A030177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A030177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A030177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A030177Inst Instance=new A030177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030178
{
public static readonly long[] Value={ 5L,6L,7L,1L,4L,3L,2L,9L,0L,4L,0L,9L,7L,8L,3L,8L,7L,2L,9L,9L,9L,9L,6L,8L,6L,6L,2L,2L,1L,0L,3L,5L,5L,5L,4L,9L,7L,5L,3L,8L,1L,5L,7L,8L,7L,1L,8L,6L,5L,1L,2L,5L,0L,8L,1L,3L,5L,1L,3L,1L,0L,7L,9L,2L,2L,3L,0L,4L,5L,7L,9L,3L,0L,8L,6L,6L,8L,4L,5L,6L,6L,6L,9L,3L,2L,1L,9L,4L,4L,6L,9L,6L,1L,7L,5L,2L,2L,9L,4L,5L,5L,7L,6L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030178Inst : IEnumerable<long>
{
public static readonly long[] Value=A030178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030178.Bytes);
public long this[int i]=>Value[i];

public static A030178Inst Instance=new A030178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030179
{
public static readonly long[] Value={ 0L,0L,1L,4L,16L,36L,81L,144L,256L,400L,625L,900L,1296L,1764L,2401L,3136L,4096L,5184L,6561L,8100L,10000L,12100L,14641L,17424L,20736L,24336L,28561L,33124L,38416L,44100L,50625L,57600L,65536L,73984L,83521L,93636L,104976L,116964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030179Inst : IEnumerable<long>
{
public static readonly long[] Value=A030179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030179.Bytes);
public long this[int i]=>Value[i];

public static A030179Inst Instance=new A030179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030180
{
public static readonly long[] Value={ 0L,0L,3L,52L,390L,1860L,6665L,19608L,49932L,113880L,238095L,463980L,853138L,1494012L,2509845L,4068080L,6391320L,9769968L,14576667L,21282660L,30476190L,42883060L,59389473L,81067272L,109201700L,145321800L,191233575L,249056028L,321260202L,410711340L,520714285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030180Inst : IEnumerable<long>
{
public static readonly long[] Value=A030180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030180.Bytes);
public long this[int i]=>Value[i];

public static A030180Inst Instance=new A030180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030181
{
public static readonly long[] Value={ 1L,-4L,2L,8L,-5L,-4L,-10L,12L,-7L,8L,46L,-36L,-26L,-44L,46L,-28L,42L,188L,-132L,-96L,-167L,172L,-98L,120L,596L,-420L,-286L,-492L,496L,-280L,368L,1680L,-1151L,-792L,-1332L,1320L,-735L,916L,4264L,-2908L,-1960L,-3252L,3200L,-1764L,2230L,10104L,-6798L,-4560L,-7536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030181Inst : IEnumerable<long>
{
public static readonly long[] Value=A030181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030181.Bytes);
public long this[int i]=>Value[i];

public static A030181Inst Instance=new A030181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030182
{
public static readonly long[] Value={ 1L,-12L,54L,-76L,-243L,1188L,-1384L,-2916L,11934L,-11580L,-21870L,79704L,-71022L,-123444L,421308L,-352544L,-581013L,1885572L,-1510236L,-2388204L,7469928L,-5777672L,-8852004L,26869968L,-20218587L,-30177684L,89408826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030182Inst : IEnumerable<long>
{
public static readonly long[] Value=A030182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030182.Bytes);
public long this[int i]=>Value[i];

public static A030182Inst Instance=new A030182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030183
{
public static readonly long[] Value={ 1L,10L,51L,204L,681L,1956L,5135L,12360L,28119L,60572L,125682L,251040L,487426L,920568L,1699611L,3070508L,5445510L,9490116L,16283793L,27537708L,45959775L,75760640L,123471327L,199081632L,317814988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030183Inst : IEnumerable<long>
{
public static readonly long[] Value=A030183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030183.Bytes);
public long this[int i]=>Value[i];

public static A030183Inst Instance=new A030183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030184
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,1L,1L,0L,3L,1L,-1L,-4L,1L,-2L,0L,-1L,-1L,2L,-1L,4L,-1L,0L,4L,0L,-3L,1L,2L,-1L,0L,-2L,1L,0L,-5L,4L,-2L,0L,-1L,-10L,-4L,2L,3L,10L,0L,4L,4L,1L,0L,8L,1L,-7L,-1L,-2L,2L,-10L,1L,-4L,0L,-4L,2L,-4L,1L,-2L,0L,0L,7L,-2L,-4L,12L,-2L,0L,0L,-8L,3L,10L,10L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030184Inst : IEnumerable<long>
{
public static readonly long[] Value=A030184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030184.Bytes);
public long this[int i]=>Value[i];

public static A030184Inst Instance=new A030184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030185
{
public static readonly BigInteger[] Value={ 1L,720L,911520L,1301011200L,1958042030400L,3036508587993600L,4800606078996518400L,BigInteger.Parse("7692266556998230118400"),BigInteger.Parse("12448466349673022940816000"),BigInteger.Parse("20299324957420186505619072000"),BigInteger.Parse("33301542920000564787678367257600") };
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
public class A030185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A030185.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A030185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A030185Inst Instance=new A030185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030186
{
public static readonly long[] Value={ 1L,2L,7L,22L,71L,228L,733L,2356L,7573L,24342L,78243L,251498L,808395L,2598440L,8352217L,26846696L,86293865L,277376074L,891575391L,2865808382L,9211624463L,29609106380L,95173135221L,305916887580L,983314691581L,3160687827102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030186Inst : IEnumerable<long>
{
public static readonly long[] Value=A030186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030186.Bytes);
public long this[int i]=>Value[i];

public static A030186Inst Instance=new A030186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030187
{
public static readonly long[] Value={ 1L,-1L,-2L,1L,0L,2L,1L,-1L,1L,0L,0L,-2L,-4L,-1L,0L,1L,6L,-1L,2L,0L,-2L,0L,0L,2L,-5L,4L,4L,1L,-6L,0L,-4L,-1L,0L,-6L,0L,1L,2L,-2L,8L,0L,6L,2L,8L,0L,0L,0L,-12L,-2L,1L,5L,-12L,-4L,6L,-4L,0L,-1L,-4L,6L,-6L,0L,8L,4L,1L,1L,0L,0L,-4L,6L,0L,0L,0L,-1L,2L,-2L,10L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030187Inst : IEnumerable<long>
{
public static readonly long[] Value=A030187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030187.Bytes);
public long this[int i]=>Value[i];

public static A030187Inst Instance=new A030187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030188
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,1L,4L,-2L,2L,2L,-4L,0L,-8L,-1L,-1L,6L,8L,-4L,0L,6L,2L,-6L,4L,-2L,0L,-7L,-2L,-2L,-8L,4L,4L,-2L,0L,4L,-4L,8L,8L,10L,1L,0L,-8L,1L,-4L,-4L,-6L,-6L,0L,-8L,8L,2L,4L,-18L,16L,0L,-12L,-2L,-6L,18L,16L,-2L,0L,5L,6L,12L,-8L,-4L,-4L,0L,2L,-6L,-12L,0L,-8L,-12L,7L,14L,-16L,2L,-16L,-2L,2L,0L,12L,8L,24L,-9L,-4L,6L,0L,-4L,12L,6L,2L,-12L,8L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030188Inst : IEnumerable<long>
{
public static readonly long[] Value=A030188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030188.Bytes);
public long this[int i]=>Value[i];

public static A030188Inst Instance=new A030188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030221
{
public static readonly long[] Value={ 1L,6L,29L,139L,666L,3191L,15289L,73254L,350981L,1681651L,8057274L,38604719L,184966321L,886226886L,4246168109L,20344613659L,97476900186L,467039887271L,2237722536169L,10721572793574L,51370141431701L,246129134364931L,1179275530392954L,5650248517599839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030221Inst : IEnumerable<long>
{
public static readonly long[] Value=A030221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030221.Bytes);
public long this[int i]=>Value[i];

public static A030221Inst Instance=new A030221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030222
{
public static readonly long[] Value={ 1L,2L,5L,22L,94L,524L,3031L,18770L,118133L,758381L,4915652L,32149296L,211637205L,1401194463L,9321454604L,62272330564L,417546684096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030222Inst : IEnumerable<long>
{
public static readonly long[] Value=A030222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030222.Bytes);
public long this[int i]=>Value[i];

public static A030222Inst Instance=new A030222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030223
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,5L,5L,12L,13L,30L,36L,80L,97L,213L,266L,578L,737L,1589L,2051L,4408L,5747L,12333L,16213L,34737L,45979L,98367L,131007L,279902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030223Inst : IEnumerable<long>
{
public static readonly long[] Value=A030223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030223.Bytes);
public long this[int i]=>Value[i];

public static A030223Inst Instance=new A030223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030224
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,7L,19L,54L,147L,418L,1150L,3254L,9138L,25953L,73717L,210719L,603370L,1734739L,4998542L,14444576L,41829991L,121406927L,353029078L,1028417980L,3000754648L,8769118355L,25661830891L,75194886765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030224Inst : IEnumerable<long>
{
public static readonly long[] Value=A030224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030224.Bytes);
public long this[int i]=>Value[i];

public static A030224Inst Instance=new A030224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030225
{
public static readonly long[] Value={ 1L,1L,3L,4L,11L,17L,46L,75L,202L,341L,914L,1581L,4222L,7436L,19794L,35357L,93859L,169558L,449039L,818793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030225Inst : IEnumerable<long>
{
public static readonly long[] Value=A030225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030225.Bytes);
public long this[int i]=>Value[i];

public static A030225Inst Instance=new A030225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030226
{
public static readonly long[] Value={ 0L,0L,0L,3L,11L,65L,287L,1373L,6370L,30149L,142638L,681520L,3270604L,15789461L,76562081L,372832744L,1822142769L,8934740804L,43938715224L,216650217219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030226Inst : IEnumerable<long>
{
public static readonly long[] Value=A030226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030226.Bytes);
public long this[int i]=>Value[i];

public static A030226Inst Instance=new A030226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030227
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,10L,20L,34L,70L,121L,250L,441L,912L,1630L,3375L,6092L,12624L,22961L,47616L,87136L,180811L,332549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030227Inst : IEnumerable<long>
{
public static readonly long[] Value=A030227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030227.Bytes);
public long this[int i]=>Value[i];

public static A030227Inst Instance=new A030227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030228
{
public static readonly long[] Value={ 0L,0L,0L,2L,6L,25L,88L,335L,1215L,4534L,16823L,63159L,237679L,900341L,3423201L,13073163L,50095285L,192599091L,742576616L,2870584814L,11122879867L,43191525139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030228Inst : IEnumerable<long>
{
public static readonly long[] Value=A030228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030228.Bytes);
public long this[int i]=>Value[i];

public static A030228Inst Instance=new A030228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030229
{
public static readonly long[] Value={ 1L,6L,10L,14L,15L,21L,22L,26L,33L,34L,35L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,74L,77L,82L,85L,86L,87L,91L,93L,94L,95L,106L,111L,115L,118L,119L,122L,123L,129L,133L,134L,141L,142L,143L,145L,146L,155L,158L,159L,161L,166L,177L,178L,183L,185L,187L,194L,201L,202L,203L,205L,206L,209L,210L,213L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030229Inst : IEnumerable<long>
{
public static readonly long[] Value=A030229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030229.Bytes);
public long this[int i]=>Value[i];

public static A030229Inst Instance=new A030229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030230
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,16L,17L,19L,23L,25L,27L,29L,30L,31L,32L,37L,41L,42L,43L,47L,49L,53L,59L,60L,61L,64L,66L,67L,70L,71L,73L,78L,79L,81L,83L,84L,89L,90L,97L,101L,102L,103L,105L,107L,109L,110L,113L,114L,120L,121L,125L,126L,127L,128L,130L,131L,132L,137L,138L,139L,140L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030230Inst : IEnumerable<long>
{
public static readonly long[] Value=A030230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030230.Bytes);
public long this[int i]=>Value[i];

public static A030230Inst Instance=new A030230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030231
{
public static readonly long[] Value={ 1L,6L,10L,12L,14L,15L,18L,20L,21L,22L,24L,26L,28L,33L,34L,35L,36L,38L,39L,40L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,62L,63L,65L,68L,69L,72L,74L,75L,76L,77L,80L,82L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,98L,99L,100L,104L,106L,108L,111L,112L,115L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030231Inst : IEnumerable<long>
{
public static readonly long[] Value=A030231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030231.Bytes);
public long this[int i]=>Value[i];

public static A030231Inst Instance=new A030231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030232
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,13L,20L,22L,24L,32L,33L,34L,37L,42L,56L,68L,75L,100L,102L,108L,114L,129L,133L,134L,136L,148L,149L,153L,159L,161L,162L,186L,187L,248L,249L,254L,277L,300L,301L,310L,311L,330L,331L,351L,380L,381L,382L,388L,411L,423L,430L,488L,489L,531L,545L,556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030232Inst : IEnumerable<long>
{
public static readonly long[] Value=A030232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030232.Bytes);
public long this[int i]=>Value[i];

public static A030232Inst Instance=new A030232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030233
{
public static readonly long[] Value={ 1L,2L,6L,34L,166L,991L,5931L,37196L,235456L,1514618L,9826177L,64284947L,423241426L,2802300793L,18642694440L,124544085550L,835091956750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030233Inst : IEnumerable<long>
{
public static readonly long[] Value=A030233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030233.Bytes);
public long this[int i]=>Value[i];

public static A030233Inst Instance=new A030233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030234
{
public static readonly long[] Value={ 1L,2L,4L,10L,22L,57L,131L,344L,810L,2144L,5127L,13645L,32984L,88133L,214768L,575578L,1411442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030234Inst : IEnumerable<long>
{
public static readonly long[] Value=A030234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030234.Bytes);
public long this[int i]=>Value[i];

public static A030234Inst Instance=new A030234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030235
{
public static readonly long[] Value={ 0L,0L,1L,12L,72L,467L,2900L,18426L,117323L,756237L,4910525L,32135651L,211604221L,1401106330L,9321239836L,62271754986L,417545272654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030235Inst : IEnumerable<long>
{
public static readonly long[] Value=A030235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030235.Bytes);
public long this[int i]=>Value[i];

public static A030235Inst Instance=new A030235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030236
{
public static readonly long[] Value={ 1L,2L,7L,18L,49L,136L,377L,1044L,2891L,8006L,22171L,61398L,170029L,470860L,1303949L,3611016L,9999959L,27692810L,76689487L,212375610L,588130153L,1628704336L,4510358465L,12490501212L,34589849507L,95789405774L,265268869027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030236Inst : IEnumerable<long>
{
public static readonly long[] Value=A030236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030236.Bytes);
public long this[int i]=>Value[i];

public static A030236Inst Instance=new A030236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030301
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030301Inst : IEnumerable<long>
{
public static readonly long[] Value=A030301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030301.Bytes);
public long this[int i]=>Value[i];

public static A030301Inst Instance=new A030301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030302
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030302Inst : IEnumerable<long>
{
public static readonly long[] Value=A030302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030302.Bytes);
public long this[int i]=>Value[i];

public static A030302Inst Instance=new A030302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030303
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,9L,11L,12L,13L,15L,16L,17L,18L,22L,25L,26L,28L,30L,32L,33L,34L,35L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,50L,55L,59L,60L,63L,65L,68L,69L,70L,72L,75L,77L,79L,80L,82L,83L,85L,87L,88L,89L,90L,91L,95L,96L,99L,100L,101L,103L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030303Inst : IEnumerable<long>
{
public static readonly long[] Value=A030303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030303.Bytes);
public long this[int i]=>Value[i];

public static A030303Inst Instance=new A030303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030304
{
public static readonly long[] Value={ 1L,2L,1L,6L,2L,1L,4L,18L,6L,26L,2L,5L,1L,4L,15L,50L,18L,6L,22L,63L,26L,77L,2L,17L,5L,25L,1L,4L,11L,15L,46L,130L,50L,18L,55L,154L,6L,22L,65L,146L,63L,26L,28L,163L,77L,2L,13L,49L,17L,5L,34L,69L,25L,79L,1L,16L,4L,68L,11L,15L,41L,46L,125L,322L,130L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030304Inst : IEnumerable<long>
{
public static readonly long[] Value=A030304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030304.Bytes);
public long this[int i]=>Value[i];

public static A030304Inst Instance=new A030304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030305
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,4L,3L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,5L,4L,3L,1L,3L,2L,2L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,3L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,6L,5L,4L,1L,4L,3L,2L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030305Inst : IEnumerable<long>
{
public static readonly long[] Value=A030305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030305.Bytes);
public long this[int i]=>Value[i];

public static A030305Inst Instance=new A030305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030306
{
public static readonly long[] Value={ 2L,3L,1L,3L,4L,1L,2L,1L,1L,4L,2L,4L,5L,1L,2L,1L,1L,3L,1L,1L,1L,2L,2L,1L,5L,2L,3L,1L,2L,5L,3L,5L,6L,1L,2L,1L,1L,3L,1L,1L,1L,2L,2L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,3L,2L,1L,2L,2L,3L,1L,6L,2L,3L,1L,2L,4L,1L,2L,1L,3L,2L,2L,6L,3L,4L,1L,3L,6L,4L,6L,7L,1L,2L,1L,1L,3L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030306Inst : IEnumerable<long>
{
public static readonly long[] Value=A030306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030306.Bytes);
public long this[int i]=>Value[i];

public static A030306Inst Instance=new A030306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030307
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,4L,3L,2L,3L,2L,3L,4L,5L,4L,5L,6L,7L,8L,7L,6L,5L,6L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,7L,8L,9L,8L,7L,8L,9L,8L,9L,10L,11L,12L,11L,12L,13L,14L,15L,16L,15L,14L,13L,12L,13L,12L,11L,10L,11L,12L,11L,10L,11L,10L,11L,10L,9L,10L,11L,12L,11L,12L,11L,10L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030307Inst : IEnumerable<long>
{
public static readonly long[] Value=A030307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030307.Bytes);
public long this[int i]=>Value[i];

public static A030307Inst Instance=new A030307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030308
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030308Inst : IEnumerable<long>
{
public static readonly long[] Value=A030308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030308.Bytes);
public long this[int i]=>Value[i];

public static A030308Inst Instance=new A030308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030309
{
public static readonly long[] Value={ 2L,6L,7L,10L,12L,18L,19L,20L,23L,24L,26L,28L,32L,34L,35L,39L,42L,50L,51L,52L,53L,56L,57L,58L,60L,62L,63L,67L,68L,70L,71L,73L,76L,78L,80L,83L,88L,90L,91L,92L,96L,97L,100L,102L,107L,110L,111L,116L,120L,130L,131L,132L,133L,134L,137L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030309Inst : IEnumerable<long>
{
public static readonly long[] Value=A030309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030309.Bytes);
public long this[int i]=>Value[i];

public static A030309Inst Instance=new A030309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030310
{
public static readonly long[] Value={ 1L,3L,4L,5L,8L,9L,11L,13L,14L,15L,16L,17L,21L,22L,25L,27L,29L,30L,31L,33L,36L,37L,38L,40L,41L,43L,44L,45L,46L,47L,48L,49L,54L,55L,59L,61L,64L,65L,66L,69L,72L,74L,75L,77L,79L,81L,82L,84L,85L,86L,87L,89L,93L,94L,95L,98L,99L,101L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030310Inst : IEnumerable<long>
{
public static readonly long[] Value=A030310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030310.Bytes);
public long this[int i]=>Value[i];

public static A030310Inst Instance=new A030310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030311
{
public static readonly long[] Value={ 1L,1L,3L,5L,1L,4L,3L,17L,5L,9L,1L,4L,8L,3L,13L,49L,17L,22L,5L,31L,9L,38L,1L,16L,4L,8L,37L,3L,29L,14L,13L,129L,49L,55L,17L,66L,22L,5L,33L,87L,31L,75L,9L,106L,38L,1L,11L,48L,16L,21L,4L,30L,8L,37L,40L,15L,3L,29L,36L,14L,84L,13L,43L,321L,129L,136L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030311Inst : IEnumerable<long>
{
public static readonly long[] Value=A030311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030311.Bytes);
public long this[int i]=>Value[i];

public static A030311Inst Instance=new A030311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030312
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,4L,3L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,5L,4L,1L,3L,3L,2L,2L,1L,2L,1L,2L,2L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,4L,3L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,6L,5L,1L,4L,4L,2L,3L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030312Inst : IEnumerable<long>
{
public static readonly long[] Value=A030312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030312.Bytes);
public long this[int i]=>Value[i];

public static A030312Inst Instance=new A030312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030313
{
public static readonly long[] Value={ 1L,3L,2L,1L,5L,2L,1L,1L,3L,1L,3L,2L,7L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,4L,1L,3L,2L,1L,4L,2L,4L,3L,9L,2L,1L,1L,3L,1L,1L,2L,1L,1L,2L,4L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,2L,2L,2L,1L,3L,5L,1L,3L,2L,1L,4L,2L,1L,3L,1L,2L,2L,5L,2L,4L,3L,1L,5L,3L,5L,4L,11L,2L,1L,1L,3L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030313Inst : IEnumerable<long>
{
public static readonly long[] Value=A030313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030313.Bytes);
public long this[int i]=>Value[i];

public static A030313Inst Instance=new A030313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030314
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,4L,5L,6L,7L,6L,5L,4L,5L,6L,5L,4L,5L,4L,5L,4L,5L,6L,7L,6L,7L,6L,5L,6L,7L,8L,7L,8L,9L,8L,9L,10L,11L,12L,13L,14L,15L,14L,13L,12L,11L,12L,13L,12L,11L,10L,11L,10L,11L,10L,9L,10L,11L,12L,11L,10L,11L,10L,9L,10L,9L,10L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030314Inst : IEnumerable<long>
{
public static readonly long[] Value=A030314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030314.Bytes);
public long this[int i]=>Value[i];

public static A030314Inst Instance=new A030314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030315
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030315Inst : IEnumerable<long>
{
public static readonly long[] Value=A030315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030315.Bytes);
public long this[int i]=>Value[i];

public static A030315Inst Instance=new A030315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030316
{
public static readonly long[] Value={ 3L,3L,7L,3L,8L,7L,19L,3L,24L,8L,21L,23L,7L,19L,51L,14L,3L,24L,58L,8L,27L,21L,54L,66L,23L,7L,20L,56L,19L,51L,131L,45L,14L,10L,3L,37L,24L,58L,140L,8L,76L,27L,62L,21L,71L,54L,135L,173L,66L,23L,57L,7L,61L,20L,53L,149L,56L,143L,19L,137L,51L,131L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030316Inst : IEnumerable<long>
{
public static readonly long[] Value=A030316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030316.Bytes);
public long this[int i]=>Value[i];

public static A030316Inst Instance=new A030316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030317
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030317Inst : IEnumerable<long>
{
public static readonly long[] Value=A030317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030317.Bytes);
public long this[int i]=>Value[i];

public static A030317Inst Instance=new A030317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030318
{
public static readonly long[] Value={ 5L,11L,12L,15L,20L,27L,28L,29L,32L,33L,37L,39L,42L,48L,49L,53L,59L,67L,68L,69L,70L,73L,74L,75L,79L,80L,82L,85L,86L,91L,93L,94L,97L,99L,103L,106L,109L,116L,117L,118L,122L,123L,128L,130L,134L,141L,142L,147L,154L,163L,164L,165L,166L,167L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030318Inst : IEnumerable<long>
{
public static readonly long[] Value=A030318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030318.Bytes);
public long this[int i]=>Value[i];

public static A030318Inst Instance=new A030318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030319
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,10L,13L,14L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,30L,31L,34L,35L,36L,38L,40L,41L,43L,44L,45L,46L,47L,50L,51L,52L,54L,55L,56L,57L,58L,60L,61L,62L,63L,64L,65L,66L,71L,72L,76L,77L,78L,81L,83L,84L,87L,88L,89L,90L,92L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030319Inst : IEnumerable<long>
{
public static readonly long[] Value=A030319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030319.Bytes);
public long this[int i]=>Value[i];

public static A030319Inst Instance=new A030319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030320
{
public static readonly long[] Value={ 1L,4L,1L,10L,4L,3L,1L,26L,10L,36L,4L,9L,3L,2L,1L,66L,26L,78L,10L,90L,36L,38L,4L,25L,9L,35L,3L,8L,2L,1L,6L,162L,66L,176L,26L,190L,78L,10L,31L,218L,90L,232L,36L,81L,38L,98L,4L,65L,25L,77L,9L,89L,35L,101L,3L,24L,8L,34L,2L,7L,1L,6L,21L,162L,66L,176L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030320Inst : IEnumerable<long>
{
public static readonly long[] Value=A030320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030320.Bytes);
public long this[int i]=>Value[i];

public static A030320Inst Instance=new A030320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030321
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,4L,3L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,1L,1L,5L,4L,3L,1L,3L,2L,2L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030321Inst : IEnumerable<long>
{
public static readonly long[] Value=A030321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030321.Bytes);
public long this[int i]=>Value[i];

public static A030321Inst Instance=new A030321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030322
{
public static readonly long[] Value={ 4L,5L,2L,4L,6L,2L,3L,1L,2L,5L,3L,5L,7L,2L,3L,1L,2L,4L,1L,2L,1L,3L,2L,2L,6L,3L,4L,1L,3L,6L,4L,6L,8L,2L,3L,1L,2L,4L,1L,2L,1L,3L,2L,2L,5L,1L,2L,1L,3L,1L,1L,2L,1L,4L,2L,2L,2L,3L,3L,2L,7L,3L,4L,1L,3L,5L,1L,3L,1L,4L,2L,3L,7L,4L,5L,1L,4L,7L,5L,7L,9L,2L,3L,1L,2L,4L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030322Inst : IEnumerable<long>
{
public static readonly long[] Value=A030322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030322.Bytes);
public long this[int i]=>Value[i];

public static A030322Inst Instance=new A030322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030323
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,5L,6L,7L,8L,7L,6L,7L,8L,7L,8L,9L,10L,11L,10L,11L,12L,13L,14L,15L,16L,15L,14L,13L,14L,15L,14L,13L,14L,15L,16L,15L,16L,15L,16L,17L,16L,17L,18L,19L,20L,21L,20L,19L,20L,21L,22L,21L,22L,23L,24L,25L,26L,25L,26L,27L,28L,29L,30L,31L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030323Inst : IEnumerable<long>
{
public static readonly long[] Value=A030323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030323.Bytes);
public long this[int i]=>Value[i];

public static A030323Inst Instance=new A030323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030324
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030324Inst : IEnumerable<long>
{
public static readonly long[] Value=A030324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030324.Bytes);
public long this[int i]=>Value[i];

public static A030324Inst Instance=new A030324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030325
{
public static readonly long[] Value={ 3L,7L,10L,11L,12L,15L,18L,20L,23L,24L,25L,27L,30L,35L,38L,39L,42L,43L,45L,46L,47L,48L,52L,54L,55L,58L,63L,64L,67L,68L,71L,72L,73L,75L,80L,83L,88L,89L,90L,95L,98L,100L,101L,102L,103L,106L,107L,108L,110L,111L,112L,113L,114L,116L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030325Inst : IEnumerable<long>
{
public static readonly long[] Value=A030325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030325.Bytes);
public long this[int i]=>Value[i];

public static A030325Inst Instance=new A030325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030326
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,13L,14L,16L,17L,19L,21L,22L,26L,28L,29L,31L,32L,33L,34L,36L,37L,40L,41L,44L,49L,50L,51L,53L,56L,57L,59L,60L,61L,62L,65L,66L,69L,70L,74L,76L,77L,78L,79L,81L,82L,84L,85L,86L,87L,91L,92L,93L,94L,96L,97L,99L,104L,105L,109L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030326Inst : IEnumerable<long>
{
public static readonly long[] Value=A030326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030326.Bytes);
public long this[int i]=>Value[i];

public static A030326Inst Instance=new A030326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030327
{
public static readonly long[] Value={ 1L,2L,1L,9L,2L,1L,4L,9L,37L,17L,2L,8L,1L,4L,31L,44L,9L,41L,37L,51L,17L,6L,2L,8L,36L,16L,1L,60L,4L,31L,160L,109L,44L,22L,9L,41L,155L,37L,296L,97L,51L,115L,17L,6L,14L,2L,29L,141L,8L,40L,36L,50L,16L,5L,1L,85L,60L,49L,4L,59L,31L,161L,160L,109L,142L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030327Inst : IEnumerable<long>
{
public static readonly long[] Value=A030327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030327.Bytes);
public long this[int i]=>Value[i];

public static A030327Inst Instance=new A030327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030328
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,1L,3L,1L,1L,1L,2L,2L,4L,1L,2L,1L,2L,2L,3L,1L,1L,1L,3L,1L,1L,4L,3L,5L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,4L,1L,3L,1L,2L,1L,1L,3L,1L,1L,1L,2L,5L,2L,2L,1L,3L,3L,1L,1L,3L,3L,1L,1L,4L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,1L,2L,1L,2L,3L,1L,3L,1L,2L,3L,1L,1L,1L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030328Inst : IEnumerable<long>
{
public static readonly long[] Value=A030328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030328.Bytes);
public long this[int i]=>Value[i];

public static A030328Inst Instance=new A030328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030329
{
public static readonly long[] Value={ 2L,3L,2L,2L,2L,1L,2L,1L,2L,4L,2L,2L,1L,3L,1L,2L,4L,2L,2L,1L,4L,2L,4L,4L,2L,1L,2L,1L,1L,1L,1L,3L,1L,2L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,6L,8L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,4L,2L,1L,2L,2L,8L,1L,1L,1L,2L,2L,1L,3L,7L,2L,1L,2L,1L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030329Inst : IEnumerable<long>
{
public static readonly long[] Value=A030329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030329.Bytes);
public long this[int i]=>Value[i];

public static A030329Inst Instance=new A030329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030330
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,4L,3L,4L,5L,4L,3L,2L,3L,4L,3L,4L,5L,4L,5L,4L,5L,6L,5L,4L,3L,4L,3L,4L,5L,4L,5L,6L,7L,8L,7L,8L,9L,8L,7L,8L,9L,8L,7L,8L,7L,6L,5L,4L,5L,6L,7L,6L,7L,6L,5L,6L,7L,6L,7L,8L,9L,10L,9L,8L,9L,10L,9L,8L,9L,10L,9L,8L,7L,8L,7L,8L,9L,10L,11L,10L,11L,12L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030330Inst : IEnumerable<long>
{
public static readonly long[] Value=A030330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030330.Bytes);
public long this[int i]=>Value[i];

public static A030330Inst Instance=new A030330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030331
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,18216L,156492L,1147608L,3736557L,6248088L,4399164L,1038312L,32778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030331Inst : IEnumerable<long>
{
public static readonly long[] Value=A030331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030331.Bytes);
public long this[int i]=>Value[i];

public static A030331Inst Instance=new A030331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030332
{
public static readonly long[] Value={ 4L,10L,16L,17L,19L,22L,26L,35L,43L,44L,46L,49L,53L,62L,70L,71L,72L,74L,75L,78L,79L,82L,84L,86L,90L,94L,96L,98L,102L,107L,108L,111L,115L,120L,132L,143L,144L,147L,151L,156L,168L,178L,179L,180L,182L,183L,186L,187L,190L,192L,194L,198L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030332Inst : IEnumerable<long>
{
public static readonly long[] Value=A030332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030332.Bytes);
public long this[int i]=>Value[i];

public static A030332Inst Instance=new A030332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030429
{
public static readonly long[] Value={ 1L,2L,7L,26L,115L,596L,3331L,19100L,110329L,638540L,3697405L,21411974L,124001893L,718129334L,4158891979L,24085338398L,139485124807L,807798504728L,4678193659303L,27092766081872L,156902006957821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030429Inst : IEnumerable<long>
{
public static readonly long[] Value=A030429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030429.Bytes);
public long this[int i]=>Value[i];

public static A030429Inst Instance=new A030429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030430
{
public static readonly long[] Value={ 11L,31L,41L,61L,71L,101L,131L,151L,181L,191L,211L,241L,251L,271L,281L,311L,331L,401L,421L,431L,461L,491L,521L,541L,571L,601L,631L,641L,661L,691L,701L,751L,761L,811L,821L,881L,911L,941L,971L,991L,1021L,1031L,1051L,1061L,1091L,1151L,1171L,1181L,1201L,1231L,1291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030430Inst : IEnumerable<long>
{
public static readonly long[] Value=A030430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030430.Bytes);
public long this[int i]=>Value[i];

public static A030430Inst Instance=new A030430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A030431
{
public static readonly long[] Value={ 3L,13L,23L,43L,53L,73L,83L,103L,113L,163L,173L,193L,223L,233L,263L,283L,293L,313L,353L,373L,383L,433L,443L,463L,503L,523L,563L,593L,613L,643L,653L,673L,683L,733L,743L,773L,823L,853L,863L,883L,953L,983L,1013L,1033L,1063L,1093L,1103L,1123L,1153L,1163L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A030431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A030431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A030431Inst : IEnumerable<long>
{
public static readonly long[] Value=A030431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A030431.Bytes);
public long this[int i]=>Value[i];

public static A030431Inst Instance=new A030431Inst();

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