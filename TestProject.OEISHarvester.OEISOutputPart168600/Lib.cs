using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199057
{
public static readonly long[] Value={ 5L,8L,5L,3L,2L,0L,5L,6L,4L,3L,4L,1L,9L,9L,3L,0L,7L,6L,5L,4L,2L,6L,7L,4L,6L,8L,6L,9L,6L,7L,3L,7L,7L,2L,8L,3L,6L,0L,9L,1L,9L,4L,4L,1L,8L,5L,7L,0L,6L,8L,3L,8L,9L,5L,9L,1L,6L,3L,9L,4L,2L,7L,5L,0L,4L,7L,2L,3L,3L,0L,4L,0L,8L,9L,3L,1L,4L,1L,8L,2L,1L,3L,1L,2L,1L,2L,5L,7L,5L,7L,4L,1L,8L,3L,9L,7L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199057Inst : IEnumerable<long>
{
public static readonly long[] Value=A199057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199057.Bytes);
public long this[int i]=>Value[i];

public static A199057Inst Instance=new A199057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199058
{
public static readonly long[] Value={ 2L,2L,9L,1L,9L,6L,5L,0L,4L,1L,2L,6L,7L,4L,2L,8L,6L,4L,9L,0L,9L,5L,1L,3L,3L,1L,1L,8L,3L,9L,4L,4L,4L,3L,3L,8L,9L,5L,3L,7L,0L,8L,4L,4L,8L,8L,9L,5L,3L,1L,5L,0L,9L,7L,9L,1L,1L,5L,2L,1L,5L,3L,3L,5L,1L,5L,4L,7L,8L,6L,1L,2L,5L,9L,9L,2L,9L,0L,7L,7L,1L,8L,0L,8L,4L,2L,3L,3L,8L,3L,5L,8L,8L,9L,2L,2L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199058Inst : IEnumerable<long>
{
public static readonly long[] Value=A199058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199058.Bytes);
public long this[int i]=>Value[i];

public static A199058Inst Instance=new A199058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199059
{
public static readonly long[] Value={ 8L,5L,6L,4L,3L,0L,5L,5L,5L,9L,0L,7L,5L,6L,1L,1L,7L,9L,4L,6L,3L,6L,3L,2L,5L,3L,8L,7L,5L,2L,4L,8L,2L,9L,7L,6L,0L,9L,8L,9L,3L,9L,8L,2L,3L,9L,7L,2L,4L,3L,4L,5L,1L,5L,7L,3L,3L,8L,4L,1L,3L,9L,9L,3L,0L,5L,3L,9L,4L,8L,8L,2L,7L,0L,6L,6L,5L,1L,9L,3L,8L,7L,2L,9L,7L,0L,9L,8L,5L,0L,5L,1L,4L,3L,8L,2L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199059Inst : IEnumerable<long>
{
public static readonly long[] Value=A199059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199059.Bytes);
public long this[int i]=>Value[i];

public static A199059Inst Instance=new A199059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199060
{
public static readonly long[] Value={ 7L,4L,8L,4L,4L,2L,4L,4L,7L,0L,1L,5L,8L,1L,1L,1L,5L,4L,6L,4L,3L,5L,9L,6L,4L,6L,5L,0L,1L,0L,4L,0L,6L,2L,7L,4L,4L,1L,5L,8L,5L,8L,8L,0L,9L,8L,3L,8L,9L,2L,3L,8L,8L,0L,8L,4L,0L,2L,0L,7L,3L,0L,4L,5L,2L,3L,4L,2L,2L,2L,8L,0L,1L,9L,1L,4L,8L,7L,9L,1L,9L,6L,0L,5L,7L,2L,5L,9L,8L,1L,3L,8L,6L,1L,8L,1L,5L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199060Inst : IEnumerable<long>
{
public static readonly long[] Value=A199060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199060.Bytes);
public long this[int i]=>Value[i];

public static A199060Inst Instance=new A199060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199061
{
public static readonly long[] Value={ 9L,5L,2L,6L,0L,9L,7L,8L,3L,7L,1L,1L,3L,0L,6L,7L,1L,3L,7L,4L,7L,3L,4L,8L,0L,7L,3L,7L,9L,2L,3L,6L,0L,7L,0L,5L,8L,6L,4L,4L,5L,2L,8L,6L,2L,8L,1L,4L,1L,4L,5L,1L,1L,1L,7L,3L,6L,0L,8L,6L,8L,2L,8L,4L,8L,5L,0L,5L,0L,2L,3L,7L,8L,5L,1L,3L,9L,0L,0L,6L,4L,0L,3L,1L,9L,7L,1L,4L,1L,4L,7L,4L,1L,2L,1L,7L,9L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199061Inst : IEnumerable<long>
{
public static readonly long[] Value=A199061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199061.Bytes);
public long this[int i]=>Value[i];

public static A199061Inst Instance=new A199061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199062
{
public static readonly long[] Value={ 5L,0L,7L,1L,1L,8L,9L,2L,8L,4L,1L,5L,3L,7L,3L,9L,7L,5L,3L,6L,3L,0L,7L,5L,1L,8L,2L,4L,4L,9L,8L,5L,1L,9L,9L,6L,9L,5L,7L,7L,2L,8L,9L,7L,4L,6L,6L,5L,4L,0L,7L,7L,4L,1L,8L,0L,9L,1L,8L,0L,7L,7L,6L,2L,9L,8L,6L,6L,3L,4L,1L,0L,2L,9L,2L,3L,4L,4L,4L,5L,4L,6L,6L,7L,0L,1L,4L,6L,4L,7L,7L,4L,9L,8L,5L,9L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199062Inst : IEnumerable<long>
{
public static readonly long[] Value=A199062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199062.Bytes);
public long this[int i]=>Value[i];

public static A199062Inst Instance=new A199062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199063
{
public static readonly long[] Value={ 1L,2L,1L,1L,6L,5L,1L,2L,8L,2L,4L,3L,1L,5L,7L,7L,1L,2L,2L,6L,9L,0L,9L,7L,0L,1L,0L,8L,4L,4L,1L,9L,6L,8L,6L,5L,3L,8L,7L,2L,9L,2L,3L,0L,5L,2L,8L,3L,3L,6L,0L,1L,1L,1L,9L,8L,0L,8L,8L,1L,6L,3L,1L,1L,7L,1L,6L,8L,4L,2L,3L,2L,7L,9L,2L,2L,2L,0L,9L,0L,7L,0L,2L,1L,1L,1L,7L,4L,2L,1L,0L,3L,4L,5L,0L,7L,9L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199063Inst : IEnumerable<long>
{
public static readonly long[] Value=A199063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199063.Bytes);
public long this[int i]=>Value[i];

public static A199063Inst Instance=new A199063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199064
{
public static readonly long[] Value={ 8L,0L,0L,6L,7L,8L,3L,0L,4L,5L,7L,0L,0L,9L,1L,1L,2L,1L,1L,2L,4L,1L,3L,4L,0L,6L,6L,0L,4L,5L,3L,2L,7L,5L,6L,2L,0L,5L,7L,6L,8L,7L,6L,6L,4L,6L,2L,2L,7L,2L,4L,0L,5L,6L,9L,1L,3L,6L,4L,5L,5L,1L,9L,4L,5L,3L,5L,4L,4L,3L,9L,3L,1L,7L,5L,4L,2L,0L,8L,6L,9L,8L,6L,6L,3L,1L,8L,3L,9L,2L,7L,7L,9L,0L,2L,5L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199064Inst : IEnumerable<long>
{
public static readonly long[] Value=A199064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199064.Bytes);
public long this[int i]=>Value[i];

public static A199064Inst Instance=new A199064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199065
{
public static readonly long[] Value={ 1L,4L,1L,1L,9L,8L,7L,3L,1L,0L,2L,3L,2L,3L,0L,3L,2L,8L,8L,8L,7L,3L,0L,6L,3L,5L,7L,9L,6L,8L,8L,4L,5L,9L,7L,9L,1L,6L,4L,0L,2L,1L,9L,8L,7L,2L,0L,9L,4L,7L,0L,1L,2L,4L,1L,0L,8L,9L,7L,4L,7L,3L,6L,7L,3L,7L,9L,8L,3L,5L,9L,8L,2L,5L,0L,1L,8L,7L,6L,8L,2L,6L,9L,6L,3L,4L,0L,7L,9L,8L,3L,5L,1L,1L,2L,1L,2L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199065Inst : IEnumerable<long>
{
public static readonly long[] Value=A199065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199065.Bytes);
public long this[int i]=>Value[i];

public static A199065Inst Instance=new A199065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199066
{
public static readonly long[] Value={ 1L,0L,3L,4L,5L,0L,2L,6L,9L,1L,7L,7L,7L,3L,8L,2L,7L,3L,4L,5L,2L,1L,7L,6L,7L,9L,0L,0L,8L,8L,5L,1L,3L,1L,0L,5L,8L,1L,1L,0L,1L,9L,0L,5L,2L,6L,6L,5L,5L,7L,0L,4L,4L,8L,7L,4L,1L,2L,7L,1L,1L,3L,0L,7L,8L,5L,5L,0L,2L,0L,5L,6L,4L,3L,9L,9L,6L,9L,8L,5L,2L,2L,9L,6L,7L,5L,3L,0L,1L,0L,6L,4L,9L,3L,9L,0L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199066Inst : IEnumerable<long>
{
public static readonly long[] Value=A199066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199066.Bytes);
public long this[int i]=>Value[i];

public static A199066Inst Instance=new A199066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199067
{
public static readonly long[] Value={ 1L,1L,9L,6L,0L,8L,2L,0L,3L,3L,2L,9L,7L,1L,3L,4L,8L,1L,9L,1L,4L,5L,6L,2L,1L,9L,5L,2L,9L,4L,1L,0L,4L,3L,2L,1L,1L,5L,9L,7L,2L,0L,4L,7L,1L,5L,9L,5L,9L,6L,8L,3L,8L,0L,5L,1L,0L,2L,3L,8L,0L,7L,4L,0L,4L,9L,8L,1L,6L,1L,1L,3L,2L,3L,3L,5L,5L,1L,9L,8L,2L,1L,9L,3L,1L,4L,3L,5L,8L,7L,7L,8L,5L,0L,2L,9L,8L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199067Inst : IEnumerable<long>
{
public static readonly long[] Value=A199067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199067.Bytes);
public long this[int i]=>Value[i];

public static A199067Inst Instance=new A199067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199068
{
public static readonly long[] Value={ 3L,7L,0L,8L,8L,7L,3L,4L,0L,1L,1L,1L,9L,9L,2L,0L,7L,0L,6L,0L,1L,4L,2L,9L,3L,4L,5L,7L,3L,4L,4L,8L,8L,9L,9L,2L,9L,4L,8L,9L,9L,8L,3L,1L,9L,9L,9L,7L,2L,7L,6L,9L,5L,6L,8L,7L,9L,0L,7L,1L,7L,0L,5L,0L,6L,9L,2L,0L,6L,6L,0L,3L,0L,4L,2L,1L,8L,8L,7L,2L,5L,9L,6L,2L,2L,3L,7L,6L,8L,2L,1L,9L,4L,9L,4L,2L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199068Inst : IEnumerable<long>
{
public static readonly long[] Value=A199068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199068.Bytes);
public long this[int i]=>Value[i];

public static A199068Inst Instance=new A199068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199069
{
public static readonly long[] Value={ 1L,5L,8L,1L,1L,2L,1L,9L,7L,2L,2L,0L,7L,4L,1L,1L,9L,1L,8L,3L,1L,2L,8L,8L,3L,1L,1L,8L,0L,2L,8L,2L,2L,7L,3L,5L,8L,5L,0L,3L,1L,0L,2L,9L,7L,9L,7L,6L,8L,8L,0L,2L,5L,6L,3L,6L,4L,2L,6L,9L,0L,6L,4L,4L,0L,3L,4L,9L,9L,2L,6L,0L,8L,5L,5L,3L,0L,2L,1L,8L,2L,3L,8L,5L,5L,6L,6L,5L,7L,3L,9L,3L,9L,0L,9L,9L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199069Inst : IEnumerable<long>
{
public static readonly long[] Value=A199069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199069.Bytes);
public long this[int i]=>Value[i];

public static A199069Inst Instance=new A199069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199070
{
public static readonly long[] Value={ 8L,6L,1L,0L,7L,7L,6L,7L,4L,7L,3L,9L,5L,5L,2L,9L,9L,0L,2L,4L,1L,9L,8L,2L,3L,6L,5L,6L,7L,0L,3L,7L,7L,6L,3L,1L,0L,9L,4L,3L,0L,3L,9L,3L,3L,5L,8L,1L,2L,7L,3L,9L,0L,8L,9L,2L,8L,5L,6L,4L,3L,0L,9L,6L,2L,6L,0L,8L,4L,5L,1L,8L,3L,9L,2L,1L,6L,9L,4L,9L,3L,0L,5L,8L,6L,3L,0L,8L,4L,2L,1L,8L,8L,4L,7L,9L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199070Inst : IEnumerable<long>
{
public static readonly long[] Value=A199070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199070.Bytes);
public long this[int i]=>Value[i];

public static A199070Inst Instance=new A199070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199071
{
public static readonly long[] Value={ 1L,4L,0L,7L,1L,0L,6L,6L,3L,9L,7L,6L,3L,0L,3L,9L,9L,0L,5L,9L,9L,6L,1L,6L,6L,8L,8L,9L,0L,3L,5L,9L,5L,7L,1L,2L,8L,5L,0L,8L,7L,2L,6L,3L,1L,0L,5L,4L,0L,1L,0L,4L,5L,4L,1L,3L,6L,1L,7L,6L,9L,4L,2L,3L,1L,7L,2L,2L,7L,3L,2L,3L,1L,9L,6L,9L,6L,4L,2L,7L,3L,6L,7L,4L,7L,2L,9L,1L,3L,6L,5L,2L,1L,3L,2L,7L,1L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199071Inst : IEnumerable<long>
{
public static readonly long[] Value=A199071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199071.Bytes);
public long this[int i]=>Value[i];

public static A199071Inst Instance=new A199071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199072
{
public static readonly long[] Value={ 2L,8L,3L,5L,2L,5L,5L,5L,1L,4L,4L,4L,1L,2L,2L,7L,4L,8L,6L,1L,8L,4L,5L,1L,1L,7L,3L,2L,7L,8L,6L,2L,1L,3L,5L,0L,3L,2L,2L,8L,8L,4L,9L,3L,7L,7L,7L,2L,9L,1L,6L,0L,1L,8L,2L,7L,7L,5L,5L,2L,4L,0L,5L,2L,1L,5L,1L,4L,5L,2L,6L,0L,6L,2L,4L,5L,3L,8L,6L,0L,7L,7L,8L,9L,1L,9L,4L,4L,4L,8L,2L,4L,8L,4L,6L,1L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199072Inst : IEnumerable<long>
{
public static readonly long[] Value=A199072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199072.Bytes);
public long this[int i]=>Value[i];

public static A199072Inst Instance=new A199072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199073
{
public static readonly long[] Value={ 1L,5L,8L,1L,1L,1L,3L,5L,8L,4L,2L,6L,8L,0L,1L,2L,6L,2L,3L,6L,2L,3L,5L,1L,3L,3L,0L,1L,1L,3L,1L,8L,9L,6L,6L,7L,8L,7L,2L,0L,2L,3L,7L,3L,1L,0L,7L,9L,2L,1L,8L,9L,5L,8L,1L,2L,5L,2L,1L,2L,1L,0L,4L,8L,8L,9L,3L,3L,9L,5L,3L,3L,2L,1L,6L,1L,0L,1L,2L,1L,9L,4L,3L,5L,4L,0L,9L,3L,2L,0L,7L,4L,2L,5L,9L,6L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199073Inst : IEnumerable<long>
{
public static readonly long[] Value=A199073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199073.Bytes);
public long this[int i]=>Value[i];

public static A199073Inst Instance=new A199073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199074
{
public static readonly long[] Value={ 5L,1L,3L,2L,7L,4L,7L,7L,7L,7L,0L,2L,5L,6L,8L,2L,3L,4L,5L,1L,7L,1L,8L,5L,0L,4L,2L,0L,2L,4L,9L,9L,0L,2L,8L,7L,6L,3L,0L,7L,4L,1L,4L,1L,1L,3L,7L,0L,7L,7L,7L,1L,8L,1L,7L,2L,5L,5L,6L,9L,9L,4L,9L,2L,2L,6L,8L,7L,0L,1L,5L,7L,8L,5L,9L,8L,2L,1L,2L,8L,2L,1L,4L,2L,9L,2L,4L,7L,4L,0L,8L,2L,0L,3L,1L,6L,7L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199074Inst : IEnumerable<long>
{
public static readonly long[] Value=A199074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199074.Bytes);
public long this[int i]=>Value[i];

public static A199074Inst Instance=new A199074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199075
{
public static readonly long[] Value={ 1L,7L,2L,6L,7L,8L,5L,3L,2L,2L,3L,7L,1L,0L,9L,3L,1L,9L,6L,9L,4L,1L,7L,1L,4L,1L,6L,8L,5L,6L,3L,4L,9L,9L,4L,6L,6L,1L,7L,1L,0L,5L,8L,0L,5L,9L,3L,1L,3L,0L,0L,9L,9L,3L,9L,4L,8L,9L,0L,9L,7L,0L,2L,8L,1L,6L,5L,7L,4L,3L,2L,2L,7L,6L,5L,3L,3L,0L,3L,2L,0L,3L,4L,8L,7L,4L,2L,3L,1L,7L,3L,3L,6L,2L,6L,1L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199075Inst : IEnumerable<long>
{
public static readonly long[] Value=A199075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199075.Bytes);
public long this[int i]=>Value[i];

public static A199075Inst Instance=new A199075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199076
{
public static readonly long[] Value={ 7L,1L,7L,0L,8L,6L,3L,8L,9L,1L,8L,1L,9L,2L,1L,8L,2L,6L,6L,9L,7L,0L,0L,4L,2L,9L,5L,3L,3L,3L,3L,0L,7L,7L,1L,8L,7L,3L,8L,6L,3L,1L,8L,4L,1L,8L,2L,8L,5L,8L,2L,3L,0L,6L,4L,5L,9L,4L,3L,8L,2L,5L,1L,8L,4L,8L,5L,7L,2L,8L,6L,7L,3L,5L,4L,3L,7L,1L,4L,5L,9L,0L,1L,0L,5L,6L,5L,4L,4L,1L,6L,8L,9L,7L,6L,4L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199076Inst : IEnumerable<long>
{
public static readonly long[] Value=A199076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199076.Bytes);
public long this[int i]=>Value[i];

public static A199076Inst Instance=new A199076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199077
{
public static readonly long[] Value={ 4L,3L,8L,0L,9L,5L,8L,9L,7L,4L,2L,1L,3L,4L,0L,4L,5L,2L,7L,3L,0L,7L,2L,2L,5L,9L,0L,3L,6L,5L,4L,4L,5L,6L,4L,2L,4L,0L,7L,9L,0L,3L,3L,6L,7L,7L,9L,6L,3L,6L,8L,6L,4L,0L,2L,4L,3L,6L,2L,9L,7L,8L,9L,3L,6L,7L,2L,7L,6L,1L,3L,3L,7L,2L,7L,9L,6L,1L,1L,4L,1L,4L,4L,1L,0L,4L,3L,1L,3L,0L,2L,6L,7L,1L,8L,9L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199077Inst : IEnumerable<long>
{
public static readonly long[] Value=A199077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199077.Bytes);
public long this[int i]=>Value[i];

public static A199077Inst Instance=new A199077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199078
{
public static readonly long[] Value={ 9L,7L,0L,4L,1L,5L,8L,4L,1L,6L,3L,5L,5L,9L,0L,4L,4L,7L,8L,4L,3L,5L,9L,2L,6L,5L,7L,4L,3L,0L,8L,4L,4L,1L,0L,3L,4L,5L,4L,9L,4L,2L,7L,9L,9L,4L,0L,0L,0L,3L,2L,1L,3L,3L,6L,7L,2L,4L,8L,1L,7L,1L,3L,3L,1L,9L,1L,9L,8L,1L,9L,3L,6L,7L,1L,2L,3L,6L,1L,7L,1L,0L,9L,3L,6L,6L,9L,8L,9L,9L,0L,3L,2L,9L,1L,8L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199078Inst : IEnumerable<long>
{
public static readonly long[] Value=A199078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199078.Bytes);
public long this[int i]=>Value[i];

public static A199078Inst Instance=new A199078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199079
{
public static readonly long[] Value={ 6L,7L,6L,7L,0L,1L,5L,9L,4L,0L,7L,3L,0L,7L,7L,8L,7L,4L,1L,9L,4L,8L,5L,5L,7L,2L,0L,3L,8L,4L,0L,1L,6L,6L,9L,7L,7L,4L,7L,6L,2L,6L,9L,0L,0L,8L,3L,6L,5L,9L,2L,0L,9L,8L,0L,7L,6L,8L,9L,7L,6L,7L,6L,7L,4L,9L,0L,6L,6L,3L,1L,1L,0L,6L,3L,0L,2L,6L,6L,3L,2L,3L,7L,1L,0L,3L,6L,9L,4L,7L,7L,3L,5L,9L,3L,2L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199079Inst : IEnumerable<long>
{
public static readonly long[] Value=A199079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199079.Bytes);
public long this[int i]=>Value[i];

public static A199079Inst Instance=new A199079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199080
{
public static readonly long[] Value={ 1L,7L,2L,5L,1L,7L,1L,2L,0L,5L,4L,2L,8L,9L,3L,0L,1L,2L,7L,1L,3L,4L,4L,2L,4L,0L,0L,2L,0L,6L,3L,2L,3L,1L,6L,2L,3L,5L,0L,8L,1L,1L,9L,4L,2L,4L,8L,7L,6L,9L,8L,3L,8L,6L,0L,5L,5L,8L,4L,1L,7L,0L,8L,5L,7L,9L,5L,5L,2L,6L,1L,3L,8L,2L,7L,8L,3L,6L,5L,4L,5L,7L,7L,1L,1L,2L,5L,3L,1L,6L,2L,3L,6L,0L,1L,3L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199080Inst : IEnumerable<long>
{
public static readonly long[] Value=A199080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199080.Bytes);
public long this[int i]=>Value[i];

public static A199080Inst Instance=new A199080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199081
{
public static readonly long[] Value={ 4L,2L,3L,0L,2L,8L,1L,8L,1L,8L,8L,5L,1L,6L,0L,4L,2L,8L,8L,5L,1L,2L,9L,3L,3L,2L,4L,7L,3L,2L,6L,0L,7L,1L,8L,9L,5L,7L,2L,6L,9L,9L,8L,1L,0L,8L,4L,9L,1L,9L,9L,6L,0L,1L,7L,7L,7L,0L,2L,2L,5L,5L,3L,1L,6L,0L,9L,3L,4L,1L,1L,9L,8L,1L,1L,0L,6L,1L,3L,3L,0L,2L,6L,5L,3L,6L,7L,5L,5L,1L,7L,6L,3L,8L,0L,5L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199081Inst : IEnumerable<long>
{
public static readonly long[] Value=A199081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199081.Bytes);
public long this[int i]=>Value[i];

public static A199081Inst Instance=new A199081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199082
{
public static readonly long[] Value={ 1L,9L,6L,1L,8L,8L,4L,2L,4L,6L,4L,1L,0L,8L,3L,4L,8L,9L,3L,4L,1L,9L,2L,8L,0L,7L,7L,9L,7L,7L,4L,8L,9L,4L,2L,6L,8L,2L,5L,7L,4L,7L,1L,2L,0L,7L,1L,2L,7L,2L,1L,8L,6L,6L,5L,5L,2L,0L,8L,9L,8L,6L,8L,6L,9L,2L,3L,2L,5L,8L,8L,5L,0L,6L,8L,5L,9L,0L,3L,7L,8L,4L,0L,1L,3L,8L,9L,0L,9L,6L,5L,8L,4L,8L,8L,1L,9L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199082Inst : IEnumerable<long>
{
public static readonly long[] Value=A199082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199082.Bytes);
public long this[int i]=>Value[i];

public static A199082Inst Instance=new A199082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199083
{
public static readonly long[] Value={ 7L,7L,4L,9L,8L,0L,8L,1L,4L,4L,2L,3L,0L,4L,3L,4L,4L,5L,9L,5L,8L,5L,9L,3L,5L,0L,2L,4L,7L,0L,4L,0L,1L,9L,1L,4L,6L,7L,6L,9L,3L,8L,6L,6L,1L,8L,5L,6L,1L,6L,3L,3L,1L,0L,6L,1L,5L,5L,2L,5L,6L,6L,3L,6L,2L,3L,7L,4L,2L,3L,1L,3L,5L,3L,1L,4L,1L,1L,7L,5L,2L,0L,4L,7L,9L,4L,0L,9L,8L,0L,8L,2L,5L,1L,2L,7L,7L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199083Inst : IEnumerable<long>
{
public static readonly long[] Value=A199083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199083.Bytes);
public long this[int i]=>Value[i];

public static A199083Inst Instance=new A199083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199084
{
public static readonly long[] Value={ 1L,-1L,3L,-4L,5L,-5L,7L,-12L,9L,-9L,11L,-20L,13L,-13L,15L,-32L,17L,-21L,19L,-36L,21L,-21L,23L,-60L,25L,-25L,27L,-52L,29L,-45L,31L,-80L,33L,-33L,35L,-84L,37L,-37L,39L,-108L,41L,-65L,43L,-84L,45L,-45L,47L,-160L,49L,-65L,51L,-100L,53L,-81L,55L,-156L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199084Inst : IEnumerable<long>
{
public static readonly long[] Value=A199084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199084.Bytes);
public long this[int i]=>Value[i];

public static A199084Inst Instance=new A199084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199085
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,15L,20L,26L,32L,39L,47L,55L,64L,74L,84L,95L,107L,119L,132L,146L,160L,175L,191L,207L,224L,242L,260L,279L,299L,319L,340L,362L,384L,407L,431L,455L,480L,506L,532L,559L,587L,615L,644L,674L,704L,735L,767L,799L,832L,866L,900L,935L,971L,1007L,1044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199085Inst : IEnumerable<long>
{
public static readonly long[] Value=A199085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199085.Bytes);
public long this[int i]=>Value[i];

public static A199085Inst Instance=new A199085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199086
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,2L,5L,1L,2L,2L,4L,7L,1L,2L,2L,3L,4L,11L,1L,2L,2L,3L,4L,7L,15L,1L,2L,2L,3L,3L,5L,8L,22L,1L,2L,2L,3L,3L,5L,6L,12L,30L,1L,2L,2L,3L,3L,4L,5L,9L,14L,42L,1L,2L,2L,3L,3L,4L,5L,7L,10L,21L,56L,1L,2L,2L,3L,3L,4L,4L,6L,8L,13L,24L,77L,1L,2L,2L,3L,3L,4L,4L,6L,7L,11L,17L,34L,101L,1L,2L,2L,3L,3L,4L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199086Inst : IEnumerable<long>
{
public static readonly long[] Value=A199086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199086.Bytes);
public long this[int i]=>Value[i];

public static A199086Inst Instance=new A199086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199087
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,4L,1L,3L,2L,4L,5L,1L,6L,3L,2L,8L,4L,9L,5L,1L,12L,6L,3L,7L,2L,16L,8L,4L,10L,9L,5L,11L,1L,13L,12L,6L,14L,3L,7L,15L,2L,18L,16L,8L,19L,4L,10L,20L,9L,23L,5L,11L,24L,1L,13L,25L,12L,29L,6L,14L,30L,3L,17L,7L,15L,35L,2L,18L,36L,16L,21L,8L,19L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199087Inst : IEnumerable<long>
{
public static readonly long[] Value=A199087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199087.Bytes);
public long this[int i]=>Value[i];

public static A199087Inst Instance=new A199087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199088
{
public static readonly long[] Value={ 2L,2L,4L,5L,4L,6L,5L,4L,7L,5L,6L,5L,5L,8L,5L,6L,7L,5L,6L,5L,6L,9L,5L,6L,7L,6L,8L,5L,6L,7L,6L,6L,7L,6L,10L,6L,6L,7L,6L,8L,7L,6L,9L,6L,6L,7L,6L,8L,7L,6L,7L,6L,8L,7L,6L,11L,7L,6L,7L,6L,8L,7L,6L,9L,7L,8L,7L,6L,10L,7L,6L,7L,7L,8L,7L,6L,9L,7L,8L,7L,7L,8L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199088Inst : IEnumerable<long>
{
public static readonly long[] Value=A199088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199088.Bytes);
public long this[int i]=>Value[i];

public static A199088Inst Instance=new A199088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199089
{
public static readonly BigInteger[] Value={ 5L,709L,127973L,26249645L,5813473253L,1354962283005L,327517079413293L,81354547180103625L,BigInteger.Parse("20640739602876893733"),BigInteger.Parse("5326171952368494472061"),BigInteger.Parse("1393506059395687309946181"),BigInteger.Parse("368808221492178082683574433") };
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
public class A199089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199089Inst Instance=new A199089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199090
{
public static readonly BigInteger[] Value={ 5L,420L,44837L,5471810L,726413391L,101787127746L,14800090575471L,2211229549716802L,337343474770282699L,BigInteger.Parse("52327061345761775192") };
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
public class A199090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199090Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199090.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199090.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199090Inst Instance=new A199090Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199091
{
public static readonly long[] Value={ 1L,709L,24353L,5471810L,349276385L,59171718202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199091Inst : IEnumerable<long>
{
public static readonly long[] Value=A199091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199091.Bytes);
public long this[int i]=>Value[i];

public static A199091Inst Instance=new A199091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199092
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,420L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,709L,0L,44837L,0L,44837L,0L,709L,0L,0L,0L,24353L,0L,0L,0L,0L,24353L,0L,0L,0L,0L,0L,5471810L,0L,0L,0L,5471810L,0L,0L,0L,0L,0L,0L,0L,349276385L,0L,0L,349276385L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199092Inst : IEnumerable<long>
{
public static readonly long[] Value=A199092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199092.Bytes);
public long this[int i]=>Value[i];

public static A199092Inst Instance=new A199092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199093
{
public static readonly long[] Value={ 1L,6L,280L,732964L,5569129037L,114472439855502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199093Inst : IEnumerable<long>
{
public static readonly long[] Value=A199093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199093.Bytes);
public long this[int i]=>Value[i];

public static A199093Inst Instance=new A199093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199094
{
public static readonly long[] Value={ 1L,1L,1L,6L,15L,15L,105L,280L,280L,2100L,5775L,5775L,45045L,126126L,126126L,1009008L,2858856L,2858856L,23279256L,66512160L,66512160L,548725320L,1577585295L,1577585295L,13146544125L,37978905250L,37978905250L,319022804100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199094Inst : IEnumerable<long>
{
public static readonly long[] Value=A199094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199094.Bytes);
public long this[int i]=>Value[i];

public static A199094Inst Instance=new A199094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199095
{
public static readonly long[] Value={ 1L,6L,15L,280L,2040L,5503L,113010L,857532L,2340127L,50784920L,395160694L,1085939598L,24341903776L,192371505064L,530944513322L,12155425553076L,97080455287086L,268728663225260L,6244348288426664L,50251726336557552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199095Inst : IEnumerable<long>
{
public static readonly long[] Value=A199095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199095.Bytes);
public long this[int i]=>Value[i];

public static A199095Inst Instance=new A199095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199096
{
public static readonly BigInteger[] Value={ 1L,15L,280L,5295L,101460L,1999365L,40210161L,820951127L,16962540224L,353916457700L,7444303111792L,157654572063308L,3358267477535756L,71896125048485001L,1545960357028561441L,BigInteger.Parse("33370692254737883179") };
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
public class A199096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199096Inst Instance=new A199096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199097
{
public static readonly BigInteger[] Value={ 6L,280L,5295L,732964L,38753124L,743464228L,115707966228L,6468027944244L,127149344295419L,20829692931992406L,1196759182608043852L,BigInteger.Parse("23839712978251419910"),BigInteger.Parse("4020627629769950572704"),BigInteger.Parse("234848943742720409725658") };
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
public class A199097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199097Inst Instance=new A199097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199098
{
public static readonly BigInteger[] Value={ 15L,2040L,101460L,38753124L,5569129037L,287771242262L,123022787797053L,18696906414385635L,993411195529074382L,BigInteger.Parse("446003814998395266655"),BigInteger.Parse("69706902367712447882179"),BigInteger.Parse("3759620769505560043717063") };
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
public class A199098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199098Inst Instance=new A199098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199099
{
public static readonly long[] Value={ 15L,5503L,1999365L,743464228L,287771242262L,114472439855502L,46438726281827509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199099Inst : IEnumerable<long>
{
public static readonly long[] Value=A199099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199099.Bytes);
public long this[int i]=>Value[i];

public static A199099Inst Instance=new A199099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199100
{
public static readonly long[] Value={ 105L,113010L,40210161L,115707966228L,123022787797053L,46438726281827509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199100Inst : IEnumerable<long>
{
public static readonly long[] Value=A199100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199100.Bytes);
public long this[int i]=>Value[i];

public static A199100Inst Instance=new A199100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199101
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,6L,15L,15L,6L,15L,280L,280L,280L,15L,15L,2040L,5295L,5295L,2040L,15L,105L,5503L,101460L,732964L,101460L,5503L,105L,280L,113010L,1999365L,38753124L,38753124L,1999365L,113010L,280L,280L,857532L,40210161L,743464228L,5569129037L,743464228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199101Inst : IEnumerable<long>
{
public static readonly long[] Value=A199101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199101.Bytes);
public long this[int i]=>Value[i];

public static A199101Inst Instance=new A199101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199102
{
public static readonly long[] Value={ 1L,2L,6L,20L,63L,213L,719L,2505L,8864L,31948L,116725L,432074L,1616022L,6100775L,23214144L,88949045L,342899474L,1329020016L,5175758820L,20243197030L,79480515302L,313155710230L,1237771800135L,4906616164195L,19502048947616L,77703941363599L,310305199056779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199102Inst : IEnumerable<long>
{
public static readonly long[] Value=A199102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199102.Bytes);
public long this[int i]=>Value[i];

public static A199102Inst Instance=new A199102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199103
{
public static readonly long[] Value={ 1L,1L,3L,8L,23L,67L,202L,622L,1955L,6248L,20261L,66484L,220429L,737260L,2484734L,8429714L,28766001L,98670291L,340011308L,1176505537L,4086143638L,14239716570L,49776772808L,174492148048L,613266137776L,2160518118345L,7628244051977L,26988540797766L,95666557041459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199103Inst : IEnumerable<long>
{
public static readonly long[] Value=A199103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199103.Bytes);
public long this[int i]=>Value[i];

public static A199103Inst Instance=new A199103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199104
{
public static readonly long[] Value={ 1L,1L,3L,9L,28L,88L,284L,931L,3109L,10532L,36162L,125546L,440201L,1556519L,5544715L,19879791L,71685522L,259809731L,945913555L,3457947627L,12687782600L,46709518473L,172484216742L,638712762962L,2371241532557L,8824154454401L,32909438791706L,122984173008460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199104Inst : IEnumerable<long>
{
public static readonly long[] Value=A199104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199104.Bytes);
public long this[int i]=>Value[i];

public static A199104Inst Instance=new A199104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199105
{
public static readonly long[] Value={ 24L,48L,56L,72L,80L,88L,96L,112L,144L,152L,160L,168L,176L,184L,192L,208L,216L,224L,240L,248L,264L,288L,304L,320L,336L,344L,352L,368L,376L,384L,392L,400L,416L,432L,448L,456L,464L,472L,480L,496L,504L,528L,536L,552L,560L,568L,576L,592L,608L,616L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199105Inst : IEnumerable<long>
{
public static readonly long[] Value=A199105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199105.Bytes);
public long this[int i]=>Value[i];

public static A199105Inst Instance=new A199105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199106
{
public static readonly long[] Value={ 3L,47L,575L,6911L,82943L,995327L,11943935L,143327231L,1719926783L,20639121407L,247669456895L,2972033482751L,35664401793023L,427972821516287L,5135673858195455L,61628086298345471L,739537035580145663L,8874444426961747967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199106Inst : IEnumerable<long>
{
public static readonly long[] Value=A199106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199106.Bytes);
public long this[int i]=>Value[i];

public static A199106Inst Instance=new A199106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199107
{
public static readonly ulong[] Value={ 4L,59L,719L,8639L,103679L,1244159L,14929919L,179159039L,2149908479L,25798901759L,309586821119L,3715041853439L,44580502241279L,534966026895359L,6419592322744319L,77035107872931839L,924421294475182079L,11093055533702184959UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199107Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A199107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199107.Bytes);
public ulong this[int i]=>Value[i];

public static A199107Inst Instance=new A199107Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199108
{
public static readonly long[] Value={ 5L,13L,37L,109L,325L,973L,2917L,8749L,26245L,78733L,236197L,708589L,2125765L,6377293L,19131877L,57395629L,172186885L,516560653L,1549681957L,4649045869L,13947137605L,41841412813L,125524238437L,376572715309L,1129718145925L,3389154437773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199108Inst : IEnumerable<long>
{
public static readonly long[] Value=A199108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199108.Bytes);
public long this[int i]=>Value[i];

public static A199108Inst Instance=new A199108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199109
{
public static readonly long[] Value={ 4L,11L,32L,95L,284L,851L,2552L,7655L,22964L,68891L,206672L,620015L,1860044L,5580131L,16740392L,50221175L,150663524L,451990571L,1355971712L,4067915135L,12203745404L,36611236211L,109833708632L,329501125895L,988503377684L,2965510133051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199109Inst : IEnumerable<long>
{
public static readonly long[] Value=A199109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199109.Bytes);
public long this[int i]=>Value[i];

public static A199109Inst Instance=new A199109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199110
{
public static readonly long[] Value={ 8L,22L,64L,190L,568L,1702L,5104L,15310L,45928L,137782L,413344L,1240030L,3720088L,11160262L,33480784L,100442350L,301327048L,903981142L,2711943424L,8135830270L,24407490808L,73222472422L,219667417264L,659002251790L,1977006755368L,5931020266102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199110Inst : IEnumerable<long>
{
public static readonly long[] Value=A199110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199110.Bytes);
public long this[int i]=>Value[i];

public static A199110Inst Instance=new A199110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199111
{
public static readonly long[] Value={ 9L,25L,73L,217L,649L,1945L,5833L,17497L,52489L,157465L,472393L,1417177L,4251529L,12754585L,38263753L,114791257L,344373769L,1033121305L,3099363913L,9298091737L,27894275209L,83682825625L,251048476873L,753145430617L,2259436291849L,6778308875545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199111Inst : IEnumerable<long>
{
public static readonly long[] Value=A199111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199111.Bytes);
public long this[int i]=>Value[i];

public static A199111Inst Instance=new A199111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199112
{
public static readonly long[] Value={ 11L,31L,91L,271L,811L,2431L,7291L,21871L,65611L,196831L,590491L,1771471L,5314411L,15943231L,47829691L,143489071L,430467211L,1291401631L,3874204891L,11622614671L,34867844011L,104603532031L,313810596091L,941431788271L,2824295364811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199112Inst : IEnumerable<long>
{
public static readonly long[] Value=A199112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199112.Bytes);
public long this[int i]=>Value[i];

public static A199112Inst Instance=new A199112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199113
{
public static readonly long[] Value={ 6L,17L,50L,149L,446L,1337L,4010L,12029L,36086L,108257L,324770L,974309L,2922926L,8768777L,26306330L,78918989L,236756966L,710270897L,2130812690L,6392438069L,19177314206L,57531942617L,172595827850L,517787483549L,1553362450646L,4660087351937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199113Inst : IEnumerable<long>
{
public static readonly long[] Value=A199113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199113.Bytes);
public long this[int i]=>Value[i];

public static A199113Inst Instance=new A199113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199114
{
public static readonly long[] Value={ 12L,34L,100L,298L,892L,2674L,8020L,24058L,72172L,216514L,649540L,1948618L,5845852L,17537554L,52612660L,157837978L,473513932L,1420541794L,4261625380L,12784876138L,38354628412L,115063885234L,345191655700L,1035574967098L,3106724901292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199114Inst : IEnumerable<long>
{
public static readonly long[] Value=A199114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199114.Bytes);
public long this[int i]=>Value[i];

public static A199114Inst Instance=new A199114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199115
{
public static readonly long[] Value={ 6L,21L,81L,321L,1281L,5121L,20481L,81921L,327681L,1310721L,5242881L,20971521L,83886081L,335544321L,1342177281L,5368709121L,21474836481L,85899345921L,343597383681L,1374389534721L,5497558138881L,21990232555521L,87960930222081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199115Inst : IEnumerable<long>
{
public static readonly long[] Value=A199115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199115.Bytes);
public long this[int i]=>Value[i];

public static A199115Inst Instance=new A199115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199116
{
public static readonly long[] Value={ 7L,25L,97L,385L,1537L,6145L,24577L,98305L,393217L,1572865L,6291457L,25165825L,100663297L,402653185L,1610612737L,6442450945L,25769803777L,103079215105L,412316860417L,1649267441665L,6597069766657L,26388279066625L,105553116266497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199116Inst : IEnumerable<long>
{
public static readonly long[] Value=A199116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199116.Bytes);
public long this[int i]=>Value[i];

public static A199116Inst Instance=new A199116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199117
{
public static readonly long[] Value={ 0L,2L,2L,4L,6L,8L,8L,8L,10L,14L,12L,14L,18L,20L,20L,18L,20L,26L,22L,26L,30L,32L,32L,28L,36L,36L,34L,38L,42L,44L,42L,38L,48L,50L,46L,50L,54L,56L,52L,48L,54L,60L,58L,60L,64L,68L,66L,60L,72L,74L,68L,70L,78L,76L,80L,72L,78L,86L,76L,84L,90L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199117Inst : IEnumerable<long>
{
public static readonly long[] Value=A199117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199117.Bytes);
public long this[int i]=>Value[i];

public static A199117Inst Instance=new A199117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199118
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,7L,10L,13L,17L,21L,28L,34L,42L,52L,65L,78L,96L,113L,138L,165L,196L,231L,276L,322L,379L,442L,518L,600L,698L,803L,931L,1071L,1231L,1407L,1615L,1839L,2099L,2384L,2712L,3069L,3478L,3923L,4434L,4991L,5618L,6303L,7083L,7928L,8878L,9916L,11081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199118Inst : IEnumerable<long>
{
public static readonly long[] Value=A199118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199118.Bytes);
public long this[int i]=>Value[i];

public static A199118Inst Instance=new A199118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199119
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,2L,2L,2L,3L,4L,4L,4L,5L,6L,6L,7L,7L,8L,10L,9L,9L,12L,13L,13L,13L,14L,17L,18L,18L,19L,21L,23L,25L,26L,27L,30L,33L,33L,36L,40L,42L,43L,45L,51L,55L,55L,57L,62L,67L,71L,72L,76L,82L,87L,91L,95L,100L,107L,112L,116L,124L,132L,137L,143L,151L,159L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199119Inst : IEnumerable<long>
{
public static readonly long[] Value=A199119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199119.Bytes);
public long this[int i]=>Value[i];

public static A199119Inst Instance=new A199119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199120
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,7L,8L,11L,13L,17L,20L,25L,30L,38L,44L,54L,63L,77L,90L,107L,124L,148L,171L,202L,231L,271L,310L,360L,412L,477L,542L,622L,705L,809L,915L,1042L,1175L,1335L,1501L,1699L,1905L,2148L,2403L,2702L,3018L,3383L,3768L,4212L,4682L,5223L,5794L,6445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199120Inst : IEnumerable<long>
{
public static readonly long[] Value=A199120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199120.Bytes);
public long this[int i]=>Value[i];

public static A199120Inst Instance=new A199120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199121
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,2L,2L,2L,2L,2L,3L,4L,4L,4L,4L,5L,6L,6L,7L,8L,7L,8L,10L,11L,11L,12L,14L,14L,15L,17L,18L,20L,21L,22L,24L,25L,27L,30L,31L,32L,35L,37L,39L,41L,44L,45L,48L,52L,53L,56L,60L,62L,66L,69L,72L,76L,81L,86L,89L,92L,96L,103L,109L,113L,117L,123L,127L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199121Inst : IEnumerable<long>
{
public static readonly long[] Value=A199121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199121.Bytes);
public long this[int i]=>Value[i];

public static A199121Inst Instance=new A199121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199122
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,9L,11L,14L,16L,20L,23L,29L,33L,39L,47L,54L,64L,75L,86L,101L,117L,135L,155L,179L,204L,236L,268L,306L,349L,397L,450L,511L,577L,653L,736L,831L,934L,1050L,1179L,1322L,1478L,1657L,1848L,2065L,2302L,2562L,2852L,3172L,3518L,3909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199122Inst : IEnumerable<long>
{
public static readonly long[] Value=A199122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199122.Bytes);
public long this[int i]=>Value[i];

public static A199122Inst Instance=new A199122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199123
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,2L,2L,2L,3L,2L,3L,3L,4L,4L,5L,5L,6L,6L,6L,8L,8L,9L,11L,10L,12L,14L,12L,17L,16L,17L,22L,19L,24L,25L,25L,30L,30L,33L,37L,37L,42L,45L,46L,52L,54L,57L,64L,66L,69L,79L,76L,87L,93L,91L,109L,105L,115L,126L,123L,140L,144L,151L,166L,169L,180L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199123Inst : IEnumerable<long>
{
public static readonly long[] Value=A199123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199123.Bytes);
public long this[int i]=>Value[i];

public static A199123Inst Instance=new A199123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199124
{
public static readonly BigInteger[] Value={ 2L,13L,107L,1009L,10037L,100049L,1000099L,10000379L,100000399L,1000000787L,10000000799L,100000001989L,1000000001999L,10000000003999L,100000000006997L,1000000000017899L,10000000000018999L,100000000000038989L,1000000000000067999L,10000000000000079899UL,BigInteger.Parse("100000000000000079999") };
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
public class A199124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199124Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199124.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199124Inst Instance=new A199124Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199125
{
public static readonly long[] Value={ 1L,2L,6L,258L,11475L,438502L,358599045L,247746055048L,141388449764548L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199125Inst : IEnumerable<long>
{
public static readonly long[] Value=A199125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199125.Bytes);
public long this[int i]=>Value[i];

public static A199125Inst Instance=new A199125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199126
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,5L,19L,37L,29L,124L,240L,182L,834L,1614L,1198L,5746L,11137L,8142L,40336L,78332L,56620L,287358L,559134L,400598L,2071558L,4038130L,2872754L,15079270L,29443040L,20824778L,110653854L,216379650L,152303410L,817542980L,1600817660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199126Inst : IEnumerable<long>
{
public static readonly long[] Value=A199126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199126.Bytes);
public long this[int i]=>Value[i];

public static A199126Inst Instance=new A199126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199127
{
public static readonly long[] Value={ 1L,2L,2L,12L,30L,30L,210L,560L,560L,4200L,11550L,11550L,90090L,252252L,252252L,2018016L,5717712L,5717712L,46558512L,133024320L,133024320L,1097450640L,3155170590L,3155170590L,26293088250L,75957810500L,75957810500L,638045608200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199127Inst : IEnumerable<long>
{
public static readonly long[] Value=A199127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199127.Bytes);
public long this[int i]=>Value[i];

public static A199127Inst Instance=new A199127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199128
{
public static readonly long[] Value={ 1L,2L,6L,19L,70L,264L,1038L,4155L,16896L,69584L,289146L,1211873L,5111178L,21686612L,92453594L,395888507L,1701506820L,7337867736L,31739124866L,137656095241L,598476364166L,2607710997676L,11385288787534L,49800060551081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199128Inst : IEnumerable<long>
{
public static readonly long[] Value=A199128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199128.Bytes);
public long this[int i]=>Value[i];

public static A199128Inst Instance=new A199128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199129
{
public static readonly long[] Value={ 3L,12L,19L,258L,1409L,2836L,48320L,295092L,629776L,11499816L,73045294L,159683856L,3012721252L,19537447260L,43276955012L,832789320948L,5471578311520L,12222775051564L,238366172778672L,1580313985819656L,3551105861275344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199129Inst : IEnumerable<long>
{
public static readonly long[] Value=A199129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199129.Bytes);
public long this[int i]=>Value[i];

public static A199129Inst Instance=new A199129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199130
{
public static readonly long[] Value={ 6L,30L,70L,1409L,11475L,33970L,887966L,8181546L,26354800L,739462036L,7166709232L,23742940530L,690068431668L,6837489856538L,23031293598718L,682253330136338L,6857414650447522L,23326710623207736L,700022706564351432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199130Inst : IEnumerable<long>
{
public static readonly long[] Value=A199130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199130.Bytes);
public long this[int i]=>Value[i];

public static A199130Inst Instance=new A199130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199131
{
public static readonly long[] Value={ 5L,30L,264L,2836L,33970L,438502L,5926852L,82908094L,1187201812L,17307138986L,255687902462L,3817658150424L,57485010058768L,871667490461400L,13295046323445896L,203799010704532580L,3137556683409570358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199131Inst : IEnumerable<long>
{
public static readonly long[] Value=A199131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199131.Bytes);
public long this[int i]=>Value[i];

public static A199131Inst Instance=new A199131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199132
{
public static readonly BigInteger[] Value={ 19L,210L,1038L,48320L,887966L,5926852L,358599045L,7633754680L,56435001338L,3718131446504L,84113596169937L,647071266317908L,44371190146396476L,1031280656608709860L,8107333731404729122L,BigInteger.Parse("567373010032314560752") };
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
public class A199132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199132Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199132.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199132Inst Instance=new A199132Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199133
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,2L,3L,6L,12L,6L,12L,6L,5L,30L,19L,19L,30L,5L,19L,30L,70L,258L,70L,30L,19L,37L,210L,264L,1409L,1409L,264L,210L,37L,29L,560L,1038L,2836L,11475L,2836L,1038L,560L,29L,124L,560L,4155L,48320L,33970L,33970L,48320L,4155L,560L,124L,240L,4200L,16896L,295092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199133Inst : IEnumerable<long>
{
public static readonly long[] Value=A199133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199133.Bytes);
public long this[int i]=>Value[i];

public static A199133Inst Instance=new A199133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199134
{
public static readonly long[] Value={ 4L,5L,10L,11L,13L,15L,20L,21L,26L,27L,29L,31L,34L,38L,40L,42L,43L,49L,50L,54L,56L,58L,59L,64L,67L,69L,71L,75L,77L,78L,80L,85L,86L,90L,91L,95L,99L,101L,102L,104L,108L,111L,113L,116L,117L,120L,123L,128L,129L,132L,133L,136L,141L,143L,144L,146L,151L,152L,154L,156L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199134Inst : IEnumerable<long>
{
public static readonly long[] Value=A199134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199134.Bytes);
public long this[int i]=>Value[i];

public static A199134Inst Instance=new A199134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199135
{
public static readonly long[] Value={ 1L,3L,11L,64L,504L,5241L,66515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199135Inst : IEnumerable<long>
{
public static readonly long[] Value=A199135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199135.Bytes);
public long this[int i]=>Value[i];

public static A199135Inst Instance=new A199135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199136
{
public static readonly long[] Value={ 1L,2L,8L,47L,389L,4226L,54888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199136Inst : IEnumerable<long>
{
public static readonly long[] Value=A199136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199136.Bytes);
public long this[int i]=>Value[i];

public static A199136Inst Instance=new A199136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199137
{
public static readonly long[] Value={ 1L,1L,3L,9L,30L,97L,336L,1153L,4081L,14552L,52609L,191657L,704385L,2604476L,9687433L,36207241L,135920489L,512182805L,1936656361L,7345211322L,27935373368L,106509551719L,407015199144L,1558603221623L,5979839952471L,22983021033071L,88477003979994L,341120527468590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199137Inst : IEnumerable<long>
{
public static readonly long[] Value=A199137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199137.Bytes);
public long this[int i]=>Value[i];

public static A199137Inst Instance=new A199137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199138
{
public static readonly long[] Value={ 1L,1L,3L,17L,135L,1463L,19306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199138Inst : IEnumerable<long>
{
public static readonly long[] Value=A199138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199138.Bytes);
public long this[int i]=>Value[i];

public static A199138Inst Instance=new A199138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199139
{
public static readonly long[] Value={ 0L,0L,1L,9L,122L,1701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199139Inst : IEnumerable<long>
{
public static readonly long[] Value=A199139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199139.Bytes);
public long this[int i]=>Value[i];

public static A199139Inst Instance=new A199139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199140
{
public static readonly long[] Value={ 3L,9L,43L,217L,1328L,19700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199140Inst : IEnumerable<long>
{
public static readonly long[] Value=A199140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199140.Bytes);
public long this[int i]=>Value[i];

public static A199140Inst Instance=new A199140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199141
{
public static readonly long[] Value={ 0L,3L,132L,125468L,839006010L,44832664800117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199141Inst : IEnumerable<long>
{
public static readonly long[] Value=A199141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199141.Bytes);
public long this[int i]=>Value[i];

public static A199141Inst Instance=new A199141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199142
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,6L,11L,23L,47L,102L,221L,492L,1099L,2485L,5637L,12858L,29391L,67354L,154539L,355003L,816035L,1876862L,4318201L,9937840L,22874731L,52659593L,121237417L,279141170L,642732027L,1479959118L,3407837387L,7847200511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199142Inst : IEnumerable<long>
{
public static readonly long[] Value=A199142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199142.Bytes);
public long this[int i]=>Value[i];

public static A199142Inst Instance=new A199142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199143
{
public static readonly long[] Value={ 1L,3L,13L,65L,393L,2539L,16866L,113432L,766473L,5188597L,35148945L,238173743L,1614066774L,10938730576L,74134306725L,502428413393L,3405102418833L,23077383280435L,156402287318610L,1059984943413152L,7183834447992225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199143Inst : IEnumerable<long>
{
public static readonly long[] Value=A199143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199143.Bytes);
public long this[int i]=>Value[i];

public static A199143Inst Instance=new A199143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199144
{
public static readonly BigInteger[] Value={ 1L,13L,132L,2453L,42420L,794416L,14511531L,268456338L,4940928443L,91146218920L,1679743067872L,30969409565822L,570877041856787L,10524153072061784L,194006638767664141L,3576453618832667684L,BigInteger.Parse("65930406443303698229") };
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
public class A199144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199144Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199144.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199144.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199144Inst Instance=new A199144Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199145
{
public static readonly BigInteger[] Value={ 2L,65L,2453L,125468L,6235011L,316561994L,15958823113L,806680624447L,40736752748774L,2057896226081573L,103945296750116087L,5250572116269762125L,BigInteger.Parse("265216743260845702081"),BigInteger.Parse("13396704712673136390007"),BigInteger.Parse("676696655003807234547723") };
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
public class A199145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199145Inst Instance=new A199145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199146
{
public static readonly BigInteger[] Value={ 3L,393L,42420L,6235011L,839006010L,117380324984L,16158623337745L,2239304268913257L,309471298054332806L,BigInteger.Parse("42818034223579225138"),BigInteger.Parse("5921413251810033475103"),BigInteger.Parse("819050117505774849777870") };
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
public class A199146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199146Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199146.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199146.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199146Inst Instance=new A199146Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199147
{
public static readonly long[] Value={ 6L,2539L,794416L,316561994L,117380324984L,44832664800117L,16925667317073175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199147Inst : IEnumerable<long>
{
public static readonly long[] Value=A199147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199147.Bytes);
public long this[int i]=>Value[i];

public static A199147Inst Instance=new A199147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199148
{
public static readonly long[] Value={ 11L,16866L,14511531L,15958823113L,16158623337745L,16925667317073175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199148Inst : IEnumerable<long>
{
public static readonly long[] Value=A199148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199148.Bytes);
public long this[int i]=>Value[i];

public static A199148Inst Instance=new A199148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199149
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,13L,13L,2L,3L,65L,132L,65L,3L,6L,393L,2453L,2453L,393L,6L,11L,2539L,42420L,125468L,42420L,2539L,11L,23L,16866L,794416L,6235011L,6235011L,794416L,16866L,23L,47L,113432L,14511531L,316561994L,839006010L,316561994L,14511531L,113432L,47L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199149Inst : IEnumerable<long>
{
public static readonly long[] Value=A199149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199149.Bytes);
public long this[int i]=>Value[i];

public static A199149Inst Instance=new A199149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199150
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,2L,9L,8L,6L,4L,6L,4L,2L,3L,9L,2L,5L,6L,2L,7L,0L,7L,5L,0L,6L,6L,0L,5L,6L,2L,9L,4L,8L,6L,7L,7L,8L,4L,6L,7L,2L,7L,2L,6L,6L,3L,6L,4L,1L,5L,7L,9L,5L,5L,0L,7L,5L,8L,6L,1L,6L,9L,7L,2L,5L,6L,0L,8L,6L,3L,1L,1L,9L,6L,7L,3L,5L,7L,4L,4L,7L,8L,8L,7L,7L,9L,0L,4L,6L,9L,5L,4L,3L,7L,2L,5L,7L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199150Inst : IEnumerable<long>
{
public static readonly long[] Value=A199150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199150.Bytes);
public long this[int i]=>Value[i];

public static A199150Inst Instance=new A199150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199151
{
public static readonly long[] Value={ 8L,6L,4L,0L,1L,1L,2L,7L,2L,4L,2L,7L,9L,0L,3L,4L,5L,7L,3L,2L,9L,5L,5L,0L,3L,1L,5L,0L,3L,5L,9L,0L,0L,2L,9L,4L,7L,0L,4L,8L,8L,0L,1L,7L,2L,7L,8L,9L,4L,2L,0L,3L,8L,5L,2L,7L,5L,0L,0L,7L,7L,8L,3L,4L,3L,8L,2L,4L,2L,2L,0L,4L,0L,1L,2L,5L,9L,8L,3L,2L,0L,0L,5L,6L,4L,3L,1L,1L,8L,0L,0L,8L,8L,7L,4L,2L,1L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199151Inst : IEnumerable<long>
{
public static readonly long[] Value=A199151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199151.Bytes);
public long this[int i]=>Value[i];

public static A199151Inst Instance=new A199151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199152
{
public static readonly long[] Value={ 9L,3L,1L,9L,4L,4L,5L,3L,9L,1L,9L,6L,5L,7L,4L,8L,0L,8L,7L,5L,7L,9L,9L,4L,8L,2L,2L,2L,1L,9L,0L,3L,5L,7L,7L,7L,4L,3L,2L,4L,1L,6L,3L,2L,3L,9L,2L,4L,2L,2L,3L,1L,3L,6L,1L,2L,1L,0L,2L,9L,6L,0L,5L,1L,6L,3L,7L,4L,3L,3L,6L,3L,4L,4L,7L,8L,0L,9L,1L,8L,6L,6L,5L,1L,4L,5L,5L,7L,1L,6L,5L,7L,7L,3L,9L,3L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199152Inst : IEnumerable<long>
{
public static readonly long[] Value=A199152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199152.Bytes);
public long this[int i]=>Value[i];

public static A199152Inst Instance=new A199152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199153
{
public static readonly long[] Value={ 3L,3L,6L,4L,8L,2L,7L,0L,1L,9L,2L,3L,3L,5L,2L,8L,1L,5L,7L,7L,0L,3L,9L,4L,9L,3L,7L,6L,1L,1L,0L,6L,7L,7L,8L,1L,4L,4L,3L,6L,5L,3L,0L,1L,1L,7L,8L,4L,0L,0L,3L,6L,7L,9L,4L,6L,8L,5L,6L,3L,5L,3L,2L,4L,2L,5L,3L,4L,9L,3L,1L,1L,2L,9L,0L,3L,6L,8L,3L,7L,2L,5L,6L,4L,9L,3L,2L,1L,7L,3L,9L,8L,2L,0L,0L,1L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199153Inst : IEnumerable<long>
{
public static readonly long[] Value=A199153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199153.Bytes);
public long this[int i]=>Value[i];

public static A199153Inst Instance=new A199153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199154
{
public static readonly long[] Value={ 1L,1L,2L,6L,2L,9L,9L,9L,4L,0L,9L,9L,3L,8L,7L,7L,5L,2L,3L,9L,9L,2L,8L,6L,7L,7L,3L,3L,6L,4L,1L,8L,6L,8L,5L,0L,7L,2L,2L,2L,7L,0L,7L,8L,8L,7L,1L,8L,7L,3L,6L,9L,6L,8L,2L,1L,0L,1L,2L,4L,1L,9L,8L,1L,3L,2L,7L,5L,3L,6L,9L,3L,2L,2L,5L,1L,7L,5L,0L,6L,8L,2L,5L,0L,4L,4L,0L,7L,7L,5L,3L,0L,0L,7L,7L,6L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199154Inst : IEnumerable<long>
{
public static readonly long[] Value=A199154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199154.Bytes);
public long this[int i]=>Value[i];

public static A199154Inst Instance=new A199154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199155
{
public static readonly long[] Value={ 5L,5L,9L,3L,7L,2L,1L,7L,0L,8L,1L,3L,1L,2L,7L,0L,4L,7L,7L,6L,5L,6L,2L,9L,6L,4L,7L,3L,2L,6L,5L,4L,8L,9L,2L,0L,7L,0L,8L,1L,5L,6L,2L,5L,3L,5L,4L,4L,2L,3L,2L,2L,2L,9L,8L,4L,0L,6L,5L,6L,7L,2L,9L,4L,5L,4L,1L,6L,4L,0L,8L,0L,2L,8L,3L,7L,1L,8L,3L,6L,5L,6L,4L,6L,9L,0L,6L,8L,6L,3L,4L,4L,1L,5L,1L,6L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199155Inst : IEnumerable<long>
{
public static readonly long[] Value=A199155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199155.Bytes);
public long this[int i]=>Value[i];

public static A199155Inst Instance=new A199155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199156
{
public static readonly long[] Value={ 1L,2L,8L,0L,1L,1L,7L,0L,2L,7L,8L,2L,3L,5L,9L,2L,9L,0L,0L,0L,4L,5L,6L,8L,9L,8L,4L,5L,5L,5L,8L,5L,5L,4L,9L,7L,9L,6L,5L,5L,2L,8L,2L,3L,5L,3L,6L,5L,3L,4L,8L,6L,3L,0L,8L,5L,6L,7L,7L,8L,2L,6L,9L,0L,0L,8L,4L,7L,4L,8L,3L,3L,1L,9L,7L,1L,7L,6L,9L,0L,6L,9L,7L,1L,8L,5L,9L,5L,0L,8L,4L,8L,1L,0L,8L,4L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199156Inst : IEnumerable<long>
{
public static readonly long[] Value=A199156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199156.Bytes);
public long this[int i]=>Value[i];

public static A199156Inst Instance=new A199156Inst();

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