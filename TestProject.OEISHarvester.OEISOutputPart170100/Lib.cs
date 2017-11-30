using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200557
{
public static readonly long[] Value={ 142L,4978L,43698L,211374L,737460L,2076774L,5012084L,10807826L,21368704L,39388482L,68614738L,114064374L,182196622L,281328582L,421889370L,616590012L,881040966L,1234022180L,1697613488L,2298081194L,3066132222L,4036964078L,5251498784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200557Inst : IEnumerable<long>
{
public static readonly long[] Value=A200557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200557.Bytes);
public long this[int i]=>Value[i];

public static A200557Inst Instance=new A200557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200558
{
public static readonly long[] Value={ 362L,21626L,266812L,1689732L,7286542L,24378976L,68263780L,167521092L,371147726L,758120242L,1449515972L,2623194882L,4532144132L,7526204850L,12076969112L,18807807576L,28527996642L,42270457652L,61336410730L,87344689150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200558Inst : IEnumerable<long>
{
public static readonly long[] Value=A200558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200558.Bytes);
public long this[int i]=>Value[i];

public static A200558Inst Instance=new A200558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200559
{
public static readonly long[] Value={ 778L,91058L,1639804L,13587804L,72366820L,288237528L,936121220L,2613794508L,6492378076L,14694189538L,30833955936L,60757353766L,113535692414L,202761648044L,348183768616L,577776075892L,930286238568L,1458297755836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200559Inst : IEnumerable<long>
{
public static readonly long[] Value=A200559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200559.Bytes);
public long this[int i]=>Value[i];

public static A200559Inst Instance=new A200559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200560
{
public static readonly BigInteger[] Value={ 1L,2L,6L,28L,180L,1502L,15456L,189208L,2683920L,43263962L,780807456L,15593180788L,341340941760L,8126644655222L,209050212857856L,5777935570510768L,170755837008595200L,5373097909706399282L,BigInteger.Parse("179351443518333574656"),BigInteger.Parse("6329687401322560131148"),BigInteger.Parse("235491796312126982538240") };
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
public class A200560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200560Inst Instance=new A200560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200561
{
public static readonly long[] Value={ 2L,-2L,6L,6L,-10L,70L,-42L,102L,374L,-506L,2070L,-90L,182L,16198L,-16554L,50406L,46070L,-77690L,573078L,-359898L,884534L,2980294L,-4090410L,17127270L,-1465738L,2996998L,131089686L,-136821594L,422976950L,352097350L,-600716202L,4688726502L,-3073380106L,7645103494L,23717948310L,-33014782170L,141611506742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200561Inst : IEnumerable<long>
{
public static readonly long[] Value=A200561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200561.Bytes);
public long this[int i]=>Value[i];

public static A200561Inst Instance=new A200561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200562
{
public static readonly long[] Value={ 1L,-1L,3L,3L,-5L,35L,-21L,51L,187L,-253L,1035L,-45L,91L,8099L,-8277L,25203L,23035L,-38845L,286539L,-179949L,442267L,1490147L,-2045205L,8563635L,-732869L,1498499L,65544843L,-68410797L,211488475L,176048675L,-300358101L,2344363251L,-1536690053L,3822551747L,11858974155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200562Inst : IEnumerable<long>
{
public static readonly long[] Value=A200562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200562.Bytes);
public long this[int i]=>Value[i];

public static A200562Inst Instance=new A200562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200563
{
public static readonly long[] Value={ 2L,6L,-2L,30L,14L,30L,238L,-66L,782L,990L,46L,8190L,-178L,16926L,48238L,-15810L,247694L,106590L,262318L,1932414L,-555058L,6518430L,7830766L,765630L,67043342L,-2865954L,143077678L,387537150L,-124309426L,2044005150L,807673198L,2285861694L,15681525902L,-4648416930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200563Inst : IEnumerable<long>
{
public static readonly long[] Value=A200563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200563.Bytes);
public long this[int i]=>Value[i];

public static A200563Inst Instance=new A200563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200564
{
public static readonly BigInteger[] Value={ 1L,2L,12L,288L,33280L,16793600L,34360786944L,281475110928384L,9223372071214514176UL,BigInteger.Parse("1208925819632221360750592"),BigInteger.Parse("633825300114132715146861084672"),BigInteger.Parse("1329227995784915909797295207699447808"),BigInteger.Parse("11150372599265311570918974863776009399828480") };
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
public class A200564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200564Inst Instance=new A200564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200565
{
public static readonly long[] Value={ 819L,5256L,838044L,322001299796379844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200565Inst : IEnumerable<long>
{
public static readonly long[] Value=A200565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200565.Bytes);
public long this[int i]=>Value[i];

public static A200565Inst Instance=new A200565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200566
{
public static readonly long[] Value={ 2L,4L,8L,10L,14L,20L,22L,28L,32L,34L,38L,44L,50L,52L,182L,242L,284L,528L,868L,5246L,8473L,8784L,48503L,48509L,146065L,438122L,591216L,1312724L,4325171L,6629045L,6823284L,56075700L,154392832L,248932942L,251237694L,1913253200L,3123337916L,3180792660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200566Inst : IEnumerable<long>
{
public static readonly long[] Value=A200566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200566.Bytes);
public long this[int i]=>Value[i];

public static A200566Inst Instance=new A200566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200567
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,19L,21L,27L,31L,33L,37L,43L,49L,51L,117L,201L,527L,867L,3472L,8472L,48508L,146064L,373824L,591215L,4325170L,6629044L,6823283L,30188529L,105066156L,203403620L,203403621L,323547634L,439515072L,478478082L,585101566L,1170278794L,2809596042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200567Inst : IEnumerable<long>
{
public static readonly long[] Value=A200567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200567.Bytes);
public long this[int i]=>Value[i];

public static A200567Inst Instance=new A200567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200568
{
public static readonly long[] Value={ 2L,6L,8L,12L,18L,20L,26L,30L,32L,36L,42L,48L,50L,116L,200L,212L,296L,320L,527L,3471L,8471L,48507L,85760L,104661L,283968L,1487448L,2982728L,3500623L,6748298L,6804175L,11135837L,11421278L,18567910L,25039773L,31512846L,203403620L,1170278793L,2809596041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200568Inst : IEnumerable<long>
{
public static readonly long[] Value=A200568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200568.Bytes);
public long this[int i]=>Value[i];

public static A200568Inst Instance=new A200568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200569
{
public static readonly long[] Value={ 1L,5L,7L,11L,17L,19L,25L,29L,31L,35L,41L,47L,49L,115L,119L,125L,127L,137L,139L,295L,319L,1333L,1334L,3470L,8470L,48506L,85759L,87165L,416320L,721404L,2731942L,3500623L,6804174L,8763443L,18567909L,25039772L,25039773L,37980379L,162799068L,304261639L,475527535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200569Inst : IEnumerable<long>
{
public static readonly long[] Value=A200569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200569.Bytes);
public long this[int i]=>Value[i];

public static A200569Inst Instance=new A200569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200570
{
public static readonly long[] Value={ 4L,6L,10L,16L,18L,24L,28L,30L,34L,40L,46L,48L,114L,118L,124L,126L,136L,138L,294L,318L,1332L,1333L,48505L,48509L,87164L,135990L,416319L,436744L,780358L,8763442L,25039772L,35176558L,44444364L,61575288L,100918165L,846178875L,1214569400L,2644138052L,9381631594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200570Inst : IEnumerable<long>
{
public static readonly long[] Value=A200570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200570.Bytes);
public long this[int i]=>Value[i];

public static A200570Inst Instance=new A200570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200571
{
public static readonly long[] Value={ 2L,36L,2174L,938128L,2421467558L,36460159508108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200571Inst : IEnumerable<long>
{
public static readonly long[] Value=A200571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200571.Bytes);
public long this[int i]=>Value[i];

public static A200571Inst Instance=new A200571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200572
{
public static readonly long[] Value={ 2L,6L,10L,22L,52L,114L,260L,600L,1374L,3162L,7290L,16796L,38722L,89296L,205916L,474882L,1095218L,2525902L,5825564L,13435770L,30987588L,71468368L,164831598L,380160714L,876787090L,2022186212L,4663888698L,10756605360L,24808602932L,57217567106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200572Inst : IEnumerable<long>
{
public static readonly long[] Value=A200572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200572.Bytes);
public long this[int i]=>Value[i];

public static A200572Inst Instance=new A200572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200573
{
public static readonly long[] Value={ 6L,36L,174L,922L,5202L,29180L,163706L,919924L,5171420L,29068726L,163403454L,918546962L,5163485576L,29025793202L,163164480016L,917206531060L,5155949803838L,28983459159770L,162926511803678L,915868877073788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200573Inst : IEnumerable<long>
{
public static readonly long[] Value=A200573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200573.Bytes);
public long this[int i]=>Value[i];

public static A200573Inst Instance=new A200573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200574
{
public static readonly long[] Value={ 10L,174L,2174L,28890L,388824L,5236786L,70594592L,951777602L,12832277870L,173011315794L,2332637651278L,31449955203276L,424026281913518L,5716965606842562L,77079410192481546L,1039228825310882064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200574Inst : IEnumerable<long>
{
public static readonly long[] Value=A200574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200574.Bytes);
public long this[int i]=>Value[i];

public static A200574Inst Instance=new A200574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200575
{
public static readonly BigInteger[] Value={ 22L,922L,28890L,938128L,30603332L,997303772L,32523513414L,1060675282092L,34590199046646L,1128052999950878L,36788018142626902L,1199728544485667908L,BigInteger.Parse("39125481049547004512"),BigInteger.Parse("1275958061644704120210"),BigInteger.Parse("41611474500836339304542") };
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
public class A200575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200575Inst Instance=new A200575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200576
{
public static readonly BigInteger[] Value={ 52L,5202L,388824L,30603332L,2421467558L,190970366840L,15075017283404L,1190087102438968L,93945476108897056L,7416172358628866324L,BigInteger.Parse("585443124609564375428"),BigInteger.Parse("46215655238302362668328"),BigInteger.Parse("3648325917726970721199010") };
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
public class A200576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200576Inst Instance=new A200576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200577
{
public static readonly long[] Value={ 114L,29180L,5236786L,997303772L,190970366840L,36460159508108L,6967106819900592L,1331428645830077622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200577Inst : IEnumerable<long>
{
public static readonly long[] Value=A200577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200577.Bytes);
public long this[int i]=>Value[i];

public static A200577Inst Instance=new A200577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200578
{
public static readonly long[] Value={ 260L,163706L,70594592L,32523513414L,15075017283404L,6967106819900592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200578Inst : IEnumerable<long>
{
public static readonly long[] Value=A200578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200578.Bytes);
public long this[int i]=>Value[i];

public static A200578Inst Instance=new A200578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200579
{
public static readonly long[] Value={ 2L,6L,6L,10L,36L,10L,22L,174L,174L,22L,52L,922L,2174L,922L,52L,114L,5202L,28890L,28890L,5202L,114L,260L,29180L,388824L,938128L,388824L,29180L,260L,600L,163706L,5236786L,30603332L,30603332L,5236786L,163706L,600L,1374L,919924L,70594592L,997303772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200579Inst : IEnumerable<long>
{
public static readonly long[] Value=A200579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200579.Bytes);
public long this[int i]=>Value[i];

public static A200579Inst Instance=new A200579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200580
{
public static readonly long[] Value={ 0L,1L,10L,73L,490L,3246L,21814L,150535L,1072786L,7915081L,60512348L,479371384L,3932969516L,33392961185L,293143783762L,2658128519225L,24872012040510L,239916007100054L,2383444110867378L,24363881751014383L,256034413642582418L,2763708806499744097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200580Inst : IEnumerable<long>
{
public static readonly long[] Value=A200580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200580.Bytes);
public long this[int i]=>Value[i];

public static A200580Inst Instance=new A200580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200581
{
public static readonly BigInteger[] Value={ 297L,4456485L,552604437L,8291281429233L,1028119449829329L,15425912516520681549UL,BigInteger.Parse("1912814180168014341405"),BigInteger.Parse("28699879385153403699122169"),BigInteger.Parse("3558786956573202226705490361"),BigInteger.Parse("53396068196303711362892876498613"),BigInteger.Parse("6621116015128616782200943391318373") };
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
public class A200581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200581Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200581.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200581Inst Instance=new A200581Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200582
{
public static readonly BigInteger[] Value={ 297L,36531L,548111421L,67965852735L,1019760202547361L,126450333081725499L,BigInteger.Parse("1897261817318411934357"),BigInteger.Parse("235260591797816161585767"),BigInteger.Parse("3529851816596251006844782425"),BigInteger.Parse("437701860518526922664914606467"),BigInteger.Parse("6567282245071794543915385600213293"),BigInteger.Parse("814343436090763041972430479341054799") };
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
public class A200582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200582Inst Instance=new A200582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200583
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,8L,3L,1L,16L,1L,32L,10L,4L,1L,64L,1L,128L,35L,5L,1L,256L,22L,1L,512L,126L,6L,1L,1024L,1L,2048L,462L,134L,46L,7L,1L,4096L,1L,8192L,1716L,8L,1L,16384L,866L,94L,1L,32768L,6435L,485L,9L,1L,65536L,1L,131072L,24310L,5812L,190L,10L,1L,262144L,1L,524288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200583Inst : IEnumerable<long>
{
public static readonly long[] Value=A200583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200583.Bytes);
public long this[int i]=>Value[i];

public static A200583Inst Instance=new A200583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200584
{
public static readonly long[] Value={ 2L,1L,8L,3L,6L,5L,7L,8L,0L,2L,7L,1L,6L,2L,3L,8L,6L,5L,1L,6L,7L,8L,7L,8L,8L,2L,4L,5L,4L,8L,0L,9L,0L,3L,6L,6L,5L,8L,9L,1L,2L,2L,3L,1L,5L,2L,8L,1L,4L,4L,7L,3L,4L,1L,9L,6L,9L,7L,7L,8L,0L,8L,7L,3L,8L,1L,4L,8L,1L,8L,8L,9L,8L,0L,6L,6L,6L,5L,3L,2L,8L,5L,9L,6L,6L,0L,8L,7L,6L,2L,5L,3L,7L,9L,5L,2L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200584Inst : IEnumerable<long>
{
public static readonly long[] Value=A200584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200584.Bytes);
public long this[int i]=>Value[i];

public static A200584Inst Instance=new A200584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200585
{
public static readonly long[] Value={ 8L,1L,7L,5L,8L,9L,2L,3L,9L,1L,0L,3L,2L,7L,8L,4L,3L,9L,4L,4L,7L,9L,0L,3L,1L,6L,0L,5L,4L,5L,1L,5L,0L,6L,7L,9L,4L,0L,7L,1L,7L,4L,9L,3L,5L,1L,1L,6L,6L,2L,1L,2L,1L,5L,3L,0L,6L,6L,6L,5L,2L,9L,7L,2L,7L,3L,4L,9L,1L,9L,6L,6L,3L,5L,3L,3L,1L,2L,7L,6L,1L,5L,9L,4L,5L,4L,1L,0L,2L,9L,1L,8L,3L,5L,5L,2L,7L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200585Inst : IEnumerable<long>
{
public static readonly long[] Value=A200585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200585.Bytes);
public long this[int i]=>Value[i];

public static A200585Inst Instance=new A200585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200586
{
public static readonly long[] Value={ 1L,4L,2L,1L,2L,9L,3L,6L,0L,9L,0L,3L,9L,2L,7L,8L,6L,6L,7L,9L,4L,8L,4L,2L,1L,4L,0L,1L,1L,8L,5L,9L,4L,5L,2L,9L,6L,8L,2L,9L,5L,3L,4L,9L,9L,5L,3L,4L,9L,9L,5L,0L,7L,5L,7L,2L,9L,3L,9L,9L,1L,9L,6L,6L,3L,9L,6L,1L,8L,1L,6L,0L,0L,4L,6L,8L,0L,7L,0L,6L,6L,7L,6L,6L,6L,6L,8L,9L,9L,3L,6L,3L,6L,3L,4L,3L,5L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200586Inst : IEnumerable<long>
{
public static readonly long[] Value=A200586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200586.Bytes);
public long this[int i]=>Value[i];

public static A200586Inst Instance=new A200586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200587
{
public static readonly long[] Value={ 1L,4L,4L,3L,3L,9L,6L,3L,5L,7L,5L,0L,5L,4L,8L,4L,4L,2L,5L,0L,0L,5L,6L,8L,8L,1L,4L,7L,9L,5L,2L,5L,1L,6L,6L,1L,1L,1L,7L,7L,5L,5L,3L,9L,1L,2L,4L,6L,1L,6L,6L,5L,7L,3L,7L,2L,8L,2L,4L,5L,4L,8L,3L,8L,3L,1L,4L,1L,5L,3L,2L,3L,4L,4L,3L,5L,3L,5L,6L,1L,8L,0L,4L,2L,0L,3L,2L,2L,4L,3L,9L,6L,7L,6L,0L,9L,8L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200587Inst : IEnumerable<long>
{
public static readonly long[] Value=A200587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200587.Bytes);
public long this[int i]=>Value[i];

public static A200587Inst Instance=new A200587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200588
{
public static readonly long[] Value={ 1L,4L,5L,9L,2L,6L,7L,9L,4L,9L,4L,2L,8L,9L,8L,3L,9L,8L,1L,4L,7L,6L,5L,2L,1L,6L,1L,8L,0L,9L,2L,9L,4L,3L,5L,0L,4L,7L,0L,0L,3L,5L,3L,6L,0L,4L,2L,4L,7L,3L,6L,3L,1L,7L,3L,4L,9L,2L,3L,3L,6L,5L,1L,8L,7L,1L,1L,7L,0L,7L,1L,1L,3L,6L,9L,1L,3L,1L,3L,0L,4L,6L,5L,8L,9L,3L,0L,2L,8L,8L,5L,4L,4L,4L,3L,2L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200588Inst : IEnumerable<long>
{
public static readonly long[] Value=A200588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200588.Bytes);
public long this[int i]=>Value[i];

public static A200588Inst Instance=new A200588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200589
{
public static readonly long[] Value={ 1L,2L,8L,2L,1L,0L,9L,7L,8L,0L,7L,3L,9L,4L,6L,0L,8L,2L,4L,1L,2L,8L,6L,7L,3L,4L,2L,3L,6L,8L,2L,8L,3L,4L,8L,3L,0L,3L,3L,4L,0L,7L,6L,1L,7L,7L,2L,1L,5L,2L,5L,0L,1L,5L,2L,2L,8L,3L,2L,2L,9L,6L,4L,0L,5L,4L,0L,5L,9L,2L,2L,1L,1L,8L,5L,6L,7L,4L,8L,3L,9L,2L,2L,9L,2L,9L,6L,2L,9L,2L,1L,4L,9L,6L,8L,6L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200589Inst : IEnumerable<long>
{
public static readonly long[] Value=A200589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200589.Bytes);
public long this[int i]=>Value[i];

public static A200589Inst Instance=new A200589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200590
{
public static readonly long[] Value={ 1L,3L,6L,8L,8L,0L,9L,1L,8L,9L,5L,8L,6L,2L,9L,4L,1L,4L,3L,7L,5L,7L,8L,7L,5L,5L,6L,4L,9L,2L,1L,5L,2L,3L,3L,7L,8L,8L,4L,6L,3L,3L,4L,4L,7L,0L,5L,0L,3L,9L,1L,1L,1L,9L,4L,2L,1L,8L,3L,6L,8L,0L,7L,3L,8L,8L,9L,2L,8L,3L,9L,2L,0L,5L,0L,0L,8L,9L,9L,3L,4L,3L,1L,3L,4L,6L,6L,2L,4L,0L,4L,6L,2L,7L,1L,8L,4L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200590Inst : IEnumerable<long>
{
public static readonly long[] Value=A200590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200590.Bytes);
public long this[int i]=>Value[i];

public static A200590Inst Instance=new A200590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200591
{
public static readonly long[] Value={ 1L,4L,0L,9L,3L,5L,0L,0L,7L,6L,3L,7L,9L,6L,7L,8L,1L,0L,7L,7L,5L,7L,3L,1L,7L,0L,2L,9L,9L,8L,5L,0L,0L,0L,4L,0L,7L,4L,9L,7L,2L,0L,6L,8L,4L,7L,2L,1L,1L,2L,1L,6L,5L,6L,8L,6L,5L,3L,2L,9L,6L,0L,1L,8L,5L,7L,2L,0L,6L,9L,8L,1L,1L,3L,4L,5L,0L,3L,2L,2L,5L,6L,5L,6L,7L,9L,6L,1L,9L,3L,7L,3L,3L,8L,0L,3L,7L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200591Inst : IEnumerable<long>
{
public static readonly long[] Value=A200591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200591.Bytes);
public long this[int i]=>Value[i];

public static A200591Inst Instance=new A200591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200592
{
public static readonly long[] Value={ 1L,4L,3L,4L,7L,7L,0L,7L,3L,1L,0L,6L,3L,2L,9L,7L,3L,2L,6L,1L,4L,9L,8L,6L,0L,0L,4L,3L,7L,9L,2L,2L,0L,2L,6L,8L,8L,7L,4L,2L,9L,8L,9L,3L,1L,5L,1L,6L,7L,0L,6L,1L,3L,8L,9L,5L,5L,3L,0L,5L,6L,0L,9L,7L,8L,1L,7L,1L,0L,5L,0L,1L,2L,0L,2L,7L,5L,1L,2L,1L,3L,2L,7L,8L,1L,6L,2L,3L,5L,6L,6L,5L,3L,5L,0L,0L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200592Inst : IEnumerable<long>
{
public static readonly long[] Value=A200592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200592.Bytes);
public long this[int i]=>Value[i];

public static A200592Inst Instance=new A200592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200593
{
public static readonly long[] Value={ 3L,2L,7L,2L,8L,3L,7L,3L,0L,1L,5L,9L,5L,3L,0L,8L,4L,1L,1L,5L,6L,0L,0L,1L,1L,4L,3L,3L,8L,4L,3L,2L,4L,7L,7L,4L,4L,0L,7L,6L,1L,9L,1L,3L,4L,2L,5L,1L,4L,3L,2L,3L,6L,6L,4L,6L,6L,6L,9L,2L,4L,4L,1L,4L,4L,1L,8L,9L,4L,1L,5L,5L,8L,3L,2L,9L,6L,4L,6L,7L,4L,6L,8L,5L,0L,9L,3L,4L,1L,7L,7L,6L,4L,6L,3L,5L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200593Inst : IEnumerable<long>
{
public static readonly long[] Value=A200593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200593.Bytes);
public long this[int i]=>Value[i];

public static A200593Inst Instance=new A200593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200594
{
public static readonly long[] Value={ 1L,2L,3L,6L,1L,3L,1L,7L,8L,7L,5L,1L,5L,2L,3L,7L,2L,2L,4L,1L,3L,4L,5L,7L,0L,0L,3L,1L,7L,3L,6L,5L,8L,9L,7L,8L,2L,1L,5L,2L,6L,2L,5L,2L,0L,4L,5L,4L,0L,2L,6L,9L,4L,9L,6L,8L,2L,1L,3L,3L,8L,1L,8L,6L,7L,2L,5L,5L,3L,1L,1L,4L,2L,7L,1L,8L,3L,4L,0L,8L,4L,0L,6L,3L,1L,1L,1L,4L,1L,7L,7L,6L,6L,7L,0L,8L,8L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200594Inst : IEnumerable<long>
{
public static readonly long[] Value=A200594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200594.Bytes);
public long this[int i]=>Value[i];

public static A200594Inst Instance=new A200594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200595
{
public static readonly long[] Value={ 1L,3L,9L,5L,8L,5L,1L,3L,6L,0L,6L,2L,1L,1L,4L,9L,0L,7L,4L,2L,7L,3L,3L,7L,7L,9L,0L,3L,8L,5L,6L,2L,9L,4L,1L,8L,1L,3L,8L,6L,2L,5L,9L,2L,9L,3L,6L,6L,7L,1L,2L,8L,5L,3L,4L,1L,1L,5L,7L,8L,9L,5L,2L,1L,2L,5L,9L,4L,3L,7L,2L,5L,3L,3L,8L,5L,0L,8L,2L,3L,6L,6L,7L,8L,3L,1L,4L,5L,0L,3L,2L,9L,1L,1L,4L,1L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200595Inst : IEnumerable<long>
{
public static readonly long[] Value=A200595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200595.Bytes);
public long this[int i]=>Value[i];

public static A200595Inst Instance=new A200595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200596
{
public static readonly long[] Value={ 2L,3L,1L,2L,4L,1L,1L,1L,4L,8L,4L,6L,2L,2L,4L,0L,8L,6L,0L,0L,8L,7L,7L,1L,2L,6L,3L,7L,7L,6L,0L,4L,6L,9L,2L,5L,8L,7L,6L,0L,0L,2L,3L,1L,2L,8L,6L,3L,3L,6L,5L,0L,8L,3L,5L,1L,4L,7L,0L,9L,0L,8L,9L,9L,3L,8L,4L,4L,7L,2L,2L,3L,9L,4L,0L,1L,9L,0L,2L,3L,8L,8L,8L,2L,3L,4L,5L,6L,9L,3L,0L,1L,1L,6L,8L,2L,8L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200596Inst : IEnumerable<long>
{
public static readonly long[] Value=A200596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200596.Bytes);
public long this[int i]=>Value[i];

public static A200596Inst Instance=new A200596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200597
{
public static readonly long[] Value={ 5L,9L,7L,7L,9L,0L,7L,0L,6L,8L,8L,1L,9L,3L,7L,5L,2L,1L,8L,3L,7L,2L,5L,5L,0L,8L,8L,4L,1L,7L,4L,4L,0L,0L,4L,5L,7L,8L,5L,1L,0L,6L,9L,6L,8L,2L,1L,2L,7L,9L,8L,2L,1L,5L,5L,6L,9L,2L,4L,9L,3L,1L,6L,0L,1L,4L,6L,9L,0L,7L,3L,0L,7L,8L,6L,8L,9L,8L,6L,4L,4L,4L,8L,2L,8L,1L,5L,5L,5L,2L,4L,1L,2L,4L,7L,4L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200597Inst : IEnumerable<long>
{
public static readonly long[] Value=A200597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200597.Bytes);
public long this[int i]=>Value[i];

public static A200597Inst Instance=new A200597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200598
{
public static readonly long[] Value={ 1L,1L,8L,7L,6L,3L,8L,0L,2L,6L,3L,5L,4L,6L,0L,3L,9L,8L,2L,4L,4L,7L,2L,9L,1L,0L,9L,8L,0L,4L,2L,1L,6L,2L,2L,3L,5L,9L,7L,1L,6L,3L,7L,8L,6L,7L,2L,8L,0L,3L,5L,9L,3L,3L,0L,8L,6L,2L,7L,8L,7L,7L,8L,3L,6L,0L,1L,7L,6L,1L,1L,5L,1L,3L,9L,3L,9L,3L,9L,6L,3L,9L,6L,3L,7L,2L,6L,0L,7L,3L,1L,6L,4L,3L,4L,5L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200598Inst : IEnumerable<long>
{
public static readonly long[] Value=A200598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200598.Bytes);
public long this[int i]=>Value[i];

public static A200598Inst Instance=new A200598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200599
{
public static readonly long[] Value={ 1L,3L,2L,3L,4L,9L,9L,6L,2L,2L,7L,1L,9L,5L,6L,0L,4L,9L,9L,3L,3L,3L,9L,3L,8L,5L,0L,5L,1L,5L,4L,9L,9L,7L,6L,3L,8L,6L,7L,7L,6L,2L,2L,7L,6L,0L,0L,7L,5L,2L,3L,6L,3L,3L,6L,8L,5L,5L,1L,5L,3L,5L,1L,6L,6L,2L,6L,3L,7L,2L,8L,1L,8L,0L,2L,2L,3L,7L,9L,7L,1L,8L,0L,6L,9L,1L,9L,0L,3L,6L,4L,3L,9L,9L,7L,7L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200599Inst : IEnumerable<long>
{
public static readonly long[] Value=A200599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200599.Bytes);
public long this[int i]=>Value[i];

public static A200599Inst Instance=new A200599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200600
{
public static readonly long[] Value={ 1L,4L,4L,4L,9L,9L,4L,6L,8L,8L,9L,5L,5L,1L,3L,1L,1L,8L,0L,4L,5L,3L,3L,2L,4L,9L,5L,9L,5L,8L,3L,8L,4L,1L,1L,6L,9L,9L,2L,8L,1L,0L,1L,8L,9L,1L,7L,5L,1L,3L,6L,2L,1L,6L,8L,6L,9L,8L,7L,1L,7L,9L,8L,3L,1L,4L,4L,9L,9L,7L,9L,7L,2L,2L,8L,7L,6L,1L,9L,2L,2L,0L,3L,4L,4L,2L,4L,7L,9L,1L,0L,9L,4L,7L,1L,3L,6L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200600Inst : IEnumerable<long>
{
public static readonly long[] Value=A200600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200600.Bytes);
public long this[int i]=>Value[i];

public static A200600Inst Instance=new A200600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200601
{
public static readonly long[] Value={ 1L,4L,6L,1L,0L,8L,1L,7L,4L,3L,4L,8L,8L,1L,8L,9L,4L,1L,5L,2L,6L,5L,5L,8L,1L,2L,2L,8L,9L,5L,8L,0L,8L,2L,0L,8L,8L,0L,2L,7L,4L,7L,9L,8L,7L,8L,0L,1L,7L,0L,9L,4L,7L,4L,2L,4L,0L,0L,2L,2L,8L,4L,6L,8L,3L,0L,1L,8L,6L,2L,1L,2L,3L,6L,0L,8L,9L,1L,7L,0L,7L,8L,5L,8L,6L,4L,1L,9L,9L,7L,3L,7L,3L,9L,4L,9L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200601Inst : IEnumerable<long>
{
public static readonly long[] Value=A200601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200601.Bytes);
public long this[int i]=>Value[i];

public static A200601Inst Instance=new A200601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200602
{
public static readonly long[] Value={ 1L,4L,7L,3L,1L,4L,0L,0L,7L,1L,1L,2L,6L,3L,0L,1L,7L,2L,3L,4L,7L,9L,2L,7L,5L,0L,8L,1L,6L,1L,2L,3L,1L,1L,6L,9L,8L,1L,9L,2L,5L,5L,6L,5L,5L,5L,1L,6L,9L,8L,9L,9L,0L,7L,7L,0L,4L,4L,9L,1L,0L,7L,7L,6L,6L,5L,2L,8L,1L,6L,3L,6L,3L,3L,5L,9L,0L,2L,7L,9L,3L,1L,9L,1L,4L,9L,5L,4L,6L,1L,9L,0L,3L,5L,6L,0L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200602Inst : IEnumerable<long>
{
public static readonly long[] Value=A200602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200602.Bytes);
public long this[int i]=>Value[i];

public static A200602Inst Instance=new A200602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200603
{
public static readonly long[] Value={ 1L,4L,8L,2L,6L,0L,7L,4L,9L,2L,1L,8L,1L,6L,3L,4L,0L,4L,9L,6L,3L,8L,8L,5L,0L,7L,9L,6L,7L,4L,5L,5L,8L,7L,0L,7L,5L,9L,5L,4L,3L,1L,5L,1L,9L,4L,4L,0L,3L,0L,5L,8L,7L,5L,4L,4L,6L,2L,9L,3L,6L,3L,1L,6L,8L,3L,6L,2L,8L,4L,6L,9L,6L,3L,3L,7L,0L,0L,8L,8L,9L,7L,0L,5L,4L,4L,8L,9L,8L,0L,7L,5L,8L,6L,0L,7L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200603Inst : IEnumerable<long>
{
public static readonly long[] Value=A200603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200603.Bytes);
public long this[int i]=>Value[i];

public static A200603Inst Instance=new A200603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200604
{
public static readonly long[] Value={ 1L,4L,0L,8L,8L,8L,1L,6L,6L,6L,0L,4L,8L,5L,8L,3L,9L,9L,3L,2L,7L,2L,3L,6L,4L,4L,1L,8L,8L,3L,4L,3L,4L,8L,8L,5L,8L,0L,9L,5L,2L,3L,6L,7L,5L,5L,6L,2L,6L,5L,4L,6L,8L,7L,5L,5L,9L,5L,5L,3L,9L,8L,2L,9L,2L,8L,9L,6L,3L,3L,3L,6L,0L,0L,9L,4L,8L,1L,5L,9L,4L,1L,1L,7L,1L,5L,8L,1L,5L,3L,9L,9L,1L,6L,9L,5L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200604Inst : IEnumerable<long>
{
public static readonly long[] Value=A200604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200604.Bytes);
public long this[int i]=>Value[i];

public static A200604Inst Instance=new A200604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200605
{
public static readonly long[] Value={ 1L,4L,5L,4L,3L,9L,7L,1L,3L,0L,5L,6L,2L,5L,8L,0L,1L,9L,3L,6L,5L,3L,9L,6L,3L,1L,4L,9L,9L,5L,2L,1L,3L,5L,2L,1L,7L,8L,6L,5L,1L,0L,4L,7L,1L,9L,5L,4L,5L,4L,6L,3L,4L,3L,2L,0L,2L,5L,2L,7L,2L,0L,2L,5L,6L,9L,5L,8L,3L,9L,4L,2L,3L,7L,5L,2L,2L,2L,6L,9L,2L,7L,8L,6L,1L,1L,4L,7L,4L,4L,4L,0L,8L,3L,4L,5L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200605Inst : IEnumerable<long>
{
public static readonly long[] Value=A200605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200605.Bytes);
public long this[int i]=>Value[i];

public static A200605Inst Instance=new A200605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200606
{
public static readonly long[] Value={ 1L,3L,3L,1L,3L,2L,4L,5L,4L,2L,2L,0L,8L,0L,3L,3L,2L,1L,6L,1L,3L,8L,7L,6L,9L,4L,4L,6L,9L,0L,3L,9L,3L,9L,8L,5L,8L,4L,8L,3L,4L,4L,7L,1L,1L,0L,3L,3L,5L,1L,2L,5L,4L,9L,4L,6L,5L,8L,2L,1L,6L,0L,7L,0L,1L,6L,0L,6L,4L,1L,8L,0L,6L,6L,1L,7L,0L,6L,4L,6L,6L,8L,4L,3L,7L,5L,3L,5L,2L,0L,8L,5L,4L,9L,8L,2L,3L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200606Inst : IEnumerable<long>
{
public static readonly long[] Value=A200606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200606.Bytes);
public long this[int i]=>Value[i];

public static A200606Inst Instance=new A200606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200607
{
public static readonly long[] Value={ 1L,3L,9L,3L,7L,4L,1L,9L,5L,4L,2L,0L,3L,5L,9L,0L,5L,0L,6L,5L,1L,9L,5L,3L,4L,7L,9L,5L,6L,0L,7L,4L,8L,4L,4L,1L,9L,5L,2L,6L,4L,8L,8L,9L,2L,7L,0L,9L,4L,0L,0L,6L,0L,5L,8L,9L,2L,4L,3L,5L,7L,5L,1L,3L,1L,5L,8L,9L,4L,8L,4L,5L,3L,5L,9L,4L,2L,9L,5L,2L,1L,0L,1L,5L,3L,8L,6L,9L,0L,3L,1L,1L,2L,2L,2L,5L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200607Inst : IEnumerable<long>
{
public static readonly long[] Value=A200607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200607.Bytes);
public long this[int i]=>Value[i];

public static A200607Inst Instance=new A200607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200608
{
public static readonly long[] Value={ 1L,4L,2L,5L,9L,4L,9L,1L,1L,1L,8L,3L,1L,5L,0L,1L,9L,7L,5L,6L,7L,7L,5L,9L,9L,7L,2L,4L,4L,7L,1L,2L,4L,3L,7L,0L,1L,4L,6L,4L,0L,0L,4L,2L,1L,3L,5L,6L,4L,9L,1L,0L,4L,1L,8L,5L,9L,0L,5L,9L,0L,3L,7L,6L,3L,7L,4L,7L,9L,0L,9L,6L,5L,4L,9L,7L,1L,6L,7L,7L,4L,5L,7L,6L,2L,1L,4L,0L,0L,7L,7L,6L,1L,0L,0L,7L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200608Inst : IEnumerable<long>
{
public static readonly long[] Value=A200608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200608.Bytes);
public long this[int i]=>Value[i];

public static A200608Inst Instance=new A200608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200609
{
public static readonly long[] Value={ 1L,4L,4L,6L,9L,6L,0L,6L,8L,6L,1L,4L,8L,8L,1L,9L,5L,4L,3L,8L,0L,8L,8L,6L,8L,8L,6L,1L,4L,7L,3L,9L,9L,5L,0L,1L,3L,9L,0L,8L,3L,7L,6L,2L,4L,8L,3L,2L,6L,9L,2L,8L,9L,1L,0L,4L,3L,7L,4L,6L,0L,0L,4L,9L,6L,1L,8L,9L,1L,5L,7L,1L,5L,9L,1L,1L,8L,5L,3L,9L,1L,9L,5L,2L,9L,4L,3L,2L,0L,8L,6L,2L,2L,9L,8L,7L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200609Inst : IEnumerable<long>
{
public static readonly long[] Value=A200609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200609.Bytes);
public long this[int i]=>Value[i];

public static A200609Inst Instance=new A200609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200610
{
public static readonly long[] Value={ 2L,4L,8L,2L,6L,0L,9L,1L,4L,5L,2L,3L,0L,8L,3L,2L,1L,9L,8L,7L,0L,8L,3L,3L,6L,3L,7L,2L,2L,8L,9L,0L,9L,5L,7L,5L,3L,3L,4L,8L,9L,8L,6L,1L,0L,0L,9L,9L,4L,3L,5L,5L,5L,5L,0L,0L,9L,8L,6L,2L,9L,7L,6L,6L,7L,2L,3L,3L,5L,2L,5L,3L,7L,0L,6L,2L,8L,0L,2L,9L,6L,1L,7L,5L,2L,3L,0L,4L,9L,8L,7L,9L,1L,2L,4L,9L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200610Inst : IEnumerable<long>
{
public static readonly long[] Value=A200610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200610.Bytes);
public long this[int i]=>Value[i];

public static A200610Inst Instance=new A200610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200611
{
public static readonly long[] Value={ 1L,3L,7L,6L,0L,5L,2L,5L,1L,5L,3L,9L,9L,6L,6L,9L,7L,5L,3L,5L,7L,9L,4L,8L,9L,2L,7L,4L,8L,8L,0L,9L,1L,1L,6L,1L,2L,8L,3L,1L,1L,3L,8L,8L,8L,2L,4L,0L,3L,0L,3L,6L,7L,6L,5L,9L,3L,2L,9L,8L,6L,3L,0L,8L,3L,2L,5L,3L,6L,4L,7L,0L,0L,9L,9L,4L,9L,9L,1L,6L,0L,5L,7L,3L,2L,2L,6L,6L,0L,7L,3L,2L,0L,7L,1L,8L,9L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200611Inst : IEnumerable<long>
{
public static readonly long[] Value=A200611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200611.Bytes);
public long this[int i]=>Value[i];

public static A200611Inst Instance=new A200611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200612
{
public static readonly long[] Value={ 3L,9L,20L,27L,60L,81L,112L,180L,243L,336L,400L,540L,729L,1008L,1200L,1620L,2187L,2240L,2816L,3024L,3600L,4860L,6561L,6720L,8000L,8448L,9072L,10800L,12544L,13312L,14580L,19683L,20160L,24000L,25344L,27216L,32400L,37632L,39936L,43740L,44800L,56320L,59049L,60480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200612Inst : IEnumerable<long>
{
public static readonly long[] Value=A200612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200612.Bytes);
public long this[int i]=>Value[i];

public static A200612Inst Instance=new A200612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200613
{
public static readonly long[] Value={ 1L,3L,11L,44L,183L,774L,3294L,14034L,59711L,253430L,1072506L,4525168L,19036726L,79861404L,334155036L,1394789214L,5808981711L,24143440374L,100156051746L,414762312504L,1714844273586L,7079573497524L,29187378344676L,120180109515204L,494264431607718L,2030539136846844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200613Inst : IEnumerable<long>
{
public static readonly long[] Value=A200613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200613.Bytes);
public long this[int i]=>Value[i];

public static A200613Inst Instance=new A200613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200614
{
public static readonly long[] Value={ 8L,3L,9L,5L,8L,2L,2L,5L,9L,0L,4L,5L,3L,0L,2L,9L,4L,1L,5L,1L,3L,7L,6L,4L,0L,0L,8L,8L,6L,3L,8L,0L,4L,9L,8L,6L,3L,0L,8L,4L,1L,6L,5L,4L,1L,0L,2L,6L,9L,4L,4L,0L,9L,0L,0L,3L,3L,4L,9L,1L,4L,3L,4L,0L,6L,7L,6L,5L,8L,4L,1L,4L,6L,1L,0L,4L,1L,1L,6L,7L,4L,2L,5L,9L,5L,3L,5L,3L,0L,0L,2L,3L,6L,6L,2L,4L,6L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200614Inst : IEnumerable<long>
{
public static readonly long[] Value=A200614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200614.Bytes);
public long this[int i]=>Value[i];

public static A200614Inst Instance=new A200614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200615
{
public static readonly long[] Value={ 1L,3L,5L,0L,9L,5L,6L,5L,9L,3L,9L,7L,6L,5L,1L,9L,3L,9L,7L,7L,4L,4L,6L,9L,6L,2L,9L,4L,3L,6L,8L,5L,2L,4L,7L,1L,5L,3L,7L,3L,0L,3L,7L,3L,0L,1L,6L,7L,5L,8L,8L,2L,5L,6L,2L,9L,7L,8L,8L,4L,4L,6L,2L,0L,4L,7L,6L,6L,0L,1L,7L,1L,8L,4L,6L,3L,4L,3L,8L,0L,2L,8L,2L,8L,5L,3L,9L,6L,5L,0L,6L,3L,4L,5L,9L,4L,4L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200615Inst : IEnumerable<long>
{
public static readonly long[] Value=A200615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200615.Bytes);
public long this[int i]=>Value[i];

public static A200615Inst Instance=new A200615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200616
{
public static readonly long[] Value={ 6L,6L,9L,1L,0L,2L,9L,7L,2L,0L,2L,3L,5L,7L,5L,4L,1L,6L,0L,7L,6L,6L,0L,1L,2L,5L,0L,1L,8L,8L,4L,5L,6L,9L,8L,2L,4L,5L,6L,2L,2L,7L,9L,4L,4L,3L,8L,7L,1L,8L,5L,6L,4L,3L,3L,0L,1L,1L,5L,8L,3L,0L,0L,2L,1L,7L,3L,9L,4L,9L,8L,4L,0L,8L,4L,2L,6L,3L,7L,2L,4L,5L,6L,0L,2L,7L,9L,3L,9L,0L,4L,3L,4L,2L,2L,9L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200616Inst : IEnumerable<long>
{
public static readonly long[] Value=A200616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200616.Bytes);
public long this[int i]=>Value[i];

public static A200616Inst Instance=new A200616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200617
{
public static readonly long[] Value={ 1L,4L,3L,3L,0L,6L,8L,7L,8L,5L,5L,8L,4L,9L,1L,6L,8L,7L,5L,2L,2L,6L,7L,8L,2L,7L,1L,7L,5L,9L,6L,7L,2L,8L,7L,7L,0L,2L,2L,0L,9L,2L,4L,0L,2L,6L,8L,4L,7L,5L,6L,2L,1L,5L,0L,8L,5L,0L,2L,2L,7L,6L,3L,4L,2L,5L,3L,1L,1L,6L,8L,1L,0L,4L,7L,6L,9L,2L,5L,0L,7L,4L,5L,8L,6L,3L,1L,9L,1L,6L,5L,0L,3L,1L,8L,1L,0L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200617Inst : IEnumerable<long>
{
public static readonly long[] Value=A200617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200617.Bytes);
public long this[int i]=>Value[i];

public static A200617Inst Instance=new A200617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200618
{
public static readonly long[] Value={ 1L,4L,7L,9L,7L,0L,5L,2L,0L,2L,2L,4L,4L,3L,5L,8L,0L,5L,9L,6L,7L,5L,1L,2L,3L,9L,9L,3L,9L,5L,2L,3L,3L,1L,8L,5L,2L,9L,5L,9L,7L,1L,4L,2L,1L,5L,4L,9L,5L,0L,2L,7L,0L,7L,2L,5L,0L,2L,7L,0L,3L,7L,3L,0L,9L,6L,1L,2L,0L,6L,4L,7L,5L,6L,5L,6L,3L,2L,5L,7L,0L,7L,7L,0L,5L,0L,5L,6L,0L,4L,9L,0L,5L,9L,9L,4L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200618Inst : IEnumerable<long>
{
public static readonly long[] Value=A200618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200618.Bytes);
public long this[int i]=>Value[i];

public static A200618Inst Instance=new A200618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200619
{
public static readonly long[] Value={ 1L,4L,5L,0L,1L,4L,9L,5L,5L,1L,5L,6L,1L,7L,6L,7L,7L,4L,0L,8L,6L,2L,2L,1L,6L,8L,3L,0L,9L,0L,9L,2L,2L,0L,1L,3L,5L,2L,4L,3L,6L,4L,2L,6L,2L,5L,8L,8L,4L,3L,7L,3L,6L,0L,4L,2L,0L,3L,1L,0L,5L,7L,9L,5L,4L,0L,8L,6L,8L,1L,5L,2L,0L,3L,9L,9L,4L,3L,4L,1L,8L,7L,2L,2L,5L,9L,1L,2L,8L,2L,6L,7L,0L,7L,2L,4L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200619Inst : IEnumerable<long>
{
public static readonly long[] Value=A200619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200619.Bytes);
public long this[int i]=>Value[i];

public static A200619Inst Instance=new A200619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200620
{
public static readonly long[] Value={ 5L,7L,3L,8L,2L,5L,6L,1L,4L,2L,2L,0L,7L,0L,7L,5L,1L,9L,4L,7L,0L,6L,9L,9L,3L,0L,7L,3L,9L,5L,0L,2L,8L,9L,7L,2L,0L,4L,0L,0L,1L,2L,6L,2L,0L,5L,6L,7L,5L,7L,0L,8L,3L,3L,8L,2L,7L,1L,3L,0L,1L,2L,7L,4L,1L,8L,7L,9L,3L,4L,4L,0L,9L,7L,0L,1L,7L,1L,2L,2L,0L,9L,2L,8L,2L,1L,3L,3L,5L,3L,7L,0L,0L,6L,1L,5L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200620Inst : IEnumerable<long>
{
public static readonly long[] Value=A200620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200620.Bytes);
public long this[int i]=>Value[i];

public static A200620Inst Instance=new A200620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200621
{
public static readonly long[] Value={ 1L,4L,6L,9L,0L,0L,2L,7L,1L,9L,5L,1L,3L,6L,1L,0L,6L,1L,3L,2L,2L,3L,3L,6L,2L,5L,9L,7L,5L,8L,3L,6L,3L,2L,4L,1L,1L,2L,7L,8L,0L,0L,0L,3L,4L,6L,1L,5L,3L,5L,7L,4L,6L,4L,8L,5L,8L,8L,7L,7L,3L,5L,8L,6L,2L,2L,8L,1L,7L,2L,0L,1L,8L,4L,8L,3L,0L,6L,1L,0L,4L,5L,6L,4L,2L,4L,9L,0L,1L,9L,0L,6L,6L,9L,7L,6L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200621Inst : IEnumerable<long>
{
public static readonly long[] Value=A200621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200621.Bytes);
public long this[int i]=>Value[i];

public static A200621Inst Instance=new A200621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200622
{
public static readonly long[] Value={ 7L,7L,0L,8L,9L,6L,8L,8L,3L,9L,1L,4L,2L,7L,7L,1L,8L,2L,8L,3L,7L,2L,6L,4L,9L,2L,7L,3L,5L,8L,7L,0L,6L,3L,2L,1L,8L,6L,8L,7L,5L,4L,8L,4L,3L,3L,6L,1L,9L,2L,8L,8L,8L,3L,4L,1L,1L,0L,9L,3L,2L,0L,8L,9L,6L,3L,2L,6L,1L,7L,9L,1L,3L,9L,9L,0L,3L,8L,2L,1L,8L,6L,6L,4L,7L,7L,7L,3L,0L,9L,1L,9L,7L,1L,1L,5L,9L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200622Inst : IEnumerable<long>
{
public static readonly long[] Value=A200622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200622.Bytes);
public long this[int i]=>Value[i];

public static A200622Inst Instance=new A200622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200623
{
public static readonly long[] Value={ 1L,4L,5L,4L,7L,9L,9L,2L,1L,3L,5L,1L,9L,9L,9L,5L,5L,2L,6L,3L,7L,0L,7L,8L,4L,3L,0L,0L,7L,9L,8L,9L,4L,4L,5L,8L,9L,0L,1L,2L,6L,0L,8L,7L,1L,2L,0L,1L,7L,0L,7L,4L,3L,1L,5L,0L,0L,2L,1L,9L,3L,2L,6L,9L,3L,9L,2L,3L,5L,3L,2L,2L,1L,5L,8L,0L,0L,0L,6L,1L,6L,9L,5L,4L,5L,8L,6L,7L,0L,2L,0L,8L,8L,7L,6L,7L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200623Inst : IEnumerable<long>
{
public static readonly long[] Value=A200623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200623.Bytes);
public long this[int i]=>Value[i];

public static A200623Inst Instance=new A200623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200624
{
public static readonly long[] Value={ 9L,3L,2L,5L,1L,7L,0L,5L,1L,8L,6L,4L,2L,2L,9L,4L,8L,1L,9L,4L,9L,8L,5L,7L,1L,8L,9L,8L,9L,3L,1L,3L,9L,9L,8L,9L,7L,6L,4L,9L,1L,7L,3L,6L,7L,7L,6L,1L,8L,0L,6L,4L,5L,2L,3L,9L,0L,8L,8L,9L,6L,8L,9L,1L,4L,2L,8L,6L,3L,2L,4L,8L,6L,6L,9L,2L,4L,5L,1L,5L,4L,5L,3L,2L,2L,7L,7L,0L,3L,8L,6L,5L,7L,0L,6L,4L,3L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200624Inst : IEnumerable<long>
{
public static readonly long[] Value=A200624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200624.Bytes);
public long this[int i]=>Value[i];

public static A200624Inst Instance=new A200624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200625
{
public static readonly long[] Value={ 1L,4L,3L,4L,4L,3L,6L,7L,9L,8L,5L,3L,1L,0L,6L,4L,8L,8L,2L,7L,1L,8L,8L,6L,4L,3L,5L,1L,3L,5L,4L,3L,3L,5L,8L,5L,0L,3L,4L,3L,9L,6L,6L,8L,1L,5L,1L,2L,5L,3L,6L,8L,1L,7L,1L,8L,4L,8L,5L,3L,0L,2L,3L,6L,4L,7L,1L,1L,6L,6L,0L,5L,2L,5L,8L,3L,9L,9L,2L,6L,4L,1L,9L,5L,5L,1L,8L,5L,9L,7L,6L,8L,1L,3L,6L,1L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200625Inst : IEnumerable<long>
{
public static readonly long[] Value=A200625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200625.Bytes);
public long this[int i]=>Value[i];

public static A200625Inst Instance=new A200625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200626
{
public static readonly long[] Value={ 1L,0L,8L,6L,2L,4L,8L,3L,0L,7L,3L,7L,2L,3L,5L,1L,4L,9L,3L,0L,5L,1L,6L,5L,3L,7L,4L,7L,0L,2L,5L,7L,9L,0L,1L,3L,0L,2L,1L,1L,1L,2L,7L,3L,5L,5L,4L,3L,6L,3L,1L,5L,1L,1L,7L,1L,8L,9L,4L,2L,5L,9L,8L,4L,9L,7L,6L,9L,4L,5L,4L,7L,8L,5L,2L,6L,3L,5L,8L,1L,9L,0L,8L,9L,9L,5L,8L,4L,4L,2L,6L,6L,5L,2L,0L,8L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200626Inst : IEnumerable<long>
{
public static readonly long[] Value=A200626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200626.Bytes);
public long this[int i]=>Value[i];

public static A200626Inst Instance=new A200626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200627
{
public static readonly long[] Value={ 1L,4L,0L,0L,1L,0L,2L,5L,5L,5L,3L,3L,6L,9L,4L,1L,7L,4L,1L,8L,3L,1L,9L,5L,9L,3L,7L,1L,5L,7L,1L,5L,8L,5L,4L,7L,3L,0L,5L,3L,8L,8L,4L,6L,9L,6L,6L,3L,4L,1L,9L,0L,6L,0L,7L,3L,0L,4L,4L,3L,6L,4L,3L,4L,4L,5L,2L,6L,9L,3L,7L,2L,9L,0L,5L,1L,9L,5L,1L,5L,7L,0L,3L,3L,9L,8L,8L,1L,7L,5L,6L,5L,2L,3L,4L,9L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200627Inst : IEnumerable<long>
{
public static readonly long[] Value=A200627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200627.Bytes);
public long this[int i]=>Value[i];

public static A200627Inst Instance=new A200627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200628
{
public static readonly long[] Value={ 1L,4L,8L,8L,1L,5L,5L,7L,7L,9L,6L,4L,7L,9L,2L,1L,7L,1L,7L,9L,5L,9L,5L,7L,4L,1L,1L,8L,6L,2L,8L,2L,0L,9L,8L,6L,9L,0L,4L,1L,7L,5L,4L,3L,2L,8L,2L,8L,2L,0L,5L,8L,8L,7L,8L,0L,2L,4L,6L,8L,3L,1L,2L,7L,1L,9L,9L,4L,1L,8L,6L,6L,6L,5L,2L,9L,0L,2L,8L,1L,9L,3L,5L,9L,6L,1L,8L,3L,2L,7L,7L,0L,3L,9L,1L,9L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200628Inst : IEnumerable<long>
{
public static readonly long[] Value=A200628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200628.Bytes);
public long this[int i]=>Value[i];

public static A200628Inst Instance=new A200628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200629
{
public static readonly long[] Value={ 1L,4L,9L,5L,0L,4L,4L,8L,0L,5L,5L,6L,5L,1L,6L,7L,7L,4L,0L,1L,1L,5L,2L,3L,9L,3L,6L,2L,5L,4L,5L,5L,1L,6L,4L,4L,9L,5L,9L,6L,7L,8L,9L,7L,9L,7L,5L,8L,1L,1L,8L,6L,0L,1L,7L,8L,9L,9L,1L,6L,5L,8L,0L,7L,7L,7L,5L,8L,9L,0L,4L,4L,2L,1L,6L,0L,4L,8L,2L,1L,0L,7L,2L,5L,3L,7L,1L,7L,4L,1L,4L,5L,7L,5L,1L,9L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200629Inst : IEnumerable<long>
{
public static readonly long[] Value=A200629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200629.Bytes);
public long this[int i]=>Value[i];

public static A200629Inst Instance=new A200629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200630
{
public static readonly long[] Value={ 1L,5L,0L,0L,7L,9L,4L,0L,8L,1L,5L,3L,5L,0L,7L,9L,3L,8L,1L,8L,8L,2L,2L,5L,2L,4L,7L,6L,5L,5L,7L,5L,7L,1L,7L,5L,2L,3L,2L,6L,5L,9L,6L,2L,1L,4L,4L,7L,6L,4L,8L,8L,8L,1L,1L,3L,0L,0L,7L,9L,7L,8L,7L,7L,2L,5L,1L,6L,0L,0L,7L,1L,1L,3L,2L,4L,4L,3L,1L,8L,8L,3L,5L,0L,5L,1L,0L,3L,5L,1L,6L,3L,9L,0L,7L,1L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200630Inst : IEnumerable<long>
{
public static readonly long[] Value=A200630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200630.Bytes);
public long this[int i]=>Value[i];

public static A200630Inst Instance=new A200630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200631
{
public static readonly long[] Value={ 1L,5L,0L,5L,6L,7L,9L,7L,3L,4L,4L,8L,8L,3L,8L,7L,0L,0L,6L,2L,2L,6L,5L,5L,8L,5L,8L,7L,6L,7L,7L,6L,1L,2L,5L,6L,6L,5L,2L,3L,7L,8L,2L,2L,9L,0L,1L,8L,1L,6L,9L,5L,3L,9L,4L,7L,6L,1L,9L,6L,2L,9L,6L,8L,2L,9L,7L,6L,1L,9L,1L,2L,0L,1L,7L,9L,3L,4L,5L,1L,0L,7L,5L,9L,4L,8L,9L,5L,5L,5L,7L,3L,1L,6L,6L,6L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200631Inst : IEnumerable<long>
{
public static readonly long[] Value=A200631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200631.Bytes);
public long this[int i]=>Value[i];

public static A200631Inst Instance=new A200631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200632
{
public static readonly long[] Value={ 1L,4L,9L,6L,5L,1L,3L,6L,4L,8L,2L,6L,7L,2L,5L,4L,1L,7L,0L,8L,4L,0L,7L,6L,6L,7L,6L,9L,1L,9L,8L,0L,8L,8L,3L,7L,0L,7L,2L,1L,2L,0L,8L,4L,9L,0L,1L,4L,3L,4L,3L,6L,3L,3L,8L,7L,5L,9L,3L,5L,1L,5L,0L,0L,4L,0L,0L,3L,5L,0L,5L,4L,0L,0L,8L,3L,0L,0L,9L,3L,9L,3L,2L,2L,6L,0L,7L,5L,9L,7L,9L,9L,4L,1L,5L,6L,1L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200632Inst : IEnumerable<long>
{
public static readonly long[] Value=A200632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200632.Bytes);
public long this[int i]=>Value[i];

public static A200632Inst Instance=new A200632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200633
{
public static readonly long[] Value={ 5L,0L,9L,7L,4L,1L,7L,0L,8L,9L,1L,8L,5L,4L,8L,4L,8L,9L,2L,4L,6L,0L,4L,9L,6L,6L,5L,8L,5L,2L,5L,8L,6L,8L,6L,2L,7L,0L,8L,3L,1L,7L,8L,6L,0L,0L,8L,3L,0L,9L,5L,8L,7L,7L,8L,7L,4L,7L,1L,7L,9L,9L,7L,5L,2L,7L,3L,3L,5L,2L,6L,3L,9L,7L,6L,8L,4L,6L,6L,8L,7L,4L,2L,1L,8L,0L,2L,1L,7L,9L,8L,8L,3L,0L,5L,1L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200633Inst : IEnumerable<long>
{
public static readonly long[] Value=A200633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200633.Bytes);
public long this[int i]=>Value[i];

public static A200633Inst Instance=new A200633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200634
{
public static readonly long[] Value={ 1L,4L,8L,9L,7L,8L,3L,6L,5L,6L,0L,8L,3L,4L,9L,8L,2L,2L,0L,9L,6L,6L,8L,1L,7L,9L,8L,6L,8L,6L,0L,6L,7L,1L,4L,7L,5L,0L,4L,2L,6L,1L,4L,1L,5L,1L,4L,5L,8L,4L,9L,3L,2L,5L,8L,7L,9L,8L,2L,4L,1L,9L,1L,4L,6L,2L,0L,1L,1L,9L,1L,7L,6L,2L,2L,0L,1L,7L,8L,7L,0L,3L,4L,0L,1L,8L,8L,7L,0L,9L,4L,1L,5L,0L,3L,8L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200634Inst : IEnumerable<long>
{
public static readonly long[] Value=A200634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200634.Bytes);
public long this[int i]=>Value[i];

public static A200634Inst Instance=new A200634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200635
{
public static readonly long[] Value={ 1L,0L,6L,5L,0L,2L,1L,6L,2L,0L,6L,1L,8L,7L,0L,7L,9L,0L,0L,2L,9L,4L,9L,3L,5L,9L,3L,6L,1L,1L,9L,5L,2L,2L,7L,3L,3L,0L,1L,3L,2L,2L,7L,0L,0L,8L,8L,5L,6L,6L,5L,4L,2L,2L,2L,0L,2L,6L,8L,6L,1L,0L,7L,3L,2L,6L,6L,7L,7L,2L,0L,2L,9L,0L,1L,1L,1L,2L,4L,3L,0L,9L,1L,0L,0L,6L,8L,5L,2L,3L,6L,7L,9L,8L,8L,5L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200635Inst : IEnumerable<long>
{
public static readonly long[] Value=A200635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200635.Bytes);
public long this[int i]=>Value[i];

public static A200635Inst Instance=new A200635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200636
{
public static readonly long[] Value={ 1L,4L,3L,5L,9L,7L,2L,7L,9L,7L,7L,4L,7L,7L,2L,7L,8L,3L,9L,7L,3L,7L,7L,5L,9L,5L,7L,1L,3L,6L,3L,1L,8L,0L,6L,3L,4L,7L,5L,2L,4L,1L,9L,4L,0L,1L,6L,2L,8L,5L,6L,2L,7L,2L,5L,4L,8L,4L,5L,2L,6L,7L,0L,5L,9L,8L,1L,8L,9L,4L,9L,9L,2L,6L,7L,0L,0L,1L,3L,6L,4L,5L,6L,5L,8L,9L,7L,8L,0L,1L,1L,3L,5L,1L,5L,1L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200636Inst : IEnumerable<long>
{
public static readonly long[] Value=A200636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200636.Bytes);
public long this[int i]=>Value[i];

public static A200636Inst Instance=new A200636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200637
{
public static readonly long[] Value={ 1L,5L,0L,2L,1L,2L,0L,1L,4L,3L,8L,3L,3L,5L,6L,9L,4L,1L,6L,1L,1L,2L,7L,7L,2L,8L,4L,6L,0L,5L,8L,0L,3L,1L,5L,1L,0L,3L,5L,5L,8L,3L,4L,9L,0L,3L,9L,4L,0L,5L,9L,0L,0L,9L,6L,5L,9L,2L,3L,7L,4L,1L,9L,4L,7L,1L,7L,7L,4L,0L,5L,6L,5L,6L,1L,1L,8L,3L,9L,8L,4L,1L,0L,4L,2L,9L,0L,9L,5L,9L,8L,2L,2L,7L,5L,1L,2L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200637Inst : IEnumerable<long>
{
public static readonly long[] Value=A200637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200637.Bytes);
public long this[int i]=>Value[i];

public static A200637Inst Instance=new A200637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200638
{
public static readonly long[] Value={ 1L,5L,1L,7L,7L,1L,3L,3L,1L,8L,6L,7L,9L,0L,9L,2L,8L,1L,6L,9L,8L,6L,2L,5L,5L,9L,8L,1L,2L,0L,6L,5L,2L,1L,7L,2L,8L,5L,5L,8L,1L,6L,4L,1L,1L,3L,4L,9L,5L,3L,8L,8L,9L,0L,3L,4L,6L,3L,7L,0L,3L,8L,2L,5L,0L,0L,3L,3L,7L,7L,3L,3L,9L,4L,0L,2L,0L,0L,7L,6L,5L,9L,7L,8L,7L,3L,0L,5L,2L,7L,6L,4L,8L,0L,5L,4L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200638Inst : IEnumerable<long>
{
public static readonly long[] Value=A200638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200638.Bytes);
public long this[int i]=>Value[i];

public static A200638Inst Instance=new A200638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200639
{
public static readonly long[] Value={ 1L,4L,2L,9L,7L,7L,9L,1L,8L,9L,1L,9L,0L,6L,0L,7L,6L,4L,8L,7L,2L,8L,6L,6L,8L,9L,1L,7L,2L,2L,2L,1L,3L,4L,2L,4L,9L,2L,0L,7L,9L,5L,2L,2L,5L,8L,4L,8L,0L,0L,0L,2L,9L,9L,9L,7L,5L,0L,4L,0L,7L,7L,4L,9L,5L,6L,6L,3L,0L,1L,2L,5L,2L,3L,2L,0L,5L,0L,3L,9L,5L,7L,4L,5L,4L,6L,1L,0L,8L,7L,0L,3L,9L,9L,0L,1L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200639Inst : IEnumerable<long>
{
public static readonly long[] Value=A200639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200639.Bytes);
public long this[int i]=>Value[i];

public static A200639Inst Instance=new A200639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200640
{
public static readonly long[] Value={ 1L,4L,6L,3L,4L,9L,3L,5L,3L,1L,5L,8L,7L,8L,1L,6L,7L,8L,7L,4L,0L,1L,6L,4L,7L,0L,5L,3L,7L,9L,7L,8L,9L,8L,2L,6L,9L,2L,6L,3L,6L,0L,4L,4L,4L,4L,6L,0L,2L,7L,9L,9L,8L,9L,4L,3L,6L,4L,5L,5L,2L,2L,7L,9L,3L,0L,9L,3L,0L,8L,2L,4L,3L,2L,8L,1L,2L,2L,1L,4L,9L,4L,7L,6L,6L,4L,6L,1L,6L,8L,1L,5L,1L,0L,3L,9L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200640Inst : IEnumerable<long>
{
public static readonly long[] Value=A200640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200640.Bytes);
public long this[int i]=>Value[i];

public static A200640Inst Instance=new A200640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200641
{
public static readonly long[] Value={ 1L,4L,8L,4L,9L,1L,1L,7L,2L,5L,4L,2L,5L,8L,9L,4L,5L,5L,7L,9L,6L,7L,6L,2L,3L,6L,4L,1L,7L,8L,4L,7L,2L,8L,0L,8L,3L,2L,8L,1L,7L,5L,4L,7L,2L,0L,3L,6L,3L,7L,8L,2L,4L,0L,1L,7L,8L,5L,5L,8L,9L,2L,2L,1L,4L,7L,5L,8L,2L,0L,2L,7L,0L,3L,1L,1L,8L,3L,5L,3L,2L,7L,4L,8L,5L,1L,3L,0L,2L,4L,8L,3L,7L,8L,5L,6L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200641Inst : IEnumerable<long>
{
public static readonly long[] Value=A200641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200641.Bytes);
public long this[int i]=>Value[i];

public static A200641Inst Instance=new A200641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200642
{
public static readonly long[] Value={ 1L,4L,9L,9L,4L,5L,5L,6L,9L,7L,1L,2L,8L,7L,3L,0L,9L,7L,4L,2L,7L,9L,9L,3L,6L,4L,0L,4L,3L,1L,7L,2L,1L,6L,3L,6L,5L,2L,6L,3L,3L,8L,1L,8L,9L,4L,6L,1L,2L,9L,8L,9L,5L,2L,4L,8L,6L,0L,5L,6L,6L,9L,2L,5L,8L,1L,6L,9L,7L,5L,3L,9L,3L,4L,7L,5L,7L,0L,1L,9L,7L,8L,8L,1L,3L,5L,4L,5L,0L,3L,1L,3L,3L,4L,4L,2L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200642Inst : IEnumerable<long>
{
public static readonly long[] Value=A200642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200642.Bytes);
public long this[int i]=>Value[i];

public static A200642Inst Instance=new A200642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200643
{
public static readonly long[] Value={ 1L,5L,0L,8L,0L,6L,3L,8L,7L,5L,0L,8L,5L,6L,5L,4L,9L,9L,0L,0L,6L,8L,7L,1L,0L,4L,0L,4L,9L,4L,2L,1L,0L,1L,5L,5L,9L,2L,6L,1L,7L,9L,8L,8L,8L,2L,3L,7L,2L,4L,0L,6L,5L,2L,3L,2L,8L,7L,9L,4L,8L,7L,4L,1L,5L,0L,7L,5L,0L,7L,9L,6L,8L,6L,8L,2L,1L,4L,7L,9L,7L,9L,8L,6L,3L,5L,9L,0L,5L,9L,2L,9L,5L,6L,1L,7L,1L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200643Inst : IEnumerable<long>
{
public static readonly long[] Value=A200643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200643.Bytes);
public long this[int i]=>Value[i];

public static A200643Inst Instance=new A200643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200644
{
public static readonly long[] Value={ 1L,5L,1L,6L,4L,9L,6L,2L,8L,2L,9L,2L,4L,1L,2L,3L,7L,5L,6L,0L,1L,2L,7L,2L,8L,3L,5L,2L,0L,3L,1L,5L,7L,9L,9L,8L,6L,5L,2L,6L,3L,3L,7L,8L,1L,3L,5L,1L,5L,9L,5L,1L,0L,2L,4L,6L,2L,3L,9L,5L,4L,7L,5L,8L,3L,6L,1L,7L,1L,8L,0L,3L,8L,9L,5L,8L,4L,7L,1L,9L,0L,2L,7L,0L,8L,7L,4L,7L,6L,7L,8L,5L,4L,5L,5L,1L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200644Inst : IEnumerable<long>
{
public static readonly long[] Value=A200644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200644.Bytes);
public long this[int i]=>Value[i];

public static A200644Inst Instance=new A200644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200645
{
public static readonly long[] Value={ 1L,5L,2L,2L,9L,2L,5L,8L,1L,4L,4L,6L,9L,9L,6L,5L,5L,3L,7L,6L,7L,3L,6L,6L,4L,3L,8L,7L,6L,6L,5L,1L,9L,9L,6L,6L,1L,6L,6L,2L,7L,3L,7L,1L,7L,8L,3L,3L,6L,5L,2L,6L,2L,1L,9L,4L,7L,2L,9L,4L,8L,1L,1L,4L,6L,5L,6L,1L,4L,2L,5L,9L,5L,1L,2L,3L,6L,9L,4L,1L,8L,7L,8L,9L,0L,3L,2L,4L,3L,4L,6L,7L,3L,6L,3L,4L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200645Inst : IEnumerable<long>
{
public static readonly long[] Value=A200645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200645.Bytes);
public long this[int i]=>Value[i];

public static A200645Inst Instance=new A200645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200646
{
public static readonly long[] Value={ 1L,5L,2L,7L,9L,9L,1L,4L,9L,7L,9L,1L,3L,9L,9L,9L,9L,1L,7L,1L,7L,1L,1L,3L,4L,3L,8L,4L,8L,6L,1L,4L,5L,5L,9L,3L,8L,6L,7L,7L,1L,6L,3L,1L,6L,6L,2L,6L,2L,4L,0L,5L,2L,1L,3L,0L,3L,4L,4L,9L,0L,9L,0L,9L,0L,1L,8L,8L,7L,9L,9L,3L,0L,3L,3L,9L,8L,1L,7L,9L,9L,3L,7L,4L,9L,7L,0L,5L,9L,2L,0L,4L,5L,3L,4L,3L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200646Inst : IEnumerable<long>
{
public static readonly long[] Value=A200646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200646.Bytes);
public long this[int i]=>Value[i];

public static A200646Inst Instance=new A200646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200647
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,3L,2L,2L,3L,4L,2L,1L,2L,3L,4L,4L,3L,2L,3L,2L,2L,3L,4L,4L,3L,4L,5L,4L,2L,3L,4L,2L,1L,2L,3L,4L,4L,3L,4L,5L,4L,4L,5L,6L,4L,3L,2L,3L,4L,4L,3L,2L,3L,2L,2L,3L,4L,4L,3L,4L,5L,4L,4L,5L,6L,4L,3L,4L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200647Inst : IEnumerable<long>
{
public static readonly long[] Value=A200647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200647.Bytes);
public long this[int i]=>Value[i];

public static A200647Inst Instance=new A200647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200648
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,3L,4L,4L,4L,5L,4L,4L,5L,4L,5L,5L,5L,6L,4L,5L,5L,5L,6L,5L,5L,6L,5L,6L,6L,6L,7L,5L,5L,6L,5L,6L,6L,6L,7L,5L,6L,6L,6L,7L,6L,6L,7L,6L,7L,7L,7L,8L,5L,6L,6L,6L,7L,6L,6L,7L,6L,7L,7L,7L,8L,6L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200648Inst : IEnumerable<long>
{
public static readonly long[] Value=A200648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200648.Bytes);
public long this[int i]=>Value[i];

public static A200648Inst Instance=new A200648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200649
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,2L,4L,1L,3L,3L,3L,5L,2L,2L,4L,2L,4L,4L,4L,6L,1L,3L,3L,3L,5L,3L,3L,5L,3L,5L,5L,5L,7L,2L,2L,4L,2L,4L,4L,4L,6L,2L,4L,4L,4L,6L,4L,4L,6L,4L,6L,6L,6L,8L,1L,3L,3L,3L,5L,3L,3L,5L,3L,5L,5L,5L,7L,3L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200649Inst : IEnumerable<long>
{
public static readonly long[] Value=A200649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200649.Bytes);
public long this[int i]=>Value[i];

public static A200649Inst Instance=new A200649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200650
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,2L,1L,1L,1L,0L,2L,2L,1L,2L,1L,1L,1L,0L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,3L,3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,4L,3L,3L,3L,2L,3L,3L,2L,3L,2L,2L,2L,1L,3L,3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,4L,4L,3L,4L,3L,3L,3L,2L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200650Inst : IEnumerable<long>
{
public static readonly long[] Value=A200650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200650.Bytes);
public long this[int i]=>Value[i];

public static A200650Inst Instance=new A200650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200651
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,1L,2L,3L,3L,2L,1L,4L,3L,3L,2L,3L,3L,2L,1L,2L,5L,3L,4L,3L,4L,3L,3L,2L,3L,3L,2L,1L,4L,3L,5L,4L,3L,5L,4L,3L,2L,5L,3L,4L,3L,4L,3L,3L,2L,3L,3L,2L,1L,2L,5L,3L,6L,5L,5L,4L,3L,4L,5L,5L,4L,3L,4L,3L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200651Inst : IEnumerable<long>
{
public static readonly long[] Value=A200651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200651.Bytes);
public long this[int i]=>Value[i];

public static A200651Inst Instance=new A200651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200652
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,-1L,-1L,3L,-1L,11L,0L,5L,23L,9L,17L,-1L,9L,5L,5L,0L,-1L,-1L,15L,17L,-1L,9L,0L,53L,9L,11L,0L,27L,5L,29L,39L,17L,0L,21L,-1L,47L,27L,-1L,65L,39L,17L,11L,75L,11L,29L,0L,-1L,5L,33L,0L,-1L,39L,59L,23L,39L,-1L,11L,39L,11L,17L,57L,47L,-1L,81L,29L,101L,39L,119L,23L,15L,89L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200652Inst : IEnumerable<long>
{
public static readonly long[] Value=A200652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200652.Bytes);
public long this[int i]=>Value[i];

public static A200652Inst Instance=new A200652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200653
{
public static readonly long[] Value={ 1L,-1L,5L,0L,-1L,-1L,3L,-1L,17L,0L,17L,23L,15L,17L,29L,9L,5L,5L,0L,11L,-1L,15L,17L,41L,9L,0L,53L,45L,11L,0L,57L,35L,29L,39L,59L,0L,45L,5L,59L,57L,65L,71L,57L,47L,71L,75L,83L,29L,0L,41L,77L,45L,0L,29L,87L,107L,83L,105L,41L,107L,69L,113L,125L,111L,47L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200653Inst : IEnumerable<long>
{
public static readonly long[] Value=A200653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200653.Bytes);
public long this[int i]=>Value[i];

public static A200653Inst Instance=new A200653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200654
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,27L,9L,2L,6L,7L,5L,14L,1L,5L,3L,10L,1L,15L,93L,36L,33L,5L,18L,1L,18L,1L,2L,28L,2L,10L,8L,1L,34L,11L,12L,3L,2L,116L,4L,52L,31L,29L,18L,42L,13L,32L,24L,71L,93L,122L,61L,75L,11L,141L,73L,31L,57L,36L,23L,43L,18L,15L,69L,33L,15L,10L,39L,8L,108L,29L,72L,7L,8L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200654Inst : IEnumerable<long>
{
public static readonly long[] Value=A200654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200654.Bytes);
public long this[int i]=>Value[i];

public static A200654Inst Instance=new A200654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200655
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,19L,20L,23L,96L,190L,312L,400L,434L,852L,980L,1063L,1208L,3960L,5464L,6694L,7178L,13118L,13680L,18803L,27445L,28541L,42031L,73209L,83873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200655Inst : IEnumerable<long>
{
public static readonly long[] Value=A200655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200655.Bytes);
public long this[int i]=>Value[i];

public static A200655Inst Instance=new A200655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200656
{
public static readonly long[] Value={ 1942L,2878L,3862L,6100L,8380L,11512L,15448L,18694L,31228L,93844L,111382L,117118L,129910L,143950L,186145L,210025L,375376L,445528L,468472L,575800L,844596L,1002438L,1054062L,1193740L,1248412L,1326025L,1388545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200656Inst : IEnumerable<long>
{
public static readonly long[] Value=A200656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200656.Bytes);
public long this[int i]=>Value[i];

public static A200656Inst Instance=new A200656Inst();

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