using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011301
{
public static readonly long[] Value={ 1L,1L,5L,1L,4L,8L,5L,2L,8L,7L,1L,7L,9L,4L,9L,6L,3L,1L,7L,8L,4L,5L,5L,0L,4L,5L,6L,8L,1L,3L,2L,4L,7L,4L,0L,7L,1L,6L,3L,1L,1L,7L,8L,0L,4L,8L,2L,7L,4L,8L,4L,4L,9L,2L,3L,9L,0L,2L,1L,9L,2L,4L,6L,4L,0L,4L,6L,6L,3L,0L,2L,2L,5L,4L,6L,2L,4L,7L,8L,3L,3L,4L,1L,8L,3L,7L,6L,6L,4L,4L,3L,4L,8L,8L,6L,8L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011301Inst : IEnumerable<long>
{
public static readonly long[] Value=A011301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011301.Bytes);
public long this[int i]=>Value[i];

public static A011301Inst Instance=new A011301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011302
{
public static readonly long[] Value={ 1L,1L,4L,2L,4L,9L,7L,2L,1L,2L,5L,9L,8L,3L,1L,5L,1L,7L,5L,4L,4L,0L,1L,4L,5L,3L,1L,5L,6L,0L,0L,6L,2L,9L,1L,4L,1L,0L,1L,7L,4L,8L,2L,1L,0L,1L,3L,0L,3L,7L,7L,7L,7L,1L,2L,7L,2L,5L,1L,0L,9L,9L,2L,1L,2L,8L,2L,9L,1L,2L,7L,7L,5L,4L,6L,3L,7L,0L,8L,5L,0L,3L,0L,6L,0L,7L,4L,2L,8L,9L,5L,6L,6L,0L,4L,6L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011302Inst : IEnumerable<long>
{
public static readonly long[] Value=A011302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011302.Bytes);
public long this[int i]=>Value[i];

public static A011302Inst Instance=new A011302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011303
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,1L,4L,7L,3L,6L,2L,5L,2L,4L,0L,1L,5L,5L,1L,0L,8L,5L,0L,6L,3L,5L,0L,8L,8L,5L,6L,9L,4L,3L,5L,2L,8L,9L,1L,8L,1L,4L,3L,2L,6L,7L,8L,4L,5L,9L,3L,0L,7L,6L,5L,5L,8L,3L,3L,4L,4L,1L,0L,9L,0L,3L,0L,1L,9L,6L,6L,1L,4L,4L,4L,4L,7L,1L,0L,2L,5L,1L,3L,7L,3L,6L,2L,9L,1L,9L,7L,1L,9L,5L,9L,5L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011303Inst : IEnumerable<long>
{
public static readonly long[] Value=A011303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011303.Bytes);
public long this[int i]=>Value[i];

public static A011303Inst Instance=new A011303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011304
{
public static readonly long[] Value={ 1L,1L,2L,7L,3L,7L,8L,2L,0L,4L,1L,5L,7L,8L,3L,3L,0L,2L,4L,1L,4L,3L,0L,7L,8L,0L,1L,9L,8L,1L,3L,4L,3L,4L,7L,5L,3L,4L,5L,0L,8L,6L,3L,7L,6L,6L,5L,1L,8L,8L,9L,1L,9L,2L,6L,8L,6L,9L,3L,5L,9L,1L,2L,2L,7L,4L,7L,0L,7L,2L,5L,0L,1L,9L,5L,5L,3L,9L,3L,6L,2L,2L,8L,8L,2L,1L,7L,9L,8L,8L,9L,7L,3L,3L,4L,6L,7L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011304Inst : IEnumerable<long>
{
public static readonly long[] Value=A011304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011304.Bytes);
public long this[int i]=>Value[i];

public static A011304Inst Instance=new A011304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011305
{
public static readonly long[] Value={ 1L,5L,1L,3L,0L,8L,5L,7L,4L,9L,4L,2L,2L,9L,0L,1L,5L,8L,8L,7L,8L,4L,0L,5L,9L,9L,4L,0L,9L,6L,8L,7L,7L,5L,8L,1L,6L,8L,7L,2L,5L,2L,4L,3L,6L,9L,9L,9L,8L,9L,1L,6L,1L,7L,7L,1L,8L,0L,9L,3L,0L,6L,9L,3L,9L,6L,0L,6L,6L,8L,5L,1L,0L,9L,1L,5L,0L,1L,5L,0L,4L,3L,0L,7L,2L,7L,7L,2L,5L,7L,3L,1L,7L,2L,1L,5L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011305Inst : IEnumerable<long>
{
public static readonly long[] Value=A011305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011305.Bytes);
public long this[int i]=>Value[i];

public static A011305Inst Instance=new A011305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011306
{
public static readonly long[] Value={ 1L,4L,2L,6L,1L,6L,1L,6L,3L,5L,2L,2L,7L,3L,7L,8L,8L,4L,0L,4L,8L,4L,1L,2L,0L,6L,8L,5L,4L,5L,1L,4L,4L,2L,5L,6L,6L,7L,2L,9L,7L,0L,3L,9L,8L,7L,6L,4L,5L,1L,6L,7L,1L,7L,4L,3L,1L,0L,5L,7L,6L,8L,3L,6L,7L,8L,8L,0L,7L,3L,6L,8L,3L,7L,0L,2L,5L,4L,5L,6L,0L,9L,5L,5L,8L,2L,9L,5L,1L,5L,2L,3L,4L,9L,8L,8L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011306Inst : IEnumerable<long>
{
public static readonly long[] Value=A011306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011306.Bytes);
public long this[int i]=>Value[i];

public static A011306Inst Instance=new A011306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011307
{
public static readonly long[] Value={ 1L,3L,6L,4L,2L,6L,1L,6L,0L,1L,8L,2L,1L,3L,6L,5L,9L,2L,9L,5L,8L,6L,0L,3L,5L,2L,7L,5L,2L,3L,9L,6L,1L,1L,5L,8L,4L,4L,3L,9L,4L,6L,5L,0L,5L,7L,6L,3L,5L,0L,7L,5L,6L,3L,5L,6L,5L,7L,0L,8L,6L,5L,5L,2L,4L,2L,6L,8L,0L,0L,3L,9L,7L,7L,7L,1L,5L,4L,5L,7L,1L,5L,7L,6L,0L,0L,0L,7L,8L,1L,3L,3L,7L,8L,8L,0L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011307Inst : IEnumerable<long>
{
public static readonly long[] Value=A011307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011307.Bytes);
public long this[int i]=>Value[i];

public static A011307Inst Instance=new A011307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011308
{
public static readonly long[] Value={ 1L,3L,1L,7L,9L,8L,0L,6L,2L,9L,2L,1L,3L,0L,0L,2L,2L,3L,9L,7L,7L,5L,9L,1L,7L,7L,4L,1L,9L,8L,8L,2L,9L,6L,2L,7L,7L,0L,8L,2L,9L,7L,6L,7L,3L,9L,9L,6L,1L,3L,7L,4L,6L,4L,3L,5L,9L,2L,4L,6L,6L,7L,2L,9L,8L,6L,9L,1L,4L,3L,9L,0L,7L,8L,3L,0L,0L,8L,6L,4L,8L,0L,6L,9L,0L,3L,8L,4L,5L,9L,0L,7L,9L,7L,0L,8L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011308Inst : IEnumerable<long>
{
public static readonly long[] Value=A011308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011308.Bytes);
public long this[int i]=>Value[i];

public static A011308Inst Instance=new A011308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011309
{
public static readonly long[] Value={ 1L,2L,8L,2L,0L,8L,8L,8L,5L,3L,9L,8L,6L,8L,1L,5L,4L,4L,0L,4L,4L,8L,5L,3L,0L,7L,6L,2L,9L,1L,5L,5L,9L,9L,4L,8L,2L,5L,8L,2L,0L,8L,8L,5L,4L,8L,9L,4L,7L,0L,0L,2L,4L,2L,4L,8L,2L,2L,5L,0L,6L,4L,6L,2L,0L,9L,3L,6L,9L,8L,4L,1L,4L,4L,1L,6L,6L,0L,7L,0L,7L,6L,7L,8L,6L,0L,6L,4L,7L,6L,4L,8L,1L,6L,0L,9L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011309Inst : IEnumerable<long>
{
public static readonly long[] Value=A011309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011309.Bytes);
public long this[int i]=>Value[i];

public static A011309Inst Instance=new A011309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011310
{
public static readonly long[] Value={ 1L,2L,5L,3L,4L,5L,1L,0L,7L,1L,7L,2L,3L,0L,9L,0L,0L,1L,4L,1L,4L,2L,1L,3L,9L,1L,4L,7L,5L,6L,1L,5L,3L,6L,4L,9L,8L,9L,4L,5L,4L,5L,7L,1L,6L,4L,3L,0L,1L,7L,5L,9L,0L,5L,8L,6L,5L,2L,4L,7L,5L,1L,9L,5L,6L,3L,2L,4L,5L,1L,5L,0L,2L,5L,6L,5L,5L,6L,3L,7L,0L,7L,8L,2L,5L,4L,4L,5L,9L,9L,7L,4L,0L,4L,7L,5L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011310Inst : IEnumerable<long>
{
public static readonly long[] Value=A011310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011310.Bytes);
public long this[int i]=>Value[i];

public static A011310Inst Instance=new A011310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011311
{
public static readonly long[] Value={ 1L,2L,3L,0L,0L,7L,5L,5L,0L,5L,5L,7L,7L,9L,7L,1L,2L,5L,3L,6L,6L,3L,0L,0L,5L,4L,9L,6L,1L,1L,7L,0L,8L,1L,6L,7L,9L,7L,7L,8L,5L,0L,8L,9L,6L,8L,7L,5L,9L,4L,4L,1L,8L,7L,8L,5L,4L,0L,5L,4L,9L,6L,7L,1L,3L,9L,3L,4L,6L,2L,9L,7L,7L,0L,7L,6L,8L,3L,2L,7L,4L,9L,5L,5L,5L,0L,2L,2L,3L,1L,7L,3L,1L,9L,6L,6L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011311Inst : IEnumerable<long>
{
public static readonly long[] Value=A011311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011311.Bytes);
public long this[int i]=>Value[i];

public static A011311Inst Instance=new A011311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011312
{
public static readonly long[] Value={ 1L,2L,1L,0L,6L,3L,6L,9L,9L,7L,5L,8L,2L,2L,3L,0L,4L,7L,5L,1L,6L,0L,8L,4L,7L,6L,8L,1L,1L,6L,0L,9L,7L,7L,1L,1L,0L,3L,2L,6L,9L,0L,6L,4L,3L,5L,3L,4L,0L,5L,0L,2L,1L,5L,0L,8L,3L,5L,0L,0L,7L,0L,9L,4L,5L,2L,2L,1L,2L,3L,8L,7L,5L,3L,8L,3L,0L,4L,2L,7L,1L,4L,2L,4L,0L,3L,2L,0L,4L,0L,7L,2L,5L,5L,2L,4L,9L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011312Inst : IEnumerable<long>
{
public static readonly long[] Value=A011312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011312.Bytes);
public long this[int i]=>Value[i];

public static A011312Inst Instance=new A011312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011313
{
public static readonly long[] Value={ 1L,1L,9L,4L,2L,2L,0L,0L,9L,4L,9L,6L,8L,8L,3L,7L,3L,2L,5L,3L,6L,8L,8L,8L,4L,1L,8L,9L,2L,9L,2L,2L,9L,1L,9L,6L,1L,3L,9L,1L,2L,2L,7L,8L,0L,0L,1L,5L,3L,2L,1L,6L,5L,0L,0L,0L,7L,1L,2L,7L,7L,3L,8L,0L,6L,3L,1L,9L,6L,5L,2L,4L,0L,7L,5L,1L,9L,7L,1L,3L,4L,1L,0L,6L,9L,9L,0L,4L,1L,6L,1L,8L,0L,9L,3L,4L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011313Inst : IEnumerable<long>
{
public static readonly long[] Value=A011313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011313.Bytes);
public long this[int i]=>Value[i];

public static A011313Inst Instance=new A011313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011314
{
public static readonly long[] Value={ 1L,1L,8L,0L,1L,7L,2L,2L,9L,8L,2L,9L,1L,0L,0L,5L,6L,8L,7L,7L,6L,3L,2L,5L,3L,9L,0L,4L,3L,9L,3L,6L,7L,3L,5L,4L,4L,2L,6L,6L,2L,9L,4L,3L,5L,4L,3L,0L,0L,4L,9L,2L,8L,3L,0L,2L,3L,1L,5L,2L,5L,7L,6L,4L,7L,8L,9L,6L,5L,9L,2L,8L,3L,7L,6L,0L,9L,4L,9L,5L,0L,2L,7L,5L,3L,0L,9L,4L,2L,5L,5L,9L,3L,2L,1L,2L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011314Inst : IEnumerable<long>
{
public static readonly long[] Value=A011314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011314.Bytes);
public long this[int i]=>Value[i];

public static A011314Inst Instance=new A011314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011315
{
public static readonly long[] Value={ 1L,1L,6L,8L,0L,1L,6L,0L,9L,6L,5L,5L,9L,1L,8L,9L,5L,1L,7L,0L,5L,6L,6L,8L,2L,0L,5L,0L,7L,4L,6L,9L,8L,1L,4L,3L,4L,6L,9L,6L,2L,1L,5L,0L,6L,2L,8L,6L,4L,4L,6L,9L,7L,9L,3L,9L,0L,5L,7L,5L,3L,2L,8L,7L,4L,9L,8L,9L,6L,5L,7L,2L,5L,0L,1L,7L,8L,4L,1L,6L,8L,2L,0L,3L,5L,3L,0L,3L,5L,4L,8L,4L,8L,3L,6L,3L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011315Inst : IEnumerable<long>
{
public static readonly long[] Value=A011315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011315.Bytes);
public long this[int i]=>Value[i];

public static A011315Inst Instance=new A011315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011316
{
public static readonly long[] Value={ 1L,1L,5L,7L,3L,9L,4L,0L,6L,1L,6L,7L,5L,5L,6L,9L,3L,0L,4L,7L,6L,3L,2L,2L,0L,6L,7L,0L,9L,9L,7L,5L,3L,2L,5L,9L,4L,0L,4L,2L,1L,5L,3L,0L,3L,9L,2L,3L,8L,7L,3L,1L,3L,3L,0L,5L,4L,3L,1L,8L,8L,3L,7L,9L,5L,4L,4L,5L,5L,1L,8L,4L,6L,4L,7L,1L,1L,2L,8L,2L,1L,4L,6L,6L,5L,8L,7L,8L,3L,2L,8L,0L,5L,8L,8L,4L,3L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011316Inst : IEnumerable<long>
{
public static readonly long[] Value=A011316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011316.Bytes);
public long this[int i]=>Value[i];

public static A011316Inst Instance=new A011316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011317
{
public static readonly long[] Value={ 1L,1L,4L,8L,0L,3L,3L,3L,7L,4L,6L,0L,7L,6L,3L,8L,4L,1L,6L,7L,0L,6L,2L,9L,5L,7L,2L,5L,0L,4L,5L,2L,5L,5L,6L,9L,1L,9L,2L,9L,0L,3L,1L,7L,1L,4L,2L,0L,6L,3L,7L,1L,8L,3L,6L,9L,9L,1L,2L,9L,3L,5L,5L,0L,0L,0L,6L,8L,5L,0L,4L,3L,3L,2L,9L,7L,2L,8L,3L,6L,7L,3L,0L,7L,1L,1L,7L,1L,3L,3L,9L,8L,2L,0L,8L,1L,8L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011317Inst : IEnumerable<long>
{
public static readonly long[] Value=A011317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011317.Bytes);
public long this[int i]=>Value[i];

public static A011317Inst Instance=new A011317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011318
{
public static readonly long[] Value={ 1L,1L,3L,9L,7L,2L,2L,2L,1L,3L,6L,9L,3L,8L,7L,8L,2L,5L,9L,8L,0L,5L,4L,7L,8L,7L,7L,9L,6L,7L,2L,9L,4L,9L,2L,8L,7L,4L,8L,9L,3L,7L,7L,9L,3L,3L,4L,4L,3L,6L,4L,2L,7L,1L,1L,0L,8L,2L,0L,9L,5L,7L,1L,1L,1L,9L,0L,2L,1L,5L,2L,7L,7L,9L,1L,7L,5L,4L,1L,5L,3L,1L,7L,8L,5L,3L,4L,6L,7L,3L,3L,1L,4L,5L,5L,9L,7L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011318Inst : IEnumerable<long>
{
public static readonly long[] Value=A011318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011318.Bytes);
public long this[int i]=>Value[i];

public static A011318Inst Instance=new A011318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011319
{
public static readonly long[] Value={ 1L,1L,3L,2L,2L,9L,3L,6L,2L,5L,3L,4L,0L,5L,3L,6L,5L,8L,7L,9L,9L,5L,2L,5L,8L,5L,5L,9L,8L,7L,7L,5L,8L,7L,8L,5L,0L,1L,7L,6L,6L,9L,3L,8L,4L,9L,7L,7L,4L,9L,2L,6L,9L,6L,0L,1L,4L,8L,8L,4L,3L,4L,1L,6L,9L,7L,4L,5L,0L,1L,7L,7L,8L,6L,8L,7L,1L,2L,1L,9L,1L,9L,2L,9L,9L,5L,1L,9L,4L,6L,9L,4L,1L,8L,2L,6L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011319Inst : IEnumerable<long>
{
public static readonly long[] Value=A011319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011319.Bytes);
public long this[int i]=>Value[i];

public static A011319Inst Instance=new A011319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011320
{
public static readonly long[] Value={ 1L,5L,3L,3L,4L,0L,6L,2L,3L,7L,0L,1L,6L,3L,8L,7L,4L,7L,7L,5L,2L,7L,8L,3L,1L,3L,2L,5L,2L,8L,0L,1L,7L,4L,0L,5L,9L,3L,9L,0L,9L,6L,2L,0L,7L,4L,7L,1L,8L,1L,7L,4L,6L,7L,8L,9L,6L,1L,2L,1L,6L,3L,4L,8L,6L,0L,6L,5L,5L,8L,9L,2L,1L,5L,0L,9L,4L,8L,8L,4L,5L,8L,4L,2L,1L,0L,5L,2L,2L,3L,3L,7L,0L,8L,4L,0L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011320Inst : IEnumerable<long>
{
public static readonly long[] Value=A011320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011320.Bytes);
public long this[int i]=>Value[i];

public static A011320Inst Instance=new A011320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011321
{
public static readonly long[] Value={ 1L,4L,4L,2L,5L,6L,2L,9L,1L,9L,4L,4L,2L,9L,7L,7L,7L,3L,0L,8L,7L,9L,4L,4L,0L,7L,6L,5L,7L,4L,1L,9L,4L,9L,7L,4L,0L,9L,4L,2L,3L,0L,0L,3L,3L,6L,7L,5L,1L,4L,9L,1L,2L,7L,7L,8L,7L,2L,0L,8L,1L,7L,6L,2L,0L,7L,6L,0L,4L,4L,0L,1L,3L,6L,0L,0L,6L,5L,6L,0L,3L,4L,3L,5L,8L,5L,3L,6L,2L,5L,0L,9L,9L,9L,1L,6L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011321Inst : IEnumerable<long>
{
public static readonly long[] Value=A011321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011321.Bytes);
public long this[int i]=>Value[i];

public static A011321Inst Instance=new A011321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011322
{
public static readonly long[] Value={ 1L,3L,7L,7L,9L,8L,0L,0L,1L,5L,1L,3L,6L,6L,2L,8L,0L,8L,9L,8L,7L,7L,0L,0L,1L,9L,0L,0L,1L,6L,7L,7L,4L,9L,4L,8L,4L,7L,2L,6L,0L,2L,2L,1L,1L,4L,4L,0L,7L,0L,9L,7L,2L,5L,0L,9L,3L,9L,4L,8L,3L,5L,3L,0L,5L,4L,4L,2L,8L,1L,5L,8L,3L,2L,6L,1L,6L,1L,7L,0L,6L,6L,6L,6L,6L,5L,4L,9L,3L,7L,8L,5L,5L,7L,9L,8L,6L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011322Inst : IEnumerable<long>
{
public static readonly long[] Value=A011322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011322.Bytes);
public long this[int i]=>Value[i];

public static A011322Inst Instance=new A011322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011323
{
public static readonly long[] Value={ 1L,3L,2L,9L,7L,5L,4L,5L,4L,5L,6L,3L,9L,7L,8L,5L,9L,7L,2L,9L,0L,5L,2L,7L,3L,8L,7L,5L,1L,4L,8L,8L,1L,3L,1L,7L,9L,4L,2L,7L,0L,8L,7L,5L,0L,0L,4L,6L,4L,7L,8L,2L,0L,2L,0L,8L,3L,1L,0L,1L,5L,9L,2L,9L,8L,7L,3L,8L,6L,4L,5L,4L,2L,5L,5L,2L,4L,3L,9L,5L,3L,0L,2L,7L,3L,6L,8L,5L,5L,4L,0L,6L,9L,6L,1L,1L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011323Inst : IEnumerable<long>
{
public static readonly long[] Value=A011323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011323.Bytes);
public long this[int i]=>Value[i];

public static A011323Inst Instance=new A011323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011324
{
public static readonly long[] Value={ 1L,2L,9L,2L,3L,9L,2L,2L,2L,0L,7L,8L,0L,8L,3L,1L,8L,4L,1L,5L,1L,0L,9L,1L,3L,1L,9L,8L,8L,5L,6L,6L,8L,7L,1L,6L,0L,6L,2L,1L,0L,6L,2L,9L,6L,4L,6L,7L,2L,7L,7L,5L,1L,4L,8L,3L,4L,7L,4L,5L,3L,0L,6L,5L,5L,6L,0L,7L,4L,5L,6L,2L,4L,3L,3L,7L,7L,2L,1L,9L,8L,1L,1L,4L,0L,6L,9L,9L,0L,0L,6L,8L,0L,1L,2L,4L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011324Inst : IEnumerable<long>
{
public static readonly long[] Value=A011324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011324.Bytes);
public long this[int i]=>Value[i];

public static A011324Inst Instance=new A011324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011325
{
public static readonly long[] Value={ 1L,2L,6L,2L,6L,0L,5L,2L,1L,1L,2L,1L,9L,6L,5L,3L,0L,3L,3L,3L,6L,6L,0L,3L,2L,0L,3L,1L,2L,0L,8L,0L,9L,8L,7L,1L,8L,7L,6L,3L,3L,2L,1L,3L,4L,0L,1L,2L,4L,9L,4L,3L,1L,4L,3L,6L,3L,6L,4L,4L,3L,6L,6L,1L,2L,7L,1L,9L,2L,1L,1L,3L,4L,1L,0L,3L,0L,0L,5L,9L,3L,3L,9L,6L,7L,3L,1L,4L,1L,0L,2L,0L,8L,3L,9L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011325Inst : IEnumerable<long>
{
public static readonly long[] Value=A011325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011325.Bytes);
public long this[int i]=>Value[i];

public static A011325Inst Instance=new A011325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011342
{
public static readonly long[] Value={ 1L,2L,2L,5L,0L,7L,7L,8L,7L,0L,7L,9L,2L,7L,4L,0L,0L,5L,8L,3L,7L,8L,9L,8L,7L,9L,2L,3L,6L,9L,3L,9L,3L,8L,2L,4L,7L,5L,6L,9L,6L,3L,7L,1L,0L,6L,9L,2L,4L,2L,0L,2L,3L,0L,0L,9L,2L,6L,3L,7L,5L,9L,4L,4L,7L,8L,6L,4L,3L,5L,9L,1L,0L,0L,4L,5L,3L,5L,2L,1L,2L,3L,4L,0L,7L,7L,1L,0L,7L,5L,6L,0L,2L,4L,2L,1L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011342Inst : IEnumerable<long>
{
public static readonly long[] Value=A011342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011342.Bytes);
public long this[int i]=>Value[i];

public static A011342Inst Instance=new A011342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011343
{
public static readonly long[] Value={ 1L,2L,0L,7L,4L,4L,2L,0L,2L,7L,4L,1L,8L,4L,1L,1L,3L,1L,0L,4L,0L,7L,4L,6L,9L,8L,7L,6L,1L,6L,8L,9L,3L,2L,9L,6L,3L,9L,3L,1L,9L,1L,2L,6L,5L,7L,7L,8L,4L,4L,2L,2L,1L,5L,7L,0L,0L,3L,9L,1L,3L,4L,1L,7L,4L,3L,4L,8L,2L,0L,7L,9L,0L,2L,4L,3L,5L,8L,1L,9L,7L,1L,1L,7L,1L,9L,3L,9L,5L,2L,5L,5L,0L,1L,7L,9L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011343Inst : IEnumerable<long>
{
public static readonly long[] Value=A011343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011343.Bytes);
public long this[int i]=>Value[i];

public static A011343Inst Instance=new A011343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011344
{
public static readonly long[] Value={ 1L,1L,9L,2L,3L,6L,3L,1L,2L,2L,6L,0L,2L,4L,5L,8L,6L,7L,7L,6L,4L,3L,7L,1L,7L,0L,0L,9L,3L,4L,7L,4L,7L,5L,9L,9L,6L,6L,6L,3L,1L,5L,0L,5L,2L,1L,1L,6L,6L,6L,5L,0L,6L,6L,5L,0L,5L,8L,0L,6L,5L,3L,1L,5L,7L,0L,4L,7L,8L,8L,9L,1L,6L,8L,7L,3L,5L,0L,8L,1L,7L,1L,6L,6L,1L,7L,2L,5L,8L,2L,9L,5L,0L,4L,4L,0L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011344Inst : IEnumerable<long>
{
public static readonly long[] Value=A011344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011344.Bytes);
public long this[int i]=>Value[i];

public static A011344Inst Instance=new A011344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011345
{
public static readonly long[] Value={ 1L,1L,7L,9L,3L,2L,3L,6L,3L,4L,5L,7L,2L,9L,9L,4L,6L,1L,4L,0L,6L,2L,1L,2L,1L,3L,2L,3L,5L,8L,2L,2L,1L,1L,5L,2L,5L,0L,4L,6L,6L,7L,7L,9L,6L,7L,6L,0L,0L,1L,4L,1L,4L,8L,6L,0L,1L,0L,1L,1L,9L,2L,4L,8L,5L,3L,0L,6L,5L,7L,5L,5L,5L,0L,0L,8L,7L,9L,9L,7L,5L,7L,9L,4L,2L,2L,7L,7L,5L,8L,4L,3L,0L,8L,5L,6L,9L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011345Inst : IEnumerable<long>
{
public static readonly long[] Value=A011345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011345.Bytes);
public long this[int i]=>Value[i];

public static A011345Inst Instance=new A011345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011346
{
public static readonly long[] Value={ 1L,1L,6L,7L,9L,3L,6L,6L,7L,5L,1L,4L,1L,6L,5L,1L,5L,8L,4L,9L,3L,3L,6L,4L,5L,7L,4L,2L,1L,0L,7L,0L,0L,8L,9L,4L,4L,5L,2L,3L,4L,4L,7L,5L,5L,7L,7L,5L,8L,3L,6L,9L,1L,9L,6L,7L,5L,5L,1L,1L,8L,5L,9L,4L,2L,3L,4L,0L,5L,1L,6L,2L,2L,1L,6L,9L,3L,6L,0L,3L,3L,1L,3L,4L,9L,7L,8L,7L,5L,8L,1L,1L,9L,6L,6L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011346Inst : IEnumerable<long>
{
public static readonly long[] Value=A011346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011346.Bytes);
public long this[int i]=>Value[i];

public static A011346Inst Instance=new A011346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011347
{
public static readonly long[] Value={ 1L,1L,5L,7L,9L,0L,7L,2L,6L,7L,5L,2L,8L,4L,8L,4L,1L,6L,6L,8L,7L,2L,1L,7L,5L,1L,0L,3L,4L,9L,8L,9L,3L,0L,4L,4L,1L,5L,8L,3L,7L,0L,4L,0L,3L,5L,8L,2L,9L,9L,6L,0L,4L,7L,9L,4L,2L,5L,0L,1L,1L,7L,0L,2L,0L,5L,2L,8L,4L,8L,6L,7L,1L,3L,4L,6L,5L,2L,6L,0L,2L,5L,1L,8L,1L,1L,5L,7L,1L,1L,8L,9L,8L,4L,6L,7L,0L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011347Inst : IEnumerable<long>
{
public static readonly long[] Value=A011347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011347.Bytes);
public long this[int i]=>Value[i];

public static A011347Inst Instance=new A011347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011348
{
public static readonly long[] Value={ 1L,1L,4L,9L,0L,0L,6L,6L,1L,2L,8L,8L,5L,9L,1L,2L,8L,3L,3L,8L,0L,6L,6L,0L,7L,9L,9L,2L,5L,3L,5L,5L,8L,5L,7L,3L,6L,7L,0L,4L,0L,1L,9L,2L,7L,3L,6L,4L,4L,0L,1L,7L,9L,7L,7L,1L,2L,0L,3L,9L,0L,8L,9L,6L,1L,5L,9L,3L,7L,4L,0L,1L,0L,4L,1L,3L,2L,0L,9L,3L,5L,0L,7L,9L,4L,1L,5L,2L,4L,3L,6L,6L,0L,7L,8L,7L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011348Inst : IEnumerable<long>
{
public static readonly long[] Value=A011348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011348.Bytes);
public long this[int i]=>Value[i];

public static A011348Inst Instance=new A011348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011349
{
public static readonly long[] Value={ 1L,1L,4L,1L,0L,5L,4L,5L,3L,6L,0L,8L,3L,8L,2L,2L,6L,4L,0L,5L,7L,2L,8L,1L,7L,9L,2L,7L,0L,8L,4L,9L,6L,1L,7L,8L,6L,7L,0L,8L,0L,3L,2L,7L,3L,1L,3L,1L,1L,6L,7L,5L,2L,3L,6L,2L,6L,2L,7L,5L,0L,5L,8L,6L,2L,2L,1L,0L,6L,6L,4L,5L,4L,5L,0L,7L,9L,2L,9L,7L,0L,5L,7L,9L,4L,2L,4L,4L,3L,9L,0L,5L,5L,0L,4L,8L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011349Inst : IEnumerable<long>
{
public static readonly long[] Value=A011349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011349.Bytes);
public long this[int i]=>Value[i];

public static A011349Inst Instance=new A011349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011350
{
public static readonly long[] Value={ 1L,5L,7L,0L,4L,1L,7L,8L,0L,2L,4L,7L,5L,0L,1L,9L,7L,3L,5L,3L,1L,0L,5L,2L,9L,6L,6L,7L,0L,0L,2L,6L,2L,3L,3L,4L,9L,4L,5L,8L,3L,7L,7L,7L,7L,6L,6L,5L,8L,1L,3L,5L,3L,3L,7L,8L,9L,6L,2L,8L,9L,9L,3L,8L,4L,0L,0L,7L,4L,6L,5L,8L,5L,2L,9L,2L,6L,0L,5L,4L,2L,2L,2L,1L,3L,4L,3L,4L,6L,9L,0L,4L,8L,9L,0L,6L,6L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011350Inst : IEnumerable<long>
{
public static readonly long[] Value=A011350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011350.Bytes);
public long this[int i]=>Value[i];

public static A011350Inst Instance=new A011350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011351
{
public static readonly long[] Value={ 1L,4L,7L,2L,3L,5L,6L,7L,0L,0L,1L,8L,0L,3L,4L,6L,9L,2L,3L,7L,1L,2L,7L,9L,0L,0L,0L,0L,9L,7L,4L,0L,2L,4L,2L,3L,2L,7L,9L,6L,1L,6L,6L,4L,0L,7L,5L,4L,6L,7L,7L,5L,7L,6L,3L,4L,6L,8L,2L,8L,2L,2L,1L,4L,8L,3L,9L,3L,8L,8L,2L,6L,5L,5L,3L,8L,1L,2L,3L,5L,3L,5L,0L,2L,8L,0L,8L,3L,0L,3L,4L,9L,8L,6L,5L,0L,1L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011351Inst : IEnumerable<long>
{
public static readonly long[] Value=A011351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011351.Bytes);
public long this[int i]=>Value[i];

public static A011351Inst Instance=new A011351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011352
{
public static readonly long[] Value={ 1L,4L,0L,2L,8L,5L,0L,5L,5L,2L,0L,0L,6L,6L,7L,4L,1L,6L,5L,8L,6L,6L,2L,3L,7L,8L,5L,2L,7L,5L,1L,5L,1L,4L,4L,0L,4L,8L,3L,0L,8L,1L,1L,7L,4L,6L,4L,0L,8L,9L,6L,8L,1L,5L,2L,6L,2L,0L,0L,9L,5L,1L,2L,6L,0L,5L,5L,2L,8L,4L,7L,1L,5L,6L,9L,4L,8L,3L,0L,4L,3L,3L,1L,0L,9L,4L,7L,4L,5L,3L,0L,3L,6L,4L,1L,1L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011352Inst : IEnumerable<long>
{
public static readonly long[] Value=A011352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011352.Bytes);
public long this[int i]=>Value[i];

public static A011352Inst Instance=new A011352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011353
{
public static readonly long[] Value={ 1L,3L,5L,1L,0L,6L,6L,7L,5L,1L,6L,0L,1L,7L,7L,0L,8L,3L,1L,3L,4L,6L,1L,9L,8L,1L,5L,4L,0L,3L,1L,1L,0L,4L,1L,6L,7L,9L,4L,8L,9L,0L,0L,4L,0L,3L,4L,5L,0L,6L,8L,2L,0L,2L,8L,2L,8L,4L,6L,7L,7L,7L,5L,0L,4L,1L,8L,4L,7L,7L,9L,4L,6L,6L,6L,7L,4L,8L,8L,8L,3L,9L,8L,8L,3L,4L,0L,1L,8L,0L,2L,5L,7L,4L,3L,3L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011353Inst : IEnumerable<long>
{
public static readonly long[] Value=A011353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011353.Bytes);
public long this[int i]=>Value[i];

public static A011353Inst Instance=new A011353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011354
{
public static readonly long[] Value={ 1L,3L,1L,1L,0L,1L,9L,4L,2L,3L,0L,3L,9L,7L,4L,9L,9L,2L,5L,2L,0L,4L,5L,5L,6L,4L,0L,7L,0L,5L,2L,8L,0L,4L,3L,3L,0L,7L,3L,2L,0L,1L,6L,4L,3L,4L,7L,8L,3L,5L,3L,5L,3L,9L,3L,1L,0L,6L,1L,2L,6L,9L,1L,9L,7L,0L,2L,3L,3L,4L,7L,2L,8L,5L,6L,3L,4L,4L,0L,8L,9L,2L,6L,0L,8L,6L,3L,3L,9L,8L,7L,4L,7L,2L,3L,7L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011354Inst : IEnumerable<long>
{
public static readonly long[] Value=A011354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011354.Bytes);
public long this[int i]=>Value[i];

public static A011354Inst Instance=new A011354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011355
{
public static readonly long[] Value={ 1L,2L,7L,9L,1L,3L,7L,9L,5L,9L,5L,1L,2L,4L,0L,0L,9L,7L,0L,5L,8L,2L,8L,5L,3L,4L,9L,4L,1L,9L,1L,7L,7L,2L,9L,7L,7L,9L,0L,2L,2L,5L,7L,3L,4L,8L,1L,3L,1L,0L,4L,2L,9L,2L,8L,4L,9L,4L,7L,5L,1L,2L,9L,8L,9L,4L,7L,9L,4L,6L,4L,9L,8L,1L,0L,6L,0L,8L,5L,6L,8L,5L,3L,5L,7L,6L,8L,6L,2L,4L,8L,3L,5L,2L,0L,5L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011355Inst : IEnumerable<long>
{
public static readonly long[] Value=A011355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011355.Bytes);
public long this[int i]=>Value[i];

public static A011355Inst Instance=new A011355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011356
{
public static readonly long[] Value={ 1L,2L,5L,3L,1L,6L,3L,1L,1L,8L,8L,6L,1L,6L,3L,4L,7L,6L,2L,2L,8L,6L,4L,3L,4L,9L,2L,6L,5L,9L,1L,1L,8L,5L,4L,4L,4L,4L,5L,2L,4L,7L,7L,7L,8L,4L,3L,1L,2L,4L,6L,7L,9L,7L,6L,5L,2L,9L,6L,2L,1L,7L,3L,3L,6L,3L,1L,5L,0L,9L,9L,8L,0L,7L,9L,6L,2L,8L,0L,1L,7L,5L,0L,2L,2L,9L,5L,3L,7L,8L,2L,8L,9L,8L,3L,3L,1L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011356Inst : IEnumerable<long>
{
public static readonly long[] Value=A011356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011356.Bytes);
public long this[int i]=>Value[i];

public static A011356Inst Instance=new A011356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011357
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,9L,6L,8L,1L,8L,6L,1L,2L,2L,4L,8L,4L,5L,7L,0L,7L,0L,7L,4L,0L,0L,5L,3L,1L,8L,3L,7L,4L,6L,1L,2L,0L,2L,4L,4L,7L,4L,3L,6L,0L,9L,2L,2L,9L,2L,7L,4L,3L,1L,7L,6L,2L,8L,5L,9L,5L,1L,4L,7L,4L,7L,8L,7L,5L,3L,4L,8L,9L,9L,0L,1L,4L,3L,7L,6L,4L,9L,1L,3L,2L,2L,3L,7L,8L,4L,6L,5L,0L,7L,7L,4L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011357Inst : IEnumerable<long>
{
public static readonly long[] Value=A011357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011357.Bytes);
public long this[int i]=>Value[i];

public static A011357Inst Instance=new A011357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011358
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,0L,7L,0L,6L,2L,8L,5L,2L,5L,0L,6L,6L,0L,8L,7L,7L,8L,0L,9L,4L,6L,5L,1L,8L,6L,8L,6L,4L,7L,5L,6L,4L,9L,7L,3L,4L,4L,8L,2L,6L,1L,4L,8L,4L,6L,6L,7L,3L,5L,1L,8L,7L,4L,2L,5L,5L,8L,2L,4L,8L,8L,6L,0L,8L,4L,5L,6L,9L,7L,5L,5L,8L,6L,5L,2L,1L,2L,8L,1L,6L,1L,1L,8L,0L,7L,5L,8L,6L,9L,9L,7L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011358Inst : IEnumerable<long>
{
public static readonly long[] Value=A011358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011358.Bytes);
public long this[int i]=>Value[i];

public static A011358Inst Instance=new A011358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011359
{
public static readonly long[] Value={ 1L,1L,9L,7L,8L,6L,0L,0L,5L,8L,2L,6L,9L,6L,3L,6L,2L,4L,4L,4L,2L,7L,1L,6L,2L,8L,8L,1L,8L,1L,0L,0L,7L,5L,4L,6L,4L,3L,8L,0L,9L,0L,1L,7L,3L,8L,8L,9L,2L,8L,4L,1L,6L,9L,1L,6L,4L,4L,6L,5L,0L,9L,8L,7L,2L,9L,8L,3L,6L,4L,8L,5L,9L,0L,6L,9L,6L,4L,8L,1L,0L,3L,9L,3L,8L,5L,3L,7L,9L,5L,5L,0L,3L,2L,6L,3L,2L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011359Inst : IEnumerable<long>
{
public static readonly long[] Value=A011359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011359.Bytes);
public long this[int i]=>Value[i];

public static A011359Inst Instance=new A011359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011360
{
public static readonly long[] Value={ 1L,1L,8L,4L,4L,1L,9L,9L,2L,2L,1L,5L,8L,8L,0L,6L,8L,8L,7L,1L,7L,4L,6L,8L,9L,9L,8L,5L,2L,2L,0L,2L,0L,7L,9L,4L,3L,4L,0L,9L,8L,2L,9L,2L,2L,5L,0L,3L,6L,2L,6L,9L,4L,3L,9L,7L,7L,1L,4L,0L,0L,1L,5L,1L,9L,9L,7L,5L,8L,8L,1L,4L,9L,2L,9L,5L,9L,4L,3L,8L,1L,1L,8L,1L,2L,0L,1L,0L,1L,8L,8L,6L,2L,1L,2L,3L,0L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011360Inst : IEnumerable<long>
{
public static readonly long[] Value=A011360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011360.Bytes);
public long this[int i]=>Value[i];

public static A011360Inst Instance=new A011360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011361
{
public static readonly long[] Value={ 1L,1L,7L,2L,6L,8L,6L,2L,6L,5L,6L,1L,5L,2L,6L,3L,2L,8L,6L,9L,6L,7L,7L,7L,4L,7L,5L,0L,2L,9L,3L,6L,3L,4L,5L,5L,9L,1L,8L,8L,3L,6L,6L,4L,1L,4L,9L,5L,7L,7L,0L,4L,9L,6L,6L,5L,8L,5L,7L,2L,3L,5L,0L,3L,4L,5L,0L,1L,4L,1L,1L,1L,8L,2L,3L,2L,7L,7L,2L,1L,6L,8L,3L,8L,0L,4L,9L,5L,2L,5L,2L,4L,6L,0L,4L,8L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011361Inst : IEnumerable<long>
{
public static readonly long[] Value=A011361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011361.Bytes);
public long this[int i]=>Value[i];

public static A011361Inst Instance=new A011361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011362
{
public static readonly long[] Value={ 1L,1L,6L,2L,3L,5L,3L,9L,7L,0L,0L,1L,1L,6L,1L,8L,6L,3L,4L,2L,7L,2L,8L,5L,5L,4L,3L,7L,2L,1L,6L,2L,2L,8L,4L,5L,9L,6L,2L,9L,4L,7L,0L,5L,4L,7L,2L,4L,0L,6L,9L,3L,6L,6L,3L,1L,1L,2L,5L,8L,5L,3L,4L,0L,9L,4L,2L,7L,0L,7L,1L,0L,2L,1L,3L,8L,5L,9L,5L,6L,6L,3L,7L,3L,0L,8L,9L,1L,6L,7L,8L,8L,8L,6L,2L,0L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011362Inst : IEnumerable<long>
{
public static readonly long[] Value=A011362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011362.Bytes);
public long this[int i]=>Value[i];

public static A011362Inst Instance=new A011362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011363
{
public static readonly long[] Value={ 1L,1L,5L,3L,1L,8L,6L,4L,7L,4L,3L,9L,3L,2L,9L,9L,4L,6L,9L,6L,4L,6L,2L,2L,6L,6L,0L,2L,8L,2L,5L,1L,4L,1L,9L,2L,8L,1L,6L,8L,3L,6L,2L,6L,1L,6L,7L,5L,8L,6L,7L,1L,3L,8L,3L,6L,5L,6L,8L,2L,4L,4L,8L,0L,8L,3L,6L,5L,8L,6L,0L,9L,6L,5L,8L,1L,5L,7L,2L,7L,6L,5L,5L,6L,1L,7L,5L,3L,4L,7L,0L,9L,7L,5L,1L,2L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011363Inst : IEnumerable<long>
{
public static readonly long[] Value=A011363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011363.Bytes);
public long this[int i]=>Value[i];

public static A011363Inst Instance=new A011363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011364
{
public static readonly long[] Value={ 1L,1L,4L,4L,9L,9L,7L,5L,6L,4L,6L,4L,3L,5L,8L,9L,0L,6L,7L,4L,0L,4L,4L,9L,1L,6L,6L,5L,5L,2L,5L,5L,9L,6L,2L,6L,8L,5L,6L,9L,2L,7L,2L,6L,0L,3L,7L,4L,9L,1L,8L,3L,7L,7L,9L,2L,3L,1L,1L,3L,8L,7L,0L,2L,4L,6L,4L,4L,3L,6L,6L,5L,9L,7L,0L,5L,9L,3L,9L,6L,8L,1L,0L,1L,9L,3L,4L,3L,3L,5L,2L,9L,3L,0L,1L,2L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011364Inst : IEnumerable<long>
{
public static readonly long[] Value=A011364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011364.Bytes);
public long this[int i]=>Value[i];

public static A011364Inst Instance=new A011364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011365
{
public static readonly long[] Value={ 1L,-2L,-3L,-11L,-49L,-244L,-1301L,-7265L,-41945L,-248357L,-1499838L,-9202478L,-57204263L,-359491066L,-2280171089L,-14578108497L,-93850280001L,-607856133804L,-3958143058643L,-25897182540675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011365Inst : IEnumerable<long>
{
public static readonly long[] Value=A011365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011365.Bytes);
public long this[int i]=>Value[i];

public static A011365Inst Instance=new A011365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011366
{
public static readonly long[] Value={ 1L,4L,8L,5L,9L,9L,4L,2L,8L,9L,1L,3L,6L,9L,4L,8L,4L,2L,4L,7L,9L,9L,8L,5L,3L,2L,8L,6L,7L,1L,4L,5L,9L,2L,6L,0L,6L,3L,2L,3L,7L,1L,1L,3L,5L,9L,4L,3L,7L,1L,0L,9L,7L,3L,3L,3L,5L,6L,5L,0L,3L,1L,9L,7L,1L,5L,0L,7L,9L,0L,8L,5L,8L,3L,4L,0L,5L,5L,6L,2L,0L,0L,4L,9L,6L,3L,9L,7L,9L,9L,4L,0L,9L,1L,2L,3L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011366Inst : IEnumerable<long>
{
public static readonly long[] Value=A011366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011366.Bytes);
public long this[int i]=>Value[i];

public static A011366Inst Instance=new A011366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011367
{
public static readonly long[] Value={ 1L,2L,8L,29L,107L,393L,1445L,5312L,19528L,71789L,263911L,970191L,3566621L,13111630L,48201040L,177196905L,651412151L,2394724617L,8803498649L,32363465892L,118974735648L,437375519969L,1607882080395L,5910904169119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011367Inst : IEnumerable<long>
{
public static readonly long[] Value=A011367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011367.Bytes);
public long this[int i]=>Value[i];

public static A011367Inst Instance=new A011367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011368
{
public static readonly long[] Value={ 1L,3L,6L,0L,7L,9L,0L,0L,0L,0L,1L,7L,4L,3L,7L,6L,9L,6L,4L,2L,5L,5L,6L,8L,0L,3L,7L,5L,3L,2L,4L,8L,1L,3L,0L,9L,8L,8L,7L,0L,1L,2L,6L,6L,9L,8L,7L,3L,9L,3L,2L,7L,8L,6L,3L,6L,6L,4L,7L,9L,9L,7L,1L,4L,9L,6L,6L,6L,5L,3L,2L,7L,6L,0L,8L,8L,7L,4L,6L,8L,2L,5L,7L,2L,1L,7L,6L,2L,8L,4L,1L,2L,2L,9L,5L,4L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011368Inst : IEnumerable<long>
{
public static readonly long[] Value=A011368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011368.Bytes);
public long this[int i]=>Value[i];

public static A011368Inst Instance=new A011368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011369
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,1L,6L,14L,1L,22L,56L,1L,90L,234L,1L,378L,988L,1L,1598L,4182L,1L,6766L,17712L,1L,28658L,75026L,1L,121394L,317812L,1L,514230L,1346270L,1L,2178310L,5702888L,1L,9227466L,24157818L,1L,39088170L,102334156L,1L,165580142L,433494438L,1L,701408734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011369Inst : IEnumerable<long>
{
public static readonly long[] Value=A011369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011369.Bytes);
public long this[int i]=>Value[i];

public static A011369Inst Instance=new A011369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011370
{
public static readonly long[] Value={ 1L,2L,8L,6L,6L,6L,4L,8L,9L,8L,0L,0L,9L,4L,3L,1L,7L,9L,0L,4L,4L,2L,6L,6L,4L,3L,5L,3L,5L,7L,7L,2L,4L,8L,3L,9L,0L,9L,5L,2L,4L,6L,1L,1L,2L,4L,3L,2L,6L,8L,2L,7L,9L,5L,5L,9L,8L,0L,5L,8L,5L,7L,1L,1L,8L,7L,4L,9L,4L,6L,4L,4L,8L,4L,7L,9L,1L,0L,1L,1L,4L,0L,7L,9L,5L,3L,6L,6L,5L,5L,6L,5L,9L,5L,9L,5L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011370Inst : IEnumerable<long>
{
public static readonly long[] Value=A011370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011370.Bytes);
public long this[int i]=>Value[i];

public static A011370Inst Instance=new A011370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011371
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,3L,4L,4L,7L,7L,8L,8L,10L,10L,11L,11L,15L,15L,16L,16L,18L,18L,19L,19L,22L,22L,23L,23L,25L,25L,26L,26L,31L,31L,32L,32L,34L,34L,35L,35L,38L,38L,39L,39L,41L,41L,42L,42L,46L,46L,47L,47L,49L,49L,50L,50L,53L,53L,54L,54L,56L,56L,57L,57L,63L,63L,64L,64L,66L,66L,67L,67L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011371Inst : IEnumerable<long>
{
public static readonly long[] Value=A011371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011371.Bytes);
public long this[int i]=>Value[i];

public static A011371Inst Instance=new A011371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011372
{
public static readonly long[] Value={ 1L,2L,3L,7L,7L,2L,6L,2L,8L,5L,3L,0L,5L,4L,2L,8L,0L,4L,7L,6L,3L,7L,0L,6L,2L,0L,3L,8L,9L,6L,4L,3L,4L,7L,9L,8L,7L,2L,0L,0L,6L,3L,1L,5L,1L,0L,3L,9L,6L,7L,3L,8L,3L,4L,4L,0L,2L,9L,0L,4L,9L,0L,8L,3L,5L,5L,3L,7L,4L,8L,5L,5L,7L,1L,7L,0L,6L,2L,6L,4L,9L,8L,7L,7L,9L,5L,3L,8L,3L,9L,7L,3L,3L,4L,7L,1L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011372Inst : IEnumerable<long>
{
public static readonly long[] Value=A011372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011372.Bytes);
public long this[int i]=>Value[i];

public static A011372Inst Instance=new A011372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011373
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,1L,3L,3L,2L,5L,4L,2L,5L,6L,4L,8L,7L,4L,5L,8L,6L,8L,11L,6L,6L,9L,11L,11L,12L,8L,11L,9L,13L,12L,11L,12L,14L,10L,12L,16L,17L,14L,16L,18L,15L,21L,13L,12L,18L,18L,17L,17L,17L,16L,22L,21L,16L,24L,20L,16L,19L,26L,23L,20L,25L,19L,26L,15L,23L,23L,22L,25L,27L,24L,23L,23L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011373Inst : IEnumerable<long>
{
public static readonly long[] Value=A011373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011373.Bytes);
public long this[int i]=>Value[i];

public static A011373Inst Instance=new A011373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011374
{
public static readonly long[] Value={ 1L,2L,0L,3L,0L,2L,5L,0L,3L,6L,0L,8L,2L,1L,1L,6L,6L,5L,0L,9L,5L,7L,1L,2L,5L,4L,4L,2L,5L,0L,3L,7L,2L,7L,4L,5L,1L,0L,1L,5L,5L,4L,7L,6L,9L,4L,1L,9L,0L,5L,0L,8L,5L,0L,8L,7L,5L,9L,9L,1L,5L,7L,4L,9L,7L,9L,7L,3L,2L,9L,2L,4L,1L,2L,9L,0L,5L,6L,0L,8L,8L,9L,6L,7L,1L,9L,0L,6L,1L,4L,0L,6L,5L,8L,6L,6L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011374Inst : IEnumerable<long>
{
public static readonly long[] Value=A011374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011374.Bytes);
public long this[int i]=>Value[i];

public static A011374Inst Instance=new A011374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011375
{
public static readonly long[] Value={ 3L,3L,4L,4L,5L,5L,5L,6L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011375Inst : IEnumerable<long>
{
public static readonly long[] Value=A011375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011375.Bytes);
public long this[int i]=>Value[i];

public static A011375Inst Instance=new A011375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011376
{
public static readonly long[] Value={ 1L,1L,7L,7L,1L,4L,6L,6L,9L,3L,9L,0L,8L,9L,1L,7L,6L,8L,6L,9L,2L,5L,6L,3L,0L,3L,8L,9L,8L,4L,2L,6L,0L,3L,1L,9L,8L,2L,5L,9L,4L,3L,3L,7L,4L,2L,1L,4L,6L,1L,1L,6L,1L,7L,7L,9L,5L,0L,3L,2L,8L,6L,2L,9L,2L,9L,9L,6L,1L,0L,7L,7L,3L,7L,4L,0L,2L,1L,0L,6L,2L,4L,8L,4L,1L,1L,3L,1L,4L,6L,1L,7L,6L,0L,3L,6L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011376Inst : IEnumerable<long>
{
public static readonly long[] Value=A011376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011376.Bytes);
public long this[int i]=>Value[i];

public static A011376Inst Instance=new A011376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011377
{
public static readonly long[] Value={ 1L,3L,8L,18L,39L,81L,166L,336L,677L,1359L,2724L,5454L,10915L,21837L,43682L,87372L,174753L,349515L,699040L,1398090L,2796191L,5592393L,11184798L,22369608L,44739229L,89478471L,178956956L,357913926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011377Inst : IEnumerable<long>
{
public static readonly long[] Value=A011377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011377.Bytes);
public long this[int i]=>Value[i];

public static A011377Inst Instance=new A011377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011378
{
public static readonly long[] Value={ 1L,1L,5L,7L,1L,1L,0L,2L,3L,7L,2L,8L,2L,7L,1L,9L,8L,2L,5L,5L,1L,4L,2L,9L,1L,1L,2L,3L,6L,2L,9L,6L,9L,0L,0L,2L,0L,5L,4L,8L,3L,6L,6L,6L,3L,3L,9L,5L,1L,4L,3L,5L,8L,3L,4L,5L,5L,1L,3L,7L,1L,3L,3L,1L,4L,7L,1L,2L,3L,6L,7L,3L,1L,2L,8L,6L,7L,9L,1L,6L,6L,3L,0L,1L,9L,1L,4L,0L,4L,3L,8L,6L,4L,7L,4L,5L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011378Inst : IEnumerable<long>
{
public static readonly long[] Value=A011378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011378.Bytes);
public long this[int i]=>Value[i];

public static A011378Inst Instance=new A011378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011379
{
public static readonly long[] Value={ 0L,2L,12L,36L,80L,150L,252L,392L,576L,810L,1100L,1452L,1872L,2366L,2940L,3600L,4352L,5202L,6156L,7220L,8400L,9702L,11132L,12696L,14400L,16250L,18252L,20412L,22736L,25230L,27900L,30752L,33792L,37026L,40460L,44100L,47952L,52022L,56316L,60840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011379Inst : IEnumerable<long>
{
public static readonly long[] Value=A011379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011379.Bytes);
public long this[int i]=>Value[i];

public static A011379Inst Instance=new A011379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011380
{
public static readonly long[] Value={ 1L,6L,0L,3L,5L,2L,1L,6L,2L,1L,5L,1L,2L,5L,4L,9L,2L,8L,2L,9L,8L,5L,4L,6L,4L,7L,9L,0L,7L,0L,2L,3L,1L,7L,5L,8L,6L,5L,3L,5L,1L,3L,4L,8L,6L,6L,5L,4L,4L,9L,7L,1L,0L,0L,9L,8L,5L,9L,8L,3L,0L,2L,4L,1L,2L,5L,1L,1L,1L,7L,4L,0L,4L,2L,5L,5L,5L,0L,6L,2L,4L,1L,7L,8L,4L,7L,7L,5L,0L,4L,0L,7L,7L,9L,1L,4L,7L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011380Inst : IEnumerable<long>
{
public static readonly long[] Value=A011380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011380.Bytes);
public long this[int i]=>Value[i];

public static A011380Inst Instance=new A011380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011381
{
public static readonly long[] Value={ 1L,4L,9L,8L,9L,1L,9L,8L,7L,2L,0L,7L,1L,5L,6L,2L,0L,1L,2L,1L,7L,2L,7L,9L,0L,1L,2L,3L,6L,8L,2L,5L,2L,9L,6L,7L,7L,8L,5L,9L,7L,2L,2L,7L,9L,7L,9L,4L,0L,2L,2L,5L,5L,6L,8L,2L,4L,5L,6L,7L,1L,2L,2L,3L,1L,8L,5L,4L,5L,3L,6L,1L,3L,3L,5L,0L,0L,6L,6L,9L,2L,0L,2L,1L,6L,2L,3L,7L,9L,1L,7L,1L,0L,2L,3L,2L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011381Inst : IEnumerable<long>
{
public static readonly long[] Value=A011381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011381.Bytes);
public long this[int i]=>Value[i];

public static A011381Inst Instance=new A011381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011382
{
public static readonly long[] Value={ 1L,4L,2L,4L,9L,7L,1L,2L,9L,2L,6L,4L,7L,3L,0L,4L,7L,7L,8L,6L,3L,1L,3L,0L,7L,3L,3L,0L,5L,4L,9L,5L,1L,0L,0L,6L,8L,9L,8L,6L,8L,0L,5L,4L,5L,1L,7L,5L,1L,1L,8L,3L,1L,1L,6L,1L,1L,0L,4L,1L,0L,2L,8L,8L,0L,2L,1L,4L,8L,8L,1L,6L,0L,9L,4L,5L,8L,9L,4L,7L,6L,5L,1L,2L,4L,3L,1L,7L,3L,6L,7L,9L,1L,2L,8L,8L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011382Inst : IEnumerable<long>
{
public static readonly long[] Value=A011382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011382.Bytes);
public long this[int i]=>Value[i];

public static A011382Inst Instance=new A011382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011383
{
public static readonly long[] Value={ 1L,3L,6L,9L,9L,8L,7L,3L,1L,7L,7L,3L,9L,7L,4L,5L,7L,0L,2L,1L,0L,9L,1L,7L,1L,6L,9L,0L,6L,5L,1L,9L,8L,2L,1L,8L,3L,1L,9L,8L,6L,3L,0L,3L,7L,4L,6L,9L,3L,9L,5L,9L,9L,0L,4L,8L,4L,2L,2L,2L,9L,0L,4L,0L,7L,2L,3L,6L,2L,5L,4L,8L,7L,1L,1L,5L,4L,3L,2L,8L,7L,7L,6L,5L,7L,8L,0L,9L,4L,0L,2L,1L,2L,3L,3L,5L,1L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011383Inst : IEnumerable<long>
{
public static readonly long[] Value=A011383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011383.Bytes);
public long this[int i]=>Value[i];

public static A011383Inst Instance=new A011383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011384
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,3L,1L,6L,7L,4L,8L,8L,8L,5L,1L,9L,1L,9L,0L,6L,4L,3L,2L,5L,6L,8L,8L,6L,0L,2L,1L,2L,0L,7L,5L,2L,6L,0L,0L,9L,7L,6L,3L,0L,6L,0L,7L,9L,4L,6L,8L,4L,6L,2L,9L,5L,7L,8L,4L,6L,7L,2L,9L,4L,2L,3L,2L,4L,2L,5L,3L,6L,0L,6L,5L,4L,6L,5L,6L,3L,3L,1L,3L,2L,3L,7L,6L,8L,9L,4L,3L,5L,9L,3L,7L,2L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011384Inst : IEnumerable<long>
{
public static readonly long[] Value=A011384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011384.Bytes);
public long this[int i]=>Value[i];

public static A011384Inst Instance=new A011384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011385
{
public static readonly long[] Value={ 1L,2L,9L,3L,7L,7L,5L,7L,0L,8L,9L,1L,5L,5L,5L,7L,8L,8L,8L,1L,2L,0L,2L,1L,3L,1L,3L,7L,2L,7L,3L,3L,8L,7L,0L,9L,3L,0L,7L,3L,1L,3L,6L,8L,6L,2L,0L,4L,0L,2L,2L,4L,0L,0L,6L,9L,9L,1L,9L,7L,0L,9L,9L,3L,7L,5L,3L,0L,6L,1L,3L,6L,0L,3L,5L,5L,7L,0L,1L,2L,9L,6L,5L,7L,3L,6L,5L,3L,3L,6L,1L,7L,3L,2L,8L,4L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011385Inst : IEnumerable<long>
{
public static readonly long[] Value=A011385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011385.Bytes);
public long this[int i]=>Value[i];

public static A011385Inst Instance=new A011385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011386
{
public static readonly long[] Value={ 1L,2L,6L,6L,3L,0L,2L,3L,4L,2L,0L,6L,2L,3L,3L,2L,7L,9L,1L,2L,0L,8L,5L,5L,4L,6L,0L,5L,1L,3L,8L,0L,7L,8L,5L,9L,8L,0L,8L,2L,2L,7L,4L,2L,1L,1L,1L,0L,9L,7L,6L,6L,8L,3L,7L,7L,6L,2L,4L,9L,7L,6L,7L,1L,3L,8L,5L,2L,6L,7L,7L,0L,7L,9L,8L,8L,3L,9L,3L,3L,5L,2L,2L,1L,7L,3L,9L,4L,2L,8L,9L,2L,0L,7L,7L,5L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011386Inst : IEnumerable<long>
{
public static readonly long[] Value=A011386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011386.Bytes);
public long this[int i]=>Value[i];

public static A011386Inst Instance=new A011386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011387
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,1L,1L,8L,1L,7L,9L,6L,0L,5L,8L,0L,3L,3L,9L,7L,5L,9L,8L,0L,1L,3L,2L,0L,6L,0L,2L,0L,5L,0L,9L,3L,7L,2L,2L,7L,9L,6L,0L,9L,7L,1L,9L,4L,0L,3L,6L,6L,5L,5L,5L,0L,5L,1L,2L,6L,1L,6L,7L,3L,0L,6L,8L,6L,9L,9L,2L,0L,7L,0L,6L,9L,7L,1L,4L,8L,1L,6L,8L,7L,4L,9L,5L,2L,3L,1L,1L,6L,1L,9L,2L,2L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011387Inst : IEnumerable<long>
{
public static readonly long[] Value=A011387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011387.Bytes);
public long this[int i]=>Value[i];

public static A011387Inst Instance=new A011387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011388
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,0L,3L,8L,3L,1L,6L,0L,0L,4L,5L,7L,7L,5L,1L,4L,1L,0L,9L,8L,9L,6L,6L,8L,1L,5L,7L,3L,7L,5L,8L,0L,2L,9L,9L,9L,8L,2L,8L,1L,9L,9L,1L,5L,9L,6L,2L,6L,6L,9L,9L,9L,1L,0L,6L,9L,3L,7L,4L,1L,8L,7L,9L,0L,3L,4L,0L,4L,3L,4L,4L,6L,9L,7L,5L,3L,1L,3L,6L,5L,1L,9L,5L,9L,1L,1L,3L,9L,6L,6L,7L,5L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011388Inst : IEnumerable<long>
{
public static readonly long[] Value=A011388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011388.Bytes);
public long this[int i]=>Value[i];

public static A011388Inst Instance=new A011388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011389
{
public static readonly long[] Value={ 1L,2L,0L,7L,8L,9L,7L,0L,7L,0L,8L,1L,5L,4L,3L,3L,9L,3L,3L,8L,5L,2L,9L,2L,1L,9L,0L,3L,1L,5L,7L,4L,9L,2L,4L,3L,3L,9L,1L,1L,5L,8L,8L,7L,5L,8L,3L,8L,5L,3L,4L,2L,1L,4L,5L,8L,1L,0L,3L,3L,6L,4L,5L,5L,9L,6L,0L,6L,5L,3L,4L,5L,6L,3L,1L,5L,5L,2L,1L,6L,4L,9L,0L,6L,0L,5L,1L,6L,7L,0L,4L,7L,2L,3L,5L,7L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011389Inst : IEnumerable<long>
{
public static readonly long[] Value=A011389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011389.Bytes);
public long this[int i]=>Value[i];

public static A011389Inst Instance=new A011389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011390
{
public static readonly long[] Value={ 1L,1L,9L,3L,7L,2L,1L,6L,1L,4L,3L,8L,3L,9L,0L,0L,1L,3L,7L,0L,7L,3L,3L,0L,2L,5L,9L,3L,0L,2L,1L,7L,4L,6L,8L,3L,9L,6L,1L,7L,1L,7L,4L,1L,2L,2L,0L,5L,2L,3L,6L,7L,7L,8L,1L,6L,3L,3L,1L,4L,3L,8L,0L,4L,7L,2L,6L,1L,4L,0L,6L,9L,8L,7L,9L,5L,1L,3L,9L,9L,9L,0L,6L,5L,7L,4L,8L,5L,3L,4L,0L,1L,8L,5L,2L,0L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011390Inst : IEnumerable<long>
{
public static readonly long[] Value=A011390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011390.Bytes);
public long this[int i]=>Value[i];

public static A011390Inst Instance=new A011390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011391
{
public static readonly long[] Value={ 1L,1L,8L,1L,3L,5L,2L,0L,7L,4L,6L,2L,5L,5L,4L,5L,7L,2L,1L,5L,4L,0L,1L,5L,5L,6L,9L,3L,0L,5L,5L,3L,1L,0L,6L,3L,2L,5L,0L,3L,5L,3L,2L,3L,2L,9L,9L,9L,1L,6L,7L,1L,0L,6L,4L,4L,5L,4L,6L,2L,9L,8L,6L,4L,6L,3L,3L,0L,5L,1L,5L,8L,2L,9L,0L,7L,2L,6L,8L,5L,8L,2L,3L,7L,7L,4L,0L,2L,2L,9L,3L,7L,0L,2L,2L,4L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011391Inst : IEnumerable<long>
{
public static readonly long[] Value=A011391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011391.Bytes);
public long this[int i]=>Value[i];

public static A011391Inst Instance=new A011391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011392
{
public static readonly long[] Value={ 1L,1L,7L,0L,4L,6L,4L,5L,7L,3L,4L,6L,6L,3L,4L,1L,9L,1L,1L,6L,1L,1L,0L,6L,4L,5L,8L,8L,8L,4L,9L,7L,6L,4L,4L,4L,5L,4L,5L,8L,3L,4L,7L,7L,4L,1L,1L,0L,5L,8L,8L,3L,9L,1L,3L,6L,7L,6L,6L,9L,3L,4L,1L,9L,0L,2L,5L,4L,2L,1L,6L,7L,2L,3L,2L,1L,4L,8L,6L,7L,0L,3L,5L,9L,6L,5L,1L,2L,5L,6L,5L,1L,1L,8L,9L,9L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011392Inst : IEnumerable<long>
{
public static readonly long[] Value=A011392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011392.Bytes);
public long this[int i]=>Value[i];

public static A011392Inst Instance=new A011392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011393
{
public static readonly long[] Value={ 1L,1L,6L,0L,8L,0L,8L,2L,0L,5L,9L,6L,1L,6L,9L,4L,4L,5L,8L,3L,7L,3L,3L,0L,6L,6L,4L,9L,3L,6L,7L,5L,4L,1L,7L,2L,8L,9L,1L,0L,0L,5L,4L,8L,3L,8L,1L,5L,8L,7L,8L,8L,8L,7L,2L,4L,7L,7L,2L,0L,7L,8L,7L,0L,7L,0L,0L,3L,9L,8L,4L,6L,1L,1L,0L,6L,1L,5L,0L,0L,8L,0L,7L,7L,5L,9L,4L,6L,0L,0L,0L,2L,3L,6L,9L,9L,0L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011393Inst : IEnumerable<long>
{
public static readonly long[] Value=A011393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011393.Bytes);
public long this[int i]=>Value[i];

public static A011393Inst Instance=new A011393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011394
{
public static readonly long[] Value={ 1L,1L,5L,2L,1L,8L,5L,6L,0L,7L,8L,2L,9L,1L,0L,2L,8L,4L,9L,9L,8L,7L,1L,9L,1L,9L,2L,9L,1L,2L,3L,0L,6L,6L,8L,1L,9L,4L,5L,2L,0L,0L,4L,1L,4L,7L,7L,2L,1L,8L,8L,3L,4L,6L,3L,6L,5L,5L,2L,7L,1L,8L,1L,0L,0L,5L,9L,2L,0L,6L,6L,1L,8L,3L,4L,9L,7L,3L,9L,3L,4L,1L,2L,3L,8L,9L,1L,6L,0L,1L,5L,6L,9L,2L,1L,0L,0L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011394Inst : IEnumerable<long>
{
public static readonly long[] Value=A011394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011394.Bytes);
public long this[int i]=>Value[i];

public static A011394Inst Instance=new A011394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011395
{
public static readonly long[] Value={ 1L,6L,1L,8L,8L,7L,0L,4L,0L,6L,8L,6L,0L,5L,6L,6L,6L,5L,1L,9L,3L,0L,3L,4L,8L,0L,0L,5L,2L,7L,0L,5L,9L,2L,2L,1L,9L,9L,8L,4L,4L,6L,7L,5L,0L,3L,9L,8L,3L,5L,4L,1L,5L,0L,0L,3L,9L,4L,9L,7L,4L,1L,0L,3L,1L,1L,7L,5L,8L,6L,5L,8L,0L,4L,9L,0L,2L,0L,7L,6L,1L,1L,7L,8L,0L,1L,7L,3L,2L,7L,0L,8L,1L,3L,2L,6L,3L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011395Inst : IEnumerable<long>
{
public static readonly long[] Value=A011395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011395.Bytes);
public long this[int i]=>Value[i];

public static A011395Inst Instance=new A011395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011396
{
public static readonly long[] Value={ 1L,5L,1L,1L,2L,0L,9L,3L,9L,0L,5L,0L,9L,4L,0L,3L,1L,3L,5L,6L,9L,1L,0L,3L,4L,1L,1L,1L,4L,1L,3L,2L,9L,1L,5L,0L,9L,5L,4L,9L,3L,0L,8L,8L,1L,9L,6L,5L,6L,0L,1L,1L,6L,9L,9L,0L,7L,7L,8L,0L,1L,3L,6L,5L,3L,4L,7L,7L,5L,3L,8L,0L,2L,7L,9L,1L,2L,3L,2L,5L,1L,8L,6L,6L,2L,1L,9L,9L,7L,0L,0L,5L,6L,0L,7L,3L,7L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011396Inst : IEnumerable<long>
{
public static readonly long[] Value=A011396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011396.Bytes);
public long this[int i]=>Value[i];

public static A011396Inst Instance=new A011396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011397
{
public static readonly long[] Value={ 1L,4L,3L,5L,1L,8L,8L,8L,8L,7L,8L,8L,4L,4L,8L,9L,4L,9L,4L,3L,9L,5L,0L,1L,7L,4L,2L,3L,7L,6L,0L,8L,4L,0L,9L,0L,3L,6L,6L,1L,4L,2L,6L,7L,2L,1L,7L,6L,8L,0L,7L,2L,1L,1L,6L,4L,7L,3L,3L,4L,3L,5L,8L,3L,7L,8L,3L,1L,1L,5L,4L,6L,5L,2L,7L,3L,8L,4L,1L,7L,5L,1L,8L,8L,6L,4L,9L,2L,6L,6L,0L,0L,5L,5L,9L,3L,5L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011397Inst : IEnumerable<long>
{
public static readonly long[] Value=A011397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011397.Bytes);
public long this[int i]=>Value[i];

public static A011397Inst Instance=new A011397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011398
{
public static readonly long[] Value={ 1L,3L,7L,8L,7L,1L,5L,7L,0L,5L,3L,4L,1L,7L,2L,8L,6L,0L,4L,1L,4L,5L,6L,6L,0L,2L,6L,7L,1L,9L,7L,5L,4L,9L,9L,0L,6L,5L,3L,4L,2L,8L,5L,9L,4L,6L,2L,2L,6L,4L,7L,5L,2L,7L,7L,4L,6L,3L,7L,2L,0L,5L,1L,6L,4L,9L,4L,3L,1L,0L,4L,2L,9L,1L,5L,8L,1L,3L,0L,7L,8L,9L,9L,6L,2L,5L,2L,6L,7L,3L,1L,1L,7L,9L,5L,4L,8L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011398Inst : IEnumerable<long>
{
public static readonly long[] Value=A011398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011398.Bytes);
public long this[int i]=>Value[i];

public static A011398Inst Instance=new A011398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011399
{
public static readonly long[] Value={ 1L,3L,3L,5L,1L,4L,1L,3L,6L,2L,5L,4L,0L,3L,1L,2L,9L,4L,0L,7L,3L,6L,7L,3L,8L,7L,8L,0L,7L,0L,3L,1L,7L,1L,7L,2L,0L,3L,5L,3L,6L,1L,5L,8L,9L,8L,4L,7L,8L,0L,8L,1L,7L,6L,0L,3L,8L,1L,8L,4L,7L,7L,2L,8L,4L,1L,1L,6L,1L,8L,9L,7L,8L,4L,4L,8L,8L,2L,8L,0L,0L,9L,6L,7L,9L,3L,2L,1L,5L,2L,4L,8L,7L,5L,6L,4L,2L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011399Inst : IEnumerable<long>
{
public static readonly long[] Value=A011399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011399.Bytes);
public long this[int i]=>Value[i];

public static A011399Inst Instance=new A011399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011400
{
public static readonly long[] Value={ 1L,3L,0L,0L,5L,1L,5L,9L,4L,8L,1L,2L,0L,2L,8L,8L,9L,8L,5L,5L,9L,5L,6L,1L,9L,2L,7L,7L,2L,0L,5L,2L,5L,6L,0L,9L,6L,6L,0L,7L,7L,3L,1L,9L,2L,2L,5L,6L,7L,8L,3L,1L,0L,4L,9L,6L,1L,9L,1L,2L,6L,5L,5L,0L,8L,5L,9L,0L,1L,3L,3L,0L,3L,6L,3L,6L,2L,9L,5L,2L,5L,7L,5L,0L,0L,1L,7L,6L,1L,8L,9L,7L,0L,0L,1L,1L,2L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011400Inst : IEnumerable<long>
{
public static readonly long[] Value=A011400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011400.Bytes);
public long this[int i]=>Value[i];

public static A011400Inst Instance=new A011400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011401
{
public static readonly long[] Value={ 1L,2L,7L,2L,3L,4L,8L,3L,8L,2L,6L,6L,1L,1L,9L,8L,1L,2L,4L,3L,8L,8L,0L,5L,9L,7L,1L,8L,3L,7L,0L,5L,5L,5L,5L,7L,6L,4L,4L,4L,5L,9L,5L,8L,9L,1L,7L,3L,8L,9L,8L,7L,4L,9L,2L,2L,4L,3L,6L,8L,3L,6L,0L,3L,0L,3L,2L,6L,4L,9L,3L,9L,4L,5L,8L,6L,4L,4L,0L,6L,8L,4L,3L,2L,9L,0L,0L,0L,0L,5L,6L,0L,7L,6L,1L,7L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011401Inst : IEnumerable<long>
{
public static readonly long[] Value=A011401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011401.Bytes);
public long this[int i]=>Value[i];

public static A011401Inst Instance=new A011401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011402
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,9L,1L,3L,2L,9L,3L,7L,9L,0L,3L,9L,4L,9L,0L,5L,9L,8L,3L,3L,9L,0L,6L,7L,8L,2L,7L,5L,9L,9L,2L,9L,2L,0L,4L,2L,9L,4L,8L,8L,3L,5L,0L,3L,6L,0L,8L,8L,9L,2L,5L,8L,6L,7L,3L,8L,7L,8L,1L,1L,7L,4L,8L,4L,4L,9L,4L,7L,9L,8L,6L,6L,5L,5L,8L,6L,7L,0L,7L,5L,4L,0L,3L,3L,7L,9L,4L,0L,3L,8L,7L,1L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011402Inst : IEnumerable<long>
{
public static readonly long[] Value=A011402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011402.Bytes);
public long this[int i]=>Value[i];

public static A011402Inst Instance=new A011402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011403
{
public static readonly long[] Value={ 1L,2L,2L,9L,3L,1L,2L,5L,6L,8L,2L,7L,1L,1L,4L,6L,8L,7L,0L,6L,0L,5L,1L,3L,0L,5L,4L,3L,9L,7L,3L,3L,9L,2L,4L,9L,4L,9L,6L,0L,4L,6L,8L,1L,6L,9L,4L,8L,6L,1L,0L,0L,2L,8L,1L,7L,3L,6L,3L,3L,3L,5L,8L,7L,3L,8L,8L,2L,7L,2L,3L,2L,4L,3L,2L,1L,4L,3L,7L,1L,9L,3L,2L,1L,9L,1L,0L,6L,1L,5L,0L,6L,9L,6L,4L,5L,5L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011403Inst : IEnumerable<long>
{
public static readonly long[] Value=A011403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011403.Bytes);
public long this[int i]=>Value[i];

public static A011403Inst Instance=new A011403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011404
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,0L,8L,6L,1L,6L,9L,0L,0L,6L,2L,1L,9L,0L,9L,9L,2L,4L,8L,7L,3L,6L,8L,7L,8L,5L,6L,8L,9L,3L,1L,6L,4L,9L,3L,5L,8L,5L,8L,0L,9L,8L,9L,5L,3L,9L,1L,9L,3L,5L,6L,7L,7L,7L,1L,0L,3L,1L,3L,1L,7L,2L,9L,1L,1L,1L,7L,8L,3L,4L,7L,3L,2L,3L,1L,8L,5L,5L,5L,4L,9L,8L,0L,3L,3L,5L,4L,3L,9L,9L,1L,2L,3L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011404Inst : IEnumerable<long>
{
public static readonly long[] Value=A011404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011404.Bytes);
public long this[int i]=>Value[i];

public static A011404Inst Instance=new A011404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011405
{
public static readonly long[] Value={ 1L,1L,9L,7L,9L,9L,3L,6L,9L,2L,7L,5L,6L,5L,5L,5L,9L,9L,9L,3L,8L,7L,7L,8L,3L,2L,7L,2L,0L,4L,7L,1L,4L,2L,5L,4L,0L,7L,7L,7L,5L,9L,4L,2L,8L,4L,5L,3L,7L,2L,2L,6L,8L,4L,2L,7L,3L,3L,3L,9L,2L,0L,7L,1L,7L,1L,3L,8L,0L,6L,6L,5L,5L,2L,6L,6L,1L,9L,8L,1L,8L,3L,7L,4L,8L,3L,0L,5L,6L,3L,3L,3L,9L,4L,0L,7L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011405Inst : IEnumerable<long>
{
public static readonly long[] Value=A011405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011405.Bytes);
public long this[int i]=>Value[i];

public static A011405Inst Instance=new A011405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011422
{
public static readonly long[] Value={ 1L,1L,7L,7L,7L,1L,9L,5L,0L,2L,1L,9L,2L,3L,5L,9L,5L,5L,2L,9L,0L,2L,4L,8L,5L,3L,2L,6L,0L,8L,0L,5L,2L,8L,8L,9L,7L,3L,8L,9L,4L,8L,0L,8L,6L,5L,3L,6L,4L,0L,1L,3L,0L,2L,5L,7L,3L,0L,4L,0L,5L,1L,7L,3L,9L,3L,3L,4L,2L,2L,4L,6L,8L,9L,7L,4L,3L,2L,0L,3L,2L,6L,1L,9L,2L,5L,8L,9L,2L,1L,3L,7L,8L,4L,6L,2L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011422Inst : IEnumerable<long>
{
public static readonly long[] Value=A011422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011422.Bytes);
public long this[int i]=>Value[i];

public static A011422Inst Instance=new A011422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011423
{
public static readonly long[] Value={ 1L,1L,6L,7L,6L,2L,3L,4L,8L,3L,6L,9L,6L,1L,0L,7L,6L,2L,4L,0L,8L,3L,3L,1L,3L,8L,8L,3L,1L,6L,1L,0L,8L,0L,1L,5L,6L,5L,9L,1L,5L,0L,2L,3L,6L,4L,3L,0L,8L,3L,5L,7L,9L,1L,7L,0L,8L,3L,9L,2L,5L,0L,1L,3L,8L,3L,3L,4L,0L,3L,6L,4L,6L,9L,8L,9L,1L,7L,1L,9L,7L,2L,2L,6L,8L,4L,1L,7L,6L,6L,8L,8L,7L,0L,2L,6L,7L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011423Inst : IEnumerable<long>
{
public static readonly long[] Value=A011423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011423.Bytes);
public long this[int i]=>Value[i];

public static A011423Inst Instance=new A011423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011424
{
public static readonly long[] Value={ 1L,1L,5L,8L,6L,1L,1L,0L,8L,7L,0L,1L,8L,4L,6L,3L,1L,5L,3L,6L,7L,3L,1L,7L,1L,6L,5L,3L,7L,4L,0L,9L,3L,0L,0L,6L,3L,6L,0L,1L,2L,9L,6L,3L,8L,6L,5L,7L,1L,8L,2L,7L,9L,9L,9L,1L,3L,4L,8L,8L,9L,6L,1L,8L,2L,7L,3L,7L,8L,7L,0L,1L,9L,3L,2L,3L,9L,3L,5L,5L,3L,2L,8L,2L,0L,7L,1L,2L,4L,4L,5L,2L,1L,7L,2L,3L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011424Inst : IEnumerable<long>
{
public static readonly long[] Value=A011424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011424.Bytes);
public long this[int i]=>Value[i];

public static A011424Inst Instance=new A011424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011425
{
public static readonly long[] Value={ 1L,6L,4L,7L,5L,4L,8L,9L,7L,2L,4L,4L,2L,0L,6L,5L,7L,0L,2L,4L,7L,0L,2L,5L,9L,3L,7L,3L,9L,8L,9L,3L,2L,9L,0L,7L,7L,1L,3L,7L,3L,2L,5L,0L,8L,4L,8L,2L,8L,1L,3L,5L,1L,5L,9L,1L,4L,1L,5L,8L,2L,3L,8L,5L,8L,1L,4L,3L,2L,7L,4L,8L,2L,5L,5L,8L,1L,1L,2L,9L,3L,9L,3L,2L,2L,9L,6L,3L,5L,2L,2L,2L,2L,2L,8L,1L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011425Inst : IEnumerable<long>
{
public static readonly long[] Value=A011425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011425.Bytes);
public long this[int i]=>Value[i];

public static A011425Inst Instance=new A011425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011426
{
public static readonly long[] Value={ 1L,5L,3L,4L,1L,2L,7L,4L,0L,4L,6L,3L,4L,3L,9L,0L,9L,8L,1L,2L,7L,7L,8L,3L,5L,1L,2L,7L,2L,9L,5L,4L,1L,4L,8L,2L,8L,1L,5L,3L,4L,1L,6L,5L,0L,7L,2L,2L,9L,0L,1L,9L,1L,6L,1L,1L,7L,7L,3L,2L,0L,1L,1L,2L,4L,5L,5L,0L,7L,9L,6L,9L,6L,3L,8L,0L,8L,7L,9L,7L,6L,4L,2L,2L,0L,8L,5L,0L,1L,9L,3L,1L,7L,7L,0L,2L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011426Inst : IEnumerable<long>
{
public static readonly long[] Value=A011426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011426.Bytes);
public long this[int i]=>Value[i];

public static A011426Inst Instance=new A011426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011427
{
public static readonly long[] Value={ 1L,4L,5L,4L,2L,1L,5L,4L,3L,3L,4L,4L,8L,9L,5L,3L,6L,8L,3L,2L,8L,4L,3L,2L,3L,4L,5L,4L,9L,5L,6L,2L,9L,5L,6L,1L,2L,4L,7L,7L,3L,4L,7L,1L,0L,8L,0L,7L,9L,9L,0L,3L,6L,1L,9L,7L,0L,5L,1L,9L,7L,6L,2L,0L,5L,4L,7L,8L,8L,6L,3L,6L,1L,0L,3L,0L,9L,2L,7L,8L,5L,1L,9L,4L,0L,2L,1L,9L,3L,1L,5L,3L,8L,8L,3L,8L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011427Inst : IEnumerable<long>
{
public static readonly long[] Value=A011427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011427.Bytes);
public long this[int i]=>Value[i];

public static A011427Inst Instance=new A011427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011428
{
public static readonly long[] Value={ 1L,3L,9L,4L,9L,5L,0L,7L,9L,3L,9L,6L,2L,4L,2L,0L,9L,7L,9L,3L,6L,5L,9L,2L,8L,7L,1L,8L,8L,6L,1L,8L,3L,8L,9L,6L,5L,5L,5L,3L,3L,8L,6L,4L,6L,5L,7L,9L,3L,3L,6L,6L,7L,3L,6L,0L,3L,8L,2L,9L,7L,4L,1L,5L,3L,9L,2L,5L,1L,3L,0L,3L,9L,9L,1L,4L,9L,2L,3L,1L,5L,3L,2L,9L,2L,3L,6L,7L,1L,4L,8L,7L,4L,2L,0L,3L,4L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011428Inst : IEnumerable<long>
{
public static readonly long[] Value=A011428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011428.Bytes);
public long this[int i]=>Value[i];

public static A011428Inst Instance=new A011428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011429
{
public static readonly long[] Value={ 1L,3L,4L,9L,2L,8L,2L,8L,4L,7L,6L,7L,3L,5L,6L,3L,3L,1L,5L,1L,2L,2L,2L,1L,9L,7L,0L,5L,8L,0L,9L,0L,3L,2L,7L,6L,6L,6L,9L,1L,8L,8L,8L,4L,4L,9L,1L,3L,7L,5L,9L,5L,3L,4L,8L,5L,2L,5L,0L,6L,0L,6L,1L,4L,1L,6L,6L,5L,9L,4L,7L,7L,2L,5L,6L,7L,1L,0L,3L,5L,4L,7L,6L,9L,4L,6L,5L,0L,2L,6L,3L,6L,2L,5L,3L,3L,0L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011429Inst : IEnumerable<long>
{
public static readonly long[] Value=A011429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011429.Bytes);
public long this[int i]=>Value[i];

public static A011429Inst Instance=new A011429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011430
{
public static readonly long[] Value={ 1L,3L,1L,3L,0L,3L,2L,4L,3L,4L,4L,8L,7L,8L,8L,3L,9L,2L,6L,4L,3L,0L,9L,3L,0L,5L,1L,0L,4L,3L,8L,0L,4L,0L,8L,4L,0L,4L,7L,6L,0L,1L,0L,8L,3L,1L,2L,8L,3L,5L,3L,0L,0L,4L,7L,6L,0L,8L,5L,7L,1L,6L,3L,3L,7L,3L,7L,6L,4L,5L,1L,7L,5L,7L,8L,7L,7L,1L,7L,8L,3L,3L,0L,5L,7L,8L,4L,5L,5L,5L,0L,4L,6L,8L,9L,2L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011430Inst : IEnumerable<long>
{
public static readonly long[] Value=A011430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011430.Bytes);
public long this[int i]=>Value[i];

public static A011430Inst Instance=new A011430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011431
{
public static readonly long[] Value={ 1L,2L,8L,3L,5L,6L,8L,8L,4L,2L,1L,1L,2L,5L,1L,6L,2L,6L,2L,8L,6L,2L,6L,6L,5L,9L,4L,5L,1L,8L,2L,2L,1L,7L,4L,0L,1L,2L,3L,0L,7L,2L,1L,2L,6L,1L,9L,8L,2L,5L,0L,9L,5L,1L,6L,5L,9L,0L,3L,4L,6L,3L,1L,0L,0L,4L,6L,7L,0L,1L,8L,1L,4L,8L,0L,2L,7L,7L,4L,0L,2L,7L,3L,4L,0L,6L,3L,5L,7L,4L,5L,3L,6L,5L,6L,2L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011431Inst : IEnumerable<long>
{
public static readonly long[] Value=A011431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011431.Bytes);
public long this[int i]=>Value[i];

public static A011431Inst Instance=new A011431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011432
{
public static readonly long[] Value={ 1L,2L,5L,9L,1L,5L,5L,1L,0L,4L,5L,7L,6L,5L,7L,2L,6L,5L,4L,6L,7L,9L,1L,4L,6L,7L,3L,0L,0L,5L,6L,3L,7L,8L,1L,6L,9L,7L,4L,8L,6L,4L,4L,3L,1L,9L,5L,0L,9L,9L,3L,5L,4L,4L,5L,6L,5L,1L,1L,4L,6L,2L,6L,2L,9L,0L,3L,4L,8L,5L,1L,3L,7L,3L,7L,2L,2L,7L,8L,1L,3L,4L,7L,6L,9L,0L,2L,9L,9L,0L,0L,9L,7L,0L,7L,8L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011432Inst : IEnumerable<long>
{
public static readonly long[] Value=A011432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011432.Bytes);
public long this[int i]=>Value[i];

public static A011432Inst Instance=new A011432Inst();

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