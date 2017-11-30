using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199957
{
public static readonly long[] Value={ 5L,2L,5L,4L,1L,6L,2L,7L,9L,2L,8L,2L,3L,5L,3L,6L,4L,9L,0L,7L,1L,5L,2L,2L,0L,5L,3L,3L,9L,2L,6L,8L,9L,6L,5L,6L,7L,3L,8L,8L,5L,6L,5L,3L,0L,2L,0L,7L,8L,3L,2L,8L,4L,4L,6L,3L,6L,0L,9L,8L,3L,8L,0L,6L,7L,2L,5L,4L,7L,6L,7L,6L,6L,0L,7L,4L,2L,3L,4L,8L,8L,5L,3L,7L,0L,6L,4L,8L,5L,2L,4L,7L,7L,1L,1L,8L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199957Inst : IEnumerable<long>
{
public static readonly long[] Value=A199957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199957.Bytes);
public long this[int i]=>Value[i];

public static A199957Inst Instance=new A199957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199958
{
public static readonly long[] Value={ 2L,1L,1L,1L,5L,9L,4L,8L,6L,7L,3L,1L,3L,0L,9L,4L,1L,6L,6L,6L,4L,6L,4L,1L,3L,3L,1L,0L,9L,9L,2L,0L,7L,4L,5L,4L,6L,0L,6L,7L,6L,8L,3L,5L,7L,6L,1L,4L,3L,6L,4L,6L,4L,5L,3L,4L,0L,0L,6L,1L,8L,8L,8L,3L,7L,3L,2L,8L,4L,5L,1L,2L,2L,9L,1L,7L,9L,0L,0L,3L,6L,6L,6L,5L,8L,1L,5L,8L,8L,3L,6L,6L,7L,2L,6L,2L,4L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199958Inst : IEnumerable<long>
{
public static readonly long[] Value=A199958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199958.Bytes);
public long this[int i]=>Value[i];

public static A199958Inst Instance=new A199958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199959
{
public static readonly long[] Value={ 1L,0L,4L,6L,4L,7L,2L,5L,4L,2L,5L,4L,0L,0L,9L,3L,4L,0L,3L,6L,1L,8L,0L,7L,3L,5L,5L,3L,7L,8L,6L,4L,3L,7L,0L,9L,3L,4L,0L,0L,2L,5L,5L,1L,4L,3L,3L,5L,3L,1L,8L,0L,5L,3L,7L,0L,1L,6L,8L,6L,3L,4L,0L,1L,8L,9L,4L,1L,2L,2L,9L,6L,3L,9L,8L,0L,8L,4L,0L,8L,9L,4L,2L,8L,1L,2L,0L,4L,0L,6L,9L,5L,1L,7L,7L,0L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199959Inst : IEnumerable<long>
{
public static readonly long[] Value=A199959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199959.Bytes);
public long this[int i]=>Value[i];

public static A199959Inst Instance=new A199959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199960
{
public static readonly long[] Value={ 1L,9L,9L,0L,5L,0L,3L,4L,6L,1L,6L,6L,8L,4L,9L,3L,8L,3L,5L,5L,8L,1L,8L,7L,6L,0L,2L,2L,2L,0L,4L,4L,1L,2L,4L,7L,6L,3L,6L,9L,4L,5L,1L,1L,6L,7L,7L,1L,8L,2L,5L,3L,6L,2L,0L,8L,9L,8L,8L,7L,5L,4L,8L,8L,9L,7L,0L,7L,6L,6L,2L,2L,9L,2L,7L,5L,9L,1L,9L,6L,3L,0L,3L,2L,0L,2L,8L,2L,0L,8L,9L,2L,5L,5L,7L,4L,8L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199960Inst : IEnumerable<long>
{
public static readonly long[] Value=A199960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199960.Bytes);
public long this[int i]=>Value[i];

public static A199960Inst Instance=new A199960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199961
{
public static readonly long[] Value={ 7L,5L,8L,9L,6L,2L,2L,0L,3L,5L,1L,7L,6L,9L,6L,8L,5L,1L,8L,5L,7L,1L,9L,8L,2L,8L,6L,0L,5L,6L,1L,0L,5L,0L,9L,2L,5L,9L,4L,9L,0L,2L,6L,0L,7L,0L,3L,6L,4L,4L,6L,6L,1L,4L,5L,8L,2L,5L,7L,3L,8L,3L,9L,2L,8L,9L,8L,3L,0L,8L,4L,2L,6L,2L,3L,5L,4L,9L,1L,4L,6L,4L,9L,2L,4L,6L,1L,2L,2L,8L,2L,3L,9L,2L,9L,2L,2L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199961Inst : IEnumerable<long>
{
public static readonly long[] Value=A199961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199961.Bytes);
public long this[int i]=>Value[i];

public static A199961Inst Instance=new A199961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199962
{
public static readonly long[] Value={ 2L,2L,3L,5L,8L,0L,9L,2L,8L,2L,0L,6L,4L,5L,6L,9L,1L,2L,1L,1L,1L,5L,2L,6L,4L,1L,4L,8L,3L,1L,7L,0L,1L,9L,8L,4L,4L,2L,4L,8L,0L,4L,9L,2L,0L,3L,9L,2L,6L,5L,3L,9L,0L,4L,0L,4L,3L,4L,1L,5L,0L,9L,1L,3L,0L,2L,6L,0L,5L,2L,4L,8L,0L,6L,1L,5L,1L,6L,5L,3L,9L,7L,5L,3L,5L,0L,8L,8L,3L,7L,8L,7L,4L,1L,9L,3L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199962Inst : IEnumerable<long>
{
public static readonly long[] Value=A199962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199962.Bytes);
public long this[int i]=>Value[i];

public static A199962Inst Instance=new A199962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199963
{
public static readonly long[] Value={ 1L,2L,3L,9L,7L,5L,1L,1L,5L,4L,8L,3L,0L,7L,0L,3L,3L,2L,2L,6L,6L,3L,0L,9L,4L,2L,9L,8L,7L,0L,9L,1L,8L,2L,0L,7L,2L,6L,0L,6L,9L,1L,2L,5L,7L,4L,9L,4L,5L,2L,1L,7L,2L,4L,7L,2L,3L,1L,7L,5L,6L,5L,2L,6L,4L,7L,6L,7L,4L,5L,9L,6L,3L,6L,0L,1L,8L,5L,6L,2L,6L,2L,6L,5L,9L,7L,5L,8L,2L,5L,7L,9L,2L,3L,1L,8L,7L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199963Inst : IEnumerable<long>
{
public static readonly long[] Value=A199963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199963.Bytes);
public long this[int i]=>Value[i];

public static A199963Inst Instance=new A199963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199964
{
public static readonly long[] Value={ 2L,1L,7L,8L,8L,4L,3L,3L,0L,3L,0L,3L,8L,4L,3L,8L,4L,7L,8L,7L,4L,7L,3L,5L,1L,5L,4L,6L,6L,3L,1L,1L,2L,0L,7L,8L,8L,0L,9L,8L,3L,8L,5L,5L,8L,5L,8L,9L,3L,8L,0L,7L,1L,9L,4L,3L,7L,4L,9L,0L,8L,7L,6L,0L,0L,4L,7L,5L,6L,4L,2L,6L,7L,4L,4L,8L,5L,4L,0L,4L,7L,5L,3L,2L,0L,2L,9L,5L,4L,4L,4L,8L,4L,5L,2L,5L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199964Inst : IEnumerable<long>
{
public static readonly long[] Value=A199964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199964.Bytes);
public long this[int i]=>Value[i];

public static A199964Inst Instance=new A199964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199965
{
public static readonly long[] Value={ 9L,4L,3L,3L,7L,9L,5L,7L,1L,5L,9L,1L,7L,9L,4L,6L,2L,2L,0L,8L,4L,1L,6L,7L,0L,2L,0L,5L,1L,5L,6L,3L,9L,8L,3L,8L,6L,1L,9L,2L,7L,5L,7L,1L,7L,2L,6L,5L,9L,1L,0L,4L,8L,4L,0L,1L,9L,0L,9L,2L,2L,8L,9L,2L,7L,0L,3L,8L,2L,6L,3L,8L,9L,2L,0L,0L,2L,3L,9L,8L,2L,6L,4L,6L,2L,1L,3L,8L,9L,7L,9L,5L,0L,7L,5L,4L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199965Inst : IEnumerable<long>
{
public static readonly long[] Value=A199965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199965.Bytes);
public long this[int i]=>Value[i];

public static A199965Inst Instance=new A199965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199966
{
public static readonly long[] Value={ 2L,3L,7L,8L,1L,2L,8L,1L,6L,8L,6L,7L,3L,7L,6L,7L,9L,8L,5L,9L,6L,8L,2L,0L,1L,6L,6L,1L,4L,7L,2L,8L,8L,6L,2L,1L,5L,3L,6L,6L,2L,9L,9L,9L,1L,5L,8L,9L,3L,5L,4L,1L,0L,0L,2L,2L,0L,8L,2L,0L,2L,7L,0L,8L,1L,3L,7L,4L,7L,2L,2L,3L,6L,2L,6L,6L,4L,9L,9L,0L,1L,2L,4L,6L,4L,8L,9L,3L,9L,4L,0L,0L,3L,4L,4L,9L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199966Inst : IEnumerable<long>
{
public static readonly long[] Value=A199966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199966.Bytes);
public long this[int i]=>Value[i];

public static A199966Inst Instance=new A199966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199967
{
public static readonly long[] Value={ 4L,5L,0L,4L,1L,2L,2L,3L,6L,3L,8L,3L,2L,4L,9L,1L,3L,3L,7L,6L,4L,7L,8L,1L,9L,0L,7L,8L,3L,8L,3L,9L,7L,7L,8L,4L,1L,7L,1L,6L,1L,9L,0L,7L,4L,6L,3L,2L,2L,9L,7L,3L,5L,9L,9L,9L,4L,0L,9L,3L,4L,8L,3L,9L,5L,8L,0L,6L,3L,6L,2L,8L,3L,9L,7L,8L,0L,8L,5L,2L,8L,5L,8L,6L,5L,1L,7L,2L,8L,8L,8L,2L,1L,7L,7L,4L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199967Inst : IEnumerable<long>
{
public static readonly long[] Value=A199967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199967.Bytes);
public long this[int i]=>Value[i];

public static A199967Inst Instance=new A199967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199968
{
public static readonly long[] Value={ 0L,0L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199968Inst : IEnumerable<long>
{
public static readonly long[] Value=A199968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199968.Bytes);
public long this[int i]=>Value[i];

public static A199968Inst Instance=new A199968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199969
{
public static readonly long[] Value={ 0L,0L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199969Inst : IEnumerable<long>
{
public static readonly long[] Value=A199969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199969.Bytes);
public long this[int i]=>Value[i];

public static A199969Inst Instance=new A199969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199970
{
public static readonly long[] Value={ 0L,3L,4L,6L,12L,0L,60L,420L,840L,0L,2520L,0L,27720L,0L,0L,360360L,720720L,0L,12252240L,0L,0L,0L,232792560L,0L,5354228880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199970Inst : IEnumerable<long>
{
public static readonly long[] Value=A199970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199970.Bytes);
public long this[int i]=>Value[i];

public static A199970Inst Instance=new A199970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199971
{
public static readonly long[] Value={ 0L,0L,2L,3L,7L,8L,13L,17L,17L,23L,23L,37L,30L,37L,39L,48L,40L,59L,46L,62L,57L,64L,56L,101L,67L,78L,76L,92L,73L,126L,79L,108L,96L,104L,96L,168L,96L,119L,115L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199971Inst : IEnumerable<long>
{
public static readonly long[] Value=A199971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199971.Bytes);
public long this[int i]=>Value[i];

public static A199971Inst Instance=new A199971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199972
{
public static readonly long[] Value={ 0L,0L,4L,9L,19L,29L,41L,55L,71L,89L,109L,131L,155L,181L,209L,239L,271L,305L,341L,379L,419L,461L,505L,551L,599L,649L,701L,755L,811L,869L,929L,991L,1055L,1121L,1189L,1259L,1331L,1405L,1481L,1559L,1639L,1721L,1805L,1891L,1979L,2069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199972Inst : IEnumerable<long>
{
public static readonly long[] Value=A199972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199972.Bytes);
public long this[int i]=>Value[i];

public static A199972Inst Instance=new A199972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199973
{
public static readonly long[] Value={ 0L,0L,4L,9L,12L,25L,18L,28L,28L,33L,28L,64L,35L,47L,51L,59L,45L,76L,51L,81L,68L,74L,61L,128L,72L,88L,87L,103L,78L,145L,84L,119L,107L,114L,101L,195L,101L,129L,126L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199973Inst : IEnumerable<long>
{
public static readonly long[] Value=A199973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199973.Bytes);
public long this[int i]=>Value[i];

public static A199973Inst Instance=new A199973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199974
{
public static readonly long[] Value={ 2L,6L,7L,14L,12L,25L,18L,28L,28L,33L,28L,64L,35L,47L,51L,59L,45L,76L,51L,81L,68L,74L,61L,128L,72L,88L,87L,103L,78L,145L,84L,119L,107L,114L,101L,195L,101L,129L,126L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199974Inst : IEnumerable<long>
{
public static readonly long[] Value=A199974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199974.Bytes);
public long this[int i]=>Value[i];

public static A199974Inst Instance=new A199974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199975
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,3L,7L,9L,6L,8L,3L,2L,4L,2L,6L,5L,0L,6L,8L,7L,2L,8L,8L,4L,8L,0L,0L,0L,0L,3L,4L,3L,2L,4L,8L,5L,5L,8L,8L,2L,8L,8L,9L,4L,8L,8L,2L,2L,6L,8L,8L,0L,8L,0L,0L,8L,0L,4L,4L,6L,6L,0L,0L,3L,9L,2L,9L,8L,6L,0L,0L,5L,2L,8L,4L,4L,2L,4L,0L,0L,8L,8L,2L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199975Inst : IEnumerable<long>
{
public static readonly long[] Value=A199975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199975.Bytes);
public long this[int i]=>Value[i];

public static A199975Inst Instance=new A199975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199976
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,0L,2L,4L,5L,6L,8L,0L,2L,4L,8L,0L,2L,4L,6L,0L,6L,9L,2L,5L,8L,8L,4L,0L,8L,6L,0L,8L,6L,8L,0L,5L,0L,0L,0L,0L,5L,0L,0L,2L,8L,8L,0L,8L,6L,0L,0L,4L,6L,5L,8L,8L,0L,0L,8L,6L,6L,0L,6L,0L,8L,0L,9L,8L,4L,8L,0L,0L,4L,8L,0L,0L,0L,0L,0L,0L,0L,1L,2L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199976Inst : IEnumerable<long>
{
public static readonly long[] Value=A199976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199976.Bytes);
public long this[int i]=>Value[i];

public static A199976Inst Instance=new A199976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199977
{
public static readonly long[] Value={ 59L,101L,103L,107L,109L,239L,251L,257L,269L,293L,307L,349L,353L,401L,409L,439L,457L,479L,503L,509L,521L,523L,541L,547L,563L,569L,577L,587L,599L,601L,607L,619L,653L,659L,691L,701L,709L,757L,787L,809L,853L,857L,859L,877L,907L,947L,997L,1009L,1013L,1019L,1021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199977Inst : IEnumerable<long>
{
public static readonly long[] Value=A199977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199977.Bytes);
public long this[int i]=>Value[i];

public static A199977Inst Instance=new A199977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199978
{
public static readonly long[] Value={ 10L,20L,25L,30L,40L,45L,50L,52L,54L,55L,56L,58L,60L,65L,69L,70L,78L,80L,85L,87L,90L,95L,96L,100L,102L,104L,105L,106L,108L,110L,120L,125L,130L,140L,145L,150L,152L,154L,155L,156L,158L,159L,160L,165L,169L,170L,178L,180L,185L,187L,190L,195L,196L,200L,201L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199978Inst : IEnumerable<long>
{
public static readonly long[] Value=A199978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199978.Bytes);
public long this[int i]=>Value[i];

public static A199978Inst Instance=new A199978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199979
{
public static readonly BigInteger[] Value={ 1L,111L,1111L,11111L,111111L,1111111L,11111111L,111111111L,1111111111L,11111111111L,111111111111L,1111111111111L,11111111111111L,111111111111111L,1111111111111111L,11111111111111111L,111111111111111111L,11111111111111111111UL,BigInteger.Parse("111111111111111111111") };
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
public class A199979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199979Inst Instance=new A199979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199980
{
public static readonly long[] Value={ 2L,37L,43L,73L,137L,173L,211L,223L,317L,367L,389L,431L,673L,827L,839L,929L,983L,1223L,1279L,1297L,1367L,1447L,1621L,1637L,1693L,1999L,2111L,2161L,2179L,2213L,2269L,2339L,2393L,2663L,2699L,2719L,2791L,2917L,2969L,2971L,3167L,3169L,3221L,3329L,3463L,3499L,3617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199980Inst : IEnumerable<long>
{
public static readonly long[] Value=A199980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199980.Bytes);
public long this[int i]=>Value[i];

public static A199980Inst Instance=new A199980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199981
{
public static readonly long[] Value={ 12L,21L,26L,34L,62L,112L,121L,126L,134L,143L,162L,216L,232L,261L,278L,279L,287L,297L,299L,314L,322L,341L,369L,371L,376L,396L,398L,413L,447L,469L,474L,496L,612L,621L,637L,639L,649L,666L,693L,694L,713L,728L,729L,731L,736L,744L,763L,782L,792L,872L,893L,927L,936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199981Inst : IEnumerable<long>
{
public static readonly long[] Value=A199981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199981.Bytes);
public long this[int i]=>Value[i];

public static A199981Inst Instance=new A199981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199982
{
public static readonly long[] Value={ 1113L,1131L,1311L,3111L,13111L,31111L,111113L,111131L,111311L,1111113L,1111131L,1111311L,1113111L,1131111L,1311111L,3111111L,11111113L,11311111L,13111111L,31111111L,111111311L,111113111L,111131111L,111311111L,113111111L,311111111L,1111111113L,1111111131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199982Inst : IEnumerable<long>
{
public static readonly long[] Value=A199982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199982.Bytes);
public long this[int i]=>Value[i];

public static A199982Inst Instance=new A199982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199983
{
public static readonly long[] Value={ 41L,89L,127L,139L,193L,271L,277L,379L,383L,397L,463L,643L,677L,727L,739L,937L,1193L,1217L,1249L,1277L,1319L,1429L,1721L,1913L,1931L,1973L,2377L,2711L,3119L,3191L,3313L,3331L,3373L,3461L,3719L,3727L,3733L,3911L,3917L,4111L,4129L,4219L,6143L,7121L,7127L,7193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199983Inst : IEnumerable<long>
{
public static readonly long[] Value=A199983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199983.Bytes);
public long this[int i]=>Value[i];

public static A199983Inst Instance=new A199983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199984
{
public static readonly long[] Value={ 4L,14L,22L,27L,39L,72L,93L,98L,114L,122L,141L,172L,189L,198L,212L,217L,221L,249L,266L,294L,319L,333L,338L,346L,364L,391L,411L,429L,436L,492L,626L,634L,662L,712L,721L,767L,772L,776L,793L,819L,833L,891L,913L,918L,924L,931L,942L,973L,981L,1114L,1122L,1127L,1139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199984Inst : IEnumerable<long>
{
public static readonly long[] Value=A199984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199984.Bytes);
public long this[int i]=>Value[i];

public static A199984Inst Instance=new A199984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199985
{
public static readonly long[] Value={ 5L,15L,51L,115L,151L,511L,1115L,1151L,1511L,5111L,11115L,11151L,11511L,15111L,51111L,111115L,111151L,111511L,115111L,151111L,511111L,1111115L,1111151L,1111511L,1115111L,1151111L,1511111L,5111111L,11111115L,11111151L,11111511L,11115111L,11151111L,11511111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199985Inst : IEnumerable<long>
{
public static readonly long[] Value=A199985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199985.Bytes);
public long this[int i]=>Value[i];

public static A199985Inst Instance=new A199985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199986
{
public static readonly long[] Value={ 2L,12L,21L,112L,121L,211L,1112L,1121L,1211L,2111L,11112L,11121L,11211L,12111L,21111L,111112L,111121L,111211L,112111L,121111L,211111L,1111112L,1111121L,1111211L,1112111L,1121111L,1211111L,2111111L,11111112L,11111121L,11111211L,11112111L,11121111L,11211111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199986Inst : IEnumerable<long>
{
public static readonly long[] Value=A199986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199986.Bytes);
public long this[int i]=>Value[i];

public static A199986Inst Instance=new A199986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199987
{
public static readonly long[] Value={ 4L,14L,22L,41L,114L,122L,141L,212L,221L,411L,1114L,1122L,1141L,1212L,1221L,1411L,2112L,2121L,2211L,4111L,11114L,11122L,11141L,11212L,11221L,11411L,12112L,12121L,12211L,14111L,21112L,21121L,21211L,22111L,41111L,111114L,111122L,111141L,111212L,111221L,111411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199987Inst : IEnumerable<long>
{
public static readonly long[] Value=A199987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199987.Bytes);
public long this[int i]=>Value[i];

public static A199987Inst Instance=new A199987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199988
{
public static readonly long[] Value={ 6L,16L,23L,32L,61L,116L,123L,132L,161L,213L,231L,312L,321L,611L,1116L,1123L,1132L,1161L,1213L,1231L,1312L,1321L,1611L,2113L,2131L,2311L,3112L,3121L,3211L,6111L,11116L,11123L,11132L,11161L,11213L,11231L,11312L,11321L,11611L,12113L,12131L,12311L,13112L,13121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199988Inst : IEnumerable<long>
{
public static readonly long[] Value=A199988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199988.Bytes);
public long this[int i]=>Value[i];

public static A199988Inst Instance=new A199988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199989
{
public static readonly long[] Value={ 8L,18L,24L,42L,81L,118L,124L,142L,181L,214L,222L,241L,412L,421L,811L,1118L,1124L,1142L,1181L,1214L,1222L,1241L,1412L,1421L,1811L,2114L,2122L,2141L,2212L,2221L,2411L,4112L,4121L,4211L,8111L,11118L,11124L,11142L,11181L,11214L,11222L,11241L,11412L,11421L,11811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199989Inst : IEnumerable<long>
{
public static readonly long[] Value=A199989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199989.Bytes);
public long this[int i]=>Value[i];

public static A199989Inst Instance=new A199989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199990
{
public static readonly long[] Value={ 25L,52L,125L,152L,215L,251L,512L,521L,1125L,1152L,1215L,1251L,1512L,1521L,2115L,2151L,2511L,5112L,5121L,5211L,11125L,11152L,11215L,11251L,11512L,11521L,12115L,12151L,12511L,15112L,15121L,15211L,21115L,21151L,21511L,25111L,51112L,51121L,51211L,52111L,111125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199990Inst : IEnumerable<long>
{
public static readonly long[] Value=A199990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199990.Bytes);
public long this[int i]=>Value[i];

public static A199990Inst Instance=new A199990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199991
{
public static readonly long[] Value={ 10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,30L,32L,33L,40L,42L,50L,51L,60L,70L,80L,81L,90L,91L,100L,102L,104L,105L,106L,108L,110L,111L,112L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,130L,132L,133L,140L,141L,142L,150L,160L,161L,170L,171L,180L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199991Inst : IEnumerable<long>
{
public static readonly long[] Value=A199991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199991.Bytes);
public long this[int i]=>Value[i];

public static A199991Inst Instance=new A199991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199992
{
public static readonly long[] Value={ 25L,26L,27L,28L,34L,35L,36L,38L,44L,45L,46L,48L,52L,54L,56L,58L,62L,63L,64L,65L,72L,76L,82L,84L,85L,92L,99L,125L,126L,128L,129L,134L,135L,136L,138L,143L,144L,145L,146L,148L,152L,153L,154L,156L,158L,162L,164L,165L,172L,176L,182L,183L,184L,185L,192L,215L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199992Inst : IEnumerable<long>
{
public static readonly long[] Value=A199992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199992.Bytes);
public long this[int i]=>Value[i];

public static A199992Inst Instance=new A199992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199993
{
public static readonly long[] Value={ 39L,49L,55L,57L,66L,68L,69L,74L,75L,78L,86L,87L,88L,93L,94L,95L,96L,98L,147L,155L,159L,166L,168L,169L,174L,175L,178L,186L,187L,188L,189L,194L,195L,196L,198L,236L,238L,246L,247L,248L,249L,264L,266L,267L,272L,274L,276L,279L,284L,288L,289L,292L,294L,297L,298L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199993Inst : IEnumerable<long>
{
public static readonly long[] Value=A199993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199993.Bytes);
public long this[int i]=>Value[i];

public static A199993Inst Instance=new A199993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199994
{
public static readonly long[] Value={ 77L,177L,268L,286L,348L,355L,377L,378L,384L,387L,438L,446L,464L,476L,477L,483L,489L,498L,535L,553L,575L,628L,644L,668L,674L,678L,682L,686L,687L,699L,717L,737L,738L,746L,747L,755L,764L,767L,768L,771L,772L,774L,776L,777L,778L,783L,786L,788L,793L,826L,834L,837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199994Inst : IEnumerable<long>
{
public static readonly long[] Value=A199994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199994.Bytes);
public long this[int i]=>Value[i];

public static A199994Inst Instance=new A199994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199995
{
public static readonly long[] Value={ 679L,688L,697L,796L,868L,886L,976L,1679L,1688L,1769L,1796L,1868L,1886L,1967L,1976L,2379L,2388L,2397L,2468L,2486L,2648L,2684L,2688L,2739L,2793L,2838L,2846L,2864L,2868L,2883L,2886L,2937L,2973L,3279L,3288L,3297L,3367L,3376L,3448L,3484L,3488L,3729L,3736L,3763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199995Inst : IEnumerable<long>
{
public static readonly long[] Value=A199995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199995.Bytes);
public long this[int i]=>Value[i];

public static A199995Inst Instance=new A199995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199996
{
public static readonly long[] Value={ 6788L,6878L,6887L,7688L,7868L,7886L,8678L,8687L,8768L,8786L,8876L,16788L,16878L,16887L,17688L,17868L,17886L,18678L,18687L,18768L,18786L,18867L,18876L,23788L,23878L,24678L,24687L,24768L,24786L,24867L,24876L,26478L,26487L,26748L,26784L,26847L,26874L,27388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199996Inst : IEnumerable<long>
{
public static readonly long[] Value=A199996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199996.Bytes);
public long this[int i]=>Value[i];

public static A199996Inst Instance=new A199996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199997
{
public static readonly long[] Value={ 68889L,68898L,68988L,69888L,86889L,86898L,86988L,88689L,88698L,88869L,88896L,88968L,88986L,89688L,89868L,89886L,96888L,98688L,98868L,98886L,168889L,168898L,168988L,169888L,186898L,186988L,188689L,188698L,188896L,188968L,188986L,189688L,189868L,189886L,196888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199997Inst : IEnumerable<long>
{
public static readonly long[] Value=A199997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199997.Bytes);
public long this[int i]=>Value[i];

public static A199997Inst Instance=new A199997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199998
{
public static readonly long[] Value={ 2677889L,2677898L,2677988L,2678798L,2678879L,2678897L,2678978L,2678987L,2679788L,2679878L,2679887L,2687789L,2687798L,2687978L,2687987L,2688779L,2689778L,2689787L,2697788L,2697878L,2698778L,2698787L,2698877L,2767889L,2767898L,2767988L,2768798L,2768879L,2768978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199998Inst : IEnumerable<long>
{
public static readonly long[] Value=A199998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199998.Bytes);
public long this[int i]=>Value[i];

public static A199998Inst Instance=new A199998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199999
{
public static readonly long[] Value={ 26888999L,26889899L,26889989L,26889998L,26898899L,26898989L,26898998L,26899898L,26899988L,26988899L,26988989L,26988998L,26989889L,26989898L,26989988L,26998889L,26998898L,26998988L,26999888L,28688999L,28689899L,28689989L,28689998L,28698989L,28698998L,28699898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199999Inst : IEnumerable<long>
{
public static readonly long[] Value=A199999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199999.Bytes);
public long this[int i]=>Value[i];

public static A199999Inst Instance=new A199999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200000
{
public static readonly BigInteger[] Value={ 1L,1L,0L,4L,42L,9050L,6965359L,26721852461L,429651752290375L,BigInteger.Parse("31194475941824888769"),BigInteger.Parse("9828395457980805457337560"),BigInteger.Parse("13684686862375136981850903785368"),BigInteger.Parse("83297108604256429529069019958551956425"),BigInteger.Parse("2226741508593975401942934273354241209226704830"),BigInteger.Parse("260577257822688861848154672171293101310412373160498171"),BigInteger.Parse("133631198381015786582155688877301469836628906260462969996612568"),BigInteger.Parse("299985729493560746632648983353916422875677601725131683097521792924081609") };
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
public class A200000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200000Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200000.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200000.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200000Inst Instance=new A200000Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200001
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,24L,27L,28L,30L,32L,35L,36L,40L,42L,45L,48L,54L,56L,60L,63L,64L,70L,72L,80L,84L,90L,96L,105L,108L,112L,120L,126L,135L,140L,144L,160L,162L,168L,180L,189L,192L,210L,216L,224L,240L,252L,270L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200001Inst : IEnumerable<long>
{
public static readonly long[] Value=A200001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200001.Bytes);
public long this[int i]=>Value[i];

public static A200001Inst Instance=new A200001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200002
{
public static readonly BigInteger[] Value={ 1L,1L,5L,338L,375502L,6351970709L,1620698781098852L,BigInteger.Parse("6259260939361008796229"),BigInteger.Parse("367534769386519350929158503892"),BigInteger.Parse("329474737492618783473185792974307067503"),BigInteger.Parse("4525697838840190793599072589249813785373031191426"),BigInteger.Parse("955617474162634862818320009634143510233705849191099879550608") };
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
public class A200002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200002Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200002.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200002.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200002Inst Instance=new A200002Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200003
{
public static readonly long[] Value={ 9L,8L,9L,4L,5L,0L,0L,1L,4L,4L,9L,3L,9L,4L,9L,1L,6L,7L,4L,8L,9L,7L,8L,8L,3L,3L,2L,6L,9L,5L,7L,1L,4L,9L,7L,5L,5L,4L,8L,1L,1L,9L,5L,4L,8L,4L,6L,2L,4L,1L,2L,6L,4L,4L,4L,2L,2L,0L,0L,1L,6L,0L,8L,4L,4L,9L,9L,6L,8L,2L,5L,8L,2L,7L,1L,5L,4L,1L,8L,2L,4L,3L,0L,4L,3L,1L,8L,3L,2L,4L,6L,9L,5L,2L,6L,3L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200003Inst : IEnumerable<long>
{
public static readonly long[] Value=A200003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200003.Bytes);
public long this[int i]=>Value[i];

public static A200003Inst Instance=new A200003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200004
{
public static readonly long[] Value={ 2L,8L,4L,1L,5L,5L,4L,2L,5L,1L,7L,7L,1L,4L,8L,1L,4L,9L,1L,6L,8L,0L,5L,3L,6L,2L,8L,8L,7L,3L,5L,4L,4L,3L,3L,1L,0L,5L,0L,2L,6L,1L,5L,3L,6L,0L,2L,5L,8L,1L,3L,5L,3L,6L,8L,0L,9L,3L,6L,7L,6L,7L,1L,4L,5L,7L,3L,3L,4L,3L,5L,2L,2L,1L,4L,0L,1L,8L,7L,8L,6L,5L,4L,8L,3L,5L,5L,8L,2L,8L,9L,0L,5L,2L,9L,2L,9L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200004Inst : IEnumerable<long>
{
public static readonly long[] Value=A200004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200004.Bytes);
public long this[int i]=>Value[i];

public static A200004Inst Instance=new A200004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200005
{
public static readonly long[] Value={ 1L,3L,6L,0L,8L,3L,2L,2L,5L,5L,3L,9L,0L,6L,6L,8L,9L,0L,4L,6L,7L,1L,8L,3L,9L,2L,8L,5L,6L,9L,1L,3L,2L,6L,3L,6L,8L,8L,2L,5L,4L,9L,7L,9L,2L,6L,2L,5L,5L,0L,8L,5L,8L,3L,1L,1L,0L,7L,4L,1L,3L,2L,6L,7L,8L,2L,0L,6L,1L,0L,6L,2L,3L,0L,1L,3L,9L,9L,4L,2L,4L,7L,4L,6L,2L,9L,0L,5L,6L,4L,0L,9L,9L,1L,4L,8L,2L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200005Inst : IEnumerable<long>
{
public static readonly long[] Value=A200005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200005.Bytes);
public long this[int i]=>Value[i];

public static A200005Inst Instance=new A200005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200006
{
public static readonly long[] Value={ 3L,1L,9L,1L,6L,5L,5L,8L,4L,4L,9L,3L,9L,5L,6L,1L,1L,4L,5L,0L,9L,4L,4L,8L,2L,8L,0L,4L,6L,1L,2L,3L,8L,7L,8L,6L,4L,5L,0L,7L,4L,1L,1L,2L,3L,8L,1L,1L,0L,4L,6L,5L,8L,9L,6L,6L,4L,5L,3L,7L,3L,6L,2L,4L,0L,6L,0L,0L,9L,7L,9L,2L,3L,1L,2L,2L,5L,3L,6L,7L,3L,1L,2L,1L,1L,7L,2L,2L,3L,0L,9L,5L,8L,1L,8L,9L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200006Inst : IEnumerable<long>
{
public static readonly long[] Value=A200006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200006.Bytes);
public long this[int i]=>Value[i];

public static A200006Inst Instance=new A200006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200007
{
public static readonly long[] Value={ 9L,3L,5L,7L,8L,1L,9L,5L,4L,5L,6L,0L,2L,0L,1L,6L,9L,0L,6L,4L,7L,6L,9L,0L,3L,5L,6L,7L,4L,8L,3L,5L,0L,6L,5L,5L,1L,8L,6L,4L,5L,4L,2L,4L,0L,5L,5L,1L,0L,1L,8L,8L,3L,7L,9L,3L,0L,4L,1L,7L,2L,9L,1L,9L,1L,7L,6L,6L,5L,6L,9L,6L,0L,6L,1L,3L,3L,0L,9L,3L,0L,3L,4L,5L,2L,2L,9L,7L,6L,1L,1L,2L,8L,2L,8L,0L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200007Inst : IEnumerable<long>
{
public static readonly long[] Value=A200007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200007.Bytes);
public long this[int i]=>Value[i];

public static A200007Inst Instance=new A200007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200008
{
public static readonly long[] Value={ 4L,0L,3L,9L,5L,4L,8L,5L,6L,2L,7L,7L,0L,9L,9L,0L,5L,7L,8L,7L,9L,3L,5L,3L,4L,4L,6L,4L,2L,2L,1L,1L,0L,4L,1L,1L,1L,7L,5L,9L,3L,5L,1L,4L,1L,8L,7L,3L,6L,5L,1L,0L,3L,8L,3L,8L,8L,8L,5L,6L,4L,5L,4L,9L,5L,7L,2L,7L,5L,8L,6L,8L,5L,8L,4L,8L,9L,0L,1L,6L,0L,8L,0L,0L,5L,2L,9L,6L,5L,2L,1L,1L,0L,7L,6L,1L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200008Inst : IEnumerable<long>
{
public static readonly long[] Value=A200008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200008.Bytes);
public long this[int i]=>Value[i];

public static A200008Inst Instance=new A200008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200009
{
public static readonly long[] Value={ 5L,9L,2L,4L,7L,0L,2L,9L,0L,7L,9L,2L,5L,0L,3L,9L,3L,2L,9L,3L,1L,2L,8L,2L,2L,7L,6L,2L,8L,8L,0L,6L,3L,2L,4L,8L,3L,9L,9L,2L,9L,0L,6L,5L,3L,9L,7L,4L,8L,6L,4L,5L,5L,8L,1L,0L,3L,1L,3L,1L,1L,7L,5L,0L,1L,1L,5L,9L,3L,8L,8L,5L,9L,1L,7L,1L,8L,4L,8L,5L,2L,6L,8L,7L,3L,3L,8L,7L,8L,5L,7L,1L,8L,6L,2L,9L,6L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200009Inst : IEnumerable<long>
{
public static readonly long[] Value=A200009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200009.Bytes);
public long this[int i]=>Value[i];

public static A200009Inst Instance=new A200009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200010
{
public static readonly long[] Value={ 5L,6L,0L,9L,8L,7L,7L,2L,9L,2L,3L,5L,9L,1L,1L,3L,7L,5L,2L,7L,7L,4L,3L,7L,0L,2L,8L,5L,3L,3L,6L,6L,8L,2L,3L,1L,7L,9L,9L,0L,9L,2L,1L,5L,5L,1L,9L,4L,7L,5L,5L,4L,2L,4L,5L,2L,8L,3L,2L,9L,7L,2L,2L,5L,4L,0L,7L,4L,4L,5L,9L,4L,6L,4L,3L,0L,6L,8L,8L,2L,4L,4L,1L,5L,5L,2L,8L,5L,5L,6L,6L,3L,2L,9L,2L,4L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200010Inst : IEnumerable<long>
{
public static readonly long[] Value=A200010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200010.Bytes);
public long this[int i]=>Value[i];

public static A200010Inst Instance=new A200010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200011
{
public static readonly long[] Value={ 1L,1L,4L,9L,5L,5L,4L,6L,2L,7L,2L,7L,7L,4L,7L,3L,1L,8L,9L,0L,6L,9L,5L,2L,2L,4L,9L,4L,7L,4L,4L,4L,0L,9L,0L,2L,0L,1L,1L,3L,9L,6L,8L,1L,7L,7L,9L,1L,3L,9L,2L,4L,4L,8L,1L,3L,1L,9L,2L,5L,2L,4L,8L,6L,3L,4L,8L,5L,5L,1L,5L,3L,5L,9L,0L,5L,7L,3L,7L,8L,3L,9L,3L,2L,6L,2L,5L,3L,2L,9L,9L,1L,6L,6L,5L,1L,2L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200011Inst : IEnumerable<long>
{
public static readonly long[] Value=A200011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200011.Bytes);
public long this[int i]=>Value[i];

public static A200011Inst Instance=new A200011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200012
{
public static readonly long[] Value={ 3L,9L,4L,1L,2L,4L,1L,9L,2L,8L,5L,8L,9L,7L,5L,9L,6L,0L,0L,9L,9L,7L,0L,5L,3L,9L,9L,3L,5L,4L,5L,9L,0L,0L,9L,8L,5L,3L,6L,9L,2L,2L,4L,9L,6L,1L,9L,3L,9L,1L,2L,2L,9L,7L,9L,2L,1L,9L,8L,4L,8L,1L,1L,6L,8L,5L,3L,1L,1L,8L,7L,4L,1L,7L,6L,0L,2L,4L,8L,1L,7L,9L,3L,5L,8L,3L,4L,5L,6L,0L,3L,0L,7L,1L,7L,9L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200012Inst : IEnumerable<long>
{
public static readonly long[] Value=A200012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200012.Bytes);
public long this[int i]=>Value[i];

public static A200012Inst Instance=new A200012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200013
{
public static readonly long[] Value={ 1L,4L,5L,0L,9L,3L,8L,4L,4L,9L,6L,3L,4L,9L,7L,4L,4L,3L,1L,1L,2L,8L,2L,8L,5L,5L,7L,6L,6L,9L,0L,3L,5L,7L,7L,3L,8L,9L,4L,4L,7L,4L,8L,7L,0L,1L,1L,5L,3L,4L,6L,3L,9L,8L,7L,6L,5L,4L,2L,3L,5L,8L,6L,2L,6L,2L,9L,6L,1L,9L,2L,8L,4L,3L,0L,8L,1L,3L,5L,0L,5L,9L,1L,7L,2L,0L,8L,4L,3L,0L,4L,9L,7L,0L,9L,4L,6L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200013Inst : IEnumerable<long>
{
public static readonly long[] Value=A200013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200013.Bytes);
public long this[int i]=>Value[i];

public static A200013Inst Instance=new A200013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200014
{
public static readonly long[] Value={ 2L,9L,4L,3L,4L,8L,7L,7L,2L,3L,3L,5L,6L,8L,6L,3L,9L,8L,3L,6L,9L,6L,5L,7L,8L,9L,0L,2L,0L,3L,6L,1L,9L,5L,0L,3L,0L,8L,6L,7L,2L,1L,9L,9L,0L,0L,5L,9L,4L,0L,0L,3L,2L,8L,8L,8L,6L,8L,4L,1L,8L,0L,1L,6L,5L,1L,9L,9L,9L,8L,1L,5L,0L,7L,0L,7L,8L,4L,3L,8L,3L,5L,7L,8L,4L,4L,7L,6L,2L,2L,5L,3L,2L,2L,6L,0L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200014Inst : IEnumerable<long>
{
public static readonly long[] Value=A200014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200014.Bytes);
public long this[int i]=>Value[i];

public static A200014Inst Instance=new A200014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200015
{
public static readonly long[] Value={ 1L,6L,9L,0L,7L,7L,9L,7L,3L,8L,9L,6L,9L,8L,1L,5L,3L,3L,4L,9L,5L,7L,5L,0L,4L,8L,5L,7L,5L,5L,8L,8L,0L,9L,5L,4L,3L,4L,2L,1L,3L,2L,4L,1L,6L,3L,9L,0L,6L,5L,4L,5L,2L,8L,5L,4L,4L,5L,1L,8L,3L,8L,5L,4L,9L,7L,2L,6L,1L,2L,8L,7L,2L,5L,7L,1L,9L,9L,7L,4L,5L,7L,7L,4L,3L,1L,6L,4L,5L,7L,1L,3L,7L,0L,0L,8L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200015Inst : IEnumerable<long>
{
public static readonly long[] Value=A200015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200015.Bytes);
public long this[int i]=>Value[i];

public static A200015Inst Instance=new A200015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200016
{
public static readonly long[] Value={ 2L,3L,1L,9L,3L,1L,7L,3L,6L,5L,0L,8L,0L,7L,7L,0L,6L,8L,2L,7L,9L,2L,1L,6L,2L,9L,5L,0L,7L,8L,0L,8L,0L,1L,1L,5L,5L,2L,8L,9L,5L,6L,6L,7L,4L,9L,1L,7L,6L,0L,4L,6L,3L,1L,5L,8L,1L,2L,1L,7L,4L,2L,7L,6L,4L,9L,1L,9L,4L,3L,4L,9L,1L,6L,1L,6L,1L,4L,6L,5L,4L,1L,6L,9L,0L,8L,8L,3L,0L,5L,2L,0L,0L,8L,3L,6L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200016Inst : IEnumerable<long>
{
public static readonly long[] Value=A200016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200016.Bytes);
public long this[int i]=>Value[i];

public static A200016Inst Instance=new A200016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200017
{
public static readonly long[] Value={ 1L,8L,7L,5L,2L,0L,0L,6L,8L,8L,7L,5L,6L,6L,9L,0L,1L,3L,7L,0L,0L,0L,9L,9L,5L,4L,4L,2L,7L,0L,2L,2L,4L,9L,1L,3L,9L,1L,5L,1L,8L,7L,1L,7L,6L,0L,4L,2L,4L,5L,7L,9L,4L,7L,0L,6L,9L,5L,5L,6L,0L,1L,4L,9L,5L,6L,5L,1L,5L,3L,3L,6L,8L,6L,6L,1L,5L,7L,7L,6L,9L,0L,2L,9L,6L,4L,3L,2L,2L,4L,4L,2L,9L,3L,0L,2L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200017Inst : IEnumerable<long>
{
public static readonly long[] Value=A200017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200017.Bytes);
public long this[int i]=>Value[i];

public static A200017Inst Instance=new A200017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200018
{
public static readonly long[] Value={ 8L,0L,9L,6L,2L,9L,9L,9L,9L,1L,2L,9L,5L,5L,2L,4L,1L,3L,1L,8L,6L,1L,0L,9L,6L,9L,8L,4L,8L,4L,0L,2L,7L,1L,3L,2L,1L,9L,6L,6L,9L,1L,7L,6L,0L,3L,5L,6L,5L,4L,5L,3L,7L,8L,5L,3L,8L,9L,4L,7L,8L,4L,6L,3L,2L,9L,8L,3L,6L,9L,0L,8L,2L,3L,2L,1L,6L,6L,6L,8L,3L,9L,6L,9L,0L,1L,7L,5L,9L,9L,6L,0L,8L,6L,5L,1L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200018Inst : IEnumerable<long>
{
public static readonly long[] Value=A200018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200018.Bytes);
public long this[int i]=>Value[i];

public static A200018Inst Instance=new A200018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200019
{
public static readonly long[] Value={ 1L,2L,5L,4L,1L,8L,7L,9L,6L,2L,4L,7L,7L,9L,1L,9L,5L,5L,3L,3L,6L,3L,9L,1L,2L,3L,2L,6L,3L,2L,1L,8L,0L,1L,3L,7L,4L,2L,6L,0L,6L,2L,4L,1L,3L,8L,6L,9L,8L,6L,9L,2L,8L,5L,1L,5L,7L,7L,7L,5L,1L,6L,0L,3L,0L,8L,2L,5L,6L,2L,2L,5L,8L,3L,8L,4L,0L,8L,2L,4L,8L,4L,9L,2L,4L,2L,6L,4L,5L,9L,4L,9L,4L,6L,1L,3L,9L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200019Inst : IEnumerable<long>
{
public static readonly long[] Value=A200019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200019.Bytes);
public long this[int i]=>Value[i];

public static A200019Inst Instance=new A200019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200020
{
public static readonly long[] Value={ 6L,4L,0L,0L,4L,9L,1L,9L,1L,1L,4L,2L,5L,7L,7L,1L,1L,5L,7L,3L,9L,8L,3L,5L,2L,6L,9L,6L,7L,5L,8L,4L,1L,2L,0L,1L,2L,9L,6L,6L,3L,4L,6L,8L,4L,7L,7L,3L,3L,5L,0L,9L,7L,1L,1L,0L,6L,6L,7L,1L,3L,8L,2L,1L,5L,6L,7L,3L,9L,6L,0L,7L,9L,0L,4L,4L,6L,2L,3L,0L,8L,5L,8L,3L,7L,5L,0L,9L,3L,3L,0L,9L,7L,6L,3L,5L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200020Inst : IEnumerable<long>
{
public static readonly long[] Value=A200020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200020.Bytes);
public long this[int i]=>Value[i];

public static A200020Inst Instance=new A200020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200021
{
public static readonly long[] Value={ 1L,4L,7L,6L,3L,6L,8L,7L,4L,8L,3L,8L,0L,9L,2L,0L,3L,9L,1L,6L,7L,1L,6L,9L,6L,8L,8L,9L,7L,8L,9L,8L,3L,6L,4L,1L,6L,4L,3L,6L,9L,3L,2L,3L,2L,3L,1L,9L,7L,3L,2L,4L,9L,9L,3L,0L,3L,6L,9L,4L,0L,4L,4L,5L,3L,9L,6L,6L,8L,4L,3L,0L,8L,6L,1L,5L,8L,0L,7L,6L,0L,1L,2L,4L,0L,6L,0L,1L,7L,3L,0L,4L,8L,3L,3L,6L,9L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200021Inst : IEnumerable<long>
{
public static readonly long[] Value=A200021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200021.Bytes);
public long this[int i]=>Value[i];

public static A200021Inst Instance=new A200021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200022
{
public static readonly long[] Value={ 5L,1L,4L,5L,1L,4L,8L,3L,0L,4L,7L,6L,4L,5L,8L,6L,8L,6L,5L,6L,5L,6L,3L,8L,9L,4L,5L,6L,7L,5L,3L,7L,1L,8L,1L,5L,9L,5L,2L,1L,1L,1L,9L,8L,3L,6L,7L,0L,3L,4L,0L,2L,2L,7L,8L,2L,0L,3L,9L,7L,8L,3L,7L,7L,5L,8L,1L,9L,3L,2L,4L,4L,5L,9L,9L,6L,6L,4L,1L,8L,7L,7L,8L,9L,1L,5L,6L,2L,9L,3L,8L,0L,2L,0L,5L,0L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200022Inst : IEnumerable<long>
{
public static readonly long[] Value=A200022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200022.Bytes);
public long this[int i]=>Value[i];

public static A200022Inst Instance=new A200022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200023
{
public static readonly long[] Value={ 1L,6L,6L,9L,6L,9L,2L,1L,6L,9L,6L,4L,9L,7L,6L,3L,4L,5L,8L,2L,5L,2L,8L,3L,8L,3L,0L,5L,9L,8L,4L,9L,1L,7L,3L,3L,5L,9L,3L,7L,7L,5L,8L,9L,9L,6L,5L,9L,1L,6L,9L,9L,1L,6L,8L,2L,8L,2L,4L,0L,8L,4L,9L,6L,1L,1L,2L,9L,1L,0L,5L,6L,2L,3L,4L,4L,1L,3L,3L,4L,1L,9L,3L,2L,5L,7L,8L,3L,8L,7L,2L,9L,5L,5L,6L,9L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200023Inst : IEnumerable<long>
{
public static readonly long[] Value=A200023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200023.Bytes);
public long this[int i]=>Value[i];

public static A200023Inst Instance=new A200023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200024
{
public static readonly long[] Value={ 4L,2L,3L,5L,2L,7L,2L,9L,4L,7L,1L,8L,6L,9L,1L,1L,6L,1L,8L,5L,7L,4L,1L,1L,5L,5L,5L,0L,9L,6L,9L,2L,8L,8L,3L,4L,0L,2L,6L,1L,3L,5L,4L,6L,3L,4L,7L,0L,2L,5L,0L,3L,2L,6L,3L,0L,0L,0L,1L,8L,3L,3L,2L,6L,9L,9L,7L,3L,3L,7L,4L,3L,5L,0L,7L,9L,3L,7L,1L,8L,8L,5L,4L,1L,2L,8L,7L,8L,7L,0L,5L,2L,5L,4L,1L,4L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200024Inst : IEnumerable<long>
{
public static readonly long[] Value=A200024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200024.Bytes);
public long this[int i]=>Value[i];

public static A200024Inst Instance=new A200024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200025
{
public static readonly long[] Value={ 1L,8L,3L,0L,7L,3L,3L,4L,5L,3L,2L,9L,0L,8L,6L,3L,5L,9L,9L,2L,1L,0L,2L,3L,5L,9L,5L,4L,7L,3L,4L,1L,4L,7L,8L,8L,4L,5L,3L,6L,6L,7L,8L,1L,2L,8L,3L,2L,4L,2L,1L,4L,9L,5L,2L,2L,9L,5L,8L,1L,6L,4L,2L,6L,7L,1L,0L,0L,0L,8L,5L,1L,1L,9L,4L,6L,2L,3L,6L,2L,0L,3L,8L,0L,5L,5L,4L,6L,3L,7L,8L,8L,4L,3L,4L,1L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200025Inst : IEnumerable<long>
{
public static readonly long[] Value=A200025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200025.Bytes);
public long this[int i]=>Value[i];

public static A200025Inst Instance=new A200025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200026
{
public static readonly long[] Value={ 9L,5L,5L,9L,0L,8L,7L,9L,8L,4L,8L,1L,6L,1L,3L,4L,1L,3L,5L,3L,7L,3L,0L,1L,4L,3L,9L,5L,8L,4L,4L,0L,6L,1L,0L,3L,5L,9L,4L,8L,9L,8L,6L,6L,8L,6L,7L,5L,3L,9L,4L,3L,2L,8L,6L,5L,9L,3L,6L,8L,9L,4L,2L,2L,4L,3L,3L,7L,9L,9L,4L,8L,6L,9L,8L,5L,4L,7L,3L,9L,0L,1L,1L,1L,9L,1L,2L,8L,8L,5L,8L,4L,3L,9L,8L,0L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200026Inst : IEnumerable<long>
{
public static readonly long[] Value=A200026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200026.Bytes);
public long this[int i]=>Value[i];

public static A200026Inst Instance=new A200026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200027
{
public static readonly long[] Value={ 1L,3L,1L,4L,4L,8L,5L,6L,0L,9L,1L,9L,7L,7L,6L,1L,9L,6L,5L,5L,1L,9L,2L,1L,9L,8L,6L,7L,6L,1L,0L,9L,1L,0L,6L,0L,0L,1L,2L,8L,8L,8L,9L,4L,4L,1L,4L,1L,6L,8L,4L,7L,5L,3L,8L,0L,0L,2L,1L,2L,0L,7L,0L,0L,4L,7L,7L,1L,9L,8L,2L,3L,4L,9L,0L,0L,2L,9L,7L,4L,5L,7L,6L,7L,9L,0L,4L,2L,7L,1L,0L,0L,5L,0L,1L,4L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200027Inst : IEnumerable<long>
{
public static readonly long[] Value=A200027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200027.Bytes);
public long this[int i]=>Value[i];

public static A200027Inst Instance=new A200027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200028
{
public static readonly long[] Value={ 1L,1L,5L,23L,123L,714L,4371L,27789L,181703L,1214166L,8254642L,56915989L,397055129L,2797402939L,19875881883L,142255845279L,1024672816559L,7422364394376L,54034027247172L,395121014784661L,2900916414217452L,21375452831552800L,158025136138734047L,1171770189246765570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200028Inst : IEnumerable<long>
{
public static readonly long[] Value=A200028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200028.Bytes);
public long this[int i]=>Value[i];

public static A200028Inst Instance=new A200028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200029
{
public static readonly long[] Value={ 1L,1L,4L,18L,89L,483L,2765L,16441L,100553L,628496L,3996864L,25778259L,168216339L,1108586737L,7367790912L,49326025289L,332342006775L,2251828394103L,15333892329935L,104883312564708L,720280904233625L,4964456716210287L,34329831032740121L,238109354053880367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200029Inst : IEnumerable<long>
{
public static readonly long[] Value=A200029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200029.Bytes);
public long this[int i]=>Value[i];

public static A200029Inst Instance=new A200029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200030
{
public static readonly long[] Value={ 1L,1L,1L,3L,11L,42L,167L,685L,2879L,12338L,53718L,236961L,1056825L,4757575L,21590295L,98665559L,453663399L,2097270984L,9742489832L,45452945649L,212884993100L,1000597657272L,4718101921367L,22312506322722L,105802828419669L,502945922930746L,2396283673887013L,11441289644315619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200030Inst : IEnumerable<long>
{
public static readonly long[] Value=A200030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200030.Bytes);
public long this[int i]=>Value[i];

public static A200030Inst Instance=new A200030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200031
{
public static readonly BigInteger[] Value={ 1L,5L,25L,150L,1000L,7125L,53125L,409375L,3234375L,26059375L,213296875L,1768625000L,14825156250L,125419296875L,1069473046875L,9182583593750L,79319843750000L,688837802734375L,6010580419921875L,52670308222656250L,463321803125000000L,4089876834521484375L,BigInteger.Parse("36217014743896484375") };
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
public class A200031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200031Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200031.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A200031.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200031Inst Instance=new A200031Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200032
{
public static readonly long[] Value={ 0L,4L,2L,28L,26L,168L,214L,1140L,1882L,7930L,15222L,56732L,122760L,416928L,975508L,3116724L,7715598L,23651892L,60875844L,181428684L,479853296L,1403488666L,3783362306L,10927395294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200032Inst : IEnumerable<long>
{
public static readonly long[] Value=A200032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200032.Bytes);
public long this[int i]=>Value[i];

public static A200032Inst Instance=new A200032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200033
{
public static readonly long[] Value={ 0L,6L,14L,84L,264L,1450L,5268L,25070L,102854L,460146L,1954930L,8681238L,37537698L,165783402L,725328338L,3201189116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200033Inst : IEnumerable<long>
{
public static readonly long[] Value=A200033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200033.Bytes);
public long this[int i]=>Value[i];

public static A200033Inst Instance=new A200033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200034
{
public static readonly long[] Value={ 0L,8L,28L,218L,1074L,7384L,41228L,262004L,1565836L,9730070L,59336930L,368674288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200034Inst : IEnumerable<long>
{
public static readonly long[] Value=A200034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200034.Bytes);
public long this[int i]=>Value[i];

public static A200034Inst Instance=new A200034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200035
{
public static readonly long[] Value={ 0L,10L,52L,444L,3054L,25814L,192280L,1557104L,12157838L,97030120L,768491618L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200035Inst : IEnumerable<long>
{
public static readonly long[] Value=A200035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200035.Bytes);
public long this[int i]=>Value[i];

public static A200035Inst Instance=new A200035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200036
{
public static readonly long[] Value={ 0L,12L,78L,808L,7104L,72220L,674234L,6674940L,64642466L,635825548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200036Inst : IEnumerable<long>
{
public static readonly long[] Value=A200036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200036.Bytes);
public long this[int i]=>Value[i];

public static A200036Inst Instance=new A200036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200037
{
public static readonly long[] Value={ 0L,14L,114L,1330L,14156L,169170L,1882238L,22017152L,254776338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200037Inst : IEnumerable<long>
{
public static readonly long[] Value=A200037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200037.Bytes);
public long this[int i]=>Value[i];

public static A200037Inst Instance=new A200037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200038
{
public static readonly long[] Value={ 0L,0L,2L,0L,4L,0L,0L,6L,2L,2L,0L,8L,14L,28L,0L,0L,10L,28L,84L,26L,2L,0L,12L,52L,218L,264L,168L,0L,0L,14L,78L,444L,1074L,1450L,214L,2L,0L,16L,114L,808L,3054L,7384L,5268L,1140L,0L,0L,18L,152L,1330L,7104L,25814L,41228L,25070L,1882L,2L,0L,20L,200L,2068L,14156L,72220L,192280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200038Inst : IEnumerable<long>
{
public static readonly long[] Value=A200038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200038.Bytes);
public long this[int i]=>Value[i];

public static A200038Inst Instance=new A200038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200039
{
public static readonly long[] Value={ 0L,2L,14L,28L,52L,78L,114L,152L,200L,250L,310L,372L,444L,518L,602L,688L,784L,882L,990L,1100L,1220L,1342L,1474L,1608L,1752L,1898L,2054L,2212L,2380L,2550L,2730L,2912L,3104L,3298L,3502L,3708L,3924L,4142L,4370L,4600L,4840L,5082L,5334L,5588L,5852L,6118L,6394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200039Inst : IEnumerable<long>
{
public static readonly long[] Value=A200039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200039.Bytes);
public long this[int i]=>Value[i];

public static A200039Inst Instance=new A200039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200040
{
public static readonly long[] Value={ 2L,28L,84L,218L,444L,808L,1330L,2068L,2996L,4230L,5740L,7552L,9746L,12348L,15304L,18782L,22732L,27144L,32162L,37784L,43912L,50790L,58332L,66496L,75494L,85280L,95736L,107166L,119452L,132524L,146646L,161752L,177688L,194822L,213008L,232132L,252534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200040Inst : IEnumerable<long>
{
public static readonly long[] Value=A200040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200040.Bytes);
public long this[int i]=>Value[i];

public static A200040Inst Instance=new A200040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200041
{
public static readonly long[] Value={ 0L,26L,264L,1074L,3054L,7104L,14156L,25546L,42928L,67782L,102250L,148624L,209216L,286370L,383924L,503834L,650334L,826512L,1036716L,1283846L,1574252L,1909734L,2297538L,2740864L,3246472L,3817174L,4462780L,5184398L,5992386L,6889492L,7886048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200041Inst : IEnumerable<long>
{
public static readonly long[] Value=A200041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200041.Bytes);
public long this[int i]=>Value[i];

public static A200041Inst Instance=new A200041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200042
{
public static readonly long[] Value={ 2L,168L,1450L,7384L,25814L,72220L,169170L,351964L,667998L,1174860L,1958474L,3119900L,4772250L,7066336L,10146330L,14251004L,19583286L,26418704L,35030826L,45705392L,58910542L,75014652L,94447002L,117742012L,145274026L,177897944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200042Inst : IEnumerable<long>
{
public static readonly long[] Value=A200042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200042.Bytes);
public long this[int i]=>Value[i];

public static A200042Inst Instance=new A200042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200043
{
public static readonly long[] Value={ 0L,214L,5268L,41228L,192280L,674234L,1882238L,4559584L,9869410L,19627458L,36265862L,63537830L,105895974L,169797756L,263132194L,395819648L,579860740L,831059432L,1166406254L,1608524888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200043Inst : IEnumerable<long>
{
public static readonly long[] Value=A200043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200043.Bytes);
public long this[int i]=>Value[i];

public static A200043Inst Instance=new A200043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200044
{
public static readonly long[] Value={ 1L,2L,6L,2L,10L,4L,28L,20L,11L,1L,11L,132L,119L,105L,90L,74L,57L,39L,20L,400L,379L,357L,334L,310L,285L,259L,232L,204L,175L,145L,114L,82L,49L,15L,525L,489L,452L,414L,375L,335L,294L,252L,209L,165L,120L,74L,27L,1296L,1247L,1197L,1146L,1094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200044Inst : IEnumerable<long>
{
public static readonly long[] Value=A200044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200044.Bytes);
public long this[int i]=>Value[i];

public static A200044Inst Instance=new A200044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200045
{
public static readonly long[] Value={ 4L,16L,252L,64L,3912L,228984L,256L,59928L,12870096L,2545607472L,1024L,906912L,696448224L,465659203104L,272454472598400L,4096L,13571712L,36376835616L,79102304162784L,140221913588582784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200045Inst : IEnumerable<long>
{
public static readonly long[] Value=A200045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200045.Bytes);
public long this[int i]=>Value[i];

public static A200045Inst Instance=new A200045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200046
{
public static readonly long[] Value={ 15L,25L,33L,35L,39L,55L,57L,69L,75L,95L,99L,115L,117L,119L,121L,123L,125L,129L,135L,143L,145L,153L,155L,169L,175L,195L,203L,205L,209L,215L,217L,221L,225L,235L,247L,253L,255L,259L,273L,275L,285L,289L,295L,299L,305L,309L,315L,319L,321L,323L,325L,333L,335L,339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200046Inst : IEnumerable<long>
{
public static readonly long[] Value=A200046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200046.Bytes);
public long this[int i]=>Value[i];

public static A200046Inst Instance=new A200046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200047
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,5L,9L,15L,25L,42L,70L,116L,192L,317L,522L,858L,1408L,2307L,3775L,6170L,10074L,16433L,26784L,43623L,71002L,115497L,187777L,305147L,495669L,804839L,1306404L,2119884L,3438952L,5577396L,9043549L,14660810L,23762784L,38509220L,62397495L,101090631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200047Inst : IEnumerable<long>
{
public static readonly long[] Value=A200047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200047.Bytes);
public long this[int i]=>Value[i];

public static A200047Inst Instance=new A200047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200048
{
public static readonly long[] Value={ 4L,59L,220L,581L,1162L,2105L,3370L,5171L,7384L,10319L,13744L,18089L,22990L,29021L,35662L,43655L,52300L,62531L,73444L,86189L,99634L,115169L,131410L,150011L,169312L,191255L,213880L,239441L,265654L,295109L,325174L,358799L,392980L,431051L,469612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200048Inst : IEnumerable<long>
{
public static readonly long[] Value=A200048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200048.Bytes);
public long this[int i]=>Value[i];

public static A200048Inst Instance=new A200048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200049
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,12L,14L,16L,20L,21L,27L,29L,30L,34L,37L,44L,45L,48L,52L,53L,58L,61L,65L,71L,75L,76L,78L,79L,84L,93L,97L,100L,101L,109L,111L,115L,119L,122L,128L,132L,133L,142L,144L,146L,147L,157L,165L,169L,170L,172L,178L,180L,188L,193L,198L,202L,203L,207L,211L,213L,221L,231L,233L,234L,238L,251L,254L,261L,263L,267L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200049Inst : IEnumerable<long>
{
public static readonly long[] Value=A200049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200049.Bytes);
public long this[int i]=>Value[i];

public static A200049Inst Instance=new A200049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200050
{
public static readonly long[] Value={ 1L,2L,9L,35L,54L,104L,135L,209L,350L,405L,594L,740L,819L,989L,1274L,1595L,1710L,2079L,2345L,2484L,2925L,3239L,3740L,4464L,4850L,5049L,5459L,5670L,6104L,7749L,8255L,9044L,9315L,10730L,11025L,11934L,12879L,13529L,14534L,15575L,15930L,17765L,18144L,18914L,19305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200050Inst : IEnumerable<long>
{
public static readonly long[] Value=A200050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200050.Bytes);
public long this[int i]=>Value[i];

public static A200050Inst Instance=new A200050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200051
{
public static readonly long[] Value={ 1L,4L,10L,26L,68L,178L,472L,1276L,3462L,9496L,26024L,71956L,198740L,552814L,1535556L,4290252L,11968194L,33553214L,93917400L,264020106L,741024426L,2087799972L,5872999754L,16577458520L,46720454112L,132081262316L,372843051320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200051Inst : IEnumerable<long>
{
public static readonly long[] Value=A200051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200051.Bytes);
public long this[int i]=>Value[i];

public static A200051Inst Instance=new A200051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200052
{
public static readonly long[] Value={ 1L,6L,22L,78L,288L,1098L,4224L,16432L,64310L,253692L,1003374L,3992358L,15908668L,63684848L,255153798L,1026057576L,4127971346L,16658240722L,67237254862L,272092306164L,1101134446908L,4466186295698L,18113540529096L,73607652658268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200052Inst : IEnumerable<long>
{
public static readonly long[] Value=A200052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200052.Bytes);
public long this[int i]=>Value[i];

public static A200052Inst Instance=new A200052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200053
{
public static readonly long[] Value={ 1L,8L,36L,172L,840L,4172L,20978L,106674L,545698L,2811236L,14534258L,75522854L,393338058L,2056376914L,10767639532L,56550307652L,297322835298L,1567022163228L,8265441146830L,43685281805084L,231022736833454L,1223830782531260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200053Inst : IEnumerable<long>
{
public static readonly long[] Value=A200053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200053.Bytes);
public long this[int i]=>Value[i];

public static A200053Inst Instance=new A200053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200054
{
public static readonly long[] Value={ 1L,10L,56L,324L,1948L,11962L,74338L,466548L,2947742L,18746754L,119701782L,767860824L,4938868628L,31876070432L,206122332340L,1336425077996L,8676994345132L,56457974059982L,367738443114696L,2399500033305708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200054Inst : IEnumerable<long>
{
public static readonly long[] Value=A200054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200054.Bytes);
public long this[int i]=>Value[i];

public static A200054Inst Instance=new A200054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200055
{
public static readonly long[] Value={ 1L,12L,78L,546L,3914L,28554L,211242L,1577878L,11867186L,89815404L,682642050L,5211283212L,39897460856L,306446600454L,2358644800468L,18199380449274L,140644480480176L,1089068472750998L,8443172123261506L,65564035662489652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200055Inst : IEnumerable<long>
{
public static readonly long[] Value=A200055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200055.Bytes);
public long this[int i]=>Value[i];

public static A200055Inst Instance=new A200055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200056
{
public static readonly long[] Value={ 1L,14L,106L,850L,7074L,59910L,514168L,4453946L,38855488L,341052122L,3006680636L,26619825378L,236386648574L,2105717447626L,18798362729604L,168222072625668L,1507848061916274L,13541292792666004L,121763260320351938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200056Inst : IEnumerable<long>
{
public static readonly long[] Value=A200056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200056.Bytes);
public long this[int i]=>Value[i];

public static A200056Inst Instance=new A200056Inst();

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