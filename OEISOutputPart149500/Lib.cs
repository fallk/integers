using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A242012
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,4L,1L,1L,3L,1L,3L,1L,1L,2L,5L,1L,1L,2L,1L,1L,1L,1L,2L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,4L,1L,3L,3L,1L,2L,2L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242012Inst : IEnumerable<long>
{
public static readonly long[] Value=A242012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242012.Bytes);
public long this[int i]=>Value[i];

public static A242012Inst Instance=new A242012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242013
{
public static readonly long[] Value={ 1L,6L,3L,8L,9L,7L,3L,1L,8L,6L,3L,4L,5L,8L,1L,5L,9L,5L,8L,5L,6L,2L,9L,9L,7L,6L,9L,0L,0L,4L,7L,3L,5L,1L,1L,8L,6L,0L,9L,6L,6L,5L,7L,4L,6L,1L,4L,3L,5L,4L,5L,0L,4L,3L,6L,4L,6L,8L,4L,2L,5L,9L,8L,5L,3L,0L,5L,0L,2L,4L,6L,3L,1L,1L,1L,9L,0L,0L,6L,9L,2L,2L,8L,6L,0L,2L,4L,7L,2L,2L,6L,2L,9L,8L,4L,8L,2L,6L,9L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242013Inst : IEnumerable<long>
{
public static readonly long[] Value=A242013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242013.Bytes);
public long this[int i]=>Value[i];

public static A242013Inst Instance=new A242013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242014
{
public static readonly long[] Value={ 1L,4L,5L,8L,13L,27L,30L,59L,79L,101L,107L,115L,132L,153L,182L,206L,241L,260L,332L,344L,370L,437L,493L,521L,541L,587L,602L,660L,710L,812L,829L,838L,868L,979L,1040L,1079L,1114L,1240L,1294L,1367L,1634L,1713L,1727L,1779L,1886L,1929L,1940L,1984L,2060L,2246L,2373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242014Inst : IEnumerable<long>
{
public static readonly long[] Value=A242014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242014.Bytes);
public long this[int i]=>Value[i];

public static A242014Inst Instance=new A242014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242015
{
public static readonly long[] Value={ 4L,0L,9L,5L,0L,6L,9L,0L,3L,4L,1L,1L,8L,9L,5L,7L,6L,8L,2L,4L,5L,1L,1L,6L,3L,9L,5L,1L,8L,3L,7L,9L,7L,6L,3L,7L,0L,4L,3L,1L,9L,9L,5L,2L,9L,0L,9L,8L,4L,7L,1L,6L,6L,3L,2L,3L,4L,8L,9L,0L,9L,7L,6L,6L,8L,2L,7L,2L,5L,6L,9L,2L,7L,8L,0L,6L,3L,7L,6L,8L,8L,9L,2L,1L,2L,7L,2L,9L,8L,5L,0L,7L,0L,4L,4L,6L,0L,5L,2L,8L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242015Inst : IEnumerable<long>
{
public static readonly long[] Value=A242015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242015.Bytes);
public long this[int i]=>Value[i];

public static A242015Inst Instance=new A242015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242064
{
public static readonly long[] Value={ 1L,2L,9L,9L,36L,36L,81L,220L,220L,386L,386L,386L,434L,521L,896L,896L,896L,1167L,1167L,1695L,2065L,2096L,2096L,2968L,2968L,2968L,2968L,3341L,4561L,4561L,4561L,4561L,4672L,4672L,5964L,6203L,7158L,8294L,8294L,8294L,8740L,8740L,10452L,10452L,11075L,11075L,12092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242064Inst : IEnumerable<long>
{
public static readonly long[] Value=A242064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242064.Bytes);
public long this[int i]=>Value[i];

public static A242064Inst Instance=new A242064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242065
{
public static readonly long[] Value={ 2L,3L,4L,8L,8L,17L,17L,17L,60L,60L,60L,60L,60L,60L,60L,60L,60L,60L,179L,179L,179L,179L,179L,179L,179L,179L,264L,264L,264L,319L,319L,319L,319L,365L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,1112L,4372L,4372L,4372L,4372L,4372L,15504L,15504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242065Inst : IEnumerable<long>
{
public static readonly long[] Value=A242065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242065.Bytes);
public long this[int i]=>Value[i];

public static A242065Inst Instance=new A242065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242066
{
public static readonly long[] Value={ 16L,22L,34L,40L,70L,70L,70L,112L,112L,112L,130L,130L,142L,160L,184L,184L,202L,214L,310L,310L,310L,310L,310L,310L,310L,340L,340L,340L,382L,412L,412L,490L,490L,490L,490L,490L,502L,544L,544L,544L,574L,580L,634L,634L,634L,754L,754L,754L,754L,754L,754L,754L,772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242066Inst : IEnumerable<long>
{
public static readonly long[] Value=A242066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242066.Bytes);
public long this[int i]=>Value[i];

public static A242066Inst Instance=new A242066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242067
{
public static readonly long[] Value={ 0L,0L,1L,3L,5L,9L,12L,16L,21L,25L,31L,36L,42L,48L,54L,61L,68L,75L,83L,90L,98L,106L,115L,123L,132L,142L,150L,160L,170L,180L,190L,200L,211L,221L,232L,243L,254L,266L,277L,289L,301L,313L,326L,338L,351L,363L,376L,390L,402L,416L,429L,443L,456L,471L,485L,499L,514L,528L,543L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242067Inst : IEnumerable<long>
{
public static readonly long[] Value=A242067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242067.Bytes);
public long this[int i]=>Value[i];

public static A242067Inst Instance=new A242067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242068
{
public static readonly long[] Value={ 102L,170L,230L,238L,255L,282L,285L,366L,399L,429L,430L,434L,438L,598L,602L,606L,609L,615L,638L,642L,645L,651L,663L,741L,759L,805L,822L,826L,854L,902L,935L,969L,986L,1001L,1022L,1030L,1065L,1085L,1086L,1102L,1105L,1130L,1178L,1182L,1221L,1245L,1265L,1295L,1309L,1310L,1334L,1358L,1374L,1406L,1419L,1426L,1434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242068Inst : IEnumerable<long>
{
public static readonly long[] Value=A242068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242068.Bytes);
public long this[int i]=>Value[i];

public static A242068Inst Instance=new A242068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242069
{
public static readonly long[] Value={ 1L,9L,4L,0L,1L,0L,1L,6L,8L,3L,7L,4L,3L,6L,2L,5L,2L,8L,6L,0L,1L,7L,4L,6L,9L,3L,9L,0L,5L,2L,5L,5L,4L,8L,8L,7L,8L,2L,3L,0L,2L,4L,7L,6L,0L,7L,4L,4L,5L,7L,5L,8L,4L,5L,3L,6L,2L,8L,7L,0L,7L,6L,7L,3L,8L,9L,6L,6L,3L,5L,9L,6L,5L,7L,9L,2L,4L,8L,3L,2L,0L,8L,7L,3L,8L,7L,3L,5L,1L,2L,1L,8L,6L,8L,7L,2L,4L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242069Inst : IEnumerable<long>
{
public static readonly long[] Value=A242069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242069.Bytes);
public long this[int i]=>Value[i];

public static A242069Inst Instance=new A242069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242070
{
public static readonly long[] Value={ 2L,8L,1L,3L,0L,1L,4L,0L,2L,0L,2L,5L,2L,8L,9L,8L,3L,6L,7L,5L,2L,7L,2L,5L,5L,4L,0L,1L,2L,1L,6L,6L,8L,6L,9L,6L,3L,8L,4L,6L,1L,4L,0L,5L,6L,0L,5L,4L,0L,2L,6L,2L,2L,1L,5L,2L,6L,6L,4L,3L,8L,7L,4L,0L,4L,7L,1L,5L,0L,8L,3L,6L,8L,9L,2L,3L,7L,0L,7L,9L,9L,5L,8L,4L,0L,2L,0L,7L,1L,8L,2L,6L,3L,6L,9L,6L,0L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242070Inst : IEnumerable<long>
{
public static readonly long[] Value=A242070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242070.Bytes);
public long this[int i]=>Value[i];

public static A242070Inst Instance=new A242070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242071
{
public static readonly long[] Value={ 2L,0L,4L,1L,5L,4L,8L,1L,8L,6L,4L,1L,2L,1L,3L,2L,4L,1L,8L,0L,4L,5L,4L,9L,0L,1L,5L,8L,3L,8L,1L,4L,5L,5L,8L,6L,6L,3L,4L,0L,2L,5L,0L,2L,5L,2L,5L,6L,4L,6L,9L,1L,9L,1L,5L,5L,1L,2L,1L,3L,1L,2L,8L,1L,0L,5L,3L,6L,2L,1L,0L,6L,3L,7L,6L,7L,0L,0L,1L,2L,0L,9L,7L,1L,1L,0L,5L,5L,6L,4L,3L,9L,7L,6L,4L,3L,2L,8L,6L,9L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242071Inst : IEnumerable<long>
{
public static readonly long[] Value=A242071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242071.Bytes);
public long this[int i]=>Value[i];

public static A242071Inst Instance=new A242071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242072
{
public static readonly long[] Value={ 3L,1L,8L,2L,4L,8L,1L,5L,8L,4L,0L,5L,8L,4L,4L,8L,6L,9L,4L,2L,5L,9L,6L,2L,0L,2L,7L,4L,8L,1L,4L,0L,6L,9L,4L,2L,4L,3L,8L,0L,6L,2L,3L,6L,5L,6L,4L,0L,6L,8L,4L,8L,8L,4L,0L,6L,7L,6L,7L,6L,0L,6L,3L,2L,2L,1L,4L,7L,6L,7L,3L,0L,9L,2L,5L,7L,5L,8L,7L,9L,1L,0L,3L,9L,7L,4L,5L,6L,9L,5L,4L,1L,9L,5L,2L,5L,5L,7L,0L,3L,7L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242072Inst : IEnumerable<long>
{
public static readonly long[] Value=A242072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242072.Bytes);
public long this[int i]=>Value[i];

public static A242072Inst Instance=new A242072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242073
{
public static readonly long[] Value={ 1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L,-1L,-2L,1L,-1L,-1L,1L,1L,2L,-1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242073Inst : IEnumerable<long>
{
public static readonly long[] Value=A242073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242073.Bytes);
public long this[int i]=>Value[i];

public static A242073Inst Instance=new A242073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242074
{
public static readonly long[] Value={ 25L,41L,64L,103L,131L,169L,271L,274L,281L,441L,713L,901L,1156L,1871L,3025L,4894L,7921L,12817L,20736L,21319L,33551L,54289L,87842L,142129L,229969L,372100L,602071L,974169L,1576238L,2550409L,4126649L,6677056L,10803703L,17480761L,28284466L,45765225L,74049689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242074Inst : IEnumerable<long>
{
public static readonly long[] Value=A242074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242074.Bytes);
public long this[int i]=>Value[i];

public static A242074Inst Instance=new A242074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242075
{
public static readonly BigInteger[] Value={ 1L,50L,3L,2500L,20L,0L,14L,125000L,111111111L,10L,BigInteger.Parse("909090909090909090909"),0L,BigInteger.Parse("769230769230769230769230769"),714L,0L,6250000L,5882L,0L,5263L,500L,BigInteger.Parse("4761904761904761904761904761904761"),454545454L,4347L,0L,400L };
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
public class A242075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242075Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242075.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242075Inst Instance=new A242075Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242076
{
public static readonly long[] Value={ 3L,5L,6L,7L,11L,12L,13L,17L,19L,20L,23L,28L,31L,40L,43L,61L,79L,92L,96L,101L,104L,127L,148L,167L,191L,199L,313L,347L,356L,596L,692L,701L,1004L,1228L,1268L,1709L,2617L,3539L,3824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242076Inst : IEnumerable<long>
{
public static readonly long[] Value=A242076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242076.Bytes);
public long this[int i]=>Value[i];

public static A242076Inst Instance=new A242076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242077
{
public static readonly long[] Value={ 4L,5L,6L,14L,16L,24L,26L,34L,36L,64L,66L,74L,76L,84L,86L,114L,116L,124L,126L,134L,136L,164L,166L,174L,176L,184L,186L,214L,216L,224L,226L,234L,236L,264L,266L,274L,276L,284L,286L,314L,316L,324L,326L,334L,336L,364L,366L,374L,376L,384L,386L,414L,416L,424L,426L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242077Inst : IEnumerable<long>
{
public static readonly long[] Value=A242077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242077.Bytes);
public long this[int i]=>Value[i];

public static A242077Inst Instance=new A242077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242078
{
public static readonly long[] Value={ 1L,16L,169L,1764L,17689L,177241L,1774224L,17749369L,177502329L,1775105424L,17751298756L,177513070329L,1775132540281L,17751332312289L,177513333968569L,1775133399758224L,17751334196261689L,177513342503762329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242078Inst : IEnumerable<long>
{
public static readonly long[] Value=A242078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242078.Bytes);
public long this[int i]=>Value[i];

public static A242078Inst Instance=new A242078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242079
{
public static readonly long[] Value={ 1L,4L,12L,28L,73L,163L,343L,867L,1915L,4011L,8203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242079Inst : IEnumerable<long>
{
public static readonly long[] Value=A242079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242079.Bytes);
public long this[int i]=>Value[i];

public static A242079Inst Instance=new A242079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242208
{
public static readonly long[] Value={ 6L,9L,4L,2L,4L,1L,9L,1L,3L,6L,3L,0L,6L,1L,7L,3L,0L,1L,7L,3L,8L,7L,9L,0L,2L,6L,6L,8L,9L,8L,5L,9L,5L,2L,2L,3L,4L,6L,3L,5L,6L,7L,2L,8L,5L,2L,2L,7L,1L,2L,9L,7L,1L,5L,9L,8L,0L,9L,8L,9L,8L,6L,6L,5L,4L,1L,4L,0L,5L,7L,4L,4L,1L,0L,5L,0L,1L,1L,7L,6L,1L,8L,9L,7L,6L,3L,1L,4L,1L,7L,2L,3L,4L,7L,6L,4L,5L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242208Inst : IEnumerable<long>
{
public static readonly long[] Value=A242208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242208.Bytes);
public long this[int i]=>Value[i];

public static A242208Inst Instance=new A242208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242209
{
public static readonly long[] Value={ 38L,339L,579L,1731L,5739L,8499L,32259L,133851L,145779L,163851L,207579L,222531L,235779L,260187L,308019L,323619L,366819L,469731L,550491L,644979L,684699L,743091L,926427L,1003539L,1242939L,1743531L,1808259L,1852107L,1909059L,2075091L,2585571L,4226979L,5358291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242209Inst : IEnumerable<long>
{
public static readonly long[] Value=A242209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242209.Bytes);
public long this[int i]=>Value[i];

public static A242209Inst Instance=new A242209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242210
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,2L,2L,1L,4L,2L,3L,6L,3L,2L,5L,6L,5L,7L,4L,6L,6L,10L,11L,12L,8L,10L,9L,12L,10L,13L,9L,9L,10L,10L,17L,11L,7L,11L,18L,22L,15L,11L,12L,15L,21L,15L,10L,15L,23L,18L,26L,15L,15L,22L,26L,22L,25L,19L,26L,22L,22L,20L,17L,23L,20L,28L,17L,18L,28L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242210Inst : IEnumerable<long>
{
public static readonly long[] Value=A242210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242210.Bytes);
public long this[int i]=>Value[i];

public static A242210Inst Instance=new A242210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242211
{
public static readonly long[] Value={ 4L,6L,12L,36L,144L,1296L,20736L,1679616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242211Inst : IEnumerable<long>
{
public static readonly long[] Value=A242211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242211.Bytes);
public long this[int i]=>Value[i];

public static A242211Inst Instance=new A242211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242212
{
public static readonly long[] Value={ 4L,5L,7L,11L,19L,37L,71L,151L,379L,1051L,3307L,11483L,44453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242212Inst : IEnumerable<long>
{
public static readonly long[] Value=A242212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242212.Bytes);
public long this[int i]=>Value[i];

public static A242212Inst Instance=new A242212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242213
{
public static readonly long[] Value={ 0L,0L,2L,2L,3L,2L,3L,17L,2L,2L,7L,2L,3L,19L,2L,2L,3L,2L,17L,2L,7L,2L,3L,3L,13L,2L,2L,3L,3L,3L,3L,3L,3L,5L,2L,3L,3L,7L,2L,2L,3L,2L,2L,5L,2L,2L,5L,3L,3L,3L,3L,2L,7L,3L,3L,2L,2L,2L,3L,5L,11L,2L,13L,2L,11L,2L,5L,17L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242213Inst : IEnumerable<long>
{
public static readonly long[] Value=A242213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242213.Bytes);
public long this[int i]=>Value[i];

public static A242213Inst Instance=new A242213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242214
{
public static readonly long[] Value={ 16L,22L,34L,37L,42L,43L,47L,48L,52L,59L,63L,67L,69L,73L,74L,79L,84L,86L,87L,89L,93L,94L,99L,101L,102L,103L,106L,107L,109L,112L,115L,116L,117L,118L,123L,124L,126L,127L,128L,131L,134L,135L,138L,141L,143L,145L,149L,152L,159L,163L,164L,169L,171L,172L,174L,182L,184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242214Inst : IEnumerable<long>
{
public static readonly long[] Value=A242214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242214.Bytes);
public long this[int i]=>Value[i];

public static A242214Inst Instance=new A242214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242215
{
public static readonly long[] Value={ 5L,23L,41L,59L,77L,95L,113L,131L,149L,167L,185L,203L,221L,239L,257L,275L,293L,311L,329L,347L,365L,383L,401L,419L,437L,455L,473L,491L,509L,527L,545L,563L,581L,599L,617L,635L,653L,671L,689L,707L,725L,743L,761L,779L,797L,815L,833L,851L,869L,887L,905L,923L,941L,959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242215Inst : IEnumerable<long>
{
public static readonly long[] Value=A242215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242215.Bytes);
public long this[int i]=>Value[i];

public static A242215Inst Instance=new A242215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242216
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,9L,11L,14L,17L,21L,25L,30L,36L,42L,49L,57L,66L,76L,87L,100L,114L,129L,146L,165L,185L,207L,232L,258L,287L,318L,352L,389L,428L,471L,517L,566L,619L,676L,737L,802L,872L,947L,1027L,1112L,1203L,1300L,1402L,1512L,1628L,1751L,1882L,2020L,2167L,2322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242216Inst : IEnumerable<long>
{
public static readonly long[] Value=A242216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242216.Bytes);
public long this[int i]=>Value[i];

public static A242216Inst Instance=new A242216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242217
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,3L,3L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,3L,3L,2L,3L,2L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242217Inst : IEnumerable<long>
{
public static readonly long[] Value=A242217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242217.Bytes);
public long this[int i]=>Value[i];

public static A242217Inst Instance=new A242217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242218
{
public static readonly long[] Value={ 511L,537L,1073L,1461L,1501L,1541L,1763L,2071L,2181L,2449L,4101L,4387L,4399L,4467L,4559L,4607L,4681L,4705L,5089L,5257L,5429L,6415L,6621L,6671L,7097L,7111L,7261L,7391L,7447L,7811L,7831L,7897L,7909L,7969L,8079L,8129L,8193L,8333L,8639L,8915L,9101L,9113L,9123L,9211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242218Inst : IEnumerable<long>
{
public static readonly long[] Value=A242218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242218.Bytes);
public long this[int i]=>Value[i];

public static A242218Inst Instance=new A242218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242219
{
public static readonly long[] Value={ 3L,4L,9L,8L,15L,12L,21L,12L,15L,20L,33L,24L,39L,28L,45L,24L,51L,24L,57L,40L,63L,44L,69L,36L,35L,52L,45L,56L,87L,60L,93L,40L,99L,68L,105L,48L,111L,76L,117L,60L,123L,84L,129L,88L,75L,92L,141L,72L,63L,60L,153L,104L,159L,72L,165L,84L,171L,116L,177L,120L,183L,124L,105L,80L,195L,132L,201L,136L,207L,140L,213L,84L,219L,148L,105L,152L,231L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242219Inst : IEnumerable<long>
{
public static readonly long[] Value=A242219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242219.Bytes);
public long this[int i]=>Value[i];

public static A242219Inst Instance=new A242219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242220
{
public static readonly long[] Value={ 5L,7L,7L,2L,1L,7L,3L,4L,5L,0L,1L,5L,9L,4L,1L,8L,6L,0L,8L,7L,9L,6L,4L,6L,7L,8L,3L,2L,5L,9L,6L,7L,5L,2L,4L,7L,6L,2L,9L,6L,7L,2L,4L,7L,1L,0L,9L,6L,0L,5L,4L,2L,9L,1L,2L,4L,4L,6L,1L,7L,7L,5L,3L,1L,7L,3L,2L,0L,5L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242220Inst : IEnumerable<long>
{
public static readonly long[] Value=A242220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242220.Bytes);
public long this[int i]=>Value[i];

public static A242220Inst Instance=new A242220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242221
{
public static readonly long[] Value={ 1L,25L,26L,28L,33L,35L,39L,46L,50L,58L,63L,65L,77L,78L,81L,85L,86L,88L,92L,93L,94L,95L,105L,111L,116L,118L,119L,122L,123L,124L,125L,130L,133L,134L,143L,144L,145L,146L,148L,153L,155L,160L,161L,162L,165L,170L,171L,172L,176L,178L,183L,185L,186L,188L,189L,196L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242221Inst : IEnumerable<long>
{
public static readonly long[] Value=A242221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242221.Bytes);
public long this[int i]=>Value[i];

public static A242221Inst Instance=new A242221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242222
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,3L,1L,1L,1L,2L,3L,4L,4L,5L,6L,3L,2L,3L,2L,3L,2L,6L,6L,4L,6L,4L,8L,7L,9L,5L,7L,11L,5L,11L,5L,6L,6L,11L,8L,12L,7L,8L,9L,8L,11L,7L,13L,18L,8L,18L,14L,8L,9L,14L,18L,17L,7L,14L,11L,9L,19L,10L,12L,7L,21L,5L,15L,19L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242222Inst : IEnumerable<long>
{
public static readonly long[] Value=A242222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242222.Bytes);
public long this[int i]=>Value[i];

public static A242222Inst Instance=new A242222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242223
{
public static readonly long[] Value={ 1L,3L,11L,5L,137L,7L,1L,761L,7129L,61L,97L,13L,29L,1049L,41233L,17L,37L,19L,7440427L,11167027L,18858053L,23L,583859L,577L,109L,34395742267L,521L,375035183L,4990290163L,31L,2667653736673L,2917L,269L,3583L,397L,1297L,10839223L,199L,737281L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242223Inst : IEnumerable<long>
{
public static readonly long[] Value=A242223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242223.Bytes);
public long this[int i]=>Value[i];

public static A242223Inst Instance=new A242223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242272
{
public static readonly long[] Value={ 1L,8L,12L,16L,20L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242272Inst : IEnumerable<long>
{
public static readonly long[] Value=A242272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242272.Bytes);
public long this[int i]=>Value[i];

public static A242272Inst Instance=new A242272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242273
{
public static readonly long[] Value={ 5L,7L,8L,9L,10L,12L,18L,20L,25L,32L,37L,39L,72L,80L,85L,90L,97L,142L,150L,159L,163L,168L,169L,186L,192L,272L,305L,349L,363L,369L,375L,463L,465L,615L,668L,672L,789L,797L,817L,859L,908L,938L,951L,1092L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242273Inst : IEnumerable<long>
{
public static readonly long[] Value=A242273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242273.Bytes);
public long this[int i]=>Value[i];

public static A242273Inst Instance=new A242273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242274
{
public static readonly long[] Value={ 4L,5L,8L,12L,20L,24L,25L,28L,32L,38L,42L,44L,60L,62L,66L,70L,72L,80L,122L,125L,148L,228L,244L,270L,389L,390L,432L,464L,470L,488L,549L,804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242274Inst : IEnumerable<long>
{
public static readonly long[] Value=A242274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242274.Bytes);
public long this[int i]=>Value[i];

public static A242274Inst Instance=new A242274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242275
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,55L,246L,1398L,10301L,98532L,1246479L,20837171L,466087624L,13943041873L,563753074915L,30784745506212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242275Inst : IEnumerable<long>
{
public static readonly long[] Value=A242275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242275.Bytes);
public long this[int i]=>Value[i];

public static A242275Inst Instance=new A242275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242276
{
public static readonly long[] Value={ 11L,31L,3L,11L,17L,3L,5L,43L,5L,13L,17L,19L,73L,7L,13L,19L,3L,5L,127L,23L,89L,5L,17L,29L,37L,73L,7L,13L,31L,29L,113L,37L,109L,17L,257L,3L,31L,47L,31L,151L,43L,127L,7L,23L,41L,73L,109L,53L,157L,3L,11L,257L,7L,19L,67L,31L,331L,5L,29L,73L,5L,7L,17L,19L,3L,17L,251L,7L,13L,151L,59L,233L,11L,31L,41L,43L,337L,23L,683L,7L,31L,73L,5L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242276Inst : IEnumerable<long>
{
public static readonly long[] Value=A242276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242276.Bytes);
public long this[int i]=>Value[i];

public static A242276Inst Instance=new A242276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242277
{
public static readonly long[] Value={ 0L,2L,2L,5L,2L,2L,5L,2L,5L,2L,17L,2L,17L,5L,5L,2L,2L,2L,2L,28L,5L,28L,2L,28L,5L,2L,5L,2L,10L,5L,58L,2L,5L,2L,2L,77L,5L,2L,5L,2L,2L,2L,28L,5L,2L,41L,2L,5L,2L,10L,5L,41L,129L,77L,5L,5L,2L,58L,5L,41L,5L,2L,5L,17L,10L,2L,28L,10L,2L,2L,5L,28L,10L,2L,2L,5L,2L,5L,17L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242277Inst : IEnumerable<long>
{
public static readonly long[] Value=A242277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242277.Bytes);
public long this[int i]=>Value[i];

public static A242277Inst Instance=new A242277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242278
{
public static readonly long[] Value={ 0L,6L,18L,72L,216L,702L,2106L,6480L,19440L,58806L,176418L,530712L,1592136L,4780782L,14342346L,43040160L,129120480L,387400806L,1162202418L,3486725352L,10460176056L,31380882462L,94142647386L,282429005040L,847287015120L,2541864234006L,7625592702018L,22876787671992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242278Inst : IEnumerable<long>
{
public static readonly long[] Value=A242278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242278.Bytes);
public long this[int i]=>Value[i];

public static A242278Inst Instance=new A242278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242279
{
public static readonly long[] Value={ 1L,23L,252L,1666L,7509L,26865L,79920L,209096L,491425L,1064575L,2150076L,4104738L,7458437L,13005041L,21857984L,35598880L,56353185L,87019191L,131364700L,194364050L,282314901L,403316353L,567402672L,787201416L,1078078209L,1459020095L,1952782300L,2587048786L,3394568325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242279Inst : IEnumerable<long>
{
public static readonly long[] Value=A242279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242279.Bytes);
public long this[int i]=>Value[i];

public static A242279Inst Instance=new A242279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242280
{
public static readonly BigInteger[] Value={ 1L,1L,9L,433L,63225L,18954001L,10159366329L,8924902306993L,11969476975085625L,BigInteger.Parse("23232038620328946001"),BigInteger.Parse("62655369716047066046649"),BigInteger.Parse("227268291642918880258797553"),BigInteger.Parse("1079475019974966974009683584825"),BigInteger.Parse("6565863403062578428919598754170001") };
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
public class A242280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242280Inst Instance=new A242280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242281
{
public static readonly long[] Value={ 419L,761L,911L,1601L,2351L,6269L,6551L,9029L,22259L,28559L,28949L,37139L,52571L,56531L,67559L,70379L,78509L,108359L,114641L,133571L,135119L,138179L,146669L,153449L,176021L,187409L,193841L,200639L,252761L,288731L,303581L,312551L,333479L,337349L,407639L,408389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242281Inst : IEnumerable<long>
{
public static readonly long[] Value=A242281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242281.Bytes);
public long this[int i]=>Value[i];

public static A242281Inst Instance=new A242281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242282
{
public static readonly BigInteger[] Value={ 1L,1L,17L,1441L,379217L,241351201L,316806826577L,767860003562401L,3168021900014798417L,BigInteger.Parse("20904944903800508800801"),BigInteger.Parse("210024043938800961464262737"),BigInteger.Parse("3086813642229865705833791897761"),BigInteger.Parse("64215498113561436496993921529947217") };
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
public class A242282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242282Inst Instance=new A242282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242283
{
public static readonly BigInteger[] Value={ 1L,1L,65L,48385L,201202625L,3177816192001L,149444281172914625L,BigInteger.Parse("17688550295661103160065"),BigInteger.Parse("4659004670032668841494537665"),BigInteger.Parse("2485460204094055083075883434816001"),BigInteger.Parse("2493268982658347340546535733064008565185") };
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
public class A242283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242283Inst Instance=new A242283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242284
{
public static readonly long[] Value={ 2L,2L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242284Inst : IEnumerable<long>
{
public static readonly long[] Value=A242284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242284.Bytes);
public long this[int i]=>Value[i];

public static A242284Inst Instance=new A242284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242285
{
public static readonly long[] Value={ 1L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,4L,2L,3L,3L,3L,4L,4L,2L,3L,3L,3L,4L,4L,3L,2L,3L,3L,3L,4L,4L,3L,4L,2L,3L,3L,3L,4L,4L,3L,4L,4L,2L,3L,3L,3L,4L,4L,3L,4L,4L,4L,2L,3L,3L,3L,4L,4L,3L,4L,4L,4L,3L,2L,3L,3L,3L,4L,4L,3L,4L,4L,4L,3L,4L,2L,3L,3L,3L,4L,4L,3L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242285Inst : IEnumerable<long>
{
public static readonly long[] Value=A242285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242285.Bytes);
public long this[int i]=>Value[i];

public static A242285Inst Instance=new A242285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242286
{
public static readonly long[] Value={ 4L,6L,7L,9L,10L,11L,13L,14L,15L,16L,18L,19L,21L,22L,24L,25L,27L,28L,29L,31L,32L,34L,35L,36L,37L,39L,40L,42L,43L,45L,46L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,64L,65L,66L,67L,69L,70L,72L,73L,75L,76L,77L,78L,79L,81L,82L,84L,85L,87L,88L,89L,91L,92L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242286Inst : IEnumerable<long>
{
public static readonly long[] Value=A242286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242286.Bytes);
public long this[int i]=>Value[i];

public static A242286Inst Instance=new A242286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242287
{
public static readonly long[] Value={ 10L,21L,28L,45L,55L,66L,91L,105L,120L,136L,171L,190L,231L,253L,300L,325L,378L,406L,435L,496L,528L,595L,630L,666L,703L,780L,820L,903L,946L,1035L,1081L,1176L,1225L,1326L,1378L,1485L,1540L,1596L,1711L,1770L,1891L,1953L,2080L,2145L,2211L,2278L,2415L,2485L,2628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242287Inst : IEnumerable<long>
{
public static readonly long[] Value=A242287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242287.Bytes);
public long this[int i]=>Value[i];

public static A242287Inst Instance=new A242287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242624
{
public static readonly long[] Value={ 4L,5L,4L,5L,1L,2L,1L,8L,0L,5L,1L,4L,6L,4L,6L,3L,1L,7L,0L,3L,2L,8L,0L,1L,4L,6L,3L,6L,8L,4L,3L,2L,7L,3L,9L,9L,3L,0L,7L,5L,8L,6L,8L,1L,2L,2L,6L,9L,9L,5L,4L,4L,3L,6L,0L,4L,9L,3L,4L,8L,9L,2L,3L,6L,5L,9L,2L,7L,0L,7L,6L,1L,5L,1L,1L,2L,3L,2L,6L,2L,5L,1L,5L,6L,1L,0L,0L,1L,5L,4L,0L,9L,6L,0L,5L,5L,4L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242624Inst : IEnumerable<long>
{
public static readonly long[] Value=A242624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242624.Bytes);
public long this[int i]=>Value[i];

public static A242624Inst Instance=new A242624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242625
{
public static readonly long[] Value={ 5L,241L,503L,3299L,4861L,9749L,10501L,11633L,13799L,14057L,23003L,40493L,56569L,74323L,90023L,90641L,185177L,224633L,307187L,367097L,648887L,732761L,766679L,954221L,997103L,1004567L,1070423L,1095491L,1100311L,1252997L,1284083L,1434757L,1483397L,1695139L,1716521L,1720151L,2115823L,2176817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242625Inst : IEnumerable<long>
{
public static readonly long[] Value=A242625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242625.Bytes);
public long this[int i]=>Value[i];

public static A242625Inst Instance=new A242625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242626
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,2L,2L,3L,1L,2L,11L,2L,3L,2L,2L,14L,8L,6L,6L,33L,14L,11L,5L,15L,43L,45L,20L,44L,82L,99L,25L,6L,14L,74L,141L,230L,41L,12L,202L,260L,451L,85L,26L,6L,22L,351L,514L,953L,148L,54L,24L,766L,1049L,1798L,355L,104L,18L,104L,1301L,2321L,3503L,751L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242626Inst : IEnumerable<long>
{
public static readonly long[] Value=A242626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242626.Bytes);
public long this[int i]=>Value[i];

public static A242626Inst Instance=new A242626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242627
{
public static readonly long[] Value={ 9L,1L,2L,2L,3L,2L,4L,2L,4L,3L,3L,1L,5L,1L,3L,3L,4L,1L,5L,1L,4L,3L,2L,1L,6L,2L,2L,3L,4L,1L,5L,1L,4L,2L,2L,3L,6L,1L,2L,2L,5L,1L,5L,1L,3L,4L,2L,1L,6L,2L,3L,2L,3L,1L,5L,2L,5L,2L,2L,1L,6L,1L,2L,4L,4L,2L,4L,1L,3L,2L,4L,1L,7L,1L,2L,3L,3L,2L,4L,1L,5L,3L,2L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242627Inst : IEnumerable<long>
{
public static readonly long[] Value=A242627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242627.Bytes);
public long this[int i]=>Value[i];

public static A242627Inst Instance=new A242627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242628
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,2L,2L,2L,1L,1L,1L,1L,4L,3L,3L,3L,2L,2L,2L,2L,3L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,5L,4L,4L,4L,3L,3L,3L,3L,4L,2L,3L,3L,2L,3L,2L,2L,2L,2L,2L,2L,4L,1L,3L,3L,1L,3L,2L,1L,2L,2L,2L,1L,3L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,6L,5L,5L,5L,4L,4L,4L,4L,5L,3L,4L,4L,3L,4L,3L,3L,3L,3L,3L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242628Inst : IEnumerable<long>
{
public static readonly long[] Value=A242628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242628.Bytes);
public long this[int i]=>Value[i];

public static A242628Inst Instance=new A242628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242629
{
public static readonly long[] Value={ 1L,6L,35L,204L,1188L,6919L,40295L,234672L,1366694L,7959418L,46354440L,269961210L,1572213035L,9156329637L,53325071447L,310557107219L,1808637367513L,10533228997581L,61343923944270L,357257684774972L,2080614429665859L,12117182049311250L,70568625653399251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242629Inst : IEnumerable<long>
{
public static readonly long[] Value=A242629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242629.Bytes);
public long this[int i]=>Value[i];

public static A242629Inst Instance=new A242629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242630
{
public static readonly long[] Value={ 1L,7L,48L,329L,2254L,15443L,105804L,724892L,4966431L,34026362L,233123809L,1597194268L,10942809918L,74972150416L,513654479985L,3519185768909L,24110893526041L,165190252745398L,1131763100053353L,7754015102916294L,53124854674462893L,363972747889200054L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242630Inst : IEnumerable<long>
{
public static readonly long[] Value=A242630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242630.Bytes);
public long this[int i]=>Value[i];

public static A242630Inst Instance=new A242630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242631
{
public static readonly long[] Value={ 1L,8L,63L,496L,3904L,30729L,241871L,1903792L,14984945L,117948062L,928381475L,7307387240L,57517205708L,452723914009L,3563437058402L,28048184061555L,220770176730345L,1737705044525640L,13677657310833723L,107658264618591797L,847389408675004032L,6669890253930098674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242631Inst : IEnumerable<long>
{
public static readonly long[] Value=A242631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242631.Bytes);
public long this[int i]=>Value[i];

public static A242631Inst Instance=new A242631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242632
{
public static readonly ulong[] Value={ 1L,9L,80L,711L,6318L,56143L,498896L,4433274L,39394819L,350068993L,3110771999L,27642843622L,245638961566L,2182789161071L,19396631915857L,172361736254288L,1531635402139359L,13610370004776711L,120944038906506659L,1074729088326395697L,9550223588843166996UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242632Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A242632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242632.Bytes);
public ulong this[int i]=>Value[i];

public static A242632Inst Instance=new A242632Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242633
{
public static readonly BigInteger[] Value={ 1L,10L,99L,980L,9700L,96011L,950319L,9406280L,93103581L,921541438L,9121438862L,90284216730L,893635304019L,8845223290551L,87550228496839L,866574224082841L,8577372083864876L,84899030943287514L,840332608243515705L,8317631952113371291L,BigInteger.Parse("82328117000511661919") };
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
public class A242633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242633Inst Instance=new A242633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242634
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,5L,6L,7L,9L,10L,13L,14L,18L,19L,24L,25L,31L,32L,40L,41L,50L,51L,63L,64L,77L,78L,95L,96L,114L,115L,138L,139L,163L,164L,194L,195L,226L,227L,266L,267L,307L,308L,357L,358L,408L,409L,471L,472L,535L,536L,612L,613L,690L,691L,785L,786L,881L,882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242634Inst : IEnumerable<long>
{
public static readonly long[] Value=A242634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242634.Bytes);
public long this[int i]=>Value[i];

public static A242634Inst Instance=new A242634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242635
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,208L,2631L,40295L,724892L,14984945L,350068993L,9121438862L,262285777567L,8250643190038L,281849526767134L,10390959086757005L,411219228179234026L,17387847546353549435UL,BigInteger.Parse("782342249208357483984"),BigInteger.Parse("37321230268969840324231"),BigInteger.Parse("1881590248383756833279387") };
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
public class A242635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242635Inst Instance=new A242635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242636
{
public static readonly long[] Value={ 1L,0L,3L,12L,23L,94L,289L,842L,2771L,8510L,26411L,83122L,258199L,805914L,2517287L,7846960L,24490017L,76416244L,238387767L,743840496L,2320800841L,7240890040L,22592311143L,70488834118L,219928631821L,686190651342L,2140948175385L,6679872756528L,20841562274863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242636Inst : IEnumerable<long>
{
public static readonly long[] Value=A242636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242636.Bytes);
public long this[int i]=>Value[i];

public static A242636Inst Instance=new A242636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242637
{
public static readonly long[] Value={ 0L,0L,3L,14L,63L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242637Inst : IEnumerable<long>
{
public static readonly long[] Value=A242637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242637.Bytes);
public long this[int i]=>Value[i];

public static A242637Inst Instance=new A242637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242638
{
public static readonly long[] Value={ 0L,0L,2L,10L,47L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242638Inst : IEnumerable<long>
{
public static readonly long[] Value=A242638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242638.Bytes);
public long this[int i]=>Value[i];

public static A242638Inst Instance=new A242638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242639
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,4L,1L,5L,7L,7L,1L,5L,10L,13L,6L,1L,5L,10L,17L,11L,12L,1L,5L,10L,21L,16L,23L,8L,1L,5L,10L,21L,21L,32L,15L,15L,1L,5L,10L,21L,26L,38L,22L,29L,13L,1L,5L,10L,21L,26L,44L,29L,41L,25L,18L,1L,5L,10L,21L,26L,50L,36L,53L,37L,35L,12L,1L,5L,10L,21L,26L,50L,43L,61L,46L,50L,23L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242639Inst : IEnumerable<long>
{
public static readonly long[] Value=A242639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242639.Bytes);
public long this[int i]=>Value[i];

public static A242639Inst Instance=new A242639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242720
{
public static readonly long[] Value={ 12L,38L,80L,212L,224L,440L,440L,854L,1250L,1460L,1742L,2282L,2282L,3434L,4190L,4664L,4760L,4760L,6890L,8054L,8054L,8054L,12374L,12830L,12830L,13592L,13592L,14282L,17402L,17402L,18212L,22502L,22502L,22502L,25220L,28202L,28202L,32234L,32402L,32402L,38012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242720Inst : IEnumerable<long>
{
public static readonly long[] Value=A242720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242720.Bytes);
public long this[int i]=>Value[i];

public static A242720Inst Instance=new A242720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242721
{
public static readonly long[] Value={ 1L,1L,1L,4L,3L,0L,5L,5L,5L,0L,8L,4L,8L,6L,9L,0L,0L,0L,2L,3L,0L,1L,6L,9L,3L,5L,8L,4L,9L,4L,4L,8L,2L,1L,1L,3L,4L,8L,2L,7L,3L,7L,8L,2L,5L,6L,3L,1L,9L,1L,7L,7L,4L,2L,5L,5L,7L,0L,0L,9L,1L,8L,1L,3L,7L,4L,3L,5L,0L,7L,0L,2L,7L,9L,3L,3L,4L,4L,4L,3L,4L,3L,0L,9L,6L,1L,2L,9L,5L,5L,1L,9L,1L,0L,2L,2L,8L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242721Inst : IEnumerable<long>
{
public static readonly long[] Value=A242721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242721.Bytes);
public long this[int i]=>Value[i];

public static A242721Inst Instance=new A242721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242722
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,5L,16L,6L,7L,9L,32L,10L,64L,12L,11L,15L,128L,13L,256L,17L,14L,18L,512L,19L,31L,20L,21L,23L,1024L,22L,2048L,24L,25L,33L,47L,26L,4096L,34L,28L,27L,8192L,35L,16384L,29L,37L,36L,32768L,30L,127L,40L,38L,39L,65536L,41L,55L,43L,42L,48L,131072L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242722Inst : IEnumerable<long>
{
public static readonly long[] Value=A242722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242722.Bytes);
public long this[int i]=>Value[i];

public static A242722Inst Instance=new A242722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242723
{
public static readonly long[] Value={ 1L,1L,6L,5L,6L,5L,0L,5L,1L,1L,7L,7L,0L,7L,7L,9L,8L,9L,3L,5L,1L,5L,7L,2L,1L,9L,3L,7L,2L,0L,4L,5L,3L,2L,9L,4L,6L,7L,1L,2L,0L,4L,2L,1L,4L,2L,9L,9L,6L,4L,5L,2L,2L,1L,0L,2L,7L,9L,8L,6L,0L,1L,6L,3L,1L,5L,2L,8L,8L,0L,6L,5L,8L,2L,1L,4L,8L,4L,7L,4L,0L,6L,1L,1L,7L,0L,8L,5L,7L,3L,8L,1L,0L,6L,0L,2L,1L,6L,4L,7L,2L,1L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242723Inst : IEnumerable<long>
{
public static readonly long[] Value=A242723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242723.Bytes);
public long this[int i]=>Value[i];

public static A242723Inst Instance=new A242723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242724
{
public static readonly long[] Value={ 6L,2L,9L,4L,6L,5L,0L,2L,0L,4L,5L,5L,1L,8L,6L,7L,7L,1L,8L,3L,1L,2L,9L,4L,2L,2L,9L,1L,0L,7L,2L,3L,2L,1L,2L,2L,6L,9L,3L,5L,3L,0L,0L,6L,9L,2L,3L,9L,0L,8L,8L,0L,5L,6L,1L,7L,5L,7L,0L,4L,5L,6L,1L,3L,2L,9L,8L,3L,4L,7L,4L,4L,3L,6L,1L,7L,3L,6L,2L,4L,9L,1L,9L,5L,3L,9L,9L,8L,8L,7L,7L,9L,4L,0L,7L,3L,7L,3L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242724Inst : IEnumerable<long>
{
public static readonly long[] Value=A242724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242724.Bytes);
public long this[int i]=>Value[i];

public static A242724Inst Instance=new A242724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242725
{
public static readonly long[] Value={ 1L,1L,3L,10L,37L,137L,511L,1906L,7113L,26545L,99067L,369722L,1379821L,5149561L,19218423L,71724130L,267678097L,998988257L,3728274931L,13914111466L,51928170933L,193798572265L,723266118127L,2699265900242L,10073797482841L,37595924031121L,140309898641643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242725Inst : IEnumerable<long>
{
public static readonly long[] Value=A242725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242725.Bytes);
public long this[int i]=>Value[i];

public static A242725Inst Instance=new A242725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242726
{
public static readonly long[] Value={ 66L,286L,606L,682L,2222L,2486L,2626L,2882L,3333L,3939L,5555L,6262L,6842L,6886L,7777L,9393L,14443L,18887L,22462L,22682L,22826L,24266L,26422L,26462L,26686L,28622L,33693L,34441L,36399L,39633L,39693L,62822L,66242L,68662L,78881L,99363L,118877L,125543L,145541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242726Inst : IEnumerable<long>
{
public static readonly long[] Value=A242726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242726.Bytes);
public long this[int i]=>Value[i];

public static A242726Inst Instance=new A242726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242727
{
public static readonly long[] Value={ 1L,7L,29L,86L,198L,396L,719L,1203L,1899L,2866L,4156L,5840L,7997L,10695L,14025L,18086L,22962L,28764L,35611L,43603L,52871L,63554L,75768L,89664L,105401L,123111L,142965L,165142L,189790L,217100L,247271L,280467L,316899L,356786L,400308L,447696L,499189L,554983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242727Inst : IEnumerable<long>
{
public static readonly long[] Value=A242727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242727.Bytes);
public long this[int i]=>Value[i];

public static A242727Inst Instance=new A242727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242728
{
public static readonly long[] Value={ 1L,2L,7L,25L,93L,346L,1291L,4817L,17977L,67090L,250383L,934441L,3487381L,13015082L,48572947L,181276705L,676533873L,2524858786L,9422901271L,35166746297L,131244083917L,489809589370L,1827994273563L,6822167504881L,25460675745961L,95020535478962L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242728Inst : IEnumerable<long>
{
public static readonly long[] Value=A242728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242728.Bytes);
public long this[int i]=>Value[i];

public static A242728Inst Instance=new A242728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242729
{
public static readonly long[] Value={ 3L,1L,6L,6L,8L,4L,1L,7L,3L,6L,5L,2L,7L,0L,5L,8L,2L,0L,2L,1L,8L,3L,5L,6L,5L,7L,2L,3L,0L,8L,2L,8L,8L,3L,2L,9L,6L,4L,6L,6L,7L,9L,9L,5L,4L,3L,9L,1L,7L,0L,8L,3L,4L,4L,6L,0L,2L,2L,0L,0L,5L,6L,8L,8L,2L,0L,2L,0L,0L,1L,4L,0L,2L,1L,2L,6L,1L,4L,6L,8L,2L,5L,6L,5L,6L,5L,0L,1L,7L,8L,9L,8L,2L,5L,5L,0L,4L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242729Inst : IEnumerable<long>
{
public static readonly long[] Value=A242729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242729.Bytes);
public long this[int i]=>Value[i];

public static A242729Inst Instance=new A242729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242730
{
public static readonly long[] Value={ 2L,3L,5L,1L,2L,5L,2L,8L,4L,8L,1L,1L,1L,7L,4L,8L,6L,5L,6L,3L,5L,5L,8L,8L,1L,7L,4L,3L,9L,1L,8L,7L,9L,0L,0L,9L,8L,8L,0L,9L,8L,4L,5L,1L,9L,5L,8L,3L,5L,2L,9L,5L,9L,8L,5L,8L,2L,6L,7L,7L,9L,6L,6L,3L,1L,6L,7L,0L,3L,1L,9L,0L,5L,1L,3L,7L,1L,3L,2L,4L,8L,7L,4L,7L,1L,4L,0L,9L,0L,0L,0L,0L,1L,5L,0L,0L,3L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242730Inst : IEnumerable<long>
{
public static readonly long[] Value=A242730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242730.Bytes);
public long this[int i]=>Value[i];

public static A242730Inst Instance=new A242730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242731
{
public static readonly long[] Value={ 5L,6L,8L,10L,12L,17L,7L,9L,11L,13L,16L,6L,10L,9L,12L,15L,16L,14L,18L,22L,27L,20L,26L,32L,37L,8L,14L,18L,18L,22L,22L,27L,27L,32L,20L,20L,26L,32L,32L,37L,37L,42L,42L,26L,34L,42L,47L,52L,8L,11L,14L,10L,13L,11L,14L,14L,17L,16L,20L,20L,24L,12L,8L,10L,14L,22L,30L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242731Inst : IEnumerable<long>
{
public static readonly long[] Value=A242731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242731.Bytes);
public long this[int i]=>Value[i];

public static A242731Inst Instance=new A242731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242732
{
public static readonly long[] Value={ 8L,10L,15L,20L,25L,35L,12L,16L,20L,20L,25L,9L,15L,15L,20L,25L,24L,27L,36L,45L,55L,33L,44L,55L,65L,14L,24L,32L,32L,40L,40L,50L,50L,60L,36L,36L,48L,60L,60L,70L,70L,80L,80L,42L,56L,70L,80L,90L,13L,17L,21L,19L,23L,22L,26L,26L,30L,35L,40L,40L,45L,20L,15L,18L,27L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242732Inst : IEnumerable<long>
{
public static readonly long[] Value=A242732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242732.Bytes);
public long this[int i]=>Value[i];

public static A242732Inst Instance=new A242732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242733
{
public static readonly long[] Value={ 5L,6L,9L,12L,15L,20L,7L,9L,11L,9L,11L,5L,7L,8L,10L,12L,10L,15L,20L,25L,30L,15L,20L,25L,30L,8L,12L,16L,16L,20L,20L,25L,25L,30L,18L,18L,24L,30L,30L,35L,35L,40L,40L,18L,24L,30L,35L,40L,7L,8L,9L,11L,12L,13L,14L,14L,15L,21L,22L,22L,23L,10L,9L,10L,15L,28L,32L,65L,70L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242733Inst : IEnumerable<long>
{
public static readonly long[] Value=A242733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242733.Bytes);
public long this[int i]=>Value[i];

public static A242733Inst Instance=new A242733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242734
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,2L,4L,3L,2L,3L,2L,3L,2L,2L,3L,6L,4L,5L,4L,6L,6L,17L,9L,2L,3L,6L,1L,3L,22L,3L,2L,2L,8L,12L,15L,7L,4L,17L,25L,41L,20L,11L,23L,22L,54L,3L,28L,3L,7L,43L,14L,24L,13L,6L,61L,10L,10L,30L,17L,4L,8L,4L,32L,68L,1L,21L,29L,28L,17L,16L,23L,17L,46L,69L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242734Inst : IEnumerable<long>
{
public static readonly long[] Value=A242734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242734.Bytes);
public long this[int i]=>Value[i];

public static A242734Inst Instance=new A242734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242735
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,-3L,-1L,1L,3L,15L,3L,-1L,3L,15L,-35L,-5L,1L,-1L,5L,35L,315L,35L,-5L,3L,-5L,35L,315L,-693L,-63L,7L,-3L,3L,-7L,63L,693L,3003L,231L,-21L,7L,-5L,7L,-21L,231L,3003L,-6435L,-429L,33L,-9L,5L,-5L,9L,-33L,429L,6435L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242735Inst : IEnumerable<long>
{
public static readonly long[] Value=A242735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242735.Bytes);
public long this[int i]=>Value[i];

public static A242735Inst Instance=new A242735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242816
{
public static readonly long[] Value={ 1L,0L,7L,8L,6L,4L,7L,0L,1L,2L,0L,1L,6L,9L,2L,5L,5L,5L,8L,6L,4L,2L,6L,8L,4L,4L,8L,0L,0L,2L,7L,4L,1L,5L,0L,6L,1L,1L,5L,0L,3L,3L,1L,9L,9L,8L,7L,2L,3L,5L,3L,8L,3L,1L,1L,3L,2L,8L,1L,7L,8L,6L,8L,1L,8L,2L,4L,4L,0L,9L,1L,2L,7L,8L,9L,4L,4L,4L,5L,5L,9L,0L,8L,7L,4L,8L,0L,4L,8L,0L,7L,1L,6L,3L,2L,3L,1L,9L,0L,0L,7L,1L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242816Inst : IEnumerable<long>
{
public static readonly long[] Value=A242816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242816.Bytes);
public long this[int i]=>Value[i];

public static A242816Inst Instance=new A242816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242817
{
public static readonly BigInteger[] Value={ 1L,1L,6L,57L,756L,12880L,268098L,6593839L,187104200L,6016681467L,216229931110L,8588688990640L,373625770888956L,17666550789597073L,902162954264563306L,BigInteger.Parse("49482106424507339565"),BigInteger.Parse("2901159958960121863952"),BigInteger.Parse("181069240855214001514460"),BigInteger.Parse("11985869691525854175222222") };
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
public class A242817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242817Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242817.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242817Inst Instance=new A242817Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242818
{
public static readonly long[] Value={ 1L,1L,3L,5L,19L,39L,173L,407L,2025L,5281L,28787L,81597L,479851L,1459015L,9156093L,29582303L,196506001L,669822849L,4680247715L,16737058997L,122398824579L,457140004519L,3484655325197L,13541735424615L,107230543328761L,432232193519521L,3545227970258067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242818Inst : IEnumerable<long>
{
public static readonly long[] Value=A242818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242818.Bytes);
public long this[int i]=>Value[i];

public static A242818Inst Instance=new A242818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242819
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,3L,90L,30L,450L,270L,2619L,2322L,99L,17334L,20772L,2214L,129114L,195372L,38394L,1067661L,1958337L,591543L,11259L,9713682L,20933154L,8826246L,443718L,96393726L,238789782L,131367258L,12450834L,1036348587L,2900868876L,1989555210L,297195804L,3052323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242819Inst : IEnumerable<long>
{
public static readonly long[] Value=A242819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242819.Bytes);
public long this[int i]=>Value[i];

public static A242819Inst Instance=new A242819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242820
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,116L,4L,672L,48L,4536L,504L,34944L,5376L,302896L,59488L,496L,2916992L,697856L,13952L,30899616L,8720448L,296736L,357080064L,116109312L,5812224L,4470310976L,1645662912L,110697408L,349504L,60269056512L,24776769024L,2114735616L,17730048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242820Inst : IEnumerable<long>
{
public static readonly long[] Value=A242820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242820.Bytes);
public long this[int i]=>Value[i];

public static A242820Inst Instance=new A242820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242821
{
public static readonly long[] Value={ 1L,0L,0L,2L,3L,11L,14L,33L,43L,82L,141L,260L,514L,1049L,2321L,4789L,10454L,21735L,46213L,94782L,196060L,398662L,810178L,1631089L,3278372L,6556096L,13088339L,26063238L,51824061L,102926784L,204239173L,405087125L,803109813L,1592179369L,3156298826L,6258390137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242821Inst : IEnumerable<long>
{
public static readonly long[] Value=A242821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242821.Bytes);
public long this[int i]=>Value[i];

public static A242821Inst Instance=new A242821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242822
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,8L,5L,2L,5L,1L,9L,9L,9L,4L,0L,6L,5L,9L,5L,1L,8L,2L,0L,0L,7L,5L,5L,5L,4L,4L,1L,1L,0L,7L,7L,9L,4L,7L,1L,5L,2L,5L,1L,6L,2L,5L,5L,6L,8L,9L,6L,8L,8L,2L,0L,8L,1L,9L,4L,2L,6L,2L,2L,8L,1L,2L,7L,0L,0L,8L,1L,0L,7L,3L,4L,2L,9L,5L,8L,3L,5L,2L,1L,0L,8L,2L,2L,9L,6L,3L,7L,7L,5L,4L,4L,7L,9L,8L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242822Inst : IEnumerable<long>
{
public static readonly long[] Value=A242822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242822.Bytes);
public long this[int i]=>Value[i];

public static A242822Inst Instance=new A242822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242823
{
public static readonly long[] Value={ 1L,2L,5L,15L,39L,103L,269L,700L,1821L,4736L,12313L,32016L,83242L,216429L,562716L,1463063L,3803966L,9890311L,25714810L,66858508L,173832121L,451963515L,1175105140L,3055273364L,7943710747L,20653647942L,53699484649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242823Inst : IEnumerable<long>
{
public static readonly long[] Value=A242823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242823.Bytes);
public long this[int i]=>Value[i];

public static A242823Inst Instance=new A242823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242824
{
public static readonly BigInteger[] Value={ 1428571L,BigInteger.Parse("1428571428571428571428571") };
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
public class A242824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242824Inst Instance=new A242824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242825
{
public static readonly long[] Value={ 6L,11L,10L,34L,27L,2L,44L,1L,55L,90L,54L,126L,16L,119L,21L,88L,8L,19L,141L,54L,56L,71L,106L,64L,69L,27L,72L,55L,135L,47L,168L,161L,137L,79L,64L,309L,123L,332L,307L,8L,254L,83L,448L,109L,27L,519L,567L,2L,259L,107L,225L,269L,216L,118L,90L,316L,164L,503L,1015L,333L,181L,47L,857L,6L,704L,63L,385L,253L,343L,604L,457L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242825Inst : IEnumerable<long>
{
public static readonly long[] Value=A242825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242825.Bytes);
public long this[int i]=>Value[i];

public static A242825Inst Instance=new A242825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242826
{
public static readonly BigInteger[] Value={ 7L,769L,769230769L,BigInteger.Parse("769230769230769230769"),BigInteger.Parse("769230769230769230769230769230769") };
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
public class A242826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242826Inst Instance=new A242826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242827
{
public static readonly BigInteger[] Value={ 7L,71L,71428571L,7142857142857L,BigInteger.Parse("7142857142857142857142857142857") };
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
public class A242827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242827Inst Instance=new A242827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242828
{
public static readonly BigInteger[] Value={ 5L,5882352941L,588235294117L,BigInteger.Parse("588235294117647058823529411764705882352941176470588235294117") };
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
public class A242828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242828Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242828.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242828Inst Instance=new A242828Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242829
{
public static readonly long[] Value={ 6639266409L,8628052209L,12692281897L,14492398389L,15798643881L,18883291565L,20404935965L,20825703713L,21342970293L,21597222381L,22221458853L,22567169229L,22578915665L,23000623161L,23198162685L,23247729109L,24163642653L,24802386189L,24894100941L,26297281109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242829Inst : IEnumerable<long>
{
public static readonly long[] Value=A242829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242829.Bytes);
public long this[int i]=>Value[i];

public static A242829Inst Instance=new A242829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242830
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,2L,2L,1L,0L,0L,1L,0L,2L,0L,0L,0L,1L,1L,0L,1L,1L,2L,1L,0L,2L,1L,0L,1L,0L,1L,1L,3L,0L,0L,1L,1L,1L,1L,0L,2L,0L,3L,0L,2L,2L,2L,2L,2L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,2L,0L,0L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242830Inst : IEnumerable<long>
{
public static readonly long[] Value=A242830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242830.Bytes);
public long this[int i]=>Value[i];

public static A242830Inst Instance=new A242830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242831
{
public static readonly long[] Value={ 10L,21L,136L,153L,351L,630L,780L,3403L,3570L,5671L,6441L,6670L,7503L,9870L,10011L,13366L,14535L,16653L,20301L,23220L,33153L,34716L,36046L,36315L,37950L,43660L,46360L,56616L,66430L,93096L,93961L,95703L,112101L,139656L,144453L,159895L,166753L,169653L,187578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242831Inst : IEnumerable<long>
{
public static readonly long[] Value=A242831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242831.Bytes);
public long this[int i]=>Value[i];

public static A242831Inst Instance=new A242831Inst();

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