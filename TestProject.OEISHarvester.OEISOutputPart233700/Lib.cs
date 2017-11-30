using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A010157
{
public static readonly long[] Value={ 8L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L,1L,7L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010157Inst : IEnumerable<long>
{
public static readonly long[] Value=A010157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010157.Bytes);
public long this[int i]=>Value[i];

public static A010157Inst Instance=new A010157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010158
{
public static readonly long[] Value={ 9L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L,18L,4L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010158Inst : IEnumerable<long>
{
public static readonly long[] Value=A010158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010158.Bytes);
public long this[int i]=>Value[i];

public static A010158Inst Instance=new A010158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010159
{
public static readonly long[] Value={ 9L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L,1L,3L,18L,3L,1L,1L,1L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010159Inst : IEnumerable<long>
{
public static readonly long[] Value=A010159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010159.Bytes);
public long this[int i]=>Value[i];

public static A010159Inst Instance=new A010159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010160
{
public static readonly long[] Value={ 9L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L,1L,1L,2L,18L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010160Inst : IEnumerable<long>
{
public static readonly long[] Value=A010160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010160.Bytes);
public long this[int i]=>Value[i];

public static A010160Inst Instance=new A010160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010161
{
public static readonly long[] Value={ 9L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L,18L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010161Inst : IEnumerable<long>
{
public static readonly long[] Value=A010161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010161.Bytes);
public long this[int i]=>Value[i];

public static A010161Inst Instance=new A010161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010162
{
public static readonly long[] Value={ 9L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L,1L,1L,18L,1L,1L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010162Inst : IEnumerable<long>
{
public static readonly long[] Value=A010162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010162.Bytes);
public long this[int i]=>Value[i];

public static A010162Inst Instance=new A010162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010163
{
public static readonly long[] Value={ 9L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L,1L,1L,18L,1L,1L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010163Inst : IEnumerable<long>
{
public static readonly long[] Value=A010163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010163.Bytes);
public long this[int i]=>Value[i];

public static A010163Inst Instance=new A010163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010164
{
public static readonly long[] Value={ 9L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L,1L,1L,18L,1L,1L,1L,4L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010164Inst : IEnumerable<long>
{
public static readonly long[] Value=A010164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010164.Bytes);
public long this[int i]=>Value[i];

public static A010164Inst Instance=new A010164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010165
{
public static readonly long[] Value={ 9L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L,18L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L,18L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L,18L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L,18L,1L,2L,3L,1L,1L,5L,1L,8L,1L,5L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010165Inst : IEnumerable<long>
{
public static readonly long[] Value=A010165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010165.Bytes);
public long this[int i]=>Value[i];

public static A010165Inst Instance=new A010165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010166
{
public static readonly long[] Value={ 9L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L,1L,2L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010166Inst : IEnumerable<long>
{
public static readonly long[] Value=A010166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010166.Bytes);
public long this[int i]=>Value[i];

public static A010166Inst Instance=new A010166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010167
{
public static readonly long[] Value={ 9L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L,1L,3L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010167Inst : IEnumerable<long>
{
public static readonly long[] Value=A010167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010167.Bytes);
public long this[int i]=>Value[i];

public static A010167Inst Instance=new A010167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010168
{
public static readonly long[] Value={ 9L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L,1L,5L,1L,1L,1L,1L,1L,1L,5L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010168Inst : IEnumerable<long>
{
public static readonly long[] Value=A010168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010168.Bytes);
public long this[int i]=>Value[i];

public static A010168Inst Instance=new A010168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010169
{
public static readonly long[] Value={ 9L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L,1L,8L,1L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010169Inst : IEnumerable<long>
{
public static readonly long[] Value=A010169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010169.Bytes);
public long this[int i]=>Value[i];

public static A010169Inst Instance=new A010169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010170
{
public static readonly long[] Value={ 9L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L,18L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010170Inst : IEnumerable<long>
{
public static readonly long[] Value=A010170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010170.Bytes);
public long this[int i]=>Value[i];

public static A010170Inst Instance=new A010170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010171
{
public static readonly long[] Value={ 10L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L,9L,1L,1L,2L,1L,6L,20L,6L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010171Inst : IEnumerable<long>
{
public static readonly long[] Value=A010171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010171.Bytes);
public long this[int i]=>Value[i];

public static A010171Inst Instance=new A010171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010172
{
public static readonly long[] Value={ 10L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L,1L,2L,3L,20L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010172Inst : IEnumerable<long>
{
public static readonly long[] Value=A010172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010172.Bytes);
public long this[int i]=>Value[i];

public static A010172Inst Instance=new A010172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010173
{
public static readonly long[] Value={ 10L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L,9L,1L,2L,20L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010173Inst : IEnumerable<long>
{
public static readonly long[] Value=A010173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010173.Bytes);
public long this[int i]=>Value[i];

public static A010173Inst Instance=new A010173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010222
{
public static readonly long[] Value={ 13L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L,1L,2L,26L,2L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010222Inst : IEnumerable<long>
{
public static readonly long[] Value=A010222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010222.Bytes);
public long this[int i]=>Value[i];

public static A010222Inst Instance=new A010222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010223
{
public static readonly long[] Value={ 13L,2L,1L,1L,1L,3L,5L,13L,5L,3L,1L,1L,1L,2L,26L,2L,1L,1L,1L,3L,5L,13L,5L,3L,1L,1L,1L,2L,26L,2L,1L,1L,1L,3L,5L,13L,5L,3L,1L,1L,1L,2L,26L,2L,1L,1L,1L,3L,5L,13L,5L,3L,1L,1L,1L,2L,26L,2L,1L,1L,1L,3L,5L,13L,5L,3L,1L,1L,1L,2L,26L,2L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010223Inst : IEnumerable<long>
{
public static readonly long[] Value=A010223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010223.Bytes);
public long this[int i]=>Value[i];

public static A010223Inst Instance=new A010223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010224
{
public static readonly long[] Value={ 13L,2L,4L,1L,8L,6L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,6L,8L,1L,4L,2L,26L,2L,4L,1L,8L,6L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,6L,8L,1L,4L,2L,26L,2L,4L,1L,8L,6L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,6L,8L,1L,4L,2L,26L,2L,4L,1L,8L,6L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010224Inst : IEnumerable<long>
{
public static readonly long[] Value=A010224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010224.Bytes);
public long this[int i]=>Value[i];

public static A010224Inst Instance=new A010224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010225
{
public static readonly long[] Value={ 13L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L,8L,1L,1L,26L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010225Inst : IEnumerable<long>
{
public static readonly long[] Value=A010225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010225.Bytes);
public long this[int i]=>Value[i];

public static A010225Inst Instance=new A010225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010226
{
public static readonly long[] Value={ 13L,1L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,26L,1L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,26L,1L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,26L,1L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,26L,1L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,26L,1L,1L,3L,2L,1L,2L,1L,2L,3L,1L,1L,26L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010226Inst : IEnumerable<long>
{
public static readonly long[] Value=A010226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010226.Bytes);
public long this[int i]=>Value[i];

public static A010226Inst Instance=new A010226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010227
{
public static readonly long[] Value={ 13L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L,26L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010227Inst : IEnumerable<long>
{
public static readonly long[] Value=A010227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010227.Bytes);
public long this[int i]=>Value[i];

public static A010227Inst Instance=new A010227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010228
{
public static readonly long[] Value={ 13L,1L,1L,1L,3L,4L,3L,1L,1L,1L,26L,1L,1L,1L,3L,4L,3L,1L,1L,1L,26L,1L,1L,1L,3L,4L,3L,1L,1L,1L,26L,1L,1L,1L,3L,4L,3L,1L,1L,1L,26L,1L,1L,1L,3L,4L,3L,1L,1L,1L,26L,1L,1L,1L,3L,4L,3L,1L,1L,1L,26L,1L,1L,1L,3L,4L,3L,1L,1L,1L,26L,1L,1L,1L,3L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010228Inst : IEnumerable<long>
{
public static readonly long[] Value=A010228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010228.Bytes);
public long this[int i]=>Value[i];

public static A010228Inst Instance=new A010228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010229
{
public static readonly long[] Value={ 13L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L,2L,1L,26L,1L,2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010229Inst : IEnumerable<long>
{
public static readonly long[] Value=A010229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010229.Bytes);
public long this[int i]=>Value[i];

public static A010229Inst Instance=new A010229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010230
{
public static readonly long[] Value={ 13L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L,2L,2L,1L,26L,1L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010230Inst : IEnumerable<long>
{
public static readonly long[] Value=A010230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010230.Bytes);
public long this[int i]=>Value[i];

public static A010230Inst Instance=new A010230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010231
{
public static readonly long[] Value={ 13L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L,26L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010231Inst : IEnumerable<long>
{
public static readonly long[] Value=A010231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010231.Bytes);
public long this[int i]=>Value[i];

public static A010231Inst Instance=new A010231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010232
{
public static readonly long[] Value={ 13L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,1L,3L,1L,26L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,1L,3L,1L,26L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,1L,3L,1L,26L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,1L,3L,1L,26L,1L,3L,1L,1L,1L,2L,2L,2L,1L,1L,1L,3L,1L,26L,1L,3L,1L,1L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010232Inst : IEnumerable<long>
{
public static readonly long[] Value=A010232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010232.Bytes);
public long this[int i]=>Value[i];

public static A010232Inst Instance=new A010232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010233
{
public static readonly long[] Value={ 13L,1L,4L,1L,1L,3L,2L,2L,13L,2L,2L,3L,1L,1L,4L,1L,26L,1L,4L,1L,1L,3L,2L,2L,13L,2L,2L,3L,1L,1L,4L,1L,26L,1L,4L,1L,1L,3L,2L,2L,13L,2L,2L,3L,1L,1L,4L,1L,26L,1L,4L,1L,1L,3L,2L,2L,13L,2L,2L,3L,1L,1L,4L,1L,26L,1L,4L,1L,1L,3L,2L,2L,13L,2L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010233Inst : IEnumerable<long>
{
public static readonly long[] Value=A010233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010233.Bytes);
public long this[int i]=>Value[i];

public static A010233Inst Instance=new A010233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010234
{
public static readonly long[] Value={ 13L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L,26L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010234Inst : IEnumerable<long>
{
public static readonly long[] Value=A010234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010234.Bytes);
public long this[int i]=>Value[i];

public static A010234Inst Instance=new A010234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010235
{
public static readonly long[] Value={ 13L,1L,8L,3L,2L,1L,3L,3L,1L,2L,3L,8L,1L,26L,1L,8L,3L,2L,1L,3L,3L,1L,2L,3L,8L,1L,26L,1L,8L,3L,2L,1L,3L,3L,1L,2L,3L,8L,1L,26L,1L,8L,3L,2L,1L,3L,3L,1L,2L,3L,8L,1L,26L,1L,8L,3L,2L,1L,3L,3L,1L,2L,3L,8L,1L,26L,1L,8L,3L,2L,1L,3L,3L,1L,2L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010235Inst : IEnumerable<long>
{
public static readonly long[] Value=A010235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010235.Bytes);
public long this[int i]=>Value[i];

public static A010235Inst Instance=new A010235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010236
{
public static readonly long[] Value={ 13L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L,12L,1L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010236Inst : IEnumerable<long>
{
public static readonly long[] Value=A010236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010236.Bytes);
public long this[int i]=>Value[i];

public static A010236Inst Instance=new A010236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010237
{
public static readonly long[] Value={ 14L,9L,2L,1L,2L,2L,5L,4L,1L,1L,13L,1L,1L,4L,5L,2L,2L,1L,2L,9L,28L,9L,2L,1L,2L,2L,5L,4L,1L,1L,13L,1L,1L,4L,5L,2L,2L,1L,2L,9L,28L,9L,2L,1L,2L,2L,5L,4L,1L,1L,13L,1L,1L,4L,5L,2L,2L,1L,2L,9L,28L,9L,2L,1L,2L,2L,5L,4L,1L,1L,13L,1L,1L,4L,5L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010237Inst : IEnumerable<long>
{
public static readonly long[] Value=A010237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010237.Bytes);
public long this[int i]=>Value[i];

public static A010237Inst Instance=new A010237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010238
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,4L,4L,7L,12L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010238Inst : IEnumerable<long>
{
public static readonly long[] Value=A010238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010238.Bytes);
public long this[int i]=>Value[i];

public static A010238Inst Instance=new A010238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010239
{
public static readonly long[] Value={ 2L,12L,2L,18L,1L,1L,1L,1L,4L,1L,1L,24L,1L,9L,1L,2L,19L,1L,2L,2L,12L,3L,2L,1L,3L,1L,2L,1L,2L,1L,1L,1L,2L,2L,2L,3L,12L,2L,1L,1L,22L,2L,1L,6L,1L,3L,2L,2L,1L,2L,5L,1L,1L,1L,1L,1L,1L,19L,4L,1L,9L,3L,1L,2L,2L,1L,1L,1L,46L,25L,2L,2L,2L,1L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010239Inst : IEnumerable<long>
{
public static readonly long[] Value=A010239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010239.Bytes);
public long this[int i]=>Value[i];

public static A010239Inst Instance=new A010239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010240
{
public static readonly long[] Value={ 2L,6L,2L,9L,1L,1L,2L,4L,1L,12L,1L,1L,1L,1L,57L,4L,2L,16L,1L,1L,1L,1L,9L,6L,2L,3L,1L,1L,12L,1L,4L,6L,2L,2L,1001L,3L,2L,6L,9L,1L,15L,1L,2L,1L,1L,27L,2L,1L,1L,21L,1L,11L,9L,2L,18L,15L,2L,25L,1L,1L,1L,1L,35L,30L,2L,4L,3L,10L,1L,3L,3L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010240Inst : IEnumerable<long>
{
public static readonly long[] Value=A010240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010240.Bytes);
public long this[int i]=>Value[i];

public static A010240Inst Instance=new A010240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010241
{
public static readonly long[] Value={ 2L,4L,2L,6L,1L,1L,2L,1L,2L,9L,88L,2L,1L,2L,1L,8L,1L,1L,3L,4L,1L,7L,1L,40L,1L,1L,36L,2L,3L,1L,29L,6L,3L,1L,2L,2L,5L,1L,4L,1L,10L,5L,1L,2L,1L,1L,1L,88L,4L,4L,3L,5L,3L,7L,1L,1L,17L,5L,4L,3L,4L,3L,5L,1L,5L,103L,1L,1L,1L,12L,4L,1L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010241Inst : IEnumerable<long>
{
public static readonly long[] Value=A010241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010241.Bytes);
public long this[int i]=>Value[i];

public static A010241Inst Instance=new A010241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010242
{
public static readonly long[] Value={ 2L,3L,2L,5L,15L,7L,3L,1L,1L,3L,1L,1L,96L,7L,2L,6L,3L,36L,1L,17L,25L,2L,4L,9L,24L,9L,1L,3L,2L,34L,1L,73L,1L,9L,1L,1L,17L,6L,2L,163L,2L,1L,1L,1L,2L,81L,3L,1L,1L,34L,3L,11L,1L,75L,12L,2L,2L,2L,1L,1L,3L,1L,19L,4L,1L,1L,2L,3L,6L,1L,234L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010242Inst : IEnumerable<long>
{
public static readonly long[] Value=A010242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010242.Bytes);
public long this[int i]=>Value[i];

public static A010242Inst Instance=new A010242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010243
{
public static readonly long[] Value={ 2L,2L,1L,5L,1L,1L,43L,3L,2L,1L,1L,3L,10L,7L,1L,12L,2L,20L,3L,1L,3L,9L,1L,6L,1L,1L,22L,1L,2L,2L,1L,3L,4L,2L,2L,43L,1L,1L,3L,4L,1L,22L,1L,6L,4L,1L,1L,2L,4L,11L,1L,1L,1L,42L,1L,1L,9L,1L,2L,2L,1L,1L,14L,3L,1L,195L,3L,1L,9L,2L,3L,2L,1L,55L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010243Inst : IEnumerable<long>
{
public static readonly long[] Value=A010243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010243.Bytes);
public long this[int i]=>Value[i];

public static A010243Inst Instance=new A010243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010244
{
public static readonly long[] Value={ 2L,2L,2L,3L,1L,1L,5L,5L,9L,6L,21L,1L,1L,54L,1L,22L,1L,1L,3L,2L,1L,5L,3L,237L,2L,20L,1L,1L,3L,3L,9L,1L,16L,1L,1L,47L,2L,1L,7L,1L,5L,2L,2L,15L,1L,11L,1L,1L,1L,1L,1L,2L,2L,1L,4L,1L,3L,3L,2L,2L,2L,1L,9L,1L,4L,1L,7L,1L,1L,1L,13L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010244Inst : IEnumerable<long>
{
public static readonly long[] Value=A010244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010244.Bytes);
public long this[int i]=>Value[i];

public static A010244Inst Instance=new A010244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010245
{
public static readonly long[] Value={ 2L,2L,6L,1L,8L,1L,10L,8L,12L,1L,719L,4L,2L,5L,2L,2L,3L,3L,2L,1L,46L,4L,2L,11L,2L,1L,3L,11L,2L,1L,7L,1L,1L,3L,5L,1L,1L,2L,16L,1L,2L,2L,1L,3L,2L,1L,3L,1L,1L,1L,19L,10L,13L,1L,1L,1L,4L,1522L,2L,2L,11L,1L,2L,1L,9L,54L,3L,1L,8L,3L,1230L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010245Inst : IEnumerable<long>
{
public static readonly long[] Value=A010245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010245.Bytes);
public long this[int i]=>Value[i];

public static A010245Inst Instance=new A010245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010246
{
public static readonly long[] Value={ 2L,1L,1L,12L,10L,18L,1L,6L,1L,21L,1L,2L,2L,24L,1L,6L,1L,2L,1L,1L,1L,1L,1L,3L,1L,28L,1L,1L,1L,5L,1L,31L,1L,1L,9L,267L,3L,1L,2L,3L,1L,60L,2L,1L,4L,2L,20L,1L,1L,2L,2L,1L,20L,3L,7L,3L,1L,2L,2L,1L,4L,9L,1L,1L,14L,3L,3L,2L,2L,1L,4L,7L,139L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010246Inst : IEnumerable<long>
{
public static readonly long[] Value=A010246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010246.Bytes);
public long this[int i]=>Value[i];

public static A010246Inst Instance=new A010246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010247
{
public static readonly long[] Value={ 2L,1L,1L,3L,138L,1L,1L,3L,2L,3L,1L,1L,207L,1L,2L,2L,1L,1L,1L,1L,2L,4L,9L,1L,2L,4L,1L,1L,3L,4L,277L,2L,5L,3L,3L,3L,1L,1L,1L,1L,13L,2L,15L,20L,2L,1L,1L,1L,1L,1L,2L,1L,2L,18L,2L,4L,1L,22L,20L,51L,23L,2L,1L,3L,2L,204L,1L,2L,3L,1L,4L,1L,3L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010247Inst : IEnumerable<long>
{
public static readonly long[] Value=A010247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010247.Bytes);
public long this[int i]=>Value[i];

public static A010247Inst Instance=new A010247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010248
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,1L,3L,22L,1L,2L,2L,2L,24L,64L,2L,2L,1L,2L,1L,2L,1L,4L,24L,1L,1L,1L,2L,2L,1L,16L,3L,2L,1L,2L,1L,5L,1L,3L,5L,2L,3L,1L,9L,1L,4L,1L,448L,2L,3L,26L,4L,3L,108L,1L,11L,1L,1L,2L,13L,4L,1L,2L,51L,1L,72L,1L,11L,1L,2L,7L,1L,16L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010248Inst : IEnumerable<long>
{
public static readonly long[] Value=A010248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010248.Bytes);
public long this[int i]=>Value[i];

public static A010248Inst Instance=new A010248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010249
{
public static readonly long[] Value={ 2L,1L,2L,63L,1L,2L,2L,2L,1L,95L,2L,1L,1L,2L,7L,4L,2L,3L,1L,2L,3L,127L,1L,4L,1L,3L,1L,4L,4L,12L,2L,1L,1L,1L,5L,1L,18L,2L,3L,1L,1L,1L,1L,1L,2L,1L,1L,8L,1L,4L,1L,4L,8L,1L,1L,2L,1L,1L,11L,1L,12L,6L,1L,1L,3L,2L,3L,3L,1L,2L,8L,1L,3L,2L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010249Inst : IEnumerable<long>
{
public static readonly long[] Value=A010249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010249.Bytes);
public long this[int i]=>Value[i];

public static A010249Inst Instance=new A010249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010250
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,154L,6L,1L,1L,1L,6L,231L,1L,15L,8L,3L,1L,10L,3L,2L,1L,1L,17L,1L,2L,77L,42L,1L,4L,8L,6L,2L,5L,2L,29L,5L,1L,2L,7L,12L,3L,18L,1L,13L,1L,1L,1L,60L,1L,1L,1L,1L,1L,15L,2L,1L,6L,2L,4L,2L,8L,1L,1L,1L,7L,1L,1L,3L,1L,1L,2L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010250Inst : IEnumerable<long>
{
public static readonly long[] Value=A010250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010250.Bytes);
public long this[int i]=>Value[i];

public static A010250Inst Instance=new A010250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010251
{
public static readonly long[] Value={ 2L,1L,3L,6L,1L,3L,17L,1L,7L,3L,3L,11L,2L,92L,1L,3L,1L,3L,1L,2L,2L,26L,2L,1L,20L,1L,4L,2L,10L,43L,2L,1L,4L,2L,3L,1L,11L,2L,1L,1L,4L,1L,1L,1L,10L,1L,1L,1L,2L,1L,12L,35L,1L,1L,2L,1L,1L,5L,1L,3L,204L,4L,1L,1L,5L,2L,13L,3L,2L,5L,1L,6L,253L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010251Inst : IEnumerable<long>
{
public static readonly long[] Value=A010251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010251.Bytes);
public long this[int i]=>Value[i];

public static A010251Inst Instance=new A010251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010252
{
public static readonly long[] Value={ 2L,1L,4L,19L,2L,2L,2L,2L,2L,29L,56L,35L,49L,39L,4L,2L,56L,1L,97L,2L,11L,1L,5L,1L,2L,1L,1L,1L,2L,1L,3L,2L,2L,1L,4L,29L,1L,2L,2L,9L,7L,2L,63L,1L,1L,3L,28L,1L,1L,3L,1L,44L,1L,2L,1L,6L,1L,1L,1L,3L,2L,1L,1L,1L,7L,3L,1L,2L,1L,2L,5L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010252Inst : IEnumerable<long>
{
public static readonly long[] Value=A010252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010252.Bytes);
public long this[int i]=>Value[i];

public static A010252Inst Instance=new A010252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010253
{
public static readonly long[] Value={ 2L,1L,5L,2L,2L,7L,1L,16L,4L,1L,8L,10L,7L,1L,4L,5L,1L,2L,2L,3L,1L,1L,1L,1L,3L,7L,1L,12L,1L,1L,1L,4L,19L,18L,3L,1L,4L,3L,6L,1L,3L,17L,1L,2L,1L,1L,1L,1L,1L,8L,81L,5L,13L,1L,2L,2L,8L,1L,3L,6L,6L,2L,2L,5L,1L,1L,3L,1L,1L,1L,43L,91L,3L,4L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010253Inst : IEnumerable<long>
{
public static readonly long[] Value=A010253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010253.Bytes);
public long this[int i]=>Value[i];

public static A010253Inst Instance=new A010253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010302
{
public static readonly long[] Value={ 4L,5L,23L,1L,5L,2L,4L,1L,3L,19L,1L,3L,2L,6L,3L,1L,17L,1L,1L,1L,4L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,7L,1L,6L,4L,9L,2L,2L,3L,1L,2L,1L,1L,1L,1L,1L,1L,1L,13L,1L,5L,47L,1L,1L,1L,1L,1L,1L,1L,12L,2L,4L,2L,22L,2L,62L,7L,1L,1L,1L,1L,2L,4L,10L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010302Inst : IEnumerable<long>
{
public static readonly long[] Value=A010302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010302.Bytes);
public long this[int i]=>Value[i];

public static A010302Inst Instance=new A010302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010303
{
public static readonly long[] Value={ 4L,4L,1L,1L,1L,1L,7L,1L,2L,6L,2L,2L,10L,2L,3L,2L,1L,1L,3L,1L,2L,1L,41L,1L,2L,3L,1L,1L,4L,1L,2L,1L,2L,5L,1L,17L,3L,1L,1L,112L,6L,3L,1L,3L,11L,7L,1L,4L,9L,1L,1L,1L,2L,8L,2L,1L,1L,3L,1L,1L,2L,2L,1L,24L,1L,2L,71L,2L,3L,1L,1L,2L,2L,3L,9L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010303Inst : IEnumerable<long>
{
public static readonly long[] Value=A010303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010303.Bytes);
public long this[int i]=>Value[i];

public static A010303Inst Instance=new A010303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010304
{
public static readonly long[] Value={ 4L,4L,4L,6L,3L,2L,1L,426L,2L,4L,1L,17L,23L,2L,2L,43L,1L,1L,2L,1L,1L,1L,1L,1L,7L,19L,3L,2L,3L,1L,2L,4L,15L,1L,1L,4L,1L,1L,4L,1L,12L,3L,1L,1L,4L,8L,1L,385L,2L,3L,3L,1L,1L,1L,2L,2L,2L,4L,2L,1L,3L,8L,1L,7L,1L,11L,1L,5L,11L,5L,1L,66L,6L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010304Inst : IEnumerable<long>
{
public static readonly long[] Value=A010304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010304.Bytes);
public long this[int i]=>Value[i];

public static A010304Inst Instance=new A010304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010305
{
public static readonly long[] Value={ 4L,3L,1L,13L,1L,2L,1L,1L,49L,5L,1L,1L,3L,4L,1L,8L,3L,9L,7L,1L,7L,1L,6L,2L,1L,1L,7L,131L,1L,3L,5L,5L,11L,1L,1L,12L,4L,9L,1L,37L,7L,1L,1L,3L,1L,2L,2L,1L,7L,2L,4L,2L,1L,10L,12L,1L,1L,1L,8L,424L,7L,2L,1L,1L,1L,3L,1L,1L,1L,4L,2L,2L,1L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010305Inst : IEnumerable<long>
{
public static readonly long[] Value=A010305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010305.Bytes);
public long this[int i]=>Value[i];

public static A010305Inst Instance=new A010305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010306
{
public static readonly long[] Value={ 4L,3L,1L,2L,120L,7L,1L,45L,3L,2L,6L,1L,4L,149L,1L,1L,1L,9L,2L,4L,2L,2L,23L,2L,1L,1L,1L,5L,49L,4L,1L,3L,1L,2L,1L,3L,1L,1L,1L,5L,1L,1L,9L,1L,4L,2L,3L,2L,2L,1L,2L,1L,12L,1L,2L,79L,5L,22L,3L,1L,12L,2L,14L,1L,6L,8L,1L,2L,1L,1L,2L,1L,1L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010306Inst : IEnumerable<long>
{
public static readonly long[] Value=A010306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010306.Bytes);
public long this[int i]=>Value[i];

public static A010306Inst Instance=new A010306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010307
{
public static readonly long[] Value={ 4L,3L,2L,3L,1L,1L,4L,3L,1L,76L,1L,1L,40L,7L,1L,2L,14L,3L,1L,5L,1L,1L,21L,7L,1L,2L,1L,5L,1L,11L,1L,3L,1L,1L,1L,7L,5L,1L,10L,9L,1L,2L,1L,3L,1L,3L,1L,145L,1L,3L,38L,2L,2L,4L,1L,1L,1L,1L,2L,40L,1L,1L,1L,6L,2L,2L,2L,5L,2L,1L,1L,5L,1L,24L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010307Inst : IEnumerable<long>
{
public static readonly long[] Value=A010307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010307.Bytes);
public long this[int i]=>Value[i];

public static A010307Inst Instance=new A010307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010308
{
public static readonly long[] Value={ 4L,3L,4L,4L,1L,3L,1L,9L,1L,5L,1L,4L,115L,2L,4L,8L,3L,3L,4L,1L,1L,2L,1L,2L,1L,1L,3L,1L,5L,1L,9L,3L,4L,1L,2002L,1L,1L,2L,1L,2L,1L,1L,4L,2L,7L,1L,6L,55L,1L,3L,1L,10L,2L,5L,1L,1L,4L,4L,9L,30L,1L,51L,4L,1L,17L,60L,1L,8L,1L,1L,1L,4L,1L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010308Inst : IEnumerable<long>
{
public static readonly long[] Value=A010308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010308.Bytes);
public long this[int i]=>Value[i];

public static A010308Inst Instance=new A010308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010309
{
public static readonly long[] Value={ 4L,3L,16L,1L,1L,5L,1L,1L,2L,16L,2L,1L,3L,3L,2L,1L,6L,2L,12L,1L,1L,1L,2L,4L,3L,2L,14L,3L,3L,2L,1L,2L,1L,11L,3L,21L,1L,1L,1L,1L,2L,6L,1L,1L,3L,1L,3L,12L,1L,1L,1L,3L,2L,3L,1L,1L,10L,3L,3L,1L,3L,26L,1L,45L,1L,2L,2L,2L,25L,1L,1L,9L,4L,11L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010309Inst : IEnumerable<long>
{
public static readonly long[] Value=A010309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010309.Bytes);
public long this[int i]=>Value[i];

public static A010309Inst Instance=new A010309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010310
{
public static readonly long[] Value={ 4L,2L,1L,9L,3L,3L,93L,4L,4L,1L,2L,3L,2L,7L,1L,2L,2L,5L,1L,1L,1L,2L,1L,3L,4L,4L,4L,217L,4L,2L,1L,1L,1L,3L,1L,4L,51L,45L,10L,1L,6L,1L,2L,4L,1L,2L,2L,1L,5L,11L,1L,4L,1L,1L,3L,3L,1L,2L,128L,5L,1L,1L,5L,4L,1L,43L,1L,4L,15L,5L,1L,2L,1L,3L,1L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010310Inst : IEnumerable<long>
{
public static readonly long[] Value=A010310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010310.Bytes);
public long this[int i]=>Value[i];

public static A010310Inst Instance=new A010310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010311
{
public static readonly long[] Value={ 4L,2L,1L,3L,5L,174L,15L,1L,2L,1L,1L,1L,5L,1L,3L,1L,1L,1L,5L,2L,26L,1L,3L,1L,1L,1L,4L,2L,101L,2L,1L,2L,2L,5L,1L,15L,1L,1L,1L,2L,3L,1L,1L,88L,1L,1L,1L,74L,1L,5L,1L,5L,1L,4L,1L,16L,1L,6L,11L,2L,1L,2L,3L,7L,1L,1L,11L,1L,1L,4L,2L,1L,1L,234L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010311Inst : IEnumerable<long>
{
public static readonly long[] Value=A010311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010311.Bytes);
public long this[int i]=>Value[i];

public static A010311Inst Instance=new A010311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010312
{
public static readonly long[] Value={ 4L,2L,1L,1L,1L,2L,1L,4L,1L,33L,6L,665L,2L,1L,1L,5L,1L,14L,3L,1L,1L,1L,126L,5L,2L,4L,1L,10L,1L,2L,9L,1L,1L,19L,1L,3L,1L,1L,2L,5L,5L,1L,1L,4L,21L,10L,168L,12L,4L,1L,3L,14L,46L,1L,1L,2L,1L,10L,5L,3L,3L,1L,2L,1L,3L,1L,1L,2L,9L,1L,60L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010312Inst : IEnumerable<long>
{
public static readonly long[] Value=A010312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010312.Bytes);
public long this[int i]=>Value[i];

public static A010312Inst Instance=new A010312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010313
{
public static readonly long[] Value={ 4L,2L,1L,1L,12L,58L,1L,5L,1L,3L,2L,1L,1L,2L,1L,5L,9L,2L,2L,3L,1L,1L,84L,3L,1L,1L,12L,1L,1L,2L,2L,2L,7L,4L,2L,1L,6L,4L,15L,22L,1L,13L,1L,2L,57L,4L,2L,1L,1L,3L,2L,46L,1L,2L,1L,5L,1L,15L,1L,16L,1L,1L,12L,1L,1L,1L,1L,20L,2L,1L,1L,2L,3L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010313Inst : IEnumerable<long>
{
public static readonly long[] Value=A010313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010313.Bytes);
public long this[int i]=>Value[i];

public static A010313Inst Instance=new A010313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010314
{
public static readonly long[] Value={ 4L,2L,2L,2L,2L,5L,5L,30L,1L,27L,1L,4L,1L,80L,2L,1L,2L,17L,1L,5L,36L,1L,4L,2L,1L,4L,1L,1L,2L,1L,6L,1L,1L,3L,4L,3L,2L,4L,2L,2L,2L,1L,64L,1L,11L,4L,14L,2L,1L,6L,4L,1L,1L,1L,2L,2L,8L,1L,2L,1L,22L,1L,40L,1L,2L,1L,2L,1L,4L,1L,1L,2L,19L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010314Inst : IEnumerable<long>
{
public static readonly long[] Value=A010314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010314.Bytes);
public long this[int i]=>Value[i];

public static A010314Inst Instance=new A010314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010315
{
public static readonly long[] Value={ 4L,2L,3L,7L,1L,21L,1L,2L,1L,12L,1L,27L,12L,48L,3L,1L,4L,19L,1L,16L,1L,3L,1L,1L,1L,2L,63L,2L,3L,8L,6L,1L,4L,2L,2L,4L,1L,1L,1L,31L,3L,2L,2L,1L,2L,3L,93L,1L,7L,1L,3L,1L,1L,2L,1L,8L,3L,1L,1L,31L,14L,4L,1L,6L,1L,2L,11L,5L,1L,3L,3L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010315Inst : IEnumerable<long>
{
public static readonly long[] Value=A010315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010315.Bytes);
public long this[int i]=>Value[i];

public static A010315Inst Instance=new A010315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010316
{
public static readonly long[] Value={ 4L,2L,4L,3L,3L,2L,5L,4L,1L,1L,43L,1L,2L,6L,1L,3L,1L,3L,1L,1L,1L,1L,1L,16L,1L,19L,1L,3L,18L,4L,1L,1L,59L,3L,7L,2L,2L,1L,2L,2L,2L,2L,5L,11L,2L,4L,1L,43L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,1L,1L,3L,3L,1L,8L,10L,2L,6L,2L,6L,2L,1L,11L,51L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010316Inst : IEnumerable<long>
{
public static readonly long[] Value=A010316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010316.Bytes);
public long this[int i]=>Value[i];

public static A010316Inst Instance=new A010316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010317
{
public static readonly long[] Value={ 4L,2L,6L,1L,1L,2L,4L,6L,1L,1L,2L,6L,1L,3L,1L,2L,1L,3L,1L,1L,8L,1L,1L,2L,2L,3L,1L,16L,2L,1L,1L,7L,1L,1L,2L,1L,11L,72L,1L,1L,1L,4L,1L,1L,9L,10L,1L,2L,1L,2L,2L,1L,3L,2L,1L,1L,9L,15L,4L,2L,1L,3L,2L,3L,5L,6L,2L,3L,4L,1L,20L,4L,1L,1L,1L,5L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010317Inst : IEnumerable<long>
{
public static readonly long[] Value=A010317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010317.Bytes);
public long this[int i]=>Value[i];

public static A010317Inst Instance=new A010317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010366
{
public static readonly long[] Value={ 1L,0L,1L,1L,4L,8L,24L,69L,230L,761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010366Inst : IEnumerable<long>
{
public static readonly long[] Value=A010366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010366.Bytes);
public long this[int i]=>Value[i];

public static A010366Inst Instance=new A010366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010367
{
public static readonly BigInteger[] Value={ 2L,128L,9792L,886784L,92722944L,11014965248L,1465369976832L,215937597784064L,34916329300783104L,6147843514432913408L,BigInteger.Parse("1170908043876450435072") };
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
public class A010367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010367Inst Instance=new A010367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010368
{
public static readonly long[] Value={ 1L,16L,352L,3376L,19648L,82256L,273440L,767600L,1894784L,4228752L,8703712L,16763824L,30549568L,53125072L,88750496L,143203568L,224154368L,341597456L,508345440L,740588080L,1058521024L,1487048272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010368Inst : IEnumerable<long>
{
public static readonly long[] Value=A010368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010368.Bytes);
public long this[int i]=>Value[i];

public static A010368Inst Instance=new A010368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010369
{
public static readonly long[] Value={ 1L,0L,128L,0L,2944L,1024L,31616L,15360L,199424L,101376L,877696L,439296L,3011200L,1464320L,8630144L,4073472L,21607936L,9922560L,48713856L,21829632L,101009792L,44301312L,195640192L,84198400L,358064384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010369Inst : IEnumerable<long>
{
public static readonly long[] Value=A010369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010369.Bytes);
public long this[int i]=>Value[i];

public static A010369Inst Instance=new A010369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010370
{
public static readonly BigInteger[] Value={ 1L,-4L,-12L,-80L,-700L,-7056L,-77616L,-906048L,-11042460L,-139053200L,-1796567344L,-23696871744L,-317933029232L,-4326899214400L,-59605244280000L,-829705000377600L,-11654762427179100L,-165021757273414800L,-2353088020380174000L,BigInteger.Parse("-33764531705178120000") };
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
public class A010370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A010370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A010370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A010370Inst Instance=new A010370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010371
{
public static readonly long[] Value={ 6L,2L,5L,5L,4L,5L,6L,4L,7L,6L,8L,4L,7L,7L,6L,7L,8L,6L,9L,8L,11L,7L,10L,10L,9L,10L,11L,9L,12L,11L,11L,7L,10L,10L,9L,10L,11L,9L,12L,11L,10L,6L,9L,9L,8L,9L,10L,8L,11L,10L,11L,7L,10L,10L,9L,10L,11L,9L,12L,11L,12L,8L,11L,11L,10L,11L,12L,10L,13L,12L,10L,6L,9L,9L,8L,9L,10L,8L,11L,10L,13L,9L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010371Inst : IEnumerable<long>
{
public static readonly long[] Value=A010371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010371.Bytes);
public long this[int i]=>Value[i];

public static A010371Inst Instance=new A010371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010372
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,2L,9L,8L,35L,39L,159L,202L,802L,1078L,4347L,6354L,24894L,38157L,148284L,237541L,910726L,1511717L,5731580L,9816092L,36797588L,64658432L,240215803L,431987953L,1590507121L,2917928218L,10660307791L,19910436898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010372Inst : IEnumerable<long>
{
public static readonly long[] Value=A010372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010372.Bytes);
public long this[int i]=>Value[i];

public static A010372Inst Instance=new A010372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010373
{
public static readonly long[] Value={ 1L,1L,3L,10L,36L,153L,780L,4005L,22366L,128778L,766941L,4674153L,29180980L,185117661L,1193918545L,7800816871L,51584238201L,344632209090L,2324190638055L,15804057614995L,108277583483391L,746878494484128L,5183852459907628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010373Inst : IEnumerable<long>
{
public static readonly long[] Value=A010373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010373.Bytes);
public long this[int i]=>Value[i];

public static A010373Inst Instance=new A010373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010374
{
public static readonly long[] Value={ 1L,2L,5L,12L,29L,72L,182L,464L,1190L,3070L,7958L,20706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010374Inst : IEnumerable<long>
{
public static readonly long[] Value=A010374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010374.Bytes);
public long this[int i]=>Value[i];

public static A010374Inst Instance=new A010374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010375
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010375Inst : IEnumerable<long>
{
public static readonly long[] Value=A010375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010375.Bytes);
public long this[int i]=>Value[i];

public static A010375Inst Instance=new A010375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010376
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010376Inst : IEnumerable<long>
{
public static readonly long[] Value=A010376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010376.Bytes);
public long this[int i]=>Value[i];

public static A010376Inst Instance=new A010376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010377
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,8L,9L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010377Inst : IEnumerable<long>
{
public static readonly long[] Value=A010377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010377.Bytes);
public long this[int i]=>Value[i];

public static A010377Inst Instance=new A010377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010378
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010378Inst : IEnumerable<long>
{
public static readonly long[] Value=A010378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010378.Bytes);
public long this[int i]=>Value[i];

public static A010378Inst Instance=new A010378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010379
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,9L,13L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010379Inst : IEnumerable<long>
{
public static readonly long[] Value=A010379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010379.Bytes);
public long this[int i]=>Value[i];

public static A010379Inst Instance=new A010379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010380
{
public static readonly long[] Value={ 0L,1L,4L,7L,9L,10L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010380Inst : IEnumerable<long>
{
public static readonly long[] Value=A010380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010380.Bytes);
public long this[int i]=>Value[i];

public static A010380Inst Instance=new A010380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010381
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,9L,11L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010381Inst : IEnumerable<long>
{
public static readonly long[] Value=A010381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010381.Bytes);
public long this[int i]=>Value[i];

public static A010381Inst Instance=new A010381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010414
{
public static readonly long[] Value={ 0L,1L,4L,6L,7L,9L,10L,11L,13L,15L,16L,17L,24L,25L,28L,29L,36L,37L,38L,40L,42L,43L,44L,46L,47L,49L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010414Inst : IEnumerable<long>
{
public static readonly long[] Value=A010414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010414.Bytes);
public long this[int i]=>Value[i];

public static A010414Inst Instance=new A010414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010415
{
public static readonly long[] Value={ 0L,1L,4L,7L,9L,10L,13L,16L,19L,22L,25L,27L,28L,31L,34L,36L,37L,40L,43L,46L,49L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010415Inst : IEnumerable<long>
{
public static readonly long[] Value=A010415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010415.Bytes);
public long this[int i]=>Value[i];

public static A010415Inst Instance=new A010415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010416
{
public static readonly long[] Value={ 0L,1L,4L,5L,9L,11L,14L,15L,16L,20L,25L,26L,31L,34L,36L,44L,45L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010416Inst : IEnumerable<long>
{
public static readonly long[] Value=A010416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010416.Bytes);
public long this[int i]=>Value[i];

public static A010416Inst Instance=new A010416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010417
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,16L,25L,28L,32L,36L,44L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010417Inst : IEnumerable<long>
{
public static readonly long[] Value=A010417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010417.Bytes);
public long this[int i]=>Value[i];

public static A010417Inst Instance=new A010417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010418
{
public static readonly long[] Value={ 0L,1L,4L,6L,7L,9L,16L,19L,24L,25L,28L,30L,36L,39L,42L,43L,45L,49L,54L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010418Inst : IEnumerable<long>
{
public static readonly long[] Value=A010418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010418.Bytes);
public long this[int i]=>Value[i];

public static A010418Inst Instance=new A010418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010419
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,7L,9L,13L,16L,20L,22L,23L,24L,25L,28L,29L,30L,33L,34L,35L,36L,38L,42L,45L,49L,51L,52L,53L,54L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010419Inst : IEnumerable<long>
{
public static readonly long[] Value=A010419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010419.Bytes);
public long this[int i]=>Value[i];

public static A010419Inst Instance=new A010419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010420
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,9L,12L,15L,16L,17L,19L,20L,21L,22L,25L,26L,27L,28L,29L,35L,36L,41L,45L,46L,48L,49L,51L,53L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010420Inst : IEnumerable<long>
{
public static readonly long[] Value=A010420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010420.Bytes);
public long this[int i]=>Value[i];

public static A010420Inst Instance=new A010420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010421
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,21L,24L,25L,36L,40L,45L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010421Inst : IEnumerable<long>
{
public static readonly long[] Value=A010421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010421.Bytes);
public long this[int i]=>Value[i];

public static A010421Inst Instance=new A010421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010422
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,9L,12L,13L,14L,15L,16L,19L,20L,22L,25L,27L,34L,36L,39L,41L,42L,45L,46L,47L,48L,49L,52L,56L,57L,58L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010422Inst : IEnumerable<long>
{
public static readonly long[] Value=A010422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010422.Bytes);
public long this[int i]=>Value[i];

public static A010422Inst Instance=new A010422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010423
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,9L,10L,14L,16L,18L,19L,20L,25L,28L,31L,32L,33L,35L,36L,38L,39L,40L,41L,45L,47L,49L,50L,51L,56L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010423Inst : IEnumerable<long>
{
public static readonly long[] Value=A010423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010423.Bytes);
public long this[int i]=>Value[i];

public static A010423Inst Instance=new A010423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010424
{
public static readonly long[] Value={ 0L,1L,4L,7L,9L,16L,18L,22L,25L,28L,36L,37L,43L,46L,49L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010424Inst : IEnumerable<long>
{
public static readonly long[] Value=A010424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010424.Bytes);
public long this[int i]=>Value[i];

public static A010424Inst Instance=new A010424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010425
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,17L,25L,33L,36L,41L,49L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010425Inst : IEnumerable<long>
{
public static readonly long[] Value=A010425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010425.Bytes);
public long this[int i]=>Value[i];

public static A010425Inst Instance=new A010425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010426
{
public static readonly long[] Value={ 0L,1L,4L,9L,10L,14L,16L,25L,26L,29L,30L,35L,36L,39L,40L,49L,51L,55L,56L,61L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010426Inst : IEnumerable<long>
{
public static readonly long[] Value=A010426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010426.Bytes);
public long this[int i]=>Value[i];

public static A010426Inst Instance=new A010426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010427
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,12L,15L,16L,22L,25L,27L,31L,33L,34L,36L,37L,42L,45L,48L,49L,55L,58L,60L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010427Inst : IEnumerable<long>
{
public static readonly long[] Value=A010427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010427.Bytes);
public long this[int i]=>Value[i];

public static A010427Inst Instance=new A010427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010428
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,10L,14L,15L,16L,17L,19L,21L,22L,23L,24L,25L,26L,29L,33L,35L,36L,37L,39L,40L,47L,49L,54L,55L,56L,59L,60L,62L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010428Inst : IEnumerable<long>
{
public static readonly long[] Value=A010428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010428.Bytes);
public long this[int i]=>Value[i];

public static A010428Inst Instance=new A010428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010429
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,13L,16L,17L,21L,25L,32L,33L,36L,49L,52L,53L,60L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010429Inst : IEnumerable<long>
{
public static readonly long[] Value=A010429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010429.Bytes);
public long this[int i]=>Value[i];

public static A010429Inst Instance=new A010429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010462
{
public static readonly long[] Value={ 0L,1L,4L,6L,9L,10L,15L,16L,19L,21L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010462Inst : IEnumerable<long>
{
public static readonly long[] Value=A010462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010462.Bytes);
public long this[int i]=>Value[i];

public static A010462Inst Instance=new A010462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010463
{
public static readonly long[] Value={ 1L,0L,0L,992L,10540L,60512L,228160L,446400L,603942L,446400L,228160L,60512L,10540L,992L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010463Inst : IEnumerable<long>
{
public static readonly long[] Value=A010463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010463.Bytes);
public long this[int i]=>Value[i];

public static A010463Inst Instance=new A010463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A010464
{
public static readonly long[] Value={ 2L,4L,4L,9L,4L,8L,9L,7L,4L,2L,7L,8L,3L,1L,7L,8L,0L,9L,8L,1L,9L,7L,2L,8L,4L,0L,7L,4L,7L,0L,5L,8L,9L,1L,3L,9L,1L,9L,6L,5L,9L,4L,7L,4L,8L,0L,6L,5L,6L,6L,7L,0L,1L,2L,8L,4L,3L,2L,6L,9L,2L,5L,6L,7L,2L,5L,0L,9L,6L,0L,3L,7L,7L,4L,5L,7L,3L,1L,5L,0L,2L,6L,5L,3L,9L,8L,5L,9L,4L,3L,3L,1L,0L,4L,6L,4L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A010464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A010464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A010464Inst : IEnumerable<long>
{
public static readonly long[] Value=A010464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A010464.Bytes);
public long this[int i]=>Value[i];

public static A010464Inst Instance=new A010464Inst();

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