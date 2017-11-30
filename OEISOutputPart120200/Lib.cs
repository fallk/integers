using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A154164
{
public static readonly long[] Value={ 8L,7L,2L,5L,0L,2L,8L,6L,9L,5L,4L,9L,1L,5L,5L,8L,9L,0L,0L,2L,4L,3L,1L,9L,4L,3L,8L,6L,1L,2L,9L,5L,0L,9L,0L,3L,1L,0L,7L,5L,8L,7L,5L,3L,2L,0L,3L,1L,8L,9L,4L,6L,5L,5L,1L,6L,1L,5L,7L,5L,3L,9L,9L,7L,4L,6L,5L,9L,1L,5L,6L,4L,4L,0L,4L,6L,0L,3L,0L,7L,1L,1L,8L,2L,3L,2L,9L,2L,6L,0L,5L,1L,2L,5L,0L,4L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154164Inst : IEnumerable<long>
{
public static readonly long[] Value=A154164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154164.Bytes);
public long this[int i]=>Value[i];

public static A154164Inst Instance=new A154164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154165
{
public static readonly long[] Value={ 8L,5L,0L,2L,7L,4L,1L,5L,3L,7L,2L,7L,6L,0L,2L,5L,9L,5L,0L,0L,4L,7L,7L,2L,6L,8L,2L,2L,6L,3L,4L,0L,9L,7L,4L,0L,9L,0L,5L,0L,7L,4L,1L,0L,1L,4L,9L,2L,6L,2L,0L,7L,1L,4L,8L,4L,2L,1L,6L,8L,4L,0L,4L,7L,4L,8L,4L,4L,8L,0L,4L,6L,4L,8L,3L,0L,9L,9L,6L,9L,8L,1L,3L,4L,1L,1L,2L,7L,9L,2L,7L,3L,9L,3L,9L,8L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154165Inst : IEnumerable<long>
{
public static readonly long[] Value=A154165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154165.Bytes);
public long this[int i]=>Value[i];

public static A154165Inst Instance=new A154165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154166
{
public static readonly long[] Value={ 8L,3L,0L,4L,8L,2L,0L,2L,3L,7L,2L,1L,8L,4L,0L,5L,8L,6L,9L,6L,7L,5L,7L,9L,8L,5L,7L,3L,7L,2L,3L,4L,7L,5L,4L,3L,9L,6L,6L,2L,0L,7L,8L,4L,8L,2L,5L,6L,1L,4L,5L,1L,5L,3L,0L,1L,3L,6L,8L,9L,0L,9L,8L,9L,5L,3L,9L,8L,3L,6L,9L,4L,1L,5L,2L,1L,5L,6L,3L,0L,3L,9L,6L,2L,5L,3L,4L,9L,3L,5L,8L,3L,9L,8L,4L,2L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154166Inst : IEnumerable<long>
{
public static readonly long[] Value=A154166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154166.Bytes);
public long this[int i]=>Value[i];

public static A154166Inst Instance=new A154166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154167
{
public static readonly long[] Value={ 8L,1L,2L,7L,1L,1L,5L,0L,9L,2L,9L,1L,9L,5L,8L,9L,9L,9L,2L,5L,5L,6L,2L,1L,9L,8L,9L,7L,2L,6L,5L,9L,8L,3L,3L,2L,2L,9L,1L,7L,6L,3L,0L,2L,9L,9L,8L,4L,8L,0L,4L,9L,0L,8L,7L,0L,8L,8L,8L,2L,3L,5L,6L,0L,8L,5L,4L,0L,0L,5L,9L,0L,8L,7L,9L,7L,6L,5L,8L,1L,4L,5L,6L,1L,4L,3L,8L,4L,4L,5L,6L,0L,3L,4L,8L,7L,9L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154167Inst : IEnumerable<long>
{
public static readonly long[] Value=A154167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154167.Bytes);
public long this[int i]=>Value[i];

public static A154167Inst Instance=new A154167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154168
{
public static readonly long[] Value={ 7L,9L,6L,6L,3L,9L,7L,7L,0L,1L,9L,6L,9L,1L,2L,1L,6L,4L,7L,3L,4L,7L,4L,7L,2L,3L,5L,0L,2L,0L,3L,7L,2L,6L,6L,4L,1L,1L,6L,0L,0L,6L,9L,1L,5L,0L,2L,7L,5L,9L,8L,1L,6L,0L,1L,7L,2L,4L,3L,7L,1L,2L,8L,9L,8L,1L,6L,5L,9L,3L,2L,4L,0L,4L,2L,7L,6L,1L,6L,1L,6L,3L,9L,8L,1L,9L,6L,1L,5L,9L,6L,7L,0L,1L,8L,3L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154168Inst : IEnumerable<long>
{
public static readonly long[] Value=A154168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154168.Bytes);
public long this[int i]=>Value[i];

public static A154168Inst Instance=new A154168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154169
{
public static readonly long[] Value={ 7L,8L,2L,0L,1L,1L,4L,8L,3L,0L,9L,9L,5L,4L,0L,6L,8L,6L,0L,6L,2L,4L,1L,0L,0L,3L,0L,9L,1L,5L,5L,0L,9L,3L,0L,8L,0L,4L,3L,8L,4L,4L,0L,2L,9L,2L,2L,0L,8L,7L,3L,1L,0L,5L,1L,8L,5L,5L,5L,0L,8L,4L,9L,3L,3L,9L,4L,6L,5L,6L,9L,6L,9L,5L,0L,0L,2L,4L,3L,4L,3L,3L,6L,7L,5L,0L,4L,3L,4L,7L,4L,6L,3L,8L,6L,1L,3L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154169Inst : IEnumerable<long>
{
public static readonly long[] Value=A154169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154169.Bytes);
public long this[int i]=>Value[i];

public static A154169Inst Instance=new A154169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154170
{
public static readonly long[] Value={ 7L,6L,8L,6L,2L,1L,7L,8L,6L,8L,4L,0L,2L,4L,0L,8L,2L,5L,7L,3L,6L,3L,0L,2L,2L,9L,8L,9L,0L,2L,3L,5L,9L,5L,0L,4L,1L,0L,9L,0L,3L,4L,4L,9L,2L,6L,2L,6L,4L,3L,4L,1L,3L,8L,1L,6L,0L,3L,8L,2L,2L,0L,5L,8L,8L,6L,4L,7L,5L,4L,4L,5L,9L,6L,9L,8L,4L,1L,6L,1L,5L,2L,8L,6L,0L,3L,4L,4L,1L,5L,9L,5L,5L,2L,4L,6L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154170Inst : IEnumerable<long>
{
public static readonly long[] Value=A154170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154170.Bytes);
public long this[int i]=>Value[i];

public static A154170Inst Instance=new A154170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154171
{
public static readonly long[] Value={ 7L,5L,6L,3L,0L,4L,1L,9L,5L,5L,1L,6L,4L,0L,1L,0L,6L,2L,6L,1L,8L,1L,3L,1L,2L,2L,5L,1L,6L,0L,0L,1L,0L,9L,0L,9L,6L,8L,0L,0L,3L,0L,7L,2L,2L,5L,7L,8L,0L,2L,3L,6L,8L,2L,6L,2L,6L,2L,5L,0L,6L,1L,7L,7L,8L,6L,0L,4L,6L,9L,6L,9L,3L,5L,8L,9L,7L,7L,2L,9L,3L,2L,6L,9L,8L,6L,4L,8L,8L,0L,4L,2L,8L,0L,9L,8L,0L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154171Inst : IEnumerable<long>
{
public static readonly long[] Value=A154171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154171.Bytes);
public long this[int i]=>Value[i];

public static A154171Inst Instance=new A154171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154172
{
public static readonly long[] Value={ 7L,4L,4L,9L,2L,1L,8L,5L,9L,7L,7L,3L,3L,4L,6L,9L,4L,7L,3L,1L,8L,0L,3L,7L,9L,5L,2L,3L,6L,2L,7L,8L,2L,4L,0L,6L,9L,2L,1L,6L,2L,4L,5L,6L,7L,7L,2L,2L,0L,6L,6L,7L,8L,7L,9L,2L,2L,5L,6L,0L,1L,0L,1L,8L,0L,5L,1L,7L,7L,4L,5L,2L,0L,8L,4L,4L,6L,7L,4L,7L,1L,0L,6L,5L,8L,1L,3L,4L,4L,9L,1L,1L,7L,8L,6L,6L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154172Inst : IEnumerable<long>
{
public static readonly long[] Value=A154172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154172.Bytes);
public long this[int i]=>Value[i];

public static A154172Inst Instance=new A154172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154173
{
public static readonly long[] Value={ 7L,3L,4L,3L,6L,1L,1L,3L,5L,5L,7L,3L,5L,5L,5L,5L,9L,0L,8L,0L,7L,9L,7L,9L,3L,3L,4L,6L,3L,6L,4L,2L,0L,6L,3L,7L,1L,5L,3L,1L,8L,2L,1L,6L,0L,0L,9L,1L,9L,2L,4L,0L,7L,5L,2L,4L,9L,7L,3L,5L,6L,3L,7L,1L,0L,9L,6L,3L,1L,6L,4L,3L,5L,4L,1L,8L,4L,0L,4L,4L,2L,3L,9L,7L,9L,7L,2L,5L,0L,3L,7L,9L,8L,5L,4L,9L,8L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154173Inst : IEnumerable<long>
{
public static readonly long[] Value=A154173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154173.Bytes);
public long this[int i]=>Value[i];

public static A154173Inst Instance=new A154173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154174
{
public static readonly long[] Value={ 7L,2L,4L,5L,2L,6L,7L,7L,5L,1L,6L,2L,2L,5L,3L,8L,6L,4L,7L,4L,4L,4L,3L,7L,2L,2L,5L,6L,5L,0L,9L,7L,6L,0L,1L,6L,6L,1L,8L,6L,8L,2L,9L,0L,1L,7L,7L,7L,6L,4L,9L,0L,5L,3L,9L,2L,3L,7L,7L,0L,1L,8L,5L,1L,8L,5L,0L,7L,5L,6L,9L,5L,3L,3L,9L,9L,0L,4L,7L,7L,3L,3L,5L,7L,2L,3L,7L,3L,1L,0L,6L,9L,5L,8L,6L,2L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154174Inst : IEnumerable<long>
{
public static readonly long[] Value=A154174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154174.Bytes);
public long this[int i]=>Value[i];

public static A154174Inst Instance=new A154174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154175
{
public static readonly long[] Value={ 2L,1L,8L,2L,6L,5L,8L,3L,3L,8L,6L,4L,4L,1L,3L,8L,0L,8L,1L,0L,4L,8L,9L,8L,0L,4L,1L,4L,7L,3L,1L,9L,2L,8L,9L,2L,3L,5L,4L,2L,9L,6L,1L,5L,2L,5L,2L,0L,0L,9L,4L,4L,3L,6L,0L,2L,3L,7L,2L,9L,3L,0L,1L,0L,1L,7L,1L,8L,0L,8L,6L,3L,3L,8L,9L,1L,4L,1L,2L,3L,6L,3L,3L,2L,5L,2L,6L,1L,0L,3L,0L,1L,6L,3L,9L,7L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154175Inst : IEnumerable<long>
{
public static readonly long[] Value=A154175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154175.Bytes);
public long this[int i]=>Value[i];

public static A154175Inst Instance=new A154175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154176
{
public static readonly long[] Value={ 1L,7L,2L,9L,7L,1L,5L,8L,0L,9L,3L,1L,8L,6L,4L,8L,6L,2L,8L,0L,9L,9L,6L,8L,1L,5L,2L,3L,3L,6L,2L,8L,9L,6L,4L,7L,9L,3L,5L,1L,6L,1L,5L,7L,6L,2L,8L,4L,0L,8L,8L,4L,0L,3L,5L,6L,5L,6L,4L,0L,0L,8L,2L,2L,8L,6L,3L,1L,6L,5L,3L,0L,9L,8L,6L,0L,0L,0L,9L,1L,7L,6L,3L,5L,4L,7L,4L,5L,6L,4L,9L,6L,4L,3L,4L,5L,0L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154176Inst : IEnumerable<long>
{
public static readonly long[] Value=A154176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154176.Bytes);
public long this[int i]=>Value[i];

public static A154176Inst Instance=new A154176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154177
{
public static readonly long[] Value={ 1L,4L,8L,9L,8L,9L,6L,1L,0L,2L,4L,0L,4L,9L,7L,8L,0L,7L,2L,7L,9L,9L,2L,0L,1L,7L,7L,9L,9L,8L,3L,9L,7L,1L,3L,0L,7L,6L,1L,3L,4L,8L,0L,4L,4L,4L,5L,5L,9L,6L,3L,3L,7L,5L,0L,5L,2L,7L,3L,5L,2L,6L,0L,6L,5L,1L,1L,2L,9L,8L,8L,2L,2L,5L,3L,5L,4L,0L,6L,9L,1L,4L,8L,3L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154177Inst : IEnumerable<long>
{
public static readonly long[] Value=A154177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154177.Bytes);
public long this[int i]=>Value[i];

public static A154177Inst Instance=new A154177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154178
{
public static readonly long[] Value={ 1L,3L,3L,8L,2L,9L,0L,8L,3L,3L,1L,0L,5L,7L,7L,2L,5L,3L,9L,9L,5L,8L,4L,1L,7L,6L,1L,0L,8L,7L,2L,9L,8L,3L,1L,9L,8L,4L,1L,1L,6L,5L,6L,8L,1L,7L,2L,2L,1L,0L,3L,9L,8L,5L,6L,5L,7L,1L,6L,0L,4L,5L,6L,2L,2L,0L,8L,3L,3L,1L,6L,2L,0L,8L,7L,4L,8L,5L,7L,1L,3L,8L,4L,0L,9L,2L,3L,9L,4L,3L,5L,3L,9L,1L,0L,3L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154178Inst : IEnumerable<long>
{
public static readonly long[] Value=A154178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154178.Bytes);
public long this[int i]=>Value[i];

public static A154178Inst Instance=new A154178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154179
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,7L,4L,4L,0L,5L,8L,6L,7L,3L,4L,3L,7L,6L,1L,8L,6L,0L,7L,5L,6L,8L,6L,7L,6L,5L,5L,6L,2L,9L,2L,9L,9L,1L,5L,2L,8L,3L,9L,8L,9L,3L,2L,8L,6L,8L,1L,7L,5L,5L,5L,6L,2L,6L,3L,2L,3L,1L,3L,4L,7L,9L,6L,8L,2L,9L,5L,0L,4L,2L,4L,1L,7L,7L,0L,0L,9L,0L,8L,8L,8L,6L,7L,3L,7L,6L,0L,2L,9L,7L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154179Inst : IEnumerable<long>
{
public static readonly long[] Value=A154179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154179.Bytes);
public long this[int i]=>Value[i];

public static A154179Inst Instance=new A154179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154180
{
public static readonly long[] Value={ 1L,1L,5L,3L,1L,4L,3L,8L,7L,2L,8L,7L,9L,0L,9L,9L,0L,8L,5L,3L,9L,9L,7L,8L,7L,6L,8L,2L,2L,4L,1L,9L,3L,0L,9L,8L,6L,2L,3L,4L,4L,1L,0L,5L,0L,8L,5L,6L,0L,5L,8L,9L,3L,5L,7L,1L,0L,4L,2L,6L,7L,2L,1L,5L,2L,4L,2L,1L,1L,0L,2L,0L,6L,5L,7L,3L,3L,3L,9L,4L,5L,0L,9L,0L,3L,1L,6L,3L,7L,6L,6L,4L,2L,8L,9L,6L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154180Inst : IEnumerable<long>
{
public static readonly long[] Value=A154180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154180.Bytes);
public long this[int i]=>Value[i];

public static A154180Inst Instance=new A154180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154181
{
public static readonly long[] Value={ 1L,0L,9L,1L,3L,2L,9L,1L,6L,9L,3L,2L,2L,0L,6L,9L,0L,4L,0L,5L,2L,4L,4L,9L,0L,2L,0L,7L,3L,6L,5L,9L,6L,4L,4L,6L,1L,7L,7L,1L,4L,8L,0L,7L,6L,2L,6L,0L,0L,4L,7L,2L,1L,8L,0L,1L,1L,8L,6L,4L,6L,5L,0L,5L,0L,8L,5L,9L,0L,4L,3L,1L,6L,9L,4L,5L,7L,0L,6L,1L,8L,1L,6L,6L,2L,6L,3L,0L,5L,1L,5L,0L,8L,1L,9L,8L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154181Inst : IEnumerable<long>
{
public static readonly long[] Value=A154181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154181.Bytes);
public long this[int i]=>Value[i];

public static A154181Inst Instance=new A154181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154182
{
public static readonly long[] Value={ 1L,0L,4L,1L,3L,9L,2L,6L,8L,5L,1L,5L,8L,2L,2L,5L,0L,4L,0L,7L,5L,0L,1L,9L,9L,9L,7L,1L,2L,4L,3L,0L,2L,4L,2L,4L,1L,7L,0L,6L,7L,0L,2L,1L,9L,0L,4L,6L,6L,4L,5L,3L,0L,9L,4L,5L,9L,6L,5L,3L,9L,0L,1L,8L,6L,7L,9L,7L,5L,3L,0L,3L,2L,2L,3L,3L,2L,4L,9L,3L,4L,7L,5L,7L,1L,2L,9L,4L,7L,8L,6L,3L,8L,5L,7L,3L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154182Inst : IEnumerable<long>
{
public static readonly long[] Value=A154182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154182.Bytes);
public long this[int i]=>Value[i];

public static A154182Inst Instance=new A154182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154183
{
public static readonly long[] Value={ 9L,6L,4L,9L,8L,4L,0L,4L,5L,9L,8L,1L,3L,4L,3L,7L,5L,0L,8L,5L,8L,1L,1L,3L,0L,0L,6L,2L,4L,7L,2L,5L,4L,9L,1L,2L,5L,8L,1L,8L,0L,7L,7L,7L,1L,8L,6L,5L,2L,9L,3L,8L,7L,8L,0L,0L,7L,3L,0L,6L,4L,3L,4L,7L,5L,6L,3L,6L,6L,3L,0L,3L,6L,5L,5L,6L,3L,3L,3L,2L,7L,3L,9L,3L,7L,1L,2L,4L,5L,6L,7L,7L,4L,6L,9L,3L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154183Inst : IEnumerable<long>
{
public static readonly long[] Value=A154183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154183.Bytes);
public long this[int i]=>Value[i];

public static A154183Inst Instance=new A154183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154184
{
public static readonly long[] Value={ 9L,3L,4L,8L,7L,0L,4L,1L,5L,9L,8L,8L,0L,5L,8L,6L,3L,0L,3L,6L,5L,3L,2L,8L,0L,8L,8L,6L,1L,3L,5L,5L,5L,7L,7L,4L,1L,1L,4L,0L,9L,7L,4L,4L,9L,5L,7L,6L,0L,3L,0L,7L,0L,5L,4L,0L,4L,9L,4L,9L,5L,7L,6L,8L,3L,3L,8L,1L,6L,8L,7L,1L,3L,7L,8L,3L,9L,8L,8L,9L,5L,2L,5L,3L,2L,7L,5L,7L,2L,1L,8L,8L,4L,8L,2L,4L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154184Inst : IEnumerable<long>
{
public static readonly long[] Value=A154184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154184.Bytes);
public long this[int i]=>Value[i];

public static A154184Inst Instance=new A154184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154185
{
public static readonly long[] Value={ 9L,0L,8L,6L,1L,8L,1L,0L,6L,1L,2L,8L,0L,5L,1L,9L,9L,3L,8L,8L,5L,0L,7L,2L,3L,3L,5L,7L,8L,5L,4L,0L,0L,0L,4L,0L,9L,3L,7L,5L,2L,6L,0L,6L,8L,6L,2L,2L,1L,1L,8L,6L,3L,6L,6L,5L,8L,4L,5L,4L,2L,4L,5L,9L,8L,2L,6L,8L,5L,2L,5L,7L,1L,7L,8L,2L,0L,1L,0L,7L,0L,4L,8L,4L,0L,5L,5L,2L,4L,7L,1L,6L,3L,1L,7L,8L,1L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154185Inst : IEnumerable<long>
{
public static readonly long[] Value=A154185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154185.Bytes);
public long this[int i]=>Value[i];

public static A154185Inst Instance=new A154185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154186
{
public static readonly long[] Value={ 8L,8L,5L,4L,6L,9L,2L,8L,4L,0L,7L,1L,0L,2L,5L,4L,8L,7L,6L,4L,7L,3L,7L,9L,5L,2L,6L,7L,7L,0L,8L,1L,2L,3L,4L,5L,3L,0L,2L,8L,8L,8L,5L,0L,4L,9L,0L,1L,0L,3L,1L,6L,8L,1L,9L,0L,1L,6L,9L,1L,9L,8L,5L,5L,2L,5L,5L,1L,3L,6L,6L,2L,7L,0L,8L,3L,8L,6L,0L,1L,2L,1L,2L,2L,0L,0L,9L,2L,8L,3L,0L,6L,2L,5L,7L,8L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154186Inst : IEnumerable<long>
{
public static readonly long[] Value=A154186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154186.Bytes);
public long this[int i]=>Value[i];

public static A154186Inst Instance=new A154186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154187
{
public static readonly long[] Value={ 8L,6L,4L,8L,5L,7L,9L,0L,4L,6L,5L,9L,3L,2L,4L,3L,1L,4L,0L,4L,9L,8L,4L,0L,7L,6L,1L,6L,8L,1L,4L,4L,8L,2L,3L,9L,6L,7L,5L,8L,0L,7L,8L,8L,1L,4L,2L,0L,4L,4L,2L,0L,1L,7L,8L,2L,8L,2L,0L,0L,4L,1L,1L,4L,3L,1L,5L,8L,2L,6L,5L,4L,9L,3L,0L,0L,0L,4L,5L,8L,8L,1L,7L,7L,3L,7L,2L,8L,2L,4L,8L,2L,1L,7L,2L,5L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154187Inst : IEnumerable<long>
{
public static readonly long[] Value=A154187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154187.Bytes);
public long this[int i]=>Value[i];

public static A154187Inst Instance=new A154187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154188
{
public static readonly long[] Value={ 8L,4L,6L,3L,5L,1L,8L,2L,0L,9L,2L,0L,5L,4L,6L,9L,4L,2L,8L,2L,0L,6L,0L,1L,9L,2L,0L,4L,6L,1L,7L,0L,7L,8L,8L,2L,7L,7L,7L,9L,5L,6L,3L,4L,0L,6L,8L,1L,4L,0L,7L,0L,2L,8L,7L,0L,9L,1L,4L,9L,7L,6L,2L,7L,7L,4L,7L,4L,4L,2L,6L,9L,8L,1L,9L,3L,7L,7L,0L,9L,4L,5L,9L,9L,5L,2L,0L,5L,1L,9L,8L,4L,4L,3L,4L,8L,8L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154188Inst : IEnumerable<long>
{
public static readonly long[] Value=A154188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154188.Bytes);
public long this[int i]=>Value[i];

public static A154188Inst Instance=new A154188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154189
{
public static readonly long[] Value={ 8L,2L,9L,6L,1L,4L,8L,2L,9L,3L,8L,9L,1L,9L,3L,6L,9L,8L,0L,4L,4L,9L,1L,7L,1L,0L,3L,7L,0L,8L,6L,0L,6L,8L,3L,5L,3L,7L,4L,4L,2L,0L,1L,2L,6L,7L,0L,7L,6L,1L,1L,3L,7L,0L,1L,8L,2L,9L,6L,0L,5L,1L,4L,5L,9L,1L,1L,8L,8L,4L,5L,3L,4L,8L,9L,3L,1L,8L,8L,2L,3L,2L,5L,5L,4L,1L,7L,4L,2L,2L,8L,2L,0L,5L,6L,8L,0L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154189Inst : IEnumerable<long>
{
public static readonly long[] Value=A154189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154189.Bytes);
public long this[int i]=>Value[i];

public static A154189Inst Instance=new A154189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154190
{
public static readonly long[] Value={ 8L,1L,4L,3L,8L,1L,0L,3L,8L,2L,0L,9L,5L,9L,6L,5L,9L,6L,1L,0L,5L,8L,2L,4L,4L,0L,0L,8L,3L,2L,8L,7L,7L,6L,7L,6L,5L,6L,7L,8L,1L,8L,0L,6L,8L,3L,3L,5L,3L,7L,8L,7L,7L,4L,2L,0L,5L,6L,6L,9L,5L,5L,1L,5L,0L,9L,5L,2L,7L,4L,3L,8L,1L,6L,9L,6L,1L,1L,5L,3L,4L,5L,0L,3L,7L,8L,1L,5L,2L,7L,9L,9L,5L,0L,1L,9L,9L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154190Inst : IEnumerable<long>
{
public static readonly long[] Value=A154190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154190.Bytes);
public long this[int i]=>Value[i];

public static A154190Inst Instance=new A154190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154191
{
public static readonly long[] Value={ 8L,0L,0L,4L,3L,7L,1L,0L,6L,4L,6L,8L,6L,7L,1L,2L,7L,3L,1L,0L,4L,4L,3L,3L,5L,7L,3L,6L,7L,1L,6L,7L,0L,7L,5L,3L,5L,2L,1L,7L,8L,3L,8L,0L,5L,2L,8L,1L,6L,8L,6L,0L,4L,2L,9L,4L,4L,3L,7L,6L,6L,4L,1L,8L,4L,7L,4L,1L,7L,2L,3L,2L,3L,7L,8L,3L,9L,1L,4L,7L,9L,7L,0L,1L,8L,8L,7L,2L,1L,4L,3L,4L,9L,2L,8L,3L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154191Inst : IEnumerable<long>
{
public static readonly long[] Value=A154191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154191.Bytes);
public long this[int i]=>Value[i];

public static A154191Inst Instance=new A154191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154192
{
public static readonly long[] Value={ 7L,8L,7L,6L,0L,9L,6L,5L,6L,9L,6L,5L,2L,5L,6L,1L,2L,6L,2L,9L,1L,8L,7L,8L,5L,7L,0L,7L,6L,7L,9L,0L,2L,2L,9L,4L,5L,0L,2L,6L,3L,3L,4L,4L,9L,7L,6L,6L,5L,8L,6L,1L,6L,6L,0L,8L,4L,9L,6L,1L,7L,4L,1L,4L,2L,5L,2L,6L,9L,2L,7L,2L,9L,1L,0L,8L,5L,8L,3L,1L,4L,5L,8L,4L,7L,3L,0L,4L,7L,9L,5L,0L,1L,4L,9L,0L,1L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154192Inst : IEnumerable<long>
{
public static readonly long[] Value=A154192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154192.Bytes);
public long this[int i]=>Value[i];

public static A154192Inst Instance=new A154192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154193
{
public static readonly long[] Value={ 7L,7L,5L,7L,5L,6L,1L,7L,5L,7L,8L,2L,4L,2L,4L,5L,6L,0L,5L,2L,2L,4L,3L,7L,6L,6L,1L,5L,9L,6L,5L,1L,9L,5L,2L,9L,1L,0L,2L,0L,8L,7L,1L,1L,7L,5L,5L,7L,7L,7L,7L,9L,9L,0L,2L,7L,4L,2L,3L,8L,2L,8L,8L,9L,3L,4L,8L,8L,5L,4L,6L,9L,9L,9L,3L,5L,9L,8L,5L,7L,6L,0L,8L,2L,4L,2L,0L,5L,2L,3L,0L,6L,9L,2L,9L,6L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154193Inst : IEnumerable<long>
{
public static readonly long[] Value=A154193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154193.Bytes);
public long this[int i]=>Value[i];

public static A154193Inst Instance=new A154193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154194
{
public static readonly long[] Value={ 7L,6L,4L,7L,5L,8L,3L,1L,4L,8L,5L,0L,7L,8L,8L,3L,9L,2L,3L,0L,9L,7L,7L,1L,8L,7L,7L,8L,0L,8L,6L,2L,7L,7L,7L,9L,3L,5L,9L,0L,5L,4L,2L,0L,0L,4L,0L,6L,1L,3L,7L,8L,7L,1L,3L,7L,8L,5L,7L,1L,6L,5L,2L,8L,5L,9L,9L,8L,3L,8L,2L,7L,7L,1L,3L,6L,7L,8L,4L,2L,6L,4L,3L,5L,8L,6L,4L,4L,9L,3L,7L,7L,3L,5L,4L,7L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154194Inst : IEnumerable<long>
{
public static readonly long[] Value=A154194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154194.Bytes);
public long this[int i]=>Value[i];

public static A154194Inst Instance=new A154194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154195
{
public static readonly long[] Value={ 7L,5L,4L,5L,1L,6L,8L,8L,3L,8L,5L,5L,2L,4L,9L,1L,4L,1L,3L,8L,2L,4L,9L,4L,9L,1L,1L,3L,6L,5L,4L,8L,7L,8L,9L,6L,3L,7L,9L,1L,7L,3L,2L,9L,9L,9L,9L,6L,6L,2L,5L,3L,3L,5L,6L,0L,2L,8L,1L,6L,7L,5L,5L,8L,2L,6L,6L,9L,7L,0L,3L,5L,3L,9L,3L,6L,0L,6L,6L,5L,6L,4L,4L,3L,8L,5L,1L,0L,0L,3L,3L,2L,8L,7L,6L,5L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154195Inst : IEnumerable<long>
{
public static readonly long[] Value=A154195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154195.Bytes);
public long this[int i]=>Value[i];

public static A154195Inst Instance=new A154195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154196
{
public static readonly long[] Value={ 2L,2L,6L,1L,8L,5L,9L,5L,0L,7L,1L,4L,2L,9L,1L,4L,8L,7L,4L,1L,9L,9L,0L,5L,4L,2L,2L,8L,6L,8L,5L,5L,2L,1L,7L,0L,8L,5L,9L,9L,1L,7L,1L,2L,8L,0L,2L,6L,3L,7L,6L,0L,8L,5L,5L,7L,4L,1L,3L,0L,9L,8L,8L,7L,6L,7L,7L,3L,7L,0L,4L,0L,2L,7L,6L,1L,8L,2L,9L,6L,1L,0L,1L,2L,2L,3L,4L,5L,3L,7L,7L,0L,9L,8L,9L,0L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154196Inst : IEnumerable<long>
{
public static readonly long[] Value=A154196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154196.Bytes);
public long this[int i]=>Value[i];

public static A154196Inst Instance=new A154196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154197
{
public static readonly long[] Value={ 1L,7L,9L,2L,4L,8L,1L,2L,5L,0L,3L,6L,0L,5L,7L,8L,0L,9L,0L,7L,2L,6L,8L,6L,9L,4L,7L,1L,9L,7L,3L,9L,0L,8L,2L,5L,4L,3L,7L,9L,9L,0L,7L,2L,0L,3L,8L,4L,6L,2L,4L,0L,5L,3L,0L,2L,2L,7L,8L,7L,6L,3L,2L,7L,2L,7L,0L,5L,4L,9L,1L,1L,3L,8L,9L,7L,1L,7L,9L,2L,8L,1L,2L,6L,1L,1L,4L,0L,2L,3L,7L,4L,5L,9L,0L,4L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154197Inst : IEnumerable<long>
{
public static readonly long[] Value=A154197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154197.Bytes);
public long this[int i]=>Value[i];

public static A154197Inst Instance=new A154197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154198
{
public static readonly long[] Value={ 1L,5L,4L,3L,9L,5L,9L,3L,1L,0L,6L,3L,2L,7L,7L,1L,3L,9L,6L,4L,7L,4L,7L,7L,9L,4L,9L,6L,7L,9L,8L,9L,8L,3L,5L,1L,7L,1L,6L,4L,2L,5L,3L,2L,6L,4L,0L,3L,2L,6L,8L,8L,1L,0L,8L,3L,0L,4L,0L,0L,8L,7L,6L,7L,4L,1L,5L,0L,7L,0L,3L,2L,8L,0L,0L,2L,6L,8L,4L,2L,8L,9L,5L,0L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154198Inst : IEnumerable<long>
{
public static readonly long[] Value=A154198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154198.Bytes);
public long this[int i]=>Value[i];

public static A154198Inst Instance=new A154198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154199
{
public static readonly long[] Value={ 1L,3L,8L,6L,8L,5L,2L,8L,0L,7L,2L,3L,4L,5L,4L,1L,5L,8L,6L,8L,7L,0L,2L,4L,6L,1L,3L,8L,4L,6L,7L,8L,2L,0L,8L,7L,6L,4L,6L,5L,1L,4L,1L,8L,5L,9L,4L,5L,7L,1L,0L,3L,4L,2L,8L,3L,8L,9L,4L,9L,4L,9L,2L,8L,8L,2L,6L,6L,4L,2L,0L,1L,8L,5L,4L,0L,7L,2L,2L,8L,0L,3L,8L,3L,1L,6L,5L,2L,3L,0L,0L,2L,9L,4L,8L,1L,6L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154199Inst : IEnumerable<long>
{
public static readonly long[] Value=A154199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154199.Bytes);
public long this[int i]=>Value[i];

public static A154199Inst Instance=new A154199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154200
{
public static readonly long[] Value={ 1L,2L,7L,6L,9L,8L,9L,4L,0L,8L,2L,6L,9L,6L,2L,3L,9L,6L,6L,8L,3L,2L,9L,0L,4L,3L,2L,3L,1L,7L,7L,4L,8L,9L,5L,9L,4L,7L,3L,8L,7L,4L,2L,2L,3L,6L,7L,3L,2L,4L,1L,9L,9L,9L,5L,1L,2L,4L,5L,6L,2L,1L,7L,7L,8L,8L,9L,4L,8L,7L,4L,7L,4L,9L,1L,8L,9L,2L,8L,1L,8L,8L,3L,3L,8L,0L,2L,9L,6L,7L,5L,6L,8L,3L,9L,0L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154200Inst : IEnumerable<long>
{
public static readonly long[] Value=A154200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154200.Bytes);
public long this[int i]=>Value[i];

public static A154200Inst Instance=new A154200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154201
{
public static readonly long[] Value={ 1L,1L,9L,4L,9L,8L,7L,5L,0L,0L,2L,4L,0L,3L,8L,5L,3L,9L,3L,8L,1L,7L,9L,1L,2L,9L,8L,1L,3L,1L,5L,9L,3L,8L,8L,3L,6L,2L,5L,3L,2L,7L,1L,4L,6L,9L,2L,3L,0L,8L,2L,7L,0L,2L,0L,1L,5L,1L,9L,1L,7L,5L,5L,1L,5L,1L,3L,6L,9L,9L,4L,0L,9L,2L,6L,4L,7L,8L,6L,1L,8L,7L,5L,0L,7L,4L,2L,6L,8L,2L,4L,9L,7L,2L,6L,9L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154201Inst : IEnumerable<long>
{
public static readonly long[] Value=A154201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154201.Bytes);
public long this[int i]=>Value[i];

public static A154201Inst Instance=new A154201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154202
{
public static readonly long[] Value={ 1L,1L,3L,0L,9L,2L,9L,7L,5L,3L,5L,7L,1L,4L,5L,7L,4L,3L,7L,0L,9L,9L,5L,2L,7L,1L,1L,4L,3L,4L,2L,7L,6L,0L,8L,5L,4L,2L,9L,9L,5L,8L,5L,6L,4L,0L,1L,3L,1L,8L,8L,0L,4L,2L,7L,8L,7L,0L,6L,5L,4L,9L,4L,3L,8L,3L,8L,6L,8L,5L,2L,0L,1L,3L,8L,0L,9L,1L,4L,8L,0L,5L,0L,6L,1L,1L,7L,2L,6L,8L,8L,5L,4L,9L,4L,5L,1L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154202Inst : IEnumerable<long>
{
public static readonly long[] Value=A154202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154202.Bytes);
public long this[int i]=>Value[i];

public static A154202Inst Instance=new A154202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154203
{
public static readonly long[] Value={ 1L,0L,7L,9L,1L,8L,1L,2L,4L,6L,0L,4L,7L,6L,2L,4L,8L,2L,7L,7L,2L,2L,5L,0L,5L,6L,9L,2L,7L,0L,4L,1L,0L,1L,3L,6L,2L,7L,3L,6L,5L,0L,8L,6L,2L,7L,1L,1L,4L,9L,1L,2L,9L,4L,7L,4L,5L,0L,7L,2L,0L,5L,6L,2L,5L,5L,9L,4L,4L,5L,5L,3L,1L,3L,3L,2L,5L,1L,0L,1L,4L,2L,0L,1L,6L,8L,2L,2L,8L,5L,9L,8L,8L,3L,9L,8L,8L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154203Inst : IEnumerable<long>
{
public static readonly long[] Value=A154203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154203.Bytes);
public long this[int i]=>Value[i];

public static A154203Inst Instance=new A154203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154204
{
public static readonly long[] Value={ 1L,0L,3L,6L,2L,8L,6L,5L,6L,2L,6L,2L,7L,1L,0L,1L,9L,4L,1L,0L,1L,4L,6L,4L,0L,2L,4L,9L,2L,9L,3L,2L,7L,9L,7L,5L,1L,3L,0L,7L,2L,0L,8L,6L,1L,7L,5L,9L,6L,2L,0L,9L,3L,3L,5L,9L,1L,5L,0L,0L,2L,6L,0L,7L,8L,2L,4L,3L,6L,1L,9L,6L,9L,7L,3L,8L,3L,4L,2L,8L,0L,8L,3L,1L,0L,4L,1L,0L,2L,3L,1L,5L,6L,2L,9L,8L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154204Inst : IEnumerable<long>
{
public static readonly long[] Value=A154204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154204.Bytes);
public long this[int i]=>Value[i];

public static A154204Inst Instance=new A154204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154205
{
public static readonly long[] Value={ 9L,6L,8L,7L,9L,3L,6L,4L,9L,8L,8L,6L,0L,3L,4L,1L,6L,3L,5L,7L,8L,9L,9L,0L,3L,8L,4L,8L,2L,2L,2L,4L,9L,1L,6L,5L,7L,0L,3L,9L,1L,9L,3L,3L,3L,0L,1L,1L,0L,4L,6L,9L,1L,5L,8L,0L,5L,3L,8L,5L,5L,3L,0L,3L,3L,6L,6L,3L,3L,5L,0L,9L,9L,9L,2L,3L,0L,9L,7L,7L,7L,8L,0L,4L,9L,0L,2L,3L,1L,7L,5L,6L,3L,9L,3L,0L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154205Inst : IEnumerable<long>
{
public static readonly long[] Value=A154205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154205.Bytes);
public long this[int i]=>Value[i];

public static A154205Inst Instance=new A154205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154206
{
public static readonly long[] Value={ 9L,4L,1L,5L,8L,8L,7L,3L,3L,9L,4L,0L,1L,8L,6L,3L,1L,0L,4L,9L,4L,3L,5L,4L,4L,2L,9L,4L,7L,2L,7L,1L,3L,1L,7L,0L,1L,8L,8L,1L,2L,2L,1L,8L,3L,1L,3L,8L,2L,5L,5L,5L,3L,6L,5L,3L,0L,4L,9L,1L,3L,6L,9L,8L,7L,9L,4L,9L,1L,8L,4L,5L,1L,7L,2L,1L,4L,4L,9L,7L,6L,4L,7L,3L,2L,7L,0L,3L,0L,7L,0L,3L,8L,0L,1L,2L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154206Inst : IEnumerable<long>
{
public static readonly long[] Value=A154206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154206.Bytes);
public long this[int i]=>Value[i];

public static A154206Inst Instance=new A154206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154207
{
public static readonly long[] Value={ 9L,1L,7L,5L,9L,9L,9L,2L,0L,7L,0L,1L,8L,4L,3L,8L,7L,3L,1L,5L,8L,2L,6L,0L,3L,5L,4L,3L,3L,0L,9L,9L,7L,0L,7L,0L,3L,0L,9L,7L,5L,1L,5L,3L,7L,7L,8L,4L,0L,8L,2L,7L,1L,1L,9L,6L,3L,3L,7L,7L,8L,8L,8L,0L,4L,0L,4L,0L,9L,6L,1L,2L,8L,3L,3L,4L,1L,7L,7L,8L,5L,4L,1L,0L,0L,6L,9L,9L,5L,8L,8L,1L,9L,4L,5L,9L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154207Inst : IEnumerable<long>
{
public static readonly long[] Value=A154207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154207.Bytes);
public long this[int i]=>Value[i];

public static A154207Inst Instance=new A154207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154208
{
public static readonly long[] Value={ 8L,9L,6L,2L,4L,0L,6L,2L,5L,1L,8L,0L,2L,8L,9L,0L,4L,5L,3L,6L,3L,4L,3L,4L,7L,3L,5L,9L,8L,6L,9L,5L,4L,1L,2L,7L,1L,8L,9L,9L,5L,3L,6L,0L,1L,9L,2L,3L,1L,2L,0L,2L,6L,5L,1L,1L,3L,9L,3L,8L,1L,6L,3L,6L,3L,5L,2L,7L,4L,5L,5L,6L,9L,4L,8L,5L,8L,9L,6L,4L,0L,6L,3L,0L,5L,7L,0L,1L,1L,8L,7L,2L,9L,5L,2L,2L,0L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154208Inst : IEnumerable<long>
{
public static readonly long[] Value=A154208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154208.Bytes);
public long this[int i]=>Value[i];

public static A154208Inst Instance=new A154208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154209
{
public static readonly long[] Value={ 8L,7L,7L,0L,6L,3L,0L,1L,9L,2L,7L,4L,9L,4L,2L,1L,3L,6L,2L,1L,5L,7L,2L,2L,3L,4L,3L,1L,9L,8L,3L,7L,4L,2L,6L,1L,6L,1L,9L,1L,9L,5L,5L,6L,0L,6L,6L,0L,6L,0L,3L,6L,3L,7L,9L,1L,9L,4L,5L,9L,0L,0L,0L,3L,4L,5L,2L,0L,3L,9L,3L,5L,1L,0L,7L,4L,5L,8L,4L,2L,8L,9L,5L,2L,9L,4L,3L,8L,6L,4L,8L,0L,7L,4L,8L,2L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154209Inst : IEnumerable<long>
{
public static readonly long[] Value=A154209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154209.Bytes);
public long this[int i]=>Value[i];

public static A154209Inst Instance=new A154209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154210
{
public static readonly long[] Value={ 8L,5L,9L,7L,1L,8L,6L,9L,9L,8L,5L,2L,1L,9L,7L,1L,6L,7L,1L,0L,3L,5L,2L,6L,2L,4L,7L,3L,6L,5L,7L,8L,4L,5L,9L,2L,6L,5L,2L,2L,6L,6L,8L,9L,5L,0L,2L,8L,6L,0L,5L,8L,4L,8L,9L,6L,7L,9L,6L,7L,3L,5L,1L,0L,7L,2L,3L,6L,9L,3L,5L,8L,6L,1L,4L,7L,8L,4L,3L,1L,7L,2L,7L,5L,9L,8L,3L,4L,6L,2L,2L,2L,0L,2L,1L,1L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154210Inst : IEnumerable<long>
{
public static readonly long[] Value=A154210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154210.Bytes);
public long this[int i]=>Value[i];

public static A154210Inst Instance=new A154210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154211
{
public static readonly long[] Value={ 8L,4L,3L,9L,3L,2L,1L,2L,6L,7L,5L,4L,9L,1L,3L,4L,2L,1L,7L,7L,2L,1L,6L,3L,2L,8L,8L,1L,7L,8L,8L,7L,6L,7L,4L,3L,8L,9L,6L,4L,3L,0L,3L,0L,1L,5L,0L,7L,7L,6L,8L,4L,5L,2L,5L,6L,5L,1L,3L,0L,9L,7L,8L,9L,5L,2L,5L,9L,4L,7L,9L,5L,9L,8L,7L,1L,5L,6L,2L,8L,0L,5L,2L,8L,9L,1L,0L,1L,4L,1L,6L,6L,6L,2L,5L,7L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154211Inst : IEnumerable<long>
{
public static readonly long[] Value=A154211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154211.Bytes);
public long this[int i]=>Value[i];

public static A154211Inst Instance=new A154211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154212
{
public static readonly long[] Value={ 8L,2L,9L,4L,8L,2L,2L,1L,7L,6L,6L,1L,6L,0L,2L,9L,7L,7L,4L,4L,0L,2L,0L,2L,5L,4L,4L,8L,5L,4L,6L,1L,3L,6L,4L,5L,3L,7L,7L,6L,9L,9L,4L,4L,5L,6L,7L,9L,4L,6L,3L,7L,9L,1L,9L,6L,8L,2L,2L,3L,1L,6L,5L,5L,0L,1L,9L,9L,5L,8L,0L,4L,9L,9L,1L,8L,8L,5L,8L,7L,8L,8L,0L,6L,7L,3L,7L,1L,0L,5L,8L,7L,3L,9L,1L,4L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154212Inst : IEnumerable<long>
{
public static readonly long[] Value=A154212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154212.Bytes);
public long this[int i]=>Value[i];

public static A154212Inst Instance=new A154212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154213
{
public static readonly long[] Value={ 8L,1L,6L,1L,8L,9L,3L,0L,4L,1L,0L,8L,4L,3L,6L,1L,6L,9L,2L,0L,9L,2L,3L,5L,7L,4L,0L,7L,0L,6L,0L,8L,7L,2L,5L,1L,3L,4L,6L,5L,1L,7L,6L,6L,2L,2L,3L,1L,4L,0L,4L,2L,3L,9L,9L,9L,3L,7L,3L,8L,0L,5L,0L,4L,9L,2L,6L,8L,7L,3L,1L,6L,6L,9L,4L,9L,8L,5L,5L,1L,4L,0L,6L,6L,1L,6L,2L,0L,5L,1L,9L,2L,0L,5L,6L,1L,4L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154213Inst : IEnumerable<long>
{
public static readonly long[] Value=A154213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154213.Bytes);
public long this[int i]=>Value[i];

public static A154213Inst Instance=new A154213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154214
{
public static readonly long[] Value={ 8L,0L,3L,9L,0L,5L,7L,0L,0L,8L,3L,8L,3L,1L,4L,6L,1L,1L,4L,3L,5L,4L,1L,0L,7L,4L,7L,5L,8L,9L,1L,2L,5L,3L,2L,9L,3L,1L,6L,0L,0L,4L,1L,0L,6L,7L,1L,5L,6L,6L,0L,7L,5L,5L,7L,5L,7L,7L,3L,6L,6L,5L,0L,0L,2L,0L,8L,8L,7L,7L,7L,8L,0L,4L,4L,8L,9L,5L,9L,5L,9L,2L,1L,0L,7L,6L,4L,6L,4L,5L,6L,1L,6L,5L,2L,2L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154214Inst : IEnumerable<long>
{
public static readonly long[] Value=A154214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154214.Bytes);
public long this[int i]=>Value[i];

public static A154214Inst Instance=new A154214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154215
{
public static readonly long[] Value={ 7L,9L,2L,5L,0L,8L,7L,6L,5L,3L,3L,7L,2L,1L,8L,4L,6L,9L,7L,0L,6L,2L,1L,5L,5L,1L,6L,8L,3L,4L,8L,3L,8L,4L,6L,1L,5L,4L,9L,9L,7L,8L,0L,5L,9L,8L,6L,8L,2L,5L,1L,6L,5L,0L,0L,5L,0L,2L,4L,4L,1L,3L,8L,9L,6L,4L,2L,3L,4L,4L,5L,4L,3L,7L,6L,6L,2L,1L,7L,6L,7L,3L,9L,6L,1L,1L,3L,2L,7L,1L,0L,4L,0L,6L,4L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154215Inst : IEnumerable<long>
{
public static readonly long[] Value=A154215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154215.Bytes);
public long this[int i]=>Value[i];

public static A154215Inst Instance=new A154215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154216
{
public static readonly long[] Value={ 7L,8L,1L,8L,9L,5L,7L,0L,8L,0L,1L,4L,4L,6L,8L,4L,4L,0L,7L,7L,0L,6L,6L,2L,1L,9L,3L,5L,5L,6L,6L,1L,1L,6L,1L,1L,3L,7L,2L,3L,3L,9L,5L,7L,4L,5L,0L,0L,5L,0L,0L,2L,3L,2L,3L,8L,5L,2L,6L,1L,8L,4L,3L,5L,3L,5L,8L,1L,5L,7L,6L,1L,8L,4L,9L,9L,0L,0L,7L,6L,4L,9L,0L,2L,0L,0L,8L,2L,2L,8L,5L,8L,1L,1L,7L,7L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154216Inst : IEnumerable<long>
{
public static readonly long[] Value=A154216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154216.Bytes);
public long this[int i]=>Value[i];

public static A154216Inst Instance=new A154216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154217
{
public static readonly long[] Value={ 2L,3L,3L,4L,7L,1L,7L,5L,1L,9L,4L,7L,2L,7L,9L,2L,6L,9L,3L,3L,7L,9L,6L,0L,2L,4L,0L,7L,2L,4L,4L,5L,2L,8L,4L,9L,5L,8L,6L,1L,7L,6L,6L,5L,8L,6L,7L,2L,4L,8L,3L,1L,3L,4L,6L,4L,3L,9L,2L,2L,4L,1L,7L,4L,9L,6L,7L,4L,5L,3L,1L,8L,8L,7L,4L,8L,3L,9L,4L,9L,1L,7L,3L,9L,1L,7L,5L,7L,3L,5L,2L,7L,7L,4L,3L,0L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154217Inst : IEnumerable<long>
{
public static readonly long[] Value=A154217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154217.Bytes);
public long this[int i]=>Value[i];

public static A154217Inst Instance=new A154217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154218
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,4L,1L,1L,9L,12L,9L,1L,1L,20L,45L,45L,20L,1L,1L,48L,160L,300L,160L,48L,1L,1L,117L,624L,1820L,1820L,624L,117L,1L,1L,294L,2457L,12012L,18200L,12012L,2457L,294L,1L,1L,748L,9996L,78897L,198016L,198016L,78897L,9996L,748L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154218Inst : IEnumerable<long>
{
public static readonly long[] Value=A154218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154218.Bytes);
public long this[int i]=>Value[i];

public static A154218Inst Instance=new A154218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154219
{
public static readonly BigInteger[] Value={ 1L,2L,4L,10L,32L,132L,718L,5124L,47728L,575316L,8940208L,178299576L,4547802212L,148044149064L,6144073801072L,324818609118696L,21861634817456704L,1872569477046791376L,BigInteger.Parse("204095509252622560120"),BigInteger.Parse("28301889241280320588944") };
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
public class A154219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154219Inst Instance=new A154219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154220
{
public static readonly long[] Value={ 1L,1L,1L,-9L,-1L,9L,9L,-1L,-9L,1L,9L,-9L,-9L,1L,1L,-1L,-1L,3L,3L,-7L,-3L,3L,3L,-1L,-1L,3L,3L,-3L,-7L,9L,1L,-9L,-1L,3L,9L,-9L,-9L,7L,1L,-3L,-3L,3L,7L,-3L,-3L,1L,7L,-9L,-9L,1L,7L,-3L,-7L,9L,1L,-9L,-1L,9L,1L,-9L,-9L,1L,1L,-1L,-9L,7L,1L,-9L,-7L,1L,1L,-1L,-1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154220Inst : IEnumerable<long>
{
public static readonly long[] Value=A154220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154220.Bytes);
public long this[int i]=>Value[i];

public static A154220Inst Instance=new A154220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154221
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,5L,5L,5L,1L,1L,9L,9L,9L,9L,1L,1L,17L,17L,17L,17L,17L,1L,1L,33L,33L,33L,33L,33L,33L,1L,1L,65L,65L,65L,65L,65L,65L,65L,1L,1L,129L,129L,129L,129L,129L,129L,129L,129L,1L,1L,257L,257L,257L,257L,257L,257L,257L,257L,257L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154221Inst : IEnumerable<long>
{
public static readonly long[] Value=A154221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154221.Bytes);
public long this[int i]=>Value[i];

public static A154221Inst Instance=new A154221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154222
{
public static readonly long[] Value={ 1L,2L,4L,8L,17L,38L,87L,200L,457L,1034L,2315L,5132L,11277L,24590L,53263L,114704L,245777L,524306L,1114131L,2359316L,4980757L,10485782L,22020119L,46137368L,96469017L,201326618L,419430427L,872415260L,1811939357L,3758096414L,7784628255L,16106127392L,33285996577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154222Inst : IEnumerable<long>
{
public static readonly long[] Value=A154222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154222.Bytes);
public long this[int i]=>Value[i];

public static A154222Inst Instance=new A154222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154223
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,16L,32L,61L,125L,246L,502L,999L,2023L,4040L,8136L,16265L,32649L,65290L,130826L,261643L,523787L,1047564L,2096140L,4192269L,8386573L,16773134L,33550350L,67100687L,134209551L,268419088L,536854544L,1073709073L,2147450897L,4294901778L,8589869074L,17179738131L,34359607315L,68719214612L,137438691348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154223Inst : IEnumerable<long>
{
public static readonly long[] Value=A154223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154223.Bytes);
public long this[int i]=>Value[i];

public static A154223Inst Instance=new A154223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154224
{
public static readonly long[] Value={ 1L,8L,5L,0L,2L,1L,9L,8L,5L,9L,0L,7L,0L,5L,4L,6L,0L,8L,0L,1L,9L,8L,4L,0L,6L,3L,2L,7L,1L,2L,8L,3L,4L,7L,3L,6L,6L,8L,1L,4L,2L,1L,8L,2L,0L,0L,8L,9L,5L,5L,1L,8L,6L,8L,4L,7L,6L,9L,2L,3L,1L,7L,6L,2L,9L,2L,1L,4L,2L,7L,5L,9L,3L,3L,1L,6L,5L,1L,2L,6L,5L,0L,0L,7L,3L,6L,8L,8L,2L,6L,5L,1L,4L,0L,5L,7L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154224Inst : IEnumerable<long>
{
public static readonly long[] Value=A154224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154224.Bytes);
public long this[int i]=>Value[i];

public static A154224Inst Instance=new A154224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154225
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,5L,4L,14L,36L,30L,576L,55L,14400L,91L,518400L,140L,25401600L,204L,1625702400L,285L,131681894400L,385L,13168189440000L,506L,1593350922240000L,650L,229442532802560000L,819L,BigInteger.Parse("38775788043632640000"),1015L };
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
public class A154225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154225Inst Instance=new A154225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154226
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,9L,8L,36L,216L,100L,13824L,225L,1728000L,441L,373248000L,784L,128024064000L,1296L,65548320768000L,2025L,47784725839872000L,3025L,BigInteger.Parse("47784725839872000000"),4356L,BigInteger.Parse("63601470092869632000000"),6084L };
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
public class A154226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154226Inst Instance=new A154226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154227
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,19L,19L,1L,1L,35L,158L,35L,1L,1L,57L,592L,592L,57L,1L,1L,86L,1629L,5608L,1629L,86L,1L,1L,123L,3767L,28549L,28549L,3767L,123L,1L,1L,169L,7760L,105621L,309458L,105621L,7760L,169L,1L,1L,225L,14694L,320566L,1985274L,1985274L,320566L,14694L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154227Inst : IEnumerable<long>
{
public static readonly long[] Value=A154227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154227.Bytes);
public long this[int i]=>Value[i];

public static A154227Inst Instance=new A154227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154228
{
public static readonly long[] Value={ 1L,1L,1L,1L,16L,1L,1L,47L,47L,1L,1L,103L,974L,103L,1L,1L,195L,5354L,5354L,195L,1L,1L,336L,19969L,147068L,19969L,336L,1L,1L,541L,60085L,1259253L,1259253L,60085L,541L,1L,1L,827L,156386L,7010503L,44432886L,7010503L,156386L,827L,1L,1L,1213L,365498L,30299614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154228Inst : IEnumerable<long>
{
public static readonly long[] Value=A154228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154228.Bytes);
public long this[int i]=>Value[i];

public static A154228Inst Instance=new A154228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154229
{
public static readonly long[] Value={ 1L,1L,1L,1L,38L,1L,1L,139L,139L,1L,1L,365L,8828L,365L,1L,1L,807L,70492L,70492L,807L,1L,1L,1592L,357459L,7062136L,357459L,1592L,1L,1L,2889L,1404923L,98777227L,98777227L,1404923L,2889L,1L,1L,4915L,4631612L,824036625L,14498379854L,824036625L,4631612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154229Inst : IEnumerable<long>
{
public static readonly long[] Value=A154229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154229.Bytes);
public long this[int i]=>Value[i];

public static A154229Inst Instance=new A154229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154230
{
public static readonly long[] Value={ 1L,1L,1L,1L,100L,1L,1L,455L,455L,1L,1L,1435L,98810L,1435L,1L,1L,3711L,1135370L,1135370L,3711L,1L,1L,8388L,7849141L,464306300L,7849141L,8388L,1L,1L,17161L,40410421L,10431621081L,10431621081L,40410421L,17161L,1L,1L,32495L,169040786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154230Inst : IEnumerable<long>
{
public static readonly long[] Value=A154230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154230.Bytes);
public long this[int i]=>Value[i];

public static A154230Inst Instance=new A154230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154231
{
public static readonly long[] Value={ 1L,1L,1L,1L,278L,1L,1L,1579L,1579L,1L,1L,6005L,1233308L,6005L,1L,1L,18207L,20504692L,20504692L,18207L,1L,1L,47216L,194715939L,35816807848L,194715939L,47216L,1L,1L,108993L,1319518787L,1302709376779L,1302709376779L,1319518787L,108993L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154231Inst : IEnumerable<long>
{
public static readonly long[] Value=A154231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154231.Bytes);
public long this[int i]=>Value[i];

public static A154231Inst Instance=new A154231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154232
{
public static readonly BigInteger[] Value={ 0L,1L,-1L,-1L,0L,-1L,5L,-5L,16L,-55L,35L,-1045L,64L,-30305L,105L,-1242505L,160L,-68337775L,231L,-4851982025L,320L,-431826400225L,429L,-47069077624525L,560L,-6166049168812775L,715L,-955737621165980125L,896L,BigInteger.Parse("-172988509431042402625") };
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
public class A154232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154232Inst Instance=new A154232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154233
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,19L,19L,1L,1L,39L,171L,39L,1L,1L,69L,761L,761L,69L,1L,1L,111L,2429L,8533L,2429L,111L,1L,1L,167L,6335L,52817L,52817L,6335L,167L,1L,1L,239L,14383L,231611L,711477L,231611L,14383L,239L,1L,1L,329L,29485L,809809L,5643801L,5643801L,809809L,29485L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154233Inst : IEnumerable<long>
{
public static readonly long[] Value=A154233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154233.Bytes);
public long this[int i]=>Value[i];

public static A154233Inst Instance=new A154233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154234
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,2L,1L,0L,0L,0L,0L,0L,2L,0L,1L,1L,1L,1L,3L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,2L,0L,2L,1L,2L,0L,1L,1L,2L,1L,3L,1L,3L,2L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154234Inst : IEnumerable<long>
{
public static readonly long[] Value=A154234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154234.Bytes);
public long this[int i]=>Value[i];

public static A154234Inst Instance=new A154234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154235
{
public static readonly long[] Value={ 1L,8L,54L,352L,2276L,14688L,94744L,611072L,3941136L,25418368L,163935584L,1057300992L,6819052096L,43979406848L,283644733824L,1829363802112L,11798463078656L,76094066608128L,490767902078464L,3165202550546432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154235Inst : IEnumerable<long>
{
public static readonly long[] Value=A154235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154235.Bytes);
public long this[int i]=>Value[i];

public static A154235Inst Instance=new A154235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154236
{
public static readonly long[] Value={ 1L,10L,81L,620L,4661L,34830L,259741L,1935640L,14421321L,107436050L,800355401L,5962269060L,44415937981L,330876267670L,2464859855061L,18361949464880L,136787157402641L,1018994534193690L,7590989351286721L,56548997363187100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154236Inst : IEnumerable<long>
{
public static readonly long[] Value=A154236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154236.Bytes);
public long this[int i]=>Value[i];

public static A154236Inst Instance=new A154236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154237
{
public static readonly long[] Value={ 1L,12L,114L,1008L,8676L,73872L,626184L,5298048L,44791056L,378551232L,3198883104L,27030060288L,228394230336L,1929828955392L,16306120554624L,137778577993728L,1164159319286016L,9836554491620352L,83113874320863744L,702269857101754368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154237Inst : IEnumerable<long>
{
public static readonly long[] Value=A154237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154237.Bytes);
public long this[int i]=>Value[i];

public static A154237Inst Instance=new A154237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154238
{
public static readonly BigInteger[] Value={ 1L,1L,10L,3411L,179228736L,2483590604688125L,BigInteger.Parse("14325593551925794051596768"),BigInteger.Parse("50976900379139614139041610902600299311"),BigInteger.Parse("155682086692129060007763454017522652304844346252853248") };
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
public class A154238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154238Inst Instance=new A154238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154239
{
public static readonly long[] Value={ 1L,14L,153L,1540L,14981L,143514L,1365013L,12939080L,122451561L,1157941414L,10945762673L,103449196620L,977620957741L,9238377953714L,87299590169133L,824944010358160L,7795333767741521L,73662080302980414L,696069772228840393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154239Inst : IEnumerable<long>
{
public static readonly long[] Value=A154239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154239.Bytes);
public long this[int i]=>Value[i];

public static A154239Inst Instance=new A154239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154240
{
public static readonly long[] Value={ 1L,16L,198L,2240L,24356L,259776L,2743768L,28833280L,302193936L,3162772736L,33077115488L,345793029120L,3614215767616L,37771456592896L,394718790964608L,4124756173045760L,43102408892784896L,450402684247904256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154240Inst : IEnumerable<long>
{
public static readonly long[] Value=A154240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154240.Bytes);
public long this[int i]=>Value[i];

public static A154240Inst Instance=new A154240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154241
{
public static readonly long[] Value={ 1L,18L,249L,3132L,37701L,443718L,5159349L,59589432L,685658601L,7872647418L,90283258449L,1034650095732L,11852457339501L,135745474931118L,1554484248297549L,17799805849522032L,203810186669080401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154241Inst : IEnumerable<long>
{
public static readonly long[] Value=A154241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154241.Bytes);
public long this[int i]=>Value[i];

public static A154241Inst Instance=new A154241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154242
{
public static readonly BigInteger[] Value={ 1L,3L,45L,1890L,56700L,748440L,10216206000L,8756748000L,2841962760000L,24946749107280000L,8232427205402400000L,BigInteger.Parse("103279541304139200000"),BigInteger.Parse("3101484625363300176000000"),BigInteger.Parse("1431454442475369312000000") };
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
public class A154242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154242Inst Instance=new A154242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154243
{
public static readonly BigInteger[] Value={ 2L,-1L,1L,-1L,-1L,1L,23L,-23L,157L,97051L,-1614583L,-331691L,1418383997L,-5720927L,-1868325937L,1207461869239L,118209298450003L,-3069893653L,-14303719087308533L,65108016166881997L,BigInteger.Parse("-310766859240153209819") };
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
public class A154243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154243.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154243Inst Instance=new A154243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154244
{
public static readonly long[] Value={ 1L,6L,34L,192L,1084L,6120L,34552L,195072L,1101328L,6217824L,35104288L,198190080L,1118931904L,6317211264L,35665403776L,201358000128L,1136817193216L,6418187159040L,36235488567808L,204576557088768L,1154988365396992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154244Inst : IEnumerable<long>
{
public static readonly long[] Value=A154244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154244.Bytes);
public long this[int i]=>Value[i];

public static A154244Inst Instance=new A154244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154245
{
public static readonly long[] Value={ 1L,8L,55L,368L,2449L,16280L,108199L,719072L,4778785L,31758632L,211059991L,1402652240L,9321678001L,61949553848L,411701328775L,2736064645568L,18183205205569L,120841059834440L,803079631825399L,5337067516093232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154245Inst : IEnumerable<long>
{
public static readonly long[] Value=A154245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154245.Bytes);
public long this[int i]=>Value[i];

public static A154245Inst Instance=new A154245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154246
{
public static readonly long[] Value={ 1L,10L,82L,640L,4924L,37720L,288568L,2206720L,16872976L,129008800L,986374432L,7541585920L,57661119424L,440862647680L,3370726327168L,25771735613440L,197044282245376L,1506551581411840L,11518718733701632L,88069258871603200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154246Inst : IEnumerable<long>
{
public static readonly long[] Value=A154246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154246.Bytes);
public long this[int i]=>Value[i];

public static A154246Inst Instance=new A154246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154247
{
public static readonly long[] Value={ 1L,12L,115L,1032L,9049L,78660L,681499L,5896848L,50998705L,440975868L,3812747971L,32964675480L,285006414601L,2464101386292L,21304030612075L,184189427142432L,1592456237959009L,13767981468377580L,119034546719719699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154247Inst : IEnumerable<long>
{
public static readonly long[] Value=A154247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154247.Bytes);
public long this[int i]=>Value[i];

public static A154247Inst Instance=new A154247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154248
{
public static readonly long[] Value={ 1L,14L,154L,1568L,15484L,150920L,1462552L,14137088L,136492048L,1317130976L,12707167648L,122580846080L,1182430803904L,11405635719296L,110016806306176L,1061198588076032L,10236074368205056L,98734700455677440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154248Inst : IEnumerable<long>
{
public static readonly long[] Value=A154248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154248.Bytes);
public long this[int i]=>Value[i];

public static A154248Inst Instance=new A154248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154249
{
public static readonly long[] Value={ 1L,16L,199L,2272L,25009L,270640L,2904727L,31049152L,331216993L,3529670224L,37595354983L,400334476960L,4262416397329L,45379597170544L,483115820080951L,5143216082574208L,54753855576573121L,582898372518440080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154249Inst : IEnumerable<long>
{
public static readonly long[] Value=A154249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154249.Bytes);
public long this[int i]=>Value[i];

public static A154249Inst Instance=new A154249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154250
{
public static readonly long[] Value={ 1L,18L,250L,3168L,38524L,459000L,5411224L,63436032L,741418000L,8651257632L,100857705376L,1175245632000L,13690951178176L,159468944439168L,1857310612720000L,21630889140461568L,251915019187028224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154250Inst : IEnumerable<long>
{
public static readonly long[] Value=A154250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154250.Bytes);
public long this[int i]=>Value[i];

public static A154250Inst Instance=new A154250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154251
{
public static readonly long[] Value={ 1L,2L,11L,29L,65L,137L,281L,569L,1145L,2297L,4601L,9209L,18425L,36857L,73721L,147449L,294905L,589817L,1179641L,2359289L,4718585L,9437177L,18874361L,37748729L,75497465L,150994937L,301989881L,603979769L,1207959545L,2415919097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154251Inst : IEnumerable<long>
{
public static readonly long[] Value=A154251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154251.Bytes);
public long this[int i]=>Value[i];

public static A154251Inst Instance=new A154251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154252
{
public static readonly long[] Value={ 1L,2L,12L,32L,72L,152L,312L,632L,1272L,2552L,5112L,10232L,20472L,40952L,81912L,163832L,327672L,655352L,1310712L,2621432L,5242872L,10485752L,20971512L,41943032L,83886072L,167772152L,335544312L,671088632L,1342177272L,2684354552L,5368709112L,10737418232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154252Inst : IEnumerable<long>
{
public static readonly long[] Value=A154252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154252.Bytes);
public long this[int i]=>Value[i];

public static A154252Inst Instance=new A154252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154253
{
public static readonly long[] Value={ 2L,3L,59L,659L,1907L,2467L,3803L,9539L,19507L,23003L,24859L,30859L,37507L,42299L,52747L,58403L,61339L,67427L,98387L,122267L,126499L,139627L,162947L,182899L,209459L,214987L,232003L,243707L,280547L,347707L,362003L,383987L,429899L,478403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154253Inst : IEnumerable<long>
{
public static readonly long[] Value=A154253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154253.Bytes);
public long this[int i]=>Value[i];

public static A154253Inst Instance=new A154253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154254
{
public static readonly long[] Value={ 2L,3L,22L,59L,114L,187L,278L,387L,514L,659L,822L,1003L,1202L,1419L,1654L,1907L,2178L,2467L,2774L,3099L,3442L,3803L,4182L,4579L,4994L,5427L,5878L,6347L,6834L,7339L,7862L,8403L,8962L,9539L,10134L,10747L,11378L,12027L,12694L,13379L,14082L,14803L,15542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154254Inst : IEnumerable<long>
{
public static readonly long[] Value=A154254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154254.Bytes);
public long this[int i]=>Value[i];

public static A154254Inst Instance=new A154254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154255
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,13L,17L,22L,28L,34L,41L,49L,57L,66L,76L,87L,98L,110L,123L,137L,152L,167L,182L,199L,217L,235L,254L,274L,294L,315L,337L,360L,384L,409L,434L,460L,487L,514L,543L,572L,601L,632L,664L,697L,730L,764L,799L,835L,871L,909L,947L,985L,1025L,1066L,1108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154255Inst : IEnumerable<long>
{
public static readonly long[] Value=A154255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154255.Bytes);
public long this[int i]=>Value[i];

public static A154255Inst Instance=new A154255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154256
{
public static readonly BigInteger[] Value={ 1L,2L,10L,102L,1578L,32920L,864813L,27405798L,1017153322L,43271534196L,2075757894648L,110845691264880L,6521081183455941L,419050045344986432L,BigInteger.Parse("29204306270878653424"),BigInteger.Parse("2193909534863339799870"),BigInteger.Parse("176728502294889963614250") };
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
public class A154256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A154256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A154256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A154256Inst Instance=new A154256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154257
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,4L,6L,6L,7L,6L,7L,8L,6L,10L,8L,10L,10L,10L,12L,10L,10L,10L,12L,14L,13L,12L,15L,8L,12L,12L,13L,14L,13L,10L,16L,10L,13L,16L,11L,16L,11L,14L,17L,16L,15L,12L,12L,16L,11L,20L,13L,14L,13L,12L,12L,18L,12L,16L,14L,14L,19L,16L,18L,20L,16L,18L,15L,18L,16L,12L,16L,18L,19L,22L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154257Inst : IEnumerable<long>
{
public static readonly long[] Value=A154257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154257.Bytes);
public long this[int i]=>Value[i];

public static A154257Inst Instance=new A154257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154258
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,2L,3L,3L,2L,4L,3L,5L,4L,5L,6L,3L,5L,6L,5L,7L,4L,5L,7L,4L,6L,7L,6L,6L,6L,5L,11L,6L,8L,6L,6L,7L,6L,9L,9L,4L,9L,5L,9L,10L,6L,8L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154258Inst : IEnumerable<long>
{
public static readonly long[] Value=A154258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154258.Bytes);
public long this[int i]=>Value[i];

public static A154258Inst Instance=new A154258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154259
{
public static readonly long[] Value={ 1L,2L,7L,30L,155L,950L,6706L,52996L,459256L,4303020L,43163392L,460170882L,5184956805L,61468942912L,763967696243L,9924157671028L,134400823231643L,1893397004671954L,27693154054839058L,419804185629085664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154259Inst : IEnumerable<long>
{
public static readonly long[] Value=A154259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154259.Bytes);
public long this[int i]=>Value[i];

public static A154259Inst Instance=new A154259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154260
{
public static readonly long[] Value={ 0L,7L,9L,30L,34L,69L,75L,124L,132L,195L,205L,282L,294L,385L,399L,504L,520L,639L,657L,790L,810L,957L,979L,1140L,1164L,1339L,1365L,1554L,1582L,1785L,1815L,2032L,2064L,2295L,2329L,2574L,2610L,2869L,2907L,3180L,3220L,3507L,3549L,3850L,3894L,4209L,4255L,4584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154260Inst : IEnumerable<long>
{
public static readonly long[] Value=A154260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154260.Bytes);
public long this[int i]=>Value[i];

public static A154260Inst Instance=new A154260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154261
{
public static readonly long[] Value={ 3L,2L,19L,107L,499L,1627L,4139L,5827L,6779L,10067L,12619L,16987L,18587L,22003L,23819L,40939L,43403L,59699L,65707L,68819L,89003L,111779L,124139L,132739L,137147L,175003L,190387L,195659L,206419L,223099L,258403L,296299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154261Inst : IEnumerable<long>
{
public static readonly long[] Value=A154261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154261.Bytes);
public long this[int i]=>Value[i];

public static A154261Inst Instance=new A154261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154262
{
public static readonly long[] Value={ 3L,2L,19L,54L,107L,178L,267L,374L,499L,642L,803L,982L,1179L,1394L,1627L,1878L,2147L,2434L,2739L,3062L,3403L,3762L,4139L,4534L,4947L,5378L,5827L,6294L,6779L,7282L,7803L,8342L,8899L,9474L,10067L,10678L,11307L,11954L,12619L,13302L,14003L,14722L,15459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154262Inst : IEnumerable<long>
{
public static readonly long[] Value=A154262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154262.Bytes);
public long this[int i]=>Value[i];

public static A154262Inst Instance=new A154262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A154263
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,1L,3L,1L,2L,2L,2L,4L,2L,5L,3L,2L,3L,4L,3L,4L,2L,3L,4L,5L,3L,4L,2L,2L,3L,7L,6L,5L,6L,3L,4L,5L,4L,9L,4L,6L,6L,3L,7L,7L,5L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A154263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A154263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A154263Inst : IEnumerable<long>
{
public static readonly long[] Value=A154263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A154263.Bytes);
public long this[int i]=>Value[i];

public static A154263Inst Instance=new A154263Inst();

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