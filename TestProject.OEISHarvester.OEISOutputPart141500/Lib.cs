using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A170805
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,12L,20L,29L,45L,72L,104L,168L,249L,377L,620L,876L,1388L,2117L,3141L,5189L,7376L,11472L,18033L,26225L,42609L,62292L,95060L,154109L,219645L,350717L,527864L,790008L,1314296L,1845737L,2894313L,4488636L,6585788L,10780092L,15563061L,23951669L,38300576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170805Inst : IEnumerable<long>
{
public static readonly long[] Value=A170805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170805.Bytes);
public long this[int i]=>Value[i];

public static A170805Inst Instance=new A170805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170806
{
public static readonly long[] Value={ 12L,20L,21L,22L,102L,201L,202L,212L,1002L,1012L,1021L,1022L,1102L,1201L,1202L,2001L,2002L,2011L,2012L,2021L,2022L,2101L,2102L,2112L,2122L,2201L,2202L,2212L,10002L,10012L,10021L,10022L,10112L,10121L,10122L,10211L,10212L,10221L,10222L,11002L,11102L,11201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170806Inst : IEnumerable<long>
{
public static readonly long[] Value=A170806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170806.Bytes);
public long this[int i]=>Value[i];

public static A170806Inst Instance=new A170806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170807
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170807Inst : IEnumerable<long>
{
public static readonly long[] Value=A170807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170807.Bytes);
public long this[int i]=>Value[i];

public static A170807Inst Instance=new A170807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170808
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,116L,252L,768L,2704L,12756L,63168L,338308L,1956876L,11971780L,77909884L,535178056L,3906154920L,30146769464L,244980749052L,2094507398508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170808Inst : IEnumerable<long>
{
public static readonly long[] Value=A170808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170808.Bytes);
public long this[int i]=>Value[i];

public static A170808Inst Instance=new A170808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170809
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,116L,200L,444L,864L,3368L,10936L,38320L,139848L,534828L,2230464L,9802612L,46188544L,231210272L,1213437504L,6717614708L,39002297800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170809Inst : IEnumerable<long>
{
public static readonly long[] Value=A170809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170809.Bytes);
public long this[int i]=>Value[i];

public static A170809Inst Instance=new A170809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170810
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,116L,200L,444L,760L,2160L,4872L,11932L,29252L,71708L,191356L,536908L,1607592L,5184252L,17331516L,61597568L,228854684L,891958912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170810Inst : IEnumerable<long>
{
public static readonly long[] Value=A170810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170810.Bytes);
public long this[int i]=>Value[i];

public static A170810Inst Instance=new A170810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170811
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,116L,200L,444L,760L,2160L,4368L,7852L,14040L,24284L,42312L,79340L,152764L,320920L,688780L,1577244L,3763512L,9412948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170811Inst : IEnumerable<long>
{
public static readonly long[] Value=A170811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170811.Bytes);
public long this[int i]=>Value[i];

public static A170811Inst Instance=new A170811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170812
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,116L,200L,444L,760L,2160L,4368L,7852L,12828L,17252L,21136L,28716L,37276L,53624L,76740L,114856L,180232L,290280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170812Inst : IEnumerable<long>
{
public static readonly long[] Value=A170812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170812.Bytes);
public long this[int i]=>Value[i];

public static A170812Inst Instance=new A170812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170813
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,116L,200L,444L,760L,2160L,4368L,7852L,12828L,17252L,19612L,21104L,19760L,20392L,20128L,20636L,22408L,23988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170813Inst : IEnumerable<long>
{
public static readonly long[] Value=A170813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170813.Bytes);
public long this[int i]=>Value[i];

public static A170813Inst Instance=new A170813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170814
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,116L,200L,444L,760L,2160L,4368L,7852L,12828L,17252L,19612L,21104L,18276L,15096L,11052L,8484L,6400L,5360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170814Inst : IEnumerable<long>
{
public static readonly long[] Value=A170814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170814.Bytes);
public long this[int i]=>Value[i];

public static A170814Inst Instance=new A170814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170815
{
public static readonly long[] Value={ 1L,2L,4L,12L,40L,116L,200L,444L,760L,2160L,4368L,7852L,12828L,17252L,19612L,21104L,18276L,15096L,10240L,6464L,3776L,2536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170815Inst : IEnumerable<long>
{
public static readonly long[] Value=A170815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170815.Bytes);
public long this[int i]=>Value[i];

public static A170815Inst Instance=new A170815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170816
{
public static readonly long[] Value={ 1L,4L,3L,5L,5L,8L,9L,11L,15L,16L,21L,23L,23L,26L,31L,35L,36L,41L,44L,45L,49L,51L,56L,63L,66L,67L,69L,70L,73L,85L,87L,92L,93L,101L,102L,107L,112L,115L,119L,124L,125L,134L,135L,137L,137L,148L,159L,162L,163L,165L,170L,171L,179L,183L,188L,193L,194L,199L,201L,202L,211L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170816Inst : IEnumerable<long>
{
public static readonly long[] Value=A170816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170816.Bytes);
public long this[int i]=>Value[i];

public static A170816Inst Instance=new A170816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170817
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,1L,1L,5L,1L,1L,13L,1L,5L,1L,17L,1L,1L,5L,1L,1L,1L,1L,5L,13L,1L,1L,29L,5L,1L,1L,1L,17L,5L,1L,37L,1L,13L,5L,41L,1L,1L,1L,5L,1L,1L,1L,1L,5L,17L,13L,53L,1L,5L,1L,1L,29L,1L,5L,61L,1L,1L,1L,65L,1L,1L,17L,1L,5L,1L,1L,73L,37L,5L,1L,1L,13L,1L,5L,1L,41L,1L,1L,85L,1L,29L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170817Inst : IEnumerable<long>
{
public static readonly long[] Value=A170817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170817.Bytes);
public long this[int i]=>Value[i];

public static A170817Inst Instance=new A170817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170818
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,1L,1L,5L,1L,1L,13L,1L,5L,1L,17L,1L,1L,5L,1L,1L,1L,1L,25L,13L,1L,1L,29L,5L,1L,1L,1L,17L,5L,1L,37L,1L,13L,5L,41L,1L,1L,1L,5L,1L,1L,1L,1L,25L,17L,13L,53L,1L,5L,1L,1L,29L,1L,5L,61L,1L,1L,1L,65L,1L,1L,17L,1L,5L,1L,1L,73L,37L,25L,1L,1L,13L,1L,5L,1L,41L,1L,1L,85L,1L,29L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170818Inst : IEnumerable<long>
{
public static readonly long[] Value=A170818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170818.Bytes);
public long this[int i]=>Value[i];

public static A170818Inst Instance=new A170818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170819
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,7L,1L,3L,1L,11L,3L,1L,7L,3L,1L,1L,3L,19L,1L,21L,11L,23L,3L,1L,1L,3L,7L,1L,3L,31L,1L,33L,1L,7L,3L,1L,19L,3L,1L,1L,21L,43L,11L,3L,23L,47L,3L,7L,1L,3L,1L,1L,3L,11L,7L,57L,1L,59L,3L,1L,31L,21L,1L,1L,33L,67L,1L,69L,7L,71L,3L,1L,1L,3L,19L,77L,3L,79L,1L,3L,1L,83L,21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170819Inst : IEnumerable<long>
{
public static readonly long[] Value=A170819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170819.Bytes);
public long this[int i]=>Value[i];

public static A170819Inst Instance=new A170819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170820
{
public static readonly long[] Value={ 2L,1L,1L,3L,1L,6L,2L,4L,1L,1L,1L,2L,2L,4L,1L,5L,2L,10L,2L,3L,1L,1L,12L,4L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,5L,2L,2L,4L,3L,42L,1L,1L,1L,1L,2L,8L,1L,1L,2L,4L,1L,1L,7L,2L,4L,6L,2L,2L,4L,30L,2L,1L,1L,1L,2L,1L,3L,2L,2L,2L,1L,25L,4L,11L,1L,10L,2L,3L,1L,1L,8L,10L,33L,1L,2L,3L,1L,6L,2L,4L,1L,2L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170820Inst : IEnumerable<long>
{
public static readonly long[] Value=A170820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170820.Bytes);
public long this[int i]=>Value[i];

public static A170820Inst Instance=new A170820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170821
{
public static readonly long[] Value={ 0L,2L,6L,9L,4L,5L,15L,18L,8L,24L,10L,11L,33L,36L,14L,45L,16L,51L,54L,19L,60L,63L,23L,25L,26L,78L,81L,28L,29L,96L,99L,35L,105L,38L,114L,40L,123L,126L,44L,135L,46L,144L,49L,50L,150L,159L,168L,171L,58L,59L,180L,61L,189L,65L,198L,68L,204L,70L,71L,213L,74L,231L,234L,79L,80L,249L,85L,261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170821Inst : IEnumerable<long>
{
public static readonly long[] Value=A170821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170821.Bytes);
public long this[int i]=>Value[i];

public static A170821Inst Instance=new A170821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170822
{
public static readonly long[] Value={ 1L,3L,2L,2L,1L,1L,2L,1L,1L,12L,1L,1L,2L,1L,2L,4L,1L,14L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,1L,10L,1L,3L,1L,1L,4L,9L,2L,1L,2L,18L,2L,16L,1L,1L,1L,1L,2L,2L,1L,2L,6L,2L,1L,2L,1L,1L,2L,1L,1L,1L,3L,10L,12L,1L,1L,42L,2L,12L,1L,2L,1L,4L,27L,2L,1L,4L,1L,6L,2L,6L,10L,4L,3L,2L,1L,2L,1L,1L,2L,2L,1L,2L,3L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170822Inst : IEnumerable<long>
{
public static readonly long[] Value=A170822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170822.Bytes);
public long this[int i]=>Value[i];

public static A170822Inst Instance=new A170822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170823
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,2L,3L,1L,3L,2L,3L,1L,2L,1L,3L,2L,3L,1L,3L,2L,1L,2L,3L,2L,1L,2L,3L,1L,3L,2L,3L,1L,2L,1L,3L,1L,2L,3L,2L,1L,3L,1L,2L,1L,3L,2L,3L,1L,3L,2L,3L,1L,2L,1L,3L,1L,2L,3L,2L,1L,2L,3L,1L,3L,2L,1L,2L,3L,2L,1L,3L,1L,2L,1L,3L,2L,3L,1L,3L,2L,3L,1L,2L,1L,3L,1L,2L,3L,2L,1L,3L,1L,2L,1L,3L,2L,3L,1L,3L,2L,1L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170823Inst : IEnumerable<long>
{
public static readonly long[] Value=A170823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170823.Bytes);
public long this[int i]=>Value[i];

public static A170823Inst Instance=new A170823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170824
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,13L,7L,1L,1L,1L,1L,19L,1L,7L,1L,1L,1L,1L,13L,1L,7L,1L,1L,31L,1L,1L,1L,7L,1L,37L,19L,13L,1L,1L,7L,43L,1L,1L,1L,1L,1L,7L,1L,1L,13L,1L,1L,1L,7L,19L,1L,1L,1L,61L,31L,7L,1L,13L,1L,67L,1L,1L,7L,1L,1L,73L,37L,1L,19L,7L,13L,79L,1L,1L,1L,1L,7L,1L,43L,1L,1L,1L,1L,91L,1L,31L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170824Inst : IEnumerable<long>
{
public static readonly long[] Value=A170824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170824.Bytes);
public long this[int i]=>Value[i];

public static A170824Inst Instance=new A170824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170825
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,1L,1L,5L,11L,1L,1L,1L,5L,1L,17L,1L,1L,5L,1L,11L,23L,1L,5L,1L,1L,1L,29L,5L,1L,1L,11L,17L,5L,1L,1L,1L,1L,5L,41L,1L,1L,11L,5L,23L,47L,1L,1L,5L,17L,1L,53L,1L,55L,1L,1L,29L,59L,5L,1L,1L,1L,1L,5L,11L,1L,17L,23L,5L,71L,1L,1L,1L,5L,1L,11L,1L,1L,5L,1L,41L,83L,1L,85L,1L,29L,11L,89L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170825Inst : IEnumerable<long>
{
public static readonly long[] Value=A170825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170825.Bytes);
public long this[int i]=>Value[i];

public static A170825Inst Instance=new A170825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170826
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,36L,7L,64L,81L,100L,11L,144L,13L,196L,225L,256L,17L,324L,19L,400L,441L,484L,23L,576L,625L,676L,729L,784L,29L,900L,31L,1024L,1089L,1156L,1225L,1296L,37L,1444L,1521L,1600L,41L,1764L,43L,1936L,2025L,2116L,47L,2304L,2401L,2500L,2601L,2704L,53L,2916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170826Inst : IEnumerable<long>
{
public static readonly long[] Value=A170826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170826.Bytes);
public long this[int i]=>Value[i];

public static A170826Inst Instance=new A170826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170827
{
public static readonly long[] Value={ 0L,5L,7L,15L,13L,29L,25L,37L,38L,43L,42L,67L,60L,67L,60L,85L,73L,77L,71L,79L,95L,107L,106L,100L,95L,120L,95L,137L,143L,146L,138L,140L,147L,166L,172L,163L,172L,177L,180L,193L,158L,174L,171L,184L,177L,188L,188L,223L,212L,241L,213L,198L,243L,229L,236L,245L,278L,281L,305L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170827Inst : IEnumerable<long>
{
public static readonly long[] Value=A170827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170827.Bytes);
public long this[int i]=>Value[i];

public static A170827Inst Instance=new A170827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170828
{
public static readonly long[] Value={ 0L,5L,12L,27L,40L,69L,94L,131L,169L,212L,254L,321L,381L,448L,508L,593L,666L,743L,814L,893L,988L,1095L,1201L,1301L,1396L,1516L,1611L,1748L,1891L,2037L,2175L,2315L,2462L,2628L,2800L,2963L,3135L,3312L,3492L,3685L,3843L,4017L,4188L,4372L,4549L,4737L,4925L,5148L,5360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170828Inst : IEnumerable<long>
{
public static readonly long[] Value=A170828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170828.Bytes);
public long this[int i]=>Value[i];

public static A170828Inst Instance=new A170828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170829
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,6L,12L,3L,10L,2L,4L,14L,28L,100L,360L,45L,90L,330L,23100L,2310L,8580L,780L,1560L,5850L,468L,1764L,6664L,476L,52360L,198968L,397936L,24871L,94962L,363090L,20748L,79534L,159068L,8372L,32200L,123970L,247940L,956340L,1912680L,7389900L,28574280L,1242360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170829Inst : IEnumerable<long>
{
public static readonly long[] Value=A170829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170829.Bytes);
public long this[int i]=>Value[i];

public static A170829Inst Instance=new A170829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170830
{
public static readonly long[] Value={ 360L,363L,364L,729L,730L,732L,738L,756L,757L,810L,819L,820L,949L,972L,984L,1036L,1053L,1080L,1089L,1092L,1093L,2187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170830Inst : IEnumerable<long>
{
public static readonly long[] Value=A170830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170830.Bytes);
public long this[int i]=>Value[i];

public static A170830Inst Instance=new A170830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170831
{
public static readonly long[] Value={ 2L,2L,4L,4L,10L,8L,20L,20L,40L,40L,88L,80L,176L,176L,352L,352L,736L,704L,1472L,1472L,2944L,2944L,6016L,5888L,12032L,12032L,24064L,24064L,48640L,48128L,97280L,97280L,194560L,194560L,391168L,389120L,782336L,782336L,1564672L,1564672L,3137536L,3129344L,6275072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170831Inst : IEnumerable<long>
{
public static readonly long[] Value=A170831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170831.Bytes);
public long this[int i]=>Value[i];

public static A170831Inst Instance=new A170831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170832
{
public static readonly long[] Value={ 3L,3L,9L,9L,33L,27L,99L,99L,297L,297L,945L,891L,2835L,2835L,8505L,8505L,26001L,25515L,78003L,78003L,234009L,234009L,706401L,702027L,2119203L,2119203L,6357609L,6357609L,19112193L,19072827L,57336579L,57336579L,172009737L,172009737L,516383505L,516029211L,1549150515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170832Inst : IEnumerable<long>
{
public static readonly long[] Value=A170832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170832.Bytes);
public long this[int i]=>Value[i];

public static A170832Inst Instance=new A170832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170833
{
public static readonly long[] Value={ 4L,4L,16L,16L,76L,64L,304L,304L,1216L,1216L,5056L,4864L,20224L,20224L,80896L,80896L,326656L,323584L,1306624L,1306624L,5226496L,5226496L,20955136L,20905984L,83820544L,83820544L,335282176L,335282176L,1341915136L,1341128704L,5367660544L,5367660544L,21470642176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170833Inst : IEnumerable<long>
{
public static readonly long[] Value=A170833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170833.Bytes);
public long this[int i]=>Value[i];

public static A170833Inst Instance=new A170833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170834
{
public static readonly long[] Value={ 5L,5L,25L,25L,145L,125L,725L,725L,3625L,3625L,18625L,18125L,93125L,93125L,465625L,465625L,2340625L,2328125L,11703125L,11703125L,58515625L,58515625L,292890625L,292578125L,1464453125L,1464453125L,7322265625L,7322265625L,36619140625L,36611328125L,183095703125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170834Inst : IEnumerable<long>
{
public static readonly long[] Value=A170834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170834.Bytes);
public long this[int i]=>Value[i];

public static A170834Inst Instance=new A170834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170835
{
public static readonly long[] Value={ 3L,5L,11L,9L,8L,25L,12L,4L,16L,19L,13L,22L,7L,26L,14L,10L,15L,2L,6L,24L,23L,18L,21L,17L,1L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170835Inst : IEnumerable<long>
{
public static readonly long[] Value=A170835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170835.Bytes);
public long this[int i]=>Value[i];

public static A170835Inst Instance=new A170835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170836
{
public static readonly long[] Value={ 0L,1L,4L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170836Inst : IEnumerable<long>
{
public static readonly long[] Value=A170836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170836.Bytes);
public long this[int i]=>Value[i];

public static A170836Inst Instance=new A170836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170837
{
public static readonly long[] Value={ 0L,1L,5L,21L,37L,53L,69L,85L,101L,117L,133L,149L,165L,181L,197L,213L,229L,245L,261L,277L,293L,309L,325L,341L,357L,373L,389L,405L,421L,437L,453L,469L,485L,501L,517L,533L,549L,565L,581L,597L,613L,629L,645L,661L,677L,693L,709L,725L,741L,757L,773L,789L,805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170837Inst : IEnumerable<long>
{
public static readonly long[] Value=A170837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170837.Bytes);
public long this[int i]=>Value[i];

public static A170837Inst Instance=new A170837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170838
{
public static readonly long[] Value={ 2L,5L,9L,11L,11L,24L,36L,29L,11L,24L,38L,44L,57L,108L,135L,83L,11L,24L,38L,44L,57L,108L,137L,98L,57L,110L,158L,189L,279L,459L,486L,245L,11L,24L,38L,44L,57L,108L,137L,98L,57L,110L,158L,189L,279L,459L,488L,260L,57L,110L,158L,189L,279L,461L,509L,351L,281L,488L,663L,846L,1296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170838Inst : IEnumerable<long>
{
public static readonly long[] Value=A170838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170838.Bytes);
public long this[int i]=>Value[i];

public static A170838Inst Instance=new A170838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170839
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,6L,9L,1L,4L,6L,10L,7L,18L,27L,27L,1L,4L,6L,10L,7L,18L,27L,28L,7L,18L,28L,37L,39L,81L,108L,81L,1L,4L,6L,10L,7L,18L,27L,28L,7L,18L,28L,37L,39L,81L,108L,82L,7L,18L,28L,37L,39L,81L,109L,91L,39L,82L,121L,150L,198L,351L,405L,243L,1L,4L,6L,10L,7L,18L,27L,28L,7L,18L,28L,37L,39L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170839Inst : IEnumerable<long>
{
public static readonly long[] Value=A170839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170839.Bytes);
public long this[int i]=>Value[i];

public static A170839Inst Instance=new A170839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170840
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,0L,0L,1L,3L,0L,1L,6L,9L,0L,0L,1L,3L,0L,1L,6L,9L,0L,1L,6L,9L,1L,9L,27L,27L,0L,0L,1L,3L,0L,1L,6L,9L,0L,1L,6L,9L,1L,9L,27L,27L,0L,1L,6L,9L,1L,9L,27L,27L,1L,9L,27L,28L,12L,54L,108L,81L,0L,0L,1L,3L,0L,1L,6L,9L,0L,1L,6L,9L,1L,9L,27L,27L,0L,1L,6L,9L,1L,9L,27L,27L,1L,9L,27L,28L,12L,54L,108L,81L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170840Inst : IEnumerable<long>
{
public static readonly long[] Value=A170840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170840.Bytes);
public long this[int i]=>Value[i];

public static A170840Inst Instance=new A170840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170841
{
public static readonly long[] Value={ 3L,9L,15L,15L,27L,57L,63L,33L,27L,57L,75L,99L,195L,297L,243L,87L,27L,57L,75L,99L,195L,297L,255L,153L,195L,321L,423L,687L,1179L,1377L,891L,249L,27L,57L,75L,99L,195L,297L,255L,153L,195L,321L,423L,687L,1179L,1377L,903L,315L,195L,321L,423L,687L,1179L,1401L,1071L,849L,1227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170841Inst : IEnumerable<long>
{
public static readonly long[] Value=A170841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170841.Bytes);
public long this[int i]=>Value[i];

public static A170841Inst Instance=new A170841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170842
{
public static readonly long[] Value={ 1L,2L,3L,2L,7L,12L,9L,2L,7L,12L,13L,20L,45L,54L,27L,2L,7L,12L,13L,20L,45L,54L,31L,20L,45L,62L,79L,150L,243L,216L,81L,2L,7L,12L,13L,20L,45L,54L,31L,20L,45L,62L,79L,150L,243L,216L,85L,20L,45L,62L,79L,150L,243L,224L,133L,150L,259L,344L,537L,936L,1161L,810L,243L,2L,7L,12L,13L,20L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170842Inst : IEnumerable<long>
{
public static readonly long[] Value=A170842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170842.Bytes);
public long this[int i]=>Value[i];

public static A170842Inst Instance=new A170842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170843
{
public static readonly long[] Value={ 1L,0L,0L,2L,3L,0L,0L,2L,3L,0L,4L,12L,9L,0L,0L,2L,3L,0L,4L,12L,9L,0L,4L,12L,9L,8L,36L,54L,27L,0L,0L,2L,3L,0L,4L,12L,9L,0L,4L,12L,9L,8L,36L,54L,27L,0L,4L,12L,9L,8L,36L,54L,27L,8L,36L,54L,43L,96L,216L,216L,81L,0L,0L,2L,3L,0L,4L,12L,9L,0L,4L,12L,9L,8L,36L,54L,27L,0L,4L,12L,9L,8L,36L,54L,27L,8L,36L,54L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170843Inst : IEnumerable<long>
{
public static readonly long[] Value=A170843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170843.Bytes);
public long this[int i]=>Value[i];

public static A170843Inst Instance=new A170843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170844
{
public static readonly long[] Value={ 4L,13L,7L,13L,43L,34L,10L,13L,43L,34L,46L,142L,145L,64L,13L,13L,43L,34L,46L,142L,145L,64L,49L,142L,145L,172L,472L,577L,337L,103L,16L,13L,43L,34L,46L,142L,145L,64L,49L,142L,145L,172L,472L,577L,337L,103L,52L,142L,145L,172L,472L,577L,337L,211L,475L,577L,661L,1588L,2203L,1588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170844Inst : IEnumerable<long>
{
public static readonly long[] Value=A170844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170844.Bytes);
public long this[int i]=>Value[i];

public static A170844Inst Instance=new A170844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170845
{
public static readonly long[] Value={ 1L,3L,1L,3L,10L,6L,1L,3L,10L,6L,10L,33L,28L,9L,1L,3L,10L,6L,10L,33L,28L,9L,10L,33L,28L,36L,109L,117L,55L,12L,1L,3L,10L,6L,10L,33L,28L,9L,10L,33L,28L,36L,109L,117L,55L,12L,10L,33L,28L,36L,109L,117L,55L,39L,109L,117L,136L,363L,460L,282L,91L,15L,1L,3L,10L,6L,10L,33L,28L,9L,10L,33L,28L,36L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170845Inst : IEnumerable<long>
{
public static readonly long[] Value=A170845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170845.Bytes);
public long this[int i]=>Value[i];

public static A170845Inst Instance=new A170845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170846
{
public static readonly long[] Value={ 1L,0L,0L,3L,1L,0L,0L,3L,1L,0L,9L,6L,1L,0L,0L,3L,1L,0L,9L,6L,1L,0L,9L,6L,1L,27L,27L,9L,1L,0L,0L,3L,1L,0L,9L,6L,1L,0L,9L,6L,1L,27L,27L,9L,1L,0L,9L,6L,1L,27L,27L,9L,1L,27L,27L,9L,82L,108L,54L,12L,1L,0L,0L,3L,1L,0L,9L,6L,1L,0L,9L,6L,1L,27L,27L,9L,1L,0L,9L,6L,1L,27L,27L,9L,1L,27L,27L,9L,82L,108L,54L,12L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170846Inst : IEnumerable<long>
{
public static readonly long[] Value=A170846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170846.Bytes);
public long this[int i]=>Value[i];

public static A170846Inst Instance=new A170846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170847
{
public static readonly long[] Value={ 4L,14L,14L,16L,50L,70L,40L,20L,50L,70L,76L,182L,310L,260L,104L,28L,50L,70L,76L,182L,310L,260L,140L,190L,310L,368L,698L,1294L,1400L,832L,256L,44L,50L,70L,76L,182L,310L,260L,140L,190L,310L,368L,698L,1294L,1400L,832L,292L,206L,310L,368L,698L,1294L,1400L,940L,850L,1310L,1724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170847Inst : IEnumerable<long>
{
public static readonly long[] Value=A170847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170847.Bytes);
public long this[int i]=>Value[i];

public static A170847Inst Instance=new A170847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170848
{
public static readonly long[] Value={ 1L,3L,2L,3L,11L,12L,4L,3L,11L,12L,13L,39L,58L,36L,8L,3L,11L,12L,13L,39L,58L,36L,17L,39L,58L,63L,143L,252L,224L,96L,16L,3L,11L,12L,13L,39L,58L,36L,17L,39L,58L,63L,143L,252L,224L,96L,25L,39L,58L,63L,143L,252L,224L,123L,151L,252L,305L,555L,1042L,1176L,736L,240L,32L,3L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170848Inst : IEnumerable<long>
{
public static readonly long[] Value=A170848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170848.Bytes);
public long this[int i]=>Value[i];

public static A170848Inst Instance=new A170848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170849
{
public static readonly long[] Value={ 1L,0L,0L,3L,2L,0L,0L,3L,2L,0L,9L,12L,4L,0L,0L,3L,2L,0L,9L,12L,4L,0L,9L,12L,4L,27L,54L,36L,8L,0L,0L,3L,2L,0L,9L,12L,4L,0L,9L,12L,4L,27L,54L,36L,8L,0L,9L,12L,4L,27L,54L,36L,8L,27L,54L,36L,89L,216L,216L,96L,16L,0L,0L,3L,2L,0L,9L,12L,4L,0L,9L,12L,4L,27L,54L,36L,8L,0L,9L,12L,4L,27L,54L,36L,8L,27L,54L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170849Inst : IEnumerable<long>
{
public static readonly long[] Value=A170849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170849.Bytes);
public long this[int i]=>Value[i];

public static A170849Inst Instance=new A170849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170850
{
public static readonly long[] Value={ 4L,15L,21L,21L,57L,108L,90L,39L,57L,108L,126L,234L,495L,594L,351L,93L,57L,108L,126L,234L,495L,594L,387L,288L,495L,702L,1080L,2187L,3267L,2835L,1296L,255L,57L,108L,126L,234L,495L,594L,387L,288L,495L,702L,1080L,2187L,3267L,2835L,1332L,450L,495L,702L,1080L,2187L,3267L,2943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170850Inst : IEnumerable<long>
{
public static readonly long[] Value=A170850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170850.Bytes);
public long this[int i]=>Value[i];

public static A170850Inst Instance=new A170850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170851
{
public static readonly long[] Value={ 1L,3L,3L,3L,12L,18L,9L,3L,12L,18L,18L,45L,90L,81L,27L,3L,12L,18L,18L,45L,90L,81L,36L,45L,90L,108L,189L,405L,513L,324L,81L,3L,12L,18L,18L,45L,90L,81L,36L,45L,90L,108L,189L,405L,513L,324L,90L,45L,90L,108L,189L,405L,513L,351L,243L,405L,594L,891L,1782L,2754L,2511L,1215L,243L,3L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170851Inst : IEnumerable<long>
{
public static readonly long[] Value=A170851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170851.Bytes);
public long this[int i]=>Value[i];

public static A170851Inst Instance=new A170851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170852
{
public static readonly long[] Value={ 1L,0L,0L,3L,3L,0L,0L,3L,3L,0L,9L,18L,9L,0L,0L,3L,3L,0L,9L,18L,9L,0L,9L,18L,9L,27L,81L,81L,27L,0L,0L,3L,3L,0L,9L,18L,9L,0L,9L,18L,9L,27L,81L,81L,27L,0L,9L,18L,9L,27L,81L,81L,27L,27L,81L,81L,108L,324L,486L,324L,81L,0L,0L,3L,3L,0L,9L,18L,9L,0L,9L,18L,9L,27L,81L,81L,27L,0L,9L,18L,9L,27L,81L,81L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170852Inst : IEnumerable<long>
{
public static readonly long[] Value=A170852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170852.Bytes);
public long this[int i]=>Value[i];

public static A170852Inst Instance=new A170852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170853
{
public static readonly long[] Value={ 0L,31L,37L,85L,93L,94L,109L,111L,112L,118L,247L,253L,255L,256L,271L,274L,279L,280L,282L,283L,325L,327L,333L,334L,336L,337L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170853Inst : IEnumerable<long>
{
public static readonly long[] Value=A170853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170853.Bytes);
public long this[int i]=>Value[i];

public static A170853Inst Instance=new A170853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170854
{
public static readonly long[] Value={ 0L,1L,2L,7L,2L,7L,20L,25L,2L,7L,20L,25L,20L,61L,110L,79L,2L,7L,20L,25L,20L,61L,110L,79L,20L,61L,110L,115L,182L,403L,488L,241L,2L,7L,20L,25L,20L,61L,110L,79L,20L,61L,110L,115L,182L,403L,488L,241L,20L,61L,110L,115L,182L,403L,488L,277L,182L,403L,560L,709L,1352L,2185L,1946L,727L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170854Inst : IEnumerable<long>
{
public static readonly long[] Value=A170854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170854.Bytes);
public long this[int i]=>Value[i];

public static A170854Inst Instance=new A170854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170855
{
public static readonly long[] Value={ 0L,1L,3L,10L,3L,10L,33L,19L,3L,10L,33L,19L,33L,109L,90L,28L,3L,10L,33L,19L,33L,109L,90L,28L,33L,109L,90L,118L,360L,379L,174L,37L,3L,10L,33L,19L,33L,109L,90L,28L,33L,109L,90L,118L,360L,379L,174L,37L,33L,109L,90L,118L,360L,379L,174L,127L,360L,379L,444L,1198L,1497L,901L,285L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170855Inst : IEnumerable<long>
{
public static readonly long[] Value=A170855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170855.Bytes);
public long this[int i]=>Value[i];

public static A170855Inst Instance=new A170855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170856
{
public static readonly long[] Value={ 0L,1L,3L,11L,3L,11L,39L,31L,3L,11L,39L,31L,39L,139L,171L,71L,3L,11L,39L,31L,39L,139L,171L,71L,39L,139L,171L,179L,495L,791L,555L,151L,3L,11L,39L,31L,39L,139L,171L,71L,39L,139L,171L,179L,495L,791L,555L,151L,39L,139L,171L,179L,495L,791L,555L,259L,495L,791L,879L,1843L,3363L,3247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170856Inst : IEnumerable<long>
{
public static readonly long[] Value=A170856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170856.Bytes);
public long this[int i]=>Value[i];

public static A170856Inst Instance=new A170856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170857
{
public static readonly long[] Value={ 0L,1L,3L,12L,3L,12L,45L,45L,3L,12L,45L,45L,45L,171L,270L,144L,3L,12L,45L,45L,45L,171L,270L,144L,45L,171L,270L,270L,648L,1323L,1242L,441L,3L,12L,45L,45L,45L,171L,270L,144L,45L,171L,270L,270L,648L,1323L,1242L,441L,45L,171L,270L,270L,648L,1323L,1242L,567L,648L,1323L,1620L,2754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170857Inst : IEnumerable<long>
{
public static readonly long[] Value=A170857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170857.Bytes);
public long this[int i]=>Value[i];

public static A170857Inst Instance=new A170857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170858
{
public static readonly long[] Value={ 1L,0L,3L,3L,3L,3L,12L,12L,3L,3L,12L,12L,12L,21L,48L,39L,3L,3L,12L,12L,12L,21L,48L,39L,12L,21L,48L,48L,57L,111L,183L,120L,3L,3L,12L,12L,12L,21L,48L,39L,12L,21L,48L,48L,57L,111L,183L,120L,12L,21L,48L,48L,57L,111L,183L,129L,57L,111L,192L,201L,282L,516L,669L,363L,3L,3L,12L,12L,12L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170858Inst : IEnumerable<long>
{
public static readonly long[] Value=A170858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170858.Bytes);
public long this[int i]=>Value[i];

public static A170858Inst Instance=new A170858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170859
{
public static readonly long[] Value={ 1L,0L,3L,6L,3L,6L,21L,24L,3L,6L,21L,24L,21L,60L,111L,78L,3L,6L,21L,24L,21L,60L,111L,78L,21L,60L,111L,114L,183L,402L,489L,240L,3L,6L,21L,24L,21L,60L,111L,78L,21L,60L,111L,114L,183L,402L,489L,240L,21L,60L,111L,114L,183L,402L,489L,276L,183L,402L,561L,708L,1353L,2184L,1947L,726L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170859Inst : IEnumerable<long>
{
public static readonly long[] Value=A170859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170859.Bytes);
public long this[int i]=>Value[i];

public static A170859Inst Instance=new A170859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170860
{
public static readonly long[] Value={ 1L,0L,1L,3L,1L,3L,10L,6L,1L,3L,10L,6L,10L,33L,28L,9L,1L,3L,10L,6L,10L,33L,28L,9L,10L,33L,28L,36L,109L,117L,55L,12L,1L,3L,10L,6L,10L,33L,28L,9L,10L,33L,28L,36L,109L,117L,55L,12L,10L,33L,28L,36L,109L,117L,55L,39L,109L,117L,136L,363L,460L,282L,91L,15L,1L,3L,10L,6L,10L,33L,28L,9L,10L,33L,28L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170860Inst : IEnumerable<long>
{
public static readonly long[] Value=A170860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170860.Bytes);
public long this[int i]=>Value[i];

public static A170860Inst Instance=new A170860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170861
{
public static readonly long[] Value={ 1L,0L,2L,6L,2L,6L,22L,18L,2L,6L,22L,18L,22L,78L,98L,42L,2L,6L,22L,18L,22L,78L,98L,42L,22L,78L,98L,102L,278L,450L,322L,90L,2L,6L,22L,18L,22L,78L,98L,42L,22L,78L,98L,102L,278L,450L,322L,90L,22L,78L,98L,102L,278L,450L,322L,150L,278L,450L,502L,1038L,1906L,1866L,914L,186L,2L,6L,22L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170861Inst : IEnumerable<long>
{
public static readonly long[] Value=A170861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170861.Bytes);
public long this[int i]=>Value[i];

public static A170861Inst Instance=new A170861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170862
{
public static readonly long[] Value={ 1L,0L,3L,9L,3L,9L,36L,36L,3L,9L,36L,36L,36L,135L,216L,117L,3L,9L,36L,36L,36L,135L,216L,117L,36L,135L,216L,216L,513L,1053L,999L,360L,3L,9L,36L,36L,36L,135L,216L,117L,36L,135L,216L,216L,513L,1053L,999L,360L,36L,135L,216L,216L,513L,1053L,999L,459L,513L,1053L,1296L,2187L,4698L,6156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170862Inst : IEnumerable<long>
{
public static readonly long[] Value=A170862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170862.Bytes);
public long this[int i]=>Value[i];

public static A170862Inst Instance=new A170862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170863
{
public static readonly long[] Value={ 1L,1L,4L,7L,4L,7L,19L,25L,4L,7L,19L,25L,19L,40L,82L,79L,4L,7L,19L,25L,19L,40L,82L,79L,19L,40L,82L,94L,97L,202L,325L,241L,4L,7L,19L,25L,19L,40L,82L,79L,19L,40L,82L,94L,97L,202L,325L,241L,19L,40L,82L,94L,97L,202L,325L,256L,97L,202L,340L,379L,493L,931L,1216L,727L,4L,7L,19L,25L,19L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170863Inst : IEnumerable<long>
{
public static readonly long[] Value=A170863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170863.Bytes);
public long this[int i]=>Value[i];

public static A170863Inst Instance=new A170863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170864
{
public static readonly long[] Value={ 1L,1L,5L,13L,5L,13L,41L,49L,5L,13L,41L,49L,41L,121L,221L,157L,5L,13L,41L,49L,41L,121L,221L,157L,41L,121L,221L,229L,365L,805L,977L,481L,5L,13L,41L,49L,41L,121L,221L,157L,41L,121L,221L,229L,365L,805L,977L,481L,41L,121L,221L,229L,365L,805L,977L,553L,365L,805L,1121L,1417L,2705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170864Inst : IEnumerable<long>
{
public static readonly long[] Value=A170864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170864.Bytes);
public long this[int i]=>Value[i];

public static A170864Inst Instance=new A170864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170865
{
public static readonly long[] Value={ 1L,1L,4L,13L,4L,13L,43L,25L,4L,13L,43L,25L,43L,142L,118L,37L,4L,13L,43L,25L,43L,142L,118L,37L,43L,142L,118L,154L,469L,496L,229L,49L,4L,13L,43L,25L,43L,142L,118L,37L,43L,142L,118L,154L,469L,496L,229L,49L,43L,142L,118L,154L,469L,496L,229L,166L,469L,496L,580L,1561L,1957L,1183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170865Inst : IEnumerable<long>
{
public static readonly long[] Value=A170865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170865.Bytes);
public long this[int i]=>Value[i];

public static A170865Inst Instance=new A170865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170866
{
public static readonly long[] Value={ 1L,1L,5L,17L,5L,17L,61L,49L,5L,17L,61L,49L,61L,217L,269L,113L,5L,17L,61L,49L,61L,217L,269L,113L,61L,217L,269L,281L,773L,1241L,877L,241L,5L,17L,61L,49L,61L,217L,269L,113L,61L,217L,269L,281L,773L,1241L,877L,241L,61L,217L,269L,281L,773L,1241L,877L,409L,773L,1241L,1381L,2881L,5269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170866Inst : IEnumerable<long>
{
public static readonly long[] Value=A170866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170866.Bytes);
public long this[int i]=>Value[i];

public static A170866Inst Instance=new A170866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170867
{
public static readonly long[] Value={ 1L,1L,6L,21L,6L,21L,81L,81L,6L,21L,81L,81L,81L,306L,486L,261L,6L,21L,81L,81L,81L,306L,486L,261L,81L,306L,486L,486L,1161L,2376L,2241L,801L,6L,21L,81L,81L,81L,306L,486L,261L,81L,306L,486L,486L,1161L,2376L,2241L,801L,81L,306L,486L,486L,1161L,2376L,2241L,1026L,1161L,2376L,2916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170867Inst : IEnumerable<long>
{
public static readonly long[] Value=A170867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170867.Bytes);
public long this[int i]=>Value[i];

public static A170867Inst Instance=new A170867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170868
{
public static readonly long[] Value={ 1L,2L,5L,11L,5L,11L,26L,38L,5L,11L,26L,38L,26L,59L,116L,119L,5L,11L,26L,38L,26L,59L,116L,119L,26L,59L,116L,140L,137L,293L,467L,362L,5L,11L,26L,38L,26L,59L,116L,119L,26L,59L,116L,140L,137L,293L,467L,362L,26L,59L,116L,140L,137L,293L,467L,383L,137L,293L,488L,557L,704L,1346L,1763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170868Inst : IEnumerable<long>
{
public static readonly long[] Value=A170868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170868.Bytes);
public long this[int i]=>Value[i];

public static A170868Inst Instance=new A170868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170869
{
public static readonly long[] Value={ 1L,2L,7L,20L,7L,20L,61L,74L,7L,20L,61L,74L,61L,182L,331L,236L,7L,20L,61L,74L,61L,182L,331L,236L,61L,182L,331L,344L,547L,1208L,1465L,722L,7L,20L,61L,74L,61L,182L,331L,236L,61L,182L,331L,344L,547L,1208L,1465L,722L,61L,182L,331L,344L,547L,1208L,1465L,830L,547L,1208L,1681L,2126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170869Inst : IEnumerable<long>
{
public static readonly long[] Value=A170869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170869.Bytes);
public long this[int i]=>Value[i];

public static A170869Inst Instance=new A170869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170870
{
public static readonly long[] Value={ 1L,2L,7L,23L,7L,23L,76L,44L,7L,23L,76L,44L,76L,251L,208L,65L,7L,23L,76L,44L,76L,251L,208L,65L,76L,251L,208L,272L,829L,875L,403L,86L,7L,23L,76L,44L,76L,251L,208L,65L,76L,251L,208L,272L,829L,875L,403L,86L,76L,251L,208L,272L,829L,875L,403L,293L,829L,875L,1024L,2759L,3454L,2084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170870Inst : IEnumerable<long>
{
public static readonly long[] Value=A170870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170870.Bytes);
public long this[int i]=>Value[i];

public static A170870Inst Instance=new A170870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170871
{
public static readonly long[] Value={ 1L,2L,8L,28L,8L,28L,100L,80L,8L,28L,100L,80L,100L,356L,440L,184L,8L,28L,100L,80L,100L,356L,440L,184L,100L,356L,440L,460L,1268L,2032L,1432L,392L,8L,28L,100L,80L,100L,356L,440L,184L,100L,356L,440L,460L,1268L,2032L,1432L,392L,100L,356L,440L,460L,1268L,2032L,1432L,668L,1268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170871Inst : IEnumerable<long>
{
public static readonly long[] Value=A170871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170871.Bytes);
public long this[int i]=>Value[i];

public static A170871Inst Instance=new A170871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170872
{
public static readonly long[] Value={ 1L,2L,9L,33L,9L,33L,126L,126L,9L,33L,126L,126L,126L,477L,756L,405L,9L,33L,126L,126L,126L,477L,756L,405L,126L,477L,756L,756L,1809L,3699L,3483L,1242L,9L,33L,126L,126L,126L,477L,756L,405L,126L,477L,756L,756L,1809L,3699L,3483L,1242L,126L,477L,756L,756L,1809L,3699L,3483L,1593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170872Inst : IEnumerable<long>
{
public static readonly long[] Value=A170872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170872.Bytes);
public long this[int i]=>Value[i];

public static A170872Inst Instance=new A170872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170873
{
public static readonly long[] Value={ 2L,11L,7L,14L,1L,5L,1L,6L,2L,8L,10L,14L,13L,2L,10L,6L,10L,11L,15L,7L,1L,5L,8L,8L,0L,9L,12L,15L,4L,15L,3L,12L,7L,6L,2L,14L,7L,1L,6L,0L,15L,3L,8L,11L,4L,13L,10L,5L,6L,10L,7L,8L,4L,13L,9L,0L,4L,5L,1L,9L,0L,12L,15L,14L,15L,3L,2L,4L,14L,7L,7L,3L,8L,9L,2L,6L,12L,15L,11L,14L,5L,15L,4L,11L,15L,8L,13L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170873Inst : IEnumerable<long>
{
public static readonly long[] Value=A170873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170873.Bytes);
public long this[int i]=>Value[i];

public static A170873Inst Instance=new A170873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170874
{
public static readonly long[] Value={ 9L,3L,12L,4L,6L,7L,14L,3L,7L,13L,11L,0L,12L,7L,10L,4L,13L,1L,11L,14L,3L,15L,8L,1L,0L,1L,5L,2L,12L,11L,5L,6L,10L,1L,12L,14L,12L,12L,3L,10L,15L,6L,5L,12L,12L,0L,1L,9L,0L,12L,0L,3L,13L,15L,3L,4L,7L,0L,9L,10L,15L,15L,11L,13L,8L,14L,4L,11L,5L,9L,15L,10L,0L,3L,10L,9L,15L,0L,14L,14L,13L,0L,6L,4L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170874Inst : IEnumerable<long>
{
public static readonly long[] Value=A170874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170874.Bytes);
public long this[int i]=>Value[i];

public static A170874Inst Instance=new A170874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170875
{
public static readonly long[] Value={ 0L,1L,4L,16L,16L,16L,64L,80L,64L,144L,160L,224L,176L,256L,320L,400L,512L,480L,688L,768L,704L,816L,896L,1120L,1168L,1536L,1568L,1936L,1600L,1984L,1776L,2112L,2304L,2544L,2656L,3008L,2896L,3072L,3200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170875Inst : IEnumerable<long>
{
public static readonly long[] Value=A170875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170875.Bytes);
public long this[int i]=>Value[i];

public static A170875Inst Instance=new A170875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170876
{
public static readonly long[] Value={ 0L,1L,5L,21L,37L,53L,117L,197L,261L,405L,565L,789L,965L,1221L,1541L,1941L,2453L,2933L,3621L,4389L,5093L,5909L,6805L,7925L,9093L,10629L,12197L,14133L,15733L,17717L,19493L,21605L,23909L,26453L,29109L,32117L,35013L,38085L,41285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170876Inst : IEnumerable<long>
{
public static readonly long[] Value=A170876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170876.Bytes);
public long this[int i]=>Value[i];

public static A170876Inst Instance=new A170876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170877
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,15L,22L,30L,43L,61L,88L,123L,173L,246L,348L,487L,688L,972L,1371L,1928L,2714L,3822L,5387L,7582L,10681L,15046L,21194L,29835L,42009L,59159L,83305L,117292L,165170L,232593L,327530L,461198L,649431L,914493L,1287747L,1813281L,2553346L,3595465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170877Inst : IEnumerable<long>
{
public static readonly long[] Value=A170877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170877.Bytes);
public long this[int i]=>Value[i];

public static A170877Inst Instance=new A170877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170878
{
public static readonly long[] Value={ 4L,0L,12L,-12L,20L,-8L,44L,-56L,20L,0L,60L,-68L,68L,-24L,156L,-212L,20L,0L,60L,-60L,100L,-40L,220L,-288L,68L,0L,204L,-228L,244L,-88L,556L,-768L,20L,0L,60L,-60L,100L,-40L,220L,-280L,100L,0L,300L,-340L,340L,-120L,780L,-1068L,68L,0L,204L,-204L,340L,-136L,748L,-976L,244L,0L,732L,-820L,868L,-312L,1980L,-2748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170878Inst : IEnumerable<long>
{
public static readonly long[] Value=A170878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170878.Bytes);
public long this[int i]=>Value[i];

public static A170878Inst Instance=new A170878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170879
{
public static readonly long[] Value={ 0L,1L,4L,9L,17L,26L,37L,54L,75L,90L,101L,119L,144L,173L,212L,266L,319L,346L,357L,375L,400L,429L,468L,523L,580L,621L,661L,722L,801L,898L,1030L,1190L,1319L,1370L,1381L,1399L,1424L,1453L,1492L,1547L,1604L,1645L,1685L,1746L,1825L,1922L,2054L,2215L,2348L,2413L,2453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170879Inst : IEnumerable<long>
{
public static readonly long[] Value=A170879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170879.Bytes);
public long this[int i]=>Value[i];

public static A170879Inst Instance=new A170879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170880
{
public static readonly long[] Value={ 0L,1L,6L,11L,22L,29L,44L,63L,86L,93L,108L,129L,158L,187L,236L,295L,342L,349L,364L,385L,414L,443L,492L,553L,606L,635L,686L,757L,844L,951L,1108L,1271L,1366L,1373L,1388L,1409L,1438L,1467L,1516L,1577L,1630L,1659L,1710L,1781L,1868L,1975L,2132L,2297L,2398L,2427L,2478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170880Inst : IEnumerable<long>
{
public static readonly long[] Value=A170880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170880.Bytes);
public long this[int i]=>Value[i];

public static A170880Inst Instance=new A170880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170881
{
public static readonly long[] Value={ 1L,3L,8L,21L,53L,129L,305L,705L,1601L,3585L,7937L,17409L,37889L,81921L,176129L,376833L,802817L,1703937L,3604481L,7602177L,15990785L,33554433L,70254593L,146800641L,306184193L,637534209L,1325400065L,2751463425L,5704253441L,11811160065L,24427626497L,50465865729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170881Inst : IEnumerable<long>
{
public static readonly long[] Value=A170881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170881.Bytes);
public long this[int i]=>Value[i];

public static A170881Inst Instance=new A170881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170882
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,5L,7L,11L,11L,7L,7L,13L,19L,19L,19L,25L,23L,11L,7L,13L,19L,21L,25L,37L,45L,35L,23L,31L,49L,53L,51L,59L,49L,19L,7L,13L,19L,21L,25L,37L,45L,37L,29L,41L,65L,77L,77L,89L,97L,67L,31L,31L,49L,59L,69L,97L,125L,111L,75L,79L,119L,135L,129L,135L,103L,35L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170882Inst : IEnumerable<long>
{
public static readonly long[] Value=A170882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170882.Bytes);
public long this[int i]=>Value[i];

public static A170882Inst Instance=new A170882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170883
{
public static readonly long[] Value={ 0L,1L,3L,7L,12L,17L,24L,35L,46L,53L,60L,73L,92L,111L,130L,155L,178L,189L,196L,209L,228L,249L,274L,311L,356L,391L,414L,445L,494L,547L,598L,657L,706L,725L,732L,745L,764L,785L,810L,847L,892L,929L,958L,999L,1064L,1141L,1218L,1307L,1404L,1471L,1502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170883Inst : IEnumerable<long>
{
public static readonly long[] Value=A170883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170883.Bytes);
public long this[int i]=>Value[i];

public static A170883Inst Instance=new A170883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170884
{
public static readonly long[] Value={ 0L,3L,7L,15L,27L,39L,51L,67L,99L,155L,223L,263L,283L,299L,331L,387L,467L,555L,659L,811L,1067L,1443L,1831L,1995L,2059L,2083L,2123L,2179L,2259L,2347L,2451L,2603L,2859L,3235L,3659L,3955L,4211L,4483L,4899L,5451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170884Inst : IEnumerable<long>
{
public static readonly long[] Value=A170884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170884.Bytes);
public long this[int i]=>Value[i];

public static A170884Inst Instance=new A170884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170885
{
public static readonly long[] Value={ 0L,3L,4L,8L,12L,12L,12L,16L,32L,56L,68L,40L,20L,16L,32L,56L,80L,88L,104L,152L,256L,376L,388L,164L,64L,24L,40L,56L,80L,88L,104L,152L,256L,376L,424L,296L,256L,272L,416L,552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170885Inst : IEnumerable<long>
{
public static readonly long[] Value=A170885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170885.Bytes);
public long this[int i]=>Value[i];

public static A170885Inst Instance=new A170885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170886
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,11L,17L,23L,29L,37L,49L,55L,63L,75L,93L,107L,121L,141L,161L,167L,175L,187L,205L,219L,235L,259L,285L,301L,325L,363L,409L,447L,489L,541L,577L,583L,591L,603L,621L,635L,651L,675L,701L,717L,741L,779L,825L,863L,907L,963L,1005L,1021L,1045L,1083L,1129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170886Inst : IEnumerable<long>
{
public static readonly long[] Value=A170886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170886.Bytes);
public long this[int i]=>Value[i];

public static A170886Inst Instance=new A170886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170887
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,4L,6L,6L,6L,8L,12L,6L,8L,12L,18L,14L,14L,20L,20L,6L,8L,12L,18L,14L,16L,24L,26L,16L,24L,38L,46L,38L,42L,52L,36L,6L,8L,12L,18L,14L,16L,24L,26L,16L,24L,38L,46L,38L,44L,56L,42L,16L,24L,38L,46L,40L,52L,70L,64L,52L,82L,118L,126L,114L,130L,132L,68L,6L,8L,12L,18L,14L,16L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170887Inst : IEnumerable<long>
{
public static readonly long[] Value=A170887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170887.Bytes);
public long this[int i]=>Value[i];

public static A170887Inst Instance=new A170887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170888
{
public static readonly long[] Value={ 0L,1L,3L,7L,11L,15L,21L,31L,39L,43L,49L,59L,69L,81L,101L,127L,143L,147L,153L,163L,173L,185L,205L,231L,249L,261L,281L,309L,339L,381L,445L,511L,543L,547L,553L,563L,573L,585L,605L,631L,649L,661L,681L,709L,739L,781L,845L,911L,945L,957L,977L,1005L,1035L,1077L,1141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170888Inst : IEnumerable<long>
{
public static readonly long[] Value=A170888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170888.Bytes);
public long this[int i]=>Value[i];

public static A170888Inst Instance=new A170888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170889
{
public static readonly long[] Value={ 0L,1L,2L,4L,4L,4L,6L,10L,8L,4L,6L,10L,10L,12L,20L,26L,16L,4L,6L,10L,10L,12L,20L,26L,18L,12L,20L,28L,30L,42L,64L,66L,32L,4L,6L,10L,10L,12L,20L,26L,18L,12L,20L,28L,30L,42L,64L,66L,34L,12L,20L,28L,30L,42L,64L,68L,46L,42L,66L,84L,100L,146L,192L,162L,64L,4L,6L,10L,10L,12L,20L,26L,18L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170889Inst : IEnumerable<long>
{
public static readonly long[] Value=A170889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170889.Bytes);
public long this[int i]=>Value[i];

public static A170889Inst Instance=new A170889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170890
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,10L,14L,21L,29L,37L,43L,53L,61L,71L,83L,103L,123L,139L,151L,165L,173L,183L,195L,215L,235L,253L,271L,295L,317L,345L,385L,441L,493L,531L,559L,581L,589L,599L,611L,631L,651L,669L,687L,711L,733L,761L,801L,857L,909L,949L,983L,1015L,1037L,1065L,1105L,1161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170890Inst : IEnumerable<long>
{
public static readonly long[] Value=A170890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170890.Bytes);
public long this[int i]=>Value[i];

public static A170890Inst Instance=new A170890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170891
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,4L,7L,8L,8L,6L,10L,8L,10L,12L,20L,20L,16L,12L,14L,8L,10L,12L,20L,20L,18L,18L,24L,22L,28L,40L,56L,52L,38L,28L,22L,8L,10L,12L,20L,20L,18L,18L,24L,22L,28L,40L,56L,52L,40L,34L,32L,22L,28L,40L,56L,54L,50L,56L,66L,68L,92L,132L,160L,138L,98L,68L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170891Inst : IEnumerable<long>
{
public static readonly long[] Value=A170891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170891.Bytes);
public long this[int i]=>Value[i];

public static A170891Inst Instance=new A170891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170892
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,12L,16L,24L,34L,44L,48L,56L,66L,78L,90L,112L,138L,156L,160L,168L,178L,190L,202L,224L,250L,270L,282L,304L,332L,364L,406L,472L,538L,572L,576L,584L,594L,606L,618L,640L,666L,686L,698L,720L,748L,780L,822L,888L,954L,990L,1002L,1024L,1052L,1084L,1126L,1192L,1260L,1308L,1350L,1418L,1502L,1604L,1750L,1944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170892Inst : IEnumerable<long>
{
public static readonly long[] Value=A170892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170892.Bytes);
public long this[int i]=>Value[i];

public static A170892Inst Instance=new A170892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170893
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,4L,4L,8L,10L,10L,4L,8L,10L,12L,12L,22L,26L,18L,4L,8L,10L,12L,12L,22L,26L,20L,12L,22L,28L,32L,42L,66L,66L,34L,4L,8L,10L,12L,12L,22L,26L,20L,12L,22L,28L,32L,42L,66L,66L,36L,12L,22L,28L,32L,42L,66L,68L,48L,42L,68L,84L,102L,146L,194L,162L,66L,4L,8L,10L,12L,12L,22L,26L,20L,12L,22L,28L,32L,42L,66L,66L,36L,12L,22L,28L,32L,42L,66L,68L,48L,42L,68L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170893Inst : IEnumerable<long>
{
public static readonly long[] Value=A170893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170893.Bytes);
public long this[int i]=>Value[i];

public static A170893Inst Instance=new A170893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170894
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,10L,13L,19L,27L,33L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170894Inst : IEnumerable<long>
{
public static readonly long[] Value=A170894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170894.Bytes);
public long this[int i]=>Value[i];

public static A170894Inst Instance=new A170894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170895
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,3L,6L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170895Inst : IEnumerable<long>
{
public static readonly long[] Value=A170895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170895.Bytes);
public long this[int i]=>Value[i];

public static A170895Inst Instance=new A170895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170896
{
public static readonly long[] Value={ 0L,1L,5L,9L,13L,25L,29L,41L,53L,65L,85L,97L,117L,145L,157L,169L,181L,201L,229L,249L,285L,321L,365L,409L,445L,497L,549L,577L,605L,633L,669L,713L,757L,825L,893L,969L,1045L,1105L,1173L,1241L,1309L,1377L,1437L,1473L,1541L,1609L,1693L,1793L,1869L,1945L,2037L,2105L,2189L,2281L,2381L,2521L,2621L,2753L,2869L,2969L,3053L,3129L,3237L,3377L,3485L,3585L,3685L,3817L,3909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170896Inst : IEnumerable<long>
{
public static readonly long[] Value=A170896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170896.Bytes);
public long this[int i]=>Value[i];

public static A170896Inst Instance=new A170896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170897
{
public static readonly long[] Value={ 0L,1L,4L,4L,4L,12L,4L,12L,12L,12L,20L,12L,20L,28L,12L,12L,12L,20L,28L,20L,36L,36L,44L,44L,36L,52L,52L,28L,28L,28L,36L,44L,44L,68L,68L,76L,76L,60L,68L,68L,68L,68L,60L,36L,68L,68L,84L,100L,76L,76L,92L,68L,84L,92L,100L,140L,100L,132L,116L,100L,84L,76L,108L,140L,108L,100L,100L,132L,92L,156L,172L,124L,76L,108L,108L,124L,164L,140L,148L,132L,116L,108L,172L,156L,132L,108L,140L,148L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170897Inst : IEnumerable<long>
{
public static readonly long[] Value=A170897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170897.Bytes);
public long this[int i]=>Value[i];

public static A170897Inst Instance=new A170897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170898
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,5L,7L,1L,3L,5L,9L,9L,7L,13L,15L,1L,3L,5L,9L,9L,9L,17L,25L,17L,7L,13L,23L,27L,19L,31L,31L,1L,3L,5L,9L,9L,9L,17L,25L,17L,9L,17L,29L,37L,33L,41L,57L,33L,7L,13L,23L,27L,27L,43L,67L,59L,27L,31L,55L,69L,49L,69L,63L,1L,3L,5L,9L,9L,9L,17L,25L,17L,9L,17L,29L,37L,33L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170898Inst : IEnumerable<long>
{
public static readonly long[] Value=A170898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170898.Bytes);
public long this[int i]=>Value[i];

public static A170898Inst Instance=new A170898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170899
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,3L,0L,1L,2L,4L,4L,3L,6L,7L,0L,1L,2L,4L,4L,4L,8L,12L,8L,3L,6L,11L,13L,9L,15L,15L,0L,1L,2L,4L,4L,4L,8L,12L,8L,4L,8L,14L,18L,16L,20L,28L,16L,3L,6L,11L,13L,13L,21L,33L,29L,13L,15L,27L,34L,24L,34L,31L,0L,1L,2L,4L,4L,4L,8L,12L,8L,4L,8L,14L,18L,16L,20L,28L,16L,4L,8L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170899Inst : IEnumerable<long>
{
public static readonly long[] Value=A170899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170899.Bytes);
public long this[int i]=>Value[i];

public static A170899Inst Instance=new A170899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170900
{
public static readonly long[] Value={ 3L,8L,19L,53L,162L,540L,2043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170900Inst : IEnumerable<long>
{
public static readonly long[] Value=A170900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170900.Bytes);
public long this[int i]=>Value[i];

public static A170900Inst Instance=new A170900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170901
{
public static readonly long[] Value={ 3L,8L,11L,26L,43L,91L,173L,388L,798L,1586L,3502L,7693L,16447L,34410L,94960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170901Inst : IEnumerable<long>
{
public static readonly long[] Value=A170901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170901.Bytes);
public long this[int i]=>Value[i];

public static A170901Inst Instance=new A170901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170902
{
public static readonly long[] Value={ 1L,3L,4L,8L,14L,23L,44L,86L,161L,281L,486L,908L,1966L,3744L,7574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170902Inst : IEnumerable<long>
{
public static readonly long[] Value=A170902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170902.Bytes);
public long this[int i]=>Value[i];

public static A170902Inst Instance=new A170902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170903
{
public static readonly long[] Value={ 1L,1L,5L,1L,5L,9L,13L,1L,5L,9L,13L,9L,21L,33L,29L,1L,5L,9L,13L,9L,21L,33L,29L,9L,21L,33L,37L,41L,77L,97L,61L,1L,5L,9L,13L,9L,21L,33L,29L,9L,21L,33L,37L,41L,77L,97L,61L,9L,21L,33L,37L,41L,77L,97L,69L,41L,77L,105L,117L,161L,253L,257L,125L,1L,5L,9L,13L,9L,21L,33L,29L,9L,21L,33L,37L,41L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A170903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170903Inst : IEnumerable<long>
{
public static readonly long[] Value=A170903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170903.Bytes);
public long this[int i]=>Value[i];

public static A170903Inst Instance=new A170903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A170904
{
public static readonly BigInteger[] Value={ 1L,0L,0L,2L,24L,572L,21280L,1074390L,70299264L,5792903144L,587159944704L,71822748886440L,10435273503677440L,1776780701352504408L,BigInteger.Parse("350461958856515690496"),BigInteger.Parse("79284041282799128098778"),BigInteger.Parse("20392765404792755583221760"),BigInteger.Parse("5917934230798152486136427600"),BigInteger.Parse("1924427226324694427836833857536") };
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
public class A170904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A170904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A170904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A170904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A170904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A170904Inst Instance=new A170904Inst();

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