using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A280650
{
public static readonly long[] Value={ 0L,3L,4L,12L,16L,17L,29L,30L,31L,43L,44L,46L,48L,50L,64L,65L,68L,78L,79L,80L,102L,104L,105L,107L,108L,109L,112L,114L,116L,117L,118L,121L,127L,163L,167L,169L,170L,172L,173L,174L,175L,176L,179L,183L,186L,187L,188L,189L,191L,192L,193L,195L,196L,198L,200L,202L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280650Inst : IEnumerable<long>
{
public static readonly long[] Value=A280650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280650.Bytes);
public long this[int i]=>Value[i];

public static A280650Inst Instance=new A280650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280651
{
public static readonly long[] Value={ 1L,5L,7L,11L,18L,19L,20L,26L,27L,28L,41L,42L,45L,47L,49L,66L,67L,69L,70L,71L,72L,73L,74L,75L,76L,77L,103L,106L,110L,111L,113L,115L,119L,120L,122L,123L,124L,125L,126L,162L,164L,165L,166L,168L,171L,177L,178L,180L,181L,182L,184L,185L,190L,194L,197L,199L,201L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280651Inst : IEnumerable<long>
{
public static readonly long[] Value=A280651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280651.Bytes);
public long this[int i]=>Value[i];

public static A280651Inst Instance=new A280651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280652
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,8L,0L,12L,16L,20L,0L,18L,32L,36L,36L,0L,24L,48L,56L,60L,72L,0L,30L,62L,76L,84L,88L,104L,0L,36L,76L,104L,112L,120L,132L,140L,0L,42L,86L,130L,136L,152L,160L,184L,180L,0L,48L,100L,144L,180L,184L,192L,216L,232L,240L,0L,54L,110L,166L,210L,228L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280652Inst : IEnumerable<long>
{
public static readonly long[] Value=A280652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280652.Bytes);
public long this[int i]=>Value[i];

public static A280652Inst Instance=new A280652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280653
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,8L,0L,0L,6L,24L,0L,0L,6L,22L,40L,0L,0L,2L,20L,46L,64L,0L,0L,2L,20L,44L,70L,96L,0L,0L,2L,8L,42L,76L,98L,136L,0L,0L,2L,8L,34L,74L,104L,138L,176L,0L,0L,2L,8L,22L,72L,110L,148L,186L,208L,0L,0L,2L,4L,18L,56L,112L,146L,188L,234L,264L,0L,0L,2L,4L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280653Inst : IEnumerable<long>
{
public static readonly long[] Value=A280653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280653.Bytes);
public long this[int i]=>Value[i];

public static A280653Inst Instance=new A280653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280654
{
public static readonly BigInteger[] Value={ 1L,3L,23L,404L,9524L,357264L,16987536L,1061800704L,87631559424L,8894837836800L,1063107188812800L,151494084266803200L,BigInteger.Parse("25373057708287180800"),BigInteger.Parse("5011895098867920076800"),BigInteger.Parse("1135276451701834014720000"),BigInteger.Parse("292340783888393707192320000"),BigInteger.Parse("84048723407048386326036480000") };
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
public class A280654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280654Inst Instance=new A280654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280655
{
public static readonly BigInteger[] Value={ 0L,3L,11091L,32104739L,43189424229655L,BigInteger.Parse("110209500084824275641"),BigInteger.Parse("17401090686295157740521962087"),BigInteger.Parse("1341749054684714449837337405947519267"),BigInteger.Parse("416437630008271514606815213642830281374740126189"),BigInteger.Parse("31880038884855523088456476438831355463732624957105297113285") };
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
public class A280655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280655Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280655.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280655.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280655Inst Instance=new A280655Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280656
{
public static readonly BigInteger[] Value={ 1L,16L,32768L,67108864L,70368744177664L,BigInteger.Parse("147573952589676412928"),BigInteger.Parse("19807040628566084398385987584"),BigInteger.Parse("1329227995784915872903807060280344576"),BigInteger.Parse("365375409332725729550921208179070754913983135744"),BigInteger.Parse("25108406941546723055343157692830665664409421777856138051584") };
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
public class A280656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280656Inst Instance=new A280656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280657
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,19L,20L,29L,30L,39L,40L,49L,50L,59L,60L,69L,70L,79L,80L,89L,90L,99L,100L,109L,118L,127L,136L,145L,154L,163L,172L,181L,190L,199L,200L,209L,218L,227L,236L,245L,254L,263L,272L,281L,290L,299L,300L,309L,318L,327L,336L,345L,354L,363L,372L,381L,390L,399L,400L,409L,418L,427L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280657Inst : IEnumerable<long>
{
public static readonly long[] Value=A280657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280657.Bytes);
public long this[int i]=>Value[i];

public static A280657Inst Instance=new A280657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280658
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,91L,92L,93L,94L,95L,96L,97L,98L,99L,181L,182L,183L,184L,185L,186L,187L,188L,189L,271L,272L,273L,274L,275L,276L,277L,278L,279L,361L,362L,363L,364L,365L,366L,367L,368L,369L,451L,452L,453L,454L,455L,456L,457L,458L,459L,541L,542L,543L,544L,545L,546L,547L,548L,549L,631L,632L,633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280658Inst : IEnumerable<long>
{
public static readonly long[] Value=A280658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280658.Bytes);
public long this[int i]=>Value[i];

public static A280658Inst Instance=new A280658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280659
{
public static readonly long[] Value={ 1L,2309L,421L,1889L,841L,1469L,1261L,1049L,1681L,629L,2101L,209L,2521L,1769L,541L,2189L,121L,2609L,961L,1349L,1381L,929L,1801L,509L,2221L,89L,2641L,1649L,661L,2069L,241L,2489L,1081L,1229L,1501L,809L,1921L,389L,2341L,1949L,361L,2369L,1201L,1109L,1621L,689L,2041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280659Inst : IEnumerable<long>
{
public static readonly long[] Value=A280659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280659.Bytes);
public long this[int i]=>Value[i];

public static A280659Inst Instance=new A280659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280660
{
public static readonly long[] Value={ 12L,53L,53L,232L,93L,1862L,93L,3244L,93L,93L,93L,55754L,12864L,55756L,23353L,361353L,16441L,361353L,304362L,361353L,361353L,361353L,361353L,3748854L,3748854L,78055893L,66290232L,119133355L,119133355L,379371432L,20958353L,130883333L,20958353L,130883333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280660Inst : IEnumerable<long>
{
public static readonly long[] Value=A280660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280660.Bytes);
public long this[int i]=>Value[i];

public static A280660Inst Instance=new A280660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280709
{
public static readonly long[] Value={ 1L,3L,6L,10L,16L,24L,38L,58L,86L,122L,172L,236L,328L,448L,606L,802L,1060L,1380L,1806L,2338L,3018L,3846L,4900L,6180L,7816L,9808L,12294L,15274L,18982L,23418L,28938L,35542L,43638L,53226L,64942L,78786L,95686L,115642L,139754L,168022L,202086L,241946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280709Inst : IEnumerable<long>
{
public static readonly long[] Value=A280709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280709.Bytes);
public long this[int i]=>Value[i];

public static A280709Inst Instance=new A280709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280710
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280710Inst : IEnumerable<long>
{
public static readonly long[] Value=A280710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280710.Bytes);
public long this[int i]=>Value[i];

public static A280710Inst Instance=new A280710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280711
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280711Inst : IEnumerable<long>
{
public static readonly long[] Value=A280711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280711.Bytes);
public long this[int i]=>Value[i];

public static A280711Inst Instance=new A280711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280712
{
public static readonly long[] Value={ 2L,1L,0L,1L,0L,4L,0L,1L,0L,2L,0L,2L,0L,0L,0L,1L,0L,4L,0L,3L,0L,2L,0L,4L,0L,0L,0L,2L,0L,2L,0L,1L,0L,0L,0L,4L,0L,0L,0L,4L,0L,4L,0L,1L,0L,2L,0L,1L,0L,0L,0L,2L,0L,2L,0L,1L,0L,2L,0L,7L,0L,0L,0L,1L,0L,2L,0L,0L,0L,2L,0L,9L,0L,0L,0L,0L,0L,2L,0L,1L,0L,2L,0L,2L,0L,0L,0L,3L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280712Inst : IEnumerable<long>
{
public static readonly long[] Value=A280712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280712.Bytes);
public long this[int i]=>Value[i];

public static A280712Inst Instance=new A280712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280713
{
public static readonly BigInteger[] Value={ 1L,2L,4L,7L,31L,51L,771L,1401L,14841L,51129L,3679929L,3957129L,482958729L,927745929L,6739632009L,27172044009L,20949961932009L,22047762636009L,6424421468364009L,6728534219386089L,122581010799226089L,2444896564058746089L,BigInteger.Parse("1126445624341666426089") };
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
public class A280713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280713Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280713.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280713.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280713Inst Instance=new A280713Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280714
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,144L,2880L,2073600L,1306368000L,17557585920000L,637129677864960000L,BigInteger.Parse("2312016175036366848000000"),BigInteger.Parse("640890883720080890265600000000"),BigInteger.Parse("306987758727332698566646824960000000000"),BigInteger.Parse("136544225638605874463902854662848512000000000000") };
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
public class A280714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280714Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280714.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280714.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280714Inst Instance=new A280714Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280715
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,3L,4L,6L,7L,9L,12L,15L,19L,23L,29L,36L,44L,53L,65L,78L,94L,112L,134L,159L,189L,222L,263L,307L,361L,420L,491L,569L,661L,764L,883L,1017L,1170L,1343L,1539L,1761L,2011L,2293L,2611L,2968L,3369L,3819L,4323L,4887L,5518L,6222L,7007L,7883L,8857L,9942L,11144L,12483L,13964L,15609L,17426L,19440L,21664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280715Inst : IEnumerable<long>
{
public static readonly long[] Value=A280715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280715.Bytes);
public long this[int i]=>Value[i];

public static A280715Inst Instance=new A280715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280716
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,2L,2L,1L,3L,2L,3L,3L,3L,4L,4L,3L,5L,4L,5L,6L,4L,8L,6L,8L,8L,9L,11L,10L,11L,14L,13L,14L,15L,16L,19L,16L,20L,22L,22L,23L,26L,29L,30L,31L,35L,39L,38L,43L,44L,49L,50L,52L,58L,59L,64L,67L,71L,77L,82L,85L,93L,97L,107L,108L,117L,125L,131L,138L,143L,157L,162L,168L,179L,194L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280716Inst : IEnumerable<long>
{
public static readonly long[] Value=A280716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280716.Bytes);
public long this[int i]=>Value[i];

public static A280716Inst Instance=new A280716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280717
{
public static readonly BigInteger[] Value={ 3L,7L,43L,1693L,2864557L,8205572225569L,BigInteger.Parse("67331415548799635795058613"),BigInteger.Parse("4533519519805137360312930667312809111343819483374997"),BigInteger.Parse("20552799236454203238557860425684304712780972342513397945121797314302926172950212696842909492430773376197") };
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
public class A280717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280717Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280717.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280717.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280717Inst Instance=new A280717Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280718
{
public static readonly long[] Value={ 1L,5L,10L,10L,5L,6L,20L,30L,20L,5L,10L,30L,35L,30L,30L,30L,25L,30L,60L,60L,25L,5L,35L,80L,70L,51L,35L,50L,80L,90L,80L,30L,35L,60L,80L,95L,90L,90L,50L,75L,140L,140L,85L,20L,70L,120L,130L,120L,95L,115L,100L,115L,140L,155L,110L,40L,80L,200L,230L,140L,81L,120L,200L,190L,180L,120L,80L,100L,160L,240L,200L,155L,120L,140L,245L,260L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280718Inst : IEnumerable<long>
{
public static readonly long[] Value=A280718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280718.Bytes);
public long this[int i]=>Value[i];

public static A280718Inst Instance=new A280718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280719
{
public static readonly long[] Value={ 1L,6L,15L,20L,15L,6L,7L,30L,60L,60L,30L,6L,15L,60L,90L,66L,45L,60L,80L,90L,66L,50L,120L,180L,135L,60L,15L,60L,186L,210L,141L,126L,120L,126L,165L,180L,241L,300L,210L,90L,90L,180L,270L,270L,210L,212L,270L,270L,200L,210L,366L,450L,390L,270L,135L,210L,375L,360L,396L,420L,300L,330L,375L,380L,510L,480L,336L,450L,510L,390L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280719Inst : IEnumerable<long>
{
public static readonly long[] Value=A280719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280719.Bytes);
public long this[int i]=>Value[i];

public static A280719Inst Instance=new A280719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280720
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,3L,0L,0L,2L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,2L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280720Inst : IEnumerable<long>
{
public static readonly long[] Value=A280720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280720.Bytes);
public long this[int i]=>Value[i];

public static A280720Inst Instance=new A280720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280721
{
public static readonly long[] Value={ 5L,10L,24L,31L,81L,89L,134L,127L,255L,267L,430L,476L,744L,424L,629L,895L,1105L,1079L,1301L,1331L,1440L,2092L,1451L,2466L,2488L,2140L,3326L,2638L,2815L,3517L,4345L,4138L,4505L,4659L,5571L,6021L,5383L,5460L,6071L,6844L,8434L,7076L,8961L,10215L,7522L,9817L,11499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280721Inst : IEnumerable<long>
{
public static readonly long[] Value=A280721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280721.Bytes);
public long this[int i]=>Value[i];

public static A280721Inst Instance=new A280721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280722
{
public static readonly long[] Value={ 7L,5L,8L,2L,7L,1L,1L,5L,4L,3L,6L,8L,4L,6L,4L,0L,6L,9L,2L,3L,0L,1L,1L,4L,0L,4L,5L,5L,1L,5L,2L,1L,6L,8L,9L,1L,3L,3L,6L,4L,2L,1L,1L,0L,8L,7L,6L,3L,4L,1L,4L,6L,2L,2L,1L,4L,9L,9L,7L,2L,1L,0L,0L,1L,4L,6L,9L,6L,0L,8L,1L,6L,7L,0L,2L,6L,7L,8L,0L,4L,0L,8L,3L,8L,5L,1L,1L,0L,4L,4L,3L,9L,6L,4L,6L,3L,3L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280722Inst : IEnumerable<long>
{
public static readonly long[] Value=A280722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280722.Bytes);
public long this[int i]=>Value[i];

public static A280722Inst Instance=new A280722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280723
{
public static readonly BigInteger[] Value={ 2L,16L,384L,6144L,819200L,19660800L,7707033600L,3288334336L,14205604331520L,568224173260800L,3741775508275200L,179605224397209600L,BigInteger.Parse("135982707495615332352"),BigInteger.Parse("1410191040695270113280"),BigInteger.Parse("169222924883432413593600"),BigInteger.Parse("10830267192539674469990400"),BigInteger.Parse("1655509272671188586751590400") };
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
public class A280723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280723Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280723.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280723.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280723Inst Instance=new A280723Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280724
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,11L,13L,15L,18L,21L,24L,27L,30L,33L,36L,39L,42L,45L,48L,51L,54L,57L,60L,63L,66L,69L,73L,77L,81L,85L,89L,93L,97L,101L,105L,109L,113L,117L,121L,125L,129L,133L,137L,141L,145L,149L,153L,157L,161L,165L,169L,173L,177L,181L,185L,189L,193L,197L,201L,205L,209L,213L,217L,221L,225L,229L,233L,237L,241L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280724Inst : IEnumerable<long>
{
public static readonly long[] Value=A280724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280724.Bytes);
public long this[int i]=>Value[i];

public static A280724Inst Instance=new A280724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280773
{
public static readonly long[] Value={ 3L,5L,11L,23L,31L,73L,79L,83L,109L,127L,139L,181L,191L,193L,197L,199L,211L,241L,227L,229L,233L,239L,251L,257L,271L,263L,269L,277L,281L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280773Inst : IEnumerable<long>
{
public static readonly long[] Value=A280773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280773.Bytes);
public long this[int i]=>Value[i];

public static A280773Inst Instance=new A280773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280774
{
public static readonly long[] Value={ 1L,3L,6L,10L,13L,23L,27L,30L,34L,38L,48L,54L,62L,65L,69L,86L,90L,94L,103L,120L,127L,131L,135L,139L,144L,148L,161L,165L,185L,197L,211L,255L,258L,262L,275L,286L,290L,300L,311L,319L,330L,334L,350L,354L,358L,367L,375L,379L,399L,414L,420L,427L,443L,447L,453L,457L,465L,486L,500L,504L,530L,534L,549L,555L,559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280774Inst : IEnumerable<long>
{
public static readonly long[] Value=A280774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280774.Bytes);
public long this[int i]=>Value[i];

public static A280774Inst Instance=new A280774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280775
{
public static readonly BigInteger[] Value={ 1L,3L,11L,65L,573L,6547L,89639L,1414417L,25148617L,496416579L,10762275539L,254153371121L,6494217863461L,178558132802259L,5257524611172751L,165089697983580641L,5507950426778674129L,BigInteger.Parse("194605351254360182403"),BigInteger.Parse("7259714571747394749147"),BigInteger.Parse("285174902634083710549601") };
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
public class A280775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280775.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280775Inst Instance=new A280775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280776
{
public static readonly BigInteger[] Value={ 1L,-5L,-43L,-579L,-44477L,-5326191L,-180306541L,-203331297947L,-58726239094693L,-781618285277957L,-1025587838964854273L,BigInteger.Parse("-35763822710356866613"),BigInteger.Parse("-330773478104531041960421"),BigInteger.Parse("-237504847171108896327033959"),BigInteger.Parse("-196526060612842999084524774697"),BigInteger.Parse("-20633624138373135772483762873819") };
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
public class A280776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280776.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280776Inst Instance=new A280776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280777
{
public static readonly BigInteger[] Value={ 1L,2L,8L,16L,128L,1280L,3072L,215040L,3440640L,2293760L,137625600L,201850880L,72666316800L,1889324236800L,52901078630400L,176336928768000L,135426761293824L,191854578499584000L,1593868805996544000L,BigInteger.Parse("787371190162292736000"),BigInteger.Parse("31494847606491709440000"),BigInteger.Parse("29395191099392262144000") };
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
public class A280777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280777Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280777.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280777.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280777Inst Instance=new A280777Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280778
{
public static readonly BigInteger[] Value={ 1L,-4L,-6L,-154L,-1610L,-34588L,-4666292L,-553625626L,-1158735422L,-388434091184L,-31268175015478L,-2796356409576766L,-4624948938397276052L,BigInteger.Parse("-1691272281281652408568"),BigInteger.Parse("-2154089954877183990112"),BigInteger.Parse("-170222948041126582837968646"),BigInteger.Parse("-5761785676811885455064909606"),BigInteger.Parse("-55629298859254851627617870836") };
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
public class A280778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280778.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280778Inst Instance=new A280778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280779
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,3L,5L,45L,315L,35L,567L,2025L,7425L,467775L,6081075L,257985L,638512875L,638512875L,172297125L,13956067125L,74246277105L,3093594879375L,14992036723125L,2143861251406875L,16436269594119375L,4226469324202125L,48028060502296875L,593531957565421875L,BigInteger.Parse("56437147443285984375") };
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
public class A280779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280779.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280779Inst Instance=new A280779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280780
{
public static readonly BigInteger[] Value={ 1L,-4L,2L,-40L,-182L,-7624L,-202652L,-14115088L,-30800534L,-16435427656L,-1051314228316L,-22675483971248L,-6980651581556876L,-283099764343781072L,BigInteger.Parse("-163910651754113166328"),BigInteger.Parse("-43009695328217994139936"),BigInteger.Parse("-793529010007812171331166"),BigInteger.Parse("-20144221762701827321778088"),BigInteger.Parse("-274475989492312981198559876") };
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
public class A280780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280780Inst Instance=new A280780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280781
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,3L,15L,45L,315L,63L,2835L,14175L,22275L,467775L,1216215L,42567525L,638512875L,638512875L,834978375L,558242685L,1856156927625L,713906510625L,17717861581875L,2143861251406875L,9861761756471625L,147926426347074375L,75472666503609375L,BigInteger.Parse("48076088562799171875") };
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
public class A280781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280781Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280781.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280781.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280781Inst Instance=new A280781Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280782
{
public static readonly long[] Value={ 1L,2L,6L,15L,42L,99L,262L,633L,1592L,3897L,9697L,23767L,58804L,144541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280782Inst : IEnumerable<long>
{
public static readonly long[] Value=A280782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280782.Bytes);
public long this[int i]=>Value[i];

public static A280782Inst Instance=new A280782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280783
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,27L,51L,83L,140L,225L,369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280783Inst : IEnumerable<long>
{
public static readonly long[] Value=A280783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280783.Bytes);
public long this[int i]=>Value[i];

public static A280783Inst Instance=new A280783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280784
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,13L,9L,3L,1L,35L,26L,10L,3L,1L,95L,75L,30L,10L,3L,1L,262L,214L,91L,31L,10L,3L,1L,727L,612L,268L,95L,31L,10L,3L,1L,2033L,1747L,790L,284L,96L,31L,10L,3L,1L,5714L,4995L,2308L,848L,288L,96L,31L,10L,3L,1L,16136L,14294L,6737L,2506L,864L,289L,96L,31L,10L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280784Inst : IEnumerable<long>
{
public static readonly long[] Value=A280784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280784.Bytes);
public long this[int i]=>Value[i];

public static A280784Inst Instance=new A280784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280785
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,5L,5L,2L,1L,13L,13L,6L,2L,1L,35L,35L,16L,6L,2L,1L,95L,95L,46L,17L,6L,2L,1L,262L,262L,128L,49L,17L,6L,2L,1L,727L,727L,364L,139L,50L,17L,6L,2L,1L,2033L,2033L,1029L,401L,142L,50L,17L,6L,2L,1L,5714L,5714L,2930L,1147L,412L,143L,50L,17L,6L,2L,1L,16136L,16136L,8344L,3299L,1184L,415L,143L,50L,17L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280785Inst : IEnumerable<long>
{
public static readonly long[] Value=A280785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280785.Bytes);
public long this[int i]=>Value[i];

public static A280785Inst Instance=new A280785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280786
{
public static readonly long[] Value={ 1L,4L,15L,50L,162L,506L,1558L,4727L,14227L,42521L,126506L,374969L,1108476L,3269902L,9630631L,28328999L,83251569L,244471484L,717486860L,2104777227L,6172357873L,18096097750L,53044095421L,155464365080L,455601800970L,1335107222743L,3912330438784L,11464463809180L,33595343643160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280786Inst : IEnumerable<long>
{
public static readonly long[] Value=A280786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280786.Bytes);
public long this[int i]=>Value[i];

public static A280786Inst Instance=new A280786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280787
{
public static readonly long[] Value={ 1L,3L,1L,10L,4L,1L,30L,15L,4L,1L,91L,50L,16L,4L,1L,268L,162L,55L,16L,4L,1L,790L,506L,185L,56L,16L,4L,1L,2308L,1558L,594L,190L,56L,16L,4L,1L,6737L,4727L,1878L,617L,191L,56L,16L,4L,1L,19609L,14227L,5825L,1970L,622L,191L,56L,16L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280787Inst : IEnumerable<long>
{
public static readonly long[] Value=A280787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280787.Bytes);
public long this[int i]=>Value[i];

public static A280787Inst Instance=new A280787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280788
{
public static readonly long[] Value={ 1L,2L,6L,15L,41L,106L,284L,750L,2010L,5382L,14523L,39290L,106854L,291552L,798675L,2194828L,6051153L,16730373L,46383002L,128910484L,359115067L,1002575810L,2804667061L,7860780578L,22070885735L,62071872704L,174842835886L,493217417610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280788Inst : IEnumerable<long>
{
public static readonly long[] Value=A280788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280788.Bytes);
public long this[int i]=>Value[i];

public static A280788Inst Instance=new A280788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280837
{
public static readonly ulong[] Value={ 1L,11L,110L,1111L,11010L,111111L,1101010L,11111111L,110101010L,1111111111L,11010101110L,111111111011L,1101010100100L,11111111111110L,110101010101011L,1111111111111100L,11010101010101010L,111111111111111111L,1101010111011101000L,11111111101110111000UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280837Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A280837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280837.Bytes);
public ulong this[int i]=>Value[i];

public static A280837Inst Instance=new A280837Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280838
{
public static readonly long[] Value={ 1L,11L,11L,1111L,1011L,111111L,101011L,11111111L,10101011L,1111111111L,1110101011L,110111111111L,10010101011L,1111111111111L,110101010101011L,11111111111111L,1010101010101011L,111111111111111111L,1011101110101011L,11101110111111111L,101100010010101011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280838Inst : IEnumerable<long>
{
public static readonly long[] Value=A280838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280838.Bytes);
public long this[int i]=>Value[i];

public static A280838Inst Instance=new A280838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280839
{
public static readonly long[] Value={ 1L,3L,6L,15L,26L,63L,106L,255L,426L,1023L,1710L,4091L,6820L,16382L,27307L,65532L,109226L,262143L,437992L,1047480L,1746024L,4193944L,6990824L,16776408L,27962088L,67108824L,112126184L,268155096L,446982376L,1073658072L,1789651176L,4294719704L,7158245608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280839Inst : IEnumerable<long>
{
public static readonly long[] Value=A280839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280839.Bytes);
public long this[int i]=>Value[i];

public static A280839Inst Instance=new A280839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280840
{
public static readonly long[] Value={ 1L,3L,3L,15L,11L,63L,43L,255L,171L,1023L,939L,3583L,1195L,8191L,27307L,16383L,43691L,262143L,48043L,122367L,181419L,417791L,780971L,1785855L,3058347L,7340031L,12106667L,28433919L,48415915L,113729535L,193718955L,454836223L,774417067L,1819410431L,3097541547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280840Inst : IEnumerable<long>
{
public static readonly long[] Value=A280840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280840.Bytes);
public long this[int i]=>Value[i];

public static A280840Inst Instance=new A280840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280841
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1727L,20652479L,2059268143L,24860948333867803L,BigInteger.Parse("145905074443586569379"),BigInteger.Parse("4567419249415312673370820607"),BigInteger.Parse("1642142815363470261591271553081"),BigInteger.Parse("4093745592094627817260334517735412136353665283") };
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
public class A280841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280841Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280841.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280841.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280841Inst Instance=new A280841Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280842
{
public static readonly BigInteger[] Value={ 2L,2L,2L,3456L,41472000L,4147200000L,50185433088000000L,BigInteger.Parse("295090346557440000000"),BigInteger.Parse("9251918060437194670080000000"),BigInteger.Parse("3330690501757390081228800000000"),BigInteger.Parse("8312243866372850396258184884618526720000000000") };
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
public class A280842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280842Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280842.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280842.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280842Inst Instance=new A280842Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280843
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,0L,2L,3L,3L,6L,0L,3L,0L,0L,0L,6L,4L,0L,0L,4L,0L,0L,0L,3L,0L,7L,3L,0L,0L,7L,6L,0L,4L,8L,4L,4L,0L,0L,1L,6L,4L,2L,3L,0L,4L,0L,5L,7L,0L,10L,0L,0L,4L,0L,8L,5L,3L,0L,0L,5L,4L,2L,6L,2L,0L,4L,0L,10L,5L,8L,1L,0L,8L,0L,4L,3L,0L,9L,7L,6L,0L,10L,0L,5L,0L,0L,2L,12L,5L,6L,3L,5L,4L,7L,0L,8L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280843Inst : IEnumerable<long>
{
public static readonly long[] Value=A280843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280843.Bytes);
public long this[int i]=>Value[i];

public static A280843Inst Instance=new A280843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280844
{
public static readonly long[] Value={ 0L,0L,0L,4L,16L,20L,16L,36L,56L,60L,72L,76L,80L,100L,112L,100L,136L,124L,152L,172L,192L,196L,224L,196L,232L,236L,264L,252L,288L,276L,288L,308L,344L,332L,344L,332L,384L,388L,416L,404L,456L,428L,456L,444L,496L,468L,512L,468L,536L,556L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280844Inst : IEnumerable<long>
{
public static readonly long[] Value=A280844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280844.Bytes);
public long this[int i]=>Value[i];

public static A280844Inst Instance=new A280844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280845
{
public static readonly BigInteger[] Value={ 0L,16L,8192L,15925248L,86973087744L,1087163596800000L,BigInteger.Parse("27052109211893760000"),BigInteger.Parse("1212439465398129131520000"),BigInteger.Parse("90809637490664903729479680000"),BigInteger.Parse("10724436568372543800644091248640000"),BigInteger.Parse("1906566501044007786781171777536000000000"),BigInteger.Parse("491287106495421596910231193510320537600000000") };
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
public class A280845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280845Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A280845.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A280845.Bytes);
public BigInteger this[int i]=>Value[i];

public static A280845Inst Instance=new A280845Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280846
{
public static readonly long[] Value={ 9L,10L,16L,17L,19L,20L,21L,22L,23L,24L,26L,29L,30L,33L,34L,36L,37L,38L,39L,40L,42L,43L,44L,45L,46L,47L,48L,49L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,82L,83L,84L,86L,87L,88L,89L,90L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280846Inst : IEnumerable<long>
{
public static readonly long[] Value=A280846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280846.Bytes);
public long this[int i]=>Value[i];

public static A280846Inst Instance=new A280846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280847
{
public static readonly long[] Value={ 0L,6L,144L,47520L,664024227840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280847Inst : IEnumerable<long>
{
public static readonly long[] Value=A280847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280847.Bytes);
public long this[int i]=>Value[i];

public static A280847Inst Instance=new A280847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280848
{
public static readonly long[] Value={ 0L,1L,2L,5L,7L,8L,12L,42L,80L,91L,138L,169L,1376L,1715L,3212L,6410L,8492L,9257L,10584L,11123L,13819L,17532L,20369L,22513L,56156L,69626L,71498L,83201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280848Inst : IEnumerable<long>
{
public static readonly long[] Value=A280848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280848.Bytes);
public long this[int i]=>Value[i];

public static A280848Inst Instance=new A280848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280849
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,21L,6L,7L,27L,75L,8L,9L,33L,135L,105L,12L,10L,39L,147L,189L,315L,16L,11L,45L,165L,225L,525L,495L,20L,13L,51L,171L,297L,675L,585L,945L,24L,14L,55L,175L,351L,693L,765L,1155L,1575L,28L,15L,57L,195L,385L,735L,855L,1365L,2475L,2835L,32L,17L,63L,207L,405L,819L,1071L,1485L,2625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280849Inst : IEnumerable<long>
{
public static readonly long[] Value=A280849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280849.Bytes);
public long this[int i]=>Value[i];

public static A280849Inst Instance=new A280849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280850
{
public static readonly long[] Value={ 1L,3L,2L,2L,7L,0L,3L,3L,11L,0L,1L,4L,4L,0L,15L,0L,0L,5L,5L,3L,9L,0L,0L,9L,6L,6L,0L,0L,23L,0L,5L,0L,7L,7L,0L,0L,12L,0L,0L,12L,8L,8L,7L,0L,1L,31L,0L,0L,0L,0L,9L,9L,0L,0L,0L,35L,0L,2L,2L,0L,10L,10L,0L,0L,0L,39L,0L,0L,0L,3L,11L,11L,5L,0L,0L,5L,18L,0L,0L,18L,0L,0L,12L,12L,0L,0L,0L,0L,47L,0L,13L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280850Inst : IEnumerable<long>
{
public static readonly long[] Value=A280850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280850.Bytes);
public long this[int i]=>Value[i];

public static A280850Inst Instance=new A280850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280851
{
public static readonly long[] Value={ 1L,3L,2L,2L,7L,3L,3L,11L,1L,4L,4L,15L,5L,3L,5L,9L,9L,6L,6L,23L,5L,7L,7L,12L,12L,8L,7L,1L,8L,31L,9L,9L,35L,2L,2L,10L,10L,39L,3L,11L,5L,5L,11L,18L,18L,12L,12L,47L,13L,13L,5L,13L,21L,21L,14L,6L,6L,14L,55L,1L,15L,15L,59L,3L,7L,3L,16L,16L,63L,17L,7L,7L,17L,27L,27L,18L,9L,3L,18L,71L,10L,10L,19L,19L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280851Inst : IEnumerable<long>
{
public static readonly long[] Value=A280851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280851.Bytes);
public long this[int i]=>Value[i];

public static A280851Inst Instance=new A280851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A280852
{
public static readonly long[] Value={ 1L,9L,46L,124L,282L,712L,1738L,4124L,9562L,21752L,48730L,107992L,237082L,516376L,1117210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A280852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A280852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A280852Inst : IEnumerable<long>
{
public static readonly long[] Value=A280852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A280852.Bytes);
public long this[int i]=>Value[i];

public static A280852Inst Instance=new A280852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281046
{
public static readonly long[] Value={ 1L,2L,6L,1L,24L,7L,96L,31L,416L,223L,1248L,2079L,6016L,13951L,7168L,46079L,122880L,57343L,376832L,933887L,65536L,3866623L,950272L,13074431L,2293760L,55640063L,32292864L,171032575L,487309312L,249446399L,1187577856L,2786263039L,7543848960L,952238079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281046Inst : IEnumerable<long>
{
public static readonly long[] Value=A281046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281046.Bytes);
public long this[int i]=>Value[i];

public static A281046Inst Instance=new A281046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281047
{
public static readonly long[] Value={ 483L,525L,635L,2015L,2043L,3335L,3575L,4275L,10317L,14955L,17855L,22547L,49433L,51695L,52773L,79877L,125807L,132725L,176417L,242073L,314177L,451937L,463517L,590663L,598793L,707817L,795143L,798335L,963815L,994565L,1095465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281047Inst : IEnumerable<long>
{
public static readonly long[] Value=A281047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281047.Bytes);
public long this[int i]=>Value[i];

public static A281047Inst Instance=new A281047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281048
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-2L,1L,1L,0L,-3L,1L,2L,-1L,1L,0L,-1L,1L,-4L,1L,3L,-2L,3L,-1L,-2L,1L,1L,0L,-1L,1L,-2L,1L,1L,0L,-5L,1L,4L,-3L,5L,-2L,-3L,1L,4L,-1L,-3L,2L,-3L,1L,2L,-1L,1L,0L,-1L,1L,-2L,1L,1L,0L,-3L,1L,2L,-1L,1L,0L,-1L,1L,-6L,1L,5L,-4L,7L,-3L,-4L,1L,7L,-2L,-5L,3L,-4L,1L,3L,-2L,5L,-1L,-4L,3L,-5L,2L,3L,-1L,-4L,1L,3L,-2L,3L,-1L,-2L,1L,1L,0L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281048Inst : IEnumerable<long>
{
public static readonly long[] Value=A281048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281048.Bytes);
public long this[int i]=>Value[i];

public static A281048Inst Instance=new A281048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281049
{
public static readonly long[] Value={ 0L,1L,68L,1022L,7803L,46610L,221212L,926077L,3549039L,12749511L,43675963L,144504080L,466130380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281049Inst : IEnumerable<long>
{
public static readonly long[] Value=A281049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281049.Bytes);
public long this[int i]=>Value[i];

public static A281049Inst Instance=new A281049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281050
{
public static readonly long[] Value={ 0L,1L,6L,29L,122L,468L,1686L,5807L,19338L,62731L,199264L,622152L,1914780L,5821645L,17515566L,52221929L,154461110L,453654108L,1324053522L,3842768987L,11096398578L,31895230903L,91296545404L,260329675536L,739725018360L,2095147333465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281050Inst : IEnumerable<long>
{
public static readonly long[] Value=A281050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281050.Bytes);
public long this[int i]=>Value[i];

public static A281050Inst Instance=new A281050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281051
{
public static readonly long[] Value={ 0L,6L,68L,376L,1492L,4988L,15028L,42252L,113076L,291660L,731060L,1791052L,4306868L,10197068L,23828404L,55060556L,125999028L,285894732L,643864500L,1440442444L,3203438516L,7086237772L,15599703988L,34190878796L,74638727092L,162339448908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281051Inst : IEnumerable<long>
{
public static readonly long[] Value=A281051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281051.Bytes);
public long this[int i]=>Value[i];

public static A281051Inst Instance=new A281051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281052
{
public static readonly long[] Value={ 1L,34L,239L,1022L,3416L,10112L,27635L,71419L,177320L,426696L,1002035L,2306828L,5224307L,11669686L,25762564L,56301813L,121961820L,262154625L,559637795L,1187392495L,2505484374L,5260557953L,10995496220L,22888340830L,47465895442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281052Inst : IEnumerable<long>
{
public static readonly long[] Value=A281052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281052.Bytes);
public long this[int i]=>Value[i];

public static A281052Inst Instance=new A281052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281053
{
public static readonly long[] Value={ 2L,104L,618L,2452L,7803L,22106L,58005L,144283L,344972L,800225L,1812024L,4023754L,8791481L,18948288L,40366695L,85135873L,177990242L,369259703L,760850914L,1558181104L,3173635543L,6432024694L,12977428633L,26076680087L,52202242904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281053Inst : IEnumerable<long>
{
public static readonly long[] Value=A281053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281053.Bytes);
public long this[int i]=>Value[i];

public static A281053Inst Instance=new A281053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281054
{
public static readonly long[] Value={ 6L,251L,1403L,5400L,16875L,46610L,119205L,288527L,671451L,1515524L,3339671L,7217269L,15347530L,32196671L,66765699L,137073842L,278977066L,563443975L,1130260537L,2253558987L,4468793135L,8818038639L,17322550753L,33890757331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281054Inst : IEnumerable<long>
{
public static readonly long[] Value=A281054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281054.Bytes);
public long this[int i]=>Value[i];

public static A281054Inst Instance=new A281054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281055
{
public static readonly long[] Value={ 13L,535L,2828L,10570L,32370L,87995L,221212L,526340L,1201939L,2661939L,5752796L,12190173L,25413086L,52258597L,106216045L,213723050L,426288170L,843735147L,1658596579L,3240610144L,6297012052L,12175728717L,23437264280L,44930659786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281055Inst : IEnumerable<long>
{
public static readonly long[] Value=A281055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281055.Bytes);
public long this[int i]=>Value[i];

public static A281055Inst Instance=new A281055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281056
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,1L,6L,6L,0L,2L,34L,68L,29L,0L,6L,104L,239L,376L,122L,0L,13L,251L,618L,1022L,1492L,468L,0L,29L,535L,1403L,2452L,3416L,4988L,1686L,0L,60L,1076L,2828L,5400L,7803L,10112L,15028L,5807L,0L,122L,2090L,5482L,10570L,16875L,22106L,27635L,42252L,19338L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281056Inst : IEnumerable<long>
{
public static readonly long[] Value=A281056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281056.Bytes);
public long this[int i]=>Value[i];

public static A281056Inst Instance=new A281056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281057
{
public static readonly long[] Value={ 0L,1L,6L,34L,104L,251L,535L,1076L,2090L,3956L,7353L,13474L,24417L,43846L,78142L,138374L,243687L,427098L,745403L,1296072L,2246018L,3880504L,6686165L,11491746L,19706373L,33722458L,57596214L,98195818L,167136611L,284039674L,482013727L,816869276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281057Inst : IEnumerable<long>
{
public static readonly long[] Value=A281057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281057.Bytes);
public long this[int i]=>Value[i];

public static A281057Inst Instance=new A281057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281058
{
public static readonly long[] Value={ 0L,6L,68L,239L,618L,1403L,2828L,5482L,10342L,19136L,34907L,62976L,112617L,199929L,352771L,619208L,1081946L,1882951L,3265367L,5644772L,9730124L,16728760L,28693405L,49108842L,83882613L,143016171L,243420929L,413658928L,701916100L,1189400585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281058Inst : IEnumerable<long>
{
public static readonly long[] Value=A281058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281058.Bytes);
public long this[int i]=>Value[i];

public static A281058Inst Instance=new A281058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281059
{
public static readonly long[] Value={ 0L,29L,376L,1022L,2452L,5400L,10570L,19892L,36616L,66354L,118926L,211382L,373266L,655580L,1146156L,1995858L,3463242L,5990498L,10332426L,17775144L,30506480L,52242450L,89285638L,152311246L,259377954L,440998484L,748670868L,1269219570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281059Inst : IEnumerable<long>
{
public static readonly long[] Value=A281059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281059.Bytes);
public long this[int i]=>Value[i];

public static A281059Inst Instance=new A281059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281060
{
public static readonly long[] Value={ 0L,122L,1492L,3416L,7803L,16875L,32370L,59669L,107693L,191953L,339219L,595824L,1041681L,1814253L,3149435L,5451162L,9409735L,16202663L,27835100L,47716151L,81633286L,139397983L,237621979L,404396106L,687167939L,1165993033L,1975805797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281060Inst : IEnumerable<long>
{
public static readonly long[] Value=A281060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281060.Bytes);
public long this[int i]=>Value[i];

public static A281060Inst Instance=new A281060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281061
{
public static readonly long[] Value={ 0L,468L,4988L,10112L,22106L,46610L,87995L,159317L,282552L,495655L,864369L,1501627L,2601791L,4498333L,7762266L,13369326L,22983871L,39440039L,67556367L,115513187L,197179026L,336035590L,571793109L,971529387L,1648428839L,2793279473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281061Inst : IEnumerable<long>
{
public static readonly long[] Value=A281061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281061.Bytes);
public long this[int i]=>Value[i];

public static A281061Inst Instance=new A281061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281094
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,16L,23L,33L,47L,68L,105L,160L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281094Inst : IEnumerable<long>
{
public static readonly long[] Value=A281094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281094.Bytes);
public long this[int i]=>Value[i];

public static A281094Inst Instance=new A281094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281095
{
public static readonly ulong[] Value={ 1L,11L,100L,1100L,10100L,111110L,1000001L,11001001L,101010001L,1111111011L,10000000100L,110010000100L,1010100010100L,11111100111100L,100000000000100L,1100101000100110L,10101010000000001L,111111111000000001L,1000000000000000101L,11001000101010100111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281095Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A281095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281095.Bytes);
public ulong this[int i]=>Value[i];

public static A281095Inst Instance=new A281095Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281096
{
public static readonly ulong[] Value={ 1L,11L,1L,11L,101L,11111L,1000001L,10010011L,100010101L,1101111111L,100000001L,1000010011L,10100010101L,111100111111L,1000000000001L,110010001010011L,10000000001010101L,100000000111111111L,1010000000000000001L,11100101010100010011UL,1000101010000010101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281096Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A281096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281096.Bytes);
public ulong this[int i]=>Value[i];

public static A281096Inst Instance=new A281096Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281097
{
public static readonly long[] Value={ 1L,2L,10L,34L,146L,1036L,5692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281097Inst : IEnumerable<long>
{
public static readonly long[] Value=A281097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281097.Bytes);
public long this[int i]=>Value[i];

public static A281097Inst Instance=new A281097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281098
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,1L,3L,1L,8L,3L,5L,1L,12L,1L,7L,3L,16L,1L,9L,1L,20L,3L,11L,1L,24L,1L,13L,3L,28L,1L,15L,1L,32L,3L,17L,1L,36L,1L,19L,3L,40L,1L,21L,1L,44L,3L,23L,1L,48L,1L,25L,3L,52L,1L,27L,1L,56L,3L,29L,1L,60L,1L,31L,3L,64L,1L,33L,1L,68L,3L,35L,1L,72L,1L,37L,3L,76L,1L,39L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281098Inst : IEnumerable<long>
{
public static readonly long[] Value=A281098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281098.Bytes);
public long this[int i]=>Value[i];

public static A281098Inst Instance=new A281098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281099
{
public static readonly long[] Value={ 1L,11L,11L,1011L,11011L,1011L,111011L,11101011L,1111011L,11101011L,101111011L,1111101011L,10101111011L,111111101011L,1010101111011L,11111111101011L,100010101111011L,1001111111101011L,10001110101111011L,101110011111101011L,1100111010101111011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281099Inst : IEnumerable<long>
{
public static readonly long[] Value=A281099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281099.Bytes);
public long this[int i]=>Value[i];

public static A281099Inst Instance=new A281099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281100
{
public static readonly long[] Value={ 1L,3L,6L,13L,27L,52L,110L,215L,444L,860L,1780L,3452L,7124L,13820L,28500L,55292L,113988L,221156L,456132L,884340L,1824204L,3538480L,7298306L,14148431L,29185988L,56621092L,116773988L,226393780L,466982348L,905871348L,1868399916L,3621930932L,7471626092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281100Inst : IEnumerable<long>
{
public static readonly long[] Value=A281100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281100.Bytes);
public long this[int i]=>Value[i];

public static A281100Inst Instance=new A281100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281101
{
public static readonly long[] Value={ 1L,3L,3L,11L,27L,11L,59L,235L,123L,235L,379L,1003L,1403L,4075L,5499L,16363L,17787L,40939L,73083L,190443L,423291L,204779L,2121083L,15910891L,4707707L,9469931L,20012411L,47704043L,108344699L,201301995L,441507195L,769804267L,1843385723L,3057844203L,7378722171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281101Inst : IEnumerable<long>
{
public static readonly long[] Value=A281101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281101.Bytes);
public long this[int i]=>Value[i];

public static A281101Inst Instance=new A281101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281102
{
public static readonly ulong[] Value={ 1L,10L,101L,1000L,10100L,100010L,1010101L,10000010L,101000101L,1000101000L,10101000100L,100000101010L,1010001010101L,10001010001010L,101010001010101L,1000001010101010L,10100010000010101L,100010101000101010L,1010100000101000101L,10000010001010101010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281102Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A281102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281102.Bytes);
public ulong this[int i]=>Value[i];

public static A281102Inst Instance=new A281102Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281103
{
public static readonly BigInteger[] Value={ 1L,1L,101L,1L,101L,10001L,1010101L,1000001L,101000101L,1010001L,100010101L,10101000001L,1010101000101L,1010001010001L,101010100010101L,101010101000001L,10101000001000101L,10101000101010001L,1010001010000010101L,1010101010001000001L,BigInteger.Parse("101010000010101000101") };
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
public class A281103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281103.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A281103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281103Inst Instance=new A281103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281104
{
public static readonly long[] Value={ 1L,2L,5L,8L,20L,34L,85L,130L,325L,552L,1348L,2090L,5205L,8842L,21589L,33450L,82965L,141866L,344389L,533162L,1332245L,2263594L,5525845L,8563370L,21239125L,36317866L,88163669L,136489642L,341067093L,579513002L,1414530389L,2192050858L,5437134165L,9297341098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281104Inst : IEnumerable<long>
{
public static readonly long[] Value=A281104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281104.Bytes);
public long this[int i]=>Value[i];

public static A281104Inst Instance=new A281104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281105
{
public static readonly long[] Value={ 1L,1L,5L,1L,5L,17L,85L,65L,325L,81L,277L,1345L,5445L,5201L,21781L,21825L,86085L,86353L,332821L,349249L,1377605L,1381457L,5588245L,5592385L,22368325L,22368593L,89461781L,89478209L,357844293L,357913681L,1431307541L,1431311681L,5726294085L,5726359889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281105Inst : IEnumerable<long>
{
public static readonly long[] Value=A281105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281105.Bytes);
public long this[int i]=>Value[i];

public static A281105Inst Instance=new A281105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281106
{
public static readonly ulong[] Value={ 1L,11L,100L,1110L,10001L,111011L,1000100L,11101110L,100000001L,1110000011L,10001000100L,111011101110L,1000000010001L,11100000111011L,100010001000000L,1110111011100000L,10000000100010000L,111000001110111000L,1000100010000000100L,11101110111000001110UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281106Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A281106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281106.Bytes);
public ulong this[int i]=>Value[i];

public static A281106Inst Instance=new A281106Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281107
{
public static readonly BigInteger[] Value={ 1L,11L,1L,111L,10001L,110111L,10001L,1110111L,100000001L,1100000111L,100010001L,11101110111L,1000100000001L,11011100000111L,100010001L,11101110111L,1000100000001L,111011100000111L,10000000100010001L,1110000011101110111L,BigInteger.Parse("100010001000100000001") };
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
public class A281107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281107Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A281107.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A281107.Bytes);
public BigInteger this[int i]=>Value[i];

public static A281107Inst Instance=new A281107Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281108
{
public static readonly long[] Value={ 1L,3L,4L,14L,17L,59L,68L,238L,257L,899L,1092L,3822L,4113L,14395L,17472L,61152L,65808L,230328L,279556L,978446L,1052945L,3685307L,4473924L,15658734L,16842769L,58949691L,71581764L,250536174L,269553937L,943438779L,1145061444L,4007715054L,4312862993L,15095020475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281108Inst : IEnumerable<long>
{
public static readonly long[] Value=A281108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281108.Bytes);
public long this[int i]=>Value[i];

public static A281108Inst Instance=new A281108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281109
{
public static readonly long[] Value={ 1L,3L,1L,7L,17L,55L,17L,119L,257L,775L,273L,1911L,4353L,14087L,273L,1911L,4353L,30471L,65809L,460663L,1118465L,3634951L,1118481L,7829367L,17826049L,57673479L,17830161L,124811127L,286331137L,930576135L,285278481L,1996949367L,4581298433L,14889219847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281109Inst : IEnumerable<long>
{
public static readonly long[] Value=A281109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281109.Bytes);
public long this[int i]=>Value[i];

public static A281109Inst Instance=new A281109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281160
{
public static readonly long[] Value={ 0L,5L,40L,477L,3237L,17806L,84443L,363824L,1461206L,5575913L,20472627L,72964149L,253964856L,867114052L,2913619968L,9658923248L,31652960455L,102699696500L,330326674680L,1054362056499L,3342590109159L,10532688379736L,33008494114988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281160Inst : IEnumerable<long>
{
public static readonly long[] Value=A281160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281160.Bytes);
public long this[int i]=>Value[i];

public static A281160Inst Instance=new A281160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281161
{
public static readonly long[] Value={ 0L,18L,477L,4744L,27229L,136138L,619502L,2648442L,10801150L,42551822L,163239272L,612961308L,2261647383L,8223780452L,29535123698L,104951937704L,369520911863L,1290569244146L,4475343603756L,15421104322462L,52836768615741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281161Inst : IEnumerable<long>
{
public static readonly long[] Value=A281161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281161.Bytes);
public long this[int i]=>Value[i];

public static A281161Inst Instance=new A281161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281162
{
public static readonly long[] Value={ 0L,85L,3237L,27229L,163762L,865821L,4098895L,18213313L,76987169L,312665502L,1230221726L,4717647935L,17711793715L,65341972674L,237540919189L,852805158008L,3028838128471L,10656713673211L,37186870963633L,128821858880480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281162Inst : IEnumerable<long>
{
public static readonly long[] Value=A281162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281162.Bytes);
public long this[int i]=>Value[i];

public static A281162Inst Instance=new A281162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281163
{
public static readonly long[] Value={ 0L,346L,17806L,136138L,865821L,4716420L,22796763L,102696802L,438513869L,1799338352L,7158291149L,27787053444L,105726471706L,395690330122L,1460576127556L,5328417840400L,19243721441580L,68891667482710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281163Inst : IEnumerable<long>
{
public static readonly long[] Value=A281163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281163.Bytes);
public long this[int i]=>Value[i];

public static A281163Inst Instance=new A281163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281164
{
public static readonly long[] Value={ 0L,1388L,84443L,619502L,4098895L,22796763L,111826676L,511077328L,2213577238L,9219387478L,37243761722L,146843636089L,567586366405L,2158163009599L,8094169842566L,30006682413781L,110139856305082L,400800296115796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281164Inst : IEnumerable<long>
{
public static readonly long[] Value=A281164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281164.Bytes);
public long this[int i]=>Value[i];

public static A281164Inst Instance=new A281164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281165
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,5L,5L,0L,0L,18L,40L,18L,0L,0L,85L,477L,477L,85L,0L,0L,346L,3237L,4744L,3237L,346L,0L,0L,1388L,17806L,27229L,27229L,17806L,1388L,0L,0L,5454L,84443L,136138L,163762L,136138L,84443L,5454L,0L,0L,21171L,363824L,619502L,865821L,865821L,619502L,363824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281165Inst : IEnumerable<long>
{
public static readonly long[] Value=A281165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281165.Bytes);
public long this[int i]=>Value[i];

public static A281165Inst Instance=new A281165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281166
{
public static readonly long[] Value={ 1L,1L,3L,8L,17L,33L,64L,127L,255L,512L,1025L,2049L,4096L,8191L,16383L,32768L,65537L,131073L,262144L,524287L,1048575L,2097152L,4194305L,8388609L,16777216L,33554431L,67108863L,134217728L,268435457L,536870913L,1073741824L,2147483647L,4294967295L,8589934592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281166Inst : IEnumerable<long>
{
public static readonly long[] Value=A281166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281166.Bytes);
public long this[int i]=>Value[i];

public static A281166Inst Instance=new A281166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281167
{
public static readonly long[] Value={ 1L,2L,6L,7L,14L,22L,31L,33L,42L,51L,799L,934L,1996L,3372L,3570L,3883L,4417L,4747L,4965L,5055L,5647L,7183L,19702L,42124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281167Inst : IEnumerable<long>
{
public static readonly long[] Value=A281167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281167.Bytes);
public long this[int i]=>Value[i];

public static A281167Inst Instance=new A281167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A281168
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,18L,22L,25L,38L,40L,154L,256L,282L,318L,640L,1095L,1126L,1214L,2588L,5616L,13159L,17644L,18631L,66714L,75465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A281168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A281168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A281168Inst : IEnumerable<long>
{
public static readonly long[] Value=A281168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A281168.Bytes);
public long this[int i]=>Value[i];

public static A281168Inst Instance=new A281168Inst();

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