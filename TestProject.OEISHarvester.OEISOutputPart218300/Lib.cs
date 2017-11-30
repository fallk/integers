using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A256682
{
public static readonly long[] Value={ 4L,6L,5L,3L,2L,3L,7L,7L,6L,1L,7L,4L,3L,1L,4L,2L,4L,4L,1L,7L,1L,4L,5L,9L,8L,1L,5L,1L,1L,4L,8L,2L,0L,7L,3L,6L,3L,7L,1L,9L,0L,6L,9L,4L,1L,6L,1L,3L,3L,8L,6L,8L,5L,5L,5L,1L,7L,2L,5L,8L,6L,8L,0L,7L,9L,5L,4L,1L,5L,6L,5L,4L,0L,7L,5L,8L,8L,6L,7L,9L,1L,7L,0L,0L,3L,0L,9L,3L,6L,3L,8L,1L,7L,9L,4L,4L,6L,7L,6L,3L,8L,0L,1L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256682Inst : IEnumerable<long>
{
public static readonly long[] Value=A256682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256682.Bytes);
public long this[int i]=>Value[i];

public static A256682Inst Instance=new A256682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256683
{
public static readonly long[] Value={ 5L,6L,6L,7L,1L,6L,2L,4L,4L,1L,5L,5L,6L,8L,8L,5L,5L,3L,5L,8L,4L,9L,4L,7L,4L,1L,7L,4L,5L,1L,8L,1L,5L,5L,4L,2L,4L,7L,1L,1L,7L,9L,5L,7L,8L,7L,6L,9L,4L,8L,4L,8L,8L,9L,3L,6L,7L,0L,4L,1L,9L,7L,3L,3L,3L,2L,6L,7L,8L,1L,4L,9L,4L,9L,9L,3L,8L,5L,8L,1L,4L,3L,4L,2L,8L,9L,1L,3L,3L,7L,7L,2L,7L,3L,3L,8L,7L,2L,2L,8L,5L,0L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256683Inst : IEnumerable<long>
{
public static readonly long[] Value=A256683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256683.Bytes);
public long this[int i]=>Value[i];

public static A256683Inst Instance=new A256683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256684
{
public static readonly long[] Value={ 6L,6L,7L,8L,4L,1L,8L,2L,1L,3L,0L,7L,3L,4L,2L,6L,7L,4L,2L,8L,2L,9L,8L,5L,5L,8L,8L,8L,6L,0L,2L,2L,0L,0L,0L,9L,9L,2L,0L,4L,6L,8L,6L,0L,1L,0L,1L,5L,0L,7L,6L,0L,1L,4L,3L,3L,9L,7L,5L,0L,1L,3L,1L,9L,8L,3L,4L,9L,5L,6L,1L,8L,2L,2L,9L,0L,5L,8L,7L,2L,6L,6L,6L,2L,0L,1L,5L,6L,2L,2L,6L,5L,8L,8L,9L,7L,4L,8L,1L,6L,0L,6L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256684Inst : IEnumerable<long>
{
public static readonly long[] Value=A256684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256684.Bytes);
public long this[int i]=>Value[i];

public static A256684Inst Instance=new A256684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256685
{
public static readonly long[] Value={ 7L,6L,8L,7L,7L,8L,8L,3L,2L,5L,0L,3L,1L,6L,2L,6L,0L,3L,7L,4L,4L,0L,0L,9L,8L,8L,9L,1L,8L,4L,3L,7L,0L,4L,9L,5L,3L,6L,8L,3L,8L,2L,1L,7L,9L,7L,8L,8L,2L,6L,4L,3L,3L,5L,9L,4L,0L,8L,4L,8L,6L,9L,9L,9L,1L,2L,5L,9L,7L,9L,4L,3L,4L,9L,4L,1L,7L,2L,7L,7L,6L,5L,6L,1L,3L,9L,0L,1L,9L,8L,2L,9L,5L,3L,2L,8L,1L,5L,8L,3L,1L,5L,7L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256685Inst : IEnumerable<long>
{
public static readonly long[] Value=A256685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256685.Bytes);
public long this[int i]=>Value[i];

public static A256685Inst Instance=new A256685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256686
{
public static readonly long[] Value={ 8L,6L,9L,5L,7L,6L,4L,1L,6L,3L,8L,1L,6L,4L,0L,1L,2L,6L,6L,4L,8L,8L,7L,7L,6L,1L,6L,0L,8L,0L,4L,6L,4L,5L,8L,2L,0L,2L,7L,2L,4L,3L,8L,0L,8L,4L,9L,6L,6L,7L,2L,8L,7L,8L,3L,2L,6L,6L,5L,7L,8L,8L,6L,7L,4L,7L,7L,7L,3L,8L,7L,1L,4L,2L,7L,7L,1L,8L,5L,9L,6L,1L,5L,8L,5L,7L,0L,0L,9L,5L,9L,3L,1L,8L,6L,5L,8L,6L,8L,8L,9L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256686Inst : IEnumerable<long>
{
public static readonly long[] Value=A256686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256686.Bytes);
public long this[int i]=>Value[i];

public static A256686Inst Instance=new A256686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256687
{
public static readonly long[] Value={ 9L,7L,0L,2L,6L,7L,2L,5L,4L,0L,0L,0L,1L,8L,6L,3L,7L,3L,6L,0L,8L,4L,4L,2L,6L,7L,6L,4L,8L,9L,4L,2L,1L,5L,3L,1L,8L,5L,7L,7L,5L,5L,0L,5L,9L,9L,8L,2L,1L,9L,1L,2L,4L,8L,6L,4L,3L,4L,9L,7L,4L,8L,4L,7L,9L,4L,5L,5L,5L,1L,2L,2L,7L,0L,3L,0L,0L,8L,6L,5L,3L,6L,3L,3L,8L,6L,9L,9L,7L,0L,5L,3L,0L,5L,7L,1L,2L,1L,9L,9L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256687Inst : IEnumerable<long>
{
public static readonly long[] Value=A256687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256687.Bytes);
public long this[int i]=>Value[i];

public static A256687Inst Instance=new A256687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256688
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,14L,2L,1L,1L,2L,1L,1L,1L,35L,1L,2L,1L,2L,1L,1L,1L,14L,2L,1L,14L,2L,1L,1L,1L,91L,1L,1L,1L,4L,1L,1L,1L,14L,1L,1L,1L,2L,2L,1L,1L,35L,2L,2L,1L,2L,1L,14L,1L,14L,1L,1L,1L,2L,1L,1L,2L,728L,1L,1L,1L,2L,1L,1L,1L,28L,1L,1L,2L,2L,1L,1L,1L,35L,35L,1L,1L,2L,1L,1L,1L,14L,1L,2L,1L,2L,1L,1L,1L,91L,1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256688Inst : IEnumerable<long>
{
public static readonly long[] Value=A256688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256688.Bytes);
public long this[int i]=>Value[i];

public static A256688Inst Instance=new A256688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256689
{
public static readonly long[] Value={ 1L,3L,3L,9L,3L,9L,3L,81L,9L,9L,3L,27L,3L,9L,9L,243L,3L,27L,3L,27L,9L,9L,3L,243L,9L,9L,81L,27L,3L,27L,3L,729L,9L,9L,9L,81L,3L,9L,9L,243L,3L,27L,3L,27L,27L,9L,3L,729L,9L,27L,9L,27L,3L,243L,9L,243L,9L,9L,3L,81L,3L,9L,27L,6561L,9L,27L,3L,27L,9L,27L,3L,729L,3L,9L,27L,27L,9L,27L,3L,729L,243L,9L,3L,81L,9L,9L,9L,243L,3L,81L,9L,27L,9L,9L,9L,2187L,3L,27L,27L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256689Inst : IEnumerable<long>
{
public static readonly long[] Value=A256689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256689.Bytes);
public long this[int i]=>Value[i];

public static A256689Inst Instance=new A256689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256690
{
public static readonly long[] Value={ 1L,1L,1L,5L,1L,1L,1L,15L,5L,1L,1L,5L,1L,1L,1L,195L,1L,5L,1L,5L,1L,1L,1L,15L,5L,1L,15L,5L,1L,1L,1L,663L,1L,1L,1L,25L,1L,1L,1L,15L,1L,1L,1L,5L,5L,1L,1L,195L,5L,5L,1L,5L,1L,15L,1L,15L,1L,1L,1L,5L,1L,1L,5L,4641L,1L,1L,1L,5L,1L,1L,1L,75L,1L,1L,5L,5L,1L,1L,1L,195L,195L,1L,1L,5L,1L,1L,1L,15L,1L,5L,1L,5L,1L,1L,1L,663L,1L,5L,5L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256690Inst : IEnumerable<long>
{
public static readonly long[] Value=A256690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256690.Bytes);
public long this[int i]=>Value[i];

public static A256690Inst Instance=new A256690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256691
{
public static readonly long[] Value={ 1L,4L,4L,32L,4L,16L,4L,128L,32L,16L,4L,128L,4L,16L,16L,2048L,4L,128L,4L,128L,16L,16L,4L,512L,32L,16L,128L,128L,4L,64L,4L,8192L,16L,16L,16L,1024L,4L,16L,16L,512L,4L,64L,4L,128L,128L,16L,4L,8192L,32L,128L,16L,128L,4L,512L,16L,512L,16L,16L,4L,512L,4L,16L,128L,65536L,16L,64L,4L,128L,16L,64L,4L,4096L,4L,16L,128L,128L,16L,64L,4L,8192L,2048L,16L,4L,512L,16L,16L,16L,512L,4L,512L,16L,128L,16L,16L,16L,32768L,4L,128L,128L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256691Inst : IEnumerable<long>
{
public static readonly long[] Value=A256691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256691.Bytes);
public long this[int i]=>Value[i];

public static A256691Inst Instance=new A256691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256692
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,1L,11L,3L,1L,1L,3L,1L,1L,1L,44L,1L,3L,1L,3L,1L,1L,1L,11L,3L,1L,11L,3L,1L,1L,1L,924L,1L,1L,1L,9L,1L,1L,1L,11L,1L,1L,1L,3L,3L,1L,1L,44L,3L,3L,1L,3L,1L,11L,1L,11L,1L,1L,1L,3L,1L,1L,3L,4004L,1L,1L,1L,3L,1L,1L,1L,33L,1L,1L,3L,3L,1L,1L,1L,44L,44L,1L,1L,3L,1L,1L,1L,11L,1L,3L,1L,3L,1L,1L,1L,924L,1L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256692Inst : IEnumerable<long>
{
public static readonly long[] Value=A256692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256692.Bytes);
public long this[int i]=>Value[i];

public static A256692Inst Instance=new A256692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256693
{
public static readonly long[] Value={ 1L,5L,5L,25L,5L,25L,5L,125L,25L,25L,5L,125L,5L,25L,25L,625L,5L,125L,5L,125L,25L,25L,5L,625L,25L,25L,125L,125L,5L,125L,5L,15625L,25L,25L,25L,625L,5L,25L,25L,625L,5L,125L,5L,125L,125L,25L,5L,3125L,25L,125L,25L,125L,5L,625L,25L,625L,25L,25L,5L,625L,5L,25L,125L,78125L,25L,125L,5L,125L,25L,125L,5L,3125L,5L,25L,125L,125L,25L,125L,5L,3125L,625L,25L,5L,625L,25L,25L,25L,625L,5L,625L,25L,125L,25L,25L,25L,78125L,5L,125L,125L,625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256693Inst : IEnumerable<long>
{
public static readonly long[] Value=A256693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256693.Bytes);
public long this[int i]=>Value[i];

public static A256693Inst Instance=new A256693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256694
{
public static readonly long[] Value={ 69L,70L,132L,138L,140L,153L,198L,207L,210L,216L,238L,252L,264L,264L,264L,270L,276L,280L,285L,290L,306L,345L,350L,390L,396L,396L,414L,420L,429L,432L,459L,476L,483L,490L,504L,504L,520L,528L,528L,528L,539L,540L,552L,560L,567L,570L,580L,594L,595L,612L,621L,630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256694Inst : IEnumerable<long>
{
public static readonly long[] Value=A256694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256694.Bytes);
public long this[int i]=>Value[i];

public static A256694Inst Instance=new A256694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256695
{
public static readonly long[] Value={ 12L,48L,108L,192L,300L,432L,588L,768L,972L,1008L,1200L,1452L,1728L,2028L,2352L,2448L,2520L,2700L,2772L,3060L,3072L,3468L,3888L,4032L,4332L,4800L,5292L,5808L,6348L,6912L,7500L,8112L,8748L,9072L,9408L,9792L,10080L,10092L,10800L,11088L,11532L,11628L,12240L,12288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256695Inst : IEnumerable<long>
{
public static readonly long[] Value=A256695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256695.Bytes);
public long this[int i]=>Value[i];

public static A256695Inst Instance=new A256695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256696
{
public static readonly long[] Value={ 0L,1L,2L,4L,-1L,4L,8L,-4L,1L,8L,-2L,8L,-1L,8L,16L,-8L,1L,16L,-8L,2L,16L,-8L,4L,-1L,16L,-4L,16L,-4L,1L,16L,-2L,16L,-1L,16L,32L,-16L,1L,32L,-16L,2L,32L,-16L,4L,-1L,32L,-16L,4L,32L,-16L,8L,-4L,1L,32L,-16L,8L,-2L,32L,-16L,8L,-1L,32L,-8L,32L,-8L,1L,32L,-8L,2L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256696Inst : IEnumerable<long>
{
public static readonly long[] Value=A256696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256696.Bytes);
public long this[int i]=>Value[i];

public static A256696Inst Instance=new A256696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256697
{
public static readonly long[] Value={ 0L,1L,-1L,3L,1L,-1L,6L,-3L,1L,-1L,10L,-1L,-3L,1L,-1L,15L,1L,-1L,-3L,1L,-1L,21L,-6L,1L,-1L,-3L,1L,-1L,28L,3L,-6L,1L,-1L,-3L,1L,-1L,36L,-1L,3L,-6L,1L,-1L,-3L,1L,-1L,45L,1L,-1L,3L,-6L,1L,-1L,-3L,1L,-1L,55L,-10L,1L,-1L,3L,-6L,1L,-1L,-3L,1L,-1L,66L,1L,-10L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256697Inst : IEnumerable<long>
{
public static readonly long[] Value=A256697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256697.Bytes);
public long this[int i]=>Value[i];

public static A256697Inst Instance=new A256697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256698
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,13L,15L,16L,19L,21L,23L,26L,28L,29L,31L,34L,36L,38L,40L,43L,45L,46L,48L,50L,53L,55L,57L,59L,61L,64L,66L,67L,69L,71L,73L,76L,78L,79L,80L,82L,84L,86L,89L,91L,93L,94L,96L,98L,100L,103L,105L,106L,108L,109L,111L,113L,115L,118L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256698Inst : IEnumerable<long>
{
public static readonly long[] Value=A256698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256698.Bytes);
public long this[int i]=>Value[i];

public static A256698Inst Instance=new A256698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256699
{
public static readonly long[] Value={ 2L,5L,7L,9L,11L,12L,14L,17L,18L,20L,22L,24L,25L,27L,30L,32L,33L,35L,37L,39L,41L,42L,44L,47L,49L,51L,52L,54L,56L,58L,60L,62L,63L,65L,68L,70L,72L,74L,75L,77L,81L,83L,85L,87L,88L,90L,92L,95L,97L,99L,101L,102L,104L,107L,110L,112L,114L,116L,117L,119L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256699Inst : IEnumerable<long>
{
public static readonly long[] Value=A256699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256699.Bytes);
public long this[int i]=>Value[i];

public static A256699Inst Instance=new A256699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256700
{
public static readonly long[] Value={ 1L,3L,3L,7L,6L,6L,10L,11L,10L,10L,18L,15L,16L,15L,15L,22L,24L,21L,22L,21L,21L,28L,29L,31L,28L,29L,28L,28L,39L,36L,37L,39L,36L,37L,36L,36L,48L,48L,45L,46L,48L,45L,46L,45L,45L,56L,58L,58L,55L,56L,58L,55L,56L,55L,55L,66L,67L,69L,69L,66L,67L,69L,66L,67L,66L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256700Inst : IEnumerable<long>
{
public static readonly long[] Value=A256700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256700.Bytes);
public long this[int i]=>Value[i];

public static A256700Inst Instance=new A256700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256701
{
public static readonly long[] Value={ 1L,2L,4L,4L,9L,8L,8L,8L,17L,18L,20L,16L,17L,16L,16L,16L,33L,34L,36L,36L,41L,40L,40L,32L,33L,34L,36L,32L,33L,32L,32L,32L,65L,66L,68L,68L,73L,72L,72L,72L,81L,82L,84L,80L,81L,80L,80L,64L,65L,66L,68L,68L,73L,72L,72L,64L,65L,66L,68L,64L,65L,64L,64L,64L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256701Inst : IEnumerable<long>
{
public static readonly long[] Value=A256701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256701.Bytes);
public long this[int i]=>Value[i];

public static A256701Inst Instance=new A256701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256702
{
public static readonly long[] Value={ 0L,0L,1L,0L,4L,2L,1L,0L,8L,8L,9L,4L,4L,2L,1L,0L,16L,16L,17L,16L,20L,18L,17L,8L,8L,8L,9L,4L,4L,2L,1L,0L,32L,32L,33L,32L,36L,34L,33L,32L,40L,40L,41L,36L,36L,34L,33L,16L,16L,16L,17L,16L,20L,18L,17L,8L,8L,8L,9L,4L,4L,2L,1L,0L,64L,64L,65L,64L,68L,66L,65L,64L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256702Inst : IEnumerable<long>
{
public static readonly long[] Value=A256702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256702.Bytes);
public long this[int i]=>Value[i];

public static A256702Inst Instance=new A256702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256703
{
public static readonly long[] Value={ 4L,292L,330L,615L,625L,744L,982L,1075L,1671L,2176L,2389L,2820L,2937L,3228L,3598L,4187L,6590L,7803L,9960L,10173L,11628L,13140L,13396L,14035L,15588L,16396L,17766L,18813L,19858L,21111L,21115L,21246L,22808L,23241L,24784L,25050L,25149L,25167L,25384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256703Inst : IEnumerable<long>
{
public static readonly long[] Value=A256703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256703.Bytes);
public long this[int i]=>Value[i];

public static A256703Inst Instance=new A256703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256704
{
public static readonly long[] Value={ 5L,505L,525L,545L,565L,585L,5005L,5225L,5445L,5665L,5885L,50005L,50105L,50205L,50305L,50405L,50505L,50605L,50705L,50805L,50905L,52025L,52125L,52225L,52325L,52425L,52525L,52625L,52725L,52825L,52925L,54045L,54145L,54245L,54345L,54445L,54545L,54645L,54745L,54845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256704Inst : IEnumerable<long>
{
public static readonly long[] Value=A256704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256704.Bytes);
public long this[int i]=>Value[i];

public static A256704Inst Instance=new A256704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256705
{
public static readonly long[] Value={ 9L,16L,25L,45L,49L,63L,75L,80L,81L,99L,112L,117L,121L,125L,128L,147L,153L,169L,171L,175L,176L,207L,208L,225L,243L,245L,250L,256L,261L,275L,279L,289L,304L,315L,325L,333L,343L,361L,363L,368L,369L,375L,387L,405L,423L,425L,441L,464L,475L,477L,486L,495L,496L,500L,507L,512L,525L,529L,531L,539L,549L,560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256705Inst : IEnumerable<long>
{
public static readonly long[] Value=A256705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256705.Bytes);
public long this[int i]=>Value[i];

public static A256705Inst Instance=new A256705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256706
{
public static readonly long[] Value={ 0L,1L,4L,12L,14L,39L,46L,54L,55L,94L,138L,155L,158L,183L,203L,256L,291L,295L,297L,299L,320L,323L,334L,426L,432L,446L,512L,579L,583L,695L,718L,799L,878L,943L,955L,959L,979L,1002L,1029L,1080L,1146L,1191L,1254L,1255L,1269L,1404L,1411L,1454L,1678L,1703L,1920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256706Inst : IEnumerable<long>
{
public static readonly long[] Value=A256706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256706.Bytes);
public long this[int i]=>Value[i];

public static A256706Inst Instance=new A256706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256707
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,5L,4L,3L,5L,5L,5L,3L,3L,5L,5L,5L,5L,3L,5L,6L,5L,2L,3L,5L,6L,2L,1L,3L,7L,4L,3L,4L,5L,5L,5L,3L,5L,3L,4L,3L,3L,5L,4L,3L,3L,4L,5L,2L,5L,4L,5L,6L,4L,5L,6L,5L,7L,3L,4L,5L,4L,6L,3L,3L,4L,4L,5L,3L,3L,2L,5L,5L,2L,4L,6L,7L,7L,4L,6L,6L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256707Inst : IEnumerable<long>
{
public static readonly long[] Value=A256707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256707.Bytes);
public long this[int i]=>Value[i];

public static A256707Inst Instance=new A256707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256708
{
public static readonly long[] Value={ 280L,508L,780L,805L,1028L,1078L,1280L,1308L,1680L,1780L,1805L,1840L,2078L,2608L,2680L,2780L,2800L,2801L,2802L,2805L,2840L,2850L,3280L,3580L,3780L,3805L,3808L,3850L,4048L,4078L,4280L,4780L,4804L,4805L,4880L,5008L,5018L,5028L,5048L,5078L,5080L,5084L,5180L,5280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256708Inst : IEnumerable<long>
{
public static readonly long[] Value=A256708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256708.Bytes);
public long this[int i]=>Value[i];

public static A256708Inst Instance=new A256708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256709
{
public static readonly long[] Value={ 509L,890L,903L,905L,930L,950L,960L,970L,980L,990L,1039L,1091L,1095L,1097L,1390L,1709L,1903L,1905L,1930L,1970L,1980L,1990L,2049L,2093L,2095L,2097L,2190L,2509L,2809L,2903L,2905L,2907L,2930L,2970L,2990L,3009L,3049L,3079L,3090L,3092L,3095L,3097L,3098L,3099L,3209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256709Inst : IEnumerable<long>
{
public static readonly long[] Value=A256709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256709.Bytes);
public long this[int i]=>Value[i];

public static A256709Inst Instance=new A256709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256710
{
public static readonly BigInteger[] Value={ 0L,1L,1L,1L,3L,19L,165L,1777L,22771L,338011L,5700645L,107636233L,2248959603L,51510798403L,1283272040869L,34545323506657L,999247837611315L,30907592318937451L,1017952050849713253L,BigInteger.Parse("35566506595102088953"),BigInteger.Parse("1313924839917077864755"),BigInteger.Parse("51171935743575832547539") };
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
public class A256710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256710Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256710.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256710.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256710Inst Instance=new A256710Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256711
{
public static readonly long[] Value={ 3L,8L,12L,17L,86L,146L,1428L,1949L,4809L,16922L,33102L,125792L,211610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256711Inst : IEnumerable<long>
{
public static readonly long[] Value=A256711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256711.Bytes);
public long this[int i]=>Value[i];

public static A256711Inst Instance=new A256711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256712
{
public static readonly long[] Value={ 2L,3L,13L,29L,89L,113L,199L,229L,263L,281L,317L,337L,349L,541L,593L,673L,683L,827L,857L,911L,929L,971L,997L,1069L,1109L,1291L,1399L,1481L,1657L,1693L,1733L,1759L,1783L,1877L,1907L,1931L,2003L,2053L,2089L,2377L,2543L,2551L,2777L,2903L,3011L,3023L,3041L,3089L,3181L,3251L,3361L,3617L,3671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256712Inst : IEnumerable<long>
{
public static readonly long[] Value=A256712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256712.Bytes);
public long this[int i]=>Value[i];

public static A256712Inst Instance=new A256712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256713
{
public static readonly long[] Value={ 6L,43L,252L,1262L,5511L,21152L,74042L,238684L,725685L,2104589L,5895064L,16057747L,42805464L,112213032L,290287667L,743123654L,1886919028L,4760112931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256713Inst : IEnumerable<long>
{
public static readonly long[] Value=A256713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256713.Bytes);
public long this[int i]=>Value[i];

public static A256713Inst Instance=new A256713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256714
{
public static readonly long[] Value={ 4L,19L,73L,217L,547L,1106L,2009L,3330L,5417L,8260L,12540L,18642L,27527L,40722L,59550L,86879L,125491L,181837L,262975L,380342L,551367L,798045L,1155637L,1673351L,2425756L,3518191L,5106563L,7410173L,10763697L,15634003L,22716117L,33022641L,48024049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256714Inst : IEnumerable<long>
{
public static readonly long[] Value=A256714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256714.Bytes);
public long this[int i]=>Value[i];

public static A256714Inst Instance=new A256714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256715
{
public static readonly long[] Value={ 4L,15L,33L,46L,67L,75L,76L,64L,77L,69L,75L,72L,75L,96L,121L,137L,127L,139L,152L,153L,161L,159L,155L,165L,184L,188L,206L,218L,211L,232L,238L,244L,261L,263L,267L,291L,290L,298L,301L,326L,318L,326L,334L,343L,335L,334L,349L,371L,420L,439L,451L,465L,474L,485L,524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256715Inst : IEnumerable<long>
{
public static readonly long[] Value=A256715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256715.Bytes);
public long this[int i]=>Value[i];

public static A256715Inst Instance=new A256715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256716
{
public static readonly long[] Value={ 0L,1L,25L,94L,230L,455L,791L,1260L,1884L,2685L,3685L,4906L,6370L,8099L,10115L,12440L,15096L,18105L,21489L,25270L,29470L,34111L,39215L,44804L,50900L,57525L,64701L,72450L,80794L,89755L,99355L,109616L,120560L,132209L,144585L,157710L,171606L,186295L,201799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256716Inst : IEnumerable<long>
{
public static readonly long[] Value=A256716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256716.Bytes);
public long this[int i]=>Value[i];

public static A256716Inst Instance=new A256716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256717
{
public static readonly long[] Value={ 1L,0L,6L,5L,0L,4L,4L,5L,3L,8L,5L,3L,0L,9L,5L,5L,7L,1L,7L,1L,5L,9L,7L,1L,7L,5L,8L,3L,6L,9L,4L,9L,7L,7L,1L,4L,1L,9L,3L,7L,3L,4L,9L,0L,7L,3L,2L,6L,9L,7L,6L,1L,8L,9L,2L,2L,2L,1L,3L,9L,9L,3L,1L,5L,2L,0L,0L,4L,3L,8L,3L,7L,6L,1L,6L,8L,6L,0L,2L,2L,4L,4L,7L,6L,4L,6L,1L,5L,2L,5L,1L,0L,9L,9L,2L,8L,1L,4L,9L,1L,9L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256717Inst : IEnumerable<long>
{
public static readonly long[] Value=A256717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256717.Bytes);
public long this[int i]=>Value[i];

public static A256717Inst Instance=new A256717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256718
{
public static readonly long[] Value={ 0L,1L,24L,90L,220L,435L,756L,1204L,1800L,2565L,3520L,4686L,6084L,7735L,9660L,11880L,14416L,17289L,20520L,24130L,28140L,32571L,37444L,42780L,48600L,54925L,61776L,69174L,77140L,85695L,94860L,104656L,115104L,126225L,138040L,150570L,163836L,177859L,192660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256718Inst : IEnumerable<long>
{
public static readonly long[] Value=A256718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256718.Bytes);
public long this[int i]=>Value[i];

public static A256718Inst Instance=new A256718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256719
{
public static readonly long[] Value={ 1L,4L,0L,4L,0L,7L,1L,4L,8L,3L,4L,8L,3L,0L,0L,8L,7L,2L,6L,8L,1L,2L,1L,8L,4L,2L,8L,4L,5L,7L,6L,4L,6L,8L,7L,0L,6L,8L,0L,8L,0L,1L,1L,3L,5L,7L,2L,8L,6L,8L,9L,7L,0L,1L,4L,3L,1L,0L,2L,6L,2L,8L,7L,7L,4L,8L,6L,3L,7L,0L,0L,4L,8L,6L,4L,2L,3L,0L,6L,5L,5L,2L,5L,0L,7L,7L,6L,6L,7L,3L,2L,0L,0L,9L,6L,1L,8L,8L,1L,3L,5L,3L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256719Inst : IEnumerable<long>
{
public static readonly long[] Value=A256719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256719.Bytes);
public long this[int i]=>Value[i];

public static A256719Inst Instance=new A256719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256720
{
public static readonly long[] Value={ 2L,4L,5L,5L,6L,6L,7L,2L,1L,9L,3L,7L,4L,7L,9L,9L,0L,4L,6L,5L,0L,2L,0L,4L,0L,5L,3L,6L,0L,9L,6L,0L,4L,2L,6L,8L,0L,8L,9L,6L,2L,4L,1L,9L,7L,2L,1L,3L,6L,2L,8L,8L,0L,6L,7L,7L,5L,4L,9L,7L,0L,9L,2L,1L,2L,0L,1L,1L,8L,8L,0L,4L,8L,4L,7L,7L,2L,3L,7L,4L,8L,9L,5L,1L,2L,0L,1L,4L,6L,9L,5L,3L,6L,6L,3L,5L,7L,5L,1L,9L,1L,1L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256720Inst : IEnumerable<long>
{
public static readonly long[] Value=A256720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256720.Bytes);
public long this[int i]=>Value[i];

public static A256720Inst Instance=new A256720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256721
{
public static readonly long[] Value={ 1L,6L,10L,34L,36L,370L,8256L,13290L,14724L,427912L,685224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256721Inst : IEnumerable<long>
{
public static readonly long[] Value=A256721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256721.Bytes);
public long this[int i]=>Value[i];

public static A256721Inst Instance=new A256721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256722
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,11L,18L,20L,29L,39L,123L,153L,267L,327L,627L,1020L,1686L,1764L,2960L,18236L,34613L,53991L,67404L,119880L,221654L,230706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256722Inst : IEnumerable<long>
{
public static readonly long[] Value=A256722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256722.Bytes);
public long this[int i]=>Value[i];

public static A256722Inst Instance=new A256722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256723
{
public static readonly long[] Value={ 2L,5L,8L,18L,38L,1919L,1934L,4250L,4397L,12626L,13151L,26693L,81353L,83916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256723Inst : IEnumerable<long>
{
public static readonly long[] Value=A256723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256723.Bytes);
public long this[int i]=>Value[i];

public static A256723Inst Instance=new A256723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256724
{
public static readonly long[] Value={ 1L,2L,8L,56L,675470L,718580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256724Inst : IEnumerable<long>
{
public static readonly long[] Value=A256724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256724.Bytes);
public long this[int i]=>Value[i];

public static A256724Inst Instance=new A256724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256725
{
public static readonly long[] Value={ 1L,3L,4L,7L,60L,394L,552L,1164L,1494L,5398L,7899L,11254L,13224L,77637L,118324L,120574L,142425L,142699L,157792L,188164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256725Inst : IEnumerable<long>
{
public static readonly long[] Value=A256725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256725.Bytes);
public long this[int i]=>Value[i];

public static A256725Inst Instance=new A256725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256726
{
public static readonly long[] Value={ 3L,4L,7L,12L,15L,48L,87L,138L,342L,675L,901L,1323L,1362L,1485L,1909L,9498L,10941L,11563L,16308L,37495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256726Inst : IEnumerable<long>
{
public static readonly long[] Value=A256726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256726.Bytes);
public long this[int i]=>Value[i];

public static A256726Inst Instance=new A256726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256727
{
public static readonly BigInteger[] Value={ 384L,21904L,2267136L,635846656L,369798053888L,518482372363264L,1660456237166444544L,BigInteger.Parse("12360763736706787835904"),BigInteger.Parse("213138208143073867255382016"),BigInteger.Parse("8574203840471307169557947613184"),BigInteger.Parse("794898094262223266831863119010856960") };
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
public class A256727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256727Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256727.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256727.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256727Inst Instance=new A256727Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256728
{
public static readonly long[] Value={ 384L,2304L,13056L,73984L,413440L,2310400L,12865280L,71639296L,398552832L,2217279744L,12332535552L,68593705216L,381495652096L,2121753477376L,11800309124864L,65628404490496L,364996358434560L,2029949420601600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256728Inst : IEnumerable<long>
{
public static readonly long[] Value=A256728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256728.Bytes);
public long this[int i]=>Value[i];

public static A256728Inst Instance=new A256728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256729
{
public static readonly long[] Value={ 2304L,21904L,186624L,1648656L,14137600L,122323600L,1047687424L,9002973456L,77177284864L,662446232464L,5681548960000L,48744134890000L,418086024911104L,3586417795077264L,30762931758747904L,263883025624611600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256729Inst : IEnumerable<long>
{
public static readonly long[] Value=A256729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256729.Bytes);
public long this[int i]=>Value[i];

public static A256729Inst Instance=new A256729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256730
{
public static readonly long[] Value={ 13056L,186624L,2267136L,30294016L,388595712L,5101387776L,65927512064L,859759181824L,11156772618240L,145188233150464L,1886191427256320L,24528150473998336L,318786248816721920L,4144523593872572416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256730Inst : IEnumerable<long>
{
public static readonly long[] Value=A256730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256730.Bytes);
public long this[int i]=>Value[i];

public static A256730Inst Instance=new A256730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256731
{
public static readonly BigInteger[] Value={ 73984L,1648656L,30294016L,635846656L,12465275904L,249872016384L,4910514177024L,97652975330304L,1928407075431424L,38241122864997376L,755959578691609600L,14964039006030816256UL,BigInteger.Parse("295846953794462196736"),BigInteger.Parse("5852653217025122329600") };
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
public class A256731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256731.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256731Inst Instance=new A256731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256732
{
public static readonly BigInteger[] Value={ 413440L,14137600L,388595712L,12465275904L,369798053888L,11265313555456L,337855448236032L,10232633445990400L,307652425443164160L,9286825801707749376UL,BigInteger.Parse("279497997763831857152"),BigInteger.Parse("8426534426750002397184") };
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
public class A256732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256732Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256732.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256732.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256732Inst Instance=new A256732Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256733
{
public static readonly BigInteger[] Value={ 2310400L,122323600L,5101387776L,249872016384L,11265313555456L,518482372363264L,23679083944969216L,1087948930038793216L,BigInteger.Parse("49833394812336710656"),BigInteger.Parse("2289420346251101357056"),BigInteger.Parse("104989233738265588491264") };
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
public class A256733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256733Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256733.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256733.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256733Inst Instance=new A256733Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256734
{
public static readonly BigInteger[] Value={ 12865280L,1047687424L,65927512064L,4910514177024L,337855448236032L,23679083944969216L,1660456237166444544L,BigInteger.Parse("116231639047144574976"),BigInteger.Parse("8123935526478378696704"),BigInteger.Parse("568293011012555646713856") };
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
public class A256734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256734Inst Instance=new A256734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256735
{
public static readonly long[] Value={ 384L,2304L,2304L,13056L,21904L,13056L,73984L,186624L,186624L,73984L,413440L,1648656L,2267136L,1648656L,413440L,2310400L,14137600L,30294016L,30294016L,14137600L,2310400L,12865280L,122323600L,388595712L,635846656L,388595712L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256735Inst : IEnumerable<long>
{
public static readonly long[] Value=A256735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256735.Bytes);
public long this[int i]=>Value[i];

public static A256735Inst Instance=new A256735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256736
{
public static readonly long[] Value={ 1L,3L,3L,3L,1L,3L,3L,5L,5L,1L,3L,7L,1L,1L,13L,5L,9L,5L,3L,5L,9L,3L,11L,3L,3L,1L,5L,5L,5L,1L,13L,1L,13L,9L,3L,7L,5L,5L,3L,9L,9L,5L,5L,3L,3L,7L,7L,5L,1L,5L,5L,1L,9L,5L,5L,3L,11L,1L,5L,1L,3L,7L,7L,7L,5L,7L,3L,3L,9L,1L,1L,1L,13L,1L,13L,1L,19L,7L,7L,5L,13L,5L,7L,11L,5L,9L,5L,1L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256736Inst : IEnumerable<long>
{
public static readonly long[] Value=A256736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256736.Bytes);
public long this[int i]=>Value[i];

public static A256736Inst Instance=new A256736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256737
{
public static readonly long[] Value={ 0L,1L,1L,1L,5L,5L,1L,5L,1L,3L,5L,5L,3L,3L,3L,3L,1L,1L,5L,5L,1L,1L,1L,11L,1L,5L,9L,5L,1L,3L,9L,3L,3L,5L,1L,5L,5L,3L,7L,7L,1L,1L,3L,7L,1L,11L,3L,3L,11L,17L,9L,5L,5L,5L,1L,5L,1L,9L,3L,5L,11L,5L,9L,9L,5L,3L,5L,7L,13L,11L,9L,3L,9L,3L,3L,3L,3L,3L,9L,3L,5L,3L,5L,5L,3L,1L,1L,9L,9L,5L,3L,3L,5L,5L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256737Inst : IEnumerable<long>
{
public static readonly long[] Value=A256737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256737.Bytes);
public long this[int i]=>Value[i];

public static A256737Inst Instance=new A256737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256738
{
public static readonly long[] Value={ 1969L,0L,1349L,1387L,0L,1475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256738Inst : IEnumerable<long>
{
public static readonly long[] Value=A256738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256738.Bytes);
public long this[int i]=>Value[i];

public static A256738Inst Instance=new A256738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256739
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,6L,6L,12L,10L,12L,10L,12L,12L,10L,8L,24L,16L,30L,18L,24L,16L,30L,22L,24L,28L,20L,18L,20L,28L,24L,30L,48L,40L,48L,32L,60L,36L,54L,40L,48L,40L,48L,42L,60L,40L,58L,46L,48L,54L,36L,32L,40L,52L,54L,56L,40L,40L,36L,58L,48L,60L,34L,32L,96L,72L,120L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256739Inst : IEnumerable<long>
{
public static readonly long[] Value=A256739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256739.Bytes);
public long this[int i]=>Value[i];

public static A256739Inst Instance=new A256739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256740
{
public static readonly BigInteger[] Value={ 153L,570L,2992L,5888L,22080L,72192L,404480L,897280L,4353536L,14508288L,119161088L,528994560L,4198855680L,110906421504L,711119970816L,7163830821120L,725781597115392L,5138241788813568L,58548192656601856L,BigInteger.Parse("21076849186784276736") };
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
public class A256740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256740.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256740Inst Instance=new A256740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256741
{
public static readonly long[] Value={ 153L,393L,857L,2065L,5255L,12914L,31032L,75634L,185630L,453792L,1107035L,2701934L,6602744L,16133440L,39398362L,96225937L,235055049L,574159002L,1402439544L,3425537766L,8367239407L,20438044264L,49921902827L,121939228872L,297849461916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256741Inst : IEnumerable<long>
{
public static readonly long[] Value=A256741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256741.Bytes);
public long this[int i]=>Value[i];

public static A256741Inst Instance=new A256741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256742
{
public static readonly long[] Value={ 393L,570L,1564L,2512L,6352L,12280L,28816L,60728L,137768L,311200L,695592L,1606920L,3675600L,8477144L,19719880L,45890144L,107177032L,251576104L,590847248L,1391314808L,3284435240L,7758601632L,18359082728L,43496258888L,103115774544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256742Inst : IEnumerable<long>
{
public static readonly long[] Value=A256742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256742.Bytes);
public long this[int i]=>Value[i];

public static A256742Inst Instance=new A256742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256743
{
public static readonly long[] Value={ 857L,1564L,2992L,3752L,9112L,16560L,38376L,61376L,135552L,202832L,517472L,837568L,2004832L,3082192L,7494688L,11500352L,29366208L,44880848L,112714720L,169674112L,434165792L,652380752L,1696204320L,2515078784L,6570529664L,9672961104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256743Inst : IEnumerable<long>
{
public static readonly long[] Value=A256743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256743.Bytes);
public long this[int i]=>Value[i];

public static A256743Inst Instance=new A256743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256744
{
public static readonly long[] Value={ 2065L,2512L,3752L,5888L,10360L,18688L,33616L,61568L,112928L,209024L,394816L,732800L,1397888L,2665088L,5068544L,9757312L,18928128L,36301440L,71073280L,138021504L,269741056L,527544960L,1039244800L,2031272576L,4023613440L,7901280896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256744Inst : IEnumerable<long>
{
public static readonly long[] Value=A256744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256744.Bytes);
public long this[int i]=>Value[i];

public static A256744Inst Instance=new A256744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256745
{
public static readonly long[] Value={ 5255L,6352L,9112L,10360L,22080L,47440L,96576L,160704L,300864L,463632L,1034880L,2109632L,4284608L,6583568L,14819840L,24554944L,53916864L,105740048L,216703616L,332082880L,839473856L,1386101008L,2999244544L,5804012480L,12212984000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256745Inst : IEnumerable<long>
{
public static readonly long[] Value=A256745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256745.Bytes);
public long this[int i]=>Value[i];

public static A256745Inst Instance=new A256745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256746
{
public static readonly long[] Value={ 12914L,12280L,16560L,18688L,47440L,72192L,155792L,255488L,600080L,869632L,2236176L,3351808L,8175376L,12600576L,31831312L,46718208L,122490640L,182095104L,471224592L,698647808L,1859822352L,2698396928L,7245722896L,10683665664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256746Inst : IEnumerable<long>
{
public static readonly long[] Value=A256746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256746.Bytes);
public long this[int i]=>Value[i];

public static A256746Inst Instance=new A256746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256747
{
public static readonly long[] Value={ 31032L,28816L,38376L,33616L,96576L,155792L,404480L,615296L,1258112L,1664400L,5004928L,7111808L,19624576L,26821008L,65198848L,91451776L,279105152L,356736400L,1053470592L,1397940864L,3792784000L,5223606672L,16267412480L,19397621632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256747Inst : IEnumerable<long>
{
public static readonly long[] Value=A256747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256747.Bytes);
public long this[int i]=>Value[i];

public static A256747Inst Instance=new A256747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256748
{
public static readonly long[] Value={ 153L,393L,393L,857L,570L,857L,2065L,1564L,1564L,2065L,5255L,2512L,2992L,2512L,5255L,12914L,6352L,3752L,3752L,6352L,12914L,31032L,12280L,9112L,5888L,9112L,12280L,31032L,75634L,28816L,16560L,10360L,10360L,16560L,28816L,75634L,185630L,60728L,38376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256748Inst : IEnumerable<long>
{
public static readonly long[] Value=A256748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256748.Bytes);
public long this[int i]=>Value[i];

public static A256748Inst Instance=new A256748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256749
{
public static readonly long[] Value={ 0L,60L,61L,120L,122L,180L,183L,240L,244L,300L,305L,360L,366L,420L,427L,480L,488L,540L,549L,600L,610L,660L,671L,721L,732L,781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256749Inst : IEnumerable<long>
{
public static readonly long[] Value=A256749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256749.Bytes);
public long this[int i]=>Value[i];

public static A256749Inst Instance=new A256749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256750
{
public static readonly long[] Value={ 0L,1L,2L,2L,0L,2L,3L,2L,0L,4L,3L,2L,0L,2L,5L,-1L,0L,2L,5L,2L,0L,4L,3L,2L,0L,4L,-2L,0L,0L,2L,3L,2L,0L,6L,3L,-1L,0L,2L,5L,-1L,0L,2L,3L,2L,0L,-2L,5L,2L,0L,6L,-3L,-1L,0L,2L,0L,-1L,0L,4L,3L,2L,0L,2L,7L,-2L,0L,6L,3L,2L,0L,-3L,3L,2L,0L,2L,-2L,-2L,0L,6L,3L,2L,0L,0L,3L,2L,0L,4L,-3L,-1L,0L,2L,-2L,-1L,0L,4L,7L,-1L,0L,2L,7L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256750Inst : IEnumerable<long>
{
public static readonly long[] Value=A256750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256750.Bytes);
public long this[int i]=>Value[i];

public static A256750Inst Instance=new A256750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256751
{
public static readonly long[] Value={ 2L,4L,3L,5L,2L,7L,2L,8L,3L,7L,4L,6L,4L,10L,8L,4L,12L,2L,11L,3L,10L,6L,11L,4L,8L,6L,12L,10L,4L,12L,4L,12L,8L,7L,4L,14L,2L,19L,5L,21L,3L,17L,7L,9L,7L,13L,4L,19L,7L,13L,5L,17L,5L,21L,9L,11L,5L,17L,3L,17L,7L,9L,13L,17L,5L,17L,6L,12L,5L,24L,4L,16L,12L,8L,6L,15L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256751Inst : IEnumerable<long>
{
public static readonly long[] Value=A256751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256751.Bytes);
public long this[int i]=>Value[i];

public static A256751Inst Instance=new A256751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256752
{
public static readonly long[] Value={ 1L,3L,11L,44L,190L,859L,4015L,19248L,94117L,467575L,2353443L,11975568L,61505088L,318406927L,1659801852L,8704865907L,45898065978L,243163198928L,1293769867676L,6910165762943L,37036898772008L,199140325574519L,1073849938338566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256752Inst : IEnumerable<long>
{
public static readonly long[] Value=A256752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256752.Bytes);
public long this[int i]=>Value[i];

public static A256752Inst Instance=new A256752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256753
{
public static readonly long[] Value={ 12L,18L,30L,42L,60L,102L,108L,228L,270L,312L,420L,462L,570L,600L,858L,882L,1050L,1092L,1230L,1290L,1302L,1428L,1488L,1620L,1872L,1998L,2028L,2340L,2550L,2688L,2730L,3390L,3462L,3540L,3582L,4020L,4230L,4242L,4272L,4338L,4518L,4650L,4788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256753Inst : IEnumerable<long>
{
public static readonly long[] Value=A256753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256753.Bytes);
public long this[int i]=>Value[i];

public static A256753Inst Instance=new A256753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256754
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,11L,4L,13L,8L,3L,16L,1L,16L,19L,0L,4L,22L,0L,8L,16L,26L,8L,16L,28L,2L,13L,0L,33L,34L,33L,36L,1L,2L,5L,0L,8L,8L,34L,44L,36L,0L,10L,16L,16L,0L,3L,16L,33L,36L,55L,0L,9L,16L,27L,4L,16L,26L,36L,0L,0L,66L,64L,68L,64L,6L,1L,8L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256754Inst : IEnumerable<long>
{
public static readonly long[] Value=A256754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256754.Bytes);
public long this[int i]=>Value[i];

public static A256754Inst Instance=new A256754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256755
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,11L,29L,31L,47L,63L,61L,87L,83L,91L,22L,29L,22L,55L,58L,61L,62L,91L,94L,93L,31L,31L,55L,33L,43L,55L,63L,109L,119L,127L,44L,47L,58L,43L,44L,63L,110L,111L,116L,127L,55L,63L,61L,55L,63L,55L,121L,123L,127L,127L,62L,61L,62L,63L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256755Inst : IEnumerable<long>
{
public static readonly long[] Value=A256755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256755.Bytes);
public long this[int i]=>Value[i];

public static A256755Inst Instance=new A256755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256756
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,0L,25L,18L,39L,60L,45L,86L,67L,72L,22L,25L,0L,55L,50L,45L,36L,83L,78L,65L,29L,18L,55L,0L,9L,22L,27L,108L,117L,122L,44L,39L,50L,9L,0L,27L,110L,101L,100L,111L,55L,60L,45L,22L,27L,0L,121L,114L,111L,100L,58L,45L,36L,27L,110L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256756Inst : IEnumerable<long>
{
public static readonly long[] Value=A256756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256756.Bytes);
public long this[int i]=>Value[i];

public static A256756Inst Instance=new A256756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256757
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,2L,3L,1L,3L,2L,3L,2L,3L,3L,2L,1L,2L,3L,4L,2L,3L,3L,4L,2L,3L,3L,4L,3L,4L,2L,3L,1L,3L,2L,3L,3L,4L,4L,3L,2L,3L,3L,4L,3L,3L,4L,5L,2L,4L,3L,2L,3L,4L,4L,3L,3L,4L,4L,5L,2L,3L,3L,3L,1L,3L,3L,4L,2L,4L,3L,4L,3L,4L,4L,3L,4L,3L,3L,4L,2L,5L,3L,4L,3L,2L,4L,4L,3L,4L,3L,3L,4L,3L,5L,4L,2L,3L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256757Inst : IEnumerable<long>
{
public static readonly long[] Value=A256757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256757.Bytes);
public long this[int i]=>Value[i];

public static A256757Inst Instance=new A256757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256758
{
public static readonly long[] Value={ 1L,2L,3L,7L,19L,47L,163L,487L,1307L,2879L,19683L,59049L,177147L,531441L,1594323L,4782969L,14348907L,43046721L,86093443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256758Inst : IEnumerable<long>
{
public static readonly long[] Value=A256758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256758.Bytes);
public long this[int i]=>Value[i];

public static A256758Inst Instance=new A256758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256759
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,0L,3L,3L,1L,0L,7L,3L,3L,1L,0L,6L,7L,3L,3L,1L,0L,6L,6L,7L,3L,3L,1L,0L,10L,6L,6L,7L,3L,3L,1L,0L,11L,10L,6L,6L,7L,3L,3L,1L,0L,10L,11L,10L,6L,6L,7L,3L,3L,1L,0L,10L,10L,11L,10L,6L,6L,7L,3L,3L,1L,0L,18L,10L,10L,11L,10L,6L,6L,7L,3L,3L,1L,0L,15L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256759Inst : IEnumerable<long>
{
public static readonly long[] Value=A256759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256759.Bytes);
public long this[int i]=>Value[i];

public static A256759Inst Instance=new A256759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256760
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,17L,19L,64L,368L,616L,857L,4351L,6526L,10555L,12685L,14549L,33886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256760Inst : IEnumerable<long>
{
public static readonly long[] Value=A256760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256760.Bytes);
public long this[int i]=>Value[i];

public static A256760Inst Instance=new A256760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256761
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,10L,16L,124L,243L,303L,459L,471L,520L,591L,1726L,2971L,5560L,5757L,13222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256761Inst : IEnumerable<long>
{
public static readonly long[] Value=A256761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256761.Bytes);
public long this[int i]=>Value[i];

public static A256761Inst Instance=new A256761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256762
{
public static readonly long[] Value={ 3L,6L,27L,30L,108L,119L,209L,444L,1050L,15189L,16401L,81363L,134385L,135011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256762Inst : IEnumerable<long>
{
public static readonly long[] Value=A256762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256762.Bytes);
public long this[int i]=>Value[i];

public static A256762Inst Instance=new A256762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256763
{
public static readonly long[] Value={ 352L,14641L,475904L,16777216L,372556800L,7780827681L,117202871808L,1607509551376L,18188873230624L,185599234557361L,1717824808451648L,14261419187961856L,114631549276294144L,822273125910687361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256763Inst : IEnumerable<long>
{
public static readonly long[] Value=A256763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256763.Bytes);
public long this[int i]=>Value[i];

public static A256763Inst Instance=new A256763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256764
{
public static readonly long[] Value={ 352L,1936L,9152L,43264L,189696L,831744L,3502080L,14745600L,60702720L,249892864L,1015758848L,4128833536L,16663379968L,67251011584L,270331805696L,1086664474624L,4358399852544L,17480694104064L,70025528475648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256764Inst : IEnumerable<long>
{
public static readonly long[] Value=A256764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256764.Bytes);
public long this[int i]=>Value[i];

public static A256764Inst Instance=new A256764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256765
{
public static readonly long[] Value={ 1936L,14641L,81796L,456976L,2196324L,10556001L,46785600L,207360000L,878529600L,3722098081L,15374512036L,63506016016L,258598692676L,1053022816561L,4253774251024L,17183478927616L,69105769488144L,277918540050321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256765Inst : IEnumerable<long>
{
public static readonly long[] Value=A256765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256765.Bytes);
public long this[int i]=>Value[i];

public static A256765Inst Instance=new A256765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256766
{
public static readonly long[] Value={ 9152L,81796L,475904L,2768896L,13278720L,63680400L,277704000L,1211040000L,5037021600L,20950246564L,85158087248L,346148662336L,1392238414592L,5599697511424L,22422624104192L,89785934095936L,358953258998256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256766Inst : IEnumerable<long>
{
public static readonly long[] Value=A256766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256766.Bytes);
public long this[int i]=>Value[i];

public static A256766Inst Instance=new A256766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256767
{
public static readonly long[] Value={ 43264L,456976L,2768896L,16777216L,80281600L,384160000L,1648360000L,7072810000L,28879603600L,117920812816L,471683251264L,1886733005056L,7495505035264L,29777713954816L,118194817601536L,469143297200656L,1864496164355344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256767Inst : IEnumerable<long>
{
public static readonly long[] Value=A256767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256767.Bytes);
public long this[int i]=>Value[i];

public static A256767Inst Instance=new A256767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256768
{
public static readonly long[] Value={ 189696L,2196324L,13278720L,80281600L,372556800L,1728896400L,7138454400L,29474022400L,115996965440L,456513732964L,1770623949536L,6867502430464L,26647772775936L,103400588657664L,403585055517696L,1575241487033344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256768Inst : IEnumerable<long>
{
public static readonly long[] Value=A256768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256768.Bytes);
public long this[int i]=>Value[i];

public static A256768Inst Instance=new A256768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256769
{
public static readonly long[] Value={ 831744L,10556001L,63680400L,384160000L,1728896400L,7780827681L,30914078976L,122825015296L,465909995776L,1767328289281L,6646640859664L,24996960092416L,94737284622864L,359049783034881L,1378071393843456L,5289185110982656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256769Inst : IEnumerable<long>
{
public static readonly long[] Value=A256769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256769.Bytes);
public long this[int i]=>Value[i];

public static A256769Inst Instance=new A256769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256770
{
public static readonly long[] Value={ 3502080L,46785600L,277704000L,1648360000L,7138454400L,30914078976L,117202871808L,444344894464L,1607870564992L,5818110629776L,20980333531040L,75655899841600L,277153998638400L,1015311946881600L,3799410667004160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256770Inst : IEnumerable<long>
{
public static readonly long[] Value=A256770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256770.Bytes);
public long this[int i]=>Value[i];

public static A256770Inst Instance=new A256770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256771
{
public static readonly long[] Value={ 352L,1936L,1936L,9152L,14641L,9152L,43264L,81796L,81796L,43264L,189696L,456976L,475904L,456976L,189696L,831744L,2196324L,2768896L,2768896L,2196324L,831744L,3502080L,10556001L,13278720L,16777216L,13278720L,10556001L,3502080L,14745600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256771Inst : IEnumerable<long>
{
public static readonly long[] Value=A256771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256771.Bytes);
public long this[int i]=>Value[i];

public static A256771Inst Instance=new A256771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256772
{
public static readonly long[] Value={ 2L,3L,4L,7L,9L,37L,39L,67L,73L,183L,216L,1161L,2622L,2775L,6240L,22078L,30384L,189385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256772Inst : IEnumerable<long>
{
public static readonly long[] Value=A256772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256772.Bytes);
public long this[int i]=>Value[i];

public static A256772Inst Instance=new A256772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256773
{
public static readonly long[] Value={ 2L,4L,6L,10L,12L,14L,17L,41L,69L,141L,170L,188L,204L,233L,306L,555L,743L,1908L,2006L,2140L,2772L,8105L,15170L,40038L,41908L,48604L,51652L,54038L,56781L,129051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256773Inst : IEnumerable<long>
{
public static readonly long[] Value=A256773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256773.Bytes);
public long this[int i]=>Value[i];

public static A256773Inst Instance=new A256773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256774
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,16L,24L,25L,64L,120L,125L,216L,625L,720L,1296L,2401L,5040L,16807L,32768L,40320L,59049L,262144L,362880L,531441L,1000000L,3628800L,10000000L,19487171L,39916800L,214358881L,429981696L,479001600L,815730721L,5159780352L,6227020800L,10604499373L,20661046784L,87178291200L,289254654976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256774Inst : IEnumerable<long>
{
public static readonly long[] Value=A256774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256774.Bytes);
public long this[int i]=>Value[i];

public static A256774Inst Instance=new A256774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256775
{
public static readonly long[] Value={ 97L,181L,277L,337L,757L,1237L,2017L,3217L,4177L,5557L,5857L,6481L,7477L,11317L,13537L,16981L,19681L,21397L,33937L,37717L,48481L,51157L,52981L,59617L,62581L,65617L,80737L,84181L,87697L,96181L,102481L,106357L,111637L,119797L,144481L,149077L,155317L,160081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256775Inst : IEnumerable<long>
{
public static readonly long[] Value=A256775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256775.Bytes);
public long this[int i]=>Value[i];

public static A256775Inst Instance=new A256775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256776
{
public static readonly long[] Value={ 257L,281L,337L,617L,881L,1097L,1217L,1481L,1777L,2281L,2657L,2857L,4481L,5297L,5881L,7481L,8537L,9281L,10457L,12577L,14897L,15881L,17417L,18481L,19577L,23057L,24281L,25537L,26177L,27481L,28817L,30881L,32297L,35977L,38281L,39857L,42281L,44777L,52697L,53617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256776Inst : IEnumerable<long>
{
public static readonly long[] Value=A256776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256776.Bytes);
public long this[int i]=>Value[i];

public static A256776Inst Instance=new A256776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256777
{
public static readonly long[] Value={ 641L,661L,769L,821L,881L,1109L,1201L,1301L,1409L,2069L,2389L,2741L,3329L,3541L,3761L,3989L,4721L,6101L,6709L,7349L,7681L,8369L,9461L,12289L,14081L,14549L,16001L,18049L,19121L,20789L,25589L,28181L,31601L,32309L,33749L,35221L,35969L,37489L,38261L,39041L,39829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256777Inst : IEnumerable<long>
{
public static readonly long[] Value=A256777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256777.Bytes);
public long this[int i]=>Value[i];

public static A256777Inst Instance=new A256777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256778
{
public static readonly long[] Value={ 7L,1L,0L,2L,8L,9L,7L,9L,3L,0L,6L,4L,0L,9L,3L,6L,9L,7L,3L,1L,3L,7L,6L,6L,4L,7L,5L,7L,9L,5L,0L,8L,2L,6L,1L,0L,3L,0L,4L,0L,6L,1L,0L,4L,2L,4L,9L,6L,9L,3L,2L,9L,4L,0L,8L,5L,3L,4L,7L,9L,8L,8L,5L,1L,3L,3L,0L,4L,2L,3L,8L,7L,9L,7L,2L,6L,1L,5L,9L,7L,1L,4L,6L,4L,2L,0L,6L,9L,5L,0L,7L,3L,9L,8L,0L,5L,9L,9L,2L,7L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256778Inst : IEnumerable<long>
{
public static readonly long[] Value=A256778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256778.Bytes);
public long this[int i]=>Value[i];

public static A256778Inst Instance=new A256778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256779
{
public static readonly long[] Value={ 7L,3L,5L,9L,2L,0L,3L,9L,6L,8L,3L,1L,6L,1L,7L,5L,8L,4L,1L,8L,9L,2L,8L,9L,7L,2L,5L,8L,4L,4L,7L,5L,2L,8L,9L,3L,0L,5L,9L,9L,9L,7L,3L,8L,3L,9L,8L,7L,6L,2L,5L,0L,1L,7L,6L,5L,2L,6L,4L,2L,1L,5L,4L,5L,4L,3L,4L,8L,9L,1L,5L,3L,2L,7L,6L,7L,9L,2L,3L,7L,7L,5L,8L,3L,2L,8L,8L,7L,8L,9L,2L,4L,5L,2L,7L,8L,1L,5L,0L,3L,2L,2L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256779Inst : IEnumerable<long>
{
public static readonly long[] Value=A256779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256779.Bytes);
public long this[int i]=>Value[i];

public static A256779Inst Instance=new A256779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256780
{
public static readonly long[] Value={ 1L,9L,0L,3L,8L,9L,3L,2L,6L,4L,3L,0L,2L,0L,3L,1L,5L,4L,2L,2L,5L,9L,8L,3L,2L,2L,9L,7L,6L,4L,2L,6L,8L,1L,6L,3L,2L,6L,0L,1L,5L,1L,9L,4L,8L,4L,4L,8L,4L,5L,8L,4L,8L,7L,0L,6L,4L,2L,6L,1L,1L,5L,6L,7L,4L,7L,6L,8L,6L,4L,1L,1L,0L,4L,4L,5L,7L,6L,7L,2L,3L,8L,6L,8L,4L,0L,5L,3L,6L,2L,8L,5L,2L,0L,8L,6L,8L,4L,1L,3L,2L,2L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256780Inst : IEnumerable<long>
{
public static readonly long[] Value=A256780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256780.Bytes);
public long this[int i]=>Value[i];

public static A256780Inst Instance=new A256780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256781
{
public static readonly long[] Value={ 7L,8L,8L,6L,3L,1L,3L,9L,0L,2L,0L,2L,0L,0L,2L,3L,6L,7L,4L,4L,3L,8L,8L,0L,8L,1L,9L,8L,3L,8L,9L,7L,6L,6L,6L,1L,9L,7L,8L,1L,1L,8L,2L,0L,4L,9L,2L,1L,0L,8L,8L,9L,2L,2L,5L,9L,4L,2L,5L,5L,8L,6L,2L,0L,2L,5L,3L,4L,0L,8L,6L,9L,6L,9L,1L,7L,7L,8L,6L,5L,0L,2L,5L,9L,9L,7L,8L,6L,7L,7L,1L,0L,1L,6L,0L,7L,4L,8L,0L,7L,3L,3L,5L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256781Inst : IEnumerable<long>
{
public static readonly long[] Value=A256781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256781.Bytes);
public long this[int i]=>Value[i];

public static A256781Inst Instance=new A256781Inst();

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