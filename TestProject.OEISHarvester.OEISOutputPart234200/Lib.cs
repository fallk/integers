using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011537
{
public static readonly long[] Value={ 7L,17L,27L,37L,47L,57L,67L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,87L,97L,107L,117L,127L,137L,147L,157L,167L,170L,171L,172L,173L,174L,175L,176L,177L,178L,179L,187L,197L,207L,217L,227L,237L,247L,257L,267L,270L,271L,272L,273L,274L,275L,276L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011537Inst : IEnumerable<long>
{
public static readonly long[] Value=A011537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011537.Bytes);
public long this[int i]=>Value[i];

public static A011537Inst Instance=new A011537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011538
{
public static readonly long[] Value={ 8L,18L,28L,38L,48L,58L,68L,78L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,98L,108L,118L,128L,138L,148L,158L,168L,178L,180L,181L,182L,183L,184L,185L,186L,187L,188L,189L,198L,208L,218L,228L,238L,248L,258L,268L,278L,280L,281L,282L,283L,284L,285L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011538Inst : IEnumerable<long>
{
public static readonly long[] Value=A011538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011538.Bytes);
public long this[int i]=>Value[i];

public static A011538Inst Instance=new A011538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011539
{
public static readonly long[] Value={ 9L,19L,29L,39L,49L,59L,69L,79L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,109L,119L,129L,139L,149L,159L,169L,179L,189L,190L,191L,192L,193L,194L,195L,196L,197L,198L,199L,209L,219L,229L,239L,249L,259L,269L,279L,289L,290L,291L,292L,293L,294L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011539Inst : IEnumerable<long>
{
public static readonly long[] Value=A011539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011539.Bytes);
public long this[int i]=>Value[i];

public static A011539Inst Instance=new A011539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011540
{
public static readonly long[] Value={ 0L,10L,20L,30L,40L,50L,60L,70L,80L,90L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,120L,130L,140L,150L,160L,170L,180L,190L,200L,201L,202L,203L,204L,205L,206L,207L,208L,209L,210L,220L,230L,240L,250L,260L,270L,280L,290L,300L,301L,302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011540Inst : IEnumerable<long>
{
public static readonly long[] Value=A011540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011540.Bytes);
public long this[int i]=>Value[i];

public static A011540Inst Instance=new A011540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011541
{
public static readonly BigInteger[] Value={ 2L,1729L,87539319L,6963472309248L,48988659276962496L,BigInteger.Parse("24153319581254312065344") };
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
public class A011541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011541Inst Instance=new A011541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011542
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011542Inst : IEnumerable<long>
{
public static readonly long[] Value=A011542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011542.Bytes);
public long this[int i]=>Value[i];

public static A011542Inst Instance=new A011542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011543
{
public static readonly BigInteger[] Value={ 2L,27L,271L,2718L,27182L,271828L,2718281L,27182818L,271828182L,2718281828L,27182818284L,271828182845L,2718281828459L,27182818284590L,271828182845904L,2718281828459045L,27182818284590452L,271828182845904523L,2718281828459045235L,BigInteger.Parse("27182818284590452353"),BigInteger.Parse("271828182845904523536") };
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
public class A011543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011543Inst Instance=new A011543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011544
{
public static readonly long[] Value={ 3L,27L,272L,2718L,27183L,271828L,2718282L,27182818L,271828183L,2718281828L,27182818285L,271828182846L,2718281828459L,27182818284590L,271828182845905L,2718281828459045L,27182818284590452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011544Inst : IEnumerable<long>
{
public static readonly long[] Value=A011544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011544.Bytes);
public long this[int i]=>Value[i];

public static A011544Inst Instance=new A011544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011545
{
public static readonly long[] Value={ 3L,31L,314L,3141L,31415L,314159L,3141592L,31415926L,314159265L,3141592653L,31415926535L,314159265358L,3141592653589L,31415926535897L,314159265358979L,3141592653589793L,31415926535897932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011545Inst : IEnumerable<long>
{
public static readonly long[] Value=A011545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011545.Bytes);
public long this[int i]=>Value[i];

public static A011545Inst Instance=new A011545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011546
{
public static readonly BigInteger[] Value={ 3L,31L,314L,3142L,31416L,314159L,3141593L,31415927L,314159265L,3141592654L,31415926536L,314159265359L,3141592653590L,31415926535898L,314159265358979L,3141592653589793L,31415926535897932L,314159265358979324L,3141592653589793238L,BigInteger.Parse("31415926535897932385") };
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
public class A011546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011546Inst Instance=new A011546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011547
{
public static readonly long[] Value={ 1L,14L,141L,1414L,14142L,141421L,1414213L,14142135L,141421356L,1414213562L,14142135623L,141421356237L,1414213562373L,14142135623730L,141421356237309L,1414213562373095L,14142135623730950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011547Inst : IEnumerable<long>
{
public static readonly long[] Value=A011547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011547.Bytes);
public long this[int i]=>Value[i];

public static A011547Inst Instance=new A011547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011548
{
public static readonly long[] Value={ 1L,14L,141L,1414L,14142L,141421L,1414214L,14142136L,141421356L,1414213562L,14142135624L,141421356237L,1414213562373L,14142135623731L,141421356237310L,1414213562373095L,14142135623730950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011548Inst : IEnumerable<long>
{
public static readonly long[] Value=A011548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011548.Bytes);
public long this[int i]=>Value[i];

public static A011548Inst Instance=new A011548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011549
{
public static readonly long[] Value={ 1L,17L,173L,1732L,17320L,173205L,1732050L,17320508L,173205080L,1732050807L,17320508075L,173205080756L,1732050807568L,17320508075688L,173205080756887L,1732050807568877L,17320508075688772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011549Inst : IEnumerable<long>
{
public static readonly long[] Value=A011549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011549.Bytes);
public long this[int i]=>Value[i];

public static A011549Inst Instance=new A011549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011614
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011614Inst : IEnumerable<long>
{
public static readonly long[] Value=A011614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011614.Bytes);
public long this[int i]=>Value[i];

public static A011614Inst Instance=new A011614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011615
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011615Inst : IEnumerable<long>
{
public static readonly long[] Value=A011615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011615.Bytes);
public long this[int i]=>Value[i];

public static A011615Inst Instance=new A011615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011616
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011616Inst : IEnumerable<long>
{
public static readonly long[] Value=A011616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011616.Bytes);
public long this[int i]=>Value[i];

public static A011616Inst Instance=new A011616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011617
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011617Inst : IEnumerable<long>
{
public static readonly long[] Value=A011617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011617.Bytes);
public long this[int i]=>Value[i];

public static A011617Inst Instance=new A011617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011618
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011618Inst : IEnumerable<long>
{
public static readonly long[] Value=A011618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011618.Bytes);
public long this[int i]=>Value[i];

public static A011618Inst Instance=new A011618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011619
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011619Inst : IEnumerable<long>
{
public static readonly long[] Value=A011619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011619.Bytes);
public long this[int i]=>Value[i];

public static A011619Inst Instance=new A011619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011620
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011620Inst : IEnumerable<long>
{
public static readonly long[] Value=A011620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011620.Bytes);
public long this[int i]=>Value[i];

public static A011620Inst Instance=new A011620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011621
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011621Inst : IEnumerable<long>
{
public static readonly long[] Value=A011621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011621.Bytes);
public long this[int i]=>Value[i];

public static A011621Inst Instance=new A011621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011622
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011622Inst : IEnumerable<long>
{
public static readonly long[] Value=A011622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011622.Bytes);
public long this[int i]=>Value[i];

public static A011622Inst Instance=new A011622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011623
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011623Inst : IEnumerable<long>
{
public static readonly long[] Value=A011623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011623.Bytes);
public long this[int i]=>Value[i];

public static A011623Inst Instance=new A011623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011624
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011624Inst : IEnumerable<long>
{
public static readonly long[] Value=A011624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011624.Bytes);
public long this[int i]=>Value[i];

public static A011624Inst Instance=new A011624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011625
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011625Inst : IEnumerable<long>
{
public static readonly long[] Value=A011625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011625.Bytes);
public long this[int i]=>Value[i];

public static A011625Inst Instance=new A011625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011626
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011626Inst : IEnumerable<long>
{
public static readonly long[] Value=A011626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011626.Bytes);
public long this[int i]=>Value[i];

public static A011626Inst Instance=new A011626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011627
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011627Inst : IEnumerable<long>
{
public static readonly long[] Value=A011627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011627.Bytes);
public long this[int i]=>Value[i];

public static A011627Inst Instance=new A011627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011628
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011628Inst : IEnumerable<long>
{
public static readonly long[] Value=A011628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011628.Bytes);
public long this[int i]=>Value[i];

public static A011628Inst Instance=new A011628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011629
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011629Inst : IEnumerable<long>
{
public static readonly long[] Value=A011629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011629.Bytes);
public long this[int i]=>Value[i];

public static A011629Inst Instance=new A011629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011630
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011630Inst : IEnumerable<long>
{
public static readonly long[] Value=A011630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011630.Bytes);
public long this[int i]=>Value[i];

public static A011630Inst Instance=new A011630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011631
{
public static readonly long[] Value={ 0L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011631Inst : IEnumerable<long>
{
public static readonly long[] Value=A011631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011631.Bytes);
public long this[int i]=>Value[i];

public static A011631Inst Instance=new A011631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011632
{
public static readonly long[] Value={ 1L,0L,-1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011632Inst : IEnumerable<long>
{
public static readonly long[] Value=A011632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011632.Bytes);
public long this[int i]=>Value[i];

public static A011632Inst Instance=new A011632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011633
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011633Inst : IEnumerable<long>
{
public static readonly long[] Value=A011633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011633.Bytes);
public long this[int i]=>Value[i];

public static A011633Inst Instance=new A011633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011634
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011634Inst : IEnumerable<long>
{
public static readonly long[] Value=A011634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011634.Bytes);
public long this[int i]=>Value[i];

public static A011634Inst Instance=new A011634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011635
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,0L,1L,0L,-1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011635Inst : IEnumerable<long>
{
public static readonly long[] Value=A011635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011635.Bytes);
public long this[int i]=>Value[i];

public static A011635Inst Instance=new A011635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011636
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011636Inst : IEnumerable<long>
{
public static readonly long[] Value=A011636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011636.Bytes);
public long this[int i]=>Value[i];

public static A011636Inst Instance=new A011636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011637
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011637Inst : IEnumerable<long>
{
public static readonly long[] Value=A011637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011637.Bytes);
public long this[int i]=>Value[i];

public static A011637Inst Instance=new A011637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011638
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011638Inst : IEnumerable<long>
{
public static readonly long[] Value=A011638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011638.Bytes);
public long this[int i]=>Value[i];

public static A011638Inst Instance=new A011638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011639
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011639Inst : IEnumerable<long>
{
public static readonly long[] Value=A011639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011639.Bytes);
public long this[int i]=>Value[i];

public static A011639Inst Instance=new A011639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011640
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011640Inst : IEnumerable<long>
{
public static readonly long[] Value=A011640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011640.Bytes);
public long this[int i]=>Value[i];

public static A011640Inst Instance=new A011640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011641
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,-1L,-1L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,-1L,-1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011641Inst : IEnumerable<long>
{
public static readonly long[] Value=A011641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011641.Bytes);
public long this[int i]=>Value[i];

public static A011641Inst Instance=new A011641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011642
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,-1L,0L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L,-1L,0L,1L,0L,-1L,0L,1L,0L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011642Inst : IEnumerable<long>
{
public static readonly long[] Value=A011642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011642.Bytes);
public long this[int i]=>Value[i];

public static A011642Inst Instance=new A011642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011643
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011643Inst : IEnumerable<long>
{
public static readonly long[] Value=A011643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011643.Bytes);
public long this[int i]=>Value[i];

public static A011643Inst Instance=new A011643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011644
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,0L,0L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,0L,1L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011644Inst : IEnumerable<long>
{
public static readonly long[] Value=A011644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011644.Bytes);
public long this[int i]=>Value[i];

public static A011644Inst Instance=new A011644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011645
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011645Inst : IEnumerable<long>
{
public static readonly long[] Value=A011645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011645.Bytes);
public long this[int i]=>Value[i];

public static A011645Inst Instance=new A011645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011678
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011678Inst : IEnumerable<long>
{
public static readonly long[] Value=A011678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011678.Bytes);
public long this[int i]=>Value[i];

public static A011678Inst Instance=new A011678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011679
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011679Inst : IEnumerable<long>
{
public static readonly long[] Value=A011679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011679.Bytes);
public long this[int i]=>Value[i];

public static A011679Inst Instance=new A011679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011680
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011680Inst : IEnumerable<long>
{
public static readonly long[] Value=A011680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011680.Bytes);
public long this[int i]=>Value[i];

public static A011680Inst Instance=new A011680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011681
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011681Inst : IEnumerable<long>
{
public static readonly long[] Value=A011681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011681.Bytes);
public long this[int i]=>Value[i];

public static A011681Inst Instance=new A011681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011682
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011682Inst : IEnumerable<long>
{
public static readonly long[] Value=A011682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011682.Bytes);
public long this[int i]=>Value[i];

public static A011682Inst Instance=new A011682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011683
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011683Inst : IEnumerable<long>
{
public static readonly long[] Value=A011683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011683.Bytes);
public long this[int i]=>Value[i];

public static A011683Inst Instance=new A011683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011684
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011684Inst : IEnumerable<long>
{
public static readonly long[] Value=A011684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011684.Bytes);
public long this[int i]=>Value[i];

public static A011684Inst Instance=new A011684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011685
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011685Inst : IEnumerable<long>
{
public static readonly long[] Value=A011685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011685.Bytes);
public long this[int i]=>Value[i];

public static A011685Inst Instance=new A011685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011686
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011686Inst : IEnumerable<long>
{
public static readonly long[] Value=A011686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011686.Bytes);
public long this[int i]=>Value[i];

public static A011686Inst Instance=new A011686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011687
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011687Inst : IEnumerable<long>
{
public static readonly long[] Value=A011687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011687.Bytes);
public long this[int i]=>Value[i];

public static A011687Inst Instance=new A011687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011688
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011688Inst : IEnumerable<long>
{
public static readonly long[] Value=A011688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011688.Bytes);
public long this[int i]=>Value[i];

public static A011688Inst Instance=new A011688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011689
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011689Inst : IEnumerable<long>
{
public static readonly long[] Value=A011689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011689.Bytes);
public long this[int i]=>Value[i];

public static A011689Inst Instance=new A011689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011690
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011690Inst : IEnumerable<long>
{
public static readonly long[] Value=A011690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011690.Bytes);
public long this[int i]=>Value[i];

public static A011690Inst Instance=new A011690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011691
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011691Inst : IEnumerable<long>
{
public static readonly long[] Value=A011691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011691.Bytes);
public long this[int i]=>Value[i];

public static A011691Inst Instance=new A011691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011692
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011692Inst : IEnumerable<long>
{
public static readonly long[] Value=A011692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011692.Bytes);
public long this[int i]=>Value[i];

public static A011692Inst Instance=new A011692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011693
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011693Inst : IEnumerable<long>
{
public static readonly long[] Value=A011693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011693.Bytes);
public long this[int i]=>Value[i];

public static A011693Inst Instance=new A011693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011710
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011710Inst : IEnumerable<long>
{
public static readonly long[] Value=A011710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011710.Bytes);
public long this[int i]=>Value[i];

public static A011710Inst Instance=new A011710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011711
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011711Inst : IEnumerable<long>
{
public static readonly long[] Value=A011711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011711.Bytes);
public long this[int i]=>Value[i];

public static A011711Inst Instance=new A011711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011712
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011712Inst : IEnumerable<long>
{
public static readonly long[] Value=A011712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011712.Bytes);
public long this[int i]=>Value[i];

public static A011712Inst Instance=new A011712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011713
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011713Inst : IEnumerable<long>
{
public static readonly long[] Value=A011713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011713.Bytes);
public long this[int i]=>Value[i];

public static A011713Inst Instance=new A011713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011714
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011714Inst : IEnumerable<long>
{
public static readonly long[] Value=A011714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011714.Bytes);
public long this[int i]=>Value[i];

public static A011714Inst Instance=new A011714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011715
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011715Inst : IEnumerable<long>
{
public static readonly long[] Value=A011715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011715.Bytes);
public long this[int i]=>Value[i];

public static A011715Inst Instance=new A011715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011716
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011716Inst : IEnumerable<long>
{
public static readonly long[] Value=A011716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011716.Bytes);
public long this[int i]=>Value[i];

public static A011716Inst Instance=new A011716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011717
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011717Inst : IEnumerable<long>
{
public static readonly long[] Value=A011717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011717.Bytes);
public long this[int i]=>Value[i];

public static A011717Inst Instance=new A011717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011718
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011718Inst : IEnumerable<long>
{
public static readonly long[] Value=A011718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011718.Bytes);
public long this[int i]=>Value[i];

public static A011718Inst Instance=new A011718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011719
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011719Inst : IEnumerable<long>
{
public static readonly long[] Value=A011719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011719.Bytes);
public long this[int i]=>Value[i];

public static A011719Inst Instance=new A011719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011720
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011720Inst : IEnumerable<long>
{
public static readonly long[] Value=A011720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011720.Bytes);
public long this[int i]=>Value[i];

public static A011720Inst Instance=new A011720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011721
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011721Inst : IEnumerable<long>
{
public static readonly long[] Value=A011721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011721.Bytes);
public long this[int i]=>Value[i];

public static A011721Inst Instance=new A011721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011722
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011722Inst : IEnumerable<long>
{
public static readonly long[] Value=A011722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011722.Bytes);
public long this[int i]=>Value[i];

public static A011722Inst Instance=new A011722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011723
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011723Inst : IEnumerable<long>
{
public static readonly long[] Value=A011723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011723.Bytes);
public long this[int i]=>Value[i];

public static A011723Inst Instance=new A011723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011724
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011724Inst : IEnumerable<long>
{
public static readonly long[] Value=A011724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011724.Bytes);
public long this[int i]=>Value[i];

public static A011724Inst Instance=new A011724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011725
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011725Inst : IEnumerable<long>
{
public static readonly long[] Value=A011725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011725.Bytes);
public long this[int i]=>Value[i];

public static A011725Inst Instance=new A011725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011742
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011742Inst : IEnumerable<long>
{
public static readonly long[] Value=A011742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011742.Bytes);
public long this[int i]=>Value[i];

public static A011742Inst Instance=new A011742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011743
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011743Inst : IEnumerable<long>
{
public static readonly long[] Value=A011743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011743.Bytes);
public long this[int i]=>Value[i];

public static A011743Inst Instance=new A011743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011744
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011744Inst : IEnumerable<long>
{
public static readonly long[] Value=A011744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011744.Bytes);
public long this[int i]=>Value[i];

public static A011744Inst Instance=new A011744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011745
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011745Inst : IEnumerable<long>
{
public static readonly long[] Value=A011745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011745.Bytes);
public long this[int i]=>Value[i];

public static A011745Inst Instance=new A011745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011746
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011746Inst : IEnumerable<long>
{
public static readonly long[] Value=A011746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011746.Bytes);
public long this[int i]=>Value[i];

public static A011746Inst Instance=new A011746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011747
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011747Inst : IEnumerable<long>
{
public static readonly long[] Value=A011747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011747.Bytes);
public long this[int i]=>Value[i];

public static A011747Inst Instance=new A011747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011748
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011748Inst : IEnumerable<long>
{
public static readonly long[] Value=A011748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011748.Bytes);
public long this[int i]=>Value[i];

public static A011748Inst Instance=new A011748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011749
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011749Inst : IEnumerable<long>
{
public static readonly long[] Value=A011749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011749.Bytes);
public long this[int i]=>Value[i];

public static A011749Inst Instance=new A011749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011750
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011750Inst : IEnumerable<long>
{
public static readonly long[] Value=A011750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011750.Bytes);
public long this[int i]=>Value[i];

public static A011750Inst Instance=new A011750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011751
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011751Inst : IEnumerable<long>
{
public static readonly long[] Value=A011751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011751.Bytes);
public long this[int i]=>Value[i];

public static A011751Inst Instance=new A011751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011752
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011752Inst : IEnumerable<long>
{
public static readonly long[] Value=A011752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011752.Bytes);
public long this[int i]=>Value[i];

public static A011752Inst Instance=new A011752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011753
{
public static readonly BigInteger[] Value={ 11L,20L,30L,420L,5460L,60060L,746130L,80059980L,900029130L,10407767370L,1100869379610L,12026713528830L,1300912477633230L,14299762385778870L,1502172599891453490L,BigInteger.Parse("160000041334479776430"),BigInteger.Parse("17000158733027932351890") };
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
public class A011753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011753.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011753Inst Instance=new A011753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011754
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,6L,6L,5L,6L,8L,9L,13L,10L,11L,14L,15L,11L,14L,14L,17L,17L,20L,19L,22L,16L,18L,24L,30L,25L,25L,25L,26L,26L,34L,29L,32L,27L,34L,36L,32L,28L,39L,38L,39L,34L,34L,45L,38L,41L,33L,41L,46L,42L,35L,39L,42L,39L,40L,42L,48L,56L,56L,49L,57L,56L,51L,45L,47L,55L,55L,64L,68L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011754Inst : IEnumerable<long>
{
public static readonly long[] Value=A011754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011754.Bytes);
public long this[int i]=>Value[i];

public static A011754Inst Instance=new A011754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011755
{
public static readonly long[] Value={ 1L,3L,9L,17L,37L,49L,91L,123L,177L,217L,327L,375L,531L,615L,735L,863L,1135L,1243L,1585L,1745L,1997L,2217L,2723L,2915L,3415L,3727L,4213L,4549L,5361L,5601L,6531L,7043L,7703L,8247L,9087L,9519L,10851L,11535L,12471L,13111L,14751L,15255L,17061L,17941L,19021L,20033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011755Inst : IEnumerable<long>
{
public static readonly long[] Value=A011755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011755.Bytes);
public long this[int i]=>Value[i];

public static A011755Inst Instance=new A011755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011756
{
public static readonly long[] Value={ 2L,5L,13L,29L,47L,73L,107L,151L,197L,257L,317L,397L,467L,571L,659L,769L,883L,1019L,1151L,1291L,1453L,1607L,1783L,1987L,2153L,2371L,2593L,2791L,3037L,3307L,3541L,3797L,4073L,4357L,4657L,4973L,5303L,5641L,5939L,6301L,6679L,7019L,7477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011756Inst : IEnumerable<long>
{
public static readonly long[] Value=A011756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011756.Bytes);
public long this[int i]=>Value[i];

public static A011756Inst Instance=new A011756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011757
{
public static readonly long[] Value={ 2L,7L,23L,53L,97L,151L,227L,311L,419L,541L,661L,827L,1009L,1193L,1427L,1619L,1879L,2143L,2437L,2741L,3083L,3461L,3803L,4211L,4637L,5051L,5519L,6007L,6481L,6997L,7573L,8161L,8737L,9341L,9931L,10627L,11321L,12049L,12743L,13499L,14327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011757Inst : IEnumerable<long>
{
public static readonly long[] Value=A011757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011757.Bytes);
public long this[int i]=>Value[i];

public static A011757Inst Instance=new A011757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011774
{
public static readonly long[] Value={ 1L,312L,560L,588L,1400L,23760L,59400L,85632L,147492L,153720L,556160L,569328L,1590816L,2013216L,3343776L,4563000L,4695456L,9745728L,12558912L,22013952L,23336172L,30002960L,45326160L,52021242L,75007400L,113315400L,137617728L,153587720L,402831360L,699117024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011774Inst : IEnumerable<long>
{
public static readonly long[] Value=A011774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011774.Bytes);
public long this[int i]=>Value[i];

public static A011774Inst Instance=new A011774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011775
{
public static readonly long[] Value={ 1L,6L,18L,24L,28L,40L,54L,72L,84L,96L,117L,120L,135L,162L,196L,200L,216L,224L,234L,252L,270L,288L,360L,384L,468L,486L,496L,540L,588L,600L,640L,648L,672L,756L,775L,819L,864L,891L,936L,1000L,1080L,1152L,1350L,1372L,1458L,1488L,1521L,1536L,1550L,1568L,1638L,1701L,1764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011775Inst : IEnumerable<long>
{
public static readonly long[] Value=A011775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011775.Bytes);
public long this[int i]=>Value[i];

public static A011775Inst Instance=new A011775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011776
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,1L,5L,1L,2L,3L,3L,1L,4L,1L,4L,3L,2L,1L,7L,3L,2L,4L,4L,1L,7L,1L,6L,3L,2L,5L,8L,1L,2L,3L,9L,1L,6L,1L,4L,10L,2L,1L,11L,4L,6L,3L,4L,1L,8L,5L,9L,3L,2L,1L,14L,1L,2L,10L,10L,5L,6L,1L,4L,3L,11L,1L,17L,1L,2L,9L,4L,7L,6L,1L,19L,10L,2L,1L,13L,5L,2L,3L,8L,1L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011776Inst : IEnumerable<long>
{
public static readonly long[] Value=A011776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011776.Bytes);
public long this[int i]=>Value[i];

public static A011776Inst Instance=new A011776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011777
{
public static readonly long[] Value={ 2L,6L,15L,18L,12L,32L,24L,36L,40L,45L,48L,100L,84L,60L,154L,165L,72L,96L,80L,126L,90L,135L,286L,200L,312L,264L,168L,120L,297L,189L,160L,330L,544L,210L,144L,224L,300L,385L,396L,324L,252L,680L,350L,180L,280L,748L,572L,486L,400L,405L,315L,528L,320L,336L,450L,512L,288L,240L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011777Inst : IEnumerable<long>
{
public static readonly long[] Value=A011777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011777.Bytes);
public long this[int i]=>Value[i];

public static A011777Inst Instance=new A011777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011778
{
public static readonly long[] Value={ 2L,6L,12L,24L,36L,40L,45L,48L,60L,72L,80L,90L,120L,144L,180L,240L,360L,480L,630L,672L,720L,1080L,1120L,1260L,1344L,1440L,1890L,2016L,2160L,2240L,2520L,2880L,3024L,3360L,3780L,4032L,4320L,5040L,6048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011778Inst : IEnumerable<long>
{
public static readonly long[] Value=A011778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011778.Bytes);
public long this[int i]=>Value[i];

public static A011778Inst Instance=new A011778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011779
{
public static readonly long[] Value={ 1L,3L,6L,12L,21L,33L,51L,75L,105L,145L,195L,255L,330L,420L,525L,651L,798L,966L,1162L,1386L,1638L,1926L,2250L,2610L,3015L,3465L,3960L,4510L,5115L,5775L,6501L,7293L,8151L,9087L,10101L,11193L,12376L,13650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011779Inst : IEnumerable<long>
{
public static readonly long[] Value=A011779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011779.Bytes);
public long this[int i]=>Value[i];

public static A011779Inst Instance=new A011779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011780
{
public static readonly long[] Value={ 1L,6L,26L,92L,291L,850L,2348L,6216L,15925L,39742L,97086L,233012L,550983L,1286442L,2970960L,6796320L,15417945L,34719510L,77672290L,172743180L,382147691L,841346306L,1844250996L,4026531832L,8758949501L,18989322990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011780Inst : IEnumerable<long>
{
public static readonly long[] Value=A011780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011780.Bytes);
public long this[int i]=>Value[i];

public static A011780Inst Instance=new A011780Inst();

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