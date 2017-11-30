using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A133843
{
public static readonly long[] Value={ 1L,5L,0L,1L,9L,7L,5L,2L,6L,8L,2L,6L,8L,6L,1L,1L,4L,9L,8L,8L,6L,0L,3L,4L,8L,7L,0L,8L,0L,2L,9L,1L,2L,2L,5L,9L,9L,7L,3L,3L,8L,6L,1L,9L,0L,2L,1L,4L,4L,6L,5L,5L,1L,7L,0L,6L,5L,6L,8L,3L,4L,7L,3L,1L,0L,5L,2L,9L,7L,9L,1L,0L,4L,7L,3L,9L,8L,5L,9L,5L,3L,4L,2L,9L,2L,2L,8L,8L,0L,0L,6L,2L,7L,7L,8L,1L,1L,0L,4L,5L,2L,5L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133843Inst : IEnumerable<long>
{
public static readonly long[] Value=A133843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133843.Bytes);
public long this[int i]=>Value[i];

public static A133843Inst Instance=new A133843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133844
{
public static readonly long[] Value={ 1L,4L,0L,9L,3L,5L,6L,2L,7L,0L,3L,5L,4L,6L,1L,9L,7L,0L,3L,6L,1L,1L,3L,6L,2L,9L,0L,8L,7L,4L,2L,3L,5L,9L,1L,0L,8L,1L,7L,1L,2L,1L,4L,5L,5L,0L,6L,4L,1L,4L,8L,6L,7L,9L,7L,5L,3L,8L,2L,7L,2L,3L,9L,5L,8L,9L,1L,8L,0L,0L,8L,1L,5L,5L,2L,0L,9L,7L,7L,5L,8L,7L,3L,5L,5L,9L,8L,5L,4L,9L,8L,6L,5L,8L,7L,2L,3L,9L,7L,8L,0L,9L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133844Inst : IEnumerable<long>
{
public static readonly long[] Value=A133844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133844.Bytes);
public long this[int i]=>Value[i];

public static A133844Inst Instance=new A133844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133845
{
public static readonly long[] Value={ 4L,4L,0L,0L,5L,3L,4L,6L,7L,0L,5L,2L,4L,9L,2L,3L,0L,2L,3L,9L,1L,3L,3L,4L,5L,2L,6L,5L,1L,8L,6L,1L,7L,4L,9L,9L,1L,6L,8L,2L,8L,1L,3L,7L,6L,8L,0L,2L,6L,6L,9L,8L,8L,1L,8L,9L,4L,2L,7L,2L,4L,6L,9L,3L,0L,7L,5L,2L,2L,0L,2L,1L,8L,7L,0L,0L,0L,3L,7L,1L,9L,6L,4L,6L,2L,7L,6L,9L,7L,5L,8L,9L,2L,3L,0L,7L,5L,8L,6L,3L,4L,8L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133845Inst : IEnumerable<long>
{
public static readonly long[] Value=A133845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133845.Bytes);
public long this[int i]=>Value[i];

public static A133845Inst Instance=new A133845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133846
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,5L,7L,11L,19L,31L,111L,195L,283L,465L,831L,1381L,4969L,8741L,12697L,20885L,37353L,62101L,223471L,393121L,571051L,939331L,1680031L,2793151L,10051203L,17681675L,25684567L,42248981L,75564019L,125629681L,452080641L,795282225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133846Inst : IEnumerable<long>
{
public static readonly long[] Value=A133846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133846.Bytes);
public long this[int i]=>Value[i];

public static A133846Inst Instance=new A133846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133847
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,5L,7L,9L,13L,21L,33L,49L,169L,293L,421L,553L,823L,1365L,2179L,3265L,11289L,19585L,28153L,36993L,55081L,91393L,145929L,218689L,756163L,1311861L,1885783L,2477929L,3689557L,6121925L,9775033L,14648881L,50651601L,87875061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133847Inst : IEnumerable<long>
{
public static readonly long[] Value=A133847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133847.Bytes);
public long this[int i]=>Value[i];

public static A133847Inst Instance=new A133847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133880
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133880Inst : IEnumerable<long>
{
public static readonly long[] Value=A133880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133880.Bytes);
public long this[int i]=>Value[i];

public static A133880Inst Instance=new A133880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133881
{
public static readonly long[] Value={ 4L,68L,164L,260L,292L,356L,388L,452L,484L,516L,548L,676L,708L,772L,836L,932L,964L,1028L,1060L,1124L,1156L,1252L,1348L,1412L,1444L,1508L,1572L,1604L,1636L,1732L,1796L,1828L,1892L,1924L,2084L,2116L,2244L,2276L,2308L,2372L,2404L,2468L,2564L,2596L,2692L,2756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133881Inst : IEnumerable<long>
{
public static readonly long[] Value=A133881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133881.Bytes);
public long this[int i]=>Value[i];

public static A133881Inst Instance=new A133881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133882
{
public static readonly long[] Value={ 1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L,3L,2L,2L,3L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133882Inst : IEnumerable<long>
{
public static readonly long[] Value=A133882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133882.Bytes);
public long this[int i]=>Value[i];

public static A133882Inst Instance=new A133882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133883
{
public static readonly long[] Value={ 1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,0L,0L,0L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,0L,0L,0L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L,0L,0L,0L,1L,4L,1L,2L,8L,2L,3L,3L,3L,4L,7L,4L,5L,2L,5L,6L,6L,6L,7L,1L,7L,8L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133883Inst : IEnumerable<long>
{
public static readonly long[] Value=A133883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133883.Bytes);
public long this[int i]=>Value[i];

public static A133883Inst Instance=new A133883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133884
{
public static readonly long[] Value={ 1L,1L,3L,3L,2L,2L,2L,2L,3L,3L,1L,1L,0L,0L,0L,0L,1L,1L,3L,3L,2L,2L,2L,2L,3L,3L,1L,1L,0L,0L,0L,0L,1L,1L,3L,3L,2L,2L,2L,2L,3L,3L,1L,1L,0L,0L,0L,0L,1L,1L,3L,3L,2L,2L,2L,2L,3L,3L,1L,1L,0L,0L,0L,0L,1L,1L,3L,3L,2L,2L,2L,2L,3L,3L,1L,1L,0L,0L,0L,0L,1L,1L,3L,3L,2L,2L,2L,2L,3L,3L,1L,1L,0L,0L,0L,0L,1L,1L,3L,3L,2L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133884Inst : IEnumerable<long>
{
public static readonly long[] Value=A133884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133884.Bytes);
public long this[int i]=>Value[i];

public static A133884Inst Instance=new A133884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133885
{
public static readonly long[] Value={ 1L,6L,21L,6L,1L,2L,12L,17L,12L,2L,3L,18L,13L,18L,3L,4L,24L,9L,24L,4L,5L,5L,5L,5L,5L,6L,11L,1L,11L,6L,7L,17L,22L,17L,7L,8L,23L,18L,23L,8L,9L,4L,14L,4L,9L,10L,10L,10L,10L,10L,11L,16L,6L,16L,11L,12L,22L,2L,22L,12L,13L,3L,23L,3L,13L,14L,9L,19L,9L,14L,15L,15L,15L,15L,15L,16L,21L,11L,21L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133885Inst : IEnumerable<long>
{
public static readonly long[] Value=A133885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133885.Bytes);
public long this[int i]=>Value[i];

public static A133885Inst Instance=new A133885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133886
{
public static readonly long[] Value={ 1L,1L,4L,0L,0L,0L,0L,0L,3L,1L,4L,4L,0L,0L,0L,0L,3L,3L,4L,4L,4L,0L,0L,0L,3L,3L,0L,4L,4L,4L,0L,0L,3L,3L,0L,0L,4L,4L,4L,0L,3L,3L,0L,0L,0L,4L,4L,4L,3L,3L,0L,0L,0L,0L,4L,4L,1L,3L,0L,0L,0L,0L,0L,4L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,4L,0L,0L,0L,0L,0L,3L,1L,4L,4L,0L,0L,0L,0L,3L,3L,4L,4L,4L,0L,0L,0L,3L,3L,0L,4L,4L,4L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133886Inst : IEnumerable<long>
{
public static readonly long[] Value=A133886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133886.Bytes);
public long this[int i]=>Value[i];

public static A133886Inst Instance=new A133886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133887
{
public static readonly long[] Value={ 1L,8L,36L,22L,36L,8L,1L,2L,16L,23L,44L,23L,16L,2L,3L,24L,10L,17L,10L,24L,3L,4L,32L,46L,39L,46L,32L,4L,5L,40L,33L,12L,33L,40L,5L,6L,48L,20L,34L,20L,48L,6L,7L,7L,7L,7L,7L,7L,7L,8L,15L,43L,29L,43L,15L,8L,9L,23L,30L,2L,30L,23L,9L,10L,31L,17L,24L,17L,31L,10L,11L,39L,4L,46L,4L,39L,11L,12L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133887Inst : IEnumerable<long>
{
public static readonly long[] Value=A133887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133887.Bytes);
public long this[int i]=>Value[i];

public static A133887Inst Instance=new A133887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133888
{
public static readonly long[] Value={ 1L,1L,5L,5L,7L,7L,3L,3L,6L,6L,6L,6L,2L,2L,2L,2L,7L,7L,3L,3L,1L,1L,5L,5L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,1L,1L,3L,3L,7L,7L,2L,2L,2L,2L,6L,6L,6L,6L,3L,3L,7L,7L,5L,5L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,5L,5L,7L,7L,3L,3L,6L,6L,6L,6L,2L,2L,2L,2L,7L,7L,3L,3L,1L,1L,5L,5L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,1L,1L,3L,3L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133888Inst : IEnumerable<long>
{
public static readonly long[] Value=A133888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133888.Bytes);
public long this[int i]=>Value[i];

public static A133888Inst Instance=new A133888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133889
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,4L,1L,1L,1L,2L,2L,2L,8L,8L,8L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,7L,7L,7L,4L,4L,4L,5L,5L,5L,2L,2L,2L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,1L,1L,1L,7L,7L,7L,8L,8L,8L,5L,5L,5L,8L,8L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,4L,4L,4L,1L,1L,1L,2L,2L,2L,8L,8L,8L,2L,2L,2L,3L,3L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133889Inst : IEnumerable<long>
{
public static readonly long[] Value=A133889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133889.Bytes);
public long this[int i]=>Value[i];

public static A133889Inst Instance=new A133889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133890
{
public static readonly long[] Value={ 1L,1L,6L,6L,1L,3L,8L,8L,8L,8L,6L,6L,6L,6L,6L,0L,5L,5L,0L,0L,5L,5L,0L,0L,0L,6L,6L,6L,6L,6L,8L,8L,3L,3L,8L,6L,1L,1L,6L,6L,0L,0L,0L,0L,0L,0L,0L,0L,5L,5L,6L,6L,1L,1L,6L,8L,8L,8L,8L,8L,6L,6L,6L,6L,1L,5L,0L,0L,5L,5L,0L,0L,0L,0L,0L,6L,6L,6L,6L,6L,3L,3L,8L,8L,3L,1L,6L,6L,6L,6L,0L,0L,0L,0L,0L,0L,5L,5L,0L,0L,1L,1L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133890Inst : IEnumerable<long>
{
public static readonly long[] Value=A133890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133890.Bytes);
public long this[int i]=>Value[i];

public static A133890Inst Instance=new A133890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133891
{
public static readonly long[] Value={ 1L,1L,7L,11L,8L,8L,0L,0L,6L,2L,2L,2L,4L,4L,4L,0L,3L,3L,9L,9L,0L,0L,0L,0L,0L,0L,0L,4L,4L,4L,8L,8L,5L,9L,3L,3L,8L,8L,8L,4L,10L,10L,6L,6L,0L,0L,0L,0L,3L,3L,9L,9L,0L,0L,4L,4L,4L,8L,8L,8L,0L,0L,0L,8L,5L,5L,7L,7L,4L,0L,0L,0L,6L,6L,6L,6L,0L,0L,0L,0L,3L,7L,1L,1L,8L,8L,8L,0L,0L,0L,8L,8L,8L,4L,4L,4L,9L,9L,3L,3L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133891Inst : IEnumerable<long>
{
public static readonly long[] Value=A133891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133891.Bytes);
public long this[int i]=>Value[i];

public static A133891Inst Instance=new A133891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133892
{
public static readonly BigInteger[] Value={ 0L,1L,2L,6L,36L,360L,4542L,68544L,1226792L,25441920L,598142170L,15713984000L,456391238028L,14521095333888L,502259604707798L,18763725111828480L,752970270575818192L,BigInteger.Parse("32301914469949407232"),BigInteger.Parse("1475208429063535282482"),BigInteger.Parse("71458043399471257288704"),BigInteger.Parse("3659301012147404374818420") };
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
public class A133892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133892Inst Instance=new A133892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133893
{
public static readonly long[] Value={ 6L,7L,8L,15L,16L,17L,24L,25L,26L,33L,34L,35L,42L,43L,44L,51L,52L,53L,60L,61L,62L,69L,70L,71L,78L,79L,80L,87L,88L,89L,96L,97L,98L,105L,106L,107L,114L,115L,116L,123L,124L,125L,132L,133L,134L,141L,142L,143L,150L,151L,152L,159L,160L,161L,168L,169L,170L,177L,178L,179L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133893Inst : IEnumerable<long>
{
public static readonly long[] Value=A133893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133893.Bytes);
public long this[int i]=>Value[i];

public static A133893Inst Instance=new A133893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133894
{
public static readonly long[] Value={ 12L,13L,14L,15L,28L,29L,30L,31L,44L,45L,46L,47L,60L,61L,62L,63L,76L,77L,78L,79L,92L,93L,94L,95L,108L,109L,110L,111L,124L,125L,126L,127L,140L,141L,142L,143L,156L,157L,158L,159L,172L,173L,174L,175L,188L,189L,190L,191L,204L,205L,206L,207L,220L,221L,222L,223L,236L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133894Inst : IEnumerable<long>
{
public static readonly long[] Value=A133894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133894.Bytes);
public long this[int i]=>Value[i];

public static A133894Inst Instance=new A133894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133895
{
public static readonly long[] Value={ 20L,21L,22L,23L,24L,45L,46L,47L,48L,49L,70L,71L,72L,73L,74L,95L,96L,97L,98L,99L,120L,121L,122L,123L,124L,145L,146L,147L,148L,149L,170L,171L,172L,173L,174L,195L,196L,197L,198L,199L,220L,221L,222L,223L,224L,245L,246L,247L,248L,249L,270L,271L,272L,273L,274L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133895Inst : IEnumerable<long>
{
public static readonly long[] Value=A133895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133895.Bytes);
public long this[int i]=>Value[i];

public static A133895Inst Instance=new A133895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133944
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133944Inst : IEnumerable<long>
{
public static readonly long[] Value=A133944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133944.Bytes);
public long this[int i]=>Value[i];

public static A133944Inst Instance=new A133944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133945
{
public static readonly long[] Value={ 1L,0L,3L,2L,5L,2L,7L,6L,9L,8L,11L,6L,13L,12L,15L,14L,17L,14L,19L,12L,21L,20L,23L,18L,25L,24L,27L,26L,29L,20L,31L,30L,33L,32L,35L,30L,37L,36L,39L,32L,41L,30L,43L,42L,45L,44L,47L,42L,49L,48L,51L,50L,53L,50L,55L,44L,57L,56L,59L,48L,61L,60L,63L,62L,65L,62L,67L,66L,69L,68L,71L,56L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133945Inst : IEnumerable<long>
{
public static readonly long[] Value=A133945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133945.Bytes);
public long this[int i]=>Value[i];

public static A133945Inst Instance=new A133945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133946
{
public static readonly long[] Value={ 2L,2L,4L,2L,2L,6L,2L,2L,4L,8L,2L,6L,2L,2L,10L,2L,2L,6L,2L,8L,12L,2L,2L,6L,2L,2L,4L,12L,2L,12L,2L,2L,4L,2L,2L,16L,2L,2L,4L,8L,2L,14L,2L,2L,20L,2L,2L,6L,2L,8L,4L,2L,2L,6L,16L,12L,4L,2L,2L,12L,2L,2L,12L,2L,2L,20L,2L,2L,4L,8L,2L,16L,2L,2L,10L,2L,2L,22L,2L,8L,4L,2L,2L,18L,2L,2L,4L,2L,2L,22L,20L,2L,4L,2L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133946Inst : IEnumerable<long>
{
public static readonly long[] Value=A133946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133946.Bytes);
public long this[int i]=>Value[i];

public static A133946Inst Instance=new A133946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133947
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,5L,4L,6L,7L,4L,6L,6L,4L,8L,8L,4L,5L,5L,6L,11L,7L,4L,6L,8L,4L,5L,8L,4L,7L,7L,4L,8L,5L,4L,15L,6L,4L,5L,10L,6L,7L,7L,4L,12L,9L,4L,6L,9L,4L,7L,8L,4L,5L,10L,10L,9L,5L,4L,8L,8L,4L,7L,10L,6L,9L,5L,4L,6L,10L,4L,8L,8L,4L,7L,10L,4L,11L,5L,6L,13L,5L,4L,8L,15L,4L,5L,8L,4L,9L,13L,6L,6L,5L,4L,12L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133947Inst : IEnumerable<long>
{
public static readonly long[] Value=A133947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133947.Bytes);
public long this[int i]=>Value[i];

public static A133947Inst Instance=new A133947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133948
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,6L,5L,4L,6L,6L,4L,8L,12L,6L,7L,7L,6L,13L,9L,4L,10L,16L,8L,11L,16L,8L,9L,9L,8L,16L,11L,12L,21L,12L,4L,11L,22L,10L,9L,9L,8L,24L,15L,4L,14L,21L,14L,17L,16L,8L,11L,22L,22L,23L,11L,4L,16L,16L,4L,17L,32L,22L,23L,11L,8L,18L,22L,12L,16L,16L,4L,17L,26L,20L,21L,11L,14L,37L,15L,4L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133948Inst : IEnumerable<long>
{
public static readonly long[] Value=A133948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133948.Bytes);
public long this[int i]=>Value[i];

public static A133948Inst Instance=new A133948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133949
{
public static readonly long[] Value={ 0L,0L,3L,2L,0L,0L,2L,4L,0L,0L,3L,3L,0L,0L,6L,2L,0L,0L,2L,8L,0L,0L,4L,6L,0L,0L,5L,2L,0L,0L,2L,6L,0L,0L,10L,3L,0L,0L,8L,4L,0L,0L,2L,8L,0L,0L,4L,7L,0L,0L,3L,2L,0L,0L,6L,6L,0L,0L,5L,5L,0L,0L,8L,4L,0L,0L,2L,3L,0L,0L,4L,4L,0L,0L,5L,2L,0L,0L,4L,9L,0L,0L,5L,10L,0L,0L,6L,2L,0L,0L,4L,3L,0L,0L,10L,4L,0L,0L,8L,2L,0L,0L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133949Inst : IEnumerable<long>
{
public static readonly long[] Value=A133949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133949.Bytes);
public long this[int i]=>Value[i];

public static A133949Inst Instance=new A133949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133950
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,4L,4L,5L,6L,4L,5L,5L,4L,8L,10L,6L,6L,6L,6L,8L,8L,4L,8L,12L,6L,8L,11L,6L,8L,8L,8L,14L,8L,8L,14L,9L,4L,8L,16L,8L,8L,8L,6L,16L,12L,4L,12L,17L,9L,12L,13L,6L,8L,16L,18L,18L,8L,4L,11L,11L,4L,12L,28L,20L,16L,8L,6L,13L,16L,8L,14L,14L,4L,12L,19L,14L,16L,8L,12L,31L,10L,4L,11L,22L,8L,8L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133950Inst : IEnumerable<long>
{
public static readonly long[] Value=A133950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133950.Bytes);
public long this[int i]=>Value[i];

public static A133950Inst Instance=new A133950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133951
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,11L,17L,19L,23L,27L,43L,43L,64L,74L,80L,82L,124L,124L,177L,185L,195L,214L,300L,300L,300L,328L,328L,334L,454L,454L,618L,618L,635L,677L,677L,677L,872L,936L,949L,949L,1224L,1228L,1579L,1587L,1587L,1672L,2124L,2124L,2126L,2126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133951Inst : IEnumerable<long>
{
public static readonly long[] Value=A133951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133951.Bytes);
public long this[int i]=>Value[i];

public static A133951Inst Instance=new A133951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133952
{
public static readonly long[] Value={ 1L,0L,1L,4L,10L,19L,43L,77L,137L,243L,497L,749L,1520L,2518L,3952L,5294L,10628L,14564L,29199L,40855L,60605L,95786L,191700L,242580L,339732L,531896L,677048L,916946L,1834106L,2332346L,4664982L,5528982L,7863685L,12164443L,16422235L,19594843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133952Inst : IEnumerable<long>
{
public static readonly long[] Value=A133952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133952.Bytes);
public long this[int i]=>Value[i];

public static A133952Inst Instance=new A133952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133953
{
public static readonly long[] Value={ 2L,6L,12L,24L,50L,110L,252L,592L,1410L,3382L,8140L,19624L,47346L,114270L,275836L,665888L,1607554L,3880934L,9369356L,22619576L,54608434L,131836366L,318281084L,768398448L,1855077890L,4478554134L,10812186060L,26102926152L,63018038258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133953Inst : IEnumerable<long>
{
public static readonly long[] Value=A133953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133953.Bytes);
public long this[int i]=>Value[i];

public static A133953Inst Instance=new A133953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133954
{
public static readonly BigInteger[] Value={ 0L,3L,5L,-7L,11L,13L,697L,19L,-23L,29L,-237367L,37L,97129L,44250483L,-47L,53L,59L,61L,67L,-71L,1325443061345L,-79L,83L,6096136101052865L,6711137545L,101L,-103L,107L,197096207419453L,1733616652657L,BigInteger.Parse("-16388345406766785202757351"),131L,904581545L };
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
public class A133954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133954Inst Instance=new A133954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133955
{
public static readonly long[] Value={ 2L,23L,211L,773L,773L,13367L,3411949L,236122171L,3129706267L,3314192745739L,711114155396657L,331149818444273L,3331113965338635107L,3331113965338635107L,7241721710291471119L,3318308475676071413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133955Inst : IEnumerable<long>
{
public static readonly long[] Value=A133955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133955.Bytes);
public long this[int i]=>Value[i];

public static A133955Inst Instance=new A133955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133956
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,29L,31L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,239L,251L,263L,269L,281L,293L,307L,349L,401L,409L,419L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133956Inst : IEnumerable<long>
{
public static readonly long[] Value=A133956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133956.Bytes);
public long this[int i]=>Value[i];

public static A133956Inst Instance=new A133956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133957
{
public static readonly long[] Value={ 23L,37L,211L,223L,227L,229L,233L,241L,257L,271L,277L,283L,311L,313L,317L,331L,337L,347L,353L,359L,367L,373L,379L,383L,389L,397L,523L,541L,547L,557L,571L,577L,719L,743L,761L,773L,797L,1117L,1123L,1129L,1153L,1171L,1319L,1361L,1367L,1373L,1723L,1741L,1747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133957Inst : IEnumerable<long>
{
public static readonly long[] Value=A133957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133957.Bytes);
public long this[int i]=>Value[i];

public static A133957Inst Instance=new A133957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133958
{
public static readonly long[] Value={ 37L,227L,229L,233L,241L,257L,271L,277L,283L,313L,317L,331L,347L,353L,359L,367L,383L,397L,523L,541L,557L,577L,719L,743L,761L,797L,1117L,1171L,1361L,1367L,1373L,1723L,1741L,1747L,1753L,1759L,1783L,1789L,1973L,1979L,1997L,2113L,2131L,2137L,2179L,2213L,2239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133958Inst : IEnumerable<long>
{
public static readonly long[] Value=A133958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133958.Bytes);
public long this[int i]=>Value[i];

public static A133958Inst Instance=new A133958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133959
{
public static readonly long[] Value={ 211L,223L,311L,337L,373L,379L,389L,547L,571L,773L,1123L,1129L,1153L,1319L,1931L,2237L,2311L,2341L,2347L,2371L,2383L,2389L,2557L,2719L,2797L,2953L,2971L,3137L,3167L,3181L,3191L,3251L,3257L,3313L,3329L,3331L,3347L,3359L,3373L,3389L,3449L,3457L,3461L,3463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133959Inst : IEnumerable<long>
{
public static readonly long[] Value=A133959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133959.Bytes);
public long this[int i]=>Value[i];

public static A133959Inst Instance=new A133959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133992
{
public static readonly long[] Value={ 2L,4L,8L,4L,12L,12L,8L,16L,18L,16L,24L,30L,8L,6L,12L,12L,4L,24L,72L,8L,32L,8L,24L,24L,6L,8L,24L,16L,8L,64L,16L,8L,36L,16L,8L,24L,16L,48L,16L,24L,6L,24L,8L,16L,6L,12L,16L,4L,32L,24L,8L,48L,16L,16L,6L,16L,8L,16L,12L,24L,18L,24L,40L,96L,16L,16L,72L,24L,8L,16L,36L,16L,8L,16L,16L,48L,16L,48L,48L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133992Inst : IEnumerable<long>
{
public static readonly long[] Value=A133992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133992.Bytes);
public long this[int i]=>Value[i];

public static A133992Inst Instance=new A133992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133993
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,14L,31L,56L,117L,226L,459L,908L,1825L,3638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133993Inst : IEnumerable<long>
{
public static readonly long[] Value=A133993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133993.Bytes);
public long this[int i]=>Value[i];

public static A133993Inst Instance=new A133993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133994
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,5L,6L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,7L,8L,1L,2L,3L,4L,5L,7L,8L,9L,1L,2L,3L,5L,7L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,1L,2L,3L,4L,5L,6L,7L,11L,12L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,1L,2L,3L,5L,7L,9L,11L,13L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133994Inst : IEnumerable<long>
{
public static readonly long[] Value=A133994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133994.Bytes);
public long this[int i]=>Value[i];

public static A133994Inst Instance=new A133994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133995
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,4L,0L,6L,6L,4L,6L,8L,0L,8L,9L,10L,0L,4L,6L,8L,10L,12L,6L,9L,10L,12L,6L,10L,12L,14L,0L,4L,8L,10L,12L,14L,15L,16L,0L,6L,8L,12L,14L,15L,16L,18L,6L,9L,12L,14L,15L,18L,4L,6L,8L,10L,12L,14L,16L,18L,20L,0L,9L,10L,14L,15L,16L,18L,20L,21L,22L,10L,15L,20L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,6L,12L,15L,18L,21L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133995Inst : IEnumerable<long>
{
public static readonly long[] Value=A133995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133995.Bytes);
public long this[int i]=>Value[i];

public static A133995Inst Instance=new A133995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133996
{
public static readonly long[] Value={ 2L,6L,12L,30L,60L,90L,180L,360L,630L,420L,840L,1680L,4200L,1260L,2520L,3780L,7560L,15120L,13860L,36960L,49140L,27720L,32760L,65520L,83160L,98280L,196560L,314160L,277200L,491400L,526680L,471240L,360360L,1164240L,942480L,720720L,1081080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133996Inst : IEnumerable<long>
{
public static readonly long[] Value=A133996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133996.Bytes);
public long this[int i]=>Value[i];

public static A133996Inst Instance=new A133996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133997
{
public static readonly long[] Value={ 1L,3L,9L,15L,36L,45L,126L,96L,144L,120L,324L,240L,336L,432L,360L,480L,672L,864L,720L,840L,1260L,1008L,1080L,1920L,1440L,2040L,1680L,2016L,2160L,3024L,2880L,2520L,4620L,4200L,3360L,5544L,4320L,6048L,6300L,9072L,7200L,11700L,5040L,12096L,7920L,7560L,10800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133997Inst : IEnumerable<long>
{
public static readonly long[] Value=A133997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133997.Bytes);
public long this[int i]=>Value[i];

public static A133997Inst Instance=new A133997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133998
{
public static readonly long[] Value={ 1L,1L,37L,577L,8236L,91030L,835476L,6436782L,42650532L,246386091L,1256602779L,5711668755L,23322797475L,86114390460L,289098819780L,886568158468L,2493474394140L,6453694644705L,15417163018725L,34080036632565L,69864082608210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133998Inst : IEnumerable<long>
{
public static readonly long[] Value=A133998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133998.Bytes);
public long this[int i]=>Value[i];

public static A133998Inst Instance=new A133998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133999
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,19L,36L,69L,131L,251L,478L,913L,1741L,3322L,6338L,12092L,23070L,44014L,83972L,160206L,305650L,583135L,1112536L,2122555L,4049524L,7725897L,14739878L,28121524L,53651742L,102359650L,195287193L,372579307L,710826647L,1356152937L,2587340805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133999Inst : IEnumerable<long>
{
public static readonly long[] Value=A133999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133999.Bytes);
public long this[int i]=>Value[i];

public static A133999Inst Instance=new A133999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134000
{
public static readonly long[] Value={ 2L,6L,4L,12L,18L,8L,30L,20L,54L,10L,60L,42L,24L,66L,14L,90L,72L,126L,36L,78L,16L,180L,168L,84L,150L,40L,102L,22L,360L,210L,270L,120L,294L,48L,114L,26L,630L,660L,240L,330L,132L,306L,56L,138L,28L,420L,924L,1080L,480L,336L,144L,342L,80L,162L,32L,840L,720L,1200L,1092L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134000Inst : IEnumerable<long>
{
public static readonly long[] Value=A134000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134000.Bytes);
public long this[int i]=>Value[i];

public static A134000Inst Instance=new A134000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134001
{
public static readonly long[] Value={ 3L,9L,5L,15L,16L,7L,36L,21L,18L,8L,45L,54L,24L,25L,10L,126L,48L,64L,27L,30L,11L,96L,150L,60L,66L,28L,42L,12L,144L,105L,162L,63L,78L,32L,49L,13L,120L,168L,108L,196L,70L,81L,33L,121L,14L,324L,180L,198L,135L,256L,72L,90L,35L,169L,17L,240L,378L,192L,225L,140L,294L,75L,100L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134001Inst : IEnumerable<long>
{
public static readonly long[] Value=A134001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134001.Bytes);
public long this[int i]=>Value[i];

public static A134001Inst Instance=new A134001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134002
{
public static readonly long[] Value={ 5L,10L,11L,13L,15L,16L,20L,23L,24L,25L,30L,31L,33L,35L,36L,37L,38L,40L,42L,45L,46L,47L,49L,50L,55L,57L,60L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,73L,75L,76L,80L,81L,84L,85L,86L,88L,89L,90L,92L,95L,98L,99L,100L,101L,102L,105L,108L,110L,111L,112L,114L,115L,118L,120L,124L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134002Inst : IEnumerable<long>
{
public static readonly long[] Value=A134002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134002.Bytes);
public long this[int i]=>Value[i];

public static A134002Inst Instance=new A134002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134003
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,12L,14L,17L,18L,19L,21L,22L,26L,27L,28L,29L,32L,34L,39L,41L,43L,44L,48L,51L,52L,53L,54L,56L,58L,59L,66L,72L,74L,77L,78L,79L,82L,83L,87L,91L,93L,94L,96L,97L,103L,104L,106L,107L,109L,113L,116L,117L,119L,121L,122L,123L,126L,134L,136L,137L,144L,151L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134003Inst : IEnumerable<long>
{
public static readonly long[] Value=A134003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134003.Bytes);
public long this[int i]=>Value[i];

public static A134003Inst Instance=new A134003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134004
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,14L,22L,32L,46L,66L,93L,128L,176L,238L,319L,426L,562L,736L,960L,1244L,1602L,2054L,2620L,3324L,4203L,5292L,6634L,8290L,10322L,12808L,15845L,19542L,24028L,29468L,36042L,43966L,53506L,64960L,78685L,95106L,114709L,138066L,165855L,198856L,237979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134004Inst : IEnumerable<long>
{
public static readonly long[] Value=A134004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134004.Bytes);
public long this[int i]=>Value[i];

public static A134004Inst Instance=new A134004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134005
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,4L,-4L,5L,-6L,9L,-12L,13L,-16L,21L,-26L,29L,-36L,46L,-54L,62L,-76L,94L,-108L,126L,-150L,179L,-210L,239L,-282L,335L,-384L,440L,-512L,597L,-684L,781L,-902L,1041L,-1186L,1347L,-1544L,1768L,-2006L,2268L,-2584L,2941L,-3318L,3742L,-4236L,4792L,-5392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134005Inst : IEnumerable<long>
{
public static readonly long[] Value=A134005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134005.Bytes);
public long this[int i]=>Value[i];

public static A134005Inst Instance=new A134005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134006
{
public static readonly long[] Value={ 4L,16L,84L,496L,3108L,20176L,134004L,903856L,6161988L,42326416L,292299924L,2026332016L,14085959268L,98111307856L,684331371444L,4778093436976L,33385561506948L,233393582580496L,1632228682596564L,11417969833962736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134006Inst : IEnumerable<long>
{
public static readonly long[] Value=A134006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134006.Bytes);
public long this[int i]=>Value[i];

public static A134006Inst Instance=new A134006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134007
{
public static readonly long[] Value={ 5L,25L,165L,1225L,9669L,79225L,665445L,5686825L,49208709L,429746905L,3779084325L,33407391625L,296515495749L,2639977136185L,23561123826405L,210669225531625L,1886405750358789L,16910575282247065L,151726863979595685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134007Inst : IEnumerable<long>
{
public static readonly long[] Value=A134007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134007.Bytes);
public long this[int i]=>Value[i];

public static A134007Inst Instance=new A134007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134072
{
public static readonly BigInteger[] Value={ 1L,31L,431L,7431L,117431L,18117431L,2918117431L,472918117431L,76472918117431L,12376472918117431L,BigInteger.Parse("19912376472918117431"),BigInteger.Parse("32219912376472918117431"),BigInteger.Parse("52132219912376472918117431"),BigInteger.Parse("84352132219912376472918117431") };
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
public class A134072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134072Inst Instance=new A134072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134073
{
public static readonly long[] Value={ 3L,9L,10L,17L,611L,6717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134073Inst : IEnumerable<long>
{
public static readonly long[] Value=A134073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134073.Bytes);
public long this[int i]=>Value[i];

public static A134073Inst Instance=new A134073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134074
{
public static readonly long[] Value={ -4L,2L,3L,6L,72L,356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134074Inst : IEnumerable<long>
{
public static readonly long[] Value=A134074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134074.Bytes);
public long this[int i]=>Value[i];

public static A134074Inst Instance=new A134074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134075
{
public static readonly long[] Value={ 907L,3019L,5281L,11689L,16741L,33329L,241051L,248063L,382649L,556819L,852757L,1104737L,1372627L,3122771L,3590089L,5482207L,5870659L,6505361L,7059161L,7753579L,8751097L,17452957L,18080497L,18261829L,26184449L,28633609L,30561919L,37544699L,37762223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134075Inst : IEnumerable<long>
{
public static readonly long[] Value=A134075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134075.Bytes);
public long this[int i]=>Value[i];

public static A134075Inst Instance=new A134075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134076
{
public static readonly long[] Value={ 17L,31L,41L,61L,73L,103L,277L,281L,349L,421L,521L,593L,661L,997L,1069L,1321L,1367L,1439L,1499L,1571L,1669L,2357L,2399L,2411L,2887L,3019L,3119L,3457L,3467L,3917L,4049L,4091L,4211L,4241L,4297L,4337L,4441L,4691L,4721L,5077L,5231L,5261L,5393L,5591L,5813L,6101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134076Inst : IEnumerable<long>
{
public static readonly long[] Value=A134076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134076.Bytes);
public long this[int i]=>Value[i];

public static A134076Inst Instance=new A134076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134077
{
public static readonly long[] Value={ 1L,-5L,6L,8L,-23L,12L,14L,-30L,18L,20L,-40L,24L,31L,-77L,30L,32L,-60L,48L,38L,-70L,42L,44L,-138L,48L,57L,-90L,54L,72L,-100L,60L,62L,-184L,84L,68L,-120L,72L,74L,-155L,96L,80L,-239L,84L,108L,-150L,90L,112L,-160L,120L,98L,-276L,102L,104L,-240L,108L,110L,-190L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134077Inst : IEnumerable<long>
{
public static readonly long[] Value=A134077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134077.Bytes);
public long this[int i]=>Value[i];

public static A134077Inst Instance=new A134077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134078
{
public static readonly long[] Value={ 1L,-6L,18L,-34L,42L,-36L,30L,-48L,90L,-118L,108L,-72L,54L,-84L,144L,-204L,186L,-108L,66L,-120L,252L,-272L,216L,-144L,102L,-186L,252L,-370L,336L,-180L,180L,-192L,378L,-408L,324L,-288L,90L,-228L,360L,-476L,540L,-252L,240L,-264L,504L,-708L,432L,-288L,198L,-342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134078Inst : IEnumerable<long>
{
public static readonly long[] Value=A134078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134078.Bytes);
public long this[int i]=>Value[i];

public static A134078Inst Instance=new A134078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134079
{
public static readonly long[] Value={ 1L,-2L,5L,-4L,8L,-6L,14L,-8L,14L,-10L,21L,-16L,20L,-14L,28L,-16L,31L,-18L,40L,-20L,32L,-28L,42L,-24L,38L,-32L,62L,-28L,44L,-30L,56L,-40L,57L,-34L,70L,-36L,72L,-38L,70L,-48L,62L,-52L,85L,-44L,68L,-46L,112L,-56L,74L,-50L,100L,-64L,80L,-64L,98L,-56L,108L,-58L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134079Inst : IEnumerable<long>
{
public static readonly long[] Value=A134079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134079.Bytes);
public long this[int i]=>Value[i];

public static A134079Inst Instance=new A134079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134080
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,12L,12L,10L,16L,20L,12L,22L,25L,20L,30L,32L,24L,30L,36L,24L,42L,42L,35L,46L,43L,32L,52L,60L,40L,60L,62L,42L,60L,66L,44L,72L,72L,50L,72L,80L,61L,82L,80L,60L,90L,72L,64L,100L,96L,84L,102L,102L,60L,106L,110L,72L,112L,110L,84L,96L,133L,84L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134080Inst : IEnumerable<long>
{
public static readonly long[] Value=A134080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134080.Bytes);
public long this[int i]=>Value[i];

public static A134080Inst Instance=new A134080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134081
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,4L,12L,8L,1L,5L,22L,26L,11L,1L,6L,35L,60L,45L,14L,1L,7L,51L,115L,125L,69L,17L,1L,8L,70L,196L,280L,224L,98L,20L,1L,9L,92L,308L,546L,574L,364L,132L,23L,1L,10L,117L,456L,966L,1260L,1050L,552L,171L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134081Inst : IEnumerable<long>
{
public static readonly long[] Value=A134081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134081.Bytes);
public long this[int i]=>Value[i];

public static A134081Inst Instance=new A134081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134082
{
public static readonly long[] Value={ 1L,2L,1L,0L,4L,1L,0L,0L,6L,1L,0L,0L,0L,8L,1L,0L,0L,0L,0L,10L,1L,0L,0L,0L,0L,0L,12L,1L,0L,0L,0L,0L,0L,0L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134082Inst : IEnumerable<long>
{
public static readonly long[] Value=A134082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134082.Bytes);
public long this[int i]=>Value[i];

public static A134082Inst Instance=new A134082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134083
{
public static readonly long[] Value={ 1L,3L,1L,5L,6L,1L,7L,15L,9L,1L,9L,28L,30L,12L,1L,11L,45L,70L,50L,15L,1L,13L,66L,135L,140L,75L,18L,1L,15L,91L,231L,315L,245L,105L,21L,1L,17L,120L,364L,616L,630L,392L,140L,24L,1L,19L,153L,540L,1092L,1386L,1134L,588L,180L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134083Inst : IEnumerable<long>
{
public static readonly long[] Value=A134083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134083.Bytes);
public long this[int i]=>Value[i];

public static A134083Inst Instance=new A134083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134084
{
public static readonly BigInteger[] Value={ 1L,2L,2L,-4L,-106L,-6948L,-1623788L,-1213437064L,-2912047916698L,-23264250235542100L,BigInteger.Parse("-641982248042094828676"),BigInteger.Parse("-62929856484660987275500088"),BigInteger.Parse("-22331407793040258023249030997892"),BigInteger.Parse("-29057717949243934527799656871001480808") };
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
public class A134084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134084Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134084.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134084.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134084Inst Instance=new A134084Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134085
{
public static readonly BigInteger[] Value={ 1L,2L,2L,0L,-14L,-448L,-51184L,-19010908L,-22769359414L,-90898737308664L,-1253962465550022928L,BigInteger.Parse("-61456191890306429529460"),BigInteger.Parse("-10904069167010301985293186456"),BigInteger.Parse("-7094180325240570739957963715038868"),BigInteger.Parse("-17078681470682524119645862432516881125820") };
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
public class A134085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134085Inst Instance=new A134085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134086
{
public static readonly BigInteger[] Value={ 1L,2L,8L,80L,2464L,255808L,90320512L,108630646016L,451779274750464L,6626041977171637248L,BigInteger.Parse("348460175972420307970048"),BigInteger.Parse("66523219303893985885632450560"),BigInteger.Parse("46531358180797100870477866170818560") };
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
public class A134086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134086Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134086.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134086.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134086Inst Instance=new A134086Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134087
{
public static readonly BigInteger[] Value={ 1L,4L,32L,672L,42816L,8822400L,6065609984L,14256471226880L,117000916309144576L,BigInteger.Parse("3410202131850138806272"),BigInteger.Parse("357670541003601468527333376"),BigInteger.Parse("136391046228660672398602237353984") };
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
public class A134087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134087Inst Instance=new A134087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134136
{
public static readonly long[] Value={ 0L,1L,1L,2L,6L,8L,20L,40L,72L,160L,304L,608L,1248L,2432L,4928L,9856L,19584L,39424L,78592L,157184L,314880L,628736L,1258496L,2516992L,5031936L,10067968L,20131840L,40263680L,80535552L,161054720L,322125824L,644251648L,1288470528L,2577006592L,5153947648L,10307895296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134136Inst : IEnumerable<long>
{
public static readonly long[] Value=A134136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134136.Bytes);
public long this[int i]=>Value[i];

public static A134136Inst Instance=new A134136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134137
{
public static readonly BigInteger[] Value={ 1L,3L,9L,15L,-159L,-3021L,-36903L,-381249L,-3212415L,-12995901L,315857961L,12457515663L,304888863969L,6280156107315L,113710631625081L,1717208752084479L,15528594345353217L,-265033870991715069L,BigInteger.Parse("-22048996644203788215") };
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
public class A134137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134137Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134137.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134137Inst Instance=new A134137Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134138
{
public static readonly long[] Value={ 1L,2L,4L,2L,-74L,-916L,-8672L,-73564L,-542852L,-2595016L,18348496L,906083672L,21021502984L,406255974032L,7157641045696L,116383645516784L,1681549859135248L,18311613681506336L,-3332917116147392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134138Inst : IEnumerable<long>
{
public static readonly long[] Value=A134138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134138.Bytes);
public long this[int i]=>Value[i];

public static A134138Inst Instance=new A134138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134139
{
public static readonly BigInteger[] Value={ 1L,4L,16L,44L,-244L,-7336L,-112664L,-1406336L,-14058944L,-66627136L,1879992896L,85070733824L,2359547577856L,54106723270144L,1055100890838016L,15611883969810944L,48348082318102016L,-9055743653514520576L,BigInteger.Parse("-521351156412528902144") };
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
public class A134139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134139Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134139.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134139Inst Instance=new A134139Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134140
{
public static readonly BigInteger[] Value={ 1L,5L,25L,95L,-275L,-14755L,-278795L,-4134145L,-49014215L,-304537195L,7111142545L,397535340575L,12667519999525L,327297915798125L,7052174242084525L,109425656597938175L,-88497453300450575L,BigInteger.Parse("-107470322009554282075"),BigInteger.Parse("-6297063330456696598775") };
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
public class A134140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134140Inst Instance=new A134140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134141
{
public static readonly long[] Value={ 1L,7L,1L,56L,21L,1L,504L,371L,42L,1L,5040L,6440L,1295L,70L,1L,55440L,114520L,36225L,3325L,105L,1L,665280L,2116800L,983920L,135975L,7105L,147L,1L,8648640L,40884480L,26714800L,5199145L,398860L,13426L,196L,1L,121080960L,826338240L,735469280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134141Inst : IEnumerable<long>
{
public static readonly long[] Value=A134141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134141.Bytes);
public long this[int i]=>Value[i];

public static A134141Inst Instance=new A134141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134142
{
public static readonly long[] Value={ 2L,-3L,2L,2L,-8L,12L,-8L,-8L,32L,-48L,32L,32L,-128L,192L,-128L,-128L,512L,-768L,512L,512L,-2048L,3072L,-2048L,-2048L,8192L,-12288L,8192L,8192L,-32768L,49152L,-32768L,-32768L,131072L,-196608L,131072L,131072L,-524288L,786432L,-524288L,-524288L,2097152L,-3145728L,2097152L,2097152L,-8388608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134142Inst : IEnumerable<long>
{
public static readonly long[] Value=A134142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134142.Bytes);
public long this[int i]=>Value[i];

public static A134142Inst Instance=new A134142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134143
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,3L,2L,3L,1L,4L,3L,3L,3L,2L,6L,3L,5L,3L,3L,3L,3L,3L,8L,4L,2L,3L,3L,6L,4L,4L,6L,7L,8L,3L,6L,3L,9L,8L,7L,7L,5L,8L,4L,1L,6L,6L,3L,7L,1L,6L,6L,4L,8L,1L,5L,5L,8L,9L,11L,10L,6L,8L,16L,13L,9L,12L,6L,7L,8L,4L,16L,9L,6L,13L,10L,9L,5L,6L,6L,8L,11L,16L,11L,13L,6L,6L,6L,17L,9L,6L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134143Inst : IEnumerable<long>
{
public static readonly long[] Value=A134143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134143.Bytes);
public long this[int i]=>Value[i];

public static A134143Inst Instance=new A134143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134144
{
public static readonly long[] Value={ 1L,3L,1L,15L,9L,1L,105L,60L,27L,18L,1L,945L,525L,450L,150L,135L,30L,1L,10395L,5670L,4725L,2250L,1575L,2700L,405L,300L,405L,45L,1L,135135L,72765L,59535L,55125L,19845L,33075L,15750L,14175L,3675L,9450L,2835L,525L,945L,63L,1L,2027025L,1081080L,873180L,793800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134144Inst : IEnumerable<long>
{
public static readonly long[] Value=A134144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134144.Bytes);
public long this[int i]=>Value[i];

public static A134144Inst Instance=new A134144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134145
{
public static readonly long[] Value={ 1L,3L,1L,15L,3L,1L,105L,15L,9L,3L,1L,945L,105L,45L,15L,9L,3L,1L,10395L,945L,315L,225L,105L,45L,27L,15L,9L,3L,1L,135135L,10395L,2835L,1575L,945L,315L,225L,135L,105L,45L,27L,15L,9L,3L,1L,2027025L,135135L,31185L,14175L,11025L,10395L,2835L,1575L,945L,675L,945L,315L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134145Inst : IEnumerable<long>
{
public static readonly long[] Value=A134145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134145.Bytes);
public long this[int i]=>Value[i];

public static A134145Inst Instance=new A134145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134146
{
public static readonly long[] Value={ 1L,3L,1L,15L,3L,1L,105L,24L,3L,1L,945L,150L,24L,3L,1L,10395L,1485L,177L,24L,3L,1L,135135L,14805L,1620L,177L,24L,3L,1L,2027025L,191520L,16425L,1701L,177L,24L,3L,1L,34459425L,2687580L,208125L,16830L,1701L,177L,24L,3L,1L,654729075L,44552025L,2880360L,212985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134146Inst : IEnumerable<long>
{
public static readonly long[] Value=A134146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134146.Bytes);
public long this[int i]=>Value[i];

public static A134146Inst Instance=new A134146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134147
{
public static readonly BigInteger[] Value={ 1L,4L,19L,133L,1123L,12085L,151765L,2236876L,37373866L,702393424L,14611910794L,333811635793L,8298224157103L,223061783080075L,6444694333816630L,199168434836797921L,6555131451981351961L,BigInteger.Parse("228906927287899911709") };
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
public class A134147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134147.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134147Inst Instance=new A134147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134148
{
public static readonly BigInteger[] Value={ 1L,2L,13L,83L,817L,9065L,121795L,1850384L,31964686L,612859952L,12980965588L,300358150373L,7548024748057L,204624140789585L,5954693801179750L,185127523366125449L,6124428454164394921L,BigInteger.Parse("214815152433502078607") };
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
public class A134148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134148Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134148.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134148.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134148Inst Instance=new A134148Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134149
{
public static readonly long[] Value={ 1L,4L,1L,28L,12L,1L,280L,112L,48L,24L,1L,3640L,1400L,1120L,280L,240L,40L,1L,58240L,21840L,16800L,7840L,4200L,6720L,960L,560L,720L,60L,1L,1106560L,407680L,305760L,274400L,76440L,117600L,54880L,47040L,9800L,23520L,6720L,980L,1680L,84L,1L,24344320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134149Inst : IEnumerable<long>
{
public static readonly long[] Value=A134149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134149.Bytes);
public long this[int i]=>Value[i];

public static A134149Inst Instance=new A134149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134150
{
public static readonly long[] Value={ 1L,4L,1L,28L,4L,1L,280L,28L,16L,4L,1L,3640L,280L,112L,28L,16L,4L,1L,58240L,3640L,1120L,784L,280L,112L,64L,28L,16L,4L,1L,1106560L,58240L,14560L,7840L,3640L,1120L,784L,448L,280L,112L,64L,28L,16L,4L,1L,24344320L,1106560L,232960L,101920L,78400L,58240L,14560L,7840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134150Inst : IEnumerable<long>
{
public static readonly long[] Value=A134150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134150.Bytes);
public long this[int i]=>Value[i];

public static A134150Inst Instance=new A134150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134151
{
public static readonly long[] Value={ 1L,4L,1L,28L,4L,1L,280L,44L,4L,1L,3640L,392L,44L,4L,1L,58240L,5544L,456L,44L,4L,1L,1106560L,80640L,5992L,456L,44L,4L,1L,24344320L,1519840L,88256L,6248L,456L,44L,4L,1L,608608000L,31420480L,1631392L,90048L,6248L,456L,44L,4L,1L,17041024000L,766525760L,33293120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134151Inst : IEnumerable<long>
{
public static readonly long[] Value=A134151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134151.Bytes);
public long this[int i]=>Value[i];

public static A134151Inst Instance=new A134151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134200
{
public static readonly BigInteger[] Value={ 0L,1L,2L,9L,68L,725L,9942L,166453L,3290632L,75017097L,1937420010L,55906879809L,1782695466444L,62247810769053L,2362246665531326L,96806321000599725L,4260677055123222544L,BigInteger.Parse("200440759819510706321"),BigInteger.Parse("10037364633737549049042"),BigInteger.Parse("533071599267242747118585") };
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
public class A134200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134200Inst Instance=new A134200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134201
{
public static readonly long[] Value={ 1L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134201Inst : IEnumerable<long>
{
public static readonly long[] Value=A134201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134201.Bytes);
public long this[int i]=>Value[i];

public static A134201Inst Instance=new A134201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134202
{
public static readonly long[] Value={ 1L,5L,13L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134202Inst : IEnumerable<long>
{
public static readonly long[] Value=A134202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134202.Bytes);
public long this[int i]=>Value[i];

public static A134202Inst Instance=new A134202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134203
{
public static readonly long[] Value={ 32L,1L,6L,9L,2L,4L,7L,13L,11L,5L,49L,94L,148L,110L,1L,3L,40L,95L,424L,37L,53L,93L,135L,16L,292L,89L,6L,28L,33L,186L,64L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134203Inst : IEnumerable<long>
{
public static readonly long[] Value=A134203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134203.Bytes);
public long this[int i]=>Value[i];

public static A134203Inst Instance=new A134203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134204
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,41L,31L,29L,37L,11L,67L,59L,61L,83L,53L,73L,79L,101L,109L,89L,233L,103L,47L,239L,139L,113L,293L,97L,151L,137L,127L,43L,167L,157L,509L,251L,373L,107L,467L,163L,181L,347L,193L,313L,439L,281L,307L,443L,271L,197L,227L,367L,733L,331L,353L,401L,71L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134204Inst : IEnumerable<long>
{
public static readonly long[] Value=A134204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134204.Bytes);
public long this[int i]=>Value[i];

public static A134204Inst Instance=new A134204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134205
{
public static readonly long[] Value={ 5L,8L,12L,20L,30L,36L,42L,64L,72L,60L,66L,48L,78L,126L,120L,144L,136L,126L,152L,180L,210L,198L,322L,336L,150L,286L,378L,252L,406L,390L,248L,288L,264L,170L,210L,324L,666L,760L,624L,480L,574L,630L,344L,528L,540L,506L,752L,720L,588L,750L,714L,468L,424L,594L,1100L,1064L,684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134205Inst : IEnumerable<long>
{
public static readonly long[] Value=A134205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134205.Bytes);
public long this[int i]=>Value[i];

public static A134205Inst Instance=new A134205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134206
{
public static readonly long[] Value={ 5L,4L,4L,5L,6L,6L,6L,8L,8L,6L,6L,4L,6L,9L,8L,9L,8L,7L,8L,9L,10L,9L,14L,14L,6L,11L,14L,9L,14L,13L,8L,9L,8L,5L,6L,9L,18L,20L,16L,12L,14L,15L,8L,12L,12L,11L,16L,15L,12L,15L,14L,9L,8L,11L,20L,19L,12L,13L,8L,5L,12L,11L,6L,12L,12L,8L,12L,13L,12L,10L,18L,19L,16L,17L,14L,12L,12L,14L,22L,21L,10L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134206Inst : IEnumerable<long>
{
public static readonly long[] Value=A134206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134206.Bytes);
public long this[int i]=>Value[i];

public static A134206Inst Instance=new A134206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134207
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,19L,23L,41L,67L,73L,103L,113L,173L,191L,199L,233L,277L,281L,479L,521L,571L,617L,809L,823L,827L,863L,919L,929L,1217L,1303L,1487L,1489L,1613L,1753L,2027L,2113L,2179L,2267L,2647L,2713L,3109L,3191L,3259L,3517L,3593L,3767L,3847L,3881L,4057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134207Inst : IEnumerable<long>
{
public static readonly long[] Value=A134207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134207.Bytes);
public long this[int i]=>Value[i];

public static A134207Inst Instance=new A134207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134208
{
public static readonly long[] Value={ 5L,8L,12L,20L,30L,36L,42L,64L,108L,140L,176L,216L,286L,364L,390L,432L,510L,558L,760L,1000L,1092L,1188L,1426L,1632L,1650L,1690L,1782L,1848L,2146L,2520L,2790L,2976L,3102L,3366L,3780L,4140L,4292L,4446L,4914L,5360L,5822L,6300L,6450L,6776L,7110L,7360L,7614L,7728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134208Inst : IEnumerable<long>
{
public static readonly long[] Value=A134208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134208.Bytes);
public long this[int i]=>Value[i];

public static A134208Inst Instance=new A134208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134209
{
public static readonly long[] Value={ 5L,4L,4L,5L,6L,6L,6L,8L,12L,14L,16L,18L,22L,26L,26L,27L,30L,31L,40L,50L,52L,54L,62L,68L,66L,65L,66L,66L,74L,84L,90L,93L,94L,99L,108L,115L,116L,117L,126L,134L,142L,150L,150L,154L,158L,160L,162L,161L,162L,163L,164L,169L,180L,190L,192L,196L,202L,205L,210L,216L,226L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134209Inst : IEnumerable<long>
{
public static readonly long[] Value=A134209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134209.Bytes);
public long this[int i]=>Value[i];

public static A134209Inst Instance=new A134209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134210
{
public static readonly long[] Value={ 49L,163L,175L,206L,269L,442L,681L,780L,852L,854L,1011L,1219L,1223L,1270L,1318L,1487L,1816L,1892L,2162L,2238L,2514L,2534L,2563L,2721L,2749L,2780L,2810L,2874L,2880L,2955L,3170L,3201L,3208L,3241L,3254L,3405L,3457L,3480L,3486L,3494L,3845L,3848L,3939L,3964L,3966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134210Inst : IEnumerable<long>
{
public static readonly long[] Value=A134210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134210.Bytes);
public long this[int i]=>Value[i];

public static A134210Inst Instance=new A134210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134211
{
public static readonly long[] Value={ 1119L,1129L,1139L,1149L,1159L,1169L,1179L,1189L,1190L,1191L,1192L,1193L,1194L,1195L,1196L,1197L,1198L,1199L,1229L,1239L,1249L,1259L,1269L,1279L,1289L,1290L,1291L,1292L,1293L,1294L,1295L,1296L,1297L,1298L,1299L,1339L,1349L,1359L,1369L,1379L,1389L,1390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134211Inst : IEnumerable<long>
{
public static readonly long[] Value=A134211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134211.Bytes);
public long this[int i]=>Value[i];

public static A134211Inst Instance=new A134211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134212
{
public static readonly long[] Value={ 148L,220L,243L,297L,483L,499L,607L,660L,710L,712L,963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134212Inst : IEnumerable<long>
{
public static readonly long[] Value=A134212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134212.Bytes);
public long this[int i]=>Value[i];

public static A134212Inst Instance=new A134212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134213
{
public static readonly long[] Value={ 110L,281L,363L,381L,525L,598L,627L,734L,744L,759L,859L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134213Inst : IEnumerable<long>
{
public static readonly long[] Value=A134213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134213.Bytes);
public long this[int i]=>Value[i];

public static A134213Inst Instance=new A134213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134214
{
public static readonly long[] Value={ 1L,103L,250L,295L,385L,610L,651L,670L,882L,895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134214Inst : IEnumerable<long>
{
public static readonly long[] Value=A134214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134214.Bytes);
public long this[int i]=>Value[i];

public static A134214Inst Instance=new A134214Inst();

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