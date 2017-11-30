using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A019853
{
public static readonly long[] Value={ 6L,9L,4L,6L,5L,8L,3L,7L,0L,4L,5L,8L,9L,9L,7L,2L,8L,6L,6L,5L,6L,4L,0L,6L,2L,9L,9L,4L,2L,2L,6L,8L,6L,2L,2L,9L,9L,1L,9L,8L,1L,3L,5L,2L,5L,9L,8L,6L,1L,8L,6L,2L,3L,3L,7L,8L,9L,6L,2L,3L,6L,9L,0L,3L,0L,3L,8L,1L,7L,4L,8L,0L,7L,1L,9L,1L,4L,7L,2L,7L,2L,1L,2L,8L,7L,4L,9L,5L,6L,3L,5L,0L,8L,6L,2L,0L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019853Inst : IEnumerable<long>
{
public static readonly long[] Value=A019853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019853.Bytes);
public long this[int i]=>Value[i];

public static A019853Inst Instance=new A019853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019870
{
public static readonly long[] Value={ 8L,7L,4L,6L,1L,9L,7L,0L,7L,1L,3L,9L,3L,9L,5L,8L,0L,0L,2L,8L,4L,6L,3L,6L,9L,5L,8L,6L,6L,1L,0L,7L,9L,5L,0L,6L,8L,5L,6L,3L,0L,6L,3L,8L,5L,1L,1L,3L,2L,1L,0L,2L,7L,8L,4L,2L,7L,6L,1L,8L,0L,7L,3L,3L,9L,2L,0L,7L,6L,4L,0L,7L,4L,0L,1L,6L,1L,0L,0L,1L,0L,5L,9L,1L,6L,6L,1L,0L,3L,7L,7L,8L,8L,3L,6L,3L,8L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019870Inst : IEnumerable<long>
{
public static readonly long[] Value=A019870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019870.Bytes);
public long this[int i]=>Value[i];

public static A019870Inst Instance=new A019870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019871
{
public static readonly long[] Value={ 8L,8L,2L,9L,4L,7L,5L,9L,2L,8L,5L,8L,9L,2L,6L,9L,4L,2L,0L,3L,2L,1L,7L,1L,3L,6L,0L,3L,1L,5L,7L,1L,9L,3L,8L,6L,0L,8L,3L,5L,3L,6L,6L,3L,1L,9L,9L,9L,5L,4L,2L,2L,3L,0L,4L,7L,6L,8L,6L,7L,7L,2L,8L,0L,7L,0L,3L,9L,7L,2L,8L,2L,8L,1L,0L,2L,4L,6L,2L,4L,8L,2L,9L,9L,1L,7L,1L,6L,8L,0L,5L,0L,3L,7L,5L,6L,2L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019871Inst : IEnumerable<long>
{
public static readonly long[] Value=A019871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019871.Bytes);
public long this[int i]=>Value[i];

public static A019871Inst Instance=new A019871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019872
{
public static readonly long[] Value={ 8L,9L,1L,0L,0L,6L,5L,2L,4L,1L,8L,8L,3L,6L,7L,8L,6L,2L,3L,5L,9L,7L,0L,9L,5L,7L,1L,4L,1L,3L,6L,2L,6L,3L,1L,2L,7L,7L,0L,5L,1L,8L,5L,1L,9L,0L,3L,6L,0L,8L,8L,7L,4L,5L,4L,0L,5L,5L,2L,2L,2L,8L,4L,5L,2L,2L,4L,9L,2L,2L,7L,4L,1L,7L,6L,1L,3L,5L,2L,2L,4L,3L,7L,7L,9L,3L,8L,5L,8L,2L,7L,3L,4L,8L,6L,1L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019872Inst : IEnumerable<long>
{
public static readonly long[] Value=A019872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019872.Bytes);
public long this[int i]=>Value[i];

public static A019872Inst Instance=new A019872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019873
{
public static readonly long[] Value={ 8L,9L,8L,7L,9L,4L,0L,4L,6L,2L,9L,9L,1L,6L,6L,9L,9L,2L,7L,8L,2L,2L,9L,5L,6L,7L,6L,6L,9L,5L,7L,8L,5L,3L,5L,4L,9L,2L,9L,9L,7L,3L,4L,1L,3L,8L,1L,8L,4L,2L,1L,8L,6L,9L,9L,3L,8L,1L,9L,6L,9L,6L,4L,4L,6L,1L,0L,4L,3L,0L,2L,7L,0L,9L,8L,9L,1L,4L,8L,9L,9L,9L,9L,1L,4L,8L,1L,5L,1L,3L,3L,9L,2L,2L,2L,3L,9L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019873Inst : IEnumerable<long>
{
public static readonly long[] Value=A019873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019873.Bytes);
public long this[int i]=>Value[i];

public static A019873Inst Instance=new A019873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019874
{
public static readonly long[] Value={ 9L,0L,6L,3L,0L,7L,7L,8L,7L,0L,3L,6L,6L,4L,9L,9L,6L,3L,2L,4L,2L,5L,5L,2L,6L,5L,6L,7L,5L,4L,3L,1L,6L,9L,8L,3L,2L,6L,7L,7L,1L,2L,6L,2L,5L,1L,7L,5L,8L,6L,4L,6L,8L,0L,8L,7L,1L,2L,9L,8L,4L,0L,8L,8L,2L,2L,6L,1L,8L,3L,8L,5L,9L,3L,6L,3L,6L,9L,4L,1L,1L,2L,9L,0L,3L,6L,3L,7L,0L,1L,0L,8L,5L,4L,5L,7L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019874Inst : IEnumerable<long>
{
public static readonly long[] Value=A019874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019874.Bytes);
public long this[int i]=>Value[i];

public static A019874Inst Instance=new A019874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019875
{
public static readonly long[] Value={ 9L,1L,3L,5L,4L,5L,4L,5L,7L,6L,4L,2L,6L,0L,0L,8L,9L,5L,5L,0L,2L,1L,2L,7L,5L,7L,1L,9L,8L,5L,3L,1L,7L,1L,7L,7L,9L,4L,0L,8L,1L,0L,4L,5L,9L,3L,7L,7L,4L,7L,4L,5L,4L,5L,0L,6L,0L,9L,9L,9L,7L,8L,8L,0L,6L,5L,1L,1L,4L,8L,8L,2L,1L,0L,2L,6L,3L,1L,2L,7L,1L,6L,8L,1L,7L,8L,4L,0L,0L,0L,8L,9L,3L,2L,9L,9L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019875Inst : IEnumerable<long>
{
public static readonly long[] Value=A019875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019875.Bytes);
public long this[int i]=>Value[i];

public static A019875Inst Instance=new A019875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019876
{
public static readonly long[] Value={ 9L,2L,0L,5L,0L,4L,8L,5L,3L,4L,5L,2L,4L,4L,0L,3L,2L,7L,3L,9L,6L,8L,9L,4L,7L,2L,3L,3L,0L,0L,4L,6L,1L,4L,2L,0L,2L,7L,9L,5L,0L,3L,2L,8L,0L,9L,7L,0L,2L,4L,0L,3L,0L,1L,2L,6L,2L,7L,0L,1L,7L,1L,1L,7L,8L,2L,9L,5L,3L,7L,9L,0L,0L,8L,7L,3L,1L,0L,3L,6L,5L,7L,5L,4L,5L,7L,3L,9L,7L,7L,6L,6L,2L,2L,6L,6L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019876Inst : IEnumerable<long>
{
public static readonly long[] Value=A019876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019876.Bytes);
public long this[int i]=>Value[i];

public static A019876Inst Instance=new A019876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019877
{
public static readonly long[] Value={ 9L,2L,7L,1L,8L,3L,8L,5L,4L,5L,6L,6L,7L,8L,7L,4L,0L,0L,8L,0L,6L,4L,7L,4L,4L,5L,1L,1L,3L,6L,9L,5L,6L,9L,4L,2L,0L,9L,7L,6L,2L,1L,7L,1L,9L,8L,4L,8L,9L,9L,7L,6L,1L,5L,1L,4L,3L,0L,2L,0L,9L,1L,2L,4L,0L,9L,5L,6L,2L,8L,5L,3L,4L,0L,6L,6L,3L,4L,7L,4L,2L,4L,1L,2L,8L,4L,9L,3L,5L,8L,0L,3L,9L,3L,2L,6L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019877Inst : IEnumerable<long>
{
public static readonly long[] Value=A019877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019877.Bytes);
public long this[int i]=>Value[i];

public static A019877Inst Instance=new A019877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019878
{
public static readonly long[] Value={ 9L,3L,3L,5L,8L,0L,4L,2L,6L,4L,9L,7L,2L,0L,1L,7L,4L,8L,9L,9L,0L,0L,4L,3L,0L,6L,3L,1L,3L,9L,5L,7L,0L,7L,4L,1L,4L,0L,5L,9L,6L,5L,2L,6L,8L,5L,3L,7L,4L,6L,6L,8L,0L,6L,8L,8L,1L,6L,4L,9L,6L,8L,1L,1L,3L,9L,1L,4L,9L,4L,9L,8L,2L,3L,6L,0L,2L,2L,3L,1L,6L,3L,6L,8L,2L,3L,7L,9L,8L,3L,0L,7L,4L,3L,8L,6L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019878Inst : IEnumerable<long>
{
public static readonly long[] Value=A019878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019878.Bytes);
public long this[int i]=>Value[i];

public static A019878Inst Instance=new A019878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019879
{
public static readonly long[] Value={ 9L,3L,9L,6L,9L,2L,6L,2L,0L,7L,8L,5L,9L,0L,8L,3L,8L,4L,0L,5L,4L,1L,0L,9L,2L,7L,7L,3L,2L,4L,7L,3L,1L,4L,6L,9L,9L,3L,6L,2L,0L,8L,1L,3L,4L,2L,6L,4L,4L,6L,4L,6L,3L,3L,0L,9L,0L,2L,8L,6L,6L,6L,2L,7L,7L,4L,2L,2L,1L,2L,1L,0L,9L,9L,5L,8L,8L,9L,4L,5L,8L,9L,4L,9L,7L,4L,5L,8L,8L,9L,8L,3L,7L,9L,4L,8L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019879Inst : IEnumerable<long>
{
public static readonly long[] Value=A019879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019879.Bytes);
public long this[int i]=>Value[i];

public static A019879Inst Instance=new A019879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019880
{
public static readonly long[] Value={ 9L,4L,5L,5L,1L,8L,5L,7L,5L,5L,9L,9L,3L,1L,6L,8L,1L,0L,3L,4L,8L,1L,2L,4L,7L,0L,7L,5L,1L,9L,4L,0L,3L,1L,7L,7L,6L,7L,6L,4L,5L,8L,7L,2L,5L,9L,1L,8L,9L,5L,2L,7L,0L,3L,0L,1L,0L,1L,4L,0L,8L,2L,0L,9L,6L,7L,5L,9L,6L,8L,0L,0L,9L,3L,0L,7L,7L,2L,8L,6L,3L,2L,6L,1L,9L,3L,0L,3L,0L,7L,7L,8L,6L,0L,9L,1L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019880Inst : IEnumerable<long>
{
public static readonly long[] Value=A019880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019880.Bytes);
public long this[int i]=>Value[i];

public static A019880Inst Instance=new A019880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019881
{
public static readonly long[] Value={ 9L,5L,1L,0L,5L,6L,5L,1L,6L,2L,9L,5L,1L,5L,3L,5L,7L,2L,1L,1L,6L,4L,3L,9L,3L,3L,3L,3L,7L,9L,3L,8L,2L,1L,4L,3L,4L,0L,5L,6L,9L,8L,6L,3L,4L,1L,2L,5L,7L,5L,0L,2L,2L,2L,4L,4L,7L,3L,0L,5L,6L,4L,4L,4L,3L,0L,1L,5L,3L,1L,7L,0L,0L,8L,5L,1L,9L,3L,5L,0L,1L,7L,1L,8L,7L,9L,2L,8L,1L,0L,9L,7L,0L,8L,1L,1L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019881Inst : IEnumerable<long>
{
public static readonly long[] Value=A019881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019881.Bytes);
public long this[int i]=>Value[i];

public static A019881Inst Instance=new A019881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019882
{
public static readonly long[] Value={ 9L,5L,6L,3L,0L,4L,7L,5L,5L,9L,6L,3L,0L,3L,5L,4L,8L,1L,3L,3L,8L,6L,5L,0L,8L,1L,6L,6L,1L,8L,4L,1L,8L,9L,6L,2L,0L,0L,9L,4L,1L,0L,3L,4L,3L,9L,9L,1L,2L,2L,2L,8L,6L,5L,7L,3L,3L,9L,4L,8L,3L,0L,1L,7L,0L,3L,0L,8L,5L,3L,0L,6L,4L,8L,9L,4L,0L,2L,8L,2L,2L,9L,0L,2L,6L,7L,0L,9L,8L,7L,3L,2L,1L,2L,0L,5L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019882Inst : IEnumerable<long>
{
public static readonly long[] Value=A019882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019882.Bytes);
public long this[int i]=>Value[i];

public static A019882Inst Instance=new A019882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019883
{
public static readonly long[] Value={ 9L,6L,1L,2L,6L,1L,6L,9L,5L,9L,3L,8L,3L,1L,8L,8L,6L,1L,9L,1L,6L,4L,9L,7L,0L,4L,8L,5L,5L,7L,0L,6L,4L,8L,7L,3L,5L,2L,5L,6L,9L,2L,4L,8L,9L,3L,4L,0L,7L,0L,8L,6L,6L,5L,8L,5L,6L,6L,8L,5L,3L,0L,0L,1L,5L,4L,3L,7L,1L,5L,1L,5L,7L,4L,7L,6L,7L,6L,5L,3L,0L,3L,5L,2L,3L,9L,6L,8L,1L,3L,6L,0L,5L,3L,5L,7L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019883Inst : IEnumerable<long>
{
public static readonly long[] Value=A019883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019883.Bytes);
public long this[int i]=>Value[i];

public static A019883Inst Instance=new A019883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019884
{
public static readonly long[] Value={ 9L,6L,5L,9L,2L,5L,8L,2L,6L,2L,8L,9L,0L,6L,8L,2L,8L,6L,7L,4L,9L,7L,4L,3L,1L,9L,9L,7L,2L,8L,8L,9L,7L,3L,6L,7L,6L,3L,3L,9L,0L,4L,8L,3L,9L,0L,0L,8L,4L,0L,4L,5L,5L,0L,4L,0L,2L,3L,4L,3L,0L,7L,6L,3L,1L,0L,4L,2L,3L,2L,1L,3L,9L,7L,9L,8L,5L,5L,5L,1L,6L,3L,4L,7L,5L,6L,1L,7L,4L,1L,8L,5L,8L,0L,7L,0L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019884Inst : IEnumerable<long>
{
public static readonly long[] Value=A019884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019884.Bytes);
public long this[int i]=>Value[i];

public static A019884Inst Instance=new A019884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019885
{
public static readonly long[] Value={ 9L,7L,0L,2L,9L,5L,7L,2L,6L,2L,7L,5L,9L,9L,6L,4L,7L,2L,3L,0L,6L,3L,7L,7L,8L,7L,4L,0L,3L,3L,9L,9L,0L,3L,7L,7L,6L,3L,2L,2L,6L,0L,8L,5L,2L,4L,4L,3L,0L,8L,2L,9L,1L,5L,6L,5L,6L,5L,8L,8L,7L,6L,2L,3L,2L,3L,5L,5L,5L,7L,3L,5L,8L,3L,6L,6L,3L,0L,9L,2L,9L,6L,5L,5L,4L,4L,2L,9L,2L,2L,4L,4L,5L,3L,1L,9L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019885Inst : IEnumerable<long>
{
public static readonly long[] Value=A019885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019885.Bytes);
public long this[int i]=>Value[i];

public static A019885Inst Instance=new A019885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019886
{
public static readonly long[] Value={ 9L,7L,4L,3L,7L,0L,0L,6L,4L,7L,8L,5L,2L,3L,5L,2L,2L,8L,5L,3L,9L,6L,9L,4L,4L,8L,0L,0L,8L,8L,2L,6L,8L,8L,3L,3L,0L,0L,5L,1L,2L,0L,9L,8L,8L,9L,4L,4L,5L,6L,7L,9L,4L,4L,5L,9L,7L,9L,7L,2L,2L,2L,2L,6L,6L,8L,5L,8L,6L,9L,9L,0L,0L,3L,2L,4L,3L,0L,4L,2L,7L,0L,2L,0L,5L,8L,7L,3L,4L,5L,1L,9L,4L,8L,9L,7L,6L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019886Inst : IEnumerable<long>
{
public static readonly long[] Value=A019886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019886.Bytes);
public long this[int i]=>Value[i];

public static A019886Inst Instance=new A019886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019887
{
public static readonly long[] Value={ 9L,7L,8L,1L,4L,7L,6L,0L,0L,7L,3L,3L,8L,0L,5L,6L,3L,7L,9L,2L,8L,5L,6L,6L,7L,4L,7L,8L,6L,9L,5L,9L,9L,5L,3L,2L,4L,5L,9L,7L,3L,7L,8L,0L,8L,8L,6L,2L,6L,7L,7L,1L,0L,7L,8L,8L,5L,1L,7L,7L,6L,6L,3L,6L,4L,0L,5L,9L,6L,8L,3L,3L,1L,2L,0L,0L,9L,5L,1L,2L,1L,9L,9L,9L,7L,5L,8L,5L,2L,5L,4L,5L,4L,7L,8L,5L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019887Inst : IEnumerable<long>
{
public static readonly long[] Value=A019887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019887.Bytes);
public long this[int i]=>Value[i];

public static A019887Inst Instance=new A019887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019888
{
public static readonly long[] Value={ 9L,8L,1L,6L,2L,7L,1L,8L,3L,4L,4L,7L,6L,6L,3L,9L,5L,3L,4L,9L,6L,5L,0L,4L,8L,9L,9L,8L,1L,8L,1L,4L,0L,8L,1L,9L,3L,1L,8L,2L,5L,3L,3L,0L,4L,6L,2L,9L,4L,7L,2L,8L,9L,7L,0L,2L,5L,4L,5L,6L,9L,4L,9L,6L,0L,1L,1L,6L,9L,1L,4L,4L,3L,2L,6L,1L,0L,9L,8L,0L,3L,1L,1L,1L,9L,6L,4L,0L,2L,3L,1L,0L,7L,3L,9L,8L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019888Inst : IEnumerable<long>
{
public static readonly long[] Value=A019888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019888.Bytes);
public long this[int i]=>Value[i];

public static A019888Inst Instance=new A019888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019889
{
public static readonly long[] Value={ 9L,8L,4L,8L,0L,7L,7L,5L,3L,0L,1L,2L,2L,0L,8L,0L,5L,9L,3L,6L,6L,7L,4L,3L,0L,2L,4L,5L,8L,9L,5L,2L,3L,0L,1L,3L,6L,7L,0L,6L,4L,3L,2L,5L,1L,7L,1L,9L,8L,4L,2L,4L,1L,8L,7L,9L,0L,0L,2L,5L,7L,5L,2L,3L,5L,5L,8L,2L,7L,5L,9L,9L,9L,4L,3L,0L,3L,6L,2L,3L,9L,2L,7L,4L,6L,7L,8L,4L,1L,0L,0L,5L,6L,1L,1L,9L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019889Inst : IEnumerable<long>
{
public static readonly long[] Value=A019889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019889.Bytes);
public long this[int i]=>Value[i];

public static A019889Inst Instance=new A019889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019890
{
public static readonly long[] Value={ 9L,8L,7L,6L,8L,8L,3L,4L,0L,5L,9L,5L,1L,3L,7L,7L,2L,6L,1L,9L,0L,0L,4L,0L,2L,4L,7L,6L,9L,3L,4L,3L,7L,2L,6L,0L,7L,5L,8L,4L,0L,6L,8L,6L,1L,5L,8L,9L,8L,8L,0L,4L,3L,4L,9L,2L,3L,9L,0L,4L,8L,0L,1L,6L,3L,8L,0L,7L,2L,9L,3L,5L,9L,6L,9L,7L,1L,2L,7L,3L,5L,7L,1L,1L,9L,6L,3L,0L,3L,7L,9L,9L,9L,8L,8L,6L,7L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019890Inst : IEnumerable<long>
{
public static readonly long[] Value=A019890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019890.Bytes);
public long this[int i]=>Value[i];

public static A019890Inst Instance=new A019890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019891
{
public static readonly long[] Value={ 9L,9L,0L,2L,6L,8L,0L,6L,8L,7L,4L,1L,5L,7L,0L,3L,1L,5L,0L,8L,3L,7L,7L,4L,8L,6L,7L,3L,4L,4L,8L,5L,0L,7L,5L,9L,2L,5L,1L,0L,8L,9L,7L,9L,3L,7L,6L,8L,8L,8L,6L,5L,0L,0L,0L,8L,9L,7L,1L,4L,1L,2L,7L,6L,0L,0L,9L,9L,5L,8L,1L,7L,7L,2L,9L,3L,3L,6L,4L,5L,4L,9L,8L,9L,9L,1L,8L,6L,1L,6L,7L,5L,9L,6L,4L,9L,3L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019891Inst : IEnumerable<long>
{
public static readonly long[] Value=A019891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019891.Bytes);
public long this[int i]=>Value[i];

public static A019891Inst Instance=new A019891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019892
{
public static readonly long[] Value={ 9L,9L,2L,5L,4L,6L,1L,5L,1L,6L,4L,1L,3L,2L,2L,0L,3L,4L,9L,8L,0L,0L,6L,1L,5L,8L,9L,3L,3L,0L,5L,8L,4L,1L,0L,9L,0L,4L,3L,6L,5L,2L,8L,7L,7L,4L,0L,6L,8L,2L,8L,2L,3L,2L,2L,3L,5L,5L,5L,3L,5L,7L,6L,0L,1L,0L,0L,9L,7L,4L,7L,1L,6L,8L,7L,0L,1L,2L,1L,9L,2L,9L,5L,9L,0L,9L,2L,8L,4L,8L,3L,5L,0L,4L,0L,9L,5L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019892Inst : IEnumerable<long>
{
public static readonly long[] Value=A019892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019892.Bytes);
public long this[int i]=>Value[i];

public static A019892Inst Instance=new A019892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019893
{
public static readonly long[] Value={ 9L,9L,4L,5L,2L,1L,8L,9L,5L,3L,6L,8L,2L,7L,3L,3L,3L,6L,9L,2L,2L,6L,9L,1L,9L,4L,4L,9L,8L,0L,5L,7L,0L,3L,8L,1L,5L,2L,0L,7L,9L,2L,0L,8L,8L,7L,0L,9L,3L,1L,9L,4L,2L,7L,3L,6L,6L,5L,5L,8L,8L,3L,3L,5L,7L,4L,3L,1L,6L,2L,5L,0L,6L,8L,6L,8L,9L,8L,3L,6L,2L,5L,7L,9L,3L,0L,6L,2L,2L,0L,3L,8L,3L,3L,6L,0L,9L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019893Inst : IEnumerable<long>
{
public static readonly long[] Value=A019893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019893.Bytes);
public long this[int i]=>Value[i];

public static A019893Inst Instance=new A019893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019894
{
public static readonly long[] Value={ 9L,9L,6L,1L,9L,4L,6L,9L,8L,0L,9L,1L,7L,4L,5L,5L,3L,2L,2L,9L,5L,0L,1L,0L,4L,0L,2L,4L,7L,3L,8L,8L,8L,0L,4L,6L,1L,8L,3L,5L,6L,2L,6L,7L,2L,6L,4L,5L,8L,5L,0L,9L,7L,4L,5L,2L,5L,4L,4L,2L,2L,7L,7L,3L,8L,0L,1L,1L,6L,7L,4L,9L,8L,3L,8L,2L,5L,1L,5L,9L,9L,6L,7L,4L,1L,8L,6L,3L,8L,6L,2L,5L,9L,6L,5L,1L,9L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019894Inst : IEnumerable<long>
{
public static readonly long[] Value=A019894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019894.Bytes);
public long this[int i]=>Value[i];

public static A019894Inst Instance=new A019894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019895
{
public static readonly long[] Value={ 9L,9L,7L,5L,6L,4L,0L,5L,0L,2L,5L,9L,8L,2L,4L,2L,4L,7L,6L,1L,3L,1L,6L,2L,6L,8L,0L,6L,4L,4L,2L,5L,5L,0L,2L,6L,3L,6L,9L,3L,7L,7L,6L,6L,0L,3L,8L,4L,2L,2L,1L,5L,3L,6L,2L,2L,5L,9L,9L,5L,6L,0L,8L,8L,9L,8L,2L,1L,9L,1L,8L,1L,4L,1L,1L,0L,8L,1L,8L,4L,3L,0L,8L,5L,2L,8L,9L,2L,1L,1L,6L,7L,5L,4L,7L,6L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019895Inst : IEnumerable<long>
{
public static readonly long[] Value=A019895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019895.Bytes);
public long this[int i]=>Value[i];

public static A019895Inst Instance=new A019895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019896
{
public static readonly long[] Value={ 9L,9L,8L,6L,2L,9L,5L,3L,4L,7L,5L,4L,5L,7L,3L,8L,7L,3L,7L,8L,4L,4L,9L,2L,0L,5L,8L,4L,3L,9L,4L,3L,6L,5L,8L,0L,5L,9L,0L,9L,5L,2L,2L,9L,0L,7L,6L,7L,7L,8L,5L,5L,3L,2L,4L,4L,1L,4L,4L,1L,2L,5L,4L,8L,3L,1L,6L,4L,8L,9L,7L,3L,7L,3L,3L,4L,7L,8L,3L,1L,8L,6L,3L,5L,3L,3L,2L,0L,2L,8L,2L,3L,3L,2L,7L,5L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019896Inst : IEnumerable<long>
{
public static readonly long[] Value=A019896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019896.Bytes);
public long this[int i]=>Value[i];

public static A019896Inst Instance=new A019896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019897
{
public static readonly long[] Value={ 9L,9L,9L,3L,9L,0L,8L,2L,7L,0L,1L,9L,0L,9L,5L,7L,3L,0L,0L,0L,6L,2L,4L,3L,4L,4L,0L,0L,4L,3L,9L,2L,9L,9L,6L,4L,4L,9L,5L,2L,3L,6L,3L,0L,6L,6L,6L,9L,9L,9L,6L,7L,7L,3L,1L,0L,3L,9L,0L,0L,4L,0L,8L,0L,1L,0L,9L,4L,8L,6L,1L,8L,9L,1L,8L,3L,3L,2L,6L,5L,2L,5L,4L,9L,5L,0L,4L,5L,3L,4L,4L,6L,4L,2L,2L,3L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019897Inst : IEnumerable<long>
{
public static readonly long[] Value=A019897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019897.Bytes);
public long this[int i]=>Value[i];

public static A019897Inst Instance=new A019897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019898
{
public static readonly long[] Value={ 9L,9L,9L,8L,4L,7L,6L,9L,5L,1L,5L,6L,3L,9L,1L,2L,3L,9L,1L,5L,7L,0L,1L,1L,5L,5L,8L,8L,1L,3L,9L,1L,4L,8L,5L,1L,6L,9L,2L,7L,4L,0L,3L,1L,0L,5L,8L,3L,1L,8L,5L,9L,3L,9L,6L,5L,8L,3L,2L,0L,7L,1L,4L,5L,1L,1L,5L,3L,9L,1L,8L,1L,1L,0L,3L,3L,3L,7L,2L,1L,5L,3L,9L,7L,2L,9L,9L,3L,9L,5L,2L,8L,8L,1L,1L,0L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019898Inst : IEnumerable<long>
{
public static readonly long[] Value=A019898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019898.Bytes);
public long this[int i]=>Value[i];

public static A019898Inst Instance=new A019898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019899
{
public static readonly long[] Value={ 0L,1L,7L,4L,5L,5L,0L,6L,4L,9L,2L,8L,2L,1L,7L,5L,8L,5L,7L,6L,5L,1L,2L,8L,8L,9L,5L,2L,1L,9L,7L,2L,7L,8L,2L,4L,3L,1L,4L,1L,0L,1L,5L,8L,8L,8L,3L,9L,8L,7L,5L,2L,7L,6L,9L,0L,4L,7L,1L,1L,4L,2L,7L,1L,0L,2L,1L,0L,4L,8L,5L,4L,8L,5L,6L,4L,6L,2L,3L,6L,7L,6L,2L,2L,8L,8L,9L,6L,8L,9L,1L,5L,8L,2L,9L,9L,2L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019899Inst : IEnumerable<long>
{
public static readonly long[] Value=A019899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019899.Bytes);
public long this[int i]=>Value[i];

public static A019899Inst Instance=new A019899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019900
{
public static readonly long[] Value={ 0L,3L,4L,9L,2L,0L,7L,6L,9L,4L,9L,1L,7L,4L,7L,7L,3L,0L,5L,0L,0L,4L,0L,2L,6L,2L,5L,7L,7L,3L,7L,2L,5L,3L,1L,5L,8L,7L,9L,1L,7L,4L,2L,9L,7L,7L,8L,4L,6L,1L,5L,2L,5L,0L,5L,0L,4L,9L,7L,0L,0L,8L,3L,1L,9L,0L,3L,5L,2L,5L,3L,4L,1L,8L,7L,0L,5L,8L,9L,9L,8L,7L,1L,5L,5L,1L,4L,5L,1L,9L,6L,9L,5L,0L,5L,9L,7L,3L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019900Inst : IEnumerable<long>
{
public static readonly long[] Value=A019900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019900.Bytes);
public long this[int i]=>Value[i];

public static A019900Inst Instance=new A019900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019901
{
public static readonly long[] Value={ 0L,5L,2L,4L,0L,7L,7L,7L,9L,2L,8L,3L,0L,4L,1L,2L,0L,4L,0L,3L,8L,8L,0L,5L,8L,2L,4L,4L,7L,3L,9L,8L,4L,3L,7L,4L,9L,5L,3L,4L,2L,4L,9L,2L,7L,8L,0L,9L,9L,4L,7L,3L,8L,4L,4L,7L,3L,4L,4L,4L,9L,1L,5L,3L,5L,3L,0L,3L,6L,1L,6L,0L,8L,9L,3L,7L,3L,8L,0L,8L,0L,4L,5L,2L,6L,2L,7L,7L,9L,3L,2L,1L,8L,4L,0L,4L,7L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019901Inst : IEnumerable<long>
{
public static readonly long[] Value=A019901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019901.Bytes);
public long this[int i]=>Value[i];

public static A019901Inst Instance=new A019901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019918
{
public static readonly long[] Value={ 3L,6L,3L,9L,7L,0L,2L,3L,4L,2L,6L,6L,2L,0L,2L,3L,6L,1L,3L,5L,1L,0L,4L,7L,8L,8L,2L,7L,7L,6L,8L,3L,4L,0L,4L,3L,8L,9L,0L,4L,7L,1L,7L,8L,3L,7L,5L,3L,7L,3L,8L,1L,1L,4L,1L,9L,5L,6L,1L,2L,9L,8L,8L,7L,1L,3L,0L,7L,3L,9L,6L,2L,1L,0L,0L,4L,8L,9L,6L,3L,8L,8L,2L,4L,3L,8L,5L,4L,5L,7L,4L,0L,3L,1L,4L,6L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019918Inst : IEnumerable<long>
{
public static readonly long[] Value=A019918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019918.Bytes);
public long this[int i]=>Value[i];

public static A019918Inst Instance=new A019918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019919
{
public static readonly long[] Value={ 3L,8L,3L,8L,6L,4L,0L,3L,5L,0L,3L,5L,4L,1L,5L,7L,9L,5L,9L,7L,1L,4L,4L,8L,4L,0L,8L,1L,0L,3L,2L,7L,0L,1L,2L,0L,9L,3L,9L,3L,6L,8L,2L,4L,7L,1L,6L,1L,4L,7L,6L,9L,2L,7L,3L,8L,3L,2L,0L,6L,5L,2L,7L,4L,2L,2L,4L,8L,3L,1L,9L,3L,8L,3L,3L,9L,2L,8L,9L,3L,5L,2L,2L,7L,8L,0L,6L,3L,3L,7L,4L,0L,8L,8L,4L,6L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019919Inst : IEnumerable<long>
{
public static readonly long[] Value=A019919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019919.Bytes);
public long this[int i]=>Value[i];

public static A019919Inst Instance=new A019919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019920
{
public static readonly long[] Value={ 4L,0L,4L,0L,2L,6L,2L,2L,5L,8L,3L,5L,1L,5L,6L,8L,1L,1L,3L,2L,2L,3L,4L,8L,1L,4L,3L,5L,7L,9L,9L,1L,0L,2L,7L,1L,4L,7L,2L,3L,7L,9L,8L,2L,0L,0L,7L,4L,7L,8L,6L,6L,2L,8L,5L,7L,1L,5L,3L,7L,1L,4L,7L,8L,8L,9L,3L,8L,4L,6L,3L,3L,3L,9L,8L,4L,1L,0L,0L,4L,2L,7L,7L,0L,1L,1L,9L,7L,9L,6L,9L,8L,5L,9L,0L,3L,1L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019920Inst : IEnumerable<long>
{
public static readonly long[] Value=A019920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019920.Bytes);
public long this[int i]=>Value[i];

public static A019920Inst Instance=new A019920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019921
{
public static readonly long[] Value={ 4L,2L,4L,4L,7L,4L,8L,1L,6L,2L,0L,9L,6L,0L,4L,7L,4L,2L,0L,2L,3L,5L,3L,2L,0L,6L,2L,9L,4L,2L,5L,2L,0L,4L,0L,1L,0L,1L,8L,6L,5L,8L,6L,9L,8L,2L,4L,5L,0L,6L,0L,1L,1L,4L,0L,1L,0L,6L,7L,6L,2L,8L,2L,4L,5L,2L,7L,9L,8L,5L,3L,6L,6L,4L,5L,8L,1L,7L,7L,5L,8L,0L,6L,9L,0L,6L,9L,8L,5L,0L,3L,3L,4L,9L,5L,4L,0L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019921Inst : IEnumerable<long>
{
public static readonly long[] Value=A019921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019921.Bytes);
public long this[int i]=>Value[i];

public static A019921Inst Instance=new A019921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019922
{
public static readonly long[] Value={ 4L,4L,5L,2L,2L,8L,6L,8L,5L,3L,0L,8L,5L,3L,6L,1L,6L,3L,9L,2L,2L,3L,6L,7L,0L,3L,0L,6L,4L,5L,6L,6L,5L,7L,5L,4L,9L,8L,7L,4L,3L,0L,6L,7L,8L,4L,2L,7L,9L,2L,6L,5L,1L,6L,5L,5L,6L,2L,7L,0L,1L,8L,7L,0L,0L,0L,5L,2L,8L,5L,5L,7L,3L,3L,3L,7L,8L,8L,3L,4L,9L,5L,1L,0L,8L,1L,6L,3L,7L,5L,0L,4L,3L,5L,1L,8L,5L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019922Inst : IEnumerable<long>
{
public static readonly long[] Value=A019922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019922.Bytes);
public long this[int i]=>Value[i];

public static A019922Inst Instance=new A019922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019923
{
public static readonly long[] Value={ 4L,6L,6L,3L,0L,7L,6L,5L,8L,1L,5L,4L,9L,9L,8L,5L,9L,2L,8L,3L,0L,0L,0L,6L,1L,9L,4L,7L,9L,9L,5L,5L,9L,4L,5L,1L,3L,1L,1L,0L,6L,3L,0L,0L,8L,2L,5L,1L,3L,7L,5L,9L,1L,7L,8L,1L,0L,9L,3L,2L,4L,4L,8L,2L,3L,9L,2L,1L,8L,3L,8L,3L,3L,8L,8L,9L,0L,6L,5L,3L,6L,5L,5L,3L,1L,2L,6L,8L,2L,3L,2L,5L,7L,2L,7L,2L,8L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019923Inst : IEnumerable<long>
{
public static readonly long[] Value=A019923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019923.Bytes);
public long this[int i]=>Value[i];

public static A019923Inst Instance=new A019923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019924
{
public static readonly long[] Value={ 4L,8L,7L,7L,3L,2L,5L,8L,8L,5L,6L,5L,8L,6L,1L,4L,2L,2L,7L,7L,3L,1L,1L,1L,1L,2L,6L,6L,1L,6L,9L,6L,0L,4L,3L,3L,5L,9L,6L,6L,0L,0L,8L,2L,2L,0L,4L,0L,0L,2L,7L,0L,9L,0L,8L,2L,3L,9L,2L,1L,4L,2L,4L,6L,9L,5L,4L,5L,6L,0L,4L,0L,2L,8L,4L,8L,2L,1L,6L,3L,3L,8L,8L,3L,6L,2L,0L,4L,3L,5L,3L,8L,1L,2L,8L,7L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019924Inst : IEnumerable<long>
{
public static readonly long[] Value=A019924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019924.Bytes);
public long this[int i]=>Value[i];

public static A019924Inst Instance=new A019924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019925
{
public static readonly long[] Value={ 5L,0L,9L,5L,2L,5L,4L,4L,9L,4L,9L,4L,4L,2L,8L,8L,1L,0L,5L,1L,3L,7L,0L,6L,9L,1L,1L,2L,5L,0L,6L,5L,7L,4L,8L,5L,8L,2L,4L,5L,2L,5L,9L,6L,6L,6L,4L,6L,3L,1L,7L,2L,6L,1L,5L,2L,0L,8L,3L,0L,9L,1L,8L,0L,6L,4L,7L,7L,1L,5L,3L,3L,7L,9L,2L,1L,2L,1L,8L,1L,0L,9L,9L,3L,8L,3L,6L,8L,8L,6L,1L,6L,2L,6L,4L,2L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019925Inst : IEnumerable<long>
{
public static readonly long[] Value=A019925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019925.Bytes);
public long this[int i]=>Value[i];

public static A019925Inst Instance=new A019925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019926
{
public static readonly long[] Value={ 5L,3L,1L,7L,0L,9L,4L,3L,1L,6L,6L,1L,4L,7L,8L,7L,4L,8L,0L,7L,5L,9L,1L,5L,8L,7L,1L,8L,4L,0L,0L,5L,8L,9L,8L,0L,3L,0L,5L,4L,6L,4L,3L,1L,5L,1L,4L,2L,6L,5L,7L,0L,5L,0L,8L,5L,9L,2L,5L,5L,9L,6L,5L,0L,2L,8L,8L,0L,3L,7L,0L,6L,7L,7L,6L,5L,3L,1L,9L,9L,1L,4L,5L,2L,2L,9L,5L,9L,4L,9L,6L,2L,0L,4L,9L,1L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019926Inst : IEnumerable<long>
{
public static readonly long[] Value=A019926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019926.Bytes);
public long this[int i]=>Value[i];

public static A019926Inst Instance=new A019926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019927
{
public static readonly long[] Value={ 5L,5L,4L,3L,0L,9L,0L,5L,1L,4L,5L,2L,7L,6L,8L,9L,1L,7L,8L,2L,0L,7L,6L,3L,0L,9L,2L,3L,3L,8L,1L,3L,4L,4L,0L,7L,6L,9L,3L,9L,1L,6L,6L,5L,0L,0L,1L,3L,1L,1L,1L,8L,3L,5L,9L,2L,9L,3L,6L,3L,1L,0L,3L,9L,1L,5L,5L,7L,8L,0L,0L,4L,8L,0L,0L,4L,3L,5L,2L,2L,3L,2L,8L,2L,0L,5L,7L,5L,3L,5L,0L,5L,5L,6L,5L,0L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019927Inst : IEnumerable<long>
{
public static readonly long[] Value=A019927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019927.Bytes);
public long this[int i]=>Value[i];

public static A019927Inst Instance=new A019927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019928
{
public static readonly long[] Value={ 1L,20L,269L,3040L,31161L,300300L,2775109L,24887960L,218303921L,1882786180L,16026538749L,135010883280L,1127921219881L,9359429537660L,77233958267189L,634411837477000L,5191228487083041L,42342127346986740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019928Inst : IEnumerable<long>
{
public static readonly long[] Value=A019928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019928.Bytes);
public long this[int i]=>Value[i];

public static A019928Inst Instance=new A019928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019929
{
public static readonly long[] Value={ 6L,0L,0L,8L,6L,0L,6L,1L,9L,0L,2L,7L,5L,6L,0L,4L,1L,4L,8L,7L,8L,6L,6L,4L,4L,2L,6L,3L,5L,4L,6L,6L,4L,4L,6L,3L,1L,5L,8L,5L,5L,5L,2L,3L,0L,8L,2L,3L,2L,4L,0L,7L,9L,1L,2L,2L,2L,5L,4L,2L,6L,1L,5L,5L,6L,6L,8L,3L,4L,2L,5L,8L,6L,1L,5L,4L,0L,9L,0L,8L,3L,5L,2L,4L,5L,4L,8L,5L,0L,3L,0L,4L,0L,6L,9L,0L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019929Inst : IEnumerable<long>
{
public static readonly long[] Value=A019929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019929.Bytes);
public long this[int i]=>Value[i];

public static A019929Inst Instance=new A019929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019930
{
public static readonly long[] Value={ 6L,2L,4L,8L,6L,9L,3L,5L,1L,9L,0L,9L,3L,2L,7L,5L,0L,9L,7L,8L,0L,5L,1L,0L,8L,2L,7L,9L,4L,9L,4L,3L,6L,6L,5L,8L,3L,1L,0L,8L,7L,0L,2L,0L,2L,8L,4L,2L,7L,0L,4L,9L,6L,6L,7L,6L,3L,6L,5L,7L,3L,8L,0L,3L,3L,2L,9L,3L,3L,6L,4L,7L,5L,9L,6L,3L,9L,4L,8L,5L,8L,4L,4L,1L,0L,3L,8L,2L,7L,8L,8L,6L,1L,4L,6L,8L,7L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019930Inst : IEnumerable<long>
{
public static readonly long[] Value=A019930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019930.Bytes);
public long this[int i]=>Value[i];

public static A019930Inst Instance=new A019930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019931
{
public static readonly long[] Value={ 6L,4L,9L,4L,0L,7L,5L,9L,3L,1L,9L,7L,5L,1L,0L,5L,7L,6L,9L,8L,2L,0L,6L,2L,9L,1L,1L,3L,1L,1L,4L,4L,8L,6L,1L,5L,7L,3L,3L,5L,2L,5L,6L,7L,5L,3L,0L,9L,6L,2L,8L,6L,4L,6L,6L,8L,6L,6L,4L,5L,1L,2L,9L,0L,0L,1L,2L,7L,6L,4L,5L,2L,2L,8L,1L,5L,0L,7L,4L,2L,6L,3L,8L,6L,5L,2L,4L,9L,1L,3L,5L,9L,1L,2L,5L,9L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019931Inst : IEnumerable<long>
{
public static readonly long[] Value=A019931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019931.Bytes);
public long this[int i]=>Value[i];

public static A019931Inst Instance=new A019931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019932
{
public static readonly long[] Value={ 6L,7L,4L,5L,0L,8L,5L,1L,6L,8L,4L,2L,4L,2L,6L,6L,3L,2L,1L,4L,2L,4L,6L,0L,8L,6L,1L,9L,9L,4L,6L,0L,9L,4L,8L,7L,5L,3L,5L,0L,8L,6L,5L,9L,1L,3L,1L,6L,2L,7L,3L,7L,4L,7L,8L,4L,1L,6L,2L,9L,4L,4L,3L,0L,2L,8L,0L,1L,7L,6L,0L,9L,8L,1L,7L,1L,4L,5L,1L,9L,3L,2L,1L,7L,1L,4L,0L,5L,9L,7L,1L,6L,6L,4L,0L,1L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019932Inst : IEnumerable<long>
{
public static readonly long[] Value=A019932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019932.Bytes);
public long this[int i]=>Value[i];

public static A019932Inst Instance=new A019932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019933
{
public static readonly long[] Value={ 7L,0L,0L,2L,0L,7L,5L,3L,8L,2L,0L,9L,7L,0L,9L,7L,7L,9L,4L,5L,8L,5L,2L,2L,7L,1L,9L,4L,4L,4L,8L,3L,2L,6L,5L,1L,8L,5L,2L,8L,5L,8L,0L,4L,4L,5L,6L,7L,8L,4L,2L,8L,6L,9L,2L,2L,0L,5L,6L,8L,1L,4L,9L,8L,5L,5L,5L,4L,7L,5L,9L,3L,3L,2L,7L,0L,0L,9L,2L,5L,5L,2L,8L,8L,5L,3L,1L,6L,4L,9L,3L,1L,9L,0L,4L,7L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019933Inst : IEnumerable<long>
{
public static readonly long[] Value=A019933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019933.Bytes);
public long this[int i]=>Value[i];

public static A019933Inst Instance=new A019933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019998
{
public static readonly long[] Value={ 2L,4L,7L,14L,87L,110L,178L,1551L,2311L,2820L,2862L,5158L,9267L,15867L,25023L,34363L,68486L,2570490L,4313372L,21511363L,22412883L,54933234L,66947210L,341535842L,995434171L,1491645143L,4258696422L,26212684635L,28500533228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019998Inst : IEnumerable<long>
{
public static readonly long[] Value=A019998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019998.Bytes);
public long this[int i]=>Value[i];

public static A019998Inst Instance=new A019998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019999
{
public static readonly BigInteger[] Value={ 4L,36L,384L,4800L,69120L,1128960L,20643840L,418037760L,9289728000L,224811417600L,5885971660800L,165788201779200L,4999151930572800L,160687026339840000L,5484783832399872000L,BigInteger.Parse("198137815945445376000") };
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
public class A019999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019999Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A019999.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A019999.Bytes);
public BigInteger this[int i]=>Value[i];

public static A019999Inst Instance=new A019999Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020000
{
public static readonly long[] Value={ 1L,23L,362L,4870L,60411L,715533L,8243572L,93366380L,1046230421L,11644889443L,129058033182L,1426436938290L,15738640474831L,173461105001753L,1910430676985192L,21031277618176600L,231459987587209641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020000Inst : IEnumerable<long>
{
public static readonly long[] Value=A020000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020000.Bytes);
public long this[int i]=>Value[i];

public static A020000Inst Instance=new A020000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020001
{
public static readonly long[] Value={ 1L,1L,2L,5L,20L,99L,584L,4038L,31970L,285070L,2826941L,30860774L,367757553L,4750201727L,66106974037L,986095696055L,15695356495548L,265513114049684L,4757109960056837L,89988663411075165L,1792274212937247027L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020001Inst : IEnumerable<long>
{
public static readonly long[] Value=A020001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020001.Bytes);
public long this[int i]=>Value[i];

public static A020001Inst Instance=new A020001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020002
{
public static readonly long[] Value={ 1L,1L,1L,2L,9L,39L,219L,1440L,10923L,93755L,898484L,9508956L,110145409L,1385996396L,18826451052L,274552411176L,4278441740820L,70950825535270L,1247552015661833L,23183674957715736L,454013634588599834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020002Inst : IEnumerable<long>
{
public static readonly long[] Value=A020002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020002.Bytes);
public long this[int i]=>Value[i];

public static A020002Inst Instance=new A020002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020003
{
public static readonly long[] Value={ 1L,0L,1L,1L,5L,22L,117L,748L,5549L,46705L,439803L,4581280L,52302950L,649428294L,8713162940L,125614765716L,1936560971460L,31791875948135L,553708506096682L,10197464987280554L,198000778503030764L,4042515894436878102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020003Inst : IEnumerable<long>
{
public static readonly long[] Value=A020003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020003.Bytes);
public long this[int i]=>Value[i];

public static A020003Inst Instance=new A020003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020004
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,2L,12L,73L,519L,4193L,38084L,384010L,4256112L,51428023L,672849973L,9475970455L,142929221024L,2298778304796L,39270796040273L,710146895061598L,13551969914092152L,272168729108017393L,5738224038694033364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020004Inst : IEnumerable<long>
{
public static readonly long[] Value=A020004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020004.Bytes);
public long this[int i]=>Value[i];

public static A020004Inst Instance=new A020004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020005
{
public static readonly long[] Value={ 1L,1L,2L,5L,20L,97L,573L,3956L,31285L,278721L,2761871L,30129503L,358814994L,4631975383L,64426566695L,960541539816L,15281342678897L,258393612570435L,4627594697852333L,87503608832116847L,1742117303112144502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020005Inst : IEnumerable<long>
{
public static readonly long[] Value=A020005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020005.Bytes);
public long this[int i]=>Value[i];

public static A020005Inst Instance=new A020005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020006
{
public static readonly long[] Value={ 1L,1L,1L,4L,16L,77L,449L,3060L,23920L,210929L,2070941L,22403814L,264772349L,3393900115L,46897528867L,694936109571L,10992625733214L,184875978240420L,3294153794102035L,61989985034465559L,1228528794319408361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020006Inst : IEnumerable<long>
{
public static readonly long[] Value=A020006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020006.Bytes);
public long this[int i]=>Value[i];

public static A020006Inst Instance=new A020006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020007
{
public static readonly long[] Value={ 1L,1L,1L,3L,13L,60L,346L,2326L,17972L,156848L,1525708L,16366685L,191936577L,2442829156L,33533382055L,493855262996L,7766996408941L,129920667204110L,2303139100436492L,43131514062719763L,850867141055471684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020007Inst : IEnumerable<long>
{
public static readonly long[] Value=A020007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020007.Bytes);
public long this[int i]=>Value[i];

public static A020007Inst Instance=new A020007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020008
{
public static readonly long[] Value={ 1L,1L,1L,3L,10L,46L,261L,1731L,13221L,114178L,1100260L,11702761L,136177584L,1720789476L,23465311033L,343446825119L,5370259447317L,89341588987180L,1575660751228445L,29364586727439204L,576613703011533457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020008Inst : IEnumerable<long>
{
public static readonly long[] Value=A020008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020008.Bytes);
public long this[int i]=>Value[i];

public static A020008Inst Instance=new A020008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020009
{
public static readonly long[] Value={ 1L,1L,1L,2L,8L,35L,192L,1255L,9471L,80933L,772545L,8146834L,94058896L,1180011610L,15983793633L,232491543753L,3614186725612L,59798362187392L,1049189445651507L,19457695173900667L,380309496580785766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020009Inst : IEnumerable<long>
{
public static readonly long[] Value=A020009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020009.Bytes);
public long this[int i]=>Value[i];

public static A020009Inst Instance=new A020009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020010
{
public static readonly long[] Value={ 1L,0L,1L,2L,6L,25L,136L,879L,6554L,55412L,523897L,5477110L,62737807L,781370863L,10512989797L,151960488890L,2348480282846L,38643175563195L,674499064375772L,12447573642571061L,242161887228200640L,4953311329667740359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020010Inst : IEnumerable<long>
{
public static readonly long[] Value=A020010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020010.Bytes);
public long this[int i]=>Value[i];

public static A020010Inst Instance=new A020010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020011
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,17L,92L,587L,4324L,36162L,338611L,3509239L,39877720L,493033635L,6588722213L,94638009964L,1453983971265L,23792464984330L,413123710182463L,7586453586987049L,146901328548021943L,2991445235886992290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020011Inst : IEnumerable<long>
{
public static readonly long[] Value=A020011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020011.Bytes);
public long this[int i]=>Value[i];

public static A020011Inst Instance=new A020011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020012
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,11L,58L,365L,2653L,21951L,203550L,2091015L,23571445L,289285911L,3839613004L,54801749237L,836972170164L,13619819859948L,235251433944553L,4298685292986838L,82847389283019056L,1679542528192113596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020012Inst : IEnumerable<long>
{
public static readonly long[] Value=A020012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020012.Bytes);
public long this[int i]=>Value[i];

public static A020012Inst Instance=new A020012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020013
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,6L,32L,200L,1435L,11742L,107810L,1097700L,12274283L,149523080L,1970986053L,27952165839L,424364699555L,6866992410974L,117987415061287L,2145225728387030L,41149329880878478L,830468293959547465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020013Inst : IEnumerable<long>
{
public static readonly long[] Value=A020013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020013.Bytes);
public long this[int i]=>Value[i];

public static A020013Inst Instance=new A020013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020062
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,12L,67L,425L,3102L,25750L,239483L,2466677L,27873456L,342843514L,4559818740L,65205407994L,997642742321L,16261576699844L,281325276907303L,5148252567403658L,99361274550890613L,2017033873383079453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020062Inst : IEnumerable<long>
{
public static readonly long[] Value=A020062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020062.Bytes);
public long this[int i]=>Value[i];

public static A020062Inst Instance=new A020062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020063
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,2L,14L,91L,648L,5252L,47801L,482796L,5359035L,64844332L,849460756L,11977396665L,180858689641L,2911824903229L,49792205845228L,901238925798638L,17213663482753993L,345994636003355264L,7300486819670796087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020063Inst : IEnumerable<long>
{
public static readonly long[] Value=A020063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020063.Bytes);
public long this[int i]=>Value[i];

public static A020063Inst Instance=new A020063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020064
{
public static readonly long[] Value={ 1L,0L,1L,4L,18L,92L,543L,3741L,29513L,262341L,2594261L,28248627L,335844792L,4328666215L,60120364100L,895125421053L,14222548356738L,240203038913807L,4296965473902563L,81164903395937306L,1614279745319197538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020064Inst : IEnumerable<long>
{
public static readonly long[] Value=A020064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020064.Bytes);
public long this[int i]=>Value[i];

public static A020064Inst Instance=new A020064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020065
{
public static readonly long[] Value={ 1L,0L,1L,3L,14L,69L,400L,2714L,21115L,185345L,1812263L,19532170L,230045568L,2939471157L,40499380396L,598490843642L,9442855533026L,158430131720783L,2816535675036146L,52888281009012092L,1046012668844905826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020065Inst : IEnumerable<long>
{
public static readonly long[] Value=A020065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020065.Bytes);
public long this[int i]=>Value[i];

public static A020065Inst Instance=new A020065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020066
{
public static readonly long[] Value={ 1L,0L,0L,2L,7L,35L,198L,1302L,9843L,84216L,804738L,8494460L,98158213L,1232430908L,16706285646L,243169268856L,3782633071103L,62623591954942L,1099391947653437L,20399828362013787L,398929976857158503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020066Inst : IEnumerable<long>
{
public static readonly long[] Value=A020066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020066.Bytes);
public long this[int i]=>Value[i];

public static A020066Inst Instance=new A020066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020067
{
public static readonly long[] Value={ 1L,0L,0L,1L,5L,24L,130L,842L,6274L,52988L,500442L,5226841L,59818300L,744405515L,10008118594L,144561713037L,2232675345794L,36715105686390L,640474621418148L,11813198572823622L,229701083360459334L,4696111037591613052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020067Inst : IEnumerable<long>
{
public static readonly long[] Value=A020067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020067.Bytes);
public long this[int i]=>Value[i];

public static A020067Inst Instance=new A020067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020068
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,8L,42L,266L,1927L,15844L,146122L,1493700L,16762639L,204876708L,2708925368L,38526938568L,586465620430L,9513775620309L,163848357905335L,2985681188497227L,57391427290002261L,1160582196308934615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020068Inst : IEnumerable<long>
{
public static readonly long[] Value=A020068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020068.Bytes);
public long this[int i]=>Value[i];

public static A020068Inst Instance=new A020068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020069
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,17L,104L,740L,6005L,54717L,553253L,6147263L,74450193L,976124760L,13774204958L,208143541601L,3353423725801L,57380805974819L,1039230152655057L,19860842917407765L,399423618672311729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020069Inst : IEnumerable<long>
{
public static readonly long[] Value=A020069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020069.Bytes);
public long this[int i]=>Value[i];

public static A020069Inst Instance=new A020069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020070
{
public static readonly long[] Value={ 1L,0L,1L,4L,18L,89L,523L,3598L,28341L,251531L,2483877L,27012163L,320769440L,4129906548L,57302453360L,852373993744L,13531437150692L,228343001917931L,4081631159283027L,77040788131467135L,1531185664112909314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020070Inst : IEnumerable<long>
{
public static readonly long[] Value=A020070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020070.Bytes);
public long this[int i]=>Value[i];

public static A020070Inst Instance=new A020070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020071
{
public static readonly long[] Value={ 1L,0L,1L,2L,9L,44L,251L,1665L,12700L,109544L,1054363L,11202616L,130230419L,1644159040L,22401666926L,327624378797L,5119130918712L,85105551523594L,1499985345603353L,27937227061862467L,548268081089050917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020071Inst : IEnumerable<long>
{
public static readonly long[] Value=A020071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020071.Bytes);
public long this[int i]=>Value[i];

public static A020071Inst Instance=new A020071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020072
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,18L,97L,619L,4569L,38269L,358778L,3722325L,42341447L,523975411L,7008171124L,100742459918L,1548915321245L,25363488385398L,440690610696307L,8097689971544644L,156892743198677492L,3196689642673053918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020072Inst : IEnumerable<long>
{
public static readonly long[] Value=A020072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020072.Bytes);
public long this[int i]=>Value[i];

public static A020072Inst Instance=new A020072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020073
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,19L,120L,861L,7000L,63875L,646742L,7195012L,87239530L,1145018831L,16173391001L,244622538902L,3944538439805L,67550220781671L,1224347751667801L,23415650750646695L,471239971356764753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020073Inst : IEnumerable<long>
{
public static readonly long[] Value=A020073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020073.Bytes);
public long this[int i]=>Value[i];

public static A020073Inst Instance=new A020073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020074
{
public static readonly long[] Value={ 1L,0L,1L,4L,17L,85L,499L,3422L,26888L,238157L,2347553L,25487720L,302211542L,3885576978L,53842995267L,799953072548L,12684970150410L,213832353964066L,3818434892215473L,72004772253206072L,1429809049027949159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020074Inst : IEnumerable<long>
{
public static readonly long[] Value=A020074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020074.Bytes);
public long this[int i]=>Value[i];

public static A020074Inst Instance=new A020074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020075
{
public static readonly long[] Value={ 1L,0L,1L,3L,12L,58L,332L,2232L,17225L,150103L,1458149L,15623031L,183012659L,2326875239L,31911431853L,469553925838L,7378704548888L,123329776031414L,2184698889699346L,40885079221516335L,806020133224179176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020075Inst : IEnumerable<long>
{
public static readonly long[] Value=A020075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020075.Bytes);
public long this[int i]=>Value[i];

public static A020075Inst Instance=new A020075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020076
{
public static readonly long[] Value={ 1L,0L,0L,2L,8L,37L,210L,1380L,10450L,89574L,857351L,9063434L,104876887L,1318452295L,17893281147L,260730668150L,4059948975490L,67279154450985L,1182190856781603L,21954973054515489L,429690186924088870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020076Inst : IEnumerable<long>
{
public static readonly long[] Value=A020076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020076.Bytes);
public long this[int i]=>Value[i];

public static A020076Inst Instance=new A020076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020077
{
public static readonly long[] Value={ 1L,0L,0L,1L,5L,22L,122L,787L,5852L,49330L,465112L,4850460L,55433829L,688963306L,9251792972L,133490155743L,2059562402902L,33835668047686L,589707357402530L,10867464157846629L,211139303638163096L,4313274345751046120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020077Inst : IEnumerable<long>
{
public static readonly long[] Value=A020077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020077.Bytes);
public long this[int i]=>Value[i];

public static A020077Inst Instance=new A020077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020110
{
public static readonly long[] Value={ 1L,1L,2L,4L,15L,70L,401L,2715L,21116L,185346L,1812264L,19532171L,230045569L,2939471158L,40499380397L,598490843643L,9442855533027L,158430131720784L,2816535675036147L,52888281009012093L,1046012668844905827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020110Inst : IEnumerable<long>
{
public static readonly long[] Value=A020110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020110.Bytes);
public long this[int i]=>Value[i];

public static A020110Inst Instance=new A020110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020111
{
public static readonly long[] Value={ 1L,1L,1L,3L,8L,36L,199L,1303L,9844L,84217L,804739L,8494461L,98158214L,1232430909L,16706285647L,243169268857L,3782633071104L,62623591954943L,1099391947653438L,20399828362013788L,398929976857158504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020111Inst : IEnumerable<long>
{
public static readonly long[] Value=A020111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020111.Bytes);
public long this[int i]=>Value[i];

public static A020111Inst Instance=new A020111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020112
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,25L,131L,843L,6275L,52989L,500443L,5226842L,59818301L,744405516L,10008118595L,144561713038L,2232675345795L,36715105686391L,640474621418149L,11813198572823623L,229701083360459335L,4696111037591613053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020112Inst : IEnumerable<long>
{
public static readonly long[] Value=A020112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020112.Bytes);
public long this[int i]=>Value[i];

public static A020112Inst Instance=new A020112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020113
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,9L,43L,267L,1928L,15845L,146123L,1493701L,16762640L,204876709L,2708925369L,38526938569L,586465620431L,9513775620310L,163848357905336L,2985681188497228L,57391427290002262L,1160582196308934616L,BigInteger.Parse("24630133277222945727"),BigInteger.Parse("547336295049398793928") };
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
public class A020113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A020113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A020113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A020113Inst Instance=new A020113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020114
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,18L,105L,741L,6006L,54718L,553254L,6147264L,74450194L,976124761L,13774204959L,208143541602L,3353423725802L,57380805974820L,1039230152655058L,19860842917407766L,399423618672311730L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020114Inst : IEnumerable<long>
{
public static readonly long[] Value=A020114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020114.Bytes);
public long this[int i]=>Value[i];

public static A020114Inst Instance=new A020114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020115
{
public static readonly long[] Value={ 1L,1L,2L,5L,19L,90L,524L,3599L,28342L,251532L,2483878L,27012164L,320769441L,4129906549L,57302453361L,852373993745L,13531437150693L,228343001917932L,4081631159283028L,77040788131467136L,1531185664112909315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020115Inst : IEnumerable<long>
{
public static readonly long[] Value=A020115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020115.Bytes);
public long this[int i]=>Value[i];

public static A020115Inst Instance=new A020115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020116
{
public static readonly long[] Value={ 1L,1L,2L,3L,10L,45L,252L,1666L,12701L,109545L,1054364L,11202617L,130230420L,1644159041L,22401666927L,327624378798L,5119130918713L,85105551523595L,1499985345603354L,27937227061862468L,548268081089050918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020116Inst : IEnumerable<long>
{
public static readonly long[] Value=A020116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020116.Bytes);
public long this[int i]=>Value[i];

public static A020116Inst Instance=new A020116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020117
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,19L,98L,620L,4570L,38270L,358779L,3722326L,42341448L,523975412L,7008171125L,100742459919L,1548915321246L,25363488385399L,440690610696308L,8097689971544645L,156892743198677493L,3196689642673053919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020117Inst : IEnumerable<long>
{
public static readonly long[] Value=A020117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020117.Bytes);
public long this[int i]=>Value[i];

public static A020117Inst Instance=new A020117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020118
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,20L,121L,862L,7001L,63876L,646743L,7195013L,87239531L,1145018832L,16173391002L,244622538903L,3944538439806L,67550220781672L,1224347751667802L,23415650750646696L,471239971356764754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020118Inst : IEnumerable<long>
{
public static readonly long[] Value=A020118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020118.Bytes);
public long this[int i]=>Value[i];

public static A020118Inst Instance=new A020118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020119
{
public static readonly long[] Value={ 1L,1L,2L,5L,18L,86L,500L,3423L,26889L,238158L,2347554L,25487721L,302211543L,3885576979L,53842995268L,799953072549L,12684970150411L,213832353964067L,3818434892215474L,72004772253206073L,1429809049027949160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020119Inst : IEnumerable<long>
{
public static readonly long[] Value=A020119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020119.Bytes);
public long this[int i]=>Value[i];

public static A020119Inst Instance=new A020119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020120
{
public static readonly long[] Value={ 1L,1L,2L,4L,13L,59L,333L,2233L,17226L,150104L,1458150L,15623032L,183012660L,2326875240L,31911431854L,469553925839L,7378704548889L,123329776031415L,2184698889699347L,40885079221516336L,806020133224179177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020120Inst : IEnumerable<long>
{
public static readonly long[] Value=A020120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020120.Bytes);
public long this[int i]=>Value[i];

public static A020120Inst Instance=new A020120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020121
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,38L,211L,1381L,10451L,89575L,857352L,9063435L,104876888L,1318452296L,17893281148L,260730668151L,4059948975491L,67279154450986L,1182190856781604L,21954973054515490L,429690186924088871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020121Inst : IEnumerable<long>
{
public static readonly long[] Value=A020121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020121.Bytes);
public long this[int i]=>Value[i];

public static A020121Inst Instance=new A020121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020122
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,23L,123L,788L,5853L,49331L,465113L,4850461L,55433830L,688963307L,9251792973L,133490155744L,2059562402903L,33835668047687L,589707357402531L,10867464157846630L,211139303638163097L,4313274345751046121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020122Inst : IEnumerable<long>
{
public static readonly long[] Value=A020122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020122.Bytes);
public long this[int i]=>Value[i];

public static A020122Inst Instance=new A020122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020123
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,12L,63L,393L,2863L,23715L,220205L,2264966L,25561752L,314044379L,4172303890L,59604341273L,911094930877L,14837831731420L,256482519928832L,4689966078698629L,90449345803473559L,1834829586299035049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020123Inst : IEnumerable<long>
{
public static readonly long[] Value=A020123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020123.Bytes);
public long this[int i]=>Value[i];

public static A020123Inst Instance=new A020123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020124
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,5L,24L,144L,1028L,8371L,76528L,776208L,8649166L,105025576L,1380336142L,19521896862L,295617295327L,4772107767406L,81807561726951L,1484222905617530L,28412267050392706L,572304236300767348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020124Inst : IEnumerable<long>
{
public static readonly long[] Value=A020124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020124.Bytes);
public long this[int i]=>Value[i];

public static A020124Inst Instance=new A020124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020125
{
public static readonly long[] Value={ 1L,1L,2L,5L,17L,81L,468L,3197L,25043L,221209L,2175217L,23564851L,278850731L,3578584369L,49503750433L,734305631413L,11626505830702L,195712848150141L,3490212458677515L,65732334638426517L,1303691303662125906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020125Inst : IEnumerable<long>
{
public static readonly long[] Value=A020125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020125.Bytes);
public long this[int i]=>Value[i];

public static A020125Inst Instance=new A020125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020142
{
public static readonly long[] Value={ 15L,39L,65L,195L,481L,561L,781L,793L,841L,985L,1105L,1111L,1541L,1891L,2257L,2465L,2561L,2665L,2743L,3277L,5185L,5713L,6501L,6533L,6541L,7107L,7171L,7449L,7543L,7585L,8321L,9073L,10585L,12403L,12505L,12545L,12805L,12871L,13429L,14111L,14689L,15067L,15457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020142Inst : IEnumerable<long>
{
public static readonly long[] Value=A020142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020142.Bytes);
public long this[int i]=>Value[i];

public static A020142Inst Instance=new A020142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020143
{
public static readonly long[] Value={ 14L,341L,742L,946L,1477L,1541L,1687L,1729L,1891L,1921L,2821L,3133L,3277L,4187L,6541L,6601L,7471L,8701L,8911L,9073L,10279L,10649L,12871L,14041L,14701L,15409L,15841L,16841L,19201L,20017L,24521L,25313L,25546L,28063L,29341L,30889L,31021L,38963L,41041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020143Inst : IEnumerable<long>
{
public static readonly long[] Value=A020143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020143.Bytes);
public long this[int i]=>Value[i];

public static A020143Inst Instance=new A020143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A020144
{
public static readonly long[] Value={ 15L,51L,85L,91L,255L,341L,435L,451L,561L,595L,645L,703L,1105L,1247L,1261L,1271L,1285L,1387L,1581L,1687L,1695L,1729L,1891L,1905L,2047L,2071L,2091L,2431L,2465L,2701L,2821L,3133L,3277L,3367L,3655L,3683L,4033L,4369L,4371L,4681L,4795L,4859L,5083L,5151L,5461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A020144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A020144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A020144Inst : IEnumerable<long>
{
public static readonly long[] Value=A020144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A020144.Bytes);
public long this[int i]=>Value[i];

public static A020144Inst Instance=new A020144Inst();

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