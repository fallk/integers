using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A106941
{
public static readonly long[] Value={ 5L,43L,73L,131L,179L,229L,263L,367L,521L,569L,811L,953L,997L,1009L,1021L,1051L,1151L,1163L,1279L,1283L,1307L,1409L,1429L,1439L,1607L,1697L,1747L,1783L,1823L,2017L,2069L,2213L,2221L,2237L,2393L,2659L,2699L,2741L,2801L,2819L,3001L,3253L,3271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106941Inst : IEnumerable<long>
{
public static readonly long[] Value=A106941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106941.Bytes);
public long this[int i]=>Value[i];

public static A106941Inst Instance=new A106941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106942
{
public static readonly long[] Value={ 3L,29L,103L,109L,191L,271L,409L,499L,503L,557L,587L,613L,1031L,1193L,1237L,1321L,1619L,1637L,1657L,1693L,1873L,1949L,2251L,2281L,2417L,2423L,2459L,2687L,2969L,3089L,3167L,3413L,3491L,3607L,3697L,3769L,3793L,3863L,3911L,4261L,4339L,4447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106942Inst : IEnumerable<long>
{
public static readonly long[] Value=A106942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106942.Bytes);
public long this[int i]=>Value[i];

public static A106942Inst Instance=new A106942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106943
{
public static readonly long[] Value={ 3L,29L,89L,103L,109L,151L,157L,191L,271L,379L,409L,419L,499L,503L,557L,587L,593L,613L,659L,677L,787L,853L,857L,977L,1031L,1069L,1103L,1181L,1193L,1237L,1297L,1321L,1493L,1523L,1531L,1571L,1619L,1637L,1657L,1693L,1723L,1787L,1871L,1873L,1949L,1993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106943Inst : IEnumerable<long>
{
public static readonly long[] Value=A106943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106943.Bytes);
public long this[int i]=>Value[i];

public static A106943Inst Instance=new A106943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106944
{
public static readonly long[] Value={ 3L,89L,151L,157L,379L,419L,593L,659L,677L,787L,853L,857L,977L,1069L,1103L,1181L,1297L,1493L,1523L,1531L,1571L,1723L,1787L,1871L,1993L,2131L,2383L,2441L,2503L,2543L,2647L,2833L,2897L,2927L,3011L,3019L,3527L,3631L,3779L,3923L,4001L,4021L,4057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106944Inst : IEnumerable<long>
{
public static readonly long[] Value=A106944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106944.Bytes);
public long this[int i]=>Value[i];

public static A106944Inst Instance=new A106944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106945
{
public static readonly long[] Value={ 2L,19L,233L,277L,311L,463L,641L,797L,829L,929L,941L,1019L,1303L,1381L,1399L,1511L,1709L,1733L,1753L,1777L,1933L,2063L,2089L,2273L,2549L,2707L,2713L,2777L,2971L,3083L,3323L,3347L,3529L,3767L,3907L,3943L,4013L,4019L,4289L,4451L,4621L,4729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106945Inst : IEnumerable<long>
{
public static readonly long[] Value=A106945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106945.Bytes);
public long this[int i]=>Value[i];

public static A106945Inst Instance=new A106945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106946
{
public static readonly long[] Value={ 2L,19L,37L,83L,101L,199L,223L,233L,251L,277L,311L,313L,431L,463L,547L,571L,641L,719L,797L,821L,829L,839L,929L,941L,983L,1019L,1097L,1129L,1303L,1327L,1381L,1399L,1447L,1499L,1511L,1549L,1669L,1709L,1733L,1753L,1777L,1847L,1933L,1997L,2003L,2063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106946Inst : IEnumerable<long>
{
public static readonly long[] Value=A106946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106946.Bytes);
public long this[int i]=>Value[i];

public static A106946Inst Instance=new A106946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106947
{
public static readonly long[] Value={ 2L,37L,83L,101L,199L,223L,251L,313L,431L,547L,571L,719L,821L,839L,983L,1097L,1129L,1327L,1447L,1499L,1549L,1669L,1847L,1997L,2003L,2113L,2203L,2207L,2287L,2297L,2593L,2663L,3061L,3169L,3259L,3361L,3391L,3457L,3511L,3559L,3593L,3821L,3877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106947Inst : IEnumerable<long>
{
public static readonly long[] Value=A106947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106947.Bytes);
public long this[int i]=>Value[i];

public static A106947Inst Instance=new A106947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106948
{
public static readonly long[] Value={ 107L,293L,509L,647L,739L,971L,1013L,1039L,1123L,1217L,1361L,1367L,1373L,1423L,1663L,1811L,2083L,2099L,2239L,2309L,2351L,2657L,2677L,2917L,3181L,3343L,3517L,3533L,3539L,3623L,3671L,3803L,4003L,4079L,4253L,4483L,4691L,4957L,5273L,5581L,5783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106948Inst : IEnumerable<long>
{
public static readonly long[] Value=A106948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106948.Bytes);
public long this[int i]=>Value[i];

public static A106948Inst Instance=new A106948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106949
{
public static readonly long[] Value={ 2L,11L,17L,41L,59L,83L,89L,107L,113L,131L,137L,179L,227L,233L,251L,257L,281L,347L,353L,401L,419L,443L,449L,467L,491L,521L,563L,569L,587L,593L,617L,641L,659L,683L,761L,809L,827L,857L,881L,929L,947L,953L,971L,977L,1019L,1049L,1091L,1097L,1163L,1187L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106949Inst : IEnumerable<long>
{
public static readonly long[] Value=A106949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106949.Bytes);
public long this[int i]=>Value[i];

public static A106949Inst Instance=new A106949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106950
{
public static readonly long[] Value={ 19L,43L,67L,73L,97L,139L,163L,193L,211L,241L,283L,307L,313L,331L,337L,379L,409L,433L,457L,499L,523L,547L,571L,577L,601L,619L,643L,673L,691L,739L,769L,787L,811L,859L,883L,907L,937L,1009L,1033L,1051L,1123L,1129L,1153L,1171L,1201L,1249L,1291L,1297L,1321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106950Inst : IEnumerable<long>
{
public static readonly long[] Value=A106950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106950.Bytes);
public long this[int i]=>Value[i];

public static A106950Inst Instance=new A106950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106951
{
public static readonly long[] Value={ 3L,7L,13L,37L,43L,67L,73L,97L,127L,193L,223L,277L,283L,337L,367L,373L,397L,433L,457L,463L,487L,523L,547L,577L,607L,613L,643L,727L,733L,787L,823L,853L,877L,883L,907L,937L,967L,997L,1033L,1087L,1123L,1153L,1213L,1297L,1303L,1327L,1423L,1447L,1453L,1483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106951Inst : IEnumerable<long>
{
public static readonly long[] Value=A106951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106951.Bytes);
public long this[int i]=>Value[i];

public static A106951Inst Instance=new A106951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106952
{
public static readonly long[] Value={ 3L,7L,13L,37L,43L,67L,73L,97L,103L,127L,157L,163L,193L,223L,277L,283L,307L,313L,337L,367L,373L,397L,433L,457L,463L,487L,523L,547L,577L,607L,613L,643L,673L,727L,733L,757L,787L,823L,853L,877L,883L,907L,937L,967L,997L,1033L,1063L,1087L,1093L,1117L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106952Inst : IEnumerable<long>
{
public static readonly long[] Value=A106952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106952.Bytes);
public long this[int i]=>Value[i];

public static A106952Inst Instance=new A106952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106953
{
public static readonly long[] Value={ 5L,11L,47L,73L,139L,191L,229L,263L,277L,283L,347L,349L,457L,461L,541L,613L,631L,719L,727L,757L,821L,881L,883L,1013L,1049L,1061L,1087L,1103L,1201L,1223L,1303L,1451L,1483L,1487L,1493L,1531L,1567L,1583L,1601L,1621L,1697L,1733L,1759L,1811L,1847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106953Inst : IEnumerable<long>
{
public static readonly long[] Value=A106953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106953.Bytes);
public long this[int i]=>Value[i];

public static A106953Inst Instance=new A106953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106954
{
public static readonly long[] Value={ 5L,7L,11L,17L,43L,47L,61L,73L,131L,137L,139L,149L,191L,199L,229L,233L,239L,251L,263L,277L,283L,311L,347L,349L,359L,389L,397L,443L,457L,461L,463L,467L,499L,541L,557L,577L,587L,613L,617L,631L,643L,647L,653L,691L,719L,727L,739L,757L,761L,769L,809L,821L,823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106954Inst : IEnumerable<long>
{
public static readonly long[] Value=A106954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106954.Bytes);
public long this[int i]=>Value[i];

public static A106954Inst Instance=new A106954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106955
{
public static readonly long[] Value={ 5L,7L,17L,43L,61L,131L,137L,149L,199L,233L,239L,251L,311L,359L,389L,397L,443L,463L,467L,499L,557L,577L,587L,617L,643L,647L,653L,691L,739L,761L,769L,809L,823L,859L,937L,997L,1069L,1109L,1163L,1277L,1279L,1289L,1373L,1423L,1429L,1453L,1489L,1559L,1613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106955Inst : IEnumerable<long>
{
public static readonly long[] Value=A106955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106955.Bytes);
public long this[int i]=>Value[i];

public static A106955Inst Instance=new A106955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106956
{
public static readonly long[] Value={ 5L,23L,67L,73L,151L,269L,337L,421L,431L,439L,557L,593L,643L,733L,761L,887L,1117L,1171L,1229L,1249L,1319L,1381L,1511L,1543L,1667L,1811L,2063L,2099L,2213L,2333L,2389L,2467L,2539L,2549L,2609L,2707L,2741L,2801L,2927L,3067L,3169L,3191L,3343L,3391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106956Inst : IEnumerable<long>
{
public static readonly long[] Value=A106956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106956.Bytes);
public long this[int i]=>Value[i];

public static A106956Inst Instance=new A106956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106957
{
public static readonly long[] Value={ 5L,19L,23L,67L,73L,97L,131L,151L,239L,269L,277L,281L,337L,347L,421L,431L,433L,439L,557L,569L,593L,599L,641L,643L,683L,733L,761L,773L,787L,839L,857L,887L,911L,997L,1013L,1021L,1049L,1063L,1069L,1117L,1129L,1171L,1229L,1249L,1283L,1319L,1381L,1427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106957Inst : IEnumerable<long>
{
public static readonly long[] Value=A106957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106957.Bytes);
public long this[int i]=>Value[i];

public static A106957Inst Instance=new A106957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106958
{
public static readonly long[] Value={ 5L,19L,97L,131L,239L,277L,281L,347L,433L,569L,599L,641L,683L,773L,787L,839L,857L,911L,997L,1013L,1021L,1049L,1063L,1069L,1129L,1283L,1427L,1447L,1453L,1487L,1699L,1783L,1907L,1951L,2027L,2143L,2153L,2179L,2293L,2309L,2381L,2617L,2671L,2683L,2699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106958Inst : IEnumerable<long>
{
public static readonly long[] Value=A106958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106958.Bytes);
public long this[int i]=>Value[i];

public static A106958Inst Instance=new A106958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106959
{
public static readonly long[] Value={ 2L,13L,31L,181L,257L,263L,283L,383L,457L,467L,499L,547L,653L,719L,751L,809L,821L,919L,971L,1091L,1151L,1187L,1217L,1223L,1237L,1423L,1471L,1709L,1721L,1747L,1879L,2137L,2141L,2221L,2267L,2521L,2593L,2657L,2659L,2753L,2909L,2939L,3011L,3083L,3257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106959Inst : IEnumerable<long>
{
public static readonly long[] Value=A106959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106959.Bytes);
public long this[int i]=>Value[i];

public static A106959Inst Instance=new A106959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106960
{
public static readonly long[] Value={ 2L,11L,13L,31L,89L,101L,163L,167L,181L,241L,257L,263L,283L,313L,367L,383L,389L,457L,467L,487L,499L,523L,547L,571L,617L,653L,719L,743L,751L,809L,821L,877L,919L,953L,971L,1031L,1091L,1151L,1187L,1193L,1201L,1217L,1223L,1231L,1237L,1361L,1423L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106960Inst : IEnumerable<long>
{
public static readonly long[] Value=A106960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106960.Bytes);
public long this[int i]=>Value[i];

public static A106960Inst Instance=new A106960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106961
{
public static readonly long[] Value={ 2L,11L,89L,101L,163L,167L,241L,313L,367L,389L,487L,523L,571L,617L,743L,877L,953L,1031L,1193L,1201L,1231L,1361L,1601L,1663L,1669L,1697L,1723L,1759L,1787L,1789L,1861L,1901L,2017L,2237L,2243L,2371L,2393L,2437L,2687L,2711L,2791L,2797L,2803L,2857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106961Inst : IEnumerable<long>
{
public static readonly long[] Value=A106961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106961.Bytes);
public long this[int i]=>Value[i];

public static A106961Inst Instance=new A106961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106962
{
public static readonly long[] Value={ 83L,179L,223L,397L,479L,541L,563L,677L,727L,757L,811L,863L,907L,941L,967L,1103L,1277L,1289L,1433L,1489L,1523L,1553L,1867L,1889L,1993L,1997L,2011L,2039L,2311L,2341L,2383L,2459L,2551L,2579L,2633L,2647L,2917L,2999L,3271L,3373L,3469L,3739L,3797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106962Inst : IEnumerable<long>
{
public static readonly long[] Value=A106962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106962.Bytes);
public long this[int i]=>Value[i];

public static A106962Inst Instance=new A106962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106963
{
public static readonly long[] Value={ 5L,41L,61L,109L,149L,241L,269L,281L,389L,409L,421L,449L,569L,601L,641L,661L,701L,821L,829L,881L,929L,1069L,1129L,1181L,1201L,1301L,1321L,1381L,1429L,1481L,1489L,1609L,1801L,1889L,1901L,1949L,2129L,2141L,2161L,2221L,2269L,2281L,2309L,2341L,2381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106963Inst : IEnumerable<long>
{
public static readonly long[] Value=A106963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106963.Bytes);
public long this[int i]=>Value[i];

public static A106963Inst Instance=new A106963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106964
{
public static readonly long[] Value={ 3L,7L,23L,67L,127L,163L,227L,263L,307L,383L,463L,467L,523L,563L,587L,647L,727L,787L,907L,983L,1087L,1103L,1123L,1163L,1187L,1283L,1327L,1367L,1447L,1483L,1543L,1567L,1583L,1783L,1823L,1847L,1867L,1907L,2003L,2027L,2087L,2143L,2207L,2243L,2467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106964Inst : IEnumerable<long>
{
public static readonly long[] Value=A106964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106964.Bytes);
public long this[int i]=>Value[i];

public static A106964Inst Instance=new A106964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106965
{
public static readonly long[] Value={ 3L,7L,43L,47L,83L,103L,107L,167L,223L,283L,347L,367L,443L,487L,503L,547L,607L,643L,683L,743L,823L,827L,863L,883L,887L,947L,967L,1063L,1223L,1303L,1307L,1423L,1427L,1487L,1523L,1607L,1627L,1663L,1667L,1723L,1747L,1787L,1987L,2063L,2083L,2203L,2267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106965Inst : IEnumerable<long>
{
public static readonly long[] Value=A106965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106965.Bytes);
public long this[int i]=>Value[i];

public static A106965Inst Instance=new A106965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106966
{
public static readonly long[] Value={ 3L,7L,11L,37L,59L,61L,113L,151L,197L,313L,317L,353L,419L,463L,499L,563L,593L,733L,757L,859L,881L,907L,929L,941L,977L,997L,1021L,1033L,1109L,1123L,1223L,1237L,1249L,1283L,1451L,1481L,1543L,1559L,1613L,1741L,1759L,1811L,1867L,1877L,1889L,1901L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106966Inst : IEnumerable<long>
{
public static readonly long[] Value=A106966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106966.Bytes);
public long this[int i]=>Value[i];

public static A106966Inst Instance=new A106966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106967
{
public static readonly long[] Value={ 3L,7L,11L,17L,29L,31L,37L,59L,61L,109L,113L,127L,151L,167L,173L,191L,197L,241L,313L,317L,349L,353L,359L,373L,383L,409L,419L,431L,443L,463L,479L,499L,509L,523L,547L,563L,593L,617L,619L,673L,691L,727L,733L,757L,839L,853L,857L,859L,863L,881L,907L,911L,929L,941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106967Inst : IEnumerable<long>
{
public static readonly long[] Value=A106967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106967.Bytes);
public long this[int i]=>Value[i];

public static A106967Inst Instance=new A106967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106968
{
public static readonly long[] Value={ 3L,7L,17L,29L,31L,109L,127L,167L,173L,191L,241L,349L,359L,373L,383L,409L,431L,443L,479L,509L,523L,547L,617L,619L,673L,691L,727L,839L,853L,857L,863L,911L,953L,991L,1091L,1163L,1171L,1187L,1193L,1213L,1361L,1439L,1459L,1489L,1571L,1607L,1621L,1663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106968Inst : IEnumerable<long>
{
public static readonly long[] Value=A106968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106968.Bytes);
public long this[int i]=>Value[i];

public static A106968Inst Instance=new A106968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106969
{
public static readonly long[] Value={ 23L,41L,131L,193L,199L,227L,229L,277L,293L,397L,401L,557L,607L,659L,701L,739L,773L,787L,811L,983L,1013L,1061L,1117L,1231L,1289L,1409L,1423L,1427L,1447L,1511L,1523L,1531L,1553L,1667L,1669L,1709L,1723L,1747L,1753L,1847L,1913L,1987L,1993L,2111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106969Inst : IEnumerable<long>
{
public static readonly long[] Value=A106969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106969.Bytes);
public long this[int i]=>Value[i];

public static A106969Inst Instance=new A106969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106970
{
public static readonly long[] Value={ 23L,41L,83L,131L,193L,199L,227L,229L,277L,293L,397L,401L,521L,557L,607L,659L,701L,739L,751L,773L,787L,811L,983L,1013L,1019L,1061L,1117L,1231L,1289L,1409L,1423L,1427L,1447L,1511L,1523L,1531L,1553L,1667L,1669L,1693L,1709L,1723L,1747L,1753L,1847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106970Inst : IEnumerable<long>
{
public static readonly long[] Value=A106970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106970.Bytes);
public long this[int i]=>Value[i];

public static A106970Inst Instance=new A106970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106971
{
public static readonly long[] Value={ 5L,89L,101L,173L,461L,593L,773L,1013L,1049L,1193L,1277L,1301L,1601L,1697L,1889L,1973L,2309L,2393L,2441L,2621L,2729L,2957L,3617L,3701L,3797L,3881L,4157L,4289L,4409L,4457L,4721L,4793L,4973L,5081L,5333L,5381L,5897L,6053L,6221L,6317L,6473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106971Inst : IEnumerable<long>
{
public static readonly long[] Value=A106971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106971.Bytes);
public long this[int i]=>Value[i];

public static A106971Inst Instance=new A106971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106972
{
public static readonly long[] Value={ 5L,17L,41L,89L,101L,173L,257L,269L,293L,353L,461L,509L,521L,593L,677L,761L,773L,797L,857L,881L,929L,941L,1013L,1049L,1097L,1109L,1181L,1193L,1217L,1277L,1301L,1361L,1433L,1553L,1601L,1613L,1637L,1697L,1721L,1889L,1949L,1973L,2141L,2273L,2309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106972Inst : IEnumerable<long>
{
public static readonly long[] Value=A106972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106972.Bytes);
public long this[int i]=>Value[i];

public static A106972Inst Instance=new A106972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106973
{
public static readonly long[] Value={ 5L,17L,41L,257L,269L,293L,353L,509L,521L,677L,761L,797L,857L,881L,929L,941L,1097L,1109L,1181L,1217L,1361L,1433L,1553L,1613L,1637L,1721L,1949L,2141L,2273L,2357L,2477L,2609L,2693L,2777L,2789L,2861L,2897L,3041L,3209L,3449L,3461L,3533L,3821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106973Inst : IEnumerable<long>
{
public static readonly long[] Value=A106973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106973.Bytes);
public long this[int i]=>Value[i];

public static A106973Inst Instance=new A106973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106974
{
public static readonly long[] Value={ 2L,11L,23L,71L,107L,179L,191L,239L,347L,359L,431L,443L,491L,599L,659L,683L,743L,827L,911L,947L,1019L,1031L,1103L,1163L,1187L,1367L,1439L,1451L,1499L,1523L,1583L,1607L,1619L,1667L,1871L,2003L,2027L,2039L,2087L,2111L,2207L,2339L,2459L,2531L,2543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106974Inst : IEnumerable<long>
{
public static readonly long[] Value=A106974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106974.Bytes);
public long this[int i]=>Value[i];

public static A106974Inst Instance=new A106974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106975
{
public static readonly long[] Value={ 13L,67L,199L,223L,313L,499L,523L,991L,1009L,1021L,1153L,1213L,1399L,1483L,1669L,1789L,1831L,1861L,1879L,2089L,2137L,2287L,2377L,2551L,2713L,2797L,2833L,3061L,3271L,3319L,3457L,3583L,3823L,3853L,3943L,4027L,4051L,4177L,4789L,5011L,5023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106975Inst : IEnumerable<long>
{
public static readonly long[] Value=A106975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106975.Bytes);
public long this[int i]=>Value[i];

public static A106975Inst Instance=new A106975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106976
{
public static readonly long[] Value={ 7L,13L,67L,109L,139L,181L,199L,223L,241L,277L,313L,439L,457L,463L,499L,523L,547L,613L,631L,643L,661L,673L,691L,811L,919L,937L,991L,1009L,1021L,1051L,1069L,1093L,1153L,1213L,1231L,1321L,1327L,1399L,1483L,1543L,1579L,1657L,1669L,1741L,1747L,1789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106976Inst : IEnumerable<long>
{
public static readonly long[] Value=A106976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106976.Bytes);
public long this[int i]=>Value[i];

public static A106976Inst Instance=new A106976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106977
{
public static readonly long[] Value={ 7L,109L,139L,181L,241L,277L,439L,457L,463L,547L,613L,631L,643L,661L,673L,691L,811L,919L,937L,1051L,1069L,1093L,1231L,1321L,1327L,1543L,1579L,1657L,1741L,1747L,2053L,2083L,2113L,2269L,2311L,2437L,2503L,2539L,2677L,2731L,2887L,2953L,2971L,3049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106977Inst : IEnumerable<long>
{
public static readonly long[] Value=A106977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106977.Bytes);
public long this[int i]=>Value[i];

public static A106977Inst Instance=new A106977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106978
{
public static readonly long[] Value={ 3L,41L,137L,191L,263L,359L,461L,479L,617L,797L,827L,971L,983L,1229L,1439L,1481L,1493L,1613L,1697L,1721L,1787L,2099L,2339L,2381L,2393L,2531L,2621L,2729L,2753L,2939L,2999L,3347L,3407L,3449L,3767L,3797L,3917L,4139L,4481L,4493L,4679L,4889L,5087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106978Inst : IEnumerable<long>
{
public static readonly long[] Value=A106978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106978.Bytes);
public long this[int i]=>Value[i];

public static A106978Inst Instance=new A106978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106979
{
public static readonly long[] Value={ 3L,29L,41L,137L,191L,263L,359L,461L,467L,479L,491L,617L,773L,797L,827L,971L,983L,1229L,1433L,1439L,1481L,1493L,1613L,1697L,1721L,1787L,1931L,2003L,2099L,2339L,2381L,2393L,2531L,2621L,2729L,2753L,2903L,2927L,2939L,2999L,3347L,3407L,3449L,3557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106979Inst : IEnumerable<long>
{
public static readonly long[] Value=A106979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106979.Bytes);
public long this[int i]=>Value[i];

public static A106979Inst Instance=new A106979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106980
{
public static readonly long[] Value={ 2L,11L,47L,89L,113L,251L,293L,311L,443L,599L,653L,659L,677L,809L,911L,1013L,1091L,1163L,1181L,1187L,1361L,1409L,1607L,1871L,1877L,2243L,2351L,2357L,2477L,2549L,2579L,2711L,2741L,2969L,3089L,3221L,3251L,3323L,3461L,3581L,3671L,4013L,4019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106980Inst : IEnumerable<long>
{
public static readonly long[] Value=A106980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106980.Bytes);
public long this[int i]=>Value[i];

public static A106980Inst Instance=new A106980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106981
{
public static readonly long[] Value={ 2L,11L,17L,47L,89L,101L,113L,131L,251L,269L,293L,311L,317L,389L,443L,449L,503L,563L,569L,599L,641L,653L,659L,677L,743L,809L,839L,881L,887L,911L,947L,1013L,1061L,1091L,1163L,1181L,1187L,1259L,1307L,1319L,1361L,1373L,1409L,1487L,1511L,1523L,1583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106981Inst : IEnumerable<long>
{
public static readonly long[] Value=A106981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106981.Bytes);
public long this[int i]=>Value[i];

public static A106981Inst Instance=new A106981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106982
{
public static readonly long[] Value={ 2L,11L,17L,101L,131L,269L,317L,389L,449L,503L,563L,569L,641L,743L,839L,881L,887L,947L,1061L,1259L,1307L,1319L,1373L,1487L,1511L,1523L,1583L,1667L,1709L,2027L,2069L,2129L,2207L,2273L,2309L,2399L,2417L,2447L,2591L,2657L,2687L,2699L,2801L,2861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106982Inst : IEnumerable<long>
{
public static readonly long[] Value=A106982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106982.Bytes);
public long this[int i]=>Value[i];

public static A106982Inst Instance=new A106982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106983
{
public static readonly long[] Value={ 103L,151L,283L,373L,397L,487L,571L,709L,877L,883L,1039L,1459L,1531L,1567L,1753L,2017L,2029L,2203L,2239L,2371L,2383L,2557L,2617L,2659L,2719L,2749L,2791L,2851L,3181L,3253L,3301L,3331L,3373L,3793L,3919L,3931L,4093L,4111L,4201L,4327L,4357L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106983Inst : IEnumerable<long>
{
public static readonly long[] Value=A106983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106983.Bytes);
public long this[int i]=>Value[i];

public static A106983Inst Instance=new A106983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106984
{
public static readonly long[] Value={ 2L,11L,13L,19L,29L,43L,61L,83L,101L,107L,109L,131L,139L,149L,173L,197L,211L,227L,277L,283L,293L,307L,347L,349L,373L,461L,491L,523L,541L,547L,557L,563L,571L,613L,659L,677L,701L,733L,739L,787L,811L,821L,827L,853L,877L,941L,997L,1019L,1051L,1069L,1091L,1117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106984Inst : IEnumerable<long>
{
public static readonly long[] Value=A106984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106984.Bytes);
public long this[int i]=>Value[i];

public static A106984Inst Instance=new A106984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106985
{
public static readonly long[] Value={ 5L,13L,31L,59L,83L,97L,271L,307L,349L,353L,409L,479L,593L,643L,691L,733L,761L,839L,941L,983L,1151L,1217L,1259L,1307L,1567L,1601L,1721L,1861L,1867L,1879L,1931L,2113L,2243L,2273L,2309L,2351L,2371L,2663L,2719L,2749L,2777L,2803L,2819L,2897L,2953L,2957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106985Inst : IEnumerable<long>
{
public static readonly long[] Value=A106985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106985.Bytes);
public long this[int i]=>Value[i];

public static A106985Inst Instance=new A106985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106986
{
public static readonly long[] Value={ 5L,7L,13L,19L,31L,41L,47L,59L,73L,83L,89L,97L,167L,223L,227L,229L,241L,271L,293L,307L,349L,353L,383L,397L,409L,461L,479L,509L,577L,587L,593L,619L,643L,661L,691L,733L,761L,769L,773L,787L,811L,839L,853L,929L,941L,983L,1021L,1097L,1123L,1151L,1181L,1217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106986Inst : IEnumerable<long>
{
public static readonly long[] Value=A106986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106986.Bytes);
public long this[int i]=>Value[i];

public static A106986Inst Instance=new A106986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106987
{
public static readonly long[] Value={ 5L,7L,19L,41L,47L,73L,89L,167L,223L,227L,229L,241L,293L,383L,397L,461L,509L,577L,587L,619L,661L,769L,773L,787L,811L,853L,929L,1021L,1097L,1123L,1181L,1237L,1279L,1319L,1321L,1399L,1487L,1489L,1553L,1571L,1627L,1657L,1669L,1697L,1753L,1783L,1987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106987Inst : IEnumerable<long>
{
public static readonly long[] Value=A106987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106987.Bytes);
public long this[int i]=>Value[i];

public static A106987Inst Instance=new A106987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106988
{
public static readonly long[] Value={ 23L,29L,43L,53L,79L,107L,113L,127L,179L,191L,211L,233L,263L,277L,337L,347L,373L,389L,443L,491L,547L,599L,641L,653L,659L,673L,701L,751L,757L,809L,883L,907L,911L,919L,953L,991L,1031L,1093L,1171L,1187L,1213L,1283L,1297L,1303L,1327L,1381L,1429L,1439L,1453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106988Inst : IEnumerable<long>
{
public static readonly long[] Value=A106988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106988.Bytes);
public long this[int i]=>Value[i];

public static A106988Inst Instance=new A106988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106989
{
public static readonly long[] Value={ 23L,29L,43L,53L,79L,107L,113L,127L,179L,191L,211L,233L,263L,277L,337L,347L,373L,389L,443L,491L,547L,569L,571L,599L,641L,653L,659L,673L,701L,751L,757L,809L,823L,883L,907L,911L,919L,953L,991L,1031L,1093L,1117L,1171L,1187L,1213L,1283L,1297L,1303L,1327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106989Inst : IEnumerable<long>
{
public static readonly long[] Value=A106989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106989.Bytes);
public long this[int i]=>Value[i];

public static A106989Inst Instance=new A106989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106990
{
public static readonly long[] Value={ 5L,199L,251L,491L,709L,739L,929L,1151L,1201L,1289L,1429L,1451L,1621L,2039L,2129L,2281L,2341L,2551L,2591L,2819L,3019L,3329L,3539L,3581L,3919L,4091L,4519L,4831L,4861L,4889L,4919L,5179L,5381L,5431L,5521L,5749L,5861L,6091L,6659L,6661L,7069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106990Inst : IEnumerable<long>
{
public static readonly long[] Value=A106990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106990.Bytes);
public long this[int i]=>Value[i];

public static A106990Inst Instance=new A106990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106991
{
public static readonly long[] Value={ 5L,19L,191L,199L,251L,349L,491L,709L,739L,809L,929L,1151L,1201L,1289L,1429L,1451L,1559L,1619L,1621L,2039L,2129L,2281L,2341L,2551L,2591L,2741L,2819L,2861L,3019L,3329L,3391L,3539L,3581L,3769L,3919L,3931L,4091L,4129L,4519L,4831L,4861L,4889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106991Inst : IEnumerable<long>
{
public static readonly long[] Value=A106991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106991.Bytes);
public long this[int i]=>Value[i];

public static A106991Inst Instance=new A106991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106992
{
public static readonly long[] Value={ 11L,61L,271L,499L,571L,631L,769L,881L,1031L,1061L,1069L,1279L,1301L,1871L,1999L,2069L,2221L,2239L,2381L,2531L,2671L,2851L,2969L,3079L,3089L,3361L,3389L,3659L,3779L,3881L,3911L,4111L,4159L,4241L,4409L,4721L,4751L,4759L,5059L,5261L,5519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106992Inst : IEnumerable<long>
{
public static readonly long[] Value=A106992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106992.Bytes);
public long this[int i]=>Value[i];

public static A106992Inst Instance=new A106992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106993
{
public static readonly long[] Value={ 11L,61L,101L,139L,149L,229L,271L,311L,359L,479L,499L,541L,571L,619L,631L,691L,701L,719L,761L,769L,881L,1031L,1049L,1061L,1069L,1259L,1279L,1301L,1489L,1499L,1669L,1721L,1759L,1811L,1831L,1871L,1949L,1999L,2069L,2099L,2221L,2239L,2251L,2381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106993Inst : IEnumerable<long>
{
public static readonly long[] Value=A106993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106993.Bytes);
public long this[int i]=>Value[i];

public static A106993Inst Instance=new A106993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106994
{
public static readonly long[] Value={ 101L,139L,149L,229L,311L,359L,479L,541L,619L,691L,701L,719L,761L,1049L,1259L,1489L,1499L,1669L,1721L,1759L,1811L,1831L,1949L,2099L,2251L,2441L,2999L,3049L,3121L,3209L,3331L,3691L,4001L,4051L,4229L,4339L,4481L,4561L,4621L,4729L,4871L,5021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106994Inst : IEnumerable<long>
{
public static readonly long[] Value=A106994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106994.Bytes);
public long this[int i]=>Value[i];

public static A106994Inst Instance=new A106994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106995
{
public static readonly long[] Value={ 3L,37L,167L,193L,223L,293L,523L,563L,827L,857L,863L,1063L,1123L,1153L,1307L,1637L,1747L,2003L,2203L,2273L,2333L,2423L,2617L,2767L,2917L,2963L,3187L,3257L,3527L,3613L,3623L,3643L,3793L,3943L,3967L,4003L,4057L,4133L,4397L,4663L,4673L,4877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106995Inst : IEnumerable<long>
{
public static readonly long[] Value=A106995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106995.Bytes);
public long this[int i]=>Value[i];

public static A106995Inst Instance=new A106995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106996
{
public static readonly long[] Value={ 3L,37L,53L,97L,127L,167L,193L,223L,257L,293L,373L,523L,547L,563L,677L,683L,743L,787L,797L,827L,857L,863L,877L,953L,1063L,1123L,1153L,1307L,1367L,1553L,1637L,1667L,1693L,1747L,1777L,1913L,2003L,2027L,2083L,2203L,2207L,2273L,2333L,2347L,2423L,2617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106996Inst : IEnumerable<long>
{
public static readonly long[] Value=A106996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106996.Bytes);
public long this[int i]=>Value[i];

public static A106996Inst Instance=new A106996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106997
{
public static readonly long[] Value={ 3L,53L,97L,127L,257L,373L,547L,677L,683L,743L,787L,797L,877L,953L,1367L,1553L,1667L,1693L,1777L,1913L,2027L,2083L,2207L,2347L,2803L,2833L,2887L,3167L,3343L,3373L,3637L,3727L,3803L,3833L,3853L,3907L,3917L,4093L,4217L,4327L,4373L,4517L,4733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106997Inst : IEnumerable<long>
{
public static readonly long[] Value=A106997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106997.Bytes);
public long this[int i]=>Value[i];

public static A106997Inst Instance=new A106997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106998
{
public static readonly long[] Value={ 2L,67L,113L,173L,227L,307L,383L,433L,607L,673L,887L,907L,983L,1093L,1117L,1427L,1433L,1627L,1723L,1877L,1933L,2143L,2237L,2377L,2383L,2447L,2473L,2663L,2903L,2957L,3533L,3593L,4027L,4513L,4597L,4703L,4783L,4817L,4933L,5087L,5233L,5347L,5623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106998Inst : IEnumerable<long>
{
public static readonly long[] Value=A106998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106998.Bytes);
public long this[int i]=>Value[i];

public static A106998Inst Instance=new A106998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106999
{
public static readonly long[] Value={ 2L,13L,67L,103L,107L,113L,173L,227L,307L,317L,337L,383L,433L,487L,607L,673L,773L,887L,907L,977L,983L,1093L,1097L,1117L,1193L,1237L,1283L,1427L,1433L,1447L,1523L,1627L,1663L,1723L,1823L,1877L,1933L,1997L,2017L,2143L,2237L,2293L,2377L,2383L,2393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106999Inst : IEnumerable<long>
{
public static readonly long[] Value=A106999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106999.Bytes);
public long this[int i]=>Value[i];

public static A106999Inst Instance=new A106999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107000
{
public static readonly long[] Value={ 2L,13L,103L,107L,317L,337L,487L,773L,977L,1097L,1193L,1237L,1283L,1447L,1523L,1663L,1823L,1997L,2017L,2293L,2393L,2503L,2687L,2693L,2713L,2777L,2843L,2953L,3023L,3067L,3137L,3347L,3413L,3433L,3457L,3517L,3547L,3677L,3947L,4157L,4283L,4297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107000Inst : IEnumerable<long>
{
public static readonly long[] Value=A107000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107000.Bytes);
public long this[int i]=>Value[i];

public static A107000Inst Instance=new A107000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107001
{
public static readonly long[] Value={ 131L,239L,389L,419L,461L,821L,919L,1051L,1109L,1531L,1601L,1879L,1901L,2011L,2399L,2411L,2609L,2699L,2791L,2971L,3011L,3041L,3469L,3541L,3559L,3671L,3709L,4139L,4219L,4261L,4349L,4451L,4679L,4789L,4799L,4951L,5101L,5231L,5279L,5479L,5821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107001Inst : IEnumerable<long>
{
public static readonly long[] Value=A107001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107001.Bytes);
public long this[int i]=>Value[i];

public static A107001Inst Instance=new A107001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107002
{
public static readonly long[] Value={ 5L,29L,149L,197L,293L,461L,509L,557L,677L,773L,1013L,1109L,1181L,1373L,1637L,1877L,1901L,1973L,2213L,2237L,2309L,2621L,2861L,2909L,3221L,3461L,3581L,3677L,3917L,3989L,4013L,4133L,4157L,4253L,4349L,4397L,4517L,4733L,5189L,5381L,5813L,6029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107002Inst : IEnumerable<long>
{
public static readonly long[] Value=A107002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107002.Bytes);
public long this[int i]=>Value[i];

public static A107002Inst Instance=new A107002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107003
{
public static readonly long[] Value={ 5L,29L,53L,101L,149L,173L,197L,269L,293L,317L,389L,461L,509L,557L,653L,677L,701L,773L,797L,821L,941L,1013L,1061L,1109L,1181L,1229L,1277L,1301L,1373L,1493L,1613L,1637L,1709L,1733L,1877L,1901L,1949L,1973L,1997L,2069L,2141L,2213L,2237L,2309L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107003Inst : IEnumerable<long>
{
public static readonly long[] Value=A107003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107003.Bytes);
public long this[int i]=>Value[i];

public static A107003Inst Instance=new A107003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107004
{
public static readonly long[] Value={ 5L,53L,101L,173L,269L,317L,389L,653L,701L,797L,821L,941L,1061L,1229L,1277L,1301L,1493L,1613L,1709L,1733L,1949L,1997L,2069L,2141L,2333L,2357L,2381L,2477L,2549L,2693L,2741L,2789L,2837L,2957L,3389L,3413L,3533L,3557L,3701L,3797L,3821L,4229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107004Inst : IEnumerable<long>
{
public static readonly long[] Value=A107004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107004.Bytes);
public long this[int i]=>Value[i];

public static A107004Inst Instance=new A107004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107005
{
public static readonly long[] Value={ 7L,31L,79L,103L,127L,199L,223L,271L,367L,439L,463L,607L,631L,823L,919L,967L,991L,1087L,1231L,1279L,1303L,1327L,1423L,1447L,1543L,1567L,1663L,1831L,1879L,1951L,1999L,2143L,2239L,2311L,2383L,2503L,2551L,2719L,2791L,2887L,3079L,3271L,3319L,3391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107005Inst : IEnumerable<long>
{
public static readonly long[] Value=A107005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107005.Bytes);
public long this[int i]=>Value[i];

public static A107005Inst Instance=new A107005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107006
{
public static readonly long[] Value={ 7L,31L,79L,103L,127L,151L,199L,223L,271L,367L,439L,463L,487L,607L,631L,727L,751L,823L,919L,967L,991L,1039L,1063L,1087L,1231L,1279L,1303L,1327L,1399L,1423L,1447L,1471L,1543L,1567L,1663L,1759L,1783L,1831L,1879L,1951L,1999L,2143L,2239L,2287L,2311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107006Inst : IEnumerable<long>
{
public static readonly long[] Value=A107006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107006.Bytes);
public long this[int i]=>Value[i];

public static A107006Inst Instance=new A107006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107007
{
public static readonly long[] Value={ 3L,11L,59L,83L,107L,131L,179L,227L,251L,347L,419L,443L,467L,491L,563L,587L,659L,683L,827L,947L,971L,1019L,1091L,1163L,1187L,1259L,1283L,1307L,1427L,1451L,1499L,1523L,1571L,1619L,1667L,1787L,1811L,1907L,1931L,1979L,2003L,2027L,2099L,2243L,2267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107007Inst : IEnumerable<long>
{
public static readonly long[] Value=A107007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107007.Bytes);
public long this[int i]=>Value[i];

public static A107007Inst Instance=new A107007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107008
{
public static readonly long[] Value={ 73L,97L,193L,241L,313L,337L,409L,433L,457L,577L,601L,673L,769L,937L,1009L,1033L,1129L,1153L,1201L,1249L,1297L,1321L,1489L,1609L,1657L,1753L,1777L,1801L,1873L,1993L,2017L,2089L,2113L,2137L,2161L,2281L,2377L,2473L,2521L,2593L,2617L,2689L,2713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107008Inst : IEnumerable<long>
{
public static readonly long[] Value=A107008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107008.Bytes);
public long this[int i]=>Value[i];

public static A107008Inst Instance=new A107008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107009
{
public static readonly long[] Value={ 5L,11L,53L,71L,89L,137L,191L,257L,311L,353L,389L,419L,443L,467L,521L,647L,683L,797L,863L,929L,977L,1013L,1049L,1103L,1109L,1181L,1301L,1367L,1373L,1499L,1511L,1637L,1721L,1901L,1907L,2003L,2099L,2237L,2267L,2333L,2381L,2423L,2447L,2531L,2663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107009Inst : IEnumerable<long>
{
public static readonly long[] Value=A107009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107009.Bytes);
public long this[int i]=>Value[i];

public static A107009Inst Instance=new A107009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107010
{
public static readonly long[] Value={ 5L,11L,23L,47L,53L,59L,71L,89L,113L,137L,179L,191L,251L,257L,269L,311L,317L,353L,383L,389L,401L,419L,443L,449L,467L,509L,521L,587L,599L,617L,641L,647L,653L,683L,719L,773L,797L,839L,863L,881L,911L,929L,947L,971L,977L,983L,1013L,1049L,1061L,1103L,1109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107010Inst : IEnumerable<long>
{
public static readonly long[] Value=A107010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107010.Bytes);
public long this[int i]=>Value[i];

public static A107010Inst Instance=new A107010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107011
{
public static readonly long[] Value={ 5L,23L,47L,59L,113L,179L,251L,269L,317L,383L,401L,449L,509L,587L,599L,617L,641L,653L,719L,773L,839L,881L,911L,947L,971L,983L,1061L,1193L,1259L,1277L,1307L,1409L,1433L,1439L,1523L,1571L,1607L,1697L,1709L,1787L,1871L,1973L,2027L,2039L,2069L,2297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107011Inst : IEnumerable<long>
{
public static readonly long[] Value=A107011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107011.Bytes);
public long this[int i]=>Value[i];

public static A107011Inst Instance=new A107011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107012
{
public static readonly long[] Value={ 31L,37L,67L,97L,103L,157L,163L,181L,199L,229L,313L,331L,367L,379L,421L,433L,463L,487L,499L,577L,631L,643L,661L,691L,709L,727L,751L,757L,823L,829L,859L,883L,907L,991L,1021L,1039L,1087L,1093L,1123L,1153L,1171L,1237L,1279L,1291L,1303L,1321L,1423L,1453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107012Inst : IEnumerable<long>
{
public static readonly long[] Value=A107012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107012.Bytes);
public long this[int i]=>Value[i];

public static A107012Inst Instance=new A107012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107013
{
public static readonly long[] Value={ 31L,37L,67L,97L,103L,157L,163L,181L,199L,223L,229L,313L,331L,367L,379L,397L,421L,433L,463L,487L,499L,577L,619L,631L,643L,661L,691L,709L,727L,751L,757L,823L,829L,859L,883L,907L,991L,1021L,1039L,1087L,1093L,1123L,1153L,1171L,1213L,1237L,1279L,1291L,1303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107013Inst : IEnumerable<long>
{
public static readonly long[] Value=A107013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107013.Bytes);
public long this[int i]=>Value[i];

public static A107013Inst Instance=new A107013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107014
{
public static readonly long[] Value={ 6L,10L,11L,12L,20L,21L,22L,23L,24L,28L,30L,33L,34L,36L,41L,42L,46L,49L,58L,60L,61L,62L,66L,68L,73L,83L,92L,96L,100L,101L,102L,103L,110L,111L,112L,113L,114L,118L,120L,121L,122L,123L,126L,127L,128L,129L,130L,131L,132L,133L,134L,136L,138L,143L,150L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107014Inst : IEnumerable<long>
{
public static readonly long[] Value=A107014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107014.Bytes);
public long this[int i]=>Value[i];

public static A107014Inst Instance=new A107014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107015
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,1L,1L,1L,2L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,2L,3L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,2L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,2L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,2L,1L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107015Inst : IEnumerable<long>
{
public static readonly long[] Value=A107015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107015.Bytes);
public long this[int i]=>Value[i];

public static A107015Inst Instance=new A107015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107016
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,0L,1L,0L,1L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,4L,3L,4L,3L,2L,3L,2L,3L,4L,3L,4L,3L,2L,3L,2L,3L,4L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107016Inst : IEnumerable<long>
{
public static readonly long[] Value=A107016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107016.Bytes);
public long this[int i]=>Value[i];

public static A107016Inst Instance=new A107016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107017
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,0L,1L,2L,3L,3L,0L,1L,2L,3L,3L,5L,5L,5L,0L,1L,2L,3L,3L,5L,5L,5L,8L,8L,8L,8L,8L,0L,1L,2L,3L,3L,5L,5L,5L,8L,8L,8L,8L,8L,13L,13L,13L,13L,13L,13L,13L,13L,0L,1L,2L,3L,3L,5L,5L,5L,8L,8L,8L,8L,8L,13L,13L,13L,13L,13L,13L,13L,13L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107017Inst : IEnumerable<long>
{
public static readonly long[] Value=A107017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107017.Bytes);
public long this[int i]=>Value[i];

public static A107017Inst Instance=new A107017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107018
{
public static readonly long[] Value={ 7L,10L,11L,21L,27L,29L,31L,32L,37L,41L,56L,70L,71L,77L,85L,94L,100L,101L,103L,106L,110L,111L,112L,113L,117L,118L,119L,122L,127L,128L,131L,133L,143L,152L,173L,176L,201L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107018Inst : IEnumerable<long>
{
public static readonly long[] Value=A107018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107018.Bytes);
public long this[int i]=>Value[i];

public static A107018Inst Instance=new A107018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107019
{
public static readonly long[] Value={ 1L,2L,6L,8L,14L,24L,30L,32L,58L,60L,68L,70L,84L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107019Inst : IEnumerable<long>
{
public static readonly long[] Value=A107019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107019.Bytes);
public long this[int i]=>Value[i];

public static A107019Inst Instance=new A107019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107020
{
public static readonly long[] Value={ 2L,11L,41L,1901L,2459L,5081L,5849L,6131L,6449L,8969L,9221L,10691L,12119L,13229L,14009L,14321L,14669L,15161L,18461L,19709L,20411L,21179L,22271L,23099L,24551L,25601L,30389L,37991L,39419L,41381L,43691L,44699L,52289L,55631L,56081L,58979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107020Inst : IEnumerable<long>
{
public static readonly long[] Value=A107020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107020.Bytes);
public long this[int i]=>Value[i];

public static A107020Inst Instance=new A107020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107021
{
public static readonly long[] Value={ 2L,6449L,12119L,19709L,30389L,74699L,107699L,133499L,143609L,167759L,175349L,206369L,210209L,229739L,244589L,254279L,334289L,422069L,528509L,541529L,607319L,641969L,658349L,751529L,810539L,810809L,812849L,926669L,934259L,956909L,968729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107021Inst : IEnumerable<long>
{
public static readonly long[] Value=A107021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107021.Bytes);
public long this[int i]=>Value[i];

public static A107021Inst Instance=new A107021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107022
{
public static readonly long[] Value={ 2L,6449L,210209L,244589L,528509L,810539L,968729L,985109L,1316699L,1551899L,1743419L,2832629L,4094999L,4328459L,5608409L,6036869L,7077419L,7939829L,8176979L,8673569L,8789279L,9080189L,9797279L,10122419L,10309889L,10487969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107022Inst : IEnumerable<long>
{
public static readonly long[] Value=A107022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107022.Bytes);
public long this[int i]=>Value[i];

public static A107022Inst Instance=new A107022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107023
{
public static readonly long[] Value={ 4094999L,9080189L,10957169L,11148899L,15917579L,19422059L,37267229L,37622339L,58680929L,63196349L,64595369L,66383519L,108463739L,177109379L,186977699L,189997079L,196068179L,228875849L,251891639L,261703889L,271031669L,310143959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107023Inst : IEnumerable<long>
{
public static readonly long[] Value=A107023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107023.Bytes);
public long this[int i]=>Value[i];

public static A107023Inst Instance=new A107023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107024
{
public static readonly long[] Value={ 4094999L,9080189L,63196349L,66383519L,177109379L,196068179L,310143959L,389825729L,528083219L,909696059L,937924259L,1080610439L,1318820159L,1342772969L,1824166469L,1921977329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107024Inst : IEnumerable<long>
{
public static readonly long[] Value=A107024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107024.Bytes);
public long this[int i]=>Value[i];

public static A107024Inst Instance=new A107024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107025
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,8L,29L,85L,211L,464L,938L,1808L,3459L,6826L,14198L,30960L,69143L,154433L,340006L,734561L,1561313L,3286129L,6900097L,14542101L,30855957L,65908862L,141395972L,303745077L,651763377L,1395140215L,2978858672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107025Inst : IEnumerable<long>
{
public static readonly long[] Value=A107025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107025.Bytes);
public long this[int i]=>Value[i];

public static A107025Inst Instance=new A107025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107026
{
public static readonly long[] Value={ 1L,2L,10L,62L,426L,3112L,23686L,185684L,1488554L,12144248L,100489320L,841268078L,7112138790L,60629940152L,520591221412L,4498091003272L,39079909924522L,341193986978008L,2991881019936760L,26338436818801496L,232688056611178216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107026Inst : IEnumerable<long>
{
public static readonly long[] Value=A107026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107026.Bytes);
public long this[int i]=>Value[i];

public static A107026Inst Instance=new A107026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107027
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,1L,2L,4L,2L,1L,2L,6L,8L,2L,1L,2L,8L,20L,16L,2L,1L,2L,10L,38L,70L,32L,2L,1L,2L,12L,62L,196L,252L,64L,2L,1L,2L,14L,92L,426L,1062L,924L,128L,2L,1L,2L,16L,128L,792L,3112L,5948L,3432L,256L,2L,1L,2L,18L,170L,1326L,7302L,23686L,34120L,12870L,512L,2L,1L,2L,20L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107027Inst : IEnumerable<long>
{
public static readonly long[] Value=A107027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107027.Bytes);
public long this[int i]=>Value[i];

public static A107027Inst Instance=new A107027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107028
{
public static readonly long[] Value={ 1L,3L,5L,9L,19L,49L,155L,591L,2651L,13689L,80009L,522193L,3762273L,29629483L,252966249L,2325176147L,22874076091L,239615657133L,2661015200515L,31207545002577L,385191232715737L,4988767088734625L,67615869255979521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107028Inst : IEnumerable<long>
{
public static readonly long[] Value=A107028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107028.Bytes);
public long this[int i]=>Value[i];

public static A107028Inst Instance=new A107028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107029
{
public static readonly long[] Value={ 1L,1L,3L,3L,5L,7L,11L,19L,35L,69L,151L,339L,829L,2111L,5607L,15737L,45289L,136477L,423279L,1353671L,4471673L,15114479L,52605755L,187162155L,681817179L,2539492249L,9646349779L,37415172217L,147745308403L,594368656811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107029Inst : IEnumerable<long>
{
public static readonly long[] Value=A107029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107029.Bytes);
public long this[int i]=>Value[i];

public static A107029Inst Instance=new A107029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107030
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,1L,2L,4L,2L,1L,2L,8L,6L,2L,1L,2L,16L,20L,8L,2L,1L,2L,32L,70L,38L,10L,2L,1L,2L,64L,252L,196L,62L,12L,2L,1L,2L,128L,924L,1062L,426L,92L,14L,2L,1L,2L,256L,3432L,5948L,3112L,792L,128L,16L,2L,1L,2L,512L,12870L,34120L,23686L,7302L,1326L,170L,18L,2L,1L,2L,1024L,48620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107030Inst : IEnumerable<long>
{
public static readonly long[] Value=A107030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107030.Bytes);
public long this[int i]=>Value[i];

public static A107030Inst Instance=new A107030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107031
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,12L,25L,56L,145L,422L,1389L,5072L,20283L,87996L,412663L,2087868L,11361831L,66155642L,409567833L,2680486870L,18465061963L,133504614880L,1011121118741L,8008145020804L,66201411633209L,570006877641976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107031Inst : IEnumerable<long>
{
public static readonly long[] Value=A107031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107031.Bytes);
public long this[int i]=>Value[i];

public static A107031Inst Instance=new A107031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107032
{
public static readonly long[] Value={ 8L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,22L,23L,26L,28L,31L,35L,40L,42L,43L,44L,48L,53L,62L,64L,71L,74L,75L,79L,80L,86L,88L,97L,100L,101L,102L,104L,105L,106L,108L,109L,110L,111L,112L,113L,115L,117L,118L,119L,120L,121L,123L,126L,129L,132L,135L,139L,141L,142L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107032Inst : IEnumerable<long>
{
public static readonly long[] Value=A107032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107032.Bytes);
public long this[int i]=>Value[i];

public static A107032Inst Instance=new A107032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107033
{
public static readonly long[] Value={ 1L,3L,1L,-2L,2L,1L,-4L,-1L,-2L,0L,2L,-4L,-1L,-2L,-2L,1L,0L,2L,-2L,2L,0L,-4L,1L,0L,2L,2L,5L,0L,-2L,0L,0L,4L,-2L,0L,0L,3L,4L,0L,0L,2L,1L,-4L,2L,-2L,0L,0L,0L,2L,-2L,0L,2L,3L,-2L,0L,-2L,-2L,-4L,-1L,0L,0L,0L,-4L,2L,0L,4L,0L,-4L,-2L,0L,-2L,-1L,0L,0L,-2L,-2L,2L,-6L,1L,2L,0L,0L,4L,0L,-2L,2L,0L,0L,-2L,-2L,-2L,2L,0L,1L,0L,0L,-2L,4L,0L,0L,2L,1L,6L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107033Inst : IEnumerable<long>
{
public static readonly long[] Value=A107033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107033.Bytes);
public long this[int i]=>Value[i];

public static A107033Inst Instance=new A107033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107034
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,-1L,2L,1L,1L,-1L,0L,1L,-1L,-1L,-1L,0L,-2L,1L,0L,0L,1L,2L,-1L,0L,1L,0L,1L,0L,1L,1L,-1L,-3L,0L,-1L,1L,-1L,-1L,0L,0L,0L,1L,-2L,0L,1L,0L,1L,0L,1L,0L,0L,1L,2L,1L,0L,-1L,1L,-3L,0L,1L,0L,-1L,-1L,0L,1L,0L,0L,-2L,0L,-1L,-1L,0L,-2L,1L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107034Inst : IEnumerable<long>
{
public static readonly long[] Value=A107034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107034.Bytes);
public long this[int i]=>Value[i];

public static A107034Inst Instance=new A107034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107035
{
public static readonly long[] Value={ 1L,4L,12L,32L,78L,176L,376L,768L,1509L,2872L,5316L,9600L,16966L,29408L,50088L,83968L,138738L,226196L,364284L,580032L,913824L,1425552L,2203368L,3376128L,5130999L,7738136L,11585208L,17225472L,25444278L,37350816L,54504160L,79085568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107035Inst : IEnumerable<long>
{
public static readonly long[] Value=A107035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107035.Bytes);
public long this[int i]=>Value[i];

public static A107035Inst Instance=new A107035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107036
{
public static readonly long[] Value={ 3L,4L,5L,7L,11L,13L,17L,19L,23L,31L,43L,61L,79L,101L,127L,167L,191L,199L,313L,347L,701L,1709L,2617L,3539L,5807L,10501L,10691L,11279L,12391L,14479L,42737L,83339L,95369L,117239L,127031L,138937L,141079L,267017L,269987L,374321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107036Inst : IEnumerable<long>
{
public static readonly long[] Value=A107036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107036.Bytes);
public long this[int i]=>Value[i];

public static A107036Inst Instance=new A107036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107037
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,41L,43L,44L,46L,47L,48L,49L,50L,51L,52L,53L,56L,57L,58L,59L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,82L,83L,85L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107037Inst : IEnumerable<long>
{
public static readonly long[] Value=A107037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107037.Bytes);
public long this[int i]=>Value[i];

public static A107037Inst Instance=new A107037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107038
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107038Inst : IEnumerable<long>
{
public static readonly long[] Value=A107038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107038.Bytes);
public long this[int i]=>Value[i];

public static A107038Inst Instance=new A107038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107039
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107039Inst : IEnumerable<long>
{
public static readonly long[] Value=A107039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107039.Bytes);
public long this[int i]=>Value[i];

public static A107039Inst Instance=new A107039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A107040
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,10L,11L,13L,17L,18L,19L,22L,23L,25L,26L,27L,29L,31L,33L,34L,37L,38L,39L,41L,43L,46L,47L,50L,51L,53L,54L,55L,57L,58L,59L,61L,62L,65L,66L,67L,69L,71L,73L,74L,78L,79L,81L,82L,83L,85L,86L,87L,89L,93L,94L,95L,97L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A107040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A107040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A107040Inst : IEnumerable<long>
{
public static readonly long[] Value=A107040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A107040.Bytes);
public long this[int i]=>Value[i];

public static A107040Inst Instance=new A107040Inst();

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