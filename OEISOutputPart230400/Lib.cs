using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286249
{
public static readonly long[] Value={ 1L,3L,2L,3L,0L,4L,10L,5L,0L,7L,3L,0L,0L,0L,11L,21L,5L,8L,0L,0L,16L,3L,0L,0L,0L,0L,0L,22L,36L,14L,0L,12L,0L,0L,0L,29L,10L,0L,8L,0L,0L,0L,0L,0L,37L,21L,5L,0L,0L,17L,0L,0L,0L,0L,46L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,56L,78L,27L,19L,12L,0L,23L,0L,0L,0L,0L,0L,67L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,79L,21L,5L,0L,0L,0L,0L,30L,0L,0L,0L,0L,0L,0L,92L,21L,0L,8L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,0L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286249Inst : IEnumerable<long>
{
public static readonly long[] Value=A286249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286249.Bytes);
public long this[int i]=>Value[i];

public static A286249Inst Instance=new A286249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286250
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,2L,6L,2L,4L,6L,2L,2L,2L,6L,12L,6L,8L,2L,2L,2L,2L,16L,2L,6L,4L,6L,6L,2L,2L,30L,12L,6L,6L,4L,12L,6L,6L,6L,6L,6L,2L,2L,6L,6L,30L,2L,6L,2L,6L,6L,2L,6L,2L,6L,6L,6L,6L,2L,6L,6L,2L,12L,2L,36L,2L,6L,4L,2L,12L,30L,12L,12L,2L,12L,2L,24L,2L,2L,6L,6L,24L,2L,2L,12L,2L,24L,12L,2L,2L,30L,30L,6L,6L,2L,2L,4L,6L,2L,30L,6L,32L,2L,6L,2L,6L,2L,6L,12L,4L,2L,30L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286250Inst : IEnumerable<long>
{
public static readonly long[] Value=A286250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286250.Bytes);
public long this[int i]=>Value[i];

public static A286250Inst Instance=new A286250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286251
{
public static readonly long[] Value={ 3L,2L,9L,7L,5L,16L,14L,29L,12L,16L,9L,67L,5L,16L,50L,121L,5L,67L,9L,67L,23L,16L,14L,277L,12L,16L,48L,67L,5L,436L,27L,497L,23L,16L,31L,631L,5L,16L,40L,277L,5L,436L,9L,67L,80L,16L,20L,1129L,12L,67L,31L,67L,5L,277L,40L,277L,23L,16L,9L,1771L,5L,16L,160L,2017L,23L,436L,9L,67L,23L,436L,14L,2557L,5L,16L,94L,67L,23L,436L,20L,1129L,138L,16L,9L,1771L,23L,16L,40L,277L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286251Inst : IEnumerable<long>
{
public static readonly long[] Value=A286251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286251.Bytes);
public long this[int i]=>Value[i];

public static A286251Inst Instance=new A286251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286252
{
public static readonly long[] Value={ 1L,5L,2L,18L,2L,23L,7L,59L,2L,23L,16L,94L,7L,80L,29L,195L,2L,23L,16L,94L,16L,467L,67L,355L,7L,80L,67L,706L,29L,302L,121L,672L,2L,23L,16L,94L,16L,467L,67L,355L,16L,467L,436L,1894L,67L,1832L,277L,1331L,7L,80L,67L,706L,67L,1832L,631L,2779L,29L,302L,277L,2704L,121L,1178L,497L,2422L,2L,23L,16L,94L,16L,467L,67L,355L,16L,467L,436L,1894L,67L,1832L,277L,1331L,16L,467L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286252Inst : IEnumerable<long>
{
public static readonly long[] Value=A286252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286252.Bytes);
public long this[int i]=>Value[i];

public static A286252Inst Instance=new A286252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286253
{
public static readonly long[] Value={ 0L,1L,8L,1L,9L,1L,25L,1L,5L,1L,26L,1L,27L,1L,17L,1L,35L,1L,53L,1L,5L,1L,75L,1L,9L,1L,8L,1L,65L,1L,131L,1L,5L,1L,13L,1L,90L,1L,12L,1L,104L,1L,134L,1L,5L,1L,186L,1L,14L,1L,8L,1L,152L,1L,18L,1L,5L,1L,188L,1L,189L,1L,30L,1L,9L,1L,229L,1L,5L,1L,273L,1L,252L,1L,8L,1L,14L,1L,347L,1L,5L,1L,323L,1L,9L,1L,12L,1L,324L,1L,19L,1L,5L,1L,31L,1L,350L,1L,8L,1L,377L,1L,462L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286253Inst : IEnumerable<long>
{
public static readonly long[] Value=A286253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286253.Bytes);
public long this[int i]=>Value[i];

public static A286253Inst Instance=new A286253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286254
{
public static readonly long[] Value={ 1L,5L,1L,13L,1L,12L,1L,14L,1L,17L,1L,31L,1L,5L,1L,60L,1L,38L,1L,9L,1L,47L,1L,19L,1L,5L,1L,69L,1L,68L,1L,27L,1L,8L,1L,94L,1L,5L,1L,124L,1L,107L,1L,9L,1L,122L,1L,33L,1L,5L,1L,156L,1L,8L,1L,14L,1L,155L,1L,193L,1L,5L,1L,43L,1L,192L,1L,9L,1L,212L,1L,280L,1L,5L,1L,18L,1L,255L,1L,20L,1L,278L,1L,13L,1L,5L,1L,355L,1L,12L,1L,9L,1L,8L,1L,441L,1L,5L,1L,381L,1L,380L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286254Inst : IEnumerable<long>
{
public static readonly long[] Value=A286254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286254.Bytes);
public long this[int i]=>Value[i];

public static A286254Inst Instance=new A286254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286255
{
public static readonly long[] Value={ 2L,5L,12L,14L,23L,27L,38L,63L,40L,27L,80L,90L,23L,61L,216L,152L,80L,90L,80L,148L,61L,27L,302L,375L,40L,84L,179L,90L,467L,495L,530L,698L,61L,61L,826L,702L,23L,61L,412L,324L,467L,495L,80L,265L,148L,27L,1178L,1323L,109L,148L,142L,90L,302L,430L,412L,430L,61L,27L,1832L,1890L,23L,142L,2787L,2410L,601L,495L,80L,148L,601L,495L,2630L,2700L,23L,142L,265L,148L,601L,495L,1178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286255Inst : IEnumerable<long>
{
public static readonly long[] Value=A286255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286255.Bytes);
public long this[int i]=>Value[i];

public static A286255Inst Instance=new A286255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286256
{
public static readonly long[] Value={ 2L,12L,5L,40L,5L,84L,12L,86L,14L,142L,5L,148L,23L,216L,27L,367L,5L,265L,23L,148L,27L,412L,12L,430L,59L,142L,44L,832L,5L,1860L,23L,698L,61L,826L,27L,856L,23L,412L,27L,1402L,5L,850L,80L,148L,90L,1384L,12L,1759L,40L,265L,27L,607L,23L,1105L,61L,430L,27L,2086L,5L,2140L,80L,2352L,148L,4342L,27L,850L,23L,832L,27L,5080L,5L,2998L,80L,142L,148L,832L,27L,2956L,138L,1426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286256Inst : IEnumerable<long>
{
public static readonly long[] Value=A286256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286256.Bytes);
public long this[int i]=>Value[i];

public static A286256Inst Instance=new A286256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286257
{
public static readonly long[] Value={ 1L,5L,5L,14L,12L,27L,5L,86L,14L,27L,23L,90L,12L,84L,27L,152L,23L,148L,5L,148L,27L,27L,80L,324L,25L,61L,44L,148L,23L,495L,5L,935L,61L,27L,61L,702L,5L,142L,61L,324L,138L,495L,23L,148L,90L,61L,23L,1426L,14L,265L,27L,90L,467L,324L,27L,430L,27L,61L,80L,2140L,12L,61L,183L,2144L,61L,495L,23L,607L,27L,495L,23L,2998L,23L,142L,90L,90L,142L,625L,5L,1426L,226L,27L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286257Inst : IEnumerable<long>
{
public static readonly long[] Value=A286257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286257.Bytes);
public long this[int i]=>Value[i];

public static A286257Inst Instance=new A286257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286258
{
public static readonly long[] Value={ 2L,5L,5L,25L,5L,27L,23L,44L,14L,61L,5L,117L,38L,27L,27L,226L,23L,90L,23L,90L,27L,142L,5L,375L,40L,27L,86L,148L,5L,495L,80L,698L,27L,61L,27L,702L,80L,61L,27L,765L,5L,625L,23L,90L,148L,61L,23L,1224L,109L,90L,27L,832L,5L,324L,61L,324L,61L,142L,23L,2013L,23L,84L,90L,2410L,27L,625L,302L,90L,27L,625L,23L,2998L,80L,27L,90L,265L,61L,495L,23L,1426L,152L,601L,5L,2013L,142L,27L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286258Inst : IEnumerable<long>
{
public static readonly long[] Value=A286258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286258.Bytes);
public long this[int i]=>Value[i];

public static A286258Inst Instance=new A286258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286259
{
public static readonly long[] Value={ 1L,2L,1L,6L,4L,5L,11L,25L,16L,23L,37L,31L,56L,57L,56L,110L,106L,80L,137L,123L,137L,173L,211L,175L,232L,255L,254L,279L,352L,255L,407L,471L,407L,467L,466L,409L,596L,597L,596L,599L,742L,597L,821L,783L,742L,905L,991L,866L,1036L,992L,1082L,1131L,1276L,1083L,1276L,1279L,1379L,1487L,1597L,1228L,1712L,1713L,1597L,1960L,1831L,1713L,2081L,2019L,2081L,1955L,2347L,1957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286259Inst : IEnumerable<long>
{
public static readonly long[] Value=A286259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286259.Bytes);
public long this[int i]=>Value[i];

public static A286259Inst Instance=new A286259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286260
{
public static readonly long[] Value={ 1L,8L,1L,39L,4L,8L,1L,157L,79L,47L,4L,39L,22L,8L,4L,600L,37L,782L,11L,256L,1L,47L,4L,157L,466L,233L,11L,39L,106L,47L,1L,2284L,4L,380L,4L,4281L,172L,122L,22L,1132L,211L,8L,56L,256L,742L,47L,4L,600L,1597L,4373L,37L,1278L,352L,122L,37L,157L,11L,1037L,106L,256L,466L,8L,79L,8785L,211L,47L,137L,2083L,4L,47L,37L,19507L,667L,1655L,466L,669L,4L,233L,11L,4661L,7261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286260Inst : IEnumerable<long>
{
public static readonly long[] Value=A286260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286260.Bytes);
public long this[int i]=>Value[i];

public static A286260Inst Instance=new A286260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286261
{
public static readonly long[] Value={ 7L,8L,14L,15L,16L,17L,23L,24L,28L,29L,30L,31L,32L,33L,34L,35L,39L,40L,42L,46L,47L,48L,49L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,78L,79L,80L,81L,84L,85L,87L,88L,92L,93L,94L,95L,96L,97L,98L,99L,103L,104L,106L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,125L,126L,127L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286261Inst : IEnumerable<long>
{
public static readonly long[] Value=A286261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286261.Bytes);
public long this[int i]=>Value[i];

public static A286261Inst Instance=new A286261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286262
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,13L,18L,19L,20L,21L,22L,25L,26L,27L,36L,37L,38L,41L,43L,44L,45L,50L,51L,52L,53L,54L,73L,74L,75L,76L,77L,82L,83L,86L,89L,90L,91L,100L,101L,102L,105L,107L,108L,109L,146L,147L,148L,150L,153L,154L,155L,164L,165L,166L,172L,173L,178L,179L,180L,181L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286262Inst : IEnumerable<long>
{
public static readonly long[] Value=A286262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286262.Bytes);
public long this[int i]=>Value[i];

public static A286262Inst Instance=new A286262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286455
{
public static readonly long[] Value={ 0L,2L,8L,2L,18L,11L,40L,2L,8L,22L,71L,11L,97L,46L,30L,2L,143L,11L,179L,22L,93L,92L,262L,11L,18L,121L,8L,46L,335L,154L,417L,2L,212L,211L,69L,11L,540L,254L,302L,22L,679L,326L,794L,92L,30L,379L,918L,11L,40L,22L,467L,121L,1051L,11L,234L,46L,530L,529L,1242L,154L,1344L,631L,93L,2L,744L,704L,1615L,211L,822L,326L,1790L,11L,1912L,904L,30L,254L,140L,947L,2167L,22L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286455Inst : IEnumerable<long>
{
public static readonly long[] Value=A286455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286455.Bytes);
public long this[int i]=>Value[i];

public static A286455Inst Instance=new A286455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286456
{
public static readonly long[] Value={ 0L,1L,5L,5L,13L,18L,25L,13L,19L,40L,41L,40L,61L,71L,41L,25L,85L,41L,113L,83L,72L,111L,145L,71L,42L,160L,42L,142L,181L,84L,221L,41L,112L,218L,73L,72L,265L,285L,161L,142L,313L,143L,365L,217L,85L,361L,421L,111L,74L,85L,219L,308L,481L,73L,113L,238L,286L,446L,545L,143L,613L,540L,144L,61L,162L,218L,685L,415L,362L,144L,761L,112L,841L,643L,86L,538L,114L,309L,925L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286456Inst : IEnumerable<long>
{
public static readonly long[] Value=A286456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286456.Bytes);
public long this[int i]=>Value[i];

public static A286456Inst Instance=new A286456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286457
{
public static readonly long[] Value={ 0L,1L,1L,5L,1L,13L,1L,25L,5L,41L,1L,61L,1L,85L,13L,113L,1L,145L,1L,181L,32L,221L,1L,265L,5L,313L,33L,365L,1L,421L,1L,481L,72L,545L,13L,613L,1L,685L,143L,761L,1L,841L,1L,925L,86L,1013L,1L,1105L,5L,1201L,219L,1301L,1L,1405L,32L,1513L,335L,1625L,1L,1741L,1L,1861L,201L,1985L,60L,2113L,1L,2245L,447L,2381L,1L,2521L,1L,2665L,223L,2813L,13L,2965L,1L,3121L,224L,3281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286457Inst : IEnumerable<long>
{
public static readonly long[] Value=A286457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286457.Bytes);
public long this[int i]=>Value[i];

public static A286457Inst Instance=new A286457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286458
{
public static readonly long[] Value={ 1L,1L,2L,3L,13L,25L,24L,15L,61L,5L,85L,113L,112L,64L,87L,55L,201L,243L,242L,313L,204L,393L,451L,513L,137L,22L,613L,250L,723L,651L,842L,276L,67L,844L,196L,1015L,1107L,657L,196L,1253L,1355L,1020L,1407L,559L,812L,795L,1744L,1864L,833L,2051L,1062L,101L,2181L,1363L,2384L,2524L,597L,2741L,2891L,3045L,3203L,1935L,1756L,1081L,1249L,1938L,3703L,1534L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286458Inst : IEnumerable<long>
{
public static readonly long[] Value=A286458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286458.Bytes);
public long this[int i]=>Value[i];

public static A286458Inst Instance=new A286458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286459
{
public static readonly long[] Value={ 1L,1L,2L,13L,3L,24L,85L,25L,112L,201L,5L,242L,61L,15L,451L,723L,64L,87L,842L,393L,1107L,1355L,113L,1407L,137L,22L,1744L,204L,844L,2181L,2891L,313L,67L,3203L,657L,3703L,4056L,243L,196L,4424L,55L,4908L,196L,795L,5521L,2384L,2741L,1062L,6507L,250L,7574L,8460L,651L,8590L,9122L,1935L,9393L,597L,559L,1249L,833L,1507L,613L,9391L,4155L,12492L,5949L,513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286459Inst : IEnumerable<long>
{
public static readonly long[] Value=A286459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286459.Bytes);
public long this[int i]=>Value[i];

public static A286459Inst Instance=new A286459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286460
{
public static readonly long[] Value={ 1L,8L,7L,39L,16L,80L,29L,157L,79L,173L,67L,438L,92L,302L,277L,600L,154L,782L,191L,949L,497L,668L,277L,1957L,466L,905L,781L,1656L,436L,2630L,497L,2284L,1129L,1487L,1129L,4281L,704L,1832L,1541L,4282L,862L,4658L,947L,3658L,3004L,2630L,1129L,8133L,1597L,4373L,2557L,4953L,1432L,7262L,2557L,7507L,3161L,4097L,1771L,14368L,1892L,4658L,5357L,8785L,3487L,10442L,2279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286460Inst : IEnumerable<long>
{
public static readonly long[] Value=A286460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286460.Bytes);
public long this[int i]=>Value[i];

public static A286460Inst Instance=new A286460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286461
{
public static readonly long[] Value={ 1L,5L,4L,9L,22L,5L,4L,32L,4L,5L,121L,9L,46L,437L,4L,20L,121L,17L,4L,24L,4L,5L,67L,14L,22L,17L,4L,24L,121L,5L,4L,2562L,211L,5L,121L,9L,4L,107L,121L,14L,7261L,5L,211L,24L,4L,17L,121L,41L,4L,2280L,4L,9L,254L,5L,4L,32L,4L,17L,67L,24L,22L,17L,631L,35L,121L,5L,121L,783L,4L,5L,121L,32L,211L,2280L,4L,9L,67L,17L,4L,41L,121L,5L,254L,9L,46L,2280L,4L,140L,121L,5L,4L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286461Inst : IEnumerable<long>
{
public static readonly long[] Value=A286461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286461.Bytes);
public long this[int i]=>Value[i];

public static A286461Inst Instance=new A286461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286462
{
public static readonly long[] Value={ 1L,1L,5L,1L,1L,5L,4L,1L,6L,1L,2L,5L,1L,4L,12L,1L,1L,6L,2L,1L,3L,2L,4L,5L,1L,1L,14L,4L,1L,12L,11L,1L,3L,1L,2L,6L,1L,2L,8L,1L,1L,3L,2L,2L,6L,4L,7L,5L,1L,1L,5L,1L,1L,14L,4L,4L,3L,1L,2L,12L,1L,11L,31L,1L,1L,3L,2L,1L,3L,2L,4L,6L,1L,1L,5L,2L,1L,8L,7L,1L,15L,1L,2L,3L,1L,2L,8L,2L,1L,6L,2L,4L,3L,7L,11L,5L,1L,1L,9L,1L,1L,5L,4L,1L,3L,1L,2L,14L,1L,4L,12L,4L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286462Inst : IEnumerable<long>
{
public static readonly long[] Value=A286462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286462.Bytes);
public long this[int i]=>Value[i];

public static A286462Inst Instance=new A286462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286463
{
public static readonly long[] Value={ 1L,2L,5L,7L,2L,23L,2L,29L,18L,16L,2L,80L,2L,16L,23L,121L,2L,94L,2L,67L,23L,16L,2L,302L,7L,16L,59L,67L,2L,467L,2L,497L,23L,16L,16L,706L,2L,16L,23L,277L,2L,467L,2L,67L,94L,16L,2L,1178L,7L,67L,23L,67L,2L,355L,16L,277L,23L,16L,2L,1832L,2L,16L,94L,2017L,16L,467L,2L,67L,23L,436L,2L,2704L,2L,16L,80L,67L,16L,467L,2L,1129L,195L,16L,2L,1832L,16L,16L,23L,277L,2L,1894L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286463Inst : IEnumerable<long>
{
public static readonly long[] Value=A286463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286463.Bytes);
public long this[int i]=>Value[i];

public static A286463Inst Instance=new A286463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286464
{
public static readonly long[] Value={ 2L,2L,12L,2L,16L,12L,29L,2L,31L,16L,67L,12L,67L,29L,138L,2L,16L,31L,67L,16L,467L,67L,277L,12L,67L,67L,745L,29L,277L,138L,497L,2L,23L,16L,67L,31L,436L,67L,302L,16L,436L,467L,1771L,67L,1894L,277L,1129L,12L,67L,67L,668L,67L,1771L,745L,2557L,29L,302L,277L,2557L,138L,1129L,497L,2148L,2L,16L,23L,67L,16L,467L,67L,277L,31L,436L,436L,1832L,67L,1771L,302L,1129L,16L,566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286464Inst : IEnumerable<long>
{
public static readonly long[] Value=A286464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286464.Bytes);
public long this[int i]=>Value[i];

public static A286464Inst Instance=new A286464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286465
{
public static readonly long[] Value={ 1L,2L,2L,5L,12L,2L,2L,23L,5L,2L,16L,9L,18L,29L,2L,5L,23L,16L,2L,23L,5L,2L,67L,9L,25L,16L,2L,23L,23L,2L,2L,80L,23L,2L,16L,14L,9L,67L,16L,5L,138L,2L,16L,23L,5L,16L,16L,31L,9L,67L,2L,5L,467L,2L,2L,23L,5L,16L,67L,40L,33L,16L,29L,5L,23L,2L,16L,302L,5L,2L,16L,31L,31L,67L,2L,5L,80L,16L,2L,23L,23L,2L,436L,9L,42L,67L,2L,80L,23L,2L,2L,23L,23L,16L,277L,14L,9L,436L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286465Inst : IEnumerable<long>
{
public static readonly long[] Value=A286465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286465.Bytes);
public long this[int i]=>Value[i];

public static A286465Inst Instance=new A286465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286466
{
public static readonly long[] Value={ 1L,2L,5L,12L,2L,16L,5L,38L,7L,16L,9L,94L,2L,16L,23L,138L,2L,67L,5L,80L,16L,16L,9L,355L,7L,16L,38L,80L,2L,436L,5L,530L,16L,16L,40L,706L,2L,16L,23L,302L,2L,436L,5L,80L,67L,16L,9L,1228L,7L,67L,23L,80L,2L,277L,23L,302L,16L,16L,14L,2021L,2L,16L,80L,2082L,16L,436L,5L,80L,16L,436L,9L,2704L,2L,16L,80L,80L,16L,436L,5L,1178L,121L,16L,9L,2086L,16L,16L,23L,302L,2L,1771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286466Inst : IEnumerable<long>
{
public static readonly long[] Value=A286466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286466.Bytes);
public long this[int i]=>Value[i];

public static A286466Inst Instance=new A286466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286467
{
public static readonly long[] Value={ 1L,3L,5L,9L,5L,19L,5L,33L,18L,25L,5L,51L,5L,25L,40L,73L,5L,72L,12L,84L,40L,25L,5L,128L,69L,25L,71L,84L,5L,180L,12L,146L,40L,25L,40L,242L,23L,40L,40L,198L,12L,180L,5L,177L,177L,40L,5L,337L,31L,216L,40L,84L,12L,284L,59L,308L,140L,40L,12L,478L,12L,40L,177L,339L,40L,180L,23L,177L,140L,387L,12L,610L,12L,59L,216L,177L,59L,309L,12L,540L,332L,40L,5L,608L,59L,40L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286467Inst : IEnumerable<long>
{
public static readonly long[] Value=A286467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286467.Bytes);
public long this[int i]=>Value[i];

public static A286467Inst Instance=new A286467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286468
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,3L,4L,4L,3L,1L,2L,6L,5L,9L,8L,8L,9L,5L,6L,2L,1L,3L,4L,12L,15L,7L,10L,18L,25L,27L,16L,16L,27L,25L,18L,10L,7L,15L,12L,4L,3L,1L,2L,6L,5L,9L,8L,24L,45L,35L,30L,14L,11L,21L,20L,36L,75L,49L,50L,54L,125L,81L,32L,32L,81L,125L,54L,50L,49L,75L,36L,20L,21L,11L,14L,30L,35L,45L,24L,8L,9L,5L,6L,2L,1L,3L,4L,12L,15L,7L,10L,18L,25L,27L,16L,48L,135L,175L,90L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286468Inst : IEnumerable<long>
{
public static readonly long[] Value=A286468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286468.Bytes);
public long this[int i]=>Value[i];

public static A286468Inst Instance=new A286468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286469
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,1L,4L,1L,2L,2L,5L,1L,6L,3L,2L,1L,7L,1L,8L,2L,2L,4L,9L,1L,3L,5L,2L,3L,10L,1L,11L,1L,3L,6L,3L,1L,12L,7L,4L,2L,13L,2L,14L,4L,2L,8L,15L,1L,4L,2L,5L,5L,16L,1L,3L,3L,6L,9L,17L,1L,18L,10L,2L,1L,3L,3L,19L,6L,7L,2L,20L,1L,21L,11L,2L,7L,4L,4L,22L,2L,2L,12L,23L,2L,4L,13L,8L,4L,24L,1L,4L,8L,9L,14L,5L,1L,25L,3L,3L,2L,26L,5L,27L,5L,2L,15L,28L,1L,29L,2L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286469Inst : IEnumerable<long>
{
public static readonly long[] Value=A286469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286469.Bytes);
public long this[int i]=>Value[i];

public static A286469Inst Instance=new A286469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286470
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,2L,0L,1L,0L,3L,1L,0L,0L,1L,0L,2L,2L,4L,0L,1L,0L,5L,0L,3L,0L,1L,0L,0L,3L,6L,1L,1L,0L,7L,4L,2L,0L,2L,0L,4L,1L,8L,0L,1L,0L,2L,5L,5L,0L,1L,2L,3L,6L,9L,0L,1L,0L,10L,2L,0L,3L,3L,0L,6L,7L,2L,0L,1L,0L,11L,1L,7L,1L,4L,0L,2L,0L,12L,0L,2L,4L,13L,8L,4L,0L,1L,2L,8L,9L,14L,5L,1L,0L,3L,3L,2L,0L,5L,0L,5L,1L,15L,0L,1L,0L,2L,10L,3L,0L,6L,6L,9L,4L,16L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286470Inst : IEnumerable<long>
{
public static readonly long[] Value=A286470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286470.Bytes);
public long this[int i]=>Value[i];

public static A286470Inst Instance=new A286470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286551
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,3L,5L,6L,7L,6L,8L,3L,2L,9L,10L,11L,12L,13L,14L,11L,15L,12L,16L,3L,6L,4L,6L,10L,5L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,19L,27L,20L,28L,21L,29L,26L,30L,3L,31L,11L,32L,6L,32L,11L,33L,17L,3L,9L,34L,35L,36L,37L,38L,27L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,27L,45L,54L,55L,40L,56L,57L,58L,42L,59L,60L,61L,52L,43L,62L,30L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286551Inst : IEnumerable<long>
{
public static readonly long[] Value=A286551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286551.Bytes);
public long this[int i]=>Value[i];

public static A286551Inst Instance=new A286551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286552
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,1L,4L,2L,3L,1L,3L,2L,2L,1L,5L,4L,5L,3L,6L,1L,4L,1L,4L,5L,6L,1L,3L,2L,2L,1L,6L,7L,8L,7L,9L,2L,8L,3L,10L,3L,4L,1L,9L,2L,4L,1L,5L,10L,11L,2L,12L,3L,3L,1L,4L,5L,6L,2L,3L,2L,2L,1L,7L,11L,12L,13L,13L,5L,14L,7L,14L,6L,7L,4L,15L,5L,8L,3L,15L,8L,9L,6L,10L,1L,7L,1L,16L,8L,9L,1L,9L,2L,4L,1L,6L,17L,18L,4L,19L,10L,5L,3L,20L,11L,12L,2L,6L,3L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286552Inst : IEnumerable<long>
{
public static readonly long[] Value=A286552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286552.Bytes);
public long this[int i]=>Value[i];

public static A286552Inst Instance=new A286552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286553
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,4L,8L,2L,6L,6L,12L,4L,12L,6L,16L,2L,6L,8L,12L,6L,30L,6L,24L,4L,12L,6L,36L,6L,30L,12L,32L,2L,6L,6L,12L,6L,24L,6L,24L,6L,30L,6L,60L,6L,30L,6L,48L,4L,12L,12L,36L,8L,30L,30L,72L,6L,30L,6L,60L,6L,60L,6L,64L,2L,6L,12L,12L,6L,30L,16L,24L,6L,30L,6L,72L,6L,30L,12L,48L,6L,30L,12L,60L,6L,30L,6L,120L,6L,30L,30L,60L,12L,30L,6L,96L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286553Inst : IEnumerable<long>
{
public static readonly long[] Value=A286553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286553.Bytes);
public long this[int i]=>Value[i];

public static A286553Inst Instance=new A286553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286554
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,2L,3L,4L,4L,3L,1L,4L,2L,1L,1L,3L,4L,1L,2L,5L,5L,6L,6L,5L,5L,7L,2L,8L,3L,1L,1L,9L,3L,1L,1L,2L,3L,2L,4L,4L,7L,2L,2L,3L,5L,2L,3L,10L,8L,4L,6L,11L,9L,12L,10L,6L,6L,13L,4L,14L,5L,3L,4L,15L,6L,1L,1L,4L,5L,2L,6L,16L,4L,3L,2L,4L,2L,1L,1L,3L,7L,1L,1L,5L,8L,6L,9L,5L,11L,5L,7L,6L,8L,2L,1L,7L,10L,3L,2L,5L,9L,3L,10L,17L,12L,8L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286554Inst : IEnumerable<long>
{
public static readonly long[] Value=A286554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286554.Bytes);
public long this[int i]=>Value[i];

public static A286554Inst Instance=new A286554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286555
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,8L,6L,5L,25L,18L,16L,21L,15L,12L,10L,7L,49L,50L,36L,51L,45L,32L,42L,55L,35L,30L,24L,33L,27L,20L,14L,11L,121L,98L,100L,147L,105L,72L,102L,125L,115L,90L,64L,93L,123L,84L,110L,91L,77L,70L,60L,87L,69L,48L,66L,85L,65L,54L,40L,57L,39L,28L,22L,13L,169L,242L,196L,291L,297L,200L,294L,365L,265L,210L,144L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286555Inst : IEnumerable<long>
{
public static readonly long[] Value=A286555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286555.Bytes);
public long this[int i]=>Value[i];

public static A286555Inst Instance=new A286555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286556
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,15L,5L,4L,14L,31L,13L,63L,30L,12L,10L,127L,9L,255L,29L,11L,62L,511L,26L,8L,126L,28L,61L,1023L,25L,2047L,21L,27L,254L,24L,18L,4095L,510L,60L,58L,8191L,22L,16383L,125L,20L,1022L,32767L,53L,16L,17L,19L,253L,65535L,57L,23L,122L,59L,2046L,131071L,50L,262143L,4094L,124L,42L,56L,54L,524287L,509L,52L,49L,1048575L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286556Inst : IEnumerable<long>
{
public static readonly long[] Value=A286556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286556.Bytes);
public long this[int i]=>Value[i];

public static A286556Inst Instance=new A286556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286557
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,6L,2L,4L,12L,16L,6L,6L,12L,6L,2L,4L,12L,36L,6L,12L,32L,30L,6L,6L,30L,24L,6L,8L,12L,6L,2L,4L,12L,36L,12L,30L,72L,30L,8L,6L,60L,64L,6L,6L,60L,30L,6L,6L,30L,60L,6L,6L,48L,30L,6L,6L,24L,24L,6L,6L,12L,6L,2L,4L,12L,36L,6L,24L,72L,60L,6L,6L,210L,144L,6L,6L,60L,24L,6L,6L,30L,180L,6L,24L,128L,30L,6L,6L,30L,120L,6L,6L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286557Inst : IEnumerable<long>
{
public static readonly long[] Value=A286557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286557.Bytes);
public long this[int i]=>Value[i];

public static A286557Inst Instance=new A286557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286558
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,3L,4L,2L,1L,3L,5L,4L,6L,4L,7L,5L,2L,6L,3L,1L,4L,7L,8L,8L,5L,9L,9L,10L,10L,5L,11L,11L,6L,12L,7L,2L,8L,13L,9L,3L,1L,4L,10L,5L,11L,14L,12L,15L,12L,16L,13L,6L,14L,17L,13L,18L,15L,19L,14L,20L,15L,6L,16L,21L,16L,22L,17L,7L,18L,23L,19L,8L,2L,9L,20L,10L,21L,24L,22L,11L,3L,12L,4L,1L,5L,13L,23L,14L,6L,15L,24L,16L,25L,25L,17L,26L,26L,27L,27L,17L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286558Inst : IEnumerable<long>
{
public static readonly long[] Value=A286558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286558.Bytes);
public long this[int i]=>Value[i];

public static A286558Inst Instance=new A286558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286559
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,5L,8L,8L,13L,13L,13L,25L,24L,25L,41L,32L,41L,50L,50L,61L,61L,61L,61L,113L,84L,86L,113L,113L,113L,113L,181L,128L,129L,181L,200L,163L,182L,221L,200L,221L,242L,242L,265L,265L,265L,265L,265L,481L,263L,290L,420L,363L,314L,422L,420L,365L,481L,420L,481L,481L,481L,481L,761L,512L,452L,687L,577L,513L,722L,761L,650L,687L,762L,723L,760L,722L,842L,760L,801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286559Inst : IEnumerable<long>
{
public static readonly long[] Value=A286559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286559.Bytes);
public long this[int i]=>Value[i];

public static A286559Inst Instance=new A286559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286560
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,41L,71L,71L,198L,313L,484L,922L,1153L,1201L,2105L,1565L,2588L,4046L,5001L,7443L,7443L,8851L,10671L,19589L,16570L,16935L,22254L,25313L,25313L,25313L,42891L,28793L,32768L,52795L,65504L,59178L,73355L,89033L,88632L,107660L,129045L,129045L,153471L,167646L,167646L,182446L,182446L,336130L,197244L,233297L,330472L,307358L,270167L,355325L,378466L,332156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286560Inst : IEnumerable<long>
{
public static readonly long[] Value=A286560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286560.Bytes);
public long this[int i]=>Value[i];

public static A286560Inst Instance=new A286560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286561
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286561Inst : IEnumerable<long>
{
public static readonly long[] Value=A286561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286561.Bytes);
public long this[int i]=>Value[i];

public static A286561Inst Instance=new A286561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286562
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,2L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,3L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286562Inst : IEnumerable<long>
{
public static readonly long[] Value=A286562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286562.Bytes);
public long this[int i]=>Value[i];

public static A286562Inst Instance=new A286562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286563
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,2L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,3L,0L,1L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286563Inst : IEnumerable<long>
{
public static readonly long[] Value=A286563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286563.Bytes);
public long this[int i]=>Value[i];

public static A286563Inst Instance=new A286563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286564
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,3L,1L,1L,0L,0L,0L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286564Inst : IEnumerable<long>
{
public static readonly long[] Value=A286564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286564.Bytes);
public long this[int i]=>Value[i];

public static A286564Inst Instance=new A286564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286565
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,3L,4L,3L,2L,5L,2L,3L,6L,6L,2L,7L,2L,7L,6L,6L,2L,8L,6L,3L,9L,10L,3L,8L,2L,5L,5L,3L,5L,11L,3L,3L,6L,12L,3L,12L,2L,8L,13L,6L,3L,14L,3L,8L,10L,8L,3L,15L,7L,16L,5L,10L,6L,17L,2L,3L,13L,8L,10L,18L,3L,8L,5L,18L,3L,19L,3L,5L,8L,8L,10L,16L,2L,11L,20L,5L,10L,19L,6L,5L,5L,14L,6L,17L,10L,18L,5L,10L,5L,21L,5L,5L,22L,23L,2L,24L,3L,14L,24L,10L,3L,25L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286565Inst : IEnumerable<long>
{
public static readonly long[] Value=A286565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286565.Bytes);
public long this[int i]=>Value[i];

public static A286565Inst Instance=new A286565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286566
{
public static readonly long[] Value={ 1L,3L,5L,9L,5L,19L,5L,26L,18L,19L,5L,51L,5L,19L,40L,73L,5L,72L,5L,72L,40L,40L,5L,113L,31L,19L,83L,111L,8L,129L,5L,101L,32L,19L,32L,221L,8L,19L,40L,179L,8L,199L,5L,84L,159L,40L,8L,312L,13L,84L,82L,84L,8L,239L,49L,261L,32L,82L,23L,419L,5L,19L,159L,224L,82L,334L,8L,84L,32L,334L,8L,543L,8L,32L,84L,84L,82L,285L,5L,243L,332L,32L,57L,478L,40L,32L,32L,218L,23L,419L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286566Inst : IEnumerable<long>
{
public static readonly long[] Value=A286566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286566.Bytes);
public long this[int i]=>Value[i];

public static A286566Inst Instance=new A286566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286663
{
public static readonly long[] Value={ 0L,2L,0L,4L,0L,4L,6L,37L,17L,21L,75L,27L,3L,20L,96L,21L,13L,90L,37L,26L,22L,20L,204L,12L,148L,23L,46L,24L,0L,71L,22L,3L,36L,41L,4L,101L,228L,31L,155L,304L,309L,392L,146L,85L,222L,346L,134L,277L,43L,7L,67L,484L,230L,152L,10L,135L,40L,256L,28L,97L,129L,90L,458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286663Inst : IEnumerable<long>
{
public static readonly long[] Value=A286663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286663.Bytes);
public long this[int i]=>Value[i];

public static A286663Inst Instance=new A286663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286664
{
public static readonly long[] Value={ 2L,5L,2L,2L,2L,20663L,2L,229L,2L,2L,2L,11L,2L,5L,2L,2L,2L,23L,2L,3L,2L,2L,2L,101L,2L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286664Inst : IEnumerable<long>
{
public static readonly long[] Value=A286664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286664.Bytes);
public long this[int i]=>Value[i];

public static A286664Inst Instance=new A286664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286665
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286665Inst : IEnumerable<long>
{
public static readonly long[] Value=A286665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286665.Bytes);
public long this[int i]=>Value[i];

public static A286665Inst Instance=new A286665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286666
{
public static readonly long[] Value={ 1L,3L,6L,8L,11L,13L,15L,18L,20L,23L,25L,27L,30L,32L,35L,37L,40L,42L,44L,47L,49L,52L,54L,56L,59L,61L,64L,66L,69L,71L,73L,76L,78L,81L,83L,85L,88L,90L,93L,95L,97L,100L,102L,105L,107L,110L,112L,114L,117L,119L,122L,124L,126L,129L,131L,134L,136L,139L,141L,143L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286666Inst : IEnumerable<long>
{
public static readonly long[] Value=A286666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286666.Bytes);
public long this[int i]=>Value[i];

public static A286666Inst Instance=new A286666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286667
{
public static readonly long[] Value={ 2L,4L,5L,7L,9L,10L,12L,14L,16L,17L,19L,21L,22L,24L,26L,28L,29L,31L,33L,34L,36L,38L,39L,41L,43L,45L,46L,48L,50L,51L,53L,55L,57L,58L,60L,62L,63L,65L,67L,68L,70L,72L,74L,75L,77L,79L,80L,82L,84L,86L,87L,89L,91L,92L,94L,96L,98L,99L,101L,103L,104L,106L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286667Inst : IEnumerable<long>
{
public static readonly long[] Value=A286667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286667.Bytes);
public long this[int i]=>Value[i];

public static A286667Inst Instance=new A286667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286668
{
public static readonly BigInteger[] Value={ 1L,10L,1L,1100L,11L,111000L,0L,11111111L,0L,1111100001L,0L,111111110000L,1001L,11111111100100L,11L,1111111111111000L,0L,111111111000100011L,1011000L,11111111111110000111UL,1100000L,BigInteger.Parse("1111111111110010000011"),0L,BigInteger.Parse("111111111111111111000011"),0L };
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
public class A286668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286668Inst Instance=new A286668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286669
{
public static readonly BigInteger[] Value={ 1L,1L,100L,11L,11000L,111L,0L,11111111L,0L,1000011111L,0L,11111111L,1001000000000L,100111111111L,110000000000000L,1111111111111L,0L,110001000111111111L,1101000000000000L,11100001111111111111UL,1100000000000000L,BigInteger.Parse("1100000100111111111111"),0L };
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
public class A286669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286669Inst Instance=new A286669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286670
{
public static readonly long[] Value={ 1L,2L,1L,12L,3L,56L,0L,255L,0L,993L,0L,4080L,9L,16356L,3L,65528L,0L,261667L,88L,1048455L,96L,4193411L,0L,16777155L,0L,67107843L,28L,268431361L,1542L,1073725697L,7688L,4294951169L,48L,17179740099L,30728L,68719445888L,115L,274877808512L,60L,1099511167041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286670Inst : IEnumerable<long>
{
public static readonly long[] Value=A286670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286670.Bytes);
public long this[int i]=>Value[i];

public static A286670Inst Instance=new A286670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286671
{
public static readonly long[] Value={ 1L,1L,4L,3L,24L,7L,0L,255L,0L,543L,0L,255L,4608L,2559L,24576L,8191L,0L,201215L,53248L,925695L,49152L,3166207L,0L,12845055L,0L,50397183L,29360128L,134283263L,202113024L,539033599L,138149888L,2156134399L,402653184L,13145079807L,2163212288L,505413631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286671Inst : IEnumerable<long>
{
public static readonly long[] Value=A286671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286671.Bytes);
public long this[int i]=>Value[i];

public static A286671Inst Instance=new A286671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286672
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,11L,111111L,11L,11111111L,1001L,1111111111L,1001L,111111111111L,1111L,11111111111111L,1111L,1111111111111111L,11111111L,111111111111111111L,10011001L,11111111111111111111UL,10010011L,BigInteger.Parse("1111111111111111111111"),11001001L,BigInteger.Parse("111111111111111111111111") };
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
public class A286672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286672Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286672.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286672Inst Instance=new A286672Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286673
{
public static readonly ulong[] Value={ 1L,11L,100L,1111L,11000L,111111L,1100000L,11111111L,100100000L,1111111111L,10010000000L,111111111111L,1111000000000L,11111111111111L,111100000000000L,1111111111111111L,11111111000000000L,111111111111111111L,1001100100000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286673Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286673.Bytes);
public ulong this[int i]=>Value[i];

public static A286673Inst Instance=new A286673Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286674
{
public static readonly long[] Value={ 1L,3L,1L,15L,3L,63L,3L,255L,9L,1023L,9L,4095L,15L,16383L,15L,65535L,255L,262143L,153L,1048575L,147L,4194303L,201L,16777215L,9L,67108863L,227L,268435455L,227L,1073741823L,227L,4294967295L,65535L,17179869183L,65535L,68719476735L,61951L,274877906943L,58623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286674Inst : IEnumerable<long>
{
public static readonly long[] Value=A286674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286674.Bytes);
public long this[int i]=>Value[i];

public static A286674Inst Instance=new A286674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286675
{
public static readonly long[] Value={ 1L,3L,4L,15L,24L,63L,96L,255L,288L,1023L,1152L,4095L,7680L,16383L,30720L,65535L,130560L,262143L,313344L,1048575L,1646592L,4194303L,4816896L,16777215L,18874368L,67108863L,104333312L,268435455L,417333248L,1073741823L,1669332992L,4294967295L,8589803520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286675Inst : IEnumerable<long>
{
public static readonly long[] Value=A286675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286675.Bytes);
public long this[int i]=>Value[i];

public static A286675Inst Instance=new A286675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286676
{
public static readonly long[] Value={ 1L,3L,9L,2L,20L,12L,23L,27L,31L,35L,187L,1461L,485L,105L,64L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286676Inst : IEnumerable<long>
{
public static readonly long[] Value=A286676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286676.Bytes);
public long this[int i]=>Value[i];

public static A286676Inst Instance=new A286676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286677
{
public static readonly long[] Value={ 1L,2L,5L,1L,9L,5L,9L,10L,11L,12L,62L,470L,152L,32L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286677Inst : IEnumerable<long>
{
public static readonly long[] Value=A286677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286677.Bytes);
public long this[int i]=>Value[i];

public static A286677Inst Instance=new A286677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286678
{
public static readonly BigInteger[] Value={ 5L,17L,257L,65537L,BigInteger.Parse("795866110996400884391941"),BigInteger.Parse("3402823669209384634633746074317682114560000000000000000000000000000000000000000000000000000000000000039") };
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
public class A286678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286678Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286678.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286678Inst Instance=new A286678Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286759
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,5L,11L,11L,25L,25L,39L,39L,123L,123L,169L,169L,425L,425L,553L,553L,1897L,1897L,2569L,2569L,6665L,6665L,8713L,8713L,30217L,30217L,41353L,41353L,106889L,106889L,139657L,139657L,483721L,483721L,655753L,655753L,1704329L,1704329L,2228617L,2228617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286759Inst : IEnumerable<long>
{
public static readonly long[] Value=A286759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286759.Bytes);
public long this[int i]=>Value[i];

public static A286759Inst Instance=new A286759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286760
{
public static readonly long[] Value={ 1L,2L,10L,42L,214L,1098L,5978L,33190L,189078L,1093490L,6414714L,38027030L,227489950L,1370980490L,8314674202L,50696630838L,310541818382L,1909850054666L,11786947172234L,72969941803662L,452976340653030L,2818815920369754L,17579546535174946L,109850944544149134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286760Inst : IEnumerable<long>
{
public static readonly long[] Value=A286760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286760.Bytes);
public long this[int i]=>Value[i];

public static A286760Inst Instance=new A286760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286761
{
public static readonly long[] Value={ 1L,2L,7L,25L,106L,470L,2218L,10799L,54158L,277089L,1441956L,7602630L,40524952L,217954222L,1181107568L,6441519814L,35323986620L,194629681327L,1076819450324L,5979314763974L,33308210757892L,186074808452033L,1042146006514656L,5850075202736100L,32907053660222560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286761Inst : IEnumerable<long>
{
public static readonly long[] Value=A286761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286761.Bytes);
public long this[int i]=>Value[i];

public static A286761Inst Instance=new A286761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286762
{
public static readonly long[] Value={ 0L,21L,22L,45L,46L,57L,70L,94L,105L,118L,142L,147L,165L,171L,177L,187L,190L,214L,221L,222L,225L,237L,238L,261L,267L,281L,286L,291L,313L,315L,318L,334L,345L,350L,357L,358L,381L,382L,387L,403L,430L,437L,441L,448L,465L,477L,478L,501L,507L,538L,555L,558L,561L,565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286762Inst : IEnumerable<long>
{
public static readonly long[] Value=A286762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286762.Bytes);
public long this[int i]=>Value[i];

public static A286762Inst Instance=new A286762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286763
{
public static readonly long[] Value={ 1L,30L,210L,330L,2310L,3990L,6090L,14790L,43890L,66990L,82110L,125970L,144210L,181830L,881790L,1009470L,1067430L,1217370L,2284590L,2381190L,17687670L,18888870L,26265030L,35068110L,39544890L,47763870L,115223790L,127652070L,406816410L,497668710L,741110370L,1024748670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286763Inst : IEnumerable<long>
{
public static readonly long[] Value=A286763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286763.Bytes);
public long this[int i]=>Value[i];

public static A286763Inst Instance=new A286763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286764
{
public static readonly BigInteger[] Value={ 1L,3L,16L,109L,855L,7298L,65838L,617118L,5946781L,58506642L,584894463L,5921596628L,60565217546L,624644829720L,6487216108058L,67767838847144L,711463437534474L,7501409431304796L,79386836213817417L,842882477863610604L,8974911258934880498L,BigInteger.Parse("95806877080558096428") };
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
public class A286764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286764Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286764.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286764Inst Instance=new A286764Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286765
{
public static readonly BigInteger[] Value={ 1L,5L,36L,320L,3204L,34488L,389320L,4542784L,54298992L,660897208L,8157832672L,101824497960L,1282453483896L,16272274720064L,207749196820392L,2666235340584848L,34371222980687520L,444797703379924056L,5775424372048775480L,BigInteger.Parse("75210745056872493904") };
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
public class A286765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286765Inst Instance=new A286765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286766
{
public static readonly BigInteger[] Value={ 1L,11L,1L,1111L,0L,111111L,11L,11111111L,1001L,1111111111L,0L,111111111111L,0L,11111111111111L,1111L,1111111111111111L,10011L,111111111111111111L,1L,11111111111111111111UL,11001L,BigInteger.Parse("1111111111111111111111"),1000000001L,BigInteger.Parse("111111111111111111111111"),10000100L };
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
public class A286766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286766Inst Instance=new A286766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286767
{
public static readonly BigInteger[] Value={ 1L,11L,100L,1111L,0L,111111L,1100000L,11111111L,100100000L,1111111111L,0L,111111111111L,0L,11111111111111L,111100000000000L,1111111111111111L,11001000000000000L,111111111111111111L,1000000000000000000L,11111111111111111111UL,BigInteger.Parse("100110000000000000000") };
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
public class A286767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286767Inst Instance=new A286767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286768
{
public static readonly long[] Value={ 1L,3L,1L,15L,0L,63L,3L,255L,9L,1023L,0L,4095L,0L,16383L,15L,65535L,19L,262143L,1L,1048575L,25L,4194303L,513L,16777215L,132L,67108863L,1553L,268435455L,6151L,1073741823L,1L,4294967295L,57377L,17179869183L,16641L,68719476735L,12353L,274877906943L,131856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286768Inst : IEnumerable<long>
{
public static readonly long[] Value=A286768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286768.Bytes);
public long this[int i]=>Value[i];

public static A286768Inst Instance=new A286768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286769
{
public static readonly long[] Value={ 1L,3L,4L,15L,0L,63L,96L,255L,288L,1023L,0L,4095L,0L,16383L,30720L,65535L,102400L,262143L,262144L,1048575L,1245184L,4194303L,4202496L,16777215L,4325376L,67108863L,71499776L,268435455L,469958656L,1073741823L,1073741824L,4294967295L,4430102528L,17179869183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286769Inst : IEnumerable<long>
{
public static readonly long[] Value=A286769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286769.Bytes);
public long this[int i]=>Value[i];

public static A286769Inst Instance=new A286769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286770
{
public static readonly BigInteger[] Value={ 1L,10L,0L,1110L,1L,111110L,1L,11111110L,1L,1111111110L,1L,111111111110L,1L,11111111111110L,1L,1111111111111110L,1L,111111111111111110L,1L,11111111111111111110UL,1L,BigInteger.Parse("1111111111111111111110"),1L,BigInteger.Parse("111111111111111111111110"),1L,BigInteger.Parse("11111111111111111111111110"),1L };
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
public class A286770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286770Inst Instance=new A286770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286771
{
public static readonly long[] Value={ 1L,1L,0L,111L,10000L,11111L,1000000L,1111111L,100000000L,111111111L,10000000000L,11111111111L,1000000000000L,1111111111111L,100000000000000L,111111111111111L,10000000000000000L,11111111111111111L,1000000000000000000L,1111111111111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286771Inst : IEnumerable<long>
{
public static readonly long[] Value=A286771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286771.Bytes);
public long this[int i]=>Value[i];

public static A286771Inst Instance=new A286771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286772
{
public static readonly long[] Value={ 1L,2L,0L,14L,1L,62L,1L,254L,1L,1022L,1L,4094L,1L,16382L,1L,65534L,1L,262142L,1L,1048574L,1L,4194302L,1L,16777214L,1L,67108862L,1L,268435454L,1L,1073741822L,1L,4294967294L,1L,17179869182L,1L,68719476734L,1L,274877906942L,1L,1099511627774L,1L,4398046511102L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286772Inst : IEnumerable<long>
{
public static readonly long[] Value=A286772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286772.Bytes);
public long this[int i]=>Value[i];

public static A286772Inst Instance=new A286772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286773
{
public static readonly long[] Value={ 1L,1L,0L,7L,16L,31L,64L,127L,256L,511L,1024L,2047L,4096L,8191L,16384L,32767L,65536L,131071L,262144L,524287L,1048576L,2097151L,4194304L,8388607L,16777216L,33554431L,67108864L,134217727L,268435456L,536870911L,1073741824L,2147483647L,4294967296L,8589934591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286773Inst : IEnumerable<long>
{
public static readonly long[] Value=A286773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286773.Bytes);
public long this[int i]=>Value[i];

public static A286773Inst Instance=new A286773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286774
{
public static readonly long[] Value={ 1L,1L,10L,0L,100L,0L,1110L,0L,11010L,0L,110010L,1000L,1110010L,0L,11010010L,100000L,111010000L,1100010L,1100000000L,10100100L,11101000000L,10011000L,111000100000L,1011110L,1100100000000L,1011010110L,11110000000000L,111001110L,110001000000000L,1011001010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286774Inst : IEnumerable<long>
{
public static readonly long[] Value=A286774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286774.Bytes);
public long this[int i]=>Value[i];

public static A286774Inst Instance=new A286774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286839
{
public static readonly long[] Value={ 8L,7L,11L,12L,7L,7L,11L,12L,11L,4L,4L,6L,0L,6L,9L,12L,8L,5L,8L,7L,12L,7L,11L,8L,1L,5L,6L,2L,7L,7L,7L,3L,6L,2L,6L,10L,7L,12L,12L,10L,1L,5L,5L,12L,5L,7L,0L,9L,8L,10L,3L,6L,5L,10L,0L,5L,6L,11L,7L,12L,7L,9L,1L,12L,2L,0L,9L,4L,7L,6L,2L,7L,3L,6L,3L,10L,4L,7L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286839Inst : IEnumerable<long>
{
public static readonly long[] Value=A286839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286839.Bytes);
public long this[int i]=>Value[i];

public static A286839Inst Instance=new A286839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286840
{
public static readonly BigInteger[] Value={ 0L,5L,70L,239L,239L,143044L,1999509L,6826318L,6826318L,822557039L,85658552023L,1188526486815L,11941488851037L,291518510320809L,2108769149874327L,13920898306972194L,13920898306972194L,2675587335039691558L,BigInteger.Parse("63228498770709057089"),BigInteger.Parse("513050126578538629605") };
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
public class A286840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286840Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286840.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286840Inst Instance=new A286840Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286841
{
public static readonly BigInteger[] Value={ 0L,8L,99L,1958L,28322L,228249L,2827300L,55922199L,808904403L,9781942334L,52199939826L,603633907222L,11356596271444L,11356596271444L,1828607235824962L,37264994707118563L,651495710876207647L,5974828584341646375L,BigInteger.Parse("49226908181248336040") };
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
public class A286841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286841Inst Instance=new A286841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286842
{
public static readonly long[] Value={ 4L,2L,7L,1L,7L,54L,3L,1L,3L,5L,5L,27L,3L,7L,35L,2L,5L,18L,3L,40L,1L,11L,5L,96L,2L,13L,1L,14L,7L,120L,5L,1L,99L,68L,1L,9L,3L,19L,1L,20L,5L,5145000L,3L,88L,80L,23L,5L,48L,2L,1L,323L,52L,5L,6L,1L,7L,1L,116L,7L,60L,5L,124L,1L,2L,1L,1650L,3L,34L,299L,35L,7L,32L,5L,37L,7L,19L,1L,26693550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286842Inst : IEnumerable<long>
{
public static readonly long[] Value=A286842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286842.Bytes);
public long this[int i]=>Value[i];

public static A286842Inst Instance=new A286842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286843
{
public static readonly long[] Value={ 10L,14L,22L,38L,44L,92L,110L,130L,134L,136L,152L,170L,184L,248L,250L,262L,284L,376L,410L,442L,632L,730L,752L,884L,988L,1012L,1052L,1276L,1292L,1370L,1628L,2144L,2168L,2272L,2332L,2528L,3068L,4064L,4124L,5210L,6112L,6364L,6556L,7372L,8198L,8312L,8384L,8648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286843Inst : IEnumerable<long>
{
public static readonly long[] Value=A286843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286843.Bytes);
public long this[int i]=>Value[i];

public static A286843Inst Instance=new A286843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286844
{
public static readonly long[] Value={ 1L,2L,3L,4L,2L,4L,2L,3L,6L,1L,2L,4L,3L,4L,5L,7L,6L,5L,6L,7L,6L,7L,4L,2L,4L,3L,8L,5L,6L,8L,6L,2L,8L,3L,7L,4L,8L,6L,10L,10L,7L,10L,9L,10L,12L,10L,2L,4L,6L,11L,7L,4L,10L,6L,5L,7L,11L,2L,3L,9L,5L,8L,6L,8L,12L,7L,11L,10L,12L,1L,3L,11L,4L,10L,8L,7L,10L,4L,15L,12L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286844Inst : IEnumerable<long>
{
public static readonly long[] Value=A286844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286844.Bytes);
public long this[int i]=>Value[i];

public static A286844Inst Instance=new A286844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286845
{
public static readonly long[] Value={ 459L,468L,486L,495L,549L,567L,576L,594L,639L,648L,657L,675L,693L,729L,738L,783L,792L,819L,837L,846L,864L,873L,891L,918L,927L,936L,945L,954L,963L,972L,981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286845Inst : IEnumerable<long>
{
public static readonly long[] Value=A286845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286845.Bytes);
public long this[int i]=>Value[i];

public static A286845Inst Instance=new A286845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286846
{
public static readonly long[] Value={ 459173286L,459176283L,459183276L,459186273L,459273186L,459276183L,459283176L,459286173L,468173295L,468175293L,468193275L,468195273L,468273195L,468275193L,468293175L,468295173L,486127359L,486129357L,486157329L,486159327L,486327159L,486329157L,486357129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286846Inst : IEnumerable<long>
{
public static readonly long[] Value=A286846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286846.Bytes);
public long this[int i]=>Value[i];

public static A286846Inst Instance=new A286846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286847
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,2L,4L,7L,7L,4L,4L,18L,16L,18L,4L,7L,39L,53L,53L,39L,7L,9L,75L,154L,306L,154L,75L,9L,13L,155L,436L,1167L,1167L,436L,155L,13L,18L,310L,1268L,4939L,6958L,4939L,1268L,310L,18L,25L,638L,3660L,21313L,40931L,40931L,21313L,3660L,638L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286847Inst : IEnumerable<long>
{
public static readonly long[] Value=A286847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286847.Bytes);
public long this[int i]=>Value[i];

public static A286847Inst Instance=new A286847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286848
{
public static readonly long[] Value={ 2L,7L,16L,53L,154L,436L,1268L,3660L,10610L,30744L,89079L,258251L,748420L,2169219L,6287336L,18222901L,52817261L,153084840L,443698814L,1286012537L,3727362387L,10803344089L,31312289784L,90755170545L,263043739916L,762402920030L,2209739758798L,6404684091893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286848Inst : IEnumerable<long>
{
public static readonly long[] Value=A286848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286848.Bytes);
public long this[int i]=>Value[i];

public static A286848Inst Instance=new A286848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286849
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,4L,6L,6L,4L,4L,16L,12L,16L,4L,7L,20L,36L,36L,20L,7L,9L,52L,64L,256L,64L,52L,9L,13L,80L,204L,400L,400L,204L,80L,13L,18L,176L,446L,2704L,971L,2704L,446L,176L,18L,25L,296L,1184L,6400L,6486L,6486L,6400L,1184L,296L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286849Inst : IEnumerable<long>
{
public static readonly long[] Value=A286849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286849.Bytes);
public long this[int i]=>Value[i];

public static A286849Inst Instance=new A286849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286850
{
public static readonly long[] Value={ 2L,4L,6L,16L,20L,52L,80L,176L,296L,592L,1104L,2064L,3936L,7296L,14048L,25984L,49600L,92736L,175872L,330240L,623232L,1175296L,2213632L,4176128L,7863808L,14838784L,27948544L,52707328L,99320832L,187257856L,352940032L,665276416L,1254090752L,2363805696L,4455927808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286850Inst : IEnumerable<long>
{
public static readonly long[] Value=A286850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286850.Bytes);
public long this[int i]=>Value[i];

public static A286850Inst Instance=new A286850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286851
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,25L,2L,2L,2L,129L,2L,170L,2L,742L,450L,2L,2L,4603L,2L,1503L,3321L,29967L,2L,9278L,2L,200390L,2L,13460L,2L,154004511L,2L,2L,226020L,9262157L,51886L,127654L,2L,63346598L,2044895L,170354L,2L,185493291001L,2L,1304512L,567124L,2972038875L,2L,59489916L,2L,20367343494L,184947044L,14324735L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286851Inst : IEnumerable<long>
{
public static readonly long[] Value=A286851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286851.Bytes);
public long this[int i]=>Value[i];

public static A286851Inst Instance=new A286851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286852
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,1L,0L,0L,2L,1L,1L,1L,2L,2L,0L,1L,1L,1L,1L,2L,2L,1L,1L,0L,2L,0L,1L,1L,21L,1L,0L,2L,2L,2L,0L,1L,2L,2L,1L,1L,28L,1L,1L,1L,2L,1L,1L,0L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,5L,1L,2L,1L,0L,2L,42L,1L,1L,2L,43L,1L,0L,1L,2L,1L,1L,2L,49L,1L,1L,0L,2L,1L,5L,2L,2L,2L,1L,1L,10L,2L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286852Inst : IEnumerable<long>
{
public static readonly long[] Value=A286852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286852.Bytes);
public long this[int i]=>Value[i];

public static A286852Inst Instance=new A286852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286853
{
public static readonly long[] Value={ 198L,22L,110L,220L,110L,220L,110L,36L,184L,110L,220L,110L,6L,60L,154L,110L,220L,110L,120L,100L,110L,88L,132L,110L,220L,44L,66L,48L,172L,110L,220L,110L,220L,66L,44L,220L,110L,132L,88L,110L,220L,110L,70L,150L,110L,6L,148L,66L,110L,220L,110L,220L,110L,220L,110L,220L,110L,22L,198L,32L,78L,198L,22L,110L,220L,110L,210L,10L,30L,80L,220L,110L,220L,110L,66L,154L,110L,220L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286853Inst : IEnumerable<long>
{
public static readonly long[] Value=A286853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286853.Bytes);
public long this[int i]=>Value[i];

public static A286853Inst Instance=new A286853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286854
{
public static readonly long[] Value={ 55L,253L,275L,385L,605L,715L,935L,1045L,1081L,1265L,1375L,1595L,1705L,1711L,1771L,1925L,2035L,2255L,2365L,2485L,2585L,2695L,2783L,2915L,3025L,3245L,3289L,3355L,3403L,3575L,3685L,3905L,4015L,4235L,4301L,4345L,4565L,4675L,4807L,4895L,5005L,5225L,5335L,5405L,5555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286854Inst : IEnumerable<long>
{
public static readonly long[] Value=A286854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286854.Bytes);
public long this[int i]=>Value[i];

public static A286854Inst Instance=new A286854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286936
{
public static readonly long[] Value={ 1L,2L,4L,8L,26L,28L,43L,70L,92L,128L,331L,364L,478L,532L,689L,778L,895L,1210L,5081L,7855L,17852L,20864L,42598L,56858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286936Inst : IEnumerable<long>
{
public static readonly long[] Value=A286936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286936.Bytes);
public long this[int i]=>Value[i];

public static A286936Inst Instance=new A286936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286937
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286937Inst : IEnumerable<long>
{
public static readonly long[] Value=A286937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286937.Bytes);
public long this[int i]=>Value[i];

public static A286937Inst Instance=new A286937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286938
{
public static readonly long[] Value={ 2L,3L,5L,8L,13L,21L,33L,52L,82L,128L,200L,313L,488L,761L,1188L,1852L,2887L,4503L,7020L,10943L,17063L,26601L,41468L,64652L,100792L,157128L,244965L,381898L,595363L,928166L,1446998L,2255827L,3516797L,5482628L,8547285L,13325053L,20773513L,32385456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286938Inst : IEnumerable<long>
{
public static readonly long[] Value=A286938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286938.Bytes);
public long this[int i]=>Value[i];

public static A286938Inst Instance=new A286938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286939
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286939Inst : IEnumerable<long>
{
public static readonly long[] Value=A286939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286939.Bytes);
public long this[int i]=>Value[i];

public static A286939Inst Instance=new A286939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286940
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,7L,15L,13L,1L,42L,39L,42L,39L,42L,28L,1L,42L,39L,42L,39L,42L,28L,1L,42L,39L,42L,39L,35L,7L,32L,7L,35L,7L,32L,7L,35L,7L,32L,4L,39L,42L,39L,42L,39L,35L,7L,32L,7L,35L,7L,32L,7L,35L,7L,32L,4L,39L,42L,39L,42L,39L,35L,7L,32L,7L,35L,7L,32L,7L,35L,7L,32L,4L,28L,1L,42L,39L,42L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286940Inst : IEnumerable<long>
{
public static readonly long[] Value=A286940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286940.Bytes);
public long this[int i]=>Value[i];

public static A286940Inst Instance=new A286940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286941
{
public static readonly long[] Value={ 1L,1L,5L,1L,7L,11L,13L,17L,19L,23L,29L,1L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,143L,149L,151L,157L,163L,167L,169L,173L,179L,181L,187L,191L,193L,197L,199L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286941Inst : IEnumerable<long>
{
public static readonly long[] Value=A286941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286941.Bytes);
public long this[int i]=>Value[i];

public static A286941Inst Instance=new A286941Inst();

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