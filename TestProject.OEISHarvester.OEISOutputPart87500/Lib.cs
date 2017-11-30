using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A107141
{
public static readonly long[] Value={ 13L,73L,97L,109L,181L,229L,241L,277L,337L,409L,421L,457L,541L,709L,733L,757L,829L,1009L,1033L,1093L,1117L,1129L,1153L,1213L,1237L,1249L,1381L,1453L,1489L,1597L,1609L,1621L,1669L,1753L,1777L,1873L,2017L,2029L,2089L,2113L,2161L,2221L,2281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107141Inst : IEnumerable<long>
{
public static readonly long[] Value=A107141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107141.Bytes);
public long this[int i]=>Value[i];

public static A107141Inst Instance=new A107141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107142
{
public static readonly long[] Value={ 37L,61L,157L,193L,313L,349L,373L,397L,433L,577L,601L,613L,661L,673L,769L,853L,877L,937L,997L,1021L,1069L,1201L,1297L,1321L,1429L,1549L,1657L,1693L,1741L,1789L,1801L,1861L,1933L,1993L,2053L,2137L,2269L,2293L,2389L,2437L,2473L,2521L,2593L,2749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107142Inst : IEnumerable<long>
{
public static readonly long[] Value=A107142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107142.Bytes);
public long this[int i]=>Value[i];

public static A107142Inst Instance=new A107142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107143
{
public static readonly long[] Value={ 2L,19L,37L,173L,179L,181L,269L,307L,509L,547L,563L,683L,971L,1093L,1123L,1171L,1229L,1381L,1523L,1571L,1579L,1627L,1637L,1667L,1877L,1931L,1933L,2083L,2339L,2371L,2389L,2621L,2731L,2749L,2789L,2909L,3061L,3067L,3109L,3181L,3221L,3229L,3371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107143Inst : IEnumerable<long>
{
public static readonly long[] Value=A107143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107143.Bytes);
public long this[int i]=>Value[i];

public static A107143Inst Instance=new A107143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107144
{
public static readonly long[] Value={ 5L,13L,37L,53L,157L,173L,197L,277L,293L,317L,373L,397L,557L,613L,653L,677L,733L,757L,773L,797L,853L,877L,997L,1013L,1093L,1117L,1213L,1237L,1277L,1373L,1453L,1493L,1597L,1613L,1637L,1693L,1733L,1877L,1933L,1973L,1997L,2053L,2213L,2237L,2293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107144Inst : IEnumerable<long>
{
public static readonly long[] Value=A107144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107144.Bytes);
public long this[int i]=>Value[i];

public static A107144Inst Instance=new A107144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107145
{
public static readonly long[] Value={ 41L,89L,241L,281L,401L,409L,449L,521L,569L,601L,641L,761L,769L,809L,881L,929L,1009L,1049L,1129L,1201L,1249L,1289L,1321L,1361L,1409L,1481L,1489L,1601L,1609L,1721L,1801L,1889L,2081L,2089L,2129L,2161L,2281L,2441L,2521L,2609L,2689L,2729L,2801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107145Inst : IEnumerable<long>
{
public static readonly long[] Value=A107145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107145.Bytes);
public long this[int i]=>Value[i];

public static A107145Inst Instance=new A107145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107146
{
public static readonly long[] Value={ 7L,13L,31L,61L,103L,157L,181L,199L,223L,229L,271L,349L,367L,397L,439L,607L,661L,727L,733L,829L,853L,997L,1021L,1039L,1063L,1069L,1231L,1237L,1279L,1399L,1447L,1543L,1567L,1669L,1693L,1741L,1783L,1861L,1879L,1951L,2029L,2239L,2287L,2341L,2383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107146Inst : IEnumerable<long>
{
public static readonly long[] Value=A107146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107146.Bytes);
public long this[int i]=>Value[i];

public static A107146Inst Instance=new A107146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107147
{
public static readonly long[] Value={ 3L,17L,41L,59L,83L,89L,131L,227L,251L,257L,353L,419L,467L,521L,563L,587L,593L,761L,857L,881L,929L,971L,1049L,1091L,1097L,1193L,1217L,1259L,1307L,1361L,1427L,1433L,1553L,1571L,1601L,1697L,1721L,1811L,1889L,1907L,1931L,1979L,2099L,2243L,2267L,2273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107147Inst : IEnumerable<long>
{
public static readonly long[] Value=A107147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107147.Bytes);
public long this[int i]=>Value[i];

public static A107147Inst Instance=new A107147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107148
{
public static readonly long[] Value={ 2L,23L,29L,53L,71L,149L,191L,197L,239L,263L,317L,359L,389L,431L,557L,599L,653L,701L,743L,821L,863L,911L,1031L,1061L,1103L,1229L,1367L,1373L,1439L,1493L,1583L,1607L,1709L,1733L,1871L,1877L,1901L,1997L,2039L,2069L,2087L,2111L,2207L,2213L,2237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107148Inst : IEnumerable<long>
{
public static readonly long[] Value=A107148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107148.Bytes);
public long this[int i]=>Value[i];

public static A107148Inst Instance=new A107148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107149
{
public static readonly long[] Value={ 11L,47L,103L,163L,199L,311L,419L,499L,587L,599L,683L,863L,883L,907L,911L,991L,1087L,1123L,1291L,1307L,1367L,1439L,1543L,1567L,1571L,1699L,1907L,2003L,2039L,2539L,2579L,2671L,2731L,2803L,2843L,2927L,3191L,3259L,3323L,3391L,3463L,3499L,3623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107149Inst : IEnumerable<long>
{
public static readonly long[] Value=A107149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107149.Bytes);
public long this[int i]=>Value[i];

public static A107149Inst Instance=new A107149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107150
{
public static readonly long[] Value={ 53L,257L,269L,397L,401L,421L,617L,757L,773L,929L,1021L,1109L,1181L,1237L,1433L,1609L,1621L,1697L,1753L,1873L,2069L,2113L,2237L,2381L,2621L,2729L,2777L,2797L,2897L,2953L,3041L,3257L,3433L,3613L,3677L,3701L,3733L,3793L,3853L,3877L,4013L,4093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107150Inst : IEnumerable<long>
{
public static readonly long[] Value=A107150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107150.Bytes);
public long this[int i]=>Value[i];

public static A107150Inst Instance=new A107150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107151
{
public static readonly long[] Value={ 5L,29L,41L,89L,101L,149L,269L,281L,389L,401L,449L,461L,509L,521L,569L,641L,701L,761L,809L,821L,881L,929L,941L,1049L,1061L,1109L,1181L,1229L,1289L,1301L,1361L,1409L,1481L,1601L,1709L,1721L,1889L,1901L,1949L,2069L,2081L,2129L,2141L,2309L,2381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107151Inst : IEnumerable<long>
{
public static readonly long[] Value=A107151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107151.Bytes);
public long this[int i]=>Value[i];

public static A107151Inst Instance=new A107151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107152
{
public static readonly long[] Value={ 61L,109L,181L,229L,241L,349L,409L,421L,541L,601L,661L,709L,769L,829L,1009L,1021L,1069L,1129L,1201L,1249L,1321L,1381L,1429L,1489L,1549L,1609L,1621L,1669L,1741L,1789L,1801L,1861L,2029L,2089L,2161L,2221L,2269L,2281L,2341L,2389L,2521L,2689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107152Inst : IEnumerable<long>
{
public static readonly long[] Value=A107152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107152.Bytes);
public long this[int i]=>Value[i];

public static A107152Inst Instance=new A107152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107153
{
public static readonly long[] Value={ 2L,23L,31L,41L,73L,151L,223L,239L,257L,311L,449L,577L,593L,599L,601L,607L,647L,673L,719L,823L,863L,929L,967L,991L,1087L,1129L,1153L,1223L,1289L,1297L,1327L,1481L,1543L,1559L,1823L,1871L,1889L,1913L,2063L,2129L,2143L,2377L,2441L,2473L,2657L,2663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107153Inst : IEnumerable<long>
{
public static readonly long[] Value=A107153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107153.Bytes);
public long this[int i]=>Value[i];

public static A107153Inst Instance=new A107153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107154
{
public static readonly long[] Value={ 3L,19L,43L,67L,139L,163L,211L,283L,307L,331L,379L,499L,523L,547L,571L,619L,643L,691L,739L,787L,811L,859L,883L,907L,1051L,1123L,1171L,1291L,1459L,1483L,1531L,1579L,1627L,1699L,1723L,1747L,1867L,1987L,2011L,2083L,2131L,2179L,2203L,2251L,2347L,2371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107154Inst : IEnumerable<long>
{
public static readonly long[] Value=A107154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107154.Bytes);
public long this[int i]=>Value[i];

public static A107154Inst Instance=new A107154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107155
{
public static readonly long[] Value={ 53L,113L,149L,193L,197L,277L,317L,373L,421L,449L,457L,541L,557L,809L,821L,953L,1009L,1117L,1229L,1289L,1409L,1481L,1493L,1549L,1597L,1709L,1789L,1801L,1873L,1877L,1901L,1933L,2053L,2153L,2221L,2293L,2377L,2381L,2389L,2417L,2437L,2521L,2549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107155Inst : IEnumerable<long>
{
public static readonly long[] Value=A107155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107155.Bytes);
public long this[int i]=>Value[i];

public static A107155Inst Instance=new A107155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107156
{
public static readonly long[] Value={ 2L,43L,97L,227L,233L,257L,313L,353L,467L,563L,617L,643L,673L,787L,907L,947L,1193L,1283L,1297L,1483L,1777L,1873L,1907L,2027L,2083L,2153L,2203L,2267L,2273L,2377L,2417L,2617L,2683L,2803L,2963L,3067L,3083L,3187L,3217L,3313L,3593L,3673L,3907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107156Inst : IEnumerable<long>
{
public static readonly long[] Value=A107156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107156.Bytes);
public long this[int i]=>Value[i];

public static A107156Inst Instance=new A107156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107157
{
public static readonly long[] Value={ 59L,131L,281L,491L,499L,571L,619L,641L,739L,809L,811L,881L,929L,1259L,1289L,1291L,1571L,1721L,1801L,1889L,1979L,2089L,2131L,2161L,2339L,2459L,2531L,2659L,2801L,2851L,3169L,3209L,3259L,3299L,3449L,3539L,3851L,3929L,3931L,4019L,4049L,4051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107157Inst : IEnumerable<long>
{
public static readonly long[] Value=A107157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107157.Bytes);
public long this[int i]=>Value[i];

public static A107157Inst Instance=new A107157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107158
{
public static readonly long[] Value={ 3L,17L,29L,71L,311L,317L,347L,419L,431L,449L,617L,743L,857L,881L,941L,947L,1013L,1091L,1151L,1163L,1193L,1217L,1451L,1601L,1847L,1877L,2063L,2069L,2153L,2207L,2357L,2411L,2459L,2591L,2777L,2861L,2963L,3023L,3089L,3257L,3359L,3407L,3461L,3533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107158Inst : IEnumerable<long>
{
public static readonly long[] Value=A107158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107158.Bytes);
public long this[int i]=>Value[i];

public static A107158Inst Instance=new A107158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107159
{
public static readonly long[] Value={ 13L,17L,29L,113L,157L,181L,269L,313L,337L,373L,389L,521L,601L,641L,653L,673L,701L,797L,809L,1069L,1109L,1117L,1153L,1213L,1249L,1453L,1481L,1609L,1613L,1621L,1637L,1777L,1933L,1949L,1973L,2053L,2081L,2089L,2129L,2213L,2237L,2297L,2341L,2357L,2393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107159Inst : IEnumerable<long>
{
public static readonly long[] Value=A107159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107159.Bytes);
public long this[int i]=>Value[i];

public static A107159Inst Instance=new A107159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107160
{
public static readonly long[] Value={ 53L,61L,101L,173L,233L,257L,277L,433L,569L,677L,757L,829L,857L,881L,937L,953L,997L,1013L,1049L,1093L,1193L,1277L,1297L,1301L,1361L,1381L,1429L,1433L,1693L,1733L,1741L,1873L,1889L,1901L,1993L,2029L,2141L,2161L,2389L,2417L,2549L,2557L,2609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107160Inst : IEnumerable<long>
{
public static readonly long[] Value=A107160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107160.Bytes);
public long this[int i]=>Value[i];

public static A107160Inst Instance=new A107160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107161
{
public static readonly long[] Value={ 2L,29L,59L,227L,251L,269L,293L,419L,443L,677L,683L,773L,821L,827L,1013L,1187L,1277L,1301L,1373L,1451L,1493L,1523L,1709L,1733L,1811L,1901L,1949L,2027L,2237L,2243L,2339L,2357L,2381L,2477L,2579L,2693L,2699L,2909L,3299L,3371L,3389L,3413L,3467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107161Inst : IEnumerable<long>
{
public static readonly long[] Value=A107161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107161.Bytes);
public long this[int i]=>Value[i];

public static A107161Inst Instance=new A107161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107162
{
public static readonly long[] Value={ 79L,103L,223L,241L,337L,487L,577L,607L,1033L,1153L,1279L,1327L,1399L,1423L,1447L,1471L,1489L,1879L,1993L,2089L,2113L,2311L,2473L,2617L,2647L,2671L,2713L,2719L,2767L,2887L,3079L,3169L,3271L,3313L,3457L,3511L,3559L,3607L,3673L,3697L,3793L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107162Inst : IEnumerable<long>
{
public static readonly long[] Value=A107162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107162.Bytes);
public long this[int i]=>Value[i];

public static A107162Inst Instance=new A107162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107163
{
public static readonly long[] Value={ 7L,71L,79L,191L,263L,463L,599L,631L,823L,863L,919L,991L,1031L,1327L,1367L,1471L,1583L,1607L,1831L,1999L,2087L,2111L,2143L,2311L,2543L,2647L,2671L,2767L,2879L,2927L,3119L,3623L,3767L,3823L,4327L,4447L,4463L,4663L,4783L,4799L,4951L,5023L,5119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107163Inst : IEnumerable<long>
{
public static readonly long[] Value=A107163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107163.Bytes);
public long this[int i]=>Value[i];

public static A107163Inst Instance=new A107163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107164
{
public static readonly long[] Value={ 137L,233L,281L,449L,673L,953L,977L,1033L,1129L,1409L,1481L,1873L,2017L,2081L,2129L,2137L,2377L,2417L,2657L,2713L,2753L,2857L,2969L,3313L,3529L,3593L,3697L,3833L,4001L,4561L,4649L,4657L,4673L,4729L,4817L,4993L,5657L,5737L,5849L,6217L,6329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107164Inst : IEnumerable<long>
{
public static readonly long[] Value=A107164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107164.Bytes);
public long this[int i]=>Value[i];

public static A107164Inst Instance=new A107164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107165
{
public static readonly long[] Value={ 3L,19L,31L,67L,79L,103L,127L,151L,211L,223L,307L,331L,379L,439L,487L,523L,547L,607L,751L,787L,811L,907L,991L,1039L,1063L,1123L,1171L,1231L,1291L,1399L,1447L,1459L,1471L,1579L,1627L,1663L,1699L,1723L,1747L,1951L,2083L,2131L,2143L,2179L,2203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107165Inst : IEnumerable<long>
{
public static readonly long[] Value=A107165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107165.Bytes);
public long this[int i]=>Value[i];

public static A107165Inst Instance=new A107165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107166
{
public static readonly long[] Value={ 2L,29L,31L,37L,47L,61L,79L,101L,127L,157L,191L,229L,263L,269L,271L,293L,311L,317L,359L,367L,389L,421L,461L,479L,503L,541L,599L,607L,653L,677L,727L,733L,743L,751L,757L,773L,797L,823L,829L,839L,853L,887L,911L,967L,983L,997L,1013L,1061L,1063L,1087L,1117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107166Inst : IEnumerable<long>
{
public static readonly long[] Value=A107166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107166.Bytes);
public long this[int i]=>Value[i];

public static A107166Inst Instance=new A107166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107167
{
public static readonly long[] Value={ 5L,17L,53L,113L,137L,173L,197L,233L,257L,293L,317L,353L,557L,593L,617L,653L,677L,773L,797L,857L,953L,977L,1013L,1097L,1193L,1217L,1277L,1373L,1433L,1493L,1553L,1613L,1637L,1697L,1733L,1877L,1913L,1973L,1997L,2153L,2213L,2237L,2273L,2297L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107167Inst : IEnumerable<long>
{
public static readonly long[] Value=A107167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107167.Bytes);
public long this[int i]=>Value[i];

public static A107167Inst Instance=new A107167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107168
{
public static readonly long[] Value={ 19L,31L,79L,139L,151L,199L,211L,271L,331L,379L,439L,499L,571L,619L,631L,691L,739L,751L,811L,859L,919L,991L,1039L,1051L,1171L,1231L,1279L,1291L,1399L,1459L,1471L,1531L,1579L,1699L,1759L,1831L,1879L,1951L,1999L,2011L,2131L,2179L,2239L,2251L,2311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107168Inst : IEnumerable<long>
{
public static readonly long[] Value=A107168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107168.Bytes);
public long this[int i]=>Value[i];

public static A107168Inst Instance=new A107168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107169
{
public static readonly long[] Value={ 3L,23L,47L,83L,107L,167L,227L,263L,347L,383L,443L,467L,503L,563L,587L,647L,683L,743L,827L,863L,887L,947L,983L,1103L,1163L,1187L,1223L,1283L,1307L,1367L,1427L,1487L,1523L,1583L,1607L,1667L,1787L,1823L,1847L,1907L,2003L,2027L,2063L,2087L,2207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107169Inst : IEnumerable<long>
{
public static readonly long[] Value=A107169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107169.Bytes);
public long this[int i]=>Value[i];

public static A107169Inst Instance=new A107169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107170
{
public static readonly long[] Value={ 2L,31L,103L,193L,281L,311L,479L,521L,617L,857L,937L,1063L,1423L,1489L,1657L,1831L,1847L,2543L,2591L,2609L,2671L,2711L,2729L,2753L,2903L,2953L,3023L,3089L,3167L,3319L,3559L,3697L,3761L,3769L,3823L,3863L,4079L,4111L,4201L,4561L,4639L,4903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107170Inst : IEnumerable<long>
{
public static readonly long[] Value=A107170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107170.Bytes);
public long this[int i]=>Value[i];

public static A107170Inst Instance=new A107170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107171
{
public static readonly long[] Value={ 5L,13L,97L,137L,193L,197L,457L,593L,613L,617L,733L,877L,1097L,1237L,1373L,1553L,1753L,1877L,1913L,1997L,2273L,2293L,2333L,2377L,2477L,2593L,2917L,2953L,3037L,3373L,3517L,3593L,3673L,3677L,3697L,3733L,3853L,4217L,4337L,4457L,4513L,4517L,4673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107171Inst : IEnumerable<long>
{
public static readonly long[] Value=A107171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107171.Bytes);
public long this[int i]=>Value[i];

public static A107171Inst Instance=new A107171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107172
{
public static readonly long[] Value={ 11L,17L,107L,227L,281L,491L,563L,569L,593L,659L,761L,1187L,1289L,1361L,1427L,1451L,1481L,1553L,1811L,1889L,1913L,1931L,2153L,2243L,2273L,2411L,2441L,2459L,2657L,2939L,3203L,3209L,3329L,3449L,3467L,3593L,3761L,3779L,3803L,4259L,4289L,4457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107172Inst : IEnumerable<long>
{
public static readonly long[] Value=A107172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107172.Bytes);
public long this[int i]=>Value[i];

public static A107172Inst Instance=new A107172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107173
{
public static readonly long[] Value={ 3L,97L,163L,331L,379L,499L,577L,859L,1153L,1171L,1321L,1483L,1609L,1753L,1873L,2083L,2137L,2161L,2203L,2347L,2539L,2689L,2707L,2731L,2953L,2971L,3067L,3169L,3433L,3529L,3697L,3793L,3931L,4027L,4129L,4339L,4651L,4657L,4723L,4801L,4987L,5113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107173Inst : IEnumerable<long>
{
public static readonly long[] Value=A107173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107173.Bytes);
public long this[int i]=>Value[i];

public static A107173Inst Instance=new A107173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107174
{
public static readonly long[] Value={ 2L,41L,83L,131L,233L,347L,809L,827L,857L,953L,1019L,1091L,1097L,1163L,1217L,1283L,1601L,1619L,1667L,1979L,2081L,2129L,2339L,2393L,2417L,2609L,2801L,2969L,3011L,3137L,3251L,3299L,3539L,3659L,3923L,3929L,4001L,4091L,4241L,4451L,4523L,4721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107174Inst : IEnumerable<long>
{
public static readonly long[] Value=A107174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107174.Bytes);
public long this[int i]=>Value[i];

public static A107174Inst Instance=new A107174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107175
{
public static readonly long[] Value={ 17L,53L,157L,349L,409L,461L,569L,593L,829L,937L,977L,1381L,1409L,1597L,1721L,1733L,1753L,1777L,1861L,2053L,2089L,2129L,2161L,2269L,2381L,2633L,2729L,2857L,2909L,2957L,3137L,3313L,3449L,3517L,3617L,3821L,3877L,3889L,4021L,4373L,4513L,4637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107175Inst : IEnumerable<long>
{
public static readonly long[] Value=A107175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107175.Bytes);
public long this[int i]=>Value[i];

public static A107175Inst Instance=new A107175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107176
{
public static readonly long[] Value={ 149L,281L,293L,353L,509L,613L,661L,733L,797L,1097L,1237L,1361L,1453L,1709L,2141L,2293L,2297L,2473L,2609L,2617L,2789L,3221L,3413L,3557L,3637L,3673L,4093L,4129L,4241L,4297L,4337L,4421L,4657L,4793L,5081L,5101L,5441L,5557L,5653L,5669L,5693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107176Inst : IEnumerable<long>
{
public static readonly long[] Value=A107176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107176.Bytes);
public long this[int i]=>Value[i];

public static A107176Inst Instance=new A107176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107177
{
public static readonly long[] Value={ 3L,23L,71L,131L,167L,239L,443L,587L,599L,683L,1163L,1223L,1319L,1427L,1451L,1499L,1559L,1619L,1979L,2027L,2099L,2243L,2339L,2447L,2543L,2579L,2663L,2927L,3083L,3167L,3251L,3347L,3359L,3371L,3491L,3623L,3659L,3767L,3911L,4079L,4463L,4583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107177Inst : IEnumerable<long>
{
public static readonly long[] Value=A107177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107177.Bytes);
public long this[int i]=>Value[i];

public static A107177Inst Instance=new A107177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107178
{
public static readonly long[] Value={ 7L,17L,47L,73L,97L,103L,167L,223L,257L,313L,353L,367L,383L,433L,503L,577L,593L,607L,647L,727L,857L,887L,937L,983L,1063L,1097L,1153L,1193L,1217L,1223L,1433L,1447L,1487L,1543L,1553L,1567L,1657L,1697L,1753L,1777L,1783L,1823L,1847L,1993L,2063L,2113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107178Inst : IEnumerable<long>
{
public static readonly long[] Value=A107178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107178.Bytes);
public long this[int i]=>Value[i];

public static A107178Inst Instance=new A107178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107179
{
public static readonly long[] Value={ 5L,19L,59L,61L,101L,131L,139L,181L,229L,251L,269L,349L,419L,461L,509L,619L,661L,691L,811L,829L,859L,941L,971L,1021L,1069L,1091L,1109L,1181L,1259L,1291L,1301L,1459L,1531L,1571L,1669L,1699L,1741L,1811L,1861L,1931L,1949L,1979L,2029L,2099L,2131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107179Inst : IEnumerable<long>
{
public static readonly long[] Value=A107179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107179.Bytes);
public long this[int i]=>Value[i];

public static A107179Inst Instance=new A107179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107180
{
public static readonly long[] Value={ 2L,37L,43L,53L,67L,107L,163L,197L,277L,317L,347L,373L,443L,547L,557L,613L,653L,683L,757L,827L,877L,883L,907L,947L,1093L,1117L,1163L,1187L,1213L,1283L,1373L,1453L,1493L,1523L,1597L,1667L,1723L,1733L,1747L,1787L,1877L,1933L,1997L,2003L,2027L,2053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107180Inst : IEnumerable<long>
{
public static readonly long[] Value=A107180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107180.Bytes);
public long this[int i]=>Value[i];

public static A107180Inst Instance=new A107180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107181
{
public static readonly long[] Value={ 17L,41L,89L,113L,137L,233L,257L,281L,353L,401L,449L,521L,569L,593L,617L,641L,761L,809L,857L,881L,929L,953L,977L,1049L,1097L,1193L,1217L,1289L,1361L,1409L,1433L,1481L,1553L,1601L,1697L,1721L,1889L,1913L,2081L,2129L,2153L,2273L,2297L,2393L,2417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107181Inst : IEnumerable<long>
{
public static readonly long[] Value=A107181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107181.Bytes);
public long this[int i]=>Value[i];

public static A107181Inst Instance=new A107181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107182
{
public static readonly long[] Value={ 2L,37L,109L,199L,383L,431L,461L,487L,911L,919L,997L,1087L,1213L,1301L,1583L,1831L,1901L,2381L,2383L,2999L,3079L,3221L,3271L,3389L,3517L,3533L,3613L,3719L,3797L,3967L,4349L,4549L,4639L,4679L,4751L,4919L,5309L,5333L,5741L,5869L,6197L,6271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107182Inst : IEnumerable<long>
{
public static readonly long[] Value=A107182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107182.Bytes);
public long this[int i]=>Value[i];

public static A107182Inst Instance=new A107182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107183
{
public static readonly long[] Value={ 3L,37L,73L,103L,127L,457L,463L,547L,607L,613L,643L,673L,733L,907L,967L,997L,1213L,1237L,1423L,1483L,1597L,1627L,1657L,1723L,1747L,1753L,1987L,1993L,2053L,2287L,2377L,2467L,2503L,2647L,2677L,2683L,2953L,3037L,3187L,3217L,3253L,3457L,3583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107183Inst : IEnumerable<long>
{
public static readonly long[] Value=A107183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107183.Bytes);
public long this[int i]=>Value[i];

public static A107183Inst Instance=new A107183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107184
{
public static readonly long[] Value={ 79L,139L,271L,331L,349L,421L,661L,691L,739L,751L,829L,859L,1201L,1231L,1249L,1321L,1459L,1489L,1669L,1699L,1831L,1879L,2011L,2131L,2161L,2551L,2659L,2749L,2791L,3049L,3061L,3109L,3229L,3319L,3541L,3691L,3739L,3919L,3931L,4021L,4159L,4519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107184Inst : IEnumerable<long>
{
public static readonly long[] Value=A107184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107184.Bytes);
public long this[int i]=>Value[i];

public static A107184Inst Instance=new A107184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107185
{
public static readonly long[] Value={ 19L,23L,83L,163L,271L,367L,419L,479L,491L,503L,571L,619L,919L,947L,967L,1031L,1051L,1151L,1187L,1259L,1327L,1499L,1543L,1607L,1619L,1783L,1831L,2087L,2239L,2287L,2399L,2411L,2531L,2591L,2671L,2699L,3083L,3307L,3323L,3391L,3407L,3467L,3847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107185Inst : IEnumerable<long>
{
public static readonly long[] Value=A107185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107185.Bytes);
public long this[int i]=>Value[i];

public static A107185Inst Instance=new A107185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107186
{
public static readonly long[] Value={ 101L,157L,197L,313L,353L,593L,701L,709L,733L,853L,929L,1033L,1213L,1217L,1297L,1301L,1597L,1657L,1901L,1949L,2053L,2069L,2153L,2341L,2441L,2477L,2677L,2741L,2857L,2861L,2897L,3329L,3361L,3557L,3581L,3617L,3697L,3709L,3733L,3797L,4013L,4241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107186Inst : IEnumerable<long>
{
public static readonly long[] Value=A107186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107186.Bytes);
public long this[int i]=>Value[i];

public static A107186Inst Instance=new A107186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107187
{
public static readonly long[] Value={ 7L,11L,107L,127L,211L,239L,263L,547L,571L,739L,743L,919L,1019L,1163L,1283L,1471L,1579L,1583L,1619L,1667L,1759L,2111L,2339L,2503L,2543L,2683L,2767L,2879L,3571L,3607L,3691L,3739L,3847L,3907L,4099L,4111L,4127L,4391L,4463L,4831L,4967L,5147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107187Inst : IEnumerable<long>
{
public static readonly long[] Value=A107187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107187.Bytes);
public long this[int i]=>Value[i];

public static A107187Inst Instance=new A107187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107188
{
public static readonly long[] Value={ 13L,19L,37L,67L,109L,163L,229L,307L,331L,349L,379L,397L,421L,499L,541L,613L,619L,643L,661L,691L,709L,733L,739L,787L,811L,853L,877L,1021L,1051L,1123L,1237L,1549L,1579L,1597L,1627L,1669L,1723L,1747L,1789L,1861L,1867L,1987L,2179L,2203L,2221L,2251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107188Inst : IEnumerable<long>
{
public static readonly long[] Value=A107188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107188.Bytes);
public long this[int i]=>Value[i];

public static A107188Inst Instance=new A107188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107189
{
public static readonly long[] Value={ 3L,29L,53L,101L,107L,131L,173L,179L,251L,269L,347L,389L,419L,443L,467L,491L,563L,653L,659L,677L,701L,797L,971L,1013L,1091L,1109L,1187L,1277L,1283L,1301L,1427L,1499L,1613L,1637L,1667L,1733L,1811L,1901L,1907L,1949L,1973L,1979L,2003L,2027L,2141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107189Inst : IEnumerable<long>
{
public static readonly long[] Value=A107189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107189.Bytes);
public long this[int i]=>Value[i];

public static A107189Inst Instance=new A107189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107190
{
public static readonly long[] Value={ 2L,41L,47L,71L,89L,137L,167L,239L,281L,353L,359L,383L,401L,431L,449L,479L,593L,617L,743L,761L,839L,863L,929L,977L,983L,1097L,1103L,1151L,1217L,1289L,1319L,1367L,1409L,1487L,1553L,1601L,1607L,1697L,1721L,1913L,2039L,2087L,2111L,2153L,2273L,2351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107190Inst : IEnumerable<long>
{
public static readonly long[] Value=A107190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107190.Bytes);
public long this[int i]=>Value[i];

public static A107190Inst Instance=new A107190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107191
{
public static readonly long[] Value={ 5L,61L,109L,149L,269L,389L,421L,661L,701L,821L,829L,1069L,1181L,1301L,1381L,1429L,1901L,1949L,2141L,2221L,2269L,2309L,2341L,2381L,2549L,2741L,2749L,2789L,2909L,3061L,3109L,3181L,3221L,3229L,3541L,3701L,3709L,4261L,4349L,4421L,4909L,5189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107191Inst : IEnumerable<long>
{
public static readonly long[] Value=A107191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107191.Bytes);
public long this[int i]=>Value[i];

public static A107191Inst Instance=new A107191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107192
{
public static readonly long[] Value={ 89L,401L,521L,761L,769L,809L,1009L,1049L,1249L,1289L,1361L,1409L,1601L,1721L,2081L,2089L,2441L,2729L,2801L,3001L,3049L,3089L,3121L,3169L,3329L,3529L,3881L,3929L,4001L,4049L,4201L,4289L,4441L,4561L,4649L,4729L,5009L,5081L,5209L,5281L,5441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107192Inst : IEnumerable<long>
{
public static readonly long[] Value=A107192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107192.Bytes);
public long this[int i]=>Value[i];

public static A107192Inst Instance=new A107192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107193
{
public static readonly long[] Value={ 97L,181L,277L,337L,349L,373L,613L,733L,757L,829L,853L,1129L,1213L,1237L,1297L,1321L,1549L,1657L,1693L,1753L,2017L,2029L,2089L,2137L,2221L,2281L,2521L,2917L,3037L,3049L,3181L,3217L,3229L,3433L,3469L,3541L,3697L,3877L,4093L,4177L,4549L,4597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107193Inst : IEnumerable<long>
{
public static readonly long[] Value=A107193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107193.Bytes);
public long this[int i]=>Value[i];

public static A107193Inst Instance=new A107193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107194
{
public static readonly long[] Value={ 2L,41L,43L,59L,73L,113L,139L,241L,283L,379L,401L,419L,433L,467L,491L,569L,619L,761L,881L,947L,1009L,1033L,1091L,1097L,1123L,1153L,1187L,1193L,1291L,1427L,1499L,1609L,1619L,1721L,1723L,1747L,1907L,1993L,2011L,2017L,2027L,2081L,2083L,2089L,2137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107194Inst : IEnumerable<long>
{
public static readonly long[] Value=A107194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107194.Bytes);
public long this[int i]=>Value[i];

public static A107194Inst Instance=new A107194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107195
{
public static readonly long[] Value={ 7L,19L,199L,223L,283L,307L,367L,439L,607L,643L,859L,1039L,1231L,1279L,1291L,1459L,1483L,1543L,1627L,1951L,2131L,2203L,2371L,2383L,2539L,2707L,2719L,2791L,3079L,3499L,3547L,3643L,3727L,3919L,4003L,4051L,4231L,4339L,4423L,4483L,4507L,4567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107195Inst : IEnumerable<long>
{
public static readonly long[] Value=A107195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107195.Bytes);
public long this[int i]=>Value[i];

public static A107195Inst Instance=new A107195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107196
{
public static readonly long[] Value={ 37L,193L,277L,421L,541L,673L,1009L,1033L,1093L,1129L,1201L,1213L,1429L,1549L,1621L,1789L,1801L,2053L,2137L,2377L,2473L,2521L,2557L,2689L,2797L,2857L,3217L,3229L,3301L,3529L,3613L,3637L,3697L,3733L,3889L,4201L,4621L,4657L,4729L,4789L,4813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107196Inst : IEnumerable<long>
{
public static readonly long[] Value=A107196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107196.Bytes);
public long this[int i]=>Value[i];

public static A107196Inst Instance=new A107196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107197
{
public static readonly long[] Value={ 3L,31L,103L,139L,271L,523L,619L,691L,727L,787L,811L,1063L,1123L,1399L,1447L,1531L,1567L,1699L,1783L,1867L,1879L,1987L,2239L,2287L,2467L,2551L,2659L,2803L,2887L,2971L,3163L,3307L,3331L,3391L,3463L,3559L,3583L,3631L,3967L,4219L,4591L,4639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107197Inst : IEnumerable<long>
{
public static readonly long[] Value=A107197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107197.Bytes);
public long this[int i]=>Value[i];

public static A107197Inst Instance=new A107197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107198
{
public static readonly long[] Value={ 109L,337L,373L,457L,613L,709L,757L,877L,1117L,1297L,1381L,1453L,1597L,1873L,1933L,2017L,2221L,2269L,2293L,2389L,2437L,2713L,3049L,3061L,3109L,3313L,3361L,3469L,4057L,4153L,4561L,4909L,4957L,5077L,5233L,5413L,5569L,5581L,5737L,5821L,6217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107198Inst : IEnumerable<long>
{
public static readonly long[] Value=A107198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107198.Bytes);
public long this[int i]=>Value[i];

public static A107198Inst Instance=new A107198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107199
{
public static readonly long[] Value={ 5L,17L,37L,73L,97L,113L,173L,193L,197L,233L,277L,313L,317L,337L,397L,617L,653L,673L,677L,853L,857L,877L,997L,1013L,1093L,1117L,1153L,1193L,1213L,1217L,1297L,1433L,1493L,1553L,1637L,1693L,1697L,1873L,1877L,1933L,2017L,2113L,2137L,2153L,2213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107199Inst : IEnumerable<long>
{
public static readonly long[] Value=A107199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107199.Bytes);
public long this[int i]=>Value[i];

public static A107199Inst Instance=new A107199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107200
{
public static readonly long[] Value={ 2L,43L,61L,331L,389L,419L,587L,691L,1093L,1109L,1187L,1237L,1637L,1723L,2069L,2179L,2221L,2269L,2309L,2557L,2699L,2837L,3253L,3259L,3491L,3533L,3571L,3581L,3821L,3907L,4093L,4259L,4283L,4451L,4603L,4651L,4733L,5051L,5189L,5387L,5531L,5653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107200Inst : IEnumerable<long>
{
public static readonly long[] Value=A107200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107200.Bytes);
public long this[int i]=>Value[i];

public static A107200Inst Instance=new A107200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107201
{
public static readonly long[] Value={ 11L,19L,43L,83L,107L,131L,139L,211L,227L,283L,307L,347L,491L,523L,547L,563L,571L,659L,739L,787L,811L,827L,1019L,1051L,1091L,1163L,1187L,1283L,1427L,1451L,1459L,1531L,1579L,1619L,1627L,1667L,1723L,1811L,1867L,1931L,1979L,1987L,2131L,2243L,2251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107201Inst : IEnumerable<long>
{
public static readonly long[] Value=A107201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107201.Bytes);
public long this[int i]=>Value[i];

public static A107201Inst Instance=new A107201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107202
{
public static readonly long[] Value={ 89L,97L,113L,137L,257L,313L,353L,401L,433L,449L,521L,577L,617L,641L,881L,929L,977L,1049L,1153L,1193L,1321L,1409L,1433L,1489L,1609L,1697L,1721L,1753L,1873L,2017L,2113L,2137L,2161L,2281L,2297L,2377L,2473L,2633L,2689L,2729L,2753L,2777L,2897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107202Inst : IEnumerable<long>
{
public static readonly long[] Value=A107202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107202.Bytes);
public long this[int i]=>Value[i];

public static A107202Inst Instance=new A107202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107203
{
public static readonly long[] Value={ 19L,241L,331L,499L,571L,601L,691L,739L,769L,1009L,1129L,1249L,1291L,1531L,1579L,1699L,2011L,2089L,2131L,2161L,2521L,2689L,2731L,2851L,2971L,3001L,3049L,3259L,3331L,3499L,3691L,3739L,3889L,4051L,4129L,4219L,4339L,4441L,4561L,4729L,4801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107203Inst : IEnumerable<long>
{
public static readonly long[] Value=A107203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107203.Bytes);
public long this[int i]=>Value[i];

public static A107203Inst Instance=new A107203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107204
{
public static readonly long[] Value={ 5L,23L,167L,197L,263L,293L,317L,653L,677L,773L,863L,887L,1277L,1487L,1493L,1583L,1607L,1733L,1823L,1877L,1997L,2063L,2423L,2663L,2687L,2837L,2903L,2957L,3023L,3167L,3413L,3527L,3533L,3623L,3797L,4007L,4133L,4373L,4397L,4493L,4583L,4733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107204Inst : IEnumerable<long>
{
public static readonly long[] Value=A107204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107204.Bytes);
public long this[int i]=>Value[i];

public static A107204Inst Instance=new A107204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107205
{
public static readonly long[] Value={ 2L,47L,53L,173L,383L,503L,557L,647L,743L,797L,983L,1013L,1103L,1223L,1367L,1373L,1613L,1637L,1847L,1973L,2087L,2207L,2213L,2237L,2333L,2357L,2447L,2477L,2543L,2693L,2927L,3407L,3557L,3677L,3767L,3863L,3917L,4013L,4127L,4157L,4253L,4463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107205Inst : IEnumerable<long>
{
public static readonly long[] Value=A107205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107205.Bytes);
public long this[int i]=>Value[i];

public static A107205Inst Instance=new A107205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107206
{
public static readonly long[] Value={ 139L,211L,379L,409L,619L,811L,859L,1051L,1171L,1201L,1321L,1459L,1489L,1609L,1801L,2179L,2251L,2281L,2371L,2539L,2659L,3019L,3121L,3169L,3361L,3529L,3571L,3769L,3931L,4099L,4201L,4651L,5059L,5419L,5449L,5641L,5689L,5779L,5851L,5881L,6091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107206Inst : IEnumerable<long>
{
public static readonly long[] Value=A107206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107206.Bytes);
public long this[int i]=>Value[i];

public static A107206Inst Instance=new A107206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107207
{
public static readonly long[] Value={ 7L,13L,41L,59L,227L,229L,271L,353L,383L,461L,577L,619L,643L,773L,811L,839L,1021L,1307L,1399L,1489L,1601L,1627L,1697L,1753L,1783L,1867L,1879L,2273L,2281L,2309L,2579L,2593L,2719L,2897L,2917L,2953L,3037L,3323L,3359L,3373L,3391L,3671L,3853L,3911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107207Inst : IEnumerable<long>
{
public static readonly long[] Value=A107207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107207.Bytes);
public long this[int i]=>Value[i];

public static A107207Inst Instance=new A107207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107208
{
public static readonly long[] Value={ 23L,59L,167L,211L,223L,271L,307L,347L,463L,599L,607L,691L,719L,883L,991L,1151L,1163L,1231L,1319L,1451L,1787L,1867L,1871L,1879L,2027L,2143L,2339L,2347L,2423L,2539L,2647L,2707L,2819L,2879L,2887L,2927L,2939L,3019L,3307L,3343L,3359L,3463L,3491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107208Inst : IEnumerable<long>
{
public static readonly long[] Value=A107208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107208.Bytes);
public long this[int i]=>Value[i];

public static A107208Inst Instance=new A107208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107209
{
public static readonly long[] Value={ 101L,173L,317L,449L,593L,809L,821L,829L,853L,877L,997L,1097L,1117L,1181L,1453L,1481L,1553L,1613L,1669L,1697L,1789L,1889L,1913L,2053L,2309L,2381L,2393L,2677L,2693L,2741L,2969L,3037L,3229L,3313L,3361L,3389L,3433L,3617L,3637L,3673L,3821L,3853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107209Inst : IEnumerable<long>
{
public static readonly long[] Value=A107209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107209.Bytes);
public long this[int i]=>Value[i];

public static A107209Inst Instance=new A107209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107210
{
public static readonly long[] Value={ 3L,31L,43L,79L,127L,139L,151L,199L,223L,271L,331L,367L,463L,487L,499L,523L,571L,619L,631L,643L,739L,787L,823L,859L,883L,967L,991L,1171L,1231L,1447L,1483L,1531L,1543L,1567L,1579L,1627L,1747L,1759L,1951L,1987L,1999L,2011L,2083L,2131L,2287L,2311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107210Inst : IEnumerable<long>
{
public static readonly long[] Value=A107210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107210.Bytes);
public long this[int i]=>Value[i];

public static A107210Inst Instance=new A107210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107211
{
public static readonly long[] Value={ 2L,47L,79L,97L,431L,439L,521L,761L,769L,929L,1193L,1223L,1297L,1303L,1399L,1481L,1567L,1753L,1823L,1847L,2143L,2311L,2503L,2591L,2633L,2753L,2857L,3089L,3271L,3361L,3623L,3761L,3767L,3919L,4007L,4049L,4217L,4481L,4703L,5407L,5503L,5689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107211Inst : IEnumerable<long>
{
public static readonly long[] Value=A107211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107211.Bytes);
public long this[int i]=>Value[i];

public static A107211Inst Instance=new A107211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107212
{
public static readonly long[] Value={ 3L,59L,107L,131L,179L,491L,587L,659L,827L,947L,1019L,1163L,1187L,1307L,1451L,1571L,1619L,1667L,1811L,1907L,1931L,2003L,2099L,2243L,2411L,2699L,3011L,3203L,3299L,3323L,3347L,3371L,3779L,3803L,3923L,3947L,4019L,4091L,4139L,4283L,4451L,4523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107212Inst : IEnumerable<long>
{
public static readonly long[] Value=A107212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107212.Bytes);
public long this[int i]=>Value[i];

public static A107212Inst Instance=new A107212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107213
{
public static readonly long[] Value={ 97L,409L,433L,457L,673L,937L,1009L,1033L,1153L,1321L,1489L,1609L,1657L,1753L,1777L,2089L,2161L,2377L,2521L,2593L,2689L,2713L,3121L,3217L,3361L,3457L,3673L,3769L,3889L,4297L,4561L,4729L,4801L,4993L,5209L,5233L,5857L,5881L,6073L,6121L,6337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107213Inst : IEnumerable<long>
{
public static readonly long[] Value=A107213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107213.Bytes);
public long this[int i]=>Value[i];

public static A107213Inst Instance=new A107213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107214
{
public static readonly long[] Value={ 2L,67L,211L,337L,443L,449L,491L,499L,569L,641L,683L,953L,1019L,1163L,1201L,1297L,1409L,1499L,1873L,2377L,2473L,2683L,2689L,2753L,2851L,3049L,3329L,3803L,4001L,4019L,4099L,4139L,4201L,4211L,4481L,4547L,4657L,4673L,4691L,4937L,4993L,5441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107214Inst : IEnumerable<long>
{
public static readonly long[] Value=A107214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107214.Bytes);
public long this[int i]=>Value[i];

public static A107214Inst Instance=new A107214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107215
{
public static readonly long[] Value={ 107L,179L,401L,617L,827L,883L,907L,1051L,1171L,1187L,1481L,1619L,1723L,1913L,2251L,2297L,2417L,2459L,2531L,2657L,2699L,2731L,3089L,3347L,3529L,3539L,3593L,3691L,3697L,3889L,3907L,4057L,4153L,4363L,4603L,4817L,5051L,5107L,5153L,5209L,5531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107215Inst : IEnumerable<long>
{
public static readonly long[] Value=A107215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107215.Bytes);
public long this[int i]=>Value[i];

public static A107215Inst Instance=new A107215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107216
{
public static readonly long[] Value={ 11L,47L,53L,257L,269L,311L,401L,419L,587L,599L,617L,683L,773L,863L,911L,929L,1109L,1181L,1307L,1367L,1433L,1439L,1571L,1697L,1907L,2003L,2039L,2069L,2237L,2381L,2579L,2621L,2729L,2777L,2843L,2897L,2927L,3041L,3191L,3257L,3323L,3623L,3677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107216Inst : IEnumerable<long>
{
public static readonly long[] Value=A107216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107216.Bytes);
public long this[int i]=>Value[i];

public static A107216Inst Instance=new A107216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107217
{
public static readonly long[] Value={ 103L,163L,199L,397L,421L,499L,757L,883L,907L,991L,1021L,1087L,1123L,1237L,1291L,1543L,1567L,1609L,1621L,1699L,1753L,1873L,2113L,2539L,2671L,2731L,2797L,2803L,2953L,3259L,3391L,3433L,3463L,3499L,3613L,3631L,3733L,3793L,3853L,3877L,3919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107217Inst : IEnumerable<long>
{
public static readonly long[] Value=A107217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107217.Bytes);
public long this[int i]=>Value[i];

public static A107217Inst Instance=new A107217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107218
{
public static readonly long[] Value={ 29L,41L,61L,89L,229L,241L,281L,349L,421L,509L,601L,641L,661L,701L,709L,769L,809L,821L,881L,1009L,1049L,1109L,1181L,1201L,1229L,1249L,1289L,1301L,1321L,1381L,1409L,1481L,1549L,1669L,1709L,1789L,1801L,1901L,2029L,2069L,2089L,2141L,2161L,2221L,2281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107218Inst : IEnumerable<long>
{
public static readonly long[] Value=A107218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107218.Bytes);
public long this[int i]=>Value[i];

public static A107218Inst Instance=new A107218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107219
{
public static readonly long[] Value={ 101L,109L,149L,181L,269L,389L,401L,409L,449L,461L,521L,541L,569L,761L,829L,929L,941L,1021L,1061L,1069L,1129L,1361L,1429L,1489L,1601L,1609L,1621L,1721L,1741L,1861L,1889L,1949L,2081L,2129L,2269L,2309L,2441L,2549L,2609L,2621L,2689L,2749L,2789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107219Inst : IEnumerable<long>
{
public static readonly long[] Value=A107219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107219.Bytes);
public long this[int i]=>Value[i];

public static A107219Inst Instance=new A107219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107220
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,23L,27L,31L,37L,63L,69L,117L,119L,173L,219L,223L,247L,307L,363L,383L,495L,695L,987L,2519L,3919L,4633L,6537L,8881L,12841L,15935L,16383L,16519L,26525L,34415L,95139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107220Inst : IEnumerable<long>
{
public static readonly long[] Value=A107220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107220.Bytes);
public long this[int i]=>Value[i];

public static A107220Inst Instance=new A107220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107221
{
public static readonly long[] Value={ 124L,142L,214L,241L,412L,421L,1222L,2122L,2212L,2221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107221Inst : IEnumerable<long>
{
public static readonly long[] Value=A107221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107221.Bytes);
public long this[int i]=>Value[i];

public static A107221Inst Instance=new A107221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107222
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,7L,7L,19L,29L,87L,52L,315L,291L,562L,1017L,3825L,2870L,13797L,11255L,23579L,59986L,178259L,103680L,607522L,859849L,1551227L,1815045L,9203747L,5505966L,28629151L,33552327L,78899078L,167112969L,333342388L,267841392L,1848954877L,2411186731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107222Inst : IEnumerable<long>
{
public static readonly long[] Value=A107222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107222.Bytes);
public long this[int i]=>Value[i];

public static A107222Inst Instance=new A107222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107223
{
public static readonly long[] Value={ 9L,18L,28L,37L,47L,56L,65L,78L,87L,97L,106L,116L,125L,135L,147L,157L,166L,175L,185L,194L,204L,216L,226L,235L,245L,254L,263L,273L,285L,295L,304L,314L,323L,333L,342L,354L,364L,373L,383L,392L,402L,411L,424L,433L,442L,452L,461L,471L,480L,493L,502L,512L,521L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107223Inst : IEnumerable<long>
{
public static readonly long[] Value=A107223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107223.Bytes);
public long this[int i]=>Value[i];

public static A107223Inst Instance=new A107223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107224
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,12L,13L,14L,16L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,30L,32L,33L,38L,40L,48L,50L,51L,52L,53L,55L,56L,58L,59L,60L,61L,62L,64L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,87L,88L,89L,90L,92L,93L,94L,95L,96L,98L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107224Inst : IEnumerable<long>
{
public static readonly long[] Value=A107224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107224.Bytes);
public long this[int i]=>Value[i];

public static A107224Inst Instance=new A107224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107225
{
public static readonly long[] Value={ 2L,7L,8L,9L,10L,11L,15L,23L,29L,31L,34L,35L,36L,37L,39L,41L,42L,43L,44L,45L,46L,47L,49L,54L,57L,63L,65L,86L,91L,97L,99L,120L,123L,125L,130L,131L,132L,133L,134L,138L,144L,145L,146L,147L,149L,151L,152L,153L,154L,155L,156L,157L,159L,164L,165L,167L,172L,173L,174L,175L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107225Inst : IEnumerable<long>
{
public static readonly long[] Value=A107225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107225.Bytes);
public long this[int i]=>Value[i];

public static A107225Inst Instance=new A107225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107226
{
public static readonly long[] Value={ 7L,9L,11L,15L,23L,29L,35L,37L,39L,46L,47L,54L,57L,63L,86L,91L,97L,120L,123L,130L,132L,134L,138L,145L,147L,149L,156L,157L,164L,165L,172L,174L,176L,182L,184L,192L,194L,196L,199L,206L,208L,210L,214L,222L,228L,235L,241L,264L,267L,274L,276L,278L,282L,298L,332L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107226Inst : IEnumerable<long>
{
public static readonly long[] Value=A107226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107226.Bytes);
public long this[int i]=>Value[i];

public static A107226Inst Instance=new A107226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107227
{
public static readonly long[] Value={ 2L,8L,10L,34L,36L,42L,44L,144L,146L,152L,154L,178L,180L,186L,188L,610L,612L,618L,620L,644L,646L,652L,654L,754L,756L,762L,764L,788L,790L,796L,798L,2584L,2586L,2592L,2594L,2618L,2620L,2626L,2628L,2728L,2730L,2736L,2738L,2762L,2764L,2770L,2772L,3194L,3196L,3202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107227Inst : IEnumerable<long>
{
public static readonly long[] Value=A107227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107227.Bytes);
public long this[int i]=>Value[i];

public static A107227Inst Instance=new A107227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107228
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,13L,14L,16L,17L,18L,19L,21L,22L,24L,25L,26L,27L,55L,56L,58L,59L,60L,61L,68L,69L,71L,72L,73L,74L,76L,77L,79L,80L,81L,82L,89L,90L,92L,93L,94L,95L,102L,103L,105L,106L,107L,108L,110L,111L,113L,114L,115L,116L,233L,234L,236L,237L,238L,239L,246L,247L,249L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107228Inst : IEnumerable<long>
{
public static readonly long[] Value=A107228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107228.Bytes);
public long this[int i]=>Value[i];

public static A107228Inst Instance=new A107228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107229
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,11L,9L,7L,73L,59L,181L,483L,657L,1871L,3729L,7027L,16813L,32699L,68761L,149463L,301017L,642731L,1349349L,2790547L,5912353L,12327839L,25777441L,54217443L,113194077L,237322091L,497475369L,1040614567L,2181561193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107229Inst : IEnumerable<long>
{
public static readonly long[] Value=A107229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107229.Bytes);
public long this[int i]=>Value[i];

public static A107229Inst Instance=new A107229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107230
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,6L,3L,1L,6L,12L,12L,4L,1L,10L,30L,30L,20L,5L,1L,20L,60L,90L,60L,30L,6L,1L,35L,140L,210L,210L,105L,42L,7L,1L,70L,280L,560L,560L,420L,168L,56L,8L,1L,126L,630L,1260L,1680L,1260L,756L,252L,72L,9L,1L,252L,1260L,3150L,4200L,4200L,2520L,1260L,360L,90L,10L,1L,462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107230Inst : IEnumerable<long>
{
public static readonly long[] Value=A107230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107230.Bytes);
public long this[int i]=>Value[i];

public static A107230Inst Instance=new A107230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107231
{
public static readonly long[] Value={ 1L,3L,12L,30L,90L,210L,560L,1260L,3150L,6930L,16632L,36036L,84084L,180180L,411840L,875160L,1969110L,4157010L,9237800L,19399380L,42678636L,89237148L,194699232L,405623400L,878850700L,1825305300L,3931426800L,8143669800L,17450721000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107231Inst : IEnumerable<long>
{
public static readonly long[] Value=A107231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107231.Bytes);
public long this[int i]=>Value[i];

public static A107231Inst Instance=new A107231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107232
{
public static readonly long[] Value={ 1L,3L,5L,10L,18L,35L,65L,126L,238L,462L,882L,1716L,3300L,6435L,12441L,24310L,47190L,92378L,179894L,352716L,688636L,1352078L,2645370L,5200300L,10192588L,20058300L,39373700L,77558760L,152443080L,300540195L,591385545L,1166803110L,2298248550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107232Inst : IEnumerable<long>
{
public static readonly long[] Value=A107232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107232.Bytes);
public long this[int i]=>Value[i];

public static A107232Inst Instance=new A107232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107233
{
public static readonly long[] Value={ 0L,1L,8L,30L,96L,270L,720L,1820L,4480L,10710L,25200L,58212L,133056L,300300L,672672L,1492920L,3294720L,7220070L,15752880L,34179860L,73902400L,159074916L,341429088L,730122120L,1557593856L,3312591100L,7030805600L,14883258600L,31451414400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107233Inst : IEnumerable<long>
{
public static readonly long[] Value=A107233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107233.Bytes);
public long this[int i]=>Value[i];

public static A107233Inst Instance=new A107233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107234
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,8L,10L,14L,18L,23L,29L,38L,47L,60L,74L,92L,112L,139L,168L,205L,247L,298L,356L,429L,509L,607L,718L,850L,1000L,1180L,1381L,1620L,1890L,2206L,2564L,2983L,3453L,4000L,4618L,5330L,6133L,7059L,8097L,9289L,10630L,12159L,13877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107234Inst : IEnumerable<long>
{
public static readonly long[] Value=A107234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107234.Bytes);
public long this[int i]=>Value[i];

public static A107234Inst Instance=new A107234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107235
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,7L,8L,12L,14L,19L,23L,31L,37L,48L,57L,73L,86L,109L,128L,159L,187L,229L,269L,326L,382L,458L,535L,638L,742L,879L,1019L,1200L,1388L,1625L,1875L,2185L,2514L,2916L,3347L,3868L,4427L,5099L,5822L,6683L,7614L,8712L,9904L,11301L,12821L,14589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107235Inst : IEnumerable<long>
{
public static readonly long[] Value=A107235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107235.Bytes);
public long this[int i]=>Value[i];

public static A107235Inst Instance=new A107235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107236
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,5L,6L,8L,11L,13L,16L,22L,26L,32L,40L,49L,59L,73L,87L,105L,126L,151L,178L,214L,252L,297L,351L,413L,481L,566L,658L,767L,892L,1034L,1195L,1386L,1595L,1838L,2114L,2429L,2781L,3189L,3642L,4160L,4744L,5404L,6141L,6986L,7921L,8980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107236Inst : IEnumerable<long>
{
public static readonly long[] Value=A107236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107236.Bytes);
public long this[int i]=>Value[i];

public static A107236Inst Instance=new A107236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107237
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,3L,3L,5L,5L,7L,8L,12L,12L,17L,19L,26L,28L,37L,41L,53L,60L,74L,84L,105L,118L,144L,164L,198L,224L,269L,305L,362L,411L,484L,550L,645L,729L,850L,964L,1117L,1262L,1458L,1647L,1894L,2137L,2446L,2757L,3150L,3542L,4031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107237Inst : IEnumerable<long>
{
public static readonly long[] Value=A107237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107237.Bytes);
public long this[int i]=>Value[i];

public static A107237Inst Instance=new A107237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107238
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,8L,4L,1L,0L,5L,15L,15L,5L,1L,0L,6L,27L,36L,24L,6L,1L,0L,7L,42L,84L,70L,35L,7L,1L,0L,8L,64L,160L,200L,120L,48L,8L,1L,0L,9L,90L,300L,450L,405L,189L,63L,9L,1L,0L,10L,125L,500L,1000L,1050L,735L,280L,80L,10L,1L,0L,11L,165L,825L,1925L,2695L,2156L,1232L,396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107238Inst : IEnumerable<long>
{
public static readonly long[] Value=A107238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107238.Bytes);
public long this[int i]=>Value[i];

public static A107238Inst Instance=new A107238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107239
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,22L,71L,240L,816L,2752L,9313L,31514L,106590L,360606L,1219935L,4126960L,13961456L,47231280L,159782161L,540539330L,1828631430L,6186215574L,20927817799L,70798300288L,239508933824L,810252920400L,2741065994769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107239Inst : IEnumerable<long>
{
public static readonly long[] Value=A107239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107239.Bytes);
public long this[int i]=>Value[i];

public static A107239Inst Instance=new A107239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107240
{
public static readonly long[] Value={ 1L,2L,3L,12L,37L,118L,407L,1368L,4617L,15642L,52891L,178916L,605325L,2047726L,6927407L,23435376L,79281105L,268206130L,907335091L,3069492092L,10384017717L,35128880742L,118840150983L,402033352264L,1360069089113L,4601080768074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107240Inst : IEnumerable<long>
{
public static readonly long[] Value=A107240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107240.Bytes);
public long this[int i]=>Value[i];

public static A107240Inst Instance=new A107240Inst();

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