using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A129437
{
public static readonly long[] Value={ 1L,5L,22L,181L,2183L,47773L,1689841L,90972682L,6948008975L,721121538707L,98626660242232L,17361164959413148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129437Inst : IEnumerable<long>
{
public static readonly long[] Value=A129437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129437.Bytes);
public long this[int i]=>Value[i];

public static A129437Inst Instance=new A129437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129438
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,0L,0L,0L,2L,3L,0L,2L,4L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,0L,4L,1L,0L,4L,0L,0L,0L,0L,2L,4L,0L,0L,6L,0L,0L,0L,0L,2L,0L,2L,4L,0L,0L,0L,4L,1L,0L,4L,0L,0L,0L,0L,0L,4L,0L,2L,0L,0L,0L,0L,2L,0L,0L,2L,4L,0L,0L,0L,6L,2L,0L,2L,4L,0L,0L,0L,0L,5L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129438Inst : IEnumerable<long>
{
public static readonly long[] Value=A129438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129438.Bytes);
public long this[int i]=>Value[i];

public static A129438Inst Instance=new A129438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129439
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,8L,12L,8L,1L,1L,5L,20L,20L,5L,1L,1L,36L,90L,240L,240L,90L,36L,1L,1L,7L,126L,210L,210L,126L,7L,1L,1L,64L,224L,2688L,1680L,2688L,224L,64L,1L,1L,27L,864L,2016L,9072L,9072L,2016L,864L,27L,1L,1L,100L,1350L,28800L,25200L,181440L,25200L,28800L,1350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129439Inst : IEnumerable<long>
{
public static readonly long[] Value=A129439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129439.Bytes);
public long this[int i]=>Value[i];

public static A129439Inst Instance=new A129439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129440
{
public static readonly BigInteger[] Value={ 0L,1L,5L,55L,56980L,61667666167030L,BigInteger.Parse("78172010815921069181209893626754427513955") };
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
public class A129440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129440Inst Instance=new A129440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129441
{
public static readonly long[] Value={ 1L,1L,2L,7L,16L,39L,100L,248L,618L,1546L,3858L,9631L,24049L,60041L,149903L,374266L,934427L,2332981L,5824753L,14542648L,36308602L,90651625L,226329747L,565077072L,1410826915L,3522409024L,8794392287L,21956943442L,54819861280L,136868649264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129441Inst : IEnumerable<long>
{
public static readonly long[] Value=A129441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129441.Bytes);
public long this[int i]=>Value[i];

public static A129441Inst Instance=new A129441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129442
{
public static readonly long[] Value={ 1L,2L,6L,21L,80L,322L,1348L,5814L,25674L,115566L,528528L,2449746L,11485068L,54377288L,259663576L,1249249981L,6049846848L,29469261934L,144293491564L,709806846980L,3506278661820L,17385618278700L,86500622296800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129442Inst : IEnumerable<long>
{
public static readonly long[] Value=A129442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129442.Bytes);
public long this[int i]=>Value[i];

public static A129442Inst Instance=new A129442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129443
{
public static readonly long[] Value={ 1L,1L,3L,25L,75L,289L,1283L,4905L,19547L,79281L,315123L,1260153L,5049419L,20180865L,80722531L,322959049L,1291700027L,5166801489L,20667742419L,82669888537L,330679592235L,1322722573857L,5290881765955L,21163527357033L,84654142731803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129443Inst : IEnumerable<long>
{
public static readonly long[] Value=A129443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129443.Bytes);
public long this[int i]=>Value[i];

public static A129443Inst Instance=new A129443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129444
{
public static readonly long[] Value={ 0L,1L,2L,7L,16L,65L,154L,639L,1520L,6321L,15042L,62567L,148896L,619345L,1473914L,6130879L,14590240L,60689441L,144428482L,600763527L,1429694576L,5946945825L,14152517274L,58868694719L,140095478160L,582740001361L,1386802264322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129444Inst : IEnumerable<long>
{
public static readonly long[] Value=A129444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129444.Bytes);
public long this[int i]=>Value[i];

public static A129444Inst Instance=new A129444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129445
{
public static readonly long[] Value={ 1L,2L,8L,19L,79L,188L,782L,1861L,7741L,18422L,76628L,182359L,758539L,1805168L,7508762L,17869321L,74329081L,176888042L,735782048L,1751011099L,7283491399L,17333222948L,72099131942L,171581218381L,713707828021L,1698478960862L,7064979148268L,16813208390239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129445Inst : IEnumerable<long>
{
public static readonly long[] Value=A129445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129445.Bytes);
public long this[int i]=>Value[i];

public static A129445Inst Instance=new A129445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129446
{
public static readonly long[] Value={ 2L,19L,79L,1861L,7741L,1647522841025041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129446Inst : IEnumerable<long>
{
public static readonly long[] Value=A129446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129446.Bytes);
public long this[int i]=>Value[i];

public static A129446Inst Instance=new A129446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129447
{
public static readonly long[] Value={ 1L,-1L,2L,0L,1L,0L,2L,-2L,2L,0L,0L,0L,3L,-1L,2L,0L,0L,0L,2L,-2L,2L,0L,2L,0L,1L,-2L,2L,0L,0L,0L,2L,0L,4L,0L,0L,0L,2L,-3L,0L,0L,1L,0L,4L,-2L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,2L,-2L,2L,0L,2L,0L,1L,-2L,4L,0L,0L,0L,0L,-2L,2L,0L,0L,0L,4L,-1L,2L,0L,2L,0L,2L,-2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129447Inst : IEnumerable<long>
{
public static readonly long[] Value=A129447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129447.Bytes);
public long this[int i]=>Value[i];

public static A129447Inst Instance=new A129447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129464
{
public static readonly BigInteger[] Value={ 1L,-2L,-6L,-48L,-720L,-17280L,-604800L,-29030400L,-1828915200L,-146313216000L,-14485008384000L,-1738201006080000L,-248562743869440000L,BigInteger.Parse("-41758540970065920000"),BigInteger.Parse("-8142915489162854400000"),BigInteger.Parse("-1824013069572479385600000"),BigInteger.Parse("-465123332740982243328000000") };
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
public class A129464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129464Inst Instance=new A129464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129465
{
public static readonly BigInteger[] Value={ 1L,1L,-4L,-204L,-7776L,-358560L,-20839680L,-1516112640L,-135920332800L,-14772931891200L,-1917601910784000L,-293337284308992000L,BigInteger.Parse("-52263416690343936000"),BigInteger.Parse("-10734227287227924480000"),BigInteger.Parse("-2518467729187335045120000"),BigInteger.Parse("-669569466986357627289600000") };
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
public class A129465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129465Inst Instance=new A129465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129466
{
public static readonly BigInteger[] Value={ 1L,12L,208L,5208L,179688L,8175744L,472666752L,33625704960L,2858013642240L,281566521446400L,30978996781363200L,3583376917637529600L,BigInteger.Parse("374151199254884352000"),BigInteger.Parse("9777217907401555968000"),BigInteger.Parse("-16608590925355066982400000"),BigInteger.Parse("-10323797933882945175552000000") };
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
public class A129466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129466Inst Instance=new A129466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129467
{
public static readonly long[] Value={ 1L,0L,1L,0L,-2L,1L,0L,12L,-8L,1L,0L,-144L,108L,-20L,1L,0L,2880L,-2304L,508L,-40L,1L,0L,-86400L,72000L,-17544L,1708L,-70L,1L,0L,3628800L,-3110400L,808848L,-89280L,4648L,-112L,1L,0L,-203212800L,177811200L,-48405888L,5808528L,-349568L,10920L,-168L,1L,0L,14631321600L,-13005619200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129467Inst : IEnumerable<long>
{
public static readonly long[] Value=A129467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129467.Bytes);
public long this[int i]=>Value[i];

public static A129467Inst Instance=new A129467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129468
{
public static readonly long[] Value={ -1L,-1L,-2L,-3L,-4L,0L,-6L,-7L,-8L,-2L,-10L,-4L,-12L,-4L,-6L,-15L,-16L,-6L,-18L,-10L,-10L,-8L,-22L,-12L,-24L,-10L,-26L,-16L,-28L,12L,-30L,-31L,-18L,-14L,-22L,-22L,-36L,-16L,-22L,-26L,-40L,12L,-42L,-28L,-30L,-20L,-46L,-28L,-48L,-22L,-30L,-34L,-52L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129468Inst : IEnumerable<long>
{
public static readonly long[] Value=A129468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129468.Bytes);
public long this[int i]=>Value[i];

public static A129468Inst Instance=new A129468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129469
{
public static readonly BigInteger[] Value={ 883L,3181L,15913L,2146141L,17227801L,456185017L,4960846573L,568124640697L,2273325467773L,145351829612377L,9302101084613641L,595332797734595317L,5813792718345189961L,BigInteger.Parse("1139502378775815768313"),BigInteger.Parse("166245781044286357673761") };
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
public class A129469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129469Inst Instance=new A129469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129470
{
public static readonly long[] Value={ 883L,1747L,2417L,2621L,3181L,3301L,3533L,3571L,3691L,3853L,4027L,4133L,4513L,4783L,4861L,4957L,5303L,5381L,5393L,5563L,5641L,5821L,6067L,6577L,6991L,7177L,7253L,7331L,8059L,8093L,8377L,8731L,8839L,8929L,8969L,9221L,9281L,9397L,9613L,9931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129470Inst : IEnumerable<long>
{
public static readonly long[] Value=A129470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129470.Bytes);
public long this[int i]=>Value[i];

public static A129470Inst Instance=new A129470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129471
{
public static readonly long[] Value={ 883L,1747L,2417L,2621L,3301L,3533L,3571L,3691L,3853L,4027L,4133L,4783L,4861L,5303L,5381L,5393L,5563L,5641L,5821L,6577L,6991L,7253L,7331L,8059L,8093L,8377L,8839L,8929L,8969L,9221L,9281L,9613L,9931L,10069L,10477L,10487L,10601L,10607L,10903L,11491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129471Inst : IEnumerable<long>
{
public static readonly long[] Value=A129471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129471.Bytes);
public long this[int i]=>Value[i];

public static A129471Inst Instance=new A129471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129472
{
public static readonly long[] Value={ 3181L,4513L,4957L,6067L,7177L,8731L,9397L,10433L,13171L,14947L,15761L,17389L,19387L,19609L,22051L,22273L,22453L,22717L,23531L,23753L,24197L,26161L,27823L,28711L,37369L,37591L,38183L,38923L,39293L,40993L,41143L,42697L,43067L,44621L,44843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129472Inst : IEnumerable<long>
{
public static readonly long[] Value=A129472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129472.Bytes);
public long this[int i]=>Value[i];

public static A129472Inst Instance=new A129472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129473
{
public static readonly long[] Value={ 15913L,18541L,22921L,36353L,47741L,49201L,52267L,55333L,60589L,64969L,66137L,66721L,69203L,72707L,73291L,74167L,75773L,78401L,79861L,80737L,82051L,84533L,90227L,90373L,95191L,95483L,95629L,97673L,99133L,101323L,103951L,104681L,104827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129473Inst : IEnumerable<long>
{
public static readonly long[] Value=A129473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129473.Bytes);
public long this[int i]=>Value[i];

public static A129473Inst Instance=new A129473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129474
{
public static readonly long[] Value={ 1704961513L,7281416041L,7638227617L,9462536833L,11934730597L,13237911481L,13282423003L,13522629793L,13942983841L,14185279861L,16029089501L,16221987853L,17434233041L,18171787987L,19639505461L,20717555041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129474Inst : IEnumerable<long>
{
public static readonly long[] Value=A129474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129474.Bytes);
public long this[int i]=>Value[i];

public static A129474Inst Instance=new A129474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129475
{
public static readonly long[] Value={ 23869461181L,39279010921L,45608421601L,58345550881L,64788537493L,79681330633L,83807064853L,86315197987L,91658731403L,97331927117L,102581556673L,104758832257L,106426256653L,111136152961L,111795382441L,125586978001L,143216767091L,144155203267L,144708098881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129475Inst : IEnumerable<long>
{
public static readonly long[] Value=A129475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129475.Bytes);
public long this[int i]=>Value[i];

public static A129475Inst Instance=new A129475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129476
{
public static readonly long[] Value={ 1L,12L,13L,124L,15L,1236L,17L,1248L,139L,125L,1L,12346L,1L,127L,135L,1248L,1L,12369L,1L,1245L,137L,12L,1L,123468L,15L,12L,139L,1247L,1L,12356L,1L,1248L,13L,12L,157L,123469L,1L,12L,13L,12458L,1L,12367L,1L,124L,1359L,12L,1L,123468L,17L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129476Inst : IEnumerable<long>
{
public static readonly long[] Value=A129476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129476.Bytes);
public long this[int i]=>Value[i];

public static A129476Inst Instance=new A129476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129477
{
public static readonly long[] Value={ 2146141L,2182897L,2954773L,3199813L,3224317L,3285577L,3383593L,3505933L,3555121L,3567373L,3653137L,3775417L,3864037L,4250977L,4298533L,4328053L,4493773L,4504651L,4519981L,4572037L,4647277L,4692637L,4719061L,4726537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129477Inst : IEnumerable<long>
{
public static readonly long[] Value=A129477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129477.Bytes);
public long this[int i]=>Value[i];

public static A129477Inst Instance=new A129477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129478
{
public static readonly long[] Value={ 17227801L,18207913L,18592957L,19433053L,19608073L,19678081L,20028121L,20518177L,20658193L,20833213L,21043237L,21218257L,21533293L,21743317L,22128361L,22303381L,23668537L,25068697L,25418737L,25453741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129478Inst : IEnumerable<long>
{
public static readonly long[] Value=A129478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129478.Bytes);
public long this[int i]=>Value[i];

public static A129478Inst Instance=new A129478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129479
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,1L,3L,1L,1L,1L,4L,0L,0L,1L,1L,4L,3L,1L,0L,1L,1L,6L,0L,0L,0L,0L,1L,1L,6L,2L,1L,1L,0L,0L,1L,1L,6L,2L,2L,0L,0L,0L,0L,1L,1L,8L,4L,0L,1L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129479Inst : IEnumerable<long>
{
public static readonly long[] Value=A129479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129479.Bytes);
public long this[int i]=>Value[i];

public static A129479Inst Instance=new A129479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129496
{
public static readonly long[] Value={ 10L,15L,21L,30L,35L,38L,42L,45L,46L,58L,60L,62L,70L,74L,82L,84L,86L,90L,94L,105L,106L,118L,122L,126L,132L,134L,140L,142L,146L,158L,166L,178L,180L,182L,185L,190L,194L,202L,206L,210L,214L,215L,217L,218L,219L,222L,226L,228L,231L,237L,249L,252L,254L,258L,259L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129496Inst : IEnumerable<long>
{
public static readonly long[] Value=A129496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129496.Bytes);
public long this[int i]=>Value[i];

public static A129496Inst Instance=new A129496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129497
{
public static readonly long[] Value={ 14L,21L,25L,42L,50L,56L,58L,62L,70L,74L,82L,84L,86L,94L,98L,105L,106L,112L,118L,122L,132L,133L,134L,142L,146L,147L,150L,152L,158L,166L,168L,178L,182L,194L,196L,202L,206L,210L,214L,218L,226L,231L,254L,262L,266L,274L,278L,294L,298L,301L,302L,314L,325L,326L,334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129497Inst : IEnumerable<long>
{
public static readonly long[] Value=A129497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129497.Bytes);
public long this[int i]=>Value[i];

public static A129497Inst Instance=new A129497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129498
{
public static readonly long[] Value={ 12L,12L,12L,4L,12L,12L,12L,12L,12L,12L,12L,156L,12L,12L,12L,12L,12L,12L,204L,12L,12L,228L,12L,120L,12L,12L,228L,12L,12L,276L,12L,252L,300L,12L,12L,12L,180L,12L,12L,120L,12L,348L,300L,12L,12L,12L,188L,120L,12L,324L,12L,12L,48L,300L,420L,12L,12L,196L,72L,444L,12L,372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129498Inst : IEnumerable<long>
{
public static readonly long[] Value=A129498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129498.Bytes);
public long this[int i]=>Value[i];

public static A129498Inst Instance=new A129498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129499
{
public static readonly long[] Value={ 30L,210L,330L,390L,510L,570L,690L,870L,930L,1110L,1230L,1290L,1410L,1470L,1590L,1770L,1830L,2010L,2130L,2190L,2310L,2730L,3570L,3990L,4830L,5610L,6090L,6510L,7590L,7770L,8610L,9030L,9870L,11130L,12390L,12810L,14070L,14910L,15330L,16590L,17430L,18690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129499Inst : IEnumerable<long>
{
public static readonly long[] Value=A129499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129499.Bytes);
public long this[int i]=>Value[i];

public static A129499Inst Instance=new A129499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129500
{
public static readonly long[] Value={ 2L,3L,5L,10L,0L,15L,12L,11L,16L,1L,25L,33L,18L,26L,24L,58L,57L,7L,1L,18L,12L,17L,20L,44L,97L,23L,49L,85L,40L,25L,94L,0L,81L,94L,49L,10L,117L,90L,49L,167L,112L,24L,113L,38L,92L,84L,78L,110L,105L,189L,207L,45L,232L,225L,58L,45L,90L,51L,24L,159L,228L,74L,297L,52L,216L,190L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129500Inst : IEnumerable<long>
{
public static readonly long[] Value=A129500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129500.Bytes);
public long this[int i]=>Value[i];

public static A129500Inst Instance=new A129500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129501
{
public static readonly long[] Value={ 1L,2L,1L,-1L,0L,1L,3L,2L,0L,1L,-1L,0L,0L,0L,1L,-2L,-1L,2L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,4L,3L,0L,2L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,-2L,-1L,0L,0L,2L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129501Inst : IEnumerable<long>
{
public static readonly long[] Value=A129501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129501.Bytes);
public long this[int i]=>Value[i];

public static A129501Inst Instance=new A129501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129502
{
public static readonly long[] Value={ 1L,3L,0L,6L,0L,0L,0L,10L,0L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,21L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129502Inst : IEnumerable<long>
{
public static readonly long[] Value=A129502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129502.Bytes);
public long this[int i]=>Value[i];

public static A129502Inst Instance=new A129502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129503
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,3L,0L,1L,1L,4L,0L,3L,0L,1L,5L,0L,6L,0L,0L,1L,6L,0L,10L,0L,0L,0L,1L,7L,0L,15L,0L,0L,0L,1L,1L,8L,0L,21L,0L,0L,0L,4L,0L,1L,9L,0L,28L,0L,0L,0L,1L,0L,0L,1L,10L,0L,36L,0L,0L,0L,20L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129503Inst : IEnumerable<long>
{
public static readonly long[] Value=A129503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129503.Bytes);
public long this[int i]=>Value[i];

public static A129503Inst Instance=new A129503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129504
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,12L,17L,24L,34L,39L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129504Inst : IEnumerable<long>
{
public static readonly long[] Value=A129504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129504.Bytes);
public long this[int i]=>Value[i];

public static A129504Inst Instance=new A129504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129505
{
public static readonly BigInteger[] Value={ 1L,3L,35L,735L,22449L,902055L,44990231L,2681453775L,185953177553L,14710753408923L,1307535010540395L,129006659818331295L,13990945200239106865UL,BigInteger.Parse("1654339178844590073615"),BigInteger.Parse("211821088794711294496815"),BigInteger.Parse("29197210605623737977801375"),BigInteger.Parse("4310704065427058593776844065") };
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
public class A129505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129505Inst Instance=new A129505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129506
{
public static readonly BigInteger[] Value={ 1L,3L,25L,350L,6951L,179487L,5715424L,216627840L,9528822303L,477297033785L,26826851689001L,1672162773483930L,114485073343744260L,8541149231801585700L,BigInteger.Parse("689692892575539953400"),BigInteger.Parse("59932861644880019603520"),BigInteger.Parse("5576731051262006158950735"),BigInteger.Parse("553234633385550257808059085") };
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
public class A129506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129506Inst Instance=new A129506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129507
{
public static readonly long[] Value={ 0L,0L,0L,4L,-4L,0L,8L,-16L,12L,20L,-80L,116L,-4L,-376L,884L,-764L,-1308L,5816L,-9128L,648L,32008L,-79608L,73100L,122020L,-574044L,937456L,-97748L,-3366892L,8659492L,-8276056L,-13301640L,65261640L,-109501476L,14857740L,395316672L,-1042421076L,1028105156L,1582877768L,-8052459580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129507Inst : IEnumerable<long>
{
public static readonly long[] Value=A129507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129507.Bytes);
public long this[int i]=>Value[i];

public static A129507Inst Instance=new A129507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129508
{
public static readonly long[] Value={ 0L,1L,10L,12L,27L,30L,31L,36L,37L,252L,255L,256L,280L,282L,756L,757L,760L,810L,811L,3160L,3162L,3186L,3187L,3250L,3252L,3276L,3277L,3280L,6561L,6562L,6885L,6886L,6912L,6925L,7536L,7537L,7560L,7561L,7626L,7627L,7650L,7651L,19686L,19687L,20007L,20010L,20011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129508Inst : IEnumerable<long>
{
public static readonly long[] Value=A129508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129508.Bytes);
public long this[int i]=>Value[i];

public static A129508Inst Instance=new A129508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129509
{
public static readonly long[] Value={ 0L,0L,0L,1L,-1L,0L,2L,-4L,3L,5L,-20L,29L,-1L,-94L,221L,-191L,-327L,1454L,-2282L,162L,8002L,-19902L,18275L,30505L,-143511L,234364L,-24437L,-841723L,2164873L,-2069014L,-3325410L,16315410L,-27375369L,3714435L,98829168L,-260605269L,257026289L,395719442L,-2013114895L,3450787313L,-572442080L,-12414009687L,33423611731L,-33865948418L,-49805740764L,262037063892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129509Inst : IEnumerable<long>
{
public static readonly long[] Value=A129509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129509.Bytes);
public long this[int i]=>Value[i];

public static A129509Inst Instance=new A129509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129510
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,1L,6L,3L,6L,1L,10L,1L,6L,5L,10L,1L,13L,1L,13L,6L,6L,1L,18L,3L,6L,6L,14L,1L,19L,1L,15L,6L,6L,6L,24L,1L,6L,6L,22L,1L,23L,1L,15L,12L,6L,1L,30L,3L,15L,6L,15L,1L,25L,6L,23L,6L,6L,1L,37L,1L,6L,13L,21L,6L,25L,1L,15L,6L,24L,1L,40L,1L,6L,13L,15L,6L,26L,1L,34L,10L,6L,1L,45L,6L,6L,6L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129510Inst : IEnumerable<long>
{
public static readonly long[] Value=A129510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129510.Bytes);
public long this[int i]=>Value[i];

public static A129510Inst Instance=new A129510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129511
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,16L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,32L,33L,34L,35L,37L,38L,39L,41L,43L,44L,46L,47L,49L,50L,51L,52L,53L,55L,57L,58L,59L,61L,62L,64L,65L,67L,68L,69L,71L,73L,74L,76L,77L,79L,81L,82L,83L,85L,86L,87L,89L,92L,93L,94L,95L,97L,98L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129511Inst : IEnumerable<long>
{
public static readonly long[] Value=A129511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129511.Bytes);
public long this[int i]=>Value[i];

public static A129511Inst Instance=new A129511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129544
{
public static readonly long[] Value={ 0L,115L,136L,411L,1036L,1155L,2740L,6375L,7068L,16303L,37488L,41527L,95352L,218827L,242368L,556083L,1275748L,1412955L,3241420L,7435935L,8235636L,18892711L,43340136L,48001135L,110115120L,252605155L,279771448L,641798283L,1472291068L,1630627827L,3740674852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129544Inst : IEnumerable<long>
{
public static readonly long[] Value=A129544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129544.Bytes);
public long this[int i]=>Value[i];

public static A129544Inst Instance=new A129544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129545
{
public static readonly long[] Value={ 1L,6L,10L,28L,36L,66L,78L,136L,190L,210L,276L,378L,630L,820L,946L,990L,1128L,1326L,1596L,1830L,2016L,2080L,2346L,2556L,2850L,2926L,3570L,3916L,4560L,4656L,4950L,5050L,5778L,6216L,6328L,8646L,8778L,9180L,9870L,11026L,12720L,13366L,14028L,14196L,14878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129545Inst : IEnumerable<long>
{
public static readonly long[] Value=A129545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129545.Bytes);
public long this[int i]=>Value[i];

public static A129545Inst Instance=new A129545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129546
{
public static readonly long[] Value={ 58L,61L,98L,138L,193L,217L,222L,233L,253L,266L,338L,358L,373L,393L,398L,402L,453L,461L,466L,477L,481L,542L,553L,557L,586L,597L,602L,618L,633L,646L,662L,761L,822L,838L,853L,857L,877L,898L,901L,913L,918L,926L,941L,986L,1006L,1041L,1061L,1077L,1126L,1157L,1161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129546Inst : IEnumerable<long>
{
public static readonly long[] Value=A129546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129546.Bytes);
public long this[int i]=>Value[i];

public static A129546Inst Instance=new A129546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129547
{
public static readonly long[] Value={ 0L,1L,3L,18L,94L,611L,4381L,35834L,326662L,3301193L,36611767L,442379438L,5784595282L,81393560783L,1226280162097L,19696507698878L,335990910075202L,6066382761193373L,115578717461844067L,2317323290060066858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129547Inst : IEnumerable<long>
{
public static readonly long[] Value=A129547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129547.Bytes);
public long this[int i]=>Value[i];

public static A129547Inst Instance=new A129547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129548
{
public static readonly long[] Value={ 1L,1L,8L,9L,36L,43L,120L,147L,329L,406L,784L,966L,1680L,2058L,3312L,4026L,6105L,7359L,10648L,12727L,17732L,21021L,28392L,33397L,43953L,51324L,66080L,76636L,96832L,111588L,138720L,158916L,194769L,221901L,268584L,304437L,364420L,411103L,487256L,547239L,642873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129548Inst : IEnumerable<long>
{
public static readonly long[] Value=A129548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129548.Bytes);
public long this[int i]=>Value[i];

public static A129548Inst Instance=new A129548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129549
{
public static readonly long[] Value={ 1L,3L,20L,78L,352L,1365L,5232L,18271L,60598L,187296L,548020L,1515265L,3991204L,10035401L,24210308L,56188768L,125904351L,273044682L,574635828L,1176027747L,2345376048L,4565886531L,8691118644L,16198834634L,29602895824L,53105875363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129549Inst : IEnumerable<long>
{
public static readonly long[] Value=A129549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129549.Bytes);
public long this[int i]=>Value[i];

public static A129549Inst Instance=new A129549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129550
{
public static readonly long[] Value={ 1L,1L,8L,20L,98L,293L,1128L,3409L,10846L,30480L,84652L,217677L,544312L,1289225L,2961626L,6528284L,13980717L,28963980L,58464510L,114806429L,220298632L,412950779L,758418342L,1365044296L,2412766496L,4189995629L,7159916414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129550Inst : IEnumerable<long>
{
public static readonly long[] Value=A129550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129550.Bytes);
public long this[int i]=>Value[i];

public static A129550Inst Instance=new A129550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129551
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,4L,44L,280L,1304L,12452L,105012L,977664L,9239816L,90776620L,897446092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129551Inst : IEnumerable<long>
{
public static readonly long[] Value=A129551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129551.Bytes);
public long this[int i]=>Value[i];

public static A129551Inst Instance=new A129551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129552
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,6L,37L,164L,1572L,13133L,122279L,1155103L,11347863L,112182378L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129552Inst : IEnumerable<long>
{
public static readonly long[] Value=A129552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129552.Bytes);
public long this[int i]=>Value[i];

public static A129552Inst Instance=new A129552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129553
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,8L,44L,528L,5976L,77896L,1052884L,13666360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129553Inst : IEnumerable<long>
{
public static readonly long[] Value=A129553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129553.Bytes);
public long this[int i]=>Value[i];

public static A129553Inst Instance=new A129553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129554
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,6L,66L,751L,9737L,131672L,1708295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129554Inst : IEnumerable<long>
{
public static readonly long[] Value=A129554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129554.Bytes);
public long this[int i]=>Value[i];

public static A129554Inst Instance=new A129554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129555
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,2L,1L,0L,1L,5L,0L,0L,0L,1L,3L,3L,1L,0L,0L,1L,7L,0L,0L,0L,0L,0L,1L,4L,2L,0L,1L,0L,0L,0L,1L,9L,0L,3L,0L,0L,0L,0L,0L,1L,5L,5L,0L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129555Inst : IEnumerable<long>
{
public static readonly long[] Value=A129555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129555.Bytes);
public long this[int i]=>Value[i];

public static A129555Inst Instance=new A129555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129556
{
public static readonly long[] Value={ 0L,2L,21L,95L,816L,3626L,31005L,137711L,1177392L,5229410L,44709909L,198579887L,1697799168L,7540806314L,64471658493L,286352060063L,2448225223584L,10873837476098L,92968086837717L,412919472031679L,3530339074609680L,15680066099727722L,134059916748330141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129556Inst : IEnumerable<long>
{
public static readonly long[] Value=A129556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129556.Bytes);
public long this[int i]=>Value[i];

public static A129556Inst Instance=new A129556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129557
{
public static readonly long[] Value={ 1L,4L,34L,151L,1291L,5734L,49024L,217741L,1861621L,8268424L,70692574L,313982371L,2684456191L,11923061674L,101938642684L,452762361241L,3870983965801L,17193046665484L,146995452057754L,652883010927151L,5581956194228851L,24792361368566254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129557Inst : IEnumerable<long>
{
public static readonly long[] Value=A129557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129557.Bytes);
public long this[int i]=>Value[i];

public static A129557Inst Instance=new A129557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129558
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,2L,1L,0L,1L,3L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,5L,0L,0L,0L,0L,0L,1L,4L,2L,0L,1L,0L,0L,0L,1L,4L,0L,1L,0L,0L,0L,0L,0L,1L,3L,3L,0L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129558Inst : IEnumerable<long>
{
public static readonly long[] Value=A129558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129558.Bytes);
public long this[int i]=>Value[i];

public static A129558Inst Instance=new A129558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129559
{
public static readonly long[] Value={ 1L,2L,1L,2L,0L,1L,4L,2L,0L,1L,4L,0L,0L,0L,1L,4L,2L,2L,0L,0L,1L,6L,0L,0L,0L,0L,0L,1L,8L,4L,0L,2L,0L,0L,0L,1L,6L,0L,2L,0L,0L,0L,0L,0L,1L,8L,4L,0L,0L,2L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129559Inst : IEnumerable<long>
{
public static readonly long[] Value=A129559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129559.Bytes);
public long this[int i]=>Value[i];

public static A129559Inst Instance=new A129559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129640
{
public static readonly long[] Value={ 0L,155L,464L,939L,1764L,3515L,6260L,11055L,21252L,37247L,65192L,124623L,217848L,380723L,727112L,1270467L,2219772L,4238675L,7405580L,12938535L,24705564L,43163639L,75412064L,143995335L,251576880L,439534475L,839267072L,1466298267L,2561795412L,4891607723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129640Inst : IEnumerable<long>
{
public static readonly long[] Value=A129640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129640.Bytes);
public long this[int i]=>Value[i];

public static A129640Inst Instance=new A129640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129641
{
public static readonly long[] Value={ 0L,200L,611L,1227L,2291L,4620L,8180L,14364L,27927L,48671L,84711L,163760L,284664L,494720L,955451L,1660131L,2884427L,5569764L,9676940L,16812660L,32463951L,56402327L,97992351L,189214760L,328737840L,571142264L,1102825427L,1916025531L,3328862051L,6427738620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129641Inst : IEnumerable<long>
{
public static readonly long[] Value=A129641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129641.Bytes);
public long this[int i]=>Value[i];

public static A129641Inst Instance=new A129641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129642
{
public static readonly long[] Value={ 0L,348L,495L,1371L,3255L,4088L,9140L,20096L,24947L,54383L,118235L,146508L,318072L,690228L,855015L,1854963L,4024047L,4984496L,10812620L,23454968L,29052875L,63021671L,136706675L,169333668L,367318320L,796785996L,986950047L,2140889163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129642Inst : IEnumerable<long>
{
public static readonly long[] Value=A129642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129642.Bytes);
public long this[int i]=>Value[i];

public static A129642Inst Instance=new A129642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129643
{
public static readonly long[] Value={ 1L,2L,4L,12L,24L,72L,360L,720L,2160L,8640L,43200L,302400L,3931200L,7862400L,23587200L,94348800L,471744000L,3302208000L,29719872000L,386358336000L,9658958400000L,19317916800000L,57953750400000L,231815001600000L,1159075008000000L,8113525056000000L,73021725504000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129643Inst : IEnumerable<long>
{
public static readonly long[] Value=A129643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129643.Bytes);
public long this[int i]=>Value[i];

public static A129643Inst Instance=new A129643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129644
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,1L,2L,3L,4L,6L,12L,1L,2L,3L,4L,6L,8L,12L,24L,1L,2L,3L,4L,6L,8L,9L,12L,18L,24L,36L,72L,1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,15L,18L,20L,24L,30L,36L,40L,45L,60L,72L,90L,120L,180L,360L,1L,2L,3L,4L,5L,6L,8L,9L,10L,12L,15L,16L,18L,20L,24L,30L,36L,40L,45L,48L,60L,72L,80L,90L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129644Inst : IEnumerable<long>
{
public static readonly long[] Value=A129644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129644.Bytes);
public long this[int i]=>Value[i];

public static A129644Inst Instance=new A129644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129645
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,25L,26L,183L,184L,369L,1477L,11817L,11818L,59091L,1477276L,1477277L,2954555L,38409216L,998639617L,998639618L,2995918855L,182751050156L,33443442178549L,33443442178550L,66886884357101L,267547537428405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129645Inst : IEnumerable<long>
{
public static readonly long[] Value=A129645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129645.Bytes);
public long this[int i]=>Value[i];

public static A129645Inst Instance=new A129645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129646
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,7L,1L,2L,4L,8L,1L,5L,25L,1L,2L,13L,26L,1L,3L,61L,183L,1L,2L,4L,8L,23L,46L,92L,184L,1L,3L,9L,41L,123L,369L,1L,7L,211L,1477L,1L,3L,9L,13L,39L,101L,117L,303L,909L,1313L,3939L,11817L,1L,2L,19L,38L,311L,622L,5909L,11818L,1L,3L,19697L,59091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129646Inst : IEnumerable<long>
{
public static readonly long[] Value=A129646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129646.Bytes);
public long this[int i]=>Value[i];

public static A129646Inst Instance=new A129646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129647
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,12L,15L,20L,21L,30L,35L,42L,45L,56L,63L,72L,77L,90L,99L,110L,117L,132L,143L,156L,165L,182L,195L,210L,221L,240L,255L,272L,285L,306L,323L,342L,357L,380L,399L,420L,437L,462L,483L,506L,525L,552L,575L,600L,621L,650L,675L,702L,725L,756L,783L,812L,837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129647Inst : IEnumerable<long>
{
public static readonly long[] Value=A129647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129647.Bytes);
public long this[int i]=>Value[i];

public static A129647Inst Instance=new A129647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129648
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,6L,6L,12L,15L,30L,21L,60L,35L,84L,105L,140L,84L,210L,165L,280L,315L,360L,385L,504L,495L,630L,693L,792L,819L,990L,1001L,1170L,1287L,1430L,1365L,1716L,1683L,2002L,2145L,2310L,2431L,2730L,2805L,3120L,3315L,3570L,3705L,4080L,4199L,4560L,4845L,5168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129648Inst : IEnumerable<long>
{
public static readonly long[] Value=A129648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129648.Bytes);
public long this[int i]=>Value[i];

public static A129648Inst Instance=new A129648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129649
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,6L,6L,12L,15L,30L,30L,60L,60L,84L,105L,210L,140L,420L,210L,330L,420L,840L,420L,1260L,1155L,1540L,1365L,2520L,1320L,3080L,3465L,3960L,4095L,5544L,5005L,6930L,6435L,8190L,9009L,10296L,8415L,12870L,11781L,13464L,15015L,18018L,17017L,20592L,21879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129649Inst : IEnumerable<long>
{
public static readonly long[] Value=A129649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129649.Bytes);
public long this[int i]=>Value[i];

public static A129649Inst Instance=new A129649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129650
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,6L,6L,12L,15L,30L,30L,60L,60L,84L,105L,210L,210L,420L,420L,420L,420L,840L,840L,1260L,1260L,2310L,1540L,4620L,2520L,5460L,4620L,9240L,5460L,13860L,9240L,16380L,15015L,27720L,13860L,32760L,19635L,40040L,45045L,51480L,32760L,72072L,58905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129650Inst : IEnumerable<long>
{
public static readonly long[] Value=A129650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129650.Bytes);
public long this[int i]=>Value[i];

public static A129650Inst Instance=new A129650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129651
{
public static readonly long[] Value={ 1L,6L,37L,126L,287L,540L,895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129651Inst : IEnumerable<long>
{
public static readonly long[] Value=A129651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129651.Bytes);
public long this[int i]=>Value[i];

public static A129651Inst Instance=new A129651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129652
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,13L,9L,3L,1L,73L,52L,18L,4L,1L,501L,365L,130L,30L,5L,1L,4051L,3006L,1095L,260L,45L,6L,1L,37633L,28357L,10521L,2555L,455L,63L,7L,1L,394353L,301064L,113428L,28056L,5110L,728L,84L,8L,1L,4596553L,3549177L,1354788L,340284L,63126L,9198L,1092L,108L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129652Inst : IEnumerable<long>
{
public static readonly long[] Value=A129652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129652.Bytes);
public long this[int i]=>Value[i];

public static A129652Inst Instance=new A129652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129653
{
public static readonly ulong[] Value={ 1L,1L,4L,15L,83L,556L,4435L,40773L,423836L,4908403L,62606297L,871421976L,13136605577L,213122669141L,3701085673676L,68480774296803L,1344611320542931L,27917413103561540L,611000785570868627L,14056645627856206809UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129653Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A129653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129653.Bytes);
public ulong this[int i]=>Value[i];

public static A129653Inst Instance=new A129653Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129654
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,2L,3L,3L,2L,3L,2L,2L,4L,3L,2L,3L,2L,2L,4L,3L,2L,3L,3L,2L,3L,4L,2L,3L,2L,2L,3L,3L,3L,5L,2L,2L,3L,3L,2L,3L,2L,2L,5L,3L,2L,3L,3L,2L,4L,3L,2L,3L,4L,2L,3L,3L,2L,3L,2L,2L,3L,4L,3L,5L,2L,2L,3L,4L,2L,3L,2L,2L,4L,3L,2L,4L,2L,2L,5L,3L,2L,3L,3L,2L,3L,3L,2L,3L,4L,3L,3L,3L,3L,4L,2L,2L,3L,4L,2L,3L,2L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129654Inst : IEnumerable<long>
{
public static readonly long[] Value=A129654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129654.Bytes);
public long this[int i]=>Value[i];

public static A129654Inst Instance=new A129654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129655
{
public static readonly long[] Value={ 1L,2L,6L,24L,120L,720L,5040L,55440L,720720L,12252240L,232792560L,6750984240L,276790353840L,12732356276640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129655Inst : IEnumerable<long>
{
public static readonly long[] Value=A129655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129655.Bytes);
public long this[int i]=>Value[i];

public static A129655Inst Instance=new A129655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129704
{
public static readonly long[] Value={ -1L,-1L,1L,2L,1L,-1L,-4L,-4L,3L,10L,7L,-6L,-20L,-18L,12L,47L,39L,-27L,-100L,-89L,53L,224L,202L,-115L,-490L,-453L,232L,1080L,1028L,-484L,-2377L,-2309L,985L,5222L,5213L,-2005L,-11488L,-11724L,4043L,25226L,26387L,-8062L,-55420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129704Inst : IEnumerable<long>
{
public static readonly long[] Value=A129704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129704.Bytes);
public long this[int i]=>Value[i];

public static A129704Inst Instance=new A129704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129705
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,-1L,4L,3L,1L,-2L,7L,6L,4L,1L,-3L,12L,11L,9L,6L,2L,-3L,20L,19L,17L,14L,10L,5L,-1L,33L,32L,30L,27L,23L,18L,12L,5L,54L,53L,51L,48L,44L,39L,33L,26L,18L,88L,87L,85L,82L,78L,73L,67L,60L,52L,43L,143L,142L,140L,137L,133L,128L,122L,115L,107L,98L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129705Inst : IEnumerable<long>
{
public static readonly long[] Value=A129705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129705.Bytes);
public long this[int i]=>Value[i];

public static A129705Inst Instance=new A129705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129706
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,4L,2L,1L,2L,2L,2L,4L,4L,4L,2L,1L,2L,2L,2L,4L,4L,6L,6L,4L,2L,2L,2L,2L,2L,4L,4L,6L,8L,8L,6L,6L,4L,2L,1L,2L,2L,2L,4L,4L,6L,8L,10L,10L,10L,10L,8L,6L,4L,2L,1L,2L,2L,2L,4L,4L,6L,8L,10L,12L,14L,14L,14L,14L,12L,10L,8L,4L,2L,2L,2L,2L,2L,4L,4L,6L,8L,10L,12L,16L,18L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129706Inst : IEnumerable<long>
{
public static readonly long[] Value=A129706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129706.Bytes);
public long this[int i]=>Value[i];

public static A129706Inst Instance=new A129706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129707
{
public static readonly long[] Value={ 0L,0L,1L,4L,12L,31L,73L,162L,344L,707L,1416L,2778L,5358L,10188L,19139L,35582L,65556L,119825L,217487L,392286L,703618L,1255669L,2230608L,3946020L,6954060L,12212280L,21377365L,37309288L,64935132L,112726771L,195224773L,337343034L,581700476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129707Inst : IEnumerable<long>
{
public static readonly long[] Value=A129707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129707.Bytes);
public long this[int i]=>Value[i];

public static A129707Inst Instance=new A129707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129708
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,6L,2L,9L,3L,1L,13L,6L,2L,19L,11L,3L,1L,28L,18L,7L,2L,41L,30L,14L,3L,1L,60L,50L,24L,8L,2L,88L,81L,43L,17L,3L,1L,129L,130L,77L,30L,9L,2L,189L,208L,132L,57L,20L,3L,1L,277L,330L,224L,108L,36L,10L,2L,406L,520L,379L,193L,72L,23L,3L,1L,595L,816L,633L,342L,143L,42L,11L,2L,872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129708Inst : IEnumerable<long>
{
public static readonly long[] Value=A129708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129708.Bytes);
public long this[int i]=>Value[i];

public static A129708Inst Instance=new A129708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129709
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,5L,3L,6L,7L,7L,13L,1L,8L,22L,4L,9L,34L,12L,10L,50L,28L,1L,11L,70L,58L,5L,12L,95L,108L,18L,13L,125L,188L,50L,1L,14L,161L,308L,121L,6L,15L,203L,483L,261L,25L,16L,252L,728L,520L,80L,1L,17L,308L,1064L,968L,220L,7L,18L,372L,1512L,1710L,536L,33L,19L,444L,2100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129709Inst : IEnumerable<long>
{
public static readonly long[] Value=A129709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129709.Bytes);
public long this[int i]=>Value[i];

public static A129709Inst Instance=new A129709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129710
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,3L,2L,5L,1L,2L,7L,4L,2L,9L,9L,1L,2L,11L,16L,5L,2L,13L,25L,14L,1L,2L,15L,36L,30L,6L,2L,17L,49L,55L,20L,1L,2L,19L,64L,91L,50L,7L,2L,21L,81L,140L,105L,27L,1L,2L,23L,100L,204L,196L,77L,8L,2L,25L,121L,285L,336L,182L,35L,1L,2L,27L,144L,385L,540L,378L,112L,9L,2L,29L,169L,506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129710Inst : IEnumerable<long>
{
public static readonly long[] Value=A129710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129710.Bytes);
public long this[int i]=>Value[i];

public static A129710Inst Instance=new A129710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129711
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,2L,5L,2L,1L,8L,3L,2L,13L,5L,2L,1L,21L,8L,3L,2L,34L,13L,5L,2L,1L,55L,21L,8L,3L,2L,89L,34L,13L,5L,2L,1L,144L,55L,21L,8L,3L,2L,233L,89L,34L,13L,5L,2L,1L,377L,144L,55L,21L,8L,3L,2L,610L,233L,89L,34L,13L,5L,2L,1L,987L,377L,144L,55L,21L,8L,3L,2L,1597L,610L,233L,89L,34L,13L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129711Inst : IEnumerable<long>
{
public static readonly long[] Value=A129711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129711.Bytes);
public long this[int i]=>Value[i];

public static A129711Inst Instance=new A129711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129712
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,1L,6L,1L,1L,10L,2L,1L,16L,3L,1L,1L,26L,5L,2L,1L,42L,8L,3L,1L,1L,68L,13L,5L,2L,1L,110L,21L,8L,3L,1L,1L,178L,34L,13L,5L,2L,1L,288L,55L,21L,8L,3L,1L,1L,466L,89L,34L,13L,5L,2L,1L,754L,144L,55L,21L,8L,3L,1L,1L,1220L,233L,89L,34L,13L,5L,2L,1L,1974L,377L,144L,55L,21L,8L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129712Inst : IEnumerable<long>
{
public static readonly long[] Value=A129712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129712.Bytes);
public long this[int i]=>Value[i];

public static A129712Inst Instance=new A129712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129713
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,5L,3L,2L,1L,1L,1L,8L,5L,3L,2L,1L,1L,1L,13L,8L,5L,3L,2L,1L,1L,1L,21L,13L,8L,5L,3L,2L,1L,1L,1L,34L,21L,13L,8L,5L,3L,2L,1L,1L,1L,55L,34L,21L,13L,8L,5L,3L,2L,1L,1L,1L,89L,55L,34L,21L,13L,8L,5L,3L,2L,1L,1L,1L,144L,89L,55L,34L,21L,13L,8L,5L,3L,2L,1L,1L,1L,233L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129713Inst : IEnumerable<long>
{
public static readonly long[] Value=A129713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129713.Bytes);
public long this[int i]=>Value[i];

public static A129713Inst Instance=new A129713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129714
{
public static readonly long[] Value={ 1L,0L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,3L,2L,0L,1L,2L,4L,4L,2L,0L,1L,2L,5L,6L,5L,2L,0L,1L,2L,6L,8L,9L,6L,2L,0L,1L,2L,7L,10L,14L,12L,7L,2L,0L,1L,2L,8L,12L,20L,20L,16L,8L,2L,0L,1L,2L,9L,14L,27L,30L,30L,20L,9L,2L,0L,1L,2L,10L,16L,35L,42L,50L,40L,25L,10L,2L,0L,1L,2L,11L,18L,44L,56L,77L,70L,55L,30L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129714Inst : IEnumerable<long>
{
public static readonly long[] Value=A129714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129714.Bytes);
public long this[int i]=>Value[i];

public static A129714Inst Instance=new A129714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129715
{
public static readonly long[] Value={ 0L,2L,5L,11L,22L,43L,81L,150L,273L,491L,874L,1543L,2705L,4714L,8173L,14107L,24254L,41555L,70977L,120894L,205401L,348187L,589010L,994511L,1676257L,2820818L,4739861L,7953515L,13328998L,22310971L,37304049L,62307558L,103968225L,173324939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129715Inst : IEnumerable<long>
{
public static readonly long[] Value=A129715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129715.Bytes);
public long this[int i]=>Value[i];

public static A129715Inst Instance=new A129715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129716
{
public static readonly BigInteger[] Value={ 1L,2L,3L,10L,40L,196L,1176L,8352L,66816L,589248L,5892480L,67841280L,814095360L,9007096320L,126099348480L,3417110323200L,54673765171200L,-1593137026252800L,-28676466472550400L,6142121597716070400L,BigInteger.Parse("122842431954321408000"),BigInteger.Parse("-24453765000305786880000") };
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
public class A129716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129716Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129716.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129716Inst Instance=new A129716Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129717
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,4L,4L,4L,8L,1L,4L,12L,5L,4L,16L,13L,1L,4L,20L,25L,6L,4L,24L,41L,19L,1L,4L,28L,61L,44L,7L,4L,32L,85L,85L,26L,1L,4L,36L,113L,146L,70L,8L,4L,40L,145L,231L,155L,34L,1L,4L,44L,181L,344L,301L,104L,9L,4L,48L,221L,489L,532L,259L,43L,1L,4L,52L,265L,670L,876L,560L,147L,10L,4L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129717Inst : IEnumerable<long>
{
public static readonly long[] Value=A129717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129717.Bytes);
public long this[int i]=>Value[i];

public static A129717Inst Instance=new A129717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129718
{
public static readonly long[] Value={ 1L,1L,1L,0L,3L,0L,4L,1L,0L,4L,4L,0L,4L,8L,1L,0L,4L,12L,5L,0L,4L,16L,13L,1L,0L,4L,20L,25L,6L,0L,4L,24L,41L,19L,1L,0L,4L,28L,61L,44L,7L,0L,4L,32L,85L,85L,26L,1L,0L,4L,36L,113L,146L,70L,8L,0L,4L,40L,145L,231L,155L,34L,1L,0L,4L,44L,181L,344L,301L,104L,9L,0L,4L,48L,221L,489L,532L,259L,43L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129718Inst : IEnumerable<long>
{
public static readonly long[] Value=A129718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129718.Bytes);
public long this[int i]=>Value[i];

public static A129718Inst Instance=new A129718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129719
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,2L,1L,4L,3L,1L,4L,5L,3L,1L,8L,8L,4L,1L,8L,12L,9L,4L,1L,16L,20L,13L,5L,1L,16L,28L,25L,14L,5L,1L,32L,48L,38L,19L,6L,1L,32L,64L,66L,44L,20L,6L,1L,64L,112L,104L,63L,26L,7L,1L,64L,144L,168L,129L,70L,27L,7L,1L,128L,256L,272L,192L,96L,34L,8L,1L,128L,320L,416L,360L,225L,104L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129719Inst : IEnumerable<long>
{
public static readonly long[] Value=A129719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129719.Bytes);
public long this[int i]=>Value[i];

public static A129719Inst Instance=new A129719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129768
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,3L,3L,4L,6L,6L,8L,9L,9L,10L,12L,14L,14L,16L,17L,17L,19L,20L,22L,25L,26L,26L,27L,27L,28L,34L,35L,37L,37L,41L,41L,43L,45L,46L,48L,50L,50L,54L,54L,55L,55L,60L,65L,66L,66L,67L,69L,69L,73L,75L,77L,79L,79L,81L,82L,82L,86L,92L,93L,93L,94L,100L,102L,106L,106L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129768Inst : IEnumerable<long>
{
public static readonly long[] Value=A129768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129768.Bytes);
public long this[int i]=>Value[i];

public static A129768Inst Instance=new A129768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129769
{
public static readonly long[] Value={ 1L,1L,5L,1L,5L,7L,11L,1L,4L,5L,7L,8L,11L,1L,5L,7L,9L,11L,13L,17L,1L,6L,9L,11L,13L,15L,17L,19L,1L,7L,11L,13L,17L,19L,23L,29L,1L,11L,17L,19L,23L,29L,31L,51L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129769Inst : IEnumerable<long>
{
public static readonly long[] Value=A129769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129769.Bytes);
public long this[int i]=>Value[i];

public static A129769Inst Instance=new A129769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129770
{
public static readonly long[] Value={ 0L,1L,3L,9L,27L,79L,237L,705L,2115L,6327L,18981L,56889L,170667L,511843L,1535529L,4606113L,13818339L,41453607L,124360821L,373078233L,1119234699L,3357691443L,10073074329L,30219185025L,90657555075L,271972551447L,815917654341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129770Inst : IEnumerable<long>
{
public static readonly long[] Value=A129770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129770.Bytes);
public long this[int i]=>Value[i];

public static A129770Inst Instance=new A129770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129771
{
public static readonly long[] Value={ 3L,5L,9L,15L,17L,23L,27L,29L,33L,39L,43L,45L,51L,53L,57L,63L,65L,71L,75L,77L,83L,85L,89L,95L,99L,101L,105L,111L,113L,119L,123L,125L,129L,135L,139L,141L,147L,149L,153L,159L,163L,165L,169L,175L,177L,183L,187L,189L,195L,197L,201L,207L,209L,215L,219L,221L,225L,231L,235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129771Inst : IEnumerable<long>
{
public static readonly long[] Value=A129771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129771.Bytes);
public long this[int i]=>Value[i];

public static A129771Inst Instance=new A129771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129772
{
public static readonly long[] Value={ 1L,2L,6L,16L,48L,140L,420L,1248L,3744L,11200L,33600L,100704L,302112L,906056L,2718168L,8153664L,24460992L,73380480L,220141440L,660416832L,1981250496L,5943729088L,17831187264L,53493494592L,160480483776L,481441249920L,1444323749760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129772Inst : IEnumerable<long>
{
public static readonly long[] Value=A129772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129772.Bytes);
public long this[int i]=>Value[i];

public static A129772Inst Instance=new A129772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129773
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,4L,3L,2L,2L,1L,1L,1L,5L,3L,2L,1L,2L,1L,1L,1L,6L,3L,2L,1L,1L,2L,1L,1L,1L,7L,3L,2L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129773Inst : IEnumerable<long>
{
public static readonly long[] Value=A129773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129773.Bytes);
public long this[int i]=>Value[i];

public static A129773Inst Instance=new A129773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129774
{
public static readonly BigInteger[] Value={ 1L,5L,8L,30L,0L,42L,36L,47L,79L,BigInteger.Parse("1000000000000000000000000"),1000001L,80000L,19000000L,612L,1000000070L,218L,217L,234L,233L };
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
public class A129774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A129774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A129774Inst Instance=new A129774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129775
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,78L,298L,1157L,4539L,17936L,71251L,284188L,1137076L,4561093L,18333337L,73816489L,297635750L,1201551286L,4855672249L,19640147061L,79501958895L,322037615290L,1305256267511L,5293166568270L,21475362822956L,87166344495561L,353933533606927L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129775Inst : IEnumerable<long>
{
public static readonly long[] Value=A129775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129775.Bytes);
public long this[int i]=>Value[i];

public static A129775Inst Instance=new A129775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A129776
{
public static readonly long[] Value={ 1L,2L,6L,21L,78L,298L,1157L,4535L,17872L,70644L,279704L,1108462L,4395045L,17431206L,69144643L,274300461L,1088215370L,4317321235L,17128527716L,67956202025L,269612504850L,1069675361622L,4243893926396L,16837490364983L,66802139457897L,265035151393777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A129776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A129776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A129776Inst : IEnumerable<long>
{
public static readonly long[] Value=A129776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A129776.Bytes);
public long this[int i]=>Value[i];

public static A129776Inst Instance=new A129776Inst();

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