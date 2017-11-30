using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197105
{
public static readonly BigInteger[] Value={ 61L,13526L,2548972L,478107878L,89735942231L,16851142959473L,3164557733113615L,594285270687803282L,BigInteger.Parse("111603060903635664138"),BigInteger.Parse("20958362653981821987537"),BigInteger.Parse("3935850790928404307414023"),BigInteger.Parse("739128413975624217196282524") };
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
public class A197105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197105Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197105.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197105.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197105Inst Instance=new A197105Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197106
{
public static readonly BigInteger[] Value={ 212L,181032L,127561432L,89735942231L,63216096026066L,44545247280268585L,BigInteger.Parse("31390101087203449414"),BigInteger.Parse("22119869262708036718308"),BigInteger.Parse("15587336304367972010506477"),BigInteger.Parse("10984020530189934999886659182"),BigInteger.Parse("7740175041472778186520710031686") };
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
public class A197106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197106Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197106.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197106.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197106Inst Instance=new A197106Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197107
{
public static readonly BigInteger[] Value={ 753L,2421376L,6385146382L,16851142959473L,44545247280268585L,BigInteger.Parse("117783697209668555853") };
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
public class A197107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197107Inst Instance=new A197107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197108
{
public static readonly BigInteger[] Value={ 2661L,32393085L,319626874708L,3164557733113615L,BigInteger.Parse("31390101087203449414") };
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
public class A197108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197108.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197108Inst Instance=new A197108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197109
{
public static readonly long[] Value={ 2L,6L,6L,16L,78L,16L,61L,1015L,1015L,61L,212L,13526L,50831L,13526L,212L,753L,181032L,2548972L,2548972L,181032L,753L,2661L,2421376L,127561432L,478107878L,127561432L,2421376L,2661L,9415L,32393085L,6385146382L,89735942231L,89735942231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197109Inst : IEnumerable<long>
{
public static readonly long[] Value=A197109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197109.Bytes);
public long this[int i]=>Value[i];

public static A197109Inst Instance=new A197109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197110
{
public static readonly long[] Value={ 8L,1L,1L,7L,4L,2L,4L,2L,5L,2L,8L,3L,3L,5L,3L,6L,4L,3L,6L,3L,7L,0L,0L,2L,7L,7L,2L,4L,0L,5L,8L,7L,5L,9L,2L,7L,0L,8L,1L,0L,6L,3L,2L,1L,3L,9L,3L,9L,0L,4L,5L,1L,8L,0L,7L,6L,2L,2L,3L,2L,1L,6L,1L,5L,8L,3L,0L,9L,0L,4L,6L,2L,1L,4L,0L,2L,2L,6L,6L,3L,4L,9L,1L,7L,6L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197110Inst : IEnumerable<long>
{
public static readonly long[] Value=A197110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197110.Bytes);
public long this[int i]=>Value[i];

public static A197110Inst Instance=new A197110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197111
{
public static readonly long[] Value={ 0L,1L,2L,6L,1L,1L,3L,1L,1L,1L,2L,2L,1L,1L,2L,7L,1L,5L,5L,53L,3L,29L,3L,2L,6L,1L,1L,2L,1L,4L,8L,3L,2L,2L,1L,13L,1L,3L,1L,2L,1L,1L,1L,1L,2L,11L,4L,1L,37L,1L,142L,2L,1L,1L,8L,1L,19L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,3L,24L,1L,1L,1L,7L,1L,55L,9L,1L,1L,1L,224L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197111Inst : IEnumerable<long>
{
public static readonly long[] Value=A197111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197111.Bytes);
public long this[int i]=>Value[i];

public static A197111Inst Instance=new A197111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197112
{
public static readonly long[] Value={ 193L,3529L,9337L,27229L,46793L,78181L,90193L,112993L,135013L,437183L,849403L,935219L,1078579L,1283599L,1986973L,2209583L,2341183L,2411173L,2689693L,2744143L,3619069L,3712543L,4738183L,5132983L,6596119L,7829029L,8184713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197112Inst : IEnumerable<long>
{
public static readonly long[] Value=A197112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197112.Bytes);
public long this[int i]=>Value[i];

public static A197112Inst Instance=new A197112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197113
{
public static readonly long[] Value={ 1L,9L,10L,15L,21L,25L,26L,27L,33L,34L,35L,39L,45L,49L,50L,51L,55L,57L,58L,63L,65L,69L,74L,75L,77L,81L,82L,85L,87L,91L,93L,95L,99L,105L,106L,111L,115L,117L,119L,121L,122L,123L,125L,129L,130L,133L,135L,141L,143L,145L,146L,147L,153L,155L,159L,161L,165L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197113Inst : IEnumerable<long>
{
public static readonly long[] Value=A197113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197113.Bytes);
public long this[int i]=>Value[i];

public static A197113Inst Instance=new A197113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197114
{
public static readonly long[] Value={ 32009L,52009L,82009L,92009L,120091L,120097L,172009L,182009L,200903L,200909L,200927L,200929L,200971L,200983L,200987L,200989L,242009L,272009L,302009L,322009L,332009L,420097L,442009L,452009L,512009L,532009L,620099L,622009L,682009L,692009L,720091L,742009L,752009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197114Inst : IEnumerable<long>
{
public static readonly long[] Value=A197114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197114.Bytes);
public long this[int i]=>Value[i];

public static A197114Inst Instance=new A197114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197115
{
public static readonly long[] Value={ 2L,8L,10L,17L,18L,26L,32L,37L,40L,41L,50L,58L,65L,68L,72L,73L,74L,82L,89L,90L,97L,98L,101L,104L,106L,113L,122L,128L,130L,137L,145L,148L,153L,160L,162L,164L,170L,185L,193L,197L,200L,202L,218L,226L,232L,233L,234L,241L,242L,250L,257L,260L,265L,269L,272L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197115Inst : IEnumerable<long>
{
public static readonly long[] Value=A197115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197115.Bytes);
public long this[int i]=>Value[i];

public static A197115Inst Instance=new A197115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197116
{
public static readonly long[] Value={ 0L,2L,2L,2L,4L,1L,3L,1L,2L,2L,5L,1L,4L,2L,1L,2L,4L,3L,3L,1L,2L,1L,4L,1L,1L,1L,0L,2L,3L,1L,6L,1L,3L,1L,2L,3L,3L,3L,3L,1L,7L,3L,2L,1L,4L,2L,3L,1L,3L,1L,2L,2L,3L,1L,4L,3L,3L,1L,3L,0L,4L,0L,3L,3L,3L,2L,1L,2L,0L,3L,1L,2L,4L,4L,3L,1L,4L,2L,3L,3L,3L,2L,3L,6L,0L,4L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197116Inst : IEnumerable<long>
{
public static readonly long[] Value=A197116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197116.Bytes);
public long this[int i]=>Value[i];

public static A197116Inst Instance=new A197116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197117
{
public static readonly long[] Value={ 1L,2L,0L,3L,1L,2L,0L,3L,2L,2L,0L,3L,1L,4L,0L,3L,2L,5L,2L,4L,2L,1L,1L,2L,3L,2L,1L,2L,2L,3L,0L,4L,2L,4L,1L,2L,4L,7L,0L,4L,3L,3L,0L,4L,5L,1L,0L,3L,2L,2L,1L,1L,2L,2L,0L,2L,3L,2L,1L,4L,0L,5L,0L,2L,5L,4L,0L,7L,4L,2L,2L,7L,0L,3L,1L,2L,0L,5L,0L,2L,3L,1L,0L,4L,4L,0L,0L,1L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197117Inst : IEnumerable<long>
{
public static readonly long[] Value=A197117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197117.Bytes);
public long this[int i]=>Value[i];

public static A197117Inst Instance=new A197117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197118
{
public static readonly long[] Value={ 1L,2L,2L,3L,0L,4L,2L,3L,1L,4L,1L,4L,2L,1L,2L,5L,0L,5L,1L,2L,2L,4L,2L,4L,1L,3L,0L,6L,2L,4L,0L,4L,1L,3L,3L,4L,1L,4L,3L,2L,0L,5L,7L,1L,0L,5L,1L,5L,0L,1L,3L,7L,2L,8L,3L,4L,1L,4L,2L,8L,0L,3L,5L,6L,0L,7L,2L,2L,1L,1L,2L,8L,1L,2L,1L,7L,0L,2L,0L,3L,0L,5L,0L,4L,1L,2L,2L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197118Inst : IEnumerable<long>
{
public static readonly long[] Value=A197118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197118.Bytes);
public long this[int i]=>Value[i];

public static A197118Inst Instance=new A197118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197119
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,3L,2L,1L,1L,1L,2L,2L,2L,2L,4L,0L,5L,3L,3L,1L,3L,2L,2L,0L,3L,1L,4L,1L,3L,4L,1L,0L,4L,3L,1L,3L,1L,1L,2L,1L,4L,2L,2L,2L,1L,1L,3L,0L,0L,0L,4L,3L,1L,2L,6L,0L,4L,1L,2L,1L,2L,3L,3L,0L,3L,8L,4L,0L,2L,1L,1L,0L,1L,1L,4L,0L,3L,1L,7L,1L,5L,2L,1L,1L,4L,2L,3L,0L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197119Inst : IEnumerable<long>
{
public static readonly long[] Value=A197119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197119.Bytes);
public long this[int i]=>Value[i];

public static A197119Inst Instance=new A197119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197120
{
public static readonly long[] Value={ 5L,13L,20L,29L,45L,52L,53L,61L,80L,85L,109L,116L,117L,125L,149L,157L,173L,180L,181L,208L,212L,229L,244L,245L,261L,277L,293L,317L,320L,325L,340L,365L,397L,405L,421L,436L,445L,461L,464L,468L,477L,493L,500L,509L,533L,541L,549L,565L,596L,605L,613L,628L,629L,637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197120Inst : IEnumerable<long>
{
public static readonly long[] Value=A197120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197120.Bytes);
public long this[int i]=>Value[i];

public static A197120Inst Instance=new A197120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197121
{
public static readonly long[] Value={ 21L,69L,77L,84L,93L,133L,165L,189L,205L,213L,221L,237L,253L,276L,285L,301L,308L,309L,336L,341L,357L,372L,413L,429L,437L,453L,469L,501L,517L,525L,532L,581L,589L,597L,621L,645L,660L,669L,693L,717L,741L,749L,756L,789L,805L,820L,837L,852L,861L,869L,884L,893L,917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197121Inst : IEnumerable<long>
{
public static readonly long[] Value=A197121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197121.Bytes);
public long this[int i]=>Value[i];

public static A197121Inst Instance=new A197121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197122
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,7L,7L,11L,12L,17L,18L,26L,28L,37L,40L,53L,57L,74L,79L,101L,109L,136L,145L,181L,195L,237L,255L,308L,332L,397L,427L,506L,546L,641L,688L,807L,868L,1007L,1081L,1250L,1342L,1544L,1655L,1893L,2033L,2313L,2477L,2812L,3015L,3403L,3644L,4102L,4390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197122Inst : IEnumerable<long>
{
public static readonly long[] Value=A197122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197122.Bytes);
public long this[int i]=>Value[i];

public static A197122Inst Instance=new A197122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197123
{
public static readonly long[] Value={ 1L,26L,592L,582L,60943L,949129L,8530614L,52637962L,201890888L,4392366484L,89879780761L,756130190263L,3186120489507L,18220874234996L,276854551127715L,8230687217052243L,93415455347042966L,13724950651727463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197123Inst : IEnumerable<long>
{
public static readonly long[] Value=A197123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197123.Bytes);
public long this[int i]=>Value[i];

public static A197123Inst Instance=new A197123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197124
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,11L,31L,71L,9L,23L,29L,313L,74L,14L,34L,75L,35L,96L,16L,77L,17L,37L,98L,38L,99L,710L,110L,310L,7109L,113L,12L,713L,1137L,13L,91L,4L,915L,115L,716L,316L,717L,317L,918L,119L,1193L,19L,719L,92L,112L,232L,27L,22L,923L,32L,39L,24L,125L,1257L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197124Inst : IEnumerable<long>
{
public static readonly long[] Value=A197124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197124.Bytes);
public long this[int i]=>Value[i];

public static A197124Inst Instance=new A197124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197125
{
public static readonly long[] Value={ 1L,4L,9L,10L,40L,90L,100L,400L,900L,1000L,1111L,1177L,1224L,1242L,1339L,1393L,1422L,1717L,1771L,1933L,2124L,2142L,2214L,2241L,2412L,2421L,3139L,3193L,3319L,3391L,3913L,3931L,4000L,4122L,4212L,4221L,4444L,4588L,4669L,4696L,4858L,4885L,4966L,5488L,5848L,5884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197125Inst : IEnumerable<long>
{
public static readonly long[] Value=A197125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197125.Bytes);
public long this[int i]=>Value[i];

public static A197125Inst Instance=new A197125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197126
{
public static readonly long[] Value={ 1L,1L,1L,3L,0L,1L,4L,2L,0L,1L,8L,2L,1L,0L,1L,11L,4L,2L,1L,0L,1L,19L,5L,3L,1L,1L,0L,1L,26L,10L,3L,3L,1L,1L,0L,1L,41L,11L,7L,3L,2L,1L,1L,0L,1L,56L,20L,8L,5L,3L,2L,1L,1L,0L,1L,83L,25L,13L,6L,5L,2L,2L,1L,1L,0L,1L,112L,38L,17L,11L,5L,5L,2L,2L,1L,1L,0L,1L,160L,49L,25L,13L,9L,5L,4L,2L,2L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197126Inst : IEnumerable<long>
{
public static readonly long[] Value=A197126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197126.Bytes);
public long this[int i]=>Value[i];

public static A197126Inst Instance=new A197126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197127
{
public static readonly long[] Value={ 6L,14L,22L,30L,34L,38L,42L,46L,54L,56L,62L,66L,69L,70L,78L,86L,87L,93L,94L,102L,110L,114L,115L,118L,126L,130L,132L,134L,138L,142L,146L,150L,154L,155L,156L,158L,159L,166L,174L,177L,178L,182L,183L,184L,185L,186L,190L,194L,198L,206L,210L,214L,220L,222L,228L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197127Inst : IEnumerable<long>
{
public static readonly long[] Value=A197127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197127.Bytes);
public long this[int i]=>Value[i];

public static A197127Inst Instance=new A197127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197128
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,23L,24L,26L,27L,28L,29L,31L,32L,33L,35L,37L,39L,40L,41L,43L,44L,45L,47L,48L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,63L,65L,67L,68L,71L,72L,73L,74L,75L,76L,77L,79L,80L,82L,83L,84L,85L,88L,89L,90L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197128Inst : IEnumerable<long>
{
public static readonly long[] Value=A197128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197128.Bytes);
public long this[int i]=>Value[i];

public static A197128Inst Instance=new A197128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197129
{
public static readonly long[] Value={ 1L,4L,9L,10L,40L,90L,100L,400L,900L,1000L,1111L,1224L,1242L,1339L,1393L,1422L,1933L,2124L,2142L,2214L,2241L,2412L,2421L,3139L,3193L,3319L,3391L,3913L,3931L,4000L,4122L,4212L,4221L,4444L,4669L,4696L,4966L,6469L,6496L,6649L,6694L,6946L,6964L,9000L,9133L,9313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197129Inst : IEnumerable<long>
{
public static readonly long[] Value=A197129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197129.Bytes);
public long this[int i]=>Value[i];

public static A197129Inst Instance=new A197129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197130
{
public static readonly BigInteger[] Value={ 1L,10L,100L,1136L,14816L,220032L,3679488L,68548608L,1409347584L,31717048320L,775808778240L,20499651624960L,582040706088960L,17674457139118080L,571655258741145600L,BigInteger.Parse("19621314364126003200"),BigInteger.Parse("712374154997583052800"),BigInteger.Parse("27277192770051951820800") };
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
public class A197130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197130Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197130.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197130Inst Instance=new A197130Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197131
{
public static readonly BigInteger[] Value={ 4L,46L,544L,7216L,108096L,1816704L,33951744L,699512832L,15765626880L,386046443520L,10208951009280L,290039357767680L,8811722692362240L,285113464809062400L,9789232245217689600UL,BigInteger.Parse("355501479519741542400"),BigInteger.Parse("13615286053738276454400"),BigInteger.Parse("548476851979845579571200") };
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
public class A197131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197131Inst Instance=new A197131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197132
{
public static readonly long[] Value={ 1L,4L,16L,52L,157L,434L,1144L,2862L,6906L,16090L,36449L,80430L,173555L,366802L,761102L,1552569L,3118508L,6174461L,12064383L,23283027L,44419855L,83834278L,156626605L,289839251L,531534746L,966483534L,1743164649L,3119864511L,5543030861L,9779552117L,17139055493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197132Inst : IEnumerable<long>
{
public static readonly long[] Value=A197132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197132.Bytes);
public long this[int i]=>Value[i];

public static A197132Inst Instance=new A197132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197133
{
public static readonly long[] Value={ 2L,7L,2L,9L,7L,1L,8L,4L,9L,2L,3L,6L,8L,2L,4L,9L,5L,0L,4L,0L,8L,6L,1L,6L,8L,0L,6L,0L,8L,3L,8L,6L,9L,8L,3L,1L,0L,4L,7L,4L,0L,6L,6L,5L,1L,9L,6L,6L,4L,4L,0L,1L,8L,2L,7L,6L,6L,8L,0L,0L,0L,1L,1L,4L,8L,4L,3L,3L,5L,9L,2L,7L,0L,1L,0L,2L,2L,0L,8L,9L,0L,4L,3L,5L,9L,2L,4L,4L,8L,6L,4L,3L,1L,9L,4L,0L,5L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197133Inst : IEnumerable<long>
{
public static readonly long[] Value=A197133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197133.Bytes);
public long this[int i]=>Value[i];

public static A197133Inst Instance=new A197133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197134
{
public static readonly long[] Value={ 1L,1L,5L,4L,0L,2L,2L,6L,7L,3L,8L,7L,1L,2L,7L,8L,8L,2L,8L,5L,9L,2L,3L,6L,7L,4L,7L,9L,5L,7L,3L,6L,8L,7L,0L,4L,8L,4L,0L,3L,5L,4L,2L,1L,9L,7L,7L,9L,8L,2L,0L,1L,9L,0L,3L,3L,3L,9L,1L,1L,7L,8L,6L,8L,2L,4L,2L,8L,6L,9L,2L,2L,4L,2L,3L,8L,9L,4L,6L,1L,7L,7L,3L,0L,4L,8L,6L,3L,1L,4L,6L,1L,2L,8L,4L,3L,4L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197134Inst : IEnumerable<long>
{
public static readonly long[] Value=A197134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197134.Bytes);
public long this[int i]=>Value[i];

public static A197134Inst Instance=new A197134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197135
{
public static readonly long[] Value={ 6L,3L,8L,3L,2L,7L,3L,0L,5L,0L,7L,8L,0L,4L,2L,1L,7L,6L,6L,2L,3L,6L,3L,4L,6L,4L,4L,6L,0L,3L,0L,3L,3L,4L,2L,6L,1L,1L,8L,1L,7L,1L,1L,2L,1L,3L,4L,4L,4L,6L,0L,3L,0L,0L,5L,4L,1L,7L,3L,8L,2L,6L,2L,6L,5L,9L,0L,9L,6L,1L,1L,4L,2L,7L,3L,5L,2L,4L,9L,2L,9L,1L,4L,0L,8L,3L,0L,0L,4L,2L,2L,0L,4L,8L,0L,4L,4L,8L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197135Inst : IEnumerable<long>
{
public static readonly long[] Value=A197135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197135.Bytes);
public long this[int i]=>Value[i];

public static A197135Inst Instance=new A197135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197136
{
public static readonly long[] Value={ 4L,5L,5L,4L,0L,1L,9L,1L,3L,1L,2L,1L,4L,9L,0L,1L,8L,8L,6L,2L,7L,7L,3L,7L,4L,4L,3L,2L,4L,0L,1L,8L,1L,2L,5L,1L,0L,4L,1L,4L,1L,8L,8L,0L,2L,7L,0L,2L,7L,8L,0L,0L,6L,8L,4L,8L,2L,9L,8L,3L,7L,6L,5L,8L,3L,5L,7L,6L,7L,1L,1L,6L,7L,0L,4L,9L,2L,9L,6L,4L,8L,5L,6L,6L,4L,5L,9L,0L,6L,1L,5L,5L,5L,8L,4L,7L,3L,3L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197136Inst : IEnumerable<long>
{
public static readonly long[] Value=A197136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197136.Bytes);
public long this[int i]=>Value[i];

public static A197136Inst Instance=new A197136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197137
{
public static readonly long[] Value={ 3L,3L,5L,0L,1L,6L,2L,3L,1L,5L,9L,4L,3L,7L,7L,2L,2L,8L,7L,6L,6L,7L,5L,8L,7L,3L,2L,8L,8L,1L,5L,5L,7L,1L,0L,1L,9L,4L,1L,7L,2L,0L,5L,6L,2L,7L,5L,0L,0L,2L,5L,9L,5L,5L,3L,4L,7L,3L,1L,0L,2L,0L,6L,0L,2L,9L,9L,3L,2L,3L,3L,6L,1L,1L,7L,7L,1L,8L,5L,2L,3L,0L,0L,9L,0L,7L,0L,0L,4L,9L,0L,8L,6L,3L,6L,7L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197137Inst : IEnumerable<long>
{
public static readonly long[] Value=A197137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197137.Bytes);
public long this[int i]=>Value[i];

public static A197137Inst Instance=new A197137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197138
{
public static readonly long[] Value={ 3L,4L,8L,8L,3L,0L,2L,2L,3L,1L,8L,9L,9L,0L,3L,3L,3L,8L,6L,3L,0L,1L,1L,3L,2L,5L,5L,3L,4L,2L,8L,8L,1L,2L,3L,2L,7L,7L,1L,5L,9L,4L,2L,4L,2L,1L,4L,1L,3L,2L,4L,2L,5L,0L,2L,7L,8L,0L,5L,2L,7L,1L,9L,4L,2L,3L,3L,5L,2L,7L,4L,3L,9L,4L,6L,5L,1L,7L,3L,0L,1L,4L,4L,2L,8L,4L,9L,2L,6L,9L,4L,7L,1L,9L,7L,8L,3L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197138Inst : IEnumerable<long>
{
public static readonly long[] Value=A197138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197138.Bytes);
public long this[int i]=>Value[i];

public static A197138Inst Instance=new A197138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197139
{
public static readonly long[] Value={ 2L,8L,8L,6L,1L,1L,7L,1L,0L,5L,8L,9L,8L,0L,0L,1L,2L,9L,1L,5L,3L,6L,7L,2L,6L,5L,3L,2L,0L,0L,9L,5L,1L,1L,4L,1L,4L,5L,1L,7L,1L,7L,7L,6L,1L,7L,4L,7L,7L,3L,9L,4L,8L,5L,3L,3L,8L,8L,0L,7L,7L,5L,4L,2L,9L,4L,9L,9L,1L,5L,0L,7L,4L,1L,3L,0L,8L,4L,2L,4L,6L,6L,2L,4L,9L,4L,9L,2L,7L,6L,4L,3L,9L,9L,0L,1L,8L,3L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197139Inst : IEnumerable<long>
{
public static readonly long[] Value=A197139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197139.Bytes);
public long this[int i]=>Value[i];

public static A197139Inst Instance=new A197139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197140
{
public static readonly long[] Value={ 1L,4L,4L,0L,6L,1L,9L,7L,0L,0L,5L,3L,8L,1L,9L,9L,1L,1L,7L,6L,3L,3L,2L,5L,2L,3L,0L,2L,5L,8L,9L,2L,7L,7L,4L,3L,5L,3L,7L,9L,9L,0L,9L,4L,7L,2L,6L,0L,8L,9L,0L,3L,3L,7L,7L,3L,9L,8L,4L,6L,7L,3L,6L,4L,2L,5L,6L,5L,6L,3L,7L,3L,8L,9L,3L,2L,7L,7L,8L,9L,2L,9L,4L,2L,8L,1L,7L,1L,4L,8L,8L,0L,4L,1L,0L,3L,9L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197140Inst : IEnumerable<long>
{
public static readonly long[] Value=A197140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197140.Bytes);
public long this[int i]=>Value[i];

public static A197140Inst Instance=new A197140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197141
{
public static readonly long[] Value={ 1L,6L,7L,3L,6L,4L,7L,3L,0L,4L,1L,5L,2L,9L,1L,5L,0L,7L,8L,0L,1L,3L,8L,6L,3L,4L,3L,3L,2L,7L,8L,1L,6L,6L,0L,2L,6L,8L,5L,8L,3L,6L,5L,7L,7L,1L,0L,3L,5L,3L,9L,2L,8L,6L,1L,7L,9L,9L,4L,6L,0L,5L,6L,9L,5L,2L,6L,1L,8L,9L,5L,6L,2L,8L,0L,5L,4L,7L,5L,7L,2L,9L,1L,1L,9L,3L,7L,1L,7L,0L,9L,5L,8L,5L,1L,2L,9L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197141Inst : IEnumerable<long>
{
public static readonly long[] Value=A197141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197141.Bytes);
public long this[int i]=>Value[i];

public static A197141Inst Instance=new A197141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197142
{
public static readonly long[] Value={ 2L,6L,9L,1L,4L,1L,3L,9L,7L,9L,7L,8L,1L,7L,3L,6L,7L,9L,1L,9L,2L,8L,8L,6L,5L,6L,0L,5L,7L,5L,3L,2L,2L,5L,2L,1L,8L,3L,8L,5L,7L,6L,7L,6L,4L,6L,9L,2L,4L,6L,8L,9L,7L,0L,9L,7L,1L,2L,4L,7L,6L,5L,3L,6L,6L,0L,0L,4L,2L,2L,1L,8L,8L,2L,5L,9L,8L,6L,2L,1L,0L,6L,1L,9L,1L,0L,1L,9L,6L,9L,9L,3L,8L,3L,3L,7L,6L,0L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197142Inst : IEnumerable<long>
{
public static readonly long[] Value=A197142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197142.Bytes);
public long this[int i]=>Value[i];

public static A197142Inst Instance=new A197142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197143
{
public static readonly long[] Value={ 2L,7L,4L,6L,3L,9L,4L,1L,0L,7L,6L,1L,0L,0L,7L,1L,1L,6L,5L,6L,7L,9L,9L,5L,4L,9L,7L,2L,2L,5L,2L,5L,7L,3L,3L,7L,4L,3L,9L,0L,5L,1L,4L,5L,6L,9L,1L,4L,5L,8L,6L,7L,1L,7L,4L,6L,4L,6L,3L,3L,5L,2L,3L,4L,4L,2L,2L,7L,3L,4L,8L,3L,1L,6L,8L,3L,0L,0L,4L,7L,0L,6L,1L,1L,5L,0L,0L,9L,6L,4L,4L,3L,2L,2L,4L,7L,9L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197143Inst : IEnumerable<long>
{
public static readonly long[] Value=A197143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197143.Bytes);
public long this[int i]=>Value[i];

public static A197143Inst Instance=new A197143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197144
{
public static readonly long[] Value={ 3L,8L,2L,8L,9L,1L,1L,1L,4L,1L,5L,4L,2L,9L,4L,3L,6L,5L,3L,2L,1L,9L,8L,8L,2L,2L,4L,1L,3L,9L,6L,4L,8L,6L,7L,2L,1L,7L,2L,4L,4L,5L,0L,5L,3L,9L,0L,2L,8L,4L,8L,7L,2L,0L,0L,6L,8L,2L,2L,8L,6L,6L,4L,6L,4L,8L,7L,9L,4L,9L,4L,6L,6L,2L,6L,1L,3L,2L,4L,9L,7L,5L,7L,1L,7L,5L,9L,4L,6L,9L,1L,5L,9L,2L,6L,0L,8L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197144Inst : IEnumerable<long>
{
public static readonly long[] Value=A197144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197144.Bytes);
public long this[int i]=>Value[i];

public static A197144Inst Instance=new A197144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197145
{
public static readonly long[] Value={ 3L,7L,4L,2L,3L,8L,9L,1L,4L,2L,4L,4L,5L,1L,8L,4L,1L,9L,5L,1L,8L,5L,8L,7L,4L,1L,5L,7L,1L,6L,1L,4L,0L,6L,6L,7L,0L,4L,5L,0L,6L,4L,6L,4L,8L,5L,2L,6L,0L,5L,4L,6L,0L,6L,9L,0L,4L,8L,1L,7L,1L,5L,0L,7L,3L,7L,4L,9L,5L,6L,2L,2L,6L,8L,0L,8L,9L,9L,8L,5L,9L,9L,2L,0L,1L,0L,6L,0L,7L,8L,9L,0L,7L,6L,1L,6L,9L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197145Inst : IEnumerable<long>
{
public static readonly long[] Value=A197145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197145.Bytes);
public long this[int i]=>Value[i];

public static A197145Inst Instance=new A197145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197146
{
public static readonly long[] Value={ 4L,9L,2L,5L,4L,5L,5L,2L,2L,0L,4L,3L,5L,0L,0L,2L,8L,4L,4L,0L,9L,7L,4L,9L,8L,0L,2L,1L,9L,0L,5L,0L,2L,7L,3L,0L,7L,8L,7L,4L,1L,2L,9L,9L,2L,1L,1L,4L,9L,9L,6L,8L,6L,7L,1L,5L,9L,4L,8L,6L,0L,3L,3L,2L,4L,7L,8L,5L,2L,6L,5L,8L,1L,6L,3L,1L,3L,8L,3L,0L,0L,5L,0L,8L,7L,6L,8L,0L,1L,9L,9L,1L,3L,3L,0L,7L,6L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197146Inst : IEnumerable<long>
{
public static readonly long[] Value=A197146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197146.Bytes);
public long this[int i]=>Value[i];

public static A197146Inst Instance=new A197146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197147
{
public static readonly long[] Value={ 4L,7L,0L,8L,0L,0L,0L,0L,1L,7L,4L,9L,6L,4L,6L,0L,2L,7L,3L,9L,3L,1L,7L,3L,5L,6L,4L,4L,1L,0L,5L,4L,5L,3L,5L,3L,3L,8L,5L,0L,6L,9L,2L,6L,7L,9L,9L,5L,1L,2L,9L,0L,8L,3L,1L,2L,1L,0L,9L,5L,6L,9L,5L,1L,9L,1L,4L,2L,6L,9L,5L,3L,3L,3L,0L,7L,7L,9L,3L,1L,2L,8L,6L,3L,1L,3L,7L,8L,1L,7L,5L,8L,5L,6L,3L,2L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197147Inst : IEnumerable<long>
{
public static readonly long[] Value=A197147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197147.Bytes);
public long this[int i]=>Value[i];

public static A197147Inst Instance=new A197147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197148
{
public static readonly long[] Value={ 1L,6L,0L,4L,7L,9L,3L,6L,1L,8L,4L,6L,2L,1L,3L,9L,9L,0L,7L,3L,7L,8L,3L,1L,7L,9L,5L,0L,7L,1L,7L,9L,6L,1L,8L,4L,6L,7L,1L,5L,4L,4L,9L,2L,1L,9L,9L,9L,1L,2L,8L,6L,0L,7L,7L,8L,6L,3L,6L,2L,9L,2L,2L,1L,4L,9L,2L,1L,6L,3L,7L,2L,6L,1L,9L,1L,2L,6L,0L,4L,2L,1L,6L,6L,7L,9L,9L,7L,0L,2L,2L,8L,4L,7L,0L,1L,4L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197148Inst : IEnumerable<long>
{
public static readonly long[] Value=A197148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197148.Bytes);
public long this[int i]=>Value[i];

public static A197148Inst Instance=new A197148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197149
{
public static readonly long[] Value={ 1L,9L,9L,9L,1L,5L,8L,3L,9L,9L,5L,8L,0L,3L,4L,4L,2L,6L,8L,8L,1L,7L,4L,2L,3L,5L,4L,3L,8L,4L,6L,1L,6L,4L,7L,3L,4L,1L,3L,2L,8L,2L,3L,4L,7L,1L,1L,8L,9L,0L,6L,8L,3L,7L,7L,0L,9L,2L,8L,1L,2L,8L,1L,0L,4L,6L,8L,5L,4L,8L,5L,2L,8L,7L,0L,0L,4L,9L,0L,3L,2L,7L,6L,5L,3L,7L,3L,7L,5L,1L,3L,1L,8L,9L,2L,0L,5L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197149Inst : IEnumerable<long>
{
public static readonly long[] Value=A197149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197149.Bytes);
public long this[int i]=>Value[i];

public static A197149Inst Instance=new A197149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197150
{
public static readonly long[] Value={ 2L,8L,5L,1L,0L,5L,9L,7L,9L,0L,6L,2L,9L,8L,6L,2L,6L,3L,9L,8L,2L,6L,0L,7L,2L,3L,4L,0L,8L,5L,3L,6L,2L,6L,8L,9L,3L,3L,3L,9L,0L,9L,3L,5L,8L,1L,7L,2L,2L,1L,0L,1L,7L,3L,2L,2L,7L,0L,3L,3L,5L,9L,2L,6L,3L,9L,6L,4L,6L,0L,5L,4L,3L,6L,4L,2L,1L,0L,3L,0L,0L,7L,6L,0L,4L,2L,3L,4L,3L,8L,3L,2L,1L,8L,5L,2L,6L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197150Inst : IEnumerable<long>
{
public static readonly long[] Value=A197150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197150.Bytes);
public long this[int i]=>Value[i];

public static A197150Inst Instance=new A197150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197151
{
public static readonly long[] Value={ 3L,1L,6L,0L,9L,4L,6L,9L,7L,3L,0L,6L,5L,4L,4L,6L,5L,0L,6L,1L,3L,5L,8L,4L,4L,2L,7L,9L,9L,1L,7L,5L,8L,5L,1L,2L,1L,8L,2L,1L,5L,9L,8L,7L,5L,0L,7L,7L,8L,1L,5L,1L,2L,0L,1L,1L,2L,2L,6L,6L,0L,0L,3L,9L,0L,9L,7L,3L,9L,2L,1L,0L,8L,9L,2L,2L,3L,1L,0L,1L,2L,3L,7L,1L,5L,4L,0L,1L,3L,3L,7L,8L,3L,3L,5L,1L,0L,7L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197151Inst : IEnumerable<long>
{
public static readonly long[] Value=A197151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197151.Bytes);
public long this[int i]=>Value[i];

public static A197151Inst Instance=new A197151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197152
{
public static readonly long[] Value={ 3L,1L,5L,0L,9L,1L,1L,0L,8L,4L,3L,3L,5L,9L,4L,2L,6L,1L,2L,0L,5L,2L,8L,5L,6L,7L,3L,7L,5L,4L,2L,1L,5L,0L,1L,4L,0L,6L,2L,2L,5L,6L,2L,9L,3L,7L,1L,7L,4L,0L,6L,9L,9L,1L,8L,3L,8L,7L,1L,8L,7L,8L,9L,1L,8L,1L,3L,6L,6L,1L,9L,1L,5L,6L,2L,0L,2L,9L,2L,3L,6L,5L,0L,5L,6L,2L,1L,8L,0L,4L,1L,8L,8L,5L,5L,5L,4L,2L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197152Inst : IEnumerable<long>
{
public static readonly long[] Value=A197152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197152.Bytes);
public long this[int i]=>Value[i];

public static A197152Inst Instance=new A197152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197153
{
public static readonly long[] Value={ 1L,4L,8L,1L,5L,0L,6L,5L,0L,5L,8L,4L,4L,3L,0L,9L,1L,9L,4L,0L,3L,5L,9L,2L,5L,3L,0L,6L,6L,1L,1L,1L,4L,1L,7L,3L,6L,8L,1L,0L,5L,2L,2L,1L,1L,7L,1L,5L,7L,4L,1L,6L,1L,8L,6L,8L,5L,0L,4L,8L,6L,5L,0L,0L,7L,1L,1L,5L,4L,4L,9L,9L,4L,7L,0L,5L,6L,5L,9L,1L,4L,7L,2L,5L,7L,2L,4L,3L,2L,3L,1L,9L,0L,7L,7L,4L,3L,3L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197153Inst : IEnumerable<long>
{
public static readonly long[] Value=A197153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197153.Bytes);
public long this[int i]=>Value[i];

public static A197153Inst Instance=new A197153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197154
{
public static readonly long[] Value={ 4L,2L,2L,3L,6L,0L,3L,3L,0L,4L,1L,9L,3L,9L,8L,1L,1L,4L,7L,6L,0L,7L,9L,3L,9L,5L,2L,5L,9L,6L,1L,6L,9L,0L,1L,4L,2L,0L,9L,3L,1L,8L,6L,8L,4L,1L,9L,3L,2L,0L,8L,6L,3L,1L,1L,7L,6L,6L,3L,2L,5L,7L,8L,0L,7L,1L,2L,4L,8L,7L,6L,2L,3L,0L,6L,5L,6L,6L,0L,5L,7L,7L,8L,3L,5L,2L,3L,0L,8L,5L,0L,5L,5L,3L,0L,6L,3L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197154Inst : IEnumerable<long>
{
public static readonly long[] Value=A197154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197154.Bytes);
public long this[int i]=>Value[i];

public static A197154Inst Instance=new A197154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197155
{
public static readonly long[] Value={ 1L,9L,4L,6L,3L,4L,6L,4L,0L,2L,3L,7L,8L,4L,8L,3L,8L,5L,6L,1L,6L,6L,4L,0L,9L,1L,1L,4L,2L,3L,0L,0L,8L,0L,6L,8L,1L,8L,5L,8L,2L,1L,0L,6L,7L,1L,1L,7L,6L,0L,3L,8L,5L,7L,0L,1L,8L,9L,2L,3L,8L,5L,0L,9L,1L,0L,4L,9L,9L,8L,9L,5L,6L,0L,1L,8L,8L,6L,8L,0L,1L,9L,1L,0L,7L,7L,4L,4L,3L,2L,0L,7L,0L,6L,5L,2L,2L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197155Inst : IEnumerable<long>
{
public static readonly long[] Value=A197155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197155.Bytes);
public long this[int i]=>Value[i];

public static A197155Inst Instance=new A197155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197156
{
public static readonly long[] Value={ 1L,3L,5L,20L,56L,225L,819L,3333L,13336L,55231L,229146L,963284L,4068503L,17301000L,73893082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197156Inst : IEnumerable<long>
{
public static readonly long[] Value=A197156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197156.Bytes);
public long this[int i]=>Value[i];

public static A197156Inst Instance=new A197156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197157
{
public static readonly long[] Value={ 1L,4L,8L,34L,106L,430L,1616L,6594L,26588L,110188L,457964L,1925498L,8135692L,34597729L,147780810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197157Inst : IEnumerable<long>
{
public static readonly long[] Value=A197157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197157.Bytes);
public long this[int i]=>Value[i];

public static A197157Inst Instance=new A197157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197158
{
public static readonly long[] Value={ 2L,5L,16L,57L,212L,817L,3232L,13018L,53176L,219680L,915928L,3848079L,16271384L,69183099L,295561620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197158Inst : IEnumerable<long>
{
public static readonly long[] Value=A197158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197158.Bytes);
public long this[int i]=>Value[i];

public static A197158Inst Instance=new A197158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197159
{
public static readonly long[] Value={ 1L,3L,8L,25L,80L,291L,1036L,3875L,14561L,55624L,213951L,830712L,3244355L,12747718L,50320659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197159Inst : IEnumerable<long>
{
public static readonly long[] Value=A197159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197159.Bytes);
public long this[int i]=>Value[i];

public static A197159Inst Instance=new A197159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197160
{
public static readonly long[] Value={ 6L,15L,44L,141L,480L,1703L,6216L,23136L,87334L,333309L,1283706L,4982458L,19466130L,76479612L,301923554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197160Inst : IEnumerable<long>
{
public static readonly long[] Value=A197160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197160.Bytes);
public long this[int i]=>Value[i];

public static A197160Inst Instance=new A197160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197161
{
public static readonly ulong[] Value={ 1L,5L,66L,2573L,331406L,135820428L,178698032203L,752158409985973L,10105549470186567265UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197161Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A197161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197161.Bytes);
public ulong this[int i]=>Value[i];

public static A197161Inst Instance=new A197161Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197162
{
public static readonly long[] Value={ 2L,14L,66L,306L,1489L,7106L,34021L,162800L,779173L,3731019L,17861710L,85505996L,409326530L,1959518173L,9380666694L,44907278950L,214980183814L,1029152921923L,4926762747428L,23585417675523L,112908198853318L,540514482104282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197162Inst : IEnumerable<long>
{
public static readonly long[] Value=A197162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197162.Bytes);
public long this[int i]=>Value[i];

public static A197162Inst Instance=new A197162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197163
{
public static readonly long[] Value={ 3L,37L,306L,2573L,21826L,183864L,1566649L,13348347L,113287557L,961919858L,8175928275L,69488321244L,590397703542L,5016197696693L,42623892116103L,362188045090417L,3077507174666026L,26149460063126683L,222193621588208558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197163Inst : IEnumerable<long>
{
public static readonly long[] Value=A197163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197163.Bytes);
public long this[int i]=>Value[i];

public static A197163Inst Instance=new A197163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197164
{
public static readonly long[] Value={ 4L,104L,1489L,21826L,331406L,5021137L,76504483L,1160102790L,17605551567L,267441999728L,4060960996702L,61654151235887L,936161404082139L,14215009257449597L,215837797323357413L,3277242369403821064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197164Inst : IEnumerable<long>
{
public static readonly long[] Value=A197164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197164.Bytes);
public long this[int i]=>Value[i];

public static A197164Inst Instance=new A197164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197165
{
public static readonly BigInteger[] Value={ 6L,290L,7106L,183864L,5021137L,135820428L,3683084153L,99818807528L,2707589789345L,73439922027377L,1991359749836248L,54002873765907282L,1464524123912748354L,BigInteger.Parse("39716029408785484453"),BigInteger.Parse("1077051645006852678606") };
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
public class A197165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197165Inst Instance=new A197165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197166
{
public static readonly BigInteger[] Value={ 9L,803L,34021L,1566649L,76504483L,3683084153L,178698032203L,8671417152697L,420572258618870L,20392149427584727L,988923590004910009L,BigInteger.Parse("47963802827535239077"),BigInteger.Parse("2326158501038746896505"),BigInteger.Parse("112811333889530786883021") };
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
public class A197166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197166Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197166.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197166Inst Instance=new A197166Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197167
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,3L,14L,14L,3L,4L,37L,66L,37L,4L,6L,104L,306L,306L,104L,6L,9L,290L,1489L,2573L,1489L,290L,9L,13L,803L,7106L,21826L,21826L,7106L,803L,13L,19L,2233L,34021L,183864L,331406L,183864L,34021L,2233L,19L,28L,6207L,162800L,1566649L,5021137L,5021137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197167Inst : IEnumerable<long>
{
public static readonly long[] Value=A197167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197167.Bytes);
public long this[int i]=>Value[i];

public static A197167Inst Instance=new A197167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197168
{
public static readonly long[] Value={ 0L,0L,2L,6L,18L,30L,50L,70L,98L,118L,162L,198L,226L,270L,338L,366L,426L,486L,554L,622L,682L,726L,842L,926L,986L,1062L,1202L,1270L,1362L,1470L,1562L,1678L,1802L,1878L,2066L,2158L,2250L,2390L,2602L,2694L,2818L,2974L,3114L,3278L,3434L,3526L,3786L,3966L,4090L,4254L,4490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197168Inst : IEnumerable<long>
{
public static readonly long[] Value=A197168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197168.Bytes);
public long this[int i]=>Value[i];

public static A197168Inst Instance=new A197168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197169
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,2L,2L,46L,2L,2L,2L,2L,3L,10L,6L,2L,3L,3L,2L,2L,2L,6L,5L,2L,2L,5L,2L,2L,2L,2L,2L,2L,22L,5L,2L,2L,3L,2L,2L,3L,2L,2L,3L,46L,5L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,14L,2L,4L,3L,2L,2L,2L,4L,14L,3L,2L,3L,2L,5L,2L,2L,2L,5L,2L,2L,2L,3L,6L,29L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197169Inst : IEnumerable<long>
{
public static readonly long[] Value=A197169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197169.Bytes);
public long this[int i]=>Value[i];

public static A197169Inst Instance=new A197169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197170
{
public static readonly long[] Value={ 6L,69L,248L,115L,78L,511L,1016L,603L,70L,385L,3432L,793L,238L,2655L,14224L,1241L,3186L,703L,3980L,9177L,154L,736L,456L,1825L,3172L,13959L,2884L,319L,1110L,4619L,7136L,10659L,7174L,10255L,44856L,7067L,2926L,16185L,54280L,779L,7602L,10879L,22088L,10215L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197170Inst : IEnumerable<long>
{
public static readonly long[] Value=A197170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197170.Bytes);
public long this[int i]=>Value[i];

public static A197170Inst Instance=new A197170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197171
{
public static readonly long[] Value={ 6L,14L,22L,30L,34L,38L,42L,54L,56L,62L,66L,86L,94L,102L,110L,118L,126L,132L,134L,138L,142L,146L,150L,156L,158L,166L,174L,178L,182L,186L,190L,194L,198L,206L,210L,214L,220L,222L,228L,230L,246L,254L,258L,262L,270L,278L,282L,286L,294L,302L,306L,310L,322L,326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197171Inst : IEnumerable<long>
{
public static readonly long[] Value=A197171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197171.Bytes);
public long this[int i]=>Value[i];

public static A197171Inst Instance=new A197171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197172
{
public static readonly long[] Value={ 69L,87L,93L,159L,177L,183L,249L,267L,276L,312L,321L,327L,348L,372L,387L,417L,471L,597L,633L,636L,699L,711L,717L,723L,741L,747L,831L,849L,879L,921L,927L,987L,993L,1005L,1068L,1104L,1137L,1179L,1248L,1251L,1272L,1293L,1299L,1317L,1320L,1353L,1359L,1383L,1392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197172Inst : IEnumerable<long>
{
public static readonly long[] Value=A197172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197172.Bytes);
public long this[int i]=>Value[i];

public static A197172Inst Instance=new A197172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197173
{
public static readonly BigInteger[] Value={ 1L,5L,41L,969L,92206L,22335117L,16686610707L,35396160304609L,218937410204781995L,BigInteger.Parse("3910004408912399352584") };
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
public class A197173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197173Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197173.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197173Inst Instance=new A197173Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197174
{
public static readonly long[] Value={ 1L,5L,10L,23L,58L,144L,363L,917L,2321L,5878L,14889L,37722L,95576L,242163L,613583L,1554685L,3939236L,9981179L,25290188L,64079982L,162365107L,411398825L,1042397613L,2641215094L,6692280455L,16956823380L,42965004446L,108864235075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197174Inst : IEnumerable<long>
{
public static readonly long[] Value=A197174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197174.Bytes);
public long this[int i]=>Value[i];

public static A197174Inst Instance=new A197174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197175
{
public static readonly long[] Value={ 2L,10L,41L,150L,665L,2695L,11424L,47528L,199485L,834267L,3494391L,14627589L,61246810L,256420026L,1073586408L,4494857066L,18819026026L,78791164317L,329881701180L,1381143529911L,5782550639425L,24210293846101L,101363286240212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197175Inst : IEnumerable<long>
{
public static readonly long[] Value=A197175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197175.Bytes);
public long this[int i]=>Value[i];

public static A197175Inst Instance=new A197175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197176
{
public static readonly long[] Value={ 3L,23L,150L,969L,7172L,50864L,367813L,2646379L,19073997L,137434440L,990411767L,7137038938L,51431455178L,370627617651L,2670838531897L,19246742767269L,138696965305604L,999485868248461L,7202551374117304L,51903431296093738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197176Inst : IEnumerable<long>
{
public static readonly long[] Value=A197176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197176.Bytes);
public long this[int i]=>Value[i];

public static A197176Inst Instance=new A197176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197177
{
public static readonly long[] Value={ 4L,58L,665L,7172L,92206L,1096217L,13530178L,164914460L,2020163498L,24703508188L,302309943629L,3698448129411L,45252432505040L,553659760056682L,6774120187730445L,82881818656461776L,1014068105098968313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197177Inst : IEnumerable<long>
{
public static readonly long[] Value=A197177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197177.Bytes);
public long this[int i]=>Value[i];

public static A197177Inst Instance=new A197177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197178
{
public static readonly BigInteger[] Value={ 6L,144L,2695L,50864L,1096217L,22335117L,467923636L,9715240362L,202416969329L,4212994659413L,87725436272795L,1826377617714231L,38026405009459764L,791717063144087158L,16483851476415953516UL,BigInteger.Parse("343198919447137443062") };
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
public class A197178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197178Inst Instance=new A197178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197179
{
public static readonly BigInteger[] Value={ 9L,363L,11424L,367813L,13530178L,467923636L,16686610707L,589208849137L,20885016359231L,739404634476424L,26190742594221192L,927538658235022906L,BigInteger.Parse("32851194231582718073"),BigInteger.Parse("1163477523647115256949"),BigInteger.Parse("41206887402652394051361") };
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
public class A197179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197179Inst Instance=new A197179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197180
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,3L,10L,10L,3L,4L,23L,41L,23L,4L,6L,58L,150L,150L,58L,6L,9L,144L,665L,969L,665L,144L,9L,13L,363L,2695L,7172L,7172L,2695L,363L,13L,19L,917L,11424L,50864L,92206L,50864L,11424L,917L,19L,28L,2321L,47528L,367813L,1096217L,1096217L,367813L,47528L,2321L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197180Inst : IEnumerable<long>
{
public static readonly long[] Value=A197180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197180.Bytes);
public long this[int i]=>Value[i];

public static A197180Inst Instance=new A197180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197181
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,16L,18L,24L,28L,36L,45L,48L,60L,64L,70L,72L,75L,80L,84L,90L,96L,98L,128L,144L,168L,175L,180L,189L,192L,256L,280L,288L,360L,378L,384L,448L,480L,486L,567L,576L,588L,640L,648L,672L,675L,720L,729L,756L,768L,784L,840L,864L,875L,882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197181Inst : IEnumerable<long>
{
public static readonly long[] Value=A197181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197181.Bytes);
public long this[int i]=>Value[i];

public static A197181Inst Instance=new A197181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197182
{
public static readonly long[] Value={ 1L,1L,3L,7L,18L,36L,82L,153L,300L,520L,915L,1477L,2437L,3801L,6027L,9095L,13824L,20194L,29734L,42254L,60348L,83730L,116565L,158215L,215375L,286691L,382461L,500451L,656130L,846385L,1094530L,1395787L,1784670L,2254093L,2853849L,3573051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197182Inst : IEnumerable<long>
{
public static readonly long[] Value=A197182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197182.Bytes);
public long this[int i]=>Value[i];

public static A197182Inst Instance=new A197182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197183
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197183Inst : IEnumerable<long>
{
public static readonly long[] Value=A197183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197183.Bytes);
public long this[int i]=>Value[i];

public static A197183Inst Instance=new A197183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197184
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,-1L,1L,7L,-2L,-1L,1L,-13L,12L,-3L,-1L,1L,-17L,-22L,18L,-4L,-1L,1L,199L,-45L,-35L,25L,-5L,-1L,1L,-605L,465L,-84L,-53L,33L,-6L,-1L,1L,-225L,-1449L,910L,-133L,-77L,42L,-7L,-1L,1L,11703L,-864L,-3094L,1594L,-190L,-108L,52L,-8L,-1L,1L,-59317L,33780L,-1380L,-6027L,2583L,-252L,-147L,63L,-9L,-1L,1L,83143L,-179398L,78567L,-771L,-10899L,3948L,-315L,-195L,75L,-10L,-1L,1L,991671L,271073L,-461978L,159115L,2882L,-18546L,5764L,-374L,-253L,88L,-11L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197184Inst : IEnumerable<long>
{
public static readonly long[] Value=A197184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197184.Bytes);
public long this[int i]=>Value[i];

public static A197184Inst Instance=new A197184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197185
{
public static readonly long[] Value={ 2L,59L,73L,97L,109L,113L,199L,283L,463L,467L,661L,1103L,1109L,1123L,1129L,1321L,1327L,1423L,2657L,2803L,2861L,3299L,5381L,5881L,6373L,6379L,9859L,9931L,9949L,10337L,10343L,11777L,19181L,19207L,19373L,24107L,24109L,24113L,24121L,24137L,42751L,42793L,42797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197185Inst : IEnumerable<long>
{
public static readonly long[] Value=A197185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197185.Bytes);
public long this[int i]=>Value[i];

public static A197185Inst Instance=new A197185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197186
{
public static readonly long[] Value={ 2L,17L,31L,41L,53L,101L,109L,127L,139L,179L,397L,419L,547L,787L,997L,1031L,1229L,1801L,1811L,2099L,2237L,2417L,2423L,2657L,3163L,3203L,3517L,3581L,3583L,3931L,4241L,5503L,5507L,5557L,6079L,8087L,8719L,10433L,10487L,13399L,13411L,19309L,22303L,22307L,22613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197186Inst : IEnumerable<long>
{
public static readonly long[] Value=A197186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197186.Bytes);
public long this[int i]=>Value[i];

public static A197186Inst Instance=new A197186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197187
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,29L,59L,67L,97L,103L,149L,151L,233L,251L,277L,311L,313L,479L,643L,719L,919L,967L,1039L,1373L,1489L,1553L,1847L,1973L,1979L,2663L,2953L,3323L,3677L,3691L,4651L,4663L,4789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197187Inst : IEnumerable<long>
{
public static readonly long[] Value=A197187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197187.Bytes);
public long this[int i]=>Value[i];

public static A197187Inst Instance=new A197187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197188
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,17L,31L,41L,43L,71L,89L,103L,109L,139L,173L,191L,197L,241L,281L,317L,443L,487L,569L,577L,701L,761L,797L,919L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197188Inst : IEnumerable<long>
{
public static readonly long[] Value=A197188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197188.Bytes);
public long this[int i]=>Value[i];

public static A197188Inst Instance=new A197188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197189
{
public static readonly long[] Value={ 1L,2L,11L,43L,184L,767L,3221L,13498L,56599L,237287L,994856L,4171003L,17487289L,73316882L,307387091L,1288745683L,5403172504L,22653245927L,94975600301L,398193030538L,1669457093119L,6999336432047L,29345294761736L,123032566445443L,515824173145009L,2162635351662242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197189Inst : IEnumerable<long>
{
public static readonly long[] Value=A197189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197189.Bytes);
public long this[int i]=>Value[i];

public static A197189Inst Instance=new A197189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197190
{
public static readonly BigInteger[] Value={ 2L,1L,3L,18L,47L,15127L,322L,599074578L,4870847L,192900153618L,228826127L,BigInteger.Parse("97418273275323406890123"),10749957122L,BigInteger.Parse("400010949097364802732720796316482"),358890350005878082L,BigInteger.Parse("11981655542024930675232002"),BigInteger.Parse("562882766124611619513723647"),BigInteger.Parse("699259133978938420550028971714417160188479526095241271647") };
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
public class A197190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197190Inst Instance=new A197190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197191
{
public static readonly BigInteger[] Value={ 1L,1L,6L,36L,2206L,150000L,13685760L,16794009904L,23538338288640L,40111742758242240L,BigInteger.Parse("678603619866009600000"),BigInteger.Parse("19289305175281390070751204"),BigInteger.Parse("619856418580365858926902640640"),BigInteger.Parse("208006459829483370218035382709089280"),BigInteger.Parse("78451383926677134672195807581733722937984") };
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
public class A197191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197191.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197191Inst Instance=new A197191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197192
{
public static readonly BigInteger[] Value={ 1L,70L,2695L,75460L,1716715L,33647614L,588833245L,9421331920L,140142312310L,1961992372340L,26094498552122L,332111799754280L,4068369546989930L,48194531556649940L,554237112901474310L,6207455664496512272L,BigInteger.Parse("67894046330430602975") };
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
public class A197192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197192Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197192.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197192Inst Instance=new A197192Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197193
{
public static readonly BigInteger[] Value={ 1L,77L,3234L,98098L,2403401L,50471421L,942133192L,16016264264L,252256162158L,3727785507446L,52188997104244L,697434779483988L,8950413003377846L,110847422580294862L,1330169070963538344L,15518639161241280680UL,BigInteger.Parse("176524520459119567735"),BigInteger.Parse("1962537315692564605995"),BigInteger.Parse("21369850770874592376390"),BigInteger.Parse("228319984551975908021430") };
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
public class A197193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197193Inst Instance=new A197193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197194
{
public static readonly BigInteger[] Value={ 1L,90L,4455L,160380L,4691115L,118216098L,2659862205L,54717165360L,1046465787510L,18836384175180L,322102169395578L,5270762771927640L,83014513657860330L,1264374900327411180L,BigInteger.Parse("18694686026269579590"),BigInteger.Parse("269203478778281946096"),BigInteger.Parse("3785673920319589866975"),BigInteger.Parse("52108688079693178168950"),BigInteger.Parse("703467289075857905280825") };
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
public class A197194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197194Inst Instance=new A197194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197195
{
public static readonly long[] Value={ 1L,5L,25L,314L,7363L,350711L,33176391L,6258308430L,2359068239358L,1774609159901861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197195Inst : IEnumerable<long>
{
public static readonly long[] Value=A197195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197195.Bytes);
public long this[int i]=>Value[i];

public static A197195Inst Instance=new A197195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197196
{
public static readonly long[] Value={ 6L,41L,213L,1283L,7363L,42664L,247053L,1431868L,8291425L,48020216L,278171097L,1611110131L,9331719493L,54050435220L,313063366107L,1813289742008L,10502730648812L,60832658109790L,352347783107193L,2040827608413023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197196Inst : IEnumerable<long>
{
public static readonly long[] Value=A197196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197196.Bytes);
public long this[int i]=>Value[i];

public static A197196Inst Instance=new A197196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197197
{
public static readonly long[] Value={ 9L,85L,621L,5311L,42664L,350711L,2873141L,23497244L,192348965L,1574634137L,12888915436L,105499317727L,863568784956L,7068699587730L,57860690577672L,473616132534126L,3876768069957732L,31733162865254064L,259750677790161795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197197Inst : IEnumerable<long>
{
public static readonly long[] Value=A197197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197197.Bytes);
public long this[int i]=>Value[i];

public static A197197Inst Instance=new A197197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197198
{
public static readonly long[] Value={ 13L,178L,1801L,21803L,247053L,2873141L,33176391L,383262156L,4432780869L,51234398070L,592247668688L,6846309893866L,79142347014020L,914861421385891L,10575600998801299L,122251698517890245L,1413202926345456663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197198Inst : IEnumerable<long>
{
public static readonly long[] Value=A197198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197198.Bytes);
public long this[int i]=>Value[i];

public static A197198Inst Instance=new A197198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197199
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,9L,9L,4L,6L,20L,25L,20L,6L,9L,41L,75L,75L,41L,9L,13L,85L,213L,314L,213L,85L,13L,19L,178L,621L,1283L,1283L,621L,178L,19L,28L,369L,1801L,5311L,7363L,5311L,1801L,369L,28L,41L,769L,5219L,21803L,42664L,42664L,21803L,5219L,769L,41L,60L,1600L,15133L,89640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197199Inst : IEnumerable<long>
{
public static readonly long[] Value=A197199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197199.Bytes);
public long this[int i]=>Value[i];

public static A197199Inst Instance=new A197199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197200
{
public static readonly long[] Value={ 1L,5L,100L,7073L,1890344L,1989885480L,7876891407951L,117490890045317733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197200Inst : IEnumerable<long>
{
public static readonly long[] Value=A197200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197200.Bytes);
public long this[int i]=>Value[i];

public static A197200Inst Instance=new A197200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197201
{
public static readonly long[] Value={ 1L,5L,16L,47L,154L,496L,1601L,5183L,16777L,54298L,175777L,569008L,1841952L,5962675L,19302067L,62483633L,202268864L,654774451L,2119602518L,6861469468L,22211599969L,71902261547L,232758343993L,753473472226L,2439106000077L,7895749882524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197201Inst : IEnumerable<long>
{
public static readonly long[] Value=A197201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197201.Bytes);
public long this[int i]=>Value[i];

public static A197201Inst Instance=new A197201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197202
{
public static readonly long[] Value={ 2L,16L,100L,588L,3649L,22210L,135560L,827698L,5055418L,30875671L,188551113L,1151456304L,7031841993L,42943005672L,262250032226L,1601541435978L,9780493464535L,59728749093644L,364759066990417L,2227556706954487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197202Inst : IEnumerable<long>
{
public static readonly long[] Value=A197202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197202.Bytes);
public long this[int i]=>Value[i];

public static A197202Inst Instance=new A197202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197203
{
public static readonly long[] Value={ 3L,47L,588L,7073L,82408L,977946L,11746093L,140398339L,1673987573L,19978425920L,238603437585L,2848944091708L,34010711969738L,406045052968057L,4847874016932633L,57879103635687885L,691015526016683752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197203Inst : IEnumerable<long>
{
public static readonly long[] Value=A197203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197203.Bytes);
public long this[int i]=>Value[i];

public static A197203Inst Instance=new A197203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197204
{
public static readonly BigInteger[] Value={ 4L,154L,3649L,82408L,1890344L,44049565L,1024514869L,23694062554L,549372026526L,12743513094468L,295451821724325L,6849613829231115L,158818786337504605L,3682398510410799861L,BigInteger.Parse("85378510136323889541"),BigInteger.Parse("1979565632837619218162") };
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
public class A197204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197204Inst Instance=new A197204Inst();

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