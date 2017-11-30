using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A103941
{
public static readonly long[] Value={ 1L,2L,6L,22L,103L,614L,3872L,26414L,186988L,1367976L,10254326L,78461338L,610598818L,4821248244L,38546510368L,311560875422L,2542507084588L,20925300483992L,173530381632724L,1448900079476152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103941Inst : IEnumerable<long>
{
public static readonly long[] Value=A103941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103941.Bytes);
public long this[int i]=>Value[i];

public static A103941Inst Instance=new A103941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103942
{
public static readonly long[] Value={ 1L,3L,9L,38L,187L,1120L,7083L,47990L,337676L,2455517L,18310155L,139447034L,1080773098L,8502896424L,67763884363L,546147639926L,4445389286380L,36501274080076L,302060508150976L,2517213486505592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103942Inst : IEnumerable<long>
{
public static readonly long[] Value=A103942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103942.Bytes);
public long this[int i]=>Value[i];

public static A103942Inst Instance=new A103942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103943
{
public static readonly long[] Value={ 1L,3L,12L,48L,196L,798L,3248L,13184L,53416L,216018L,872344L,3518496L,14177528L,57080572L,229657792L,923474944L,3711572176L,14911097514L,59883185096L,240416320928L,964947251544L,3872021946532L,15533828715232L,62306843932928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103943Inst : IEnumerable<long>
{
public static readonly long[] Value=A103943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103943.Bytes);
public long this[int i]=>Value[i];

public static A103943Inst Instance=new A103943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103944
{
public static readonly long[] Value={ 1L,10L,93L,836L,7355L,63750L,546553L,4646920L,39250935L,329789450L,2758868981L,22995369996L,191074697203L,1583463268366L,13092015636465L,108024564809744L,889730213085167L,7316434446188562L,60078376613838829L,492692533579612180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103944Inst : IEnumerable<long>
{
public static readonly long[] Value=A103944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103944.Bytes);
public long this[int i]=>Value[i];

public static A103944Inst Instance=new A103944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103945
{
public static readonly long[] Value={ 2L,14L,107L,844L,6757L,54522L,441863L,3589880L,29206025L,237780982L,1936486411L,15771410420L,128431734797L,1045618229234L,8510270668815L,69241255165936L,563154350637073L,4578526894227438L,37209886138826771L,302291556342169580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103945Inst : IEnumerable<long>
{
public static readonly long[] Value=A103945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103945.Bytes);
public long this[int i]=>Value[i];

public static A103945Inst Instance=new A103945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103946
{
public static readonly long[] Value={ 37L,61L,157L,193L,229L,313L,373L,397L,409L,433L,457L,601L,613L,673L,877L,997L,1009L,1321L,1429L,1453L,1489L,1549L,1657L,1741L,1777L,1861L,2017L,2293L,2377L,2557L,2677L,2689L,2713L,2749L,2797L,2857L,2917L,2953L,3109L,3169L,3181L,3361L,3433L,3517L,4021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103946Inst : IEnumerable<long>
{
public static readonly long[] Value=A103946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103946.Bytes);
public long this[int i]=>Value[i];

public static A103946Inst Instance=new A103946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103947
{
public static readonly long[] Value={ 1L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103947Inst : IEnumerable<long>
{
public static readonly long[] Value=A103947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103947.Bytes);
public long this[int i]=>Value[i];

public static A103947Inst Instance=new A103947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103948
{
public static readonly long[] Value={ 1L,27L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L,12L,21L,10L,21L,12L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103948Inst : IEnumerable<long>
{
public static readonly long[] Value=A103948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103948.Bytes);
public long this[int i]=>Value[i];

public static A103948Inst Instance=new A103948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103949
{
public static readonly long[] Value={ 1L,256L,100L,116L,73L,148L,44L,148L,73L,116L,76L,148L,41L,148L,76L,116L,73L,148L,44L,148L,73L,116L,76L,148L,41L,148L,76L,116L,73L,148L,44L,148L,73L,116L,76L,148L,41L,148L,76L,116L,73L,148L,44L,148L,73L,116L,76L,148L,41L,148L,76L,116L,73L,148L,44L,148L,73L,116L,76L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103949Inst : IEnumerable<long>
{
public static readonly long[] Value=A103949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103949.Bytes);
public long this[int i]=>Value[i];

public static A103949Inst Instance=new A103949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103950
{
public static readonly long[] Value={ 1L,46656L,13356L,11026L,5721L,12942L,3136L,13806L,5601L,9286L,5952L,13806L,1921L,13806L,6816L,8422L,5601L,13806L,3136L,13806L,4737L,9286L,6816L,13806L,1921L,12942L,6816L,9286L,5601L,13806L,2272L,13806L,5601L,9286L,6816L,12942L,1921L,13806L,6816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103950Inst : IEnumerable<long>
{
public static readonly long[] Value=A103950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103950.Bytes);
public long this[int i]=>Value[i];

public static A103950Inst Instance=new A103950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103951
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,21L,23L,25L,27L,29L,32L,35L,38L,42L,46L,49L,51L,54L,56L,59L,62L,65L,68L,72L,75L,76L,79L,83L,84L,87L,92L,93L,96L,102L,103L,105L,106L,113L,114L,116L,117L,125L,126L,128L,129L,137L,138L,139L,142L,143L,152L,153L,154L,157L,158L,162L,168L,169L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103951Inst : IEnumerable<long>
{
public static readonly long[] Value=A103951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103951.Bytes);
public long this[int i]=>Value[i];

public static A103951Inst Instance=new A103951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103952
{
public static readonly long[] Value={ 9L,27L,4L,8L,9L,214375L,8L,9L,25L,2197L,27L,16L,49L,30459375L,16L,25L,25L,27L,27L,36L,25L,49L,27L,25L,125L,27L,36L,32L,225L,6889L,32L,36L,49L,899236854961L,36L,72L,64L,1369L,64L,49L,49L,518436000667L,243L,108L,49L,289L,72L,49L,81L,675L,100L,196L,125L,81L,64L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103952Inst : IEnumerable<long>
{
public static readonly long[] Value=A103952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103952.Bytes);
public long this[int i]=>Value[i];

public static A103952Inst Instance=new A103952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103953
{
public static readonly long[] Value={ 8L,25L,1L,4L,4L,0L,1L,1L,16L,2187L,16L,4L,36L,0L,1L,9L,8L,9L,8L,16L,4L,27L,4L,1L,100L,1L,9L,4L,196L,6859L,1L,4L,16L,0L,1L,64L,27L,1331L,25L,9L,8L,0L,441L,81L,4L,243L,81L,1L,32L,0L,49L,144L,676L,27L,9L,8L,64L,0L,841L,4L,64L,0L,1L,36L,16L,0L,1089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103953Inst : IEnumerable<long>
{
public static readonly long[] Value=A103953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103953.Bytes);
public long this[int i]=>Value[i];

public static A103953Inst Instance=new A103953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103954
{
public static readonly long[] Value={ 8L,25L,1L,4L,27L,214369L,9L,64L,16L,2187L,3125L,500L,36L,30459361L,49L,128L,512L,225L,81L,21296L,1331L,100467L,625L,1000L,144L,11881L,169L,972L,36963L,6859L,361L,256L,12967168L,899236854927L,289L,864L,117612L,3087L,10609L,2704L,800L,518436000625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103954Inst : IEnumerable<long>
{
public static readonly long[] Value=A103954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103954.Bytes);
public long this[int i]=>Value[i];

public static A103954Inst Instance=new A103954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103955
{
public static readonly long[] Value={ 9L,27L,4L,8L,32L,214375L,16L,72L,25L,2197L,3136L,512L,49L,30459375L,64L,144L,529L,243L,100L,21316L,1352L,100489L,648L,1024L,169L,11907L,196L,1000L,36992L,6889L,392L,288L,12967201L,899236854961L,324L,900L,117649L,3125L,10648L,2744L,841L,518436000667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103955Inst : IEnumerable<long>
{
public static readonly long[] Value=A103955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103955.Bytes);
public long this[int i]=>Value[i];

public static A103955Inst Instance=new A103955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103956
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103956Inst : IEnumerable<long>
{
public static readonly long[] Value=A103956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103956.Bytes);
public long this[int i]=>Value[i];

public static A103956Inst Instance=new A103956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103957
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L,1L,1L,2L,1L,2L,1L,3L,1L,2L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103957Inst : IEnumerable<long>
{
public static readonly long[] Value=A103957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103957.Bytes);
public long this[int i]=>Value[i];

public static A103957Inst Instance=new A103957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103958
{
public static readonly long[] Value={ 2L,2L,1L,1L,2L,2L,1L,3L,2L,3L,2L,2L,2L,2L,3L,2L,4L,6L,5L,6L,2L,4L,3L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103958Inst : IEnumerable<long>
{
public static readonly long[] Value=A103958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103958.Bytes);
public long this[int i]=>Value[i];

public static A103958Inst Instance=new A103958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103959
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,3L,5L,7L,3L,11L,13L,3L,11L,3L,3L,3L,5L,3L,3L,3L,7L,19L,11L,5L,7L,5L,3L,23L,7L,3L,3L,5L,3L,7L,5L,31L,7L,3L,3L,5L,17L,3L,3L,3L,5L,19L,3L,7L,29L,7L,5L,5L,61L,3L,3L,3L,11L,3L,3L,11L,7L,3L,3L,5L,3L,5L,3L,3L,3L,7L,11L,11L,19L,3L,61L,5L,29L,7L,3L,7L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103959Inst : IEnumerable<long>
{
public static readonly long[] Value=A103959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103959.Bytes);
public long this[int i]=>Value[i];

public static A103959Inst Instance=new A103959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103960
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,1L,2L,4L,3L,2L,5L,3L,3L,5L,3L,4L,4L,4L,5L,6L,3L,4L,6L,3L,5L,6L,5L,3L,6L,5L,8L,5L,5L,6L,5L,7L,9L,7L,6L,6L,5L,7L,6L,8L,5L,8L,10L,5L,6L,8L,6L,7L,7L,10L,10L,3L,11L,8L,11L,6L,10L,8L,12L,9L,9L,7L,11L,9L,7L,8L,9L,6L,14L,8L,10L,11L,11L,12L,11L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103960Inst : IEnumerable<long>
{
public static readonly long[] Value=A103960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103960.Bytes);
public long this[int i]=>Value[i];

public static A103960Inst Instance=new A103960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103961
{
public static readonly long[] Value={ 2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,4L,3L,1L,1L,2L,2L,1L,2L,1L,1L,3L,1L,3L,2L,1L,3L,3L,1L,1L,2L,2L,1L,2L,1L,1L,2L,3L,1L,2L,1L,3L,3L,1L,4L,3L,2L,1L,2L,1L,1L,2L,1L,1L,2L,1L,3L,3L,2L,4L,5L,2L,1L,3L,1L,3L,2L,1L,1L,2L,3L,7L,3L,1L,1L,2L,2L,1L,3L,4L,1L,2L,1L,3L,5L,1L,7L,8L,1L,1L,2L,3L,3L,2L,1L,1L,3L,1L,1L,5L,5L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103961Inst : IEnumerable<long>
{
public static readonly long[] Value=A103961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103961.Bytes);
public long this[int i]=>Value[i];

public static A103961Inst Instance=new A103961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103962
{
public static readonly long[] Value={ 1521L,4225L,4489L,11449L,15129L,32041L,38025L,67081L,99225L,114921L,136161L,137641L,152881L,173889L,182329L,218089L,221841L,227529L,292681L,294849L,297025L,299209L,301401L,303601L,305809L,308025L,310249L,312481L,314721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103962Inst : IEnumerable<long>
{
public static readonly long[] Value=A103962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103962.Bytes);
public long this[int i]=>Value[i];

public static A103962Inst Instance=new A103962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103963
{
public static readonly long[] Value={ 2L,3L,4L,7L,12L,23L,25L,2551L,800516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103963Inst : IEnumerable<long>
{
public static readonly long[] Value=A103963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103963.Bytes);
public long this[int i]=>Value[i];

public static A103963Inst Instance=new A103963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103964
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,8L,583L,6393L,9715L,33288L,3321063L,5054502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103964Inst : IEnumerable<long>
{
public static readonly long[] Value=A103964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103964.Bytes);
public long this[int i]=>Value[i];

public static A103964Inst Instance=new A103964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103965
{
public static readonly long[] Value={ 9L,27L,41L,81L,111L,113L,117L,183L,191L,219L,231L,261L,279L,281L,309L,321L,339L,363L,377L,399L,401L,411L,429L,449L,461L,467L,477L,479L,497L,503L,513L,539L,549L,567L,603L,633L,653L,659L,689L,693L,707L,723L,731L,737L,747L,773L,843L,849L,887L,891L,911L,917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103965Inst : IEnumerable<long>
{
public static readonly long[] Value=A103965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103965.Bytes);
public long this[int i]=>Value[i];

public static A103965Inst Instance=new A103965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103966
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,43L,61L,73L,103L,109L,131L,151L,181L,193L,199L,229L,241L,271L,283L,313L,349L,389L,433L,449L,491L,503L,563L,569L,577L,593L,599L,607L,613L,653L,659L,683L,733L,739L,757L,947L,953L,977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103966Inst : IEnumerable<long>
{
public static readonly long[] Value=A103966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103966.Bytes);
public long this[int i]=>Value[i];

public static A103966Inst Instance=new A103966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103967
{
public static readonly long[] Value={ 3L,9L,17L,21L,27L,29L,39L,41L,47L,51L,59L,71L,81L,87L,89L,113L,117L,119L,131L,137L,141L,159L,161L,177L,189L,201L,239L,263L,287L,291L,299L,333L,359L,371L,377L,389L,393L,399L,443L,459L,461L,467L,471L,489L,509L,539L,573L,603L,623L,653L,657L,659L,663L,671L,681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103967Inst : IEnumerable<long>
{
public static readonly long[] Value=A103967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103967.Bytes);
public long this[int i]=>Value[i];

public static A103967Inst Instance=new A103967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103968
{
public static readonly long[] Value={ 1L,13L,74L,1092L,4864L,59200L,346112L,4756752L,19436692L,251916288L,1294876800L,20786304000L,79541043200L,1073030266880L,5303003316224L,81061789640832L,324992122224640L,4102172934143680L,20588576135708672L,376372958524932096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103968Inst : IEnumerable<long>
{
public static readonly long[] Value=A103968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103968.Bytes);
public long this[int i]=>Value[i];

public static A103968Inst Instance=new A103968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103969
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,20L,24L,28L,32L,36L,40L,48L,56L,64L,72L,80L,96L,112L,128L,144L,160L,192L,224L,256L,288L,320L,384L,448L,512L,576L,640L,768L,896L,1024L,1152L,1280L,1536L,1792L,2048L,2304L,2560L,3072L,3584L,4096L,4608L,5120L,6144L,7168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103969Inst : IEnumerable<long>
{
public static readonly long[] Value=A103969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103969.Bytes);
public long this[int i]=>Value[i];

public static A103969Inst Instance=new A103969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103970
{
public static readonly long[] Value={ 1L,4L,8L,32L,128L,576L,2688L,13056L,65024L,330752L,1710080L,8962048L,47497216L,254132224L,1370849280L,7447117824L,40707293184L,223731253248L,1235630948352L,6853893292032L,38166664839168L,213288826699776L,1195775593807872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103970Inst : IEnumerable<long>
{
public static readonly long[] Value=A103970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103970.Bytes);
public long this[int i]=>Value[i];

public static A103970Inst Instance=new A103970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103971
{
public static readonly long[] Value={ 1L,5L,10L,45L,190L,930L,4660L,24445L,131190L,719830L,4013260L,22684370L,129661740L,748252580L,4353379560L,25508284445L,150392391590L,891549228430L,5310994644060L,31775749689670L,190860711108740L,1150473009844380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103971Inst : IEnumerable<long>
{
public static readonly long[] Value=A103971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103971.Bytes);
public long this[int i]=>Value[i];

public static A103971Inst Instance=new A103971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103972
{
public static readonly long[] Value={ 1L,6L,12L,60L,264L,1392L,7392L,41424L,236640L,1384512L,8224896L,49554816L,301884672L,1856878080L,11514915840L,71915838720L,451938731520L,2855705994240L,18132621772800L,115637702461440L,740356410961920L,4756888756101120L,30662391191715840L,198229520200704000L,1285001080928845824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103972Inst : IEnumerable<long>
{
public static readonly long[] Value=A103972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103972.Bytes);
public long this[int i]=>Value[i];

public static A103972Inst Instance=new A103972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103973
{
public static readonly long[] Value={ 1L,2L,4L,4L,24L,16L,160L,80L,1120L,448L,8064L,2688L,59136L,16896L,439296L,109824L,3294720L,732160L,24893440L,4978688L,189190144L,34398208L,1444724736L,240787456L,11076222976L,1704034304L,85201715200L,12171673600L,657270374400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103973Inst : IEnumerable<long>
{
public static readonly long[] Value=A103973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103973.Bytes);
public long this[int i]=>Value[i];

public static A103973Inst Instance=new A103973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103974
{
public static readonly long[] Value={ 1L,5L,65L,901L,12545L,174725L,2433601L,33895685L,472105985L,6575588101L,91586127425L,1275630195845L,17767236614401L,247465682405765L,3446752317066305L,48007066756522501L,668652182274248705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103974Inst : IEnumerable<long>
{
public static readonly long[] Value=A103974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103974.Bytes);
public long this[int i]=>Value[i];

public static A103974Inst Instance=new A103974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103975
{
public static readonly BigInteger[] Value={ 16L,240L,3360L,46816L,652080L,9082320L,126500416L,1761923520L,24540428880L,341804080816L,4760716702560L,66308229755040L,923554499868016L,12863454768397200L,179164812257692800L,2495443916839302016L,BigInteger.Parse("34757050023492535440"),BigInteger.Parse("484103256412056194160") };
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
public class A103975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A103975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A103975Inst Instance=new A103975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103976
{
public static readonly long[] Value={ 0L,1L,4L,9L,18L,29L,44L,61L,82L,109L,138L,173L,212L,253L,298L,349L,406L,465L,530L,599L,670L,747L,828L,915L,1010L,1109L,1210L,1315L,1422L,1533L,1658L,1787L,1922L,2059L,2206L,2355L,2510L,2671L,2836L,3007L,3184L,3363L,3552L,3743L,3938L,4135L,4344L,4565L,4790L,5017L,5248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103976Inst : IEnumerable<long>
{
public static readonly long[] Value=A103976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103976.Bytes);
public long this[int i]=>Value[i];

public static A103976Inst Instance=new A103976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103977
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,0L,6L,1L,5L,2L,10L,0L,12L,4L,6L,1L,16L,1L,18L,0L,10L,8L,22L,0L,19L,10L,14L,0L,28L,0L,30L,1L,18L,14L,22L,1L,36L,16L,22L,0L,40L,0L,42L,4L,12L,20L,46L,0L,41L,7L,30L,6L,52L,0L,38L,0L,34L,26L,58L,0L,60L,28L,22L,1L,46L,0L,66L,10L,42L,0L,70L,1L,72L,34L,26L,12L,58L,0L,78L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103977Inst : IEnumerable<long>
{
public static readonly long[] Value=A103977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103977.Bytes);
public long this[int i]=>Value[i];

public static A103977Inst Instance=new A103977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103978
{
public static readonly long[] Value={ 1L,3L,6L,9L,54L,54L,540L,405L,5670L,3402L,61236L,30618L,673596L,288684L,7505784L,2814669L,84440070L,28146690L,956987460L,287096238L,10909657044L,2975361012L,124965162504L,31241290626L,1437099368796L,331638315876L,16581915793800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103978Inst : IEnumerable<long>
{
public static readonly long[] Value=A103978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103978.Bytes);
public long this[int i]=>Value[i];

public static A103978Inst Instance=new A103978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103979
{
public static readonly long[] Value={ 0L,1L,-2L,14L,-4L,166L,-292L,2092L,-136L,28102L,-52412L,131468L,-2264L,5692636L,-10892936L,83688344L,-20155888L,1246068806L,-541124L,2675231852L,-19548472L,40491935468L,-552572485496L,4314388905704L,-13091776816L,65972020761116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103979Inst : IEnumerable<long>
{
public static readonly long[] Value=A103979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103979.Bytes);
public long this[int i]=>Value[i];

public static A103979Inst Instance=new A103979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103980
{
public static readonly BigInteger[] Value={ 1L,1L,3L,45L,35L,4725L,31185L,945945L,289575L,310134825L,3273645375L,50414138775L,5749711695L,102776096548125L,1494206326738125L,92854250304440625L,191898783962510625L,BigInteger.Parse("107655217802968460625") };
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
public class A103980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A103980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A103980Inst Instance=new A103980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103981
{
public static readonly long[] Value={ 0L,0L,2L,1L,3L,2L,2L,3L,4L,2L,3L,5L,4L,2L,3L,3L,7L,2L,4L,2L,5L,2L,4L,2L,4L,4L,4L,3L,4L,4L,3L,2L,6L,2L,4L,4L,4L,3L,5L,3L,6L,3L,3L,4L,4L,3L,4L,3L,6L,3L,4L,4L,5L,2L,5L,3L,7L,3L,3L,3L,5L,3L,4L,4L,7L,5L,3L,3L,4L,3L,8L,2L,5L,4L,4L,3L,4L,4L,4L,4L,7L,5L,3L,3L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103981Inst : IEnumerable<long>
{
public static readonly long[] Value=A103981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103981.Bytes);
public long this[int i]=>Value[i];

public static A103981Inst Instance=new A103981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103982
{
public static readonly long[] Value={ 2L,5L,6L,9L,13L,17L,19L,21L,23L,31L,33L,53L,71L,87L,89L,93L,113L,123L,127L,157L,163L,167L,177L,181L,197L,201L,219L,229L,237L,321L,327L,347L,373L,393L,401L,409L,417L,419L,449L,487L,489L,503L,509L,519L,523L,537L,541L,563L,571L,577L,597L,599L,633L,647L,699L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103982Inst : IEnumerable<long>
{
public static readonly long[] Value=A103982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103982.Bytes);
public long this[int i]=>Value[i];

public static A103982Inst Instance=new A103982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103983
{
public static readonly long[] Value={ 7L,7L,7L,6L,6L,5L,6L,5L,3L,5L,8L,6L,2L,6L,7L,1L,1L,5L,3L,3L,7L,9L,3L,4L,0L,9L,4L,6L,1L,7L,8L,1L,9L,5L,0L,9L,9L,6L,2L,8L,8L,2L,7L,2L,4L,4L,1L,7L,1L,3L,3L,0L,5L,8L,0L,2L,3L,4L,4L,5L,9L,6L,4L,8L,6L,5L,0L,5L,7L,3L,5L,3L,1L,5L,9L,2L,6L,5L,4L,0L,1L,1L,4L,6L,1L,5L,1L,6L,5L,6L,8L,9L,3L,1L,6L,8L,1L,8L,8L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103983Inst : IEnumerable<long>
{
public static readonly long[] Value=A103983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103983.Bytes);
public long this[int i]=>Value[i];

public static A103983Inst Instance=new A103983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103984
{
public static readonly long[] Value={ 8L,7L,8L,5L,3L,0L,9L,1L,5L,2L,6L,7L,4L,8L,0L,2L,7L,7L,1L,7L,8L,9L,1L,6L,7L,9L,6L,3L,3L,6L,2L,2L,4L,7L,4L,9L,5L,1L,1L,8L,9L,6L,9L,9L,1L,0L,8L,9L,7L,6L,8L,3L,2L,5L,1L,3L,7L,6L,1L,6L,2L,9L,0L,9L,6L,1L,1L,9L,0L,3L,7L,9L,9L,3L,2L,7L,9L,4L,9L,9L,7L,2L,5L,4L,3L,4L,6L,3L,4L,9L,4L,8L,4L,2L,9L,7L,0L,1L,1L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103984Inst : IEnumerable<long>
{
public static readonly long[] Value=A103984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103984.Bytes);
public long this[int i]=>Value[i];

public static A103984Inst Instance=new A103984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103985
{
public static readonly long[] Value={ 9L,6L,8L,9L,4L,2L,0L,8L,3L,0L,3L,6L,7L,4L,6L,7L,7L,2L,8L,0L,6L,0L,6L,5L,8L,9L,4L,6L,6L,6L,8L,9L,9L,8L,6L,4L,9L,9L,4L,5L,7L,1L,1L,5L,3L,2L,7L,1L,3L,9L,9L,8L,1L,7L,7L,2L,5L,8L,0L,4L,6L,4L,3L,3L,7L,1L,6L,7L,2L,2L,8L,1L,2L,5L,2L,0L,7L,8L,3L,6L,5L,8L,3L,3L,2L,2L,3L,8L,6L,6L,8L,9L,0L,6L,8L,4L,4L,9L,9L,3L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103985Inst : IEnumerable<long>
{
public static readonly long[] Value=A103985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103985.Bytes);
public long this[int i]=>Value[i];

public static A103985Inst Instance=new A103985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103986
{
public static readonly long[] Value={ 1L,0L,5L,1L,5L,8L,3L,8L,7L,3L,4L,3L,6L,8L,5L,1L,7L,7L,5L,8L,5L,8L,2L,1L,2L,1L,1L,3L,0L,8L,1L,7L,5L,2L,5L,6L,6L,8L,0L,9L,5L,6L,2L,8L,1L,9L,9L,1L,2L,7L,6L,1L,7L,2L,1L,9L,2L,9L,3L,8L,6L,3L,4L,8L,1L,1L,1L,8L,6L,4L,0L,7L,9L,4L,5L,1L,0L,7L,3L,7L,1L,0L,4L,7L,7L,0L,5L,0L,2L,6L,1L,8L,9L,6L,9L,4L,0L,4L,5L,7L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103986Inst : IEnumerable<long>
{
public static readonly long[] Value=A103986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103986.Bytes);
public long this[int i]=>Value[i];

public static A103986Inst Instance=new A103986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103987
{
public static readonly long[] Value={ 1L,1L,2L,8L,1L,6L,5L,3L,4L,0L,2L,4L,1L,2L,5L,9L,9L,8L,4L,6L,6L,1L,2L,0L,0L,9L,3L,9L,4L,5L,3L,2L,3L,2L,1L,8L,5L,4L,5L,6L,3L,2L,5L,1L,2L,3L,1L,5L,3L,9L,8L,0L,4L,0L,9L,7L,9L,4L,0L,7L,1L,4L,3L,3L,3L,9L,8L,1L,4L,3L,0L,5L,3L,7L,3L,3L,1L,0L,0L,0L,1L,6L,4L,1L,5L,8L,3L,8L,0L,6L,5L,0L,3L,1L,6L,9L,4L,5L,3L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103987Inst : IEnumerable<long>
{
public static readonly long[] Value=A103987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103987.Bytes);
public long this[int i]=>Value[i];

public static A103987Inst Instance=new A103987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103988
{
public static readonly long[] Value={ 1L,3L,5L,5L,7L,5L,3L,1L,1L,6L,2L,2L,2L,0L,2L,6L,0L,1L,6L,0L,8L,2L,5L,4L,5L,5L,1L,0L,2L,2L,1L,5L,0L,5L,4L,6L,0L,7L,2L,6L,1L,5L,5L,8L,9L,3L,9L,7L,5L,2L,2L,9L,6L,4L,9L,9L,3L,1L,2L,5L,0L,5L,0L,0L,3L,3L,7L,0L,0L,9L,2L,7L,8L,8L,0L,7L,2L,9L,4L,7L,2L,5L,9L,2L,2L,1L,8L,3L,9L,7L,1L,0L,1L,2L,6L,4L,7L,5L,3L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103988Inst : IEnumerable<long>
{
public static readonly long[] Value=A103988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103988.Bytes);
public long this[int i]=>Value[i];

public static A103988Inst Instance=new A103988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103989
{
public static readonly long[] Value={ 2L,5L,6L,5L,0L,2L,3L,4L,1L,0L,3L,2L,1L,8L,6L,2L,4L,2L,0L,7L,4L,9L,5L,5L,6L,8L,9L,7L,1L,8L,3L,6L,3L,9L,9L,4L,6L,8L,9L,9L,8L,5L,3L,1L,7L,2L,0L,3L,4L,0L,7L,8L,9L,6L,0L,3L,6L,0L,2L,0L,6L,6L,7L,4L,6L,1L,2L,0L,4L,6L,9L,0L,4L,1L,8L,5L,4L,9L,5L,3L,3L,8L,5L,0L,3L,2L,3L,2L,6L,6L,5L,8L,6L,6L,9L,9L,7L,3L,1L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103989Inst : IEnumerable<long>
{
public static readonly long[] Value=A103989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103989.Bytes);
public long this[int i]=>Value[i];

public static A103989Inst Instance=new A103989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103990
{
public static readonly long[] Value={ 2L,6L,50L,38L,74L,386L,206L,310L,1334L,614L,822L,3218L,1370L,1718L,6362L,2582L,3106L,11090L,4358L,5094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103990Inst : IEnumerable<long>
{
public static readonly long[] Value=A103990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103990.Bytes);
public long this[int i]=>Value[i];

public static A103990Inst Instance=new A103990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103991
{
public static readonly long[] Value={ 3L,5L,21L,9L,11L,39L,15L,17L,57L,21L,23L,75L,27L,29L,93L,33L,35L,111L,39L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103991Inst : IEnumerable<long>
{
public static readonly long[] Value=A103991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103991.Bytes);
public long this[int i]=>Value[i];

public static A103991Inst Instance=new A103991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103992
{
public static readonly long[] Value={ 11L,101L,16061L,126202621L,13236323032363231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103992Inst : IEnumerable<long>
{
public static readonly long[] Value=A103992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103992.Bytes);
public long this[int i]=>Value[i];

public static A103992Inst Instance=new A103992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103993
{
public static readonly long[] Value={ 3L,5L,131L,383L,797L,11411L,16061L,16361L,19391L,33533L,36263L,73037L,75557L,79397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103993Inst : IEnumerable<long>
{
public static readonly long[] Value=A103993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103993.Bytes);
public long this[int i]=>Value[i];

public static A103993Inst Instance=new A103993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103994
{
public static readonly long[] Value={ 1L,1L,1L,-1L,0L,1L,1L,1L,0L,1L,-1L,0L,0L,0L,1L,-1L,-1L,1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,-1L,-1L,0L,0L,1L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,1L,-1L,0L,1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103994Inst : IEnumerable<long>
{
public static readonly long[] Value=A103994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103994.Bytes);
public long this[int i]=>Value[i];

public static A103994Inst Instance=new A103994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103995
{
public static readonly BigInteger[] Value={ 1L,-1L,0L,1L,-1L,-6L,35L,181L,-6056L,-3741L,5880885L,-149991434L,-32148902071L,4867910308359L,891980177502800L,-740991835820243639L,BigInteger.Parse("-53134975005564905081"),BigInteger.Parse("626000780698404972023994") };
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
public class A103995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103995Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A103995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103995.Bytes);
public BigInteger this[int i]=>Value[i];

public static A103995Inst Instance=new A103995Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103996
{
public static readonly BigInteger[] Value={ 1L,-1L,2L,-9L,74L,-955L,17744L,-448077L,14751974L,-613569711L,31452344252L,-1947832408225L,143356013568338L,-12366684481981635L,1235842203066704648L,BigInteger.Parse("-141628365906835323573"),BigInteger.Parse("18449654196553852968254") };
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
public class A103996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103996Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A103996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103996.Bytes);
public BigInteger this[int i]=>Value[i];

public static A103996Inst Instance=new A103996Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103997
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,11L,7L,1L,1L,41L,71L,18L,1L,1L,153L,769L,539L,47L,1L,1L,571L,8449L,17753L,4271L,123L,1L,1L,2131L,93127L,603126L,434657L,34276L,322L,1L,1L,7953L,1027207L,20721019L,46069729L,10894561L,276119L,843L,1L,1L,29681L,11332097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103997Inst : IEnumerable<long>
{
public static readonly long[] Value=A103997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103997.Bytes);
public long this[int i]=>Value[i];

public static A103997Inst Instance=new A103997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103998
{
public static readonly long[] Value={ 1L,11L,71L,539L,4271L,34276L,276119L,2226851L,17965151L,144948419L,1169523076L,9436433171L,76139155439L,614339685971L,4956888901511L,39995380044004L,322708555336511L,2603821045832171L,21009309912323639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103998Inst : IEnumerable<long>
{
public static readonly long[] Value=A103998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103998.Bytes);
public long this[int i]=>Value[i];

public static A103998Inst Instance=new A103998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A103999
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,16L,34L,1L,1L,54L,196L,198L,1L,1L,196L,1666L,2704L,1154L,1L,1L,726L,16384L,64152L,37636L,6726L,1L,1L,2704L,171394L,1844164L,2549186L,524176L,39202L,1L,1L,10086L,1844164L,57523158L,220581904L,101757654L,7300804L,228486L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A103999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A103999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A103999Inst : IEnumerable<long>
{
public static readonly long[] Value=A103999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A103999.Bytes);
public long this[int i]=>Value[i];

public static A103999Inst Instance=new A103999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104000
{
public static readonly long[] Value={ 2L,4L,2L,6L,12L,2L,8L,30L,28L,2L,10L,56L,126L,84L,2L,12L,90L,344L,630L,244L,2L,14L,132L,730L,2408L,3126L,732L,2L,16L,182L,1332L,6570L,16808L,15630L,2188L,2L,18L,240L,2198L,14652L,59050L,117656L,78126L,6564L,2L,20L,306L,3376L,28574L,161052L,531450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104000Inst : IEnumerable<long>
{
public static readonly long[] Value=A104000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104000.Bytes);
public long this[int i]=>Value[i];

public static A104000Inst Instance=new A104000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104001
{
public static readonly long[] Value={ 2L,4L,6L,8L,18L,24L,16L,54L,96L,120L,32L,162L,384L,600L,720L,64L,486L,1536L,3000L,4320L,5040L,128L,1458L,6144L,15000L,25920L,35280L,40320L,256L,4374L,24576L,75000L,155520L,246960L,322560L,362880L,512L,13122L,98304L,375000L,933120L,1728720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104001Inst : IEnumerable<long>
{
public static readonly long[] Value=A104001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104001.Bytes);
public long this[int i]=>Value[i];

public static A104001Inst Instance=new A104001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104002
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,12L,6L,1L,5L,32L,27L,8L,1L,6L,80L,108L,48L,10L,1L,7L,192L,405L,256L,75L,12L,1L,8L,448L,1458L,1280L,500L,108L,14L,1L,9L,1024L,5103L,6144L,3125L,864L,147L,16L,1L,10L,2304L,17496L,28672L,18750L,6480L,1372L,192L,18L,1L,11L,5120L,59049L,131072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104002Inst : IEnumerable<long>
{
public static readonly long[] Value=A104002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104002.Bytes);
public long this[int i]=>Value[i];

public static A104002Inst Instance=new A104002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104003
{
public static readonly BigInteger[] Value={ 6L,306L,29700L,4798080L,1178634240L,412483246560L,195891696000000L,121597736131872000L,BigInteger.Parse("95776583838282547200"),BigInteger.Parse("93456899248404570278400"),BigInteger.Parse("110767880742079885561036800"),BigInteger.Parse("156855803355661410000000000000"),BigInteger.Parse("261695274412151118929854464000000"),BigInteger.Parse("508262037307349207558239385902080000") };
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
public class A104003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104003Inst Instance=new A104003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104004
{
public static readonly long[] Value={ 1L,3L,7L,16L,35L,75L,158L,329L,679L,1392L,2839L,5767L,11678L,23589L,47555L,95720L,192427L,386451L,775486L,1555153L,3117071L,6245088L,12507887L,25044431L,50135230L,100345485L,200812363L,401821144L,803960099L,1608434427L,3217700894L,6436748057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104004Inst : IEnumerable<long>
{
public static readonly long[] Value=A104004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104004.Bytes);
public long this[int i]=>Value[i];

public static A104004Inst Instance=new A104004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104005
{
public static readonly long[] Value={ 1L,-1L,3L,-2L,9L,-3L,28L,1L,91L,38L,309L,241L,1092L,1197L,3991L,5398L,14977L,23189L,57324L,96937L,222531L,398694L,872413L,1623433L,3443284L,6568757L,13651743L,26471446L,54289161L,106400013L,216324604L,426946321L,863120107L,1711309862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104005Inst : IEnumerable<long>
{
public static readonly long[] Value=A104005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104005.Bytes);
public long this[int i]=>Value[i];

public static A104005Inst Instance=new A104005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104006
{
public static readonly long[] Value={ 19L,31L,43L,67L,71L,79L,103L,131L,139L,191L,223L,239L,283L,311L,367L,419L,431L,439L,443L,499L,599L,607L,619L,643L,647L,659L,683L,743L,787L,823L,827L,907L,947L,971L,1031L,1039L,1087L,1091L,1103L,1163L,1223L,1259L,1399L,1427L,1447L,1499L,1511L,1543L,1559L,1571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104006Inst : IEnumerable<long>
{
public static readonly long[] Value=A104006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104006.Bytes);
public long this[int i]=>Value[i];

public static A104006Inst Instance=new A104006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104007
{
public static readonly ulong[] Value={ 4L,2L,12L,6L,60L,90L,378L,945L,2700L,9450L,20790L,93555L,116093250L,638512875L,1403325L,18243225L,43418875500L,325641566250L,4585799468250L,38979295480125L,161192575293750L,1531329465290625L,640374140030625L,13447856940643125L,17558223649022306250UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104007Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A104007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104007.Bytes);
public ulong this[int i]=>Value[i];

public static A104007Inst Instance=new A104007Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104008
{
public static readonly BigInteger[] Value={ 120L,25080L,4890480L,949077360L,184120982760L,35718589344360L,6929223155685600L,1344233586759971040L,BigInteger.Parse("260774386791383159640"),BigInteger.Parse("50588886806491889178840"),BigInteger.Parse("9813983266108156439587920"),BigInteger.Parse("1903862164738670605583434320"),BigInteger.Parse("369339445976042880280120411080") };
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
public class A104008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104008Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104008.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104008Inst Instance=new A104008Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104009
{
public static readonly BigInteger[] Value={ 0L,12L,1848L,351780L,68149872L,13219419708L,2564481115560L,497495864091732L,96511629630137568L,BigInteger.Parse("18722758603319903340"),BigInteger.Parse("3632118656731075949592"),BigInteger.Parse("704612296637707504759428"),BigInteger.Parse("136691153428925957468727120"),BigInteger.Parse("26517379152913151616036727452"),BigInteger.Parse("5144234864511696770165553009288") };
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
public class A104009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104009Inst Instance=new A104009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104010
{
public static readonly long[] Value={ 16L,20L,28L,32L,40L,52L,68L,80L,88L,100L,112L,128L,140L,152L,172L,200L,208L,212L,220L,268L,308L,320L,340L,352L,388L,392L,452L,460L,472L,508L,520L,532L,548L,560L,620L,628L,668L,700L,712L,740L,752L,772L,872L,892L,920L,928L,1012L,1088L,1120L,1132L,1148L,1180L,1192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104010Inst : IEnumerable<long>
{
public static readonly long[] Value=A104010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104010.Bytes);
public long this[int i]=>Value[i];

public static A104010Inst Instance=new A104010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104011
{
public static readonly long[] Value={ 0L,2L,2L,2L,3L,2L,2L,3L,3L,3L,4L,2L,4L,4L,2L,2L,3L,3L,3L,3L,3L,2L,4L,3L,3L,3L,2L,4L,4L,3L,2L,6L,3L,3L,4L,2L,2L,5L,3L,3L,6L,3L,4L,3L,2L,4L,4L,4L,3L,4L,3L,3L,4L,3L,2L,3L,3L,4L,5L,4L,3L,3L,4L,2L,5L,3L,3L,7L,3L,2L,3L,3L,4L,4L,2L,3L,5L,4L,3L,3L,3L,2L,4L,3L,4L,4L,4L,4L,3L,4L,3L,4L,4L,3L,5L,3L,3L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104011Inst : IEnumerable<long>
{
public static readonly long[] Value=A104011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104011.Bytes);
public long this[int i]=>Value[i];

public static A104011Inst Instance=new A104011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104012
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,14L,15L,21L,26L,30L,35L,36L,44L,54L,63L,69L,74L,81L,114L,128L,131L,135L,138L,153L,165L,168L,191L,194L,209L,216L,224L,228L,231L,239L,261L,270L,303L,315L,321L,323L,326L,330L,336L,345L,363L,380L,384L,398L,404L,410L,411L,414L,429L,440L,443L,455L,468L,470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104012Inst : IEnumerable<long>
{
public static readonly long[] Value=A104012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104012.Bytes);
public long this[int i]=>Value[i];

public static A104012Inst Instance=new A104012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104013
{
public static readonly ulong[] Value={ 0L,0L,10L,0L,1100L,10L,100L,0L,111000L,1100L,1011101000L,10L,100111011000L,100L,1000L,0L,11110000L,111000L,110101111001010000L,1100L,110000L,1011101000L,10110010000L,10L,10100011110101110000UL,100111011000L,100101111011010000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104013Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A104013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104013.Bytes);
public ulong this[int i]=>Value[i];

public static A104013Inst Instance=new A104013Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104014
{
public static readonly long[] Value={ 0L,0L,2L,0L,12L,2L,4L,0L,56L,12L,744L,2L,2520L,4L,8L,0L,240L,56L,220752L,12L,48L,744L,1424L,2L,671088L,2520L,155344L,4L,148102320L,8L,16L,0L,992L,240L,3744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104014Inst : IEnumerable<long>
{
public static readonly long[] Value=A104014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104014.Bytes);
public long this[int i]=>Value[i];

public static A104014Inst Instance=new A104014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104015
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104015Inst : IEnumerable<long>
{
public static readonly long[] Value=A104015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104015.Bytes);
public long this[int i]=>Value[i];

public static A104015Inst Instance=new A104015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104016
{
public static readonly long[] Value={ 561L,1105L,1729L,2465L,2821L,6601L,8911L,10585L,11305L,15841L,29341L,39865L,41041L,46657L,52633L,62745L,63973L,75361L,96985L,101101L,115921L,126217L,162401L,172081L,188461L,252601L,278545L,294409L,314821L,334153L,340561L,399001L,401401L,410041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104016Inst : IEnumerable<long>
{
public static readonly long[] Value=A104016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104016.Bytes);
public long this[int i]=>Value[i];

public static A104016Inst Instance=new A104016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104017
{
public static readonly long[] Value={ 11305L,39865L,96985L,401401L,464185L,786961L,1106785L,1296505L,1719601L,1993537L,2242513L,2615977L,2649361L,2722681L,3165961L,3181465L,3755521L,4168801L,4229601L,4483297L,4698001L,5034601L,5381265L,5910121L,5977153L,7177105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104017Inst : IEnumerable<long>
{
public static readonly long[] Value=A104017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104017.Bytes);
public long this[int i]=>Value[i];

public static A104017Inst Instance=new A104017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104018
{
public static readonly long[] Value={ 0L,1L,2L,6L,28L,180L,1448L,13944L,156592L,2010000L,29026592L,465749856L,8220541888L,158283827520L,3301678947968L,74168218575744L,1785106271372032L,45828856887701760L,1250094695454351872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104018Inst : IEnumerable<long>
{
public static readonly long[] Value=A104018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104018.Bytes);
public long this[int i]=>Value[i];

public static A104018Inst Instance=new A104018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104019
{
public static readonly long[] Value={ 1663L,1666L,1674L,1731L,1734L,1742L,1883L,1886L,1894L,1943L,1951L,2035L,2038L,2046L,2103L,2187L,2190L,2198L,2255L,2258L,2266L,2323L,2326L,2334L,2407L,2410L,2418L,2491L,2559L,2570L,2573L,2581L,2627L,2630L,2638L,2779L,2782L,2790L,2874L,2877L,2885L,2931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104019Inst : IEnumerable<long>
{
public static readonly long[] Value=A104019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104019.Bytes);
public long this[int i]=>Value[i];

public static A104019Inst Instance=new A104019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104020
{
public static readonly long[] Value={ 4L,9L,16L,18L,25L,32L,36L,48L,49L,50L,64L,72L,75L,81L,98L,100L,108L,121L,128L,144L,147L,162L,169L,180L,192L,196L,200L,225L,242L,243L,245L,256L,288L,289L,294L,300L,320L,324L,338L,361L,363L,384L,392L,400L,405L,432L,441L,448L,450L,484L,486L,500L,507L,512L,529L,567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104020Inst : IEnumerable<long>
{
public static readonly long[] Value=A104020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104020.Bytes);
public long this[int i]=>Value[i];

public static A104020Inst Instance=new A104020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104021
{
public static readonly long[] Value={ 4L,9L,16L,18L,25L,36L,48L,49L,50L,64L,75L,81L,98L,100L,121L,144L,147L,162L,169L,180L,192L,196L,225L,242L,245L,256L,289L,294L,300L,320L,324L,338L,361L,363L,400L,405L,441L,448L,450L,484L,507L,529L,567L,576L,578L,588L,605L,625L,648L,676L,700L,720L,722L,726L,729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104021Inst : IEnumerable<long>
{
public static readonly long[] Value=A104021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104021.Bytes);
public long this[int i]=>Value[i];

public static A104021Inst Instance=new A104021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104022
{
public static readonly long[] Value={ 64L,100L,144L,196L,256L,324L,400L,484L,512L,576L,648L,676L,729L,784L,800L,900L,968L,1024L,1089L,1152L,1156L,1296L,1352L,1444L,1521L,1568L,1600L,1728L,1764L,1800L,1936L,2025L,2028L,2048L,2116L,2304L,2312L,2352L,2500L,2592L,2601L,2700L,2704L,2888L,2916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104022Inst : IEnumerable<long>
{
public static readonly long[] Value=A104022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104022.Bytes);
public long this[int i]=>Value[i];

public static A104022Inst Instance=new A104022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104023
{
public static readonly long[] Value={ 100L,196L,324L,484L,676L,900L,1089L,1156L,1444L,1521L,1764L,2028L,2116L,2304L,2500L,2601L,2916L,3249L,3364L,3468L,3600L,3844L,4332L,4356L,4624L,4761L,4900L,5476L,5625L,5776L,6084L,6348L,6498L,6724L,7056L,7396L,7500L,7569L,8100L,8464L,8649L,8820L,8836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104023Inst : IEnumerable<long>
{
public static readonly long[] Value=A104023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104023.Bytes);
public long this[int i]=>Value[i];

public static A104023Inst Instance=new A104023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104024
{
public static readonly long[] Value={ 2L,1L,64L,900L,5184L,32400L,57600L,176400L,705600L,1166400L,3240000L,6350400L,14288400L,37454400L,25401600L,87609600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104024Inst : IEnumerable<long>
{
public static readonly long[] Value=A104024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104024.Bytes);
public long this[int i]=>Value[i];

public static A104024Inst Instance=new A104024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104025
{
public static readonly long[] Value={ 2L,1L,100L,900L,44100L,108900L,1232100L,11492100L,5336100L,12744900L,97416900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104025Inst : IEnumerable<long>
{
public static readonly long[] Value=A104025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104025.Bytes);
public long this[int i]=>Value[i];

public static A104025Inst Instance=new A104025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104026
{
public static readonly long[] Value={ 32L,72L,108L,128L,200L,243L,288L,384L,392L,432L,486L,500L,512L,600L,675L,800L,864L,972L,1125L,1152L,1176L,1323L,1350L,1372L,1440L,1536L,1568L,1728L,1944L,1960L,2000L,2048L,2187L,2250L,2400L,2560L,2592L,2646L,2700L,2904L,3087L,3125L,3200L,3240L,3267L,3380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104026Inst : IEnumerable<long>
{
public static readonly long[] Value=A104026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104026.Bytes);
public long this[int i]=>Value[i];

public static A104026Inst Instance=new A104026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104027
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-3L,1L,-7L,12L,-6L,1L,41L,-73L,41L,-10L,1L,-376L,675L,-390L,105L,-15L,1L,5033L,-9048L,5256L,-1446L,225L,-21L,1L,-92821L,166901L,-97034L,26796L,-4242L,427L,-28L,1L,2257166L,-4058703L,2359939L,-652054L,103515L,-10570L,742L,-36L,1L,-69981919L,125837748L,-73169550L,20218251L,-3210939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104027Inst : IEnumerable<long>
{
public static readonly long[] Value=A104027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104027.Bytes);
public long this[int i]=>Value[i];

public static A104027Inst Instance=new A104027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104028
{
public static readonly BigInteger[] Value={ 1L,-3L,12L,-73L,675L,-9048L,166901L,-4058703L,125837748L,-4845013765L,226796981895L,-12684595018992L,835391818484873L,-63990023222817531L,5640684058036591260L,BigInteger.Parse("-566948619030797914657"),BigInteger.Parse("64452061572236327204235"),BigInteger.Parse("-8228252550026752605862344") };
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
public class A104028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104028Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104028.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104028Inst Instance=new A104028Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104029
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,4L,13L,9L,1L,5L,26L,35L,14L,1L,6L,45L,96L,75L,20L,1L,7L,71L,216L,267L,140L,27L,1L,8L,105L,427L,750L,623L,238L,35L,1L,9L,148L,770L,1800L,2123L,1288L,378L,44L,1L,10L,201L,1296L,3858L,6046L,5211L,2436L,570L,54L,1L,11L,265L,2067L,7590L,15115L,17303L,11505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104029Inst : IEnumerable<long>
{
public static readonly long[] Value=A104029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104029.Bytes);
public long this[int i]=>Value[i];

public static A104029Inst Instance=new A104029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104030
{
public static readonly long[] Value={ 1L,-2L,1L,7L,-5L,1L,-41L,32L,-9L,1L,376L,-299L,91L,-14L,1L,-5033L,4015L,-1241L,205L,-20L,1L,92821L,-74080L,22954L,-3842L,400L,-27L,1L,-2257166L,1801537L,-558402L,93652L,-9863L,707L,-35L,1L,69981919L,-55855829L,17313721L,-2904530L,306409L,-22190L,1162L,-44L,1L,-2694447797L,2150565968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104030Inst : IEnumerable<long>
{
public static readonly long[] Value=A104030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104030.Bytes);
public long this[int i]=>Value[i];

public static A104030Inst Instance=new A104030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104031
{
public static readonly BigInteger[] Value={ 1L,-5L,32L,-299L,4015L,-74080L,1801537L,-55855829L,2150565968L,-100668835739L,5630336915071L,-370807060847872L,28403381397111649L,-2503741873703550533L,BigInteger.Parse("251652633457563092096"),BigInteger.Parse("-28608467296650576313259"),BigInteger.Parse("3652291148549164761101551"),BigInteger.Parse("-520296573821474451201241696") };
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
public class A104031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104031Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104031.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104031Inst Instance=new A104031Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104032
{
public static readonly BigInteger[] Value={ 1L,3L,13L,83L,781L,10515L,194125L,4721363L,146385805L,5636169363L,263831355085L,14755901813843L,971805538480141L,74439152531508243L,6561768848473177933L,BigInteger.Parse("659527417026466047443"),BigInteger.Parse("74976638559342869785741") };
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
public class A104032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104032Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A104032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104032.Bytes);
public BigInteger this[int i]=>Value[i];

public static A104032Inst Instance=new A104032Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104033
{
public static readonly long[] Value={ 1L,-3L,1L,25L,-10L,1L,-427L,175L,-21L,1L,12465L,-5124L,630L,-36L,1L,-555731L,228525L,-28182L,1650L,-55L,1L,35135945L,-14449006L,1782495L,-104676L,3575L,-78L,1L,-2990414715L,1229758075L,-151714563L,8912475L,-305305L,6825L,-105L,1L,329655706465L,-135565467080L,16724709820L,-982532408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104033Inst : IEnumerable<long>
{
public static readonly long[] Value=A104033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104033.Bytes);
public long this[int i]=>Value[i];

public static A104033Inst Instance=new A104033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104034
{
public static readonly long[] Value={ 3L,8L,57L,3L,8L,141L,3L,8L,49L,8L,84L,3L,8L,57L,84L,3L,8L,57L,3L,8L,57L,3L,8L,73L,3L,8L,73L,68L,11L,3L,8L,46L,3L,8L,141L,3L,8L,84L,3L,8L,46L,11L,3L,8L,49L,8L,73L,11L,3L,54L,3L,8L,84L,3L,8L,46L,3L,8L,84L,68L,3L,8L,46L,11L,3L,8L,73L,3L,8L,141L,11L,3L,8L,46L,3L,8L,57L,84L,3L,8L,84L,3L,8L,46L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104034Inst : IEnumerable<long>
{
public static readonly long[] Value=A104034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104034.Bytes);
public long this[int i]=>Value[i];

public static A104034Inst Instance=new A104034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104035
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,5L,0L,6L,5L,0L,28L,0L,24L,0L,61L,0L,180L,0L,120L,61L,0L,662L,0L,1320L,0L,720L,0L,1385L,0L,7266L,0L,10920L,0L,5040L,1385L,0L,24568L,0L,83664L,0L,100800L,0L,40320L,0L,50521L,0L,408360L,0L,1023120L,0L,1028160L,0L,362880L,50521L,0L,1326122L,0L,6749040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104035Inst : IEnumerable<long>
{
public static readonly long[] Value=A104035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104035.Bytes);
public long this[int i]=>Value[i];

public static A104035Inst Instance=new A104035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104036
{
public static readonly long[] Value={ 4L,7L,10L,12L,14L,17L,19L,21L,23L,26L,29L,31L,33L,36L,37L,40L,43L,46L,48L,50L,52L,55L,57L,59L,62L,64L,66L,69L,71L,74L,76L,79L,80L,84L,85L,89L,90L,92L,96L,98L,101L,102L,105L,107L,109L,112L,115L,117L,119L,122L,125L,127L,128L,132L,134L,136L,138L,141L,143L,145L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104036Inst : IEnumerable<long>
{
public static readonly long[] Value=A104036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104036.Bytes);
public long this[int i]=>Value[i];

public static A104036Inst Instance=new A104036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104037
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104037Inst : IEnumerable<long>
{
public static readonly long[] Value=A104037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104037.Bytes);
public long this[int i]=>Value[i];

public static A104037Inst Instance=new A104037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104038
{
public static readonly long[] Value={ 1L,2L,3L,12L,8L,3L,5L,14L,17L,69L,189L,42L,392L,377L,12L,2007L,434L,744L,705L,1089L,1109L,7833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104038Inst : IEnumerable<long>
{
public static readonly long[] Value=A104038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104038.Bytes);
public long this[int i]=>Value[i];

public static A104038Inst Instance=new A104038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104039
{
public static readonly long[] Value={ 1L,2L,8L,12L,40L,48L,128L,108L,220L,336L,240L,432L,640L,504L,1012L,1248L,1624L,960L,1320L,1680L,1728L,1872L,3280L,3520L,3072L,4000L,3264L,5512L,3888L,5376L,4536L,6240L,8704L,6072L,10656L,6000L,7488L,8748L,13612L,14448L,15664L,8640L,13680L,12288L,16464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104039Inst : IEnumerable<long>
{
public static readonly long[] Value=A104039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104039.Bytes);
public long this[int i]=>Value[i];

public static A104039Inst Instance=new A104039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A104040
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,4L,4L,3L,1L,8L,8L,8L,4L,1L,16L,16L,20L,12L,5L,1L,32L,32L,48L,32L,18L,6L,1L,64L,64L,112L,80L,56L,24L,7L,1L,128L,128L,256L,192L,160L,80L,32L,8L,1L,256L,256L,576L,448L,432L,240L,120L,40L,9L,1L,512L,512L,1280L,1024L,1120L,672L,400L,160L,50L,10L,1L,1024L,1024L,2816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A104040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A104040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A104040Inst : IEnumerable<long>
{
public static readonly long[] Value=A104040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A104040.Bytes);
public long this[int i]=>Value[i];

public static A104040Inst Instance=new A104040Inst();

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