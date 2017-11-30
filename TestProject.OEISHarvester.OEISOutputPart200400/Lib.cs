using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A270669
{
public static readonly BigInteger[] Value={ 1L,1L,4L,31L,168L,1841L,19320L,226885L,2655408L,47569681L,743996880L,12582916061L,245804712120L,4831304993113L,109782586920552L,2669560767444901L,61579705719702240L,1566459883903878305L,BigInteger.Parse("44585240861695115808"),BigInteger.Parse("1212424119941953292461"),BigInteger.Parse("37517727808419084095400") };
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
public class A270669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270669Inst Instance=new A270669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270670
{
public static readonly BigInteger[] Value={ 1L,1L,4L,31L,168L,1841L,18600L,221845L,2655408L,44969041L,703172880L,11894018621L,231354830520L,4504644624793L,100890401218152L,2370351246834901L,55456622199548640L,1400307612079837985L,BigInteger.Parse("39002429830457675808"),BigInteger.Parse("1058964187034314179181"),BigInteger.Parse("32049467535091477285800") };
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
public class A270670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270670Inst Instance=new A270670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270671
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,7L,6L,9L,8L,90L,10L,21L,20L,31L,30L,40L,32L,42L,41L,50L,43L,52L,51L,54L,53L,61L,60L,63L,62L,65L,64L,71L,70L,73L,72L,75L,74L,80L,76L,82L,81L,84L,83L,86L,85L,91L,87L,93L,92L,95L,94L,97L,96L,702L,12L,14L,13L,16L,15L,18L,17L,23L,19L,25L,24L,27L,26L,29L,28L,35L,34L,37L,36L,39L,38L,46L,45L,48L,47L,56L,49L,58L,57L,67L,59L,69L,68L,79L,78L,120L,98L,902L,121L,202L,130L,203L,131L,204L,132L,302L,140L,205L,141L,206L,142L,303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270671Inst : IEnumerable<long>
{
public static readonly long[] Value=A270671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270671.Bytes);
public long this[int i]=>Value[i];

public static A270671Inst Instance=new A270671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270672
{
public static readonly long[] Value={ 0L,3L,9L,12L,21L,27L,36L,39L,48L,57L,63L,75L,81L,84L,93L,108L,111L,117L,129L,144L,147L,156L,171L,183L,189L,192L,201L,219L,225L,228L,237L,243L,252L,273L,279L,291L,300L,309L,324L,327L,333L,336L,351L,363L,372L,381L,387L,399L,417L,432L,441L,444L,453L,468L,471L,489L,507L,513L,516L,525L,543L,549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270672Inst : IEnumerable<long>
{
public static readonly long[] Value=A270672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270672.Bytes);
public long this[int i]=>Value[i];

public static A270672Inst Instance=new A270672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270673
{
public static readonly long[] Value={ 1L,5L,9L,41L,21L,93L,49L,185L,61L,301L,97L,441L,141L,581L,221L,761L,237L,1005L,273L,1273L,317L,1541L,409L,1817L,477L,2149L,569L,2473L,717L,2757L,937L,3089L,973L,3565L,1009L,4089L,1053L,4613L,1145L,5145L,1213L,5733L,1305L,6313L,1453L,6853L,1697L,7409L,1805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270673Inst : IEnumerable<long>
{
public static readonly long[] Value=A270673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270673.Bytes);
public long this[int i]=>Value[i];

public static A270673Inst Instance=new A270673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270674
{
public static readonly long[] Value={ 1L,5L,41L,185L,761L,3089L,12385L,49537L,197785L,789721L,3154305L,12604401L,50383849L,201450633L,805595985L,3221892385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270674Inst : IEnumerable<long>
{
public static readonly long[] Value=A270674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270674.Bytes);
public long this[int i]=>Value[i];

public static A270674Inst Instance=new A270674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270675
{
public static readonly long[] Value={ 1L,6L,15L,56L,77L,170L,219L,404L,465L,766L,863L,1304L,1445L,2026L,2247L,3008L,3245L,4250L,4523L,5796L,6113L,7654L,8063L,9880L,10357L,12506L,13075L,15548L,16265L,19022L,19959L,23048L,24021L,27586L,28595L,32684L,33737L,38350L,39495L,44640L,45853L,51586L,52891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270675Inst : IEnumerable<long>
{
public static readonly long[] Value=A270675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270675.Bytes);
public long this[int i]=>Value[i];

public static A270675Inst Instance=new A270675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270692
{
public static readonly long[] Value={ 4L,0L,28L,-20L,80L,-68L,136L,-108L,232L,-220L,352L,-324L,496L,-480L,620L,-568L,868L,-912L,1188L,-1236L,1612L,-1520L,1672L,-1528L,1848L,-1836L,2136L,-2060L,2492L,-2496L,2748L,-2624L,3184L,-3296L,3928L,-3972L,4460L,-4280L,4716L,-4672L,5252L,-5136L,5680L,-5684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270692Inst : IEnumerable<long>
{
public static readonly long[] Value=A270692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270692.Bytes);
public long this[int i]=>Value[i];

public static A270692Inst Instance=new A270692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270693
{
public static readonly long[] Value={ 1L,-25L,51L,-100L,151L,-225L,301L,-400L,501L,-625L,751L,-900L,1051L,-1225L,1401L,-1600L,1801L,-2025L,2251L,-2500L,2751L,-3025L,3301L,-3600L,3901L,-4225L,4551L,-4900L,5251L,-5625L,6001L,-6400L,6801L,-7225L,7651L,-8100L,8551L,-9025L,9501L,-10000L,10501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270693Inst : IEnumerable<long>
{
public static readonly long[] Value=A270693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270693.Bytes);
public long this[int i]=>Value[i];

public static A270693Inst Instance=new A270693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270694
{
public static readonly long[] Value={ 0L,-1L,8L,-23L,51L,-94L,157L,-242L,354L,-495L,670L,-881L,1133L,-1428L,1771L,-2164L,2612L,-3117L,3684L,-4315L,5015L,-5786L,6633L,-7558L,8566L,-9659L,10842L,-12117L,13489L,-14960L,16535L,-18216L,20008L,-21913L,23936L,-26079L,28347L,-30742L,33269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270694Inst : IEnumerable<long>
{
public static readonly long[] Value=A270694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270694.Bytes);
public long this[int i]=>Value[i];

public static A270694Inst Instance=new A270694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270695
{
public static readonly long[] Value={ 0L,-1L,9L,-26L,58L,-107L,-276L,404L,-565L,765L,-1006L,1294L,-1631L,2023L,-2472L,2984L,-3561L,4209L,-4930L,5730L,-6611L,7579L,-8636L,9788L,-11037L,12389L,-13846L,15414L,-17095L,18895L,-20816L,22864L,-25041L,27353L,-29802L,32394L,-35131L,38019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270695Inst : IEnumerable<long>
{
public static readonly long[] Value=A270695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270695.Bytes);
public long this[int i]=>Value[i];

public static A270695Inst Instance=new A270695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270696
{
public static readonly long[] Value={ 4L,9L,64L,81L,144L,225L,324L,441L,625L,1089L,1681L,1728L,2601L,3600L,4096L,5184L,6084L,8464L,12544L,13689L,16641L,17576L,19044L,19600L,21952L,25281L,27225L,28224L,29584L,36864L,38025L,39204L,45369L,46656L,47524L,51984L,56169L,74529L,87025L,88804L,91809L,92416L,95481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270696Inst : IEnumerable<long>
{
public static readonly long[] Value=A270696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270696.Bytes);
public long this[int i]=>Value[i];

public static A270696Inst Instance=new A270696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270697
{
public static readonly long[] Value={ 2047L,42799L,90751L,256999L,271951L,476971L,514447L,741751L,877099L,916327L,1302451L,1325843L,1397419L,1441091L,1507963L,1530787L,1907851L,2004403L,2205967L,2304167L,2748023L,2811271L,2953711L,2976487L,3090091L,3116107L,4469471L,4863127L,5016191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270697Inst : IEnumerable<long>
{
public static readonly long[] Value=A270697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270697.Bytes);
public long this[int i]=>Value[i];

public static A270697Inst Instance=new A270697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270698
{
public static readonly long[] Value={ 561L,1105L,1729L,1905L,2465L,3277L,4033L,4681L,6601L,8321L,8481L,10585L,12801L,15841L,16705L,18705L,25761L,29341L,30121L,33153L,34945L,41041L,46657L,49141L,52633L,62745L,65281L,74665L,75361L,80581L,85489L,87249L,88357L,104653L,113201L,115921L,126217L,129921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270698Inst : IEnumerable<long>
{
public static readonly long[] Value=A270698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270698.Bytes);
public long this[int i]=>Value[i];

public static A270698Inst Instance=new A270698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270699
{
public static readonly long[] Value={ 1L,3L,5L,11L,13L,15L,19L,29L,35L,37L,43L,53L,59L,61L,67L,75L,83L,101L,107L,109L,119L,131L,139L,149L,157L,163L,173L,179L,181L,195L,197L,211L,227L,229L,251L,255L,269L,277L,283L,293L,307L,317L,331L,347L,349L,373L,375L,379L,389L,397L,419L,421L,435L,443L,455L,461L,467L,491L,499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270699Inst : IEnumerable<long>
{
public static readonly long[] Value=A270699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270699.Bytes);
public long this[int i]=>Value[i];

public static A270699Inst Instance=new A270699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270700
{
public static readonly long[] Value={ 12L,42L,78L,114L,150L,186L,222L,258L,294L,330L,366L,402L,438L,474L,510L,546L,582L,618L,654L,690L,726L,762L,798L,834L,870L,906L,942L,978L,1014L,1050L,1086L,1122L,1158L,1194L,1230L,1266L,1302L,1338L,1374L,1410L,1446L,1482L,1518L,1554L,1590L,1626L,1662L,1698L,1734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270700Inst : IEnumerable<long>
{
public static readonly long[] Value=A270700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270700.Bytes);
public long this[int i]=>Value[i];

public static A270700Inst Instance=new A270700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270701
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,9L,5L,9L,16L,30L,15L,25L,41L,67L,112L,52L,82L,127L,195L,299L,463L,203L,307L,456L,670L,979L,1429L,2095L,877L,1283L,1845L,2623L,3702L,5204L,7307L,10279L,4140L,5894L,8257L,11437L,15717L,21485L,29278L,39848L,54267L,21147L,29427L,40338L,54692L,73561L,98367L,131007L,174029L,230884L,306298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270701Inst : IEnumerable<long>
{
public static readonly long[] Value=A270701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270701.Bytes);
public long this[int i]=>Value[i];

public static A270701Inst Instance=new A270701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270702
{
public static readonly long[] Value={ 1L,3L,1L,9L,4L,2L,30L,16L,9L,5L,112L,67L,41L,25L,15L,463L,299L,195L,127L,82L,52L,2095L,1429L,979L,670L,456L,307L,203L,10279L,7307L,5204L,3702L,2623L,1845L,1283L,877L,54267L,39848L,29278L,21485L,15717L,11437L,8257L,5894L,4140L,306298L,230884L,174029L,131007L,98367L,73561L,54692L,40338L,29427L,21147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270702Inst : IEnumerable<long>
{
public static readonly long[] Value=A270702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270702.Bytes);
public long this[int i]=>Value[i];

public static A270702Inst Instance=new A270702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270703
{
public static readonly BigInteger[] Value={ 1L,4L,41L,670L,15717L,492112L,19610565L,961547874L,56562256041L,3914022281500L,313638627550657L,28730918805512678L,2976543225606178893L,BigInteger.Parse("345587228510915829224"),BigInteger.Parse("44615408909143456529309"),BigInteger.Parse("6361213086726610526079402"),BigInteger.Parse("995709801367376369056571089") };
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
public class A270703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270703Inst Instance=new A270703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270704
{
public static readonly long[] Value={ 0L,14L,76L,186L,344L,550L,804L,1106L,1456L,1854L,2300L,2794L,3336L,3926L,4564L,5250L,5984L,6766L,7596L,8474L,9400L,10374L,11396L,12466L,13584L,14750L,15964L,17226L,18536L,19894L,21300L,22754L,24256L,25806L,27404L,29050L,30744L,32486L,34276L,36114L,38000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270704Inst : IEnumerable<long>
{
public static readonly long[] Value=A270704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270704.Bytes);
public long this[int i]=>Value[i];

public static A270704Inst Instance=new A270704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270705
{
public static readonly long[] Value={ 1L,2L,5L,5L,6L,4L,3L,4L,4L,4L,3L,2L,3L,3L,6L,4L,4L,4L,3L,3L,3L,4L,6L,5L,6L,5L,5L,8L,8L,9L,7L,5L,7L,6L,7L,9L,7L,10L,5L,5L,9L,6L,12L,7L,8L,6L,3L,10L,6L,5L,7L,5L,8L,7L,8L,9L,5L,9L,8L,7L,5L,7L,7L,5L,6L,6L,5L,4L,6L,4L,8L,5L,9L,6L,3L,7L,5L,8L,8L,8L,8L,6L,6L,6L,6L,6L,8L,3L,1L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270705Inst : IEnumerable<long>
{
public static readonly long[] Value=A270705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270705.Bytes);
public long this[int i]=>Value[i];

public static A270705Inst Instance=new A270705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270706
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,2L,2L,4L,2L,3L,5L,2L,3L,4L,3L,6L,4L,2L,6L,5L,2L,4L,6L,2L,3L,7L,3L,5L,6L,4L,8L,5L,2L,5L,3L,5L,9L,7L,3L,5L,8L,3L,6L,5L,2L,8L,4L,2L,9L,6L,4L,7L,7L,4L,5L,7L,5L,9L,5L,3L,7L,4L,5L,12L,9L,4L,5L,8L,4L,6L,11L,3L,9L,5L,3L,10L,3L,4L,9L,6L,5L,11L,8L,5L,7L,9L,3L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270706Inst : IEnumerable<long>
{
public static readonly long[] Value=A270706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270706.Bytes);
public long this[int i]=>Value[i];

public static A270706Inst Instance=new A270706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270707
{
public static readonly ulong[] Value={ 0L,2L,3L,14L,60L,349L,2310L,17772L,154224L,1494168L,15973980L,186815386L,2372249880L,32503673760L,477955820160L,7507517217600L,125452772867520L,2222130456911520L,41587962405967872L,820019478835203840L,16990772582549183040UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270707Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A270707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270707.Bytes);
public ulong this[int i]=>Value[i];

public static A270707Inst Instance=new A270707Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270724
{
public static readonly long[] Value={ 1L,3L,5L,10L,20L,42L,93L,213L,504L,1221L,3014L,7553L,19158L,49087L,126845L,330174L,864884L,2278138L,6030218L,16031950L,42790362L,114616360L,307996874L,830084080L,2243193198L,6076953906L,16500486744L,44897830740L,122406923038L,334333367602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270724Inst : IEnumerable<long>
{
public static readonly long[] Value=A270724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270724.Bytes);
public long this[int i]=>Value[i];

public static A270724Inst Instance=new A270724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270725
{
public static readonly long[] Value={ 1L,5L,5L,33L,13L,93L,33L,177L,29L,301L,53L,437L,73L,593L,157L,777L,129L,1025L,165L,1289L,209L,1601L,209L,1873L,277L,2221L,341L,2537L,429L,2897L,613L,3209L,649L,3693L,741L,4217L,821L,4825L,749L,5365L,801L,5993L,773L,6617L,805L,7149L,1097L,7721L,1033L,8393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270725Inst : IEnumerable<long>
{
public static readonly long[] Value=A270725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270725.Bytes);
public long this[int i]=>Value[i];

public static A270725Inst Instance=new A270725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270726
{
public static readonly long[] Value={ 1L,5L,33L,177L,777L,3209L,13245L,53929L,216265L,868153L,3473737L,13914329L,55668253L,222731725L,890919341L,3563996769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270726Inst : IEnumerable<long>
{
public static readonly long[] Value=A270726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270726.Bytes);
public long this[int i]=>Value[i];

public static A270726Inst Instance=new A270726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270727
{
public static readonly long[] Value={ 1L,6L,11L,44L,57L,150L,183L,360L,389L,690L,743L,1180L,1253L,1846L,2003L,2780L,2909L,3934L,4099L,5388L,5597L,7198L,7407L,9280L,9557L,11778L,12119L,14656L,15085L,17982L,18595L,21804L,22453L,26146L,26887L,31104L,31925L,36750L,37499L,42864L,43665L,49658L,50431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270727Inst : IEnumerable<long>
{
public static readonly long[] Value=A270727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270727.Bytes);
public long this[int i]=>Value[i];

public static A270727Inst Instance=new A270727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270728
{
public static readonly long[] Value={ 4L,0L,28L,-20L,80L,-60L,144L,-148L,272L,-248L,384L,-364L,520L,-436L,620L,-648L,896L,-860L,1124L,-1080L,1392L,-1392L,1664L,-1596L,1944L,-1880L,2196L,-2108L,2468L,-2284L,2596L,-2560L,3044L,-2952L,3476L,-3396L,4004L,-4076L,4616L,-4564L,5192L,-5220L,5844L,-5812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270728Inst : IEnumerable<long>
{
public static readonly long[] Value=A270728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270728.Bytes);
public long this[int i]=>Value[i];

public static A270728Inst Instance=new A270728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270729
{
public static readonly long[] Value={ 1L,8L,4L,40L,17L,108L,17L,200L,33L,312L,45L,488L,89L,620L,105L,892L,105L,1044L,153L,1336L,181L,1640L,228L,1961L,268L,2265L,284L,2737L,424L,3041L,376L,3596L,468L,3921L,608L,4373L,720L,4936L,821L,5536L,765L,5936L,945L,6740L,981L,7316L,1105L,8016L,1381L,8620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270729Inst : IEnumerable<long>
{
public static readonly long[] Value=A270729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270729.Bytes);
public long this[int i]=>Value[i];

public static A270729Inst Instance=new A270729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270730
{
public static readonly long[] Value={ 1L,8L,40L,200L,892L,3596L,14116L,57529L,230544L,922437L,3694432L,14776516L,59132608L,236525460L,946195840L,3784776100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270730Inst : IEnumerable<long>
{
public static readonly long[] Value=A270730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270730.Bytes);
public long this[int i]=>Value[i];

public static A270730Inst Instance=new A270730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270731
{
public static readonly long[] Value={ 1L,9L,13L,53L,70L,178L,195L,395L,428L,740L,785L,1273L,1362L,1982L,2087L,2979L,3084L,4128L,4281L,5617L,5798L,7438L,7666L,9627L,9895L,12160L,12444L,15181L,15605L,18646L,19022L,22618L,23086L,27007L,27615L,31988L,32708L,37644L,38465L,44001L,44766L,50702L,51647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270731Inst : IEnumerable<long>
{
public static readonly long[] Value=A270731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270731.Bytes);
public long this[int i]=>Value[i];

public static A270731Inst Instance=new A270731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270732
{
public static readonly long[] Value={ 7L,-4L,36L,-23L,91L,-91L,183L,-167L,279L,-267L,443L,-399L,531L,-515L,787L,-787L,939L,-891L,1183L,-1155L,1459L,-1412L,1733L,-1693L,1997L,-1981L,2453L,-2313L,2617L,-2665L,3220L,-3128L,3453L,-3313L,3765L,-3653L,4216L,-4115L,4715L,-4771L,5171L,-4991L,5795L,-5759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270732Inst : IEnumerable<long>
{
public static readonly long[] Value=A270732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270732.Bytes);
public long this[int i]=>Value[i];

public static A270732Inst Instance=new A270732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270733
{
public static readonly long[] Value={ 1L,5L,8L,20L,20L,32L,48L,64L,72L,92L,92L,116L,148L,156L,212L,260L,272L,296L,272L,296L,340L,396L,416L,436L,504L,524L,580L,668L,704L,800L,972L,1092L,1080L,1032L,1104L,1160L,1176L,1240L,1280L,1288L,1452L,1572L,1624L,1624L,1680L,1856L,2016L,2140L,2224L,2340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270733Inst : IEnumerable<long>
{
public static readonly long[] Value=A270733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270733.Bytes);
public long this[int i]=>Value[i];

public static A270733Inst Instance=new A270733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270734
{
public static readonly long[] Value={ 1L,5L,20L,64L,260L,1092L,4288L,17288L,68896L,277084L,1114676L,4460992L,17809152L,71255876L,285243920L,1140843800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270734Inst : IEnumerable<long>
{
public static readonly long[] Value=A270734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270734.Bytes);
public long this[int i]=>Value[i];

public static A270734Inst Instance=new A270734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270735
{
public static readonly long[] Value={ 1L,6L,14L,34L,54L,86L,134L,198L,270L,362L,454L,570L,718L,874L,1086L,1346L,1618L,1914L,2186L,2482L,2822L,3218L,3634L,4070L,4574L,5098L,5678L,6346L,7050L,7850L,8822L,9914L,10994L,12026L,13130L,14290L,15466L,16706L,17986L,19274L,20726L,22298L,23922L,25546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270735Inst : IEnumerable<long>
{
public static readonly long[] Value=A270735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270735.Bytes);
public long this[int i]=>Value[i];

public static A270735Inst Instance=new A270735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270736
{
public static readonly long[] Value={ 4L,3L,12L,0L,12L,16L,16L,8L,20L,0L,24L,32L,8L,56L,48L,12L,24L,-24L,24L,44L,56L,20L,20L,68L,20L,56L,88L,36L,96L,172L,120L,-12L,-48L,72L,56L,16L,64L,40L,8L,164L,120L,52L,0L,56L,176L,160L,124L,84L,116L,36L,128L,36L,100L,36L,88L,244L,148L,100L,140L,108L,156L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270736Inst : IEnumerable<long>
{
public static readonly long[] Value=A270736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270736.Bytes);
public long this[int i]=>Value[i];

public static A270736Inst Instance=new A270736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270737
{
public static readonly long[] Value={ 1L,3L,5L,10L,20L,42L,91L,195L,415L,880L,1864L,3952L,8385L,17795L,37765L,80138L,170044L,360810L,765595L,1624515L,3447071L,7314368L,15520400L,32932800L,69880225L,148279107L,314634021L,667623210L,1416632420L,3005958090L,6378354619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270737Inst : IEnumerable<long>
{
public static readonly long[] Value=A270737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270737.Bytes);
public long this[int i]=>Value[i];

public static A270737Inst Instance=new A270737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270738
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,12L,18L,19L,30L,65L,77L,126L,353L,541L,576L,723L,777L,1024L,1194L,1507L,2379L,2615L,4008L,4295L,4495L,4526L,9996L,10348L,10673L,14120L,22350L,70240L,93116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270738Inst : IEnumerable<long>
{
public static readonly long[] Value=A270738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270738.Bytes);
public long this[int i]=>Value[i];

public static A270738Inst Instance=new A270738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270739
{
public static readonly long[] Value={ 8L,25L,32L,125L,128L,169L,289L,512L,625L,841L,1369L,1681L,2048L,2197L,2809L,3125L,3721L,4913L,5329L,7921L,8192L,9409L,10201L,11881L,12769L,15625L,18769L,22201L,24389L,24649L,28561L,29929L,32761L,32768L,37249L,38809L,50653L,52441L,54289L,58081L,66049L,68921L,72361L,76729L,78125L,78961L,83521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270739Inst : IEnumerable<long>
{
public static readonly long[] Value=A270739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270739.Bytes);
public long this[int i]=>Value[i];

public static A270739Inst Instance=new A270739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270740
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L,0L,1L,2L,2L,0L,1L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270740Inst : IEnumerable<long>
{
public static readonly long[] Value=A270740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270740.Bytes);
public long this[int i]=>Value[i];

public static A270740Inst Instance=new A270740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270741
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,3L,2L,0L,1L,11L,10L,0L,1L,32L,31L,0L,1L,87L,86L,0L,1L,231L,230L,0L,1L,608L,607L,0L,1L,1595L,1594L,0L,1L,4179L,4178L,0L,1L,10944L,10943L,0L,1L,28655L,28654L,0L,1L,75023L,75022L,0L,1L,196416L,196415L,0L,1L,514227L,514226L,0L,1L,1346267L,1346266L,0L,1L,3524576L,3524575L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270741Inst : IEnumerable<long>
{
public static readonly long[] Value=A270741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270741.Bytes);
public long this[int i]=>Value[i];

public static A270741Inst Instance=new A270741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270742
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270742Inst : IEnumerable<long>
{
public static readonly long[] Value=A270742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270742.Bytes);
public long this[int i]=>Value[i];

public static A270742Inst Instance=new A270742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270743
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,1L,3L,6L,1L,4L,8L,1L,5L,10L,1L,6L,12L,1L,7L,14L,1L,8L,16L,1L,9L,18L,1L,10L,20L,1L,11L,22L,1L,12L,24L,1L,13L,26L,1L,14L,28L,1L,15L,30L,1L,16L,32L,1L,17L,34L,1L,18L,36L,1L,19L,38L,1L,20L,40L,1L,21L,42L,1L,22L,44L,1L,23L,46L,1L,24L,48L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270743Inst : IEnumerable<long>
{
public static readonly long[] Value=A270743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270743.Bytes);
public long this[int i]=>Value[i];

public static A270743Inst Instance=new A270743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270744
{
public static readonly BigInteger[] Value={ 1L,2L,2L,3L,4L,32L,1065L,2038968L,5977146319204L,BigInteger.Parse("36314862033946243071181679"),BigInteger.Parse("1028280647188781709727717632740627249617427013751977"),BigInteger.Parse("958046899855070460620234639622630375078362220775180051610386376308132568342498992099474472596860400289") };
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
public class A270744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270744Inst Instance=new A270744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270745
{
public static readonly BigInteger[] Value={ 1L,3L,6L,63L,18292L,822680526L,810795400558456607L,BigInteger.Parse("3059608561526409532580548135921262544"),BigInteger.Parse("41330361304323764432512049819825720283867354602583921458622085452146872094") };
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
public class A270745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270745Inst Instance=new A270745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270746
{
public static readonly BigInteger[] Value={ 1L,2L,1L,2L,2L,2L,2L,1L,2L,1L,15L,107L,4536L,9767531L,119608113171152L,BigInteger.Parse("27706455600364135685442345886"),BigInteger.Parse("683882728856994887705617234665700899371621018916716222985") };
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
public class A270746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270746Inst Instance=new A270746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270747
{
public static readonly BigInteger[] Value={ 2L,2L,1L,2L,2L,1L,3L,7L,71L,3131L,5821925L,14364035515947L,BigInteger.Parse("451397201144015321568515204"),BigInteger.Parse("88020328073777548345010277436911545872870466008026310"),BigInteger.Parse("4344173888544359227731947461270153179826227998155726069662805370800638822815760136590246135744249701337368") };
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
public class A270747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270747Inst Instance=new A270747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270748
{
public static readonly BigInteger[] Value={ 3L,48L,5215L,43930979L,8221176288381971L,BigInteger.Parse("237472642129791861355082716048930"),BigInteger.Parse("59916111345562665920456160598356741759066440491193682529746704653") };
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
public class A270748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270748Inst Instance=new A270748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270749
{
public static readonly BigInteger[] Value={ 2L,7L,117L,28231L,934841727L,1391154929853413822L,BigInteger.Parse("3358221400639080017571595039208647108"),BigInteger.Parse("84149630763494298099512446622134485046922136023978562834130778814722933257") };
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
public class A270749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270749Inst Instance=new A270749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270750
{
public static readonly BigInteger[] Value={ 2L,2L,5L,52L,7132L,657650603L,642344866115572775L,BigInteger.Parse("833790618410287382945149122154404558"),BigInteger.Parse("1229679779588111283437146138551802288646488858072438842199407751052675116") };
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
public class A270750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270750Inst Instance=new A270750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270751
{
public static readonly BigInteger[] Value={ 1L,1L,3L,37L,1204L,21029921L,425355555167420L,BigInteger.Parse("439183524292095499600664584581"),BigInteger.Parse("240317442633783387248198509182959563857071128274317237128901") };
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
public class A270751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270751Inst Instance=new A270751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270752
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,262L,167395L,42355398928L,BigInteger.Parse("2986137074379747535250"),BigInteger.Parse("16334453331070842795541380956715272941358931"),BigInteger.Parse("334377619479874433401339085661668551899899040409749812309411639875183486098285324762070") };
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
public class A270752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270752Inst Instance=new A270752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270753
{
public static readonly long[] Value={ 5L,3L,3L,5L,5L,7L,7L,11L,11L,11L,11L,13L,13L,17L,17L,17L,17L,19L,19L,23L,23L,23L,23L,29L,29L,29L,29L,29L,29L,31L,31L,37L,37L,37L,37L,37L,37L,41L,41L,41L,41L,43L,43L,47L,47L,47L,47L,53L,53L,53L,53L,53L,53L,59L,59L,59L,59L,59L,59L,61L,61L,67L,67L,67L,67L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270753Inst : IEnumerable<long>
{
public static readonly long[] Value=A270753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270753.Bytes);
public long this[int i]=>Value[i];

public static A270753Inst Instance=new A270753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270754
{
public static readonly long[] Value={ 90438L,258918L,293862L,385740L,426162L,532950L,1073952L,1317192L,1318410L,1401318L,1565382L,1894338L,1986168L,2174772L,2612790L,2764788L,3390900L,3450048L,3618960L,3797250L,3961722L,3973062L,4074870L,4306230L,4648068L,4917360L,5351010L,5460492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270754Inst : IEnumerable<long>
{
public static readonly long[] Value=A270754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270754.Bytes);
public long this[int i]=>Value[i];

public static A270754Inst Instance=new A270754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270755
{
public static readonly long[] Value={ 1L,0L,2L,1L,3L,2L,3L,2L,2L,1L,6L,5L,7L,6L,3L,8L,8L,1L,8L,2L,11L,10L,12L,11L,3L,10L,4L,23L,5L,17L,13L,18L,14L,19L,15L,20L,16L,21L,17L,9L,31L,10L,16L,6L,30L,15L,11L,23L,20L,13L,19L,17L,13L,3L,29L,26L,30L,12L,35L,24L,36L,25L,37L,26L,8L,46L,20L,18L,36L,8L,5L,42L,30L,16L,31L,34L,42L,5L,7L,66L,14L,48L,34L,49L,35L,26L,30L,14L,7L,10L,48L,9L,52L,41L,53L,42L,19L,63L,35L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270755Inst : IEnumerable<long>
{
public static readonly long[] Value=A270755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270755.Bytes);
public long this[int i]=>Value[i];

public static A270755Inst Instance=new A270755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270788
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270788Inst : IEnumerable<long>
{
public static readonly long[] Value=A270788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270788.Bytes);
public long this[int i]=>Value[i];

public static A270788Inst Instance=new A270788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270789
{
public static readonly long[] Value={ 1L,3L,10L,37L,151L,657L,2989L,14044L,67626L,332061L,1656893L,8379773L,42871890L,221528317L,1154624725L,6063752579L,32058277129L,170492969062L,911505351447L,4896187116904L,26411691702030L,143019573086693L,777143219649275L,4236216759058815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270789Inst : IEnumerable<long>
{
public static readonly long[] Value=A270789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270789.Bytes);
public long this[int i]=>Value[i];

public static A270789Inst Instance=new A270789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270790
{
public static readonly BigInteger[] Value={ 1L,21L,11L,143L,88179L,111435L,111435L,1361270295L,1137235L,9945637L,16009448637L,19293438101L,3607872924887L,2630885818709841L,195084537038811L,45500599374052095L,BigInteger.Parse("1472444896343699846295"),1997334750675075735L,BigInteger.Parse("145805436799280528655"),BigInteger.Parse("107268833547674677179") };
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
public class A270790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270790Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270790.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270790.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270790Inst Instance=new A270790Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270791
{
public static readonly long[] Value={ 1L,1L,1L,158L,558L,135L,2339L,18378L,13689L,1575L,1354L,18908L,28764L,9660L,675L,617926L,13447818L,34604118L,23001156L,4534875L,218295L,525206428L,16383145284L,63886133214L,70424606988L,26926791930L,3567422250L,127702575L,50531787L,2134308548L,11735772822L,19350632598L,12106771137L,3063221550L,295973325L,8292375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270791Inst : IEnumerable<long>
{
public static readonly long[] Value=A270791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270791.Bytes);
public long this[int i]=>Value[i];

public static A270791Inst Instance=new A270791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270792
{
public static readonly long[] Value={ 7L,13L,23L,37L,61L,73L,101L,107L,139L,181L,197L,239L,269L,281L,313L,373L,419L,433L,467L,499L,521L,577L,613L,653L,719L,751L,761L,811L,823L,853L,977L,1013L,1051L,1069L,1163L,1187L,1237L,1289L,1307L,1373L,1439L,1453L,1549L,1559L,1583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270792Inst : IEnumerable<long>
{
public static readonly long[] Value=A270792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270792.Bytes);
public long this[int i]=>Value[i];

public static A270792Inst Instance=new A270792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270793
{
public static readonly long[] Value={ 3L,5L,23L,-15L,75L,-55L,139L,-115L,239L,-231L,367L,-299L,443L,-427L,691L,-683L,867L,-775L,1031L,-1011L,1347L,-1291L,1595L,-1511L,1891L,-1815L,2127L,-2087L,2511L,-2419L,2811L,-2783L,3355L,-3231L,3591L,-3519L,4047L,-3831L,4315L,-4387L,5107L,-4991L,5583L,-5547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270793Inst : IEnumerable<long>
{
public static readonly long[] Value=A270793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270793.Bytes);
public long this[int i]=>Value[i];

public static A270793Inst Instance=new A270793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270794
{
public static readonly long[] Value={ 6L,9L,18L,26L,45L,57L,81L,91L,112L,143L,165L,203L,228L,244L,267L,303L,345L,354L,411L,437L,454L,495L,530L,564L,623L,668L,687L,714L,728L,749L,856L,893L,931L,959L,1032L,1054L,1104L,1158L,1185L,1233L,1268L,1298L,1372L,1392L,1425L,1445L,1539L,1672L,1698L,1714L,1742L,1773L,1802L,1886L,1914L,1966L,2031L,2050L,2104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270794Inst : IEnumerable<long>
{
public static readonly long[] Value=A270794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270794.Bytes);
public long this[int i]=>Value[i];

public static A270794Inst Instance=new A270794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270795
{
public static readonly long[] Value={ 4L,12L,21L,28L,34L,42L,52L,60L,65L,74L,84L,95L,98L,106L,119L,128L,133L,135L,141L,147L,170L,177L,180L,192L,195L,209L,214L,220L,231L,246L,250L,253L,284L,288L,290L,295L,301L,316L,323L,329L,336L,339L,351L,365L,382L,387L,390L,394L,417L,429L,432L,445L,462L,470L,474L,481L,490L,505L,516L,518L,532L,538L,543L,550L,559L,566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270795Inst : IEnumerable<long>
{
public static readonly long[] Value=A270795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270795.Bytes);
public long this[int i]=>Value[i];

public static A270795Inst Instance=new A270795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270796
{
public static readonly long[] Value={ 8L,10L,15L,20L,27L,32L,38L,40L,49L,58L,63L,72L,78L,82L,88L,99L,110L,114L,121L,125L,129L,140L,146L,155L,166L,172L,175L,183L,185L,189L,212L,217L,225L,230L,245L,248L,258L,265L,272L,279L,289L,292L,306L,309L,315L,319L,334L,355L,360L,362L,368L,375L,377L,393L,402L,408L,416L,420L,427L,435L,438L,452L,473L,478L,482L,486L,507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270796Inst : IEnumerable<long>
{
public static readonly long[] Value=A270796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270796.Bytes);
public long this[int i]=>Value[i];

public static A270796Inst Instance=new A270796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270797
{
public static readonly long[] Value={ 0L,1L,4L,3L,20L,11L,84L,43L,340L,171L,1364L,683L,5460L,2731L,21844L,10923L,87380L,43691L,349524L,174763L,1398100L,699051L,5592404L,2796203L,22369620L,11184811L,89478484L,44739243L,357913940L,178956971L,1431655764L,715827883L,5726623060L,2863311531L,22906492244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270797Inst : IEnumerable<long>
{
public static readonly long[] Value=A270797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270797.Bytes);
public long this[int i]=>Value[i];

public static A270797Inst Instance=new A270797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270798
{
public static readonly long[] Value={ 5281L,5591L,6211L,6271L,8581L,8861L,9011L,9661L,10391L,10691L,11621L,12011L,12911L,13451L,15901L,19001L,19801L,20521L,20921L,21481L,21701L,22901L,22921L,23371L,26141L,27241L,27481L,28001L,28711L,29131L,30971L,31321L,31511L,32341L,32381L,34211L,38261L,38611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270798Inst : IEnumerable<long>
{
public static readonly long[] Value=A270798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270798.Bytes);
public long this[int i]=>Value[i];

public static A270798Inst Instance=new A270798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270799
{
public static readonly long[] Value={ 3251L,4751L,14251L,17401L,21401L,27551L,32051L,32251L,36151L,36451L,42451L,51001L,52501L,54101L,55001L,56501L,59051L,60101L,61051L,83401L,104801L,113051L,116101L,119851L,121351L,170701L,174901L,178501L,178601L,179051L,182101L,185951L,190301L,202751L,213901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270799Inst : IEnumerable<long>
{
public static readonly long[] Value=A270799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270799.Bytes);
public long this[int i]=>Value[i];

public static A270799Inst Instance=new A270799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270800
{
public static readonly long[] Value={ 14197L,21617L,23801L,24977L,25999L,34763L,37549L,41959L,42407L,45053L,45599L,54713L,55987L,56099L,60271L,61657L,63463L,66067L,72577L,75307L,76343L,76777L,79283L,83357L,88397L,90469L,91309L,99611L,107927L,111217L,111301L,111791L,124699L,126127L,131251L,132287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270800Inst : IEnumerable<long>
{
public static readonly long[] Value=A270800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270800.Bytes);
public long this[int i]=>Value[i];

public static A270800Inst Instance=new A270800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270801
{
public static readonly long[] Value={ 665897L,741413L,794207L,859601L,876611L,892627L,980911L,1102249L,1116977L,1123879L,1129213L,1163653L,1228543L,1237139L,1393771L,1434553L,1453019L,1471079L,1513163L,1570577L,1588133L,1608769L,1638211L,1638743L,1645253L,1670887L,1702933L,1704137L,1785337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270801Inst : IEnumerable<long>
{
public static readonly long[] Value=A270801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270801.Bytes);
public long this[int i]=>Value[i];

public static A270801Inst Instance=new A270801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270802
{
public static readonly long[] Value={ 631L,673L,953L,1163L,1709L,2003L,2143L,2731L,2857L,3109L,3389L,3739L,4271L,4999L,5237L,5279L,5531L,5867L,6553L,6679L,6959L,7001L,7309L,7351L,7393L,8191L,8681L,9157L,9829L,10627L,10739L,11117L,11243L,11299L,11411L,11467L,13007L,13259L,15121L,15233L,15583L,16073L,18439L,18803L,20063L,20147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270802Inst : IEnumerable<long>
{
public static readonly long[] Value=A270802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270802.Bytes);
public long this[int i]=>Value[i];

public static A270802Inst Instance=new A270802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270803
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270803Inst : IEnumerable<long>
{
public static readonly long[] Value=A270803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270803.Bytes);
public long this[int i]=>Value[i];

public static A270803Inst Instance=new A270803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270820
{
public static readonly long[] Value={ 343L,12167L,16807L,29791L,103823L,357911L,493039L,823543L,1092727L,2048383L,3442951L,4657463L,6436343L,6967871L,7880599L,11089567L,13651919L,18191447L,19902511L,28629151L,30080231L,40353607L,46268279L,49430863L,56181887L,80062991L,84604519L,99252847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270820Inst : IEnumerable<long>
{
public static readonly long[] Value=A270820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270820.Bytes);
public long this[int i]=>Value[i];

public static A270820Inst Instance=new A270820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270821
{
public static readonly long[] Value={ 6L,8L,16L,26L,28L,76L,148L,159L,808L,848L,916L,1143L,4036L,4959L,43239L,73432L,98716L,144039L,146132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270821Inst : IEnumerable<long>
{
public static readonly long[] Value=A270821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270821.Bytes);
public long this[int i]=>Value[i];

public static A270821Inst Instance=new A270821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270822
{
public static readonly long[] Value={ 1L,2L,10L,24L,86L,224L,708L,1920L,5734L,15872L,46124L,129024L,369916L,1040384L,2962760L,8355840L,23714950L,66977792L,189768220L,536346624L,1518330516L,4292870144L,12147349560L,34351349760L,97181500636L,274844352512L,777462405688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270822Inst : IEnumerable<long>
{
public static readonly long[] Value=A270822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270822.Bytes);
public long this[int i]=>Value[i];

public static A270822Inst Instance=new A270822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270823
{
public static readonly long[] Value={ 0L,2L,3L,1L,1L,3L,2L,0L,1L,3L,2L,0L,0L,2L,3L,1L,0L,2L,3L,1L,1L,3L,2L,0L,1L,3L,2L,0L,0L,2L,3L,1L,0L,2L,3L,1L,1L,3L,2L,0L,1L,3L,2L,0L,0L,2L,3L,1L,0L,2L,3L,1L,1L,3L,2L,0L,1L,3L,2L,0L,0L,2L,3L,1L,0L,2L,3L,1L,1L,3L,2L,0L,1L,3L,2L,0L,0L,2L,3L,1L,0L,2L,3L,1L,1L,3L,2L,0L,1L,3L,2L,0L,0L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270823Inst : IEnumerable<long>
{
public static readonly long[] Value=A270823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270823.Bytes);
public long this[int i]=>Value[i];

public static A270823Inst Instance=new A270823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270824
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,3L,3L,2L,3L,2L,2L,3L,1L,0L,0L,1L,0L,1L,1L,0L,2L,3L,3L,2L,3L,2L,2L,3L,1L,0L,0L,1L,0L,1L,1L,0L,2L,3L,3L,2L,3L,2L,2L,3L,1L,0L,0L,1L,0L,1L,1L,0L,2L,3L,3L,2L,3L,2L,2L,3L,1L,0L,0L,1L,0L,1L,1L,0L,2L,3L,3L,2L,3L,2L,2L,3L,1L,0L,0L,1L,0L,1L,1L,0L,2L,3L,3L,2L,3L,2L,2L,3L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270824Inst : IEnumerable<long>
{
public static readonly long[] Value=A270824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270824.Bytes);
public long this[int i]=>Value[i];

public static A270824Inst Instance=new A270824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270825
{
public static readonly long[] Value={ 0L,1L,0L,-1L,1L,3L,1L,-1L,1L,4L,1L,-2L,1L,4L,1L,-2L,2L,6L,2L,-2L,2L,6L,2L,-2L,2L,7L,2L,-3L,2L,7L,2L,-3L,2L,7L,2L,-3L,3L,9L,3L,-3L,3L,9L,3L,-3L,3L,9L,3L,-3L,3L,10L,3L,-4L,3L,10L,3L,-4L,3L,10L,3L,-4L,3L,10L,3L,-4L,4L,12L,4L,-4L,4L,12L,4L,-4L,4L,12L,4L,-4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270825Inst : IEnumerable<long>
{
public static readonly long[] Value=A270825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270825.Bytes);
public long this[int i]=>Value[i];

public static A270825Inst Instance=new A270825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270826
{
public static readonly long[] Value={ 0L,2L,2L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270826Inst : IEnumerable<long>
{
public static readonly long[] Value=A270826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270826.Bytes);
public long this[int i]=>Value[i];

public static A270826Inst Instance=new A270826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270827
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,3L,4L,1L,3L,6L,4L,5L,6L,5L,11L,8L,8L,3L,5L,4L,8L,16L,4L,7L,10L,5L,22L,3L,13L,23L,10L,4L,4L,20L,5L,12L,12L,8L,3L,9L,22L,9L,3L,11L,25L,4L,8L,6L,14L,14L,9L,38L,4L,31L,32L,5L,14L,18L,4L,3L,19L,8L,56L,16L,16L,28L,25L,22L,31L,50L,7L,19L,11L,10L,43L,46L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270827Inst : IEnumerable<long>
{
public static readonly long[] Value=A270827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270827.Bytes);
public long this[int i]=>Value[i];

public static A270827Inst Instance=new A270827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270828
{
public static readonly long[] Value={ 0L,1L,3L,2L,1L,4L,0L,5L,3L,17L,30L,23L,35L,17L,23L,24L,41L,19L,38L,3L,54L,4L,44L,77L,38L,98L,62L,25L,3L,73L,108L,67L,27L,124L,108L,66L,34L,4L,130L,102L,80L,40L,32L,169L,132L,78L,79L,128L,75L,5L,215L,227L,189L,243L,255L,259L,261L,193L,197L,162L,98L,148L,9L,281L,213L,194L,87L,109L,261L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270828Inst : IEnumerable<long>
{
public static readonly long[] Value=A270828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270828.Bytes);
public long this[int i]=>Value[i];

public static A270828Inst Instance=new A270828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270829
{
public static readonly long[] Value={ 2L,0L,65573L,124L,313L,484L,797L,2016L,2211L,2862L,4507L,6188L,6325L,9660L,12669L,13016L,16857L,19530L,23069L,28184L,38761L,46302L,42515L,49846L,59087L,70260L,73385L,78960L,97267L,98316L,111023L,124454L,134641L,152952L,163043L,180596L,195975L,218432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270829Inst : IEnumerable<long>
{
public static readonly long[] Value=A270829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270829.Bytes);
public long this[int i]=>Value[i];

public static A270829Inst Instance=new A270829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270830
{
public static readonly long[] Value={ 2L,0L,21821L,5L,13L,7L,7L,79L,37L,23L,67L,89L,13L,89L,131L,31L,71L,47L,43L,73L,277L,353L,41L,67L,127L,223L,79L,13L,193L,5L,23L,43L,5L,67L,3L,19L,5L,59L,59L,653L,19L,19L,97L,409L,5L,383L,29L,137L,379L,349L,653L,1187L,47L,41L,37L,17L,619L,89L,283L,283L,43L,479L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270830Inst : IEnumerable<long>
{
public static readonly long[] Value=A270830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270830.Bytes);
public long this[int i]=>Value[i];

public static A270830Inst Instance=new A270830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270831
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,23L,29L,37L,39L,40L,89L,115L,189L,227L,253L,301L,449L,533L,607L,969L,1036L,1207L,1407L,1701L,3493L,7147L,11342L,21638L,22327L,25575L,25648L,34079L,39974L,47719L,49913L,74729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270831Inst : IEnumerable<long>
{
public static readonly long[] Value=A270831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270831.Bytes);
public long this[int i]=>Value[i];

public static A270831Inst Instance=new A270831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270832
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,3L,4L,4L,5L,5L,8L,7L,9L,9L,11L,10L,12L,12L,16L,14L,16L,16L,18L,17L,19L,19L,22L,22L,24L,23L,25L,24L,27L,27L,30L,27L,30L,32L,34L,32L,35L,34L,36L,37L,38L,38L,41L,39L,42L,41L,45L,45L,48L,47L,48L,48L,49L,51L,53L,48L,53L,54L,55L,53L,57L,58L,60L,60L,63L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270832Inst : IEnumerable<long>
{
public static readonly long[] Value=A270832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270832.Bytes);
public long this[int i]=>Value[i];

public static A270832Inst Instance=new A270832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270833
{
public static readonly long[] Value={ 1093L,3511L,1194649L,3837523L,12327121L,1305751357L,4194412639L,13473543253L,43280521831L,1427186233201L,4584493014427L,14726582775529L,47305610361283L,151957912148641L,5010850864768711L,16096154973653197L,51705032124882319L,166089997978464613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270833Inst : IEnumerable<long>
{
public static readonly long[] Value=A270833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270833.Bytes);
public long this[int i]=>Value[i];

public static A270833Inst Instance=new A270833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270834
{
public static readonly long[] Value={ 3L,7L,9L,11L,19L,23L,31L,43L,47L,67L,71L,83L,107L,127L,131L,139L,151L,163L,167L,191L,211L,263L,271L,283L,307L,311L,331L,347L,359L,367L,383L,431L,439L,463L,467L,479L,491L,499L,503L,523L,547L,563L,571L,587L,619L,631L,647L,659L,691L,719L,727L,739L,743L,787L,811L,823L,839L,859L,863L,883L,887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270834Inst : IEnumerable<long>
{
public static readonly long[] Value=A270834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270834.Bytes);
public long this[int i]=>Value[i];

public static A270834Inst Instance=new A270834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270835
{
public static readonly long[] Value={ 4L,6L,12L,8L,16L,24L,10L,20L,30L,12L,24L,40L,36L,14L,48L,28L,42L,60L,16L,32L,48L,70L,64L,18L,36L,80L,54L,72L,96L,20L,40L,90L,60L,112L,80L,108L,22L,44L,66L,120L,88L,24L,110L,48L,140L,72L,132L,96L,160L,120L,26L,52L,78L,144L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270835Inst : IEnumerable<long>
{
public static readonly long[] Value=A270835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270835.Bytes);
public long this[int i]=>Value[i];

public static A270835Inst Instance=new A270835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270852
{
public static readonly long[] Value={ 0L,0L,30L,270L,1650L,7344L,24954L,68838L,164454L,347916L,677130L,1219626L,2083038L,3373728L,5268642L,7918158L,11590422L,16482708L,22978554L,31322706L,42040590L,55422696L,72165138L,92600118L,117625542L,147608988L,183683562L,226243578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270852Inst : IEnumerable<long>
{
public static readonly long[] Value=A270852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270852.Bytes);
public long this[int i]=>Value[i];

public static A270852Inst Instance=new A270852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270853
{
public static readonly long[] Value={ 0L,0L,252L,6822L,108348L,1144464L,8559378L,49511370L,225803628L,868915644L,2866094766L,8402366160L,22207133946L,53934812124L,121777854570L,258248878044L,519141258054L,994719606876L,1830153826026L,3242675095548L,5566018125510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270853Inst : IEnumerable<long>
{
public static readonly long[] Value=A270853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270853.Bytes);
public long this[int i]=>Value[i];

public static A270853Inst Instance=new A270853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270854
{
public static readonly long[] Value={ 0L,0L,2298L,307494L,15754872L,469037376L,8746813158L,121991495904L,1213829981232L,9734824653450L,61574400558324L,331178241244350L,1508910046819356L,6093153192888900L,21845378487998154L,71477509051004274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270854Inst : IEnumerable<long>
{
public static readonly long[] Value=A270854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270854.Bytes);
public long this[int i]=>Value[i];

public static A270854Inst Instance=new A270854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270855
{
public static readonly BigInteger[] Value={ 0L,0L,28440L,27582438L,5805948474L,571228600932L,29999932959600L,1131964246928502L,27738553460278170L,526704152938743948L,7209576736148583840L,BigInteger.Parse("80085435443327098104"),BigInteger.Parse("700902167873486650002") };
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
public class A270855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270855Inst Instance=new A270855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270856
{
public static readonly BigInteger[] Value={ 0L,0L,460494L,4875050400L,5281372355106L,2104222937252028L,358240737864481086L,BigInteger.Parse("41234776662339168204"),BigInteger.Parse("2798233542174582927894"),BigInteger.Parse("142439611138184581460718") };
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
public class A270856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A270856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A270856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A270856Inst Instance=new A270856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270857
{
public static readonly long[] Value={ 4L,8L,2L,6L,4L,4L,2L,2L,1L,6L,2L,0L,4L,6L,2L,6L,1L,2L,3L,7L,9L,4L,2L,8L,3L,9L,1L,1L,4L,8L,5L,7L,5L,7L,7L,3L,9L,7L,0L,1L,2L,0L,3L,9L,6L,2L,7L,5L,6L,6L,5L,6L,7L,0L,5L,0L,2L,3L,0L,1L,6L,5L,1L,6L,2L,9L,5L,1L,5L,8L,0L,9L,1L,0L,7L,1L,8L,2L,0L,0L,9L,7L,6L,2L,4L,3L,0L,1L,7L,9L,5L,1L,1L,6L,5L,3L,4L,3L,0L,1L,5L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270857Inst : IEnumerable<long>
{
public static readonly long[] Value=A270857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270857.Bytes);
public long this[int i]=>Value[i];

public static A270857Inst Instance=new A270857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270858
{
public static readonly long[] Value={ 0L,1L,14L,1446L,705366L,1304451482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270858Inst : IEnumerable<long>
{
public static readonly long[] Value=A270858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270858.Bytes);
public long this[int i]=>Value[i];

public static A270858Inst Instance=new A270858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270859
{
public static readonly long[] Value={ 5L,2L,9L,0L,5L,2L,9L,6L,9L,9L,4L,0L,4L,3L,9L,0L,2L,4L,0L,7L,2L,2L,9L,3L,9L,3L,9L,4L,7L,5L,5L,8L,9L,7L,2L,8L,0L,9L,4L,0L,3L,8L,1L,7L,1L,6L,9L,5L,9L,6L,2L,5L,6L,9L,0L,8L,6L,1L,7L,1L,8L,2L,8L,0L,9L,7L,2L,7L,7L,7L,2L,2L,9L,6L,8L,5L,1L,1L,3L,4L,8L,0L,0L,6L,5L,2L,0L,7L,2L,8L,9L,1L,1L,3L,2L,5L,5L,9L,9L,6L,4L,0L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270859Inst : IEnumerable<long>
{
public static readonly long[] Value=A270859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270859.Bytes);
public long this[int i]=>Value[i];

public static A270859Inst Instance=new A270859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270860
{
public static readonly long[] Value={ 35L,165L,6545L,179998L,7509579L,850253030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270860Inst : IEnumerable<long>
{
public static readonly long[] Value=A270860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270860.Bytes);
public long this[int i]=>Value[i];

public static A270860Inst Instance=new A270860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270861
{
public static readonly long[] Value={ 3L,1L,8L,7L,2L,1L,15L,7L,13L,3L,1L,1L,24L,23L,22L,21L,4L,3L,2L,1L,35L,17L,11L,8L,31L,5L,2L,1L,1L,1L,48L,47L,46L,45L,44L,43L,6L,5L,4L,3L,2L,1L,63L,31L,61L,15L,59L,29L,57L,7L,3L,5L,1L,3L,1L,1L,80L,79L,26L,77L,76L,25L,74L,73L,8L,7L,2L,5L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270861Inst : IEnumerable<long>
{
public static readonly long[] Value=A270861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270861.Bytes);
public long this[int i]=>Value[i];

public static A270861Inst Instance=new A270861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270862
{
public static readonly long[] Value={ 1L,2L,9L,88L,1103L,17570L,295506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270862Inst : IEnumerable<long>
{
public static readonly long[] Value=A270862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270862.Bytes);
public long this[int i]=>Value[i];

public static A270862Inst Instance=new A270862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270863
{
public static readonly long[] Value={ 0L,1L,2L,6L,17L,50L,147L,434L,1282L,3789L,11200L,33109L,97878L,289354L,855413L,2528850L,7476023L,22101326L,65338038L,193158521L,571033600L,1688143881L,4990651642L,14753839486L,43616704857L,128943855250L,381196100507L,1126928202714L,3331532438042L,9848993360069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270863Inst : IEnumerable<long>
{
public static readonly long[] Value=A270863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270863.Bytes);
public long this[int i]=>Value[i];

public static A270863Inst Instance=new A270863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A270864
{
public static readonly long[] Value={ 124L,204L,240L,258L,276L,328L,348L,468L,1764L,1812L,2556L,3354L,5118L,5768L,5940L,8160L,8574L,11298L,16230L,16932L,19896L,23364L,24202L,32778L,37452L,37668L,39582L,44070L,44226L,45146L,50478L,51838L,58522L,65718L,72438L,84630L,86418L,86562L,103862L,105646L,114076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A270864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A270864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A270864Inst : IEnumerable<long>
{
public static readonly long[] Value=A270864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A270864.Bytes);
public long this[int i]=>Value[i];

public static A270864Inst Instance=new A270864Inst();

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