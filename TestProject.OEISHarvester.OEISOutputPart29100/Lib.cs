using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021341
{
public static readonly long[] Value={ 0L,0L,2L,9L,6L,7L,3L,5L,9L,0L,5L,0L,4L,4L,5L,1L,0L,3L,8L,5L,7L,5L,6L,6L,7L,6L,5L,5L,7L,8L,6L,3L,5L,0L,1L,4L,8L,3L,6L,7L,9L,5L,2L,5L,2L,2L,2L,5L,5L,1L,9L,2L,8L,7L,8L,3L,3L,8L,2L,7L,8L,9L,3L,1L,7L,5L,0L,7L,4L,1L,8L,3L,9L,7L,6L,2L,6L,1L,1L,2L,7L,5L,9L,6L,4L,3L,9L,1L,6L,9L,1L,3L,9L,4L,6L,5L,8L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021341Inst : IEnumerable<long>
{
public static readonly long[] Value=A021341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021341.Bytes);
public long this[int i]=>Value[i];

public static A021341Inst Instance=new A021341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021340
{
public static readonly long[] Value={ 0L,0L,2L,9L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L,4L,7L,6L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021340Inst : IEnumerable<long>
{
public static readonly long[] Value=A021340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021340.Bytes);
public long this[int i]=>Value[i];

public static A021340Inst Instance=new A021340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021339
{
public static readonly long[] Value={ 0L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021339Inst : IEnumerable<long>
{
public static readonly long[] Value=A021339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021339.Bytes);
public long this[int i]=>Value[i];

public static A021339Inst Instance=new A021339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021338
{
public static readonly long[] Value={ 0L,0L,2L,9L,9L,4L,0L,1L,1L,9L,7L,6L,0L,4L,7L,9L,0L,4L,1L,9L,1L,6L,1L,6L,7L,6L,6L,4L,6L,7L,0L,6L,5L,8L,6L,8L,2L,6L,3L,4L,7L,3L,0L,5L,3L,8L,9L,2L,2L,1L,5L,5L,6L,8L,8L,6L,2L,2L,7L,5L,4L,4L,9L,1L,0L,1L,7L,9L,6L,4L,0L,7L,1L,8L,5L,6L,2L,8L,7L,4L,2L,5L,1L,4L,9L,7L,0L,0L,5L,9L,8L,8L,0L,2L,3L,9L,5L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021338Inst : IEnumerable<long>
{
public static readonly long[] Value=A021338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021338.Bytes);
public long this[int i]=>Value[i];

public static A021338Inst Instance=new A021338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021337
{
public static readonly long[] Value={ 0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021337Inst : IEnumerable<long>
{
public static readonly long[] Value=A021337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021337.Bytes);
public long this[int i]=>Value[i];

public static A021337Inst Instance=new A021337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021336
{
public static readonly long[] Value={ 0L,0L,3L,0L,1L,2L,0L,4L,8L,1L,9L,2L,7L,7L,1L,0L,8L,4L,3L,3L,7L,3L,4L,9L,3L,9L,7L,5L,9L,0L,3L,6L,1L,4L,4L,5L,7L,8L,3L,1L,3L,2L,5L,3L,0L,1L,2L,0L,4L,8L,1L,9L,2L,7L,7L,1L,0L,8L,4L,3L,3L,7L,3L,4L,9L,3L,9L,7L,5L,9L,0L,3L,6L,1L,4L,4L,5L,7L,8L,3L,1L,3L,2L,5L,3L,0L,1L,2L,0L,4L,8L,1L,9L,2L,7L,7L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021336Inst : IEnumerable<long>
{
public static readonly long[] Value=A021336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021336.Bytes);
public long this[int i]=>Value[i];

public static A021336Inst Instance=new A021336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021335
{
public static readonly long[] Value={ 0L,0L,3L,0L,2L,1L,1L,4L,8L,0L,3L,6L,2L,5L,3L,7L,7L,6L,4L,3L,5L,0L,4L,5L,3L,1L,7L,2L,2L,0L,5L,4L,3L,8L,0L,6L,6L,4L,6L,5L,2L,5L,6L,7L,9L,7L,5L,8L,3L,0L,8L,1L,5L,7L,0L,9L,9L,6L,9L,7L,8L,8L,5L,1L,9L,6L,3L,7L,4L,6L,2L,2L,3L,5L,6L,4L,9L,5L,4L,6L,8L,2L,7L,7L,9L,4L,5L,6L,1L,9L,3L,3L,5L,3L,4L,7L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021335Inst : IEnumerable<long>
{
public static readonly long[] Value=A021335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021335.Bytes);
public long this[int i]=>Value[i];

public static A021335Inst Instance=new A021335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021334
{
public static readonly long[] Value={ 1L,26L,473L,7462L,109221L,1527162L,20707681L,274691534L,3584491901L,46184032258L,589079813049L,7452543446166L,93649963947541L,1170213435915914L,14553113785023377L,180253443514702558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021334Inst : IEnumerable<long>
{
public static readonly long[] Value=A021334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021334.Bytes);
public long this[int i]=>Value[i];

public static A021334Inst Instance=new A021334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021333
{
public static readonly long[] Value={ 0L,0L,3L,0L,3L,9L,5L,1L,3L,6L,7L,7L,8L,1L,1L,5L,5L,0L,1L,5L,1L,9L,7L,5L,6L,8L,3L,8L,9L,0L,5L,7L,7L,5L,0L,7L,5L,9L,8L,7L,8L,4L,1L,9L,4L,5L,2L,8L,8L,7L,5L,3L,7L,9L,9L,3L,9L,2L,0L,9L,7L,2L,6L,4L,4L,3L,7L,6L,8L,9L,9L,6L,9L,6L,0L,4L,8L,6L,3L,2L,2L,1L,8L,8L,4L,4L,9L,8L,4L,8L,0L,2L,4L,3L,1L,6L,1L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021333Inst : IEnumerable<long>
{
public static readonly long[] Value=A021333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021333.Bytes);
public long this[int i]=>Value[i];

public static A021333Inst Instance=new A021333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021332
{
public static readonly long[] Value={ 0L,0L,3L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L,4L,8L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021332Inst : IEnumerable<long>
{
public static readonly long[] Value=A021332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021332.Bytes);
public long this[int i]=>Value[i];

public static A021332Inst Instance=new A021332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021331
{
public static readonly long[] Value={ 0L,0L,3L,0L,5L,8L,1L,0L,3L,9L,7L,5L,5L,3L,5L,1L,6L,8L,1L,9L,5L,7L,1L,8L,6L,5L,4L,4L,3L,4L,2L,5L,0L,7L,6L,4L,5L,2L,5L,9L,9L,3L,8L,8L,3L,7L,9L,2L,0L,4L,8L,9L,2L,9L,6L,6L,3L,6L,0L,8L,5L,6L,2L,6L,9L,1L,1L,3L,1L,4L,9L,8L,4L,7L,0L,9L,4L,8L,0L,1L,2L,2L,3L,2L,4L,1L,5L,9L,0L,2L,1L,4L,0L,6L,7L,2L,7L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021331Inst : IEnumerable<long>
{
public static readonly long[] Value=A021331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021331.Bytes);
public long this[int i]=>Value[i];

public static A021331Inst Instance=new A021331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021330
{
public static readonly long[] Value={ 0L,0L,3L,0L,6L,7L,4L,8L,4L,6L,6L,2L,5L,7L,6L,6L,8L,7L,1L,1L,6L,5L,6L,4L,4L,1L,7L,1L,7L,7L,9L,1L,4L,1L,1L,0L,4L,2L,9L,4L,4L,7L,8L,5L,2L,7L,6L,0L,7L,3L,6L,1L,9L,6L,3L,1L,9L,0L,1L,8L,4L,0L,4L,9L,0L,7L,9L,7L,5L,4L,6L,0L,1L,2L,2L,6L,9L,9L,3L,8L,6L,5L,0L,3L,0L,6L,7L,4L,8L,4L,6L,6L,2L,5L,7L,6L,6L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021330Inst : IEnumerable<long>
{
public static readonly long[] Value=A021330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021330.Bytes);
public long this[int i]=>Value[i];

public static A021330Inst Instance=new A021330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021329
{
public static readonly long[] Value={ 0L,0L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L,0L,7L,6L,9L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021329Inst : IEnumerable<long>
{
public static readonly long[] Value=A021329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021329.Bytes);
public long this[int i]=>Value[i];

public static A021329Inst Instance=new A021329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021328
{
public static readonly long[] Value={ 0L,0L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L,7L,5L,3L,0L,8L,6L,4L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021328Inst : IEnumerable<long>
{
public static readonly long[] Value=A021328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021328.Bytes);
public long this[int i]=>Value[i];

public static A021328Inst Instance=new A021328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021327
{
public static readonly long[] Value={ 0L,0L,3L,0L,9L,5L,9L,7L,5L,2L,3L,2L,1L,9L,8L,1L,4L,2L,4L,1L,4L,8L,6L,0L,6L,8L,1L,1L,1L,4L,5L,5L,1L,0L,8L,3L,5L,9L,1L,3L,3L,1L,2L,6L,9L,3L,4L,9L,8L,4L,5L,2L,0L,1L,2L,3L,8L,3L,9L,0L,0L,9L,2L,8L,7L,9L,2L,5L,6L,9L,6L,5L,9L,4L,4L,2L,7L,2L,4L,4L,5L,8L,2L,0L,4L,3L,3L,4L,3L,6L,5L,3L,2L,5L,0L,7L,7L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021327Inst : IEnumerable<long>
{
public static readonly long[] Value=A021327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021327.Bytes);
public long this[int i]=>Value[i];

public static A021327Inst Instance=new A021327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021326
{
public static readonly long[] Value={ 0L,0L,3L,1L,0L,5L,5L,9L,0L,0L,6L,2L,1L,1L,1L,8L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L,4L,9L,6L,8L,9L,4L,4L,0L,9L,9L,3L,7L,8L,8L,8L,1L,9L,8L,7L,5L,7L,7L,6L,3L,9L,7L,5L,1L,5L,5L,2L,7L,9L,5L,0L,3L,1L,0L,5L,5L,9L,0L,0L,6L,2L,1L,1L,1L,8L,0L,1L,2L,4L,2L,2L,3L,6L,0L,2L,4L,8L,4L,4L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021326Inst : IEnumerable<long>
{
public static readonly long[] Value=A021326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021326.Bytes);
public long this[int i]=>Value[i];

public static A021326Inst Instance=new A021326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021325
{
public static readonly long[] Value={ 0L,0L,3L,1L,1L,5L,2L,6L,4L,7L,9L,7L,5L,0L,7L,7L,8L,8L,1L,6L,1L,9L,9L,3L,7L,6L,9L,4L,7L,0L,4L,0L,4L,9L,8L,4L,4L,2L,3L,6L,7L,6L,0L,1L,2L,4L,6L,1L,0L,5L,9L,1L,9L,0L,0L,3L,1L,1L,5L,2L,6L,4L,7L,9L,7L,5L,0L,7L,7L,8L,8L,1L,6L,1L,9L,9L,3L,7L,6L,9L,4L,7L,0L,4L,0L,4L,9L,8L,4L,4L,2L,3L,6L,7L,6L,0L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021325Inst : IEnumerable<long>
{
public static readonly long[] Value=A021325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021325.Bytes);
public long this[int i]=>Value[i];

public static A021325Inst Instance=new A021325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021324
{
public static readonly long[] Value={ 1L,25L,437L,6629L,93429L,1260021L,16509109L,211998133L,2682866357L,33583284917L,416888307381L,5141548576437L,63087471804085L,770938550533813L,9390151495286453L,114070706832309941L,1382737370876575413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021324Inst : IEnumerable<long>
{
public static readonly long[] Value=A021324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021324.Bytes);
public long this[int i]=>Value[i];

public static A021324Inst Instance=new A021324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021323
{
public static readonly long[] Value={ 0L,0L,3L,1L,3L,4L,7L,9L,6L,2L,3L,8L,2L,4L,4L,5L,1L,4L,1L,0L,6L,5L,8L,3L,0L,7L,2L,1L,0L,0L,3L,1L,3L,4L,7L,9L,6L,2L,3L,8L,2L,4L,4L,5L,1L,4L,1L,0L,6L,5L,8L,3L,0L,7L,2L,1L,0L,0L,3L,1L,3L,4L,7L,9L,6L,2L,3L,8L,2L,4L,4L,5L,1L,4L,1L,0L,6L,5L,8L,3L,0L,7L,2L,1L,0L,0L,3L,1L,3L,4L,7L,9L,6L,2L,3L,8L,2L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021323Inst : IEnumerable<long>
{
public static readonly long[] Value=A021323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021323.Bytes);
public long this[int i]=>Value[i];

public static A021323Inst Instance=new A021323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021322
{
public static readonly long[] Value={ 0L,0L,3L,1L,4L,4L,6L,5L,4L,0L,8L,8L,0L,5L,0L,3L,1L,4L,4L,6L,5L,4L,0L,8L,8L,0L,5L,0L,3L,1L,4L,4L,6L,5L,4L,0L,8L,8L,0L,5L,0L,3L,1L,4L,4L,6L,5L,4L,0L,8L,8L,0L,5L,0L,3L,1L,4L,4L,6L,5L,4L,0L,8L,8L,0L,5L,0L,3L,1L,4L,4L,6L,5L,4L,0L,8L,8L,0L,5L,0L,3L,1L,4L,4L,6L,5L,4L,0L,8L,8L,0L,5L,0L,3L,1L,4L,4L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021322Inst : IEnumerable<long>
{
public static readonly long[] Value=A021322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021322.Bytes);
public long this[int i]=>Value[i];

public static A021322Inst Instance=new A021322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021321
{
public static readonly long[] Value={ 0L,0L,3L,1L,5L,4L,5L,7L,4L,1L,3L,2L,4L,9L,2L,1L,1L,3L,5L,6L,4L,6L,6L,8L,7L,6L,9L,7L,1L,6L,0L,8L,8L,3L,2L,8L,0L,7L,5L,7L,0L,9L,7L,7L,9L,1L,7L,9L,8L,1L,0L,7L,2L,5L,5L,5L,2L,0L,5L,0L,4L,7L,3L,1L,8L,6L,1L,1L,9L,8L,7L,3L,8L,1L,7L,0L,3L,4L,7L,0L,0L,3L,1L,5L,4L,5L,7L,4L,1L,3L,2L,4L,9L,2L,1L,1L,3L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021321Inst : IEnumerable<long>
{
public static readonly long[] Value=A021321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021321.Bytes);
public long this[int i]=>Value[i];

public static A021321Inst Instance=new A021321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021320
{
public static readonly long[] Value={ 0L,0L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L,6L,9L,6L,2L,0L,2L,5L,3L,1L,6L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021320Inst : IEnumerable<long>
{
public static readonly long[] Value=A021320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021320.Bytes);
public long this[int i]=>Value[i];

public static A021320Inst Instance=new A021320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021319
{
public static readonly long[] Value={ 0L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L,1L,7L,4L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021319Inst : IEnumerable<long>
{
public static readonly long[] Value=A021319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021319.Bytes);
public long this[int i]=>Value[i];

public static A021319Inst Instance=new A021319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021318
{
public static readonly long[] Value={ 0L,0L,3L,1L,8L,4L,7L,1L,3L,3L,7L,5L,7L,9L,6L,1L,7L,8L,3L,4L,3L,9L,4L,9L,0L,4L,4L,5L,8L,5L,9L,8L,7L,2L,6L,1L,1L,4L,6L,4L,9L,6L,8L,1L,5L,2L,8L,6L,6L,2L,4L,2L,0L,3L,8L,2L,1L,6L,5L,6L,0L,5L,0L,9L,5L,5L,4L,1L,4L,0L,1L,2L,7L,3L,8L,8L,5L,3L,5L,0L,3L,1L,8L,4L,7L,1L,3L,3L,7L,5L,7L,9L,6L,1L,7L,8L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021318Inst : IEnumerable<long>
{
public static readonly long[] Value=A021318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021318.Bytes);
public long this[int i]=>Value[i];

public static A021318Inst Instance=new A021318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021317
{
public static readonly long[] Value={ 0L,0L,3L,1L,9L,4L,8L,8L,8L,1L,7L,8L,9L,1L,3L,7L,3L,8L,0L,1L,9L,1L,6L,9L,3L,2L,9L,0L,7L,3L,4L,8L,2L,4L,2L,8L,1L,1L,5L,0L,1L,5L,9L,7L,4L,4L,4L,0L,8L,9L,4L,5L,6L,8L,6L,9L,0L,0L,9L,5L,8L,4L,6L,6L,4L,5L,3L,6L,7L,4L,1L,2L,1L,4L,0L,5L,7L,5L,0L,7L,9L,8L,7L,2L,2L,0L,4L,4L,7L,2L,8L,4L,3L,4L,5L,0L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021317Inst : IEnumerable<long>
{
public static readonly long[] Value=A021317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021317.Bytes);
public long this[int i]=>Value[i];

public static A021317Inst Instance=new A021317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021316
{
public static readonly long[] Value={ 0L,0L,3L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L,2L,0L,5L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021316Inst : IEnumerable<long>
{
public static readonly long[] Value=A021316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021316.Bytes);
public long this[int i]=>Value[i];

public static A021316Inst Instance=new A021316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021315
{
public static readonly long[] Value={ 0L,0L,3L,2L,1L,5L,4L,3L,4L,0L,8L,3L,6L,0L,1L,2L,8L,6L,1L,7L,3L,6L,3L,3L,4L,4L,0L,5L,1L,4L,4L,6L,9L,4L,5L,3L,3L,7L,6L,2L,0L,5L,7L,8L,7L,7L,8L,1L,3L,5L,0L,4L,8L,2L,3L,1L,5L,1L,1L,2L,5L,4L,0L,1L,9L,2L,9L,2L,6L,0L,4L,5L,0L,1L,6L,0L,7L,7L,1L,7L,0L,4L,1L,8L,0L,0L,6L,4L,3L,0L,8L,6L,8L,1L,6L,7L,2L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021315Inst : IEnumerable<long>
{
public static readonly long[] Value=A021315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021315.Bytes);
public long this[int i]=>Value[i];

public static A021315Inst Instance=new A021315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021314
{
public static readonly long[] Value={ 1L,24L,401L,5796L,77637L,992880L,12310537L,149304732L,1781240813L,20982537576L,244696801713L,2830553706708L,32524979660629L,371663665151712L,4227189205549529L,47887970149917324L,540656560537946685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021314Inst : IEnumerable<long>
{
public static readonly long[] Value=A021314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021314.Bytes);
public long this[int i]=>Value[i];

public static A021314Inst Instance=new A021314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021313
{
public static readonly long[] Value={ 0L,0L,3L,2L,3L,6L,2L,4L,5L,9L,5L,4L,6L,9L,2L,5L,5L,6L,6L,3L,4L,3L,0L,4L,2L,0L,7L,1L,1L,9L,7L,4L,1L,1L,0L,0L,3L,2L,3L,6L,2L,4L,5L,9L,5L,4L,6L,9L,2L,5L,5L,6L,6L,3L,4L,3L,0L,4L,2L,0L,7L,1L,1L,9L,7L,4L,1L,1L,0L,0L,3L,2L,3L,6L,2L,4L,5L,9L,5L,4L,6L,9L,2L,5L,5L,6L,6L,3L,4L,3L,0L,4L,2L,0L,7L,1L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021313Inst : IEnumerable<long>
{
public static readonly long[] Value=A021313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021313.Bytes);
public long this[int i]=>Value[i];

public static A021313Inst Instance=new A021313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021312
{
public static readonly long[] Value={ 0L,0L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L,2L,4L,6L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021312Inst : IEnumerable<long>
{
public static readonly long[] Value=A021312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021312.Bytes);
public long this[int i]=>Value[i];

public static A021312Inst Instance=new A021312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021311
{
public static readonly long[] Value={ 0L,0L,3L,2L,5L,7L,3L,2L,8L,9L,9L,0L,2L,2L,8L,0L,1L,3L,0L,2L,9L,3L,1L,5L,9L,6L,0L,9L,1L,2L,0L,5L,2L,1L,1L,7L,2L,6L,3L,8L,4L,3L,6L,4L,8L,2L,0L,8L,4L,6L,9L,0L,5L,5L,3L,7L,4L,5L,9L,2L,8L,3L,3L,8L,7L,6L,2L,2L,1L,4L,9L,8L,3L,7L,1L,3L,3L,5L,5L,0L,4L,8L,8L,5L,9L,9L,3L,4L,8L,5L,3L,4L,2L,0L,1L,9L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021311Inst : IEnumerable<long>
{
public static readonly long[] Value=A021311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021311.Bytes);
public long this[int i]=>Value[i];

public static A021311Inst Instance=new A021311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021310
{
public static readonly long[] Value={ 0L,0L,3L,2L,6L,7L,9L,7L,3L,8L,5L,6L,2L,0L,9L,1L,5L,0L,3L,2L,6L,7L,9L,7L,3L,8L,5L,6L,2L,0L,9L,1L,5L,0L,3L,2L,6L,7L,9L,7L,3L,8L,5L,6L,2L,0L,9L,1L,5L,0L,3L,2L,6L,7L,9L,7L,3L,8L,5L,6L,2L,0L,9L,1L,5L,0L,3L,2L,6L,7L,9L,7L,3L,8L,5L,6L,2L,0L,9L,1L,5L,0L,3L,2L,6L,7L,9L,7L,3L,8L,5L,6L,2L,0L,9L,1L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021310Inst : IEnumerable<long>
{
public static readonly long[] Value=A021310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021310.Bytes);
public long this[int i]=>Value[i];

public static A021310Inst Instance=new A021310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021309
{
public static readonly long[] Value={ 0L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021309Inst : IEnumerable<long>
{
public static readonly long[] Value=A021309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021309.Bytes);
public long this[int i]=>Value[i];

public static A021309Inst Instance=new A021309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021308
{
public static readonly long[] Value={ 0L,0L,3L,2L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021308Inst : IEnumerable<long>
{
public static readonly long[] Value=A021308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021308.Bytes);
public long this[int i]=>Value[i];

public static A021308Inst Instance=new A021308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021307
{
public static readonly long[] Value={ 0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L,3L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021307Inst : IEnumerable<long>
{
public static readonly long[] Value=A021307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021307.Bytes);
public long this[int i]=>Value[i];

public static A021307Inst Instance=new A021307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021306
{
public static readonly long[] Value={ 0L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L,3L,6L,4L,2L,3L,8L,4L,1L,0L,5L,9L,6L,0L,2L,6L,4L,9L,0L,0L,6L,6L,2L,2L,5L,1L,6L,5L,5L,6L,2L,9L,1L,3L,9L,0L,7L,2L,8L,4L,7L,6L,8L,2L,1L,1L,9L,2L,0L,5L,2L,9L,8L,0L,1L,3L,2L,4L,5L,0L,3L,3L,1L,1L,2L,5L,8L,2L,7L,8L,1L,4L,5L,6L,9L,5L,3L,6L,4L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021306Inst : IEnumerable<long>
{
public static readonly long[] Value=A021306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021306.Bytes);
public long this[int i]=>Value[i];

public static A021306Inst Instance=new A021306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021305
{
public static readonly long[] Value={ 0L,0L,3L,3L,2L,2L,2L,5L,9L,1L,3L,6L,2L,1L,2L,6L,2L,4L,5L,8L,4L,7L,1L,7L,6L,0L,7L,9L,7L,3L,4L,2L,1L,9L,2L,6L,9L,1L,0L,2L,9L,9L,0L,0L,3L,3L,2L,2L,2L,5L,9L,1L,3L,6L,2L,1L,2L,6L,2L,4L,5L,8L,4L,7L,1L,7L,6L,0L,7L,9L,7L,3L,4L,2L,1L,9L,2L,6L,9L,1L,0L,2L,9L,9L,0L,0L,3L,3L,2L,2L,2L,5L,9L,1L,3L,6L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021305Inst : IEnumerable<long>
{
public static readonly long[] Value=A021305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021305.Bytes);
public long this[int i]=>Value[i];

public static A021305Inst Instance=new A021305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021304
{
public static readonly long[] Value={ 1L,24L,403L,5886L,80113L,1046748L,13329631L,166873722L,2064748525L,25337358072L,309091680859L,3754490630358L,45462401712937L,549225447909396L,6623795021132887L,79783347069641394L,960080426180248549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021304Inst : IEnumerable<long>
{
public static readonly long[] Value=A021304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021304.Bytes);
public long this[int i]=>Value[i];

public static A021304Inst Instance=new A021304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021303
{
public static readonly long[] Value={ 0L,0L,3L,3L,4L,4L,4L,8L,1L,6L,0L,5L,3L,5L,1L,1L,7L,0L,5L,6L,8L,5L,6L,1L,8L,7L,2L,9L,0L,9L,6L,9L,8L,9L,9L,6L,6L,5L,5L,5L,1L,8L,3L,9L,4L,6L,4L,8L,8L,2L,9L,4L,3L,1L,4L,3L,8L,1L,2L,7L,0L,9L,0L,3L,0L,1L,0L,0L,3L,3L,4L,4L,4L,8L,1L,6L,0L,5L,3L,5L,1L,1L,7L,0L,5L,6L,8L,5L,6L,1L,8L,7L,2L,9L,0L,9L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021303Inst : IEnumerable<long>
{
public static readonly long[] Value=A021303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021303.Bytes);
public long this[int i]=>Value[i];

public static A021303Inst Instance=new A021303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021302
{
public static readonly long[] Value={ 0L,0L,3L,3L,5L,5L,7L,0L,4L,6L,9L,7L,9L,8L,6L,5L,7L,7L,1L,8L,1L,2L,0L,8L,0L,5L,3L,6L,9L,1L,2L,7L,5L,1L,6L,7L,7L,8L,5L,2L,3L,4L,8L,9L,9L,3L,2L,8L,8L,5L,9L,0L,6L,0L,4L,0L,2L,6L,8L,4L,5L,6L,3L,7L,5L,8L,3L,8L,9L,2L,6L,1L,7L,4L,4L,9L,6L,6L,4L,4L,2L,9L,5L,3L,0L,2L,0L,1L,3L,4L,2L,2L,8L,1L,8L,7L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021302Inst : IEnumerable<long>
{
public static readonly long[] Value=A021302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021302.Bytes);
public long this[int i]=>Value[i];

public static A021302Inst Instance=new A021302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021301
{
public static readonly long[] Value={ 0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L,3L,6L,7L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021301Inst : IEnumerable<long>
{
public static readonly long[] Value=A021301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021301.Bytes);
public long this[int i]=>Value[i];

public static A021301Inst Instance=new A021301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021300
{
public static readonly long[] Value={ 0L,0L,3L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L,3L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021300Inst : IEnumerable<long>
{
public static readonly long[] Value=A021300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021300.Bytes);
public long this[int i]=>Value[i];

public static A021300Inst Instance=new A021300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021299
{
public static readonly long[] Value={ 0L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021299Inst : IEnumerable<long>
{
public static readonly long[] Value=A021299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021299.Bytes);
public long this[int i]=>Value[i];

public static A021299Inst Instance=new A021299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021298
{
public static readonly long[] Value={ 0L,0L,3L,4L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L,6L,8L,7L,0L,7L,4L,8L,2L,9L,9L,3L,1L,9L,7L,2L,7L,8L,9L,1L,1L,5L,6L,4L,6L,2L,5L,8L,5L,0L,3L,4L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L,6L,8L,7L,0L,7L,4L,8L,2L,9L,9L,3L,1L,9L,7L,2L,7L,8L,9L,1L,1L,5L,6L,4L,6L,2L,5L,8L,5L,0L,3L,4L,0L,1L,3L,6L,0L,5L,4L,4L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021298Inst : IEnumerable<long>
{
public static readonly long[] Value=A021298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021298.Bytes);
public long this[int i]=>Value[i];

public static A021298Inst Instance=new A021298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021297
{
public static readonly long[] Value={ 0L,0L,3L,4L,1L,2L,9L,6L,9L,2L,8L,3L,2L,7L,6L,4L,5L,0L,5L,1L,1L,9L,4L,5L,3L,9L,2L,4L,9L,1L,4L,6L,7L,5L,7L,6L,7L,9L,1L,8L,0L,8L,8L,7L,3L,7L,2L,0L,1L,3L,6L,5L,1L,8L,7L,7L,1L,3L,3L,1L,0L,5L,8L,0L,2L,0L,4L,7L,7L,8L,1L,5L,6L,9L,9L,6L,5L,8L,7L,0L,3L,0L,7L,1L,6L,7L,2L,3L,5L,4L,9L,4L,8L,8L,0L,5L,4L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021297Inst : IEnumerable<long>
{
public static readonly long[] Value=A021297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021297.Bytes);
public long this[int i]=>Value[i];

public static A021297Inst Instance=new A021297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021296
{
public static readonly long[] Value={ 0L,0L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L,4L,2L,4L,6L,5L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021296Inst : IEnumerable<long>
{
public static readonly long[] Value=A021296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021296.Bytes);
public long this[int i]=>Value[i];

public static A021296Inst Instance=new A021296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021295
{
public static readonly long[] Value={ 0L,0L,3L,4L,3L,6L,4L,2L,6L,1L,1L,6L,8L,3L,8L,4L,8L,7L,9L,7L,2L,5L,0L,8L,5L,9L,1L,0L,6L,5L,2L,9L,2L,0L,9L,6L,2L,1L,9L,9L,3L,1L,2L,7L,1L,4L,7L,7L,6L,6L,3L,2L,3L,0L,2L,4L,0L,5L,4L,9L,8L,2L,8L,1L,7L,8L,6L,9L,4L,1L,5L,8L,0L,7L,5L,6L,0L,1L,3L,7L,4L,5L,7L,0L,4L,4L,6L,7L,3L,5L,3L,9L,5L,1L,8L,9L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021295Inst : IEnumerable<long>
{
public static readonly long[] Value=A021295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021295.Bytes);
public long this[int i]=>Value[i];

public static A021295Inst Instance=new A021295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021294
{
public static readonly long[] Value={ 1L,23L,368L,5098L,65559L,806541L,9640606L,112964816L,1304876837L,14914020979L,169097614764L,1905464222454L,21368620595635L,238731453906137L,2659135639187642L,29548298847110812L,327711548662770753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021294Inst : IEnumerable<long>
{
public static readonly long[] Value=A021294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021294.Bytes);
public long this[int i]=>Value[i];

public static A021294Inst Instance=new A021294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021293
{
public static readonly long[] Value={ 0L,0L,3L,4L,6L,0L,2L,0L,7L,6L,1L,2L,4L,5L,6L,7L,4L,7L,4L,0L,4L,8L,4L,4L,2L,9L,0L,6L,5L,7L,4L,3L,9L,4L,4L,6L,3L,6L,6L,7L,8L,2L,0L,0L,6L,9L,2L,0L,4L,1L,5L,2L,2L,4L,9L,1L,3L,4L,9L,4L,8L,0L,9L,6L,8L,8L,5L,8L,1L,3L,1L,4L,8L,7L,8L,8L,9L,2L,7L,3L,3L,5L,6L,4L,0L,1L,3L,8L,4L,0L,8L,3L,0L,4L,4L,9L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021293Inst : IEnumerable<long>
{
public static readonly long[] Value=A021293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021293.Bytes);
public long this[int i]=>Value[i];

public static A021293Inst Instance=new A021293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021292
{
public static readonly long[] Value={ 0L,0L,3L,4L,7L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021292Inst : IEnumerable<long>
{
public static readonly long[] Value=A021292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021292.Bytes);
public long this[int i]=>Value[i];

public static A021292Inst Instance=new A021292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021291
{
public static readonly long[] Value={ 0L,0L,3L,4L,8L,4L,3L,2L,0L,5L,5L,7L,4L,9L,1L,2L,8L,9L,1L,9L,8L,6L,0L,6L,2L,7L,1L,7L,7L,7L,0L,0L,3L,4L,8L,4L,3L,2L,0L,5L,5L,7L,4L,9L,1L,2L,8L,9L,1L,9L,8L,6L,0L,6L,2L,7L,1L,7L,7L,7L,0L,0L,3L,4L,8L,4L,3L,2L,0L,5L,5L,7L,4L,9L,1L,2L,8L,9L,1L,9L,8L,6L,0L,6L,2L,7L,1L,7L,7L,7L,0L,0L,3L,4L,8L,4L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021291Inst : IEnumerable<long>
{
public static readonly long[] Value=A021291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021291.Bytes);
public long this[int i]=>Value[i];

public static A021291Inst Instance=new A021291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021290
{
public static readonly long[] Value={ 0L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L,4L,9L,6L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021290Inst : IEnumerable<long>
{
public static readonly long[] Value=A021290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021290.Bytes);
public long this[int i]=>Value[i];

public static A021290Inst Instance=new A021290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021289
{
public static readonly long[] Value={ 0L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L,9L,2L,9L,8L,2L,4L,5L,6L,1L,4L,0L,3L,5L,0L,8L,7L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021289Inst : IEnumerable<long>
{
public static readonly long[] Value=A021289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021289.Bytes);
public long this[int i]=>Value[i];

public static A021289Inst Instance=new A021289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021288
{
public static readonly long[] Value={ 0L,0L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021288Inst : IEnumerable<long>
{
public static readonly long[] Value=A021288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021288.Bytes);
public long this[int i]=>Value[i];

public static A021288Inst Instance=new A021288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021287
{
public static readonly long[] Value={ 0L,0L,3L,5L,3L,3L,5L,6L,8L,9L,0L,4L,5L,9L,3L,6L,3L,9L,5L,7L,5L,9L,7L,1L,7L,3L,1L,4L,4L,8L,7L,6L,3L,2L,5L,0L,8L,8L,3L,3L,9L,2L,2L,2L,6L,1L,4L,8L,4L,0L,9L,8L,9L,3L,9L,9L,2L,9L,3L,2L,8L,6L,2L,1L,9L,0L,8L,1L,2L,7L,2L,0L,8L,4L,8L,0L,5L,6L,5L,3L,7L,1L,0L,2L,4L,7L,3L,4L,9L,8L,2L,3L,3L,2L,1L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021287Inst : IEnumerable<long>
{
public static readonly long[] Value=A021287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021287.Bytes);
public long this[int i]=>Value[i];

public static A021287Inst Instance=new A021287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021286
{
public static readonly long[] Value={ 0L,0L,3L,5L,4L,6L,0L,9L,9L,2L,9L,0L,7L,8L,0L,1L,4L,1L,8L,4L,3L,9L,7L,1L,6L,3L,1L,2L,0L,5L,6L,7L,3L,7L,5L,8L,8L,6L,5L,2L,4L,8L,2L,2L,6L,9L,5L,0L,3L,5L,4L,6L,0L,9L,9L,2L,9L,0L,7L,8L,0L,1L,4L,1L,8L,4L,3L,9L,7L,1L,6L,3L,1L,2L,0L,5L,6L,7L,3L,7L,5L,8L,8L,6L,5L,2L,4L,8L,2L,2L,6L,9L,5L,0L,3L,5L,4L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021286Inst : IEnumerable<long>
{
public static readonly long[] Value=A021286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021286.Bytes);
public long this[int i]=>Value[i];

public static A021286Inst Instance=new A021286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021285
{
public static readonly long[] Value={ 0L,0L,3L,5L,5L,8L,7L,1L,8L,8L,6L,1L,2L,0L,9L,9L,6L,4L,4L,1L,2L,8L,1L,1L,3L,8L,7L,9L,0L,0L,3L,5L,5L,8L,7L,1L,8L,8L,6L,1L,2L,0L,9L,9L,6L,4L,4L,1L,2L,8L,1L,1L,3L,8L,7L,9L,0L,0L,3L,5L,5L,8L,7L,1L,8L,8L,6L,1L,2L,0L,9L,9L,6L,4L,4L,1L,2L,8L,1L,1L,3L,8L,7L,9L,0L,0L,3L,5L,5L,8L,7L,1L,8L,8L,6L,1L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021285Inst : IEnumerable<long>
{
public static readonly long[] Value=A021285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021285.Bytes);
public long this[int i]=>Value[i];

public static A021285Inst Instance=new A021285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021284
{
public static readonly long[] Value={ 1L,22L,335L,4400L,53481L,620202L,6970675L,76624900L,828512861L,8845504382L,93498427815L,980374738200L,10212261530641L,105799242660562L,1091082072825755L,11208627544304300L,114766536787594821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021284Inst : IEnumerable<long>
{
public static readonly long[] Value=A021284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021284.Bytes);
public long this[int i]=>Value[i];

public static A021284Inst Instance=new A021284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021283
{
public static readonly long[] Value={ 0L,0L,3L,5L,8L,4L,2L,2L,9L,3L,9L,0L,6L,8L,1L,0L,0L,3L,5L,8L,4L,2L,2L,9L,3L,9L,0L,6L,8L,1L,0L,0L,3L,5L,8L,4L,2L,2L,9L,3L,9L,0L,6L,8L,1L,0L,0L,3L,5L,8L,4L,2L,2L,9L,3L,9L,0L,6L,8L,1L,0L,0L,3L,5L,8L,4L,2L,2L,9L,3L,9L,0L,6L,8L,1L,0L,0L,3L,5L,8L,4L,2L,2L,9L,3L,9L,0L,6L,8L,1L,0L,0L,3L,5L,8L,4L,2L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021283Inst : IEnumerable<long>
{
public static readonly long[] Value=A021283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021283.Bytes);
public long this[int i]=>Value[i];

public static A021283Inst Instance=new A021283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021282
{
public static readonly long[] Value={ 0L,0L,3L,5L,9L,7L,1L,2L,2L,3L,0L,2L,1L,5L,8L,2L,7L,3L,3L,8L,1L,2L,9L,4L,9L,6L,4L,0L,2L,8L,7L,7L,6L,9L,7L,8L,4L,1L,7L,2L,6L,6L,1L,8L,7L,0L,5L,0L,3L,5L,9L,7L,1L,2L,2L,3L,0L,2L,1L,5L,8L,2L,7L,3L,3L,8L,1L,2L,9L,4L,9L,6L,4L,0L,2L,8L,7L,7L,6L,9L,7L,8L,4L,1L,7L,2L,6L,6L,1L,8L,7L,0L,5L,0L,3L,5L,9L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021282Inst : IEnumerable<long>
{
public static readonly long[] Value=A021282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021282.Bytes);
public long this[int i]=>Value[i];

public static A021282Inst Instance=new A021282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021281
{
public static readonly long[] Value={ 0L,0L,3L,6L,1L,0L,1L,0L,8L,3L,0L,3L,2L,4L,9L,0L,9L,7L,4L,7L,2L,9L,2L,4L,1L,8L,7L,7L,2L,5L,6L,3L,1L,7L,6L,8L,9L,5L,3L,0L,6L,8L,5L,9L,2L,0L,5L,7L,7L,6L,1L,7L,3L,2L,8L,5L,1L,9L,8L,5L,5L,5L,9L,5L,6L,6L,7L,8L,7L,0L,0L,3L,6L,1L,0L,1L,0L,8L,3L,0L,3L,2L,4L,9L,0L,9L,7L,4L,7L,2L,9L,2L,4L,1L,8L,7L,7L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021281Inst : IEnumerable<long>
{
public static readonly long[] Value=A021281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021281.Bytes);
public long this[int i]=>Value[i];

public static A021281Inst Instance=new A021281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021280
{
public static readonly long[] Value={ 0L,0L,3L,6L,2L,3L,1L,8L,8L,4L,0L,5L,7L,9L,7L,1L,0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L,3L,1L,8L,8L,4L,0L,5L,7L,9L,7L,1L,0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L,3L,1L,8L,8L,4L,0L,5L,7L,9L,7L,1L,0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L,3L,1L,8L,8L,4L,0L,5L,7L,9L,7L,1L,0L,1L,4L,4L,9L,2L,7L,5L,3L,6L,2L,3L,1L,8L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021280Inst : IEnumerable<long>
{
public static readonly long[] Value=A021280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021280.Bytes);
public long this[int i]=>Value[i];

public static A021280Inst Instance=new A021280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021279
{
public static readonly long[] Value={ 1L,23L,371L,5227L,68955L,877371L,10927867L,134329979L,1637524859L,19854820219L,239894019963L,2891817662331L,34806527338363L,418516051199867L,5028894399547259L,60400347075823483L,725233079160063867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021279Inst : IEnumerable<long>
{
public static readonly long[] Value=A021279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021279.Bytes);
public long this[int i]=>Value[i];

public static A021279Inst Instance=new A021279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021278
{
public static readonly long[] Value={ 0L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L,6L,4L,9L,6L,3L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021278Inst : IEnumerable<long>
{
public static readonly long[] Value=A021278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021278.Bytes);
public long this[int i]=>Value[i];

public static A021278Inst Instance=new A021278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021277
{
public static readonly long[] Value={ 0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L,6L,6L,3L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021277Inst : IEnumerable<long>
{
public static readonly long[] Value=A021277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021277.Bytes);
public long this[int i]=>Value[i];

public static A021277Inst Instance=new A021277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021276
{
public static readonly long[] Value={ 0L,0L,3L,6L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021276Inst : IEnumerable<long>
{
public static readonly long[] Value=A021276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021276.Bytes);
public long this[int i]=>Value[i];

public static A021276Inst Instance=new A021276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021275
{
public static readonly long[] Value={ 0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L,9L,0L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021275Inst : IEnumerable<long>
{
public static readonly long[] Value=A021275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021275.Bytes);
public long this[int i]=>Value[i];

public static A021275Inst Instance=new A021275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021274
{
public static readonly long[] Value={ 1L,22L,337L,4482L,55533L,660774L,7667929L,87542794L,988535845L,11078416206L,123498755601L,1371575734386L,15192048468637L,167950256294518L,1854154604388553L,20449314929530458L,225371378475017109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021274Inst : IEnumerable<long>
{
public static readonly long[] Value=A021274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021274.Bytes);
public long this[int i]=>Value[i];

public static A021274Inst Instance=new A021274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021273
{
public static readonly long[] Value={ 0L,0L,3L,7L,1L,7L,4L,7L,2L,1L,1L,8L,9L,5L,9L,1L,0L,7L,8L,0L,6L,6L,9L,1L,4L,4L,9L,8L,1L,4L,1L,2L,6L,3L,9L,4L,0L,5L,2L,0L,4L,4L,6L,0L,9L,6L,6L,5L,4L,2L,7L,5L,0L,9L,2L,9L,3L,6L,8L,0L,2L,9L,7L,3L,9L,7L,7L,6L,9L,5L,1L,6L,7L,2L,8L,6L,2L,4L,5L,3L,5L,3L,1L,5L,9L,8L,5L,1L,3L,0L,1L,1L,1L,5L,2L,4L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021273Inst : IEnumerable<long>
{
public static readonly long[] Value=A021273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021273.Bytes);
public long this[int i]=>Value[i];

public static A021273Inst Instance=new A021273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021272
{
public static readonly long[] Value={ 0L,0L,3L,7L,3L,1L,3L,4L,3L,2L,8L,3L,5L,8L,2L,0L,8L,9L,5L,5L,2L,2L,3L,8L,8L,0L,5L,9L,7L,0L,1L,4L,9L,2L,5L,3L,7L,3L,1L,3L,4L,3L,2L,8L,3L,5L,8L,2L,0L,8L,9L,5L,5L,2L,2L,3L,8L,8L,0L,5L,9L,7L,0L,1L,4L,9L,2L,5L,3L,7L,3L,1L,3L,4L,3L,2L,8L,3L,5L,8L,2L,0L,8L,9L,5L,5L,2L,2L,3L,8L,8L,0L,5L,9L,7L,0L,1L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021272Inst : IEnumerable<long>
{
public static readonly long[] Value=A021272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021272.Bytes);
public long this[int i]=>Value[i];

public static A021272Inst Instance=new A021272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021271
{
public static readonly long[] Value={ 0L,0L,3L,7L,4L,5L,3L,1L,8L,3L,5L,2L,0L,5L,9L,9L,2L,5L,0L,9L,3L,6L,3L,2L,9L,5L,8L,8L,0L,1L,4L,9L,8L,1L,2L,7L,3L,4L,0L,8L,2L,3L,9L,7L,0L,0L,3L,7L,4L,5L,3L,1L,8L,3L,5L,2L,0L,5L,9L,9L,2L,5L,0L,9L,3L,6L,3L,2L,9L,5L,8L,8L,0L,1L,4L,9L,8L,1L,2L,7L,3L,4L,0L,8L,2L,3L,9L,7L,0L,0L,3L,7L,4L,5L,3L,1L,8L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021271Inst : IEnumerable<long>
{
public static readonly long[] Value=A021271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021271.Bytes);
public long this[int i]=>Value[i];

public static A021271Inst Instance=new A021271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021270
{
public static readonly long[] Value={ 0L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L,4L,9L,6L,2L,4L,0L,6L,0L,1L,5L,0L,3L,7L,5L,9L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021270Inst : IEnumerable<long>
{
public static readonly long[] Value=A021270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021270.Bytes);
public long this[int i]=>Value[i];

public static A021270Inst Instance=new A021270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021269
{
public static readonly long[] Value={ 0L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L,4L,9L,0L,5L,6L,6L,0L,3L,7L,7L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021269Inst : IEnumerable<long>
{
public static readonly long[] Value=A021269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021269.Bytes);
public long this[int i]=>Value[i];

public static A021269Inst Instance=new A021269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021268
{
public static readonly long[] Value={ 1L,21L,305L,3825L,44481L,494721L,5346625L,56661825L,592183361L,6126355521L,62899732545L,642086748225L,6525582872641L,66093551865921L,667637303808065L,6729987319337025L,67728787443552321L,680719188437241921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021268Inst : IEnumerable<long>
{
public static readonly long[] Value=A021268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021268.Bytes);
public long this[int i]=>Value[i];

public static A021268Inst Instance=new A021268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021267
{
public static readonly long[] Value={ 0L,0L,3L,8L,0L,2L,2L,8L,1L,3L,6L,8L,8L,2L,1L,2L,9L,2L,7L,7L,5L,6L,6L,5L,3L,9L,9L,2L,3L,9L,5L,4L,3L,7L,2L,6L,2L,3L,5L,7L,4L,1L,4L,4L,4L,8L,6L,6L,9L,2L,0L,1L,5L,2L,0L,9L,1L,2L,5L,4L,7L,5L,2L,8L,5L,1L,7L,1L,1L,0L,2L,6L,6L,1L,5L,9L,6L,9L,5L,8L,1L,7L,4L,9L,0L,4L,9L,4L,2L,9L,6L,5L,7L,7L,9L,4L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021267Inst : IEnumerable<long>
{
public static readonly long[] Value=A021267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021267.Bytes);
public long this[int i]=>Value[i];

public static A021267Inst Instance=new A021267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021266
{
public static readonly long[] Value={ 0L,0L,3L,8L,1L,6L,7L,9L,3L,8L,9L,3L,1L,2L,9L,7L,7L,0L,9L,9L,2L,3L,6L,6L,4L,1L,2L,2L,1L,3L,7L,4L,0L,4L,5L,8L,0L,1L,5L,2L,6L,7L,1L,7L,5L,5L,7L,2L,5L,1L,9L,0L,8L,3L,9L,6L,9L,4L,6L,5L,6L,4L,8L,8L,5L,4L,9L,6L,1L,8L,3L,2L,0L,6L,1L,0L,6L,8L,7L,0L,2L,2L,9L,0L,0L,7L,6L,3L,3L,5L,8L,7L,7L,8L,6L,2L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021266Inst : IEnumerable<long>
{
public static readonly long[] Value=A021266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021266.Bytes);
public long this[int i]=>Value[i];

public static A021266Inst Instance=new A021266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021265
{
public static readonly long[] Value={ 0L,0L,3L,8L,3L,1L,4L,1L,7L,6L,2L,4L,5L,2L,1L,0L,7L,2L,7L,9L,6L,9L,3L,4L,8L,6L,5L,9L,0L,0L,3L,8L,3L,1L,4L,1L,7L,6L,2L,4L,5L,2L,1L,0L,7L,2L,7L,9L,6L,9L,3L,4L,8L,6L,5L,9L,0L,0L,3L,8L,3L,1L,4L,1L,7L,6L,2L,4L,5L,2L,1L,0L,7L,2L,7L,9L,6L,9L,3L,4L,8L,6L,5L,9L,0L,0L,3L,8L,3L,1L,4L,1L,7L,6L,2L,4L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021265Inst : IEnumerable<long>
{
public static readonly long[] Value=A021265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021265.Bytes);
public long this[int i]=>Value[i];

public static A021265Inst Instance=new A021265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021264
{
public static readonly long[] Value={ 1L,20L,275L,3250L,35481L,369240L,3722575L,36698750L,355853861L,3407206660L,32301037275L,303798758250L,2838904214641L,26387861071280L,244192534790375L,2251347094369750L,20691038099509821L,189650656897307100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021264Inst : IEnumerable<long>
{
public static readonly long[] Value=A021264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021264.Bytes);
public long this[int i]=>Value[i];

public static A021264Inst Instance=new A021264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021263
{
public static readonly long[] Value={ 0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L,8L,6L,1L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021263Inst : IEnumerable<long>
{
public static readonly long[] Value=A021263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021263.Bytes);
public long this[int i]=>Value[i];

public static A021263Inst Instance=new A021263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021262
{
public static readonly long[] Value={ 0L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L,0L,6L,2L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L,0L,6L,2L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L,0L,6L,2L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L,0L,6L,2L,0L,1L,5L,5L,0L,3L,8L,7L,5L,9L,6L,8L,9L,9L,2L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021262Inst : IEnumerable<long>
{
public static readonly long[] Value=A021262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021262.Bytes);
public long this[int i]=>Value[i];

public static A021262Inst Instance=new A021262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021261
{
public static readonly long[] Value={ 0L,0L,3L,8L,9L,1L,0L,5L,0L,5L,8L,3L,6L,5L,7L,5L,8L,7L,5L,4L,8L,6L,3L,8L,1L,3L,2L,2L,9L,5L,7L,1L,9L,8L,4L,4L,3L,5L,7L,9L,7L,6L,6L,5L,3L,6L,9L,6L,4L,9L,8L,0L,5L,4L,4L,7L,4L,7L,0L,8L,1L,7L,1L,2L,0L,6L,2L,2L,5L,6L,8L,0L,9L,3L,3L,8L,5L,2L,1L,4L,0L,0L,7L,7L,8L,2L,1L,0L,1L,1L,6L,7L,3L,1L,5L,1L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021261Inst : IEnumerable<long>
{
public static readonly long[] Value=A021261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021261.Bytes);
public long this[int i]=>Value[i];

public static A021261Inst Instance=new A021261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021260
{
public static readonly long[] Value={ 0L,0L,3L,9L,0L,6L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021260Inst : IEnumerable<long>
{
public static readonly long[] Value=A021260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021260.Bytes);
public long this[int i]=>Value[i];

public static A021260Inst Instance=new A021260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021259
{
public static readonly long[] Value={ 0L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021259Inst : IEnumerable<long>
{
public static readonly long[] Value=A021259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021259.Bytes);
public long this[int i]=>Value[i];

public static A021259Inst Instance=new A021259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021258
{
public static readonly long[] Value={ 0L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021258Inst : IEnumerable<long>
{
public static readonly long[] Value=A021258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021258.Bytes);
public long this[int i]=>Value[i];

public static A021258Inst Instance=new A021258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021257
{
public static readonly long[] Value={ 0L,0L,3L,9L,5L,2L,5L,6L,9L,1L,6L,9L,9L,6L,0L,4L,7L,4L,3L,0L,8L,3L,0L,0L,3L,9L,5L,2L,5L,6L,9L,1L,6L,9L,9L,6L,0L,4L,7L,4L,3L,0L,8L,3L,0L,0L,3L,9L,5L,2L,5L,6L,9L,1L,6L,9L,9L,6L,0L,4L,7L,4L,3L,0L,8L,3L,0L,0L,3L,9L,5L,2L,5L,6L,9L,1L,6L,9L,9L,6L,0L,4L,7L,4L,3L,0L,8L,3L,0L,0L,3L,9L,5L,2L,5L,6L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021257Inst : IEnumerable<long>
{
public static readonly long[] Value=A021257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021257.Bytes);
public long this[int i]=>Value[i];

public static A021257Inst Instance=new A021257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021256
{
public static readonly long[] Value={ 0L,0L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021256Inst : IEnumerable<long>
{
public static readonly long[] Value=A021256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021256.Bytes);
public long this[int i]=>Value[i];

public static A021256Inst Instance=new A021256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021255
{
public static readonly long[] Value={ 0L,0L,3L,9L,8L,4L,0L,6L,3L,7L,4L,5L,0L,1L,9L,9L,2L,0L,3L,1L,8L,7L,2L,5L,0L,9L,9L,6L,0L,1L,5L,9L,3L,6L,2L,5L,4L,9L,8L,0L,0L,7L,9L,6L,8L,1L,2L,7L,4L,9L,0L,0L,3L,9L,8L,4L,0L,6L,3L,7L,4L,5L,0L,1L,9L,9L,2L,0L,3L,1L,8L,7L,2L,5L,0L,9L,9L,6L,0L,1L,5L,9L,3L,6L,2L,5L,4L,9L,8L,0L,0L,7L,9L,6L,8L,1L,2L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021255Inst : IEnumerable<long>
{
public static readonly long[] Value=A021255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021255.Bytes);
public long this[int i]=>Value[i];

public static A021255Inst Instance=new A021255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021254
{
public static readonly long[] Value={ 1L,22L,341L,4646L,59661L,743358L,9112405L,110693878L,1337742173L,16118816558L,193887174117L,2329875721446L,27981116089837L,335931645121822L,4032287505801077L,48395204420052950L,580796733493846653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021254Inst : IEnumerable<long>
{
public static readonly long[] Value=A021254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021254.Bytes);
public long this[int i]=>Value[i];

public static A021254Inst Instance=new A021254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021253
{
public static readonly long[] Value={ 0L,0L,4L,0L,1L,6L,0L,6L,4L,2L,5L,7L,0L,2L,8L,1L,1L,2L,4L,4L,9L,7L,9L,9L,1L,9L,6L,7L,8L,7L,1L,4L,8L,5L,9L,4L,3L,7L,7L,5L,1L,0L,0L,4L,0L,1L,6L,0L,6L,4L,2L,5L,7L,0L,2L,8L,1L,1L,2L,4L,4L,9L,7L,9L,9L,1L,9L,6L,7L,8L,7L,1L,4L,8L,5L,9L,4L,3L,7L,7L,5L,1L,0L,0L,4L,0L,1L,6L,0L,6L,4L,2L,5L,7L,0L,2L,8L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021253Inst : IEnumerable<long>
{
public static readonly long[] Value=A021253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021253.Bytes);
public long this[int i]=>Value[i];

public static A021253Inst Instance=new A021253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021252
{
public static readonly long[] Value={ 0L,0L,4L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L,0L,6L,4L,5L,1L,6L,1L,2L,9L,0L,3L,2L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021252Inst : IEnumerable<long>
{
public static readonly long[] Value=A021252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021252.Bytes);
public long this[int i]=>Value[i];

public static A021252Inst Instance=new A021252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021251
{
public static readonly long[] Value={ 0L,0L,4L,0L,4L,8L,5L,8L,2L,9L,9L,5L,9L,5L,1L,4L,1L,7L,0L,0L,4L,0L,4L,8L,5L,8L,2L,9L,9L,5L,9L,5L,1L,4L,1L,7L,0L,0L,4L,0L,4L,8L,5L,8L,2L,9L,9L,5L,9L,5L,1L,4L,1L,7L,0L,0L,4L,0L,4L,8L,5L,8L,2L,9L,9L,5L,9L,5L,1L,4L,1L,7L,0L,0L,4L,0L,4L,8L,5L,8L,2L,9L,9L,5L,9L,5L,1L,4L,1L,7L,0L,0L,4L,0L,4L,8L,5L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021251Inst : IEnumerable<long>
{
public static readonly long[] Value=A021251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021251.Bytes);
public long this[int i]=>Value[i];

public static A021251Inst Instance=new A021251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021250
{
public static readonly long[] Value={ 0L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L,6L,5L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021250Inst : IEnumerable<long>
{
public static readonly long[] Value=A021250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021250.Bytes);
public long this[int i]=>Value[i];

public static A021250Inst Instance=new A021250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021249
{
public static readonly long[] Value={ 0L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L,2L,2L,4L,4L,8L,9L,7L,9L,5L,9L,1L,8L,3L,6L,7L,3L,4L,6L,9L,3L,8L,7L,7L,5L,5L,1L,0L,2L,0L,4L,0L,8L,1L,6L,3L,2L,6L,5L,3L,0L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021249Inst : IEnumerable<long>
{
public static readonly long[] Value=A021249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021249.Bytes);
public long this[int i]=>Value[i];

public static A021249Inst Instance=new A021249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021248
{
public static readonly long[] Value={ 0L,0L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L,3L,4L,4L,2L,6L,2L,2L,9L,5L,0L,8L,1L,9L,6L,7L,2L,1L,3L,1L,1L,4L,7L,5L,4L,0L,9L,8L,3L,6L,0L,6L,5L,5L,7L,3L,7L,7L,0L,4L,9L,1L,8L,0L,3L,2L,7L,8L,6L,8L,8L,5L,2L,4L,5L,9L,0L,1L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021248Inst : IEnumerable<long>
{
public static readonly long[] Value=A021248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021248.Bytes);
public long this[int i]=>Value[i];

public static A021248Inst Instance=new A021248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021247
{
public static readonly long[] Value={ 0L,0L,4L,1L,1L,5L,2L,2L,6L,3L,3L,7L,4L,4L,8L,5L,5L,9L,6L,7L,0L,7L,8L,1L,8L,9L,3L,0L,0L,4L,1L,1L,5L,2L,2L,6L,3L,3L,7L,4L,4L,8L,5L,5L,9L,6L,7L,0L,7L,8L,1L,8L,9L,3L,0L,0L,4L,1L,1L,5L,2L,2L,6L,3L,3L,7L,4L,4L,8L,5L,5L,9L,6L,7L,0L,7L,8L,1L,8L,9L,3L,0L,0L,4L,1L,1L,5L,2L,2L,6L,3L,3L,7L,4L,4L,8L,5L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021247Inst : IEnumerable<long>
{
public static readonly long[] Value=A021247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021247.Bytes);
public long this[int i]=>Value[i];

public static A021247Inst Instance=new A021247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021246
{
public static readonly long[] Value={ 0L,0L,4L,1L,3L,2L,2L,3L,1L,4L,0L,4L,9L,5L,8L,6L,7L,7L,6L,8L,5L,9L,5L,0L,4L,1L,3L,2L,2L,3L,1L,4L,0L,4L,9L,5L,8L,6L,7L,7L,6L,8L,5L,9L,5L,0L,4L,1L,3L,2L,2L,3L,1L,4L,0L,4L,9L,5L,8L,6L,7L,7L,6L,8L,5L,9L,5L,0L,4L,1L,3L,2L,2L,3L,1L,4L,0L,4L,9L,5L,8L,6L,7L,7L,6L,8L,5L,9L,5L,0L,4L,1L,3L,2L,2L,3L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021246Inst : IEnumerable<long>
{
public static readonly long[] Value=A021246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021246.Bytes);
public long this[int i]=>Value[i];

public static A021246Inst Instance=new A021246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021245
{
public static readonly long[] Value={ 0L,0L,4L,1L,4L,9L,3L,7L,7L,5L,9L,3L,3L,6L,0L,9L,9L,5L,8L,5L,0L,6L,2L,2L,4L,0L,6L,6L,3L,9L,0L,0L,4L,1L,4L,9L,3L,7L,7L,5L,9L,3L,3L,6L,0L,9L,9L,5L,8L,5L,0L,6L,2L,2L,4L,0L,6L,6L,3L,9L,0L,0L,4L,1L,4L,9L,3L,7L,7L,5L,9L,3L,3L,6L,0L,9L,9L,5L,8L,5L,0L,6L,2L,2L,4L,0L,6L,6L,3L,9L,0L,0L,4L,1L,4L,9L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021245Inst : IEnumerable<long>
{
public static readonly long[] Value=A021245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021245.Bytes);
public long this[int i]=>Value[i];

public static A021245Inst Instance=new A021245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021244
{
public static readonly long[] Value={ 1L,21L,308L,3942L,47271L,547407L,6213586L,69694464L,776054741L,8602512633L,95089014384L,1049208790266L,11563904125411L,127361197423299L,1402080935995502L,15430644646390548L,169791371563507281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021244Inst : IEnumerable<long>
{
public static readonly long[] Value=A021244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021244.Bytes);
public long this[int i]=>Value[i];

public static A021244Inst Instance=new A021244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021243
{
public static readonly long[] Value={ 0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L,0L,4L,1L,8L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021243Inst : IEnumerable<long>
{
public static readonly long[] Value=A021243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021243.Bytes);
public long this[int i]=>Value[i];

public static A021243Inst Instance=new A021243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021242
{
public static readonly long[] Value={ 0L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021242Inst : IEnumerable<long>
{
public static readonly long[] Value=A021242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021242.Bytes);
public long this[int i]=>Value[i];

public static A021242Inst Instance=new A021242Inst();

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