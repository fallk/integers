using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A117441
{
public static readonly long[] Value={ 1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,1L,1L,0L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117441Inst : IEnumerable<long>
{
public static readonly long[] Value=A117441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117441.Bytes);
public long this[int i]=>Value[i];

public static A117441Inst Instance=new A117441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117442
{
public static readonly long[] Value={ 1L,-1L,1L,3L,-2L,1L,-11L,9L,-3L,1L,57L,-44L,18L,-4L,1L,-361L,285L,-110L,30L,-5L,1L,2763L,-2166L,855L,-220L,45L,-6L,1L,-24611L,19341L,-7581L,1995L,-385L,63L,-7L,1L,250737L,-196888L,77364L,-20216L,3990L,-616L,84L,-8L,1L,-2873041L,2256633L,-885996L,232092L,-45486L,7182L,-924L,108L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117442Inst : IEnumerable<long>
{
public static readonly long[] Value=A117442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117442.Bytes);
public long this[int i]=>Value[i];

public static A117442Inst Instance=new A117442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117443
{
public static readonly BigInteger[] Value={ 1L,0L,2L,-4L,28L,-160L,1272L,-11184L,114448L,-1309440L,16680992L,-233587264L,3569157568L,-59075960320L,1053056675712L,-20111857791744L,409715696197888L,-8868323731660800L,203247024658514432L,-4916860703228314624L,BigInteger.Parse("125206830774036241408"),BigInteger.Parse("-3347784042587048058880") };
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
public class A117443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117443Inst Instance=new A117443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117444
{
public static readonly long[] Value={ 0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L,1L,2L,-2L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117444Inst : IEnumerable<long>
{
public static readonly long[] Value=A117444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117444.Bytes);
public long this[int i]=>Value[i];

public static A117444Inst Instance=new A117444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117445
{
public static readonly long[] Value={ 0L,-1L,1L,4L,-1L,4L,-4L,-4L,1L,1L,-4L,-4L,4L,-1L,4L,1L,-1L,0L,-1L,1L,4L,-1L,4L,-4L,-4L,1L,1L,-4L,-4L,4L,-1L,4L,1L,-1L,0L,-1L,1L,4L,-1L,4L,-4L,-4L,1L,1L,-4L,-4L,4L,-1L,4L,1L,-1L,0L,-1L,1L,4L,-1L,4L,-4L,-4L,1L,1L,-4L,-4L,4L,-1L,4L,1L,-1L,0L,-1L,1L,4L,-1L,4L,-4L,-4L,1L,1L,-4L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117445Inst : IEnumerable<long>
{
public static readonly long[] Value=A117445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117445.Bytes);
public long this[int i]=>Value[i];

public static A117445Inst Instance=new A117445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117446
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,-1L,1L,0L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,1L,0L,0L,-1L,0L,0L,1L,0L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,0L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,-1L,0L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117446Inst : IEnumerable<long>
{
public static readonly long[] Value=A117446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117446.Bytes);
public long this[int i]=>Value[i];

public static A117446Inst Instance=new A117446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117447
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L,0L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117447Inst : IEnumerable<long>
{
public static readonly long[] Value=A117447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117447.Bytes);
public long this[int i]=>Value[i];

public static A117447Inst Instance=new A117447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117448
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,-1L,2L,-1L,2L,0L,2L,-2L,3L,-2L,3L,-1L,3L,-3L,4L,-3L,4L,-2L,4L,-4L,5L,-4L,5L,-3L,5L,-5L,6L,-5L,6L,-4L,6L,-6L,7L,-6L,7L,-5L,7L,-7L,8L,-7L,8L,-6L,8L,-8L,9L,-8L,9L,-7L,9L,-9L,10L,-9L,10L,-8L,10L,-10L,11L,-10L,11L,-9L,11L,-11L,12L,-11L,12L,-10L,12L,-12L,13L,-12L,13L,-11L,13L,-13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117448Inst : IEnumerable<long>
{
public static readonly long[] Value=A117448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117448.Bytes);
public long this[int i]=>Value[i];

public static A117448Inst Instance=new A117448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117449
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,1L,0L,-1L,1L,1L,0L,1L,-1L,0L,1L,0L,-2L,2L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,1L,0L,1L,-1L,0L,1L,-1L,0L,1L,0L,-2L,2L,0L,-2L,2L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,0L,-1L,1L,1L,0L,1L,-1L,0L,1L,-1L,0L,1L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117449Inst : IEnumerable<long>
{
public static readonly long[] Value=A117449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117449.Bytes);
public long this[int i]=>Value[i];

public static A117449Inst Instance=new A117449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117450
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,9L,12L,15L,18L,23L,27L,32L,37L,42L,49L,55L,62L,69L,76L,85L,93L,102L,111L,120L,131L,141L,152L,163L,174L,187L,199L,212L,225L,238L,253L,267L,282L,297L,312L,329L,345L,362L,379L,396L,415L,433L,452L,471L,490L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117450Inst : IEnumerable<long>
{
public static readonly long[] Value=A117450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117450.Bytes);
public long this[int i]=>Value[i];

public static A117450Inst Instance=new A117450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117451
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,3L,2L,3L,3L,3L,5L,4L,5L,5L,5L,7L,6L,7L,7L,7L,9L,8L,9L,9L,9L,11L,10L,11L,11L,11L,13L,12L,13L,13L,13L,15L,14L,15L,15L,15L,17L,16L,17L,17L,17L,19L,18L,19L,19L,19L,21L,20L,21L,21L,21L,23L,22L,23L,23L,23L,25L,24L,25L,25L,25L,27L,26L,27L,27L,27L,29L,28L,29L,29L,29L,31L,30L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117451Inst : IEnumerable<long>
{
public static readonly long[] Value=A117451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117451.Bytes);
public long this[int i]=>Value[i];

public static A117451Inst Instance=new A117451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117452
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L,2L,-1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117452Inst : IEnumerable<long>
{
public static readonly long[] Value=A117452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117452.Bytes);
public long this[int i]=>Value[i];

public static A117452Inst Instance=new A117452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117453
{
public static readonly long[] Value={ 1L,16L,64L,81L,256L,512L,625L,729L,1024L,1296L,2401L,4096L,6561L,10000L,14641L,15625L,16384L,19683L,20736L,28561L,32768L,38416L,46656L,50625L,59049L,65536L,83521L,104976L,117649L,130321L,160000L,194481L,234256L,262144L,279841L,331776L,390625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117453Inst : IEnumerable<long>
{
public static readonly long[] Value=A117453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117453.Bytes);
public long this[int i]=>Value[i];

public static A117453Inst Instance=new A117453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117454
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,2L,0L,1L,1L,1L,0L,2L,0L,1L,1L,0L,1L,1L,2L,0L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,0L,1L,2L,2L,1L,2L,0L,1L,1L,1L,0L,2L,2L,2L,1L,2L,0L,1L,1L,0L,2L,0L,3L,3L,2L,1L,2L,0L,1L,1L,1L,0L,2L,2L,3L,3L,2L,1L,2L,0L,1L,1L,0L,1L,2L,2L,3L,4L,3L,2L,1L,2L,0L,1L,1L,1L,1L,1L,3L,4L,3L,4L,3L,2L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117454Inst : IEnumerable<long>
{
public static readonly long[] Value=A117454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117454.Bytes);
public long this[int i]=>Value[i];

public static A117454Inst Instance=new A117454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117455
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,8L,12L,19L,27L,41L,54L,76L,99L,133L,171L,223L,279L,357L,443L,554L,682L,841L,1022L,1247L,1504L,1814L,2174L,2603L,3092L,3676L,4346L,5127L,6030L,7076L,8275L,9669L,11254L,13078L,15167L,17556L,20270L,23377L,26899L,30902L,35448L,40592L,46403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117455Inst : IEnumerable<long>
{
public static readonly long[] Value=A117455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117455.Bytes);
public long this[int i]=>Value[i];

public static A117455Inst Instance=new A117455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117456
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,3L,2L,2L,1L,1L,1L,1L,1L,1L,2L,3L,3L,2L,2L,1L,1L,1L,1L,1L,2L,2L,3L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,2L,3L,4L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,4L,3L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117456Inst : IEnumerable<long>
{
public static readonly long[] Value=A117456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117456.Bytes);
public long this[int i]=>Value[i];

public static A117456Inst Instance=new A117456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117457
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,24L,32L,45L,63L,82L,107L,144L,179L,228L,296L,362L,450L,564L,684L,839L,1029L,1232L,1487L,1799L,2141L,2546L,3044L,3589L,4237L,5015L,5863L,6869L,8051L,9361L,10904L,12677L,14657L,16948L,19595L,22552L,25927L,29812L,34130L,39066L,44703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117457Inst : IEnumerable<long>
{
public static readonly long[] Value=A117457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117457.Bytes);
public long this[int i]=>Value[i];

public static A117457Inst Instance=new A117457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117458
{
public static readonly long[] Value={ 227L,313L,1723L,2003L,2311L,2609L,3329L,3701L,4007L,4027L,4801L,4931L,5107L,7253L,10457L,12143L,12163L,12211L,12433L,12547L,13063L,14143L,14341L,14831L,15139L,15373L,16091L,17027L,17047L,19403L,20047L,20261L,21059L,21149L,22157L,23053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117458Inst : IEnumerable<long>
{
public static readonly long[] Value=A117458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117458.Bytes);
public long this[int i]=>Value[i];

public static A117458Inst Instance=new A117458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117459
{
public static readonly long[] Value={ 49L,65L,269L,304L,344L,379L,469L,517L,553L,557L,647L,658L,683L,928L,1279L,1453L,1457L,1460L,1484L,1499L,1556L,1664L,1682L,1738L,1769L,1796L,1873L,1963L,1967L,2197L,2267L,2290L,2368L,2377L,2485L,2573L,2597L,2609L,2696L,2728L,2791L,2849L,2867L,2975L,2999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117459Inst : IEnumerable<long>
{
public static readonly long[] Value=A117459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117459.Bytes);
public long this[int i]=>Value[i];

public static A117459Inst Instance=new A117459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117460
{
public static readonly long[] Value={ 2L,3L,5L,43L,113L,191L,373L,821L,1097L,1307L,1493L,1523L,1619L,1873L,1907L,2029L,2081L,2339L,3109L,3169L,3347L,3923L,4339L,4421L,4463L,4603L,5417L,5581L,6067L,6263L,6427L,6607L,6791L,6841L,6863L,7127L,7307L,7673L,7723L,7877L,8731L,9341L,10079L,10723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117460Inst : IEnumerable<long>
{
public static readonly long[] Value=A117460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117460.Bytes);
public long this[int i]=>Value[i];

public static A117460Inst Instance=new A117460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117461
{
public static readonly long[] Value={ 1L,2L,3L,14L,30L,43L,74L,142L,184L,214L,238L,241L,256L,287L,292L,308L,313L,346L,443L,449L,472L,544L,593L,601L,607L,623L,715L,737L,791L,814L,836L,854L,874L,881L,883L,913L,931L,973L,980L,995L,1088L,1156L,1237L,1307L,1316L,1343L,1381L,1396L,1462L,1565L,1622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117461Inst : IEnumerable<long>
{
public static readonly long[] Value=A117461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117461.Bytes);
public long this[int i]=>Value[i];

public static A117461Inst Instance=new A117461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117462
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,3L,2L,2L,2L,2L,2L,2L,1L,1L,4L,3L,3L,3L,2L,2L,2L,2L,2L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117462Inst : IEnumerable<long>
{
public static readonly long[] Value=A117462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117462.Bytes);
public long this[int i]=>Value[i];

public static A117462Inst Instance=new A117462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117463
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,16L,18L,16L,16L,12L,16L,20L,24L,28L,32L,18L,20L,32L,24L,32L,40L,24L,28L,32L,36L,40L,44L,48L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117463Inst : IEnumerable<long>
{
public static readonly long[] Value=A117463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117463.Bytes);
public long this[int i]=>Value[i];

public static A117463Inst Instance=new A117463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117464
{
public static readonly long[] Value={ 0L,1L,10L,28L,55L,66L,91L,105L,120L,190L,210L,300L,406L,595L,630L,703L,780L,820L,903L,990L,1035L,1081L,1128L,1326L,1540L,1770L,1830L,2016L,2080L,2211L,2346L,2701L,2850L,3003L,3081L,3160L,3240L,3403L,3486L,3570L,4005L,4095L,4560L,4950L,5050L,5151L,5460L,5995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117464Inst : IEnumerable<long>
{
public static readonly long[] Value=A117464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117464.Bytes);
public long this[int i]=>Value[i];

public static A117464Inst Instance=new A117464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117465
{
public static readonly long[] Value={ 9L,0L,15L,0L,105L,24L,945L,120L,3465L,360L,9009L,840L,19305L,1680L,36465L,3024L,62985L,5040L,101745L,7920L,156009L,11880L,229425L,17160L,326025L,24024L,450225L,32760L,606825L,43680L,801009L,57120L,1038345L,73440L,1324785L,93024L,1666665L,116280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117465Inst : IEnumerable<long>
{
public static readonly long[] Value=A117465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117465.Bytes);
public long this[int i]=>Value[i];

public static A117465Inst Instance=new A117465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117466
{
public static readonly long[] Value={ 1L,1L,1L,2L,0L,1L,2L,1L,0L,1L,3L,1L,0L,0L,1L,4L,1L,1L,0L,0L,1L,5L,1L,1L,0L,0L,0L,1L,6L,2L,0L,1L,0L,0L,0L,1L,8L,2L,1L,1L,0L,0L,0L,0L,1L,10L,2L,1L,0L,1L,0L,0L,0L,0L,1L,12L,3L,1L,0L,1L,0L,0L,0L,0L,0L,1L,15L,3L,2L,1L,0L,1L,0L,0L,0L,0L,0L,1L,18L,4L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,22L,5L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117466Inst : IEnumerable<long>
{
public static readonly long[] Value=A117466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117466.Bytes);
public long this[int i]=>Value[i];

public static A117466Inst Instance=new A117466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117467
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,15L,17L,22L,28L,32L,37L,49L,52L,60L,77L,83L,94L,116L,125L,146L,174L,187L,214L,257L,282L,315L,372L,410L,461L,544L,593L,669L,773L,851L,969L,1105L,1218L,1368L,1559L,1737L,1936L,2199L,2431L,2717L,3079L,3396L,3790L,4263L,4719L,5262L,5878L,6501L,7224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117467Inst : IEnumerable<long>
{
public static readonly long[] Value=A117467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117467.Bytes);
public long this[int i]=>Value[i];

public static A117467Inst Instance=new A117467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117468
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,0L,1L,1L,2L,1L,0L,1L,1L,3L,2L,0L,0L,1L,1L,3L,2L,1L,0L,0L,1L,1L,4L,3L,1L,0L,0L,0L,1L,1L,4L,5L,1L,1L,0L,0L,0L,1L,1L,5L,5L,2L,1L,0L,0L,0L,0L,1L,1L,5L,7L,3L,0L,1L,0L,0L,0L,0L,1L,1L,6L,9L,4L,1L,1L,0L,0L,0L,0L,0L,1L,1L,6L,10L,6L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,7L,12L,7L,2L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117468Inst : IEnumerable<long>
{
public static readonly long[] Value=A117468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117468.Bytes);
public long this[int i]=>Value[i];

public static A117468Inst Instance=new A117468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117469
{
public static readonly long[] Value={ 1L,3L,6L,9L,13L,19L,24L,30L,42L,49L,61L,79L,92L,110L,144L,162L,195L,242L,278L,332L,405L,463L,546L,656L,759L,882L,1049L,1205L,1399L,1655L,1887L,2181L,2546L,2909L,3361L,3880L,4422L,5069L,5831L,6641L,7566L,8666L,9818L,11159L,12730L,14376L,16281L,18465L,20828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117469Inst : IEnumerable<long>
{
public static readonly long[] Value=A117469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117469.Bytes);
public long this[int i]=>Value[i];

public static A117469Inst Instance=new A117469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117470
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,1L,2L,3L,4L,2L,1L,2L,5L,1L,4L,4L,2L,3L,6L,4L,4L,6L,4L,1L,2L,9L,6L,1L,6L,6L,9L,2L,2L,11L,10L,3L,4L,10L,11L,6L,4L,11L,17L,6L,1L,5L,11L,17L,10L,1L,2L,15L,21L,12L,2L,6L,12L,24L,18L,3L,2L,17L,28L,20L,5L,6L,14L,31L,26L,8L,4L,17L,38L,31L,10L,1L,4L,18L,37L,41L,14L,1L,2L,21L,45L,45L,19L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117470Inst : IEnumerable<long>
{
public static readonly long[] Value=A117470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117470.Bytes);
public long this[int i]=>Value[i];

public static A117470Inst Instance=new A117470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117471
{
public static readonly long[] Value={ 0L,0L,1L,1L,3L,4L,7L,8L,14L,17L,24L,30L,40L,50L,67L,79L,101L,126L,153L,186L,231L,276L,332L,399L,477L,567L,677L,795L,938L,1111L,1294L,1512L,1773L,2058L,2392L,2775L,3204L,3701L,4272L,4904L,5630L,6467L,7387L,8442L,9651L,10980L,12491L,14202L,16109L,18260L,20680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117471Inst : IEnumerable<long>
{
public static readonly long[] Value=A117471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117471.Bytes);
public long this[int i]=>Value[i];

public static A117471Inst Instance=new A117471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117472
{
public static readonly long[] Value={ 25L,53L,137L,305L,797L,1777L,4645L,10357L,27073L,60365L,157793L,351833L,919685L,2050633L,5360317L,11951965L,31242217L,69661157L,182092985L,406014977L,1061315693L,2366428705L,6185801173L,13792557253L,36053491345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117472Inst : IEnumerable<long>
{
public static readonly long[] Value=A117472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117472.Bytes);
public long this[int i]=>Value[i];

public static A117472Inst Instance=new A117472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117473
{
public static readonly long[] Value={ 7L,28L,88L,207L,555L,1248L,3276L,7315L,19135L,42676L,111568L,248775L,650307L,1450008L,3790308L,8451307L,22091575L,49257868L,128759176L,287095935L,750463515L,1673317776L,4374021948L,9752810755L,25493668207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117473Inst : IEnumerable<long>
{
public static readonly long[] Value=A117473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117473.Bytes);
public long this[int i]=>Value[i];

public static A117473Inst Instance=new A117473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117474
{
public static readonly long[] Value={ 5L,8L,48L,65L,297L,396L,1748L,2325L,10205L,13568L,59496L,79097L,346785L,461028L,2021228L,2687085L,11780597L,15661496L,68662368L,91281905L,400193625L,532029948L,2332499396L,3100897797L,13594802765L,18073356848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117474Inst : IEnumerable<long>
{
public static readonly long[] Value=A117474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117474.Bytes);
public long this[int i]=>Value[i];

public static A117474Inst Instance=new A117474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117475
{
public static readonly long[] Value={ 37L,65L,205L,373L,1193L,2173L,6953L,12665L,40525L,73817L,236197L,430237L,1376657L,2507605L,8023745L,14615393L,46765813L,85184753L,272571133L,496493125L,1588660985L,2893773997L,9259394777L,16866150857L,53967707677L,98303131145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117475Inst : IEnumerable<long>
{
public static readonly long[] Value=A117475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117475.Bytes);
public long this[int i]=>Value[i];

public static A117475Inst Instance=new A117475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117476
{
public static readonly long[] Value={ 12L,33L,133L,252L,832L,1525L,4905L,8944L,28644L,52185L,167005L,304212L,973432L,1773133L,5673633L,10334632L,33068412L,60234705L,192736885L,351073644L,1123352944L,2046207205L,6547380825L,11926169632L,38160932052L,69510810633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117476Inst : IEnumerable<long>
{
public static readonly long[] Value=A117476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117476.Bytes);
public long this[int i]=>Value[i];

public static A117476Inst Instance=new A117476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117477
{
public static readonly long[] Value={ 131L,263L,1039L,1091L,1301L,1361L,1433L,2221L,2441L,2591L,2663L,2719L,2803L,3433L,3631L,4153L,4357L,4397L,5507L,5701L,5741L,5927L,6311L,6353L,6553L,6737L,6827L,6971L,7013L,7213L,7411L,7523L,7741L,8821L,9103L,11173L,11353L,11731L,11821L,12277L,12347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117477Inst : IEnumerable<long>
{
public static readonly long[] Value=A117477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117477.Bytes);
public long this[int i]=>Value[i];

public static A117477Inst Instance=new A117477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117478
{
public static readonly long[] Value={ 32L,56L,175L,182L,212L,218L,227L,331L,362L,377L,386L,397L,409L,481L,508L,571L,595L,599L,728L,751L,755L,779L,821L,827L,847L,869L,878L,896L,902L,922L,940L,953L,982L,1099L,1129L,1354L,1372L,1408L,1417L,1468L,1475L,1507L,1550L,1585L,1648L,1693L,1747L,1772L,1774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117478Inst : IEnumerable<long>
{
public static readonly long[] Value=A117478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117478.Bytes);
public long this[int i]=>Value[i];

public static A117478Inst Instance=new A117478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117479
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,1L,0L,2L,2L,1L,2L,1L,1L,1L,0L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,3L,3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,4L,3L,3L,3L,2L,3L,3L,2L,3L,2L,2L,2L,1L,3L,3L,2L,3L,2L,2L,2L,1L,3L,2L,2L,2L,1L,2L,2L,1L,2L,1L,1L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117479Inst : IEnumerable<long>
{
public static readonly long[] Value=A117479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117479.Bytes);
public long this[int i]=>Value[i];

public static A117479Inst Instance=new A117479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117480
{
public static readonly long[] Value={ 3L,5L,9L,15L,39L,99L,345L,22269L,79809L,187125L,347979L,2171619L,4219797675L,98059918335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117480Inst : IEnumerable<long>
{
public static readonly long[] Value=A117480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117480.Bytes);
public long this[int i]=>Value[i];

public static A117480Inst Instance=new A117480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117481
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,30L,210L,56L,504L,5040L,55440L,132L,1716L,182L,2730L,43680L,742560L,306L,5814L,380L,7980L,175560L,4037880L,552L,13800L,358800L,9687600L,271252800L,7866331200L,870L,26970L,992L,32736L,1113024L,38955840L,1401410240L,51889178880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117481Inst : IEnumerable<long>
{
public static readonly long[] Value=A117481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117481.Bytes);
public long this[int i]=>Value[i];

public static A117481Inst Instance=new A117481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117482
{
public static readonly long[] Value={ 0L,2L,60L,62L,512L,560L,2178L,15072L,15074L,15090L,40992L,40994L,41004L,41010L,43760L,43818L,43820L,45260L,45704L,45710L,45738L,45740L,45744L,53192L,53198L,57512L,57518L,57570L,163842L,163854L,164000L,164018L,164024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117482Inst : IEnumerable<long>
{
public static readonly long[] Value=A117482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117482.Bytes);
public long this[int i]=>Value[i];

public static A117482Inst Instance=new A117482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117483
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,8L,10L,11L,17L,20L,22L,30L,31L,41L,50L,59L,67L,75L,83L,109L,127L,157L,174L,179L,191L,200L,211L,241L,277L,283L,331L,353L,360L,367L,401L,414L,431L,460L,461L,475L,509L,547L,563L,587L,599L,617L,709L,739L,773L,797L,859L,877L,919L,942L,960L,967L,991L,1014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117483Inst : IEnumerable<long>
{
public static readonly long[] Value=A117483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117483.Bytes);
public long this[int i]=>Value[i];

public static A117483Inst Instance=new A117483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117484
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,4L,4L,8L,4L,6L,6L,8L,7L,8L,6L,16L,9L,8L,10L,12L,8L,12L,12L,16L,11L,14L,11L,16L,15L,12L,16L,32L,12L,18L,12L,16L,19L,20L,14L,24L,21L,16L,22L,24L,12L,24L,24L,32L,22L,22L,18L,28L,27L,22L,18L,32L,20L,30L,30L,24L,31L,32L,16L,64L,21L,24L,34L,36L,24L,24L,36L,32L,37L,38L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117484Inst : IEnumerable<long>
{
public static readonly long[] Value=A117484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117484.Bytes);
public long this[int i]=>Value[i];

public static A117484Inst Instance=new A117484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117485
{
public static readonly long[] Value={ 1L,2L,5L,10L,18L,30L,49L,74L,110L,158L,221L,302L,407L,536L,698L,896L,1136L,1424L,1770L,2176L,2656L,3216L,3866L,4616L,5481L,6466L,7591L,8866L,10306L,11926L,13747L,15778L,18046L,20566L,23359L,26446L,29855L,33600L,37716L,42224L,47152L,52528L,58388L,64752L,71664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117485Inst : IEnumerable<long>
{
public static readonly long[] Value=A117485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117485.Bytes);
public long this[int i]=>Value[i];

public static A117485Inst Instance=new A117485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117486
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,34L,59L,94L,149L,224L,334L,480L,685L,950L,1307L,1762L,2357L,3100L,4050L,5220L,6685L,8466L,10659L,13294L,16494L,20298L,24859L,30234L,36609L,44056L,52806L,62952L,74770L,88380L,104112L,122116L,142786L,166304L,193134L,223504L,257954L,296756L,340544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117486Inst : IEnumerable<long>
{
public static readonly long[] Value=A117486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117486.Bytes);
public long this[int i]=>Value[i];

public static A117486Inst Instance=new A117486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117487
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,36L,63L,104L,169L,264L,405L,604L,888L,1278L,1815L,2536L,3502L,4772L,6437L,8586L,11352L,14866L,19315L,24890L,31851L,40466L,51089L,64092L,79952L,99172L,122386L,150264L,183639L,223394L,270605L,326422L,392225L,469490L,559970L,665542L,788412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117487Inst : IEnumerable<long>
{
public static readonly long[] Value=A117487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117487.Bytes);
public long this[int i]=>Value[i];

public static A117487Inst Instance=new A117487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117488
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,5L,8L,14L,1L,2L,5L,10L,18L,30L,49L,1L,2L,5L,10L,20L,34L,59L,94L,149L,1L,2L,5L,10L,20L,36L,63L,104L,169L,264L,405L,1L,2L,5L,10L,20L,36L,65L,108L,179L,284L,445L,676L,1017L,1L,2L,5L,10L,20L,36L,65L,110L,183L,294L,465L,716L,1089L,1622L,2387L,1L,2L,5L,10L,20L,36L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117488Inst : IEnumerable<long>
{
public static readonly long[] Value=A117488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117488.Bytes);
public long this[int i]=>Value[i];

public static A117488Inst Instance=new A117488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117489
{
public static readonly long[] Value={ 1L,6L,30L,115L,374L,1079L,2848L,7005L,16285L,36117L,76981L,158563L,317014L,617349L,1174400L,2187584L,3998057L,7181362L,12696179L,22120549L,38023748L,64546190L,108296742L,179729895L,295244362L,480358370L,774483006L,1238052200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117489Inst : IEnumerable<long>
{
public static readonly long[] Value=A117489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117489.Bytes);
public long this[int i]=>Value[i];

public static A117489Inst Instance=new A117489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117490
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,11L,14L,18L,21L,25L,29L,33L,38L,42L,48L,54L,59L,64L,70L,77L,84L,90L,96L,105L,113L,120L,128L,136L,144L,151L,161L,170L,180L,189L,199L,207L,216L,228L,239L,250L,261L,269L,281L,292L,305L,314L,327L,342L,352L,363L,378L,393L,405L,418L,429L,441L,458L,470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117490Inst : IEnumerable<long>
{
public static readonly long[] Value=A117490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117490.Bytes);
public long this[int i]=>Value[i];

public static A117490Inst Instance=new A117490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117491
{
public static readonly long[] Value={ 0L,3L,7L,16L,27L,44L,64L,93L,125L,164L,212L,264L,321L,394L,470L,558L,649L,758L,874L,999L,1139L,1290L,1448L,1624L,1812L,2011L,2218L,2451L,2697L,2951L,3217L,3501L,3806L,4126L,4472L,4810L,5182L,5567L,5983L,6401L,6837L,7295L,7775L,8279L,8796L,9347L,9901L,10484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117491Inst : IEnumerable<long>
{
public static readonly long[] Value=A117491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117491.Bytes);
public long this[int i]=>Value[i];

public static A117491Inst Instance=new A117491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117492
{
public static readonly long[] Value={ 6L,0L,9L,0L,8L,1L,2L,4L,3L,4L,8L,5L,5L,0L,4L,3L,1L,8L,8L,7L,1L,6L,9L,4L,5L,0L,5L,4L,7L,0L,6L,6L,9L,8L,0L,2L,6L,5L,8L,0L,6L,0L,8L,9L,3L,5L,3L,4L,0L,0L,7L,5L,6L,3L,1L,4L,5L,9L,2L,5L,2L,2L,3L,8L,4L,3L,0L,9L,8L,8L,4L,8L,5L,7L,7L,2L,9L,8L,5L,5L,3L,7L,9L,0L,6L,1L,2L,2L,5L,1L,4L,1L,8L,7L,8L,6L,8L,4L,5L,4L,1L,1L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117492Inst : IEnumerable<long>
{
public static readonly long[] Value=A117492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117492.Bytes);
public long this[int i]=>Value[i];

public static A117492Inst Instance=new A117492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117493
{
public static readonly long[] Value={ 7L,1L,9L,4L,0L,5L,0L,3L,1L,2L,4L,5L,0L,9L,2L,1L,1L,8L,8L,0L,9L,0L,8L,1L,5L,3L,3L,5L,6L,4L,7L,6L,8L,7L,5L,9L,8L,0L,4L,3L,5L,5L,9L,4L,2L,1L,7L,3L,3L,0L,6L,1L,7L,9L,9L,7L,3L,7L,7L,4L,4L,9L,3L,0L,4L,5L,0L,8L,2L,2L,3L,9L,6L,7L,0L,2L,2L,0L,7L,9L,2L,7L,3L,6L,9L,6L,8L,7L,9L,3L,8L,6L,2L,3L,4L,1L,6L,1L,3L,2L,5L,5L,1L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117493Inst : IEnumerable<long>
{
public static readonly long[] Value=A117493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117493.Bytes);
public long this[int i]=>Value[i];

public static A117493Inst Instance=new A117493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117494
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,1L,2L,2L,5L,1L,4L,1L,7L,6L,4L,1L,8L,1L,6L,8L,11L,1L,8L,4L,13L,6L,8L,1L,14L,1L,8L,12L,17L,10L,10L,1L,19L,14L,12L,1L,20L,1L,12L,14L,23L,1L,16L,6L,24L,18L,14L,1L,24L,14L,16L,20L,29L,1L,20L,1L,31L,18L,16L,16L,32L,1L,18L,24L,34L,1L,20L,1L,37L,28L,20L,16L,38L,1L,24L,18L,41L,1L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117494Inst : IEnumerable<long>
{
public static readonly long[] Value=A117494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117494.Bytes);
public long this[int i]=>Value[i];

public static A117494Inst Instance=new A117494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117495
{
public static readonly long[] Value={ 0L,3L,10L,21L,44L,65L,102L,133L,184L,261L,310L,407L,492L,559L,658L,795L,944L,1037L,1206L,1349L,1460L,1659L,1826L,2047L,2328L,2525L,2678L,2889L,3052L,3277L,3810L,4061L,4384L,4587L,5066L,5285L,5652L,6031L,6346L,6747L,7160L,7421L,8022L,8299L,8668L,8955L,9706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117495Inst : IEnumerable<long>
{
public static readonly long[] Value=A117495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117495.Bytes);
public long this[int i]=>Value[i];

public static A117495Inst Instance=new A117495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117496
{
public static readonly long[] Value={ 0L,2L,8L,56L,60L,62L,162L,168L,170L,186L,188L,224L,234L,236L,240L,242L,512L,546L,558L,560L,648L,650L,654L,672L,674L,702L,704L,2106L,2108L,2178L,2184L,2186L,13184L,13194L,13196L,13290L,13292L,13304L,13308L,13310L,14586L,14588L,15072L,15074L,15084L,15086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117496Inst : IEnumerable<long>
{
public static readonly long[] Value=A117496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117496.Bytes);
public long this[int i]=>Value[i];

public static A117496Inst Instance=new A117496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117497
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,3L,4L,4L,5L,4L,5L,5L,5L,4L,5L,5L,6L,5L,6L,6L,7L,5L,6L,6L,6L,6L,7L,6L,7L,5L,6L,6L,7L,6L,7L,7L,7L,6L,7L,7L,8L,7L,7L,8L,9L,6L,7L,7L,7L,7L,8L,7L,8L,7L,8L,8L,9L,7L,8L,8L,8L,6L,7L,7L,8L,7L,8L,8L,9L,7L,8L,8L,8L,8L,8L,8L,9L,7L,8L,8L,9L,8L,8L,9L,9L,8L,9L,8L,9L,9L,9L,10L,9L,7L,8L,8L,8L,8L,9L,8L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117497Inst : IEnumerable<long>
{
public static readonly long[] Value=A117497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117497.Bytes);
public long this[int i]=>Value[i];

public static A117497Inst Instance=new A117497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117498
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,3L,4L,4L,5L,4L,5L,5L,5L,4L,5L,5L,6L,5L,6L,6L,7L,5L,6L,6L,6L,6L,7L,6L,7L,5L,6L,6L,7L,6L,7L,7L,7L,6L,7L,7L,8L,7L,7L,8L,9L,6L,7L,7L,7L,7L,8L,7L,8L,7L,8L,8L,9L,7L,8L,8L,8L,6L,7L,7L,8L,7L,8L,8L,9L,7L,8L,8L,8L,8L,9L,8L,9L,7L,8L,8L,9L,8L,8L,9L,9L,8L,9L,8L,9L,9L,9L,10L,9L,7L,8L,8L,8L,8L,9L,8L,9L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117498Inst : IEnumerable<long>
{
public static readonly long[] Value=A117498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117498.Bytes);
public long this[int i]=>Value[i];

public static A117498Inst Instance=new A117498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117499
{
public static readonly long[] Value={ 4L,4L,4L,3L,2L,4L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,2L,0L,1L,1L,1L,2L,4L,2L,1L,1L,1L,1L,3L,2L,1L,1L,2L,2L,3L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,1L,0L,2L,2L,1L,1L,2L,2L,2L,0L,1L,1L,1L,2L,3L,1L,0L,0L,0L,1L,3L,2L,2L,2L,2L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117499Inst : IEnumerable<long>
{
public static readonly long[] Value=A117499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117499.Bytes);
public long this[int i]=>Value[i];

public static A117499Inst Instance=new A117499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117500
{
public static readonly long[] Value={ 1L,2L,2L,1L,3L,1L,3L,1L,1L,3L,2L,1L,4L,2L,1L,4L,2L,1L,1L,4L,3L,1L,1L,4L,3L,2L,1L,5L,3L,2L,1L,5L,3L,2L,1L,1L,5L,4L,2L,1L,1L,6L,4L,2L,1L,1L,5L,4L,3L,2L,1L,6L,4L,3L,2L,1L,6L,4L,3L,2L,1L,1L,7L,4L,3L,2L,1L,1L,7L,5L,3L,2L,1L,1L,7L,5L,3L,2L,2L,1L,7L,5L,3L,2L,2L,1L,1L,7L,5L,4L,3L,2L,1L,7L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117500Inst : IEnumerable<long>
{
public static readonly long[] Value=A117500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117500.Bytes);
public long this[int i]=>Value[i];

public static A117500Inst Instance=new A117500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117501
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,1L,4L,4L,5L,5L,1L,5L,5L,7L,8L,8L,1L,6L,6L,9L,11L,13L,13L,1L,7L,7L,11L,14L,18L,21L,21L,1L,8L,8L,13L,17L,23L,29L,34L,34L,1L,9L,9L,15L,20L,28L,37L,47L,55L,55L,1L,10L,10L,17L,23L,33L,45L,60L,76L,89L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117501Inst : IEnumerable<long>
{
public static readonly long[] Value=A117501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117501.Bytes);
public long this[int i]=>Value[i];

public static A117501Inst Instance=new A117501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117502
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,1L,2L,5L,1L,1L,2L,3L,8L,1L,1L,2L,3L,5L,13L,1L,1L,2L,3L,5L,8L,21L,1L,1L,2L,3L,5L,8L,13L,34L,1L,1L,2L,3L,5L,8L,13L,21L,55L,1L,1L,2L,3L,5L,8L,13L,21L,34L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117502Inst : IEnumerable<long>
{
public static readonly long[] Value=A117502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117502.Bytes);
public long this[int i]=>Value[i];

public static A117502Inst Instance=new A117502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117503
{
public static readonly long[] Value={ 613L,6229L,7607L,9679L,46133L,61469L,69191L,120067L,211663L,285049L,316697L,354323L,402371L,444979L,481109L,490313L,532709L,993907L,1055543L,1083721L,1237487L,1329701L,1409977L,1442899L,1484671L,1656199L,1700471L,1874767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117503Inst : IEnumerable<long>
{
public static readonly long[] Value=A117503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117503.Bytes);
public long this[int i]=>Value[i];

public static A117503Inst Instance=new A117503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117504
{
public static readonly long[] Value={ 37L,137L,151L,173L,409L,467L,503L,677L,937L,1091L,1153L,1229L,1303L,1409L,1453L,1471L,1531L,2137L,2221L,2251L,2393L,2503L,2593L,2633L,2671L,2797L,2837L,3001L,3023L,3089L,3163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117504Inst : IEnumerable<long>
{
public static readonly long[] Value=A117504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117504.Bytes);
public long this[int i]=>Value[i];

public static A117504Inst Instance=new A117504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117505
{
public static readonly long[] Value={ 1L,2L,1L,2L,4L,3L,2L,4L,16L,13L,2L,4L,16L,80L,67L,2L,4L,16L,80L,448L,381L,2L,4L,16L,80L,448L,2688L,2307L,2L,4L,16L,80L,448L,2688L,16896L,14589L,2L,4L,16L,80L,448L,2688L,16896L,109824L,95235L,2L,4L,16L,80L,448L,2688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117505Inst : IEnumerable<long>
{
public static readonly long[] Value=A117505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117505.Bytes);
public long this[int i]=>Value[i];

public static A117505Inst Instance=new A117505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117506
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,2L,3L,1L,1L,4L,5L,6L,5L,4L,1L,1L,5L,9L,5L,10L,16L,5L,10L,9L,5L,1L,1L,6L,14L,14L,15L,35L,21L,21L,20L,35L,14L,15L,14L,6L,1L,1L,7L,20L,28L,14L,21L,64L,70L,56L,42L,35L,90L,56L,70L,14L,35L,64L,28L,21L,20L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117506Inst : IEnumerable<long>
{
public static readonly long[] Value=A117506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117506.Bytes);
public long this[int i]=>Value[i];

public static A117506Inst Instance=new A117506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117507
{
public static readonly BigInteger[] Value={ 2L,23L,3919L,1400972L,1332221503L,2440266733544L,9013120937567806L,BigInteger.Parse("47710925260763230958"),BigInteger.Parse("503649376979113850651329"),BigInteger.Parse("5954610779280903922363948937"),BigInteger.Parse("114594038963707117577230115067496") };
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
public class A117507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117507.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117507Inst Instance=new A117507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117508
{
public static readonly BigInteger[] Value={ 3L,21L,3003L,969969L,872002131L,1537339756953L,5532885785273847L,BigInteger.Parse("28676947025074349001"),BigInteger.Parse("298326279901848452657403"),BigInteger.Parse("3479379402495258503343291189"),BigInteger.Parse("66257821961717207679166294112127") };
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
public class A117508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117508Inst Instance=new A117508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117509
{
public static readonly long[] Value={ 0L,2L,560L,43760L,163854L,164018L,870899850L,870899852L,870900354L,870900360L,870900362L,870907842L,870907848L,870907850L,870977340L,870977342L,871016994L,871017138L,871017144L,871018188L,871018190L,871018440L,871018442L,871025312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117509Inst : IEnumerable<long>
{
public static readonly long[] Value=A117509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117509.Bytes);
public long this[int i]=>Value[i];

public static A117509Inst Instance=new A117509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117510
{
public static readonly long[] Value={ 1L,3L,7L,11L,19L,21L,35L,63L,45L,95L,99L,93L,119L,105L,165L,429L,273L,285L,581L,385L,345L,495L,749L,651L,665L,1001L,693L,1155L,1197L,1155L,1287L,1463L,693L,1935L,1659L,2331L,2145L,1995L,2915L,2415L,3399L,2115L,4785L,3157L,3519L,5225L,5481L,2871L,5115L,6045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117510Inst : IEnumerable<long>
{
public static readonly long[] Value=A117510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117510.Bytes);
public long this[int i]=>Value[i];

public static A117510Inst Instance=new A117510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117511
{
public static readonly long[] Value={ 36L,153L,2556L,3240L,4851L,5778L,9045L,11628L,13041L,14535L,17766L,19503L,33930L,41328L,46665L,49455L,52326L,71253L,74691L,81810L,85491L,93096L,109278L,122265L,131328L,140715L,145530L,160461L,170820L,181503L,186966L,192510L,203841L,252405L,258840L,265356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117511Inst : IEnumerable<long>
{
public static readonly long[] Value=A117511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117511.Bytes);
public long this[int i]=>Value[i];

public static A117511Inst Instance=new A117511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117512
{
public static readonly long[] Value={ 3L,21L,120L,210L,300L,496L,595L,946L,1378L,1891L,2278L,2485L,2926L,3655L,3916L,4186L,4465L,4753L,5356L,5671L,6328L,6670L,7381L,7750L,8128L,8515L,8911L,9316L,9730L,10011L,10585L,11476L,11935L,12880L,13366L,13861L,14365L,15931L,16471L,18145L,18721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117512Inst : IEnumerable<long>
{
public static readonly long[] Value=A117512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117512.Bytes);
public long this[int i]=>Value[i];

public static A117512Inst Instance=new A117512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117513
{
public static readonly BigInteger[] Value={ 1L,2L,12L,136L,2480L,66336L,2446528L,118984832L,7378078464L,568142287360L,53189920492544L,5949749335001088L,783686338494312448L,BigInteger.Parse("120058889459865165824"),BigInteger.Parse("21166245289132322242560") };
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
public class A117513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117513Inst Instance=new A117513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117514
{
public static readonly long[] Value={ 1L,1L,2L,18L,248L,5560L,174752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117514Inst : IEnumerable<long>
{
public static readonly long[] Value=A117514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117514.Bytes);
public long this[int i]=>Value[i];

public static A117514Inst Instance=new A117514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117515
{
public static readonly long[] Value={ 1L,2L,6L,72L,1240L,33360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117515Inst : IEnumerable<long>
{
public static readonly long[] Value=A117515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117515.Bytes);
public long this[int i]=>Value[i];

public static A117515Inst Instance=new A117515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117516
{
public static readonly long[] Value={ 0L,3L,13L,28L,48L,73L,103L,152L,192L,273L,323L,444L,504L,673L,743L,968L,1048L,1337L,1427L,1788L,1888L,2329L,2439L,2968L,3088L,3713L,3843L,4572L,4712L,5553L,5703L,6664L,6824L,7913L,8083L,9308L,9488L,10857L,11047L,12568L,12768L,14449L,14659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117516Inst : IEnumerable<long>
{
public static readonly long[] Value=A117516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117516.Bytes);
public long this[int i]=>Value[i];

public static A117516Inst Instance=new A117516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117517
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,11L,14L,21L,23L,41L,65L,68L,179L,215L,216L,224L,254L,284L,285L,1485L,2361L,2693L,4655L,4838L,7215L,12780L,15378L,17999L,18755L,25416L,40919L,52455L,65010L,74045L,100553L,198689L,216890L,295020L,296844L,302355L,465758L,524948L,642803L,818003L,901529L,984360L,1452176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117517Inst : IEnumerable<long>
{
public static readonly long[] Value=A117517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117517.Bytes);
public long this[int i]=>Value[i];

public static A117517Inst Instance=new A117517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117518
{
public static readonly long[] Value={ 0L,1L,5L,10L,20L,33L,49L,75L,104L,147L,193L,257L,324L,413L,505L,623L,744L,895L,1049L,1237L,1428L,1657L,1889L,2163L,2440L,2763L,3089L,3465L,3844L,4277L,4713L,5207L,5704L,6263L,6825L,7453L,8084L,8785L,9489L,10267L,11048L,11907L,12769L,13713L,14660L,15693L,16729L,17855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117518Inst : IEnumerable<long>
{
public static readonly long[] Value=A117518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117518.Bytes);
public long this[int i]=>Value[i];

public static A117518Inst Instance=new A117518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117519
{
public static readonly long[] Value={ 0L,6L,15L,28L,36L,55L,105L,120L,210L,231L,378L,496L,528L,666L,990L,1540L,2145L,2556L,2628L,3081L,4095L,4186L,5460L,5565L,6105L,6555L,7140L,8128L,8256L,9316L,11628L,14706L,17955L,19900L,20100L,22155L,23436L,25200L,26565L,26796L,31878L,32131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117519Inst : IEnumerable<long>
{
public static readonly long[] Value=A117519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117519.Bytes);
public long this[int i]=>Value[i];

public static A117519Inst Instance=new A117519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117520
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,55L,66L,78L,91L,105L,120L,136L,190L,210L,231L,253L,276L,300L,325L,406L,435L,465L,496L,528L,561L,595L,703L,741L,780L,820L,861L,903L,946L,1081L,1128L,1176L,1225L,1275L,1326L,1378L,1540L,1596L,1653L,1711L,1770L,1830L,1891L,2080L,2145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117520Inst : IEnumerable<long>
{
public static readonly long[] Value=A117520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117520.Bytes);
public long this[int i]=>Value[i];

public static A117520Inst Instance=new A117520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117521
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,33L,35L,55L,57L,77L,79L,99L,101L,103L,303L,305L,505L,507L,707L,709L,909L,911L,121L,123L,323L,325L,525L,527L,727L,729L,929L,931L,141L,143L,343L,345L,545L,547L,747L,749L,949L,951L,161L,163L,363L,365L,565L,567L,767L,769L,969L,971L,181L,183L,383L,385L,585L,587L,787L,789L,989L,991L,201L,104L,403L,306L,605L,508L,807L,710L,19L,93L,41L,16L,63L,38L,85L,60L,8L,10L,3L,5L,7L,9L,11L,13L,33L,35L,55L,57L,77L,79L,99L,101L,103L,303L,305L,505L,507L,707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117521Inst : IEnumerable<long>
{
public static readonly long[] Value=A117521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117521.Bytes);
public long this[int i]=>Value[i];

public static A117521Inst Instance=new A117521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117522
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,15L,18L,20L,23L,26L,30L,35L,39L,56L,156L,176L,251L,306L,308L,431L,548L,680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117522Inst : IEnumerable<long>
{
public static readonly long[] Value=A117522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117522.Bytes);
public long this[int i]=>Value[i];

public static A117522Inst Instance=new A117522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117523
{
public static readonly long[] Value={ 0L,1L,10L,1596L,2775L,3486L,3828L,4278L,4656L,5565L,6555L,7626L,8256L,9453L,14196L,15753L,16653L,17391L,18336L,21945L,22791L,23871L,24753L,28920L,32385L,34716L,37128L,38226L,39621L,40755L,42195L,43365L,44850L,46056L,51681L,54615L,56280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117523Inst : IEnumerable<long>
{
public static readonly long[] Value=A117523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117523.Bytes);
public long this[int i]=>Value[i];

public static A117523Inst Instance=new A117523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117524
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,3L,3L,7L,8L,13L,17L,25L,32L,48L,59L,83L,108L,145L,183L,247L,310L,406L,512L,659L,824L,1055L,1307L,1651L,2047L,2558L,3146L,3913L,4788L,5904L,7202L,8821L,10707L,13054L,15770L,19118L,23027L,27775L,33312L,40029L,47835L,57231L,68182L,81261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117524Inst : IEnumerable<long>
{
public static readonly long[] Value=A117524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117524.Bytes);
public long this[int i]=>Value[i];

public static A117524Inst Instance=new A117524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117525
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,3L,7L,9L,20L,22L,44L,56L,90L,119L,186L,236L,355L,461L,651L,848L,1177L,1506L,2050L,2626L,3482L,4443L,5823L,7353L,9524L,11983L,15307L,19163L,24277L,30174L,37920L,46925L,58463L,72006L,89155L,109209L,134418L,163973L,200605L,243700L,296696L,358862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117525Inst : IEnumerable<long>
{
public static readonly long[] Value=A117525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117525.Bytes);
public long this[int i]=>Value[i];

public static A117525Inst Instance=new A117525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117526
{
public static readonly long[] Value={ 3L,10L,9837L,259441550133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117526Inst : IEnumerable<long>
{
public static readonly long[] Value=A117526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117526.Bytes);
public long this[int i]=>Value[i];

public static A117526Inst Instance=new A117526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117527
{
public static readonly long[] Value={ 5L,13L,109L,641L,757L,4007L,5387L,7901L,9349L,11467L,23297L,33503L,42193L,57139L,76343L,100213L,209597L,252583L,261631L,373621L,424231L,432287L,503593L,507961L,618593L,699427L,791489L,825389L,895243L,943837L,1212917L,1455901L,1573577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117527Inst : IEnumerable<long>
{
public static readonly long[] Value=A117527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117527.Bytes);
public long this[int i]=>Value[i];

public static A117527Inst Instance=new A117527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117528
{
public static readonly long[] Value={ 2L,3L,13L,41L,43L,109L,137L,167L,181L,199L,307L,373L,421L,491L,587L,661L,1009L,1097L,1117L,1373L,1471L,1483L,1601L,1607L,1787L,1913L,2053L,2089L,2203L,2267L,2591L,2819L,2953L,3191L,3361L,3623L,3691L,3779L,3877L,4051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117528Inst : IEnumerable<long>
{
public static readonly long[] Value=A117528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117528.Bytes);
public long this[int i]=>Value[i];

public static A117528Inst Instance=new A117528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117529
{
public static readonly long[] Value={ 168L,216L,294L,308L,348L,465L,530L,544L,657L,675L,824L,915L,927L,976L,1015L,1016L,1023L,1029L,1096L,1112L,1145L,1185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117529Inst : IEnumerable<long>
{
public static readonly long[] Value=A117529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117529.Bytes);
public long this[int i]=>Value[i];

public static A117529Inst Instance=new A117529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117530
{
public static readonly long[] Value={ 2L,3L,5L,5L,7L,11L,7L,9L,13L,19L,11L,13L,17L,23L,31L,13L,15L,19L,25L,33L,43L,17L,19L,23L,29L,37L,47L,59L,19L,21L,25L,31L,39L,49L,61L,75L,23L,25L,29L,35L,43L,53L,65L,79L,95L,29L,31L,35L,41L,49L,59L,71L,85L,101L,119L,31L,33L,37L,43L,51L,61L,73L,87L,103L,121L,141L,37L,39L,43L,49L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117530Inst : IEnumerable<long>
{
public static readonly long[] Value=A117530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117530.Bytes);
public long this[int i]=>Value[i];

public static A117530Inst Instance=new A117530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117531
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,3L,7L,3L,5L,6L,6L,6L,13L,3L,11L,8L,12L,8L,13L,10L,8L,7L,12L,10L,9L,21L,6L,22L,11L,7L,13L,12L,21L,13L,14L,16L,18L,7L,20L,17L,21L,20L,24L,14L,18L,20L,16L,16L,35L,10L,18L,29L,18L,30L,30L,26L,21L,18L,21L,29L,16L,22L,32L,40L,10L,27L,24L,25L,45L,18L,39L,40L,43L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117531Inst : IEnumerable<long>
{
public static readonly long[] Value=A117531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117531.Bytes);
public long this[int i]=>Value[i];

public static A117531Inst Instance=new A117531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117532
{
public static readonly long[] Value={ 1L,2L,4L,6L,3L,7L,8L,10L,5L,11L,12L,14L,9L,15L,17L,13L,18L,20L,16L,22L,19L,23L,24L,26L,21L,27L,29L,25L,30L,32L,28L,34L,31L,35L,36L,38L,33L,39L,41L,37L,42L,44L,40L,46L,43L,47L,48L,50L,45L,51L,53L,49L,54L,56L,52L,58L,55L,59L,60L,64L,57L,61L,62L,66L,63L,67L,68L,70L,65L,71L,72L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117532Inst : IEnumerable<long>
{
public static readonly long[] Value=A117532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117532.Bytes);
public long this[int i]=>Value[i];

public static A117532Inst Instance=new A117532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117533
{
public static readonly long[] Value={ 1L,3L,7L,13L,16L,23L,31L,41L,46L,57L,69L,83L,92L,107L,124L,137L,155L,175L,191L,213L,232L,255L,279L,305L,326L,353L,382L,407L,437L,469L,497L,531L,562L,597L,633L,671L,704L,743L,784L,821L,863L,907L,947L,993L,1036L,1083L,1131L,1181L,1226L,1277L,1330L,1379L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117533Inst : IEnumerable<long>
{
public static readonly long[] Value=A117533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117533.Bytes);
public long this[int i]=>Value[i];

public static A117533Inst Instance=new A117533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117534
{
public static readonly long[] Value={ 1L,2L,5L,3L,9L,4L,6L,7L,13L,8L,10L,11L,16L,12L,14L,19L,15L,17L,21L,18L,25L,20L,22L,23L,28L,24L,26L,31L,27L,29L,33L,30L,37L,32L,34L,35L,40L,36L,38L,43L,39L,41L,45L,42L,49L,44L,46L,47L,52L,48L,50L,55L,51L,53L,57L,54L,61L,56L,58L,59L,62L,63L,65L,60L,69L,64L,66L,67L,73L,68L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117534Inst : IEnumerable<long>
{
public static readonly long[] Value=A117534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117534.Bytes);
public long this[int i]=>Value[i];

public static A117534Inst Instance=new A117534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117535
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,1L,3L,3L,2L,4L,4L,2L,3L,3L,1L,3L,3L,2L,4L,4L,2L,3L,3L,1L,4L,4L,3L,6L,6L,3L,5L,5L,2L,6L,6L,4L,8L,8L,4L,6L,6L,2L,5L,5L,3L,6L,6L,3L,4L,4L,1L,4L,4L,3L,6L,6L,3L,5L,5L,2L,6L,6L,4L,8L,8L,4L,6L,6L,2L,5L,5L,3L,6L,6L,3L,4L,4L,1L,5L,5L,4L,8L,8L,4L,7L,7L,3L,9L,9L,6L,12L,12L,6L,9L,9L,3L,8L,8L,5L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117535Inst : IEnumerable<long>
{
public static readonly long[] Value=A117535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117535.Bytes);
public long this[int i]=>Value[i];

public static A117535Inst Instance=new A117535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117536
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,7L,10L,12L,19L,22L,27L,31L,41L,53L,72L,99L,118L,130L,152L,171L,217L,224L,270L,342L,422L,441L,494L,742L,764L,935L,954L,1012L,1106L,1178L,1236L,1395L,1448L,1578L,2460L,2684L,3395L,5585L,6079L,7033L,8269L,8539L,11664L,14348L,16808L,28742L,34691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117536Inst : IEnumerable<long>
{
public static readonly long[] Value=A117536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117536.Bytes);
public long this[int i]=>Value[i];

public static A117536Inst Instance=new A117536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117537
{
public static readonly long[] Value={ 2L,3L,5L,7L,12L,19L,31L,46L,53L,72L,270L,311L,954L,1178L,1308L,1395L,1578L,3395L,4190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117537Inst : IEnumerable<long>
{
public static readonly long[] Value=A117537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117537.Bytes);
public long this[int i]=>Value[i];

public static A117537Inst Instance=new A117537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117538
{
public static readonly long[] Value={ 2L,5L,7L,12L,19L,31L,41L,53L,72L,130L,171L,224L,270L,764L,954L,1178L,1395L,1578L,2684L,3395L,7033L,8269L,8539L,14348L,16808L,36269L,58973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117538Inst : IEnumerable<long>
{
public static readonly long[] Value=A117538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117538.Bytes);
public long this[int i]=>Value[i];

public static A117538Inst Instance=new A117538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117539
{
public static readonly long[] Value={ 12L,19L,31L,41L,46L,53L,58L,65L,72L,77L,87L,94L,99L,103L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117539Inst : IEnumerable<long>
{
public static readonly long[] Value=A117539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117539.Bytes);
public long this[int i]=>Value[i];

public static A117539Inst Instance=new A117539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117540
{
public static readonly long[] Value={ 13L,3L,2L,21L,1L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A117540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117540Inst : IEnumerable<long>
{
public static readonly long[] Value=A117540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117540.Bytes);
public long this[int i]=>Value[i];

public static A117540Inst Instance=new A117540Inst();

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