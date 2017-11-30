using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277662
{
public static readonly ulong[] Value={ 0L,0L,6L,102L,1142L,10650L,89576L,705012L,5297924L,38478492L,272262050L,1887071274L,12862479402L,86468603910L,574580180020L,3780504491400L,24663229376872L,159709443132888L,1027505285362590L,6572573611318158L,41827041105943870L,264959521695360786L,1671472578046156512L,10504743400858155708UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277662Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A277662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277662.Bytes);
public ulong this[int i]=>Value[i];

public static A277662Inst Instance=new A277662Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277663
{
public static readonly BigInteger[] Value={ 0L,0L,10L,378L,7048L,96000L,1092460L,11060700L,103150528L,905077728L,7576640950L,61098854454L,477942694136L,3645484792560L,27220292840440L,199588002587160L,1440630859132416L,10256896070590464L,72150109176698562L,502120765832371602L,3461203073248719400L,BigInteger.Parse("23654601049848668256") };
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
public class A277663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277663Inst Instance=new A277663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277664
{
public static readonly BigInteger[] Value={ 0L,0L,22L,1638L,47454L,904530L,13529862L,172576362L,1966038698L,20583987894L,201838423616L,1878183167916L,16744919877108L,144061342087884L,1202594886126228L,9783039293041644L,77823360967288812L,607079393002409364L,4654603707195506610L,BigInteger.Parse("35144449267872359562"),BigInteger.Parse("261740341786424075106") };
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
public class A277664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277664Inst Instance=new A277664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277665
{
public static readonly BigInteger[] Value={ 0L,0L,42L,6426L,291696L,7786680L,152881422L,2451889734L,34052988736L,424606263984L,4868397305884L,52193110266396L,529596113392928L,5132630490667056L,47846123752559076L,431382289963465044L,3778388016547646976L,BigInteger.Parse("32265703705734047808"),BigInteger.Parse("269434703704642529046"),BigInteger.Parse("2205554182120984631622") };
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
public class A277665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277665Inst Instance=new A277665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277666
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,3L,1L,0L,1L,4L,7L,4L,1L,0L,1L,5L,13L,16L,5L,1L,0L,1L,6L,21L,42L,37L,6L,1L,0L,1L,7L,31L,88L,136L,86L,7L,1L,0L,1L,8L,43L,160L,369L,440L,200L,8L,1L,0L,1L,9L,57L,264L,826L,1547L,1423L,465L,9L,1L,0L,1L,10L,73L,406L,1621L,4264L,6486L,4602L,1081L,10L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277666Inst : IEnumerable<long>
{
public static readonly long[] Value=A277666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277666.Bytes);
public long this[int i]=>Value[i];

public static A277666Inst Instance=new A277666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277667
{
public static readonly long[] Value={ 1L,4L,13L,42L,136L,440L,1423L,4602L,14883L,48132L,155660L,503408L,1628033L,5265096L,17027441L,55067134L,178088372L,575941872L,1862609199L,6023720790L,19480850935L,63001517896L,203748351160L,658926832032L,2130984459505L,6891652526348L,22287762039781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277667Inst : IEnumerable<long>
{
public static readonly long[] Value=A277667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277667.Bytes);
public long this[int i]=>Value[i];

public static A277667Inst Instance=new A277667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277668
{
public static readonly long[] Value={ 1L,5L,21L,88L,369L,1547L,6486L,27194L,114017L,478042L,2004299L,8403476L,35233470L,147724276L,619367372L,2596837513L,10887827441L,45649674187L,191396563242L,802473294131L,3364550422879L,14106637106664L,59145260271900L,247979854176461L,1039711513563070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277668Inst : IEnumerable<long>
{
public static readonly long[] Value=A277668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277668.Bytes);
public long this[int i]=>Value[i];

public static A277668Inst Instance=new A277668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277669
{
public static readonly long[] Value={ 1L,6L,31L,160L,826L,4264L,22012L,113632L,586599L,3028182L,15632291L,80698096L,416585304L,2150525528L,11101591924L,57309407232L,295846593873L,1527239790702L,7884023093755L,40699450421136L,210101523661770L,1084600646648368L,5599000626972168L,28903549078371648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277669Inst : IEnumerable<long>
{
public static readonly long[] Value=A277669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277669.Bytes);
public long this[int i]=>Value[i];

public static A277669Inst Instance=new A277669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277670
{
public static readonly long[] Value={ 1L,7L,43L,264L,1621L,9953L,61112L,375231L,2303939L,14146313L,86859145L,533319959L,3274614074L,20106311704L,123453866991L,758013577995L,4654245334143L,28577324020619L,175466351588409L,1077373112945523L,6615130559166437L,40617267861064920L,249392273325801363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277670Inst : IEnumerable<long>
{
public static readonly long[] Value=A277670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277670.Bytes);
public long this[int i]=>Value[i];

public static A277670Inst Instance=new A277670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277671
{
public static readonly long[] Value={ 1L,8L,57L,406L,2892L,20600L,146736L,1045216L,7445184L,53032832L,377758463L,2690813426L,19166948203L,136528196220L,972504760052L,6927254109472L,49343562590512L,351479407373632L,2503624937520704L,17833584831080448L,127030508108889857L,904851724611169300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277671Inst : IEnumerable<long>
{
public static readonly long[] Value=A277671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277671.Bytes);
public long this[int i]=>Value[i];

public static A277671Inst Instance=new A277671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277672
{
public static readonly long[] Value={ 1L,9L,73L,592L,4801L,38935L,315754L,2560693L,20766637L,168412696L,1365788605L,11076234500L,89825738954L,728466283251L,5907695633935L,47910065991605L,388539722685585L,3150968653039294L,25553638078006016L,207234184444162395L,1680622033979603605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277672Inst : IEnumerable<long>
{
public static readonly long[] Value=A277672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277672.Bytes);
public long this[int i]=>Value[i];

public static A277672Inst Instance=new A277672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277673
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,136L,1547L,22012L,375231L,7445184L,168412696L,4275561136L,120338946469L,3718175865856L,125094920949797L,4551798150123456L,178094082550301368L,7455514741874966528L,BigInteger.Parse("332495821030327545527"),BigInteger.Parse("15737024371475868676864"),BigInteger.Parse("787813565550480151088691") };
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
public class A277673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277673Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277673.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277673Inst Instance=new A277673Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277674
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277674Inst : IEnumerable<long>
{
public static readonly long[] Value=A277674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277674.Bytes);
public long this[int i]=>Value[i];

public static A277674Inst Instance=new A277674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277675
{
public static readonly long[] Value={ 1L,3L,7L,11L,15L,19L,24L,28L,33L,38L,43L,48L,54L,59L,64L,70L,75L,81L,87L,93L,98L,104L,110L,116L,122L,128L,135L,141L,147L,153L,159L,166L,172L,179L,185L,192L,198L,205L,211L,218L,224L,231L,238L,244L,251L,258L,265L,271L,278L,285L,292L,299L,306L,313L,320L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277675Inst : IEnumerable<long>
{
public static readonly long[] Value=A277675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277675.Bytes);
public long this[int i]=>Value[i];

public static A277675Inst Instance=new A277675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277676
{
public static readonly long[] Value={ 2L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,60L,61L,62L,63L,65L,66L,67L,68L,69L,71L,72L,73L,74L,76L,77L,78L,79L,80L,82L,83L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277676Inst : IEnumerable<long>
{
public static readonly long[] Value=A277676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277676.Bytes);
public long this[int i]=>Value[i];

public static A277676Inst Instance=new A277676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277677
{
public static readonly long[] Value={ 0L,2L,1L,3L,4L,5L,7L,9L,121L,10L,21L,123L,125L,127L,129L,141L,11L,143L,13L,145L,1110L,23L,147L,15L,149L,17L,161L,19L,31L,163L,33L,35L,165L,37L,39L,167L,51L,53L,169L,55L,57L,181L,59L,71L,73L,183L,75L,77L,79L,185L,91L,93L,95L,187L,97L,99L,111L,25L,189L,113L,115L,321L,323L,325L,327L,329L,341L,117L,27L,343L,119L,29L,345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277677Inst : IEnumerable<long>
{
public static readonly long[] Value=A277677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277677.Bytes);
public long this[int i]=>Value[i];

public static A277677Inst Instance=new A277677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277678
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,31L,1L,60L,4L,116L,12L,225L,30L,1L,437L,70L,5L,849L,158L,17L,1649L,351L,47L,1L,3202L,770L,118L,6L,6217L,1669L,283L,23L,12071L,3578L,664L,70L,1L,23438L,7599L,1535L,189L,7L,45510L,16016L,3500L,480L,30L,88368L,33545L,7876L,1182L,100L,1L,171586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277678Inst : IEnumerable<long>
{
public static readonly long[] Value=A277678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277678.Bytes);
public long this[int i]=>Value[i];

public static A277678Inst Instance=new A277678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277679
{
public static readonly long[] Value={ 1L,3L,2L,7L,4L,5L,13L,6L,9L,8L,17L,10L,11L,14L,15L,23L,16L,19L,12L,25L,18L,33L,26L,27L,20L,21L,24L,31L,49L,32L,39L,22L,29L,28L,35L,34L,53L,36L,43L,30L,37L,40L,41L,50L,51L,59L,52L,55L,42L,45L,38L,61L,44L,67L,54L,85L,68L,69L,62L,63L,46L,47L,56L,57L,60L,77L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277679Inst : IEnumerable<long>
{
public static readonly long[] Value=A277679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277679.Bytes);
public long this[int i]=>Value[i];

public static A277679Inst Instance=new A277679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277680
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,8L,4L,10L,9L,12L,13L,19L,7L,14L,15L,17L,11L,21L,18L,25L,26L,32L,16L,27L,20L,23L,24L,34L,33L,40L,28L,30L,22L,36L,35L,38L,41L,51L,31L,42L,43L,49L,39L,53L,50L,61L,62L,72L,29L,44L,45L,47L,37L,55L,48L,63L,64L,70L,46L,65L,52L,59L,60L,74L,73L,84L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277680Inst : IEnumerable<long>
{
public static readonly long[] Value=A277680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277680.Bytes);
public long this[int i]=>Value[i];

public static A277680Inst Instance=new A277680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277681
{
public static readonly long[] Value={ 2L,0L,6L,2L,2L,7L,7L,7L,2L,9L,5L,9L,8L,2L,8L,3L,8L,8L,4L,9L,7L,8L,4L,8L,6L,7L,2L,0L,0L,0L,8L,0L,4L,5L,9L,5L,1L,2L,8L,3L,5L,9L,2L,3L,0L,6L,7L,0L,4L,5L,9L,1L,6L,1L,3L,1L,0L,0L,9L,8L,4L,2L,0L,0L,0L,0L,4L,9L,4L,9L,8L,8L,0L,5L,3L,4L,8L,5L,2L,9L,5L,4L,7L,3L,7L,8L,9L,2L,4L,9L,9L,0L,0L,4L,2L,5L,3L,8L,6L,3L,3L,6L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277681Inst : IEnumerable<long>
{
public static readonly long[] Value=A277681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277681.Bytes);
public long this[int i]=>Value[i];

public static A277681Inst Instance=new A277681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277682
{
public static readonly long[] Value={ 7L,5L,8L,8L,6L,3L,1L,1L,7L,8L,4L,7L,2L,5L,1L,2L,6L,2L,2L,5L,6L,8L,9L,2L,3L,9L,5L,4L,1L,0L,7L,5L,8L,4L,3L,8L,3L,0L,1L,3L,4L,7L,3L,6L,7L,1L,9L,9L,2L,8L,5L,6L,3L,6L,0L,4L,0L,9L,4L,3L,7L,4L,3L,7L,3L,6L,4L,3L,2L,2L,7L,5L,6L,0L,2L,3L,4L,0L,4L,8L,7L,2L,5L,0L,4L,7L,3L,3L,2L,7L,1L,5L,4L,7L,0L,5L,0L,1L,9L,3L,0L,5L,0L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277682Inst : IEnumerable<long>
{
public static readonly long[] Value=A277682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277682.Bytes);
public long this[int i]=>Value[i];

public static A277682Inst Instance=new A277682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277683
{
public static readonly long[] Value={ 7L,8L,6L,3L,8L,6L,1L,1L,7L,6L,0L,9L,4L,2L,3L,2L,6L,6L,8L,8L,4L,2L,5L,7L,3L,6L,2L,3L,4L,8L,7L,3L,8L,2L,3L,2L,1L,4L,6L,8L,3L,2L,0L,2L,0L,7L,7L,7L,9L,8L,9L,3L,4L,6L,0L,2L,9L,4L,1L,4L,4L,5L,3L,0L,5L,7L,4L,5L,8L,5L,9L,2L,4L,3L,3L,2L,5L,2L,0L,4L,5L,8L,8L,8L,0L,1L,1L,0L,4L,5L,8L,7L,4L,9L,0L,6L,6L,4L,4L,6L,4L,0L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277683Inst : IEnumerable<long>
{
public static readonly long[] Value=A277683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277683.Bytes);
public long this[int i]=>Value[i];

public static A277683Inst Instance=new A277683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277684
{
public static readonly long[] Value={ 0L,6L,17L,18L,69L,70L,297L,298L,299L,300L,300L,301L,302L,303L,304L,305L,306L,307L,464L,465L,466L,467L,624L,625L,1810L,1811L,1812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277684Inst : IEnumerable<long>
{
public static readonly long[] Value=A277684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277684.Bytes);
public long this[int i]=>Value[i];

public static A277684Inst Instance=new A277684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277685
{
public static readonly long[] Value={ 26L,21L,4L,20L,17L,3L,19L,19L,15L,14L,4L,15L,4L,20L,17L,17L,4L,4L,4L,4L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,19L,19L,19L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277685Inst : IEnumerable<long>
{
public static readonly long[] Value=A277685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277685.Bytes);
public long this[int i]=>Value[i];

public static A277685Inst Instance=new A277685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277686
{
public static readonly long[] Value={ 1L,1L,2L,5L,20L,91L,823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277686Inst : IEnumerable<long>
{
public static readonly long[] Value=A277686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277686.Bytes);
public long this[int i]=>Value[i];

public static A277686Inst Instance=new A277686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277687
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,4L,2L,4L,2L,18L,2L,29L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277687Inst : IEnumerable<long>
{
public static readonly long[] Value=A277687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277687.Bytes);
public long this[int i]=>Value[i];

public static A277687Inst Instance=new A277687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277688
{
public static readonly long[] Value={ 1L,3L,5L,19L,29L,31L,43L,49L,55L,59L,61L,71L,79L,83L,89L,91L,101L,109L,113L,115L,119L,125L,127L,131L,139L,149L,151L,155L,161L,163L,167L,169L,175L,179L,191L,193L,197L,199L,203L,209L,211L,215L,223L,227L,229L,239L,241L,247L,251L,253L,259L,265L,269L,271L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277688Inst : IEnumerable<long>
{
public static readonly long[] Value=A277688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277688.Bytes);
public long this[int i]=>Value[i];

public static A277688Inst Instance=new A277688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277689
{
public static readonly long[] Value={ 13L,17L,23L,37L,43L,47L,53L,67L,73L,83L,97L,103L,107L,211L,307L,311L,503L,607L,811L,907L,911L,1151L,1181L,1373L,1787L,2003L,2011L,2131L,2383L,2797L,3011L,3181L,3191L,3313L,3373L,3727L,3797L,3919L,3929L,4003L,4007L,4373L,4787L,4919L,5003L,5011L,5101L,6007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277689Inst : IEnumerable<long>
{
public static readonly long[] Value=A277689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277689.Bytes);
public long this[int i]=>Value[i];

public static A277689Inst Instance=new A277689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277690
{
public static readonly long[] Value={ 2L,6L,13L,19L,26L,32L,38L,44L,51L,57L,63L,70L,76L,82L,88L,95L,101L,107L,114L,120L,126L,132L,139L,145L,151L,158L,164L,170L,176L,183L,189L,195L,202L,208L,214L,220L,227L,233L,239L,246L,252L,258L,264L,271L,277L,283L,290L,296L,302L,308L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277690Inst : IEnumerable<long>
{
public static readonly long[] Value=A277690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277690.Bytes);
public long this[int i]=>Value[i];

public static A277690Inst Instance=new A277690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277691
{
public static readonly long[] Value={ 1L,12L,710L,267L,159L,164L,76L,90L,16285L,2168L,3832L,7773L,29849L,34731L,1496L,23485L,51130L,17658L,38908L,38639L,270845L,450432L,57050L,145850L,631632L,240947L,398108L,306349L,288481L,410531L,1516421L,2621329L,781173L,333140L,2997665L,948049L,593835L,1506645L,1216039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277691Inst : IEnumerable<long>
{
public static readonly long[] Value=A277691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277691.Bytes);
public long this[int i]=>Value[i];

public static A277691Inst Instance=new A277691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277692
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,4L,1L,2L,3L,4L,1L,3L,1L,4L,3L,2L,1L,6L,2L,2L,3L,4L,1L,4L,1L,5L,3L,2L,3L,6L,1L,2L,3L,6L,1L,4L,1L,4L,5L,2L,1L,8L,2L,3L,3L,4L,1L,4L,3L,6L,3L,2L,1L,8L,1L,2L,5L,6L,3L,4L,1L,4L,3L,4L,1L,9L,1L,2L,5L,4L,3L,4L,1L,8L,4L,2L,1L,8L,3L,2L,3L,6L,1L,6L,3L,4L,3L,2L,3L,10L,1L,3L,5L,6L,1L,4L,1L,6L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277692Inst : IEnumerable<long>
{
public static readonly long[] Value=A277692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277692.Bytes);
public long this[int i]=>Value[i];

public static A277692Inst Instance=new A277692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277693
{
public static readonly long[] Value={ 1L,12L,33277L,4177L,278L,3680912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277693Inst : IEnumerable<long>
{
public static readonly long[] Value=A277693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277693.Bytes);
public long this[int i]=>Value[i];

public static A277693Inst Instance=new A277693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277694
{
public static readonly long[] Value={ 11L,13L,15L,17L,19L,31L,33L,35L,37L,39L,51L,53L,55L,57L,59L,71L,73L,75L,77L,79L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,122L,124L,126L,128L,130L,131L,132L,133L,134L,135L,136L,137L,138L,139L,140L,142L,144L,146L,148L,150L,151L,152L,153L,154L,155L,156L,157L,158L,159L,160L,162L,164L,166L,168L,170L,171L,172L,173L,174L,175L,176L,177L,178L,179L,180L,182L,184L,186L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277694Inst : IEnumerable<long>
{
public static readonly long[] Value=A277694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277694.Bytes);
public long this[int i]=>Value[i];

public static A277694Inst Instance=new A277694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277695
{
public static readonly long[] Value={ 1L,2L,4L,8L,3L,16L,6L,32L,12L,5L,13L,64L,7L,24L,10L,26L,128L,14L,27L,17L,25L,49L,48L,20L,257L,11L,21L,52L,15L,256L,28L,54L,34L,50L,55L,98L,515L,99L,9L,65L,31L,29L,97L,105L,51L,96L,40L,514L,22L,101L,43L,35L,1031L,513L,81L,42L,69L,23L,57L,104L,63L,30L,512L,56L,108L,68L,111L,100L,139L,199L,163L,110L,196L,203L,19L,211L,2063L,33L,195L,53L,1030L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277695Inst : IEnumerable<long>
{
public static readonly long[] Value=A277695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277695.Bytes);
public long this[int i]=>Value[i];

public static A277695Inst Instance=new A277695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277696
{
public static readonly long[] Value={ 1L,2L,5L,3L,10L,7L,13L,4L,39L,15L,26L,9L,11L,18L,29L,6L,20L,92L,75L,24L,27L,49L,58L,14L,21L,16L,19L,31L,42L,62L,41L,8L,78L,33L,52L,270L,172L,196L,147L,47L,312L,56L,51L,126L,101L,143L,82L,23L,22L,34L,45L,28L,80L,32L,35L,64L,59L,96L,90L,153L,118L,95L,61L,12L,40L,224L,150L,66L,57L,129L,116L,1134L,534L,606L,316L,752L,404L,520L,207L,120L,55L,1400L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277696Inst : IEnumerable<long>
{
public static readonly long[] Value=A277696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277696.Bytes);
public long this[int i]=>Value[i];

public static A277696Inst Instance=new A277696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277697
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,0L,0L,1L,5L,2L,6L,1L,2L,0L,7L,1L,8L,3L,2L,1L,9L,2L,0L,1L,0L,4L,10L,1L,11L,0L,2L,1L,3L,0L,12L,1L,2L,3L,13L,1L,14L,5L,3L,1L,15L,2L,0L,1L,2L,6L,16L,1L,3L,4L,2L,1L,17L,2L,18L,1L,4L,0L,3L,1L,19L,7L,2L,1L,20L,0L,21L,1L,2L,8L,4L,1L,22L,3L,0L,1L,23L,2L,3L,1L,2L,5L,24L,1L,4L,9L,2L,1L,3L,2L,25L,1L,5L,0L,26L,1L,27L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277697Inst : IEnumerable<long>
{
public static readonly long[] Value=A277697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277697.Bytes);
public long this[int i]=>Value[i];

public static A277697Inst Instance=new A277697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277698
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,2L,7L,1L,1L,2L,11L,3L,13L,2L,3L,1L,17L,2L,19L,5L,3L,2L,23L,3L,1L,2L,1L,7L,29L,2L,31L,1L,3L,2L,5L,1L,37L,2L,3L,5L,41L,2L,43L,11L,5L,2L,47L,3L,1L,2L,3L,13L,53L,2L,5L,7L,3L,2L,59L,3L,61L,2L,7L,1L,5L,2L,67L,17L,3L,2L,71L,1L,73L,2L,3L,19L,7L,2L,79L,5L,1L,2L,83L,3L,5L,2L,3L,11L,89L,2L,7L,23L,3L,2L,5L,3L,97L,2L,11L,1L,101L,2L,103L,13L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277698Inst : IEnumerable<long>
{
public static readonly long[] Value=A277698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277698.Bytes);
public long this[int i]=>Value[i];

public static A277698Inst Instance=new A277698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277699
{
public static readonly long[] Value={ 1L,4L,9L,16L,57L,36L,49L,64L,209L,228L,217L,144L,233L,196L,225L,256L,801L,836L,809L,912L,793L,868L,785L,576L,1009L,932L,1017L,784L,969L,900L,961L,1024L,3137L,3204L,3145L,3344L,3193L,3236L,3185L,3648L,3217L,3172L,3225L,3472L,3241L,3140L,3233L,2304L,3937L,4036L,3945L,3728L,3929L,4068L,3921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277699Inst : IEnumerable<long>
{
public static readonly long[] Value=A277699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277699.Bytes);
public long this[int i]=>Value[i];

public static A277699Inst Instance=new A277699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277700
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,2L,3L,1L,2L,1L,3L,2L,1L,3L,4L,1L,3L,2L,3L,1L,2L,3L,3L,2L,3L,1L,4L,3L,1L,4L,5L,1L,4L,3L,3L,2L,3L,3L,2L,1L,1L,2L,3L,3L,2L,3L,3L,2L,3L,3L,4L,1L,3L,4L,3L,3L,4L,1L,5L,4L,1L,5L,6L,1L,5L,4L,3L,3L,4L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,1L,2L,1L,3L,2L,1L,3L,4L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,4L,3L,3L,4L,3L,1L,2L,3L,3L,4L,3L,3L,4L,3L,3L,4L,5L,1L,4L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277700Inst : IEnumerable<long>
{
public static readonly long[] Value=A277700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277700.Bytes);
public long this[int i]=>Value[i];

public static A277700Inst Instance=new A277700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277701
{
public static readonly long[] Value={ 1L,5L,13L,29L,41L,61L,85L,125L,173L,209L,253L,281L,313L,349L,421L,509L,565L,629L,701L,845L,929L,1021L,1133L,1261L,1405L,1693L,1861L,2045L,2269L,2525L,2665L,2813L,3121L,3313L,3389L,3725L,3905L,4093L,4541L,4841L,5053L,5209L,5257L,5333L,5629L,5993L,6245L,6629L,6781L,7453L,7813L,8189L,8537L,9085L,9593L,9685L,9905L,10109L,10421L,10517L,10669L,10921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277701Inst : IEnumerable<long>
{
public static readonly long[] Value=A277701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277701.Bytes);
public long this[int i]=>Value[i];

public static A277701Inst Instance=new A277701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277702
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,9L,11L,13L,17L,19L,21L,27L,35L,37L,41L,43L,51L,53L,69L,73L,75L,83L,85L,107L,139L,147L,149L,165L,171L,213L,275L,277L,293L,299L,331L,339L,341L,427L,555L,587L,595L,597L,661L,677L,683L,853L,1107L,1109L,1171L,1173L,1189L,1195L,1323L,1355L,1363L,1365L,1707L,2213L,2219L,2347L,2379L,2387L,2389L,2645L,2709L,2731L,3413L,4427L,4435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277702Inst : IEnumerable<long>
{
public static readonly long[] Value=A277702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277702.Bytes);
public long this[int i]=>Value[i];

public static A277702Inst Instance=new A277702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277703
{
public static readonly BigInteger[] Value={ 1L,2L,3L,6L,18L,30L,90L,270L,450L,630L,6750L,20250L,47250L,330750L,3543750L,4961250L,53156250L,57881250L,173643750L,1910081250L,9550406250L,455814843750L,3190703906250L,34186113281250L,245684200781250L,29727788294531250L,3310594605527343750L,BigInteger.Parse("158005651627441406250"),BigInteger.Parse("1738062167901855468750"),BigInteger.Parse("414764835522033691406250") };
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
public class A277703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277703Inst Instance=new A277703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277704
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,14L,15L,16L,24L,28L,30L,31L,32L,48L,56L,60L,62L,63L,64L,83L,96L,112L,120L,124L,126L,127L,128L,166L,192L,224L,240L,248L,252L,254L,255L,256L,332L,365L,384L,448L,480L,496L,504L,508L,510L,511L,512L,664L,730L,768L,896L,960L,992L,1008L,1016L,1020L,1022L,1023L,1024L,1328L,1460L,1536L,1792L,1920L,1984L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277704Inst : IEnumerable<long>
{
public static readonly long[] Value=A277704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277704.Bytes);
public long this[int i]=>Value[i];

public static A277704Inst Instance=new A277704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277705
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,4L,8L,2L,12L,6L,16L,4L,18L,8L,16L,2L,24L,12L,32L,6L,40L,16L,48L,4L,48L,18L,64L,8L,54L,16L,32L,2L,48L,24L,96L,12L,120L,32L,120L,6L,150L,40L,168L,16L,180L,48L,144L,4L,144L,48L,192L,18L,240L,64L,240L,8L,192L,54L,256L,16L,162L,32L,64L,2L,96L,48L,288L,24L,480L,96L,400L,12L,560L,120L,540L,32L,480L,120L,480L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277705Inst : IEnumerable<long>
{
public static readonly long[] Value=A277705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277705.Bytes);
public long this[int i]=>Value[i];

public static A277705Inst Instance=new A277705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277706
{
public static readonly long[] Value={ 5L,9L,10L,11L,13L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,29L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,61L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,97L,98L,99L,100L,101L,102L,103L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277706Inst : IEnumerable<long>
{
public static readonly long[] Value=A277706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277706.Bytes);
public long this[int i]=>Value[i];

public static A277706Inst Instance=new A277706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277707
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,1L,4L,1L,0L,1L,5L,2L,6L,1L,2L,0L,7L,1L,8L,3L,2L,1L,9L,1L,0L,1L,2L,4L,10L,1L,11L,1L,2L,1L,3L,0L,12L,1L,2L,1L,13L,1L,14L,5L,3L,1L,15L,2L,0L,1L,2L,6L,16L,1L,3L,1L,2L,1L,17L,2L,18L,1L,4L,0L,3L,1L,19L,7L,2L,1L,20L,1L,21L,1L,2L,8L,4L,1L,22L,3L,0L,1L,23L,2L,3L,1L,2L,1L,24L,1L,4L,9L,2L,1L,3L,1L,25L,1L,5L,0L,26L,1L,27L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277707Inst : IEnumerable<long>
{
public static readonly long[] Value=A277707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277707.Bytes);
public long this[int i]=>Value[i];

public static A277707Inst Instance=new A277707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277708
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,2L,7L,2L,1L,2L,11L,3L,13L,2L,3L,1L,17L,2L,19L,5L,3L,2L,23L,2L,1L,2L,3L,7L,29L,2L,31L,2L,3L,2L,5L,1L,37L,2L,3L,2L,41L,2L,43L,11L,5L,2L,47L,3L,1L,2L,3L,13L,53L,2L,5L,2L,3L,2L,59L,3L,61L,2L,7L,1L,5L,2L,67L,17L,3L,2L,71L,2L,73L,2L,3L,19L,7L,2L,79L,5L,1L,2L,83L,3L,5L,2L,3L,2L,89L,2L,7L,23L,3L,2L,5L,2L,97L,2L,11L,1L,101L,2L,103L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277708Inst : IEnumerable<long>
{
public static readonly long[] Value=A277708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277708.Bytes);
public long this[int i]=>Value[i];

public static A277708Inst Instance=new A277708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277709
{
public static readonly long[] Value={ 1L,2L,5L,3L,10L,13L,4L,39L,26L,29L,9L,20L,75L,58L,41L,6L,21L,52L,147L,82L,61L,7L,78L,45L,116L,207L,122L,85L,8L,11L,150L,93L,164L,291L,170L,125L,81L,40L,19L,294L,189L,244L,411L,250L,173L,18L,105L,104L,35L,414L,381L,340L,579L,346L,209L,23L,42L,165L,232L,67L,582L,657L,500L,819L,418L,253L,12L,43L,90L,213L,328L,131L,822L,765L,692L,927L,506L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277709Inst : IEnumerable<long>
{
public static readonly long[] Value=A277709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277709.Bytes);
public long this[int i]=>Value[i];

public static A277709Inst Instance=new A277709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277710
{
public static readonly long[] Value={ 1L,5L,2L,13L,10L,3L,29L,26L,39L,4L,41L,58L,75L,20L,9L,61L,82L,147L,52L,21L,6L,85L,122L,207L,116L,45L,78L,7L,125L,170L,291L,164L,93L,150L,11L,8L,173L,250L,411L,244L,189L,294L,19L,40L,81L,209L,346L,579L,340L,381L,414L,35L,104L,105L,18L,253L,418L,819L,500L,657L,582L,67L,232L,165L,42L,23L,281L,506L,927L,692L,765L,822L,131L,328L,213L,90L,43L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277710Inst : IEnumerable<long>
{
public static readonly long[] Value=A277710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277710.Bytes);
public long this[int i]=>Value[i];

public static A277710Inst Instance=new A277710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277711
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,9L,6L,7L,8L,81L,18L,23L,12L,17L,14L,15L,16L,153L,162L,47L,36L,49L,46L,87L,24L,73L,34L,159L,28L,33L,30L,31L,32L,177L,306L,95L,324L,97L,94L,303L,72L,137L,98L,111L,92L,297L,174L,175L,48L,145L,146L,135L,68L,1257L,318L,295L,56L,321L,66L,143L,60L,65L,62L,63L,64L,273L,354L,191L,612L,193L,190L,1119L,648L,265L,194L,1335L,188L,1233L,606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277711Inst : IEnumerable<long>
{
public static readonly long[] Value=A277711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277711.Bytes);
public long this[int i]=>Value[i];

public static A277711Inst Instance=new A277711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277712
{
public static readonly long[] Value={ 2L,10L,26L,58L,82L,122L,170L,250L,346L,418L,506L,562L,626L,698L,842L,1018L,1130L,1258L,1402L,1690L,1858L,2042L,2266L,2522L,2810L,3386L,3722L,4090L,4538L,5050L,5330L,5626L,6242L,6626L,6778L,7450L,7810L,8186L,9082L,9682L,10106L,10418L,10514L,10666L,11258L,11986L,12490L,13258L,13562L,14906L,15626L,16378L,17074L,18170L,19186L,19370L,19810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277712Inst : IEnumerable<long>
{
public static readonly long[] Value=A277712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277712.Bytes);
public long this[int i]=>Value[i];

public static A277712Inst Instance=new A277712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277713
{
public static readonly long[] Value={ 3L,39L,75L,147L,207L,291L,411L,579L,819L,927L,1155L,1635L,1851L,2307L,2487L,2583L,2919L,3267L,3699L,3903L,4611L,4971L,5163L,5835L,6531L,7395L,7803L,9219L,9939L,10323L,10839L,11667L,13059L,14787L,15603L,15999L,17895L,18435L,19875L,20295L,20643L,21675L,23331L,26115L,29571L,31203L,31995L,33327L,34383L,35787L,36867L,39747L,40587L,41283L,43347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277713Inst : IEnumerable<long>
{
public static readonly long[] Value=A277713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277713.Bytes);
public long this[int i]=>Value[i];

public static A277713Inst Instance=new A277713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277714
{
public static readonly long[] Value={ 1L,13L,25L,49L,69L,97L,137L,193L,273L,309L,385L,545L,617L,769L,829L,861L,973L,1089L,1233L,1301L,1537L,1657L,1721L,1945L,2177L,2465L,2601L,3073L,3313L,3441L,3613L,3889L,4353L,4929L,5201L,5333L,5965L,6145L,6625L,6765L,6881L,7225L,7777L,8705L,9857L,10401L,10665L,11109L,11461L,11929L,12289L,13249L,13529L,13761L,14449L,14749L,15553L,17197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277714Inst : IEnumerable<long>
{
public static readonly long[] Value=A277714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277714.Bytes);
public long this[int i]=>Value[i];

public static A277714Inst Instance=new A277714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277715
{
public static readonly long[] Value={ 9L,21L,45L,93L,189L,381L,657L,765L,873L,1317L,1533L,1749L,2457L,2637L,3069L,3501L,4329L,4917L,5241L,5277L,5745L,6141L,6345L,7005L,8661L,9561L,9837L,10017L,10485L,10557L,11493L,12285L,12693L,14013L,15129L,17325L,17985L,19125L,19677L,20037L,20973L,21117L,21969L,22989L,24573L,25389L,26793L,28029L,30261L,31545L,34653L,35973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277715Inst : IEnumerable<long>
{
public static readonly long[] Value=A277715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277715.Bytes);
public long this[int i]=>Value[i];

public static A277715Inst Instance=new A277715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277716
{
public static readonly long[] Value={ 3L,7L,15L,31L,63L,127L,219L,255L,291L,439L,511L,583L,819L,879L,1023L,1167L,1443L,1639L,1747L,1759L,1915L,2047L,2115L,2335L,2887L,3187L,3279L,3339L,3495L,3519L,3831L,4095L,4231L,4671L,5043L,5775L,5995L,6375L,6559L,6679L,6991L,7039L,7323L,7663L,8191L,8463L,8931L,9343L,10087L,10515L,11551L,11991L,12531L,12751L,12827L,13119L,13359L,13983L,14079L,14647L,15327L,16383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277716Inst : IEnumerable<long>
{
public static readonly long[] Value=A277716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277716.Bytes);
public long this[int i]=>Value[i];

public static A277716Inst Instance=new A277716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277717
{
public static readonly long[] Value={ 3L,5L,7L,13L,19L,23L,29L,37L,43L,47L,61L,67L,71L,73L,79L,89L,97L,103L,109L,113L,151L,179L,181L,193L,211L,223L,233L,241L,277L,281L,283L,293L,307L,313L,331L,337L,347L,349L,359L,373L,379L,383L,397L,401L,409L,419L,421L,443L,449L,463L,467L,479L,487L,523L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277717Inst : IEnumerable<long>
{
public static readonly long[] Value=A277717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277717.Bytes);
public long this[int i]=>Value[i];

public static A277717Inst Instance=new A277717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277718
{
public static readonly long[] Value={ 5L,11L,17L,29L,37L,53L,127L,149L,211L,223L,307L,331L,541L,1361L,1693L,1973L,2203L,2503L,2999L,3299L,4327L,4861L,5623L,5779L,5981L,6521L,6947L,7283L,8501L,9587L,10007L,10831L,11777L,15727L,19661L,31469L,34123L,35671L,35729L,43391L,44351L,45943L,48731L,58889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277718Inst : IEnumerable<long>
{
public static readonly long[] Value=A277718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277718.Bytes);
public long this[int i]=>Value[i];

public static A277718Inst Instance=new A277718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277719
{
public static readonly long[] Value={ 3L,5L,7L,10L,12L,16L,31L,35L,47L,48L,63L,67L,100L,218L,264L,298L,328L,368L,430L,463L,591L,651L,739L,758L,782L,843L,891L,929L,1060L,1184L,1230L,1316L,1410L,1832L,2226L,3386L,3645L,3794L,3796L,4523L,4613L,4755L,5009L,5950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277719Inst : IEnumerable<long>
{
public static readonly long[] Value=A277719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277719.Bytes);
public long this[int i]=>Value[i];

public static A277719Inst Instance=new A277719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277720
{
public static readonly ulong[] Value={ 2320690177L,17069520863233L,42182344790209L,65465530560001L,3432376805760001L,13322002122777601L,20388795375960001L,129009714848870401L,580007888606160001L,1096591987029196801L,3029756968906340401L,5806765663003468801L,6213994663149504001L,6367205158826803201L,7802569551798000001L,10319507991273499201UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277720Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A277720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277720.Bytes);
public ulong this[int i]=>Value[i];

public static A277720Inst Instance=new A277720Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277721
{
public static readonly long[] Value={ 2L,1L,1L,0L,3L,2L,2L,1L,1L,1L,0L,2L,1L,2L,1L,1L,0L,3L,2L,2L,1L,0L,1L,0L,2L,1L,2L,1L,3L,2L,2L,2L,1L,1L,0L,3L,2L,2L,1L,1L,1L,3L,2L,2L,2L,1L,1L,0L,2L,2L,2L,1L,0L,1L,0L,2L,1L,1L,1L,1L,0L,2L,2L,2L,1L,0L,0L,0L,2L,1L,1L,1L,3L,2L,2L,1L,1L,1L,0L,2L,2L,2L,1L,1L,0L,3L,2L,2L,1L,1L,1L,0L,2L,1L,2L,1L,1L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277721Inst : IEnumerable<long>
{
public static readonly long[] Value=A277721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277721.Bytes);
public long this[int i]=>Value[i];

public static A277721Inst Instance=new A277721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277722
{
public static readonly long[] Value={ 0L,3L,6L,10L,13L,16L,20L,23L,27L,30L,33L,37L,40L,43L,47L,50L,54L,57L,60L,64L,67L,71L,74L,77L,81L,84L,87L,91L,94L,98L,101L,104L,108L,111L,115L,118L,121L,125L,128L,131L,135L,138L,142L,145L,148L,152L,155L,158L,162L,165L,169L,172L,175L,179L,182L,186L,189L,192L,196L,199L,202L,206L,209L,213L,216L,219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277722Inst : IEnumerable<long>
{
public static readonly long[] Value=A277722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277722.Bytes);
public long this[int i]=>Value[i];

public static A277722Inst Instance=new A277722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277723
{
public static readonly long[] Value={ 0L,6L,12L,18L,24L,31L,37L,43L,49L,56L,62L,68L,74L,80L,87L,93L,99L,105L,112L,118L,124L,130L,136L,143L,149L,155L,161L,168L,174L,180L,186L,192L,199L,205L,211L,217L,224L,230L,236L,242L,248L,255L,261L,267L,273L,280L,286L,292L,298L,304L,311L,317L,323L,329L,336L,342L,348L,354L,360L,367L,373L,379L,385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277723Inst : IEnumerable<long>
{
public static readonly long[] Value=A277723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277723.Bytes);
public long this[int i]=>Value[i];

public static A277723Inst Instance=new A277723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277724
{
public static readonly long[] Value={ 0L,3L,16L,20L,23L,27L,33L,40L,47L,57L,60L,64L,71L,77L,84L,91L,101L,104L,108L,115L,121L,125L,128L,145L,148L,152L,158L,165L,169L,172L,182L,189L,196L,202L,206L,209L,213L,226L,233L,240L,246L,250L,253L,257L,263L,270L,274L,277L,290L,294L,297L,301L,307L,314L,321L,331L,334L,338L,345L,351L,358L,375L,378L,382L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277724Inst : IEnumerable<long>
{
public static readonly long[] Value=A277724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277724.Bytes);
public long this[int i]=>Value[i];

public static A277724Inst Instance=new A277724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277725
{
public static readonly long[] Value={ 0L,12L,18L,31L,49L,62L,68L,80L,93L,99L,112L,130L,136L,143L,161L,174L,180L,211L,217L,224L,242L,248L,255L,261L,286L,292L,323L,329L,336L,342L,354L,360L,367L,373L,404L,410L,423L,435L,441L,448L,454L,472L,485L,491L,516L,522L,535L,553L,560L,566L,572L,584L,597L,603L,616L,634L,640L,647L,665L,678L,684L,709L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277725Inst : IEnumerable<long>
{
public static readonly long[] Value=A277725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277725.Bytes);
public long this[int i]=>Value[i];

public static A277725Inst Instance=new A277725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277726
{
public static readonly long[] Value={ 0L,6L,37L,43L,74L,87L,118L,155L,186L,192L,199L,230L,236L,267L,280L,304L,311L,317L,348L,385L,392L,416L,429L,460L,466L,497L,504L,510L,541L,578L,622L,659L,690L,696L,703L,734L,740L,771L,784L,808L,815L,852L,889L,896L,920L,933L,964L,970L,1001L,1008L,1014L,1045L,1082L,1126L,1163L,1194L,1200L,1207L,1238L,1244L,1275L,1288L,1312L,1319L,1356L,1387L,1393L,1400L,1424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277726Inst : IEnumerable<long>
{
public static readonly long[] Value=A277726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277726.Bytes);
public long this[int i]=>Value[i];

public static A277726Inst Instance=new A277726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277727
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,16L,18L,20L,22L,23L,24L,25L,27L,29L,30L,31L,33L,34L,36L,37L,38L,40L,42L,43L,44L,45L,47L,49L,50L,51L,53L,54L,55L,56L,57L,58L,60L,62L,64L,66L,67L,68L,69L,71L,73L,74L,75L,77L,79L,80L,81L,82L,84L,86L,87L,88L,90L,91L,93L,94L,95L,97L,98L,99L,101L,103L,104L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277727Inst : IEnumerable<long>
{
public static readonly long[] Value=A277727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277727.Bytes);
public long this[int i]=>Value[i];

public static A277727Inst Instance=new A277727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277728
{
public static readonly long[] Value={ 2L,4L,8L,15L,17L,19L,21L,26L,28L,32L,35L,39L,41L,46L,48L,52L,59L,61L,63L,65L,70L,72L,76L,78L,83L,85L,89L,92L,96L,100L,102L,107L,109L,113L,116L,120L,122L,127L,129L,133L,140L,144L,146L,151L,153L,157L,159L,164L,166L,170L,173L,177L,181L,184L,188L,190L,195L,197L,201L,203L,208L,210L,212L,214L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277728Inst : IEnumerable<long>
{
public static readonly long[] Value=A277728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277728.Bytes);
public long this[int i]=>Value[i];

public static A277728Inst Instance=new A277728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277729
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,0L,1L,1L,3L,0L,1L,1L,3L,0L,2L,1L,4L,0L,2L,1L,4L,0L,3L,1L,4L,0L,3L,0L,1L,1L,5L,0L,3L,0L,1L,1L,5L,0L,3L,0L,2L,1L,5L,0L,4L,0L,2L,1L,6L,0L,4L,0L,2L,1L,6L,0L,5L,0L,2L,1L,6L,0L,5L,0L,3L,1L,6L,0L,5L,0L,4L,1L,7L,0L,5L,0L,4L,1L,7L,0L,5L,0L,5L,1L,7L,0L,6L,0L,5L,1L,8L,0L,6L,0L,5L,1L,8L,0L,6L,0L,6L,1L,8L,0L,7L,0L,6L,1L,8L,0L,7L,0L,7L,1L,8L,0L,7L,0L,7L,0L,1L,1L,8L,0L,8L,0L,7L,0L,1L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277729Inst : IEnumerable<long>
{
public static readonly long[] Value=A277729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277729.Bytes);
public long this[int i]=>Value[i];

public static A277729Inst Instance=new A277729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277730
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,1L,3L,2L,4L,2L,4L,3L,4L,3L,1L,5L,3L,1L,5L,3L,2L,5L,4L,2L,6L,4L,2L,6L,5L,2L,6L,5L,3L,6L,5L,4L,7L,5L,4L,7L,5L,5L,7L,6L,5L,8L,6L,5L,8L,6L,6L,8L,7L,6L,8L,7L,7L,8L,7L,7L,1L,8L,8L,7L,1L,9L,8L,7L,1L,9L,9L,7L,1L,10L,9L,7L,1L,10L,10L,7L,1L,10L,10L,7L,1L,0L,0L,1L,10L,11L,7L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277730Inst : IEnumerable<long>
{
public static readonly long[] Value=A277730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277730.Bytes);
public long this[int i]=>Value[i];

public static A277730Inst Instance=new A277730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277731
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,0L,1L,2L,0L,1L,0L,1L,2L,0L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277731Inst : IEnumerable<long>
{
public static readonly long[] Value=A277731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277731.Bytes);
public long this[int i]=>Value[i];

public static A277731Inst Instance=new A277731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277732
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,12L,14L,17L,19L,22L,23L,25L,27L,30L,32L,35L,36L,38L,41L,43L,46L,47L,49L,51L,54L,56L,59L,61L,64L,65L,67L,70L,72L,75L,76L,78L,80L,83L,85L,88L,89L,91L,94L,96L,99L,100L,102L,104L,107L,109L,112L,114L,117L,118L,120L,123L,125L,128L,129L,131L,134L,136L,139L,140L,142L,144L,147L,149L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277732Inst : IEnumerable<long>
{
public static readonly long[] Value=A277732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277732.Bytes);
public long this[int i]=>Value[i];

public static A277732Inst Instance=new A277732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277733
{
public static readonly long[] Value={ 2L,4L,7L,9L,13L,15L,18L,20L,24L,26L,28L,31L,33L,37L,39L,42L,44L,48L,50L,52L,55L,57L,60L,62L,66L,68L,71L,73L,77L,79L,81L,84L,86L,90L,92L,95L,97L,101L,103L,105L,108L,110L,113L,115L,119L,121L,124L,126L,130L,132L,135L,137L,141L,143L,145L,148L,150L,154L,156L,159L,161L,165L,167L,169L,172L,174L,177L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277733Inst : IEnumerable<long>
{
public static readonly long[] Value=A277733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277733.Bytes);
public long this[int i]=>Value[i];

public static A277733Inst Instance=new A277733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277734
{
public static readonly long[] Value={ 5L,10L,16L,21L,29L,34L,40L,45L,53L,58L,63L,69L,74L,82L,87L,93L,98L,106L,111L,116L,122L,127L,133L,138L,146L,151L,157L,162L,170L,175L,180L,186L,191L,199L,204L,210L,215L,223L,228L,233L,239L,244L,250L,255L,263L,268L,274L,279L,287L,292L,298L,303L,311L,316L,321L,327L,332L,340L,345L,351L,356L,364L,369L,374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277734Inst : IEnumerable<long>
{
public static readonly long[] Value=A277734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277734.Bytes);
public long this[int i]=>Value[i];

public static A277734Inst Instance=new A277734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277735
{
public static readonly long[] Value={ 0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L,2L,0L,0L,0L,1L,0L,1L,2L,0L,0L,0L,1L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277735Inst : IEnumerable<long>
{
public static readonly long[] Value=A277735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277735.Bytes);
public long this[int i]=>Value[i];

public static A277735Inst Instance=new A277735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277736
{
public static readonly long[] Value={ 1L,4L,5L,6L,8L,10L,13L,14L,17L,18L,21L,22L,23L,25L,28L,29L,30L,32L,35L,36L,37L,39L,41L,44L,45L,48L,49L,50L,52L,54L,57L,58L,61L,62L,63L,65L,67L,70L,71L,74L,75L,78L,79L,80L,82L,85L,86L,87L,89L,91L,94L,95L,98L,99L,102L,103L,104L,106L,109L,110L,111L,113L,115L,118L,119L,122L,123L,126L,127L,128L,130L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277736Inst : IEnumerable<long>
{
public static readonly long[] Value=A277736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277736.Bytes);
public long this[int i]=>Value[i];

public static A277736Inst Instance=new A277736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277737
{
public static readonly long[] Value={ 2L,7L,9L,11L,15L,19L,24L,26L,31L,33L,38L,40L,42L,46L,51L,53L,55L,59L,64L,66L,68L,72L,76L,81L,83L,88L,90L,92L,96L,100L,105L,107L,112L,114L,116L,120L,124L,129L,131L,136L,138L,143L,145L,147L,151L,156L,158L,160L,164L,168L,173L,175L,180L,182L,187L,189L,191L,195L,200L,202L,204L,208L,212L,217L,219L,224L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277737Inst : IEnumerable<long>
{
public static readonly long[] Value=A277737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277737.Bytes);
public long this[int i]=>Value[i];

public static A277737Inst Instance=new A277737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277738
{
public static readonly long[] Value={ 3L,12L,16L,20L,27L,34L,43L,47L,56L,60L,69L,73L,77L,84L,93L,97L,101L,108L,117L,121L,125L,132L,139L,148L,152L,161L,165L,169L,176L,183L,192L,196L,205L,209L,213L,220L,227L,236L,240L,249L,253L,262L,266L,270L,277L,286L,290L,294L,301L,308L,317L,321L,330L,334L,343L,347L,351L,358L,367L,371L,375L,382L,389L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277738Inst : IEnumerable<long>
{
public static readonly long[] Value=A277738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277738.Bytes);
public long this[int i]=>Value[i];

public static A277738Inst Instance=new A277738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277739
{
public static readonly long[] Value={ 1L,3L,7L,30L,124L,733L,4586L,33373L,259434L,2152298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277739Inst : IEnumerable<long>
{
public static readonly long[] Value=A277739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277739.Bytes);
public long this[int i]=>Value[i];

public static A277739Inst Instance=new A277739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277740
{
public static readonly long[] Value={ 36L,276L,2936L,35872L,484088L,6967942L,105555336L,1664142836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277740Inst : IEnumerable<long>
{
public static readonly long[] Value=A277740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277740.Bytes);
public long this[int i]=>Value[i];

public static A277740Inst Instance=new A277740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277741
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,5L,5L,2L,3L,13L,20L,13L,3L,6L,35L,83L,83L,35L,6L,12L,104L,340L,504L,340L,12L,27L,315L,1401L,2843L,2843L,1401L,316L,27L,65L,1021L,5809L,15578L,21420L,15578L,5809L,1021L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277741Inst : IEnumerable<long>
{
public static readonly long[] Value=A277741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277741.Bytes);
public long this[int i]=>Value[i];

public static A277741Inst Instance=new A277741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277742
{
public static readonly long[] Value={ 0L,6L,32L,172L,1071L,7370L,55766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277742Inst : IEnumerable<long>
{
public static readonly long[] Value=A277742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277742.Bytes);
public long this[int i]=>Value[i];

public static A277742Inst Instance=new A277742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277743
{
public static readonly long[] Value={ 3L,2L,4L,10L,33L,114L,474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277743Inst : IEnumerable<long>
{
public static readonly long[] Value=A277743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277743.Bytes);
public long this[int i]=>Value[i];

public static A277743Inst Instance=new A277743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277744
{
public static readonly long[] Value={ 1L,4L,2L,1L,6L,3L,5L,4L,2L,3L,5L,6L,1L,4L,2L,1L,6L,3L,5L,6L,1L,4L,2L,3L,5L,4L,2L,1L,6L,3L,5L,4L,2L,3L,5L,6L,1L,4L,2L,3L,5L,4L,2L,1L,6L,3L,5L,6L,1L,4L,2L,1L,6L,3L,5L,4L,2L,3L,5L,6L,1L,4L,2L,1L,6L,3L,5L,6L,1L,4L,2L,3L,5L,4L,2L,1L,6L,3L,5L,6L,1L,4L,2L,1L,6L,3L,5L,4L,2L,3L,5L,6L,1L,4L,2L,3L,5L,4L,2L,1L,6L,3L,5L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277744Inst : IEnumerable<long>
{
public static readonly long[] Value=A277744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277744.Bytes);
public long this[int i]=>Value[i];

public static A277744Inst Instance=new A277744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277745
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277745Inst : IEnumerable<long>
{
public static readonly long[] Value=A277745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277745.Bytes);
public long this[int i]=>Value[i];

public static A277745Inst Instance=new A277745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277746
{
public static readonly long[] Value={ 1L,3L,10L,47L,314L,3360L,59744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277746Inst : IEnumerable<long>
{
public static readonly long[] Value=A277746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277746.Bytes);
public long this[int i]=>Value[i];

public static A277746Inst Instance=new A277746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277747
{
public static readonly long[] Value={ 1L,6L,16L,66L,311L,1688L,10125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277747Inst : IEnumerable<long>
{
public static readonly long[] Value=A277747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277747.Bytes);
public long this[int i]=>Value[i];

public static A277747Inst Instance=new A277747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277748
{
public static readonly long[] Value={ 1L,4L,40L,768L,27648L,1900544L,253755392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277748Inst : IEnumerable<long>
{
public static readonly long[] Value=A277748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277748.Bytes);
public long this[int i]=>Value[i];

public static A277748Inst Instance=new A277748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277749
{
public static readonly long[] Value={ 2L,1L,4L,3L,2L,3L,4L,1L,6L,5L,4L,7L,10L,3L,8L,5L,2L,5L,8L,3L,10L,7L,4L,5L,6L,1L,8L,7L,6L,11L,16L,5L,14L,9L,4L,11L,18L,7L,24L,17L,10L,13L,16L,3L,14L,11L,8L,13L,18L,5L,12L,7L,2L,7L,12L,5L,18L,13L,8L,11L,14L,3L,16L,13L,10L,17L,24L,7L,18L,11L,4L,9L,14L,5L,16L,11L,6L,7L,8L,1L,10L,9L,8L,15L,22L,7L,20L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277749Inst : IEnumerable<long>
{
public static readonly long[] Value=A277749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277749.Bytes);
public long this[int i]=>Value[i];

public static A277749Inst Instance=new A277749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277750
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,3L,2L,1L,3L,5L,2L,7L,5L,3L,4L,5L,1L,5L,4L,3L,5L,7L,2L,5L,3L,1L,4L,7L,3L,11L,8L,5L,7L,9L,2L,11L,9L,7L,12L,17L,5L,13L,8L,3L,7L,11L,4L,13L,9L,5L,6L,7L,1L,7L,6L,5L,9L,13L,4L,11L,7L,3L,8L,13L,5L,17L,12L,7L,9L,11L,2L,9L,7L,5L,8L,11L,3L,7L,4L,1L,5L,9L,4L,15L,11L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277750Inst : IEnumerable<long>
{
public static readonly long[] Value=A277750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277750.Bytes);
public long this[int i]=>Value[i];

public static A277750Inst Instance=new A277750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277751
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,31L,1L,60L,4L,116L,12L,225L,30L,1L,436L,72L,4L,845L,166L,13L,1637L,375L,35L,1L,3172L,828L,92L,4L,6146L,1802L,230L,14L,11909L,3872L,562L,40L,1L,23075L,8243L,1333L,113L,4L,44711L,17404L,3106L,300L,15L,86633L,36501L,7114L,778L,45L,1L,167863L,76104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277751Inst : IEnumerable<long>
{
public static readonly long[] Value=A277751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277751.Bytes);
public long this[int i]=>Value[i];

public static A277751Inst Instance=new A277751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277752
{
public static readonly long[] Value={ 1L,0L,2L,-2L,4L,-7L,10L,-19L,27L,-49L,73L,-126L,195L,-326L,516L,-848L,1358L,-2213L,3564L,-5785L,9341L,-15135L,24467L,-39612L,64069L,-103692L,167750L,-271454L,439192L,-710659L,1149838L,-1860511L,3010335L,-4870861L,7881181L,-12752058L,20633223L,-33385298L,54018504L,-87403820L,141422306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277752Inst : IEnumerable<long>
{
public static readonly long[] Value=A277752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277752.Bytes);
public long this[int i]=>Value[i];

public static A277752Inst Instance=new A277752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277753
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,4L,8L,12L,19L,28L,42L,58L,82L,110L,150L,200L,263L,344L,450L,578L,741L,947L,1197L,1513L,1899L,2374L,2954L,3669L,4529L,5576L,6849L,8380L,10223L,12449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277753Inst : IEnumerable<long>
{
public static readonly long[] Value=A277753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277753.Bytes);
public long this[int i]=>Value[i];

public static A277753Inst Instance=new A277753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277754
{
public static readonly long[] Value={ 2L,9L,2L,5L,6L,4L,0L,8L,4L,6L,1L,0L,7L,1L,4L,2L,7L,5L,9L,7L,1L,3L,0L,8L,7L,8L,0L,4L,8L,9L,4L,1L,1L,3L,8L,6L,8L,5L,7L,2L,9L,5L,3L,3L,3L,9L,2L,7L,9L,6L,0L,3L,4L,8L,0L,8L,8L,5L,9L,8L,1L,0L,1L,9L,2L,5L,2L,0L,8L,2L,7L,6L,3L,1L,5L,4L,6L,8L,1L,0L,9L,5L,1L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277754Inst : IEnumerable<long>
{
public static readonly long[] Value=A277754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277754.Bytes);
public long this[int i]=>Value[i];

public static A277754Inst Instance=new A277754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277755
{
public static readonly long[] Value={ 4L,6L,1L,0L,8L,7L,9L,4L,6L,9L,6L,8L,7L,6L,7L,2L,0L,1L,8L,2L,8L,0L,3L,3L,2L,8L,9L,3L,9L,2L,6L,8L,5L,4L,5L,4L,9L,9L,2L,2L,7L,0L,9L,8L,0L,2L,4L,4L,6L,4L,6L,0L,3L,0L,8L,1L,8L,3L,5L,2L,2L,9L,4L,5L,2L,0L,5L,3L,1L,4L,8L,8L,7L,7L,1L,4L,5L,9L,4L,6L,4L,4L,7L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277755Inst : IEnumerable<long>
{
public static readonly long[] Value=A277755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277755.Bytes);
public long this[int i]=>Value[i];

public static A277755Inst Instance=new A277755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277756
{
public static readonly BigInteger[] Value={ 1L,5L,32L,224L,1723L,14569L,135286L,1375882L,15263414L,183817326L,2391291386L,33443618930L,500611975023L,7988044467121L,135376576319870L,2428721569276698L,45988428905194350L,916607431346170686L,BigInteger.Parse("19182997480530342168"),BigInteger.Parse("420606731490047403144") };
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
public class A277756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277756Inst Instance=new A277756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277757
{
public static readonly BigInteger[] Value={ 2L,128L,8192L,524288L,33554432L,2147483648L,137438953472L,8796093022208L,562949953421312L,36028797018963968L,2305843009213693952L,BigInteger.Parse("147573952589676412928"),BigInteger.Parse("9444732965739290427392"),BigInteger.Parse("604462909807314587353088"),BigInteger.Parse("38685626227668133590597632") };
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
public class A277757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277757Inst Instance=new A277757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277758
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,5L,7L,9L,9L,10L,10L,12L,10L,11L,12L,13L,13L,14L,12L,14L,12L,15L,15L,17L,15L,19L,19L,17L,19L,20L,21L,17L,24L,20L,20L,21L,22L,22L,20L,26L,26L,24L,26L,29L,27L,28L,26L,27L,27L,31L,28L,28L,28L,31L,29L,30L,30L,28L,29L,32L,32L,26L,26L,31L,28L,29L,28L,30L,34L,33L,34L,35L,34L,31L,37L,35L,35L,35L,37L,42L,39L,37L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277758Inst : IEnumerable<long>
{
public static readonly long[] Value=A277758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277758.Bytes);
public long this[int i]=>Value[i];

public static A277758Inst Instance=new A277758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277759
{
public static readonly BigInteger[] Value={ 1L,1L,4L,30L,324L,4540L,78060L,1589448L,37388400L,997513200L,29759790240L,981669324240L,35475203063520L,1393746645107232L,59147129937893088L,2696314664384853120L,BigInteger.Parse("131405475202661963520"),BigInteger.Parse("6817779852438948837120"),BigInteger.Parse("375193156508083422581760") };
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
public class A277759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277759Inst Instance=new A277759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277760
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,2L,1L,2L,2L,1L,2L,2L,3L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,3L,3L,4L,3L,2L,2L,3L,4L,3L,3L,2L,4L,3L,2L,3L,4L,4L,3L,2L,2L,4L,4L,3L,2L,2L,4L,3L,4L,2L,3L,4L,3L,4L,3L,3L,3L,3L,3L,2L,3L,2L,4L,3L,3L,4L,4L,4L,3L,3L,2L,4L,3L,4L,3L,3L,2L,4L,4L,4L,4L,5L,3L,4L,4L,4L,4L,4L,4L,4L,3L,3L,3L,4L,5L,4L,4L,3L,3L,4L,4L,4L,4L,5L,3L,4L,4L,4L,4L,5L,2L,4L,4L,5L,3L,5L,3L,4L,6L,4L,3L,4L,4L,5L,5L,4L,3L,3L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277760Inst : IEnumerable<long>
{
public static readonly long[] Value=A277760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277760.Bytes);
public long this[int i]=>Value[i];

public static A277760Inst Instance=new A277760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277761
{
public static readonly long[] Value={ 0L,1L,2L,14L,56L,284L,1304L,6248L,29408L,139472L,659360L,3121376L,14768000L,69887936L,330703232L,1564924544L,7405262336L,35042157824L,165821110784L,784674242048L,3713117739008L,17570663078912L,83145267845120L,393447636985856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277761Inst : IEnumerable<long>
{
public static readonly long[] Value=A277761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277761.Bytes);
public long this[int i]=>Value[i];

public static A277761Inst Instance=new A277761Inst();

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