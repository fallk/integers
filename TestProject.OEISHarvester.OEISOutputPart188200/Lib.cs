using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A218657
{
public static readonly long[] Value={ 3L,15L,57L,225L,891L,3519L,13905L,54945L,217107L,857871L,3389769L,13394241L,52925643L,209128959L,826346529L,3265203393L,12902036643L,50980759695L,201443999193L,795980386593L,3145215436443L,12427919466687L,49107345869169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218657Inst : IEnumerable<long>
{
public static readonly long[] Value=A218657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218657.Bytes);
public long this[int i]=>Value[i];

public static A218657Inst Instance=new A218657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218658
{
public static readonly long[] Value={ 5L,57L,417L,3249L,25533L,199489L,1560161L,12202673L,95434773L,746388537L,5837454753L,45654295713L,357058903853L,2792531543489L,21840184444225L,170810481722657L,1335896257560101L,10447946710663673L,81712625405191841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218658Inst : IEnumerable<long>
{
public static readonly long[] Value=A218658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218658.Bytes);
public long this[int i]=>Value[i];

public static A218658Inst Instance=new A218658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218659
{
public static readonly ulong[] Value={ 9L,225L,3249L,50625L,793881L,12383361L,193349025L,3018953025L,47135449449L,735942652641L,11490533873361L,179405691966081L,2801123686963449L,43734921492423681L,682848585990347841L,10661553197658712449UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218659Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A218659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218659.Bytes);
public ulong this[int i]=>Value[i];

public static A218659Inst Instance=new A218659Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218660
{
public static readonly BigInteger[] Value={ 17L,891L,25533L,793881L,24879489L,775176415L,24176619049L,754066017977L,23517838102321L,733484062428443L,22876204302519509L,713472099034206097L,BigInteger.Parse("22252052902297965073"),BigInteger.Parse("694005913498881446047"),BigInteger.Parse("21644933495864588983569") };
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
public class A218660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218660.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218660Inst Instance=new A218660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218661
{
public static readonly BigInteger[] Value={ 31L,3519L,199489L,12383361L,775176415L,48231228511L,3004025019009L,187110346460865L,11653760352498463L,725837910289490239L,BigInteger.Parse("45207782461323582145"),BigInteger.Parse("2815700819921566341313"),BigInteger.Parse("175371845132587985115103") };
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
public class A218661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218661.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218661Inst Instance=new A218661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218662
{
public static readonly BigInteger[] Value={ 57L,13905L,1560161L,193349025L,24176619049L,3004025019009L,373654052856545L,46478887982679329L,5781165979795708377L,BigInteger.Parse("719085383719049449649"),BigInteger.Parse("89442819441859188818049"),BigInteger.Parse("11125261930001197817552385") };
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
public class A218662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218662Inst Instance=new A218662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218663
{
public static readonly long[] Value={ 1L,3L,3L,5L,15L,5L,9L,57L,57L,9L,17L,225L,417L,225L,17L,31L,891L,3249L,3249L,891L,31L,57L,3519L,25533L,50625L,25533L,3519L,57L,105L,13905L,199489L,793881L,793881L,199489L,13905L,105L,193L,54945L,1560161L,12383361L,24879489L,12383361L,1560161L,54945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218663Inst : IEnumerable<long>
{
public static readonly long[] Value=A218663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218663.Bytes);
public long this[int i]=>Value[i];

public static A218663Inst Instance=new A218663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218664
{
public static readonly long[] Value={ 1L,1L,-2L,-1L,1L,4L,3L,-1L,1L,7L,14L,7L,1L,10L,31L,29L,1L,13L,54L,71L,1L,16L,83L,139L,1L,19L,118L,239L,1L,22L,159L,377L,1L,25L,206L,559L,1L,28L,259L,791L,1L,31L,318L,1079L,1L,34L,383L,1429L,1L,37L,454L,1847L,1L,40L,531L,2339L,1L,43L,614L,2911L,1L,46L,703L,3569L,1L,49L,798L,4319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218664Inst : IEnumerable<long>
{
public static readonly long[] Value=A218664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218664.Bytes);
public long this[int i]=>Value[i];

public static A218664Inst Instance=new A218664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218665
{
public static readonly long[] Value={ 1L,2L,4L,10L,16L,20L,41L,44L,55L,67L,76L,548L,751L,1962L,3318L,3760L,5873L,7729L,8074L,15502L,33847L,65888L,89836L,167786L,512688L,1401686L,2520988L,2897654L,5552333L,6352323L,7981750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218665Inst : IEnumerable<long>
{
public static readonly long[] Value=A218665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218665.Bytes);
public long this[int i]=>Value[i];

public static A218665Inst Instance=new A218665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218666
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,4L,1L,2L,4L,4L,9L,1L,3L,7L,8L,9L,20L,1L,3L,9L,16L,18L,20L,48L,1L,4L,12L,30L,36L,40L,48L,115L,1L,4L,18L,38L,81L,80L,96L,115L,286L,1L,5L,21L,64L,144L,180L,192L,230L,286L,719L,1L,5L,27L,92L,216L,400L,432L,460L,572L,719L,1842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218666Inst : IEnumerable<long>
{
public static readonly long[] Value=A218666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218666.Bytes);
public long this[int i]=>Value[i];

public static A218666Inst Instance=new A218666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218667
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,13L,46L,181L,778L,3585L,17566L,91171L,499324L,2873839L,17317743L,108933098L,713481122L,4855161425L,34257461754L,250177938679L,1887886966690L,14699340919293L,117933068390123L,973776266303732L,8265721830953558L,72052688932613079L,644393453082317301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218667Inst : IEnumerable<long>
{
public static readonly long[] Value=A218667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218667.Bytes);
public long this[int i]=>Value[i];

public static A218667Inst Instance=new A218667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218668
{
public static readonly BigInteger[] Value={ 1L,0L,1L,3L,22L,161L,1546L,18857L,270320L,4471693L,85455574L,1865128265L,45735737037L,1247518965519L,37654095184226L,1250673144714138L,45415758777730668L,1792734161930717221L,BigInteger.Parse("76595370803745016626"),BigInteger.Parse("3529261203030717032927"),BigInteger.Parse("174742139545017029583279") };
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
public class A218668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218668Inst Instance=new A218668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218669
{
public static readonly BigInteger[] Value={ 1L,0L,1L,7L,97L,1561L,41136L,1551814L,72440460L,4281320257L,324623105584L,30086950057627L,3299720918091511L,428431079916572044L,BigInteger.Parse("65637957066642609845"),BigInteger.Parse("11659659637028895337265"),BigInteger.Parse("2367270866164121777222596"),BigInteger.Parse("546795407830461739380895161"),BigInteger.Parse("143176487805296033192642234802") };
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
public class A218669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218669.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218669Inst Instance=new A218669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218670
{
public static readonly long[] Value={ 1L,1L,2L,7L,26L,116L,556L,2927L,16388L,97666L,612136L,4023878L,27579410L,196537134L,1451102836L,11074811191L,87160086800L,706055915318L,5876662642720L,50182337830986L,439036984440316L,3930618736372336L,35970734643745496L,336153100655220126L,3205000520319374116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218670Inst : IEnumerable<long>
{
public static readonly long[] Value=A218670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218670.Bytes);
public long this[int i]=>Value[i];

public static A218670Inst Instance=new A218670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218671
{
public static readonly BigInteger[] Value={ 1L,1L,8L,120L,2635L,76503L,2764957L,119634152L,6030195490L,347037131298L,22453144758980L,1613322276606404L,127466755375275614L,10983423290600347408UL,BigInteger.Parse("1025046637630590359928"),BigInteger.Parse("103004615955568528609200"),BigInteger.Parse("11088429267977228122393005"),BigInteger.Parse("1273093489376335864500416685") };
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
public class A218671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218671Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218671.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218671.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218671Inst Instance=new A218671Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218672
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,63L,659L,9833L,206961L,6133990L,256650268L,15213478000L,1281205909177L,153588353066135L,26245044813624300L,6399076697684238375L,BigInteger.Parse("2227912079081482302977"),BigInteger.Parse("1108302173165578509079527"),BigInteger.Parse("788171767077184315422131588"),BigInteger.Parse("801638519723021288783092512047") };
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
public class A218672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218672.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218672Inst Instance=new A218672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218673
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,209L,3173L,67292L,1970761L,79764057L,4490097388L,354111363537L,39360693851404L,6193012446752244L,1383433132321835172L,BigInteger.Parse("439684769985895688173"),BigInteger.Parse("199116777197880585373014"),BigInteger.Parse("128631139424158036273736167"),BigInteger.Parse("118640007280899188486618513612") };
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
public class A218673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218673.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218673Inst Instance=new A218673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218674
{
public static readonly BigInteger[] Value={ 1L,1L,4L,34L,455L,8710L,230077L,8285224L,407456797L,27587687551L,2596034329278L,342275007167359L,63606742005546232L,16730509857101195808UL,BigInteger.Parse("6246818082857455197662"),BigInteger.Parse("3317816101992338134691233"),BigInteger.Parse("2510420393373091580780786808"),BigInteger.Parse("2709148467943025007607468405672") };
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
public class A218674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218674Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218674.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218674.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218674Inst Instance=new A218674Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218675
{
public static readonly BigInteger[] Value={ 1L,1L,5L,51L,817L,18562L,576687L,24203258L,1375038677L,106708683355L,11435867474152L,1708844338589752L,358640659116617571L,BigInteger.Parse("106261016900832212139"),BigInteger.Parse("44607231638918264608274"),BigInteger.Parse("26598477338494285370797703"),BigInteger.Parse("22569718290467849884279856477") };
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
public class A218675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218675Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218675.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218675Inst Instance=new A218675Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218676
{
public static readonly BigInteger[] Value={ 1L,1L,6L,71L,1311L,34146L,1207717L,57298282L,3653975784L,316252925221L,37596625187796L,6206102367103899L,1434418185304457039L,BigInteger.Parse("466995106832397752352"),BigInteger.Parse("215051811411620578152401"),BigInteger.Parse("140491107719613466192347681"),BigInteger.Parse("130481943378389095603359529403") };
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
public class A218676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218676Inst Instance=new A218676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218677
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,79L,516L,3802L,30668L,268815L,2522594L,25201736L,266014607L,2953171684L,34326755191L,416313253084L,5251970372080L,68737673434847L,931207966502919L,13031639620371226L,188051624603419973L,2793741995189126920L,BigInteger.Parse("42668132798523737471"),BigInteger.Parse("669061042470049870917") };
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
public class A218677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218677.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218677Inst Instance=new A218677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218678
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,161L,1321L,12541L,130383L,1482875L,18153076L,237430711L,3295833146L,48274094584L,742868875984L,11963384310515L,200974595790271L,3511980095379727L,63682377891348689L,1195661594431548085L,BigInteger.Parse("23199930176668566579"),BigInteger.Parse("464421513762097397125"),BigInteger.Parse("9576744471125816269165") };
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
public class A218678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218678.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218678Inst Instance=new A218678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218679
{
public static readonly BigInteger[] Value={ 1L,1L,5L,31L,273L,2652L,30071L,375628L,5135649L,75945388L,1202006514L,20243446719L,360517872287L,6758311053521L,132833835618576L,2728019848249377L,58370987166092073L,1297916560174624569L,BigInteger.Parse("29924140267551540116"),BigInteger.Parse("713934350929955200551"),BigInteger.Parse("17594768127940813003452") };
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
public class A218679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218679Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218679.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218679.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218679Inst Instance=new A218679Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218680
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,111L,911L,8622L,91414L,1067579L,13564195L,185687381L,2718184470L,42288343176L,695667651368L,12049465530936L,218945489692574L,4160440403683643L,82448824370010887L,1699889286488298603L,BigInteger.Parse("36384381642357676480"),BigInteger.Parse("806926050321577391347"),BigInteger.Parse("18510872795071148287531") };
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
public class A218680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218680Inst Instance=new A218680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218681
{
public static readonly BigInteger[] Value={ 1L,1L,2L,17L,248L,8044L,499033L,62625238L,15947986557L,8220983161264L,8675909809528468L,BigInteger.Parse("18709697284980554577"),BigInteger.Parse("82551047593942653184220"),BigInteger.Parse("747564468621251440782891798"),BigInteger.Parse("13885138852461763218258064204207"),BigInteger.Parse("529723356811556257370919794910913765") };
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
public class A218681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218681Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218681.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218681.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218681Inst Instance=new A218681Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218682
{
public static readonly BigInteger[] Value={ 1L,1L,6L,93L,2944L,167685L,16037376L,2481455137L,609371157312L,235171042752105L,141778378915235200L,BigInteger.Parse("132871933962627534741"),BigInteger.Parse("192678752056300896500544"),BigInteger.Parse("430404642833695770472870573"),BigInteger.Parse("1474859949355240010986735351872"),BigInteger.Parse("7723091241704594423130951106689225") };
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
public class A218682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218682Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218682.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218682.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218682Inst Instance=new A218682Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218683
{
public static readonly BigInteger[] Value={ 1L,1L,6L,69L,1432L,52065L,3202176L,324172597L,53099867136L,13888279032129L,5736880791449920L,3710252136325373661L,BigInteger.Parse("3729910949734728414624"),BigInteger.Parse("5792791811385586637686849"),BigInteger.Parse("13826260704559808415109532256"),BigInteger.Parse("50488064853691920270244556417445") };
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
public class A218683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218683Inst Instance=new A218683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218684
{
public static readonly long[] Value={ 1L,0L,1L,2L,7L,18L,96L,260L,1851L,5270L,46515L,137942L,1447202L,4433772L,53787706L,169169912L,2326986783L,7477418982L,114916173009L,375898894514L,6380455164161L,21185872231238L,393499602818322L,1323362744628080L,26691270481453228L,90755667374332324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218684Inst : IEnumerable<long>
{
public static readonly long[] Value=A218684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218684.Bytes);
public long this[int i]=>Value[i];

public static A218684Inst Instance=new A218684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218685
{
public static readonly BigInteger[] Value={ 1L,0L,1L,6L,34L,270L,3415L,31230L,681026L,6949920L,230637870L,2546120514L,119281951006L,1394371349490L,87612425583018L,1069010047029672L,86763885548985810L,1094149501538197236L,BigInteger.Parse("111443560982774811439"),BigInteger.Parse("1442387644419293694144"),BigInteger.Parse("180179254059921915232864") };
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
public class A218685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218685Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218685.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218685.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218685Inst Instance=new A218685Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218686
{
public static readonly BigInteger[] Value={ 1L,1L,2L,15L,107L,1164L,13932L,207527L,3424441L,65365273L,1366815507L,31899555046L,806153628997L,22260455705106L,659196741236329L,21028295211402871L,713819243969142111L,BigInteger.Parse("25836118882427921161"),BigInteger.Parse("988875977638287049631"),BigInteger.Parse("40043648314495526922945") };
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
public class A218686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218686Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218686.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218686.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218686Inst Instance=new A218686Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218687
{
public static readonly BigInteger[] Value={ 1L,1L,2L,31L,398L,10476L,296407L,12613297L,592445192L,36797742660L,2524966492661L,212912151736648L,19819138754732997L,2155966497948737905L,BigInteger.Parse("259256365067737582615"),BigInteger.Parse("35050667748654756208069"),BigInteger.Parse("5257919606219599751747894"),BigInteger.Parse("858816581875175776426876930") };
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
public class A218687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218687Inst Instance=new A218687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218688
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,106L,975L,11106L,151501L,2415960L,44221869L,915826600L,21211128411L,544126606992L,15334985416075L,471495297242256L,15719617534811625L,565271886957356416L,BigInteger.Parse("21820620411482896089"),BigInteger.Parse("900398349688515500160"),BigInteger.Parse("39564926462522623540519"),BigInteger.Parse("1845034125763359894240000") };
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
public class A218688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218688Inst Instance=new A218688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218689
{
public static readonly BigInteger[] Value={ 1L,65L,93313L,795985985L,8178690000001L,93706344780048065L,BigInteger.Parse("1453730786373283012225"),BigInteger.Parse("26552497154713885161031745"),BigInteger.Parse("513912636558068387176582890625"),BigInteger.Parse("10769375530849394271690330588432065"),BigInteger.Parse("243282405272735566295972089793676717313"),BigInteger.Parse("5763401688773271719278313934033057270226625") };
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
public class A218689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218689Inst Instance=new A218689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218690
{
public static readonly BigInteger[] Value={ 1L,5L,181L,9797L,616501L,45778505L,3678753205L,314352091205L,28154344881205L,2612340741982505L,249415797821914681L,BigInteger.Parse("24374175871569953225"),BigInteger.Parse("2428502737999745059381"),BigInteger.Parse("245952659136011117909897"),BigInteger.Parse("25260608441078125508484181"),BigInteger.Parse("2626023605592369669830217797") };
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
public class A218690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218690Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218690.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218690.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218690Inst Instance=new A218690Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218691
{
public static readonly BigInteger[] Value={ 1L,2L,6L,26L,156L,1242L,12616L,158034L,2372880L,41725106L,843126624L,19277549898L,492447987136L,13907344659210L,430397513894016L,14487404695687298L,527023721684738304L,BigInteger.Parse("20605894357093102434"),BigInteger.Parse("861761850029367846400"),BigInteger.Parse("38387125875316048363386"),BigInteger.Parse("1814541564588778500135936") };
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
public class A218691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218691Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218691.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218691.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218691Inst Instance=new A218691Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218692
{
public static readonly BigInteger[] Value={ 1L,9L,1945L,783657L,333935001L,216152253009L,148273286805001L,112444816742316585L,BigInteger.Parse("93273051852487532953"),BigInteger.Parse("80885382627785790555009"),BigInteger.Parse("73726153308964013326434945"),BigInteger.Parse("69714999360408389332640853105"),BigInteger.Parse("67921574835559806028030517001225"),BigInteger.Parse("67965584346796032477336615843457665") };
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
public class A218692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218692Inst Instance=new A218692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218693
{
public static readonly BigInteger[] Value={ 1L,9L,271L,11193L,535251L,27854739L,1531656211L,87547358649L,5149886133907L,309721191497259L,18957806551405701L,1177134132932168739L,BigInteger.Parse("73964787438524189871"),BigInteger.Parse("4694347514292389411103"),BigInteger.Parse("300499277330710307643771"),BigInteger.Parse("19378727805024033594228153"),BigInteger.Parse("1257802636907811605342461587") };
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
public class A218693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218693Inst Instance=new A218693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218694
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,2L,2L,3L,6L,9L,10L,13L,22L,32L,40L,56L,86L,122L,164L,229L,332L,474L,656L,914L,1310L,1867L,2604L,3648L,5184L,7346L,10318L,14506L,20516L,29022L,40880L,57548L,81260L,114810L,161864L,228092L,321892L,454444L,640954L,903715L,1274998L,1799320L,2538218L,3579714L,5049954L,7125359L,10051844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218694Inst : IEnumerable<long>
{
public static readonly long[] Value=A218694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218694.Bytes);
public long this[int i]=>Value[i];

public static A218694Inst Instance=new A218694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218695
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,25L,25L,1L,1L,79L,265L,79L,1L,1L,241L,2161L,2161L,241L,1L,1L,727L,16081L,41503L,16081L,727L,1L,1L,2185L,115465L,693601L,693601L,115465L,2185L,1L,1L,6559L,816985L,10924399L,24997921L,10924399L,816985L,6559L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218695Inst : IEnumerable<long>
{
public static readonly long[] Value=A218695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218695.Bytes);
public long this[int i]=>Value[i];

public static A218695Inst Instance=new A218695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218696
{
public static readonly BigInteger[] Value={ 1L,15L,222L,3680L,69345L,1477182L,35234220L,932070708L,27109785510L,860394764515L,29600058300780L,1097511032533500L,43637308561557074L,1852311640075120980L,BigInteger.Parse("83612841417061582320"),BigInteger.Parse("3999611090385007608840"),BigInteger.Parse("202111299843794061251580"),BigInteger.Parse("10758947714752854861908379") };
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
public class A218696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218696Inst Instance=new A218696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218697
{
public static readonly long[] Value={ 6L,9L,14L,21L,46L,49L,69L,86L,94L,129L,134L,141L,145L,161L,166L,201L,205L,206L,214L,249L,254L,301L,305L,309L,321L,326L,329L,334L,381L,445L,446L,454L,469L,489L,501L,505L,526L,529L,545L,566L,581L,614L,669L,681L,694L,721L,734L,745L,749L,766L,789L,841L,849L,886L,889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218697Inst : IEnumerable<long>
{
public static readonly long[] Value=A218697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218697.Bytes);
public long this[int i]=>Value[i];

public static A218697Inst Instance=new A218697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218698
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,2L,6L,3L,2L,2L,14L,5L,4L,3L,3L,27L,7L,4L,3L,2L,2L,60L,11L,8L,6L,5L,4L,4L,117L,15L,8L,6L,4L,3L,2L,2L,246L,22L,13L,9L,8L,6L,5L,4L,4L,490L,30L,15L,12L,8L,7L,5L,4L,3L,3L,1002L,42L,22L,14L,12L,9L,8L,6L,5L,4L,4L,1998L,56L,24L,16L,12L,10L,7L,6L,4L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218698Inst : IEnumerable<long>
{
public static readonly long[] Value=A218698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218698.Bytes);
public long this[int i]=>Value[i];

public static A218698Inst Instance=new A218698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218699
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,5L,4L,8L,8L,12L,12L,19L,18L,24L,26L,36L,36L,48L,50L,70L,71L,92L,96L,129L,133L,168L,177L,225L,233L,294L,307L,382L,401L,488L,518L,635L,668L,803L,855L,1027L,1089L,1298L,1381L,1638L,1745L,2047L,2184L,2569L,2734L,3181L,3404L,3953L,4213L,4863L,5203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218699Inst : IEnumerable<long>
{
public static readonly long[] Value=A218699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218699.Bytes);
public long this[int i]=>Value[i];

public static A218699Inst Instance=new A218699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218700
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,3L,6L,7L,9L,10L,15L,15L,19L,23L,26L,28L,36L,37L,48L,52L,62L,67L,85L,93L,110L,122L,144L,157L,194L,205L,241L,265L,304L,338L,391L,422L,483L,533L,607L,661L,760L,822L,933L,1032L,1151L,1260L,1432L,1554L,1751L,1920L,2137L,2333L,2621L,2848L,3176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218700Inst : IEnumerable<long>
{
public static readonly long[] Value=A218700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218700.Bytes);
public long this[int i]=>Value[i];

public static A218700Inst Instance=new A218700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218701
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,5L,5L,8L,7L,14L,11L,16L,19L,23L,22L,32L,29L,38L,40L,48L,48L,67L,63L,81L,85L,106L,106L,141L,138L,174L,180L,219L,224L,284L,282L,342L,356L,422L,431L,530L,532L,631L,660L,765L,789L,948L,965L,1123L,1184L,1356L,1408L,1658L,1703L,1967L,2076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218701Inst : IEnumerable<long>
{
public static readonly long[] Value=A218701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218701.Bytes);
public long this[int i]=>Value[i];

public static A218701Inst Instance=new A218701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218702
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,4L,6L,6L,11L,10L,13L,16L,19L,20L,25L,27L,33L,34L,39L,41L,51L,52L,61L,65L,80L,82L,99L,104L,126L,133L,156L,168L,199L,209L,243L,261L,302L,320L,372L,392L,447L,479L,537L,572L,650L,693L,770L,829L,920L,982L,1096L,1169L,1306L,1396L,1541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218702Inst : IEnumerable<long>
{
public static readonly long[] Value=A218702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218702.Bytes);
public long this[int i]=>Value[i];

public static A218702Inst Instance=new A218702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218703
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,3L,5L,4L,10L,7L,12L,13L,17L,16L,23L,21L,30L,30L,34L,35L,47L,43L,51L,52L,66L,63L,81L,77L,100L,99L,120L,121L,156L,150L,185L,189L,234L,230L,283L,281L,343L,350L,409L,414L,503L,497L,587L,600L,695L,703L,824L,830L,967L,988L,1122L,1148L,1333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218703Inst : IEnumerable<long>
{
public static readonly long[] Value=A218703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218703.Bytes);
public long this[int i]=>Value[i];

public static A218703Inst Instance=new A218703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218704
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,3L,8L,6L,9L,12L,14L,14L,20L,19L,24L,28L,29L,31L,41L,40L,44L,49L,54L,54L,69L,64L,77L,82L,94L,98L,119L,118L,139L,149L,173L,178L,215L,217L,253L,274L,306L,320L,375L,385L,440L,469L,521L,545L,626L,647L,718L,769L,838L,881L,994L,1026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218704Inst : IEnumerable<long>
{
public static readonly long[] Value=A218704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218704.Bytes);
public long this[int i]=>Value[i];

public static A218704Inst Instance=new A218704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218705
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,4L,2L,4L,3L,4L,2L,7L,4L,8L,9L,13L,11L,18L,16L,23L,22L,27L,27L,36L,35L,41L,42L,51L,48L,61L,57L,69L,65L,80L,81L,98L,93L,115L,112L,144L,136L,170L,164L,202L,204L,244L,242L,296L,290L,353L,350L,415L,412L,493L,494L,576L,580L,671L,673L,794L,786L,903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218705Inst : IEnumerable<long>
{
public static readonly long[] Value=A218705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218705.Bytes);
public long this[int i]=>Value[i];

public static A218705Inst Instance=new A218705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218706
{
public static readonly long[] Value={ 1L,2L,5L,9L,12L,19L,27L,33L,42L,54L,66L,77L,91L,105L,120L,138L,156L,175L,197L,218L,240L,263L,287L,314L,339L,367L,398L,430L,459L,493L,526L,556L,595L,637L,670L,709L,752L,794L,833L,878L,921L,965L,1018L,1065L,1112L,1163L,1215L,1266L,1317L,1370L,1433L,1492L,1544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218706Inst : IEnumerable<long>
{
public static readonly long[] Value=A218706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218706.Bytes);
public long this[int i]=>Value[i];

public static A218706Inst Instance=new A218706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218707
{
public static readonly long[] Value={ 2L,4L,4L,6L,304L,680L,1054L,1558L,15904L,41638L,82800L,241898L,241898L,241898L,241898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218707Inst : IEnumerable<long>
{
public static readonly long[] Value=A218707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218707.Bytes);
public long this[int i]=>Value[i];

public static A218707Inst Instance=new A218707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218708
{
public static readonly long[] Value={ 1L,9L,9L,4L,7L,1L,1L,4L,0L,2L,0L,0L,7L,1L,6L,3L,3L,8L,9L,6L,9L,9L,7L,3L,0L,2L,9L,9L,6L,7L,1L,9L,0L,9L,3L,4L,2L,3L,7L,9L,2L,9L,3L,1L,5L,5L,8L,2L,4L,6L,7L,3L,2L,8L,8L,3L,2L,9L,6L,2L,9L,1L,4L,8L,3L,5L,3L,2L,8L,9L,6L,2L,9L,4L,9L,6L,5L,0L,9L,1L,9L,2L,5L,0L,6L,2L,6L,1L,6L,6L,9L,5L,3L,6L,5L,3L,4L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218708Inst : IEnumerable<long>
{
public static readonly long[] Value=A218708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218708.Bytes);
public long this[int i]=>Value[i];

public static A218708Inst Instance=new A218708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218709
{
public static readonly BigInteger[] Value={ 0L,5L,70L,239L,239L,143044L,1999509L,6826318L,6826318L,822557039L,52199939826L,603633907222L,11356596271444L,11356596271444L,1828607235824962L,13920898306972194L,13920898306972194L,2675587335039691558L,BigInteger.Parse("49226908181248336040"),BigInteger.Parse("513050126578538629605") };
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
public class A218709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218709.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218709Inst Instance=new A218709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218710
{
public static readonly BigInteger[] Value={ 0L,4L,38L,1985L,27493L,390112L,390112L,96940388L,3379649772L,24306922095L,450044583893L,5597937117454L,28673959190179L,3524407382568745L,13428985415474682L,13428985415474682L,5711417117604156904L,BigInteger.Parse("91610966633729580058"),BigInteger.Parse("6709533061724423693474") };
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
public class A218710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218710.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218710Inst Instance=new A218710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218711
{
public static readonly long[] Value={ 0L,1L,8L,23L,51L,90L,157L,230L,341L,471L,639L,835L,1063L,1340L,1671L,2022L,2443L,2893L,3428L,4004L,4653L,5359L,6133L,6977L,7907L,8886L,9991L,11152L,12428L,13724L,15192L,16683L,18358L,20072L,21932L,23880L,25941L,28117L,30397L,32822L,35376L,38013L,40840L,43765L,46880L,50090L,53448L,56911L,60583L,64379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218711Inst : IEnumerable<long>
{
public static readonly long[] Value=A218711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218711.Bytes);
public long this[int i]=>Value[i];

public static A218711Inst Instance=new A218711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218712
{
public static readonly BigInteger[] Value={ 0L,12L,41L,10133L,34522L,7745569L,253879357L,7986582530L,61012922706L,4563230639355L,67972499239990L,1330094199140593L,47471944863682723L,5000878909740249297L,5000878909740249297L,BigInteger.Parse("590115586441858677665"),BigInteger.Parse("77072583141941801290876"),BigInteger.Parse("423420364218752896284166") };
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
public class A218712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218712Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218712.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218712.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218712Inst Instance=new A218712Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218713
{
public static readonly BigInteger[] Value={ 0L,6L,117L,9466L,800982L,6423465L,756360062L,24900904028L,1019349744435L,15069267560119L,794839706330581L,71333925879937154L,2419512779032508628L,BigInteger.Parse("116073623326088126430"),BigInteger.Parse("359642847542169431827"),BigInteger.Parse("144552623583462302226851"),BigInteger.Parse("3523356323886506075746572") };
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
public class A218713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218713Inst Instance=new A218713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218714
{
public static readonly BigInteger[] Value={ 0L,9L,378L,11389L,1251967L,46464143L,2363588163L,92615568742L,287369842623L,112076323050317L,2403749863808044L,56094387104417648L,1156752450536914530L,BigInteger.Parse("43970228150195457632"),BigInteger.Parse("10132163897314954464899"),BigInteger.Parse("503212117431217218892992"),BigInteger.Parse("19164391897329672149556204") };
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
public class A218714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218714Inst Instance=new A218714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218715
{
public static readonly BigInteger[] Value={ 0L,23L,500L,27590L,623098L,23048345L,5041394261L,416081467190L,11331029931180L,50928660480181L,6548598523124085L,2441875986594058601L,BigInteger.Parse("76594163421571591377"),BigInteger.Parse("7783548304686046882879"),BigInteger.Parse("252583670951378815076851"),BigInteger.Parse("4392422457122810120236558"),BigInteger.Parse("1165802007767335105471573954") };
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
public class A218715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218715Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218715.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218715.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218715Inst Instance=new A218715Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218716
{
public static readonly BigInteger[] Value={ 0L,11L,682L,51412L,6304056L,144762466L,9435321777L,988322434636L,71294762793847L,3138611770750343L,283798117998769727L,15409745938584647495UL,BigInteger.Parse("320007169218635518122"),BigInteger.Parse("45443939732277600209579"),BigInteger.Parse("207359227164430355867160"),BigInteger.Parse("59053635973003478214807486") };
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
public class A218716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218716.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218716Inst Instance=new A218716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218717
{
public static readonly BigInteger[] Value={ 0L,27L,776L,153765L,6459524L,404034898L,41865466758L,3219884218827L,239822883201307L,9110883894036198L,991706090146518323L,BigInteger.Parse("142813358470363920740"),BigInteger.Parse("8641533837443707913816"),BigInteger.Parse("586811715371303018585730"),BigInteger.Parse("2756887299416274753296336"),BigInteger.Parse("729513196939063257288876118") };
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
public class A218717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218717Inst Instance=new A218717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218718
{
public static readonly BigInteger[] Value={ 0L,34L,3861L,344464L,20099637L,2153335831L,102666405913L,4867146503697L,923990886302412L,50251663587824641L,5655954122907587985L,BigInteger.Parse("909925832091926912414"),BigInteger.Parse("85120439454684773642745"),BigInteger.Parse("2631773999763198769695986"),BigInteger.Parse("41332517834853462204330752") };
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
public class A218718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218718Inst Instance=new A218718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218719
{
public static readonly BigInteger[] Value={ 0L,22L,4052L,107551L,22709274L,331407850L,197177418061L,26457926739667L,2369608176604944L,76004727767164666L,BigInteger.Parse("25163629663367816827"),BigInteger.Parse("1965881512952938486496"),BigInteger.Parse("191165497320828772935835"),BigInteger.Parse("21700278688179406782082106"),BigInteger.Parse("560121950820639295011033922") };
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
public class A218719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218719Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218719.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218719.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218719Inst Instance=new A218719Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218720
{
public static readonly BigInteger[] Value={ 0L,10L,515L,296344L,35764191L,1108900220L,316411915250L,47023298541694L,3156215819652023L,310872228812491206L,BigInteger.Parse("28124944860980892220"),BigInteger.Parse("3783840171259076226254"),BigInteger.Parse("208193145695151069244665"),BigInteger.Parse("19364218657938636320485082"),BigInteger.Parse("663491749602035014400202724") };
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
public class A218720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218720Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218720.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218720.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218720Inst Instance=new A218720Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218721
{
public static readonly BigInteger[] Value={ 0L,1L,19L,343L,6175L,111151L,2000719L,36012943L,648232975L,11668193551L,210027483919L,3780494710543L,68048904789775L,1224880286215951L,22047845151887119L,396861212733968143L,7143501829211426575L,BigInteger.Parse("128583032925805678351") };
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
public class A218721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218721Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218721.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218721.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218721Inst Instance=new A218721Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218722
{
public static readonly BigInteger[] Value={ 0L,1L,20L,381L,7240L,137561L,2613660L,49659541L,943531280L,17927094321L,340614792100L,6471681049901L,122961939948120L,2336276859014281L,44389260321271340L,843395946104155461L,16024522975978953760UL,BigInteger.Parse("304465936543600121441") };
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
public class A218722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218722Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218722.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218722.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218722Inst Instance=new A218722Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218723
{
public static readonly BigInteger[] Value={ 0L,1L,257L,65793L,16843009L,4311810305L,1103823438081L,282578800148737L,72340172838076673L,BigInteger.Parse("18519084246547628289"),BigInteger.Parse("4740885567116192841985"),BigInteger.Parse("1213666705181745367548161"),BigInteger.Parse("310698676526526814092329217"),BigInteger.Parse("79538861190790864407636279553") };
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
public class A218723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218723.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218723Inst Instance=new A218723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218724
{
public static readonly BigInteger[] Value={ 0L,1L,22L,463L,9724L,204205L,4288306L,90054427L,1891142968L,39714002329L,833994048910L,17513875027111L,367791375569332L,7723618886955973L,162195996626075434L,3406115929147584115L,BigInteger.Parse("71528434512099266416") };
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
public class A218724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218724.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218724Inst Instance=new A218724Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218725
{
public static readonly BigInteger[] Value={ 0L,1L,23L,507L,11155L,245411L,5399043L,118778947L,2613136835L,57489010371L,1264758228163L,27824681019587L,612142982430915L,13467145613480131L,296277203496562883L,6518098476924383427L,BigInteger.Parse("143398166492336435395") };
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
public class A218725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218725Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218725.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218725.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218725Inst Instance=new A218725Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218726
{
public static readonly BigInteger[] Value={ 0L,1L,24L,553L,12720L,292561L,6728904L,154764793L,3559590240L,81870575521L,1883023236984L,43309534450633L,996119292364560L,22910743724384881L,526947105660852264L,12119783430199602073UL,BigInteger.Parse("278755018894590847680"),BigInteger.Parse("6411365434575589496641") };
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
public class A218726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218726Inst Instance=new A218726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218727
{
public static readonly BigInteger[] Value={ 0L,1L,25L,601L,14425L,346201L,8308825L,199411801L,4785883225L,114861197401L,2756668737625L,66160049703001L,1587841192872025L,38108188628928601L,914596527094286425L,BigInteger.Parse("21950316650262874201"),BigInteger.Parse("526807599606308980825"),BigInteger.Parse("12643382390551415539801") };
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
public class A218727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218727.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218727Inst Instance=new A218727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218728
{
public static readonly BigInteger[] Value={ 0L,1L,26L,651L,16276L,406901L,10172526L,254313151L,6357828776L,158945719401L,3973642985026L,99341074625651L,2483526865641276L,62088171641031901L,1552204291025797526L,BigInteger.Parse("38805107275644938151"),BigInteger.Parse("970127681891123453776"),BigInteger.Parse("24253192047278086344401") };
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
public class A218728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218728Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218728.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218728.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218728Inst Instance=new A218728Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218729
{
public static readonly BigInteger[] Value={ 0L,1L,27L,703L,18279L,475255L,12356631L,321272407L,8353082583L,217180147159L,5646683826135L,146813779479511L,3817158266467287L,99246114928149463L,2580398988131886039L,BigInteger.Parse("67090373691429037015"),BigInteger.Parse("1744349715977154962391") };
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
public class A218729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218729Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218729.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218729.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218729Inst Instance=new A218729Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218730
{
public static readonly BigInteger[] Value={ 0L,1L,28L,757L,20440L,551881L,14900788L,402321277L,10862674480L,293292210961L,7918889695948L,213810021790597L,5772870588346120L,155867505885345241L,4208422658904321508L,BigInteger.Parse("113627411790416680717"),BigInteger.Parse("3067940118341250379360"),BigInteger.Parse("82834383195213760242721") };
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
public class A218730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218730Inst Instance=new A218730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218731
{
public static readonly BigInteger[] Value={ 0L,1L,29L,813L,22765L,637421L,17847789L,499738093L,13992666605L,391794664941L,10970250618349L,307167017313773L,8600676484785645L,240818941573998061L,6742930364071945709L,BigInteger.Parse("188802050194014479853"),BigInteger.Parse("5286457405432405435885"),BigInteger.Parse("148020807352107352204781") };
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
public class A218731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218731Inst Instance=new A218731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218732
{
public static readonly BigInteger[] Value={ 0L,1L,30L,871L,25260L,732541L,21243690L,616067011L,17865943320L,518112356281L,15025258332150L,435732491632351L,12636242257338180L,366451025462807221L,10627079738421409410UL,BigInteger.Parse("308185312414220872891"),BigInteger.Parse("8937374060012405313840"),BigInteger.Parse("259183847740359754101361") };
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
public class A218732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218732Inst Instance=new A218732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218733
{
public static readonly BigInteger[] Value={ 0L,1L,31L,931L,27931L,837931L,25137931L,754137931L,22624137931L,678724137931L,20361724137931L,610851724137931L,18325551724137931L,549766551724137931L,16492996551724137931UL,BigInteger.Parse("494789896551724137931"),BigInteger.Parse("14843696896551724137931") };
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
public class A218733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218733.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218733Inst Instance=new A218733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218734
{
public static readonly BigInteger[] Value={ 0L,1L,32L,993L,30784L,954305L,29583456L,917087137L,28429701248L,881320738689L,27320942899360L,846949229880161L,26255426126284992L,813918209914834753L,BigInteger.Parse("25231464507359877344"),BigInteger.Parse("782175399728156197665"),BigInteger.Parse("24247437391572842127616"),BigInteger.Parse("751670559138758105956097") };
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
public class A218734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218734Inst Instance=new A218734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218735
{
public static readonly long[] Value={ 5L,6L,9L,13L,22L,33L,57L,86L,149L,225L,390L,589L,1021L,1542L,2673L,4037L,6998L,10569L,18321L,27670L,47965L,72441L,125574L,189653L,328757L,496518L,860697L,1299901L,2253334L,3403185L,5899305L,8909654L,15444581L,23325777L,40434438L,61067677L,105858733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218735Inst : IEnumerable<long>
{
public static readonly long[] Value=A218735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218735.Bytes);
public long this[int i]=>Value[i];

public static A218735Inst Instance=new A218735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218736
{
public static readonly BigInteger[] Value={ 0L,1L,34L,1123L,37060L,1222981L,40358374L,1331826343L,43950269320L,1450358887561L,47861843289514L,1579440828553963L,52121547342280780L,1720011062295265741L,BigInteger.Parse("56760365055743769454"),BigInteger.Parse("1873092046839544391983") };
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
public class A218736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218736.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218736Inst Instance=new A218736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218737
{
public static readonly BigInteger[] Value={ 0L,1L,35L,1191L,40495L,1376831L,46812255L,1591616671L,54114966815L,1839908871711L,62556901638175L,2126934655697951L,72315778293730335L,2458736461986831391L,BigInteger.Parse("83597039707552267295"),BigInteger.Parse("2842299350056777088031") };
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
public class A218737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218737Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218737.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218737.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218737Inst Instance=new A218737Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218738
{
public static readonly BigInteger[] Value={ 0L,1L,36L,1261L,44136L,1544761L,54066636L,1892332261L,66231629136L,2318107019761L,81133745691636L,2839681099207261L,99388838472254136L,3478609346528894761L,BigInteger.Parse("121751327128511316636"),BigInteger.Parse("4261296449497896082261") };
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
public class A218738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218738Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218738.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218738.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218738Inst Instance=new A218738Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218739
{
public static readonly BigInteger[] Value={ 0L,1L,37L,1333L,47989L,1727605L,62193781L,2238976117L,80603140213L,2901713047669L,104461669716085L,3760620109779061L,135382323952046197L,4873763662273663093L,BigInteger.Parse("175455491841851871349"),BigInteger.Parse("6316397706306667368565") };
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
public class A218739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218739Inst Instance=new A218739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218740
{
public static readonly BigInteger[] Value={ 0L,1L,38L,1407L,52060L,1926221L,71270178L,2636996587L,97568873720L,3610048327641L,133571788122718L,4942156160540567L,182859777940000980L,6765811783780036261L,BigInteger.Parse("250335035999861341658"),BigInteger.Parse("9262396331994869641347") };
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
public class A218740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218740Inst Instance=new A218740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218741
{
public static readonly BigInteger[] Value={ 0L,1L,39L,1483L,56355L,2141491L,81376659L,3092313043L,117507895635L,4465300034131L,169681401296979L,6447893249285203L,245019943472837715L,9310757851967833171UL,BigInteger.Parse("353808798374777660499"),BigInteger.Parse("13444734338241551098963") };
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
public class A218741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218741Inst Instance=new A218741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218742
{
public static readonly BigInteger[] Value={ 0L,1L,40L,1561L,60880L,2374321L,92598520L,3611342281L,140842348960L,5492851609441L,214221212768200L,8354627297959801L,325830464620432240L,12707388120196857361UL,BigInteger.Parse("495588136687677437080"),BigInteger.Parse("19327937330819420046121") };
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
public class A218742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218742Inst Instance=new A218742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218743
{
public static readonly BigInteger[] Value={ 0L,1L,41L,1641L,65641L,2625641L,105025641L,4201025641L,168041025641L,6721641025641L,268865641025641L,10754625641025641L,430185025641025641L,17207401025641025641UL,BigInteger.Parse("688296041025641025641"),BigInteger.Parse("27531841641025641025641") };
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
public class A218743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218743Inst Instance=new A218743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218744
{
public static readonly BigInteger[] Value={ 0L,1L,42L,1723L,70644L,2896405L,118752606L,4868856847L,199623130728L,8184548359849L,335566482753810L,13758225792906211L,564087257509154652L,BigInteger.Parse("23127577557875340733"),BigInteger.Parse("948230679872888970054"),BigInteger.Parse("38877457874788447772215") };
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
public class A218744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218744.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218744Inst Instance=new A218744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218745
{
public static readonly BigInteger[] Value={ 0L,1L,43L,1807L,75895L,3187591L,133878823L,5622910567L,236162243815L,9918814240231L,416590198089703L,17496788319767527L,734865109430236135L,BigInteger.Parse("30864334596069917671"),BigInteger.Parse("1296302053034936542183"),BigInteger.Parse("54444686227467334771687") };
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
public class A218745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218745.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218745Inst Instance=new A218745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218746
{
public static readonly BigInteger[] Value={ 0L,1L,44L,1893L,81400L,3500201L,150508644L,6471871693L,278290482800L,11966490760401L,514559102697244L,22126041415981493L,951419780887204200L,BigInteger.Parse("40911050578149780601"),BigInteger.Parse("1759175174860440565844"),BigInteger.Parse("75644532518998944331293") };
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
public class A218746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218746.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218746Inst Instance=new A218746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218747
{
public static readonly BigInteger[] Value={ 0L,1L,45L,1981L,87165L,3835261L,168751485L,7425065341L,326702875005L,14374926500221L,632496766009725L,27829857704427901L,1224513738994827645L,BigInteger.Parse("53878604515772416381"),BigInteger.Parse("2370658598693986320765"),BigInteger.Parse("104308978342535398113661") };
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
public class A218747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218747Inst Instance=new A218747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218748
{
public static readonly BigInteger[] Value={ 0L,1L,46L,2071L,93196L,4193821L,188721946L,8492487571L,382161940696L,17197287331321L,773877929909446L,34824506845925071L,1567102808066628196L,BigInteger.Parse("70519626362998268821"),BigInteger.Parse("3173383186334922096946"),BigInteger.Parse("142802243385071494362571") };
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
public class A218748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218748.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218748Inst Instance=new A218748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218749
{
public static readonly BigInteger[] Value={ 0L,1L,47L,2163L,99499L,4576955L,210539931L,9684836827L,445502494043L,20493114725979L,942683277395035L,43363430760171611L,1994717814967894107L,BigInteger.Parse("91757019488523128923"),BigInteger.Parse("4220822896472063930459"),BigInteger.Parse("194157853237714940801115") };
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
public class A218749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218749Inst Instance=new A218749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218750
{
public static readonly BigInteger[] Value={ 0L,1L,48L,2257L,106080L,4985761L,234330768L,11013546097L,517636666560L,24328923328321L,1143459396431088L,53742591632261137L,2525901806716273440L,BigInteger.Parse("118717384915664851681"),BigInteger.Parse("5579717091036248029008"),BigInteger.Parse("262246703278703657363377") };
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
public class A218750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218750Inst Instance=new A218750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218751
{
public static readonly BigInteger[] Value={ 0L,1L,49L,2353L,112945L,5421361L,260225329L,12490815793L,599559158065L,28778839587121L,1381384300181809L,66306446408726833L,3182709427618887985L,BigInteger.Parse("152770052525706623281"),BigInteger.Parse("7332962521233917917489"),BigInteger.Parse("351982201019228060039473") };
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
public class A218751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218751Inst Instance=new A218751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218752
{
public static readonly BigInteger[] Value={ 0L,1L,51L,2551L,127551L,6377551L,318877551L,15943877551L,797193877551L,39859693877551L,1992984693877551L,99649234693877551L,4982461734693877551L,BigInteger.Parse("249123086734693877551"),BigInteger.Parse("12456154336734693877551"),BigInteger.Parse("622807716836734693877551") };
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
public class A218752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218752.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218752Inst Instance=new A218752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218753
{
public static readonly BigInteger[] Value={ 0L,1L,50L,2451L,120100L,5884901L,288360150L,14129647351L,692352720200L,33925283289801L,1662338881200250L,81454605178812251L,3991275653761800300L,BigInteger.Parse("195572507034328214701"),BigInteger.Parse("9583052844682082520350"),BigInteger.Parse("469569589389422043497151") };
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
public class A218753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A218753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A218753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A218753Inst Instance=new A218753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218754
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,2L,2L,1L,3L,1L,3L,1L,1L,2L,1L,0L,3L,3L,2L,3L,3L,0L,3L,0L,3L,2L,1L,1L,4L,1L,2L,2L,1L,2L,0L,2L,2L,2L,3L,0L,4L,1L,1L,2L,0L,1L,2L,3L,5L,0L,2L,1L,3L,4L,1L,1L,2L,2L,6L,2L,2L,4L,1L,2L,3L,2L,3L,3L,3L,2L,4L,1L,2L,5L,0L,3L,4L,2L,3L,4L,3L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218754Inst : IEnumerable<long>
{
public static readonly long[] Value=A218754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218754.Bytes);
public long this[int i]=>Value[i];

public static A218754Inst Instance=new A218754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218755
{
public static readonly long[] Value={ 6L,42L,330L,510L,690L,798L,870L,1410L,1518L,1590L,1770L,1806L,2490L,3102L,3210L,3318L,3894L,4110L,4326L,4470L,4686L,5010L,5190L,5370L,5478L,6486L,6810L,7062L,7890L,8070L,8142L,8646L,8790L,9366L,9510L,10410L,10770L,11022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218755Inst : IEnumerable<long>
{
public static readonly long[] Value=A218755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218755.Bytes);
public long this[int i]=>Value[i];

public static A218755Inst Instance=new A218755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A218756
{
public static readonly long[] Value={ 1L,1L,2L,2L,7L,2L,20L,5L,20L,7L,166L,5L,367L,20L,39L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A218756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A218756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A218756Inst : IEnumerable<long>
{
public static readonly long[] Value=A218756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A218756.Bytes);
public long this[int i]=>Value[i];

public static A218756Inst Instance=new A218756Inst();

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