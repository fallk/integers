using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A106541
{
public static readonly long[] Value={ 2L,2L,-2L,-12L,-22L,-10L,56L,174L,222L,-92L,-1038L,-2210L,-1624L,4102L,16006L,24260L,954L,-86426L,-215528L,-212546L,267150L,1433124L,2538530L,984270L,-6873592L,-20465066L,-25058698L,13402052L,124569514L,256580886L,173699192L,-512667826L,-1893337666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106541Inst : IEnumerable<long>
{
public static readonly long[] Value=A106541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106541.Bytes);
public long this[int i]=>Value[i];

public static A106541Inst Instance=new A106541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106542
{
public static readonly long[] Value={ 3L,3L,-3L,-18L,-33L,-15L,84L,261L,333L,-138L,-1557L,-3315L,-2436L,6153L,24009L,36390L,1431L,-129639L,-323292L,-318819L,400725L,2149686L,3807795L,1476405L,-10310388L,-30697599L,-37588047L,20103078L,186854271L,384871329L,260548788L,-769001739L,-2840006499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106542Inst : IEnumerable<long>
{
public static readonly long[] Value=A106542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106542.Bytes);
public long this[int i]=>Value[i];

public static A106542Inst Instance=new A106542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106543
{
public static readonly long[] Value={ 6L,10L,12L,14L,15L,18L,20L,21L,22L,24L,26L,28L,30L,33L,34L,35L,38L,39L,40L,42L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,102L,104L,105L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106543Inst : IEnumerable<long>
{
public static readonly long[] Value=A106543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106543.Bytes);
public long this[int i]=>Value[i];

public static A106543Inst Instance=new A106543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106544
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,121L,0L,0L,0L,0L,0L,289L,0L,0L,0L,0L,0L,529L,0L,625L,0L,0L,0L,0L,0L,961L,0L,0L,0L,0L,0L,0L,0L,1521L,0L,1681L,0L,0L,0L,2025L,0L,0L,0L,0L,0L,2601L,0L,2809L,0L,0L,0L,3249L,0L,3481L,0L,0L,0L,0L,0L,4225L,0L,4489L,0L,0L,0L,0L,0L,5329L,0L,0L,0L,0L,0L,6241L,0L,6561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106544Inst : IEnumerable<long>
{
public static readonly long[] Value=A106544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106544.Bytes);
public long this[int i]=>Value[i];

public static A106544Inst Instance=new A106544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106545
{
public static readonly long[] Value={ 0L,4L,9L,16L,25L,36L,49L,64L,81L,100L,0L,144L,169L,196L,225L,256L,0L,324L,361L,400L,441L,484L,0L,576L,0L,676L,729L,784L,841L,900L,0L,1024L,1089L,1156L,1225L,1296L,1369L,1444L,0L,1600L,0L,1764L,1849L,1936L,0L,2116L,2209L,2304L,2401L,2500L,0L,2704L,0L,2916L,3025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106545Inst : IEnumerable<long>
{
public static readonly long[] Value=A106545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106545.Bytes);
public long this[int i]=>Value[i];

public static A106545Inst Instance=new A106545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106546
{
public static readonly long[] Value={ 1L,4L,9L,16L,0L,36L,0L,64L,81L,100L,0L,144L,0L,196L,225L,256L,0L,324L,0L,400L,441L,484L,0L,576L,0L,676L,0L,784L,0L,900L,0L,1024L,1089L,1156L,0L,1296L,0L,1444L,1521L,1600L,0L,1764L,0L,1936L,2025L,2116L,0L,2304L,0L,2500L,0L,2704L,0L,2916L,0L,3136L,3249L,3364L,0L,3600L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106546Inst : IEnumerable<long>
{
public static readonly long[] Value=A106546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106546.Bytes);
public long this[int i]=>Value[i];

public static A106546Inst Instance=new A106546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106547
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,121L,0L,0L,0L,0L,0L,289L,0L,0L,0L,0L,0L,529L,0L,625L,0L,0L,0L,0L,0L,961L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1681L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2601L,0L,2809L,0L,0L,0L,0L,0L,3481L,0L,0L,0L,0L,0L,4225L,0L,4489L,0L,0L,0L,0L,0L,5329L,0L,0L,0L,0L,0L,6241L,0L,0L,0L,6889L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106547Inst : IEnumerable<long>
{
public static readonly long[] Value=A106547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106547.Bytes);
public long this[int i]=>Value[i];

public static A106547Inst Instance=new A106547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106548
{
public static readonly long[] Value={ 0L,4L,9L,16L,0L,36L,0L,64L,81L,100L,0L,144L,0L,196L,225L,256L,0L,324L,0L,400L,441L,484L,0L,576L,0L,676L,0L,784L,0L,900L,0L,1024L,1089L,1156L,0L,1296L,0L,1444L,0L,1600L,0L,1764L,0L,1936L,0L,2116L,0L,2304L,0L,2500L,0L,2704L,0L,2916L,0L,3136L,0L,3364L,0L,3600L,0L,3844L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106548Inst : IEnumerable<long>
{
public static readonly long[] Value=A106548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106548.Bytes);
public long this[int i]=>Value[i];

public static A106548Inst Instance=new A106548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106549
{
public static readonly long[] Value={ 0L,-1L,-1L,-1L,1L,-1L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,-1L,-1L,0L,0L,-1L,0L,-1L,-1L,0L,-1L,1L,0L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,0L,-1L,-1L,0L,0L,-1L,0L,-1L,0L,0L,-1L,0L,0L,0L,-1L,0L,-1L,-1L,0L,-1L,-1L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,-1L,0L,0L,-1L,-1L,0L,0L,0L,0L,-1L,-1L,0L,0L,-1L,0L,0L,-1L,0L,-1L,1L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106549Inst : IEnumerable<long>
{
public static readonly long[] Value=A106549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106549.Bytes);
public long this[int i]=>Value[i];

public static A106549Inst Instance=new A106549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106550
{
public static readonly long[] Value={ 26L,29L,42L,35L,41L,50L,58L,233L,80L,239L,344L,251L,92L,257L,352L,269L,126L,368L,566L,376L,2L,87L,293L,578L,392L,311L,788L,323L,602L,329L,416L,804L,424L,341L,614L,359L,448L,638L,377L,836L,1232L,383L,464L,472L,852L,401L,488L,413L,1256L,674L,419L,686L,437L,512L,884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106550Inst : IEnumerable<long>
{
public static readonly long[] Value=A106550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106550.Bytes);
public long this[int i]=>Value[i];

public static A106550Inst Instance=new A106550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106551
{
public static readonly long[] Value={ 26L,38L,42L,62L,86L,68L,94L,134L,80L,158L,146L,206L,110L,230L,172L,278L,126L,224L,170L,250L,350L,374L,200L,302L,446L,194L,494L,260L,518L,380L,228L,406L,566L,290L,638L,484L,350L,710L,296L,242L,734L,536L,562L,330L,806L,614L,854L,284L,440L,878L,470L,950L,692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106551Inst : IEnumerable<long>
{
public static readonly long[] Value=A106551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106551.Bytes);
public long this[int i]=>Value[i];

public static A106551Inst Instance=new A106551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106552
{
public static readonly long[] Value={ 26L,29L,42L,35L,41L,50L,58L,134L,80L,158L,146L,206L,92L,230L,172L,269L,126L,224L,170L,250L,287L,293L,200L,302L,311L,194L,323L,260L,329L,380L,228L,424L,341L,290L,359L,448L,350L,377L,296L,1232L,383L,464L,472L,330L,401L,488L,413L,1256L,440L,419L,470L,437L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106552Inst : IEnumerable<long>
{
public static readonly long[] Value=A106552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106552.Bytes);
public long this[int i]=>Value[i];

public static A106552Inst Instance=new A106552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106553
{
public static readonly long[] Value={ 26L,38L,41L,62L,86L,65L,94L,233L,80L,239L,344L,251L,110L,257L,352L,278L,128L,368L,566L,376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106553Inst : IEnumerable<long>
{
public static readonly long[] Value=A106553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106553.Bytes);
public long this[int i]=>Value[i];

public static A106553Inst Instance=new A106553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106554
{
public static readonly long[] Value={ 22L,23L,33L,25L,27L,35L,37L,211L,55L,213L,311L,217L,57L,219L,313L,223L,77L,317L,511L,319L,229L,231L,513L,323L,237L,711L,241L,517L,243L,329L,713L,331L,247L,519L,253L,337L,523L,259L,717L,1111L,261L,341L,343L,719L,267L,347L,271L,1113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106554Inst : IEnumerable<long>
{
public static readonly long[] Value=A106554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106554.Bytes);
public long this[int i]=>Value[i];

public static A106554Inst Instance=new A106554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106555
{
public static readonly long[] Value={ 22L,32L,33L,52L,72L,53L,73L,112L,55L,132L,113L,172L,75L,192L,133L,232L,77L,173L,115L,193L,292L,312L,135L,233L,372L,117L,412L,175L,432L,293L,137L,313L,472L,195L,532L,373L,235L,592L,177L,1111L,612L,413L,433L,197L,672L,473L,712L,1311L,295L,732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106555Inst : IEnumerable<long>
{
public static readonly long[] Value=A106555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106555.Bytes);
public long this[int i]=>Value[i];

public static A106555Inst Instance=new A106555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106556
{
public static readonly long[] Value={ 22L,23L,33L,25L,27L,35L,37L,112L,55L,132L,113L,172L,57L,192L,133L,223L,77L,173L,115L,193L,229L,231L,135L,233L,237L,117L,241L,175L,243L,293L,137L,313L,247L,195L,253L,337L,235L,259L,177L,1111L,261L,341L,343L,197L,267L,347L,271L,1113L,295L,273L,315L,279L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106556Inst : IEnumerable<long>
{
public static readonly long[] Value=A106556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106556.Bytes);
public long this[int i]=>Value[i];

public static A106556Inst Instance=new A106556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106557
{
public static readonly long[] Value={ 22L,32L,33L,52L,72L,53L,73L,211L,55L,213L,311L,217L,75L,219L,313L,232L,77L,317L,511L,319L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106557Inst : IEnumerable<long>
{
public static readonly long[] Value=A106557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106557.Bytes);
public long this[int i]=>Value[i];

public static A106557Inst Instance=new A106557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106558
{
public static readonly long[] Value={ 3L,8L,38L,264L,2896L,37638L,639830L,12156759L,279605448L,8108557990L,251365297667L,9300516013674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106558Inst : IEnumerable<long>
{
public static readonly long[] Value=A106558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106558.Bytes);
public long this[int i]=>Value[i];

public static A106558Inst Instance=new A106558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106559
{
public static readonly long[] Value={ 2L,3L,2L,1L,4L,1L,2L,3L,2L,4L,2L,4L,2L,3L,2L,4L,2L,4L,2L,3L,2L,1L,4L,1L,2L,3L,2L,4L,2L,4L,2L,3L,2L,4L,2L,4L,1L,4L,1L,3L,1L,3L,1L,4L,1L,4L,2L,4L,2L,3L,2L,4L,2L,4L,2L,3L,2L,1L,4L,1L,2L,3L,2L,4L,2L,4L,2L,3L,2L,4L,2L,4L,2L,3L,2L,1L,4L,1L,2L,3L,2L,3L,1L,3L,4L,2L,4L,3L,1L,3L,2L,3L,2L,1L,4L,1L,2L,3L,2L,3L,1L,3L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106559Inst : IEnumerable<long>
{
public static readonly long[] Value=A106559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106559.Bytes);
public long this[int i]=>Value[i];

public static A106559Inst Instance=new A106559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106560
{
public static readonly long[] Value={ 2L,3L,2L,3L,1L,3L,2L,3L,2L,2L,3L,2L,3L,1L,3L,2L,3L,2L,2L,3L,2L,3L,1L,3L,2L,3L,2L,4L,4L,4L,2L,3L,2L,4L,4L,4L,1L,2L,1L,1L,2L,1L,1L,2L,1L,4L,4L,4L,2L,3L,2L,4L,4L,4L,2L,3L,2L,3L,1L,3L,2L,3L,2L,2L,3L,2L,3L,1L,3L,2L,3L,2L,2L,3L,2L,3L,1L,3L,2L,3L,2L,3L,1L,3L,4L,4L,4L,3L,1L,3L,4L,4L,4L,2L,3L,2L,4L,4L,4L,3L,1L,3L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106560Inst : IEnumerable<long>
{
public static readonly long[] Value=A106560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106560.Bytes);
public long this[int i]=>Value[i];

public static A106560Inst Instance=new A106560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106561
{
public static readonly long[] Value={ 3L,7L,11L,13L,23L,29L,41L,47L,53L,59L,61L,67L,79L,89L,101L,107L,109L,113L,157L,163L,181L,191L,193L,197L,199L,223L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,283L,293L,307L,311L,313L,317L,349L,353L,359L,367L,373L,379L,383L,389L,397L,401L,409L,419L,421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106561Inst : IEnumerable<long>
{
public static readonly long[] Value=A106561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106561.Bytes);
public long this[int i]=>Value[i];

public static A106561Inst Instance=new A106561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106562
{
public static readonly long[] Value={ 1L,121L,289L,529L,625L,961L,1521L,1681L,2025L,2601L,2809L,3249L,3481L,4225L,4489L,5329L,6241L,6561L,6889L,7225L,7569L,8281L,9025L,9409L,9801L,10201L,11025L,11881L,12321L,12769L,13225L,15129L,15625L,16641L,17689L,18769L,19881L,20449L,21609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106562Inst : IEnumerable<long>
{
public static readonly long[] Value=A106562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106562.Bytes);
public long this[int i]=>Value[i];

public static A106562Inst Instance=new A106562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106563
{
public static readonly long[] Value={ 1L,11L,17L,23L,25L,31L,39L,41L,45L,51L,53L,57L,59L,65L,67L,73L,79L,81L,83L,85L,87L,91L,95L,97L,99L,101L,105L,109L,111L,113L,115L,123L,125L,129L,133L,137L,141L,143L,147L,149L,151L,153L,157L,159L,163L,165L,167L,171L,175L,179L,181L,185L,187L,189L,193L,195L,197L,199L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106563Inst : IEnumerable<long>
{
public static readonly long[] Value=A106563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106563.Bytes);
public long this[int i]=>Value[i];

public static A106563Inst Instance=new A106563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106564
{
public static readonly long[] Value={ 25L,49L,121L,169L,289L,361L,529L,625L,729L,841L,961L,1225L,1369L,1681L,1849L,2209L,2401L,2601L,2809L,3025L,3481L,3721L,3969L,4225L,4489L,4761L,5041L,5329L,5625L,5929L,6241L,6889L,7225L,7569L,7921L,8281L,8649L,9025L,9409L,10201L,10609L,11449L,11881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106564Inst : IEnumerable<long>
{
public static readonly long[] Value=A106564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106564.Bytes);
public long this[int i]=>Value[i];

public static A106564Inst Instance=new A106564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106565
{
public static readonly long[] Value={ 0L,5L,25L,150L,875L,5125L,30000L,175625L,1028125L,6018750L,35234375L,206265625L,1207500000L,7068828125L,41381640625L,242252343750L,1418169921875L,8302111328125L,48601406250000L,284517587890625L,1665594970703125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106565Inst : IEnumerable<long>
{
public static readonly long[] Value=A106565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106565.Bytes);
public long this[int i]=>Value[i];

public static A106565Inst Instance=new A106565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106566
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,5L,5L,3L,1L,0L,14L,14L,9L,4L,1L,0L,42L,42L,28L,14L,5L,1L,0L,132L,132L,90L,48L,20L,6L,1L,0L,429L,429L,297L,165L,75L,27L,7L,1L,0L,1430L,1430L,1001L,572L,275L,110L,35L,8L,1L,0L,4862L,4862L,3432L,2002L,1001L,429L,154L,44L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106566Inst : IEnumerable<long>
{
public static readonly long[] Value=A106566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106566.Bytes);
public long this[int i]=>Value[i];

public static A106566Inst Instance=new A106566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106567
{
public static readonly long[] Value={ 0L,4L,20L,116L,660L,3764L,21460L,122356L,697620L,3977524L,22678100L,129300596L,737215380L,4203279284L,23965257940L,136639406836L,779058065940L,4441847957044L,25325472048980L,144394752073076L,823275648561300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106567Inst : IEnumerable<long>
{
public static readonly long[] Value=A106567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106567.Bytes);
public long this[int i]=>Value[i];

public static A106567Inst Instance=new A106567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106568
{
public static readonly long[] Value={ 0L,4L,16L,80L,384L,1856L,8960L,43264L,208896L,1008640L,4870144L,23515136L,113541120L,548225024L,2647064576L,12781158400L,61712891904L,297976201216L,1438756372480L,6946930294784L,33542746669056L,161958707855360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106568Inst : IEnumerable<long>
{
public static readonly long[] Value=A106568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106568.Bytes);
public long this[int i]=>Value[i];

public static A106568Inst Instance=new A106568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106569
{
public static readonly long[] Value={ 0L,3L,15L,84L,465L,2577L,14280L,79131L,438495L,2429868L,13464825L,74613729L,413463120L,2291156787L,12696173295L,70354336836L,389860204065L,2160364030833L,11971400766360L,66338095924299L,367604681920575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106569Inst : IEnumerable<long>
{
public static readonly long[] Value=A106569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106569.Bytes);
public long this[int i]=>Value[i];

public static A106569Inst Instance=new A106569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106570
{
public static readonly long[] Value={ 0L,3L,12L,57L,264L,1227L,5700L,26481L,123024L,571539L,2655228L,12335529L,57307800L,266237787L,1236874548L,5746211553L,26695469856L,124020514083L,576168465900L,2676735405849L,12435447021096L,57771994301931L,268394318271012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106570Inst : IEnumerable<long>
{
public static readonly long[] Value=A106570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106570.Bytes);
public long this[int i]=>Value[i];

public static A106570Inst Instance=new A106570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106571
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,23L,25L,27L,29L,31L,35L,37L,41L,43L,47L,49L,51L,53L,55L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,83L,85L,87L,89L,91L,93L,95L,97L,101L,103L,107L,109L,113L,115L,119L,121L,125L,127L,129L,131L,133L,135L,137L,139L,141L,143L,145L,149L,151L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106571Inst : IEnumerable<long>
{
public static readonly long[] Value=A106571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106571.Bytes);
public long this[int i]=>Value[i];

public static A106571Inst Instance=new A106571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106572
{
public static readonly long[] Value={ 1L,0L,119L,649L,13L,493L,989L,667L,4399L,67L,3763L,4819L,4717L,9943L,179L,20437L,15677L,193L,26797L,27977L,21251L,37267L,68923L,45671L,131179L,72967L,105779L,76409L,117961L,131867L,147109L,243169L,152447L,200653L,158399L,254563L,306079L,215639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106572Inst : IEnumerable<long>
{
public static readonly long[] Value=A106572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106572.Bytes);
public long this[int i]=>Value[i];

public static A106572Inst Instance=new A106572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106573
{
public static readonly long[] Value={ 121L,289L,529L,625L,961L,1681L,2601L,2809L,3481L,4225L,4489L,5329L,6241L,6889L,7225L,7569L,8281L,9025L,9409L,10201L,11881L,12769L,13225L,15625L,16641L,17689L,18769L,19881L,20449L,22201L,22801L,23409L,24649L,25281L,26569L,27225L,27889L,30625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106573Inst : IEnumerable<long>
{
public static readonly long[] Value=A106573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106573.Bytes);
public long this[int i]=>Value[i];

public static A106573Inst Instance=new A106573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106574
{
public static readonly long[] Value={ 11L,17L,23L,25L,31L,41L,51L,53L,59L,65L,67L,73L,79L,83L,85L,87L,91L,95L,97L,101L,109L,113L,115L,125L,129L,133L,137L,141L,143L,149L,151L,153L,157L,159L,163L,165L,167L,175L,179L,181L,185L,187L,189L,193L,195L,197L,199L,201L,203L,207L,209L,213L,215L,221L,227L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106574Inst : IEnumerable<long>
{
public static readonly long[] Value=A106574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106574.Bytes);
public long this[int i]=>Value[i];

public static A106574Inst Instance=new A106574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106575
{
public static readonly long[] Value={ 4L,9L,16L,36L,64L,81L,100L,144L,196L,225L,256L,324L,400L,441L,484L,576L,676L,784L,900L,1024L,1089L,1156L,1296L,1444L,1600L,1764L,1936L,2116L,2304L,2500L,2704L,2916L,3136L,3364L,3600L,3844L,4096L,4356L,4624L,4900L,5184L,5476L,5776L,6084L,6400L,6724L,7056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106575Inst : IEnumerable<long>
{
public static readonly long[] Value=A106575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106575.Bytes);
public long this[int i]=>Value[i];

public static A106575Inst Instance=new A106575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106576
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,6L,3L,6L,5L,0L,5L,0L,7L,4L,7L,4L,9L,8L,9L,8L,1L,2L,1L,2L,3L,6L,3L,6L,5L,0L,5L,0L,7L,4L,7L,4L,9L,8L,9L,8L,1L,2L,1L,2L,3L,6L,3L,6L,5L,0L,5L,0L,7L,4L,7L,4L,9L,8L,9L,8L,1L,2L,1L,2L,3L,6L,3L,6L,5L,0L,5L,0L,7L,4L,7L,4L,9L,8L,9L,8L,1L,2L,1L,2L,3L,6L,3L,6L,5L,0L,5L,0L,7L,4L,7L,4L,9L,8L,9L,8L,1L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106576Inst : IEnumerable<long>
{
public static readonly long[] Value=A106576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106576.Bytes);
public long this[int i]=>Value[i];

public static A106576Inst Instance=new A106576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106577
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,28L,30L,32L,33L,34L,36L,38L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,117L,118L,120L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106577Inst : IEnumerable<long>
{
public static readonly long[] Value=A106577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106577.Bytes);
public long this[int i]=>Value[i];

public static A106577Inst Instance=new A106577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106578
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,6L,2L,4L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106578Inst : IEnumerable<long>
{
public static readonly long[] Value=A106578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106578.Bytes);
public long this[int i]=>Value[i];

public static A106578Inst Instance=new A106578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106579
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,4L,6L,0L,1L,6L,16L,22L,0L,1L,8L,30L,68L,90L,0L,1L,10L,48L,146L,304L,394L,0L,1L,12L,70L,264L,714L,1412L,1806L,0L,1L,14L,96L,430L,1408L,3534L,6752L,8558L,0L,1L,16L,126L,652L,2490L,7432L,17718L,33028L,41586L,0L,1L,18L,160L,938L,4080L,14002L,39152L,89898L,164512L,206098L,0L,1L,20L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106579Inst : IEnumerable<long>
{
public static readonly long[] Value=A106579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106579.Bytes);
public long this[int i]=>Value[i];

public static A106579Inst Instance=new A106579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106580
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,2L,3L,3L,1L,2L,5L,7L,7L,1L,2L,5L,9L,12L,12L,1L,2L,5L,13L,22L,29L,29L,1L,2L,5L,13L,26L,41L,53L,53L,1L,2L,5L,13L,34L,65L,101L,130L,130L,1L,2L,5L,13L,34L,73L,129L,194L,247L,247L,1L,2L,5L,13L,34L,89L,185L,322L,481L,611L,611L,1L,2L,5L,13L,34L,89L,201L,386L,645L,945L,1192L,1192L,1L,2L,5L,13L,34L,89L,233L,514L,973L,1613L,2354L,2965L,2965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106580Inst : IEnumerable<long>
{
public static readonly long[] Value=A106580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106580.Bytes);
public long this[int i]=>Value[i];

public static A106580Inst Instance=new A106580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106581
{
public static readonly long[] Value={ 2L,4L,3L,1L,2L,2L,2L,4L,3L,1L,4L,3L,1L,4L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106581Inst : IEnumerable<long>
{
public static readonly long[] Value=A106581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106581.Bytes);
public long this[int i]=>Value[i];

public static A106581Inst Instance=new A106581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106582
{
public static readonly long[] Value={ 22L,23L,25L,27L,32L,33L,35L,37L,52L,53L,55L,57L,72L,73L,75L,77L,112L,113L,115L,117L,132L,133L,135L,137L,172L,173L,175L,177L,192L,193L,195L,197L,211L,213L,217L,219L,223L,229L,231L,232L,233L,235L,237L,241L,243L,247L,253L,259L,261L,267L,271L,273L,279L,283L,289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106582Inst : IEnumerable<long>
{
public static readonly long[] Value=A106582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106582.Bytes);
public long this[int i]=>Value[i];

public static A106582Inst Instance=new A106582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106583
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,2L,2L,2L,4L,6L,1L,3L,5L,1L,3L,5L,1L,3L,5L,5L,5L,2L,2L,2L,4L,6L,2L,2L,2L,4L,6L,2L,2L,2L,4L,6L,2L,4L,6L,2L,4L,6L,1L,3L,5L,1L,3L,5L,1L,3L,5L,5L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,5L,5L,1L,3L,5L,1L,3L,5L,1L,3L,5L,5L,5L,1L,3L,5L,5L,5L,1L,3L,5L,5L,5L,2L,2L,2L,4L,6L,2L,2L,2L,4L,6L,2L,2L,2L,4L,6L,2L,4L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106583Inst : IEnumerable<long>
{
public static readonly long[] Value=A106583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106583.Bytes);
public long this[int i]=>Value[i];

public static A106583Inst Instance=new A106583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106584
{
public static readonly long[] Value={ 3L,2L,3L,1L,3L,5L,3L,2L,3L,3L,2L,3L,1L,2L,1L,2L,4L,6L,3L,2L,3L,1L,3L,5L,3L,2L,3L,1L,2L,1L,1L,3L,5L,1L,2L,1L,3L,2L,3L,1L,3L,5L,3L,2L,3L,1L,3L,5L,6L,5L,6L,4L,5L,4L,3L,2L,3L,1L,3L,5L,3L,2L,3L,3L,2L,3L,1L,2L,1L,2L,4L,6L,3L,2L,3L,1L,3L,5L,3L,2L,3L,3L,2L,3L,1L,3L,5L,3L,2L,3L,3L,2L,3L,1L,2L,1L,2L,4L,6L,3L,2L,3L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106584Inst : IEnumerable<long>
{
public static readonly long[] Value=A106584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106584.Bytes);
public long this[int i]=>Value[i];

public static A106584Inst Instance=new A106584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106585
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,5L,7L,7L,1L,2L,5L,13L,22L,29L,29L,1L,2L,5L,13L,34L,65L,101L,130L,130L,1L,2L,5L,13L,34L,89L,185L,322L,481L,611L,611L,1L,2L,5L,13L,34L,89L,233L,514L,973L,1613L,2354L,2965L,2965L,1L,2L,5L,13L,34L,89L,233L,610L,1405L,2837L,5090L,8185L,11761L,14726L,14726L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106585Inst : IEnumerable<long>
{
public static readonly long[] Value=A106585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106585.Bytes);
public long this[int i]=>Value[i];

public static A106585Inst Instance=new A106585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106586
{
public static readonly long[] Value={ 1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L,7L,5L,9L,3L,1L,1L,3L,9L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106586Inst : IEnumerable<long>
{
public static readonly long[] Value=A106586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106586.Bytes);
public long this[int i]=>Value[i];

public static A106586Inst Instance=new A106586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106587
{
public static readonly long[] Value={ 5L,13L,34L,65L,146L,205L,338L,425L,610L,941L,1082L,1513L,1850L,2045L,2434L,3065L,3770L,4045L,4850L,5441L,5770L,6725L,7418L,8497L,10034L,10877L,11338L,12233L,12722L,13669L,17090L,18185L,19858L,20477L,23426L,24097L,26018L,28013L,29410L,31529L,33722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106587Inst : IEnumerable<long>
{
public static readonly long[] Value=A106587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106587.Bytes);
public long this[int i]=>Value[i];

public static A106587Inst Instance=new A106587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106588
{
public static readonly long[] Value={ 3L,5L,16L,33L,96L,133L,240L,297L,448L,741L,840L,1225L,1512L,1653L,1984L,2553L,3192L,3397L,4128L,4641L,4888L,5757L,6360L,7345L,8784L,9525L,9880L,10665L,11040L,11869L,15168L,16137L,17680L,18165L,20976L,21505L,23280L,25125L,26368L,28329L,30360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106588Inst : IEnumerable<long>
{
public static readonly long[] Value=A106588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106588.Bytes);
public long this[int i]=>Value[i];

public static A106588Inst Instance=new A106588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106589
{
public static readonly long[] Value={ 2L,3L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106589Inst : IEnumerable<long>
{
public static readonly long[] Value=A106589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106589.Bytes);
public long this[int i]=>Value[i];

public static A106589Inst Instance=new A106589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106590
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,3L,1L,2L,3L,2L,3L,3L,3L,1L,2L,3L,2L,3L,3L,3L,1L,2L,3L,3L,3L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,3L,1L,2L,3L,2L,3L,3L,3L,1L,2L,3L,2L,3L,3L,3L,1L,2L,3L,3L,3L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,2L,3L,3L,3L,1L,2L,3L,1L,2L,3L,1L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106590Inst : IEnumerable<long>
{
public static readonly long[] Value=A106590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106590.Bytes);
public long this[int i]=>Value[i];

public static A106590Inst Instance=new A106590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106591
{
public static readonly long[] Value={ 1L,4L,5L,6L,2L,2L,2L,3L,3L,3L,1L,2L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,4L,5L,6L,4L,4L,4L,5L,5L,5L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,2L,3L,3L,3L,1L,2L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106591Inst : IEnumerable<long>
{
public static readonly long[] Value=A106591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106591.Bytes);
public long this[int i]=>Value[i];

public static A106591Inst Instance=new A106591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106592
{
public static readonly long[] Value={ 1L,4L,5L,6L,2L,2L,3L,3L,1L,2L,3L,4L,4L,4L,4L,5L,5L,5L,5L,4L,5L,6L,4L,4L,5L,5L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,2L,2L,3L,3L,1L,2L,3L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,4L,4L,4L,4L,5L,5L,5L,5L,4L,5L,6L,4L,4L,5L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106592Inst : IEnumerable<long>
{
public static readonly long[] Value=A106592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106592.Bytes);
public long this[int i]=>Value[i];

public static A106592Inst Instance=new A106592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106593
{
public static readonly long[] Value={ 1L,4L,5L,6L,2L,3L,1L,2L,3L,4L,5L,4L,5L,6L,4L,5L,2L,3L,2L,3L,1L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,6L,4L,5L,4L,5L,2L,3L,2L,3L,2L,3L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,4L,5L,6L,4L,5L,4L,5L,4L,5L,2L,3L,2L,3L,2L,3L,2L,3L,1L,2L,3L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,4L,5L,4L,5L,4L,5L,6L,4L,5L,4L,5L,4L,5L,4L,5L,2L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106593Inst : IEnumerable<long>
{
public static readonly long[] Value=A106593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106593.Bytes);
public long this[int i]=>Value[i];

public static A106593Inst Instance=new A106593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106594
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,2L,0L,1L,0L,0L,2L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,1L,1L,0L,1L,2L,0L,1L,1L,0L,2L,0L,0L,0L,2L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,2L,1L,0L,1L,1L,0L,1L,1L,0L,0L,2L,0L,1L,1L,0L,2L,0L,0L,1L,0L,0L,1L,1L,0L,0L,2L,0L,1L,2L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106594Inst : IEnumerable<long>
{
public static readonly long[] Value=A106594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106594.Bytes);
public long this[int i]=>Value[i];

public static A106594Inst Instance=new A106594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106595
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,1L,2L,5L,9L,12L,12L,1L,2L,5L,13L,26L,41L,53L,53L,1L,2L,5L,13L,34L,73L,129L,194L,247L,247L,1L,2L,5L,13L,34L,89L,201L,386L,645L,945L,1192L,1192L,1L,2L,5L,13L,34L,89L,233L,546L,1117L,2021L,3266L,4705L,5897L,5897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106595Inst : IEnumerable<long>
{
public static readonly long[] Value=A106595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106595.Bytes);
public long this[int i]=>Value[i];

public static A106595Inst Instance=new A106595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106596
{
public static readonly long[] Value={ 3L,10L,11L,12L,14L,15L,21L,23L,30L,31L,33L,34L,35L,39L,47L,51L,52L,59L,63L,69L,73L,75L,78L,94L,100L,101L,102L,103L,104L,105L,107L,110L,111L,112L,113L,115L,116L,120L,123L,133L,141L,146L,147L,151L,153L,154L,158L,159L,163L,164L,166L,168L,183L,185L,191L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106596Inst : IEnumerable<long>
{
public static readonly long[] Value=A106596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106596.Bytes);
public long this[int i]=>Value[i];

public static A106596Inst Instance=new A106596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106597
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,5L,5L,1L,1L,7L,14L,7L,1L,1L,9L,27L,27L,9L,1L,1L,11L,44L,72L,44L,11L,1L,1L,13L,65L,149L,149L,65L,13L,1L,1L,15L,90L,266L,388L,266L,90L,15L,1L,1L,17L,119L,431L,836L,836L,431L,119L,17L,1L,1L,19L,152L,652L,1585L,2150L,1585L,652L,152L,19L,1L,1L,21L,189L,937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106597Inst : IEnumerable<long>
{
public static readonly long[] Value=A106597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106597.Bytes);
public long this[int i]=>Value[i];

public static A106597Inst Instance=new A106597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106598
{
public static readonly long[] Value={ 1L,9L,34L,86L,175L,313L,507L,768L,1105L,1530L,2053L,2683L,3429L,4301L,5310L,6466L,7780L,9259L,10917L,12761L,14801L,17048L,19511L,22201L,25127L,28300L,31730L,35425L,39397L,43654L,48207L,53066L,58243L,63746L,69584L,75769L,82310L,89216L,96499L,104168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106598Inst : IEnumerable<long>
{
public static readonly long[] Value=A106598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106598.Bytes);
public long this[int i]=>Value[i];

public static A106598Inst Instance=new A106598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106599
{
public static readonly long[] Value={ 1L,5L,6L,3L,1L,2L,5L,5L,6L,4L,3L,3L,1L,2L,2L,5L,5L,5L,6L,4L,4L,3L,3L,3L,1L,2L,2L,2L,5L,5L,5L,5L,6L,4L,4L,4L,3L,3L,3L,3L,1L,2L,2L,2L,2L,5L,5L,5L,5L,5L,6L,4L,4L,4L,4L,3L,3L,3L,3L,3L,1L,2L,2L,2L,2L,2L,5L,5L,5L,5L,5L,5L,6L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,1L,2L,2L,2L,2L,2L,2L,5L,5L,5L,5L,5L,5L,5L,6L,4L,4L,4L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106599Inst : IEnumerable<long>
{
public static readonly long[] Value=A106599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106599.Bytes);
public long this[int i]=>Value[i];

public static A106599Inst Instance=new A106599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106600
{
public static readonly long[] Value={ 1L,10L,46L,141L,338L,694L,1273L,2155L,3427L,5194L,7575L,10688L,14672L,19674L,25861L,33406L,42487L,53302L,66061L,80988L,98311L,118271L,141124L,167139L,196597L,229785L,267007L,308575L,354820L,406074L,462692L,525030L,593467L,668384L,750177L,839260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106600Inst : IEnumerable<long>
{
public static readonly long[] Value=A106600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106600.Bytes);
public long this[int i]=>Value[i];

public static A106600Inst Instance=new A106600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106601
{
public static readonly long[] Value={ 3L,1L,2L,3L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,2L,3L,3L,1L,2L,3L,3L,3L,1L,2L,3L,3L,3L,3L,1L,2L,3L,3L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106601Inst : IEnumerable<long>
{
public static readonly long[] Value=A106601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106601.Bytes);
public long this[int i]=>Value[i];

public static A106601Inst Instance=new A106601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106602
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,2L,0L,1L,0L,0L,2L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,1L,1L,0L,1L,2L,0L,1L,1L,0L,2L,0L,0L,0L,2L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,2L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106602Inst : IEnumerable<long>
{
public static readonly long[] Value=A106602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106602.Bytes);
public long this[int i]=>Value[i];

public static A106602Inst Instance=new A106602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106603
{
public static readonly long[] Value={ 1L,1L,-2L,-4L,0L,16L,0L,0L,-128L,256L,-512L,2048L,-6144L,16384L,-49152L,147456L,-425984L,1245184L,-3670016L,10747904L,-31457280L,92274688L,-270532608L,792723456L,-2323644416L,6811549696L,-19964887040L,58518929408L,-171530256384L,502779609088L,-1473710653440L,4319663357952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106603Inst : IEnumerable<long>
{
public static readonly long[] Value=A106603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106603.Bytes);
public long this[int i]=>Value[i];

public static A106603Inst Instance=new A106603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106604
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,23L,45L,67L,89L,90L,123L,456L,780L,781L,923L,4560L,4561L,7238L,9012L,3456L,7890L,7891L,23456L,23457L,60189L,60192L,73458L,73459L,80126L,80127L,93456L,93457L,102680L,123456L,789012L,789345L,6012345L,678901L,678923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106604Inst : IEnumerable<long>
{
public static readonly long[] Value=A106604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106604.Bytes);
public long this[int i]=>Value[i];

public static A106604Inst Instance=new A106604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106605
{
public static readonly long[] Value={ 10011001L,10025001L,10052001L,10088001L,10100101L,10111101L,10125101L,11011011L,11025011L,11052011L,11088011L,11100111L,11111111L,11125111L,12011051L,12025051L,12052051L,12088051L,12100151L,12111151L,12125151L,15011021L,15025021L,15052021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106605Inst : IEnumerable<long>
{
public static readonly long[] Value=A106605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106605.Bytes);
public long this[int i]=>Value[i];

public static A106605Inst Instance=new A106605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106606
{
public static readonly long[] Value={ 1L,1L,3L,8L,23L,66L,199L,601L,1861L,5815L,18396L,58684L,188764L,611103L,1990361L,6515786L,21429510L,70767468L,234565319L,780086526L,2602209961L,8704547698L,29191435328L,98125474137L,330558122499L,1115795428615L,3773380090126L,12782934685768L,43374552366876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106606Inst : IEnumerable<long>
{
public static readonly long[] Value=A106606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106606.Bytes);
public long this[int i]=>Value[i];

public static A106606Inst Instance=new A106606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106607
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,13L,20L,28L,39L,51L,67L,85L,107L,131L,160L,192L,229L,269L,315L,365L,421L,481L,548L,620L,699L,783L,875L,973L,1079L,1191L,1312L,1440L,1577L,1721L,1875L,2037L,2209L,2389L,2580L,2780L,2991L,3211L,3443L,3685L,3939L,4203L,4480L,4768L,5069L,5381L,5707L,6045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106607Inst : IEnumerable<long>
{
public static readonly long[] Value=A106607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106607.Bytes);
public long this[int i]=>Value[i];

public static A106607Inst Instance=new A106607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106608
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,1L,8L,9L,10L,11L,12L,13L,2L,15L,16L,17L,18L,19L,20L,3L,22L,23L,24L,25L,26L,27L,4L,29L,30L,31L,32L,33L,34L,5L,36L,37L,38L,39L,40L,41L,6L,43L,44L,45L,46L,47L,48L,7L,50L,51L,52L,53L,54L,55L,8L,57L,58L,59L,60L,61L,62L,9L,64L,65L,66L,67L,68L,69L,10L,71L,72L,73L,74L,75L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106608Inst : IEnumerable<long>
{
public static readonly long[] Value=A106608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106608.Bytes);
public long this[int i]=>Value[i];

public static A106608Inst Instance=new A106608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106609
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,11L,3L,13L,7L,15L,2L,17L,9L,19L,5L,21L,11L,23L,3L,25L,13L,27L,7L,29L,15L,31L,4L,33L,17L,35L,9L,37L,19L,39L,5L,41L,21L,43L,11L,45L,23L,47L,6L,49L,25L,51L,13L,53L,27L,55L,7L,57L,29L,59L,15L,61L,31L,63L,8L,65L,33L,67L,17L,69L,35L,71L,9L,73L,37L,75L,19L,77L,39L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106609Inst : IEnumerable<long>
{
public static readonly long[] Value=A106609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106609.Bytes);
public long this[int i]=>Value[i];

public static A106609Inst Instance=new A106609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106610
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,5L,2L,7L,8L,1L,10L,11L,4L,13L,14L,5L,16L,17L,2L,19L,20L,7L,22L,23L,8L,25L,26L,3L,28L,29L,10L,31L,32L,11L,34L,35L,4L,37L,38L,13L,40L,41L,14L,43L,44L,5L,46L,47L,16L,49L,50L,17L,52L,53L,6L,55L,56L,19L,58L,59L,20L,61L,62L,7L,64L,65L,22L,67L,68L,23L,70L,71L,8L,73L,74L,25L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106610Inst : IEnumerable<long>
{
public static readonly long[] Value=A106610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106610.Bytes);
public long this[int i]=>Value[i];

public static A106610Inst Instance=new A106610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106611
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,1L,3L,7L,4L,9L,1L,11L,6L,13L,7L,3L,8L,17L,9L,19L,2L,21L,11L,23L,12L,5L,13L,27L,14L,29L,3L,31L,16L,33L,17L,7L,18L,37L,19L,39L,4L,41L,21L,43L,22L,9L,23L,47L,24L,49L,5L,51L,26L,53L,27L,11L,28L,57L,29L,59L,6L,61L,31L,63L,32L,13L,33L,67L,34L,69L,7L,71L,36L,73L,37L,15L,38L,77L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106611Inst : IEnumerable<long>
{
public static readonly long[] Value=A106611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106611.Bytes);
public long this[int i]=>Value[i];

public static A106611Inst Instance=new A106611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106612
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,2L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,3L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,4L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,5L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,6L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106612Inst : IEnumerable<long>
{
public static readonly long[] Value=A106612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106612.Bytes);
public long this[int i]=>Value[i];

public static A106612Inst Instance=new A106612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106613
{
public static readonly long[] Value={ 1L,15L,25L,26L,34L,36L,40L,45L,49L,51L,52L,55L,56L,57L,63L,65L,69L,70L,76L,77L,78L,81L,86L,87L,88L,91L,93L,94L,95L,105L,106L,112L,116L,117L,118L,119L,121L,123L,124L,125L,133L,135L,143L,145L,146L,153L,154L,155L,159L,160L,161L,162L,165L,169L,170L,172L,175L,177L,183L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106613Inst : IEnumerable<long>
{
public static readonly long[] Value=A106613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106613.Bytes);
public long this[int i]=>Value[i];

public static A106613Inst Instance=new A106613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106614
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,1L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,2L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,3L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,4L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,5L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106614Inst : IEnumerable<long>
{
public static readonly long[] Value=A106614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106614.Bytes);
public long this[int i]=>Value[i];

public static A106614Inst Instance=new A106614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106615
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,5L,3L,1L,4L,9L,5L,11L,6L,13L,1L,15L,8L,17L,9L,19L,10L,3L,11L,23L,12L,25L,13L,27L,2L,29L,15L,31L,16L,33L,17L,5L,18L,37L,19L,39L,20L,41L,3L,43L,22L,45L,23L,47L,24L,7L,25L,51L,26L,53L,27L,55L,4L,57L,29L,59L,30L,61L,31L,9L,32L,65L,33L,67L,34L,69L,5L,71L,36L,73L,37L,75L,38L,11L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106615Inst : IEnumerable<long>
{
public static readonly long[] Value=A106615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106615.Bytes);
public long this[int i]=>Value[i];

public static A106615Inst Instance=new A106615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106616
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,1L,2L,7L,8L,3L,2L,11L,4L,13L,14L,1L,16L,17L,6L,19L,4L,7L,22L,23L,8L,5L,26L,9L,28L,29L,2L,31L,32L,11L,34L,7L,12L,37L,38L,13L,8L,41L,14L,43L,44L,3L,46L,47L,16L,49L,10L,17L,52L,53L,18L,11L,56L,19L,58L,59L,4L,61L,62L,21L,64L,13L,22L,67L,68L,23L,14L,71L,24L,73L,74L,5L,76L,77L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106616Inst : IEnumerable<long>
{
public static readonly long[] Value=A106616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106616.Bytes);
public long this[int i]=>Value[i];

public static A106616Inst Instance=new A106616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106617
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,11L,3L,13L,7L,15L,1L,17L,9L,19L,5L,21L,11L,23L,3L,25L,13L,27L,7L,29L,15L,31L,2L,33L,17L,35L,9L,37L,19L,39L,5L,41L,21L,43L,11L,45L,23L,47L,3L,49L,25L,51L,13L,53L,27L,55L,7L,57L,29L,59L,15L,61L,31L,63L,4L,65L,33L,67L,17L,69L,35L,71L,9L,73L,37L,75L,19L,77L,39L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106617Inst : IEnumerable<long>
{
public static readonly long[] Value=A106617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106617.Bytes);
public long this[int i]=>Value[i];

public static A106617Inst Instance=new A106617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106618
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,1L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,2L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,3L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,4L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106618Inst : IEnumerable<long>
{
public static readonly long[] Value=A106618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106618.Bytes);
public long this[int i]=>Value[i];

public static A106618Inst Instance=new A106618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106619
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,5L,1L,7L,4L,1L,5L,11L,2L,13L,7L,5L,8L,17L,1L,19L,10L,7L,11L,23L,4L,25L,13L,3L,14L,29L,5L,31L,16L,11L,17L,35L,2L,37L,19L,13L,20L,41L,7L,43L,22L,5L,23L,47L,8L,49L,25L,17L,26L,53L,3L,55L,28L,19L,29L,59L,10L,61L,31L,7L,32L,65L,11L,67L,34L,23L,35L,71L,4L,73L,37L,25L,38L,77L,13L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106619Inst : IEnumerable<long>
{
public static readonly long[] Value=A106619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106619.Bytes);
public long this[int i]=>Value[i];

public static A106619Inst Instance=new A106619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106620
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,1L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,2L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,3L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106620Inst : IEnumerable<long>
{
public static readonly long[] Value=A106620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106620.Bytes);
public long this[int i]=>Value[i];

public static A106620Inst Instance=new A106620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106621
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,1L,3L,7L,2L,9L,1L,11L,3L,13L,7L,3L,4L,17L,9L,19L,1L,21L,11L,23L,6L,5L,13L,27L,7L,29L,3L,31L,8L,33L,17L,7L,9L,37L,19L,39L,2L,41L,21L,43L,11L,9L,23L,47L,12L,49L,5L,51L,13L,53L,27L,11L,14L,57L,29L,59L,3L,61L,31L,63L,16L,13L,33L,67L,17L,69L,7L,71L,18L,73L,37L,15L,19L,77L,39L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106621Inst : IEnumerable<long>
{
public static readonly long[] Value=A106621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106621.Bytes);
public long this[int i]=>Value[i];

public static A106621Inst Instance=new A106621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106622
{
public static readonly long[] Value={ 2L,17L,23L,31L,37L,47L,67L,71L,97L,101L,103L,109L,127L,131L,137L,139L,149L,151L,157L,163L,179L,191L,197L,199L,211L,223L,227L,233L,239L,241L,257L,263L,269L,271L,277L,281L,283L,311L,313L,331L,347L,349L,353L,359L,367L,373L,379L,389L,397L,401L,419L,431L,443L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106622Inst : IEnumerable<long>
{
public static readonly long[] Value=A106622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106622.Bytes);
public long this[int i]=>Value[i];

public static A106622Inst Instance=new A106622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106623
{
public static readonly long[] Value={ 6L,13L,12L,11L,10L,25L,24L,31L,30L,21L,20L,19L,18L,17L,16L,23L,22L,29L,28L,59L,58L,41L,40L,47L,46L,37L,36L,35L,34L,33L,32L,39L,38L,45L,44L,43L,42L,57L,56L,63L,62L,53L,52L,51L,50L,49L,48L,119L,118L,125L,124L,91L,90L,73L,72L,79L,78L,69L,68L,67L,66L,65L,64L,71L,70L,77L,76L,75L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106623Inst : IEnumerable<long>
{
public static readonly long[] Value=A106623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106623.Bytes);
public long this[int i]=>Value[i];

public static A106623Inst Instance=new A106623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106624
{
public static readonly long[] Value={ 1L,0L,2L,1L,4L,3L,8L,7L,16L,15L,32L,31L,64L,63L,128L,127L,256L,255L,512L,511L,1024L,1023L,2048L,2047L,4096L,4095L,8192L,8191L,16384L,16383L,32768L,32767L,65536L,65535L,131072L,131071L,262144L,262143L,524288L,524287L,1048576L,1048575L,2097152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106624Inst : IEnumerable<long>
{
public static readonly long[] Value=A106624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106624.Bytes);
public long this[int i]=>Value[i];

public static A106624Inst Instance=new A106624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106625
{
public static readonly long[] Value={ 2L,1L,4L,3L,8L,5L,10L,6L,13L,7L,16L,9L,17L,11L,18L,12L,21L,14L,24L,15L,25L,19L,26L,20L,29L,22L,32L,23L,33L,27L,34L,28L,36L,30L,37L,31L,38L,35L,40L,39L,41L,42L,45L,43L,47L,44L,48L,46L,49L,53L,50L,57L,51L,63L,52L,67L,54L,68L,55L,73L,56L,75L,58L,76L,59L,79L,60L,80L,61L,82L,62L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106625Inst : IEnumerable<long>
{
public static readonly long[] Value=A106625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106625.Bytes);
public long this[int i]=>Value[i];

public static A106625Inst Instance=new A106625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106626
{
public static readonly long[] Value={ 4L,5L,5L,4L,4L,7L,7L,5L,5L,6L,6L,10L,8L,6L,7L,7L,7L,7L,7L,13L,10L,8L,8L,8L,8L,9L,8L,9L,9L,16L,11L,9L,9L,10L,10L,9L,10L,10L,10L,11L,10L,19L,13L,10L,11L,11L,11L,12L,11L,11L,12L,11L,12L,12L,12L,22L,14L,12L,12L,13L,12L,13L,12L,13L,13L,13L,13L,13L,13L,14L,13L,25L,16L,13L,14L,14L,14L,14L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106626Inst : IEnumerable<long>
{
public static readonly long[] Value=A106626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106626.Bytes);
public long this[int i]=>Value[i];

public static A106626Inst Instance=new A106626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106627
{
public static readonly long[] Value={ 8L,1L,9L,28L,105L,286L,918L,2871L,8977L,27892L,87084L,271635L,847182L,2641991L,8240325L,25700488L,80156033L,249994997L,779700654L,2431777739L,7584375260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106627Inst : IEnumerable<long>
{
public static readonly long[] Value=A106627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106627.Bytes);
public long this[int i]=>Value[i];

public static A106627Inst Instance=new A106627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106628
{
public static readonly long[] Value={ 199L,211L,283L,317L,337L,389L,491L,509L,547L,577L,619L,683L,701L,773L,787L,797L,863L,887L,1069L,1109L,1129L,1153L,1163L,1373L,1381L,1409L,1459L,1523L,1531L,1571L,1627L,1637L,1669L,1709L,1723L,1733L,1759L,1831L,1889L,1913L,1933L,1951L,1979L,2003L,2017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106628Inst : IEnumerable<long>
{
public static readonly long[] Value=A106628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106628.Bytes);
public long this[int i]=>Value[i];

public static A106628Inst Instance=new A106628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106629
{
public static readonly long[] Value={ 1L,10L,62L,242L,733L,1848L,4106L,8289L,15519L,27365L,45914L,73908L,114831L,173077L,254065L,364385L,511985L,706293L,958460L,1281500L,1690506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106629Inst : IEnumerable<long>
{
public static readonly long[] Value=A106629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106629.Bytes);
public long this[int i]=>Value[i];

public static A106629Inst Instance=new A106629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106630
{
public static readonly long[] Value={ 7L,8L,12L,13L,17L,20L,24L,25L,28L,29L,32L,39L,42L,45L,52L,53L,58L,59L,63L,64L,67L,72L,75L,79L,83L,87L,88L,93L,100L,102L,114L,115L,125L,126L,127L,131L,139L,140L,144L,154L,159L,160L,173L,180L,190L,195L,219L,223L,232L,234L,240L,248L,253L,265L,278L,279L,284L,296L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106630Inst : IEnumerable<long>
{
public static readonly long[] Value=A106630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106630.Bytes);
public long this[int i]=>Value[i];

public static A106630Inst Instance=new A106630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106631
{
public static readonly long[] Value={ 4L,10L,11L,13L,14L,20L,21L,22L,24L,25L,31L,32L,37L,40L,43L,44L,51L,54L,57L,64L,65L,76L,82L,84L,87L,89L,92L,98L,100L,101L,104L,110L,111L,112L,114L,116L,121L,122L,124L,125L,127L,128L,137L,140L,141L,142L,144L,145L,148L,149L,151L,154L,158L,172L,177L,191L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106631Inst : IEnumerable<long>
{
public static readonly long[] Value=A106631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106631.Bytes);
public long this[int i]=>Value[i];

public static A106631Inst Instance=new A106631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106632
{
public static readonly long[] Value={ -1L,1L,-25L,49L,-1L,529L,-1849L,289L,-9025L,58081L,-38809L,108241L,-1560001L,2283121L,-525625L,35796289L,-95863681L,2666689L,-681575449L,3261894769L,-1289169025L,9906021841L,-94109673529L,99199171681L,-84332740801L,2327696411041L,-4753075824025L,46970592529L,-48635546218561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106632Inst : IEnumerable<long>
{
public static readonly long[] Value=A106632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106632.Bytes);
public long this[int i]=>Value[i];

public static A106632Inst Instance=new A106632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106633
{
public static readonly long[] Value={ 1L,4L,8L,12L,17L,21L,27L,31L,37L,42L,48L,52L,60L,64L,70L,76L,83L,87L,95L,99L,107L,113L,119L,123L,133L,138L,144L,150L,158L,162L,172L,176L,184L,190L,196L,202L,213L,217L,223L,229L,239L,243L,253L,257L,265L,273L,279L,283L,295L,300L,308L,314L,322L,326L,336L,342L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106633Inst : IEnumerable<long>
{
public static readonly long[] Value=A106633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106633.Bytes);
public long this[int i]=>Value[i];

public static A106633Inst Instance=new A106633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106634
{
public static readonly long[] Value={ 1L,6L,21L,32L,62L,58L,124L,88L,173L,158L,226L,156L,380L,194L,340L,356L,466L,274L,613L,316L,690L,536L,596L,404L,1060L,552L,734L,728L,1032L,546L,1376L,596L,1213L,932L,1026L,976L,1858L,750L,1180L,1144L,1910L,854L,2048L,908L,1784L,1730L,1500L,1016L,2800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106634Inst : IEnumerable<long>
{
public static readonly long[] Value=A106634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106634.Bytes);
public long this[int i]=>Value[i];

public static A106634Inst Instance=new A106634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106635
{
public static readonly long[] Value={ 5L,9L,12L,15L,17L,20L,22L,24L,27L,28L,30L,32L,34L,35L,37L,37L,39L,40L,42L,44L,45L,47L,49L,50L,52L,52L,55L,56L,57L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106635Inst : IEnumerable<long>
{
public static readonly long[] Value=A106635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106635.Bytes);
public long this[int i]=>Value[i];

public static A106635Inst Instance=new A106635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106636
{
public static readonly long[] Value={ 9L,13L,16L,19L,21L,24L,26L,28L,31L,32L,34L,36L,38L,39L,41L,41L,43L,44L,46L,48L,49L,51L,53L,54L,56L,56L,59L,60L,61L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106636Inst : IEnumerable<long>
{
public static readonly long[] Value=A106636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106636.Bytes);
public long this[int i]=>Value[i];

public static A106636Inst Instance=new A106636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106637
{
public static readonly long[] Value={ 2L,3L,5L,8L,11L,13L,14L,15L,17L,20L,21L,23L,26L,29L,31L,32L,33L,35L,38L,39L,41L,44L,47L,49L,50L,51L,53L,56L,57L,59L,62L,65L,67L,68L,69L,71L,74L,75L,77L,80L,83L,85L,86L,87L,89L,92L,93L,95L,98L,101L,103L,104L,105L,107L,110L,111L,113L,116L,119L,121L,122L,123L,125L,128L,129L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106637Inst : IEnumerable<long>
{
public static readonly long[] Value=A106637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106637.Bytes);
public long this[int i]=>Value[i];

public static A106637Inst Instance=new A106637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106638
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,3L,3L,2L,2L,3L,3L,2L,1L,2L,2L,1L,2L,3L,3L,2L,3L,1L,1L,3L,3L,1L,1L,3L,2L,3L,3L,2L,2L,3L,3L,2L,3L,1L,1L,3L,3L,1L,1L,3L,2L,3L,3L,2L,1L,2L,2L,1L,2L,3L,3L,2L,2L,3L,3L,2L,1L,2L,2L,1L,2L,3L,3L,2L,3L,1L,1L,3L,3L,1L,1L,3L,2L,3L,3L,2L,3L,1L,1L,3L,1L,2L,2L,1L,1L,2L,2L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,2L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106638Inst : IEnumerable<long>
{
public static readonly long[] Value=A106638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106638.Bytes);
public long this[int i]=>Value[i];

public static A106638Inst Instance=new A106638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106639
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,23L,29L,37L,43L,59L,61L,67L,83L,157L,173L,227L,277L,283L,317L,347L,563L,653L,733L,787L,877L,907L,997L,1213L,1237L,1283L,1307L,1523L,1867L,2083L,2693L,2797L,2803L,3253L,3413L,3517L,3643L,3677L,3733L,3803L,4253L,4363L,4547L,4723L,5387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106639Inst : IEnumerable<long>
{
public static readonly long[] Value=A106639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106639.Bytes);
public long this[int i]=>Value[i];

public static A106639Inst Instance=new A106639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A106640
{
public static readonly long[] Value={ 1L,1L,4L,11L,36L,117L,393L,1339L,4630L,16193L,57201L,203799L,731602L,2643903L,9611748L,35130195L,129018798L,475907913L,1762457595L,6550726731L,24428808690L,91377474411L,342763939656L,1289070060903L,4859587760076L,18360668311027L,69514565858653L,263693929034909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A106640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A106640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A106640Inst : IEnumerable<long>
{
public static readonly long[] Value=A106640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A106640.Bytes);
public long this[int i]=>Value[i];

public static A106640Inst Instance=new A106640Inst();

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