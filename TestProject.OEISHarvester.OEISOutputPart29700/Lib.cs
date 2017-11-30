using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A019837
{
public static readonly long[] Value={ 4L,6L,9L,4L,7L,1L,5L,6L,2L,7L,8L,5L,8L,9L,0L,7L,7L,5L,9L,5L,9L,4L,6L,2L,2L,8L,8L,2L,2L,7L,8L,4L,3L,2L,9L,5L,7L,2L,3L,2L,1L,8L,7L,5L,6L,7L,1L,1L,1L,9L,6L,8L,0L,8L,3L,3L,6L,1L,0L,8L,2L,9L,9L,3L,9L,0L,8L,9L,9L,7L,9L,2L,1L,7L,4L,1L,5L,9L,3L,2L,2L,9L,9L,4L,1L,4L,7L,7L,2L,7L,9L,8L,0L,6L,9L,6L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019837Inst : IEnumerable<long>
{
public static readonly long[] Value=A019837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019837.Bytes);
public long this[int i]=>Value[i];

public static A019837Inst Instance=new A019837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019836
{
public static readonly long[] Value={ 4L,5L,3L,9L,9L,0L,4L,9L,9L,7L,3L,9L,5L,4L,6L,7L,9L,1L,5L,6L,0L,4L,0L,8L,3L,6L,6L,3L,5L,7L,8L,7L,1L,1L,9L,8L,9L,8L,3L,0L,4L,7L,7L,0L,3L,0L,4L,9L,0L,2L,1L,5L,5L,6L,9L,8L,5L,3L,1L,6L,0L,0L,5L,8L,2L,2L,0L,2L,6L,7L,8L,4L,1L,3L,1L,8L,5L,2L,4L,2L,8L,7L,5L,4L,4L,7L,3L,4L,3L,9L,2L,2L,1L,9L,4L,6L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019836Inst : IEnumerable<long>
{
public static readonly long[] Value=A019836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019836.Bytes);
public long this[int i]=>Value[i];

public static A019836Inst Instance=new A019836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019835
{
public static readonly long[] Value={ 4L,3L,8L,3L,7L,1L,1L,4L,6L,7L,8L,9L,0L,7L,7L,4L,1L,7L,4L,5L,2L,7L,3L,4L,5L,4L,0L,6L,5L,8L,2L,6L,5L,7L,3L,9L,0L,6L,2L,7L,5L,5L,7L,1L,9L,9L,8L,8L,5L,5L,2L,1L,1L,4L,4L,3L,1L,1L,2L,6L,2L,5L,6L,6L,5L,2L,8L,1L,6L,3L,3L,4L,0L,1L,3L,4L,3L,9L,0L,0L,3L,9L,0L,7L,7L,8L,0L,4L,0L,6L,3L,6L,4L,7L,4L,9L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019835Inst : IEnumerable<long>
{
public static readonly long[] Value=A019835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019835.Bytes);
public long this[int i]=>Value[i];

public static A019835Inst Instance=new A019835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019834
{
public static readonly long[] Value={ 4L,2L,2L,6L,1L,8L,2L,6L,1L,7L,4L,0L,6L,9L,9L,4L,3L,6L,1L,8L,6L,9L,7L,8L,4L,8L,9L,6L,4L,7L,7L,3L,0L,1L,8L,1L,5L,6L,3L,1L,2L,9L,3L,0L,1L,1L,9L,4L,8L,6L,4L,6L,2L,3L,4L,4L,4L,4L,1L,5L,1L,5L,9L,2L,1L,0L,6L,5L,9L,8L,4L,9L,9L,8L,5L,6L,8L,9L,9L,8L,9L,6L,1L,4L,4L,6L,4L,3L,7L,3L,6L,1L,9L,4L,3L,1L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019834Inst : IEnumerable<long>
{
public static readonly long[] Value=A019834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019834.Bytes);
public long this[int i]=>Value[i];

public static A019834Inst Instance=new A019834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019833
{
public static readonly long[] Value={ 4L,0L,6L,7L,3L,6L,6L,4L,3L,0L,7L,5L,8L,0L,0L,2L,0L,7L,7L,5L,3L,9L,8L,5L,9L,9L,0L,3L,4L,1L,4L,9L,7L,6L,1L,2L,9L,2L,3L,1L,3L,9L,6L,5L,1L,0L,6L,6L,1L,7L,3L,4L,3L,6L,2L,9L,4L,2L,8L,6L,3L,5L,2L,8L,1L,7L,0L,3L,7L,7L,7L,6L,5L,2L,4L,5L,4L,6L,4L,0L,5L,0L,7L,0L,8L,0L,2L,1L,7L,0L,5L,2L,0L,6L,1L,9L,5L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019833Inst : IEnumerable<long>
{
public static readonly long[] Value=A019833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019833.Bytes);
public long this[int i]=>Value[i];

public static A019833Inst Instance=new A019833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019832
{
public static readonly long[] Value={ 3L,9L,0L,7L,3L,1L,1L,2L,8L,4L,8L,9L,2L,7L,3L,7L,5L,5L,0L,6L,2L,0L,8L,4L,5L,8L,8L,8L,8L,9L,0L,9L,4L,2L,6L,7L,6L,1L,8L,0L,1L,5L,1L,6L,7L,5L,7L,6L,4L,3L,2L,0L,7L,5L,7L,4L,7L,1L,0L,6L,5L,4L,9L,4L,6L,4L,5L,5L,4L,6L,8L,2L,0L,7L,1L,8L,9L,2L,5L,5L,3L,2L,1L,6L,6L,2L,8L,2L,2L,9L,3L,8L,4L,0L,5L,4L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019832Inst : IEnumerable<long>
{
public static readonly long[] Value=A019832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019832.Bytes);
public long this[int i]=>Value[i];

public static A019832Inst Instance=new A019832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019831
{
public static readonly long[] Value={ 3L,7L,4L,6L,0L,6L,5L,9L,3L,4L,1L,5L,9L,1L,2L,0L,3L,5L,4L,1L,4L,9L,6L,3L,7L,7L,4L,5L,0L,1L,1L,9L,5L,1L,3L,1L,0L,0L,0L,1L,5L,8L,9L,2L,2L,2L,5L,3L,6L,7L,6L,1L,7L,4L,1L,0L,3L,4L,4L,0L,3L,7L,1L,0L,3L,3L,3L,5L,8L,6L,1L,4L,3L,6L,6L,0L,8L,5L,2L,1L,8L,9L,5L,8L,6L,3L,5L,7L,3L,6L,2L,2L,2L,4L,8L,5L,2L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019831Inst : IEnumerable<long>
{
public static readonly long[] Value=A019831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019831.Bytes);
public long this[int i]=>Value[i];

public static A019831Inst Instance=new A019831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019830
{
public static readonly long[] Value={ 3L,5L,8L,3L,6L,7L,9L,4L,9L,5L,4L,5L,3L,0L,0L,2L,7L,3L,4L,8L,4L,1L,3L,7L,7L,8L,9L,4L,1L,3L,4L,6L,6L,8L,3L,4L,1L,9L,1L,5L,4L,4L,4L,4L,9L,4L,6L,0L,0L,1L,3L,7L,9L,5L,4L,6L,3L,5L,7L,6L,7L,7L,5L,8L,5L,7L,3L,1L,9L,9L,2L,5L,9L,8L,2L,4L,9L,9L,0L,9L,8L,9L,8L,7L,3L,1L,6L,0L,9L,1L,3L,9L,2L,9L,8L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019830Inst : IEnumerable<long>
{
public static readonly long[] Value=A019830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019830.Bytes);
public long this[int i]=>Value[i];

public static A019830Inst Instance=new A019830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019829
{
public static readonly long[] Value={ 3L,4L,2L,0L,2L,0L,1L,4L,3L,3L,2L,5L,6L,6L,8L,7L,3L,3L,0L,4L,4L,0L,9L,9L,6L,1L,4L,6L,8L,2L,2L,5L,9L,5L,8L,0L,7L,6L,3L,0L,8L,3L,3L,6L,7L,5L,1L,4L,1L,6L,0L,6L,2L,8L,4L,6L,5L,0L,4L,8L,4L,9L,7L,6L,8L,4L,7L,1L,4L,7L,6L,3L,7L,0L,2L,0L,7L,7L,5L,9L,9L,5L,6L,4L,1L,9L,0L,1L,8L,2L,3L,3L,8L,5L,2L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019829Inst : IEnumerable<long>
{
public static readonly long[] Value=A019829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019829.Bytes);
public long this[int i]=>Value[i];

public static A019829Inst Instance=new A019829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019828
{
public static readonly long[] Value={ 3L,2L,5L,5L,6L,8L,1L,5L,4L,4L,5L,7L,1L,5L,6L,6L,6L,8L,7L,1L,4L,0L,0L,8L,9L,3L,5L,7L,9L,4L,7L,2L,1L,5L,7L,1L,7L,9L,8L,8L,5L,1L,6L,0L,6L,7L,5L,9L,1L,2L,3L,1L,0L,7L,2L,1L,5L,2L,2L,2L,7L,9L,4L,9L,4L,6L,6L,0L,1L,6L,8L,0L,5L,2L,8L,3L,8L,4L,1L,7L,9L,4L,2L,8L,1L,7L,6L,5L,9L,6L,7L,1L,3L,1L,2L,7L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019828Inst : IEnumerable<long>
{
public static readonly long[] Value=A019828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019828.Bytes);
public long this[int i]=>Value[i];

public static A019828Inst Instance=new A019828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019827
{
public static readonly long[] Value={ 3L,0L,9L,0L,1L,6L,9L,9L,4L,3L,7L,4L,9L,4L,7L,4L,2L,4L,1L,0L,2L,2L,9L,3L,4L,1L,7L,1L,8L,2L,8L,1L,9L,0L,5L,8L,8L,6L,0L,1L,5L,4L,5L,8L,9L,9L,0L,2L,8L,8L,1L,4L,3L,1L,0L,6L,7L,7L,2L,4L,3L,1L,1L,3L,5L,2L,6L,3L,0L,2L,3L,1L,4L,0L,9L,4L,5L,1L,2L,2L,4L,8L,5L,3L,6L,0L,3L,6L,0L,2L,0L,9L,4L,6L,9L,5L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019827Inst : IEnumerable<long>
{
public static readonly long[] Value=A019827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019827.Bytes);
public long this[int i]=>Value[i];

public static A019827Inst Instance=new A019827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019826
{
public static readonly long[] Value={ 2L,9L,2L,3L,7L,1L,7L,0L,4L,7L,2L,2L,7L,3L,6L,7L,2L,8L,0L,9L,7L,4L,6L,8L,6L,9L,5L,3L,7L,7L,1L,4L,3L,2L,5L,2L,6L,6L,4L,6L,8L,7L,1L,8L,6L,1L,8L,2L,6L,2L,4L,5L,4L,1L,7L,1L,9L,6L,6L,4L,3L,6L,9L,6L,0L,1L,0L,5L,0L,1L,0L,8L,1L,5L,7L,4L,7L,4L,7L,0L,5L,4L,0L,6L,5L,8L,5L,1L,0L,6L,5L,1L,2L,8L,9L,3L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019826Inst : IEnumerable<long>
{
public static readonly long[] Value=A019826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019826.Bytes);
public long this[int i]=>Value[i];

public static A019826Inst Instance=new A019826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019825
{
public static readonly long[] Value={ 2L,7L,5L,6L,3L,7L,3L,5L,5L,8L,1L,6L,9L,9L,9L,1L,8L,5L,6L,4L,9L,9L,7L,1L,5L,7L,4L,6L,1L,1L,3L,0L,4L,1L,4L,7L,7L,1L,2L,4L,4L,7L,3L,2L,6L,4L,5L,6L,8L,9L,6L,6L,8L,1L,8L,6L,6L,9L,6L,5L,0L,7L,2L,0L,1L,9L,7L,3L,8L,2L,5L,5L,1L,1L,7L,4L,8L,3L,6L,5L,7L,5L,2L,6L,6L,9L,3L,3L,5L,8L,9L,3L,6L,6L,9L,8L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019825Inst : IEnumerable<long>
{
public static readonly long[] Value=A019825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019825.Bytes);
public long this[int i]=>Value[i];

public static A019825Inst Instance=new A019825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019824
{
public static readonly long[] Value={ 2L,5L,8L,8L,1L,9L,0L,4L,5L,1L,0L,2L,5L,2L,0L,7L,6L,2L,3L,4L,8L,8L,9L,8L,8L,3L,7L,6L,2L,4L,0L,4L,8L,3L,2L,8L,3L,4L,9L,0L,6L,8L,9L,0L,1L,3L,1L,9L,9L,3L,0L,5L,1L,3L,8L,1L,4L,0L,0L,3L,2L,0L,7L,3L,1L,5L,0L,5L,6L,9L,7L,4L,7L,4L,8L,8L,0L,1L,9L,9L,6L,9L,2L,2L,3L,6L,7L,9L,7L,4L,6L,9L,4L,2L,4L,9L,6L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019824Inst : IEnumerable<long>
{
public static readonly long[] Value=A019824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019824.Bytes);
public long this[int i]=>Value[i];

public static A019824Inst Instance=new A019824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019823
{
public static readonly long[] Value={ 2L,4L,1L,9L,2L,1L,8L,9L,5L,5L,9L,9L,6L,6L,7L,7L,2L,2L,5L,6L,0L,4L,4L,2L,3L,7L,4L,1L,0L,0L,3L,5L,2L,9L,6L,5L,2L,9L,5L,0L,0L,7L,9L,3L,0L,3L,9L,8L,7L,4L,2L,8L,9L,4L,5L,7L,6L,4L,7L,1L,2L,6L,5L,8L,3L,8L,8L,9L,0L,8L,2L,4L,6L,7L,6L,1L,3L,2L,5L,8L,4L,3L,3L,2L,3L,5L,2L,8L,5L,7L,8L,2L,7L,3L,1L,4L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019823Inst : IEnumerable<long>
{
public static readonly long[] Value=A019823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019823.Bytes);
public long this[int i]=>Value[i];

public static A019823Inst Instance=new A019823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019822
{
public static readonly long[] Value={ 2L,2L,4L,9L,5L,1L,0L,5L,4L,3L,4L,3L,8L,6L,4L,9L,9L,8L,0L,5L,1L,1L,0L,7L,2L,0L,8L,3L,4L,2L,7L,9L,6L,5L,5L,8L,6L,3L,1L,0L,1L,3L,7L,9L,9L,2L,2L,8L,6L,8L,5L,0L,2L,1L,5L,1L,2L,7L,7L,9L,5L,0L,7L,2L,5L,6L,4L,2L,5L,9L,9L,3L,0L,1L,6L,1L,3L,3L,1L,0L,4L,4L,1L,1L,9L,0L,8L,8L,7L,8L,4L,0L,0L,5L,6L,1L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019822Inst : IEnumerable<long>
{
public static readonly long[] Value=A019822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019822.Bytes);
public long this[int i]=>Value[i];

public static A019822Inst Instance=new A019822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019805
{
public static readonly long[] Value={ 1L,5L,5L,4L,4L,2L,9L,3L,2L,1L,0L,6L,4L,7L,4L,9L,4L,6L,8L,9L,0L,9L,0L,2L,4L,0L,4L,1L,4L,4L,5L,6L,0L,0L,5L,8L,4L,2L,5L,3L,4L,9L,0L,8L,6L,6L,1L,2L,5L,0L,5L,8L,9L,4L,8L,6L,7L,2L,0L,6L,4L,2L,9L,8L,5L,1L,7L,3L,4L,0L,0L,3L,2L,9L,4L,1L,7L,7L,1L,5L,6L,6L,3L,3L,5L,0L,8L,6L,6L,6L,1L,1L,9L,6L,9L,8L,5L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019805Inst : IEnumerable<long>
{
public static readonly long[] Value=A019805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019805.Bytes);
public long this[int i]=>Value[i];

public static A019805Inst Instance=new A019805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019804
{
public static readonly long[] Value={ 1L,7L,9L,3L,5L,7L,2L,2L,9L,3L,5L,3L,6L,2L,4L,9L,3L,8L,7L,2L,0L,2L,7L,2L,0L,0L,4L,7L,8L,2L,1L,8L,4L,6L,8L,2L,7L,9L,8L,4L,7L,9L,7L,1L,5L,3L,2L,2L,1L,2L,2L,1L,8L,6L,3L,8L,5L,2L,3L,8L,1L,8L,8L,2L,9L,0L,4L,6L,2L,3L,1L,1L,4L,9L,3L,2L,8L,1L,3L,3L,4L,5L,7L,7L,1L,2L,5L,3L,8L,3L,9L,8L,4L,2L,6L,7L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019804Inst : IEnumerable<long>
{
public static readonly long[] Value=A019804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019804.Bytes);
public long this[int i]=>Value[i];

public static A019804Inst Instance=new A019804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019803
{
public static readonly long[] Value={ 2L,1L,1L,9L,6L,7L,6L,3L,4L,6L,9L,0L,6L,4L,7L,6L,5L,4L,8L,5L,1L,2L,3L,0L,5L,5L,1L,1L,0L,6L,2L,1L,8L,2L,6L,1L,4L,8L,9L,1L,1L,2L,3L,9L,0L,8L,3L,5L,2L,3L,5L,3L,1L,1L,1L,8L,2L,5L,5L,4L,2L,2L,2L,5L,2L,5L,0L,9L,1L,8L,2L,2L,6L,7L,3L,8L,7L,7L,9L,4L,0L,8L,6L,3L,8L,7L,5L,4L,5L,3L,7L,9L,9L,5L,8L,8L,8L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019803Inst : IEnumerable<long>
{
public static readonly long[] Value=A019803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019803.Bytes);
public long this[int i]=>Value[i];

public static A019803Inst Instance=new A019803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019802
{
public static readonly long[] Value={ 2L,5L,9L,0L,7L,1L,5L,5L,3L,5L,1L,0L,7L,9L,1L,5L,7L,8L,1L,5L,1L,5L,0L,4L,0L,0L,6L,9L,0L,7L,6L,0L,0L,0L,9L,7L,3L,7L,5L,5L,8L,1L,8L,1L,1L,0L,2L,0L,8L,4L,3L,1L,5L,8L,1L,1L,2L,0L,1L,0L,7L,1L,6L,4L,1L,9L,5L,5L,6L,6L,7L,2L,1L,5L,6L,9L,6L,1L,9L,2L,7L,7L,2L,2L,5L,1L,4L,4L,4L,3L,5L,3L,2L,8L,3L,0L,8L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019802Inst : IEnumerable<long>
{
public static readonly long[] Value=A019802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019802.Bytes);
public long this[int i]=>Value[i];

public static A019802Inst Instance=new A019802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019801
{
public static readonly long[] Value={ 3L,3L,3L,0L,9L,1L,9L,9L,7L,3L,7L,1L,0L,1L,7L,7L,4L,3L,3L,3L,7L,6L,4L,8L,0L,0L,8L,8L,8L,1L,2L,0L,0L,1L,2L,5L,1L,9L,7L,1L,7L,6L,6L,1L,4L,1L,6L,9L,6L,5L,5L,4L,8L,9L,0L,0L,1L,1L,5L,6L,6L,3L,5L,3L,9L,6L,5L,7L,2L,8L,6L,4L,2L,0L,1L,8L,0L,8L,1L,9L,2L,7L,8L,6L,0L,8L,9L,9L,9L,8L,8L,2L,7L,9L,2L,5L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019801Inst : IEnumerable<long>
{
public static readonly long[] Value=A019801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019801.Bytes);
public long this[int i]=>Value[i];

public static A019801Inst Instance=new A019801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019800
{
public static readonly long[] Value={ 4L,6L,6L,3L,2L,8L,7L,9L,6L,3L,1L,9L,4L,2L,4L,8L,4L,0L,6L,7L,2L,7L,0L,7L,2L,1L,2L,4L,3L,3L,6L,8L,0L,1L,7L,5L,2L,7L,6L,0L,4L,7L,2L,5L,9L,8L,3L,7L,5L,1L,7L,6L,8L,4L,6L,0L,1L,6L,1L,9L,2L,8L,9L,5L,5L,5L,2L,0L,2L,0L,0L,9L,8L,8L,2L,5L,3L,1L,4L,6L,9L,9L,0L,0L,5L,2L,5L,9L,9L,8L,3L,5L,9L,0L,9L,5L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019800Inst : IEnumerable<long>
{
public static readonly long[] Value=A019800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019800.Bytes);
public long this[int i]=>Value[i];

public static A019800Inst Instance=new A019800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019799
{
public static readonly long[] Value={ 7L,7L,7L,2L,1L,4L,6L,6L,0L,5L,3L,2L,3L,7L,4L,7L,3L,4L,4L,5L,4L,5L,1L,2L,0L,2L,0L,7L,2L,2L,8L,0L,0L,2L,9L,2L,1L,2L,6L,7L,4L,5L,4L,3L,3L,0L,6L,2L,5L,2L,9L,4L,7L,4L,3L,3L,6L,0L,3L,2L,1L,4L,9L,2L,5L,8L,6L,7L,0L,0L,1L,6L,4L,7L,0L,8L,8L,5L,7L,8L,3L,1L,6L,7L,5L,4L,3L,3L,3L,0L,5L,9L,8L,4L,9L,2L,5L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019799Inst : IEnumerable<long>
{
public static readonly long[] Value=A019799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019799.Bytes);
public long this[int i]=>Value[i];

public static A019799Inst Instance=new A019799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019798
{
public static readonly long[] Value={ 2L,3L,3L,1L,6L,4L,3L,9L,8L,1L,5L,9L,7L,1L,2L,4L,2L,0L,3L,3L,6L,3L,5L,3L,6L,0L,6L,2L,1L,6L,8L,4L,0L,0L,8L,7L,6L,3L,8L,0L,2L,3L,6L,2L,9L,9L,1L,8L,7L,5L,8L,8L,4L,2L,3L,0L,0L,8L,0L,9L,6L,4L,4L,7L,7L,7L,6L,0L,1L,0L,0L,4L,9L,4L,1L,2L,6L,5L,7L,3L,4L,9L,5L,0L,2L,6L,2L,9L,9L,9L,1L,7L,9L,5L,4L,7L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019798Inst : IEnumerable<long>
{
public static readonly long[] Value=A019798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019798.Bytes);
public long this[int i]=>Value[i];

public static A019798Inst Instance=new A019798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019797
{
public static readonly long[] Value={ 6L,8L,6L,9L,6L,7L,1L,9L,6L,1L,2L,5L,0L,5L,3L,3L,9L,4L,5L,2L,0L,2L,7L,1L,1L,6L,1L,5L,8L,9L,2L,3L,4L,8L,2L,1L,5L,2L,2L,4L,0L,6L,7L,0L,8L,6L,2L,9L,2L,2L,8L,3L,3L,8L,1L,5L,6L,2L,8L,3L,0L,4L,6L,5L,1L,6L,9L,4L,2L,0L,9L,2L,1L,6L,4L,2L,5L,6L,5L,0L,3L,5L,9L,6L,9L,9L,0L,2L,1L,6L,6L,9L,0L,1L,5L,2L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019797Inst : IEnumerable<long>
{
public static readonly long[] Value=A019797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019797.Bytes);
public long this[int i]=>Value[i];

public static A019797Inst Instance=new A019797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019796
{
public static readonly long[] Value={ 7L,1L,6L,8L,3L,5L,3L,3L,5L,0L,8L,7L,0L,1L,2L,2L,3L,7L,7L,6L,0L,2L,8L,2L,9L,5L,1L,2L,2L,3L,5L,4L,9L,3L,7L,8L,9L,7L,9L,9L,0L,2L,6L,5L,2L,4L,8L,2L,6L,7L,3L,0L,4L,8L,5L,1L,0L,9L,0L,4L,0L,4L,8L,5L,3L,9L,4L,1L,7L,8L,3L,5L,3L,0L,1L,8L,3L,2L,8L,7L,3L,3L,1L,8L,5L,9L,8L,4L,8L,6L,9L,8L,1L,0L,2L,8L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019796Inst : IEnumerable<long>
{
public static readonly long[] Value=A019796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019796.Bytes);
public long this[int i]=>Value[i];

public static A019796Inst Instance=new A019796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019795
{
public static readonly long[] Value={ 7L,4L,9L,4L,1L,8L,7L,5L,9L,4L,0L,9L,1L,4L,9L,1L,5L,7L,6L,5L,8L,4L,7L,7L,6L,3L,0L,8L,2L,4L,6L,1L,9L,8L,0L,5L,2L,9L,7L,1L,7L,0L,9L,5L,4L,8L,6L,8L,2L,4L,9L,0L,9L,6L,1L,7L,0L,4L,9L,0L,5L,9L,6L,2L,0L,0L,3L,0L,0L,4L,6L,4L,1L,7L,9L,1L,8L,8L,9L,1L,3L,0L,1L,4L,8L,9L,8L,4L,1L,8L,2L,0L,7L,4L,3L,9L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019795Inst : IEnumerable<long>
{
public static readonly long[] Value=A019795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019795.Bytes);
public long this[int i]=>Value[i];

public static A019795Inst Instance=new A019795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019794
{
public static readonly long[] Value={ 7L,8L,5L,1L,0L,5L,3L,6L,7L,0L,0L,0L,0L,6L,1L,0L,2L,2L,3L,0L,8L,8L,8L,1L,3L,2L,7L,5L,3L,0L,5L,5L,4L,0L,8L,1L,7L,3L,9L,8L,9L,3L,3L,8L,1L,2L,9L,0L,5L,4L,6L,6L,7L,2L,1L,7L,8L,6L,0L,9L,1L,9L,6L,0L,1L,9L,3L,6L,2L,3L,9L,1L,0L,4L,4L,8L,6L,4L,5L,7L,5L,5L,3L,9L,4L,1L,7L,3L,9L,0L,5L,0L,3L,0L,3L,1L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019794Inst : IEnumerable<long>
{
public static readonly long[] Value=A019794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019794.Bytes);
public long this[int i]=>Value[i];

public static A019794Inst Instance=new A019794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019793
{
public static readonly long[] Value={ 1L,20L,271L,3110L,32641L,324800L,3125011L,29414090L,272851381L,2506362980L,22871235751L,207773763470L,1881803862121L,17008495407560L,153516126074491L,1384313656687250L,12474986630176861L,112372624930994540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019793Inst : IEnumerable<long>
{
public static readonly long[] Value=A019793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019793.Bytes);
public long this[int i]=>Value[i];

public static A019793Inst Instance=new A019793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019792
{
public static readonly long[] Value={ 8L,6L,7L,7L,4L,8L,0L,3L,7L,2L,1L,0L,5L,9L,3L,7L,6L,1L,4L,9L,9L,2L,8L,9L,8L,8L,8L,3L,2L,3L,2L,4L,3L,9L,8L,5L,0L,8L,0L,9L,3L,4L,7L,8L,9L,8L,4L,7L,4L,4L,6L,3L,2L,1L,8L,8L,1L,6L,2L,0L,6L,9L,0L,3L,3L,7L,1L,9L,0L,0L,1L,1L,1L,5L,4L,8L,5L,0L,3L,2L,0L,3L,3L,3L,0L,4L,0L,2L,7L,3L,7L,1L,3L,8L,7L,7L,1L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019792Inst : IEnumerable<long>
{
public static readonly long[] Value=A019792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019792.Bytes);
public long this[int i]=>Value[i];

public static A019792Inst Instance=new A019792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019791
{
public static readonly long[] Value={ 9L,1L,5L,9L,5L,6L,2L,6L,1L,5L,0L,0L,0L,7L,1L,1L,9L,2L,6L,9L,3L,6L,9L,4L,8L,8L,2L,1L,1L,8L,9L,7L,9L,7L,6L,2L,0L,2L,9L,8L,7L,5L,6L,1L,1L,5L,0L,5L,6L,3L,7L,7L,8L,4L,2L,0L,8L,3L,7L,7L,3L,9L,5L,3L,5L,5L,9L,2L,2L,7L,8L,9L,5L,5L,2L,3L,4L,2L,0L,0L,4L,7L,9L,5L,9L,8L,6L,9L,5L,5L,5L,8L,6L,8L,7L,0L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019791Inst : IEnumerable<long>
{
public static readonly long[] Value=A019791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019791.Bytes);
public long this[int i]=>Value[i];

public static A019791Inst Instance=new A019791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019790
{
public static readonly long[] Value={ 9L,6L,9L,8L,3L,6L,0L,4L,1L,5L,8L,8L,3L,1L,0L,6L,7L,4L,6L,1L,6L,8L,5L,3L,4L,0L,4L,5L,9L,6L,5L,6L,6L,8L,0L,6L,8L,5L,5L,1L,6L,2L,4L,1L,2L,1L,8L,2L,4L,4L,0L,0L,0L,6L,8L,0L,8L,8L,7L,0L,1L,8L,3L,3L,1L,8L,0L,3L,5L,8L,9L,4L,8L,2L,0L,1L,2L,6L,8L,2L,8L,6L,0L,7L,5L,1L,5L,6L,0L,0L,0L,3L,3L,1L,5L,6L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019790Inst : IEnumerable<long>
{
public static readonly long[] Value=A019790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019790.Bytes);
public long this[int i]=>Value[i];

public static A019790Inst Instance=new A019790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019773
{
public static readonly long[] Value={ 2L,3L,6L,3L,7L,2L,3L,3L,2L,9L,0L,9L,4L,8L,2L,1L,9L,4L,3L,7L,9L,1L,5L,5L,4L,3L,2L,2L,9L,1L,5L,3L,5L,8L,6L,9L,3L,7L,0L,1L,9L,5L,3L,9L,9L,4L,5L,2L,1L,7L,0L,3L,9L,7L,8L,2L,3L,2L,1L,4L,5L,7L,6L,3L,2L,3L,8L,3L,2L,7L,5L,0L,4L,6L,5L,5L,2L,5L,8L,7L,7L,7L,8L,8L,8L,1L,5L,8L,4L,1L,6L,1L,0L,8L,8L,4L,0L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019773Inst : IEnumerable<long>
{
public static readonly long[] Value=A019773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019773.Bytes);
public long this[int i]=>Value[i];

public static A019773Inst Instance=new A019773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019772
{
public static readonly long[] Value={ 2L,5L,8L,8L,8L,3L,9L,8L,3L,6L,6L,2L,7L,6L,6L,2L,1L,2L,8L,9L,1L,4L,5L,5L,9L,4L,9L,6L,5L,2L,6L,3L,4L,5L,2L,3L,5L,9L,5L,9L,2L,8L,2L,9L,4L,6L,3L,8L,0L,9L,1L,3L,8L,8L,0L,9L,2L,0L,9L,2L,1L,5L,5L,0L,2L,1L,3L,4L,0L,6L,3L,1L,4L,6L,2L,2L,4L,2L,6L,2L,8L,0L,5L,4L,4L,1L,7L,3L,5L,0L,3L,3L,5L,7L,3L,0L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019772Inst : IEnumerable<long>
{
public static readonly long[] Value=A019772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019772.Bytes);
public long this[int i]=>Value[i];

public static A019772Inst Instance=new A019772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019771
{
public static readonly long[] Value={ 2L,8L,6L,1L,3L,4L,9L,2L,9L,3L,1L,1L,4L,7L,8L,4L,4L,5L,8L,2L,7L,3L,9L,8L,6L,8L,1L,1L,9L,5L,0L,1L,7L,1L,0L,5L,0L,2L,7L,0L,7L,8L,6L,4L,1L,4L,4L,2L,1L,0L,1L,0L,0L,7L,8L,9L,1L,2L,5L,9L,7L,5L,0L,2L,8L,6L,7L,4L,4L,9L,0L,8L,4L,5L,8L,2L,6L,8L,1L,6L,7L,8L,4L,9L,6L,1L,9L,1L,7L,6L,6L,8L,6L,8L,5L,9L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019771Inst : IEnumerable<long>
{
public static readonly long[] Value=A019771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019771.Bytes);
public long this[int i]=>Value[i];

public static A019771Inst Instance=new A019771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019770
{
public static readonly long[] Value={ 3L,1L,9L,7L,9L,7L,8L,6L,2L,1L,7L,1L,6L,5L,2L,3L,8L,0L,6L,3L,0L,6L,2L,2L,0L,5L,5L,4L,5L,3L,2L,5L,4L,4L,1L,1L,5L,0L,0L,8L,5L,2L,5L,9L,9L,2L,5L,8L,8L,1L,8L,7L,7L,3L,5L,2L,5L,5L,2L,5L,6L,0L,3L,2L,6L,1L,6L,5L,6L,0L,7L,4L,1L,5L,9L,2L,4L,0L,8L,9L,3L,4L,7L,8L,9L,8L,6L,1L,3L,8L,6L,5L,0L,0L,1L,9L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019770Inst : IEnumerable<long>
{
public static readonly long[] Value=A019770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019770.Bytes);
public long this[int i]=>Value[i];

public static A019770Inst Instance=new A019770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019769
{
public static readonly long[] Value={ 3L,6L,2L,4L,3L,7L,5L,7L,7L,1L,2L,7L,8L,7L,2L,6L,9L,8L,0L,4L,8L,0L,3L,8L,3L,2L,9L,5L,1L,3L,6L,8L,8L,3L,3L,3L,0L,3L,4L,2L,9L,9L,6L,1L,2L,4L,9L,3L,3L,2L,7L,9L,4L,3L,3L,2L,8L,9L,2L,9L,0L,1L,7L,0L,2L,9L,8L,7L,6L,8L,8L,4L,0L,4L,7L,1L,3L,9L,6L,7L,9L,2L,7L,6L,1L,8L,4L,2L,9L,0L,4L,7L,0L,0L,2L,2L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019769Inst : IEnumerable<long>
{
public static readonly long[] Value=A019769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019769.Bytes);
public long this[int i]=>Value[i];

public static A019769Inst Instance=new A019769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019768
{
public static readonly long[] Value={ 4L,1L,8L,1L,9L,7L,2L,0L,4L,3L,7L,8L,3L,1L,4L,6L,5L,1L,5L,9L,3L,8L,9L,0L,3L,8L,0L,2L,0L,8L,1L,0L,1L,9L,2L,2L,7L,3L,1L,8L,8L,4L,1L,6L,8L,2L,6L,1L,5L,3L,2L,2L,4L,2L,3L,0L,2L,6L,1L,0L,4L,0L,4L,2L,6L,5L,2L,4L,2L,5L,5L,8L,5L,1L,5L,9L,3L,0L,3L,9L,9L,1L,6L,4L,8L,2L,8L,0L,2L,7L,4L,6L,5L,4L,1L,0L,2L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019768Inst : IEnumerable<long>
{
public static readonly long[] Value=A019768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019768.Bytes);
public long this[int i]=>Value[i];

public static A019768Inst Instance=new A019768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019767
{
public static readonly long[] Value={ 4L,9L,4L,2L,3L,3L,0L,5L,9L,7L,1L,9L,8L,2L,6L,4L,0L,6L,4L,2L,9L,1L,4L,3L,1L,7L,6L,6L,0L,9L,5L,7L,4L,9L,9L,9L,5L,9L,2L,2L,2L,6L,7L,4L,4L,3L,0L,9L,0L,8L,3L,5L,5L,9L,0L,8L,4L,9L,0L,3L,2L,0L,5L,0L,4L,0L,7L,4L,1L,2L,0L,5L,5L,1L,8L,8L,2L,6L,8L,3L,5L,3L,7L,6L,6L,1L,4L,9L,4L,1L,5L,5L,0L,0L,3L,0L,2L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019767Inst : IEnumerable<long>
{
public static readonly long[] Value=A019767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019767.Bytes);
public long this[int i]=>Value[i];

public static A019767Inst Instance=new A019767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019766
{
public static readonly long[] Value={ 6L,0L,4L,0L,6L,2L,6L,2L,8L,5L,4L,6L,4L,5L,4L,4L,9L,6L,7L,4L,6L,7L,3L,0L,5L,4L,9L,1L,8L,9L,4L,8L,0L,5L,5L,5L,0L,5L,7L,1L,6L,6L,0L,2L,0L,8L,2L,2L,2L,1L,3L,2L,3L,8L,8L,8L,1L,5L,4L,8L,3L,6L,1L,7L,1L,6L,4L,6L,1L,4L,7L,3L,4L,1L,1L,8L,9L,9L,4L,6L,5L,4L,6L,0L,3L,0L,7L,1L,5L,0L,7L,8L,3L,3L,7L,0L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019766Inst : IEnumerable<long>
{
public static readonly long[] Value=A019766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019766.Bytes);
public long this[int i]=>Value[i];

public static A019766Inst Instance=new A019766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019765
{
public static readonly long[] Value={ 7L,7L,6L,6L,5L,1L,9L,5L,0L,9L,8L,8L,2L,9L,8L,6L,3L,8L,6L,7L,4L,3L,6L,7L,8L,4L,8L,9L,5L,7L,9L,0L,3L,5L,7L,0L,7L,8L,7L,7L,8L,4L,8L,8L,3L,9L,1L,4L,2L,7L,4L,1L,6L,4L,2L,7L,6L,2L,7L,6L,4L,6L,5L,0L,6L,4L,0L,2L,1L,8L,9L,4L,3L,8L,6L,7L,2L,7L,8L,8L,4L,1L,6L,3L,2L,5L,2L,0L,5L,1L,0L,0L,7L,1L,9L,0L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019765Inst : IEnumerable<long>
{
public static readonly long[] Value=A019765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019765.Bytes);
public long this[int i]=>Value[i];

public static A019765Inst Instance=new A019765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019764
{
public static readonly long[] Value={ 1L,0L,8L,7L,3L,1L,2L,7L,3L,1L,3L,8L,3L,6L,1L,8L,0L,9L,4L,1L,4L,4L,1L,1L,4L,9L,8L,8L,5L,4L,1L,0L,6L,4L,9L,9L,9L,1L,0L,2L,8L,9L,8L,8L,3L,7L,4L,7L,9L,9L,8L,3L,8L,2L,9L,9L,8L,6L,7L,8L,7L,0L,5L,1L,0L,8L,9L,6L,3L,0L,6L,5L,2L,1L,4L,1L,4L,1L,9L,0L,3L,7L,8L,2L,8L,5L,5L,2L,8L,7L,1L,4L,1L,0L,0L,6L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019764Inst : IEnumerable<long>
{
public static readonly long[] Value=A019764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019764.Bytes);
public long this[int i]=>Value[i];

public static A019764Inst Instance=new A019764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019763
{
public static readonly long[] Value={ 1L,8L,1L,2L,1L,8L,7L,8L,8L,5L,6L,3L,9L,3L,6L,3L,4L,9L,0L,2L,4L,0L,1L,9L,1L,6L,4L,7L,5L,6L,8L,4L,4L,1L,6L,6L,5L,1L,7L,1L,4L,9L,8L,0L,6L,2L,4L,6L,6L,6L,3L,9L,7L,1L,6L,6L,4L,4L,6L,4L,5L,0L,8L,5L,1L,4L,9L,3L,8L,4L,4L,2L,0L,2L,3L,5L,6L,9L,8L,3L,9L,6L,3L,8L,0L,9L,2L,1L,4L,5L,2L,3L,5L,0L,1L,1L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019763Inst : IEnumerable<long>
{
public static readonly long[] Value=A019763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019763.Bytes);
public long this[int i]=>Value[i];

public static A019763Inst Instance=new A019763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019762
{
public static readonly long[] Value={ 5L,4L,3L,6L,5L,6L,3L,6L,5L,6L,9L,1L,8L,0L,9L,0L,4L,7L,0L,7L,2L,0L,5L,7L,4L,9L,4L,2L,7L,0L,5L,3L,2L,4L,9L,9L,5L,5L,1L,4L,4L,9L,4L,1L,8L,7L,3L,9L,9L,9L,1L,9L,1L,4L,9L,9L,3L,3L,9L,3L,5L,2L,5L,5L,4L,4L,8L,1L,5L,3L,2L,6L,0L,7L,0L,7L,0L,9L,5L,1L,8L,9L,1L,4L,2L,7L,6L,4L,3L,5L,7L,0L,5L,0L,3L,3L,2L,8L,5L,4L,8L,5L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019762Inst : IEnumerable<long>
{
public static readonly long[] Value=A019762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019762.Bytes);
public long this[int i]=>Value[i];

public static A019762Inst Instance=new A019762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019761
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,1L,7L,4L,2L,8L,5L,2L,4L,6L,0L,2L,1L,8L,1L,4L,0L,0L,1L,1L,9L,7L,7L,9L,7L,3L,0L,2L,7L,6L,0L,4L,0L,7L,3L,2L,1L,8L,6L,2L,8L,9L,0L,4L,1L,6L,4L,9L,8L,2L,2L,9L,0L,2L,9L,0L,3L,1L,7L,8L,2L,1L,8L,3L,6L,5L,2L,6L,2L,6L,4L,7L,3L,1L,1L,4L,9L,7L,7L,3L,8L,0L,7L,5L,9L,0L,7L,7L,1L,8L,8L,1L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019761Inst : IEnumerable<long>
{
public static readonly long[] Value=A019761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019761.Bytes);
public long this[int i]=>Value[i];

public static A019761Inst Instance=new A019761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019760
{
public static readonly long[] Value={ 1L,1L,8L,1L,8L,6L,1L,6L,6L,4L,5L,4L,7L,4L,1L,0L,9L,7L,1L,8L,9L,5L,7L,7L,7L,1L,6L,1L,4L,5L,7L,6L,7L,9L,3L,4L,6L,8L,5L,0L,9L,7L,6L,9L,9L,7L,2L,6L,0L,8L,5L,1L,9L,8L,9L,1L,1L,6L,0L,7L,2L,8L,8L,1L,6L,1L,9L,1L,6L,3L,7L,5L,2L,3L,2L,7L,6L,2L,9L,3L,8L,8L,9L,4L,4L,0L,7L,9L,2L,0L,8L,0L,5L,4L,4L,2L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019760Inst : IEnumerable<long>
{
public static readonly long[] Value=A019760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019760.Bytes);
public long this[int i]=>Value[i];

public static A019760Inst Instance=new A019760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019759
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,8L,2L,6L,4L,9L,2L,9L,9L,5L,6L,6L,0L,1L,6L,0L,7L,2L,8L,5L,7L,9L,4L,1L,5L,2L,3L,9L,3L,7L,4L,9L,8L,9L,8L,0L,5L,6L,6L,8L,6L,0L,7L,7L,2L,7L,0L,8L,8L,9L,7L,7L,1L,2L,2L,5L,8L,0L,1L,2L,6L,0L,1L,8L,5L,3L,0L,1L,3L,7L,9L,7L,0L,6L,7L,0L,8L,8L,4L,4L,1L,5L,3L,7L,3L,5L,3L,8L,7L,5L,0L,7L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019759Inst : IEnumerable<long>
{
public static readonly long[] Value=A019759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019759.Bytes);
public long this[int i]=>Value[i];

public static A019759Inst Instance=new A019759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019758
{
public static readonly long[] Value={ 1L,2L,9L,4L,4L,1L,9L,9L,1L,8L,3L,1L,3L,8L,3L,1L,0L,6L,4L,4L,5L,7L,2L,7L,9L,7L,4L,8L,2L,6L,3L,1L,7L,2L,6L,1L,7L,9L,7L,9L,6L,4L,1L,4L,7L,3L,1L,9L,0L,4L,5L,6L,9L,4L,0L,4L,6L,0L,4L,6L,0L,7L,7L,5L,1L,0L,6L,7L,0L,3L,1L,5L,7L,3L,1L,1L,2L,1L,3L,1L,4L,0L,2L,7L,2L,0L,8L,6L,7L,5L,1L,6L,7L,8L,6L,5L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019758Inst : IEnumerable<long>
{
public static readonly long[] Value=A019758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019758.Bytes);
public long this[int i]=>Value[i];

public static A019758Inst Instance=new A019758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019741
{
public static readonly long[] Value={ 6L,7L,9L,5L,7L,0L,4L,5L,7L,1L,1L,4L,7L,6L,1L,3L,0L,8L,8L,4L,0L,0L,7L,1L,8L,6L,7L,8L,3L,8L,1L,6L,5L,6L,2L,4L,4L,3L,9L,3L,1L,1L,7L,7L,3L,4L,2L,4L,9L,8L,9L,8L,9L,3L,7L,4L,1L,7L,4L,1L,9L,0L,6L,9L,3L,1L,0L,1L,9L,1L,5L,7L,5L,8L,8L,3L,8L,6L,8L,9L,8L,6L,4L,2L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019741Inst : IEnumerable<long>
{
public static readonly long[] Value=A019741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019741.Bytes);
public long this[int i]=>Value[i];

public static A019741Inst Instance=new A019741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019740
{
public static readonly long[] Value={ 9L,0L,6L,0L,9L,3L,9L,4L,2L,8L,1L,9L,6L,8L,1L,7L,4L,5L,1L,2L,0L,0L,9L,5L,8L,2L,3L,7L,8L,4L,2L,2L,0L,8L,3L,2L,5L,8L,5L,7L,4L,9L,0L,3L,1L,2L,3L,3L,3L,1L,9L,8L,5L,8L,3L,2L,2L,3L,2L,2L,5L,4L,2L,5L,7L,4L,6L,9L,2L,2L,1L,0L,1L,1L,7L,8L,4L,9L,1L,9L,8L,1L,9L,0L,4L,6L,0L,7L,2L,6L,1L,7L,5L,0L,5L,5L,4L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019740Inst : IEnumerable<long>
{
public static readonly long[] Value=A019740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019740.Bytes);
public long this[int i]=>Value[i];

public static A019740Inst Instance=new A019740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019739
{
public static readonly long[] Value={ 1L,3L,5L,9L,1L,4L,0L,9L,1L,4L,2L,2L,9L,5L,2L,2L,6L,1L,7L,6L,8L,0L,1L,4L,3L,7L,3L,5L,6L,7L,6L,3L,3L,1L,2L,4L,8L,8L,7L,8L,6L,2L,3L,5L,4L,6L,8L,4L,9L,9L,7L,9L,7L,8L,7L,4L,8L,3L,4L,8L,3L,8L,1L,3L,8L,6L,2L,0L,3L,8L,3L,1L,5L,1L,7L,6L,7L,7L,3L,7L,9L,7L,2L,8L,5L,6L,9L,1L,0L,8L,9L,2L,6L,2L,5L,8L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019739Inst : IEnumerable<long>
{
public static readonly long[] Value=A019739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019739.Bytes);
public long this[int i]=>Value[i];

public static A019739Inst Instance=new A019739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019738
{
public static readonly long[] Value={ 1L,0L,8L,9L,8L,3L,8L,3L,8L,0L,2L,7L,4L,3L,4L,8L,0L,4L,4L,5L,2L,8L,5L,9L,3L,6L,0L,2L,0L,9L,1L,7L,5L,8L,8L,0L,5L,6L,5L,5L,2L,1L,1L,6L,2L,6L,3L,5L,2L,1L,4L,7L,0L,9L,4L,1L,8L,6L,9L,2L,3L,2L,9L,4L,0L,6L,1L,8L,6L,6L,8L,0L,6L,3L,5L,1L,2L,3L,5L,6L,4L,1L,2L,8L,1L,1L,2L,8L,6L,2L,5L,3L,8L,1L,7L,6L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019738Inst : IEnumerable<long>
{
public static readonly long[] Value=A019738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019738.Bytes);
public long this[int i]=>Value[i];

public static A019738Inst Instance=new A019738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019737
{
public static readonly long[] Value={ 1L,1L,9L,3L,6L,3L,2L,5L,1L,1L,7L,2L,9L,0L,4L,7L,8L,5L,8L,2L,9L,3L,2L,2L,1L,5L,6L,4L,1L,9L,5L,7L,3L,5L,8L,3L,4L,7L,6L,5L,2L,3L,1L,7L,8L,1L,2L,4L,2L,8L,2L,7L,7L,6L,9L,8L,2L,3L,7L,7L,3L,1L,3L,1L,5L,9L,1L,5L,6L,8L,4L,0L,6L,9L,5L,6L,1L,1L,5L,2L,2L,6L,1L,6L,5L,0L,4L,5L,6L,3L,7L,3L,2L,2L,8L,8L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019737Inst : IEnumerable<long>
{
public static readonly long[] Value=A019737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019737.Bytes);
public long this[int i]=>Value[i];

public static A019737Inst Instance=new A019737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019736
{
public static readonly long[] Value={ 1L,3L,1L,9L,2L,7L,8L,0L,3L,9L,2L,7L,9L,4L,7L,3L,9L,4L,8L,6L,3L,9L,8L,7L,6L,4L,6L,5L,6L,9L,0L,0L,2L,3L,8L,1L,7L,3L,7L,2L,0L,9L,8L,2L,8L,4L,5L,3L,1L,5L,4L,6L,4L,8L,2L,4L,3L,6L,8L,0L,1L,8L,8L,2L,2L,8L,5L,4L,1L,7L,7L,1L,2L,9L,5L,1L,4L,9L,5L,7L,7L,6L,2L,8L,7L,6L,8L,2L,0L,2L,0L,1L,9L,8L,9L,7L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019736Inst : IEnumerable<long>
{
public static readonly long[] Value=A019736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019736.Bytes);
public long this[int i]=>Value[i];

public static A019736Inst Instance=new A019736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019735
{
public static readonly long[] Value={ 1L,4L,7L,4L,4L,8L,7L,2L,2L,0L,3L,7L,1L,1L,7L,6L,7L,6L,6L,1L,2L,6L,9L,2L,0L,7L,5L,5L,7L,7L,1L,2L,0L,3L,0L,9L,0L,0L,0L,4L,1L,0L,9L,8L,4L,7L,4L,1L,7L,6L,1L,0L,7L,7L,4L,4L,8L,8L,1L,9L,0L,3L,3L,9L,0L,2L,4L,8L,7L,8L,6L,2L,0L,3L,5L,7L,5L,5L,4L,1L,0L,2L,9L,0L,9L,7L,6L,2L,2L,5L,7L,8L,6L,9L,4L,4L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019735Inst : IEnumerable<long>
{
public static readonly long[] Value=A019735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019735.Bytes);
public long this[int i]=>Value[i];

public static A019735Inst Instance=new A019735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019734
{
public static readonly long[] Value={ 1L,6L,7L,1L,0L,8L,5L,5L,1L,6L,4L,2L,0L,6L,6L,7L,0L,0L,1L,6L,1L,0L,5L,1L,0L,1L,8L,9L,8L,7L,4L,0L,3L,0L,1L,6L,8L,6L,7L,1L,3L,2L,4L,4L,9L,3L,7L,3L,9L,9L,5L,8L,8L,7L,7L,7L,5L,3L,2L,8L,2L,3L,8L,4L,2L,2L,8L,1L,9L,5L,7L,6L,9L,7L,3L,8L,5L,6L,1L,3L,1L,6L,6L,3L,1L,0L,6L,3L,8L,9L,2L,2L,5L,2L,0L,3L,8L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019734Inst : IEnumerable<long>
{
public static readonly long[] Value=A019734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019734.Bytes);
public long this[int i]=>Value[i];

public static A019734Inst Instance=new A019734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019733
{
public static readonly long[] Value={ 1L,9L,2L,8L,1L,7L,5L,5L,9L,5L,8L,7L,0L,0L,0L,0L,3L,8L,6L,4L,7L,3L,6L,6L,5L,6L,0L,3L,7L,0L,0L,8L,0L,4L,0L,4L,0L,7L,7L,4L,6L,0L,5L,1L,8L,5L,0L,8L,4L,5L,6L,7L,9L,3L,5L,8L,6L,9L,1L,7L,1L,9L,8L,1L,8L,0L,1L,7L,6L,4L,3L,4L,9L,6L,9L,8L,3L,3L,9L,9L,8L,0L,7L,2L,8L,1L,5L,0L,6L,4L,4L,9L,0L,6L,1L,9L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019733Inst : IEnumerable<long>
{
public static readonly long[] Value=A019733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019733.Bytes);
public long this[int i]=>Value[i];

public static A019733Inst Instance=new A019733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019732
{
public static readonly long[] Value={ 2L,2L,7L,8L,7L,5L,2L,9L,7L,6L,9L,3L,7L,2L,7L,3L,1L,8L,4L,0L,1L,4L,3L,3L,2L,0L,7L,7L,1L,0L,0L,9L,5L,0L,2L,3L,0L,0L,0L,6L,3L,5L,1L,5L,8L,2L,3L,7L,2L,6L,7L,1L,1L,9L,6L,9L,3L,6L,2L,9L,4L,1L,6L,0L,3L,1L,1L,1L,7L,6L,0L,4L,9L,6L,4L,3L,4L,9L,2L,7L,0L,4L,4L,9L,6L,9L,0L,5L,3L,0L,7L,6L,1L,6L,4L,1L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019732Inst : IEnumerable<long>
{
public static readonly long[] Value=A019732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019732.Bytes);
public long this[int i]=>Value[i];

public static A019732Inst Instance=new A019732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019731
{
public static readonly long[] Value={ 2L,7L,8L,5L,1L,4L,2L,5L,2L,7L,3L,6L,7L,7L,7L,8L,3L,3L,6L,0L,1L,7L,5L,1L,6L,9L,8L,3L,1L,2L,3L,3L,8L,3L,6L,1L,4L,4L,5L,2L,2L,0L,7L,4L,8L,9L,5L,6L,6L,5L,9L,8L,1L,2L,9L,5L,8L,8L,8L,0L,3L,9L,7L,3L,7L,1L,3L,6L,5L,9L,6L,1L,6L,2L,3L,0L,9L,3L,5L,5L,2L,7L,7L,1L,8L,4L,3L,9L,8L,2L,0L,4L,2L,0L,0L,6L,3L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019731Inst : IEnumerable<long>
{
public static readonly long[] Value=A019731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019731.Bytes);
public long this[int i]=>Value[i];

public static A019731Inst Instance=new A019731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019730
{
public static readonly long[] Value={ 3L,5L,8L,0L,8L,9L,7L,5L,3L,5L,1L,8L,7L,1L,4L,3L,5L,7L,4L,8L,7L,9L,6L,6L,4L,6L,9L,2L,5L,8L,7L,2L,0L,7L,5L,0L,4L,2L,9L,5L,6L,9L,5L,3L,4L,3L,7L,2L,8L,4L,8L,3L,3L,0L,9L,4L,7L,1L,3L,1L,9L,3L,9L,4L,7L,7L,4L,7L,0L,5L,2L,2L,0L,8L,6L,8L,3L,4L,5L,6L,7L,8L,4L,9L,5L,1L,3L,6L,9L,1L,1L,9L,6L,8L,6L,5L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019730Inst : IEnumerable<long>
{
public static readonly long[] Value=A019730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019730.Bytes);
public long this[int i]=>Value[i];

public static A019730Inst Instance=new A019730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019729
{
public static readonly long[] Value={ 5L,0L,1L,3L,2L,5L,6L,5L,4L,9L,2L,6L,2L,0L,0L,1L,0L,0L,4L,8L,3L,1L,5L,3L,0L,5L,6L,9L,6L,2L,2L,0L,9L,0L,5L,0L,6L,0L,1L,3L,9L,7L,3L,4L,8L,1L,2L,1L,9L,8L,7L,6L,6L,3L,3L,2L,5L,9L,8L,4L,7L,1L,5L,2L,6L,8L,4L,5L,8L,7L,3L,0L,9L,2L,1L,5L,6L,8L,3L,9L,4L,9L,8L,9L,3L,1L,9L,1L,6L,7L,6L,7L,5L,6L,1L,1L,4L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019729Inst : IEnumerable<long>
{
public static readonly long[] Value=A019729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019729.Bytes);
public long this[int i]=>Value[i];

public static A019729Inst Instance=new A019729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019728
{
public static readonly long[] Value={ 8L,3L,5L,5L,4L,2L,7L,5L,8L,2L,1L,0L,3L,3L,3L,5L,0L,0L,8L,0L,5L,2L,5L,5L,0L,9L,4L,9L,3L,7L,0L,1L,5L,0L,8L,4L,3L,3L,5L,6L,6L,2L,2L,4L,6L,8L,6L,9L,9L,7L,9L,4L,3L,8L,8L,7L,6L,6L,4L,1L,1L,9L,2L,1L,1L,4L,0L,9L,7L,8L,8L,4L,8L,6L,9L,2L,8L,0L,6L,5L,8L,3L,1L,5L,5L,3L,1L,9L,4L,6L,1L,2L,6L,0L,1L,9L,0L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019728Inst : IEnumerable<long>
{
public static readonly long[] Value=A019728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019728.Bytes);
public long this[int i]=>Value[i];

public static A019728Inst Instance=new A019728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019727
{
public static readonly long[] Value={ 2L,5L,0L,6L,6L,2L,8L,2L,7L,4L,6L,3L,1L,0L,0L,0L,5L,0L,2L,4L,1L,5L,7L,6L,5L,2L,8L,4L,8L,1L,1L,0L,4L,5L,2L,5L,3L,0L,0L,6L,9L,8L,6L,7L,4L,0L,6L,0L,9L,9L,3L,8L,3L,1L,6L,6L,2L,9L,9L,2L,3L,5L,7L,6L,3L,4L,2L,2L,9L,3L,6L,5L,4L,6L,0L,7L,8L,4L,1L,9L,7L,4L,9L,4L,6L,5L,9L,5L,8L,3L,8L,3L,7L,8L,0L,5L,7L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019727Inst : IEnumerable<long>
{
public static readonly long[] Value=A019727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019727.Bytes);
public long this[int i]=>Value[i];

public static A019727Inst Instance=new A019727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019726
{
public static readonly long[] Value={ 7L,3L,8L,5L,2L,2L,4L,3L,7L,8L,7L,7L,2L,9L,8L,3L,4L,4L,7L,0L,7L,5L,6L,9L,7L,8L,4L,7L,2L,5L,4L,7L,7L,1L,5L,9L,4L,9L,8L,9L,7L,8L,9L,4L,0L,0L,5L,0L,9L,9L,4L,6L,3L,6L,7L,5L,5L,7L,5L,3L,2L,4L,5L,7L,7L,2L,0L,4L,6L,3L,6L,8L,5L,7L,9L,5L,9L,6L,7L,4L,2L,2L,3L,9L,5L,6L,2L,7L,7L,3L,6L,4L,1L,0L,6L,0L,2L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019726Inst : IEnumerable<long>
{
public static readonly long[] Value=A019726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019726.Bytes);
public long this[int i]=>Value[i];

public static A019726Inst Instance=new A019726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019725
{
public static readonly long[] Value={ 7L,7L,0L,6L,3L,2L,1L,0L,9L,0L,8L,9L,3L,5L,4L,7L,9L,4L,4L,7L,7L,4L,6L,4L,1L,2L,3L,1L,9L,1L,8L,0L,2L,2L,5L,3L,3L,9L,0L,2L,3L,8L,8L,9L,3L,9L,6L,6L,2L,5L,5L,2L,7L,3L,1L,3L,6L,4L,3L,8L,1L,6L,9L,5L,0L,1L,2L,6L,5L,7L,7L,5L,9L,0L,9L,1L,4L,4L,4L,2L,6L,6L,8L,4L,7L,6L,1L,1L,5L,5L,1L,0L,3L,7L,1L,5L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019725Inst : IEnumerable<long>
{
public static readonly long[] Value=A019725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019725.Bytes);
public long this[int i]=>Value[i];

public static A019725Inst Instance=new A019725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019724
{
public static readonly long[] Value={ 8L,0L,5L,6L,6L,0L,8L,4L,1L,3L,2L,0L,6L,8L,9L,1L,0L,3L,3L,1L,7L,3L,4L,8L,8L,5L,6L,0L,6L,4L,1L,5L,6L,9L,0L,1L,2L,7L,1L,6L,1L,3L,3L,8L,9L,1L,4L,6L,5L,3L,9L,6L,0L,3L,7L,3L,3L,5L,4L,8L,9L,9L,5L,3L,8L,7L,6L,8L,6L,9L,4L,7L,5L,4L,1L,3L,7L,8L,2L,6L,4L,2L,6L,1L,3L,4L,1L,2L,0L,7L,6L,0L,8L,4L,2L,9L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019724Inst : IEnumerable<long>
{
public static readonly long[] Value=A019724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019724.Bytes);
public long this[int i]=>Value[i];

public static A019724Inst Instance=new A019724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019723
{
public static readonly long[] Value={ 8L,4L,4L,0L,2L,5L,6L,4L,3L,2L,8L,8L,3L,4L,0L,9L,6L,5L,3L,8L,0L,0L,7L,9L,7L,5L,3L,9L,7L,1L,9L,7L,3L,8L,9L,6L,5L,7L,0L,2L,6L,1L,6L,4L,5L,7L,7L,2L,5L,6L,5L,2L,9L,9L,1L,4L,9L,4L,3L,2L,2L,8L,0L,8L,8L,2L,3L,3L,8L,7L,0L,6L,9L,4L,8L,1L,1L,0L,5L,6L,2L,5L,5L,9L,5L,0L,0L,3L,1L,2L,7L,3L,2L,6L,4L,0L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019723Inst : IEnumerable<long>
{
public static readonly long[] Value=A019723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019723.Bytes);
public long this[int i]=>Value[i];

public static A019723Inst Instance=new A019723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019722
{
public static readonly long[] Value={ 1L,25L,433L,6457L,89089L,1174537L,15047761L,189169369L,2347464097L,28866716329L,352675969009L,4288594179961L,51971489903425L,628233183645001L,7579976215410577L,91330317763703833L,1099299246068405473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019722Inst : IEnumerable<long>
{
public static readonly long[] Value=A019722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019722.Bytes);
public long this[int i]=>Value[i];

public static A019722Inst Instance=new A019722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019721
{
public static readonly long[] Value={ 9L,3L,2L,8L,7L,0L,4L,4L,7L,8L,4L,5L,0L,0L,8L,4L,3L,5L,4L,2L,0L,0L,8L,8L,1L,4L,9L,1L,2L,6L,9L,1L,8L,5L,1L,7L,2L,6L,1L,8L,6L,8L,1L,3L,4L,8L,0L,1L,2L,5L,6L,3L,8L,3L,2L,7L,0L,4L,2L,5L,1L,5L,2L,5L,5L,4L,1L,6L,3L,8L,3L,3L,9L,9L,5L,2L,8L,0L,0L,9L,5L,4L,6L,0L,5L,0L,0L,3L,4L,5L,6L,5L,1L,8L,6L,5L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019721Inst : IEnumerable<long>
{
public static readonly long[] Value=A019721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019721.Bytes);
public long this[int i]=>Value[i];

public static A019721Inst Instance=new A019721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019720
{
public static readonly long[] Value={ 9L,8L,4L,6L,9L,6L,5L,8L,3L,8L,3L,6L,3L,9L,7L,7L,9L,2L,9L,4L,3L,4L,2L,6L,3L,7L,9L,6L,3L,3L,9L,6L,9L,5L,4L,5L,9L,9L,8L,6L,3L,8L,5L,8L,6L,7L,3L,4L,6L,5L,9L,5L,1L,5L,6L,7L,4L,3L,3L,7L,6L,6L,1L,0L,2L,9L,3L,9L,5L,1L,5L,8L,1L,0L,6L,1L,2L,8L,9L,8L,9L,6L,5L,2L,7L,5L,0L,3L,6L,4L,8L,5L,4L,7L,4L,7L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019720Inst : IEnumerable<long>
{
public static readonly long[] Value=A019720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019720.Bytes);
public long this[int i]=>Value[i];

public static A019720Inst Instance=new A019720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019719
{
public static readonly long[] Value={ 1L,0L,4L,2L,6L,1L,9L,9L,1L,2L,2L,9L,7L,3L,6L,2L,3L,6L,8L,9L,9L,8L,9L,2L,2L,0L,4L,9L,0L,2L,4L,2L,0L,3L,0L,4L,8L,7L,0L,4L,4L,4L,0L,8L,5L,6L,5L,4L,2L,5L,8L,0L,6L,6L,3L,6L,5L,5L,1L,8L,1L,0L,5L,2L,8L,5L,4L,6L,5L,3L,6L,9L,6L,8L,1L,8L,2L,5L,4L,2L,2L,4L,3L,3L,8L,2L,0L,6L,2L,6L,8L,6L,6L,9L,7L,3L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019719Inst : IEnumerable<long>
{
public static readonly long[] Value=A019719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019719.Bytes);
public long this[int i]=>Value[i];

public static A019719Inst Instance=new A019719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019718
{
public static readonly long[] Value={ 1L,1L,0L,7L,7L,8L,3L,6L,5L,6L,8L,1L,5L,9L,4L,7L,5L,1L,7L,0L,6L,1L,3L,5L,4L,6L,7L,7L,0L,8L,8L,2L,1L,5L,7L,3L,9L,2L,4L,8L,4L,6L,8L,4L,1L,0L,0L,7L,6L,4L,9L,1L,9L,5L,5L,1L,3L,3L,6L,2L,9L,8L,6L,8L,6L,5L,8L,0L,6L,9L,5L,5L,2L,8L,6L,9L,3L,9L,5L,1L,1L,3L,3L,5L,9L,3L,4L,4L,1L,6L,0L,4L,6L,1L,5L,9L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019718Inst : IEnumerable<long>
{
public static readonly long[] Value=A019718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019718.Bytes);
public long this[int i]=>Value[i];

public static A019718Inst Instance=new A019718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019717
{
public static readonly long[] Value={ 1L,1L,8L,1L,6L,3L,5L,9L,0L,0L,6L,0L,3L,6L,7L,7L,3L,5L,1L,5L,3L,2L,1L,1L,1L,6L,5L,5L,5L,6L,0L,7L,6L,3L,4L,5L,5L,1L,9L,8L,3L,6L,6L,3L,0L,4L,0L,8L,1L,5L,9L,1L,4L,1L,8L,8L,0L,9L,2L,0L,5L,1L,9L,3L,2L,3L,5L,2L,7L,4L,1L,8L,9L,7L,2L,7L,3L,5L,4L,7L,8L,7L,5L,8L,3L,3L,0L,0L,4L,3L,7L,8L,2L,5L,6L,9L,6L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019717Inst : IEnumerable<long>
{
public static readonly long[] Value=A019717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019717.Bytes);
public long this[int i]=>Value[i];

public static A019717Inst Instance=new A019717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019716
{
public static readonly long[] Value={ 1L,2L,6L,6L,0L,3L,8L,4L,6L,4L,9L,3L,2L,5L,1L,1L,4L,4L,8L,0L,7L,0L,1L,1L,9L,6L,3L,0L,9L,5L,7L,9L,6L,0L,8L,4L,4L,8L,5L,5L,3L,9L,2L,4L,6L,8L,6L,5L,8L,8L,4L,7L,9L,4L,8L,7L,2L,4L,1L,4L,8L,4L,2L,1L,3L,2L,3L,5L,0L,8L,0L,6L,0L,4L,2L,2L,1L,6L,5L,8L,4L,3L,8L,3L,9L,2L,5L,0L,4L,6L,9L,0L,9L,8L,9L,6L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019716Inst : IEnumerable<long>
{
public static readonly long[] Value=A019716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019716.Bytes);
public long this[int i]=>Value[i];

public static A019716Inst Instance=new A019716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019715
{
public static readonly long[] Value={ 1L,3L,6L,3L,4L,2L,6L,0L,3L,9L,1L,5L,8L,0L,8L,9L,2L,5L,1L,7L,6L,7L,8L,2L,1L,1L,4L,1L,0L,3L,1L,6L,5L,0L,1L,4L,0L,6L,1L,3L,4L,9L,9L,5L,8L,1L,6L,3L,2L,6L,0L,5L,4L,8L,3L,2L,4L,1L,3L,9L,0L,6L,0L,7L,5L,7L,9L,1L,6L,2L,5L,2L,6L,6L,0L,8L,4L,8L,6L,2L,9L,3L,3L,6L,5L,3L,4L,6L,6L,5L,9L,0L,2L,9L,6L,4L,9L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019715Inst : IEnumerable<long>
{
public static readonly long[] Value=A019715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019715.Bytes);
public long this[int i]=>Value[i];

public static A019715Inst Instance=new A019715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019714
{
public static readonly long[] Value={ 1L,4L,7L,7L,0L,4L,4L,8L,7L,5L,7L,5L,4L,5L,9L,6L,6L,8L,9L,4L,1L,5L,1L,3L,9L,5L,6L,9L,4L,5L,0L,9L,5L,4L,3L,1L,8L,9L,9L,7L,9L,5L,7L,8L,8L,0L,1L,0L,1L,9L,8L,9L,2L,7L,3L,5L,1L,1L,5L,0L,6L,4L,9L,1L,5L,4L,4L,0L,9L,2L,7L,3L,7L,1L,5L,9L,1L,9L,3L,4L,8L,4L,4L,7L,9L,1L,2L,5L,5L,4L,7L,2L,8L,2L,1L,2L,0L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019714Inst : IEnumerable<long>
{
public static readonly long[] Value=A019714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019714.Bytes);
public long this[int i]=>Value[i];

public static A019714Inst Instance=new A019714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019713
{
public static readonly long[] Value={ 1L,6L,1L,1L,3L,2L,1L,6L,8L,2L,6L,4L,1L,3L,7L,8L,2L,0L,6L,6L,3L,4L,6L,9L,7L,7L,1L,2L,1L,2L,8L,3L,1L,3L,8L,0L,2L,5L,4L,3L,2L,2L,6L,7L,7L,8L,2L,9L,3L,0L,7L,9L,2L,0L,7L,4L,6L,7L,0L,9L,7L,9L,9L,0L,7L,7L,5L,3L,7L,3L,8L,9L,5L,0L,8L,2L,7L,5L,6L,5L,2L,8L,5L,2L,2L,6L,8L,2L,4L,1L,5L,2L,1L,6L,8L,5L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019713Inst : IEnumerable<long>
{
public static readonly long[] Value=A019713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019713.Bytes);
public long this[int i]=>Value[i];

public static A019713Inst Instance=new A019713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019712
{
public static readonly long[] Value={ 1L,1L,5L,4L,2L,305L,1L,8L,2L,1L,4L,6L,14L,3L,1L,13L,5L,1L,7L,23L,1L,16L,4L,1L,1L,1L,1L,1L,2L,17L,1L,3L,1L,1L,1L,29L,1L,6L,1L,3L,1L,1L,1L,1L,3L,2L,5L,1L,63L,2L,1L,2L,5L,1L,4L,11L,2L,2L,1L,1L,1L,1L,1L,2L,1L,9L,3L,3L,18L,1L,38L,2L,4L,1L,20L,3L,1L,1L,1L,5L,2L,2L,1L,1L,1L,44L,6L,3L,9L,1L,1L,1L,1L,3L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019712Inst : IEnumerable<long>
{
public static readonly long[] Value=A019712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019712.Bytes);
public long this[int i]=>Value[i];

public static A019712Inst Instance=new A019712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019711
{
public static readonly long[] Value={ 1L,9L,6L,9L,3L,9L,3L,1L,6L,7L,6L,7L,2L,7L,9L,5L,5L,8L,5L,8L,8L,6L,8L,5L,2L,7L,5L,9L,2L,6L,7L,9L,3L,9L,0L,9L,1L,9L,9L,7L,2L,7L,7L,1L,7L,3L,4L,6L,9L,3L,1L,9L,0L,3L,1L,3L,4L,8L,6L,7L,5L,3L,2L,2L,0L,5L,8L,7L,9L,0L,3L,1L,6L,2L,1L,2L,2L,5L,7L,9L,7L,9L,3L,0L,5L,5L,0L,0L,7L,2L,9L,7L,0L,9L,4L,9L,4L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019711Inst : IEnumerable<long>
{
public static readonly long[] Value=A019711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019711.Bytes);
public long this[int i]=>Value[i];

public static A019711Inst Instance=new A019711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019710
{
public static readonly long[] Value={ 2L,2L,1L,5L,5L,6L,7L,3L,1L,3L,6L,3L,1L,8L,9L,5L,0L,3L,4L,1L,2L,2L,7L,0L,9L,3L,5L,4L,1L,7L,6L,4L,3L,1L,4L,7L,8L,4L,9L,6L,9L,3L,6L,8L,2L,0L,1L,5L,2L,9L,8L,3L,9L,1L,0L,2L,6L,7L,2L,5L,9L,7L,3L,7L,3L,1L,6L,1L,3L,9L,1L,0L,5L,7L,3L,8L,7L,9L,0L,2L,2L,6L,7L,1L,8L,6L,8L,8L,3L,2L,0L,9L,2L,3L,1L,8L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019710Inst : IEnumerable<long>
{
public static readonly long[] Value=A019710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019710.Bytes);
public long this[int i]=>Value[i];

public static A019710Inst Instance=new A019710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019709
{
public static readonly long[] Value={ 2L,5L,3L,2L,0L,7L,6L,9L,2L,9L,8L,6L,5L,0L,2L,2L,8L,9L,6L,1L,4L,0L,2L,3L,9L,2L,6L,1L,9L,1L,5L,9L,2L,1L,6L,8L,9L,7L,1L,0L,7L,8L,4L,9L,3L,7L,3L,1L,7L,6L,9L,5L,8L,9L,7L,4L,4L,8L,2L,9L,6L,8L,4L,2L,6L,4L,7L,0L,1L,6L,1L,2L,0L,8L,4L,4L,3L,3L,1L,6L,8L,7L,6L,7L,8L,5L,0L,0L,9L,3L,8L,1L,9L,7L,9L,2L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019709Inst : IEnumerable<long>
{
public static readonly long[] Value=A019709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019709.Bytes);
public long this[int i]=>Value[i];

public static A019709Inst Instance=new A019709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019708
{
public static readonly long[] Value={ 2L,9L,5L,4L,0L,8L,9L,7L,5L,1L,5L,0L,9L,1L,9L,3L,3L,7L,8L,8L,3L,0L,2L,7L,9L,1L,3L,8L,9L,0L,1L,9L,0L,8L,6L,3L,7L,9L,9L,5L,9L,1L,5L,7L,6L,0L,2L,0L,3L,9L,7L,8L,5L,4L,7L,0L,2L,3L,0L,1L,2L,9L,8L,3L,0L,8L,8L,1L,8L,5L,4L,7L,4L,3L,1L,8L,3L,8L,6L,9L,6L,8L,9L,5L,8L,2L,5L,1L,0L,9L,4L,5L,6L,4L,2L,4L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019708Inst : IEnumerable<long>
{
public static readonly long[] Value=A019708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019708.Bytes);
public long this[int i]=>Value[i];

public static A019708Inst Instance=new A019708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019707
{
public static readonly long[] Value={ 3L,5L,4L,4L,9L,0L,7L,7L,0L,1L,8L,1L,1L,0L,3L,2L,0L,5L,4L,5L,9L,6L,3L,3L,4L,9L,6L,6L,6L,8L,2L,2L,9L,0L,3L,6L,5L,5L,9L,5L,0L,9L,8L,9L,1L,2L,2L,4L,4L,7L,7L,4L,2L,5L,6L,4L,2L,7L,6L,1L,5L,5L,7L,9L,7L,0L,5L,8L,2L,2L,5L,6L,9L,1L,8L,2L,0L,6L,4L,3L,6L,2L,7L,4L,9L,9L,0L,1L,3L,1L,3L,4L,7L,7L,0L,8L,9L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019707Inst : IEnumerable<long>
{
public static readonly long[] Value=A019707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019707.Bytes);
public long this[int i]=>Value[i];

public static A019707Inst Instance=new A019707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019706
{
public static readonly long[] Value={ 4L,4L,3L,1L,1L,3L,4L,6L,2L,7L,2L,6L,3L,7L,9L,0L,0L,6L,8L,2L,4L,5L,4L,1L,8L,7L,0L,8L,3L,5L,2L,8L,6L,2L,9L,5L,6L,9L,9L,3L,8L,7L,3L,6L,4L,0L,3L,0L,5L,9L,6L,7L,8L,2L,0L,5L,3L,4L,5L,1L,9L,4L,7L,4L,6L,3L,2L,2L,7L,8L,2L,1L,1L,4L,7L,7L,5L,8L,0L,4L,5L,3L,4L,3L,7L,3L,7L,6L,6L,4L,1L,8L,4L,6L,3L,6L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019706Inst : IEnumerable<long>
{
public static readonly long[] Value=A019706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019706.Bytes);
public long this[int i]=>Value[i];

public static A019706Inst Instance=new A019706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019705
{
public static readonly long[] Value={ 5L,9L,0L,8L,1L,7L,9L,5L,0L,3L,0L,1L,8L,3L,8L,6L,7L,5L,7L,6L,6L,0L,5L,5L,8L,2L,7L,7L,8L,0L,3L,8L,1L,7L,2L,7L,5L,9L,9L,1L,8L,3L,1L,5L,2L,0L,4L,0L,7L,9L,5L,7L,0L,9L,4L,0L,4L,6L,0L,2L,5L,9L,6L,6L,1L,7L,6L,3L,7L,0L,9L,4L,8L,6L,3L,6L,7L,7L,3L,9L,3L,7L,9L,1L,6L,5L,0L,2L,1L,8L,9L,1L,2L,8L,4L,8L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019705Inst : IEnumerable<long>
{
public static readonly long[] Value=A019705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019705.Bytes);
public long this[int i]=>Value[i];

public static A019705Inst Instance=new A019705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019704
{
public static readonly long[] Value={ 8L,8L,6L,2L,2L,6L,9L,2L,5L,4L,5L,2L,7L,5L,8L,0L,1L,3L,6L,4L,9L,0L,8L,3L,7L,4L,1L,6L,7L,0L,5L,7L,2L,5L,9L,1L,3L,9L,8L,7L,7L,4L,7L,2L,8L,0L,6L,1L,1L,9L,3L,5L,6L,4L,1L,0L,6L,9L,0L,3L,8L,9L,4L,9L,2L,6L,4L,5L,5L,6L,4L,2L,2L,9L,5L,5L,1L,6L,0L,9L,0L,6L,8L,7L,4L,7L,5L,3L,2L,8L,3L,6L,9L,2L,7L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019704Inst : IEnumerable<long>
{
public static readonly long[] Value=A019704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019704.Bytes);
public long this[int i]=>Value[i];

public static A019704Inst Instance=new A019704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019703
{
public static readonly long[] Value={ 2L,7L,3L,1L,8L,1L,9L,6L,9L,8L,7L,7L,3L,7L,3L,3L,2L,5L,0L,8L,3L,7L,0L,8L,1L,2L,0L,2L,8L,5L,1L,7L,4L,1L,6L,3L,8L,4L,3L,2L,3L,2L,1L,2L,1L,6L,8L,4L,7L,9L,1L,8L,1L,0L,5L,1L,9L,5L,6L,0L,3L,9L,9L,3L,3L,1L,1L,1L,4L,4L,7L,0L,1L,1L,1L,8L,4L,4L,2L,6L,0L,7L,5L,0L,2L,6L,3L,8L,9L,7L,8L,5L,5L,8L,3L,6L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019703Inst : IEnumerable<long>
{
public static readonly long[] Value=A019703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019703.Bytes);
public long this[int i]=>Value[i];

public static A019703Inst Instance=new A019703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019702
{
public static readonly long[] Value={ 2L,9L,9L,1L,9L,9L,3L,0L,0L,3L,4L,1L,8L,8L,5L,0L,7L,0L,3L,2L,9L,7L,7L,5L,5L,6L,0L,3L,1L,2L,3L,3L,3L,6L,0L,8L,0L,1L,8L,7L,7L,8L,0L,3L,8L,0L,3L,5L,7L,2L,4L,3L,6L,3L,9L,0L,2L,3L,7L,5L,6L,7L,5L,4L,5L,7L,8L,8L,7L,2L,7L,6L,7L,8L,9L,1L,6L,2L,7L,6L,1L,7L,7L,4L,0L,9L,8L,5L,5L,4L,7L,9L,4L,4L,8L,7L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019702Inst : IEnumerable<long>
{
public static readonly long[] Value=A019702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019702.Bytes);
public long this[int i]=>Value[i];

public static A019702Inst Instance=new A019702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019701
{
public static readonly long[] Value={ 3L,3L,0L,6L,9L,3L,9L,6L,3L,5L,3L,5L,7L,6L,7L,7L,0L,9L,3L,1L,1L,8L,5L,7L,1L,9L,8L,2L,3L,9L,9L,4L,7L,6L,7L,2L,0L,2L,0L,7L,5L,4L,6L,7L,3L,6L,1L,8L,4L,3L,2L,1L,9L,1L,6L,8L,1L,5L,7L,3L,1L,1L,4L,9L,7L,9L,7L,7L,0L,1L,4L,8L,0L,3L,0L,1L,2L,7L,2L,6L,3L,0L,1L,3L,4L,7L,7L,3L,5L,0L,0L,3L,6L,0L,1L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019701Inst : IEnumerable<long>
{
public static readonly long[] Value=A019701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019701.Bytes);
public long this[int i]=>Value[i];

public static A019701Inst Instance=new A019701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019700
{
public static readonly long[] Value={ 3L,6L,9L,5L,9L,9L,1L,3L,5L,7L,1L,6L,4L,4L,6L,2L,6L,3L,3L,4L,8L,5L,4L,6L,2L,8L,0L,3L,8L,5L,8L,2L,3L,8L,6L,8L,7L,2L,9L,0L,7L,8L,7L,5L,2L,8L,6L,7L,6L,5L,9L,5L,0L,8L,3L,4L,9L,9L,9L,3L,4L,8L,1L,4L,4L,7L,9L,7L,8L,4L,0L,0L,7L,3L,9L,5L,5L,3L,9L,9L,9L,8L,3L,8L,5L,9L,2L,3L,3L,2L,3L,9L,3L,1L,9L,0L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019700Inst : IEnumerable<long>
{
public static readonly long[] Value=A019700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019700.Bytes);
public long this[int i]=>Value[i];

public static A019700Inst Instance=new A019700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A019699
{
public static readonly long[] Value={ 4L,1L,8L,8L,7L,9L,0L,2L,0L,4L,7L,8L,6L,3L,9L,0L,9L,8L,4L,6L,1L,6L,8L,5L,7L,8L,4L,4L,3L,7L,2L,6L,7L,0L,5L,1L,2L,2L,6L,2L,8L,9L,2L,5L,3L,2L,5L,0L,0L,1L,4L,1L,0L,9L,4L,6L,3L,3L,2L,5L,9L,4L,5L,6L,4L,1L,0L,4L,2L,1L,8L,7L,5L,0L,4L,8L,2L,7L,8L,6L,6L,4L,8L,3L,7L,3L,7L,9L,7L,6L,7L,1L,2L,2L,8L,2L,2L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A019699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A019699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A019699Inst : IEnumerable<long>
{
public static readonly long[] Value=A019699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A019699.Bytes);
public long this[int i]=>Value[i];

public static A019699Inst Instance=new A019699Inst();

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