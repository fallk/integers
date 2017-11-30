using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A106141
{
public static readonly long[] Value={ 4L,1L,4L,0L,4L,0L,1L,2L,0L,1L,3L,4L,0L,3L,4L,1L,4L,1L,0L,2L,3L,2L,0L,4L,4L,2L,2L,0L,1L,2L,1L,3L,4L,0L,1L,1L,0L,3L,4L,1L,2L,3L,4L,3L,4L,1L,2L,3L,0L,1L,0L,3L,4L,1L,1L,4L,2L,3L,3L,0L,2L,4L,1L,2L,3L,0L,1L,4L,3L,4L,0L,2L,3L,4L,1L,1L,0L,2L,2L,4L,3L,4L,4L,2L,0L,2L,4L,3L,2L,4L,1L,0L,3L,4L,1L,2L,3L,0L,4L,4L,4L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106141Inst : IEnumerable<long>
{
public static readonly long[] Value=A106141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106141.Bytes);
public long this[int i]=>Value[i];

public static A106141Inst Instance=new A106141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106142
{
public static readonly long[] Value={ 4L,0L,3L,4L,2L,3L,3L,4L,1L,2L,3L,4L,5L,2L,3L,4L,1L,3L,1L,3L,4L,2L,5L,3L,2L,5L,4L,1L,2L,3L,1L,3L,4L,5L,4L,3L,1L,4L,5L,1L,2L,3L,3L,1L,2L,3L,4L,5L,1L,2L,5L,2L,3L,5L,4L,1L,3L,4L,3L,5L,1L,2L,3L,4L,5L,1L,2L,5L,3L,4L,5L,1L,2L,3L,5L,4L,1L,3L,1L,3L,1L,2L,1L,4L,1L,3L,4L,2L,5L,1L,3L,1L,4L,5L,1L,2L,3L,5L,3L,2L,1L,3L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106142Inst : IEnumerable<long>
{
public static readonly long[] Value=A106142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106142.Bytes);
public long this[int i]=>Value[i];

public static A106142Inst Instance=new A106142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106143
{
public static readonly long[] Value={ 4L,6L,2L,3L,0L,1L,0L,1L,4L,5L,5L,6L,0L,3L,4L,4L,0L,2L,6L,1L,2L,6L,2L,6L,4L,0L,5L,1L,2L,3L,0L,2L,3L,4L,1L,6L,3L,6L,0L,2L,3L,4L,3L,0L,1L,1L,2L,3L,5L,6L,1L,4L,5L,0L,5L,1L,2L,3L,1L,3L,5L,5L,5L,6L,0L,2L,3L,6L,3L,4L,5L,0L,1L,2L,4L,2L,4L,6L,2L,4L,1L,2L,0L,3L,6L,1L,1L,5L,0L,2L,4L,1L,4L,5L,0L,1L,2L,4L,1L,6L,4L,6L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106143Inst : IEnumerable<long>
{
public static readonly long[] Value=A106143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106143.Bytes);
public long this[int i]=>Value[i];

public static A106143Inst Instance=new A106143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106144
{
public static readonly long[] Value={ 4L,6L,1L,2L,6L,7L,5L,6L,1L,2L,1L,2L,3L,6L,7L,6L,1L,3L,7L,1L,2L,6L,1L,5L,2L,5L,2L,5L,6L,7L,3L,5L,6L,7L,2L,7L,3L,6L,7L,1L,2L,3L,1L,5L,6L,5L,6L,7L,1L,2L,3L,6L,7L,1L,6L,1L,1L,2L,7L,1L,3L,2L,1L,2L,3L,5L,6L,1L,5L,6L,7L,1L,2L,3L,5L,2L,3L,5L,7L,1L,5L,6L,3L,6L,1L,3L,2L,6L,7L,1L,3L,7L,2L,3L,5L,6L,7L,1L,5L,2L,7L,1L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106144Inst : IEnumerable<long>
{
public static readonly long[] Value=A106144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106144.Bytes);
public long this[int i]=>Value[i];

public static A106144Inst Instance=new A106144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106145
{
public static readonly long[] Value={ 4L,6L,0L,1L,5L,6L,3L,4L,7L,8L,6L,7L,8L,2L,3L,1L,4L,6L,1L,3L,4L,8L,2L,6L,2L,5L,1L,4L,5L,6L,1L,3L,4L,5L,7L,3L,7L,1L,2L,4L,5L,6L,3L,7L,8L,6L,7L,8L,1L,2L,2L,5L,6L,8L,4L,7L,6L,7L,3L,5L,7L,5L,3L,4L,5L,7L,8L,2L,6L,7L,8L,1L,2L,3L,5L,1L,1L,3L,4L,6L,1L,2L,7L,1L,4L,6L,4L,8L,8L,1L,3L,7L,1L,2L,4L,5L,6L,8L,3L,8L,4L,6L,8L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106145Inst : IEnumerable<long>
{
public static readonly long[] Value=A106145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106145.Bytes);
public long this[int i]=>Value[i];

public static A106145Inst Instance=new A106145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106146
{
public static readonly long[] Value={ 4L,6L,9L,0L,4L,5L,1L,2L,5L,6L,3L,4L,5L,8L,9L,6L,9L,1L,5L,7L,8L,2L,5L,9L,4L,7L,2L,5L,6L,7L,1L,3L,4L,5L,6L,1L,5L,8L,9L,1L,2L,3L,9L,3L,4L,1L,2L,3L,5L,6L,5L,8L,9L,1L,6L,9L,7L,8L,3L,5L,7L,4L,1L,2L,3L,5L,6L,9L,3L,4L,5L,7L,8L,9L,1L,6L,5L,7L,7L,9L,3L,4L,9L,2L,5L,7L,4L,8L,7L,9L,1L,5L,8L,9L,1L,2L,3L,5L,9L,4L,9L,1L,3L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106146Inst : IEnumerable<long>
{
public static readonly long[] Value=A106146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106146.Bytes);
public long this[int i]=>Value[i];

public static A106146Inst Instance=new A106146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106147
{
public static readonly long[] Value={ 1L,4L,4L,3L,4L,3L,3L,2L,4L,3L,3L,2L,3L,2L,2L,1L,4L,3L,3L,2L,3L,2L,2L,1L,3L,2L,2L,1L,2L,1L,1L,4L,4L,3L,3L,2L,3L,2L,2L,1L,3L,2L,2L,1L,2L,1L,1L,4L,3L,2L,2L,1L,2L,1L,1L,4L,2L,1L,1L,4L,1L,4L,4L,3L,4L,3L,3L,2L,3L,2L,2L,1L,3L,2L,2L,1L,2L,1L,1L,4L,3L,2L,2L,1L,2L,1L,1L,4L,2L,1L,1L,4L,1L,4L,4L,3L,3L,2L,2L,1L,2L,1L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106147Inst : IEnumerable<long>
{
public static readonly long[] Value=A106147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106147.Bytes);
public long this[int i]=>Value[i];

public static A106147Inst Instance=new A106147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106148
{
public static readonly long[] Value={ 4L,5L,4L,8L,9L,8L,2L,3L,2L,3L,1L,3L,2L,3L,2L,5L,6L,5L,6L,4L,6L,5L,6L,5L,6L,4L,6L,4L,5L,4L,6L,4L,6L,5L,6L,5L,6L,4L,6L,5L,6L,5L,9L,7L,8L,9L,9L,7L,8L,9L,8L,7L,8L,9L,9L,7L,8L,9L,9L,7L,8L,9L,8L,7L,8L,9L,8L,9L,8L,7L,8L,9L,8L,7L,8L,9L,9L,7L,8L,9L,9L,7L,8L,9L,8L,7L,8L,9L,9L,7L,8L,9L,9L,3L,1L,3L,1L,2L,1L,2L,3L,2L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106148Inst : IEnumerable<long>
{
public static readonly long[] Value=A106148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106148.Bytes);
public long this[int i]=>Value[i];

public static A106148Inst Instance=new A106148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106149
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,3L,2L,1L,2L,1L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,3L,3L,2L,1L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,2L,3L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106149Inst : IEnumerable<long>
{
public static readonly long[] Value=A106149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106149.Bytes);
public long this[int i]=>Value[i];

public static A106149Inst Instance=new A106149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106150
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,22L,82L,218L,476L,914L,1603L,2628L,4089L,6102L,8800L,12334L,16874L,22610L,29753L,38536L,49215L,62070L,77406L,95554L,116872L,141746L,170591L,203852L,242005L,285558L,335052L,391062L,454198L,525106L,604469L,693008L,791483L,900694L,1021482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106150Inst : IEnumerable<long>
{
public static readonly long[] Value=A106150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106150.Bytes);
public long this[int i]=>Value[i];

public static A106150Inst Instance=new A106150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106151
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,3L,7L,4L,5L,3L,7L,6L,7L,7L,15L,8L,9L,5L,11L,6L,7L,7L,15L,12L,13L,7L,15L,14L,15L,15L,31L,16L,17L,9L,19L,10L,11L,11L,23L,12L,13L,7L,15L,14L,15L,15L,31L,24L,25L,13L,27L,14L,15L,15L,31L,28L,29L,15L,31L,30L,31L,31L,63L,32L,33L,17L,35L,18L,19L,19L,39L,20L,21L,11L,23L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106151Inst : IEnumerable<long>
{
public static readonly long[] Value=A106151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106151.Bytes);
public long this[int i]=>Value[i];

public static A106151Inst Instance=new A106151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106152
{
public static readonly long[] Value={ 1L,0L,0L,2L,6L,6L,0L,6L,4L,0L,6L,0L,9L,1L,9L,7L,6L,5L,6L,8L,7L,4L,4L,0L,2L,1L,3L,9L,5L,9L,8L,9L,0L,0L,4L,4L,5L,8L,2L,4L,3L,7L,5L,5L,5L,2L,8L,2L,2L,8L,7L,8L,3L,8L,4L,8L,4L,9L,6L,3L,1L,8L,6L,8L,3L,6L,0L,9L,7L,7L,2L,3L,1L,1L,2L,2L,9L,6L,3L,7L,2L,7L,8L,1L,7L,1L,4L,7L,4L,5L,9L,0L,5L,3L,1L,8L,4L,4L,0L,4L,1L,5L,2L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106152Inst : IEnumerable<long>
{
public static readonly long[] Value=A106152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106152.Bytes);
public long this[int i]=>Value[i];

public static A106152Inst Instance=new A106152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106153
{
public static readonly long[] Value={ 3L,0L,0L,8L,8L,0L,5L,2L,3L,8L,0L,8L,4L,5L,1L,7L,0L,2L,5L,8L,1L,0L,3L,4L,8L,0L,6L,5L,2L,6L,8L,3L,2L,9L,9L,6L,4L,8L,1L,3L,2L,0L,7L,7L,3L,0L,2L,0L,7L,5L,0L,6L,7L,7L,6L,1L,6L,2L,4L,0L,9L,1L,1L,3L,2L,4L,9L,2L,0L,5L,9L,7L,9L,4L,4L,0L,1L,6L,6L,5L,7L,2L,8L,2L,0L,0L,2L,9L,7L,6L,9L,2L,9L,3L,7L,1L,8L,1L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106153Inst : IEnumerable<long>
{
public static readonly long[] Value=A106153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106153.Bytes);
public long this[int i]=>Value[i];

public static A106153Inst Instance=new A106153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106154
{
public static readonly long[] Value={ 6L,5L,6L,5L,4L,5L,6L,5L,6L,5L,4L,5L,4L,3L,4L,5L,4L,5L,6L,5L,6L,5L,4L,5L,6L,5L,6L,5L,4L,5L,4L,3L,4L,5L,4L,5L,4L,3L,4L,3L,2L,3L,4L,3L,4L,5L,4L,5L,4L,3L,4L,5L,4L,5L,6L,5L,6L,5L,4L,5L,6L,5L,6L,5L,4L,5L,4L,3L,4L,5L,4L,5L,6L,5L,6L,5L,4L,5L,6L,5L,6L,5L,4L,5L,4L,3L,4L,5L,4L,5L,4L,3L,4L,3L,2L,3L,4L,3L,4L,5L,4L,5L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106154Inst : IEnumerable<long>
{
public static readonly long[] Value=A106154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106154.Bytes);
public long this[int i]=>Value[i];

public static A106154Inst Instance=new A106154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106155
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,10L,12L,13L,19L,26L,28L,41L,66L,73L,76L,78L,85L,371L,437L,513L,661L,726L,924L,1063L,1331L,1380L,1422L,1602L,1947L,1963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106155Inst : IEnumerable<long>
{
public static readonly long[] Value=A106155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106155.Bytes);
public long this[int i]=>Value[i];

public static A106155Inst Instance=new A106155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106156
{
public static readonly BigInteger[] Value={ 314L,1L,5926L,5L,35897L,932384626L,43L,383279L,50288L,419L,71693L,99375105L,820974944L,5923078L,BigInteger.Parse("164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502") };
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
public class A106156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106156Inst Instance=new A106156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106157
{
public static readonly long[] Value={ -1L,-1L,-2L,-1L,-2L,1L,2L,11L,22L,53L,106L,223L,446L,905L,1810L,3635L,7270L,14557L,29114L,58247L,116494L,233009L,466018L,932059L,1864118L,3728261L,7456522L,14913071L,29826142L,59652313L,119304626L,238609283L,477218566L,954437165L,1908874330L,3817748695L,7635497390L,15270994817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106157Inst : IEnumerable<long>
{
public static readonly long[] Value=A106157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106157.Bytes);
public long this[int i]=>Value[i];

public static A106157Inst Instance=new A106157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106158
{
public static readonly long[] Value={ 1L,1L,3L,6L,17L,63L,404L,9858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106158Inst : IEnumerable<long>
{
public static readonly long[] Value=A106158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106158.Bytes);
public long this[int i]=>Value[i];

public static A106158Inst Instance=new A106158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106159
{
public static readonly long[] Value={ 1L,2L,7L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106159Inst : IEnumerable<long>
{
public static readonly long[] Value=A106159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106159.Bytes);
public long this[int i]=>Value[i];

public static A106159Inst Instance=new A106159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106160
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,4L,4L,4L,6L,6L,6L,8L,6L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106160Inst : IEnumerable<long>
{
public static readonly long[] Value=A106160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106160.Bytes);
public long this[int i]=>Value[i];

public static A106160Inst Instance=new A106160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106161
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,3L,4L,3L,4L,4L,4L,4L,4L,4L,5L,5L,6L,5L,6L,6L,7L,7L,8L,6L,7L,7L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106161Inst : IEnumerable<long>
{
public static readonly long[] Value=A106161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106161.Bytes);
public long this[int i]=>Value[i];

public static A106161Inst Instance=new A106161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106162
{
public static readonly long[] Value={ 1L,1L,1L,7L,75L,94251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106162Inst : IEnumerable<long>
{
public static readonly long[] Value=A106162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106162.Bytes);
public long this[int i]=>Value[i];

public static A106162Inst Instance=new A106162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106163
{
public static readonly long[] Value={ 1L,1L,2L,9L,85L,94343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106163Inst : IEnumerable<long>
{
public static readonly long[] Value=A106163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106163.Bytes);
public long this[int i]=>Value[i];

public static A106163Inst Instance=new A106163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106164
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,1L,1L,1L,2L,6L,8L,19L,45L,148L,457L,2448L,20786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106164Inst : IEnumerable<long>
{
public static readonly long[] Value=A106164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106164.Bytes);
public long this[int i]=>Value[i];

public static A106164Inst Instance=new A106164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106165
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,3L,4L,5L,9L,16L,25L,46L,103L,261L,731L,3210L,24147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106165Inst : IEnumerable<long>
{
public static readonly long[] Value=A106165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106165.Bytes);
public long this[int i]=>Value[i];

public static A106165Inst Instance=new A106165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106166
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,2L,2L,6L,7L,24L,44L,145L,444L,2441L,19848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106166Inst : IEnumerable<long>
{
public static readonly long[] Value=A106166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106166.Bytes);
public long this[int i]=>Value[i];

public static A106166Inst Instance=new A106166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106167
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,1L,3L,2L,7L,8L,28L,47L,155L,457L,2482L,19914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106167Inst : IEnumerable<long>
{
public static readonly long[] Value=A106167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106167.Bytes);
public long this[int i]=>Value[i];

public static A106167Inst Instance=new A106167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106168
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,2L,2L,6L,7L,24L,44L,145L,444L,2441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106168Inst : IEnumerable<long>
{
public static readonly long[] Value=A106168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106168.Bytes);
public long this[int i]=>Value[i];

public static A106168Inst Instance=new A106168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106169
{
public static readonly long[] Value={ 1L,2L,1L,3L,19L,1L,1020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106169Inst : IEnumerable<long>
{
public static readonly long[] Value=A106169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106169.Bytes);
public long this[int i]=>Value[i];

public static A106169Inst Instance=new A106169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106170
{
public static readonly long[] Value={ 4L,5L,7L,15L,176L,476715857290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106170Inst : IEnumerable<long>
{
public static readonly long[] Value=A106170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106170.Bytes);
public long this[int i]=>Value[i];

public static A106170Inst Instance=new A106170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106171
{
public static readonly long[] Value={ 5L,11L,23L,59L,71L,89L,211L,239L,269L,349L,389L,419L,431L,467L,479L,521L,571L,577L,647L,863L,983L,1087L,1213L,1223L,1733L,1747L,1759L,1933L,1949L,1973L,2131L,2297L,2411L,2521L,2659L,2879L,2909L,2999L,3011L,3191L,3203L,3209L,3391L,3467L,3469L,3517L,3559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106171Inst : IEnumerable<long>
{
public static readonly long[] Value=A106171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106171.Bytes);
public long this[int i]=>Value[i];

public static A106171Inst Instance=new A106171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106172
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,11L,42L,53L,89L,142L,204L,238L,324L,434L,764L,926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106172Inst : IEnumerable<long>
{
public static readonly long[] Value=A106172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106172.Bytes);
public long this[int i]=>Value[i];

public static A106172Inst Instance=new A106172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106173
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,13L,72L,255L,691L,1574L,3177L,5867L,10121L,16543L,25882L,39051L,57147L,81472L,113555L,155175L,208385L,275537L,359308L,462727L,589203L,742554L,927037L,1147379L,1408809L,1717091L,2078558L,2500147L,2989435L,3554676L,4204839L,4949647L,5799617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106173Inst : IEnumerable<long>
{
public static readonly long[] Value=A106173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106173.Bytes);
public long this[int i]=>Value[i];

public static A106173Inst Instance=new A106173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106174
{
public static readonly BigInteger[] Value={ 0L,1L,4L,23L,180L,1777L,21144L,294239L,4686680L,84066001L,1676633340L,36801867479L,881568186156L,22883970972577L,639869619046000L,19173204600407423L,612902677593991536L,BigInteger.Parse("20819517833595304801"),BigInteger.Parse("748889739331836981300") };
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
public class A106174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106174Inst Instance=new A106174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106175
{
public static readonly BigInteger[] Value={ 1L,135L,11791L,3186521L,278253009L,14755412411L,24297576265L,1288470373299L,112511657189035L,30406305506223725L,2655135804746536821L,BigInteger.Parse("140798562959107191995"),BigInteger.Parse("231851453975691325309"),BigInteger.Parse("12294795423043604534211"),BigInteger.Parse("1073604668382849022129099"),BigInteger.Parse("290141949335169200729049629") };
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
public class A106175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106175Inst Instance=new A106175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106176
{
public static readonly BigInteger[] Value={ 0L,16L,1440L,389295L,33994015L,1802660535L,2968421391L,157411709575L,13745486642391L,3714721448623416L,324376465956415720L,17201282202880383816UL,BigInteger.Parse("28325163305411682840"),BigInteger.Parse("1502048325307681783960"),BigInteger.Parse("131161685794667995415400"),BigInteger.Parse("35446480734732882983897895") };
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
public class A106176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106176Inst Instance=new A106176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106177
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,1L,1L,1L,1L,1L,4L,1L,1L,5L,2L,9L,1L,1L,1L,6L,1L,1L,1L,2L,1L,1L,7L,1L,25L,1L,3L,1L,1L,1L,1L,1L,36L,1L,2L,1L,8L,1L,1L,1L,1L,49L,1L,5L,1L,27L,1L,1L,1L,10L,3L,1L,1L,6L,1L,1L,1L,2L,1L,1L,11L,1L,1L,2L,7L,1L,125L,4L,3L,1L,1L,1L,3L,1L,100L,1L,1L,1L,216L,1L,1L,1L,4L,1L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106177Inst : IEnumerable<long>
{
public static readonly long[] Value=A106177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106177.Bytes);
public long this[int i]=>Value[i];

public static A106177Inst Instance=new A106177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106178
{
public static readonly long[] Value={ 2L,3L,1L,1L,1L,4L,5L,2L,9L,1L,6L,1L,1L,1L,2L,7L,1L,25L,1L,3L,1L,1L,1L,36L,1L,2L,1L,8L,1L,1L,49L,1L,5L,1L,27L,1L,10L,3L,1L,1L,6L,1L,1L,1L,2L,11L,1L,1L,2L,7L,1L,125L,4L,3L,1L,3L,1L,100L,1L,1L,1L,216L,1L,1L,1L,4L,13L,2L,121L,1L,3L,1L,343L,1L,5L,1L,9L,1L,14L,1L,9L,1L,10L,1L,1L,1L,6L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106178Inst : IEnumerable<long>
{
public static readonly long[] Value=A106178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106178.Bytes);
public long this[int i]=>Value[i];

public static A106178Inst Instance=new A106178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106179
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,4L,10L,12L,6L,1L,5L,16L,29L,28L,11L,1L,6L,24L,57L,84L,66L,23L,1L,7L,33L,99L,192L,231L,157L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106179Inst : IEnumerable<long>
{
public static readonly long[] Value=A106179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106179.Bytes);
public long this[int i]=>Value[i];

public static A106179Inst Instance=new A106179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106180
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-1L,1L,1L,-1L,-1L,1L,0L,2L,-2L,-1L,1L,-2L,2L,3L,-3L,-1L,1L,0L,-5L,5L,4L,-4L,-1L,1L,5L,-5L,-9L,9L,5L,-5L,-1L,1L,0L,14L,-14L,-14L,14L,6L,-6L,-1L,1L,-14L,14L,28L,-28L,-20L,20L,7L,-7L,-1L,1L,0L,-42L,42L,48L,-48L,-27L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106180Inst : IEnumerable<long>
{
public static readonly long[] Value=A106180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106180.Bytes);
public long this[int i]=>Value[i];

public static A106180Inst Instance=new A106180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106181
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,2L,2L,-5L,-5L,14L,14L,-42L,-42L,132L,132L,-429L,-429L,1430L,1430L,-4862L,-4862L,16796L,16796L,-58786L,-58786L,208012L,208012L,-742900L,-742900L,2674440L,2674440L,-9694845L,-9694845L,35357670L,35357670L,-129644790L,-129644790L,477638700L,477638700L,-1767263190L,-1767263190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106181Inst : IEnumerable<long>
{
public static readonly long[] Value=A106181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106181.Bytes);
public long this[int i]=>Value[i];

public static A106181Inst Instance=new A106181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106182
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,14L,20L,32L,48L,60L,109L,138L,200L,296L,404L,576L,776L,1170L,1480L,2144L,2912L,3888L,5578L,7204L,10032L,13276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106182Inst : IEnumerable<long>
{
public static readonly long[] Value=A106182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106182.Bytes);
public long this[int i]=>Value[i];

public static A106182Inst Instance=new A106182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106183
{
public static readonly long[] Value={ 1L,2L,8L,24L,88L,304L,1120L,4096L,15328L,57536L,218112L,830208L,3176704L,12196352L,46982144L,181452800L,702465536L,2724948992L,10589474816L,41217216512L,160657903616L,627019489280L,2449986043904L,9583049572352L,37519931654144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106183Inst : IEnumerable<long>
{
public static readonly long[] Value=A106183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106183.Bytes);
public long this[int i]=>Value[i];

public static A106183Inst Instance=new A106183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106184
{
public static readonly long[] Value={ 1L,2L,10L,28L,118L,380L,1508L,5240L,20326L,73836L,284396L,1061128L,4085820L,15500120L,59820040L,229366768L,887943046L,3428967500L,13315684764L,51678099304L,201246353492L,783890932488L,3060144292600L,11953056489104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106184Inst : IEnumerable<long>
{
public static readonly long[] Value=A106184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106184.Bytes);
public long this[int i]=>Value[i];

public static A106184Inst Instance=new A106184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106185
{
public static readonly long[] Value={ 1L,2L,12L,32L,160L,480L,2208L,7104L,31104L,104960L,444928L,1554432L,6444544L,23112704L,94341120L,345243648L,1393754112L,5181456384L,20755267584L,78122680320L,311231840256L,1183024939008L,4695356866560L,17987367075840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106185Inst : IEnumerable<long>
{
public static readonly long[] Value=A106185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106185.Bytes);
public long this[int i]=>Value[i];

public static A106185Inst Instance=new A106185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106186
{
public static readonly long[] Value={ 1L,2L,4L,16L,64L,224L,800L,3008L,11392L,43008L,163328L,624640L,2397696L,9227264L,35608576L,137764864L,534102016L,2074394624L,8069922816L,31440338944L,122652655616L,479052693504L,1873097261056L,7331070869504L,28718945140736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106186Inst : IEnumerable<long>
{
public static readonly long[] Value=A106186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106186.Bytes);
public long this[int i]=>Value[i];

public static A106186Inst Instance=new A106186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106187
{
public static readonly long[] Value={ 1L,2L,1L,6L,2L,1L,20L,6L,2L,1L,70L,20L,6L,2L,1L,252L,70L,20L,6L,2L,1L,924L,252L,70L,20L,6L,2L,1L,3432L,924L,252L,70L,20L,6L,2L,1L,12870L,3432L,924L,252L,70L,20L,6L,2L,1L,48620L,12870L,3432L,924L,252L,70L,20L,6L,2L,1L,184756L,48620L,12870L,3432L,924L,252L,70L,20L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106187Inst : IEnumerable<long>
{
public static readonly long[] Value=A106187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106187.Bytes);
public long this[int i]=>Value[i];

public static A106187Inst Instance=new A106187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106188
{
public static readonly long[] Value={ 1L,2L,7L,22L,77L,274L,1001L,3706L,13871L,52326L,198627L,757758L,2902783L,11158358L,43019383L,166275878L,644099773L,2499882098L,9719235073L,37845145898L,147565763893L,576103020338L,2251664727613L,8809533747938L,34499268410713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106188Inst : IEnumerable<long>
{
public static readonly long[] Value=A106188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106188.Bytes);
public long this[int i]=>Value[i];

public static A106188Inst Instance=new A106188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106189
{
public static readonly long[] Value={ 1L,2L,8L,24L,86L,300L,1096L,4032L,15062L,56684L,214880L,818800L,3133916L,12038200L,46384432L,179193920L,693849254L,2691994060L,10462833808L,40729251920L,158772196436L,619716378280L,2421643356592L,9472863484160L,37090890396284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106189Inst : IEnumerable<long>
{
public static readonly long[] Value=A106189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106189.Bytes);
public long this[int i]=>Value[i];

public static A106189Inst Instance=new A106189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106190
{
public static readonly long[] Value={ 1L,-2L,1L,-2L,-2L,1L,-4L,-2L,-2L,1L,-10L,-4L,-2L,-2L,1L,-28L,-10L,-4L,-2L,-2L,1L,-84L,-28L,-10L,-4L,-2L,-2L,1L,-264L,-84L,-28L,-10L,-4L,-2L,-2L,1L,-858L,-264L,-84L,-28L,-10L,-4L,-2L,-2L,1L,-2860L,-858L,-264L,-84L,-28L,-10L,-4L,-2L,-2L,1L,-9724L,-2860L,-858L,-264L,-84L,-28L,-10L,-4L,-2L,-2L,1L,-33592L,-9724L,-2860L,-858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106190Inst : IEnumerable<long>
{
public static readonly long[] Value=A106190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106190.Bytes);
public long this[int i]=>Value[i];

public static A106190Inst Instance=new A106190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106191
{
public static readonly long[] Value={ 1L,-1L,-3L,-7L,-17L,-45L,-129L,-393L,-1251L,-4111L,-13835L,-47427L,-164999L,-581023L,-2066823L,-7415703L,-26805393L,-97520733L,-356810313L,-1312087713L,-4846614093L,-17974854933L,-66907388973L,-249872516253L,-935991743553L,-3515800038201L,-13239692841105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106191Inst : IEnumerable<long>
{
public static readonly long[] Value=A106191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106191.Bytes);
public long this[int i]=>Value[i];

public static A106191Inst Instance=new A106191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106192
{
public static readonly long[] Value={ 1L,-2L,-1L,-6L,-11L,-34L,-95L,-298L,-953L,-3158L,-10677L,-36750L,-128249L,-452774L,-1614049L,-5801654L,-21003739L,-76516994L,-280293319L,-1031794394L,-3814819699L,-14160035234L,-52747353739L,-197125162514L,-738866581039L,-2776933457162L,-10462759383943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106192Inst : IEnumerable<long>
{
public static readonly long[] Value=A106192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106192.Bytes);
public long this[int i]=>Value[i];

public static A106192Inst Instance=new A106192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106193
{
public static readonly long[] Value={ 1L,-2L,0L,-8L,-10L,-44L,-104L,-352L,-1066L,-3564L,-11856L,-40720L,-141284L,-497464L,-1768368L,-6343808L,-22926426L,-83402956L,-305142432L,-1122083312L,-4144811244L,-15372407464L,-57222156528L,-213709942208L,-800563540356L,-3007228179064L,-11325019883616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106193Inst : IEnumerable<long>
{
public static readonly long[] Value=A106193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106193.Bytes);
public long this[int i]=>Value[i];

public static A106193Inst Instance=new A106193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106194
{
public static readonly long[] Value={ 1L,4L,1L,12L,5L,1L,32L,17L,6L,1L,80L,49L,23L,7L,1L,192L,129L,72L,30L,8L,1L,448L,321L,201L,102L,38L,9L,1L,1024L,769L,522L,303L,140L,47L,10L,1L,2304L,1793L,1291L,825L,443L,187L,57L,11L,1L,5120L,4097L,3084L,2116L,1268L,630L,244L,68L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106194Inst : IEnumerable<long>
{
public static readonly long[] Value=A106194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106194.Bytes);
public long this[int i]=>Value[i];

public static A106194Inst Instance=new A106194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106195
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,8L,8L,4L,1L,16L,20L,13L,5L,1L,32L,48L,38L,19L,6L,1L,64L,112L,104L,63L,26L,7L,1L,128L,256L,272L,192L,96L,34L,8L,1L,256L,576L,688L,552L,321L,138L,43L,9L,1L,512L,1280L,1696L,1520L,1002L,501L,190L,53L,10L,1L,1024L,2816L,4096L,4048L,2972L,1683L,743L,253L,64L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106195Inst : IEnumerable<long>
{
public static readonly long[] Value=A106195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106195.Bytes);
public long this[int i]=>Value[i];

public static A106195Inst Instance=new A106195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106196
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,5L,10L,8L,4L,1L,8L,20L,17L,11L,5L,1L,13L,38L,35L,24L,14L,6L,1L,21L,71L,68L,50L,31L,17L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106196Inst : IEnumerable<long>
{
public static readonly long[] Value=A106196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106196.Bytes);
public long this[int i]=>Value[i];

public static A106196Inst Instance=new A106196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106197
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106197Inst : IEnumerable<long>
{
public static readonly long[] Value=A106197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106197.Bytes);
public long this[int i]=>Value[i];

public static A106197Inst Instance=new A106197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106198
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,5L,3L,1L,5L,13L,10L,4L,1L,8L,34L,35L,17L,5L,1L,13L,89L,125L,75L,26L,6L,1L,21L,233L,450L,338L,139L,37L,7L,1L,34L,610L,1625L,1541L,757L,233L,50L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106198Inst : IEnumerable<long>
{
public static readonly long[] Value=A106198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106198.Bytes);
public long this[int i]=>Value[i];

public static A106198Inst Instance=new A106198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106199
{
public static readonly long[] Value={ 0L,0L,4L,15L,36L,103L,832L,187L,2500L,981L,5904L,133L,11944L,1018L,21716L,3551L,36568L,3859L,57936L,559L,87464L,6619L,127156L,37835L,178916L,52517L,245116L,71083L,328180L,94187L,430688L,122529L,555508L,156813L,705696L,98899L,884432L,123199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106199Inst : IEnumerable<long>
{
public static readonly long[] Value=A106199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106199.Bytes);
public long this[int i]=>Value[i];

public static A106199Inst Instance=new A106199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106200
{
public static readonly long[] Value={ 1L,1L,27L,64L,125L,324L,2401L,512L,6561L,2500L,14641L,324L,28561L,2401L,50625L,8192L,83521L,8748L,130321L,1250L,194481L,14641L,279841L,82944L,390625L,114244L,531441L,153664L,707281L,202500L,923521L,262144L,1185921L,334084L,1500625L,209952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106200Inst : IEnumerable<long>
{
public static readonly long[] Value=A106200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106200.Bytes);
public long this[int i]=>Value[i];

public static A106200Inst Instance=new A106200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106201
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-3L,-11L,-23L,-39L,-43L,-3L,129L,417L,877L,1349L,1305L,-407L,-5627L,-16243L,-32079L,-46287L,-37987L,35285L,236873L,623609L,1162293L,1559837L,1009889L,-2034495L,-9728051L,-23660955L,-41633415L,-51467895L,-22390171L,101331373L,391586577L,887713361L,1473400829L,1653762805L,267778473L,-4669059303L,-15499500395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106201Inst : IEnumerable<long>
{
public static readonly long[] Value=A106201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106201.Bytes);
public long this[int i]=>Value[i];

public static A106201Inst Instance=new A106201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106202
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,6L,8L,2L,-20L,-66L,-144L,-230L,-236L,22L,856L,2610L,5308L,7918L,7104L,-4150L,-36636L,-100794L,-193368L,-269342L,-198772L,274974L,1522192L,3846778L,6966452L,8986230L,4917240L,-14538862L,-61860772L,-145127602L,-248063392L,-292843734L,-90180988L,692992166L,2468418888L,5415220546L,8722746156L,9258303102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106202Inst : IEnumerable<long>
{
public static readonly long[] Value=A106202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106202.Bytes);
public long this[int i]=>Value[i];

public static A106202Inst Instance=new A106202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106203
{
public static readonly BigInteger[] Value={ 1L,-41L,-11128L,-3785793L,-1476507895L,-618962022329L,-271503819749095L,-122857395553223337L,BigInteger.Parse("-56870247894888518054"),BigInteger.Parse("-26784343611333662213130"),BigInteger.Parse("-12787694574831980406719382"),BigInteger.Parse("-6172809198874485994313412898") };
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
public class A106203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106203Inst Instance=new A106203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106204
{
public static readonly long[] Value={ 1L,0L,2L,-1L,-14L,30L,140L,-434L,-1370L,6579L,13020L,-100040L,-101611L,1500338L,245954L,-22069601L,14502792L,316451640L,-480024439L,-4385787620L,10970363300L,57983545059L,-217649312794L,-714104478148L,3986473537118L,7776402179076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106204Inst : IEnumerable<long>
{
public static readonly long[] Value=A106204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106204.Bytes);
public long this[int i]=>Value[i];

public static A106204Inst Instance=new A106204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106205
{
public static readonly BigInteger[] Value={ 1L,31L,-2848L,413823L,-68767135L,12310047967L,-2309368876639L,447436508910495L,-88755684988520798L,17924937024841839390UL,BigInteger.Parse("-3671642907594608226078"),BigInteger.Parse("760722183234128461061246"),BigInteger.Parse("-159105706560247952472114973") };
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
public class A106205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106205Inst Instance=new A106205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106206
{
public static readonly BigInteger[] Value={ 1L,6L,-414L,38916L,-4144554L,472479156L,-56225019564L,6891580969416L,-863170516419354L,109910379090731076L,BigInteger.Parse("-14178438902704308804"),BigInteger.Parse("1848352853316179893176"),BigInteger.Parse("-243058400211077655952644") };
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
public class A106206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106206Inst Instance=new A106206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106207
{
public static readonly long[] Value={ 1L,-24L,4372L,96256L,1240002L,10698752L,74428120L,431529984L,2206741887L,10117578752L,42616961892L,166564106240L,611800208702L,2125795885056L,7040425608760L,22327393665024L,68134255043715L,200740384538624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106207Inst : IEnumerable<long>
{
public static readonly long[] Value=A106207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106207.Bytes);
public long this[int i]=>Value[i];

public static A106207Inst Instance=new A106207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106208
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,16L,10L,3L,1L,127L,78L,21L,4L,1L,1363L,832L,216L,36L,5L,1L,18628L,11342L,2901L,460L,55L,6L,1L,311250L,189286L,48081L,7456L,840L,78L,7L,1L,6173791L,3752320L,949800L,145660L,15955L,1386L,105L,8L,1L,142190703L,86392756L,21826470L,3327340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106208Inst : IEnumerable<long>
{
public static readonly long[] Value=A106208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106208.Bytes);
public long this[int i]=>Value[i];

public static A106208Inst Instance=new A106208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106209
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,231L,2453L,33393L,556999L,11039026L,254128870L,6677972615L,197547561340L,6504619941881L,236165840696980L,9380353293627619L,404848232250564042L,BigInteger.Parse("18875601922237847288"),BigInteger.Parse("945875935431064488637") };
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
public class A106209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106209Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106209.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106209Inst Instance=new A106209Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106210
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,16L,16L,5L,1L,127L,127L,39L,7L,1L,1363L,1363L,416L,72L,9L,1L,18628L,18628L,5671L,967L,115L,11L,1L,311250L,311250L,94643L,16027L,1864L,168L,13L,1L,6173791L,6173791L,1876160L,316600L,36415L,3191L,231L,15L,1L,142190703L,142190703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106210Inst : IEnumerable<long>
{
public static readonly long[] Value=A106210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106210.Bytes);
public long this[int i]=>Value[i];

public static A106210Inst Instance=new A106210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106211
{
public static readonly BigInteger[] Value={ 1L,2L,7L,38L,301L,3224L,44021L,735216L,14580195L,335762290L,8824804889L,261084641178L,8597298494025L,312159531050382L,12399137504630097L,535147013379083822L,BigInteger.Parse("24950976908580696095"),BigInteger.Parse("1250331101054276584968") };
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
public class A106211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106211Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106211.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106211Inst Instance=new A106211Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106212
{
public static readonly BigInteger[] Value={ 1L,0L,66L,512L,-4548L,-95232L,235896L,19184640L,71390982L,-3574929408L,-38686277880L,549355393536L,12560156358776L,-44726582455296L,-3304393480144896L,-11697847949288448L,730893806097007116L,7947401735635359744L,BigInteger.Parse("-128019618062747473590"),BigInteger.Parse("-2899743155552604891648") };
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
public class A106212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106212Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A106212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A106212.Bytes);
public BigInteger this[int i]=>Value[i];

public static A106212Inst Instance=new A106212Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106213
{
public static readonly long[] Value={ 0L,3L,6L,24L,33L,42L,45L,54L,60L,66L,69L,78L,87L,93L,102L,108L,111L,120L,129L,144L,153L,162L,165L,174L,183L,186L,195L,204L,213L,216L,225L,228L,231L,237L,240L,258L,261L,267L,279L,285L,300L,306L,312L,321L,333L,336L,351L,363L,366L,384L,390L,408L,414L,417L,420L,429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106213Inst : IEnumerable<long>
{
public static readonly long[] Value=A106213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106213.Bytes);
public long this[int i]=>Value[i];

public static A106213Inst Instance=new A106213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106214
{
public static readonly long[] Value={ 9L,21L,27L,48L,51L,72L,75L,81L,96L,105L,114L,117L,123L,126L,132L,135L,147L,156L,159L,177L,180L,189L,198L,201L,207L,222L,234L,252L,255L,264L,273L,288L,291L,294L,309L,315L,324L,339L,357L,360L,378L,387L,393L,399L,402L,432L,438L,444L,450L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106214Inst : IEnumerable<long>
{
public static readonly long[] Value=A106214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106214.Bytes);
public long this[int i]=>Value[i];

public static A106214Inst Instance=new A106214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106215
{
public static readonly long[] Value={ 2L,5L,17L,24L,94L,107L,315L,334L,752L,781L,1651L,1688L,3168L,3211L,5189L,5242L,8316L,8377L,12403L,12474L,17586L,17665L,24143L,24232L,32776L,32877L,43179L,43286L,54842L,54955L,69193L,69324L,87140L,87279L,107851L,108002L,131558L,131721L,158779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106215Inst : IEnumerable<long>
{
public static readonly long[] Value=A106215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106215.Bytes);
public long this[int i]=>Value[i];

public static A106215Inst Instance=new A106215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106216
{
public static readonly long[] Value={ 1L,3L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106216Inst : IEnumerable<long>
{
public static readonly long[] Value=A106216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106216.Bytes);
public long this[int i]=>Value[i];

public static A106216Inst Instance=new A106216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106217
{
public static readonly long[] Value={ 0L,3L,24L,30L,48L,57L,63L,72L,81L,99L,105L,114L,120L,129L,132L,135L,141L,147L,156L,159L,168L,177L,180L,195L,198L,201L,204L,207L,210L,222L,243L,249L,252L,261L,267L,279L,282L,285L,297L,309L,312L,315L,327L,333L,342L,351L,375L,387L,393L,399L,402L,408L,411L,414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106217Inst : IEnumerable<long>
{
public static readonly long[] Value=A106217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106217.Bytes);
public long this[int i]=>Value[i];

public static A106217Inst Instance=new A106217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106218
{
public static readonly long[] Value={ 6L,9L,12L,21L,27L,33L,69L,75L,84L,87L,93L,96L,111L,123L,126L,162L,165L,192L,225L,228L,231L,234L,237L,240L,264L,270L,273L,276L,288L,300L,306L,318L,321L,339L,345L,354L,357L,360L,378L,381L,384L,390L,417L,426L,429L,432L,438L,441L,447L,453L,468L,471L,474L,477L,483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106218Inst : IEnumerable<long>
{
public static readonly long[] Value=A106218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106218.Bytes);
public long this[int i]=>Value[i];

public static A106218Inst Instance=new A106218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106219
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-4L,9L,-21L,53L,-137L,362L,-971L,2642L,-7272L,20211L,-56631L,159795L,-453650L,1294797L,-3713100L,10693036L,-30910440L,89657680L,-260860962L,761114168L,-2226409022L,6528039545L,-19182376302L,56479676608L,-166605140314L,492304708589L,-1457061274821L,4318906269671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106219Inst : IEnumerable<long>
{
public static readonly long[] Value=A106219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106219.Bytes);
public long this[int i]=>Value[i];

public static A106219Inst Instance=new A106219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106220
{
public static readonly long[] Value={ 1L,4L,2L,0L,3L,0L,2L,0L,1L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,3L,0L,0L,0L,3L,0L,2L,0L,3L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,3L,0L,0L,0L,3L,0L,0L,0L,0L,0L,2L,0L,3L,0L,2L,0L,1L,0L,0L,0L,3L,0L,0L,0L,3L,0L,0L,0L,3L,0L,2L,0L,1L,0L,2L,0L,3L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106220Inst : IEnumerable<long>
{
public static readonly long[] Value=A106220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106220.Bytes);
public long this[int i]=>Value[i];

public static A106220Inst Instance=new A106220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106221
{
public static readonly long[] Value={ 1L,1L,-1L,2L,-4L,10L,-26L,71L,-199L,569L,-1652L,4855L,-14413L,43153L,-130143L,394967L,-1205268L,3695771L,-11381215L,35183209L,-109138163L,339599993L,-1059702401L,3315256789L,-10396158911L,32671424776L,-102879610571L,324557399534L,-1025643986057L,3246330348415L,-10290418283163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106221Inst : IEnumerable<long>
{
public static readonly long[] Value=A106221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106221.Bytes);
public long this[int i]=>Value[i];

public static A106221Inst Instance=new A106221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106222
{
public static readonly long[] Value={ 1L,5L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,1L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,4L,0L,0L,0L,0L,4L,0L,0L,0L,0L,2L,0L,0L,0L,0L,3L,0L,0L,0L,0L,3L,0L,0L,0L,0L,3L,0L,0L,0L,0L,4L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,4L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106222Inst : IEnumerable<long>
{
public static readonly long[] Value=A106222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106222.Bytes);
public long this[int i]=>Value[i];

public static A106222Inst Instance=new A106222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106223
{
public static readonly long[] Value={ 1L,1L,-2L,6L,-21L,80L,-320L,1326L,-5637L,24434L,-107541L,479192L,-2157027L,9792618L,-44780207L,206053429L,-953296364L,4431418833L,-20686477329L,96930426941L,-455717114981L,2149060994827L,-10162417338993L,48176297258115L,-228910042632050L,1089957826522693L,-5199911987465160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106223Inst : IEnumerable<long>
{
public static readonly long[] Value=A106223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106223.Bytes);
public long this[int i]=>Value[i];

public static A106223Inst Instance=new A106223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106224
{
public static readonly long[] Value={ 1L,6L,3L,2L,3L,0L,0L,0L,3L,4L,3L,0L,0L,0L,3L,2L,0L,0L,0L,0L,3L,2L,0L,0L,4L,0L,0L,2L,0L,0L,2L,0L,0L,0L,3L,0L,3L,0L,0L,4L,0L,0L,4L,0L,0L,4L,3L,0L,2L,0L,0L,4L,0L,0L,5L,0L,3L,2L,0L,0L,3L,0L,0L,0L,3L,0L,3L,0L,3L,0L,3L,0L,2L,0L,3L,0L,0L,0L,2L,0L,0L,0L,3L,0L,2L,0L,0L,0L,3L,0L,5L,0L,3L,0L,0L,0L,3L,0L,0L,0L,0L,0L,4L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106224Inst : IEnumerable<long>
{
public static readonly long[] Value=A106224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106224.Bytes);
public long this[int i]=>Value[i];

public static A106224Inst Instance=new A106224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106225
{
public static readonly long[] Value={ 1L,1L,-2L,7L,-27L,114L,-506L,2322L,-10919L,52316L,-254369L,1251563L,-6218656L,31153743L,-157167147L,797682007L,-4069817562L,20860266354L,-107358128720L,554533772363L,-2873667741743L,14935575580894L,-77833224795929L,406595414780038L,-2128748177726089L,11167899337858904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106225Inst : IEnumerable<long>
{
public static readonly long[] Value=A106225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106225.Bytes);
public long this[int i]=>Value[i];

public static A106225Inst Instance=new A106225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106226
{
public static readonly long[] Value={ 1L,7L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106226Inst : IEnumerable<long>
{
public static readonly long[] Value=A106226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106226.Bytes);
public long this[int i]=>Value[i];

public static A106226Inst Instance=new A106226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106227
{
public static readonly long[] Value={ 1L,1L,-3L,13L,-65L,351L,-1989L,11650L,-69900L,427167L,-2648438L,16612947L,-105215448L,671760933L,-4318468133L,27926126547L,-181520036139L,1185220461607L,-7769787811032L,51117085986564L,-337373170566291L,2233091754693676L,-14819626688607761L,98582852441111688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106227Inst : IEnumerable<long>
{
public static readonly long[] Value=A106227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106227.Bytes);
public long this[int i]=>Value[i];

public static A106227Inst Instance=new A106227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106228
{
public static readonly long[] Value={ 1L,1L,2L,6L,21L,80L,322L,1347L,5798L,25512L,114236L,518848L,2384538L,11068567L,51817118L,244370806L,1159883685L,5536508864L,26560581688L,127993221140L,619280193640L,3007251366000L,14651743202152L,71601107803904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106228Inst : IEnumerable<long>
{
public static readonly long[] Value=A106228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106228.Bytes);
public long this[int i]=>Value[i];

public static A106228Inst Instance=new A106228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106229
{
public static readonly long[] Value={ 5L,19L,11L,35L,79L,149L,251L,391L,575L,809L,1099L,1451L,1871L,2365L,2939L,3539L,4251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106229Inst : IEnumerable<long>
{
public static readonly long[] Value=A106229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106229.Bytes);
public long this[int i]=>Value[i];

public static A106229Inst Instance=new A106229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106230
{
public static readonly long[] Value={ 3L,8L,3L,8L,15L,24L,35L,48L,63L,80L,99L,120L,143L,168L,195L,224L,255L,288L,323L,360L,399L,440L,483L,528L,575L,624L,675L,728L,783L,840L,899L,960L,1023L,1088L,1155L,1224L,1295L,1368L,1443L,1520L,1599L,1680L,1763L,1848L,1935L,2024L,2115L,2208L,2303L,2400L,2499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106230Inst : IEnumerable<long>
{
public static readonly long[] Value=A106230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106230.Bytes);
public long this[int i]=>Value[i];

public static A106230Inst Instance=new A106230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106231
{
public static readonly long[] Value={ 11L,19L,77L,199L,409L,731L,1189L,1807L,2609L,3619L,4861L,6359L,8137L,10219L,12629L,15391L,18529L,22067L,26029L,30439L,35321L,40699L,46597L,53039L,60049L,67651L,75869L,84727L,94249L,104459L,115381L,127039L,139457L,152659L,166669L,181511L,197209L,213787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106231Inst : IEnumerable<long>
{
public static readonly long[] Value=A106231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106231.Bytes);
public long this[int i]=>Value[i];

public static A106231Inst Instance=new A106231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106232
{
public static readonly long[] Value={ 4L,4L,12L,24L,40L,60L,84L,112L,144L,180L,220L,264L,312L,364L,420L,480L,544L,612L,684L,760L,840L,924L,1012L,1104L,1200L,1300L,1404L,1512L,1624L,1740L,1860L,1984L,2112L,2244L,2380L,2520L,2664L,2812L,2964L,3120L,3280L,3444L,3612L,3784L,3960L,4140L,4324L,4512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106232Inst : IEnumerable<long>
{
public static readonly long[] Value=A106232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106232.Bytes);
public long this[int i]=>Value[i];

public static A106232Inst Instance=new A106232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106233
{
public static readonly long[] Value={ 0L,1L,3L,5L,5L,0L,-14L,-41L,-81L,-121L,-121L,0L,364L,1093L,2187L,3281L,3281L,0L,-9842L,-29525L,-59049L,-88573L,-88573L,0L,265720L,797161L,1594323L,2391485L,2391485L,0L,-7174454L,-21523361L,-43046721L,-64570081L,-64570081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106233Inst : IEnumerable<long>
{
public static readonly long[] Value=A106233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106233.Bytes);
public long this[int i]=>Value[i];

public static A106233Inst Instance=new A106233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106234
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,4L,3L,1L,1L,0L,9L,6L,3L,1L,1L,0L,20L,16L,7L,3L,1L,1L,0L,48L,37L,18L,7L,3L,1L,1L,0L,115L,96L,44L,19L,7L,3L,1L,1L,0L,286L,239L,117L,46L,19L,7L,3L,1L,1L,0L,719L,622L,299L,124L,47L,19L,7L,3L,1L,1L,0L,1842L,1607L,793L,320L,126L,47L,19L,7L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106234Inst : IEnumerable<long>
{
public static readonly long[] Value=A106234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106234.Bytes);
public long this[int i]=>Value[i];

public static A106234Inst Instance=new A106234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106235
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,0L,4L,1L,0L,0L,9L,2L,0L,0L,0L,20L,7L,1L,0L,0L,0L,48L,17L,2L,0L,0L,0L,0L,115L,48L,7L,1L,0L,0L,0L,0L,286L,124L,21L,2L,0L,0L,0L,0L,0L,719L,336L,60L,7L,1L,0L,0L,0L,0L,0L,1842L,888L,171L,21L,2L,0L,0L,0L,0L,0L,0L,4766L,2393L,488L,65L,7L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106235Inst : IEnumerable<long>
{
public static readonly long[] Value=A106235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106235.Bytes);
public long this[int i]=>Value[i];

public static A106235Inst Instance=new A106235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106236
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,0L,4L,2L,0L,0L,9L,6L,0L,0L,0L,20L,13L,2L,0L,0L,0L,48L,37L,4L,0L,0L,0L,0L,115L,86L,17L,0L,0L,0L,0L,0L,286L,239L,46L,0L,0L,0L,0L,0L,0L,719L,577L,142L,8L,0L,0L,0L,0L,0L,0L,1842L,1607L,367L,18L,0L,0L,0L,0L,0L,0L,0L,4766L,4025L,1136L,76L,0L,0L,0L,0L,0L,0L,0L,0L,12486L,11185L,2945L,248L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106236Inst : IEnumerable<long>
{
public static readonly long[] Value=A106236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106236.Bytes);
public long this[int i]=>Value[i];

public static A106236Inst Instance=new A106236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106237
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,2L,1L,0L,0L,3L,3L,0L,0L,0L,6L,5L,1L,0L,0L,0L,11L,11L,2L,0L,0L,0L,0L,23L,20L,5L,0L,0L,0L,0L,0L,47L,46L,11L,0L,0L,0L,0L,0L,0L,106L,93L,26L,2L,0L,0L,0L,0L,0L,0L,235L,216L,58L,3L,0L,0L,0L,0L,0L,0L,0L,551L,467L,139L,12L,0L,0L,0L,0L,0L,0L,0L,0L,1301L,1121L,307L,29L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106237Inst : IEnumerable<long>
{
public static readonly long[] Value=A106237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106237.Bytes);
public long this[int i]=>Value[i];

public static A106237Inst Instance=new A106237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106238
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,1L,83L,6L,1L,1L,5048L,88L,6L,1L,1L,1047008L,5146L,89L,6L,1L,1L,705422362L,1052471L,5151L,89L,6L,1L,1L,1580348371788L,706498096L,1052569L,5152L,89L,6L,1L,1L,12139024825260556L,1581059448174L,706503594L,1052574L,5152L,89L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106238Inst : IEnumerable<long>
{
public static readonly long[] Value=A106238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106238.Bytes);
public long this[int i]=>Value[i];

public static A106238Inst Instance=new A106238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106239
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,15L,0L,0L,0L,222L,0L,0L,0L,0L,3660L,10L,0L,0L,0L,0L,68295L,525L,0L,0L,0L,0L,0L,1436568L,20307L,0L,0L,0L,0L,0L,0L,33779340L,727020L,280L,0L,0L,0L,0L,0L,0L,880107840L,25934184L,31500L,0L,0L,0L,0L,0L,0L,0L,25201854045L,950478210L,2325015L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106239Inst : IEnumerable<long>
{
public static readonly long[] Value=A106239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106239.Bytes);
public long this[int i]=>Value[i];

public static A106239Inst Instance=new A106239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106240
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,5L,3L,1L,1L,12L,7L,3L,1L,1L,33L,20L,8L,3L,1L,1L,90L,55L,22L,8L,3L,1L,1L,261L,162L,63L,23L,8L,3L,1L,1L,766L,477L,188L,65L,23L,8L,3L,1L,1L,2312L,1450L,564L,196L,66L,23L,8L,3L,1L,1L,7068L,4446L,1732L,590L,198L,66L,23L,8L,3L,1L,1L,21965L,13858L,5384L,1824L,598L,199L,66L,23L,8L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106240Inst : IEnumerable<long>
{
public static readonly long[] Value=A106240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106240.Bytes);
public long this[int i]=>Value[i];

public static A106240Inst Instance=new A106240Inst();

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