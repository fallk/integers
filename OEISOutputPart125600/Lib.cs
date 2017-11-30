using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A159564
{
public static readonly BigInteger[] Value={ 1L,2L,-718L,-4324L,1546540L,15580792L,-5551847816L,-78599686576L,27901839488912L,509795468640800L,-180286562061668576L,-4041296407709913152L,BigInteger.Parse("1423753283078352004288"),BigInteger.Parse("37861298642555391557504"),BigInteger.Parse("-13287625717688301129132160"),BigInteger.Parse("-409277258114326500121514752") };
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
public class A159564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159564Inst Instance=new A159564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159565
{
public static readonly long[] Value={ 221L,241L,265L,1061L,1205L,1369L,6145L,6989L,7949L,35809L,40729L,46325L,208709L,237385L,270001L,1216445L,1383581L,1573681L,7089961L,8064101L,9172085L,41323321L,47001025L,53458829L,240849965L,273942049L,311580889L,1403776469L,1596651269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159565Inst : IEnumerable<long>
{
public static readonly long[] Value=A159565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159565.Bytes);
public long this[int i]=>Value[i];

public static A159565Inst Instance=new A159565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159566
{
public static readonly long[] Value={ 1L,1L,3L,7L,3L,9L,7L,0L,8L,8L,6L,8L,1L,3L,6L,1L,3L,7L,3L,7L,4L,9L,5L,3L,1L,7L,5L,0L,7L,5L,7L,7L,3L,1L,7L,7L,4L,8L,0L,7L,1L,8L,9L,9L,6L,3L,7L,2L,7L,3L,5L,6L,2L,5L,5L,6L,4L,2L,6L,8L,4L,4L,5L,7L,4L,0L,9L,9L,4L,2L,3L,8L,3L,9L,2L,6L,0L,0L,1L,4L,7L,2L,4L,2L,6L,1L,7L,6L,4L,5L,5L,4L,1L,5L,8L,0L,1L,3L,0L,5L,3L,9L,4L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159566Inst : IEnumerable<long>
{
public static readonly long[] Value=A159566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159566.Bytes);
public long this[int i]=>Value[i];

public static A159566Inst Instance=new A159566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159567
{
public static readonly long[] Value={ 4L,5L,0L,5L,3L,3L,5L,5L,9L,2L,0L,0L,4L,4L,8L,8L,4L,6L,0L,9L,8L,5L,5L,0L,1L,9L,1L,6L,3L,5L,8L,8L,1L,9L,9L,8L,5L,7L,9L,2L,7L,9L,2L,8L,0L,3L,4L,0L,2L,2L,4L,1L,6L,7L,3L,1L,8L,8L,7L,2L,6L,0L,2L,7L,3L,4L,4L,3L,7L,8L,4L,9L,4L,5L,2L,6L,0L,9L,3L,0L,5L,8L,3L,7L,0L,2L,4L,8L,2L,1L,7L,9L,0L,9L,3L,1L,1L,0L,9L,0L,6L,2L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159567Inst : IEnumerable<long>
{
public static readonly long[] Value=A159567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159567.Bytes);
public long this[int i]=>Value[i];

public static A159567Inst Instance=new A159567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159568
{
public static readonly long[] Value={ 1123564987L,1123586479L,1123869547L,1124356789L,1124378659L,1124685973L,1124698537L,1124753689L,1124763589L,1124785639L,1124879563L,1124895367L,1124896753L,1124956837L,1124978563L,1125347689L,1125386749L,1125398467L,1125487963L,1125648379L,1125748693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159568Inst : IEnumerable<long>
{
public static readonly long[] Value=A159568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159568.Bytes);
public long this[int i]=>Value[i];

public static A159568Inst Instance=new A159568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159569
{
public static readonly long[] Value={ 10123465789L,10123685749L,10123746859L,10123854679L,10123945687L,10123956487L,10124356789L,10124378569L,10124563987L,10124568793L,10124683759L,10124695783L,10124736859L,10124763589L,10124785639L,10124867539L,10124867593L,10124935687L,10125367849L,10125368749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159569Inst : IEnumerable<long>
{
public static readonly long[] Value=A159569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159569.Bytes);
public long this[int i]=>Value[i];

public static A159569Inst Instance=new A159569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159570
{
public static readonly long[] Value={ 0L,1L,5L,1L,1L,5L,20L,1L,13L,2L,1L,1L,61L,1L,1L,2L,4L,1L,3L,1L,2L,1L,5L,1L,13L,1L,11L,7L,6L,2L,77L,7L,1L,5L,4L,8L,1L,1L,6L,4L,2L,1L,1L,2L,4L,1L,1L,2L,1L,3L,1L,1L,6L,6L,1L,7L,1L,10L,1L,1L,4L,1L,4L,2L,1L,7L,1L,4L,1L,2L,17L,2L,2L,1L,5L,2L,1L,2L,1L,1L,1L,3L,3L,1L,1L,6L,1L,1L,16L,3L,1320L,2L,2L,7L,5L,9L,1L,217L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159570Inst : IEnumerable<long>
{
public static readonly long[] Value=A159570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159570.Bytes);
public long this[int i]=>Value[i];

public static A159570Inst Instance=new A159570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159571
{
public static readonly long[] Value={ 6L,39L,138L,364L,804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159571Inst : IEnumerable<long>
{
public static readonly long[] Value=A159571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159571.Bytes);
public long this[int i]=>Value[i];

public static A159571Inst Instance=new A159571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159572
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,5L,2L,1L,10L,14L,12L,6L,1L,15L,30L,39L,39L,20L,1L,21L,55L,95L,138L,142L,71L,1L,28L,91L,195L,364L,548L,551L,270L,1L,36L,140L,357L,804L,1564L,2317L,2278L,1100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159572Inst : IEnumerable<long>
{
public static readonly long[] Value=A159572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159572.Bytes);
public long this[int i]=>Value[i];

public static A159572Inst Instance=new A159572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159573
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,3L,8L,7L,12L,10L,16L,15L,33L,50L,37L,32L,31L,78L,160L,222L,151L,64L,63L,171L,420L,814L,1057L,674L,128L,127L,360L,990L,2368L,4379L,5392L,3263L,256L,255L,741L,2190L,6031L,14043L,24938L,29367L,17007L,512L,511L,1506L,4660L,14134L,38656L,87620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159573Inst : IEnumerable<long>
{
public static readonly long[] Value=A159573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159573.Bytes);
public long this[int i]=>Value[i];

public static A159573Inst Instance=new A159573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159574
{
public static readonly long[] Value={ 313L,337L,365L,1513L,1685L,1877L,8765L,9773L,10897L,51077L,56953L,63505L,297697L,331945L,370133L,1735105L,1934717L,2157293L,10112933L,11276357L,12573625L,58942493L,65723425L,73284457L,343542025L,383064193L,427133117L,2002309657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159574Inst : IEnumerable<long>
{
public static readonly long[] Value=A159574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159574.Bytes);
public long this[int i]=>Value[i];

public static A159574Inst Instance=new A159574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159575
{
public static readonly long[] Value={ 1L,1L,1L,5L,0L,4L,3L,1L,8L,2L,8L,5L,3L,7L,1L,0L,5L,9L,7L,2L,3L,6L,9L,2L,5L,5L,3L,9L,5L,5L,3L,2L,7L,0L,4L,7L,4L,9L,0L,4L,4L,8L,5L,0L,7L,0L,5L,0L,3L,8L,5L,9L,4L,9L,5L,2L,5L,9L,9L,2L,1L,8L,7L,8L,8L,9L,5L,4L,2L,7L,4L,3L,1L,5L,7L,2L,7L,4L,4L,1L,6L,3L,2L,3L,4L,7L,4L,7L,9L,9L,9L,6L,8L,1L,0L,6L,4L,3L,3L,4L,9L,8L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159575Inst : IEnumerable<long>
{
public static readonly long[] Value=A159575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159575.Bytes);
public long this[int i]=>Value[i];

public static A159575Inst Instance=new A159575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159576
{
public static readonly long[] Value={ 4L,6L,8L,7L,7L,8L,8L,3L,6L,6L,9L,2L,2L,9L,7L,1L,9L,6L,1L,1L,6L,7L,2L,9L,9L,1L,7L,1L,1L,5L,5L,5L,3L,3L,4L,3L,0L,7L,0L,7L,1L,8L,5L,8L,3L,8L,3L,3L,5L,9L,3L,0L,0L,9L,2L,9L,2L,2L,0L,8L,8L,2L,0L,2L,6L,5L,1L,1L,7L,2L,2L,2L,6L,0L,9L,5L,6L,6L,9L,3L,7L,1L,1L,6L,5L,8L,8L,4L,3L,9L,7L,9L,6L,3L,9L,9L,3L,1L,6L,9L,2L,6L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159576Inst : IEnumerable<long>
{
public static readonly long[] Value=A159576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159576.Bytes);
public long this[int i]=>Value[i];

public static A159576Inst Instance=new A159576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159577
{
public static readonly BigInteger[] Value={ 3L,125970L,44618574L,1050274875L,835668708875L,BigInteger.Parse("87740042053973197350"),BigInteger.Parse("249875247243953981660010"),BigInteger.Parse("958593992854426686094086750"),BigInteger.Parse("28077829144670491508241956182896750") };
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
public class A159577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159577Inst Instance=new A159577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159578
{
public static readonly BigInteger[] Value={ 2L,30L,9699690L,304250263527210L,BigInteger.Parse("267064515689275851355624017992790"),BigInteger.Parse("5766152219975951659023630035336134306565384015606066319856068810"),BigInteger.Parse("962947420735983927056946215901134429196419130606213075415963491270"),BigInteger.Parse("29819592777931214269172453467810429868925511217482600306406141434158090"),BigInteger.Parse("1030893141925860008499560888835674370998623848299590975192766715520279329390") };
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
public class A159578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159578Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159578.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159578Inst Instance=new A159578Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159579
{
public static readonly long[] Value={ 10L,77L,125L,154L,222L,455L,575L,713L,1037L,1235L,1554L,2046L,2183L,2622L,3278L,3451L,3630L,3811L,4002L,5025L,6194L,6965L,7505L,8346L,8635L,9546L,10507L,17854L,18746L,19203L,22550L,25135L,28483L,32047L,33277L,37111L,48495L,52430L,56541L,62530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159579Inst : IEnumerable<long>
{
public static readonly long[] Value=A159579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159579.Bytes);
public long this[int i]=>Value[i];

public static A159579Inst Instance=new A159579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159580
{
public static readonly long[] Value={ 2L,2L,5L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159580Inst : IEnumerable<long>
{
public static readonly long[] Value=A159580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159580.Bytes);
public long this[int i]=>Value[i];

public static A159580Inst Instance=new A159580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159581
{
public static readonly long[] Value={ 125L,2046L,3278L,8346L,18746L,89798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159581Inst : IEnumerable<long>
{
public static readonly long[] Value=A159581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159581.Bytes);
public long this[int i]=>Value[i];

public static A159581Inst Instance=new A159581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159582
{
public static readonly long[] Value={ 1L,6L,7L,34L,41L,198L,239L,1154L,1393L,6726L,8119L,39202L,47321L,228486L,275807L,1331714L,1607521L,7761798L,9369319L,45239074L,54608393L,263672646L,318281039L,1536796802L,1855077841L,8957108166L,10812186007L,52205852194L,63018038201L,304278004998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159582Inst : IEnumerable<long>
{
public static readonly long[] Value=A159582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159582.Bytes);
public long this[int i]=>Value[i];

public static A159582Inst Instance=new A159582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159583
{
public static readonly BigInteger[] Value={ 1L,31L,2521L,97921L,4974481L,226965751L,10783342081L,504420084871L,23735900452321L,1114384154071681L,52364857850613001L,2459808940392975631L,BigInteger.Parse("115562692701892638721"),BigInteger.Parse("5428914300540041959471"),BigInteger.Parse("255044709450472227347881") };
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
public class A159583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159583Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159583.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159583Inst Instance=new A159583Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159584
{
public static readonly long[] Value={ 1L,0L,-3L,-2L,0L,6L,6L,0L,-3L,-12L,0L,6L,0L,0L,-6L,4L,0L,0L,6L,0L,0L,12L,0L,-12L,1L,0L,9L,-12L,0L,-12L,-30L,0L,12L,24L,0L,6L,0L,0L,24L,24L,0L,-12L,-18L,0L,0L,-24L,0L,-12L,-23L,0L,6L,0L,0L,-18L,48L,0L,-12L,36L,0L,12L,0L,0L,-18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159584Inst : IEnumerable<long>
{
public static readonly long[] Value=A159584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159584.Bytes);
public long this[int i]=>Value[i];

public static A159584Inst Instance=new A159584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159585
{
public static readonly long[] Value={ 2L,4L,10L,4L,46L,22L,16L,46L,66L,136L,166L,124L,636L,550L,1474L,3066L,1656L,1816L,3708L,9436L,1746L,3696L,11262L,40138L,25900L,20808L,60340L,58818L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159585Inst : IEnumerable<long>
{
public static readonly long[] Value=A159585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159585.Bytes);
public long this[int i]=>Value[i];

public static A159585Inst Instance=new A159585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159586
{
public static readonly long[] Value={ 4L,8L,12L,1L,20L,24L,28L,2L,16L,40L,44L,3L,52L,56L,60L,9L,68L,32L,76L,5L,84L,88L,92L,6L,36L,104L,48L,7L,116L,120L,124L,18L,132L,136L,140L,25L,148L,152L,156L,10L,164L,168L,172L,11L,80L,184L,188L,27L,64L,72L,204L,13L,212L,96L,220L,14L,228L,232L,236L,15L,244L,248L,112L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159586Inst : IEnumerable<long>
{
public static readonly long[] Value=A159586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159586.Bytes);
public long this[int i]=>Value[i];

public static A159586Inst Instance=new A159586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159587
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,35L,8L,7L,11L,21L,9L,55L,16L,15L,14L,13L,19L,65L,17L,33L,10L,39L,25L,77L,23L,45L,29L,51L,27L,1001L,32L,31L,20L,57L,6L,85L,41L,63L,22L,69L,37L,715L,47L,75L,26L,87L,43L,91L,53L,93L,28L,95L,49L,115L,12L,99L,34L,111L,61L,1309L,59L,117L,38L,67L,18L,455L,64L,123L,40L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159587Inst : IEnumerable<long>
{
public static readonly long[] Value=A159587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159587.Bytes);
public long this[int i]=>Value[i];

public static A159587Inst Instance=new A159587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159588
{
public static readonly long[] Value={ 1L,3L,2L,9L,7L,25L,5L,27L,4L,21L,13L,125L,11L,15L,14L,81L,19L,175L,17L,63L,10L,35L,29L,625L,6L,33L,8L,45L,23L,343L,37L,243L,26L,39L,22L,875L,31L,49L,34L,189L,43L,275L,41L,75L,28L,51L,53L,3125L,38L,99L,46L,105L,47L,1225L,57L,135L,55L,65L,61L,2401L,59L,69L,20L,729L,58L,245L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159588Inst : IEnumerable<long>
{
public static readonly long[] Value=A159588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159588.Bytes);
public long this[int i]=>Value[i];

public static A159588Inst Instance=new A159588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159589
{
public static readonly long[] Value={ 421L,449L,481L,2045L,2245L,2465L,11849L,13021L,14309L,69049L,75881L,83389L,402445L,442265L,486025L,2345621L,2577709L,2832761L,13671281L,15023989L,16510541L,79682065L,87566225L,96230485L,464421109L,510373361L,560872369L,2706844589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159589Inst : IEnumerable<long>
{
public static readonly long[] Value=A159589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159589.Bytes);
public long this[int i]=>Value[i];

public static A159589Inst Instance=new A159589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159590
{
public static readonly long[] Value={ 1L,0L,9L,8L,9L,4L,5L,2L,2L,6L,8L,8L,4L,6L,1L,6L,5L,9L,5L,6L,8L,8L,3L,0L,8L,8L,2L,3L,4L,4L,3L,8L,5L,5L,1L,0L,5L,4L,7L,2L,3L,6L,1L,1L,4L,9L,8L,0L,2L,4L,6L,8L,6L,9L,0L,8L,5L,8L,1L,3L,0L,0L,4L,9L,3L,0L,8L,9L,5L,7L,6L,2L,6L,6L,2L,3L,3L,0L,3L,3L,6L,5L,6L,2L,4L,7L,4L,7L,4L,9L,6L,7L,2L,5L,6L,7L,7L,6L,1L,0L,6L,5L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159590Inst : IEnumerable<long>
{
public static readonly long[] Value=A159590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159590.Bytes);
public long this[int i]=>Value[i];

public static A159590Inst Instance=new A159590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159591
{
public static readonly long[] Value={ 4L,8L,2L,6L,1L,3L,2L,8L,9L,3L,3L,4L,6L,7L,3L,4L,8L,7L,8L,0L,8L,3L,8L,8L,6L,3L,1L,5L,8L,5L,0L,4L,4L,3L,3L,0L,5L,4L,5L,4L,1L,6L,2L,0L,0L,3L,9L,3L,5L,2L,4L,6L,3L,4L,5L,7L,3L,9L,2L,2L,1L,8L,1L,2L,8L,9L,1L,7L,2L,6L,3L,7L,0L,5L,2L,5L,2L,0L,4L,7L,5L,3L,6L,6L,8L,8L,9L,1L,9L,4L,4L,1L,1L,9L,3L,9L,8L,2L,8L,6L,0L,1L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159591Inst : IEnumerable<long>
{
public static readonly long[] Value=A159591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159591.Bytes);
public long this[int i]=>Value[i];

public static A159591Inst Instance=new A159591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159592
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,177L,3491L,133261L,9917307L,1443008813L,411772442315L,231163433300285L,255964900099068155L,BigInteger.Parse("560177408302962464013"),BigInteger.Parse("2427068640913282843197355"),BigInteger.Parse("20848444510025384551575108829") };
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
public class A159592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159592Inst Instance=new A159592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159593
{
public static readonly BigInteger[] Value={ 1L,1L,4L,49L,1768L,187474L,58888462L,55210937881L,155033790773008L,1305338879106660550L,BigInteger.Parse("32966118096763299572020"),BigInteger.Parse("2497521410388697783376754490"),BigInteger.Parse("567627952695201383291867693446222") };
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
public class A159593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159593Inst Instance=new A159593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159594
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,125L,1301L,17070L,272976L,5218727L,118508219L,3224104875L,108226321884L,4740041705554L,291705715765328L,26728599026539162L,3688459631229579912L,BigInteger.Parse("751246585455211054713"),BigInteger.Parse("208348432365596381718906") };
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
public class A159594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159594Inst Instance=new A159594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159595
{
public static readonly BigInteger[] Value={ 1L,1L,4L,13L,56L,286L,2008L,19749L,280842L,5762129L,168873970L,7023348917L,412682000624L,34188301513404L,3992802803844526L,656649238572375132L,BigInteger.Parse("152278229304524217542"),BigInteger.Parse("49749953321847000835094") };
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
public class A159595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159595Inst Instance=new A159595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159596
{
public static readonly BigInteger[] Value={ 1L,1L,5L,22L,121L,863L,8476L,118131L,2361313L,67467236L,2731757961L,156417295405L,12605225573076L,1432381581679361L,229016092616239411L,BigInteger.Parse("51628631138952017332"),BigInteger.Parse("16402709158903948390585"),BigInteger.Parse("7351149638643155728435357") };
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
public class A159596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159596Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159596.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159596Inst Instance=new A159596Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159597
{
public static readonly BigInteger[] Value={ 1L,1L,7L,37L,245L,2094L,24661L,410376L,9809637L,334520167L,16192227784L,1107914634442L,106788033119369L,14525652771018918L,2780328926392863928L,BigInteger.Parse("751651711717655433750"),BigInteger.Parse("286240041470280077141769") };
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
public class A159597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159597Inst Instance=new A159597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159598
{
public static readonly BigInteger[] Value={ 1L,1L,9L,52L,389L,3741L,49908L,938799L,25477165L,984680146L,54180019253L,4211350678751L,462028240134476L,71561459522839253L,15611478225943599423UL,BigInteger.Parse("4816139618587302209166"),BigInteger.Parse("2092942812095475521879845") };
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
public class A159598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159598Inst Instance=new A159598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159599
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,304L,5685L,177486L,9305821L,807656872L,113141689065L,25091265489130L,8644033129800321L,4584172093683770820L,BigInteger.Parse("3704744323753306881229"),BigInteger.Parse("4538175408875808587259022"),BigInteger.Parse("8381136688938251234193247485") };
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
public class A159599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159599Inst Instance=new A159599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159600
{
public static readonly BigInteger[] Value={ 1L,-1L,3L,-27L,441L,-11529L,442827L,-23444883L,1636819569L,-145703137041L,16106380394643L,-2164638920874507L,347592265948756521L,BigInteger.Parse("-65724760945840254489"),BigInteger.Parse("14454276753061349098587") };
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
public class A159600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159600Inst Instance=new A159600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159601
{
public static readonly BigInteger[] Value={ 1L,-3L,27L,-441L,11529L,-442827L,23444883L,-1636819569L,145703137041L,-16106380394643L,2164638920874507L,-347592265948756521L,BigInteger.Parse("65724760945840254489"),BigInteger.Parse("-14454276753061349098587") };
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
public class A159601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159601Inst Instance=new A159601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159602
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,26L,152L,1202L,12840L,184060L,3552960L,92338448L,3237738008L,153574021372L,9872941474544L,862850471831896L,102720981260693424L,16701084112350547436UL,BigInteger.Parse("3715705202756433837504"),BigInteger.Parse("1133547354784950481434016") };
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
public class A159602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159602Inst Instance=new A159602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159603
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,16L,62L,312L,2001L,16796L,183416L,2634814L,49703026L,1240433524L,40975503423L,1803618092422L,105967390883387L,8362303039735026L,888404336012975536L,BigInteger.Parse("127771790716640691664"),BigInteger.Parse("24942884185805223709166") };
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
public class A159603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159603Inst Instance=new A159603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159604
{
public static readonly BigInteger[] Value={ 1L,1L,6L,43L,856L,10744L,608375L,14284223L,551011548L,19119025101L,874788949035L,37896009869060L,20683158266928833L,1799893777863733707L,BigInteger.Parse("93147805938921355288"),BigInteger.Parse("3757831283217050847983"),BigInteger.Parse("180287028377782585130749") };
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
public class A159604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159604Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159604.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159604Inst Instance=new A159604Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159605
{
public static readonly BigInteger[] Value={ 1L,3L,63L,3465L,363825L,62214075L,15740160975L,5524796502225L,2569030373534625L,1528573072253101875L,BigInteger.Parse("1132672646539548489375"),BigInteger.Parse("1022803399825212285905625"),BigInteger.Parse("1105650475211054481063980625"),BigInteger.Parse("1409704355894094463356575296875") };
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
public class A159605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159605Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159605.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159605Inst Instance=new A159605Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159606
{
public static readonly long[] Value={ 1L,1L,-3L,16L,-115L,996L,-9870L,108816L,-1312227L,17116900L,-239641798L,3580451040L,-56837970358L,955277226736L,-16948413979080L,316615678469856L,-6213840704926947L,127857371413743540L,-2753054722318717950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159606Inst : IEnumerable<long>
{
public static readonly long[] Value=A159606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159606.Bytes);
public long this[int i]=>Value[i];

public static A159606Inst Instance=new A159606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159607
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,123L,1221L,14724L,207908L,3355803L,60873595L,1225319163L,27097430328L,653052022740L,17036213760892L,478306368143880L,14381009543824236L,461038595072589531L,15699544671941958663UL,BigInteger.Parse("565927686301436324649") };
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
public class A159607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159607Inst Instance=new A159607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159608
{
public static readonly BigInteger[] Value={ 1L,1L,5L,46L,597L,9791L,191876L,4348394L,111561125L,3192096511L,100729014305L,3474750994936L,130094553648612L,5254546985647116L,227771218849108212L,10548385893161367506UL,BigInteger.Parse("519835256567911242341"),BigInteger.Parse("27164324421130818956039") };
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
public class A159608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159608Inst Instance=new A159608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159609
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,57L,304L,1778L,11329L,79293L,626614L,5911340L,72622218L,1271963335L,33126504453L,1266054182987L,69124699233986L,5301840148829273L,566953161970598904L,BigInteger.Parse("84240794164243627206"),BigInteger.Parse("17363983133374688843928") };
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
public class A159609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159609Inst Instance=new A159609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159610
{
public static readonly long[] Value={ 1L,3L,2L,11L,11L,9L,53L,53L,53L,44L,309L,309L,309L,309L,265L,2119L,2119L,2119L,2119L,2119L,1854L,16687L,16687L,16687L,16687L,16687L,14833L,148329L,148329L,148329L,148329L,148329L,148329L,148329L,133496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159610Inst : IEnumerable<long>
{
public static readonly long[] Value=A159610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159610.Bytes);
public long this[int i]=>Value[i];

public static A159610Inst Instance=new A159610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159611
{
public static readonly long[] Value={ 2L,3L,7L,55L,6543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159611Inst : IEnumerable<long>
{
public static readonly long[] Value=A159611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159611.Bytes);
public long this[int i]=>Value[i];

public static A159611Inst Instance=new A159611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159612
{
public static readonly long[] Value={ 1L,4L,8L,24L,56L,152L,376L,984L,2488L,6424L,16376L,42072L,107576L,275864L,706168L,1809624L,4634296L,11872792L,30409976L,77901144L,199541048L,511145624L,1309309816L,3353892312L,8591131576L,22006700824L,56371227128L,144398030424L,369882938936L,947475060632L,2427006816376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159612Inst : IEnumerable<long>
{
public static readonly long[] Value=A159612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159612.Bytes);
public long this[int i]=>Value[i];

public static A159612Inst Instance=new A159612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159613
{
public static readonly long[] Value={ 11L,101L,131L,151L,181L,191L,313L,10301L,10501L,10601L,11311L,11411L,16061L,30103L,30203L,30403L,30703L,30803L,31013L,35053L,38083L,70207L,70507L,70607L,73037L,74047L,90709L,91019L,94049L,1003001L,1008001L,1022201L,1028201L,1035301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159613Inst : IEnumerable<long>
{
public static readonly long[] Value=A159613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159613.Bytes);
public long this[int i]=>Value[i];

public static A159613Inst Instance=new A159613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159614
{
public static readonly long[] Value={ 13L,17L,31L,71L,107L,113L,311L,701L,709L,907L,1009L,1021L,1031L,1033L,1061L,1069L,1091L,1097L,1103L,1109L,1151L,1181L,1201L,1213L,1231L,1301L,1321L,1409L,1511L,1601L,1811L,1901L,3011L,3019L,3023L,3049L,3067L,3083L,3089L,3109L,3121L,3203L,3301L,3407L,3803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159614Inst : IEnumerable<long>
{
public static readonly long[] Value=A159614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159614.Bytes);
public long this[int i]=>Value[i];

public static A159614Inst Instance=new A159614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159615
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,10L,11L,13L,15L,17L,19L,20L,21L,22L,23L,25L,27L,29L,31L,33L,35L,37L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,97L,99L,101L,103L,105L,107L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159615Inst : IEnumerable<long>
{
public static readonly long[] Value=A159615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159615.Bytes);
public long this[int i]=>Value[i];

public static A159615Inst Instance=new A159615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159616
{
public static readonly long[] Value={ 1L,4L,22L,110L,562L,2854L,14514L,73782L,375106L,1906982L,9694866L,49287446L,250571106L,1273871494L,6476200114L,32924174710L,167382301826L,850950257638L,4326122494162L,21993454571478L,111811915784610L,568437508112710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159616Inst : IEnumerable<long>
{
public static readonly long[] Value=A159616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159616.Bytes);
public long this[int i]=>Value[i];

public static A159616Inst Instance=new A159616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159617
{
public static readonly long[] Value={ 1L,7L,64L,560L,4936L,43456L,382656L,3369408L,29668864L,261244928L,2300355072L,20255449088L,178356473856L,1570492542976L,13828748541952L,121767076888576L,1072202663100416L,9441127931576320L,83132508142305280L,732011467286249472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159617Inst : IEnumerable<long>
{
public static readonly long[] Value=A159617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159617.Bytes);
public long this[int i]=>Value[i];

public static A159617Inst Instance=new A159617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159618
{
public static readonly BigInteger[] Value={ 1L,4L,-706L,-8600L,1494796L,30815984L,-5272949624L,-154586641184L,26031140834960L,997017002818624L,-165162285134295584L,-7859111900887647616L,BigInteger.Parse("1280282420933024937664"),BigInteger.Parse("73212475193022678695680"),BigInteger.Parse("-11723880902105281350131584"),BigInteger.Parse("-786927222859494361656459776") };
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
public class A159618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159618Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159618.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159618Inst Instance=new A159618Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159619
{
public static readonly long[] Value={ 4L,7L,9L,11L,12L,15L,16L,19L,20L,23L,25L,27L,28L,31L,33L,35L,36L,39L,41L,43L,44L,47L,48L,51L,52L,55L,57L,59L,60L,63L,64L,67L,68L,71L,73L,75L,76L,79L,80L,83L,84L,87L,89L,91L,92L,95L,97L,99L,100L,103L,105L,107L,108L,111L,112L,115L,116L,119L,121L,123L,124L,127L,129L,131L,132L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159619Inst : IEnumerable<long>
{
public static readonly long[] Value=A159619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159619.Bytes);
public long this[int i]=>Value[i];

public static A159619Inst Instance=new A159619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159620
{
public static readonly BigInteger[] Value={ 1L,6L,-686L,-12780L,1409196L,45363816L,-4815014664L,-225406138896L,22982647278480L,1439841741934176L,-140702191563957984L,BigInteger.Parse("-11239870526148498624"),BigInteger.Parse("1050017582244063317184"),BigInteger.Parse("103682343732014971981440"),BigInteger.Parse("-9233370964550688463200384"),BigInteger.Parse("-1103421356230511467567597824") };
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
public class A159620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159620Inst Instance=new A159620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159621
{
public static readonly BigInteger[] Value={ 1L,8L,-658L,-16816L,1290700L,58890208L,-4188305336L,-288618823744L,18858744578192L,1817932282570880L,-108000664008524576L,BigInteger.Parse("-13989476392229950208"),BigInteger.Parse("745825462417862580928"),BigInteger.Parse("127171427161623189249536"),BigInteger.Parse("-5982946372961072670593920"),BigInteger.Parse("-1333312356733375778299061248") };
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
public class A159621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159621Inst Instance=new A159621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159622
{
public static readonly BigInteger[] Value={ 1L,10L,-622L,-20660L,1140652L,71072600L,-3407027720L,-341956780400L,13799550292880L,2113137866519200L,-68538099137942240L,BigInteger.Parse("-15942236387648046400"),BigInteger.Parse("384907219477056806080"),BigInteger.Parse("141972608257353242070400"),BigInteger.Parse("-2193013079438122761162880"),BigInteger.Parse("-1456989255059707798459232000") };
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
public class A159622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159622Inst Instance=new A159622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159623
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,12L,4L,1L,1L,5L,20L,20L,5L,1L,1L,6L,30L,120L,30L,6L,1L,1L,7L,42L,210L,210L,42L,7L,1L,1L,8L,56L,336L,1680L,336L,56L,8L,1L,1L,9L,72L,504L,3024L,3024L,504L,72L,9L,1L,1L,10L,90L,720L,5040L,30240L,5040L,720L,90L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159623Inst : IEnumerable<long>
{
public static readonly long[] Value=A159623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159623.Bytes);
public long this[int i]=>Value[i];

public static A159623Inst Instance=new A159623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159624
{
public static readonly long[] Value={ 3L,4L,5L,6L,6L,7L,9L,10L,10L,10L,10L,11L,13L,15L,17L,18L,18L,18L,18L,18L,18L,18L,18L,19L,21L,23L,25L,27L,29L,31L,33L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,35L,37L,39L,41L,43L,45L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159624Inst : IEnumerable<long>
{
public static readonly long[] Value=A159624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159624.Bytes);
public long this[int i]=>Value[i];

public static A159624Inst Instance=new A159624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159625
{
public static readonly long[] Value={ 1679L,1743L,4980L,4982L,5314L,5513L,5695L,6100L,6578L,7251L,7406L,7642L,8218L,8331L,9475L,9578L,9749L,10735L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159625Inst : IEnumerable<long>
{
public static readonly long[] Value=A159625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159625.Bytes);
public long this[int i]=>Value[i];

public static A159625Inst Instance=new A159625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159626
{
public static readonly long[] Value={ 545L,577L,613L,2657L,2885L,3133L,15397L,16733L,18185L,89725L,97513L,105977L,522953L,568345L,617677L,3047993L,3312557L,3600085L,17765005L,19306997L,20982833L,103542037L,112529425L,122296913L,603487217L,655869553L,712798645L,3517381265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159626Inst : IEnumerable<long>
{
public static readonly long[] Value=A159626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159626.Bytes);
public long this[int i]=>Value[i];

public static A159626Inst Instance=new A159626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159627
{
public static readonly long[] Value={ 1L,0L,8L,6L,7L,9L,9L,4L,1L,2L,6L,8L,7L,4L,9L,6L,0L,6L,8L,7L,3L,3L,5L,4L,8L,3L,8L,2L,3L,6L,2L,4L,4L,3L,2L,1L,4L,3L,3L,5L,1L,2L,7L,9L,7L,8L,7L,9L,1L,7L,0L,9L,2L,4L,5L,2L,1L,3L,1L,8L,3L,9L,0L,1L,3L,7L,2L,0L,7L,0L,8L,9L,1L,2L,7L,8L,5L,2L,9L,7L,0L,4L,1L,9L,5L,6L,9L,0L,0L,8L,0L,0L,1L,2L,3L,7L,4L,0L,2L,6L,8L,1L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159627Inst : IEnumerable<long>
{
public static readonly long[] Value=A159627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159627.Bytes);
public long this[int i]=>Value[i];

public static A159627Inst Instance=new A159627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159628
{
public static readonly long[] Value={ 4L,9L,3L,4L,6L,0L,7L,1L,1L,4L,7L,4L,8L,7L,6L,0L,8L,8L,0L,6L,4L,4L,3L,7L,9L,4L,3L,9L,7L,5L,3L,0L,9L,9L,7L,0L,8L,2L,9L,3L,7L,2L,4L,9L,0L,1L,9L,0L,4L,6L,2L,9L,2L,3L,7L,1L,0L,0L,6L,3L,9L,6L,1L,7L,6L,4L,6L,5L,7L,9L,5L,5L,0L,5L,3L,0L,6L,2L,0L,6L,4L,1L,5L,4L,6L,0L,2L,7L,3L,8L,9L,4L,5L,8L,8L,7L,2L,8L,5L,1L,5L,6L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159628Inst : IEnumerable<long>
{
public static readonly long[] Value=A159628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159628.Bytes);
public long this[int i]=>Value[i];

public static A159628Inst Instance=new A159628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159629
{
public static readonly long[] Value={ 4L,5L,6L,9L,10L,11L,15L,17L,25L,26L,27L,30L,32L,33L,39L,49L,50L,52L,54L,58L,59L,62L,63L,66L,81L,82L,83L,87L,89L,91L,92L,97L,99L,101L,102L,121L,122L,123L,124L,125L,128L,129L,131L,132L,136L,138L,143L,147L,169L,170L,171L,173L,178L,179L,183L,184L,186L,193L,195L,199L,200L,201L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159629Inst : IEnumerable<long>
{
public static readonly long[] Value=A159629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159629.Bytes);
public long this[int i]=>Value[i];

public static A159629Inst Instance=new A159629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159630
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,5L,4L,6L,6L,6L,5L,10L,5L,7L,10L,10L,6L,12L,7L,12L,12L,9L,8L,16L,12L,10L,15L,14L,9L,18L,10L,16L,16L,12L,16L,24L,11L,13L,18L,20L,12L,22L,13L,18L,24L,15L,14L,28L,20L,24L,22L,20L,15L,27L,22L,24L,24L,18L,17L,36L,17L,19L,32L,28L,24L,30L,19L,24L,28L,30L,20L,40L,20L,22L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159630Inst : IEnumerable<long>
{
public static readonly long[] Value=A159630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159630.Bytes);
public long this[int i]=>Value[i];

public static A159630Inst Instance=new A159630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159631
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,3L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,3L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,1L,2L,4L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,2L,2L,1L,1L,1L,3L,3L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,2L,2L,4L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159631Inst : IEnumerable<long>
{
public static readonly long[] Value=A159631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159631.Bytes);
public long this[int i]=>Value[i];

public static A159631Inst Instance=new A159631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159632
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,2L,0L,2L,2L,3L,1L,3L,2L,4L,2L,5L,4L,5L,2L,2L,5L,5L,4L,6L,7L,7L,3L,9L,7L,9L,4L,8L,8L,11L,6L,9L,11L,10L,8L,10L,10L,11L,7L,6L,8L,15L,10L,12L,11L,15L,10L,17L,13L,14L,14L,14L,14L,18L,8L,17L,19L,16L,14L,21L,19L,17L,12L,17L,17L,20L,16L,21L,23L,19L,15L,15L,19L,20L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159632Inst : IEnumerable<long>
{
public static readonly long[] Value=A159632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159632.Bytes);
public long this[int i]=>Value[i];

public static A159632Inst Instance=new A159632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159633
{
public static readonly long[] Value={ 2L,3L,4L,6L,4L,6L,4L,8L,8L,6L,4L,12L,4L,6L,8L,12L,4L,12L,4L,12L,8L,6L,4L,16L,12L,6L,12L,12L,4L,12L,4L,16L,8L,6L,8L,24L,4L,6L,8L,16L,4L,12L,4L,12L,16L,6L,4L,24L,16L,18L,8L,12L,4L,18L,8L,16L,8L,6L,4L,24L,4L,6L,16L,24L,8L,12L,4L,12L,8L,12L,4L,32L,4L,6L,24L,12L,8L,12L,4L,24L,24L,6L,4L,24L,8L,6L,8L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159633Inst : IEnumerable<long>
{
public static readonly long[] Value=A159633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159633.Bytes);
public long this[int i]=>Value[i];

public static A159633Inst Instance=new A159633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159634
{
public static readonly long[] Value={ 1L,2L,4L,4L,6L,8L,8L,8L,12L,12L,12L,16L,14L,16L,24L,16L,18L,24L,20L,24L,32L,24L,24L,32L,30L,28L,36L,32L,30L,48L,32L,32L,48L,36L,48L,48L,38L,40L,56L,48L,42L,64L,44L,48L,72L,48L,48L,64L,56L,60L,72L,56L,54L,72L,72L,64L,80L,60L,60L,96L,62L,64L,96L,64L,84L,96L,68L,72L,96L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159634Inst : IEnumerable<long>
{
public static readonly long[] Value=A159634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159634.Bytes);
public long this[int i]=>Value[i];

public static A159634Inst Instance=new A159634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159635
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,9L,8L,10L,14L,12L,11L,18L,13L,15L,22L,18L,16L,24L,17L,24L,28L,21L,20L,32L,30L,24L,33L,30L,25L,42L,26L,32L,40L,30L,40L,48L,31L,33L,46L,44L,34L,54L,35L,42L,64L,39L,38L,60L,52L,54L,58L,48L,43L,63L,58L,56L,64L,48L,47L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159635Inst : IEnumerable<long>
{
public static readonly long[] Value=A159635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159635.Bytes);
public long this[int i]=>Value[i];

public static A159635Inst Instance=new A159635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159636
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,3L,4L,2L,6L,6L,7L,6L,9L,9L,14L,6L,12L,12L,13L,12L,20L,15L,16L,16L,18L,18L,21L,18L,21L,30L,22L,16L,32L,24L,32L,24L,27L,27L,38L,28L,30L,42L,31L,30L,48L,33L,34L,36L,36L,36L,50L,36L,39L,45L,50L,40L,56L,42L,43L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159636Inst : IEnumerable<long>
{
public static readonly long[] Value=A159636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159636.Bytes);
public long this[int i]=>Value[i];

public static A159636Inst Instance=new A159636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159637
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159637Inst : IEnumerable<long>
{
public static readonly long[] Value=A159637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159637.Bytes);
public long this[int i]=>Value[i];

public static A159637Inst Instance=new A159637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159638
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159638Inst : IEnumerable<long>
{
public static readonly long[] Value=A159638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159638.Bytes);
public long this[int i]=>Value[i];

public static A159638Inst Instance=new A159638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159639
{
public static readonly long[] Value={ 154L,2183L,4002L,8635L,19203L,93017L,96298L,122414L,166762L,182090L,201354L,241237L,337645L,346495L,406813L,456729L,574678L,668811L,781635L,799006L,929442L,952150L,1014194L,1379625L,1455259L,1513549L,1558110L,1573089L,1938354L,2028842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159639Inst : IEnumerable<long>
{
public static readonly long[] Value=A159639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159639.Bytes);
public long this[int i]=>Value[i];

public static A159639Inst Instance=new A159639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159640
{
public static readonly BigInteger[] Value={ 1L,1L,3L,18L,234L,7020L,498420L,84731400L,34655142600L,34169970603600L,81290360065964400L,BigInteger.Parse("466769247498767584800"),BigInteger.Parse("6469888539580417492912800"),BigInteger.Parse("216495410311439930147848113600"),BigInteger.Parse("17489148731189051877133614160948800"),BigInteger.Parse("3410838720448876031389860235353200668800") };
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
public class A159640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159640Inst Instance=new A159640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159641
{
public static readonly long[] Value={ 613L,647L,685L,2993L,3235L,3497L,17345L,18763L,20297L,101077L,109343L,118285L,589117L,637295L,689413L,3433625L,3714427L,4018193L,20012633L,21649267L,23419745L,116642173L,126181175L,136500277L,679840405L,735437783L,795581917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159641Inst : IEnumerable<long>
{
public static readonly long[] Value=A159641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159641.Bytes);
public long this[int i]=>Value[i];

public static A159641Inst Instance=new A159641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159642
{
public static readonly long[] Value={ 1L,0L,8L,1L,7L,8L,0L,0L,4L,3L,6L,5L,5L,9L,9L,9L,1L,0L,6L,2L,7L,0L,2L,6L,3L,9L,7L,8L,4L,7L,2L,2L,5L,5L,2L,2L,5L,3L,9L,1L,8L,2L,1L,0L,0L,0L,7L,9L,3L,7L,7L,1L,4L,5L,3L,8L,3L,9L,8L,1L,5L,2L,5L,5L,9L,0L,0L,5L,6L,6L,2L,5L,8L,4L,6L,1L,5L,7L,0L,0L,9L,7L,9L,8L,8L,5L,8L,4L,1L,5L,9L,5L,6L,0L,7L,3L,4L,3L,0L,6L,9L,8L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159642Inst : IEnumerable<long>
{
public static readonly long[] Value=A159642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159642.Bytes);
public long this[int i]=>Value[i];

public static A159642Inst Instance=new A159642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159643
{
public static readonly long[] Value={ 4L,9L,8L,0L,5L,0L,5L,6L,8L,0L,5L,9L,8L,9L,6L,5L,1L,0L,5L,1L,7L,5L,5L,0L,3L,1L,7L,0L,9L,3L,8L,4L,8L,6L,3L,6L,8L,3L,6L,8L,4L,3L,6L,9L,5L,1L,8L,7L,0L,1L,3L,1L,3L,6L,5L,6L,9L,2L,8L,7L,7L,1L,2L,4L,0L,3L,2L,4L,9L,8L,4L,3L,3L,4L,5L,2L,3L,4L,2L,0L,2L,6L,8L,0L,0L,2L,8L,8L,1L,9L,8L,6L,7L,3L,3L,2L,5L,9L,5L,2L,9L,4L,3L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159643Inst : IEnumerable<long>
{
public static readonly long[] Value=A159643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159643.Bytes);
public long this[int i]=>Value[i];

public static A159643Inst Instance=new A159643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159644
{
public static readonly BigInteger[] Value={ 1L,12L,-578L,-24264L,960780L,81603792L,-2489170296L,-383377670496L,7979734630032L,2310146240345280L,-24130560741804576L,BigInteger.Parse("-16968822584194576512"),BigInteger.Parse("-11980957598922975552"),BigInteger.Parse("146874107378274735193344"),BigInteger.Parse("1874942556562787870851200"),BigInteger.Parse("-1462104166700847568884106752") };
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
public class A159644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159644Inst Instance=new A159644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159645
{
public static readonly BigInteger[] Value={ 1L,14L,-526L,-27580L,753196L,90195784L,-1456296584L,-411116288464L,1604494897040L,2397070610726624L,23132980709206816L,BigInteger.Parse("-16982988079517329856"),BigInteger.Parse("-421483965905763150656"),BigInteger.Parse("141239833198257461763200"),BigInteger.Parse("5933406168767097396742016"),BigInteger.Parse("-1344584547605247059948037376") };
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
public class A159645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159645Inst Instance=new A159645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159646
{
public static readonly BigInteger[] Value={ 1L,16L,-466L,-30560L,520396L,96583616L,-333291704L,-423732891776L,-5095269996400L,2365956862955776L,70964374243899616L,BigInteger.Parse("-15946778562638308864"),BigInteger.Parse("-818747517247263692096"),BigInteger.Parse("125062929190742088924160"),BigInteger.Parse("9685771063934690436799616"),BigInteger.Parse("-1109163751237065987856615424") };
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
public class A159646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159646Inst Instance=new A159646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159647
{
public static readonly BigInteger[] Value={ 1L,18L,-398L,-33156L,265260L,100529208L,851937144L,-420157660464L,-11868528214128L,2213197138985760L,116959244837147424L,BigInteger.Parse("-13874016936408533568"),BigInteger.Parse("-1178622627351978445632"),BigInteger.Parse("98989275444707922811776"),BigInteger.Parse("12844358938330412301313920"),BigInteger.Parse("-769385135305160262357781248") };
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
public class A159647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159647Inst Instance=new A159647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159648
{
public static readonly BigInteger[] Value={ 1L,20L,-322L,-35320L,-8948L,101825200L,2068806280L,-399730640800L,-18450359755120L,1939836986158400L,158687177411937760L,BigInteger.Parse("-10831879491824892800"),BigInteger.Parse("-1476931152842107545920"),BigInteger.Parse("64308780860328720300800"),BigInteger.Parse("15148651417782595832021120"),BigInteger.Parse("-347060128580550788160064000") };
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
public class A159648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159648Inst Instance=new A159648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159649
{
public static readonly BigInteger[] Value={ 1L,22L,-238L,-37004L,-298580L,100298792L,3284447224L,-362236528016L,-24568799886448L,1551764588318560L,193786882605147424L,-6940428910346759872L,BigInteger.Parse("-1691744857677709558592"),BigInteger.Parse("22913489210334717241984"),BigInteger.Parse("16382813996790345696268160"),BigInteger.Parse("128812358991324283435925248") };
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
public class A159649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159649Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159649.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159649Inst Instance=new A159649Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159650
{
public static readonly BigInteger[] Value={ 1L,24L,-146L,-38160L,-599604L,95815584L,4464144456L,-307933642944L,-29952193511280L,1059772077373824L,220063883293269216L,-2370021199600548096L,BigInteger.Parse("-1804627869905557267776"),BigInteger.Parse("-22777205204394225722880"),BigInteger.Parse("16391584262028099097996416"),BigInteger.Parse("623630012494691211958785024") };
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
public class A159650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159650Inst Instance=new A159650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159651
{
public static readonly BigInteger[] Value={ 1L,26L,-46L,-38740L,-907604L,88283416L,5571819256L,-237576457456L,-34336962413680L,479480595510176L,235588077247357216L,2663440108847816896L,BigInteger.Parse("-1801791066668467770176"),BigInteger.Parse("-69922612836437647611520"),BigInteger.Parse("15093623018002859652972416"),BigInteger.Parse("1099211969018786093034526976") };
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
public class A159651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159651Inst Instance=new A159651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159652
{
public static readonly BigInteger[] Value={ 1L,28L,62L,-38696L,-1217780L,77656208L,6570559624L,-152431023584L,-37475677000048L,-168877363780160L,238788382960467424L,7905369289385843072L,BigInteger.Parse("-1675106997369228675392"),BigInteger.Parse("-115395115449577347286784"),BigInteger.Parse("12491491044719414623199360"),BigInteger.Parse("1516175576216471435824394752") };
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
public class A159652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159652Inst Instance=new A159652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159653
{
public static readonly BigInteger[] Value={ 1L,30L,178L,-37980L,-1524948L,63937800L,7423196280L,-54282661200L,-39145313835120L,-860822763962400L,228541566381737760L,13071387347260660800UL,BigInteger.Parse("-1422935499785941465920"),BigInteger.Parse("-155938564970244609148800"),BigInteger.Parse("8677515651883508324661120"),BigInteger.Parse("1836552484275737759015904000") };
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
public class A159653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159653Inst Instance=new A159653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159654
{
public static readonly BigInteger[] Value={ 1L,32L,302L,-36544L,-1823540L,47185792L,8092924744L,54564740864L,-39155569948528L,-1568144181583360L,204252279714867424L,17858073941907616768UL,BigInteger.Parse("-1050713239354433344832"),BigInteger.Parse("-188345176292029458712576"),BigInteger.Parse("3834948823235768695790720"),BigInteger.Parse("2026511404303378366932021248") };
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
public class A159654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159654Inst Instance=new A159654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159655
{
public static readonly BigInteger[] Value={ 1L,34L,434L,-34340L,-2107604L,27515384L,8543973496L,171298455376L,-37357094566000L,-2259561093495776L,165921323311011616L,BigInteger.Parse("21955356087613897664"),BigInteger.Parse("-571265042757181733696"),BigInteger.Parse("-209644216596830988306560"),BigInteger.Parse("-1766009672973345849952384"),BigInteger.Parse("2059039412479673870904327424") };
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
public class A159655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159655Inst Instance=new A159655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159656
{
public static readonly BigInteger[] Value={ 1L,36L,574L,-31320L,-2370804L,5103216L,8742318216L,292616324064L,-33649488597360L,-2901533477298624L,114199171722894816L,BigInteger.Parse("25060241888120278656"),-4801113850900597056L,BigInteger.Parse("-217294775817306515769600"),BigInteger.Parse("-7777548674818481563737984"),BigInteger.Parse("1916423841667868925104549376") };
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
public class A159656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159656Inst Instance=new A159656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159657
{
public static readonly BigInteger[] Value={ 1L,1L,-199L,-599L,118801L,598001L,-118202999L,-835804199L,164648394401L,1501935112801L,-294865174808999L,-3298735400410999L,645404649179386801L,8562369610165784401L,BigInteger.Parse("-1669489718256239898199"),BigInteger.Parse("-25644124626720436220999"),BigInteger.Parse("4982825030141999258376001") };
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
public class A159657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159657Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159657.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159657Inst Instance=new A159657Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159658
{
public static readonly BigInteger[] Value={ 1L,3L,-191L,-1773L,109281L,1746243L,-104042271L,-2407618413L,138436324161L,4267498433283L,-236382888189951L,-9244145531135853L,492309917424484641L,BigInteger.Parse("23662879026999501123"),BigInteger.Parse("-1209017148222661563231"),BigInteger.Parse("-69883112720266587834093"),BigInteger.Parse("3417402106507184926190721") };
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
public class A159658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159658Inst Instance=new A159658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159659
{
public static readonly BigInteger[] Value={ 1L,7L,-151L,-3857L,63601L,3530807L,-38885351L,-4509165857L,22875330401L,7374792684007L,10447954066249L,-14676449689550257L,-125720646772599599L,BigInteger.Parse("34343434727512419607"),BigInteger.Parse("567277724701345894649"),BigInteger.Parse("-92190673164125353637057"),BigInteger.Parse("-2347167886252915159406399") };
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
public class A159659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159659Inst Instance=new A159659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159660
{
public static readonly BigInteger[] Value={ 1L,9L,-119L,-4671L,29361L,4001049L,6648441L,-4741422831L,-51980622879L,7118450923689L,157631179495401L,-12818221231919391L,-462152585977156719L,BigInteger.Parse("26604357682812127929"),BigInteger.Parse("1441035942685916620761"),BigInteger.Parse("-61522878027700708614351"),BigInteger.Parse("-4876813730307056239812159") };
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
public class A159660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159660Inst Instance=new A159660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159661
{
public static readonly BigInteger[] Value={ 1L,25L,599L,14351L,343825L,8237449L,197354951L,4728281375L,113281398049L,2714025271801L,65023325125175L,1557845777732399L,37323275340452401L,894200762393125225L,BigInteger.Parse("21423495022094552999"),BigInteger.Parse("513269679767876146751"),BigInteger.Parse("12297048819406932969025"),BigInteger.Parse("294615901985998515109849") };
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
public class A159661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159661Inst Instance=new A159661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159662
{
public static readonly long[] Value={ 1L,1L,3L,13L,77L,572L,5114L,53406L,637818L,8572434L,128041458L,2103949314L,37716766350L,732505270152L,15320768312784L,343335554738328L,8207083694470392L,208444177385240472L,5605513502234263272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A159662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159662Inst : IEnumerable<long>
{
public static readonly long[] Value=A159662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159662.Bytes);
public long this[int i]=>Value[i];

public static A159662Inst Instance=new A159662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A159663
{
public static readonly BigInteger[] Value={ 1L,11L,-79L,-5269L,-10559L,4099051L,55648561L,-4306727029L,-125281982719L,5512661436491L,286146844695601L,-7877707581330389L,-716177841724956479L,11028541936218412331UL,BigInteger.Parse("1983376349783289381041"),BigInteger.Parse("-9062777573795371335349"),BigInteger.Parse("-6049819602661617227811839") };
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
public class A159663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A159663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A159663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A159663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A159663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A159663Inst Instance=new A159663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}