using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197257
{
public static readonly long[] Value={ 0L,5L,7L,7L,0L,1L,1L,3L,3L,6L,9L,3L,5L,6L,3L,9L,4L,1L,4L,2L,9L,6L,1L,8L,3L,7L,3L,9L,7L,8L,6L,8L,4L,3L,5L,2L,4L,2L,0L,1L,7L,7L,1L,0L,9L,8L,8L,9L,9L,1L,0L,0L,9L,5L,1L,6L,6L,9L,5L,5L,8L,9L,3L,4L,1L,2L,1L,4L,3L,4L,6L,1L,2L,1L,1L,9L,4L,7L,3L,0L,8L,8L,6L,5L,2L,4L,3L,1L,5L,7L,3L,0L,6L,4L,2L,1L,7L,2L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197257Inst : IEnumerable<long>
{
public static readonly long[] Value=A197257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197257.Bytes);
public long this[int i]=>Value[i];

public static A197257Inst Instance=new A197257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197258
{
public static readonly long[] Value={ 0L,4L,1L,9L,6L,1L,4L,0L,5L,6L,7L,7L,5L,6L,5L,8L,5L,0L,8L,5L,6L,3L,0L,0L,3L,6L,1L,6L,5L,8L,7L,5L,4L,1L,2L,3L,6L,9L,2L,8L,2L,8L,5L,7L,1L,3L,6L,7L,0L,1L,3L,4L,1L,4L,0L,0L,9L,3L,9L,3L,3L,1L,9L,0L,6L,1L,8L,4L,6L,7L,5L,0L,3L,0L,8L,5L,6L,8L,4L,5L,1L,2L,1L,1L,7L,1L,0L,2L,9L,5L,9L,6L,4L,7L,4L,8L,9L,5L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197258Inst : IEnumerable<long>
{
public static readonly long[] Value=A197258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197258.Bytes);
public long this[int i]=>Value[i];

public static A197258Inst Instance=new A197258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197259
{
public static readonly long[] Value={ 3L,1L,9L,1L,6L,3L,6L,5L,2L,5L,3L,9L,0L,2L,1L,0L,8L,8L,3L,1L,1L,8L,1L,7L,3L,2L,2L,3L,0L,1L,5L,1L,6L,7L,1L,3L,0L,5L,9L,0L,8L,5L,5L,6L,0L,6L,7L,2L,2L,3L,0L,1L,5L,0L,2L,7L,0L,8L,6L,9L,1L,3L,1L,3L,2L,9L,5L,4L,8L,0L,5L,7L,1L,3L,6L,7L,6L,2L,4L,6L,4L,5L,7L,0L,4L,1L,5L,0L,2L,1L,1L,0L,2L,4L,0L,2L,2L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197259Inst : IEnumerable<long>
{
public static readonly long[] Value=A197259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197259.Bytes);
public long this[int i]=>Value[i];

public static A197259Inst Instance=new A197259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197260
{
public static readonly long[] Value={ 8L,4L,8L,0L,6L,2L,0L,7L,8L,9L,8L,1L,4L,8L,1L,0L,0L,8L,0L,5L,2L,9L,4L,4L,3L,3L,8L,9L,9L,8L,4L,1L,8L,0L,8L,0L,0L,7L,3L,3L,6L,6L,2L,1L,3L,2L,6L,3L,1L,1L,2L,6L,4L,2L,8L,6L,0L,7L,1L,8L,1L,6L,3L,5L,7L,0L,2L,0L,0L,8L,2L,1L,2L,2L,8L,4L,7L,4L,2L,3L,4L,3L,4L,9L,1L,8L,9L,8L,0L,1L,7L,3L,1L,9L,5L,7L,2L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197260Inst : IEnumerable<long>
{
public static readonly long[] Value=A197260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197260.Bytes);
public long this[int i]=>Value[i];

public static A197260Inst Instance=new A197260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197261
{
public static readonly long[] Value={ 6L,5L,0L,2L,4L,0L,6L,1L,8L,2L,1L,7L,6L,1L,8L,1L,9L,2L,0L,9L,5L,5L,5L,5L,1L,7L,2L,7L,3L,4L,6L,7L,0L,5L,1L,4L,8L,8L,1L,6L,7L,2L,1L,1L,4L,3L,0L,9L,4L,0L,6L,0L,7L,6L,9L,4L,8L,4L,8L,6L,7L,4L,7L,8L,6L,7L,8L,6L,3L,3L,2L,9L,0L,5L,2L,3L,5L,6L,7L,7L,7L,5L,0L,5L,1L,8L,0L,1L,1L,8L,3L,8L,6L,6L,6L,8L,0L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197261Inst : IEnumerable<long>
{
public static readonly long[] Value=A197261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197261.Bytes);
public long this[int i]=>Value[i];

public static A197261Inst Instance=new A197261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197262
{
public static readonly long[] Value={ 2L,3L,2L,3L,1L,0L,4L,3L,1L,5L,9L,3L,4L,5L,8L,2L,0L,4L,7L,8L,4L,2L,9L,1L,7L,6L,3L,5L,0L,2L,3L,9L,4L,5L,0L,7L,9L,7L,2L,1L,8L,7L,9L,5L,1L,0L,5L,1L,9L,9L,5L,3L,9L,4L,3L,9L,4L,9L,8L,2L,5L,8L,9L,4L,7L,2L,2L,7L,7L,1L,1L,5L,9L,7L,1L,6L,0L,9L,3L,1L,9L,5L,2L,6L,3L,4L,0L,1L,4L,2L,0L,3L,1L,2L,3L,3L,0L,2L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197262Inst : IEnumerable<long>
{
public static readonly long[] Value=A197262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197262.Bytes);
public long this[int i]=>Value[i];

public static A197262Inst Instance=new A197262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197263
{
public static readonly long[] Value={ 1L,3L,6L,6L,5L,1L,1L,9L,2L,1L,7L,0L,5L,7L,2L,3L,9L,4L,9L,5L,6L,9L,7L,6L,0L,1L,7L,8L,8L,5L,9L,0L,5L,4L,6L,3L,2L,0L,0L,1L,1L,3L,9L,1L,7L,6L,8L,4L,9L,0L,6L,8L,5L,9L,4L,1L,9L,0L,6L,3L,5L,2L,4L,2L,8L,8L,8L,1L,0L,7L,0L,4L,0L,2L,7L,1L,2L,5L,0L,1L,5L,4L,4L,0L,3L,2L,2L,6L,1L,8L,6L,7L,9L,1L,7L,2L,3L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197263Inst : IEnumerable<long>
{
public static readonly long[] Value=A197263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197263.Bytes);
public long this[int i]=>Value[i];

public static A197263Inst Instance=new A197263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197264
{
public static readonly long[] Value={ 0L,9L,0L,9L,9L,0L,6L,1L,6L,4L,1L,2L,2L,7L,4L,9L,8L,3L,4L,6L,9L,5L,3L,8L,9L,3L,5L,3L,6L,1L,2L,8L,9L,9L,4L,3L,6L,8L,2L,4L,6L,8L,8L,8L,3L,9L,8L,8L,8L,1L,3L,3L,9L,4L,2L,5L,5L,6L,0L,0L,0L,0L,3L,8L,2L,8L,1L,1L,1L,9L,7L,5L,6L,7L,0L,0L,7L,3L,6L,3L,0L,1L,4L,5L,3L,0L,8L,1L,6L,2L,1L,4L,3L,9L,8L,0L,1L,8L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197264Inst : IEnumerable<long>
{
public static readonly long[] Value=A197264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197264.Bytes);
public long this[int i]=>Value[i];

public static A197264Inst Instance=new A197264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197265
{
public static readonly long[] Value={ 0L,6L,5L,2L,4L,6L,7L,8L,0L,1L,7L,9L,0L,3L,0L,4L,3L,3L,2L,3L,4L,3L,7L,0L,2L,1L,7L,9L,0L,8L,3L,8L,2L,0L,1L,3L,8L,9L,7L,9L,7L,7L,5L,4L,0L,8L,9L,3L,3L,2L,9L,5L,8L,2L,5L,1L,7L,2L,9L,1L,8L,2L,0L,8L,6L,8L,0L,3L,6L,7L,7L,3L,1L,1L,9L,6L,6L,5L,4L,8L,9L,7L,1L,6L,5L,8L,0L,3L,9L,5L,0L,2L,5L,3L,2L,6L,2L,9L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197265Inst : IEnumerable<long>
{
public static readonly long[] Value=A197265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197265.Bytes);
public long this[int i]=>Value[i];

public static A197265Inst Instance=new A197265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197266
{
public static readonly long[] Value={ 0L,4L,9L,1L,9L,2L,7L,4L,8L,3L,1L,7L,9L,5L,6L,8L,9L,6L,8L,0L,3L,0L,4L,0L,8L,0L,3L,0L,7L,2L,9L,1L,7L,8L,9L,5L,9L,7L,0L,7L,7L,0L,4L,8L,5L,9L,6L,1L,8L,0L,0L,1L,0L,9L,6L,1L,5L,4L,9L,5L,1L,1L,3L,4L,1L,2L,4L,1L,2L,9L,4L,7L,6L,4L,9L,7L,8L,0L,8L,0L,8L,6L,2L,4L,2L,6L,1L,2L,1L,6L,2L,8L,5L,8L,0L,8L,1L,1L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197266Inst : IEnumerable<long>
{
public static readonly long[] Value=A197266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197266.Bytes);
public long this[int i]=>Value[i];

public static A197266Inst Instance=new A197266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197267
{
public static readonly long[] Value={ 6L,8L,2L,9L,8L,2L,6L,9L,9L,1L,6L,0L,0L,8L,1L,6L,8L,7L,9L,7L,7L,0L,8L,0L,8L,5L,5L,6L,2L,5L,3L,8L,7L,1L,7L,0L,7L,5L,1L,0L,3L,8L,8L,1L,6L,9L,0L,3L,2L,1L,8L,2L,3L,8L,0L,9L,1L,2L,8L,1L,5L,8L,6L,2L,4L,8L,7L,5L,0L,5L,7L,0L,1L,5L,0L,4L,3L,4L,5L,0L,0L,3L,5L,3L,9L,5L,1L,3L,2L,7L,6L,7L,9L,0L,3L,1L,2L,6L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197267Inst : IEnumerable<long>
{
public static readonly long[] Value=A197267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197267.Bytes);
public long this[int i]=>Value[i];

public static A197267Inst Instance=new A197267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197268
{
public static readonly long[] Value={ 4L,5L,9L,9L,7L,5L,5L,3L,5L,4L,0L,5L,0L,9L,4L,0L,3L,2L,0L,6L,5L,1L,5L,0L,7L,5L,1L,6L,3L,0L,4L,7L,6L,8L,3L,2L,7L,2L,7L,0L,5L,9L,1L,6L,0L,4L,5L,9L,9L,1L,8L,0L,7L,7L,7L,9L,9L,0L,6L,9L,0L,4L,3L,4L,9L,1L,0L,3L,3L,0L,1L,7L,5L,1L,9L,6L,4L,5L,5L,8L,2L,2L,2L,9L,9L,3L,9L,0L,9L,8L,6L,4L,3L,5L,4L,0L,1L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197268Inst : IEnumerable<long>
{
public static readonly long[] Value=A197268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197268.Bytes);
public long this[int i]=>Value[i];

public static A197268Inst Instance=new A197268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197269
{
public static readonly long[] Value={ 3L,4L,2L,5L,6L,6L,4L,7L,6L,2L,7L,7L,5L,2L,2L,2L,4L,3L,6L,3L,6L,0L,3L,7L,7L,4L,5L,7L,7L,0L,8L,8L,5L,7L,1L,1L,6L,3L,4L,2L,6L,7L,2L,1L,5L,6L,2L,4L,3L,6L,3L,2L,1L,7L,7L,4L,3L,4L,4L,7L,7L,3L,3L,8L,2L,6L,7L,6L,2L,3L,6L,6L,5L,5L,6L,4L,0L,9L,8L,4L,5L,0L,0L,7L,5L,9L,4L,0L,0L,0L,4L,2L,6L,6L,0L,2L,9L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197269Inst : IEnumerable<long>
{
public static readonly long[] Value=A197269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197269.Bytes);
public long this[int i]=>Value[i];

public static A197269Inst Instance=new A197269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197270
{
public static readonly long[] Value={ 3L,0L,3L,8L,9L,0L,4L,1L,6L,4L,3L,4L,4L,2L,6L,1L,1L,6L,8L,6L,8L,0L,6L,5L,3L,3L,9L,5L,8L,6L,5L,2L,0L,4L,0L,2L,9L,4L,0L,7L,7L,8L,4L,6L,0L,7L,2L,6L,8L,8L,6L,8L,2L,0L,5L,2L,6L,4L,5L,7L,8L,4L,0L,0L,4L,7L,6L,0L,3L,5L,2L,6L,4L,5L,0L,0L,7L,5L,7L,2L,5L,9L,6L,5L,9L,4L,1L,5L,5L,4L,7L,6L,1L,0L,6L,9L,6L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197270Inst : IEnumerable<long>
{
public static readonly long[] Value=A197270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197270.Bytes);
public long this[int i]=>Value[i];

public static A197270Inst Instance=new A197270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197271
{
public static readonly BigInteger[] Value={ 5L,2L,5L,20L,100L,570L,3542L,23400L,161820L,1159400L,8544965L,64448228L,495508780L,3872033900L,30680401500L,246041115600L,1993987498284L,16310419381080L,134519771966180L,1117653277802000L,9347742311507600L,78652006531467930L,665393840873409150L,5657273782416664200L,BigInteger.Parse("48318619683648190500") };
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
public class A197271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197271Inst Instance=new A197271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197272
{
public static readonly long[] Value={ 3L,1L,3L,15L,95L,690L,5481L,46376L,411255L,3781635L,35791910L,346821930L,3427001253L,34425730640L,350732771160L,3617153918640L,37703805776935L,396716804816265L,4209161209968825L,44993046668984145L,484176486362971710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197272Inst : IEnumerable<long>
{
public static readonly long[] Value=A197272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197272.Bytes);
public long this[int i]=>Value[i];

public static A197272Inst Instance=new A197272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197273
{
public static readonly long[] Value={ 1L,9L,34L,627L,16890L,1276986L,209785488L,84453386767L,71088592371829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197273Inst : IEnumerable<long>
{
public static readonly long[] Value=A197273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197273.Bytes);
public long this[int i]=>Value[i];

public static A197273Inst Instance=new A197273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197274
{
public static readonly long[] Value={ 3L,9L,14L,29L,67L,134L,275L,583L,1210L,2511L,5245L,10926L,22745L,47405L,98774L,205765L,428731L,893294L,1861163L,3877815L,8079642L,16834247L,35074949L,73080470L,152266769L,317255517L,661018310L,1377265789L,2869604691L,5978971062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197274Inst : IEnumerable<long>
{
public static readonly long[] Value=A197274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197274.Bytes);
public long this[int i]=>Value[i];

public static A197274Inst Instance=new A197274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197275
{
public static readonly long[] Value={ 4L,14L,34L,92L,317L,888L,2626L,8078L,24103L,72107L,217970L,656610L,1975147L,5955136L,17950843L,54086244L,163025795L,491430743L,1481229421L,4464844849L,13458804609L,40569450638L,122290929298L,368632726282L,1111201586358L,3349591968789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197275Inst : IEnumerable<long>
{
public static readonly long[] Value=A197275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197275.Bytes);
public long this[int i]=>Value[i];

public static A197275Inst Instance=new A197275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197276
{
public static readonly long[] Value={ 5L,29L,92L,627L,2731L,11850L,57137L,276689L,1344992L,6445595L,30716245L,146763830L,705198523L,3392533967L,16288546542L,78114416927L,374644274789L,1797996141058L,8631814710395L,41433944954559L,198846557512440L,954242657026897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197276Inst : IEnumerable<long>
{
public static readonly long[] Value=A197276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197276.Bytes);
public long this[int i]=>Value[i];

public static A197276Inst Instance=new A197276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197277
{
public static readonly long[] Value={ 9L,67L,317L,2731L,16890L,114205L,886737L,6017949L,40918349L,290053910L,2074566978L,14599100959L,101671464178L,714232555115L,5052846176923L,35608078988237L,249861298059545L,1755724243450685L,12370064599008231L,87120870560445460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197277Inst : IEnumerable<long>
{
public static readonly long[] Value=A197277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197277.Bytes);
public long this[int i]=>Value[i];

public static A197277Inst Instance=new A197277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197278
{
public static readonly long[] Value={ 16L,134L,888L,11850L,114205L,1276986L,13500114L,135563958L,1464662469L,15975572837L,167590942240L,1768832921236L,19029812782209L,203511535493020L,2157669619156227L,22971322152723986L,245668877166018309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197278Inst : IEnumerable<long>
{
public static readonly long[] Value=A197278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197278.Bytes);
public long this[int i]=>Value[i];

public static A197278Inst Instance=new A197278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197279
{
public static readonly ulong[] Value={ 25L,275L,2626L,57137L,886737L,13500114L,209785488L,3332948197L,55701159000L,888511016495L,14113426224907L,227682122103328L,3670040705518361L,58842498077190676L,948189035889733725L,15294961470395061151UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197279Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A197279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197279.Bytes);
public ulong this[int i]=>Value[i];

public static A197279Inst Instance=new A197279Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197280
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,14L,14L,5L,9L,29L,34L,29L,9L,16L,67L,92L,92L,67L,16L,25L,134L,317L,627L,317L,134L,25L,39L,275L,888L,2731L,2731L,888L,275L,39L,64L,583L,2626L,11850L,16890L,11850L,2626L,583L,64L,105L,1210L,8078L,57137L,114205L,114205L,57137L,8078L,1210L,105L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197280Inst : IEnumerable<long>
{
public static readonly long[] Value=A197280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197280.Bytes);
public long this[int i]=>Value[i];

public static A197280Inst Instance=new A197280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197281
{
public static readonly long[] Value={ 2L,7L,3L,1L,7L,7L,2L,4L,4L,0L,3L,4L,0L,4L,1L,0L,3L,4L,3L,5L,1L,3L,8L,1L,8L,3L,1L,5L,4L,6L,0L,3L,4L,6L,5L,1L,8L,6L,8L,5L,3L,2L,4L,2L,4L,0L,1L,0L,9L,4L,6L,9L,6L,2L,7L,7L,0L,2L,1L,2L,7L,9L,8L,8L,8L,0L,1L,6L,2L,3L,6L,6L,0L,1L,7L,7L,8L,8L,4L,7L,1L,0L,3L,0L,4L,0L,7L,8L,8L,8L,4L,1L,5L,2L,3L,8L,2L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197281Inst : IEnumerable<long>
{
public static readonly long[] Value=A197281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197281.Bytes);
public long this[int i]=>Value[i];

public static A197281Inst Instance=new A197281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197282
{
public static readonly long[] Value={ 2L,4L,8L,2L,0L,2L,9L,3L,0L,5L,3L,6L,7L,1L,0L,5L,5L,1L,0L,9L,2L,9L,7L,9L,2L,1L,7L,3L,8L,9L,8L,0L,7L,3L,2L,1L,7L,3L,3L,4L,9L,4L,7L,5L,1L,3L,2L,5L,8L,2L,3L,9L,5L,5L,5L,9L,3L,4L,7L,5L,1L,8L,2L,3L,9L,5L,7L,8L,9L,0L,9L,7L,2L,7L,9L,5L,8L,9L,2L,3L,5L,6L,4L,4L,1L,7L,3L,6L,1L,2L,1L,1L,9L,9L,9L,7L,5L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197282Inst : IEnumerable<long>
{
public static readonly long[] Value=A197282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197282.Bytes);
public long this[int i]=>Value[i];

public static A197282Inst Instance=new A197282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197283
{
public static readonly long[] Value={ 5L,6L,9L,3L,4L,5L,9L,5L,6L,7L,0L,4L,0L,5L,4L,4L,9L,1L,2L,2L,5L,4L,7L,4L,0L,0L,3L,5L,6L,9L,6L,1L,5L,2L,8L,7L,3L,5L,1L,0L,1L,5L,8L,6L,7L,8L,9L,8L,6L,4L,7L,2L,3L,8L,0L,8L,2L,9L,2L,3L,8L,1L,8L,6L,4L,7L,2L,6L,5L,4L,0L,2L,2L,8L,9L,6L,7L,4L,2L,0L,9L,3L,8L,1L,6L,0L,3L,2L,1L,0L,6L,4L,0L,9L,3L,0L,4L,2L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197283Inst : IEnumerable<long>
{
public static readonly long[] Value=A197283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197283.Bytes);
public long this[int i]=>Value[i];

public static A197283Inst Instance=new A197283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197284
{
public static readonly long[] Value={ 4L,8L,0L,7L,8L,7L,5L,9L,8L,2L,7L,9L,7L,1L,6L,9L,5L,2L,9L,0L,4L,8L,1L,9L,9L,1L,3L,7L,2L,7L,2L,5L,3L,5L,1L,0L,8L,1L,4L,6L,8L,1L,3L,4L,5L,3L,5L,8L,8L,3L,6L,7L,4L,7L,3L,8L,1L,4L,2L,7L,0L,6L,8L,2L,7L,7L,7L,5L,0L,5L,4L,8L,8L,6L,4L,3L,5L,7L,5L,6L,7L,3L,2L,2L,2L,7L,7L,9L,2L,1L,5L,2L,6L,5L,4L,2L,1L,9L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197284Inst : IEnumerable<long>
{
public static readonly long[] Value=A197284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197284.Bytes);
public long this[int i]=>Value[i];

public static A197284Inst Instance=new A197284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197285
{
public static readonly long[] Value={ 4L,0L,9L,7L,8L,0L,0L,0L,6L,7L,3L,3L,9L,4L,5L,9L,4L,1L,3L,9L,5L,7L,6L,8L,7L,7L,6L,3L,6L,5L,5L,0L,3L,9L,7L,1L,7L,2L,5L,8L,9L,2L,1L,1L,7L,0L,4L,0L,7L,6L,3L,9L,7L,0L,5L,4L,3L,4L,2L,1L,3L,3L,3L,7L,6L,6L,0L,2L,7L,9L,7L,5L,2L,0L,1L,4L,3L,5L,9L,1L,0L,9L,7L,9L,8L,7L,3L,5L,6L,5L,1L,8L,2L,3L,0L,8L,8L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197285Inst : IEnumerable<long>
{
public static readonly long[] Value=A197285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197285.Bytes);
public long this[int i]=>Value[i];

public static A197285Inst Instance=new A197285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197286
{
public static readonly long[] Value={ 3L,5L,5L,8L,1L,3L,9L,9L,1L,8L,4L,9L,5L,2L,3L,2L,2L,8L,6L,2L,9L,3L,4L,2L,4L,4L,3L,7L,5L,4L,0L,0L,9L,5L,5L,9L,1L,0L,2L,9L,1L,3L,9L,5L,4L,6L,4L,1L,9L,1L,6L,9L,8L,2L,2L,8L,2L,6L,2L,7L,5L,4L,9L,8L,1L,3L,2L,6L,5L,9L,1L,4L,5L,7L,3L,8L,1L,4L,4L,6L,2L,2L,0L,8L,6L,1L,9L,6L,7L,5L,0L,1L,4L,9L,2L,6L,8L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197286Inst : IEnumerable<long>
{
public static readonly long[] Value=A197286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197286.Bytes);
public long this[int i]=>Value[i];

public static A197286Inst Instance=new A197286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197287
{
public static readonly long[] Value={ 2L,8L,1L,2L,2L,6L,9L,7L,5L,6L,8L,6L,2L,0L,2L,8L,3L,5L,2L,4L,7L,0L,0L,9L,2L,3L,1L,9L,9L,3L,4L,1L,0L,9L,0L,6L,5L,4L,2L,9L,2L,4L,6L,3L,7L,1L,1L,1L,0L,3L,6L,6L,4L,1L,9L,3L,7L,3L,6L,8L,7L,0L,1L,9L,5L,0L,7L,4L,5L,9L,2L,1L,6L,3L,6L,3L,8L,1L,2L,6L,9L,8L,8L,0L,3L,1L,3L,7L,6L,6L,5L,1L,2L,7L,7L,1L,2L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197287Inst : IEnumerable<long>
{
public static readonly long[] Value=A197287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197287.Bytes);
public long this[int i]=>Value[i];

public static A197287Inst Instance=new A197287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197288
{
public static readonly long[] Value={ 2L,5L,4L,5L,9L,6L,5L,2L,2L,5L,2L,8L,1L,5L,6L,4L,7L,3L,1L,2L,9L,5L,9L,7L,0L,4L,6L,5L,7L,5L,6L,9L,7L,9L,9L,7L,2L,8L,4L,1L,2L,5L,9L,9L,9L,0L,1L,6L,4L,1L,6L,9L,9L,1L,7L,3L,3L,9L,5L,8L,9L,7L,2L,6L,5L,1L,2L,5L,7L,5L,8L,8L,4L,2L,2L,3L,5L,0L,9L,9L,6L,0L,2L,1L,0L,3L,6L,4L,1L,9L,8L,2L,9L,5L,2L,9L,7L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197288Inst : IEnumerable<long>
{
public static readonly long[] Value=A197288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197288.Bytes);
public long this[int i]=>Value[i];

public static A197288Inst Instance=new A197288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197289
{
public static readonly long[] Value={ 2L,3L,2L,6L,3L,6L,4L,7L,7L,0L,8L,0L,3L,2L,6L,3L,4L,9L,8L,1L,9L,2L,2L,6L,9L,2L,0L,1L,8L,9L,0L,3L,3L,9L,2L,9L,9L,8L,4L,8L,0L,7L,3L,7L,1L,1L,6L,1L,9L,4L,6L,7L,1L,0L,7L,7L,4L,7L,8L,1L,3L,1L,3L,8L,4L,2L,3L,3L,1L,4L,4L,6L,8L,0L,2L,5L,1L,7L,8L,8L,1L,7L,5L,1L,9L,2L,9L,6L,5L,6L,0L,1L,7L,7L,6L,2L,8L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197289Inst : IEnumerable<long>
{
public static readonly long[] Value=A197289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197289.Bytes);
public long this[int i]=>Value[i];

public static A197289Inst Instance=new A197289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197290
{
public static readonly long[] Value={ 4L,8L,6L,8L,2L,4L,8L,8L,2L,0L,1L,2L,6L,5L,0L,8L,9L,5L,4L,0L,4L,4L,1L,2L,6L,4L,0L,5L,3L,3L,2L,3L,5L,9L,2L,9L,6L,2L,0L,7L,4L,8L,1L,6L,9L,6L,8L,2L,4L,7L,8L,1L,0L,8L,1L,2L,6L,1L,6L,5L,2L,1L,1L,2L,6L,6L,2L,8L,9L,5L,2L,0L,6L,1L,8L,9L,4L,0L,1L,2L,0L,5L,1L,2L,8L,9L,0L,8L,4L,5L,3L,9L,3L,2L,1L,2L,9L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197290Inst : IEnumerable<long>
{
public static readonly long[] Value=A197290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197290.Bytes);
public long this[int i]=>Value[i];

public static A197290Inst Instance=new A197290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197291
{
public static readonly long[] Value={ 4L,2L,4L,0L,3L,1L,0L,3L,9L,4L,9L,0L,7L,4L,0L,5L,0L,4L,0L,2L,6L,4L,7L,2L,1L,6L,9L,4L,9L,9L,2L,0L,9L,0L,4L,0L,0L,3L,6L,6L,8L,3L,1L,0L,6L,6L,3L,1L,5L,5L,6L,3L,2L,1L,4L,3L,0L,3L,5L,9L,0L,8L,1L,7L,8L,5L,1L,0L,0L,4L,1L,0L,6L,1L,4L,2L,3L,7L,1L,1L,7L,1L,7L,4L,5L,9L,4L,9L,0L,0L,8L,6L,5L,9L,7L,8L,6L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197291Inst : IEnumerable<long>
{
public static readonly long[] Value=A197291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197291.Bytes);
public long this[int i]=>Value[i];

public static A197291Inst Instance=new A197291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197292
{
public static readonly long[] Value={ 3L,6L,9L,0L,4L,9L,5L,7L,2L,5L,9L,8L,0L,3L,0L,1L,6L,7L,6L,7L,2L,3L,5L,5L,1L,5L,3L,3L,9L,2L,8L,4L,5L,6L,8L,0L,0L,2L,3L,3L,4L,9L,2L,1L,5L,1L,3L,3L,8L,1L,0L,8L,8L,2L,2L,2L,5L,5L,1L,3L,0L,6L,9L,1L,4L,4L,5L,7L,0L,1L,1L,2L,9L,9L,2L,4L,5L,4L,2L,6L,4L,6L,7L,1L,1L,3L,9L,0L,4L,2L,8L,9L,5L,3L,9L,0L,2L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197292Inst : IEnumerable<long>
{
public static readonly long[] Value=A197292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197292.Bytes);
public long this[int i]=>Value[i];

public static A197292Inst Instance=new A197292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197293
{
public static readonly long[] Value={ 3L,2L,5L,1L,2L,0L,3L,0L,9L,1L,0L,8L,8L,0L,9L,0L,9L,6L,0L,4L,7L,7L,7L,7L,5L,8L,6L,3L,6L,7L,3L,3L,5L,2L,5L,7L,4L,4L,0L,8L,3L,6L,0L,5L,7L,1L,5L,4L,7L,0L,3L,0L,3L,8L,4L,7L,4L,2L,4L,3L,3L,7L,3L,9L,3L,3L,9L,3L,1L,6L,6L,4L,5L,2L,6L,1L,7L,8L,3L,8L,8L,7L,5L,2L,5L,9L,0L,0L,5L,9L,1L,8L,4L,9L,0L,4L,3L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197293Inst : IEnumerable<long>
{
public static readonly long[] Value=A197293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197293.Bytes);
public long this[int i]=>Value[i];

public static A197293Inst Instance=new A197293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197294
{
public static readonly long[] Value={ 2L,9L,0L,1L,0L,8L,8L,4L,1L,7L,7L,1L,7L,9L,3L,8L,3L,8L,9L,6L,9L,3L,4L,0L,7L,8L,6L,1L,4L,0L,4L,6L,7L,1L,5L,8L,7L,3L,3L,0L,7L,5L,3L,0L,1L,6L,2L,3L,0L,3L,3L,9L,8L,2L,0L,4L,7L,3L,1L,3L,6L,3L,5L,2L,6L,7L,1L,3L,5L,2L,1L,0L,8L,9L,9L,3L,2L,8L,2L,6L,8L,1L,8L,0L,6L,6L,8L,0L,8L,3L,0L,8L,0L,6L,9L,5L,3L,2L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197294Inst : IEnumerable<long>
{
public static readonly long[] Value=A197294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197294.Bytes);
public long this[int i]=>Value[i];

public static A197294Inst Instance=new A197294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197295
{
public static readonly long[] Value={ 1L,6L,4L,5L,6L,3L,8L,0L,7L,2L,7L,9L,3L,5L,6L,6L,8L,7L,8L,2L,4L,4L,0L,5L,9L,7L,8L,5L,5L,1L,8L,8L,8L,5L,7L,9L,0L,0L,9L,1L,1L,9L,6L,3L,4L,1L,0L,0L,0L,7L,3L,6L,1L,0L,7L,9L,2L,9L,5L,0L,9L,5L,0L,8L,8L,4L,4L,0L,9L,3L,4L,1L,6L,0L,9L,4L,4L,5L,6L,1L,0L,1L,3L,6L,4L,0L,0L,3L,9L,6L,2L,5L,2L,7L,9L,2L,1L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197295Inst : IEnumerable<long>
{
public static readonly long[] Value=A197295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197295.Bytes);
public long this[int i]=>Value[i];

public static A197295Inst Instance=new A197295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197296
{
public static readonly long[] Value={ 1L,1L,6L,1L,5L,5L,2L,1L,5L,7L,9L,6L,7L,2L,9L,1L,0L,2L,3L,9L,2L,1L,4L,5L,8L,8L,1L,7L,5L,1L,1L,9L,7L,2L,5L,3L,9L,8L,6L,0L,9L,3L,9L,7L,5L,5L,2L,5L,9L,9L,7L,6L,9L,7L,1L,9L,7L,4L,9L,1L,2L,9L,4L,7L,3L,6L,1L,3L,8L,5L,5L,7L,9L,8L,5L,8L,0L,4L,6L,5L,9L,7L,6L,3L,1L,7L,0L,0L,7L,1L,0L,1L,5L,6L,1L,6L,5L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197296Inst : IEnumerable<long>
{
public static readonly long[] Value=A197296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197296.Bytes);
public long this[int i]=>Value[i];

public static A197296Inst Instance=new A197296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197297
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,29L,37L,41L,53L,59L,97L,127L,137L,149L,191L,223L,307L,331L,337L,347L,419L,541L,557L,809L,967L,1009L,1213L,1277L,1399L,1409L,1423L,1973L,2203L,2237L,2591L,2609L,2617L,2633L,2647L,2657L,3163L,3299L,4861L,4871L,4889L,4903L,4931L,5381L,7411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197297Inst : IEnumerable<long>
{
public static readonly long[] Value=A197297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197297.Bytes);
public long this[int i]=>Value[i];

public static A197297Inst Instance=new A197297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197298
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,43L,47L,59L,73L,97L,107L,109L,139L,179L,233L,263L,277L,283L,337L,347L,409L,419L,547L,643L,683L,809L,811L,821L,823L,863L,983L,991L,997L,1031L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197298Inst : IEnumerable<long>
{
public static readonly long[] Value=A197298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197298.Bytes);
public long this[int i]=>Value[i];

public static A197298Inst Instance=new A197298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197299
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,23L,31L,37L,41L,43L,47L,53L,59L,67L,73L,83L,89L,101L,103L,137L,163L,167L,179L,197L,211L,223L,239L,251L,277L,331L,379L,397L,431L,463L,467L,521L,577L,593L,601L,613L,617L,719L,809L,881L,919L,967L,1091L,1123L,1129L,1237L,1249L,1289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197299Inst : IEnumerable<long>
{
public static readonly long[] Value=A197299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197299.Bytes);
public long this[int i]=>Value[i];

public static A197299Inst Instance=new A197299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197300
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,47L,59L,61L,67L,71L,89L,97L,109L,137L,139L,167L,173L,191L,223L,229L,239L,241L,269L,271L,293L,311L,331L,347L,367L,401L,431L,433L,457L,503L,509L,571L,577L,661L,709L,719L,733L,739L,797L,911L,919L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197300Inst : IEnumerable<long>
{
public static readonly long[] Value=A197300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197300.Bytes);
public long this[int i]=>Value[i];

public static A197300Inst Instance=new A197300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197301
{
public static readonly long[] Value={ 1L,7L,31L,639L,27709L,2533633L,638181656L,388800452625L,561392899488562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197301Inst : IEnumerable<long>
{
public static readonly long[] Value=A197301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197301.Bytes);
public long this[int i]=>Value[i];

public static A197301Inst Instance=new A197301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197302
{
public static readonly long[] Value={ 2L,10L,31L,98L,344L,1139L,3750L,12470L,41479L,137872L,458412L,1524061L,5066480L,16842888L,55992885L,186143874L,618820898L,2057222809L,6839076870L,22735974296L,75583965757L,251272978516L,835337355004L,2777013682031L,9231964714182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197302Inst : IEnumerable<long>
{
public static readonly long[] Value=A197302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197302.Bytes);
public long this[int i]=>Value[i];

public static A197302Inst Instance=new A197302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197303
{
public static readonly long[] Value={ 3L,23L,98L,639L,3181L,15930L,85087L,450159L,2373372L,12475923L,65599353L,345356968L,1818230847L,9570445721L,50371708666L,265125975409L,1395500272249L,7345271614306L,38661877327141L,203496642084359L,1071104859201058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197303Inst : IEnumerable<long>
{
public static readonly long[] Value=A197303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197303.Bytes);
public long this[int i]=>Value[i];

public static A197303Inst Instance=new A197303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197304
{
public static readonly long[] Value={ 5L,57L,344L,3181L,27709L,207538L,1711736L,14233577L,115744195L,943877937L,7722480242L,63119151256L,515801027829L,4215541002540L,34452043410657L,281566682942645L,2301175324848852L,18806797415174573L,153702262527792157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197304Inst : IEnumerable<long>
{
public static readonly long[] Value=A197304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197304.Bytes);
public long this[int i]=>Value[i];

public static A197304Inst Instance=new A197304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197305
{
public static readonly long[] Value={ 8L,122L,1139L,15930L,207538L,2533633L,32070816L,406507906L,5121683931L,64661725576L,817020106978L,10316814032165L,130270307404176L,1645111173920002L,20774993393517759L,262348958240337732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197305Inst : IEnumerable<long>
{
public static readonly long[] Value=A197305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197305.Bytes);
public long this[int i]=>Value[i];

public static A197305Inst Instance=new A197305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197306
{
public static readonly BigInteger[] Value={ 13L,275L,3750L,85087L,1711736L,32070816L,638181656L,12585831905L,246443960437L,4851375382650L,95481614034558L,1877187670574508L,36916252065609179L,726088509349589766L,14280238700708392851UL,BigInteger.Parse("280852355095712813555") };
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
public class A197306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197306.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197306Inst Instance=new A197306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197307
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,10L,10L,3L,5L,23L,31L,23L,5L,8L,57L,98L,98L,57L,8L,13L,122L,344L,639L,344L,122L,13L,21L,275L,1139L,3181L,3181L,1139L,275L,21L,34L,623L,3750L,15930L,27709L,15930L,3750L,623L,34L,55L,1394L,12470L,85087L,207538L,207538L,85087L,12470L,1394L,55L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197307Inst : IEnumerable<long>
{
public static readonly long[] Value=A197307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197307.Bytes);
public long this[int i]=>Value[i];

public static A197307Inst Instance=new A197307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197308
{
public static readonly long[] Value={ 1L,11L,73L,101L,137L,803L,1111L,1507L,7373L,10001L,13837L,81103L,110011L,152207L,1010101L,11111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197308Inst : IEnumerable<long>
{
public static readonly long[] Value=A197308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197308.Bytes);
public long this[int i]=>Value[i];

public static A197308Inst Instance=new A197308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197309
{
public static readonly long[] Value={ 1L,3L,9L,37L,111L,333L,333667L,1001001L,3003003L,12345679L,37037037L,111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197309Inst : IEnumerable<long>
{
public static readonly long[] Value=A197309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197309.Bytes);
public long this[int i]=>Value[i];

public static A197309Inst Instance=new A197309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197310
{
public static readonly long[] Value={ 1L,0L,5L,160L,1033L,24704L,2241018L,282284587L,82874179361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197310Inst : IEnumerable<long>
{
public static readonly long[] Value=A197310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197310.Bytes);
public long this[int i]=>Value[i];

public static A197310Inst Instance=new A197310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197311
{
public static readonly long[] Value={ 1L,0L,3L,2L,9L,6L,27L,18L,83L,56L,257L,176L,797L,556L,2475L,1766L,7699L,5640L,23995L,18106L,74937L,58408L,234541L,189266L,735771L,615834L,2313757L,2011340L,7294375L,6591454L,23056393L,21667064L,73073221L,71416640L,232226565L,235964308L,740061147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197311Inst : IEnumerable<long>
{
public static readonly long[] Value=A197311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197311.Bytes);
public long this[int i]=>Value[i];

public static A197311Inst Instance=new A197311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197312
{
public static readonly long[] Value={ 2L,3L,5L,10L,128L,79L,249L,662L,2767L,3969L,14343L,26565L,85744L,172877L,540761L,1086259L,3216870L,6970421L,19943621L,43866426L,122208464L,276719535L,753092637L,1739409216L,4652758432L,10905015671L,28759884710L,68307698666L,178118628885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197312Inst : IEnumerable<long>
{
public static readonly long[] Value=A197312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197312.Bytes);
public long this[int i]=>Value[i];

public static A197312Inst Instance=new A197312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197313
{
public static readonly long[] Value={ 1L,2L,10L,160L,152L,790L,2724L,6242L,26422L,91756L,281296L,990140L,3437208L,11190922L,37836768L,129296206L,433975472L,1455029298L,4951850734L,16696765546L,56134653324L,190052231444L,641906625424L,2162290128232L,7306324921304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197313Inst : IEnumerable<long>
{
public static readonly long[] Value=A197313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197313.Bytes);
public long this[int i]=>Value[i];

public static A197313Inst Instance=new A197313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197314
{
public static readonly long[] Value={ 2L,9L,128L,152L,1033L,4780L,24903L,113774L,553807L,2751427L,13385323L,64601708L,318081207L,1550881210L,7598781154L,37018138503L,181198882339L,884596380240L,4326961466564L,21126289404408L,103287098681855L,504482396779592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197314Inst : IEnumerable<long>
{
public static readonly long[] Value=A197314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197314.Bytes);
public long this[int i]=>Value[i];

public static A197314Inst Instance=new A197314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197315
{
public static readonly long[] Value={ 4L,6L,79L,790L,4780L,24704L,189212L,1400102L,8813744L,62844698L,436492213L,3010736948L,20777197101L,144191070226L,998239321771L,6903357295660L,47811537748912L,330940337259970L,2291691748249353L,15860451380186238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197315Inst : IEnumerable<long>
{
public static readonly long[] Value=A197315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197315.Bytes);
public long this[int i]=>Value[i];

public static A197315Inst Instance=new A197315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197316
{
public static readonly long[] Value={ 2L,27L,249L,2724L,24903L,189212L,2241018L,20425821L,208960627L,1984221109L,20223402011L,195734767851L,1964217477394L,19163046359315L,191509608470344L,1875354477655910L,18682249962661264L,183413216662448071L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197316Inst : IEnumerable<long>
{
public static readonly long[] Value=A197316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197316.Bytes);
public long this[int i]=>Value[i];

public static A197316Inst Instance=new A197316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197317
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,2L,1L,3L,3L,1L,2L,2L,5L,2L,2L,4L,9L,10L,10L,9L,4L,2L,6L,128L,160L,128L,6L,2L,4L,27L,79L,152L,152L,79L,27L,4L,8L,18L,249L,790L,1033L,790L,249L,18L,8L,4L,83L,662L,2724L,4780L,4780L,2724L,662L,83L,4L,8L,56L,2767L,6242L,24903L,24704L,24903L,6242L,2767L,56L,8L,16L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197317Inst : IEnumerable<long>
{
public static readonly long[] Value=A197317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197317.Bytes);
public long this[int i]=>Value[i];

public static A197317Inst Instance=new A197317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197318
{
public static readonly long[] Value={ 1L,3L,7L,11L,13L,21L,33L,37L,39L,77L,91L,101L,111L,143L,231L,259L,273L,303L,407L,429L,481L,707L,777L,1001L,1111L,1221L,1313L,1443L,2121L,2849L,3003L,3333L,3367L,3737L,3939L,5291L,7777L,8547L,9191L,9901L,10101L,11211L,14443L,15873L,23331L,26159L,27573L,29703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197318Inst : IEnumerable<long>
{
public static readonly long[] Value=A197318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197318.Bytes);
public long this[int i]=>Value[i];

public static A197318Inst Instance=new A197318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197319
{
public static readonly long[] Value={ 22846L,364426L,400036L,280840L,381442L,351232L,72964L,895162L,1347868L,4289842L,1145458L,1096462L,8301784L,1025596L,9687706L,35668L,9521416L,2232424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197319Inst : IEnumerable<long>
{
public static readonly long[] Value=A197319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197319.Bytes);
public long this[int i]=>Value[i];

public static A197319Inst Instance=new A197319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197320
{
public static readonly BigInteger[] Value={ 1L,2L,31L,2024L,522241L,536215712L,2198218022911L,36024948845706368L,BigInteger.Parse("2361111184527977349121"),BigInteger.Parse("618964706995596541734949376"),BigInteger.Parse("649035559893095618486323487178751"),BigInteger.Parse("2722257150515888128204116425527951075328"),BigInteger.Parse("45671917999814457716384401535256546748378644481") };
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
public class A197320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197320.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197320Inst Instance=new A197320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197321
{
public static readonly BigInteger[] Value={ 1L,88L,4224L,146432L,4100096L,98402304L,2099249152L,40785412096L,734137417728L,12398765277184L,198380244434944L,3029807369551872L,44437174753427456L,628956934971588608L,8625695108181786624L,BigInteger.Parse("115009268109090488320"),BigInteger.Parse("1495120485418176348160"),BigInteger.Parse("18996824991195652423680") };
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
public class A197321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197321Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197321.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197321.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197321Inst Instance=new A197321Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197322
{
public static readonly BigInteger[] Value={ 3L,20L,254L,4632L,110408L,3243617L,113177496L,4570858599L,209655304352L,10763674952097L,611433842280387L,38071427445729200L,2578294348444597266L,BigInteger.Parse("188670154792420320214"),BigInteger.Parse("14834716200104606205407"),BigInteger.Parse("1247263229999781126495327"),BigInteger.Parse("111661618863544248806155259") };
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
public class A197322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197322.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197322Inst Instance=new A197322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197323
{
public static readonly BigInteger[] Value={ 4L,42L,813L,22518L,811368L,35946075L,1888624971L,114746269757L,7912720985079L,610470884770406L,52094956940751710L,4871691779130290166L,BigInteger.Parse("495409898474358881326"),BigInteger.Parse("54427906182810588386673"),BigInteger.Parse("6424384909407981686846705"),BigInteger.Parse("810777549111969648699638306"),BigInteger.Parse("108944087230453697240059783283") };
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
public class A197323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197323Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197323.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197323.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197323Inst Instance=new A197323Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197324
{
public static readonly BigInteger[] Value={ 5L,72L,1876L,69729L,3363232L,199205126L,13982257728L,1134344816184L,104416147080711L,10750872867074586L,1224163955433850943L,BigInteger.Parse("152733676280699540998"),BigInteger.Parse("20719969553916698313304"),BigInteger.Parse("3036565789908881887393113"),BigInteger.Parse("478082645334119488823777214"),BigInteger.Parse("80475210949356295594385157620") };
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
public class A197324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197324Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197324.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197324.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197324Inst Instance=new A197324Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197325
{
public static readonly BigInteger[] Value={ 6L,110L,3605L,168151L,10162550L,753640010L,66200225626L,6719243243859L,773662803646264L,99627047203913814L,14186632841753756405UL,BigInteger.Parse("2213340465298424454702"),BigInteger.Parse("375449162169269152689331"),BigInteger.Parse("68797650004483898373052060"),BigInteger.Parse("13542753444466024362689788808") };
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
public class A197325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197325Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197325.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197325.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197325Inst Instance=new A197325Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197326
{
public static readonly long[] Value={ 1L,3L,5L,1L,8L,8L,4L,1L,3L,6L,6L,5L,4L,4L,1L,9L,4L,8L,9L,6L,3L,0L,7L,9L,8L,1L,1L,0L,4L,6L,7L,8L,8L,0L,1L,8L,2L,3L,8L,0L,2L,9L,3L,1L,8L,0L,6L,2L,2L,4L,9L,8L,5L,0L,7L,9L,8L,8L,6L,6L,4L,0L,8L,9L,0L,2L,6L,7L,2L,7L,7L,3L,7L,8L,2L,7L,1L,6L,0L,2L,2L,4L,8L,4L,2L,3L,9L,9L,1L,9L,1L,9L,9L,7L,4L,8L,6L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197326Inst : IEnumerable<long>
{
public static readonly long[] Value=A197326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197326.Bytes);
public long this[int i]=>Value[i];

public static A197326Inst Instance=new A197326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197327
{
public static readonly long[] Value={ 1L,7L,9L,6L,4L,2L,6L,1L,6L,0L,2L,6L,2L,7L,7L,8L,6L,5L,5L,3L,0L,3L,2L,2L,3L,6L,0L,5L,7L,6L,2L,6L,7L,6L,3L,0L,9L,7L,4L,4L,2L,9L,6L,2L,4L,6L,0L,4L,8L,0L,9L,2L,4L,6L,0L,6L,7L,1L,0L,6L,3L,7L,4L,8L,2L,6L,0L,1L,6L,7L,1L,1L,3L,9L,5L,4L,4L,0L,2L,8L,6L,8L,5L,5L,3L,2L,5L,4L,8L,4L,3L,8L,1L,7L,3L,1L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197327Inst : IEnumerable<long>
{
public static readonly long[] Value=A197327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197327.Bytes);
public long this[int i]=>Value[i];

public static A197327Inst Instance=new A197327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197328
{
public static readonly long[] Value={ 2L,1L,7L,3L,1L,6L,8L,1L,3L,1L,5L,3L,0L,3L,6L,5L,4L,3L,4L,8L,6L,3L,4L,2L,7L,0L,4L,2L,8L,6L,0L,1L,0L,2L,7L,6L,9L,2L,4L,5L,0L,3L,3L,1L,2L,5L,0L,3L,4L,5L,0L,7L,0L,6L,0L,4L,4L,5L,0L,3L,6L,1L,4L,4L,1L,8L,4L,1L,8L,8L,1L,8L,5L,0L,4L,5L,9L,4L,1L,9L,8L,2L,4L,1L,0L,0L,7L,2L,4L,4L,8L,8L,1L,3L,4L,9L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197328Inst : IEnumerable<long>
{
public static readonly long[] Value=A197328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197328.Bytes);
public long this[int i]=>Value[i];

public static A197328Inst Instance=new A197328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197329
{
public static readonly long[] Value={ 1L,0L,8L,6L,5L,8L,4L,0L,6L,5L,7L,6L,5L,1L,8L,2L,7L,1L,7L,4L,3L,1L,7L,1L,3L,5L,2L,1L,4L,3L,0L,0L,5L,1L,3L,8L,4L,6L,2L,2L,5L,1L,6L,5L,6L,2L,5L,1L,7L,2L,5L,3L,5L,3L,0L,2L,2L,2L,5L,1L,8L,0L,7L,2L,0L,9L,2L,0L,9L,4L,0L,9L,2L,5L,2L,2L,9L,7L,0L,9L,9L,1L,2L,0L,5L,0L,3L,6L,2L,2L,4L,4L,0L,6L,7L,4L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197329Inst : IEnumerable<long>
{
public static readonly long[] Value=A197329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197329.Bytes);
public long this[int i]=>Value[i];

public static A197329Inst Instance=new A197329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197330
{
public static readonly long[] Value={ 1L,2L,0L,9L,3L,8L,6L,1L,0L,2L,8L,7L,1L,7L,0L,5L,2L,3L,4L,2L,5L,4L,4L,3L,0L,4L,4L,4L,6L,2L,6L,8L,0L,4L,9L,1L,6L,0L,6L,5L,5L,0L,4L,6L,6L,6L,0L,7L,6L,3L,7L,4L,4L,5L,0L,4L,0L,4L,3L,9L,7L,7L,2L,5L,7L,0L,5L,1L,4L,0L,3L,6L,1L,7L,7L,2L,6L,4L,8L,7L,2L,9L,6L,3L,7L,3L,1L,1L,6L,6L,2L,8L,5L,0L,6L,8L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197330Inst : IEnumerable<long>
{
public static readonly long[] Value=A197330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197330.Bytes);
public long this[int i]=>Value[i];

public static A197330Inst Instance=new A197330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197331
{
public static readonly long[] Value={ 1L,3L,5L,2L,4L,0L,4L,8L,2L,8L,4L,2L,2L,2L,7L,8L,5L,5L,5L,7L,0L,3L,5L,4L,3L,6L,2L,8L,9L,2L,9L,2L,4L,1L,6L,4L,2L,1L,4L,3L,0L,6L,4L,6L,0L,3L,1L,1L,5L,6L,1L,9L,0L,4L,1L,5L,8L,8L,7L,0L,2L,1L,4L,5L,4L,9L,9L,4L,1L,9L,1L,1L,3L,0L,5L,5L,7L,7L,5L,8L,2L,7L,6L,5L,6L,1L,1L,8L,0L,0L,5L,0L,8L,3L,6L,7L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197331Inst : IEnumerable<long>
{
public static readonly long[] Value=A197331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197331.Bytes);
public long this[int i]=>Value[i];

public static A197331Inst Instance=new A197331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197332
{
public static readonly long[] Value={ 8L,3L,6L,7L,1L,6L,3L,1L,2L,1L,6L,3L,9L,9L,1L,8L,6L,7L,7L,3L,4L,2L,1L,3L,9L,2L,9L,9L,2L,6L,7L,0L,2L,8L,4L,9L,6L,7L,9L,5L,5L,1L,5L,8L,6L,6L,8L,5L,2L,7L,0L,5L,6L,9L,5L,9L,8L,5L,6L,2L,5L,6L,3L,2L,4L,3L,2L,1L,6L,3L,7L,7L,4L,1L,9L,2L,9L,4L,4L,7L,3L,3L,5L,1L,7L,7L,7L,6L,4L,5L,8L,6L,2L,9L,9L,6L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197332Inst : IEnumerable<long>
{
public static readonly long[] Value=A197332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197332.Bytes);
public long this[int i]=>Value[i];

public static A197332Inst Instance=new A197332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197333
{
public static readonly long[] Value={ 9L,0L,1L,6L,0L,3L,2L,1L,8L,9L,4L,8L,1L,8L,5L,7L,0L,3L,8L,0L,2L,3L,6L,2L,4L,1L,9L,2L,8L,6L,1L,6L,1L,0L,9L,4L,7L,6L,2L,0L,4L,3L,0L,6L,8L,7L,4L,3L,7L,4L,6L,0L,2L,7L,7L,2L,5L,8L,0L,1L,4L,3L,0L,3L,3L,2L,9L,4L,6L,0L,7L,5L,3L,7L,0L,5L,1L,7L,2L,1L,8L,4L,3L,7L,4L,1L,2L,0L,0L,3L,3L,8L,9L,1L,1L,7L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197333Inst : IEnumerable<long>
{
public static readonly long[] Value=A197333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197333.Bytes);
public long this[int i]=>Value[i];

public static A197333Inst Instance=new A197333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197334
{
public static readonly long[] Value={ 2L,3L,6L,6L,5L,2L,1L,8L,6L,9L,3L,0L,3L,8L,8L,6L,0L,5L,2L,2L,1L,9L,2L,5L,4L,2L,2L,2L,0L,6L,5L,9L,8L,6L,0L,8L,3L,0L,7L,3L,3L,1L,1L,3L,0L,4L,1L,5L,5L,7L,1L,2L,4L,2L,7L,4L,7L,1L,0L,5L,2L,6L,5L,7L,4L,6L,3L,1L,3L,2L,7L,6L,9L,7L,0L,3L,3L,9L,9L,0L,0L,7L,6L,7L,0L,3L,1L,3L,1L,5L,9L,0L,2L,0L,5L,3L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197334Inst : IEnumerable<long>
{
public static readonly long[] Value=A197334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197334.Bytes);
public long this[int i]=>Value[i];

public static A197334Inst Instance=new A197334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197335
{
public static readonly long[] Value={ 3L,0L,9L,9L,8L,1L,4L,8L,9L,0L,7L,0L,1L,3L,6L,9L,1L,0L,3L,1L,8L,0L,1L,6L,2L,2L,6L,8L,6L,0L,1L,8L,7L,1L,9L,4L,6L,5L,0L,1L,4L,6L,2L,3L,5L,1L,1L,5L,7L,2L,9L,0L,4L,4L,3L,3L,8L,1L,7L,2L,9L,0L,6L,4L,4L,5L,5L,3L,0L,9L,9L,9L,2L,5L,5L,3L,2L,3L,6L,5L,3L,2L,4L,1L,2L,1L,5L,3L,3L,6L,4L,8L,5L,9L,6L,7L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197335Inst : IEnumerable<long>
{
public static readonly long[] Value=A197335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197335.Bytes);
public long this[int i]=>Value[i];

public static A197335Inst Instance=new A197335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197336
{
public static readonly long[] Value={ 1L,2L,11L,167L,4005L,238206L,30771790L,8790242932L,5613820818788L,8031626024398536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197336Inst : IEnumerable<long>
{
public static readonly long[] Value=A197336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197336.Bytes);
public long this[int i]=>Value[i];

public static A197336Inst Instance=new A197336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197337
{
public static readonly long[] Value={ 1L,5L,11L,38L,103L,297L,856L,2458L,7045L,20229L,58099L,166807L,478862L,1374798L,3947115L,11332271L,32534963L,93408015L,268175294L,769933854L,2210486645L,6346325657L,18220355429L,52310797713L,150184749648L,431181704516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197337Inst : IEnumerable<long>
{
public static readonly long[] Value=A197337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197337.Bytes);
public long this[int i]=>Value[i];

public static A197337Inst Instance=new A197337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197338
{
public static readonly long[] Value={ 1L,8L,38L,167L,681L,2864L,12148L,51480L,217587L,919656L,3889592L,16451263L,69570928L,294209541L,1244221402L,5261851987L,22252448435L,94105875249L,397975165117L,1683043391582L,7117616634217L,30100509329656L,127295517065791L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197338Inst : IEnumerable<long>
{
public static readonly long[] Value=A197338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197338.Bytes);
public long this[int i]=>Value[i];

public static A197338Inst Instance=new A197338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197339
{
public static readonly long[] Value={ 1L,18L,103L,681L,4005L,25336L,159818L,998934L,6247167L,39159520L,245281909L,1536123953L,9621537368L,60265981592L,377473012241L,2364297523481L,14808808584343L,92755034615479L,580971270750017L,3638915917088053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197339Inst : IEnumerable<long>
{
public static readonly long[] Value=A197339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197339.Bytes);
public long this[int i]=>Value[i];

public static A197339Inst Instance=new A197339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197340
{
public static readonly long[] Value={ 1L,37L,297L,2864L,25336L,238206L,2218128L,20616615L,191742443L,1785824065L,16629090574L,154844024184L,1441946937763L,13428059890422L,125048396631303L,1164514063002820L,10844571608332582L,100990468863127178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197340Inst : IEnumerable<long>
{
public static readonly long[] Value=A197340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197340.Bytes);
public long this[int i]=>Value[i];

public static A197340Inst Instance=new A197340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197341
{
public static readonly long[] Value={ 1L,73L,856L,12148L,159818L,2218128L,30771790L,425710602L,5901225887L,81906890563L,1136740659494L,15777299597218L,219003011443420L,3040043574547156L,42200212094991310L,585805173715282824L,8131923948348934992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197341Inst : IEnumerable<long>
{
public static readonly long[] Value=A197341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197341.Bytes);
public long this[int i]=>Value[i];

public static A197341Inst Instance=new A197341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197342
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,8L,11L,8L,1L,1L,18L,38L,38L,18L,1L,1L,37L,103L,167L,103L,37L,1L,1L,73L,297L,681L,681L,297L,73L,1L,1L,151L,856L,2864L,4005L,2864L,856L,151L,1L,1L,306L,2458L,12148L,25336L,25336L,12148L,2458L,306L,1L,1L,621L,7045L,51480L,159818L,238206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197342Inst : IEnumerable<long>
{
public static readonly long[] Value=A197342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197342.Bytes);
public long this[int i]=>Value[i];

public static A197342Inst Instance=new A197342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197343
{
public static readonly long[] Value={ 1L,1L,18L,441L,17577L,2036994L,617973077L,434261782615L,734428231903592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197343Inst : IEnumerable<long>
{
public static readonly long[] Value=A197343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197343.Bytes);
public long this[int i]=>Value[i];

public static A197343Inst Instance=new A197343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197344
{
public static readonly long[] Value={ 1L,1L,9L,17L,33L,89L,249L,553L,1321L,3361L,8281L,19801L,48561L,119729L,292017L,711473L,1743129L,4266529L,10420753L,25472041L,62314921L,152363161L,372445401L,910689521L,2226903849L,5444657417L,13311984513L,32549302369L,79585485409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197344Inst : IEnumerable<long>
{
public static readonly long[] Value=A197344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197344.Bytes);
public long this[int i]=>Value[i];

public static A197344Inst Instance=new A197344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197345
{
public static readonly long[] Value={ 1L,9L,18L,83L,245L,914L,3155L,11287L,39850L,141325L,501819L,1782870L,6328399L,22463277L,79770690L,283288919L,1005900951L,3571642082L,12682562591L,45035370321L,159915993486L,567839908711L,2016337387209L,7159825934978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197345Inst : IEnumerable<long>
{
public static readonly long[] Value=A197345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197345.Bytes);
public long this[int i]=>Value[i];

public static A197345Inst Instance=new A197345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197346
{
public static readonly long[] Value={ 1L,17L,83L,441L,2289L,12399L,71411L,387651L,2116197L,11718977L,64938109L,356963085L,1965892155L,10861424867L,59918428781L,330197022079L,1821334406081L,10048722879503L,55415859459949L,305604003423219L,1685661404741659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197346Inst : IEnumerable<long>
{
public static readonly long[] Value=A197346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197346.Bytes);
public long this[int i]=>Value[i];

public static A197346Inst Instance=new A197346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197347
{
public static readonly long[] Value={ 1L,33L,245L,2289L,17577L,152111L,1367870L,11976207L,102819888L,901652503L,7960734146L,69634517247L,607725930336L,5332051608248L,46793978443276L,409707198498049L,3587805656462116L,31453002589770190L,275677556151201299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197347Inst : IEnumerable<long>
{
public static readonly long[] Value=A197347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197347.Bytes);
public long this[int i]=>Value[i];

public static A197347Inst Instance=new A197347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197348
{
public static readonly long[] Value={ 1L,89L,914L,12399L,152111L,2036994L,28226359L,380264123L,5116945034L,69501003275L,947104916619L,12842955562852L,174219658047809L,2367698149031075L,32167182450501802L,436760612415551953L,5931634825068872065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197348Inst : IEnumerable<long>
{
public static readonly long[] Value=A197348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197348.Bytes);
public long this[int i]=>Value[i];

public static A197348Inst Instance=new A197348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197349
{
public static readonly BigInteger[] Value={ 1L,249L,3155L,71411L,1367870L,28226359L,617973077L,13101311077L,275521117202L,5873309926156L,125869557117323L,2679302153154361L,57014937116227499L,1216703701139959983L,BigInteger.Parse("25962340043703794411"),BigInteger.Parse("553346306492392023723") };
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
public class A197349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197349.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197349Inst Instance=new A197349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197350
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,9L,9L,1L,1L,17L,18L,17L,1L,1L,33L,83L,83L,33L,1L,1L,89L,245L,441L,245L,89L,1L,1L,249L,914L,2289L,2289L,914L,249L,1L,1L,553L,3155L,12399L,17577L,12399L,3155L,553L,1L,1L,1321L,11287L,71411L,152111L,152111L,71411L,11287L,1321L,1L,1L,3361L,39850L,387651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197350Inst : IEnumerable<long>
{
public static readonly long[] Value=A197350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197350.Bytes);
public long this[int i]=>Value[i];

public static A197350Inst Instance=new A197350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197351
{
public static readonly long[] Value={ 0L,1L,17L,18L,289L,290L,306L,307L,4913L,4914L,4930L,4931L,5202L,5203L,5219L,5220L,83521L,83522L,83538L,83539L,83810L,83811L,83827L,83828L,88434L,88435L,88451L,88452L,88723L,88724L,88740L,88741L,1419857L,1419858L,1419874L,1419875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197351Inst : IEnumerable<long>
{
public static readonly long[] Value=A197351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197351.Bytes);
public long this[int i]=>Value[i];

public static A197351Inst Instance=new A197351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197352
{
public static readonly long[] Value={ 0L,1L,18L,19L,324L,325L,342L,343L,5832L,5833L,5850L,5851L,6156L,6157L,6174L,6175L,104976L,104977L,104994L,104995L,105300L,105301L,105318L,105319L,110808L,110809L,110826L,110827L,111132L,111133L,111150L,111151L,1889568L,1889569L,1889586L,1889587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197352Inst : IEnumerable<long>
{
public static readonly long[] Value=A197352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197352.Bytes);
public long this[int i]=>Value[i];

public static A197352Inst Instance=new A197352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197353
{
public static readonly long[] Value={ 0L,1L,19L,20L,361L,362L,380L,381L,6859L,6860L,6878L,6879L,7220L,7221L,7239L,7240L,130321L,130322L,130340L,130341L,130682L,130683L,130701L,130702L,137180L,137181L,137199L,137200L,137541L,137542L,137560L,137561L,2476099L,2476100L,2476118L,2476119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197353Inst : IEnumerable<long>
{
public static readonly long[] Value=A197353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197353.Bytes);
public long this[int i]=>Value[i];

public static A197353Inst Instance=new A197353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197354
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,7L,8L,10L,11L,12L,13L,15L,16L,9L,10L,12L,13L,14L,15L,17L,18L,16L,17L,19L,20L,21L,22L,24L,25L,11L,12L,14L,15L,16L,17L,19L,20L,18L,19L,21L,22L,23L,24L,26L,27L,20L,21L,23L,24L,25L,26L,28L,29L,27L,28L,30L,31L,32L,33L,35L,36L,13L,14L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197354Inst : IEnumerable<long>
{
public static readonly long[] Value=A197354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197354.Bytes);
public long this[int i]=>Value[i];

public static A197354Inst Instance=new A197354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197355
{
public static readonly BigInteger[] Value={ 1L,8L,66L,560L,4876L,43488L,396664L,3695168L,35114640L,340039808L,3352381984L,33619852032L,342711219904L,3548566208000L,37299021381504L,397752024876032L,4300986840453376L,47135959519660032L,523321228732695040L,5883464372569321472L,BigInteger.Parse("66953921672396983296") };
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
public class A197355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197355.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197355Inst Instance=new A197355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197356
{
public static readonly BigInteger[] Value={ 1L,4L,40L,1216L,140800L,68583424L,138280960000L,1127848949579776L,BigInteger.Parse("36911566343372800000"),BigInteger.Parse("4836368016228644955357184"),BigInteger.Parse("2535397941156689968365568000000"),BigInteger.Parse("5316967764024635660932200566930538496"),BigInteger.Parse("44601618005626665627415483458173009920000000") };
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
public class A197356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197356.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197356Inst Instance=new A197356Inst();

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