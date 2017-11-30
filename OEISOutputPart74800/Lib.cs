using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A242419
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,11L,18L,13L,35L,10L,16L,17L,12L,19L,75L,21L,77L,23L,54L,25L,143L,27L,245L,29L,30L,31L,32L,55L,221L,14L,36L,37L,323L,91L,375L,41L,105L,43L,847L,50L,437L,47L,162L,49L,45L,187L,1859L,53L,24L,33L,1715L,247L,667L,59L,150L,61L,899L,147L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242419Inst : IEnumerable<long>
{
public static readonly long[] Value=A242419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242419.Bytes);
public long this[int i]=>Value[i];

public static A242419Inst Instance=new A242419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242420
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,15L,11L,12L,13L,35L,10L,16L,17L,18L,19L,45L,21L,77L,23L,24L,25L,143L,27L,175L,29L,30L,31L,32L,55L,221L,14L,36L,37L,323L,91L,135L,41L,105L,43L,539L,20L,437L,47L,48L,49L,75L,187L,1573L,53L,54L,33L,875L,247L,667L,59L,90L,61L,899L,63L,64L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242420Inst : IEnumerable<long>
{
public static readonly long[] Value=A242420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242420.Bytes);
public long this[int i]=>Value[i];

public static A242420Inst Instance=new A242420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242421
{
public static readonly long[] Value={ 1L,2L,6L,9L,30L,45L,50L,125L,210L,294L,315L,350L,441L,686L,875L,2310L,2401L,3234L,3465L,3630L,3850L,4851L,5445L,6050L,7546L,7986L,9625L,11979L,15125L,26411L,29282L,30030L,35490L,42042L,45045L,47190L,49686L,50050L,53235L,59150L,63063L,65910L,70785L,74529L,78650L,98098L,98865L,103818L,109850L,115934L,125125L,147875L,155727L,161051L,171366L,196625L,257049L,274625L,343343L,380666L,405769L,510510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242421Inst : IEnumerable<long>
{
public static readonly long[] Value=A242421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242421.Bytes);
public long this[int i]=>Value[i];

public static A242421Inst Instance=new A242421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242422
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,13L,21L,22L,25L,27L,28L,29L,30L,36L,40L,46L,47L,48L,57L,64L,73L,76L,85L,86L,91L,102L,107L,117L,121L,123L,130L,136L,142L,147L,151L,154L,156L,164L,165L,175L,185L,189L,196L,197L,198L,201L,206L,208L,210L,217L,220L,222L,225L,243L,250L,252L,257L,264L,268L,270L,279L,280L,296L,298L,299L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242422Inst : IEnumerable<long>
{
public static readonly long[] Value=A242422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242422.Bytes);
public long this[int i]=>Value[i];

public static A242422Inst Instance=new A242422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242423
{
public static readonly long[] Value={ 3L,4L,7L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,23L,24L,26L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,74L,75L,77L,78L,79L,80L,81L,82L,83L,84L,87L,88L,89L,90L,92L,93L,94L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242423Inst : IEnumerable<long>
{
public static readonly long[] Value=A242423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242423.Bytes);
public long this[int i]=>Value[i];

public static A242423Inst Instance=new A242423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242424
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,6L,10L,5L,12L,9L,14L,10L,22L,15L,18L,7L,26L,20L,34L,15L,30L,21L,38L,14L,27L,33L,40L,25L,46L,30L,58L,11L,42L,39L,45L,28L,62L,51L,66L,21L,74L,50L,82L,35L,60L,57L,86L,22L,75L,45L,78L,55L,94L,56L,63L,35L,102L,69L,106L,42L,118L,87L,100L,13L,99L,70L,122L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242424Inst : IEnumerable<long>
{
public static readonly long[] Value=A242424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242424.Bytes);
public long this[int i]=>Value[i];

public static A242424Inst Instance=new A242424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242425
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,2L,2L,1L,2L,3L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,3L,3L,3L,3L,3L,2L,4L,2L,1L,4L,3L,4L,4L,3L,4L,2L,2L,2L,8L,2L,2L,2L,6L,5L,1L,4L,2L,5L,3L,3L,1L,2L,6L,4L,4L,2L,3L,3L,3L,5L,2L,3L,2L,5L,5L,4L,8L,4L,2L,7L,2L,4L,5L,5L,3L,4L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242425Inst : IEnumerable<long>
{
public static readonly long[] Value=A242425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242425.Bytes);
public long this[int i]=>Value[i];

public static A242425Inst Instance=new A242425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242426
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,3L,14L,78L,497L,3628L,29990L,277200L,2834328L,31770514L,387459072L,5108103000L,72397196844L,1097800704000L,17735107218083L,304112751022080L,5516784599040000L,105559797875432727L,2124765080865042873L,BigInteger.Parse("44881973505008640000"),BigInteger.Parse("992717442773183102976") };
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
public class A242426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242426Inst Instance=new A242426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242427
{
public static readonly long[] Value={ 0L,2L,6L,24L,120L,72L,238L,384L,567L,800L,110L,0L,2184L,784L,0L,0L,1428L,0L,703L,0L,0L,2904L,4209L,0L,0L,13520L,0L,0L,15109L,0L,18228L,0L,0L,30056L,0L,0L,9546L,14440L,0L,0L,26855L,0L,23994L,0L,0L,25392L,13207L,0L,0L,0L,0L,0L,95453L,0L,0L,0L,0L,148016L,93928L,0L,208315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242427Inst : IEnumerable<long>
{
public static readonly long[] Value=A242427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242427.Bytes);
public long this[int i]=>Value[i];

public static A242427Inst Instance=new A242427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242428
{
public static readonly BigInteger[] Value={ 0L,2L,17L,180L,3298L,88431L,3064050L,130905678L,6732227475L,409094032964L,28917250469178L,2346562701385648L,216180120430479731L,BigInteger.Parse("22397392442055209003"),BigInteger.Parse("2588479398843886168171"),BigInteger.Parse("331352273262513644199134"),BigInteger.Parse("46692196905193286953380160"),BigInteger.Parse("7203294536351261350956567853"),BigInteger.Parse("1210694223244114528129261255186") };
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
public class A242428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242428Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242428.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242428.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242428Inst Instance=new A242428Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242429
{
public static readonly long[] Value={ 1L,5L,17L,53L,167L,550L,1899L,6809L,25067L,93902L,355775L,1358208L,5212573L,20082860L,77607895L,300638481L,1166999699L,4537960846L,17673418311L,68924837252L,269132082925L,1052055773292L,4116727946687L,16123827007348L,63205353550497L,247959367137320L,973469914150619L,3824345703033374L,15033634055076857L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242429Inst : IEnumerable<long>
{
public static readonly long[] Value=A242429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242429.Bytes);
public long this[int i]=>Value[i];

public static A242429Inst Instance=new A242429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242430
{
public static readonly long[] Value={ 2L,6L,7L,7L,8L,6L,8L,4L,0L,2L,1L,7L,8L,8L,9L,1L,1L,2L,3L,7L,6L,6L,7L,1L,4L,0L,3L,5L,8L,4L,3L,0L,2L,5L,5L,2L,5L,5L,5L,0L,5L,9L,8L,9L,7L,9L,9L,3L,4L,8L,4L,5L,3L,2L,0L,7L,6L,3L,1L,1L,8L,8L,8L,5L,1L,1L,2L,1L,4L,9L,3L,7L,7L,8L,5L,2L,3L,2L,7L,6L,2L,8L,5L,3L,5L,4L,4L,7L,6L,2L,2L,3L,8L,5L,6L,1L,3L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242430Inst : IEnumerable<long>
{
public static readonly long[] Value=A242430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242430.Bytes);
public long this[int i]=>Value[i];

public static A242430Inst Instance=new A242430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242431
{
public static readonly long[] Value={ 1L,2L,1L,5L,3L,1L,14L,10L,4L,1L,43L,35L,17L,5L,1L,144L,128L,74L,26L,6L,1L,523L,491L,329L,137L,37L,7L,1L,2048L,1984L,1498L,730L,230L,50L,8L,1L,8597L,8469L,7011L,3939L,1439L,359L,65L,9L,1L,38486L,38230L,33856L,21568L,9068L,2588L,530L,82L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242431Inst : IEnumerable<long>
{
public static readonly long[] Value=A242431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242431.Bytes);
public long this[int i]=>Value[i];

public static A242431Inst Instance=new A242431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242496
{
public static readonly long[] Value={ 0L,1L,7L,23L,72L,204L,564L,1521L,4059L,10747L,28336L,74504L,195576L,512865L,1344063L,3521007L,9221688L,24148468L,63230860L,165555665L,433454835L,1134839091L,2971111392L,7778574288L,20364739632L,53315851969L,139583151799L,365434146311L,956720165544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242496Inst : IEnumerable<long>
{
public static readonly long[] Value=A242496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242496.Bytes);
public long this[int i]=>Value[i];

public static A242496Inst Instance=new A242496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242497
{
public static readonly long[] Value={ 3L,4L,5L,13L,14L,15L,51L,52L,53L,193L,194L,195L,723L,724L,725L,2701L,2702L,2703L,10083L,10084L,10085L,37633L,37634L,37635L,140451L,140452L,140453L,524173L,524174L,524175L,1956243L,1956244L,1956245L,7300801L,7300802L,7300803L,27246963L,27246964L,27246965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242497Inst : IEnumerable<long>
{
public static readonly long[] Value=A242497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242497.Bytes);
public long this[int i]=>Value[i];

public static A242497Inst Instance=new A242497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242498
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,2L,1L,0L,1L,1L,1L,0L,3L,2L,0L,1L,3L,4L,1L,4L,3L,0L,1L,1L,2L,1L,6L,9L,3L,5L,4L,0L,1L,4L,9L,6L,11L,16L,6L,6L,5L,0L,1L,1L,3L,3L,11L,24L,18L,19L,25L,10L,7L,6L,0L,1L,5L,16L,18L,28L,51L,40L,31L,36L,15L,8L,7L,0L,1L,1L,4L,6L,19L,51L,60L,65L,95L,75L,48L,49L,21L,9L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242498Inst : IEnumerable<long>
{
public static readonly long[] Value=A242498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242498.Bytes);
public long this[int i]=>Value[i];

public static A242498Inst Instance=new A242498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242499
{
public static readonly long[] Value={ 1L,0L,1L,3L,1L,9L,11L,18L,51L,65L,151L,290L,477L,1043L,1835L,3486L,6931L,12540L,24607L,46797L,87979L,171072L,323269L,619245L,1190619L,2264925L,4357211L,8343322L,15973309L,30711853L,58846191L,113027716L,217192103L,416964202L,801880039L,1541412015L,2963997227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242499Inst : IEnumerable<long>
{
public static readonly long[] Value=A242499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242499.Bytes);
public long this[int i]=>Value[i];

public static A242499Inst Instance=new A242499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242500
{
public static readonly long[] Value={ 1L,0L,2L,4L,3L,16L,19L,40L,95L,136L,321L,588L,1057L,2240L,3998L,7848L,15339L,28464L,56143L,106788L,204083L,396704L,755052L,1457456L,2806531L,5377112L,10382243L,19947252L,38382957L,73996576L,142311198L,274283168L,528438319L,1017784016L,1962451118L,3781912684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242500Inst : IEnumerable<long>
{
public static readonly long[] Value=A242500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242500.Bytes);
public long this[int i]=>Value[i];

public static A242500Inst Instance=new A242500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242501
{
public static readonly long[] Value={ 1L,0L,3L,5L,6L,25L,31L,75L,162L,259L,609L,1106L,2122L,4410L,8076L,16197L,31527L,59961L,118844L,227700L,441507L,860860L,1654731L,3218501L,6226818L,12027405L,23337471L,45082050L,87258876L,168935018L,326536646L,632132760L,1222716653L,2364969824L,4576680195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242501Inst : IEnumerable<long>
{
public static readonly long[] Value=A242501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242501.Bytes);
public long this[int i]=>Value[i];

public static A242501Inst Instance=new A242501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242502
{
public static readonly long[] Value={ 1L,0L,4L,6L,10L,36L,48L,126L,259L,456L,1064L,1956L,3939L,8112L,15300L,31174L,60951L,118580L,236456L,458172L,900185L,1765556L,3431792L,6728410L,13107393L,25538448L,49856392L,96966572L,188914574L,367741688L,715053048L,1391512424L,2705016795L,5258241032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242502Inst : IEnumerable<long>
{
public static readonly long[] Value=A242502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242502.Bytes);
public long this[int i]=>Value[i];

public static A242502Inst Instance=new A242502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242503
{
public static readonly long[] Value={ 1L,0L,5L,7L,15L,49L,71L,196L,394L,753L,1746L,3285L,6865L,14124L,27445L,56661L,111892L,222222L,446524L,876876L,1744353L,3448783L,6782633L,13411528L,26346074L,51799306L,101840098L,199601828L,391637976L,767247094L,1501758784L,2939789022L,5747749147L,11235696151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242503Inst : IEnumerable<long>
{
public static readonly long[] Value=A242503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242503.Bytes);
public long this[int i]=>Value[i];

public static A242503Inst Instance=new A242503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242504
{
public static readonly long[] Value={ 1L,0L,6L,8L,21L,64L,101L,288L,576L,1180L,2727L,5280L,11363L,23496L,46981L,98176L,196482L,397644L,806351L,1606488L,3234335L,6456048L,12849330L,25637632L,50835950L,100883304L,199903578L,395067760L,781029504L,1540973568L,3037666097L,5984978112L,11775884581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242504Inst : IEnumerable<long>
{
public static readonly long[] Value=A242504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242504.Bytes);
public long this[int i]=>Value[i];

public static A242504Inst Instance=new A242504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242505
{
public static readonly long[] Value={ 1L,0L,7L,9L,28L,81L,139L,405L,815L,1771L,4092L,8173L,18019L,37609L,77246L,163345L,331968L,683631L,1400777L,2832362L,5770056L,11640546L,23446366L,47227530L,94582628L,189487950L,378658714L,754877809L,1504215522L,2990469337L,5939101301L,11782590061L,23340439078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242505Inst : IEnumerable<long>
{
public static readonly long[] Value=A242505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242505.Bytes);
public long this[int i]=>Value[i];

public static A242505Inst Instance=new A242505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242506
{
public static readonly long[] Value={ 1L,0L,8L,10L,36L,100L,186L,550L,1122L,2564L,5940L,12246L,27560L,58240L,122642L,262458L,542243L,1134944L,2352136L,4826980L,9949352L,20300312L,41377116L,84172508L,170322099L,344527304L,694617960L,1397219682L,2807142612L,5625453196L,11258808682L,22498804286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242506Inst : IEnumerable<long>
{
public static readonly long[] Value=A242506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242506.Bytes);
public long this[int i]=>Value[i];

public static A242506Inst Instance=new A242506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242507
{
public static readonly long[] Value={ 1L,0L,9L,11L,45L,121L,243L,726L,1509L,3601L,8385L,17836L,40873L,87633L,188855L,409116L,859674L,1827160L,3832786L,7981398L,16644666L,34362355L,70866846L,145637147L,297814569L,608309130L,1237764177L,2512564769L,5090761029L,10286177231L,20750532587L,41778968976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242507Inst : IEnumerable<long>
{
public static readonly long[] Value=A242507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242507.Bytes);
public long this[int i]=>Value[i];

public static A242507Inst Instance=new A242507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242508
{
public static readonly long[] Value={ 1L,0L,10L,12L,55L,144L,311L,936L,1989L,4928L,11557L,25340L,59025L,128576L,283100L,620976L,1327258L,2862528L,6080645L,12845064L,27102284L,56625624L,118144679L,245331648L,507035957L,1045854240L,2148159266L,4400962876L,8993987459L,18326508928L,37269909849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242508Inst : IEnumerable<long>
{
public static readonly long[] Value=A242508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242508.Bytes);
public long this[int i]=>Value[i];

public static A242508Inst Instance=new A242508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242509
{
public static readonly long[] Value={ 1L,5L,24L,115L,550L,2631L,12584L,60191L,287901L,1377066L,6586677L,31504891L,150691790L,720777469L,3447567781L,16490143094L,78874393932L,377265981421L,1804509849677L,8631193794141L,41284067429916L,197466800561799L,944508129929499L,4517699202928696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242509Inst : IEnumerable<long>
{
public static readonly long[] Value=A242509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242509.Bytes);
public long this[int i]=>Value[i];

public static A242509Inst Instance=new A242509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242510
{
public static readonly long[] Value={ 1L,2L,3L,8L,15L,32L,67L,138L,289L,600L,1249L,2600L,5409L,11258L,23427L,48752L,101455L,211128L,439363L,914322L,1902721L,3959600L,8240001L,17147600L,35684481L,74260082L,154536643L,321593688L,669242575L,1392706512L,2898248707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242510Inst : IEnumerable<long>
{
public static readonly long[] Value=A242510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242510.Bytes);
public long this[int i]=>Value[i];

public static A242510Inst Instance=new A242510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242511
{
public static readonly long[] Value={ 1L,1L,2L,6L,28L,100L,330L,1050L,3024L,8736L,23220L,62700L,158004L,406692L,986986L,2452450L,5788640L,14002560L,32357052L,76640148L,174174520L,405623400L,909582212L,2089064516L,4633556448L,10519464000L,23120533800L,51977741400L,113365499940L,252725219460L,547593359850L,1211884139250L,2610998927040L,5741708459520L,12309472580460L,26917328938500L,57457069777800L,125016198060600L,265832233972140L,575824335603660L,1220234181784800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242511Inst : IEnumerable<long>
{
public static readonly long[] Value=A242511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242511.Bytes);
public long this[int i]=>Value[i];

public static A242511Inst Instance=new A242511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242576
{
public static readonly BigInteger[] Value={ 13L,151L,277L,36313L,225949L,7129366889L,933784181621L,BigInteger.Parse("19397107178326126131136629644898891137047"),BigInteger.Parse("401151570474397232184569825031979125080583558010764826781295643008140597581801") };
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
public class A242576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242576.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242576Inst Instance=new A242576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242577
{
public static readonly long[] Value={ 7L,35L,159L,723L,3453L,17634L,96472L,563256L,3492837L,22901243L,158134009L,1145995500L,8690227115L,68774540753L,566710394107L,4852093593696L,43084515133226L,396100229113680L,3764573877643410L,36935721134238873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242577Inst : IEnumerable<long>
{
public static readonly long[] Value=A242577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242577.Bytes);
public long this[int i]=>Value[i];

public static A242577Inst Instance=new A242577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242578
{
public static readonly long[] Value={ 13L,35L,97L,271L,757L,2115L,5913L,16535L,46237L,129291L,361537L,1010975L,2827013L,7905235L,22105577L,61814311L,172852717L,483351835L,1351607313L,3779529135L,10568780117L,29553711331L,82641690297L,231092768695L,646209770813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242578Inst : IEnumerable<long>
{
public static readonly long[] Value=A242578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242578.Bytes);
public long this[int i]=>Value[i];

public static A242578Inst Instance=new A242578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242579
{
public static readonly long[] Value={ 14L,45L,159L,587L,2209L,8391L,32020L,122439L,468605L,1794215L,6871124L,26316013L,100792856L,386053397L,1478661408L,5663590035L,21692801897L,83088294355L,318246913929L,1218957694705L,4668884168508L,17882884906745L,68495504779439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242579Inst : IEnumerable<long>
{
public static readonly long[] Value=A242579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242579.Bytes);
public long this[int i]=>Value[i];

public static A242579Inst Instance=new A242579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242580
{
public static readonly long[] Value={ 14L,46L,174L,723L,3192L,14648L,68819L,327821L,1574161L,7594177L,36734890L,177970751L,862989003L,4186822990L,20318525824L,98621961836L,478737668736L,2324053123861L,11282584749066L,54774608227458L,265922223475021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242580Inst : IEnumerable<long>
{
public static readonly long[] Value=A242580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242580.Bytes);
public long this[int i]=>Value[i];

public static A242580Inst Instance=new A242580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242581
{
public static readonly long[] Value={ 14L,46L,175L,744L,3453L,17178L,90033L,489821L,2734513L,15534111L,89271482L,516935609L,3008249095L,17562798942L,102750973652L,601965097333L,3529737223262L,20709247799845L,121548480504365L,713577294998844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242581Inst : IEnumerable<long>
{
public static readonly long[] Value=A242581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242581.Bytes);
public long this[int i]=>Value[i];

public static A242581Inst Instance=new A242581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242582
{
public static readonly long[] Value={ 14L,46L,175L,745L,3481L,17634L,95729L,550503L,3316400L,20716789L,133010422L,871426139L,5793393075L,38920526974L,263416849112L,1792161569676L,12237842678789L,83782031880589L,574620337324485L,3946034125700132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242582Inst : IEnumerable<long>
{
public static readonly long[] Value=A242582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242582.Bytes);
public long this[int i]=>Value[i];

public static A242582Inst Instance=new A242582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242583
{
public static readonly long[] Value={ 14L,46L,175L,745L,3482L,17670L,96472L,562109L,3469255L,22511261L,152416564L,1068885011L,7711216523L,56883599674L,426892077104L,3245855512924L,24923815228380L,192793238658181L,1499479762818409L,11709699180354092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242583Inst : IEnumerable<long>
{
public static readonly long[] Value=A242583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242583.Bytes);
public long this[int i]=>Value[i];

public static A242583Inst Instance=new A242583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242584
{
public static readonly long[] Value={ 7L,13L,12L,14L,35L,21L,14L,45L,97L,37L,14L,46L,159L,271L,65L,14L,46L,174L,587L,757L,114L,14L,46L,175L,723L,2209L,2115L,200L,14L,46L,175L,744L,3192L,8391L,5913L,351L,14L,46L,175L,745L,3453L,14648L,32020L,16535L,616L,14L,46L,175L,745L,3481L,17178L,68819L,122439L,46237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242584Inst : IEnumerable<long>
{
public static readonly long[] Value=A242584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242584.Bytes);
public long this[int i]=>Value[i];

public static A242584Inst Instance=new A242584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242585
{
public static readonly long[] Value={ 1L,9L,9L,45L,9L,405L,15L,189L,81L,729L,27L,6075L,27L,1215L,2025L,729L,81L,45927L,27L,32805L,2025L,6561L,81L,229635L,243L,2187L,2187L,18225L,9L,7381125L,243L,24057L,2187L,19683L,3645L,6200145L,729L,19683L,19683L,1240029L,81L,22143375L,243L,295245L,492075L,19683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242585Inst : IEnumerable<long>
{
public static readonly long[] Value=A242585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242585.Bytes);
public long this[int i]=>Value[i];

public static A242585Inst Instance=new A242585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242586
{
public static readonly long[] Value={ 1L,2L,6L,23L,98L,437L,1995L,9242L,43258L,204053L,968441L,4619012L,22120631L,106300508L,512321438L,2475395303L,11986728458L,58156146653L,282640193313L,1375737276788L,6705522150973L,32724071280518L,159878425878848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242586Inst : IEnumerable<long>
{
public static readonly long[] Value=A242586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242586.Bytes);
public long this[int i]=>Value[i];

public static A242586Inst Instance=new A242586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242587
{
public static readonly long[] Value={ 1L,3L,12L,39L,129L,399L,1245L,3783L,11514L,34734L,104754L,314922L,946623L,2842077L,8532147L,25603788L,76830033L,230513439L,691598901L,2074870002L,6224790639L,18674600664L,56024355396L,168073769199L,504222998115L,1512671142432L,4538018555652L,13614062210490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242587Inst : IEnumerable<long>
{
public static readonly long[] Value=A242587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242587.Bytes);
public long this[int i]=>Value[i];

public static A242587Inst Instance=new A242587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242588
{
public static readonly long[] Value={ 1L,8L,8L,2L,3L,1L,2L,6L,4L,4L,3L,8L,9L,6L,6L,0L,1L,6L,0L,1L,0L,5L,6L,0L,0L,8L,3L,8L,8L,6L,8L,3L,6L,7L,5L,8L,7L,8L,5L,2L,4L,6L,2L,8L,8L,0L,3L,1L,0L,7L,0L,7L,9L,6L,0L,5L,5L,2L,9L,3L,2L,3L,1L,4L,5L,7L,7L,2L,1L,0L,3L,7L,9L,6L,1L,0L,6L,0L,3L,5L,8L,1L,2L,7L,2L,3L,9L,9L,9L,9L,1L,4L,8L,4L,5L,6L,2L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242588Inst : IEnumerable<long>
{
public static readonly long[] Value=A242588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242588.Bytes);
public long this[int i]=>Value[i];

public static A242588Inst Instance=new A242588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242589
{
public static readonly long[] Value={ 5L,19L,37L,43L,97L,107L,6091L,6389L,7121L,21727L,147107L,148151L,148279L,148429L,148469L,172877L,173209L,173741L,2621387L,5642293L,5642321L,8932771L,8981827L,8981879L,9094979L,9095089L,9997783L,10010687L,10010789L,10037749L,10144523L,40179929L,40365217L,40379077L,40379197L,40386811L,40612933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242589Inst : IEnumerable<long>
{
public static readonly long[] Value=A242589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242589.Bytes);
public long this[int i]=>Value[i];

public static A242589Inst Instance=new A242589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242590
{
public static readonly long[] Value={ 1L,2L,3L,9L,10L,11L,12L,13L,19L,20L,21L,22L,23L,29L,30L,31L,32L,33L,39L,90L,91L,92L,93L,99L,100L,101L,102L,103L,109L,110L,111L,112L,113L,119L,120L,121L,122L,123L,129L,130L,131L,132L,133L,139L,190L,191L,192L,193L,199L,200L,201L,202L,203L,209L,210L,211L,212L,213L,219L,220L,221L,222L,223L,229L,230L,231L,232L,233L,239L,290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242590Inst : IEnumerable<long>
{
public static readonly long[] Value=A242590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242590.Bytes);
public long this[int i]=>Value[i];

public static A242590Inst Instance=new A242590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242591
{
public static readonly long[] Value={ 1L,12L,2L,2L,1L,54L,6L,2L,9L,2L,2L,6L,1L,3L,32L,6L,28L,6L,24L,3L,8L,24L,3L,18L,1L,12L,85L,6L,100L,16L,95L,12L,60L,4L,25L,240L,6L,70L,4L,50L,1L,30L,201L,10L,60L,40L,330L,35L,266L,20L,150L,5L,66L,588L,20L,210L,10L,180L,5L,120L,1L,60L,462L,15L,147L,1512L,1050L,90L,952L,66L,672L,30L,357L,6L,147L,1344L,35L,336L,20L,546L,15L,420L,6L,252L,1L,105L,1044L,21L,336L,3564L,70L,210L,3024L,182L,2464L,112L,1576L,42L,784L,7L,288L,2970L,56L,756L,8700L,1456L,35L,1288L,21L,896L,7L,476L,1L,168L,2277L,28L,702L,7965L,126L,1680L,8736L,448L,7938L,336L,5868L,176L,3453L,56L,1584L,8L,513L,6390L,84L,1620L,19965L,252L,70L,3528L,56L,2808L,28L,1764L,8L,828L,1L,252L,4720L,36L,1350L,17182L,210L,3630L,47124L,1008L,23220L,882L,19260L,576L,13050L,261L,7090L,72L,2970L,9L,850L,13310L,120L,3267L,43824L,462L,7920L,8820L,126L,7920L,84L,5715L,36L,3240L,9L,1350L,1L,360L,9251L,45L,2420L,35970L,330L,7524L,105963L,924L,62700L,2100L,57387L,1620L,43725L,930L,27335L,370L,13706L,90L,5225L,10L,1331L,26664L,165L,6204L,92950L,792L,16731L,244244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242591Inst : IEnumerable<long>
{
public static readonly long[] Value=A242591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242591.Bytes);
public long this[int i]=>Value[i];

public static A242591Inst Instance=new A242591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242640
{
public static readonly long[] Value={ 1L,3L,5L,4L,7L,10L,7L,13L,17L,21L,6L,11L,16L,21L,26L,12L,23L,32L,38L,44L,50L,8L,15L,22L,29L,36L,43L,50L,15L,29L,41L,53L,61L,69L,77L,85L,13L,25L,37L,46L,55L,64L,73L,82L,91L,18L,35L,50L,65L,80L,90L,100L,110L,120L,130L,12L,23L,34L,45L,56L,67L,78L,89L,100L,111L,122L,28L,55L,80L,102L,120L,138L,150L,162L,174L,186L,198L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242640Inst : IEnumerable<long>
{
public static readonly long[] Value=A242640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242640.Bytes);
public long this[int i]=>Value[i];

public static A242640Inst Instance=new A242640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242641
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,3L,5L,5L,1L,1L,3L,6L,10L,7L,1L,1L,3L,6L,12L,16L,11L,1L,1L,3L,6L,13L,21L,29L,15L,1L,1L,3L,6L,13L,23L,40L,45L,22L,1L,1L,3L,6L,13L,24L,45L,67L,75L,30L,1L,1L,3L,6L,13L,24L,47L,78L,117L,115L,42L,1L,1L,3L,6L,13L,24L,48L,83L,141L,193L,181L,56L,1L,1L,3L,6L,13L,24L,48L,85L,152L,239L,319L,271L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242641Inst : IEnumerable<long>
{
public static readonly long[] Value=A242641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242641.Bytes);
public long this[int i]=>Value[i];

public static A242641Inst Instance=new A242641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242642
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,5L,10L,12L,13L,7L,16L,21L,23L,24L,11L,29L,40L,45L,47L,48L,15L,45L,67L,78L,83L,85L,86L,22L,75L,117L,141L,152L,157L,159L,160L,30L,115L,193L,239L,263L,274L,279L,281L,282L,42L,181L,319L,409L,457L,481L,492L,497L,499L,500L,56L,271L,510L,674L,768L,816L,840L,851L,856L,858L,859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242642Inst : IEnumerable<long>
{
public static readonly long[] Value=A242642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242642.Bytes);
public long this[int i]=>Value[i];

public static A242642Inst Instance=new A242642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242643
{
public static readonly long[] Value={ 1L,5L,10L,21L,26L,50L,43L,69L,64L,90L,67L,138L,79L,131L,125L,165L,103L,212L,115L,226L,178L,203L,139L,330L,176L,239L,226L,315L,175L,405L,187L,357L,274L,311L,278L,516L,223L,347L,322L,514L,247L,554L,259L,483L,449L,419L,283L,714L,337L,540L,418L,567L,319L,698L,422L,699L,466L,527L,355L,973L,367L,563L,610L,741L,494L,842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242643Inst : IEnumerable<long>
{
public static readonly long[] Value=A242643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242643.Bytes);
public long this[int i]=>Value[i];

public static A242643Inst Instance=new A242643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242644
{
public static readonly long[] Value={ 1L,5L,10L,21L,26L,53L,43L,69L,64L,90L,67L,138L,79L,131L,125L,165L,103L,212L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242644Inst : IEnumerable<long>
{
public static readonly long[] Value=A242644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242644.Bytes);
public long this[int i]=>Value[i];

public static A242644Inst Instance=new A242644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242645
{
public static readonly BigInteger[] Value={ 1L,111L,121111L,1331121111L,146411331121111L,BigInteger.Parse("161051146411331121111"),BigInteger.Parse("1771561161051146411331121111"),BigInteger.Parse("194871711771561161051146411331121111"),BigInteger.Parse("214358881194871711771561161051146411331121111"),BigInteger.Parse("2357947691214358881194871711771561161051146411331121111") };
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
public class A242645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242645Inst Instance=new A242645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242646
{
public static readonly BigInteger[] Value={ 1L,111L,111121L,1111211331L,111121133114641L,BigInteger.Parse("111121133114641161051"),BigInteger.Parse("1111211331146411610511771561"),BigInteger.Parse("111121133114641161051177156119487171"),BigInteger.Parse("111121133114641161051177156119487171214358881"),BigInteger.Parse("1111211331146411610511771561194871712143588812357947691"),BigInteger.Parse("111121133114641161051177156119487171214358881235794769125937424601") };
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
public class A242646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242646Inst Instance=new A242646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242647
{
public static readonly long[] Value={ 0L,1L,-1L,1L,-1L,1L,-1L,0L,1L,0L,0L,0L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,0L,0L,1L,0L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,0L,0L,0L,-1L,1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242647Inst : IEnumerable<long>
{
public static readonly long[] Value=A242647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242647.Bytes);
public long this[int i]=>Value[i];

public static A242647Inst Instance=new A242647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242648
{
public static readonly long[] Value={ 1L,3L,4L,13L,6L,24L,8L,46L,23L,36L,12L,116L,14L,48L,48L,161L,18L,156L,20L,174L,64L,72L,24L,484L,52L,84L,112L,232L,30L,360L,32L,526L,96L,108L,96L,841L,38L,120L,112L,726L,42L,480L,44L,348L,312L,144L,48L,1864L,93L,357L,144L,406L,54L,888L,144L,968L,160L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242648Inst : IEnumerable<long>
{
public static readonly long[] Value=A242648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242648.Bytes);
public long this[int i]=>Value[i];

public static A242648Inst Instance=new A242648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242649
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,8L,2L,14L,6L,8L,2L,26L,2L,8L,8L,33L,2L,26L,2L,26L,8L,8L,2L,72L,6L,8L,14L,26L,2L,40L,2L,70L,8L,8L,8L,95L,2L,8L,8L,72L,2L,40L,2L,26L,26L,8L,2L,184L,6L,26L,8L,26L,2L,72L,8L,72L,8L,8L,2L,148L,2L,8L,26L,149L,8L,40L,2L,26L,8L,40L,2L,282L,2L,8L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242649Inst : IEnumerable<long>
{
public static readonly long[] Value=A242649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242649.Bytes);
public long this[int i]=>Value[i];

public static A242649Inst Instance=new A242649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242650
{
public static readonly long[] Value={ 6L,12L,18L,24L,30L,36L,48L,54L,60L,66L,78L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242650Inst : IEnumerable<long>
{
public static readonly long[] Value=A242650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242650.Bytes);
public long this[int i]=>Value[i];

public static A242650Inst Instance=new A242650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242651
{
public static readonly BigInteger[] Value={ 0L,-1L,3L,-10L,40L,-190L,1050L,-6620L,46800L,-365300L,3103100L,-28269800L,271627200L,-2691559000L,26495469000L,-238131478000L,1394099824000L,15194495654000L,-936096296850000L,29697351895900000L,-819329864480400000L,BigInteger.Parse("21683886333440500000"),BigInteger.Parse("-570263312237604700000"),BigInteger.Parse("15145164178973569000000") };
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
public class A242651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242651Inst Instance=new A242651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242652
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,0L,-10L,90L,-730L,6160L,-55900L,549900L,-5864300L,67610400L,-839594600L,11186357000L,-159300557000L,2416003824000L,-38894192662000L,662595375078000L,-11911522255750000L,225382826562400000L,-4477959179352100000L,BigInteger.Parse("93217812901913700000"),BigInteger.Parse("-2029107997508660900000"),BigInteger.Parse("46099220630461596000000") };
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
public class A242652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242652Inst Instance=new A242652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242653
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,2L,0L,1L,2L,0L,3L,0L,1L,0L,6L,0L,4L,0L,1L,6L,0L,12L,0L,5L,0L,1L,0L,24L,0L,20L,0L,6L,0L,1L,24L,0L,60L,0L,30L,0L,7L,0L,1L,0L,120L,0L,120L,0L,42L,0L,8L,0L,1L,120L,0L,360L,0L,210L,0L,56L,0L,9L,0L,1L,0L,720L,0L,840L,0L,336L,0L,72L,0L,10L,0L,1L,720L,0L,2520L,0L,1680L,0L,504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242653Inst : IEnumerable<long>
{
public static readonly long[] Value=A242653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242653.Bytes);
public long this[int i]=>Value[i];

public static A242653Inst Instance=new A242653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242654
{
public static readonly long[] Value={ 1L,3L,4L,10L,11L,30L,31L,82L,83L,226L,227L,615L,616L,1673L,1674L,4549L,4550L,12366L,12367L,33616L,33617L,91379L,91380L,248396L,248397L,675213L,675214L,1835420L,1835421L,4989190L,4989191L,13562026L,13562027L,36865411L,36865412L,100210580L,100210581L,272400599L,272400600L,740461600L,740461601L,2012783314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242654Inst : IEnumerable<long>
{
public static readonly long[] Value=A242654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242654.Bytes);
public long this[int i]=>Value[i];

public static A242654Inst Instance=new A242654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242655
{
public static readonly long[] Value={ 0L,2L,3L,7L,8L,12L,15L,18L,27L,28L,32L,35L,42L,43L,47L,48L,50L,58L,60L,63L,72L,75L,82L,83L,87L,90L,98L,103L,107L,108L,112L,115L,122L,123L,128L,135L,138L,140L,147L,162L,163L,167L,168L,172L,175L,183L,188L,192L,200L,202L,203L,207L,210L,218L,223L,232L,235L,240L,242L,243L,252L,258L,263L,267L,282L,283L,287L,288L,290L,298L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242655Inst : IEnumerable<long>
{
public static readonly long[] Value=A242655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242655.Bytes);
public long this[int i]=>Value[i];

public static A242655Inst Instance=new A242655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242736
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,3L,3L,3L,4L,4L,5L,6L,6L,6L,7L,8L,8L,9L,9L,10L,10L,11L,12L,13L,13L,13L,14L,14L,15L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,25L,27L,28L,29L,29L,30L,30L,31L,32L,33L,33L,34L,34L,35L,36L,36L,37L,39L,39L,40L,40L,42L,43L,44L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242736Inst : IEnumerable<long>
{
public static readonly long[] Value=A242736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242736.Bytes);
public long this[int i]=>Value[i];

public static A242736Inst Instance=new A242736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242737
{
public static readonly long[] Value={ 1L,1L,2L,4L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242737Inst : IEnumerable<long>
{
public static readonly long[] Value=A242737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242737.Bytes);
public long this[int i]=>Value[i];

public static A242737Inst Instance=new A242737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242738
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,29L,41L,59L,89L,131L,197L,293L,439L,659L,991L,1481L,2221L,3329L,4993L,7487L,11239L,16843L,25253L,37879L,56821L,85223L,127837L,191773L,287629L,431441L,647161L,970747L,1456121L,2184179L,3276253L,4914373L,7371571L,11057357L,16586039L,24879017L,37318507L,55977767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242738Inst : IEnumerable<long>
{
public static readonly long[] Value=A242738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242738.Bytes);
public long this[int i]=>Value[i];

public static A242738Inst Instance=new A242738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242739
{
public static readonly long[] Value={ 4L,14L,74L,77L,111L,141L,177L,411L,417L,447L,471L,717L,771L,1111L,1114L,1141L,1147L,1174L,1177L,1411L,1417L,1441L,1477L,1711L,1714L,1717L,1774L,4117L,4141L,4171L,4174L,4411L,4414L,4417L,4471L,4474L,4711L,4714L,4717L,4741L,4747L,4771L,4777L,7111L,7114L,7117L,7141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242739Inst : IEnumerable<long>
{
public static readonly long[] Value=A242739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242739.Bytes);
public long this[int i]=>Value[i];

public static A242739Inst Instance=new A242739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242740
{
public static readonly long[] Value={ 1L,3L,9L,21L,27L,73L,99L,111L,271L,693L,707L,777L,819L,909L,999L,2151L,2629L,3441L,3813L,4551L,6987L,7227L,7373L,9999L,18981L,19019L,20007L,20979L,23199L,24453L,25641L,27027L,27417L,30303L,81819L,82113L,83883L,99999L,125523L,172013L,194841L,201917L,238139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242740Inst : IEnumerable<long>
{
public static readonly long[] Value=A242740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242740.Bytes);
public long this[int i]=>Value[i];

public static A242740Inst Instance=new A242740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242741
{
public static readonly long[] Value={ 29131L,119327070011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242741Inst : IEnumerable<long>
{
public static readonly long[] Value=A242741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242741.Bytes);
public long this[int i]=>Value[i];

public static A242741Inst Instance=new A242741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242742
{
public static readonly long[] Value={ 5L,7L,9L,8L,11L,13L,15L,4L,17L,19L,21L,8L,23L,25L,7L,27L,26L,9L,31L,33L,10L,35L,6L,37L,39L,14L,41L,43L,45L,8L,47L,49L,18L,51L,16L,9L,55L,21L,57L,20L,59L,61L,63L,8L,65L,8L,25L,69L,22L,11L,73L,75L,26L,45L,34L,79L,81L,80L,83L,85L,4L,87L,28L,89L,91L,3L,93L,32L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242742Inst : IEnumerable<long>
{
public static readonly long[] Value=A242742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242742.Bytes);
public long this[int i]=>Value[i];

public static A242742Inst Instance=new A242742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242743
{
public static readonly long[] Value={ 9L,2L,9L,6L,9L,5L,3L,9L,8L,3L,4L,1L,6L,1L,0L,2L,1L,4L,9L,8L,5L,3L,8L,4L,9L,7L,3L,6L,6L,5L,8L,7L,8L,1L,2L,1L,7L,6L,5L,8L,8L,2L,3L,7L,5L,1L,5L,1L,8L,0L,2L,1L,6L,7L,5L,8L,2L,3L,4L,3L,1L,4L,2L,9L,7L,0L,1L,9L,2L,0L,8L,4L,7L,4L,5L,7L,2L,5L,0L,8L,1L,2L,5L,6L,1L,8L,5L,3L,1L,2L,1L,0L,4L,4L,7L,7L,4L,6L,1L,5L,8L,8L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242743Inst : IEnumerable<long>
{
public static readonly long[] Value=A242743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242743.Bytes);
public long this[int i]=>Value[i];

public static A242743Inst Instance=new A242743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242744
{
public static readonly long[] Value={ 3L,4L,3L,4L,3L,6L,4L,4L,5L,10L,6L,6L,4L,10L,8L,16L,9L,18L,6L,10L,11L,6L,4L,12L,13L,6L,5L,12L,15L,30L,9L,16L,17L,12L,18L,18L,12L,26L,6L,40L,21L,42L,22L,22L,12L,16L,6L,42L,16L,12L,26L,52L,27L,44L,18L,6L,12L,58L,30L,30L,31L,12L,12L,10L,33L,66L,22L,16L,35L,70L,36L,36L,37L,18L,38L,66L,9L,78L,12L,12L,41L,82L,16L,42L,28L,58L,44L,30L,12L,18L,30L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242744Inst : IEnumerable<long>
{
public static readonly long[] Value=A242744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242744.Bytes);
public long this[int i]=>Value[i];

public static A242744Inst Instance=new A242744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242745
{
public static readonly long[] Value={ 2L,1L,2L,2L,3L,3L,4L,4L,3L,4L,5L,4L,5L,6L,5L,4L,5L,6L,7L,5L,6L,6L,7L,6L,5L,6L,7L,4L,5L,6L,7L,8L,9L,10L,5L,6L,7L,8L,9L,8L,9L,6L,7L,8L,5L,6L,7L,8L,7L,8L,6L,7L,8L,6L,7L,8L,9L,10L,11L,10L,11L,12L,7L,8L,5L,6L,7L,8L,9L,7L,8L,8L,9L,10L,11L,12L,7L,6L,7L,8L,9L,10L,11L,12L,10L,6L,7L,8L,9L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242745Inst : IEnumerable<long>
{
public static readonly long[] Value=A242745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242745.Bytes);
public long this[int i]=>Value[i];

public static A242745Inst Instance=new A242745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242746
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,1L,5L,3L,6L,1L,7L,1L,7L,6L,5L,1L,7L,1L,5L,4L,7L,1L,7L,6L,4L,9L,8L,1L,7L,1L,9L,8L,7L,6L,5L,1L,8L,7L,6L,1L,7L,1L,11L,10L,9L,1L,9L,8L,7L,10L,9L,1L,7L,6L,5L,7L,13L,1L,11L,1L,9L,8L,7L,8L,7L,1L,13L,12L,11L,1L,9L,1L,7L,6L,8L,8L,7L,1L,11L,10L,9L,1L,7L,6L,11L,10L,9L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242746Inst : IEnumerable<long>
{
public static readonly long[] Value=A242746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242746.Bytes);
public long this[int i]=>Value[i];

public static A242746Inst Instance=new A242746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242747
{
public static readonly BigInteger[] Value={ 2L,8L,25L,2874L,12337L,125124L,40312L,362871L,119710813081L,226288998L,479001588L,379491816246L,2857509238543899L,284854629849752642L,20922789887984L,BigInteger.Parse("158339857954376933898893600"),BigInteger.Parse("7802547932734125256832521"),BigInteger.Parse("1785042244078013092809522"),2432902008176639980L };
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
public class A242747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242747Inst Instance=new A242747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242748
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,3L,3L,3L,1L,3L,3L,2L,2L,3L,3L,2L,1L,2L,3L,3L,2L,3L,3L,3L,3L,1L,2L,3L,3L,3L,2L,1L,4L,2L,3L,3L,3L,3L,2L,5L,3L,4L,2L,4L,6L,6L,1L,5L,4L,6L,7L,4L,6L,4L,6L,3L,6L,3L,7L,5L,5L,6L,7L,4L,6L,8L,5L,6L,4L,6L,4L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242748Inst : IEnumerable<long>
{
public static readonly long[] Value=A242748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242748.Bytes);
public long this[int i]=>Value[i];

public static A242748Inst Instance=new A242748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242749
{
public static readonly BigInteger[] Value={ 1L,4L,11L,60L,611L,8632L,151538L,3132140L,73883667L,1949844168L,56785116742L,1806695366616L,62314198956510L,2315470815127792L,92214156916779444L,3918743752606940812L,BigInteger.Parse("177018691811732542595"),BigInteger.Parse("8471087431826716955880"),BigInteger.Parse("428141645771934036086942"),BigInteger.Parse("22791557465710675500959688") };
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
public class A242749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242749Inst Instance=new A242749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242750
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,10L,11L,13L,15L,18L,24L,26L,28L,33L,39L,41L,44L,45L,48L,50L,54L,55L,56L,58L,62L,65L,68L,69L,71L,75L,79L,83L,85L,93L,95L,107L,108L,109L,110L,117L,118L,119L,120L,123L,126L,129L,130L,131L,133L,139L,142L,143L,145L,148L,157L,158L,160L,163L,164L,166L,170L,172L,173L,174L,179L,182L,186L,190L,191L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242750Inst : IEnumerable<long>
{
public static readonly long[] Value=A242750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242750.Bytes);
public long this[int i]=>Value[i];

public static A242750Inst Instance=new A242750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242751
{
public static readonly long[] Value={ 4L,6L,9L,46L,49L,69L,86L,94L,446L,466L,469L,489L,649L,669L,689L,694L,698L,699L,849L,866L,869L,886L,889L,898L,899L,949L,989L,998L,4006L,4009L,4069L,4406L,4449L,4469L,4486L,4489L,4499L,4609L,4666L,4694L,4699L,4846L,4849L,4894L,4946L,4989L,6009L,6046L,6049L,6098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242751Inst : IEnumerable<long>
{
public static readonly long[] Value=A242751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242751.Bytes);
public long this[int i]=>Value[i];

public static A242751Inst Instance=new A242751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242832
{
public static readonly BigInteger[] Value={ 6L,14L,15L,62L,254L,511L,2047L,16382L,262142L,1048574L,8388607L,4294967294L,137438953471L,562949953421311L,576460752303423487L,4611686018427387902L,BigInteger.Parse("147573952589676412927"),BigInteger.Parse("9671406556917033397649407"),BigInteger.Parse("1237940039285380274899124222"),BigInteger.Parse("158456325028528675187087900671") };
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
public class A242832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242832Inst Instance=new A242832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242833
{
public static readonly BigInteger[] Value={ 5L,52631L,BigInteger.Parse("5263157894736842105263157"),BigInteger.Parse("52631578947368421052631578947368421052631578947368421052631") };
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
public class A242833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242833Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242833.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242833.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242833Inst Instance=new A242833Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242834
{
public static readonly long[] Value={ 0L,0L,6L,4L,0L,3L,0L,56L,0L,10L,0L,4L,0L,14L,0L,0L,0L,306L,0L,380L,0L,22L,0L,552L,0L,26L,0L,0L,0L,6L,0L,992L,0L,34L,0L,0L,0L,1722L,0L,1892L,0L,46L,0L,2256L,0L,0L,0L,0L,0L,2862L,0L,8L,0L,58L,0L,3540L,0L,62L,0L,0L,0L,0L,0L,4556L,0L,0L,0L,5112L,0L,74L,0L,0L,0L,0L,0L,6320L,0L,82L,0L,6972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242834Inst : IEnumerable<long>
{
public static readonly long[] Value=A242834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242834.Bytes);
public long this[int i]=>Value[i];

public static A242834Inst Instance=new A242834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242835
{
public static readonly BigInteger[] Value={ 2L,223L,BigInteger.Parse("22360679774997896964091") };
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
public class A242835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242835.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242835Inst Instance=new A242835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242836
{
public static readonly long[] Value={ 120L,0L,480L,0L,1800L,0L,5580L,0L,16224L,0L,43884L,0L,111828L,5040L,295752L,90720L,918144L,836640L,3717552L,5937840L,18033888L,36198000L,92552004L,199157040L,468066444L,1018608720L,2283162630L,4928557200L,10715965290L,22825049040L,48562957800L,102021279960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242836Inst : IEnumerable<long>
{
public static readonly long[] Value=A242836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242836.Bytes);
public long this[int i]=>Value[i];

public static A242836Inst Instance=new A242836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242837
{
public static readonly long[] Value={ 24L,0L,84L,0L,288L,0L,822L,0L,2226L,0L,5304L,720L,15034L,10680L,55624L,84360L,265200L,527640L,1342608L,2886960L,6673176L,14433240L,31725930L,67718568L,144265370L,302771208L,631156708L,1303769496L,2673673704L,5447789784L,11028089996L,22211684328L,44491303391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242837Inst : IEnumerable<long>
{
public static readonly long[] Value=A242837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242837.Bytes);
public long this[int i]=>Value[i];

public static A242837Inst Instance=new A242837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242838
{
public static readonly long[] Value={ 6L,0L,18L,0L,56L,0L,146L,0L,312L,120L,1037L,1440L,4658L,9624L,23906L,52524L,117032L,255732L,542186L,1150920L,2370395L,4902948L,9912558L,20084700L,40045005L,79902108L,157676536L,310969848L,608833717L,1190681692L,2317419418L,4505327884L,8732462296L,16911676140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242838Inst : IEnumerable<long>
{
public static readonly long[] Value=A242838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242838.Bytes);
public long this[int i]=>Value[i];

public static A242838Inst Instance=new A242838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242839
{
public static readonly long[] Value={ 2L,0L,5L,0L,14L,0L,22L,24L,104L,228L,518L,1272L,2621L,5986L,11836L,25396L,49077L,100200L,192678L,381724L,730806L,1424956L,2727666L,5271456L,10111091L,19503830L,37551786L,72600610L,140531739L,273027876L,531953163L,1040051736L,2040532257L,4017104634L,7935847124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242839Inst : IEnumerable<long>
{
public static readonly long[] Value=A242839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242839.Bytes);
public long this[int i]=>Value[i];

public static A242839Inst Instance=new A242839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242840
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,6L,15L,44L,74L,202L,351L,766L,1301L,2626L,4677L,8993L,16466L,31671L,60266L,116751L,229180L,452667L,905627L,1815394L,3673666L,7429123L,15109955L,30696510L,62512866L,127140993L,258745131L,525845884L,1068309682L,2167462318L,4393853912L,8896007640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242840Inst : IEnumerable<long>
{
public static readonly long[] Value=A242840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242840.Bytes);
public long this[int i]=>Value[i];

public static A242840Inst Instance=new A242840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242841
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,8L,14L,45L,99L,230L,451L,953L,1798L,3503L,6683L,12693L,24209L,46155L,89200L,172767L,338255L,664453L,1317945L,2620363L,5243700L,10509348L,21141700L,42578221L,85897588L,173380086L,350184780L,707320136L,1428681390L,2885015407L,5823971576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242841Inst : IEnumerable<long>
{
public static readonly long[] Value=A242841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242841.Bytes);
public long this[int i]=>Value[i];

public static A242841Inst Instance=new A242841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242842
{
public static readonly long[] Value={ 2L,3L,6L,11L,20L,25L,41L,85L,148L,355L,751L,1701L,3756L,8255L,17513L,37038L,76349L,156618L,317591L,639142L,1279302L,2546711L,5057675L,10010975L,19788607L,39058684L,77055159L,151930328L,299600229L,590849561L,1165782514L,2301229945L,4545782370L,8985884632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242842Inst : IEnumerable<long>
{
public static readonly long[] Value=A242842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242842.Bytes);
public long this[int i]=>Value[i];

public static A242842Inst Instance=new A242842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242843
{
public static readonly long[] Value={ 6L,12L,26L,54L,104L,194L,357L,590L,1012L,1814L,3137L,5990L,11400L,22864L,46715L,97788L,206639L,438654L,930092L,1969748L,4147412L,8696479L,18137872L,37638970L,77738200L,159832004L,327315948L,667736364L,1357690562L,2751972885L,5562836882L,11216402410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242843Inst : IEnumerable<long>
{
public static readonly long[] Value=A242843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242843.Bytes);
public long this[int i]=>Value[i];

public static A242843Inst Instance=new A242843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242844
{
public static readonly long[] Value={ 24L,60L,144L,330L,684L,1374L,2688L,5106L,9532L,17208L,30856L,55296L,97812L,175926L,316928L,581352L,1083674L,2064346L,4012614L,7957492L,16061208L,32880201L,68032764L,141844516L,297086796L,623794222L,1310685218L,2752470170L,5772036942L,12079693049L,25220161732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242844Inst : IEnumerable<long>
{
public static readonly long[] Value=A242844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242844.Bytes);
public long this[int i]=>Value[i];

public static A242844Inst Instance=new A242844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242845
{
public static readonly long[] Value={ 120L,360L,960L,2400L,5364L,11520L,23904L,48000L,94308L,181824L,344832L,643104L,1186224L,2169048L,3928932L,7096092L,12764310L,22970448L,41423646L,75112044L,137278356L,253642356L,474883278L,902578368L,1743300754L,3421941228L,6820887514L,13784976732L,28189089684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242845Inst : IEnumerable<long>
{
public static readonly long[] Value=A242845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242845.Bytes);
public long this[int i]=>Value[i];

public static A242845Inst Instance=new A242845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242846
{
public static readonly BigInteger[] Value={ 131L,313L,BigInteger.Parse("1313131313131313131313131"),BigInteger.Parse("313131313131313131313131313131313131313131313131313") };
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
public class A242846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242846Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242846.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242846.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242846Inst Instance=new A242846Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242847
{
public static readonly long[] Value={ 19L,35L,38L,41L,45L,50L,53L,56L,57L,58L,59L,63L,76L,77L,78L,79L,80L,81L,83L,84L,85L,92L,93L,95L,96L,108L,109L,112L,113L,116L,117L,124L,125L,126L,142L,143L,146L,154L,157L,173L,184L,185L,186L,193L,194L,195L,196L,197L,203L,215L,217L,224L,227L,232L,233L,237L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242847Inst : IEnumerable<long>
{
public static readonly long[] Value=A242847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242847.Bytes);
public long this[int i]=>Value[i];

public static A242847Inst Instance=new A242847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242880
{
public static readonly BigInteger[] Value={ 1729L,4033L,8321L,12801L,65281L,130561L,348161L,3225601L,8355841L,8384513L,16773121L,40280065L,104988673L,2147418113L,4294901761L,4294967297L,53282340865L,68719214593L,137439477761L,1099510579201L,1911029760001L,2199021158401L,8796097216513L,281474959933441L,9007199388958721L,576460753377165313L,2305843011361177601L,BigInteger.Parse("18446744073709551617") };
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
public class A242880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A242880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A242880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A242880Inst Instance=new A242880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242881
{
public static readonly long[] Value={ 3L,4L,10L,12L,14L,15L,23L,32L,33L,37L,39L,50L,58L,60L,64L,66L,82L,86L,90L,91L,93L,111L,112L,114L,128L,139L,143L,155L,157L,158L,162L,167L,171L,179L,190L,197L,198L,199L,207L,223L,226L,231L,241L,248L,255L,262L,270L,280L,282L,286L,293L,306L,313L,317L,318L,325L,327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242881Inst : IEnumerable<long>
{
public static readonly long[] Value=A242881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242881.Bytes);
public long this[int i]=>Value[i];

public static A242881Inst Instance=new A242881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242882
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,12L,16L,40L,60L,82L,216L,538L,788L,2034L,3740L,6320L,13336L,27498L,42936L,93534L,173520L,351374L,734650L,1592952L,3033194L,6310640L,12506972L,25296110L,49709476L,101546612L,195037028L,391548336L,764947954L,1527004522L,2953533640L,5946359758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242882Inst : IEnumerable<long>
{
public static readonly long[] Value=A242882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242882.Bytes);
public long this[int i]=>Value[i];

public static A242882Inst Instance=new A242882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242883
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,15L,18L,21L,24L,27L,33L,39L,51L,58L,60L,63L,69L,75L,81L,87L,99L,105L,111L,123L,135L,153L,165L,171L,183L,186L,207L,213L,219L,231L,243L,249L,255L,267L,279L,309L,315L,351L,363L,375L,387L,393L,399L,423L,435L,453L,465L,471L,495L,501L,531L,543L,579L,603L,615L,627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242883Inst : IEnumerable<long>
{
public static readonly long[] Value=A242883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242883.Bytes);
public long this[int i]=>Value[i];

public static A242883Inst Instance=new A242883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242884
{
public static readonly long[] Value={ 2L,1L,1L,3L,3L,7L,3L,0L,0L,11L,5L,0L,4L,0L,0L,7L,16L,0L,1L,0L,281L,0L,19L,0L,0L,0L,7L,0L,35L,0L,1L,0L,113L,0L,29L,91L,19L,0L,19L,0L,23L,0L,0L,0L,0L,37L,65L,0L,0L,0L,0L,0L,153L,0L,199L,0L,0L,115L,0L,0L,0L,0L,319L,0L,47L,0L,0L,0L,13L,0L,47L,0L,0L,0L,539L,0L,0L,0L,0L,0L,13L,0L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242884Inst : IEnumerable<long>
{
public static readonly long[] Value=A242884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242884.Bytes);
public long this[int i]=>Value[i];

public static A242884Inst Instance=new A242884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242885
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,3L,1L,2L,1L,5L,1L,4L,1L,14L,1L,16L,1L,3L,1L,5L,1L,10L,1L,3L,1L,6L,1L,4L,1L,4L,1L,18L,1L,17L,1L,9L,1L,26L,1L,10L,1L,6L,1L,20L,1L,7L,1L,6L,1L,8L,1L,12L,1L,10L,1L,8L,1L,3L,1L,3L,1L,6L,1L,29L,1L,6L,1L,6L,1L,5L,1L,6L,1L,17L,1L,19L,1L,12L,1L,20L,1L,5L,1L,12L,1L,42L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242885Inst : IEnumerable<long>
{
public static readonly long[] Value=A242885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242885.Bytes);
public long this[int i]=>Value[i];

public static A242885Inst Instance=new A242885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A242886
{
public static readonly long[] Value={ 3L,3L,419L,132749L,514664471L,1164166301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A242886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A242886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A242886Inst : IEnumerable<long>
{
public static readonly long[] Value=A242886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A242886.Bytes);
public long this[int i]=>Value[i];

public static A242886Inst Instance=new A242886Inst();

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